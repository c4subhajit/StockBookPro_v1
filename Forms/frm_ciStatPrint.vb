Public Class frm_ciStatPrint

    Private Sub frm_ciStatPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If frm_home.ciName = "ALL CRITICAL INPUTS" Then
                Me.STOCKBOOKTableAdapter.Fill(Me.KVKDhalai_StockbookDataSet.STOCKBOOK, frm_home.dateFrom, frm_home.dateTo)
            Else
                Me.STOCKBOOKTableAdapter.FillBy(Me.KVKDhalai_StockbookDataSet.STOCKBOOK, frm_home.dateFrom, frm_home.dateTo, frm_home.ciName)
            End If
            Me.ReportViewer_ciStat.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in report update Block 5")
        End Try
    End Sub

End Class