<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/BackMaster.Master" CodeBehind="frm_Report.aspx.vb" Inherits="SIA.frm_Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <link type="text/css" href="../_js-datepicker/base/jquery-ui.css"  rel="stylesheet" />

    <style type="text/css">
        .ui-datepicker
        {
            width: 175px;
            font-family: tahoma;
            font-size: 13px;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    
            <div class="row-fluid">
                <div class="span6">
                    <h2 style="color: #00bddf">
                        List All</h2>
                </div>
                       <div class="span6">
                    <div style="float: right;">
                        <asp:LinkButton ID="btnSave" CssClass="btn btn-blue-light btn-small rsu-font13" 
                            runat="server" ><i class="icon-pencil icon-white "></i>&nbsp;Save</asp:LinkButton>
                       
                    </div>
                </div>
                <%--     <asp:UpdatePanel ID="updatepanel1xxxxx" runat="server">
        <ContentTemplate>--%>
            </div>
            <hr style="margin: 0px 0px 10px 0px;" />
            <div class="block-lite ">
                <h4 runat="server" class="btn btn-blue-light btn-block btn-title disabled  " style="">
                    Search</h4>
                <table cellpadding="5" cellspacing="5" border="0" style="margin-bottom: 0px;">
                    <tr>
                        <td>
                            <b>Full Name</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <b>Patent Type</b>
                        </td>
                        <td>
                            <asp:CheckBoxList ID="CLBType" runat="server" RepeatDirection="Horizontal">
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Requst No</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDocNoFrom" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <b>To</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDocNoTo" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                                   <tr>
                        <td>
                            <b>Reserve Date</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDateFrom" runat="server" class="dp1"></asp:TextBox>
                        </td>
                        <td>
                            <b>To</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDateTo" runat="server" class="dp1"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                                   <tr>
                        <td>
                            <b>Status</b>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rdbSelect" runat="server" RepeatDirection="Horizontal" Width="183px">
                                <asp:ListItem Value="1">ว่าง</asp:ListItem>
                                <asp:ListItem Value="2">ไม่ว่าง</asp:ListItem>
                                <asp:ListItem Selected="True" Value="0">ทั้งหมด</asp:ListItem>
                            </asp:RadioButtonList>
                                       </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lbtnSearch" CssClass="btn btn-blue-light btn-small rsu-font13"
                                runat="server"><i class="icon-search icon-white" ></i>&nbsp;ค้นหา</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </div>
            <div class="block-lite">
  
                    <asp:UpdatePanel ID="UpdatePanal1" runat="server"><ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="ไม่มีข้อมูล"
                    CssClass="table table-condensed table-bordered " GridLines="None" HeaderStyle-BackColor="#00bddf"
                    HeaderStyle-ForeColor="#333333" AllowPaging="True" AllowSorting="True" PageSize="10"
                    OnPageIndexChanging="ShowPageCommand">
                    <Columns>
                        <asp:BoundField DataField="seq" HeaderText="No" />
                             <asp:TemplateField HeaderText="Select">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckbSelect" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="req_no" HeaderText="Requst No" />
                        <asp:BoundField DataField="reserve_date2" HeaderText="Reserve Date" />
                        <asp:BoundField DataField="member_id" HeaderText="Member Id" />
                        <asp:BoundField DataField="member_name" HeaderText="Member Name" />
                        <asp:BoundField DataField="reserve_order" HeaderText="Reserve Order" />
                        <asp:BoundField DataField="reserve_status" HeaderText="Status" />
                        <asp:BoundField DataField="patent_type_name" HeaderText="Patent Type" />
                   
                      
                    </Columns>
                    <HeaderStyle BackColor="#00BDDF" ForeColor="#333333"></HeaderStyle>
                    <PagerSettings Mode="NumericFirstLast" PageButtonCount="10" />
                    <PagerStyle CssClass="pagination" />
                </asp:GridView>
</ContentTemplate></asp:UpdatePanel>
            </div>

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
</asp:Content>

