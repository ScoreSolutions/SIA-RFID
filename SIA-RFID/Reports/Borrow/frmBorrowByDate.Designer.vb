﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowByDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowByDate))
        Me.btnPreviewReport = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rdiStatusAll = New System.Windows.Forms.RadioButton
        Me.rdiStatusReturn = New System.Windows.Forms.RadioButton
        Me.rdiStatusNoReturn = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdiBorrowQualityBorrow = New System.Windows.Forms.RadioButton
        Me.rdiBorrowQualityTransfer = New System.Windows.Forms.RadioButton
        Me.rdiBorrowQualityAll = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtDate2 = New DIP.txtDate
        Me.TxtDate1 = New DIP.txtDate
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreviewReport
        '
        Me.btnPreviewReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPreviewReport.Location = New System.Drawing.Point(425, 329)
        Me.btnPreviewReport.Name = "btnPreviewReport"
        Me.btnPreviewReport.Size = New System.Drawing.Size(152, 34)
        Me.btnPreviewReport.TabIndex = 19
        Me.btnPreviewReport.Text = "Preview Report"
        Me.btnPreviewReport.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(613, 40)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = " Report Check out the Daily"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "To :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtDate2)
        Me.Panel1.Controls.Add(Me.TxtDate1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(85, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 144)
        Me.Panel1.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdiStatusAll)
        Me.Panel3.Controls.Add(Me.rdiStatusReturn)
        Me.Panel3.Controls.Add(Me.rdiStatusNoReturn)
        Me.Panel3.Location = New System.Drawing.Point(146, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 28)
        Me.Panel3.TabIndex = 26
        '
        'rdiStatusAll
        '
        Me.rdiStatusAll.AutoSize = True
        Me.rdiStatusAll.Checked = True
        Me.rdiStatusAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiStatusAll.Location = New System.Drawing.Point(219, 3)
        Me.rdiStatusAll.Name = "rdiStatusAll"
        Me.rdiStatusAll.Size = New System.Drawing.Size(44, 20)
        Me.rdiStatusAll.TabIndex = 40
        Me.rdiStatusAll.TabStop = True
        Me.rdiStatusAll.Text = "All"
        Me.rdiStatusAll.UseVisualStyleBackColor = True
        '
        'rdiStatusReturn
        '
        Me.rdiStatusReturn.AutoSize = True
        Me.rdiStatusReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiStatusReturn.Location = New System.Drawing.Point(10, 3)
        Me.rdiStatusReturn.Name = "rdiStatusReturn"
        Me.rdiStatusReturn.Size = New System.Drawing.Size(85, 20)
        Me.rdiStatusReturn.TabIndex = 38
        Me.rdiStatusReturn.Text = "Check in"
        Me.rdiStatusReturn.UseVisualStyleBackColor = True
        '
        'rdiStatusNoReturn
        '
        Me.rdiStatusNoReturn.AutoSize = True
        Me.rdiStatusNoReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiStatusNoReturn.Location = New System.Drawing.Point(110, 3)
        Me.rdiStatusNoReturn.Name = "rdiStatusNoReturn"
        Me.rdiStatusNoReturn.Size = New System.Drawing.Size(109, 20)
        Me.rdiStatusNoReturn.TabIndex = 39
        Me.rdiStatusNoReturn.Text = "No Check in"
        Me.rdiStatusNoReturn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdiBorrowQualityBorrow)
        Me.Panel2.Controls.Add(Me.rdiBorrowQualityTransfer)
        Me.Panel2.Controls.Add(Me.rdiBorrowQualityAll)
        Me.Panel2.Location = New System.Drawing.Point(146, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 28)
        Me.Panel2.TabIndex = 25
        '
        'rdiBorrowQualityBorrow
        '
        Me.rdiBorrowQualityBorrow.AutoSize = True
        Me.rdiBorrowQualityBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiBorrowQualityBorrow.Location = New System.Drawing.Point(10, 3)
        Me.rdiBorrowQualityBorrow.Name = "rdiBorrowQualityBorrow"
        Me.rdiBorrowQualityBorrow.Size = New System.Drawing.Size(67, 20)
        Me.rdiBorrowQualityBorrow.TabIndex = 34
        Me.rdiBorrowQualityBorrow.Text = "Room"
        Me.rdiBorrowQualityBorrow.UseVisualStyleBackColor = True
        '
        'rdiBorrowQualityTransfer
        '
        Me.rdiBorrowQualityTransfer.AutoSize = True
        Me.rdiBorrowQualityTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiBorrowQualityTransfer.Location = New System.Drawing.Point(110, 3)
        Me.rdiBorrowQualityTransfer.Name = "rdiBorrowQualityTransfer"
        Me.rdiBorrowQualityTransfer.Size = New System.Drawing.Size(84, 20)
        Me.rdiBorrowQualityTransfer.TabIndex = 35
        Me.rdiBorrowQualityTransfer.Text = "Transfer"
        Me.rdiBorrowQualityTransfer.UseVisualStyleBackColor = True
        '
        'rdiBorrowQualityAll
        '
        Me.rdiBorrowQualityAll.AutoSize = True
        Me.rdiBorrowQualityAll.Checked = True
        Me.rdiBorrowQualityAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdiBorrowQualityAll.Location = New System.Drawing.Point(219, 3)
        Me.rdiBorrowQualityAll.Name = "rdiBorrowQualityAll"
        Me.rdiBorrowQualityAll.Size = New System.Drawing.Size(44, 20)
        Me.rdiBorrowQualityAll.TabIndex = 36
        Me.rdiBorrowQualityAll.TabStop = True
        Me.rdiBorrowQualityAll.Text = "All"
        Me.rdiBorrowQualityAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Status :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Quality  :"
        '
        'TxtDate2
        '
        Me.TxtDate2.DateValue = New Date(CType(0, Long))
        Me.TxtDate2.Location = New System.Drawing.Point(314, 29)
        Me.TxtDate2.Name = "TxtDate2"
        Me.TxtDate2.Size = New System.Drawing.Size(118, 26)
        Me.TxtDate2.TabIndex = 28
        '
        'TxtDate1
        '
        Me.TxtDate1.DateValue = New Date(CType(0, Long))
        Me.TxtDate1.Location = New System.Drawing.Point(146, 29)
        Me.TxtDate1.Name = "TxtDate1"
        Me.TxtDate1.Size = New System.Drawing.Size(118, 26)
        Me.TxtDate1.TabIndex = 27
        '
        'frmBorrowByDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 397)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnPreviewReport)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBorrowByDate"
        Me.Text = " Report Check out the Daily"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPreviewReport As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtDate2 As DIP.txtDate
    Friend WithEvents TxtDate1 As DIP.txtDate
    Friend WithEvents rdiBorrowQualityAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdiBorrowQualityTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents rdiBorrowQualityBorrow As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdiStatusAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdiStatusNoReturn As System.Windows.Forms.RadioButton
    Friend WithEvents rdiStatusReturn As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
