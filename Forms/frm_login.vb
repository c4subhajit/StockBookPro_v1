Imports System.Data
Imports System.Data.SqlClient

Public Class frm_login
    Dim prebackup As String
    Dim prebackupdate As Date
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry

    Private Sub frm_login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frm_home.MenuStrip_home.Enabled = False
        frm_home.ContextMenuStrip_home.Enabled = False
        If frm_home.Enabled = False Then
            cmd_exit.Enabled = False
        Else
            cmd_exit.Enabled = True
        End If
        Call reset_login()

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
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error in Domain name loading")
        End Try
        con_cls.disconnect()
        '======================================================================================================================================
    End Sub

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_login.Click
        con_cls.connect()
        If txt_user.Text = "" Then
            MsgBox("Please enter username")
        ElseIf txt_pass.Text = "" Then
            MsgBox("Please enter password")
        ElseIf cmb_domain.SelectedItem = "" Then
            MsgBox("Please select domain")
        Else

            'IF PASSWORD CHECK IS NOT CLICKED 
            '======================================================================================================================================
            If chk_change.Checked = False Then
                Try
                    con_cls.cmd.CommandText = "SELECT pass FROM USERACCOUNTS WHERE (domain='" & cmb_domain.SelectedItem & "' AND userid='" & txt_user.Text & "')"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        If dr.Item("pass") = txt_pass.Text Then
                            frm_home.username = txt_user.Text
                            frm_home.password = txt_pass.Text
                            frm_home.domain = cmb_domain.SelectedItem
                            trans_querry.update_trans_login(frm_home.domain, frm_home.username, "Login Status", "Successful")
                            dr.Close()
                            con_cls.disconnect()
                            Call reset_login()
                            frm_home.MenuStrip_home.Enabled = True
                            frm_home.ContextMenuStrip_home.Enabled = True
                            frm_home.Enabled = True
                            Call scheduled_backup()
                            Me.Close()
                            Exit Sub
                        End If
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        trans_querry.update_trans_login(cmb_domain.SelectedItem, txt_user.Text, "Login Status", "Unsuccessful")
                        Call reset_login()
                        dr.Close()
                        con_cls.disconnect()
                    Else
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        trans_querry.update_trans_login(cmb_domain.SelectedItem, txt_user.Text, "Login Status", "Unsuccessful")
                        Call reset_login()
                        dr.Close()
                        con_cls.disconnect()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
                End Try
            End If
            '======================================================================================================================================


            'IF PASSWORD CHECK IS CLICKED
            '======================================================================================================================================
            If chk_change.Checked = True Then
                Try
                    con_cls.cmd.CommandText = "SELECT pass FROM USERACCOUNTS WHERE (domain='" & cmb_domain.SelectedItem & "' AND userid='" & txt_user.Text & "')"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        If txt_pass.Text = dr.Item("pass") Then
                            frm_home.username = txt_user.Text
                            frm_home.password = txt_pass.Text
                            frm_home.domain = cmb_domain.SelectedItem
                            dr.Close()
                            con_cls.disconnect()
                            frm_home.MenuStrip_home.Enabled = True
                            frm_home.ContextMenuStrip_home.Enabled = True
                            frm_home.Enabled = True
                            trans_querry.update_trans_login(frm_home.domain, frm_home.username, "Login Status", "Successful")
                            Try
                                Dim form As New frm_login_modify
                                form.MdiParent = frm_home
                                form.Show()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Open Child")
                            End Try
                            Me.Close()
                            Call scheduled_backup()
                            Exit Sub
                        End If
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        trans_querry.update_trans_login(cmb_domain.SelectedItem, txt_user.Text, "Login Status", "Unsuccessful")
                        Call reset_login()
                        dr.Close()
                        con_cls.disconnect()
                    Else
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        trans_querry.update_trans_login(cmb_domain.SelectedItem, txt_user.Text, "Login Status", "Unsuccessful")
                        Call reset_login()
                        dr.Close()
                        con_cls.disconnect()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
                End Try
            End If
        End If
        '======================================================================================================================================

        txt_user.Text = ""
        txt_pass.Text = ""
        txt_user.Focus()

    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_login()
    End Sub

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        If MessageBox.Show("Do u want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frm_home.Close()
        End If
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================

    Public Sub reset_login()
        txt_user.Text = ""
        txt_pass.Text = ""
        chk_change.Checked = False
        txt_user.Focus()
        cmb_domain.SelectedIndex = 0
        AcceptButton = cmd_login
    End Sub

    Public Sub scheduled_backup()
        Try
            'Read last successfull scheduled database backup date from database
            '======================================================================================================================================
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT MAX(doe) FROM TTABLEDATABASE WHERE (type='Scheduled Backup' AND rem='Successful')"
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    prebackupdate = dr.Item(0)
                    prebackup = (prebackupdate.Date.AddDays(7)).ToString("MM.dd.yyyy")
                End If
            Else
                prebackup = System.DateTime.Today.ToString("MM.dd.yyyy")
                prebackupdate = System.DateTime.Today
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
        dr.Close()
        con_cls.disconnect()
        '======================================================================================================================================

        'Scheduled backup
        '======================================================================================================================================
        If DateDiff(DateInterval.Day, prebackupdate.Date, System.DateTime.Today, FirstDayOfWeek.System, FirstWeekOfYear.System) >= 7 Then
            Try
                If Not My.Computer.FileSystem.DirectoryExists("D:\BACKUP\KVKSTOCK") Then
                    My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK")
                    My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\" & prebackup)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook.mdf", "D:\BACKUP\KVKSTOCK\" & prebackup & "\KVKDhalai_Stockbook.mdf", True)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook_log.LDF", "D:\BACKUP\KVKSTOCK\" & prebackup & "\KVKDhalai_Stockbook_log.LDF", True)
                Else
                    My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\" & prebackup)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook.mdf", "D:\BACKUP\KVKSTOCK\" & prebackup & "\KVKDhalai_Stockbook.mdf", True)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook_log.LDF", "D:\BACKUP\KVKSTOCK\" & prebackup & "\KVKDhalai_Stockbook_log.LDF", True)
                End If
                Try
                    trans_querry.update_trans_database(0, "AUTO", "Scheduled Backup", "Successful")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                End Try
            Catch ex As Exception
                Try
                    trans_querry.update_trans_database(0, "AUTO", "Scheduled backup", "Unsuccessful")
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                End Try
            End Try
        End If
        '======================================================================================================================================
    End Sub


End Class