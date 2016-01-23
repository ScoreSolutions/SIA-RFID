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
        .zHidden
        {
            display: none;
        }

        </style>
    <%-- <script language="javascript" type="text/jscript">
             function OpenResultWindow(JobID) {
             alert('../01_Report/frmPrint.aspx?JobID=" & JobID');
             var WinSettings = "center:yes;resizable:no;dialogHeight:450px;dialogWidth:1000px;";
             var MyArgs = window.showModalDialog("../01_Report/frmPrint.aspx?JobID=" & JobID, null, WinSettings);
             if (MyArgs == true)
                 location.reload(true);
         }
     </script>--%>
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
                        &nbsp;
                        <%--<asp:LinkButton ID="btnPrint" CssClass="btn btn-blue-light btn-small rsu-font13" 
                            runat="server" ><i class="icon-pencil icon-white "></i>&nbsp;Print</asp:LinkButton>--%>
                       
                    </div>
                           <asp:Label ID="lblJobID" runat="server" Text="Label" Visible="False"></asp:Label>
                </div>
               
            </div>
            <hr style="margin: 0px 0px 10px 0px;" />
            <div class="block-lite " >
                <h4 runat="server" class="btn btn-blue-light btn-block btn-title disabled  " style="">
                    Search</h4>


                <table cellpadding="5" cellspacing="5" border="0" style="margin-bottom: 0px;" width="800px" align="center">
                    <tr>
                        <td>
                           <b>Application No</b></td>
                        <td>
                            <asp:TextBox ID="txtAppNo" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Application Name</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAppName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                                   <tr>
                        <td>
                            <b>Application Type</b></td>
                        <td>
                            <asp:CheckBoxList ID="CLBType" runat="server" RepeatDirection="Horizontal" CellSpacing="0">
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
                        <asp:BoundField DataField="app_no" HeaderText=" Application No" />
                        <asp:BoundField DataField="app_name" HeaderText="Application Name" />
                        <asp:BoundField DataField="status" HeaderText="Status" />
                        <asp:BoundField DataField="patent_type_name" HeaderText="Application Type" />                                        
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

