Imports System.Data.SqlClient
Public Class frmSelectFile
    Inherits System.Web.UI.Page

#Region "Declare Class & Paramater"
    Dim StrConn As String = ConfigurationManager.ConnectionStrings("SIAConnectionString").ConnectionString
    Private sql As String
    Const sessionName As String = "selectfile"
#End Region

#Region "Init"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            PoplateCheckBoxList()
            PopulateData()
        End If
    End Sub

    Private Sub PopulateData()
        gvData.DataSource = GetSource()
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
        sql = "select TB_REQUISTION.id,TB_REQUISTION.app_no,app_name, CASE WHEN ISNULL(br.BORROWSTATUS, '') = '' THEN 'Y' ELSE 'N' END AS status ,patent_type_id ,patent_type_name,tmp.borrower_name "
        sql += " from TB_REQUISTION Left Join  TB_PATENT_TYPE on TB_REQUISTION.patent_type_id = TB_PATENT_TYPE.id "
        sql += " left join (select distinct RT.app_no,RS.reserve_status,RS.borrowstatus from TB_RESERVE RS"
        sql += " inner join TB_REQUISTION RT on RS.requidition_id= RT.id"
        sql += " where (BORROWSTATUS IN ('B', 'T', 'A'))) as br on br.app_no=TB_REQUISTION.app_no "
        sql += " left join TMP_FILEBORROWITEM tmp on tmp.app_no=TB_REQUISTION.app_no"
        Dim whText As String = " where 1=1 "
        whText += IIf(txtAppNo.Text.Trim <> "", " and TB_REQUISTION.app_no like '%" & txtAppNo.Text.Trim & "%'", "")
        whText += IIf(txtAppName.Text.Trim <> "", " and TB_REQUISTION.app_name like '%" & txtAppName.Text.Trim & "%'", "")
        whText += IIf(txtApp_Type.Text.Trim <> "", " and TB_PATENT_TYPE.patent_type_name like '%" & txtApp_Type.Text.Trim & "%'", "")

        'whText += IIf(GetChkPatentType() <> "", " and patent_type_name in " & GetChkPatentType(), "")
        If rdbSelect.SelectedValue = 1 Then
            whText += " and (CASE WHEN ISNULL(br.BORROWSTATUS, '') = '' THEN 'Y' ELSE 'N' END) = 'Y' "
        ElseIf rdbSelect.SelectedValue = 2 Then
            whText += " and (CASE WHEN ISNULL(br.BORROWSTATUS, '') = '' THEN 'Y' ELSE 'N' END) = 'N' "
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
    End Function

    Sub ShowPageCommand(ByVal s As Object, ByVal e As GridViewPageEventArgs)
        gvData.PageIndex = e.NewPageIndex
        gvData.DataBind()
    End Sub


#End Region

    Private Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles gvData.PageIndexChanging
        gvData.PageIndex = e.NewPageIndex
        gvData.DataSource = GetSource()
        gvData.DataBind()
    End Sub

    Private Sub lbtnSearch_Click(sender As Object, e As EventArgs) Handles lbtnSearch.Click
        PopulateData()
    End Sub


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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("app_no")
        dt.Columns.Add("app_name")
        dt.Columns.Add("Status")
        dt.Columns.Add("patent_type_name")
        For Each grv As GridViewRow In gvData.Rows
            Dim chk As CheckBox = grv.FindControl("ckbSelect")
            If chk.Checked = True Then
                Dim dr As DataRow = dt.NewRow
                dr("app_no") = grv.Cells(2).Text
                dr("app_name") = grv.Cells(3).Text
                dr("Status") = grv.Cells(5).Text
                dr("patent_type_name") = grv.Cells(4).Text
                dr("id") = grv.Cells(7).Text
                dt.Rows.Add(dr)
            End If
        Next

        If dt.Rows.Count > 0 Then
            Session("ISSelectFile") = True
            Session(sessionName) = dt
        Else
            Session.Remove(sessionName)
        End If
        ScriptManager.RegisterStartupScript(Me, GetType(String), "ShowReport", "window.close();", True)

    End Sub

End Class