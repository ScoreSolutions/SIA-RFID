Imports System.Data
Imports System.Data.SqlClient
Imports DAL.Table
Imports Data.Table
Imports DAL.Common.Utilities
Imports OpenNETCF.Desktop.Communication

Public Class frmTransfer

    Private Sub frmTransfer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetLocation()

        PictureReserve.BackgroundImage = Image.FromFile("images/BG.jpg")
        Panel1.BackgroundImage = Image.FromFile("Images/blog4_03.jpg")
        btnReadRFID.BackgroundImage = Image.FromFile("Images/blog5_11.jpg")
        btnCancel.BackgroundImage = Image.FromFile("Images/blog3_13.jpg")
        PanelLocation.BackgroundImage = Image.FromFile("Images/blog4_04.jpg")
        btnMobileDevice.BackgroundImage = Image.FromFile("images/blog3_31.jpg")
        ' btnComfirm.BackgroundImage = Image.FromFile("Images/Dis_blog3_26.jpg")
        SetControl()
       
    End Sub
    Private Sub SetControl()
        If gdvDataBook.RowCount = 0 Then
            btnComfirm.Enabled = False
            btnComfirm.BackgroundImage = Image.FromFile("Images/Dis_blog3_26.jpg")
        Else
            btnComfirm.Enabled = True
            btnComfirm.BackgroundImage = Image.FromFile("Images/blog3_26.jpg")
        End If
    End Sub

    Private Sub SetFloor()
        Dim dal As New TbFloorDAL
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim sql As String = "select id,floor_name from tb_floor "
        dt = dal.GetListBySql(sql, "floor_name", trans.Trans)
        Dim dr As DataRow = dt.NewRow
        dr("floor_name") = "--Select Floor--"
        dr("id") = "0"
        dt.Rows.InsertAt(dr, 0)

        ddlFloor.ValueMember = "id"
        ddlFloor.DisplayMember = "floor_name"
        ddlFloor.DataSource = dt
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
        dr("room_name") = "--Select Room--"
        dr("id") = "0"
        dt.Rows.InsertAt(dr, 0)

        ddlRoom.ValueMember = "id"
        ddlRoom.DisplayMember = "room_name"
        ddlRoom.DataSource = dt
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
        dr("cabinet_name") = "--Select Cabinet--"
        dr("id") = "0"
        dt.Rows.InsertAt(dr, 0)

        ddlCabinet.ValueMember = "id"
        ddlCabinet.DisplayMember = "cabinet_name"
        ddlCabinet.DataSource = dt
        trans.CommitTransaction()
    End Sub

    Private Sub ddlFloor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlFloor.SelectedIndexChanged
        SetRoom(ddlFloor.SelectedValue.ToString)
    End Sub

    Private Sub ddlRoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRoom.SelectedIndexChanged
        SetCabinet(ddlFloor.SelectedValue.ToString, ddlRoom.SelectedValue.ToString)
    End Sub

    Private Sub frmTransfer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.ControlBox = False
    End Sub

    Private Sub btnReadRFID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadRFID.Click
        showdata()
    End Sub

    Private Sub btnComfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComfirm.Click
        UpdateLocation()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearForm()
        SetControl()
    End Sub

    Private Sub ClearForm()
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("seq", GetType(String)))
        dt.Columns.Add(New DataColumn("tag_id", GetType(String)))
        dt.Columns.Add(New DataColumn("floor_name", GetType(String)))
        dt.Columns.Add(New DataColumn("room_name", GetType(String)))
        dt.Columns.Add(New DataColumn("cabinet_name", GetType(String)))
        gdvDataBook.DataSource = dt
        dt.Dispose()

        txtBarcode.Text = ""
        ddlFloor.SelectedIndex = 0
        ddlRoom.SelectedIndex = 0
        ddlCabinet.SelectedIndex = 0
    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtBarcode.Text) = "" Then
                MessageBox.Show("Please specify the Barcode.")
                Exit Sub
            End If

            If IsExistBook() = False Then
                MessageBox.Show("Please specify the correct Barcode.")
                Exit Sub
            End If


            Dim dt As New DataTable
            If gdvDataBook.RowCount > 0 Then
                dt = gdvDataBook.DataSource
            Else
                dt.Columns.Add(New DataColumn("seq", GetType(String)))
                dt.Columns.Add(New DataColumn("tag_id", GetType(String)))
                dt.Columns.Add(New DataColumn("floor_name", GetType(String)))
                dt.Columns.Add(New DataColumn("room_name", GetType(String)))
                dt.Columns.Add(New DataColumn("cabinet_name", GetType(String)))
            End If


            Dim dr As DataRow
            dr = dt.NewRow
            dr("seq") = dt.Rows.Count + 1
            dr("tag_id") = Trim(txtBarcode.Text)

            Dim dtData As DataTable = GetDateTag(Trim(txtBarcode.Text))
            If dtData.Rows.Count > 0 Then
                dr("floor_name") = dtData.Rows(0)("floor_name")
                dr("room_name") = dtData.Rows(0)("room_name")
                dr("cabinet_name") = dtData.Rows(0)("cabinet_name")
            Else
                dr("floor_name") = ""
                dr("room_name") = ""
                dr("cabinet_name") = ""
            End If
            dtData = Nothing

            dt.Rows.Add(dr)

            gdvDataBook.DataSource = dt
            dt.Dispose()
            txtBarcode.Text = ""
            txtBarcode.Focus()
            SetControl()
        End If
    End Sub

    Private Function GetDateTag(ByVal App_No As String) As DataTable
        Dim Sql As String = ""
        Sql &= " SELECT "
        Sql &= " R.App_No"
        Sql &= " ,F.floor_name"
        Sql &= " ,RM.room_name"
        Sql &= " ,C.cabinet_name"
        Sql &= " ,C.createby "
        Sql &= " from  TB_REQUISTION R"
        Sql &= " Left Join TB_FLOOR F"
        Sql &= " ON F.id = R.floor_id"
        Sql &= " LEFT JOIN TB_ROOM RM"
        Sql &= " ON RM.id = R.room_id"
        Sql &= " LEFT JOIN TB_CABINET C"
        Sql &= " ON C.id = R.cabinet_id"
        Sql &= " WHERE APP_NO='" & App_No & "'"
        Dim dt As DataTable = SqlDB.ExecuteTable(Sql)


        Return dt
    End Function


    Private Sub showdata()
        Try
            Dim dal As New TmpGateReaderTagDAL
            Dim sql As String = ""
            sql &= " select "
            sql &= " tag_id"
            sql &= " ,F.floor_name"
            sql &= " ,RM.room_name"
            sql &= " ,C.cabinet_name"
            sql &= " from TMP_GATE_READER_TAG T"
            sql &= " INNER JOIN TB_REQUISTION R"
            sql &= " ON T.tag_id =R.app_no"
            sql &= " Left Join TB_FLOOR F"
            sql &= " ON F.id = R.floor_id"
            sql &= " LEFT JOIN TB_ROOM RM"
            sql &= " ON RM.id = R.room_id"
            sql &= " LEFT JOIN TB_CABINET C"
            sql &= " ON C.id = R.cabinet_id"
            sql &= " where read_type = 3"
            Dim dt As New DataTable
            dt = dal.GetListBySql(sql, "", Nothing)

            dt.Columns.Add("seq")
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("seq") = i + 1
            Next
            gdvDataBook.DataSource = dt

            dt.Dispose()
            dal = Nothing
            SetControl()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateLocation()
        Try

            If ddlFloor.SelectedIndex = 0 Then
                MessageBox.Show("Please specify the floor.")
                Exit Sub
            End If

            If ddlRoom.SelectedIndex = 0 Then
                MessageBox.Show("Please specify the room.")
                Exit Sub
            End If

            'If ddlCabinet.SelectedIndex = 0 Then
            '    MessageBox.Show("Please specify the cabinet.")
            '    Exit Sub
            'End If

            If gdvDataBook.RowCount = 0 Then
                MessageBox.Show("Please specify the files to move.")
                Exit Sub
            End If

            Dim trans As New SqlTransactionDB
            trans.CreateTransaction()
            Dim dt As New DataTable
            dt = gdvDataBook.DataSource
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dalItem As New TbRequisitionDAL
                Dim tag_id As String = dt.Rows(i).Item("tag_id").ToString()
                dalItem.GetDataByAPP_NO(tag_id, trans.Trans)
                'dalItem.LOCATION = ddlFloor.SelectedValue
                dalItem.FLOOR_ID = ddlFloor.SelectedValue
                dalItem.ROOM_ID = ddlRoom.SelectedValue
                dalItem.CABINET_ID = ddlCabinet.SelectedValue
                dalItem.STATUS = "inprogress"
                dalItem.UpdateByID(frmMain.txtIdUser.Text, trans.Trans)
            Next
            dt.Dispose()

            'ยืนยันเสร็จให้ลบ Temp
            SqlDB.ExecuteNonQuery("DELETE FROM TMP_GATE_READER_TAG WHERE read_type='3'")

            trans.CommitTransaction()
            ClearForm()
            MsgBox("Save Complete")
            btnReadRFID.Enabled = True
            btnReadRFID.BackgroundImage = Image.FromFile("images/blog3_09.jpg")
            btnComfirm.Enabled = False
            btnComfirm.BackgroundImage = Image.FromFile("images/Dis_blog3_26.jpg")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function IsExistBook() As Boolean
        Dim dal As New TbRequisitionDAL
        Dim trans As New SqlTransactionDB
        Dim dt As New DataTable
        dal.GetDataByAPP_NO(txtBarcode.Text, trans.Trans)
        If dal.ID = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub SetLocation()
        SetFloor()
        SetRoom(ddlFloor.SelectedValue)
        SetCabinet(ddlFloor.SelectedValue, ddlRoom.SelectedValue)
    End Sub


  
    Private Sub btnMobileDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMobileDevice.Click
        Dim rapi As New RAPI
        If rapi.DevicePresent = False Then
            MsgBox("Device Not Connect")
            Exit Sub
        End If

        Dim frm As New frmMobile
        frm.SyncFor = frmMobile.TASK_TYPE.Import
        frm.ShowDialog()
    End Sub
End Class