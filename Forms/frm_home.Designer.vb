<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_home))
        Me.Timer_Home = New System.Windows.Forms.Timer(Me.components)
        Me.FBD_dbBackUp = New System.Windows.Forms.FolderBrowserDialog
        Me.ContextMenuStrip_home = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMI_CAL = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_NOTE = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_LOGOUT = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip_home = New System.Windows.Forms.StatusStrip
        Me.TSSL_homeClock = New System.Windows.Forms.ToolStripStatusLabel
        Me.OFD_db = New System.Windows.Forms.OpenFileDialog
        Me.MenuStrip_home = New System.Windows.Forms.MenuStrip
        Me.START_TSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_CI = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_NCI_N = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_NCI_D = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_SD = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_SD_SDU = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_SD_SDE = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_SD_SDD = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_KVKSB_STAT = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_CS = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_TRANS = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_DB = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_DB_BDB = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_UA = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_UA_CP = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_UA_NUA = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_UA_DUA = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_UA_DD = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ABT = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_LO = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_EXIT = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ST_DB_RDB = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip_home.SuspendLayout()
        Me.StatusStrip_home.SuspendLayout()
        Me.MenuStrip_home.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_Home
        '
        Me.Timer_Home.Enabled = True
        Me.Timer_Home.Interval = 1000
        '
        'FBD_dbBackUp
        '
        Me.FBD_dbBackUp.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'ContextMenuStrip_home
        '
        Me.ContextMenuStrip_home.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_CAL, Me.TSMI_NOTE, Me.TSMI_LOGOUT})
        Me.ContextMenuStrip_home.Name = "ContextMenuStrip_home"
        Me.ContextMenuStrip_home.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip_home.Size = New System.Drawing.Size(129, 70)
        '
        'TSMI_CAL
        '
        Me.TSMI_CAL.Name = "TSMI_CAL"
        Me.TSMI_CAL.Size = New System.Drawing.Size(128, 22)
        Me.TSMI_CAL.Text = "&Calculator"
        '
        'TSMI_NOTE
        '
        Me.TSMI_NOTE.Name = "TSMI_NOTE"
        Me.TSMI_NOTE.Size = New System.Drawing.Size(128, 22)
        Me.TSMI_NOTE.Text = "&Notepad"
        '
        'TSMI_LOGOUT
        '
        Me.TSMI_LOGOUT.Name = "TSMI_LOGOUT"
        Me.TSMI_LOGOUT.Size = New System.Drawing.Size(128, 22)
        Me.TSMI_LOGOUT.Text = "&Logout"
        '
        'StatusStrip_home
        '
        Me.StatusStrip_home.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip_home.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_homeClock})
        Me.StatusStrip_home.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip_home.Name = "StatusStrip_home"
        Me.StatusStrip_home.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip_home.TabIndex = 5
        '
        'TSSL_homeClock
        '
        Me.TSSL_homeClock.AutoSize = False
        Me.TSSL_homeClock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_homeClock.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TSSL_homeClock.Name = "TSSL_homeClock"
        Me.TSSL_homeClock.Size = New System.Drawing.Size(191, 17)
        '
        'MenuStrip_home
        '
        Me.MenuStrip_home.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip_home.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.START_TSMI})
        Me.MenuStrip_home.Location = New System.Drawing.Point(0, 637)
        Me.MenuStrip_home.Name = "MenuStrip_home"
        Me.MenuStrip_home.Size = New System.Drawing.Size(984, 25)
        Me.MenuStrip_home.TabIndex = 7
        Me.MenuStrip_home.Text = "MenuStrip_home"
        '
        'START_TSMI
        '
        Me.START_TSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_KVKSB, Me.TSMI_CS, Me.TSMI_TRANS, Me.TSMI_ST, Me.TSMI_ABT, Me.TSMI_LO, Me.TSMI_EXIT})
        Me.START_TSMI.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.START_TSMI.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.START_TSMI.Name = "START_TSMI"
        Me.START_TSMI.Size = New System.Drawing.Size(60, 21)
        Me.START_TSMI.Text = "&START"
        '
        'TSMI_KVKSB
        '
        Me.TSMI_KVKSB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_KVKSB_CI, Me.TSMI_KVKSB_SD, Me.TSMI_KVKSB_STAT})
        Me.TSMI_KVKSB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMI_KVKSB.Name = "TSMI_KVKSB"
        Me.TSMI_KVKSB.Size = New System.Drawing.Size(155, 22)
        Me.TSMI_KVKSB.Text = "&KVK Stockbook"
        '
        'TSMI_KVKSB_CI
        '
        Me.TSMI_KVKSB_CI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_KVKSB_NCI_N, Me.TSMI_KVKSB_NCI_D})
        Me.TSMI_KVKSB_CI.Name = "TSMI_KVKSB_CI"
        Me.TSMI_KVKSB_CI.Size = New System.Drawing.Size(187, 22)
        Me.TSMI_KVKSB_CI.Text = "Critical Input"
        '
        'TSMI_KVKSB_NCI_N
        '
        Me.TSMI_KVKSB_NCI_N.Name = "TSMI_KVKSB_NCI_N"
        Me.TSMI_KVKSB_NCI_N.Size = New System.Drawing.Size(178, 22)
        Me.TSMI_KVKSB_NCI_N.Text = "&New Critical Input"
        '
        'TSMI_KVKSB_NCI_D
        '
        Me.TSMI_KVKSB_NCI_D.Name = "TSMI_KVKSB_NCI_D"
        Me.TSMI_KVKSB_NCI_D.Size = New System.Drawing.Size(178, 22)
        Me.TSMI_KVKSB_NCI_D.Text = "&Delete Critical Input"
        '
        'TSMI_KVKSB_SD
        '
        Me.TSMI_KVKSB_SD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_KVKSB_SD_SDU, Me.TSMI_KVKSB_SD_SDE, Me.TSMI_KVKSB_SD_SDD})
        Me.TSMI_KVKSB_SD.Name = "TSMI_KVKSB_SD"
        Me.TSMI_KVKSB_SD.Size = New System.Drawing.Size(187, 22)
        Me.TSMI_KVKSB_SD.Text = "Stock Details"
        '
        'TSMI_KVKSB_SD_SDU
        '
        Me.TSMI_KVKSB_SD_SDU.Name = "TSMI_KVKSB_SD_SDU"
        Me.TSMI_KVKSB_SD_SDU.Size = New System.Drawing.Size(177, 22)
        Me.TSMI_KVKSB_SD_SDU.Text = "Stock Detail &Update"
        '
        'TSMI_KVKSB_SD_SDE
        '
        Me.TSMI_KVKSB_SD_SDE.Name = "TSMI_KVKSB_SD_SDE"
        Me.TSMI_KVKSB_SD_SDE.Size = New System.Drawing.Size(177, 22)
        Me.TSMI_KVKSB_SD_SDE.Text = "Stock Detail &Edit"
        '
        'TSMI_KVKSB_SD_SDD
        '
        Me.TSMI_KVKSB_SD_SDD.Name = "TSMI_KVKSB_SD_SDD"
        Me.TSMI_KVKSB_SD_SDD.Size = New System.Drawing.Size(177, 22)
        Me.TSMI_KVKSB_SD_SDD.Text = "Stock Detail &Delete"
        '
        'TSMI_KVKSB_STAT
        '
        Me.TSMI_KVKSB_STAT.Name = "TSMI_KVKSB_STAT"
        Me.TSMI_KVKSB_STAT.Size = New System.Drawing.Size(187, 22)
        Me.TSMI_KVKSB_STAT.Text = "Stockbook Statement"
        '
        'TSMI_CS
        '
        Me.TSMI_CS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMI_CS.Name = "TSMI_CS"
        Me.TSMI_CS.Size = New System.Drawing.Size(155, 22)
        Me.TSMI_CS.Text = "&Current Status"
        '
        'TSMI_TRANS
        '
        Me.TSMI_TRANS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSMI_TRANS.Name = "TSMI_TRANS"
        Me.TSMI_TRANS.Size = New System.Drawing.Size(155, 22)
        Me.TSMI_TRANS.Text = "&Transactions"
        '
        'TSMI_ST
        '
        Me.TSMI_ST.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_ST_DB, Me.TSMI_ST_UA})
        Me.TSMI_ST.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMI_ST.Name = "TSMI_ST"
        Me.TSMI_ST.Size = New System.Drawing.Size(155, 22)
        Me.TSMI_ST.Text = "&System Tools"
        '
        'TSMI_ST_DB
        '
        Me.TSMI_ST_DB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_ST_DB_BDB, Me.TSMI_ST_DB_RDB})
        Me.TSMI_ST_DB.Name = "TSMI_ST_DB"
        Me.TSMI_ST_DB.Size = New System.Drawing.Size(177, 22)
        Me.TSMI_ST_DB.Text = "&Database Tasks"
        '
        'TSMI_ST_DB_BDB
        '
        Me.TSMI_ST_DB_BDB.Name = "TSMI_ST_DB_BDB"
        Me.TSMI_ST_DB_BDB.Size = New System.Drawing.Size(164, 22)
        Me.TSMI_ST_DB_BDB.Text = "&Backup Database"
        '
        'TSMI_ST_UA
        '
        Me.TSMI_ST_UA.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_ST_UA_CP, Me.TSMI_ST_UA_NUA, Me.TSMI_ST_UA_DUA, Me.TSMI_ST_UA_DD})
        Me.TSMI_ST_UA.Name = "TSMI_ST_UA"
        Me.TSMI_ST_UA.Size = New System.Drawing.Size(177, 22)
        Me.TSMI_ST_UA.Text = "&User Accounts Task"
        '
        'TSMI_ST_UA_CP
        '
        Me.TSMI_ST_UA_CP.Name = "TSMI_ST_UA_CP"
        Me.TSMI_ST_UA_CP.Size = New System.Drawing.Size(181, 22)
        Me.TSMI_ST_UA_CP.Text = "&Change Password"
        '
        'TSMI_ST_UA_NUA
        '
        Me.TSMI_ST_UA_NUA.Name = "TSMI_ST_UA_NUA"
        Me.TSMI_ST_UA_NUA.Size = New System.Drawing.Size(181, 22)
        Me.TSMI_ST_UA_NUA.Text = "&New User Account"
        '
        'TSMI_ST_UA_DUA
        '
        Me.TSMI_ST_UA_DUA.Name = "TSMI_ST_UA_DUA"
        Me.TSMI_ST_UA_DUA.Size = New System.Drawing.Size(181, 22)
        Me.TSMI_ST_UA_DUA.Text = "&Delete User Account"
        '
        'TSMI_ST_UA_DD
        '
        Me.TSMI_ST_UA_DD.Name = "TSMI_ST_UA_DD"
        Me.TSMI_ST_UA_DD.Size = New System.Drawing.Size(181, 22)
        Me.TSMI_ST_UA_DD.Text = "Delete Domain"
        '
        'TSMI_ABT
        '
        Me.TSMI_ABT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSMI_ABT.Name = "TSMI_ABT"
        Me.TSMI_ABT.Size = New System.Drawing.Size(155, 22)
        Me.TSMI_ABT.Text = "&About"
        '
        'TSMI_LO
        '
        Me.TSMI_LO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSMI_LO.Name = "TSMI_LO"
        Me.TSMI_LO.Size = New System.Drawing.Size(155, 22)
        Me.TSMI_LO.Text = "&Logout"
        '
        'TSMI_EXIT
        '
        Me.TSMI_EXIT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSMI_EXIT.Name = "TSMI_EXIT"
        Me.TSMI_EXIT.Size = New System.Drawing.Size(155, 22)
        Me.TSMI_EXIT.Text = "&Exit"
        '
        'TSMI_ST_DB_RDB
        '
        Me.TSMI_ST_DB_RDB.Name = "TSMI_ST_DB_RDB"
        Me.TSMI_ST_DB_RDB.Size = New System.Drawing.Size(164, 22)
        Me.TSMI_ST_DB_RDB.Text = "&Restore Database"
        '
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StocksKVK.My.Resources.Resources.Logo_KVK
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.ContextMenuStrip = Me.ContextMenuStrip_home
        Me.Controls.Add(Me.MenuStrip_home)
        Me.Controls.Add(Me.StatusStrip_home)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip_home
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "frm_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stockbook Pro v1.0"
        Me.ContextMenuStrip_home.ResumeLayout(False)
        Me.StatusStrip_home.ResumeLayout(False)
        Me.StatusStrip_home.PerformLayout()
        Me.MenuStrip_home.ResumeLayout(False)
        Me.MenuStrip_home.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_Home As System.Windows.Forms.Timer
    Friend WithEvents FBD_dbBackUp As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ContextMenuStrip_home As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TSMI_CAL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_NOTE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_LOGOUT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip_home As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSL_homeClock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OFD_db As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip_home As System.Windows.Forms.MenuStrip
    Friend WithEvents START_TSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_CI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_NCI_N As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_NCI_D As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_SD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_SD_SDU As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_SD_SDE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_SD_SDD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_KVKSB_STAT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_CS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_TRANS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_DB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_DB_BDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_UA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_UA_CP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_UA_NUA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_UA_DUA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_UA_DD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ABT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_LO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_EXIT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_ST_DB_RDB As System.Windows.Forms.ToolStripMenuItem
End Class
