Imports System.Data
Imports System.Data.SqlClient

Public Class frm_login_deluser
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry

    Private Sub frm_login_deluser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call loadDomains()
    End Sub

    Private Sub cmb_domain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_domain.SelectedIndexChanged
        loadUserID()
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If (Not cmb_domain.SelectedItem = "") Or (Not cmb_username.SelectedItem = "") Then
            If MessageBox.Show("Confirm User Account Deletion.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM USERACCOUNTS WHERE userid='" & cmb_username.SelectedItem & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "User ID Deletion", "Successful")
                    MsgBox("User ID deleted successfully", MsgBoxStyle.OkOnly, "User ID Delete Information")
                    loadDomains()
                Catch ex As Exception
                    trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "User ID Deletion", "Unsuccessful")
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "User ID Delete Information")
                End Try
            End If
        Else
            MsgBox("Select User ID first.", MsgBoxStyle.OkOnly, "User ID Delete Information")
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    '====================================================================
    '                  USER DEFINED FUNCTIONS
    '====================================================================
    Public Sub loadDomains()
        cmb_domain.Items.Clear()
        cmb_username.Items.Clear()
        ' LOADING DOMAIN NAMES FROM DATABASE
        '======================================================================================================================================
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "SELECT DISTINCT(domain) FROM USERACCOUNTS"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                Try
                    While dr.Read
                        cmb_domain.Items.Add(dr.Item("domain"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read error")
                End Try
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error Domain name loading")
        End Try
        con_cls.disconnect()
        '======================================================================================================================================
    End Sub

    Public Sub loadUserID()
        ' LOADING USER ID'S FROM DATABASE
        '======================================================================================================================================
        cmb_username.Items.Clear()
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "SELECT userid FROM USERACCOUNTS WHERE domain='" & cmb_domain.SelectedItem & "'"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                Try
                    While dr.Read
                        If Not dr.Item("userid") = "superuser" Then
                            cmb_username.Items.Add(dr.Item("userid"))
                        End If
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read error")
                End Try
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error Username loading")
        End Try
        con_cls.disconnect()
        '======================================================================================================================================
    End Sub
End Class