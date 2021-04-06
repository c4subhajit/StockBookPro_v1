<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_KVKSB_NCI_N
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_KVKSB_NCI_N))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_nci = New System.Windows.Forms.TextBox
        Me.txt_unit = New System.Windows.Forms.TextBox
        Me.cmd_create = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of critical input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unit"
        '
        'txt_nci
        '
        Me.txt_nci.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nci.Location = New System.Drawing.Point(125, 20)
        Me.txt_nci.MaxLength = 50
        Me.txt_nci.Name = "txt_nci"
        Me.txt_nci.Size = New System.Drawing.Size(200, 20)
        Me.txt_nci.TabIndex = 1
        '
        'txt_unit
        '
        Me.txt_unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_unit.Location = New System.Drawing.Point(125, 58)
        Me.txt_unit.MaxLength = 20
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.Size = New System.Drawing.Size(124, 20)
        Me.txt_unit.TabIndex = 2
        '
        'cmd_create
        '
        Me.cmd_create.Location = New System.Drawing.Point(55, 95)
        Me.cmd_create.Name = "cmd_create"
        Me.cmd_create.Size = New System.Drawing.Size(75, 23)
        Me.cmd_create.TabIndex = 3
        Me.cmd_create.Text = "&Create"
        Me.cmd_create.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(136, 95)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 4
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(217, 95)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 5
        Me.cmd_cancel.Text = "Ca&ncel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'frm_KVKSB_NCI_N
        '
        Me.AcceptButton = Me.cmd_create
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(344, 127)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_create)
        Me.Controls.Add(Me.txt_unit)
        Me.Controls.Add(Me.txt_nci)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 165)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 165)
        Me.Name = "frm_KVKSB_NCI_N"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Create New Critical Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nci As System.Windows.Forms.TextBox
    Friend WithEvents txt_unit As System.Windows.Forms.TextBox
    Friend WithEvents cmd_create As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
End Class
