<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowByOfficer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowByOfficer))
        Me.btnPreviewReport = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdiBorrowQualityAll = New System.Windows.Forms.RadioButton
        Me.rdiBorrowQualityTransfer = New System.Windows.Forms.RadioButton
        Me.rdiBorrowQualityBorrow = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDateTo = New DIP.txtDate
        Me.txtDateFrom = New DIP.txtDate
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOfficerID = New System.Windows.Forms.TextBox
        Me.btnSearchUser = New System.Windows.Forms.Button
        Me.txtOfficerName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreviewReport
        '
        Me.btnPreviewReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPreviewReport.Location = New System.Drawing.Point(422, 324)
        Me.btnPreviewReport.Name = "btnPreviewReport"
        Me.btnPreviewReport.Size = New System.Drawing.Size(148, 45)
        Me.btnPreviewReport.TabIndex = 19
        Me.btnPreviewReport.Text = "Preview  Report"
        Me.btnPreviewReport.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdiBorrowQualityAll)
        Me.Panel1.Controls.Add(Me.rdiBorrowQualityTransfer)
        Me.Panel1.Controls.Add(Me.rdiBorrowQualityBorrow)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDateTo)
        Me.Panel1.Controls.Add(Me.txtDateFrom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtOfficerID)
        Me.Panel1.Controls.Add(Me.btnSearchUser)
        Me.Panel1.Controls.Add(Me.txtOfficerName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(85, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 144)
        Me.Panel1.TabIndex = 21
        '
        'rdiBorrowQualityAll
        '
        Me.rdiBorrowQualityAll.AutoSize = True
        Me.rdiBorrowQualityAll.Checked = True
        Me.rdiBorrowQualityAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiBorrowQualityAll.Location = New System.Drawing.Point(361, 112)
        Me.rdiBorrowQualityAll.Name = "rdiBorrowQualityAll"
        Me.rdiBorrowQualityAll.Size = New System.Drawing.Size(44, 20)
        Me.rdiBorrowQualityAll.TabIndex = 32
        Me.rdiBorrowQualityAll.TabStop = True
        Me.rdiBorrowQualityAll.Text = "All"
        Me.rdiBorrowQualityAll.UseVisualStyleBackColor = True
        '
        'rdiBorrowQualityTransfer
        '
        Me.rdiBorrowQualityTransfer.AutoSize = True
        Me.rdiBorrowQualityTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiBorrowQualityTransfer.Location = New System.Drawing.Point(252, 112)
        Me.rdiBorrowQualityTransfer.Name = "rdiBorrowQualityTransfer"
        Me.rdiBorrowQualityTransfer.Size = New System.Drawing.Size(84, 20)
        Me.rdiBorrowQualityTransfer.TabIndex = 31
        Me.rdiBorrowQualityTransfer.Text = "Transfer"
        Me.rdiBorrowQualityTransfer.UseVisualStyleBackColor = True
        '
        'rdiBorrowQualityBorrow
        '
        Me.rdiBorrowQualityBorrow.AutoSize = True
        Me.rdiBorrowQualityBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiBorrowQualityBorrow.Location = New System.Drawing.Point(149, 110)
        Me.rdiBorrowQualityBorrow.Name = "rdiBorrowQualityBorrow"
        Me.rdiBorrowQualityBorrow.Size = New System.Drawing.Size(67, 20)
        Me.rdiBorrowQualityBorrow.TabIndex = 30
        Me.rdiBorrowQualityBorrow.Text = "Room"
        Me.rdiBorrowQualityBorrow.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Quality  :"
        '
        'txtDateTo
        '
        Me.txtDateTo.DateValue = New Date(CType(0, Long))
        Me.txtDateTo.Location = New System.Drawing.Point(309, 66)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(118, 26)
        Me.txtDateTo.TabIndex = 28
        '
        'txtDateFrom
        '
        Me.txtDateFrom.DateValue = New Date(CType(0, Long))
        Me.txtDateFrom.Location = New System.Drawing.Point(149, 67)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(124, 26)
        Me.txtDateFrom.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "To :"
        '
        'txtOfficerID
        '
        Me.txtOfficerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOfficerID.Location = New System.Drawing.Point(149, 0)
        Me.txtOfficerID.Name = "txtOfficerID"
        Me.txtOfficerID.Size = New System.Drawing.Size(31, 26)
        Me.txtOfficerID.TabIndex = 25
        Me.txtOfficerID.Visible = False
        '
        'btnSearchUser
        '
        Me.btnSearchUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearchUser.Location = New System.Drawing.Point(394, 26)
        Me.btnSearchUser.Name = "btnSearchUser"
        Me.btnSearchUser.Size = New System.Drawing.Size(34, 26)
        Me.btnSearchUser.TabIndex = 24
        Me.btnSearchUser.Text = "..."
        Me.btnSearchUser.UseVisualStyleBackColor = True
        '
        'txtOfficerName
        '
        Me.txtOfficerName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOfficerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOfficerName.Location = New System.Drawing.Point(149, 26)
        Me.txtOfficerName.Name = "txtOfficerName"
        Me.txtOfficerName.ReadOnly = True
        Me.txtOfficerName.Size = New System.Drawing.Size(235, 26)
        Me.txtOfficerName.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "User Name :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(610, 40)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "Report Applicant check out (individual)"
        '
        'frmBorrowByOfficer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 404)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPreviewReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBorrowByOfficer"
        Me.Text = "Report application check out (individual)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPreviewReport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDateFrom As DIP.txtDate
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOfficerID As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchUser As System.Windows.Forms.Button
    Friend WithEvents txtOfficerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As DIP.txtDate
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdiBorrowQualityAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdiBorrowQualityTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents rdiBorrowQualityBorrow As System.Windows.Forms.RadioButton
End Class
