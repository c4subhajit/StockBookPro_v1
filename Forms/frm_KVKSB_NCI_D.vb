Imports System.Data
Imports System.Data.SqlClient

Public Class frm_KVKSB_NCI_D
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry
    Dim valid As New class_validation_functions
    Dim deleteStatus As String

    Private Sub frm_KVKSB_NCI_D_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call resetFields()
    End Sub

    Private Sub cmb_ci_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ci.SelectedIndexChanged
        If Not cmb_ci.SelectedItem = "" Then
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "SELECT * FROM STOCKBOOK WHERE ci='" & cmb_ci.SelectedItem & "'"
                dr = con_cls.cmd.ExecuteReader()
                If dr.HasRows Then
                    deleteStatus = "BLOCKED"
                Else
                    deleteStatus = "OK"
                End If
                dr.Close()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Critical Input Delete Status Check Error")
            End Try
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "SELECT * FROM CRITICALINPUT WHERE criticalInput='" & cmb_ci.SelectedItem & "'"
                dr = con_cls.cmd.ExecuteReader()
                If dr.HasRows Then
                    dr.Read()
                    txt_unit.Text = dr.Item("ciUnit")
                End If
                dr.Close()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Critical Input Unit Check Error")
            End Try
        End If
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If deleteStatus = "OK" Then
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "DELETE FROM CRITICALINPUT WHERE criticalInput='" & cmb_ci.SelectedItem & "'"
                con_cls.cmd.ExecuteNonQuery()
                trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "Critical Input Deletion", "Successful")
                MsgBox("Critical Input deleted successfully", MsgBoxStyle.OkOnly, "Critical Input Delete Information")
                deleteStatus = "BLOCKED"
                Call resetFields()
            Catch ex As Exception
                trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "Critical Input Deletion", "Unsuccessful")
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Critical Input Delete Information")
            End Try
        Else
            MsgBox("CRITICAL INPUT CANNOT BE DELETED. The selected critical input has stockbook entries.", MsgBoxStyle.OkOnly, "Critical Input Delete Information")
            Call resetFields()
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
        cmb_ci.Items.Clear()
        deleteStatus = "BLOCKED"
        Call loadCriticalInput()
    End Sub

    Public Sub loadCriticalInput()
        cmb_ci.Items.Clear()
        ' LOADING CRITICAL ITEM NAMES FROM DATABASE
        '======================================================================================================================================
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
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error in Critical input loading")
        End Try
        con_cls.disconnect()
        '======================================================================================================================================
    End Sub

End Class