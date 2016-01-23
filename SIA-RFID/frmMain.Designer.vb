<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.tmrCurrDate = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.stsOfficerName = New System.Windows.Forms.ToolStripStatusLabel
        Me.stlOfficerName = New System.Windows.Forms.ToolStripStatusLabel
        Me.stlCurrDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.tmrBGProcess = New System.Windows.Forms.Timer(Me.components)
        Me.tmrChkAlarm = New System.Windows.Forms.Timer(Me.components)
        Me.txtFullUserName = New System.Windows.Forms.TextBox
        Me.txtIdUser = New System.Windows.Forms.TextBox
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip
        Me.pbLogout = New System.Windows.Forms.PictureBox
        Me.txtDocumentEvent = New System.Windows.Forms.TextBox
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(43, 270)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 4
        Me.txtUserName.Visible = False
        '
        'tmrCurrDate
        '
        Me.tmrCurrDate.Enabled = True
        Me.tmrCurrDate.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsOfficerName, Me.stlOfficerName, Me.stlCurrDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 703)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsOfficerName
        '
        Me.stsOfficerName.Name = "stsOfficerName"
        Me.stsOfficerName.Size = New System.Drawing.Size(0, 17)
        '
        'stlOfficerName
        '
        Me.stlOfficerName.Name = "stlOfficerName"
        Me.stlOfficerName.Size = New System.Drawing.Size(30, 17)
        Me.stlOfficerName.Text = "User"
        '
        'stlCurrDate
        '
        Me.stlCurrDate.Name = "stlCurrDate"
        Me.stlCurrDate.Size = New System.Drawing.Size(37, 17)
        Me.stlCurrDate.Text = "Date :"
        '
        'tmrBGProcess
        '
        Me.tmrBGProcess.Enabled = True
        Me.tmrBGProcess.Interval = 60000
        '
        'tmrChkAlarm
        '
        Me.tmrChkAlarm.Enabled = True
        Me.tmrChkAlarm.Interval = 200
        '
        'txtFullUserName
        '
        Me.txtFullUserName.Location = New System.Drawing.Point(188, 270)
        Me.txtFullUserName.Name = "txtFullUserName"
        Me.txtFullUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtFullUserName.TabIndex = 8
        Me.txtFullUserName.Visible = False
        '
        'txtIdUser
        '
        Me.txtIdUser.Location = New System.Drawing.Point(317, 270)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(100, 20)
        Me.txtIdUser.TabIndex = 10
        Me.txtIdUser.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(16, 42)
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 120)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip2.TabIndex = 19
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 96)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip3.TabIndex = 21
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 72)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip4.TabIndex = 22
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'MenuStrip5
        '
        Me.MenuStrip5.Location = New System.Drawing.Point(0, 48)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip5.TabIndex = 23
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Location = New System.Drawing.Point(870, 96)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(435, 48)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Location = New System.Drawing.Point(435, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(436, 48)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(436, 48)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1284, 96)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip6
        '
        Me.MenuStrip6.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip6.Name = "MenuStrip6"
        Me.MenuStrip6.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip6.TabIndex = 26
        Me.MenuStrip6.Text = "MenuStrip6"
        '
        'pbLogout
        '
        Me.pbLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogout.Location = New System.Drawing.Point(1174, 42)
        Me.pbLogout.Name = "pbLogout"
        Me.pbLogout.Size = New System.Drawing.Size(82, 28)
        Me.pbLogout.TabIndex = 28
        Me.pbLogout.TabStop = False
        '
        'txtDocumentEvent
        '
        Me.txtDocumentEvent.Location = New System.Drawing.Point(455, 270)
        Me.txtDocumentEvent.Name = "txtDocumentEvent"
        Me.txtDocumentEvent.Size = New System.Drawing.Size(100, 20)
        Me.txtDocumentEvent.TabIndex = 30
        Me.txtDocumentEvent.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 725)
        Me.Controls.Add(Me.txtDocumentEvent)
        Me.Controls.Add(Me.pbLogout)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtIdUser)
        Me.Controls.Add(Me.txtFullUserName)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.MenuStrip4)
        Me.Controls.Add(Me.MenuStrip5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip6)
        Me.Controls.Add(Me.txtUserName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Document Finder  Version [%_%]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrCurrDate As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsOfficerName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlOfficerName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlCurrDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrBGProcess As System.Windows.Forms.Timer
    Friend WithEvents tmrChkAlarm As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip4 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip5 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip6 As System.Windows.Forms.MenuStrip
    Public WithEvents txtUserName As System.Windows.Forms.TextBox
    Public WithEvents txtFullUserName As System.Windows.Forms.TextBox
    Public WithEvents txtIdUser As System.Windows.Forms.TextBox
    Friend WithEvents pbLogout As System.Windows.Forms.PictureBox
    Public WithEvents txtDocumentEvent As System.Windows.Forms.TextBox
End Class
