﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnByOfficer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturnByOfficer))
        Me.btnPreviewReport = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDateTo = New DIP.txtDate
        Me.txtDateFrom = New DIP.txtDate
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreviewReport
        '
        Me.btnPreviewReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPreviewReport.Location = New System.Drawing.Point(427, 324)
        Me.btnPreviewReport.Name = "btnPreviewReport"
        Me.btnPreviewReport.Size = New System.Drawing.Size(143, 45)
        Me.btnPreviewReport.TabIndex = 19
        Me.btnPreviewReport.Text = "Preview  Report"
        Me.btnPreviewReport.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtDateTo)
        Me.Panel1.Controls.Add(Me.txtDateFrom)
        Me.Panel1.Location = New System.Drawing.Point(85, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 118)
        Me.Panel1.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSearch.Location = New System.Drawing.Point(377, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 26)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "..."
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.White
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtId.Location = New System.Drawing.Point(220, 1)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(46, 26)
        Me.txtId.TabIndex = 36
        Me.txtId.Visible = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(126, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(245, 26)
        Me.txtName.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "User name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "To :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date :"
        '
        'txtDateTo
        '
        Me.txtDateTo.DateValue = New Date(CType(0, Long))
        Me.txtDateTo.Location = New System.Drawing.Point(295, 66)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(133, 26)
        Me.txtDateTo.TabIndex = 39
        '
        'txtDateFrom
        '
        Me.txtDateFrom.DateValue = New Date(CType(0, Long))
        Me.txtDateFrom.Location = New System.Drawing.Point(126, 66)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(130, 26)
        Me.txtDateFrom.TabIndex = 38
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(609, 40)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "Report Applicant of Check in (individual)"
        '
        'frmReturnByOfficer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 397)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPreviewReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReturnByOfficer"
        Me.Text = "Report Application of Check in (individual)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPreviewReport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As DIP.txtDate
    Friend WithEvents txtDateFrom As DIP.txtDate
End Class
