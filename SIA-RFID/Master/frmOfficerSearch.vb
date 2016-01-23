Imports System.Data
Imports DAL.Table
Imports DAL.Common.Utilities

Public Class frmOfficerSearch

    Dim SqlDB As New SqlDB
    Dim dal_position As New TbPositionDAL
    Dim dal_department As New TbDepartmentDAL
    Dim dal_officer As New TbOfficerDAL
    Dim dt As New DataTable
    Dim sql As String = ""
    Dim trans As New SqlTransactionDB

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmOfficer
        f.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub frmOfficerSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.ControlBox = False
    End Sub

    Private Sub frmOfficerSearch_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        With cbPosition
            .DataSource = dal_position.GetListBySql("select 0 as id, '--Select--' as position_name union all select id,position_name  from TB_POSITION  where isnull(position_name,'') <> ''", "position_name", Nothing)
            .ValueMember = "id"
            .DisplayMember = "position_name"
        End With

        With cbDepartment
            .DataSource = dal_department.GetListBySql("select 0 as id, '--Select--' as department_name union all select id,department_name  from TB_DEPARTMENT", "department_name", Nothing)
            .ValueMember = "id"
            .DisplayMember = "department_name"
        End With

        ShowData("")
    End Sub

    Sub ShowData(ByVal Where As String)
        sql = "select ltrim(isnull(d.title_name,'') + isnull(fname,'') + ' ' + isnull(lname,'')) as fullname,position_name,department_name"
        sql &= " ,a.id,officer_no,title_id,fname,lname,position_id,department_id,username,[password] "
        sql &= " from TB_OFFICER a left join TB_DEPARTMENT b on a.department_id = b.id"
        sql &= " left join TB_POSITION c on a.position_id = c.id left join TB_TITLE d on a.title_id = d.id where officer_no <>'2000'"
        dt = dal_position.GetListBySql(sql, "fullname", trans.Trans)
        If Where <> "" Then
            dt.DefaultView.RowFilter = Where
        End If
        GridOfficer.AutoGenerateColumns = False
        GridOfficer.DataSource = dt

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtName.Text = ""
        cbDepartment.SelectedIndex = 0
        cbPosition.SelectedIndex = 0
        ShowData("")
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim txt As String = ""
        If txtName.Text <> "" Then
            txt = "fullname like '%" & txtName.Text.Trim.Replace("'", "''") & "%' "
        End If

        If cbPosition.SelectedValue > 0 Then
            If txt = "" Then
                txt = "position_id = '" & cbPosition.SelectedValue.ToString & "' "
            Else
                txt = txt & "and position_id = '" & cbPosition.SelectedValue.ToString & "' "
            End If
        End If

        If cbDepartment.SelectedValue > 0 Then
            If txt = "" Then
                txt = "department_id = '" & cbDepartment.SelectedValue.ToString & "' "
            Else
                txt = txt & "and department_id = '" & cbDepartment.SelectedValue.ToString & "' "
            End If
        End If
        ShowData(txt)
    End Sub

    Private Sub GridOfficer_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOfficer.CellDoubleClick
        Dim f As New frmOfficer
        'Dim dal As New TbOfficerDAL

        'dal.GetDataByid(GridOfficer.Rows(e.RowIndex).Cells("id").Value, Nothing)
        f.txtId.Text = GridOfficer.Rows(e.RowIndex).Cells("id").Value
        f.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtName.Text = ""
        cbDepartment.SelectedIndex = 0
        cbPosition.SelectedIndex = 0
        txtID.Text = ""
        btnCancel.Enabled = False
        btnDelete.Enabled = False
        btnAdd.Enabled = True
        btnSearch.Enabled = True
        btnClear.Enabled = True
    End Sub

    Private Sub GridOfficer_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridOfficer.CellMouseClick
        If GridOfficer.RowCount > 0 Then
            btnAdd.Enabled = False
            btnSearch.Enabled = False
            btnClear.Enabled = False
            txtName.Text = GridOfficer.SelectedRows(0).Cells("fullname").Value.ToString.Trim
            txtID.Text = GridOfficer.SelectedRows(0).Cells("id").Value.ToString.Trim
            cbPosition.SelectedValue = Val(GridOfficer.SelectedRows(0).Cells("position_id").Value.ToString.Trim)
            cbDepartment.SelectedValue = Val(GridOfficer.SelectedRows(0).Cells("department_id").Value.ToString.Trim)
            txtName.Focus()
            txtName.SelectAll()
            btnCancel.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            SqlDB.ExecuteNonQuery("DELETE FROM TB_OFFICER_MENU WHERE officer_id='" & Val(txtID.Text) & "'")
            SqlDB.ExecuteNonQuery("DELETE FROM TB_PERMISSION_OFFICER WHERE officer_id='" & Val(txtID.Text) & "'")
            SqlDB.ExecuteNonQuery("DELETE FROM TB_OFFICER WHERE id='" & Val(txtID.Text) & "'")

            txtName.Text = ""
            cbDepartment.SelectedIndex = 0
            cbPosition.SelectedIndex = 0
            txtID.Text = ""
            btnCancel.Enabled = False
            btnDelete.Enabled = False

            btnAdd.Enabled = True
            btnSearch.Enabled = True
            btnClear.Enabled = True
            ShowData("")
            MsgBox("Delete Complete")
        Catch ex As Exception
            MsgBox("Delete Fail")
        End Try
    End Sub
End Class