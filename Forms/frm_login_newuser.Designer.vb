<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_newuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login_newuser))
        Me.cmb_domain = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_create = New System.Windows.Forms.Button
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.txt_confpass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_domain = New System.Windows.Forms.Label
        Me.txt_domain = New System.Windows.Forms.TextBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_domain
        '
        Me.cmb_domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_domain.FormattingEnabled = True
        Me.cmb_domain.Items.AddRange(New Object() {"", "Create New"})
        Me.cmb_domain.Location = New System.Drawing.Point(267, 15)
        Me.cmb_domain.Name = "cmb_domain"
        Me.cmb_domain.Size = New System.Drawing.Size(121, 21)
        Me.cmb_domain.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Domain"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(256, 216)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(65, 25)
        Me.cmd_cancel.TabIndex = 8
        Me.cmd_cancel.Text = "Ca&ncel"
        '
        'cmd_reset
        '
        Me.cmd_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_reset.Location = New System.Drawing.Point(169, 216)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(65, 25)
        Me.cmd_reset.TabIndex = 7
        Me.cmd_reset.Text = "&Reset"
        '
        'cmd_create
        '
        Me.cmd_create.Location = New System.Drawing.Point(83, 216)
        Me.cmd_create.Name = "cmd_create"
        Me.cmd_create.Size = New System.Drawing.Size(65, 25)
        Me.cmd_create.TabIndex = 6
        Me.cmd_create.Text = "&Create"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(218, 102)
        Me.txt_pass.MaxLength = 49
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(170, 20)
        Me.txt_pass.TabIndex = 3
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'txt_user
        '
        Me.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_user.Location = New System.Drawing.Point(218, 62)
        Me.txt_user.MaxLength = 49
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(170, 20)
        Me.txt_user.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(218, 78)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(170, 25)
        Me.PasswordLabel.TabIndex = 22
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(218, 38)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(170, 25)
        Me.UsernameLabel.TabIndex = 19
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_confpass
        '
        Me.txt_confpass.Location = New System.Drawing.Point(217, 139)
        Me.txt_confpass.MaxLength = 49
        Me.txt_confpass.Name = "txt_confpass"
        Me.txt_confpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confpass.Size = New System.Drawing.Size(170, 20)
        Me.txt_confpass.TabIndex = 4
        Me.txt_confpass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(217, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Confirm password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_domain
        '
        Me.lbl_domain.AutoSize = True
        Me.lbl_domain.Location = New System.Drawing.Point(218, 161)
        Me.lbl_domain.Name = "lbl_domain"
        Me.lbl_domain.Size = New System.Drawing.Size(95, 13)
        Me.lbl_domain.TabIndex = 32
        Me.lbl_domain.Text = "New domain name"
        '
        'txt_domain
        '
        Me.txt_domain.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_domain.Location = New System.Drawing.Point(217, 177)
        Me.txt_domain.MaxLength = 49
        Me.txt_domain.Name = "txt_domain"
        Me.txt_domain.Size = New System.Drawing.Size(171, 20)
        Me.txt_domain.TabIndex = 5
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.StocksKVK.My.Resources.Resources.Logo_KVK_190x190
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(190, 190)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 20
        Me.LogoPictureBox.TabStop = False
        '
        'frm_login_newuser
        '
        Me.AcceptButton = Me.cmd_create
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(399, 252)
        Me.Controls.Add(Me.txt_domain)
        Me.Controls.Add(Me.lbl_domain)
        Me.Controls.Add(Me.txt_confpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_domain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_create)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(415, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(415, 290)
        Me.Name = "frm_login_newuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New User"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_domain As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_create As System.Windows.Forms.Button
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents txt_confpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_domain As System.Windows.Forms.Label
    Friend WithEvents txt_domain As System.Windows.Forms.TextBox
End Class
