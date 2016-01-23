Imports DAL.Table
Imports System.Data

Public Class frmReturnByDepartment

    Private Sub frmReturnByDepartment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dal As New TbDepartmentDAL
        Dim dt As DataTable = dal.GetDataList("", "department_name", Nothing)
        Dim dr As DataRow = dt.NewRow
        dr("id") = "0"
        dr("department_name") = "---------------------Select---------------------"
        dt.Rows.InsertAt(dr, 0)
        With cmbDepartment
            .DataSource = dt
            .ValueMember = "id"
            .DisplayMember = "department_name"
        End With
    End Sub

    Private Sub btnPreviewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewReport.Click
        If cmbDepartment.Text = "---------------------Select---------------------" Then
            MsgBox("Please select the Department.", MsgBoxStyle.Information)
            cmbDepartment.Focus()
        ElseIf txtDateFrom.dtDate.Value.Date > txtDateTo.dtDate.Value.Date Then
            MsgBox("Please check the Date.", MsgBoxStyle.Information)
        Else
            checkInn_checked = "R011"
            date_timestart = FixDate(txtDateFrom.dtDate.Value)
            date_timestop = FixDate(txtDateTo.dtDate.Value)
            vrSearchGroup = cmbDepartment.SelectedValue
            ViewReport_CheckInn.Show()
        End If
    End Sub

    Private Sub frmReturnByDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDateFrom.dtDate.Value = Date.Now
        txtDateTo.dtDate.Value = Date.Now
    End Sub

End Class