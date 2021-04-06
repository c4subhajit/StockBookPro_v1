Imports System.Data
Imports System.Data.SqlClient

Public Class frm_transactions
    Dim dt As DataTable
    Public tableName As String
    Dim con_cls As New class_connect_string

    Private Sub frm_transactions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgv_tt.DataSource = ""
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        dgv_tt.DataSource = ""
    End Sub

    Private Sub cmd_show_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_show.Click

        '            TRANSACTION BY TYPE SEARCH
        '===================================================
        If Not cmb_type.SelectedItem = "" Then
            Call checkTableName()
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT tid,doe,dom,userInfo,type,rem FROM " & tableName & " WHERE (type='" & cmb_type.SelectedItem & "')"
            Dim dt As New DataTable
            dt.Load(con_cls.cmd.ExecuteReader)
            dgv_tt.AutoGenerateColumns = True
            dgv_tt.DataSource = dt
            con_cls.disconnect()
        Else
            MsgBox("Select type of transaction first.", MsgBoxStyle.OkOnly, "Transaction error info.")
        End If
        '===================================================
    End Sub

    Public Sub checkTableName()
        If cmb_type.SelectedItem = "Login Status" Then
            tableName = "TTABLELOGIN"
        ElseIf cmb_type.SelectedItem = "Password Change" Then
            tableName = "TTABLELOGIN"
        ElseIf cmb_type.SelectedItem = "New Domain Creation" Then
            tableName = "TTABLENEWDETAILS"
        ElseIf cmb_type.SelectedItem = "Domain Name Deletion" Then
            tableName = "TTABLENEWDETAILS"
        ElseIf cmb_type.SelectedItem = "New User ID Creation" Then
            tableName = "TTABLENEWDETAILS"
        ElseIf cmb_type.SelectedItem = "User ID Deletion" Then
            tableName = "TTABLENEWDETAILS"
        ElseIf cmb_type.SelectedItem = "New Critical Input" Then
            tableName = "TTABLENEWDETAILS"
        ElseIf cmb_type.SelectedItem = "Critical Input Deletion" Then
            tableName = "TTABLENEWDETAILS"
        ElseIf cmb_type.SelectedItem = "Backup Database" Then
            tableName = "TTABLEDATABASE"
        ElseIf cmb_type.SelectedItem = "Restore Database" Then
            tableName = "TTABLEDATABASE"
        ElseIf cmb_type.SelectedItem = "Scheduled Backup" Then
            tableName = "TTABLEDATABASE"
        ElseIf cmb_type.SelectedItem = "Stock Detail Update" Then
            tableName = "TTABLESTOCKBOOK"
        ElseIf cmb_type.SelectedItem = "Stock Detail Edit" Then
            tableName = "TTABLESTOCKBOOK"
        ElseIf cmb_type.SelectedItem = "Stock Detail Delete" Then
            tableName = "TTABLESTOCKBOOK"
        End If
    End Sub

End Class