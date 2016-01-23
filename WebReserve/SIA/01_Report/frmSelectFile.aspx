<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmSelectFile.aspx.vb" Inherits="SIA.frmSelectFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="../_bootstrap/css/bootstrap.css" rel="stylesheet" media="screen" />
    <link href="../_css/fonts/stylesheet.css" rel="stylesheet" type="text/css" />
    <link href="../_css/style.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="../_js-datepicker/base/jquery-ui.css"  rel="stylesheet" />

    <style type="text/css">
        .ui-datepicker
        {
            width: 175px;
            font-family: tahoma;
            font-size: 13px;
            text-align: center;
        }
        .zHidden
        {
            display: none;
        }

        </style>
</head>
<body> 
    <form id="form1" runat="server" >
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


            <hr style="margin: 0px 0px 10px 0px;" />
            <div class="block-lite " >
                <h4 runat="server" class="btn btn-blue-light btn-block btn-title disabled  " style="">
                    Search</h4>


                <table cellpadding="5" cellspacing="5" border="0" style="margin-bottom: 0px;" width="500px" align="center">
                    <tr>
                        <td>
                           <b>Our Ref.</b></td>
                        <td>
                            <asp:TextBox ID="txtAppNo" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Applicant</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAppName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                                   <tr>
                        <td>
                            <b>Application Type</b></td>
                        <td align="left">
                            <asp:TextBox ID="txtApp_Type" runat="server" Width="200px"></asp:TextBox>
                            <asp:CheckBoxList ID="CLBType" runat="server" RepeatDirection="Horizontal" CellSpacing="0" RepeatColumns="10" Visible="False">
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                                   <tr>
                        <td>
                            <b>Status</b>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rdbSelect"  CssClass="" runat="server" RepeatDirection="Horizontal" Width="223px">
                                <asp:ListItem Value="1" Text="Available"></asp:ListItem>
                                <asp:ListItem Value="2">Not Available</asp:ListItem>
                                <asp:ListItem Selected="True" Value="0">All</asp:ListItem>
                            </asp:RadioButtonList>
                                       </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lbtnSearch" CssClass="btn btn-blue-light btn-small rsu-font13"
                                runat="server"><i class="icon-search icon-white" ></i>&nbsp;Search</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                
            </div>


        <div class="row-fluid">

         
            <div class="span6">
                <div style="float: left; padding-left:20px">
                    <asp:LinkButton ID="btnOK" CssClass="btn btn-blue-light btn-small rsu-font13"
                        runat="server"><i class="icon-pencil icon-white "></i>&nbsp;OK</asp:LinkButton>
                    &nbsp;
                        <%--<asp:LinkButton ID="btnPrint" CssClass="btn btn-blue-light btn-small rsu-font13" 
                            runat="server" ><i class="icon-pencil icon-white "></i>&nbsp;Print</asp:LinkButton>--%>
                </div>
                <asp:Label ID="lblJobID" runat="server" Text="Label" Visible="False"></asp:Label>
            </div>

        </div>

        <div class="block-lite">
              <asp:UpdatePanel ID="UpdatePanal1" runat="server"><ContentTemplate>
                <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="False" EmptyDataText="Data Not Found"
                    CssClass="table table-condensed table-bordered " GridLines="None" HeaderStyle-BackColor="#00bddf"
                    HeaderStyle-ForeColor="#333333" AllowPaging="True" AllowSorting="True"
                    OnPageIndexChanging="ShowPageCommand">
                    <Columns>
                        <asp:BoundField DataField="seq" HeaderText="No" />
                             <asp:TemplateField HeaderText="Select">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckbSelect" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="app_no" HeaderText="Our Ref" />
                        <asp:BoundField DataField="app_name" HeaderText="Applicant" />
                                                <asp:BoundField DataField="patent_type_name" HeaderText="Application Type" />                                        

                        <asp:BoundField DataField="status" HeaderText="Status" />
                         <asp:BoundField DataField="borrower_name" HeaderText="Check Out By" />                   
                        <asp:BoundField DataField="id" HeaderText="id"  >
                            <ControlStyle CssClass="zHidden" />
                            <FooterStyle CssClass="zHidden" />
                            <HeaderStyle CssClass="zHidden" />
                            <ItemStyle CssClass="zHidden" />
                        </asp:BoundField>
                    </Columns>
                    <HeaderStyle BackColor="#00BDDF" ForeColor="#333333"></HeaderStyle>
                    <PagerSettings Mode="NumericFirstLast" PageButtonCount="10" />
                    <PagerStyle CssClass="pagination" />
                </asp:GridView>

            </div>
</ContentTemplate></asp:UpdatePanel>
    <!-- for datepicker -->
    <script type="text/javascript" src="../_js-datepicker/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="../_js-datepicker/jquery-ui-1.8.10.offset.datepicker.min.js"></script>
    <script type="text/javascript">
        $(function () {
            var d = new Date();
            var toDay = d.getDate() + '/' + (d.getMonth() + 1) + '/' + (d.getFullYear() + 543);

            // Datepicker
            $(".dp1").datepicker({
                dateFormat: 'dd/mm/yy',
                isBuddhist: true,
                defaultDate: toDay,
                dayNames: ['อาทิตย์', 'จันทร์', 'อังคาร', 'พุธ', 'พฤหัสบดี', 'ศุกร์', 'เสาร์'],
                dayNamesMin: ['อา.', 'จ.', 'อ.', 'พ.', 'พฤ.', 'ศ.', 'ส.'],
                monthNames: ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม', 'มิถุนายน', 'กรกฎาคม', 'สิงหาคม', 'กันยายน', 'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'],
                monthNamesShort: ['ม.ค.', 'ก.พ.', 'มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.', 'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.', 'พ.ย.', 'ธ.ค.']
            });


        });
    </script>
           </form>
    </body>
 
</html>
