Imports System.Data.SqlClient

Public Class frm_Report
    Inherits System.Web.UI.Page

    Const ColNoAppNo As Integer = 6

#Region "Declare Class & Paramater"
    Dim StrConn As String = ConfigurationManager.ConnectionStrings("SIAConnectionString").ConnectionString
    Private sql As String
#End Region

#Region "Init"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            PoplateCheckBoxList()
            PopulateData()
        End If
    End Sub

    Private Sub PopulateData()
        gvData.DataSource = GetSource
        gvData.DataBind()
    End Sub

    Private Sub PoplateCheckBoxList()
        CLBType.DataSource = GetSource_Patentype()
        CLBType.DataTextField = "patent_type_name"
        CLBType.DataValueField = "id"
        CLBType.DataBind()
    End Sub

    Private Function GetSource_Patentype() As DataTable
        sql = "SELECT * FROM TB_PATENT_TYPE "
        Dim strOrder As String = " Order By patent_type_code"
        Dim DAPatentype As New SqlDataAdapter(sql & strOrder, StrConn)
        Dim DTPatentype As New DataTable
        DAPatentype.Fill(DTPatentype)

        Return DTPatentype
    End Function
    Private Function GetSource() As DataTable
        Try
            sql = "select TB_REQUISTION.id,TB_REQUISTION.app_no,app_name, CASE WHEN ISNULL(br.BORROWSTATUS, '') = '' THEN 'Y' ELSE 'N' END AS status ,patent_type_id ,patent_type_name "
            sql += " from TB_REQUISTION Left Join  TB_PATENT_TYPE on TB_REQUISTION.patent_type_id = TB_PATENT_TYPE.id "
            sql += " left join (select distinct RT.app_no,RS.reserve_status,RS.borrowstatus from TB_RESERVE RS"
            sql += " inner join TB_REQUISTION RT on RS.requidition_id= RT.id"
            sql += " where (BORROWSTATUS IN ('B', 'T', 'A'))) as br on br.app_no=TB_REQUISTION.app_no where "
            Dim whText As String = " 1=1 "
            whText += IIf(txtAppNo.Text.Trim <> "", " and TB_REQUISTION.app_no like '%" & txtAppNo.Text.Trim & "%'", "")
            whText += IIf(txtAppName.Text.Trim <> "", " and TB_REQUISTION.app_name like '%" & txtAppName.Text.Trim & "%'", "")
            whText += IIf(GetChkPatentType() <> "", " and patent_type_name in " & GetChkPatentType(), "")
            If rdbSelect.SelectedValue = 1 Then
                whText += " and isnull(br.reserve_status,'Y') = 'Y' "
            ElseIf rdbSelect.SelectedValue = 2 Then
                whText += " and isnull(br.reserve_status,'Y') = 'N' "
            End If
            Dim strOrder As String = " Order By app_no"
            Dim DA As New SqlDataAdapter(sql & whText & strOrder, StrConn)
            Dim DT As New DataTable
            DA.Fill(DT)


            If DT.Rows.Count > 0 Then
                DT.Columns.Add("seq")
                For i As Integer = 0 To DT.Rows.Count - 1
                    DT.Rows(i)("seq") = i + 1
                    DT.Rows(i)("status") = IIf(DT.Rows(i)("status").ToString = "Y", "Available", "Not Available")
                Next

            End If

            Return DT
        Catch ex As Exception
            Response.Write(ex.Message.ToString)
        End Try

    End Function

    Sub ShowPageCommand(ByVal s As Object, ByVal e As GridViewPageEventArgs)
        gvData.PageIndex = e.NewPageIndex
        gvData.DataBind()
    End Sub


#End Region

#Region "Event Handled"
    Private Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles gvData.PageIndexChanging
        gvData.PageIndex = e.NewPageIndex
        gvData.DataSource = GetSource()
        gvData.DataBind()
    End Sub

    Private Sub lbtnSearch_Click(sender As Object, e As EventArgs) Handles lbtnSearch.Click
        PopulateData()
    End Sub
#End Region

#Region "Function"
    Private Function SetDate(strDate As String)
        If strDate <> "" Then
            Dim strtemp As String() = strDate.Split("/")
            Dim d As String = strtemp(0)
            Dim m As String = strtemp(1)
            Dim y As String = strtemp(2)
            If d.Length = 1 Then d = "0" & d
            If m.Length = 1 Then m = "0" & m
            ' Return " Convert(varchar(10),'" & d & "/" & m & "/" & y & "',103)"
            Return " cast(convert(char(11), '" & m & "/" & d & "/" & y & "', 113) as datetime)"
        Else
            Return ""
        End If
    End Function

    Private Function GetDateFromText(ByVal strTextDate As String, ByVal strDateFormat As String) As Date
        Try
            Dim c As New Globalization.CultureInfo("th-TH")
            c.DateTimeFormat.LongDatePattern = strDateFormat
            GetDateFromText = Date.ParseExact(strTextDate, "D", c)
        Catch ex As Exception
        End Try
    End Function

    Private Function GetChkPatentType() As String
        Dim ret As String = ""
        Dim chkItem As String = ""
        If CLBType.Items.Count > 0 Then

            For i As Integer = 0 To CLBType.Items.Count - 1
                If CLBType.Items.Item(i).Selected = True Then
                    If chkItem = "" Then
                        chkItem = "'" & CLBType.Items(i).Text & "'"
                    Else
                        chkItem += ", '" & CLBType.Items(i).Text & "'"
                    End If
                End If

            Next
       End If

        If chkItem <> "" Then
            ret = " ( " & chkItem & " )"
        Else
            ret = ""
        End If
        Return ret

    End Function
