Imports System.Data
Imports System.Data.SqlClient

Public Class frm_login_newuser

    Dim username As String
    Dim domain As String
    Dim password As String
    Dim empty_field_status As String
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry
    Dim valid As New class_validation_functions

    Private Sub frm_login_newuser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()

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

    Private Sub cmb_domain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_domain.SelectedIndexChanged
        domain = cmb_domain.SelectedItem
        If cmb_domain.SelectedItem = "Create New" Then
            lbl_domain.Visible = True
            txt_domain.Visible = True
        Else
            lbl_domain.Visible = False
            txt_domain.Visible = False
        End If
    End Sub

    Private Sub cmd_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_create.Click
        Call check_empty_fields()
        con_cls.connect()
        If empty_field_status = "OK" Then
            Try
                If cmb_domain.SelectedItem = "Create New" Then
                    If Not txt_domain.Text = "" Then
                        con_cls.cmd.CommandText = "INSERT INTO USERACCOUNTS (domain,userid,pass) VALUES ('" & txt_domain.Text & "','" & txt_user.Text & "','" & txt_pass.Text & "')"
                    Else
                        MsgBox("Please enter new domain name", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
                        Exit Sub
                    End If
                Else
                    con_cls.cmd.CommandText = "INSERT INTO USERACCOUNTS (domain,userid,pass) VALUES ('" & cmb_domain.SelectedItem & "','" & txt_user.Text & "','" & txt_pass.Text & "')"
                End If
                con_cls.cmd.ExecuteNonQuery()
                MsgBox("New user created successfully.", MsgBoxStyle.OkOnly, "User account creation information.")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "New user create information")
            End Try
            Try
                trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "New User ID Creation", "New User ID " & txt_user.Text & " Created")
                If cmb_domain.SelectedItem = "Create New" Then
                    trans_querry.update_trans_newDetails(frm_home.domain, frm_home.username, "New Domain Creation", "New Domain " & txt_domain.Text & " Created")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "New user create transaction update information")
            End Try
            con_cls.disconnect()
            Call resetFields()
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
        With txt_domain
            .Visible = False
            .Clear()
        End With
        lbl_domain.Visible = False
        txt_user.Clear()
        txt_pass.Clear()
        txt_confpass.Clear()
        cmb_domain.SelectedIndex = 0
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_domain_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_domain.Validating
        Try
            valid.domain_validate(txt_domain.Text, txt_domain)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_user_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_user.Validating
        Try
            valid.userid_validate(txt_user.Text, txt_user)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_pass_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pass.Validating
        Try
            valid.pass_validate(txt_pass.Text, txt_confpass.Text, txt_pass)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_confpass_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_confpass.Validating
        Try
            valid.pass_validate(txt_pass.Text, txt_confpass.Text, txt_pass)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    '=================================================================
    '              EMPTY FIELD VALIDATION OF DATA FIELDS
    '=================================================================

    Public Sub check_empty_fields()
        empty_field_status = ""
        If cmb_domain.SelectedItem = "" Then
            MsgBox("Please select domain", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmb_domain.Focus()
            Exit Sub
        ElseIf txt_user.Text = "" Then
            MsgBox("Please enter username", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_user.Focus()
            Exit Sub
        ElseIf txt_pass.Text = "" Then
            MsgBox("Please enter password", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_pass.Focus()
            Exit Sub
        ElseIf txt_confpass.Text = "" Then
            MsgBox("Please enter confirm password", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_confpass.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

End Class