Imports System.Data.SqlClient
Public Class frmReserve
    Inherits System.Web.UI.Page

#Region "Declare Class & Paramater"
    Dim StrConn As String = ConfigurationManager.ConnectionStrings("SIAConnectionString").ConnectionString
    Private sql As String
#End Region

    Const sessionName As String = "selectfile"
    Const ColNoAppNo As Integer = 5
    Private Sub frmReserve_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Session("ISSelectFile") Then
            AddFile(Session(sessionName))
            Session.Remove("ISSelectFile")
            Session.Remove(sessionName)
        End If
        If IsPostBack = False Then
            Session.Remove(sessionName)
            btnSearch.Attributes.Add("onclick", "showModal('frmSelectFile.aspx',900,800,0)")
        End If

    End Sub

    Sub AddFile(NewData As DataTable)
        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("app_no")
        dt.Columns.Add("app_name")
        dt.Columns.Add("Status")
        dt.Columns.Add("patent_type_name")
        Dim dr As DataRow
        For Each item As GridViewRow In gvData.Rows
            dr = dt.NewRow
            dr("id") = Replace(item.Cells(5).Text, "&nbsp;", "")
            dr("app_no") = Replace(item.Cells(1).Text, "&nbsp;", "")
            dr("app_name") = Replace(item.Cells(2).Text, "&nbsp;", "")
            dr("Status") = Replace(item.Cells(4).Text, "&nbsp;", "")
            dr("patent_type_name") = Replace(item.Cells(3).Text, "&nbsp;", "")
            dt.Rows.Add(dr)
        Next


        If Not NewData Is Nothing Then
            For k As Integer = 0 To NewData.Rows.Count - 1
                Dim tempDR() As DataRow = dt.Select(" ID ='" & Replace(NewData.Rows(k).Item("ID").ToString, "&nbsp;", "") & "'")
                If tempDR.Length = 0 Then
                    dr = dt.NewRow
                    dr("id") = Replace(NewData.Rows(k).Item("id").ToString, "&nbsp;", "")
                    dr("app_no") = Replace(NewData.Rows(k).Item("app_no").ToString, "&nbsp;", "")
                    dr("app_name") = Replace(NewData.Rows(k).Item("app_name").ToString, "&nbsp;", "")
                    dr("Status") = Replace(NewData.Rows(k).Item("Status").ToString, "&nbsp;", "")
                    dr("patent_type_name") = Replace(NewData.Rows(k).Item("patent_type_name").ToString, "&nbsp;", "")
                    dt.Rows.Add(dr)
                End If
            Next
        End If

        If dt.Rows.Count > 0 Then
            dt.Columns.Add("seq")
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("seq") = i + 1
            Next
        End If

        gvData.DataSource = dt
        gvData.DataBind()
    End Sub

    Sub ShowPageCommand(ByVal s As Object, ByVal e As GridViewPageEventArgs)
        gvData.PageIndex = e.NewPageIndex
        gvData.DataBind()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gvData.Rows.Count = 0 Then
            ScriptManager.RegisterStartupScript(Me, GetType(String), "ShowReport", "alert('Please Select Applicant');", True)
            Exit Sub
        End If


        Dim conn As New SqlConnection(StrConn)
        If conn.State = ConnectionState.Closed Then conn.Open()

        Dim trans As SqlTransaction
        trans = conn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)
        Dim job_no As String = GenReserveCode()

        Dim sql As String = "select isnull(MAX(isnull(id,0)),0) +1 from TB_RESERVE_JOB"
        Dim cmd As New SqlCommand()
        With cmd
            .CommandText = sql
            .Connection = conn
            .Transaction = trans
        End With
        Dim job_id As Long = cmd.ExecuteScalar
        lblJobID.Text = job_id

        sql = "INSERT INTO [SIA-RFID].[dbo].[TB_RESERVE_JOB]"
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
                Dim requisition_id As String = item.Cells(ColNoAppNo).Text

                sql = "select count(*) +1 from TB_RESERVE Where borrowstatus in ('S','B') and requidition_id='" & requisition_id & "'"
                cmd.CommandText = sql
                Dim job_order As Long = cmd.ExecuteScalar

                sql = "INSERT INTO [SIA-RFID].[dbo].[TB_RESERVE]"
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
                sql += "  ((select isnull(MAX(isnull(id,0)),0) +1 from TB_RESERVE)"
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

        Else
            trans.Rollback()
        End If
        conn.Close()

        gvData.DataSource = Nothing
        gvData.DataBind()

        If lblJobID.Text = "" Then Exit Sub
        Dim scr As String = "window.open('frmPrint.aspx?JobID=" & lblJobID.Text & "&JobNo=" & job_no & "', '_blank', 'height=600,width=1000,left=200,top=200,location=no,menubar=no,toolbar=no,status=yes,resizable=yes,scrollbars=yes', true);"
        ScriptManager.RegisterStartupScript(Me, GetType(String), "ShowReport", scr, True)

    End Sub

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

    Private Sub gvData_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvData.RowCommand
        Select e.CommandName.ToLower
            Case "delete"
                Dim id As String = e.CommandArgument
                Dim dt As New DataTable
                dt.Columns.Add("id")
                dt.Columns.Add("app_no")
                dt.Columns.Add("app_name")
                dt.Columns.Add("Status")
                dt.Columns.Add("patent_type_name")
                Dim dr As DataRow
                For Each item As GridViewRow In gvData.Rows
                    If Replace(item.Cells(5).Text, "&nbsp;", "") <> id Then
                        dr = dt.NewRow
                        dr("id") = Replace(item.Cells(5).Text, "&nbsp;", "")
                        dr("app_no") = Replace(item.Cells(1).Text, "&nbsp;", "")
                        dr("app_name") = Replace(item.Cells(2).Text, "&nbsp;", "")
                        dr("Status") = Replace(item.Cells(3).Text, "&nbsp;", "")
                        dr("patent_type_name") = Replace(item.Cells(4).Text, "&nbsp;", "")
                        dt.Rows.Add(dr)
                    End If
                Next

                If dt.Rows.Count > 0 Then
                    dt.Columns.Add("seq")
                    For i As Integer = 0 To dt.Rows.Count - 1
                        dt.Rows(i)("seq") = i + 1
                    Next
                End If

                
                If dt.Rows.Count > 0 Then
                    gvData.DataSource = dt
                    gvData.DataBind()

                    Session("ISSelectFile") = True
                    Session(sessionName) = dt
                    Response.Redirect("frmReserve.aspx")
                Else
                    gvData.DataSource = Nothing
                    gvData.DataBind()
                    Session("ISSelectFile") = False
                    Response.Redirect("frmReserve.aspx")
                End If


        End Select
    End Sub

End Class