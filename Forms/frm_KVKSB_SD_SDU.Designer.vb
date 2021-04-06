<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_KVKSB_SD_SDU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_KVKSB_SD_SDU))
        Me.txt_osb = New System.Windows.Forms.TextBox
        Me.cmb_ci = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_SRD_QTY = New System.Windows.Forms.TextBox
        Me.txt_SRD_MD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTP_SD_date = New System.Windows.Forms.DateTimePicker
        Me.txt_date = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_SID_REM = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_SID_QTY = New System.Windows.Forms.TextBox
        Me.txt_SID_IT = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_unit = New System.Windows.Forms.TextBox
        Me.cmd_save = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_csb = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_osb
        '
        Me.txt_osb.Location = New System.Drawing.Point(132, 51)
        Me.txt_osb.Name = "txt_osb"
        Me.txt_osb.ReadOnly = True
        Me.txt_osb.Size = New System.Drawing.Size(225, 20)
        Me.txt_osb.TabIndex = 16
        Me.txt_osb.TabStop = False
        '
        'cmb_ci
        '
        Me.cmb_ci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ci.FormattingEnabled = True
        Me.cmb_ci.Items.AddRange(New Object() {""})
        Me.cmb_ci.Location = New System.Drawing.Point(132, 12)
        Me.cmb_ci.Name = "cmb_ci"
        Me.cmb_ci.Size = New System.Drawing.Size(225, 21)
        Me.cmb_ci.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Unit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Opening stock balance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select critical input"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_SRD_QTY)
        Me.GroupBox1.Controls.Add(Me.txt_SRD_MD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Receive Details"
        '
        'txt_SRD_QTY
        '
        Me.txt_SRD_QTY.Location = New System.Drawing.Point(123, 84)
        Me.txt_SRD_QTY.MaxLength = 18
        Me.txt_SRD_QTY.Name = "txt_SRD_QTY"
        Me.txt_SRD_QTY.Size = New System.Drawing.Size(200, 20)
        Me.txt_SRD_QTY.TabIndex = 5
        '
        'txt_SRD_MD
        '
        Me.txt_SRD_MD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SRD_MD.Location = New System.Drawing.Point(123, 18)
        Me.txt_SRD_MD.MaxLength = 250
        Me.txt_SRD_MD.Multiline = True
        Me.txt_SRD_MD.Name = "txt_SRD_MD"
        Me.txt_SRD_MD.Size = New System.Drawing.Size(200, 60)
        Me.txt_SRD_MD.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Memo/Bill details"
        '
        'DTP_SD_date
        '
        Me.DTP_SD_date.Location = New System.Drawing.Point(339, 90)
        Me.DTP_SD_date.Name = "DTP_SD_date"
        Me.DTP_SD_date.Size = New System.Drawing.Size(18, 20)
        Me.DTP_SD_date.TabIndex = 2
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(202, 90)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(128, 20)
        Me.txt_date.TabIndex = 19
        Me.txt_date.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_SID_REM)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_SID_QTY)
        Me.GroupBox2.Controls.Add(Me.txt_SID_IT)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(371, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 203)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock Issue/Distribution Details"
        '
        'txt_SID_REM
        '
        Me.txt_SID_REM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SID_REM.Location = New System.Drawing.Point(86, 87)
        Me.txt_SID_REM.MaxLength = 250
        Me.txt_SID_REM.Multiline = True
        Me.txt_SID_REM.Name = "txt_SID_REM"
        Me.txt_SID_REM.Size = New System.Drawing.Size(200, 60)
        Me.txt_SID_REM.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(23, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 27)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Remarks/Utilization"
        '
        'txt_SID_QTY
        '
        Me.txt_SID_QTY.Location = New System.Drawing.Point(86, 162)
        Me.txt_SID_QTY.MaxLength = 18
        Me.txt_SID_QTY.Name = "txt_SID_QTY"
        Me.txt_SID_QTY.Size = New System.Drawing.Size(200, 20)
        Me.txt_SID_QTY.TabIndex = 9
        '
        'txt_SID_IT
        '
        Me.txt_SID_IT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SID_IT.Location = New System.Drawing.Point(86, 18)
        Me.txt_SID_IT.MaxLength = 250
        Me.txt_SID_IT.Multiline = True
        Me.txt_SID_IT.Name = "txt_SID_IT"
        Me.txt_SID_IT.Size = New System.Drawing.Size(200, 60)
        Me.txt_SID_IT.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Quantity"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(11, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 37)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Distributed/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Issued to"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_unit
        '
        Me.txt_unit.Location = New System.Drawing.Point(76, 90)
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.ReadOnly = True
        Me.txt_unit.Size = New System.Drawing.Size(82, 20)
        Me.txt_unit.TabIndex = 21
        Me.txt_unit.TabStop = False
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(329, 260)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(75, 23)
        Me.cmd_save.TabIndex = 11
        Me.cmd_save.Text = "&Save"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(193, 260)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 10
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(470, 260)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 12
        Me.cmd_cancel.Text = "&Cancel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(368, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Closing stock balance"
        '
        'txt_csb
        '
        Me.txt_csb.Location = New System.Drawing.Point(485, 224)
        Me.txt_csb.Name = "txt_csb"
        Me.txt_csb.ReadOnly = True
        Me.txt_csb.Size = New System.Drawing.Size(188, 20)
        Me.txt_csb.TabIndex = 23
        Me.txt_csb.TabStop = False
        '
        'frm_KVKSB_SD_SDU
        '
        Me.AcceptButton = Me.cmd_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(684, 292)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_csb)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.txt_unit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DTP_SD_date)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_osb)
        Me.Controls.Add(Me.cmb_ci)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 330)
        Me.MinimumSize = New System.Drawing.Size(700, 330)
        Me.Name = "frm_KVKSB_SD_SDU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stock Details Update"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_osb As System.Windows.Forms.TextBox
    Friend WithEvents cmb_ci As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_SRD_QTY As System.Windows.Forms.TextBox
    Friend WithEvents txt_SRD_MD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTP_SD_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_SID_REM As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_SID_QTY As System.Windows.Forms.TextBox
    Friend WithEvents txt_SID_IT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_unit As System.Windows.Forms.TextBox
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_csb As System.Windows.Forms.TextBox
End Class
