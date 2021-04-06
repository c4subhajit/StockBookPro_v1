<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ciStatPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ciStatPrint))
        Me.STOCKBOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KVKDhalai_StockbookDataSet = New StocksKVK.KVKDhalai_StockbookDataSet
        Me.ReportViewer_ciStat = New Microsoft.Reporting.WinForms.ReportViewer
        Me.STOCKBOOKTableAdapter = New StocksKVK.KVKDhalai_StockbookDataSetTableAdapters.STOCKBOOKTableAdapter
        CType(Me.STOCKBOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KVKDhalai_StockbookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'STOCKBOOKBindingSource
        '
        Me.STOCKBOOKBindingSource.DataMember = "STOCKBOOK"
        Me.STOCKBOOKBindingSource.DataSource = Me.KVKDhalai_StockbookDataSet
        '
        'KVKDhalai_StockbookDataSet
        '
        Me.KVKDhalai_StockbookDataSet.DataSetName = "KVKDhalai_StockbookDataSet"
        Me.KVKDhalai_StockbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer_ciStat
        '
        Me.ReportViewer_ciStat.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "KVKDhalai_StockbookDataSet_STOCKBOOK"
        ReportDataSource1.Value = Me.STOCKBOOKBindingSource
        Me.ReportViewer_ciStat.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer_ciStat.LocalReport.ReportEmbeddedResource = "StocksKVK.Report_StockBook.rdlc"
        Me.ReportViewer_ciStat.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer_ciStat.Name = "ReportViewer_ciStat"
        Me.ReportViewer_ciStat.Size = New System.Drawing.Size(884, 512)
        Me.ReportViewer_ciStat.TabIndex = 0
        '
        'STOCKBOOKTableAdapter
        '
        Me.STOCKBOOKTableAdapter.ClearBeforeFill = True
        '
        'frm_ciStatPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.Controls.Add(Me.ReportViewer_ciStat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "frm_ciStatPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Critical Input Statement"
        CType(Me.STOCKBOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KVKDhalai_StockbookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer_ciStat As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents STOCKBOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KVKDhalai_StockbookDataSet As StocksKVK.KVKDhalai_StockbookDataSet
    Friend WithEvents STOCKBOOKTableAdapter As StocksKVK.KVKDhalai_StockbookDataSetTableAdapters.STOCKBOOKTableAdapter
End Class
