Public Class frmReturnByOfficer

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim f As New frmReserveOfficer
        f.ShowDialog()
        If f.DialogResult <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        txtName.Text = f.Name
        txtId.Text = f.OfficerID
    End Sub

    Private Sub btnPreviewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewReport.Click
        If txtName.Text = "" Then
            MsgBox("Please check the User name.", MsgBoxStyle.Information)
            txtName.Focus()
        ElseIf txtDateFrom.dtDate.Value.Date > txtDateTo.dtDate.Value.Date Then
            MsgBox("Please check the Date.", MsgBoxStyle.Information)
        Else
            date_timestart = FixDate(txtDateFrom.dtDate.Value)
            date_timestop = FixDate(txtDateTo.dtDate.Value)
            vrSearchName = txtId.Text
            checkInn_checked = "R010"
            ViewReport_CheckInn.Show()
        End If
    End Sub

    Private Sub frmReturnByOfficer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDateFrom.dtDate.Value = Date.Now
        txtDateTo.dtDate.Value = Date.Now
    End Sub

End Class