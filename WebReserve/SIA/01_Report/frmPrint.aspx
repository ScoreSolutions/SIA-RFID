<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPrint.aspx.vb" Inherits="SIA.frmPrint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report</title>
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%" class="table_input">
            <tr>
                <td class="section_header">
                    <input id="hddMode" runat="server" type="hidden" />                 
                </td>
            </tr>
            <tr>
                <td align="left" bgcolor="White">
                    <asp:Button ID="btnPrint" runat="server" OnClientClick="javascript:window.print();return false;" Text="Print"/>
                 </td>
            </tr>
            <tr>
                <td>                             
                    <asp:Label ID="lblReportDesc" runat="server"></asp:Label>
                </td>
           </tr>
            <tr>
                <td align="center" >
                    <asp:Label ID="lblerror" runat="server" Text="** No data by conditional. **" Font-Bold="True" 
                        Font-Italic="False" Font-Names="Tahoma" Font-Size="Medium" 
                        ForeColor="#990000"></asp:Label>
                        <br /><br />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
