Imports System.Data.SqlClient
Imports DAL.Table
Imports DAL.Common.Utilities
Public Class frmRegisterList

    Private Sub ShowData(ByVal filter As String)
        Dim dal As New TbRoomDAL
        GridData.AutoGenerateColumns = False
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim sql As String = "select RT.ID,RT.app_no,RT.app_name,RT.app_status,PT.patent_type_name,F.floor_name,R.room_name,C.cabinet_name,patent_type_id "
        sql += ",RT.floor_id,RT.room_id,RT.cabinet_id,RT.patent_type_id,RT.app_order,RT.App_Ref,RT.FilingNo,RT.FilingDate"
        sql += " from TB_REQUISTION RT Left Join TB_PATENT_TYPE PT on RT.patent_type_id = PT.id"
        sql += " left join tb_floor F on F.id=RT.floor_id"
        sql += " left join tb_room R on  R.id = RT.room_id "
        sql += " Left Join TB_CABINET C on C.id = RT.cabinet_id where 1=1 " & filter
        GridData.DataSource = dal.GetListBySql(sql, "App_No", trans.Trans)
        trans.CommitTransaction()
    End Sub


    Private Sub CloseAllForm()
        For Each fm In Me.MdiChildren
            fm.Close()
            fm.Dispose()
        Next
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
        cbAppType.SelectedIndex = 0
        cbFloor.SelectedIndex = 0
        cbCabinet.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        cbRoom.SelectedIndex = 0

        GridData.Enabled = True
        btnAdd.Enabled = True
        btnClear.Enabled = False

        btnUpload.Enabled = False
        txtFile.Text = ""
        imgIcon.Visible = False

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
        ShowData("")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmRegister
        f.ShowDialog()
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


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim txt As String = ""


        If txtAppName.Text <> "" Then
            txt = " and RT.App_Name like '%" & txtAppName.Text.Trim.Replace("'", "''") & "%' "
        End If

        If txtAppNo.Text <> "" Then
            txt = txt & "and RT.App_No LIKE '%" & txtAppNo.Text.Trim.Replace("'", "''") & "%' "
        End If

        If cbAppType.SelectedIndex > 0 Then
            txt = txt & "and RT.patent_type_id = '" & cbAppType.SelectedValue.ToString & "' "
        End If

        If cbFloor.SelectedIndex > 0 Then
            txt = txt & "and RT.floor_id = '" & cbFloor.SelectedValue.ToString & "' "
        End If

        If cbCabinet.SelectedIndex > 0 Then
            txt = txt & "and RT.cabinet_id = '" & cbCabinet.SelectedValue.ToString & "' "
        End If

        If cbRoom.SelectedIndex > 0 Then
            txt = txt & "and RT.room_id = '" & cbRoom.SelectedValue.ToString & "' "
        End If

        If cbStatus.SelectedIndex > 0 Then
            txt = txt & "and RT.app_status = '" & cbStatus.SelectedValue.ToString & "' "
        End If
        ShowData(txt)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CloseAllForm()
        Dim frm As New frmRegister
        frm.MdiParent = frmMain
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub GridData_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridData.CellMouseDoubleClick


        Dim f As New frmRegister
        f.txtID.Text = GridData.Rows(e.RowIndex).Cells("id").Value
        f.ShowDialog()

    End Sub

    Private Sub GridData_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridData.CellMouseClick

        If GridData.RowCount > 0 Then
            btnAdd.Enabled = False
            btnSearch.Enabled = False
            btnClear.Enabled = False
            txtID.Text = GridData.SelectedRows(0).Cells("id").Value.ToString.Trim
            txtAppNo.Text = GridData.SelectedRows(0).Cells("App_No").Value.ToString.Trim
            txtAppName.Text = GridData.SelectedRows(0).Cells("App_Name").Value.ToString.Trim
            cbAppType.SelectedValue = Val(GridData.SelectedRows(0).Cells("patent_type_id").Value.ToString.Trim)
            cbFloor.SelectedValue = Val(GridData.SelectedRows(0).Cells("floor_id").Value.ToString.Trim)
            cbCabinet.SelectedValue = Val(GridData.SelectedRows(0).Cells("cabinet_id").Value.ToString.Trim)
            cbRoom.SelectedValue = Val(GridData.SelectedRows(0).Cells("room_id").Value.ToString.Trim)

            txtAppNo.Focus()
            txtAppNo.SelectAll()
            btnCancel.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub


    Private Sub cbFloor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFloor.SelectedIndexChanged
        SetRoom(cbFloor.SelectedValue.ToString)
    End Sub

    Private Sub cbRoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbRoom.SelectedIndexChanged
        SetCabinet(cbFloor.SelectedValue.ToString, cbRoom.SelectedValue.ToString)
    End Sub

    Private Sub frmRegisterList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        SetAppType()
        SetStatus()
        SetFloor()
        SetRoom("")
        SetCabinet("", "")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            SqlDB.ExecuteNonQuery("DELETE FROM TB_REQUISTION WHERE id='" & Val(txtID.Text) & "'")

            txtAppName.Text = ""
            txtAppNo.Text = ""
            cbAppType.SelectedIndex = 0
            cbFloor.SelectedIndex = 0
            cbCabinet.SelectedIndex = 0
            cbStatus.SelectedIndex = 0
            cbRoom.SelectedIndex = 0

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

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtAppName.Text = ""
        txtAppNo.Text = ""
        cbAppType.SelectedIndex = 0
        cbFloor.SelectedIndex = 0
        cbCabinet.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        cbRoom.SelectedIndex = 0
        txtID.Text = ""
        btnCancel.Enabled = False
        btnDelete.Enabled = False
        btnAdd.Enabled = True
        btnSearch.Enabled = True
        btnClear.Enabled = True
    End Sub

    Private Sub UploadFile()
        'Dim fd As OpenFileDialog = New OpenFileDialog()
        'Dim strFileName As String

        'fd.Title = "Open File Dialog"
        'fd.InitialDirectory = "C:\"
        'fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        'fd.FilterIndex = 2
        'fd.RestoreDirectory = True

        'If fd.ShowDialog() = DialogResult.OK Then
        '    strFileName = fd.FileName
        'End If
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Open File Dialog"
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "All files (*.xls)|*.xls|All files (*.xls)|*.xls"
        Dim filename As String = ""
        Dim path As String = ""
        If ofd.ShowDialog() = DialogResult.OK Then
            filename = System.IO.Path.GetFileName(ofd.FileName)
            path = System.IO.Path.GetDirectoryName(ofd.FileName)
        End If
        Dim strPath As String = path & "\" & filename
        txtFile.Text = strPath.Replace("\\", "\")
        If filename & "" <> "" Then
            btnUpload.Enabled = True
            imgIcon.Visible = True
        Else
            btnUpload.Enabled = False
            imgIcon.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        UploadFile()
    End Sub

    Private Sub OpenReports()

        Dim reportFolder As String

        Try
            'If File.Exists(Application.StartupPath & "\DIPCheckOut.txt") Then File.Delete(Application.StartupPath & "\DIPCheckOut.txt")

            reportFolder = Application.StartupPath & "\Format_S&I.xls"
            System.Diagnostics.Process.Start(reportFolder)

        Catch ex As Exception

            MsgBox("The file is not found on directory")

        End Try



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Template.Click
        OpenReports()
    End Sub

    Private Sub SaveData()
        If txtFile.Text = "" Then
            MsgBox("Please Input File")
            Exit Sub
        End If

        Dim ContentPath As String = txtFile.Text
        'fulAsset.SaveAs(ContentPath)

        Dim DT As New DataTable
        Dim Connstr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ContentPath & ";Extended Properties=""Excel 12.0 Macro;HDR=NO;IMEX=1"";"

        Dim Conn As New System.Data.OleDb.OleDbConnection(Connstr)

        Dim TB As New DataTable
        Try
            Conn.Open()
            TB = Conn.GetSchema("Tables")
            Conn.Dispose()
        Catch ex As Exception
            MsgBox("Please Input File")
            Exit Sub
            Conn.Dispose()
        End Try

        Dim TableName As String = TB.Rows(0).Item("TABLE_NAME")

        Dim sql As String = "SELECT * FROM [" & TableName & "]"
        Try
            Dim DA As New System.Data.OleDb.OleDbDataAdapter(sql, Connstr)
            DA.Fill(DT)
        Catch ex As Exception
            MsgBox("Please Input File")
            Exit Sub
            Conn.Dispose()
        End Try



        Dim CheckFormat As Boolean
        Try
            If DT.Rows.Count > 0 And DT.Rows(1)("F3") & "" <> "" And DT.Rows(1)("F4") & "" <> "" And DT.Rows(1)("F9") & "" <> "" Then
                CheckFormat = True
            Else
                CheckFormat = False
            End If
        Catch ex As Exception
            CheckFormat = False
        End Try
        If CheckFormat = False Then
            MsgBox("Input File Incorrect Format")
            Exit Sub
        End If



        DT.Rows(0).Delete()
        DT.AcceptChanges()

        DT.Columns("F1").ColumnName = "FilingNo"
        DT.Columns("F2").ColumnName = "FilingDate"
        DT.Columns("F3").ColumnName = "app_no"
        DT.Columns("F4").ColumnName = "app_name"
        DT.Columns("F5").ColumnName = "app_order"
        DT.Columns("F6").ColumnName = "app_Ref"
        DT.Columns("F7").ColumnName = "patent_type_id"
        DT.Columns("F8").ColumnName = "ApplicantNo"
        DT.Columns("F9").ColumnName = "tagrfid"


        For i As Integer = 0 To DT.Rows.Count - 1
            If ChkAppNo(Nothing, DT.Rows(i)("app_no") & "") = False Then
                Dim ret As Boolean = True
                Dim dal As New TbRequisitionDAL
                Dim trans As New SqlTransactionDB
                trans.CreateTransaction()
                Dim tagrfid As String = Func.strToHex(txtAppNo.Text.Trim)
                'Insert
                dal.APP_NO = DT.Rows(i)("app_no") & ""
                dal.APP_NAME = DT.Rows(i)("app_name") & ""
                dal.PATENT_TYPE_ID = SetPatentID(DT.Rows(i)("patent_type_id") & "")
                dal.TAGRFID = DT.Rows(i)("tagrfid") & ""
                dal.APP_ORDER = DT.Rows(i)("app_order") & ""
                dal.APP_REF = DT.Rows(i)("app_Ref") & ""
                dal.FilingNo = DT.Rows(i)("FilingNo") & ""
                If SetFormatDate(DT.Rows(i)("FilingDate") & "") <> "" Then
                    dal.FilingDate = SetFormatDate(DT.Rows(i)("FilingDate"))
                End If
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
                If ret = True Then
                    trans.CommitTransaction()
                Else
                    trans.RollbackTransaction()
                    MsgBox("Upload Fail") 'dal.ErrorMessage)
                    Exit For
                End If
            End If
        Next

        MsgBox("Upload Complete")


    End Sub

    Private Function ChkAppNo(ByVal trans As SqlTransaction, ByVal strApp_No As String) As Boolean
        Dim dal As New TbRequisitionDAL
        Return dal.ChkDataByWhere("App_No = '" & strApp_No.Replace("'", "''") & "' and id <> '" & Val(txtID.Text) & "'", trans)
    End Function

    Private Function SetPatentID(ByVal strCode As String) As Integer
        'ยืนยันเสร็จให้ลบ Temp
        Dim dt As DataTable = SqlDB.ExecuteTable("Select ID FROM TB_PATENT_TYPE WHERE patent_type_code='" & strCode & "'")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)(0)
        Else
            Return 0
        End If
    End Function
    Private Function SetFormatDate(ByVal strDate As String) As String
        If strDate <> "" Then
            Dim arr As String() = strDate.Split(".")
            If arr.Length = 3 Then
                Return SetYear(arr(0)) & "-" & arr(1) & "-" & arr(2)
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function

    Private Function SetYear(ByVal strYear As String) As String

        If strYear <> "" Then
            If strYear >= 81 And strYear <= 99 Then
                Return Val("19" & strYear) + 543
            Else
                Return Val("20" & strYear) + 543
            End If
        End If
    End Function

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        SaveData()
    End Sub
End Class