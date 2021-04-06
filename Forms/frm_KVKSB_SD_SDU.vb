Imports System.Data
Imports System.Data.SqlClient

Public Class frm_KVKSB_SD_SDU
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry
    Dim valid As New class_validation_functions
    Public empty_field_status As String
    Public saveClickStatus As String
    Dim t_id As Int64

    Private Sub frm_KVKSB_SD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
        Call loadCINames()
    End Sub

    Private Sub cmb_ci_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ci.SelectedIndexChanged
        Try
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT * FROM CRITICALINPUT WHERE criticalInput='" & cmb_ci.SelectedItem & "'"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txt_unit.Text = dr.Item("ciUnit")
                txt_osb.Text = dr.Item("csb")
                dr.Close()
            End If
            con_cls.disconnect()
            saveClickStatus = "FALSE"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Critical input details update error")
        End Try
    End Sub

    Private Sub DTP_SD_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_SD_date.ValueChanged
        txt_date.Text = DTP_SD_date.Value
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        Call check_empty_fields()
        Call updateValues()
        If empty_field_status = "OK" Then
            Try
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "SELECT MAX(tidsb) FROM STOCKBOOK"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        If Not dr.IsDBNull(0) Then
                            t_id = CInt(dr.Item(0))
                            t_id += 1
                        Else
                            t_id = 1
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Transaction ID retrieve Sqlquerry block error")
                End Try
                dr.Close()
                con_cls.cmd.CommandText = "INSERT INTO STOCKBOOK (tidsb,ci,unit,date,srmd,srqty,sdqty,sddetail,sdrem,osb,csb,rui) VALUES (" & t_id & ",'" & _
                cmb_ci.SelectedItem & "','" & txt_unit.Text & "','" & CDate(txt_date.Text) & "','" & txt_SRD_MD.Text & "'," & txt_SRD_QTY.Text & _
                "," & txt_SID_QTY.Text & ",'" & txt_SID_IT.Text & "','" & txt_SID_REM.Text & "'," & txt_osb.Text & "," & txt_csb.Text & ",'" & _
                frm_home.domain & " (" & frm_home.username & ")')"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.cmd.CommandText = "UPDATE CRITICALINPUT SET osb=" & txt_osb.Text & ",csb=" & txt_csb.Text & " WHERE criticalInput='" & cmb_ci.SelectedItem & "'"
                con_cls.cmd.ExecuteNonQuery()
                trans_querry.update_trans_stockbook(frm_home.domain, frm_home.username, "Stock Detail Update", "Successful (Unique ID:" & t_id & ")")
                MsgBox("Stockbook record updated successfully.", MsgBoxStyle.OkOnly, "Stockbook record information.")
                saveClickStatus = "TRUE"
                Call resetFields()
                Call loadCINames()
            Catch ex As Exception
                trans_querry.update_trans_stockbook(frm_home.domain, frm_home.username, "Stock Detail Update", "Unsuccessful")
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Stockbook record information.")
            End Try
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        If Not saveClickStatus = "TRUE" Then
            Call resetFields()
            Me.Close()
        Else
            If MessageBox.Show("Current unsaved data will be lost, continue?", "Sure to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call resetFields()
                Me.Close()
            End If
        End If
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================

    Public Sub resetFields()
        cmb_ci.SelectedIndex = 0
        txt_unit.Clear()
        txt_osb.Clear()
        txt_date.Clear()
        txt_SRD_MD.Clear()
        txt_SRD_QTY.Clear()
        txt_csb.Clear()
        txt_SID_IT.Clear()
        txt_SID_REM.Clear()
        txt_SID_QTY.Clear()
        saveClickStatus = "FALSE"
    End Sub

    Public Sub loadCINames()
        cmb_ci.Items.Clear()
        ' LOADING CRITICAL ITEM NAMES FROM DATABASE
        '=============================================================================================
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "SELECT criticalInput FROM CRITICALINPUT"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                Try
                    While dr.Read
                        cmb_ci.Items.Add(dr.Item("criticalInput"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read error")
                End Try
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error in Critical Input name loading")
        End Try
        con_cls.disconnect()
        '=============================================================================================
    End Sub

    Public Sub updateValues()
        If Not txt_SRD_QTY.Text = "" Then
            txt_csb.Text = CDbl(txt_osb.Text) + CDbl(txt_SRD_QTY.Text)
        End If
        If Not txt_SID_QTY.Text = "" Then
            txt_csb.Text = CDbl(txt_osb.Text) - CDbl(txt_SID_QTY.Text)
        End If
        If Not (txt_SRD_QTY.Text = "" Or txt_SID_QTY.Text = "") Then
            txt_csb.Text = CDbl(txt_osb.Text) + CDbl(txt_SRD_QTY.Text) - CDbl(txt_SID_QTY.Text)
        End If
    End Sub

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_date.Text = "" Then
            MsgBox("Please select date to continue.", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            DTP_SD_date.Focus()
            Exit Sub
        ElseIf txt_SRD_MD.Text = "" Then
            txt_SRD_MD.Text = "-- NIL --"
            Call check_empty_fields()
        ElseIf txt_SRD_QTY.Text = "" Then
            txt_SRD_QTY.Text = "0.0000"
            Call check_empty_fields()
        ElseIf txt_SID_IT.Text = "" Then
            txt_SID_IT.Text = "-- NIL --"
            Call check_empty_fields()
        ElseIf txt_SID_REM.Text = "" Then
            txt_SID_REM.Text = "-- NIL --"
            Call check_empty_fields()
        ElseIf txt_SID_QTY.Text = "" Then
            txt_SID_QTY.Text = "0.0000"
            Call check_empty_fields()
        Else
            empty_field_status = "OK"
        End If
    End Sub


    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_date.Validating
        Try
            valid.stockDetailsDate_validate(txt_date.Text, cmb_ci.SelectedItem, DTP_SD_date)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub DTP_SD_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DTP_SD_date.Validating
        txt_date.Focus()
    End Sub

    Private Sub txt_SID_IT_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_SID_IT.Validating
        Try
            valid.stockDetails_validate(txt_SID_IT.Text, txt_SID_IT)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_SID_QTY_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_SID_QTY.Validating
        Try
            valid.quantity_validate(txt_SID_QTY.Text, txt_SID_QTY)
            If valid.err_code = 0 Then
                Call updateValues()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_SID_REM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_SID_REM.Validating
        Try
            valid.stockDetails_validate(txt_SID_REM.Text, txt_SID_REM)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_SRD_MD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_SRD_MD.Validating
        Try
            valid.stockDetails_validate(txt_SRD_MD.Text, txt_SRD_MD)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_SRD_QTY_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_SRD_QTY.Validating
        Try
            valid.quantity_validate(txt_SRD_QTY.Text, txt_SRD_QTY)
            If valid.err_code = 0 Then
                Call updateValues()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class