#End Region

    Private Function GenReserveCode() As String
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
        Dim sql As String = "Select * from TB_RESERVE_JOB where substring(job_no,1,4) = '" & vYY & vMM & "' order by job_no desc"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, StrConn)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            runNext = Convert.ToInt64(dt.Rows(0)("job_no").ToString.Substring(4)) + 1
        Else
            runNext = 1
        End If

        ret = vYY & vMM & runNext.ToString.PadLeft(4, "0")
        Return ret
    End Function



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim conn As New SqlConnection(StrConn)
        If conn.State = ConnectionState.Closed Then conn.Open()

        Dim trans As SqlTransaction
        trans = conn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)
        Dim job_no As String = GenReserveCode()

        Dim sql As String = "Select isnull((select MAX(isnull(id,0))from TB_RESERVE_JOB),0) +1 " '"select MAX(isnull(id,0)) +1 from TB_RESERVE_JOB"
        Dim cmd As New SqlCommand()
        With cmd
            .CommandText = sql
            .Connection = conn
            .Transaction = trans
        End With
        Dim job_id As Long = cmd.ExecuteScalar
        lblJobID.Text = job_id

        sql = "INSERT INTO [dbo].[TB_RESERVE_JOB]"
        sql += "([id]"
        sql += " ,[job_no]"
        sql += " ,[job_date]"
        sql += ",[member_id]"
        sql += " ,[member_name]"
        sql += " ,[createby]"
        sql += " ,[createon])"
        sql += " VALUES"
        sql += " ('" & job_id & "',"
        sql += " '" & job_no & "',GETDATE()"
        sql += " ,'" & Session("member_id") & "'"
        sql += ",'" & Session("member_name") & "'"
        sql += ",'" & Session("Username") & "'"
        sql += " ,GETDATE())"
        cmd.CommandText = sql
        If cmd.ExecuteNonQuery > 0 Then
            For Each item As GridViewRow In gvData.Rows
                Dim chk As CheckBox = item.FindControl("ckbSelect")
                If chk.Checked = False Then Continue For
                Dim requisition_id As String = item.Cells(ColNoAppNo).Text

                sql = "select count(*) +1 from TB_RESERVE Where borrowstatus in ('S','B') and requidition_id='" & requisition_id & "'"
                cmd.CommandText = sql
                Dim job_order As Long = cmd.ExecuteScalar

                sql = "INSERT INTO [dbo].[TB_RESERVE]"
                sql += " ([id]"
                sql += ",[requidition_id]"
                sql += ",[reserve_order]"
                sql += ",[reserve_job_id]"
                sql += ",[reserve_status]"
                sql += " ,[borrowstatus]"
                sql += ",[member_id]"
                sql += " ,[member_name]"
                sql += " ,[reserve_date]"
                sql += " ,[createby]"
                sql += " ,[createon])"
                sql += " VALUES"
                sql += "  ((Select isnull((select MAX(isnull(id,0)) +1 from TB_RESERVE),0) +1 )"
                sql += " ,'" & requisition_id & "'"
                sql += "  ,'" & job_order & "'"
                sql += " ,'" & job_id & "'"
                sql += " ,'" & IIf(job_order = 1, "Y", "N") & "'"
                sql += " ,'S'"
                sql += "  ,'" & Session("member_id") & "'"
                sql += ",'" & Session("member_name") & "',GETDATE()"
                sql += "  ,'" & Session("Username") & "',GETDATE())"
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            Next

            trans.Commit()
            'ScriptManager.RegisterStartupScript(Me, Me.GetType, "script", "alert('ทำการจองเรียบร้อยแล้ว');", True)
        Else
            trans.Rollback()
        End If
        conn.Close()

        If lblJobID.Text = "" Then Exit Sub
        Dim scr As String = "window.open('frmPrint.aspx?JobID=" & lblJobID.Text & "&JobNo=" & job_no & "', '_blank', 'height=600,width=1000,left=200,top=200,location=no,menubar=no,toolbar=no,status=yes,resizable=yes,scrollbars=yes', true);"
        'Dim scr As String = "OpenResultWindow('" & lblJobID.Text & "')"
        ScriptManager.RegisterStartupScript(Me, GetType(String), "ShowReport", scr, True)

    End Sub

    Private Function item(p1 As String) As String
        Throw New NotImplementedException
    End Function

    'Protected Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
    '    If lblJobID.Text = "" Then Exit Sub
    '    Dim scr As String = "window.open('frmPrint.aspx?JobNo=" & lblJobID.Text & "', '_blank', 'height=650,left=600,location=no,menubar=no,toolbar=no,status=yes,resizable=yes,scrollbars=yes', true);"
    '    ScriptManager.RegisterStartupScript(Me, GetType(String), "ShowReport", scr, True)
    'End Sub


End Class