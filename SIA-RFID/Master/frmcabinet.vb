Imports System.Data.SqlClient
Imports DAL.Table
Imports DAL.Common.Utilities
Public Class frmcabinet

    Sub Add()
        txtCabinet.Enabled = True
        cbFloor.Enabled = True
        cbRoom.Enabled = True
        GridData.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Sub Clear()
        txtCabinet.Enabled = False
        cbFloor.Enabled = False
        cbRoom.Enabled = False
        txtCabinet.Text = ""
        txtID.Text = ""
        GridData.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnDelete.Enabled = False
        cbFloor.SelectedIndex = 0
        cbRoom.SelectedIndex = 0
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

    Private Sub SetRoom(ByVal floor_id As String)
        Dim dal As New TbRoomDAL
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim sql As String = "select id,room_name from tb_room where floor_id = '" & floor_id & "'"
        dt = dal.GetListBySql(sql, "room_name", trans.Trans)
        Dim dr As DataRow = dt.NewRow
        dr("room_name") = "--Select--"
        dt.Rows.InsertAt(dr, 0)

        cbRoom.ValueMember = "id"
        cbRoom.DisplayMember = "room_name"
        cbRoom.DataSource = dt
        trans.CommitTransaction()
    End Sub

    Private Function Validation() As Boolean
        Dim ret As Boolean = True
        If cbFloor.SelectedIndex = 0 Then
            ret = False
            MsgBox("Please Select Floor")
            cbFloor.Focus()
        ElseIf cbRoom.SelectedIndex = 0 Then
            ret = False
            MsgBox("Please Select Room")
            cbRoom.Focus()
        ElseIf txtCabinet.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Cabinet")
            txtCabinet.Focus()
        ElseIf ChkCabinet(Nothing) = True Then
            ret = False
            MsgBox("Cabinet Duplicate")
            txtCabinet.Focus()
        End If
        Return ret
    End Function

    Private Function ChkCabinet(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbCabinetDAL
        Return dal.ChkDataByWhere("cabinet_name = '" & txtCabinet.Text.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function

    Private Sub ShowData()
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dal As New TbCabinetDAL
        GridData.AutoGenerateColumns = False
        Dim sql As String = "Select floor_name,tb_cabinet.id,room_name,tb_cabinet.floor_id,tb_cabinet.room_id,cabinet_name "
        sql += " from tb_cabinet left join tb_room on tb_cabinet.room_id = tb_room.id"
        sql += " left join tb_floor  on tb_floor.id=tb_room.floor_id"
        GridData.DataSource = dal.GetListBySql(sql, "cabinet_name", trans.Trans)
        trans.CommitTransaction()
    End Sub

    Private Sub frmRoom_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        SetFloor()
        SetRoom("")
        ShowData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validation() Then
            Dim ret As Boolean = True
            Dim dal As New TbCabinetDAL
            Dim trans As New SqlTransactionDB
            trans.CreateTransaction()
            If txtID.Text = "" Then
                'Insert
                dal.FLOOR_ID = cbFloor.SelectedValue
                dal.ROOM_ID = cbRoom.SelectedValue
                dal.CABINET_NAME = txtCabinet.Text.Trim
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
            Else
                'Update
                dal.GetDataByPK(txtID.Text, trans.Trans)
                dal.FLOOR_ID = cbFloor.SelectedValue
                dal.ROOM_ID = cbRoom.SelectedValue
                dal.CABINET_NAME = txtCabinet.Text.Trim
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
                SetRoom(cbFloor.SelectedValue.ToString)
                cbRoom.SelectedValue = GridData.SelectedRows(0).Cells("room_id").Value
            Catch ex As Exception
            End Try

            txtCabinet.Text = GridData.SelectedRows(0).Cells("cabinet_name").Value.ToString.Trim
            txtID.Text = GridData.SelectedRows(0).Cells("id").Value.ToString.Trim
            txtCabinet.Focus()
            txtCabinet.SelectAll()
            btnDelete.Enabled = True
        End If
    End Sub


    Private Sub txtCabinet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCabinet.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub cbFloor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFloor.SelectedIndexChanged
        SetRoom(cbFloor.SelectedValue.ToString)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            'If DAL.Common.Utilities.Func.CheckDeleteRelation("TB_REQUISTION", "cabinet_id", Val(txtID.Text)) = False Then
            '    MsgBox("Can't delete because data used another process")
            '    Exit Sub
            'End If

            SqlDB.ExecuteNonQuery("DELETE FROM TB_CABINET WHERE id='" & Val(txtID.Text) & "'")
            Clear()
            ShowData()
            MsgBox("Delete Complete")
        Catch ex As Exception
            MsgBox("Delete Fail")
        End Try
    End Sub
End Class