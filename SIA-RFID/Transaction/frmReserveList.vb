Imports DAL.View
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DAL.Table
Imports Data.Table
Imports DAL.Common.Utilities
Imports Data.Common.Utilities
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmReserveList

    Dim _err As String = ""
    Dim _ReserveID As Long

    Dim _officerid, _ReqNoFrom, _ReqNoTo, _Dateform, _Dateto, _JobNo As String
    Dim _Blank, _NoBlank, _AllBlank As RadioButton
    Dim _ClbType As New CheckedListBox

    WriteOnly Property Jobno()
        Set(ByVal value)
            _JobNo = value
        End Set
    End Property

    WriteOnly Property Blank()
        Set(ByVal value)
            _Blank = value

        End Set
    End Property

    WriteOnly Property NoBlank()
        Set(ByVal value)
            _NoBlank = value
        End Set
    End Property

    WriteOnly Property AllBlank()
        Set(ByVal value)
            _AllBlank = value
        End Set
    End Property

    WriteOnly Property ClbType() As CheckedListBox
        Set(ByVal value As CheckedListBox)
            _ClbType = value
        End Set
    End Property


    WriteOnly Property officerid() As String
        Set(ByVal value As String)
            _officerid = value
        End Set
    End Property

    WriteOnly Property RegNoFrom() As String
        Set(ByVal value As String)
            _ReqNoFrom = value
        End Set
    End Property

    WriteOnly Property RegNoTo() As String
        Set(ByVal value As String)
            _ReqNoTo = value
        End Set
    End Property

    WriteOnly Property Datefrom() As String
        Set(ByVal value As String)
            _Dateform = value
        End Set
    End Property

    WriteOnly Property Dateto() As String
        Set(ByVal value As String)
            _Dateto = value
        End Set
    End Property



    Private Sub frmReserveList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Panel1.BackgroundImage = Image.FromFile("images/blog2_03.jpg")
        PictureReserve.BackgroundImage = Image.FromFile("images/bg.png")
        'gbDetail.BackgroundImage = Image.FromFile("images/blog2_03.jpg")
        'btnBorrow.BackgroundImage = Image.FromFile("images/blog2_06.jpg")
        'btnBorrow.BackgroundImage = Image.FromFile("images/Dis_blog2_06.jpg")
        'btnPrint.BackgroundImage = Image.FromFile("images/Dis_blog2_08.jpg")
        'btnPrint.BackgroundImage = Image.FromFile("images/blog2_08.jpg")
        Button1.BackgroundImage = Image.FromFile("images/blog4_06.jpg")

    End Sub



    Public Sub ShowData()
        GridReserve.DataSource = Nothing

        Dim whText As String = " 1=1 "
        whText += IIf(_officerid <> "", " and member_id = '" & _officerid & "'", "")
        whText += IIf(_ReqNoFrom <> "", " and req_no >= '" & _ReqNoFrom & "'", "")
        whText += IIf(_ReqNoTo <> "", " and req_no <= '" & _ReqNoTo & "'", "")
        whText += IIf(_Dateform <> "", _Dateform, "")
        whText += IIf(_Dateto <> "", _Dateform, "")

        Dim strChkPatentType As String = GetChkPatentType()
        whText += IIf(strChkPatentType <> "", " and patent_type_name in " & strChkPatentType, "")
        If _Blank.Checked Then
            whText += " and reserve_status = 'Y' "
        ElseIf _NoBlank.Checked Then
            whText += " and reserve_status = 'N' "
        End If

        Dim dal As New ReserveListDAL
        Dim dt As DataTable = dal.GetDataList(whText, "convert(varchar(8),reserve_date,112),member_name ,req_no", Nothing)


        If dt.Rows.Count > 0 Then
            GridReserve.AutoGenerateColumns = False
            btnBorrow.BackgroundImage = Image.FromFile("images/blog2_06.jpg")
            btnPrint.BackgroundImage = Image.FromFile("images/blog2_08.jpg")
            dt.Columns.Add("seq")
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("seq") = i + 1
                dt.Rows(i)("reserve_status") = IIf(dt.Rows(i)("reserve_status").ToString = "Y", "ว่าง", "ไม่ว่าง")
            Next
            GridReserve.DataSource = dt
            lblNum.Text = dt.Rows.Count

            'If txtOfficerID.Text.Trim <> "" Then
            btnBorrow.Enabled = True
            btnPrint.Enabled = True

            btnSelectAll.Enabled = True
            GridReserve.Columns("chkSelect").ReadOnly = False
            'End If

            Dim frm As New frmReserveList
        

      

        Else
            MsgBox("No data", MsgBoxStyle.Information)
            btnBorrow.BackgroundImage = Image.FromFile("images/Dis_blog2_06.jpg")
            btnPrint.BackgroundImage = Image.FromFile("images/Dis_blog2_08.jpg")
        End If

    End Sub

    Private Function GetChkPatentType() As String
        Dim ret As String = ""
        'For i As Integer = 0 To CLBType.Items.Count
        If _ClbType.CheckedItems.Count > 0 Then
            Dim chkItem As String = ""
            For i As Integer = 0 To _ClbType.CheckedItems.Count - 1
                If chkItem = "" Then
                    chkItem = "'" & _ClbType.CheckedItems(i) & "'"
                Else
                    chkItem += ", '" & _ClbType.CheckedItems(i) & "'"
                End If
            Next
            ret = "(" & chkItem & ")"
        Else
            ret = "(" & "null" & ")"
        End If

        Return ret

    End Function

    Function GetDate(ByVal arg As String) As String
        Dim txt As String = ""
        Try
            Dim argDate As Date = CDate(arg)

        Catch ex As Exception
            MessageBox.Show("Form of date incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        Return txt
    End Function

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        If txtSelectedAll.Text = "N" Then
            For i As Integer = 0 To GridReserve.RowCount - 1
                GridReserve.Rows(i).Cells("chkSelect").Value = "Y"
            Next
            txtSelectedAll.Text = "Y"
        Else
            For i As Integer = 0 To GridReserve.RowCount - 1
                GridReserve.Rows(i).Cells("chkSelect").Value = "N"
            Next
            txtSelectedAll.Text = "N"
        End If
    End Sub

    Private Sub btnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrow.Click
        If CheckStatus() = False Then
            'btnBorrow.BackgroundImage = Image.FromFile("images/blog2_06.jpg")
            Exit Sub
        End If

        Me.Cursor = Cursors.AppStarting
        btnBorrow.Enabled = False

        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        If SaveReserveJob(trans.Trans) = True Then
            trans.CommitTransaction()
            Dim frm As New frmBorrow
            frm.MdiParent = frmMain
            frm.StartPosition = FormStartPosition.CenterScreen
            Dim dal As New TbReserveJobDAL
            dal.GetDataByid(_ReserveID, Nothing)
            frm.txtJobNo.Text = dal.JOB_NO
            frm.ShowData(dal.JOB_NO)
            frm.Show()

            Me.Close()
            Me.Dispose()
        Else
            trans.RollbackTransaction()
            MsgBox(_err, MsgBoxStyle.Critical)
        End If

        Me.Cursor = Cursors.Default
        btnBorrow.Enabled = True
        'btnBorrow.BackgroundImage = Image.FromFile("images/blog2_06.jpg")

    End Sub


    Function CheckStatus() As Boolean
        Dim ret As Boolean = False
        If GridReserve.RowCount > 0 Then
            For i As Int32 = 0 To GridReserve.RowCount - 1
                If GridReserve.Rows(i).Cells("chkSelect").Value = "Y" And GridReserve.Rows(i).Cells("reserve_status").Value = "ไม่ว่าง" Then
                    MsgBox("The files then Borrowed.")
                    Return False
                End If
            Next
        End If
        Return True
    End Function

    Private Function GenReserveCode(ByVal trans As SqlTransaction) As String
        'Reserve Code Format : yyMM0000 เช่น 531201
        Dim ret As String = ""
        Dim vMM As String = Today.Month.ToString.PadLeft(2, "0")
        Dim vYY As String
        If Today.Year > 2500 Then
            vYY = Today.Year.ToString.Substring(2, 2)
        Else
            vYY = (Today.Year + 543).ToString.Substring(2, 2)
        End If

        Dim runNext As Int64
        Dim dal As New TbReserveJobDAL
        Dim dt As DataTable = dal.GetDataList("substring(job_no,1,4) = '" & vYY & vMM & "'", "job_no desc", trans)
        If dt.Rows.Count > 0 Then
            runNext = Convert.ToInt64(dt.Rows(0)("job_no").ToString.Substring(4)) + 1
        Else
            runNext = 1
        End If

        ret = vYY & vMM & runNext.ToString.PadLeft(4, "0")
        Return ret
    End Function

    Private Function SaveReserveJob(ByVal trans As SqlTransaction) As Boolean
        Dim ret As Boolean = False
        Dim rowChk As Boolean = False
        For i As Integer = 0 To GridReserve.RowCount - 1
            If GridReserve.Rows(i).Cells("chkSelect").Value = "Y" Then
                rowChk = True
                Exit For
            End If
        Next

        If rowChk = True Then
            Dim memberID As Long
            Dim dtMem As New DataTable
            dtMem.Columns.Add("member_id")
            dtMem.Columns.Add("member_name")
            For i As Integer = 0 To GridReserve.RowCount - 1
                If GridReserve.Rows(i).Cells("chkSelect").Value = "Y" Then
                    If GridReserve.Rows(i).Cells("member_id").Value <> memberID Then
                        memberID = GridReserve.Rows(i).Cells("member_id").Value
                        Dim dal As New TbOfficerDAL
                        Dim data As New TbOfficerData
                        data = dal.GetDataByid(memberID, Nothing)

                        Dim dr As DataRow = dtMem.NewRow
                        dr("member_id") = data.ID
                        dr("member_name") = data.FNAME & " " & data.LNAME
                        dtMem.Rows.Add(dr)
                    End If
                End If
            Next

            If dtMem.Rows.Count > 1 Then
                _err = "Please select the item for 1 user."
                Return False
            End If

            For Each dr As DataRow In dtMem.Rows
                Dim jobDal As New TbReserveJobDAL
                If _JobNo <> "" Then
                    jobDal.GetDataByJOB_NO(_JobNo, trans)
                Else
                    jobDal.JOB_NO = GenReserveCode(trans)
                End If
                jobDal.JOB_DATE = DateTime.Now
                jobDal.MEMBER_ID = Convert.ToInt64(dr("member_id"))
                jobDal.MEMBER_NAME = dr("member_name")

                If _JobNo = "" Then
                    ret = jobDal.InsertData(frmMain.txtUserName.Text, trans)
                Else
                    ret = jobDal.UpdateByJOB_NO(_JobNo, frmMain.txtUserName.Text, trans)
                End If

                If ret = False Then
                    _err = jobDal.ErrorMessage
                    Return False
                End If

                If ret = True Then
                    _ReserveID = jobDal.ID
                    Dim Sql As String = "update tb_reserve set reserve_job_id = null where reserve_job_id = " & _ReserveID
                    SqlDB.ExecuteNonQuery(Sql, trans)
                    For i As Integer = 0 To GridReserve.RowCount - 1
                        If GridReserve.Rows(i).Cells("chkSelect").Value = "Y" Then
                            If GridReserve.Rows(i).Cells("member_id").Value = dr("member_id") Then
                                Dim jobItemDal As New TbReserveDAL
                                jobItemDal.GetDataByid(GridReserve.Rows(i).Cells("id").Value, trans)
                                jobItemDal.RESERVE_JOB_ID = jobDal.ID
                                ret = jobItemDal.UpdateByid(frmMain.txtUserName.Text, trans)
                                If ret = False Then
                                    _err = jobItemDal.ErrorMessage
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                Else
                    ret = False
                    _err = jobDal.ErrorMessage
                End If
            Next
        Else
            ret = False
            _err = "Please select the reserve items."
        End If

        Return ret

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmReserve
        frm.MdiParent = frmMain
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
        Me.Close()
    End Sub

    Private Sub frmReserveList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.ControlBox = False
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If CheckStatus() = False Then
            Exit Sub
        End If

        Me.Cursor = Cursors.AppStarting
        btnPrint.Enabled = False
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        If SaveReserveJob(trans.Trans) = True Then
            trans.CommitTransaction()

            Dim rDal As New TbReserveJobDAL
            rDal.GetDataByid(_ReserveID, Nothing)
            _JobNo = rDal.JOB_NO

            Dim logonInfo As New TableLogOnInfo
            logonInfo.ConnectionInfo.DatabaseName = SqlDB.DbName
            logonInfo.ConnectionInfo.UserID = SqlDB.UserID
            logonInfo.ConnectionInfo.Password = SqlDB.Password

            Dim rep As New rptReserve
            rep.SetDataSource(GetReserveData(_ReserveID))
            rep.Database.Tables(0).ApplyLogOnInfo(logonInfo)

            Dim cryViewer As New frmReportPreview
            cryViewer.CrystalReportViewer1.ReportSource = rep
            cryViewer.CrystalReportViewer1.Refresh()
            cryViewer.WindowState = FormWindowState.Maximized
            cryViewer.Show()
        Else
            trans.RollbackTransaction()
            MsgBox(_err, MsgBoxStyle.Critical)
        End If
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
    End Sub

    Private Function GetReserveData(ByVal ReserveID As Long) As DataTable
        Dim rowPerCol As Integer = 25  'จำนวนแถวใน 1 คอลัมน์ ให้แสดงหน้าละ 3 คอลัมน์
        Dim ret As New DataTable
        Dim sql As String = ""
        'sql = "select 1 run1, '0000001' req_no1, 1 reserve_order1, "
        'sql += "26 run2, '0000026' req_no2, 1 reserve_order2,"
        'sql += "51 run3, '0000051' req_no3, 1 reserve_order3 "
        'Dim sql As String = "select  isnull(rq.app_no,rq.req_no) req_no, r.reserve_order, r.reserve_job_id, rj.job_no, rj.job_date,"
        'sql += " isnull(tm.title_name,'') + tbm.fname + ' ' + tbm.lname staff_name,"
        'sql += " isnull(tc.title_name,'') + tbc.fname + ' ' + tbc.lname createby_staff_name"
        'sql += " from TB_RESERVE r "
        'sql += " inner join TB_REQUISTION rq on rq.id=r.requidition_id"
        'sql += " inner join TB_RESERVE_JOB rj on rj.id=r.reserve_job_id"
        'sql += " left join TB_OFFICER tbm on tbm.id=rj.member_id"
        'sql += " left join TB_TITLE tm on tm.id=tbm.title_id"
        'sql += " left join TB_OFFICER tbc on tbc.username=rj.createby"
        'sql += " left join TB_TITLE tc on tc.id=tbc.title_id"
        'sql += " where r.reserve_job_id = '" & ReserveID.ToString & "'"

        sql = "declare @printdate as varchar(50); select @printdate = convert(varchar(10),dateadd(yyyy,543,GETDATE()),103)"

        sql += " select @printdate as printdate,req_no,reserve_order,reserve_job_id,job_no,job_date,staff_name,createby_staff_name,isnull(borrowername,'ว่าง') as borrowername"
        sql += " from "
        '-----------Query เดิม----------
        sql += " ("
        sql += " select rq.id,isnull(rq.app_no,rq.req_no) req_no, r.reserve_order, r.reserve_job_id, rj.job_no, rj.job_date, isnull(tm.title_name,'') + tbm.fname + ' ' + tbm.lname staff_name, isnull(tc.title_name,'') + tbc.fname + ' ' + tbc.lname createby_staff_name from TB_RESERVE r  inner join TB_REQUISTION rq on rq.id=r.requidition_id inner join TB_RESERVE_JOB rj on rj.id=r.reserve_job_id left join TB_OFFICER tbm on tbm.id=rj.member_id left join TB_TITLE tm on tm.id=tbm.title_id left join TB_OFFICER tbc on tbc.username=rj.createby left join TB_TITLE tc on tc.id=tbc.title_id "
        sql += " where r.reserve_job_id = '" & ReserveID.ToString & "'"
        '-----------------------------
        sql += " ) as TB1"
        sql += " Left Join"
        sql += " ("
        sql += " select fb_item.requisition_id,fb.borrowername from TB_FILEBORROWITEM as fb_item left join TB_FILEBORROW as fb on fb_item.fileborrow_id = fb.id where ISNULL(fb_item.returndate,'') = ''"
        sql += " ) as TB2"
        sql += " on TB1.id = TB2.requisition_id "

        Dim dal As New TbReserveDAL
        Dim dt As DataTable = dal.GetListBySql(sql, "req_no", Nothing)
        Dim rowCount As Integer = dt.Rows.Count
        If rowCount > 0 Then
            ret.Columns.Add("run1")
            ret.Columns.Add("req_no1")
            ret.Columns.Add("reserve_order1")
            ret.Columns.Add("status1")
            ret.Columns.Add("run2")
            ret.Columns.Add("req_no2")
            ret.Columns.Add("reserve_order2")
            ret.Columns.Add("status2")
            ret.Columns.Add("job_no")
            ret.Columns.Add("job_date")
            ret.Columns.Add("staff_name")
            ret.Columns.Add("createby_staff_name")
            ret.Columns.Add("filecount")
            ret.Columns.Add("printdate")
            Dim colNo As Integer = 1
            Dim rowNo As Integer = 1
            Dim pageNo As Integer = 1
            For i As Integer = 0 To rowCount - 1
                Dim iRow As Integer = i + 1
                pageNo = Math.Ceiling(iRow / (2 * rowPerCol))
                colNo = Math.Ceiling((iRow - ((2 * rowPerCol) * (pageNo - 1))) / rowPerCol)
                rowNo = iRow - ((rowPerCol * 2) * (pageNo - 1)) - (rowPerCol * (colNo - 1))
                Dim dtRow = rowNo + (rowPerCol * (pageNo - 1))

                If colNo = 1 Then
                    Dim dr As DataRow = ret.NewRow()
                    dr("run1") = i + 1
                    dr("req_no1") = dt.Rows(i)("req_no")
                    dr("reserve_order1") = dt.Rows(i)("reserve_order")
                    dr("status1") = dt.Rows(i)("borrowername")
                    dr("job_no") = dt.Rows(i)("job_no")
                    dr("job_date") = Convert.ToDateTime(dt.Rows(i)("job_date")).ToString("dd/MM/yyyy")
                    dr("staff_name") = dt.Rows(i)("staff_name")
                    dr("createby_staff_name") = dt.Rows(i)("createby_staff_name")
                    dr("filecount") = rowCount
                    dr("printdate") = dt.Rows(i)("printdate")
                    ret.Rows.Add(dr)
                End If
                If colNo = 2 Then
                    ret.Rows(dtRow - 1)("run2") = i + 1
                    ret.Rows(dtRow - 1)("req_no2") = dt.Rows(i)("req_no")
                    ret.Rows(dtRow - 1)("reserve_order2") = dt.Rows(i)("reserve_order")
                    ret.Rows(dtRow - 1)("status2") = dt.Rows(i)("borrowername")
                End If
                If colNo = 3 Then
                    ret.Rows(dtRow - 1)("run3") = i + 1
                    ret.Rows(dtRow - 1)("req_no3") = dt.Rows(i)("req_no")
                    ret.Rows(dtRow - 1)("reserve_order3") = dt.Rows(i)("reserve_order")
                End If

                If (rowNo * pageNo) = (rowPerCol * pageNo) Then
                    colNo = colNo + 1
                    rowNo = 1
                Else
                    rowNo = rowNo + 1
                End If
                If colNo > 3 Then
                    colNo = 1 'เริ่มนับหนึ่งใหม่ เพื่อให้ขึ้นหน้าใหม่
                    pageNo = pageNo + 1
                    rowNo = 1 + (pageNo * rowPerCol)
                End If
            Next

        End If

        Return ret
    End Function

    Private Sub frmReserveList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Dim dal As New TbPatentTypeDAL
        'Dim dt As DataTable = dal.GetDataList("1=1", "patent_type_code", Nothing)

        'ShowData()
    End Sub



    Private Sub GridReserve_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub lblNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gbDetail_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


End Class