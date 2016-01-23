Imports System.Data
Imports System.Data.SqlClient
Public Class frmPrint
    Inherits System.Web.UI.Page
    Dim StrConn As String = ConfigurationManager.ConnectionStrings("SIAConnectionString").ConnectionString
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowReport()
    End Sub

    Private Sub ShowReport()
        ' If Request.QueryString("JobNo").ToString = "" Then Exit Sub
        Try
            Dim tempData As DataTable = New DataTable()
            Dim con As New SqlConnection(StrConn)
            Dim sql As String = "select  R.app_no, R.app_name,CASE WHEN ISNULL(br.BORROWSTATUS, '') = '' THEN 'Y' ELSE 'N' END AS status , "
            sql += " P.patent_type_name from TB_RESERVE  S"
            sql += " left join TB_REQUISTION R on S.requidition_id=R.id"
            sql += " left join TB_PATENT_TYPE P on R.patent_type_id = P.id"
            sql += " left join (select distinct RT.app_no,RS.reserve_status,RS.borrowstatus from TB_RESERVE RS"
            sql += " inner join TB_REQUISTION RT on RS.requidition_id= RT.id"
            sql += " where (BORROWSTATUS IN ('B', 'T', 'A'))) as br on br.app_no=R.app_no "
            sql += " where reserve_job_id='" & Request.QueryString("JobID") & "'"
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            adapter.Fill(tempData)
            con.Close()
            If tempData.Rows.Count > 0 Then
                For i As Integer = 0 To tempData.Rows.Count - 1
                    tempData.Rows(i)("status") = IIf(tempData.Rows(i)("status").ToString = "Y", "Available", "Not Available")
                Next
            End If

            If tempData.Rows.Count > 0 Then
                RenderReport(tempData, Request.QueryString("JobNo"), Session("member_name"))
            End If
            tempData.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RenderReport(ByVal dt As DataTable, JobNo As String, ReserveBy As String)

        If dt.Rows.Count > 0 Then
            Dim ret As New StringBuilder
            ret.Append("<table width=""900px"" border='1' cellpadding='0' cellspacing='0' class='mGrid' >")

            '### Header Colums Start ######
            ret.Append("    <tr style='background: yellowgreen repeat-x top;font-weight: bold;' >")
            ret.Append("        <td  align='left' style='color: #ffffff;' colspan='5'>" & "Job No : " & JobNo & "</td>")
            ret.Append("    </tr>")
            ret.Append("    <tr style='background: yellowgreen repeat-x top;font-weight: bold;' >")
            ret.Append("        <td  align='left' style='color: #ffffff;' colspan='5'>" & "Reserve By : " & ReserveBy & "</td>")
            ret.Append("    </tr>")
            Dim strHeader As String() = { _
                                       "Our Ref", _
                                       "Applicant", _
                                       "Status", _
                                       "Applocation Type"}
            ret.Append("    <tr style='background: yellowgreen repeat-x top;font-weight: bold;' >")
            For intHeader As Integer = 0 To strHeader.Count - 1
                ret.Append("        <td  align='center' style='color: #ffffff;' >" & strHeader(intHeader) & "</td>")
            Next
            ret.Append("    </tr>")
            '### Header Colums End ######

            For i As Integer = 0 To dt.Rows.Count - 1
                ret.Append("    <tr style='background: #E4E4E4;'>")
                ret.Append("        <td align='center' >" & dt.Rows(i).Item("App_No").ToString & "</td>")
                ret.Append("        <td align='left' > " & dt.Rows(i).Item("App_Name").ToString & "</td>")
                ret.Append("        <td align='left' >" & dt.Rows(i).Item("Status").ToString & "</td>")
                ret.Append("        <td align='left' >" & dt.Rows(i).Item("Patent_Type_Name").ToString & "</td>")
                ret.Append("    </tr>")
            Next

            ret.Append("</table>")

            lblReportDesc.Text = ret.ToString
            ret = Nothing
        End If

        If lblReportDesc.Text.Trim <> "" Then
            lblerror.Visible = False
        End If
    End Sub

End Class