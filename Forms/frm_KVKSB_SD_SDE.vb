Imports System.Data
Imports System.Data.SqlClient

Public Class frm_KVKSB_SD_SDE
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry
    Dim valid As New class_validation_functions
    Public empty_field_status As String
    Public CIselectStatus, editClickStatus As String
    Public t_id As Int64

    Private Sub frm_KVKSB_SD_SDE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call resetFields()
        Call loadCINames()
    End Sub

    Private Sub cmb_ci_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ci.SelectedIndexChanged
        Call resetFields()
        Try
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT * FROM CRITICALINPUT WHERE criticalInput='" & cmb_ci.SelectedItem & "'"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txt_unit.Text = dr.Item("ciUnit")
                txt_osb.Text = dr.Item("osb")
                txt_csb.Text = dr.Item("csb")
                dr.Close()
            End If
            dr.Close()
            con_cls.cmd.CommandText = "SELECT MAX(tidsb) FROM STOCKBOOK WHERE ci='" & cmb_ci.SelectedItem & "'"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    t_id = dr.Item(0)
                End If
                dr.Close()
            End If
            dr.Close()
            con_cls.cmd.CommandText = "SELECT * FROM STOCKBOOK WHERE (ci='" & cmb_ci.SelectedItem & "' AND tidsb=" & t_id & ")"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txt_date.Text = dr.Item("date")
                txt_SRD_MD.Text = dr.Item("srmd")
                txt_SRD_QTY.Text = dr.Item("srqty")
                txt_SID_IT.Text = dr.Item("sddetail")
                txt_SID_REM.Text = dr.Item("sdrem")
                txt_SID_QTY.Text = dr.Item("sdqty")
                txt_rui.Text = dr.Item("rui")
                dr.Close()
            End If
            dr.Close()
            con_cls.disconnect()
            CIselectStatus = "TRUE"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Critical input details update error")
        End Try
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        If CIselectStatus = "TRUE" Then
            Call enableEdit()
            editClickStatus = "TRUE"
        End If
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If editClickStatus = "TRUE" Then
            Call check_empty_fields()
            Call updateValues()
            If empty_field_status = "OK" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "UPDATE STOCKBOOK SET srmd='" & txt_SRD_MD.Text & "',srqty=" & txt_SRD_QTY.Text & _
                    ",sdqty=" & txt_SID_QTY.Text & ",sddetail='" & txt_SID_IT.Text & "',sdrem='" & txt_SID_REM.Text & "',osb=" & _
                    txt_osb.Text & ",csb=" & txt_csb.Text & ",rui='" & frm_home.domain & " (" & frm_home.username & _
                    ")' WHERE (ci='" & cmb_ci.SelectedItem & "' AND tidsb=" & t_id & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.cmd.CommandText = "UPDATE CRITICALINPUT SET osb=" & txt_osb.Text & ",csb=" & txt_csb.Text & " WHERE criticalInput='" & cmb_ci.SelectedItem & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    trans_querry.update_trans_stockbook(frm_home.domain, frm_home.username, "Stock Detail Edit", "Successful (Unique ID:" & t_id & ")")
                    MsgBox("Stockbook record edited successfully.", MsgBoxStyle.OkOnly, "Stockbook record information.")
                    Call resetFields()
                    Call loadCINames()
                Catch ex As Exception
                    trans_querry.update_trans_stockbook(frm_home.domain, frm_home.username, "Stock Detail Edit", "Unsuccessful")
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Stockbook record information.")
                End Try
            End If
        End If
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================

    Public Sub resetFields()
        t_id = 0
        txt_unit.Clear()
        txt_osb.Clear()
        txt_date.Clear()
        txt_SRD_MD.Clear()
        txt_SRD_QTY.Clear()
        txt_csb.Clear()
        txt_SID_IT.Clear()
        txt_SID_REM.Clear()
        txt_SID_QTY.Clear()
        txt_rui.Clear()
        Call disableEdit()
        editClickStatus = "FALSE"
        CIselectStatus = "FALSE"
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

    Public Sub enableEdit()
        txt_SRD_MD.ReadOnly = False
        txt_SRD_QTY.ReadOnly = False
        txt_SID_IT.ReadOnly = False
        txt_SID_REM.ReadOnly = False
        txt_SID_QTY.ReadOnly = False
    End Sub

    Public Sub disableEdit()
        txt_SRD_MD.ReadOnly = True
        txt_SRD_QTY.ReadOnly = True
        txt_SID_IT.ReadOnly = True
        txt_SID_REM.ReadOnly = True
        txt_SID_QTY.ReadOnly = True
    End Sub

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_SRD_MD.Text = "" Then
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