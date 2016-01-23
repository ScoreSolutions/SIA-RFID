Imports System.Data
Imports DAL.Table
Imports DAL.Common.Utilities

Public Class frmOfficerSearchByDepartment

    Dim SqlDB As New SqlDB
    Dim dal_position As New TbPositionDAL
    Dim dal_department As New TbDepartmentDAL
    Dim dal_officer As New TbOfficerDAL
    Dim dt As New DataTable
    Dim sql As String = ""
    Dim trans As New SqlTransactionDB

    Private Sub frmOfficerSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.ControlBox = False
    End Sub

    Private Sub frmOfficerSearch_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        With cbDepartment
            .DataSource = dal_department.GetListBySql("select 0 as id, ' --------all--------' as department_name union all select id,department_name  from TB_DEPARTMENT", "department_name", Nothing)
            .ValueMember = "id"
            .DisplayMember = "department_name"
        End With

        ShowData("")
    End Sub

    Sub ShowData(ByVal Where As String)
        sql = "select ltrim(isnull(d.title_name,'') + isnull(fname,'') + ' ' + isnull(lname,'')) as fullname,position_name,department_name"
        sql &= " ,a.id,officer_no,title_id,fname,lname,position_id,department_id,username,[password] "
        sql &= " from TB_OFFICER a left join TB_DEPARTMENT b on a.department_id = b.id"
        sql &= " left join TB_POSITION c on a.position_id = c.id left join TB_TITLE d on a.title_id = d.id"
        dt = dal_position.GetListBySql(sql, "fullname", trans.Trans)
        If Where <> "" Then
            dt.DefaultView.RowFilter = Where
        End If
        GridOfficer.AutoGenerateColumns = False
        GridOfficer.DataSource = dt

    End Sub

    Private Sub cbDepartment_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartment.SelectionChangeCommitted
        Dim txt As String = ""
        If cbDepartment.SelectedValue > 0 Then
            If txt = "" Then
                txt = "department_id = '" & cbDepartment.SelectedValue.ToString & "' "
            Else
                txt = txt & "and department_id = '" & cbDepartment.SelectedValue.ToString & "' "
            End If
        End If
        ShowData(txt)
    End Sub

    Private Sub frmOfficerSearchByDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class