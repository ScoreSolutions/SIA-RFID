<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuReport
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
        Me.lblmnuReportsBorrow = New System.Windows.Forms.Label
        Me.lblmnuBorrowByOfficer = New System.Windows.Forms.Label
        Me.lblmnuBorrowByDepartment = New System.Windows.Forms.Label
        Me.lblmnuReportsReturn = New System.Windows.Forms.Label
        Me.lblmnuReturnByOfficer = New System.Windows.Forms.Label
        Me.lblmnuReturnByDepartment = New System.Windows.Forms.Label
        Me.lblmnuReturnByDate = New System.Windows.Forms.Label
        Me.lblmnuStatistics = New System.Windows.Forms.Label
        Me.lblmnuStatisticsBorrow = New System.Windows.Forms.Label
        Me.lblmnuStatisticsReturn = New System.Windows.Forms.Label
        Me.lblmnuStatisticsByOfficer = New System.Windows.Forms.Label
        Me.lblmnuPerform = New System.Windows.Forms.Label
        Me.lblmnuReportsHistory = New System.Windows.Forms.Label
        Me.lblmnuGraph = New System.Windows.Forms.Label
        Me.lblmnuGraphBorrowAll = New System.Windows.Forms.Label
        Me.lblmnuGraghPerform = New System.Windows.Forms.Label
        Me.lblmnuGraphAll = New System.Windows.Forms.Label
        Me.lblmnuGraphBorrowByDepartment = New System.Windows.Forms.Label
        Me.lblmnuGraphBorrowByPatentType = New System.Windows.Forms.Label
        Me.lblmnuGraphByOfficer = New System.Windows.Forms.Label
        Me.lblmnuBorrowByDate = New System.Windows.Forms.Label
        Me.lblmnuBorrowAllOfficer = New System.Windows.Forms.Label
        Me.lblmnuBorrowNoReturn = New System.Windows.Forms.Label
        Me.lblmnuBorrowBetween = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblmnuReportsBorrow
        '
        Me.lblmnuReportsBorrow.AutoSize = True
        Me.lblmnuReportsBorrow.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuReportsBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuReportsBorrow.Location = New System.Drawing.Point(86, 67)
        Me.lblmnuReportsBorrow.Name = "lblmnuReportsBorrow"
        Me.lblmnuReportsBorrow.Size = New System.Drawing.Size(265, 24)
        Me.lblmnuReportsBorrow.TabIndex = 0
        Me.lblmnuReportsBorrow.Text = "Report Check out Applicant"
        '
        'lblmnuBorrowByOfficer
        '
        Me.lblmnuBorrowByOfficer.AutoSize = True
        Me.lblmnuBorrowByOfficer.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuBorrowByOfficer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuBorrowByOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuBorrowByOfficer.Location = New System.Drawing.Point(112, 94)
        Me.lblmnuBorrowByOfficer.Name = "lblmnuBorrowByOfficer"
        Me.lblmnuBorrowByOfficer.Size = New System.Drawing.Size(266, 18)
        Me.lblmnuBorrowByOfficer.TabIndex = 1
        Me.lblmnuBorrowByOfficer.Text = "- Report applicant check out (individual)"
        '
        'lblmnuBorrowByDepartment
        '
        Me.lblmnuBorrowByDepartment.AutoSize = True
        Me.lblmnuBorrowByDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuBorrowByDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuBorrowByDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuBorrowByDepartment.Location = New System.Drawing.Point(112, 117)
        Me.lblmnuBorrowByDepartment.Name = "lblmnuBorrowByDepartment"
        Me.lblmnuBorrowByDepartment.Size = New System.Drawing.Size(281, 18)
        Me.lblmnuBorrowByDepartment.TabIndex = 2
        Me.lblmnuBorrowByDepartment.Text = "- Report applicant check out (department)"
        '
        'lblmnuReportsReturn
        '
        Me.lblmnuReportsReturn.AutoSize = True
        Me.lblmnuReportsReturn.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuReportsReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuReportsReturn.Location = New System.Drawing.Point(86, 238)
        Me.lblmnuReportsReturn.Name = "lblmnuReportsReturn"
        Me.lblmnuReportsReturn.Size = New System.Drawing.Size(253, 24)
        Me.lblmnuReportsReturn.TabIndex = 3
        Me.lblmnuReportsReturn.Text = "Report Check in Applicant"
        '
        'lblmnuReturnByOfficer
        '
        Me.lblmnuReturnByOfficer.AutoSize = True
        Me.lblmnuReturnByOfficer.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuReturnByOfficer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuReturnByOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuReturnByOfficer.Location = New System.Drawing.Point(112, 262)
        Me.lblmnuReturnByOfficer.Name = "lblmnuReturnByOfficer"
        Me.lblmnuReturnByOfficer.Size = New System.Drawing.Size(280, 18)
        Me.lblmnuReturnByOfficer.TabIndex = 4
        Me.lblmnuReturnByOfficer.Text = "- Report applicant of Check in (individual) "
        '
        'lblmnuReturnByDepartment
        '
        Me.lblmnuReturnByDepartment.AutoSize = True
        Me.lblmnuReturnByDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuReturnByDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuReturnByDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuReturnByDepartment.Location = New System.Drawing.Point(112, 285)
        Me.lblmnuReturnByDepartment.Name = "lblmnuReturnByDepartment"
        Me.lblmnuReturnByDepartment.Size = New System.Drawing.Size(295, 18)
        Me.lblmnuReturnByDepartment.TabIndex = 5
        Me.lblmnuReturnByDepartment.Text = "- Report applicant of Check in (department) "
        '
        'lblmnuReturnByDate
        '
        Me.lblmnuReturnByDate.AutoSize = True
        Me.lblmnuReturnByDate.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuReturnByDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuReturnByDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuReturnByDate.Location = New System.Drawing.Point(112, 308)
        Me.lblmnuReturnByDate.Name = "lblmnuReturnByDate"
        Me.lblmnuReturnByDate.Size = New System.Drawing.Size(188, 18)
        Me.lblmnuReturnByDate.TabIndex = 6
        Me.lblmnuReturnByDate.Text = "- Report Check in the Daily "
        '
        'lblmnuStatistics
        '
        Me.lblmnuStatistics.AutoSize = True
        Me.lblmnuStatistics.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuStatistics.Location = New System.Drawing.Point(537, 238)
        Me.lblmnuStatistics.Name = "lblmnuStatistics"
        Me.lblmnuStatistics.Size = New System.Drawing.Size(349, 24)
        Me.lblmnuStatistics.TabIndex = 8
        Me.lblmnuStatistics.Text = "Report Statistic Check out - Check in"
        '
        'lblmnuStatisticsBorrow
        '
        Me.lblmnuStatisticsBorrow.AutoSize = True
        Me.lblmnuStatisticsBorrow.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuStatisticsBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuStatisticsBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuStatisticsBorrow.Location = New System.Drawing.Point(563, 263)
        Me.lblmnuStatisticsBorrow.Name = "lblmnuStatisticsBorrow"
        Me.lblmnuStatisticsBorrow.Size = New System.Drawing.Size(190, 18)
        Me.lblmnuStatisticsBorrow.TabIndex = 9
        Me.lblmnuStatisticsBorrow.Text = "- Report Statistic Check out"
        '
        'lblmnuStatisticsReturn
        '
        Me.lblmnuStatisticsReturn.AutoSize = True
        Me.lblmnuStatisticsReturn.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuStatisticsReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuStatisticsReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuStatisticsReturn.Location = New System.Drawing.Point(563, 285)
        Me.lblmnuStatisticsReturn.Name = "lblmnuStatisticsReturn"
        Me.lblmnuStatisticsReturn.Size = New System.Drawing.Size(180, 18)
        Me.lblmnuStatisticsReturn.TabIndex = 10
        Me.lblmnuStatisticsReturn.Text = "- Report Statistic Check in"
        '
        'lblmnuStatisticsByOfficer
        '
        Me.lblmnuStatisticsByOfficer.AutoSize = True
        Me.lblmnuStatisticsByOfficer.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuStatisticsByOfficer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuStatisticsByOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuStatisticsByOfficer.Location = New System.Drawing.Point(563, 307)
        Me.lblmnuStatisticsByOfficer.Name = "lblmnuStatisticsByOfficer"
        Me.lblmnuStatisticsByOfficer.Size = New System.Drawing.Size(326, 18)
        Me.lblmnuStatisticsByOfficer.TabIndex = 11
        Me.lblmnuStatisticsByOfficer.Text = "- Report history Check out - Check in (individual)"
        '
        'lblmnuPerform
        '
        Me.lblmnuPerform.AutoSize = True
        Me.lblmnuPerform.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuPerform.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuPerform.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblmnuPerform.Location = New System.Drawing.Point(86, 363)
        Me.lblmnuPerform.Name = "lblmnuPerform"
        Me.lblmnuPerform.Size = New System.Drawing.Size(213, 18)
        Me.lblmnuPerform.TabIndex = 12
        Me.lblmnuPerform.Text = "Performance Report of officers"
        '
        'lblmnuReportsHistory
        '
        Me.lblmnuReportsHistory.AutoSize = True
        Me.lblmnuReportsHistory.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuReportsHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuReportsHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblmnuReportsHistory.Location = New System.Drawing.Point(86, 338)
        Me.lblmnuReportsHistory.Name = "lblmnuReportsHistory"
        Me.lblmnuReportsHistory.Size = New System.Drawing.Size(323, 18)
        Me.lblmnuReportsHistory.TabIndex = 13
        Me.lblmnuReportsHistory.Text = "Report history of Check out - Check in applicant"
        '
        'lblmnuGraph
        '
        Me.lblmnuGraph.AutoSize = True
        Me.lblmnuGraph.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuGraph.Location = New System.Drawing.Point(537, 67)
        Me.lblmnuGraph.Name = "lblmnuGraph"
        Me.lblmnuGraph.Size = New System.Drawing.Size(135, 24)
        Me.lblmnuGraph.TabIndex = 14
        Me.lblmnuGraph.Text = "Report Graph"
        '
        'lblmnuGraphBorrowAll
        '
        Me.lblmnuGraphBorrowAll.AutoSize = True
        Me.lblmnuGraphBorrowAll.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuGraphBorrowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuGraphBorrowAll.Location = New System.Drawing.Point(563, 93)
        Me.lblmnuGraphBorrowAll.Name = "lblmnuGraphBorrowAll"
        Me.lblmnuGraphBorrowAll.Size = New System.Drawing.Size(203, 18)
        Me.lblmnuGraphBorrowAll.TabIndex = 15
        Me.lblmnuGraphBorrowAll.Text = "Statistic Check out - Check in"
        '
        'lblmnuGraghPerform
        '
        Me.lblmnuGraghPerform.AutoSize = True
        Me.lblmnuGraghPerform.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuGraghPerform.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuGraghPerform.Location = New System.Drawing.Point(563, 184)
        Me.lblmnuGraghPerform.Name = "lblmnuGraghPerform"
        Me.lblmnuGraghPerform.Size = New System.Drawing.Size(236, 18)
        Me.lblmnuGraghPerform.TabIndex = 16
        Me.lblmnuGraghPerform.Text = "Performance of officer at the room"
        '
        'lblmnuGraphAll
        '
        Me.lblmnuGraphAll.AutoSize = True
        Me.lblmnuGraphAll.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuGraphAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuGraphAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuGraphAll.Location = New System.Drawing.Point(633, 115)
        Me.lblmnuGraphAll.Name = "lblmnuGraphAll"
        Me.lblmnuGraphAll.Size = New System.Drawing.Size(322, 18)
        Me.lblmnuGraphAll.TabIndex = 17
        Me.lblmnuGraphAll.Text = "- Chart lits the Check out - Check in all applicant"
        '
        'lblmnuGraphBorrowByDepartment
        '
        Me.lblmnuGraphBorrowByDepartment.AutoSize = True
        Me.lblmnuGraphBorrowByDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuGraphBorrowByDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuGraphBorrowByDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuGraphBorrowByDepartment.Location = New System.Drawing.Point(633, 136)
        Me.lblmnuGraphBorrowByDepartment.Name = "lblmnuGraphBorrowByDepartment"
        Me.lblmnuGraphBorrowByDepartment.Size = New System.Drawing.Size(382, 18)
        Me.lblmnuGraphBorrowByDepartment.TabIndex = 18
        Me.lblmnuGraphBorrowByDepartment.Text = "- Chart lits the Check out - Check in applicant department"
        '
        'lblmnuGraphBorrowByPatentType
        '
        Me.lblmnuGraphBorrowByPatentType.AutoSize = True
        Me.lblmnuGraphBorrowByPatentType.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuGraphBorrowByPatentType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuGraphBorrowByPatentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuGraphBorrowByPatentType.Location = New System.Drawing.Point(633, 157)
        Me.lblmnuGraphBorrowByPatentType.Name = "lblmnuGraphBorrowByPatentType"
        Me.lblmnuGraphBorrowByPatentType.Size = New System.Drawing.Size(353, 18)
        Me.lblmnuGraphBorrowByPatentType.TabIndex = 19
        Me.lblmnuGraphBorrowByPatentType.Text = "- Chart lits the Check out - Check in Application Type"
        '
        'lblmnuGraphByOfficer
        '
        Me.lblmnuGraphByOfficer.AutoSize = True
        Me.lblmnuGraphByOfficer.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuGraphByOfficer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuGraphByOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuGraphByOfficer.Location = New System.Drawing.Point(633, 205)
        Me.lblmnuGraphByOfficer.Name = "lblmnuGraphByOfficer"
        Me.lblmnuGraphByOfficer.Size = New System.Drawing.Size(359, 18)
        Me.lblmnuGraphByOfficer.TabIndex = 20
        Me.lblmnuGraphByOfficer.Text = "- Chart lits the Check out - Check in Applicant(Officer)"
        '
        'lblmnuBorrowByDate
        '
        Me.lblmnuBorrowByDate.AutoSize = True
        Me.lblmnuBorrowByDate.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuBorrowByDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuBorrowByDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuBorrowByDate.Location = New System.Drawing.Point(112, 139)
        Me.lblmnuBorrowByDate.Name = "lblmnuBorrowByDate"
        Me.lblmnuBorrowByDate.Size = New System.Drawing.Size(194, 18)
        Me.lblmnuBorrowByDate.TabIndex = 21
        Me.lblmnuBorrowByDate.Text = "- Report Check out the Daily"
        '
        'lblmnuBorrowAllOfficer
        '
        Me.lblmnuBorrowAllOfficer.AutoSize = True
        Me.lblmnuBorrowAllOfficer.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuBorrowAllOfficer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuBorrowAllOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuBorrowAllOfficer.Location = New System.Drawing.Point(112, 207)
        Me.lblmnuBorrowAllOfficer.Name = "lblmnuBorrowAllOfficer"
        Me.lblmnuBorrowAllOfficer.Size = New System.Drawing.Size(276, 18)
        Me.lblmnuBorrowAllOfficer.TabIndex = 22
        Me.lblmnuBorrowAllOfficer.Text = "- Report all applicant name of Check out "
        '
        'lblmnuBorrowNoReturn
        '
        Me.lblmnuBorrowNoReturn.AutoSize = True
        Me.lblmnuBorrowNoReturn.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuBorrowNoReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuBorrowNoReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuBorrowNoReturn.Location = New System.Drawing.Point(112, 184)
        Me.lblmnuBorrowNoReturn.Name = "lblmnuBorrowNoReturn"
        Me.lblmnuBorrowNoReturn.Size = New System.Drawing.Size(327, 18)
        Me.lblmnuBorrowNoReturn.TabIndex = 23
        Me.lblmnuBorrowNoReturn.Text = "- Report applicant name of Check out (individual)"
        '
        'lblmnuBorrowBetween
        '
        Me.lblmnuBorrowBetween.AutoSize = True
        Me.lblmnuBorrowBetween.BackColor = System.Drawing.Color.Transparent
        Me.lblmnuBorrowBetween.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmnuBorrowBetween.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmnuBorrowBetween.Location = New System.Drawing.Point(112, 161)
        Me.lblmnuBorrowBetween.Name = "lblmnuBorrowBetween"
        Me.lblmnuBorrowBetween.Size = New System.Drawing.Size(342, 18)
        Me.lblmnuBorrowBetween.TabIndex = 24
        Me.lblmnuBorrowBetween.Text = "- Report applicant name of Check out (department)"
        '
        'frmMenuReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 762)
        Me.Controls.Add(Me.lblmnuBorrowBetween)
        Me.Controls.Add(Me.lblmnuBorrowNoReturn)
        Me.Controls.Add(Me.lblmnuBorrowAllOfficer)
        Me.Controls.Add(Me.lblmnuBorrowByDate)
        Me.Controls.Add(Me.lblmnuGraphByOfficer)
        Me.Controls.Add(Me.lblmnuGraphBorrowByPatentType)
        Me.Controls.Add(Me.lblmnuGraphBorrowByDepartment)
        Me.Controls.Add(Me.lblmnuGraphAll)
        Me.Controls.Add(Me.lblmnuGraghPerform)
        Me.Controls.Add(Me.lblmnuGraphBorrowAll)
        Me.Controls.Add(Me.lblmnuGraph)
        Me.Controls.Add(Me.lblmnuReportsHistory)
        Me.Controls.Add(Me.lblmnuPerform)
        Me.Controls.Add(Me.lblmnuStatisticsByOfficer)
        Me.Controls.Add(Me.lblmnuStatisticsReturn)
        Me.Controls.Add(Me.lblmnuStatisticsBorrow)
        Me.Controls.Add(Me.lblmnuStatistics)
        Me.Controls.Add(Me.lblmnuReturnByDate)
        Me.Controls.Add(Me.lblmnuReturnByDepartment)
        Me.Controls.Add(Me.lblmnuReturnByOfficer)
        Me.Controls.Add(Me.lblmnuReportsReturn)
        Me.Controls.Add(Me.lblmnuBorrowByDepartment)
        Me.Controls.Add(Me.lblmnuBorrowByOfficer)
        Me.Controls.Add(Me.lblmnuReportsBorrow)
        Me.Name = "frmMenuReport"
        Me.Text = "Menu Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmnuReportsBorrow As System.Windows.Forms.Label
    Friend WithEvents lblmnuBorrowByOfficer As System.Windows.Forms.Label
    Friend WithEvents lblmnuBorrowByDepartment As System.Windows.Forms.Label
    Friend WithEvents lblmnuReportsReturn As System.Windows.Forms.Label
    Friend WithEvents lblmnuReturnByOfficer As System.Windows.Forms.Label
    Friend WithEvents lblmnuReturnByDepartment As System.Windows.Forms.Label
    Friend WithEvents lblmnuReturnByDate As System.Windows.Forms.Label
    Friend WithEvents lblmnuStatistics As System.Windows.Forms.Label
    Friend WithEvents lblmnuStatisticsBorrow As System.Windows.Forms.Label
    Friend WithEvents lblmnuStatisticsReturn As System.Windows.Forms.Label
    Friend WithEvents lblmnuStatisticsByOfficer As System.Windows.Forms.Label
    Friend WithEvents lblmnuPerform As System.Windows.Forms.Label
    Friend WithEvents lblmnuReportsHistory As System.Windows.Forms.Label
    Friend WithEvents lblmnuGraph As System.Windows.Forms.Label
    Friend WithEvents lblmnuGraphBorrowAll As System.Windows.Forms.Label
    Friend WithEvents lblmnuGraghPerform As System.Windows.Forms.Label
    Friend WithEvents lblmnuGraphAll As System.Windows.Forms.Label
    Friend WithEvents lblmnuGraphBorrowByDepartment As System.Windows.Forms.Label
    Friend WithEvents lblmnuGraphBorrowByPatentType As System.Windows.Forms.Label
    Friend WithEvents lblmnuGraphByOfficer As System.Windows.Forms.Label
    Friend WithEvents lblmnuBorrowByDate As System.Windows.Forms.Label
    Friend WithEvents lblmnuBorrowAllOfficer As System.Windows.Forms.Label
    Friend WithEvents lblmnuBorrowNoReturn As System.Windows.Forms.Label
    Friend WithEvents lblmnuBorrowBetween As System.Windows.Forms.Label
End Class
