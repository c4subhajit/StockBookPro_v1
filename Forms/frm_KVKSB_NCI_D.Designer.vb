<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_KVKSB_NCI_D
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_KVKSB_NCI_D))
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_delete = New System.Windows.Forms.Button
        Me.txt_unit = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_ci = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(182, 91)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 3
        Me.cmd_cancel.Text = "Ca&ncel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_delete
        '
        Me.cmd_delete.Location = New System.Drawing.Point(81, 91)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(75, 23)
        Me.cmd_delete.TabIndex = 2
        Me.cmd_delete.Text = "&Delete"
        Me.cmd_delete.UseVisualStyleBackColor = True
        '
        'txt_unit
        '
        Me.txt_unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_unit.Location = New System.Drawing.Point(126, 55)
        Me.txt_unit.MaxLength = 20
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.ReadOnly = True
        Me.txt_unit.Size = New System.Drawing.Size(124, 20)
        Me.txt_unit.TabIndex = 9
        Me.txt_unit.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name of critical input"
        '
        'cmb_ci
        '
        Me.cmb_ci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ci.FormattingEnabled = True
        Me.cmb_ci.Items.AddRange(New Object() {""})
        Me.cmb_ci.Location = New System.Drawing.Point(126, 17)
        Me.cmb_ci.Name = "cmb_ci"
        Me.cmb_ci.Size = New System.Drawing.Size(194, 21)
        Me.cmb_ci.TabIndex = 1
        '
        'frm_KVKSB_NCI_D
        '
        Me.AcceptButton = Me.cmd_delete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(344, 127)
        Me.Controls.Add(Me.cmb_ci)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.txt_unit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 165)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 165)
        Me.Name = "frm_KVKSB_NCI_D"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Delete Critical Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents txt_unit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_ci As System.Windows.Forms.ComboBox
End Class
