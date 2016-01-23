Imports System.Data.SqlClient
Imports DAL.Table
Imports DAL.Common.Utilities
Public Class frmRegister
    Sub Add()
        txtAppNo.ReadOnly = False
        txtAppNo.Enabled = True
        txtAppName.Enabled = True
        cbAppType.Enabled = True
        cbFloor.Enabled = True
        cbCabinet.Enabled = True
        cbStatus.Enabled = True
        cbRoom.Enabled = True
        txtOrder.Enabled = True
        txtYourRefNo.Enabled = True
        ' GridData.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Sub Clear()
        txtAppNo.Enabled = True
        txtAppName.Enabled = True
        cbAppType.Enabled = True
        cbFloor.Enabled = True
        cbCabinet.Enabled = True
        cbStatus.Enabled = True
        cbRoom.Enabled = True
        txtAppName.Text = ""
        txtAppNo.Text = ""
        txtOrder.Text = ""
        txtYourRefNo.Text = ""
        txtFillingDate.TextBox1.Text = ""
        txtFillingNo.Text = ""
        cbAppType.SelectedIndex = 0
        cbFloor.SelectedIndex = 0
        cbCabinet.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        cbRoom.SelectedIndex = 0

        txtID.Text = ""
        'GridData.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False

    End Sub

    Private Sub SetData()
        SetAppType()
        SetStatus()
        SetFloor()

        Dim dal As New TbRequisitionDAL
        If txtID.Text.Trim <> "" Then
            dal.GetDataByid(txtID.Text.Trim, Nothing)
        End If

        txtAppName.Text = dal.APP_NAME
        txtAppNo.Text = dal.APP_NO
        txtOrder.Text = dal.APP_ORDER
        txtYourRefNo.Text = dal.APP_REF
        cbAppType.SelectedValue = dal.PATENT_TYPE_ID
        txtFillingNo.Text = dal.FilingNo
        Try
            txtFillingDate.TextBox1.Text = dal.FilingDate
        Catch ex As Exception
        End Try


        Try
            cbFloor.SelectedValue = Val(dal.FLOOR_ID & "")
            SetRoom(cbFloor.SelectedValue)
            cbRoom.SelectedValue = Val(dal.ROOM_ID & "")
            SetCabinet(cbFloor.SelectedValue, cbRoom.SelectedValue)
            cbCabinet.SelectedValue = Val(dal.CABINET_ID & "")
            cbStatus.SelectedValue = Val(dal.APP_STATUS & "")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SetAppType()
        Dim dal As New TbFloorDAL
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim sql As String = "select id,patent_type_name from TB_PATENT_TYPE "
        dt = dal.GetListBySql(sql, "patent_type_name", trans.Trans)
        Dim dr As DataRow = dt.NewRow
        dr("patent_type_name") = "--Select--"
        dr("id") = "0"
        dt.Rows.InsertAt(dr, 0)

        cbAppType.ValueMember = "id"
        cbAppType.DisplayMember = "patent_type_name"
        cbAppType.DataSource = dt
        trans.CommitTransaction()
    End Sub

    Private Sub SetStatus()

        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("app_status", GetType(String)))
        dt.Columns.Add(New DataColumn("id", GetType(String)))
        Dim dr As DataRow = dt.NewRow
        dr("app_status") = "--Select--"
        dr("id") = ""
        dt.Rows.InsertAt(dr, 0)

        dr = dt.NewRow
        dr("id") = "1"
        dr("app_status") = "1"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("id") = "2"
        dr("app_status") = "2"
        dt.Rows.Add(dr)

        cbStatus.ValueMember = "id"
        cbStatus.DisplayMember = "app_status"
        cbStatus.DataSource = dt
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
        dr("id") = "0"
        dt.Rows.InsertAt(dr, 0)

        cbFloor.ValueMember = "id"
        cbFloor.DisplayMember = "floor_name"
        cbFloor.DataSource = dt
        trans.CommitTransaction()
    End Sub

    Public Sub SetRoom(ByVal floor_id As String)
        Dim dal As New TbRoomDAL
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim sql As String = "select id,room_name from tb_room where floor_id = '" & floor_id & "'"
        dt = dal.GetListBySql(sql, "room_name", trans.Trans)
        Dim dr As DataRow = dt.NewRow
        dr("room_name") = "--Select--"
        dr("id") = "0"
        dt.Rows.InsertAt(dr, 0)

        cbRoom.ValueMember = "id"
        cbRoom.DisplayMember = "room_name"
        cbRoom.DataSource = dt
        trans.CommitTransaction()
    End Sub

    Public Sub SetCabinet(ByVal floor_id As String, ByVal room_id As String)
        Dim dal As New TbRoomDAL
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim sql As String = "select id,cabinet_name from tb_cabinet where floor_id = '" & floor_id & "' and room_id = '" & room_id & "'"
        dt = dal.GetListBySql(sql, "cabinet_name", trans.Trans)
        Dim dr As DataRow = dt.NewRow
        dr("cabinet_name") = "--Select--"
        dr("id") = "0"
        dt.Rows.InsertAt(dr, 0)

        cbCabinet.ValueMember = "id"
        cbCabinet.DisplayMember = "cabinet_name"
        cbCabinet.DataSource = dt
        trans.CommitTransaction()
    End Sub

    Private Function Validation() As Boolean
        Dim ret As Boolean = True
        If txtAppNo.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Our Ref.")
            txtAppNo.Focus()
        ElseIf txtAppName.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Applicant")
            txtAppName.Focus()
        ElseIf txtOrder.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Order")
            txtOrder.Focus()
        ElseIf txtYourRefNo.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Your Ref No.")
            txtYourRefNo.Focus()
        ElseIf txtFillingNo.Text.Trim = "" Then
            ret = False
            MsgBox("Please Input Filing No.")
            txtFillingNo.Focus()
        ElseIf txtFillingDate.TextDate = "" Then
            ret = False
            MsgBox("Please Input Filing Date")
            txtFillingDate.TextBox1.Focus()
        ElseIf ChkAppNo(Nothing) = True Then
            ret = False
            MsgBox("Our Ref. Duplicate")
            txtAppNo.Focus()
            'ElseIf ChkAppName(Nothing) = True Then
            '    ret = False
            '    MsgBox("Application Name Duplicate")
            '    txtAppNo.Focus()
        End If
        Return ret
    End Function

    Private Function ChkAppNo(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbRequisitionDAL
        Return dal.ChkDataByWhere("App_No = '" & txtAppNo.Text.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function

    Private Function ChkAppName(ByVal trans As SqlTransaction) As Boolean
        Dim dal As New TbRequisitionDAL
        Return dal.ChkDataByWhere("App_Name = '" & txtAppName.Text.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function


    Private Sub frmRoom_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Add()
        SetData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validation() Then
            Dim ret As Boolean = True
            Dim dal As New TbRequisitionDAL
            Dim trans As New SqlTransactionDB
            trans.CreateTransaction()
            Dim tagrfid As String = Func.strToHex(txtAppNo.Text.Trim)
            If txtID.Text = "" Then
                'Insert
                dal.APP_NO = txtAppNo.Text.Trim
                dal.APP_NAME = txtAppName.Text.Trim
                dal.PATENT_TYPE_ID = cbAppType.SelectedValue
                dal.APP_STATUS = Val(cbStatus.SelectedValue & "")
                dal.FLOOR_ID = Val(cbFloor.SelectedValue & "")
                dal.ROOM_ID = Val(cbRoom.SelectedValue & "")
                dal.CABINET_ID = Val(cbCabinet.SelectedValue & "")
                dal.TAGRFID = tagrfid
                dal.APP_ORDER = txtOrder.Text.Trim()
                dal.APP_REF = txtYourRefNo.Text.Trim()
                dal.FilingNo = txtFillingNo.Text.Trim
                If txtFillingDate.TextDate <> "" Then
                    dal.FilingDate = txtFillingDate.TextDate
                End If
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
            Else
                'Update
                dal.GetDataByid(txtID.Text, trans.Trans)
                dal.APP_NO = txtAppNo.Text.Trim
                dal.APP_NAME = txtAppName.Text.Trim
                dal.PATENT_TYPE_ID = cbAppType.SelectedValue
                dal.APP_STATUS = Val(cbStatus.SelectedValue & "")
                dal.FLOOR_ID = Val(cbFloor.SelectedValue & "")
                dal.ROOM_ID = Val(cbRoom.SelectedValue & "")
                dal.CABINET_ID = Val(cbCabinet.SelectedValue & "")
                'dal.TAGRFID = tagrfid
                dal.APP_ORDER = txtOrder.Text.Trim()
                dal.APP_REF = txtYourRefNo.Text.Trim()
                dal.FilingNo = txtFillingNo.Text.Trim
                If txtFillingDate.TextDate <> "" Then
                    dal.FilingDate = txtFillingDate.TextDate
                End If

                ret = dal.UpdateByid(frmMain.txtUserName.Text, trans.Trans)
            End If

            If ret = True Then
                trans.CommitTransaction()
                MsgBox("Save Complete")
                Clear()

            Else
                trans.RollbackTransaction()
                MsgBox("Save Fail") 'dal.ErrorMessage)
            End If
        End If
    End Sub

    Private Sub CloseAllForm()
        For Each fm In Me.MdiChildren
            fm.Close()
            fm.Dispose()
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Clear()
        SetData()
    End Sub

  

    Private Sub cbFloor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFloor.SelectedIndexChanged
        SetRoom(cbFloor.SelectedValue.ToString)
    End Sub

    Private Sub cbRoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbRoom.SelectedIndexChanged
        SetCabinet(cbFloor.SelectedValue.ToString, cbRoom.SelectedValue.ToString)
    End Sub

   
End Class