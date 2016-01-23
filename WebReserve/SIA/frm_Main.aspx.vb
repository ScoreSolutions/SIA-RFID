
Imports System.Data.SqlClient
Public Class frm_Main
    Inherits System.Web.UI.Page
#Region "Declare Class & Paramater"
    Dim StrConn As String = ConfigurationManager.ConnectionStrings("SIAConnectionString").ConnectionString
    Private sql As String
#End Region

#Region "Init"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            PopulateData()
        End If
    End Sub

    Private Sub PopulateData()
        GridView1.DataSource = GetSourceReserve() 'GetSource()
        GridView1.DataBind()
    End Sub

    Private Function GetSource() As DataTable
        sql = "select id,job_no,CONVERT(varchar(10), DATEADD(year, 543,job_date), 103) job_date,member_name from TB_RESERVE_JOB  where "
        Dim whText As String = " member_id =" & Val(Session("member_id") & "")

        Dim strOrder As String = " Order By job_date desc"
        Dim DA As New SqlDataAdapter(sql & whText & strOrder, StrConn)
        Dim DT As New DataTable
        DA.Fill(DT)

        If DT.Rows.Count > 0 Then
            DT.Columns.Add("seq")
            For i As Integer = 0 To DT.Rows.Count - 1
                DT.Rows(i)("seq") = i + 1
                ' DT.Rows(i)("reserve_status") = IIf(DT.Rows(i)("reserve_status").ToString = "Y", "ว่าง", "ไม่ว่าง")
            Next
        End If

        Return DT
    End Function

    Private Function GetSourceReserve() As DataTable
        sql = " select  RJ.job_no,R.app_no, R.app_name, "
        sql &= " P.patent_type_name,S.borrowstatus,tmp.borrowdate,tmp.borrower_name,(case when isnull(tmp.borrower_name,'') = '' then 'Available' else 'Not Available' end ) as status from TB_RESERVE  S"
        sql &= " left join TB_REQUISTION R on S.requidition_id=R.id"
        sql &= " left join TB_PATENT_TYPE P on R.patent_type_id = P.id"
        sql &= " left join (select distinct RT.app_no,RS.reserve_status,RS.borrowstatus from TB_RESERVE RS"
        sql &= " inner join TB_REQUISTION RT on RS.requidition_id= RT.id"
        sql &= " where (BORROWSTATUS IN ('B', 'T', 'A'))) as br on br.app_no=R.app_no "
        sql &= " left join TMP_FILEBORROWITEM tmp on tmp.app_no =R.app_no"
        sql &= " inner join TB_RESERVE_JOB RJ on RJ.id = S.reserve_job_id"
        sql &= " WHERE S.member_id= " & Session("member_id") & " and S.borrowstatus <>'R' and S.borrowstatus ='S' "
        Dim DA As New SqlDataAdapter(sql, StrConn)
        Dim DT As New DataTable
        DA.Fill(DT)

        If DT.Rows.Count > 0 Then
            DT.Columns.Add("seq")
            For i As Integer = 0 To DT.Rows.Count - 1
                DT.Rows(i)("seq") = i + 1
                ' DT.Rows(i)("reserve_status") = IIf(DT.Rows(i)("reserve_status").ToString = "Y", "ว่าง", "ไม่ว่าง")
            Next
        End If

        Return DT
    End Function

    Sub ShowPageCommand(ByVal s As Object, ByVal e As GridViewPageEventArgs)
        GridView1.PageIndex = e.NewPageIndex
        GridView1.DataBind()
    End Sub




#End Region

#Region "Event Handled"
    Private Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        GridView1.DataSource = GetSourceReserve()
        GridView1.DataBind()
    End Sub
#End Region


    Private Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound

        Select Case e.Row.RowType
            Case DataControlRowType.DataRow
                If Not IsNothing(e.Row.DataItem("status")) Then
                    If e.Row.DataItem("status") = "Available" Then
                        e.Row.BackColor = Drawing.Color.GreenYellow
                    Else
                        e.Row.BackColor = Drawing.Color.OrangeRed
                    End If

                End If
        End Select

    End Sub
End Class