Public Class BackMaster
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(Session("member_id")) Then
            Response.Redirect("frm_Login.aspx")
        End If
    End Sub

End Class