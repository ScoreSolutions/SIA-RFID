Imports System.Data.SqlClient
Imports DAL.Table
Imports DAL.Common.Utilities
Public Class frmRoom
    Sub Add()
        txtRoom.Enabled = True
        cbFloor.Enabled = True
        GridData.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Sub Clear()
        txtRoom.Enabled = False
        cbFloor.Enabled = False
        txtRoom.Text = ""
        txtID.Text = ""
        GridData.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnDelete.Enabled = False
        cbFloor.SelectedIndex = 0
    End Sub

    Private Sub SetFloor()
        Dim dal As New TbFloorDAL
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim sql As String = "select id,floor_name from tb_floor "
        dt = dal.GetListBySql(sql, "floor_name", trans.Trans)
        Dim dr As DataRow = dt.NewRow
        dr("floor_name") = "--Select--"
        dt.Rows.InsertAt(dr, 0)

        cbFloor.ValueMember = "id"
        cbFloor.DisplayMember = "floor_name"
        cbFloor.DataSource = dt
        trans.CommitTransaction()
    End Sub

    Private Function Validation() As Boolean
        Dim ret As Boolean = True
        If cbFloor.SelectedIndex = 0 Then
            ret = False
            MsgBox("Please Select Floor")
            cbFloor.Focus()
        ElseIf txtRoom.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Room")
            txtRoom.Focus()
        ElseIf ChkRoom(Nothing) = True Then
            ret = False
            MsgBox("Room Duplicate")
            txtRoom.Focus()
        End If
        Return ret
    End Function

    Private Function ChkRoom(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbRoomDAL
        Return dal.ChkDataByWhere("room_name = '" & txtRoom.Text.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function

    Private Sub ShowData()
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim dal As New TbRoomDAL
        GridData.AutoGenerateColumns = False
        Dim sql As String = "Select floor_name,tb_room.id,room_name,floor_id from tb_floor right join tb_room on tb_floor.id=tb_room.floor_id"
        GridData.DataSource = dal.GetListBySql(sql, "room_name", Nothing)
        trans.CommitTransaction()
    End Sub

    Private Sub frmRoom_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        SetFloor()
        ShowData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validation() Then
            Dim ret As Boolean = True
            Dim dal As New TbRoomDAL
            Dim trans As New SqlTransactionDB
            trans.CreateTransaction()
            If txtID.Text = "" Then
                'Insert
                dal.FLOOR_ID = cbFloor.SelectedValue
                dal.ROOM_NAME = txtRoom.Text.Trim
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
            Else
                'Update
                dal.GetDataByPK(txtID.Text, trans.Trans)
                dal.FLOOR_ID = cbFloor.SelectedValue
                dal.ROOM_NAME = txtRoom.Text.Trim
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
            Try
                cbFloor.SelectedValue = GridData.SelectedRows(0).Cells("floor_id").Value
            Catch ex As Exception
            End Try

            txtRoom.Text = GridData.SelectedRows(0).Cells("room_name").Value.ToString.Trim
            txtID.Text = GridData.SelectedRows(0).Cells("id").Value.ToString.Trim
            txtRoom.Focus()
            txtRoom.SelectAll()
            btnDelete.Enabled = True

        End If
    End Sub


    Private Sub txtRoom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            SqlDB.ExecuteNonQuery("DELETE FROM TB_ROOM WHERE id='" & Val(txtID.Text) & "'")
            SqlDB.ExecuteNonQuery("DELETE FROM TB_CABINET WHERE room_id='" & Val(txtID.Text) & "'")
            Clear()
            ShowData()
            MsgBox("Delete Complete")
        Catch ex As Exception
            MsgBox("Delete Fail")
        End Try
    End Sub
End Class