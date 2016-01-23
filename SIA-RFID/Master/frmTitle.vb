﻿Imports System.Data.SqlClient
Imports DAL.Table
Imports Data.Table
Imports DAL.Common.Utilities

Public Class frmTitle

    Dim txtFocus As TextBox
    Dim dal As New TbTitleDAL
    Dim trans As New SqlTransactionDB

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validation() Then
            Dim ret As Boolean = True
            dal = New TbTitleDAL
            
            If txtID.Text = "" Then
                'Insert
                dal.TITLE_CODE = txtTitleCode.Text
                dal.TITLE_NAME = txtTitleName.Text
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
            Else
                'Update
                If dal.ChkDataByid(txtID.Text, trans.Trans) Then
                    dal.TITLE_CODE = txtTitleCode.Text
                    dal.TITLE_NAME = txtTitleName.Text
                    ret = dal.UpdateByid(frmMain.txtUserName.Text, trans.Trans)
                End If
            End If

            If ret = True Then
                trans.CommitTransaction()
                MsgBox("Save Complete")
                Clear()
                ShowData()
            Else
                trans.RollbackTransaction()
                MsgBox(dal.ErrorMessage)
            End If
        End If
    End Sub

    Private Sub ShowData()
        GridTitleCode.AutoGenerateColumns = False
        GridTitleCode.DataSource = dal.GetDataList("", "title_code", Nothing)
    End Sub

    Private Function Validation() As Boolean
        Dim ret As Boolean = True
        If txtTitleCode.Text.Trim = "" Then
            ret = False
            MsgBox("Please complete Title ID.")
            txtTitleCode.Focus()
        ElseIf txtTitleName.Text.Trim = "" Then
            ret = False
            MsgBox("Please complete Title.")
            txtTitleName.Focus()
        ElseIf ChkId(Nothing) = True Then
            ret = False
            MsgBox("Title ID repeat Data System.")
            txtTitleCode.Focus()
        ElseIf ChkName(Nothing) = True Then
            ret = False
            MsgBox("Title repeat Data System.")
            txtTitleName.Focus()
        End If
        Return ret
    End Function

    Private Function ChkId(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbTitleDAL
        Return dal.ChkDataByWhere("title_code = '" & txtTitleCode.Text.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function

    Private Function ChkName(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbTitleDAL
        Return dal.ChkDataByWhere("title_name = '" & txtTitleName.Text.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function

    Private Sub GridTitleCode_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridTitleCode.CellMouseDoubleClick
        If GridTitleCode.RowCount > 0 Then
            Add()
            txtTitleCode.Text = GridTitleCode.SelectedRows(0).Cells("title_code").Value.ToString.Trim
            txtTitleName.Text = GridTitleCode.SelectedRows(0).Cells("title_name").Value.ToString.Trim
            txtID.Text = GridTitleCode.SelectedRows(0).Cells("id").Value.ToString.Trim
            txtTitleName.Focus()
            txtTitleName.SelectAll()
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub GetData(ByVal vID As Long, ByVal trans As SqlClient.SqlTransaction)
        Dim dal As New TbTitleDAL
        Dim data As New TbTitleData
        data = dal.GetDataByid(vID, trans)
        If dal.HaveData = True Then
            txtID.Text = data.ID
            txtTitleCode.Text = data.TITLE_CODE
            txtTitleName.Text = data.TITLE_NAME
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Sub Add()
        txtTitleCode.Enabled = True
        txtTitleName.Enabled = True
        txtTitleCode.Focus()
        GridTitleCode.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Sub Clear()
        txtTitleCode.Text = ""
        txtTitleName.Text = ""
        txtID.Text = ""
        txtTitleCode.Enabled = False
        txtTitleName.Enabled = False
        GridTitleCode.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub txtPatentTypeCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitleCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTitleName.Focus()
        End If
    End Sub

    Private Sub txtPatentTypeName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitleName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub frmTitle_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ShowData()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            SqlDB.ExecuteNonQuery("DELETE FROM TB_TITLE WHERE id='" & Val(txtID.Text) & "'")
            Clear()
            ShowData()
            MsgBox("Delete Complete")
        Catch ex As Exception
            MsgBox("Delete Fail")
        End Try
    End Sub
End Class