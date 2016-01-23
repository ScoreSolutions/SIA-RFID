<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/BackMaster.Master"  CodeBehind="frmReserve.aspx.vb" Inherits="SIA.frmReserve" %>

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
        .zHidden
        {
            display: none;
        }

        </style>
     <script type="text/javascript">
         function showModal(page, width, height, scroll) {
             showModalDialog(page, "", "dialogWidth:" + width + "px; dialogHeight:" + height + "px;help:no;status:no;center:yes;scroll:" + scroll);
         }

 </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
      <asp:UpdatePanel ID="UpdatePanal1" runat="server"><ContentTemplate>
            <div class="row-fluid">
                <div class="span6">
                    <h2 style="color: #00bddf">
                        List Select</h2>
                </div>
                       <div class="span6">
                    <div style="float: right;">
                        <asp:LinkButton ID="btnSearch" CssClass="btn btn-blue-light btn-small rsu-font13" 
                            runat="server" ><i class="icon-pencil icon-white "></i>&nbsp;Select Applicant</asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="btnSave" CssClass="btn btn-blue-light btn-small rsu-font13" 
                            runat="server" ><i class="icon-pencil icon-white "></i>&nbsp;Save</asp:LinkButton>
                        &nbsp;
                       
                       
                    </div>
                           <asp:Label ID="lblJobID" runat="server" Text="Label" Visible="False"></asp:Label>
                </div>
               
            </div>
            <hr style="margin: 0px 0px 10px 0px;" />
            
            <div class="block-lite">
  
                  
                <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="False" EmptyDataText="Data Not Found"
                    CssClass="table table-condensed table-bordered " GridLines="None" HeaderStyle-BackColor="#00bddf"
                    HeaderStyle-ForeColor="#333333" AllowPaging="True" AllowSorting="True"
                    OnPageIndexChanging="ShowPageCommand">
                    <Columns>
                        <asp:BoundField DataField="seq" HeaderText="No" />
                        <asp:BoundField DataField="app_no" HeaderText="Our Ref" />
                        <asp:BoundField DataField="app_name" HeaderText="Applicant" />
                        <asp:BoundField DataField="patent_type_name" HeaderText="Application Type" /> 
                        <asp:BoundField DataField="status" HeaderText="Status" />
                                                              
                        <asp:BoundField DataField="id" HeaderText="id"  >
                            <ControlStyle CssClass="zHidden" />
                            <FooterStyle CssClass="zHidden" />
                            <HeaderStyle CssClass="zHidden" />
                            <ItemStyle CssClass="zHidden" />
                        </asp:BoundField>
                        <asp:TemplateField ShowHeader="false" >
                            <ItemTemplate>
                                <asp:ImageButton ID="imgDel"  ImageUrl="~/_images/ico_delete.jpg" runat="server" 
                                    OnClientClick="return confirm('Are you sure?');" CommandName="Delete" CommandArgument='<%#DataBinder.Eval(Container,"DataItem.Id") %>' />
                            </ItemTemplate>
                            <HeaderStyle Width="30px" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                        </asp:TemplateField>
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
</asp:Content>
