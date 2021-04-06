Imports System.Data
Imports System.Data.SqlClient

Public Class frm_ciStatement
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Public tableName As String
    Dim con_cls As New class_connect_string

    Private Sub frm_ciStatement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgv_tt.DataSource = ""
        txt_date_from.Clear()
        txt_date_to.Clear()
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

    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ci.SelectedIndexChanged
        dgv_tt.DataSource = ""
    End Sub

    Private Sub cmd_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click
        If ((Not txt_date_from.Text = "") And (Not txt_date_to.Text = "")) Then
            '            TRANSACTION BY TYPE SEARCH
            '===================================================
            If Not cmb_ci.SelectedItem = "" Then
                con_cls.connect()
                If cmb_ci.SelectedItem = "ALL CRITICAL INPUTS" Then
                    con_cls.cmd.CommandText = "SELECT date,ci,unit,osb,srmd,srqty,sddetail,sdrem,sdqty,csb,rui FROM STOCKBOOK WHERE " & _
                    "date BETWEEN '" & CDate(txt_date_from.Text) & "' AND '" & CDate(txt_date_to.Text) & "'"
                Else
                    con_cls.cmd.CommandText = "SELECT date,ci,unit,osb,srmd,srqty,sddetail,sdrem,sdqty,csb,rui FROM STOCKBOOK WHERE (ci='" & _
                    cmb_ci.SelectedItem & "' AND date BETWEEN '" & CDate(txt_date_from.Text) & "' AND '" & CDate(txt_date_to.Text) & "')"
                End If
                Dim dt As New DataTable
                dt.Load(con_cls.cmd.ExecuteReader)
                dgv_tt.AutoGenerateColumns = True
                dgv_tt.DataSource = dt
                con_cls.disconnect()
            Else
                MsgBox("Please select critical input to continue.", MsgBoxStyle.OkOnly, "Satement load error")
            End If
            '===================================================
        Else
            MsgBox("Please select date range first", MsgBoxStyle.OkOnly, "Statement load error.")
        End If
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        If frm_home.domain = "Administrator" Then
            If ((Not txt_date_from.Text = "") And (Not txt_date_to.Text = "")) Then
                frm_home.dateFrom = txt_date_from.Text
                frm_home.dateTo = txt_date_to.Text
                frm_home.ciName = cmb_ci.SelectedItem
                Try
                    Dim form As New frm_ciStatPrint
                    form.MdiParent = frm_home
                    form.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Open Child")
                End Try
            Else
                MsgBox("Please select date range first", MsgBoxStyle.OkOnly, "Statement load error.")
            End If
        Else
            MsgBox("User must be a member of Administrator domain to continue", MsgBoxStyle.OkOnly, "Authentication information")
        End If
    End Sub

    Private Sub DTP_from_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_from.ValueChanged
        dgv_tt.DataSource = ""
        txt_date_from.Text = DTP_from.Value.Date
    End Sub

    Private Sub DTP_to_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_to.ValueChanged
        dgv_tt.DataSource = ""
        txt_date_to.Text = DTP_to.Value.Date
    End Sub

End Class