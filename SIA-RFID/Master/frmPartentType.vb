Imports System.Data.SqlClient
Imports DAL.Table
Imports DAL.Common.Utilities
Imports System.IO
Imports System.Text

Public Class frmPatentType

    Dim dal As New TbPatentTypeDAL
    Dim trans As New SqlTransactionDB

    Private Sub GridPatentType_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPatentType.CellMouseDoubleClick
        If GridPatentType.RowCount > 0 Then
            Add()
            txtPatentTypeCode.Text = GridPatentType.SelectedRows(0).Cells("patent_type_code").Value.ToString.Trim
            txtPatentTypeName.Text = GridPatentType.SelectedRows(0).Cells("patent_type_name").Value.ToString.Trim
            txtId.Text = GridPatentType.SelectedRows(0).Cells("id").Value.ToString.Trim
            txtPatentTypeName.Focus()
            txtPatentTypeName.SelectAll()
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub ShowData()
        GridPatentType.AutoGenerateColumns = False
        GridPatentType.DataSource = dal.GetDataList("", "patent_type_code", Nothing)
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validation() Then
            Dim ret As Boolean = True
            dal = New TbPatentTypeDAL

            If txtId.Text = "" Then
                'Insert
                dal.PATENT_TYPE_CODE = txtPatentTypeCode.Text.Trim
                dal.PATENT_TYPE_NAME = txtPatentTypeName.Text.Trim
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
            Else
                'Update
                dal.GetDataByid(txtId.Text, trans.Trans)
                dal.PATENT_TYPE_CODE = txtPatentTypeCode.Text.Trim
                dal.PATENT_TYPE_NAME = txtPatentTypeName.Text.Trim
                ret = dal.UpdateByid(frmMain.txtUserName.Text, trans.Trans)
            End If

            If ret = True Then
                trans.CommitTransaction()
                MsgBox("Save Complete")
                Clear()
                ShowData()
                GenText()
            Else
                trans.RollbackTransaction()
                MsgBox(dal.ErrorMessage)
            End If
        End If
    End Sub
    'สร้าง Text ไว้ใช้ใน Handhle
    Private Sub GenText()
        Dim dal As New TbPatentTypeDAL
        Dim dt As DataTable = dal.GetDataList("", "patent_type_code", Nothing)
        If File.Exists(Application.StartupPath & "\ApplicationType.txt") Then File.Delete(Application.StartupPath & "\ApplicationType.txt")
        Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\ApplicationType.txt", True)
        Dim strText As New StringBuilder
        For i As Integer = 0 To DT.Rows.Count - 1
            strText.Append(dt.Rows(i)("patent_type_code"))
            strText.AppendLine()
        Next

        objWriter.Write(strText.ToString)
        objWriter.Close()
    End Sub

    Private Function Validation() As Boolean
        Dim ret As Boolean = True
        If txtPatentTypeCode.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Application Type ID")
            txtPatentTypeCode.Focus()
        ElseIf txtPatentTypeName.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Application Type Name")
            txtPatentTypeName.Focus()
        ElseIf ChkId(Nothing) = True Then
            ret = False
            MsgBox("Application Type ID Duplicate")
            txtPatentTypeCode.Focus()
            'ElseIf ChkName(Nothing) = True Then
            '    ret = False
            '    MsgBox("Application Type Name Duplicate")
            '    txtPatentTypeName.Focus()
        End If
        Return ret
    End Function

    Private Function ChkId(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbPatentTypeDAL
        Return dal.ChkDataByWhere("patent_type_code = '" & txtPatentTypeCode.Text.Replace("'", "''") & "' and id <> '" & Val(txtId.Text) & "'", trans)
    End Function

    'Private Function ChkName(ByVal trans As SqlTransaction) As Boolean
    '    Dim dal As New TbPatentTypeDAL
    '    Return dal.ChkDataByWhere("patent_type_name = '" & txtPatentTypeName.Text.Replace("'", "''") & "' and id <> '" & Val(txtId.Text) & "'", trans)
    'End Function

    Sub Add()
        txtPatentTypeCode.Enabled = True
        txtPatentTypeName.Enabled = True
        txtPatentTypeCode.Focus()
        GridPatentType.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Sub Clear()
        txtPatentTypeCode.Text = ""
        txtPatentTypeName.Text = ""
        txtId.Text = ""
        txtPatentTypeCode.Enabled = False
        txtPatentTypeName.Enabled = False
        GridPatentType.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub txtPatentTypeCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatentTypeCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPatentTypeName.Focus()
        End If
    End Sub

    Private Sub txtPatentTypeName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatentTypeName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub frmPatentType_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ShowData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            SqlDB.ExecuteNonQuery("DELETE FROM TB_PATENT_TYPE WHERE id='" & Val(txtId.Text) & "'")
            Clear()
            ShowData()
            MsgBox("Delete Complete")
        Catch ex As Exception
            MsgBox("Delete Fail")
        End Try
    End Sub
End Class