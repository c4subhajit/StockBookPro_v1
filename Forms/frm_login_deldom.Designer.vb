<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_deldom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login_deldom))
        Me.cmb_domain = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_delete = New System.Windows.Forms.Button
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_domain
        '
        Me.cmb_domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_domain.FormattingEnabled = True
        Me.cmb_domain.Items.AddRange(New Object() {""})
        Me.cmb_domain.Location = New System.Drawing.Point(266, 24)
        Me.cmb_domain.Name = "cmb_domain"
        Me.cmb_domain.Size = New System.Drawing.Size(121, 21)
        Me.cmb_domain.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Domain"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(309, 73)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(65, 25)
        Me.cmd_cancel.TabIndex = 48
        Me.cmd_cancel.Text = "&Cancel"
        '
        'cmd_delete
        '
        Me.cmd_delete.Location = New System.Drawing.Point(217, 73)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(65, 25)
        Me.cmd_delete.TabIndex = 47
        Me.cmd_delete.Text = "&Delete"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.StocksKVK.My.Resources.Resources.Logo_KVK_190x190
        Me.LogoPictureBox.Location = New System.Drawing.Point(2, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(190, 190)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 50
        Me.LogoPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Location = New System.Drawing.Point(195, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 68)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "---  IMPORTANT  ---" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please note that deletion of a Domain will lead to deletion " & _
            "of all associated User ID's in that Domain."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_login_deldom
        '
        Me.AcceptButton = Me.cmd_delete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(399, 192)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_domain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(415, 230)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(415, 230)
        Me.Name = "frm_login_deldom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Domain"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_domain As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
