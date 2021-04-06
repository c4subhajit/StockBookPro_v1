<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_deluser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login_deluser))
        Me.cmb_domain = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_delete = New System.Windows.Forms.Button
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.cmb_username = New System.Windows.Forms.ComboBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_domain
        '
        Me.cmb_domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_domain.FormattingEnabled = True
        Me.cmb_domain.Items.AddRange(New Object() {""})
        Me.cmb_domain.Location = New System.Drawing.Point(266, 35)
        Me.cmb_domain.Name = "cmb_domain"
        Me.cmb_domain.Size = New System.Drawing.Size(121, 21)
        Me.cmb_domain.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Domain"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(311, 133)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(65, 25)
        Me.cmd_cancel.TabIndex = 40
        Me.cmd_cancel.Text = "&Cancel"
        '
        'cmd_delete
        '
        Me.cmd_delete.Location = New System.Drawing.Point(219, 133)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(65, 25)
        Me.cmd_delete.TabIndex = 38
        Me.cmd_delete.Text = "&Delete"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(198, 82)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(62, 21)
        Me.UsernameLabel.TabIndex = 41
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_username
        '
        Me.cmb_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_username.FormattingEnabled = True
        Me.cmb_username.Items.AddRange(New Object() {""})
        Me.cmb_username.Location = New System.Drawing.Point(266, 83)
        Me.cmb_username.Name = "cmb_username"
        Me.cmb_username.Size = New System.Drawing.Size(121, 21)
        Me.cmb_username.TabIndex = 45
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.StocksKVK.My.Resources.Resources.Logo_KVK_190x190
        Me.LogoPictureBox.Location = New System.Drawing.Point(1, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(190, 190)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 42
        Me.LogoPictureBox.TabStop = False
        '
        'frm_login_deluser
        '
        Me.AcceptButton = Me.cmd_delete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(399, 192)
        Me.Controls.Add(Me.cmb_username)
        Me.Controls.Add(Me.cmb_domain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(415, 230)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(415, 230)
        Me.Name = "frm_login_deluser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete User Account"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_domain As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_username As System.Windows.Forms.ComboBox
End Class
