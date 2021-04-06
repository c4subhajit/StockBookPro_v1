<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ciStatement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ciStatement))
        Me.dgv_tt = New System.Windows.Forms.DataGridView
        Me.cmd_show = New System.Windows.Forms.Button
        Me.cmb_ci = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_date_from = New System.Windows.Forms.TextBox
        Me.txt_date_to = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTP_from = New System.Windows.Forms.DateTimePicker
        Me.DTP_to = New System.Windows.Forms.DateTimePicker
        Me.cmd_print = New System.Windows.Forms.Button
        CType(Me.dgv_tt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_tt
        '
        Me.dgv_tt.AllowUserToAddRows = False
        Me.dgv_tt.AllowUserToDeleteRows = False
        Me.dgv_tt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tt.Location = New System.Drawing.Point(12, 80)
        Me.dgv_tt.Name = "dgv_tt"
        Me.dgv_tt.ReadOnly = True
        Me.dgv_tt.Size = New System.Drawing.Size(860, 420)
        Me.dgv_tt.TabIndex = 16
        '
        'cmd_show
        '
        Me.cmd_show.Location = New System.Drawing.Point(531, 11)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(75, 23)
        Me.cmd_show.TabIndex = 4
        Me.cmd_show.Text = "&SHOW"
        Me.cmd_show.UseVisualStyleBackColor = True
        '
        'cmb_ci
        '
        Me.cmb_ci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ci.FormattingEnabled = True
        Me.cmb_ci.Items.AddRange(New Object() {"ALL CRITICAL INPUTS"})
        Me.cmb_ci.Location = New System.Drawing.Point(293, 12)
        Me.cmb_ci.Name = "cmb_ci"
        Me.cmb_ci.Size = New System.Drawing.Size(220, 21)
        Me.cmb_ci.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select critical input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Select date range"
        '
        'txt_date_from
        '
        Me.txt_date_from.Location = New System.Drawing.Point(247, 47)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.ReadOnly = True
        Me.txt_date_from.Size = New System.Drawing.Size(200, 20)
        Me.txt_date_from.TabIndex = 18
        Me.txt_date_from.TabStop = False
        Me.txt_date_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_date_to
        '
        Me.txt_date_to.Location = New System.Drawing.Point(521, 47)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.ReadOnly = True
        Me.txt_date_to.Size = New System.Drawing.Size(200, 20)
        Me.txt_date_to.TabIndex = 19
        Me.txt_date_to.TabStop = False
        Me.txt_date_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(483, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "To"
        '
        'DTP_from
        '
        Me.DTP_from.Location = New System.Drawing.Point(453, 47)
        Me.DTP_from.Name = "DTP_from"
        Me.DTP_from.Size = New System.Drawing.Size(18, 20)
        Me.DTP_from.TabIndex = 2
        '
        'DTP_to
        '
        Me.DTP_to.Location = New System.Drawing.Point(727, 47)
        Me.DTP_to.Name = "DTP_to"
        Me.DTP_to.Size = New System.Drawing.Size(18, 20)
        Me.DTP_to.TabIndex = 3
        '
        'cmd_print
        '
        Me.cmd_print.Location = New System.Drawing.Point(611, 11)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(75, 23)
        Me.cmd_print.TabIndex = 22
        Me.cmd_print.Text = "&PRINT"
        Me.cmd_print.UseVisualStyleBackColor = True
        '
        'frm_ciStatement
        '
        Me.AcceptButton = Me.cmd_show
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.DTP_to)
        Me.Controls.Add(Me.DTP_from)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_tt)
        Me.Controls.Add(Me.cmd_show)
        Me.Controls.Add(Me.cmb_ci)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 550)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "frm_ciStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Critical Input Statement"
        CType(Me.dgv_tt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_tt As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_show As System.Windows.Forms.Button
    Friend WithEvents cmb_ci As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_date_from As System.Windows.Forms.TextBox
    Friend WithEvents txt_date_to As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTP_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_print As System.Windows.Forms.Button
End Class
