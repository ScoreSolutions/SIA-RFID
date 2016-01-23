Imports DAL.Table

Public Class frmStatisticsReturn

    Private Sub SetPatentType()
        Dim dal As New TbPatentTypeDAL
        Dim dt As DataTable = dal.GetDataList("1=1", "patent_type_name", Nothing)
        Dim dr As DataRow = dt.NewRow
        dr("id") = "0"
        dr("patent_type_name") = "------------------All----------------------"
        If dt.Rows.Count > 0 Then

            dt.Rows.InsertAt(dr, 0)
            cmbPatentType.DataSource = dt
            cmbPatentType.DisplayMember = "patent_type_name"
            cmbPatentType.ValueMember = "id"
        End If
    End Sub

    Private Sub frmStatisticsReturn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetPatentType()
        txtDateFrom.dtDate.Value = Date.Now
        txtDateTo.dtDate.Value = Date.Now
    End Sub

    Private Sub btnPreviewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewReport.Click
        If date_timestart > date_timestop Then
            MsgBox("Please check the Date.", MsgBoxStyle.Information)
        Else
            Valueed = "R014"
            pattened = cmbPatentType.SelectedValue
            date_timestart = FixDate(txtDateFrom.dtDate.Value)
            date_timestop = FixDate(txtDateTo.dtDate.Value)
            ViewReport_Statistics.Show()
        End If
    End Sub
End Class