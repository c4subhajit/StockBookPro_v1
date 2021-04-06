Imports System.Data
Imports System.Data.SqlClient

Public Class frm_currentStatus
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Public t_id As Int64

    Private Sub frm_currentStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
        Call loadCINames()
    End Sub

    Private Sub cmb_ci_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ci.SelectedIndexChanged
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
        Call loadCINames()
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

End Class