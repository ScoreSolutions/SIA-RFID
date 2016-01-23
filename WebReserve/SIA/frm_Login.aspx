<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/LoginMaster.Master" CodeBehind="frm_Login.aspx.vb" Inherits="SIA.frm_Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css"> 
    #mydiv {
    position:fixed;
    top: 50%;
    left: 50%;
    width:30em;
    height:14em;
    margin-top: -9em; /*set to a negative number 1/2 of your height*/
    margin-left: -15em; /*set to a negative number 1/2 of your width*/
    border: 1px solid #ccc;
    background-color: #f3f3f3;
    }

    body {
    background-image: url("_images/login bg.jpg");no-repeat center center fixed;
        -webkit-background-size: cover;
        -moz-background-size: cover;
        -o-background-size: cover;
        background-size: cover;
}
  </style>

      <script language="javascript" type="text/jscript">
     function clickButton(e, buttonid) {
             var evt = e ? e : window.event;
             var bt = document.getElementById(buttonid);
             if (bt) {
                 if (evt.keyCode == 13) {
                     bt.click();
                     return false;
                 }
             }
     }
   </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <hr style="margin: 0px 0px 10px 0px;" />
            <div class="block-lite " id="mydiv">
               <h4 runat="server" class="btn btn-blue-light btn-block btn-title disabled  " style="">
                    Log In</h4>
                <table cellpadding="5" cellspacing="5" border="0" style="margin-bottom: 0px;width:100%"  >
            
                    <tr>
                        <td>
                            Username
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        </td>
               
                    </tr>
                                   <tr>
                        <td class="auto-style2">
                            Password
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtPassword" runat="server" class="dp1" TextMode="Password"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                         
                        <asp:LinkButton ID="btnLogin" CssClass="btn btn-blue-light btn-small rsu-font13" 
                            runat="server" >&nbsp;Log in</asp:LinkButton>
                       
                        </td>
                        
                    </tr>
                </table>
            </div>
</asp:Content>
