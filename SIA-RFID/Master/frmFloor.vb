﻿Imports System.Data.SqlClient
Imports DAL.Table
Imports DAL.Common.Utilities
Public Class frmFloor

    Sub Add()
        txtFloor.Enabled = True
        GridData.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Sub Clear()
        txtFloor.Enabled = False
        txtFloor.Text = ""
        txtID.Text = ""
        GridData.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Function Validation() As Boolean
        Dim ret As Boolean = True
        If txtFloor.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Floor")
            txtFloor.Focus()
        ElseIf ChkFloor(Nothing) = True Then
            ret = False
            MsgBox("Floor Duplicate")
            txtFloor.Focus()
        End If
        Return ret
    End Function

    Private Function ChkFloor(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbFloorDAL
        Return dal.ChkDataByWhere("floor_name = '" & txtFloor.Text.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function

    Private Sub ShowData()
        Dim dal As New TbFloorDAL
        GridData.AutoGenerateColumns = False
        GridData.DataSource = DAL.GetDataList("", "floor_name", Nothing)
    End Sub

    Private Sub frmFloor_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ShowData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validation() Then
            Dim ret As Boolean = True
            Dim dal As New TbFloorDAL
            Dim trans As New SqlTransactionDB
            trans.CreateTransaction()
            If txtID.Text = "" Then
                'Insert
                dal.FLOOR_NAME = txtFloor.Text.Trim
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
            Else
                'Update
                dal.GetDataByPK(txtID.Text, trans.Trans)
                dal.FLOOR_NAME = txtFloor.Text.Trim
                ret = dal.UpdateByPK(frmMain.txtUserName.Text, trans.Trans)
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub GridData_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridData.CellMouseDoubleClick
        If GridData.RowCount > 0 Then
            Add()
            txtFloor.Text = GridData.SelectedRows(0).Cells("floor_name").Value.ToString.Trim
            txtID.Text = GridData.SelectedRows(0).Cells("id").Value.ToString.Trim
            txtFloor.Focus()
            txtFloor.SelectAll()
            btnDelete.Enabled = True
        End If
    End Sub


    Private Sub txtFloor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFloor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub frmFloor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            SqlDB.ExecuteNonQuery("DELETE FROM TB_FLOOR WHERE id='" & Val(txtID.Text) & "'")
            SqlDB.ExecuteNonQuery("DELETE FROM TB_ROOM WHERE floor_id='" & Val(txtID.Text) & "'")
            SqlDB.ExecuteNonQuery("DELETE FROM TB_CABINET WHERE floor_id='" & Val(txtID.Text) & "'")
            Clear()
            ShowData()
            MsgBox("Delete Complete")
        Catch ex As Exception
            MsgBox("Delete Fail")
        End Try
    End Sub
End Class