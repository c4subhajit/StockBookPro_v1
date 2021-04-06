<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_modify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login_modify))
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_save = New System.Windows.Forms.Button
        Me.txt_confirmPass = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.lbl_pass = New System.Windows.Forms.Label
        Me.lbl_user = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_oldPass = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(324, 145)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 5
        Me.cmd_cancel.Text = "&Cancel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(234, 145)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(75, 23)
        Me.cmd_save.TabIndex = 4
        Me.cmd_save.Text = "&Save"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'txt_confirmPass
        '
        Me.txt_confirmPass.Location = New System.Drawing.Point(298, 95)
        Me.txt_confirmPass.MaxLength = 20
        Me.txt_confirmPass.Name = "txt_confirmPass"
        Me.txt_confirmPass.Size = New System.Drawing.Size(115, 20)
        Me.txt_confirmPass.TabIndex = 3
        Me.txt_confirmPass.UseSystemPasswordChar = True
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(298, 56)
        Me.txt_pass.MaxLength = 20
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(115, 20)
        Me.txt_pass.TabIndex = 2
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(205, 98)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(91, 13)
        Me.lbl_pass.TabIndex = 18
        Me.lbl_pass.Text = "Confirm Password"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(218, 59)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(78, 13)
        Me.lbl_user.TabIndex = 17
        Me.lbl_user.Text = "New Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StocksKVK.My.Resources.Resources.Useraccount
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Old Password"
        '
        'txt_oldPass
        '
        Me.txt_oldPass.Location = New System.Drawing.Point(298, 21)
        Me.txt_oldPass.MaxLength = 20
        Me.txt_oldPass.Name = "txt_oldPass"
        Me.txt_oldPass.Size = New System.Drawing.Size(114, 20)
        Me.txt_oldPass.TabIndex = 1
        Me.txt_oldPass.UseSystemPasswordChar = True
        '
        'frm_login_modify
        '
        Me.AcceptButton = Me.cmd_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(424, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_oldPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.txt_confirmPass)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_user)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 224)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(440, 224)
        Me.Name = "frm_login_modify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Login Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents txt_confirmPass As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_oldPass As System.Windows.Forms.TextBox
End Class
