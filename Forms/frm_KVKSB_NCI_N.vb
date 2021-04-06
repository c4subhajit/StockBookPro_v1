Imports System.Data
Imports System.Data.SqlClient

Public Class frm_KVKSB_NCI_N
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry
    Dim valid As New class_validation_functions

    Private Sub frm_FD_NCI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
    End Sub

    Private Sub cmd_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_create.Click
        If txt_nci.Text = "" Then
            MsgBox("Please enter new critical input name")
        ElseIf txt_unit.Text = "" Then
            MsgBox("Please enter unit of new critical input")
        Else
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "INSERT INTO CRITICALINPUT (criticalInput,ciUnit,osb,csb) VALUES ('" & txt_nci.Text & "','" & _
                txt_unit.Text & "',0.0000,0.0000)"
                con_cls.cmd.ExecuteNonQuery()
                trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "New Critical Input", "New Critical Input " & txt_nci.Text & " Created")
                MsgBox("New critical input created successfully.", MsgBoxStyle.OkOnly, "Critical input creation information.")
                con_cls.disconnect()
                Call resetFields()
            Catch ex As Exception
                trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "New Critical Input", "Unsuccessful")
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
            End Try
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
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
        txt_nci.Clear()
        txt_nci.Focus()
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_unit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_unit.Validating
        Try
            valid.ciUnit_validate(txt_unit.Text, txt_unit)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_nci_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nci.Validating
        Try
            valid.criticalInput_validate(txt_nci.Text, txt_nci)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class