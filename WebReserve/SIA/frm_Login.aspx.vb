Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frm_Login2
    Inherits System.Web.UI.Page

#Region "Declare Class&Valiable"
    Const encryptKey As String = "DiPRfId"
    Private Shared IV() As Byte = {10, 20, 30, 40, 50, 60, 70, 80}
    Dim StrConn As String = ConfigurationManager.ConnectionStrings("SIAConnectionString").ConnectionString

#End Region
#Region "Init"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtUserName.Attributes.Add("onkeypress", "return clickButton(event,'" + btnLogin.ClientID + "') ")
        txtPassword.Attributes.Add("onkeypress", "return clickButton(event,'" + btnLogin.ClientID + "') ")
        If Not Page.IsPostBack Then
            Session.Abandon()
        End If
    End Sub

#End Region

#Region "Event Handled"
    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If GetSource_User.Rows.Count > 0 Then
            Session("Username") = GetSource_User.Rows(0)("Username")
            If CheckPermissionReserve(Session("Username")) Then
                Session("member_id") = GetSource_User.Rows(0)("id")
                Session("member_name") = GetSource_User.Rows(0)("name")
                Response.Redirect("frm_Main.aspx")
            Else
                MsgBox("User Not Authorization")
            End If
        Else
            MsgBox("Data User Not Found")
        End If
    End Sub

#End Region

#Region "Function"
    Function CheckPermissionReserve(ByVal username As String) As Boolean
        'menu 37 = Reserve Web
        Dim sql As String = "select count(Menu_id ) from TB_PERMISSION_MENU"
        sql &= " where Permission_id in ("
        sql &= " select permission_id from TB_PERMISSION_OFFICER P inner join TB_OFFICER O on P.officer_id = O.id"
        sql &= " where username = '" & username & "' ) and Menu_id = '37'"
        Dim cmd As New SqlCommand()
        With cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            Dim conn As New SqlConnection(StrConn)
            If conn.State = ConnectionState.Closed Then conn.Open()
            .Connection = conn
        End With

        If cmd.ExecuteScalar = 0 Then
            Return False
        End If

        Return True
    End Function
    Private Function GetSource_User() As DataTable
        Dim sql As String = "SELECT   fname + ' ' + lname as name,TB_OFFICER.* from TB_OFFICER  where 1=1 "
        Dim strWhere As String = ""

        strWhere &= " and Username='" & txtUserName.Text & "'"
        strWhere &= " and Password='" & GetEncrypt(txtPassword.Text) & "'"

        Dim DAUser As New SqlDataAdapter(sql & strWhere, StrConn)
        Dim DTUser As New DataTable
        DAUser.Fill(DTUser)

        Return DTUser
    End Function

    Public Shared Function GetEncrypt(ByVal text As String) As String
        Dim tdsp As New TripleDESCryptoServiceProvider
        Dim md5csp = New MD5CryptoServiceProvider
        Dim buffer As Byte() = Encoding.ASCII.GetBytes(text)
        tdsp.Key = md5csp.ComputeHash(ASCIIEncoding.ASCII.GetBytes(encryptKey))
        tdsp.IV = IV
        Return Convert.ToBase64String(tdsp.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
#End Region

End Class