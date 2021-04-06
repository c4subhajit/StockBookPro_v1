Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frm_home
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry
    Dim filename As String
    Dim backUpPath As String
    Dim dr As SqlDataReader
    Public username, dbRestoreUser, dbRestoreDom, dbRestorePath, password, domain As String
    Public dateFrom, dateTo, preRestoreDate As Date
    Public ciName As String

    Private Sub frm_home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call con_cls.softwareValidity(Me)
        Call dbExistCheck()
        Call failsafe()
        Call scheduledBackup()
        Call checkDbRestore()
        Try
            Dim form As New frm_login
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub Timer_Home_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Home.Tick
        TSSL_homeClock.Text = My.Computer.Clock.LocalTime.ToString
    End Sub

    Private Sub TSMI_KVKSB_SD_SDU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_KVKSB_SD_SDU.Click
        Try
            Dim form As New frm_KVKSB_SD_SDU
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_KVKSB_SD_SDE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_KVKSB_SD_SDE.Click
        Try
            Dim form As New frm_KVKSB_SD_SDE
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_KVKSB_SD_SDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_KVKSB_SD_SDD.Click
        Try
            Dim form As New frm_KVKSB_SD_SDD
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_KVKSB_NCI_N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_KVKSB_NCI_N.Click
        Try
            Dim form As New frm_KVKSB_NCI_N
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_KVKSB_NCI_D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_KVKSB_NCI_D.Click
        If domain = "Administrator" Then
            Try
                Dim form As New frm_KVKSB_NCI_D
                form.MdiParent = Me
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        Else
            MsgBox("User must be a member of Administrator domain to continue", MsgBoxStyle.OkOnly, "Authentication information")
        End If
    End Sub

    Private Sub TSMI_KVKSB_STAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_KVKSB_STAT.Click
        Try
            Dim form As New frm_ciStatement
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_CS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_CS.Click
        Try
            Dim form As New frm_currentStatus
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_TRANS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_TRANS.Click
        Try
            Dim form As New frm_transactions
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_ST_UTILS_CALCULATOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_CAL.Click
        Try
            System.Diagnostics.Process.Start("calc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
    End Sub

    Private Sub TSMI_ST_UTILS_NOTEPAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_NOTE.Click
        Try
            System.Diagnostics.Process.Start("notepad")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
    End Sub

    Private Sub TSMI_ST_DB_BDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ST_DB_BDB.Click

        ' DATABASE BACKUP
        '======================================================================================================================================
        If domain = "Administrator" Then
            FBD_dbBackUp.ShowDialog()
            If Not FBD_dbBackUp.SelectedPath = "" Then
                Try
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook.mdf", FBD_dbBackUp.SelectedPath & "\KVKDhalai_Stockbook.mdf", True)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook_log.ldf", FBD_dbBackUp.SelectedPath & "\KVKDhalai_Stockbook_log.ldf", True)
                    trans_querry.update_trans_database(domain, username, "Backup Database", "Successful (Path: " & FBD_dbBackUp.SelectedPath & ")")
                    MsgBox("Backup Successful", MsgBoxStyle.OkOnly, "Backup Information")
                Catch ex As Exception
                    trans_querry.update_trans_database(domain, username, "Backup Database", "Unsuccessful (Path: " & FBD_dbBackUp.SelectedPath & ")")
                    MsgBox("Backup unsuccessful", MsgBoxStyle.OkOnly, "Backup Information")
                End Try
            Else
                MsgBox("No path selected.", MsgBoxStyle.OkOnly, "Backup information")
            End If
        Else
            MsgBox("User must be a member of Administrator domain to continue", MsgBoxStyle.OkOnly, "Authentication information")
        End If
    End Sub

    Private Sub TSMI_ST_DB_RDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ST_DB_RDB.Click
        ' DATABASE RESTORE
        '======================================================================================================================================
        If domain = "Administrator" Then
            MsgBox("Please save all unsaved information before continuing", MsgBoxStyle.OkOnly, "Database Restore Information")
            If MessageBox.Show("Do u want to continue with database restore now?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim file1, file2, filePath As String

                '   Database File KVKDhalai_Stockbook.mdf Restore
                MsgBox("Select KVKDhalai_Stockbook.mdf file.", MsgBoxStyle.OkOnly, "Database restore information")
                file1 = ""
                OFD_db.ShowDialog()
                filePath = OFD_db.FileName
                filename = My.Computer.FileSystem.GetName(OFD_db.FileName)
                If filename = "KVKDhalai_Stockbook.mdf" Or filename = "KVKDhalai_Stockbook.MDF" Then
                    Try
                        If Not My.Computer.FileSystem.DirectoryExists("D:\BACKUP\KVKSTOCK\DBRESTORE") Then
                            My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\DBRESTORE")
                            My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy"))
                            My.Computer.FileSystem.CopyFile(OFD_db.FileName, "D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy") & "\KVKDhalai_Stockbook.mdf", True)
                            file1 = "COPIED"
                        Else
                            If Not My.Computer.FileSystem.DirectoryExists("D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy")) Then
                                My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy"))
                            End If
                            My.Computer.FileSystem.CopyFile(OFD_db.FileName, "D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy") & "\KVKDhalai_Stockbook.mdf", True)
                            file1 = "COPIED"
                        End If
                    Catch ex As Exception
                        Try
                            trans_querry.update_trans_database(domain, username, "Restore Database", "Unsuccessful (Path: " & filePath & ")")
                            MsgBox("Database File KVKDhalai_Stockbook.mdf Restore unsuccessful", MsgBoxStyle.OkOnly, "Database restore information")
                            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                        Catch ex2 As Exception
                            MsgBox(ex2.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                        End Try
                    End Try
                Else
                    MsgBox("Software database not found. Please browse correct database file.", MsgBoxStyle.OkOnly, "Database restore information")
                    Exit Sub
                End If

                '   Database File KVKDhalai_Stockbook_log.LDF Restore
                MsgBox("Select KVKDhalai_Stockbook_log.LDF file.", MsgBoxStyle.OkOnly, "Database restore information")
                file2 = ""
                OFD_db.ShowDialog()
                filename = My.Computer.FileSystem.GetName(OFD_db.FileName)
                If filename = "KVKDhalai_Stockbook_log.LDF" Or filename = "KVKDhalai_Stockbook_log.ldf" Then
                    Try
                        If Not My.Computer.FileSystem.DirectoryExists("D:\BACKUP\KVKSTOCK\DBRESTORE") Then
                            My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\DBRESTORE")
                            My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy"))
                            My.Computer.FileSystem.CopyFile(OFD_db.FileName, "D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy") & "\KVKDhalai_Stockbook_log.LDF", True)
                            file2 = "COPIED"
                        Else
                            If Not My.Computer.FileSystem.DirectoryExists("D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy")) Then
                                My.Computer.FileSystem.CreateDirectory("D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy"))
                            End If
                            My.Computer.FileSystem.CopyFile(OFD_db.FileName, "D:\BACKUP\KVKSTOCK\DBRESTORE\" & Date.Today.ToString("MM.dd.yyyy") & "\KVKDhalai_Stockbook_log.LDF", True)
                            file2 = "COPIED"
                        End If
                    Catch ex As Exception
                        Try
                            trans_querry.update_trans_database(domain, username, "Restore Database", "Unsuccessful (Path: " & filePath & ")")
                            MsgBox("Database File KVKDhalai_Stockbook_log.LDF Restore unsuccessful", MsgBoxStyle.OkOnly, "Database restore information")
                            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                        Catch ex2 As Exception
                            MsgBox(ex2.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                        End Try
                    End Try
                Else
                    MsgBox("Software database not found. Please browse correct database file.", MsgBoxStyle.OkOnly, "Database restore information")
                    Exit Sub
                End If

                '    Saving database restore successful information on database 
                If file1 = "COPIED" And file2 = "COPIED" Then
                    Try
                        trans_querry.update_trans_database(domain, username, filePath, "Partially Successful")
                        MsgBox("Please restart application IMMEDIATELY to continue.", MsgBoxStyle.OkOnly, "Database restore information")
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                    End Try
                End If
            End If
        Else
            MsgBox("User must be a member of Administrator domain to continue", MsgBoxStyle.OkOnly, "Authentication information")
        End If
    End Sub

    Private Sub TSMI_ST_UA_CP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ST_UA_CP.Click
        Try
            Dim form As New frm_login_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_ST_UA_NUA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ST_UA_NUA.Click
        If domain = "Administrator" Then
            Try
                Dim form As New frm_login_newuser
                form.MdiParent = Me
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        Else
            MsgBox("User must be a member of Administrator domain to continue", MsgBoxStyle.OkOnly, "Authentication information")
        End If
    End Sub

    Private Sub TSMI_ST_UA_DUA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ST_UA_DUA.Click
        If domain = "Administrator" Then
            Try
                Dim form As New frm_login_deluser
                form.MdiParent = Me
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        Else
            MsgBox("User must be a member of Administrator domain to continue", MsgBoxStyle.OkOnly, "Authentication information")
        End If
    End Sub

    Private Sub TSMI_ST_UA_DD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ST_UA_DD.Click
        If domain = "Administrator" Then
            Try
                Dim form As New frm_login_deldom
                form.MdiParent = Me
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        Else
            MsgBox("User must be a member of Administrator domain to continue", MsgBoxStyle.OkOnly, "Authentication information")
        End If
    End Sub

    Private Sub TSMI_LO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_LO.Click
        Me.Enabled = False
        frm_login.Show()
    End Sub

    Private Sub TSMI_ABOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ABT.Click
        Try
            Dim form As New frm_about
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_EXIT.Click
        If MessageBox.Show("Do u want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    '=================================================================
    '                   CONTEXT MENU ITEMS
    '=================================================================

    Private Sub TSMI_CAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_CAL.Click
        Try
            System.Diagnostics.Process.Start("calc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
    End Sub

    Private Sub TSMI_NOTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_NOTE.Click
        Try
            System.Diagnostics.Process.Start("notepad")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
    End Sub

    Private Sub TSMI_LOGOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_LOGOUT.Click
        Me.Enabled = False
        frm_login.Show()
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================
    Public Sub dbExistCheck()

        ' DATABASE EXIST CHECK
        '======================================================================================================================================
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\DataItems\KVKDhalai_Stockbook.mdf") Then
            MsgBox("Software database not found. Please browse database file.", MsgBoxStyle.OkOnly, "Database information")
            OFD_db.ShowDialog()
            filename = My.Computer.FileSystem.GetName(OFD_db.FileName)
            If filename = "KVKDhalai_Stockbook.mdf" Then
                Try
                    My.Computer.FileSystem.CopyFile(OFD_db.FileName, Application.StartupPath & "\DataItems\" & filename, True)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Database information")
                End Try
            Else
                Call dbExistCheck()
            End If
        End If
        '======================================================================================================================================
    End Sub

    Public Sub failsafe()

        '  FAILSAFE DATABASE BACKUP TILL LAST USE
        '======================================================================================================================================
        Try
            con_cls.disconnect()
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Stockbook.mdf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Stockbook_log.ldf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Catch ex As Exception
            MsgBox("Failsafe process (delete) unsuccessful", MsgBoxStyle.OkOnly, "Failsafe information")
        End Try
        Try
            con_cls.disconnect()
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\DataItems\KVKDhalai_Stockbook.mdf", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Stockbook.mdf", True)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\DataItems\KVKDhalai_Stockbook_log.ldf", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Stockbook_log.ldf", True)
        Catch ex As Exception
            MsgBox("Failsafe process unsuccessful", MsgBoxStyle.OkOnly, "Failsafe information")
        End Try
        '======================================================================================================================================
    End Sub

    Public Sub scheduledBackup()

        '  DATABASE SCHEDULED BACKUP TILL LAST USE
        '======================================================================================================================================
        Try
            con_cls.disconnect()
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook.mdf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook_log.ldf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Catch ex As Exception
            MsgBox("ScheduledBackup process (delete) unsuccessful", MsgBoxStyle.OkOnly, "ScheduledBackup information")
        End Try
        Try
            con_cls.disconnect()
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\DataItems\KVKDhalai_Stockbook.mdf", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook.mdf", True)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\DataItems\KVKDhalai_Stockbook_log.ldf", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ScheduledBackup\KVKDhalai_Stockbook_log.ldf", True)
        Catch ex As Exception
            MsgBox("ScheduledBackup process unsuccessful", MsgBoxStyle.OkOnly, "ScheduledBackup information")
        End Try
        '======================================================================================================================================
    End Sub

    Public Sub checkDbRestore()
        'CHECK DATABASE RESTORE STATUS
        '======================================================================================================================================
        Try
            'Read last successfull database restore date from database
            '======================================================================================================================================
            con_cls.connectFailsafe()
            con_cls.cmdFailsafe.CommandText = "SELECT MAX(doe) FROM TTABLEDATABASE WHERE rem='Partially Successful'"
            dr = con_cls.cmdFailsafe.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    preRestoreDate = dr.Item(0)
                Else
                    dr.Close()
                    con_cls.disconnectFailsafe()
                    Exit Sub
                End If
            End If
            dr.Close()
            con_cls.cmdFailsafe.CommandText = "SELECT userInfo FROM TTABLEDATABASE WHERE rem='Partially Successful'"
            dr = con_cls.cmdFailsafe.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    dbRestoreUser = dr.Item(0)
                End If
            End If
            dr.Close()
            con_cls.cmdFailsafe.CommandText = "SELECT dom FROM TTABLEDATABASE WHERE rem='Partially Successful'"
            dr = con_cls.cmdFailsafe.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    dbRestoreDom = dr.Item(0)
                End If
            End If
            dr.Close()
            con_cls.cmdFailsafe.CommandText = "SELECT type FROM TTABLEDATABASE WHERE rem='Partially Successful'"
            dr = con_cls.cmdFailsafe.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    dbRestorePath = dr.Item(0)
                End If
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
        dr.Close()
        con_cls.disconnectFailsafe()
        '======================================================================================================================================

        'Database Auto Restore 
        '======================================================================================================================================
        Try
            My.Computer.FileSystem.CopyFile("D:\BACKUP\KVKSTOCK\DBRESTORE\" & preRestoreDate.Date.ToString("MM.dd.yyyy") & "\KVKDhalai_Stockbook.mdf", Application.StartupPath & "\DataItems\KVKDhalai_Stockbook.mdf", True)
            My.Computer.FileSystem.CopyFile("D:\BACKUP\KVKSTOCK\DBRESTORE\" & preRestoreDate.Date.ToString("MM.dd.yyyy") & "\KVKDhalai_Stockbook_log.ldf", Application.StartupPath & "\DataItems\KVKDhalai_Stockbook_log.ldf", True)
            Try
                trans_querry.update_trans_database(dbRestoreDom, dbRestoreUser, "Restore Database", "Successful (Path: " & dbRestorePath & ")")
                MsgBox("Restore Database Successful", MsgBoxStyle.OkOnly, "Database Restore Information")
            Catch ex1 As Exception
                MsgBox(ex1.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
            Try
                trans_querry.update_trans_database(dbRestoreDom, dbRestoreUser, "Restore Database", "Unsuccessful (Path: " & dbRestorePath & ")")
                MsgBox("Restore Database Unsuccessful", MsgBoxStyle.OkOnly, "Database Restore Information")
            Catch ex2 As Exception
                MsgBox(ex2.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
            End Try
        End Try
        '======================================================================================================================================

    End Sub

    
End Class