Imports System.Data
Imports System.Data.SqlClient

Public Class frm_KVKSB_SD_SDD
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry
    Public empty_field_status As String
    Public t_id As Int64

    Private Sub frm_KVKSB_SD_SDD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Critical input details update error")
        End Try
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        Call check_empty_fields()
        If empty_field_status = "OK" Then
            If MessageBox.Show("Confirm Stock Record Deletion.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM STOCKBOOK WHERE (ci='" & cmb_ci.SelectedItem & "' AND tidsb=" & t_id & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    trans_querry.update_trans_stockbook(frm_home.domain, frm_home.username, "Stock Detail Delete", "Successful (Unique ID:" & t_id & " and CI:" & cmb_ci.SelectedItem & ")")
                    MsgBox("Stockbook record deleted successfully", MsgBoxStyle.OkOnly, "Stockbook record information.")
                    Call resetFields()
                    Call loadCINames()
                Catch ex As Exception
                    trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "Stock Detail Delete", "Unsuccessful")
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Stockbook record information.")
                End Try
            End If
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Call resetFields()
        Me.Close()
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================

    Public Sub resetFields()
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

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_rui.Text = "" Then
            empty_field_status = "NOT OK"
            Exit Sub
        ElseIf txt_osb.Text = "" Then
            empty_field_status = "NOT OK"
            Exit Sub
        ElseIf txt_csb.Text = "" Then
            empty_field_status = "NOT OK"
            Exit Sub
        ElseIf txt_unit.Text = "" Then
            empty_field_status = "NOT OK"
            Exit Sub
        ElseIf txt_date.Text = "" Then
            empty_field_status = "NOT OK"
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

End Class