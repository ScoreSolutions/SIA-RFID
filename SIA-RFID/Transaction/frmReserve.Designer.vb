<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReserve))
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.PictureReserve = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdiBlankAll = New System.Windows.Forms.RadioButton
        Me.txtJobNo = New System.Windows.Forms.TextBox
        Me.rdiNoBlank = New System.Windows.Forms.RadioButton
        Me.rdiBlank = New System.Windows.Forms.RadioButton
        Me.txtOfficerID = New System.Windows.Forms.TextBox
        Me.txtDateTo = New DIP.txtDate
        Me.txtDateFrom = New DIP.txtDate
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtReqNoTo = New System.Windows.Forms.TextBox
        Me.txtReqNoFrom = New System.Windows.Forms.TextBox
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CLBType = New System.Windows.Forms.CheckedListBox
        CType(Me.PictureReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        resources.ApplyResources(Me.BtnSearch, "BtnSearch")
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'PictureReserve
        '
        resources.ApplyResources(Me.PictureReserve, "PictureReserve")
        Me.PictureReserve.Name = "PictureReserve"
        Me.PictureReserve.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdiBlankAll)
        Me.Panel1.Controls.Add(Me.txtJobNo)
        Me.Panel1.Controls.Add(Me.rdiNoBlank)
        Me.Panel1.Controls.Add(Me.rdiBlank)
        Me.Panel1.Controls.Add(Me.txtOfficerID)
        Me.Panel1.Controls.Add(Me.txtDateTo)
        Me.Panel1.Controls.Add(Me.txtDateFrom)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtReqNoTo)
        Me.Panel1.Controls.Add(Me.txtReqNoFrom)
        Me.Panel1.Controls.Add(Me.txtMemberName)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'rdiBlankAll
        '
        resources.ApplyResources(Me.rdiBlankAll, "rdiBlankAll")
        Me.rdiBlankAll.BackColor = System.Drawing.Color.Transparent
        Me.rdiBlankAll.Checked = True
        Me.rdiBlankAll.Name = "rdiBlankAll"
        Me.rdiBlankAll.TabStop = True
        Me.rdiBlankAll.UseVisualStyleBackColor = False
        '
        'txtJobNo
        '
        resources.ApplyResources(Me.txtJobNo, "txtJobNo")
        Me.txtJobNo.Name = "txtJobNo"
        '
        'rdiNoBlank
        '
        resources.ApplyResources(Me.rdiNoBlank, "rdiNoBlank")
        Me.rdiNoBlank.BackColor = System.Drawing.Color.Transparent
        Me.rdiNoBlank.Name = "rdiNoBlank"
        Me.rdiNoBlank.UseVisualStyleBackColor = False
        '
        'rdiBlank
        '
        resources.ApplyResources(Me.rdiBlank, "rdiBlank")
        Me.rdiBlank.BackColor = System.Drawing.Color.Transparent
        Me.rdiBlank.Name = "rdiBlank"
        Me.rdiBlank.UseVisualStyleBackColor = False
        '
        'txtOfficerID
        '
        resources.ApplyResources(Me.txtOfficerID, "txtOfficerID")
        Me.txtOfficerID.Name = "txtOfficerID"
        '
        'txtDateTo
        '
        Me.txtDateTo.DateValue = New Date(CType(0, Long))
        resources.ApplyResources(Me.txtDateTo, "txtDateTo")
        Me.txtDateTo.Name = "txtDateTo"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.DateValue = New Date(CType(0, Long))
        resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
        Me.txtDateFrom.Name = "txtDateFrom"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtReqNoTo
        '
        resources.ApplyResources(Me.txtReqNoTo, "txtReqNoTo")
        Me.txtReqNoTo.Name = "txtReqNoTo"
        '
        'txtReqNoFrom
        '
        resources.ApplyResources(Me.txtReqNoFrom, "txtReqNoFrom")
        Me.txtReqNoFrom.Name = "txtReqNoFrom"
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtMemberName, "txtMemberName")
        Me.txtMemberName.Name = "txtMemberName"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CLBType)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'CLBType
        '
        resources.ApplyResources(Me.CLBType, "CLBType")
        Me.CLBType.CheckOnClick = True
        Me.CLBType.FormattingEnabled = True
        Me.CLBType.Name = "CLBType"
        '
        'frmReserve
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.PictureReserve)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReserve"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureReserve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents PictureReserve As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdiBlankAll As System.Windows.Forms.RadioButton
    Friend WithEvents txtJobNo As System.Windows.Forms.TextBox
    Friend WithEvents rdiNoBlank As System.Windows.Forms.RadioButton
    Friend WithEvents rdiBlank As System.Windows.Forms.RadioButton
    Friend WithEvents txtOfficerID As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As DIP.txtDate
    Friend WithEvents txtDateFrom As DIP.txtDate
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtReqNoTo As System.Windows.Forms.TextBox
    Friend WithEvents txtReqNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CLBType As System.Windows.Forms.CheckedListBox
End Class
