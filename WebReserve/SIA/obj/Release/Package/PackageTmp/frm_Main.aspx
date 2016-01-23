<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/BackMaster.Master" CodeBehind="frm_Main.aspx.vb" Inherits="SIA.frm_Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row-fluid">
        <div class="span6">
            <h2 style="color: #00bddf">List You</h2>
        </div>
      
                <%--     <asp:UpdatePanel ID="updatepanel1xxxxx" runat="server">
        <ContentTemplate>--%>
            </div>
    <hr style="margin: 0px 0px 10px 0px;" />
 
    <div class="block-lite">
        <asp:UpdatePanel ID="UpdatePanal1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="ไม่มีข้อมูล"
                    CssClass="table table-condensed table-bordered " GridLines="None" HeaderStyle-BackColor="#00bddf"
                    HeaderStyle-ForeColor="#333333" AllowPaging="True" AllowSorting="True" PageSize="10"
                    OnPageIndexChanging="ShowPageCommand">
                    <Columns>
                        <asp:BoundField DataField="seq" HeaderText="No" />
            
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
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <!-- for datepicker -->
    <script type="text/javascript" src="_js-datepicker/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="_js-datepicker/jquery-ui-1.8.10.offset.datepicker.min.js"></script>
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
