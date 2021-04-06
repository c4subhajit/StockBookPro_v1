Imports System.Data
Imports System.Data.SqlClient

Public Class frm_login_deldom
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry

    Private Sub frm_login_deldom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call loadDomain()
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If Not cmb_domain.SelectedItem = "" Then
            If MessageBox.Show("Confirm Domain Name Deletion.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM USERACCOUNTS WHERE domain='" & cmb_domain.SelectedItem & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "Domain Name Deletion", "Successful")
                    MsgBox("Domain deleted successfully", MsgBoxStyle.OkOnly, "Domain Delete Information")
                    Call loadDomain()
                Catch ex As Exception
                    trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "Domain Name Deletion", "Unsuccessful")
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Domain Delete Information")
                End Try
            End If
        Else
            MsgBox("Select Domain first.", MsgBoxStyle.OkOnly, "Domain Delete Information")
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    '==============================================================================
    '               USER DEFINED FUNCTIONS
    '===============================================================================
    Public Sub loadDomain()
        cmb_domain.Items.Clear()
        ' LOADING DOMAIN NAMES FROM DATABASE
        '======================================================================================================================================
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "SELECT DISTINCT(domain) FROM USERACCOUNTS"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                Try
                    While dr.Read
                        If Not dr.Item("domain") = "Administrator" Then
                            cmb_domain.Items.Add(dr.Item("domain"))
                        End If
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

End Class