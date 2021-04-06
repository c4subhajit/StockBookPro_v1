<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.chk_change = New System.Windows.Forms.CheckBox
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_login = New System.Windows.Forms.Button
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_domain = New System.Windows.Forms.ComboBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_change
        '
        Me.chk_change.AutoSize = True
        Me.chk_change.Location = New System.Drawing.Point(230, 121)
        Me.chk_change.Name = "chk_change"
        Me.chk_change.Size = New System.Drawing.Size(121, 17)
        Me.chk_change.TabIndex = 16
        Me.chk_change.Text = "Change login details"
        Me.chk_change.UseVisualStyleBackColor = True
        '
        'cmd_exit
        '
        Me.cmd_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_exit.Location = New System.Drawing.Point(324, 143)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(52, 22)
        Me.cmd_exit.TabIndex = 15
        Me.cmd_exit.Text = "&Exit"
        '
        'cmd_reset
        '
        Me.cmd_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_reset.Location = New System.Drawing.Point(266, 143)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(52, 22)
        Me.cmd_reset.TabIndex = 14
        Me.cmd_reset.Text = "&Reset"
        '
        'cmd_login
        '
        Me.cmd_login.Location = New System.Drawing.Point(208, 143)
        Me.cmd_login.Name = "cmd_login"
        Me.cmd_login.Size = New System.Drawing.Size(52, 22)
        Me.cmd_login.TabIndex = 13
        Me.cmd_login.Text = "&Login"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(206, 95)
        Me.txt_pass.MaxLength = 49
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(170, 20)
        Me.txt_pass.TabIndex = 12
        '
        'txt_user
        '
        Me.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_user.Location = New System.Drawing.Point(206, 55)
        Me.txt_user.MaxLength = 49
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(170, 20)
        Me.txt_user.TabIndex = 10
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(206, 76)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(170, 18)
        Me.PasswordLabel.TabIndex = 11
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(206, 33)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(170, 21)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Domain"
        '
        'cmb_domain
        '
        Me.cmb_domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_domain.FormattingEnabled = True
        Me.cmb_domain.Items.AddRange(New Object() {""})
        Me.cmb_domain.Location = New System.Drawing.Point(255, 11)
        Me.cmb_domain.Name = "cmb_domain"
        Me.cmb_domain.Size = New System.Drawing.Size(121, 21)
        Me.cmb_domain.TabIndex = 18
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.StocksKVK.My.Resources.Resources.Logo_KVK_190x190
        Me.LogoPictureBox.Location = New System.Drawing.Point(1, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(190, 190)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'frm_login
        '
        Me.AcceptButton = Me.cmd_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_reset
        Me.ClientSize = New System.Drawing.Size(394, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_domain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_change)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.MaximumSize = New System.Drawing.Size(410, 230)
        Me.MinimumSize = New System.Drawing.Size(410, 230)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login to Stockbook Pro"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_change As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_login As System.Windows.Forms.Button
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_domain As System.Windows.Forms.ComboBox
End Class
