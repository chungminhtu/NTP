<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLTTB_KY_KIEMKE_LIST.ascx.vb" Inherits="NTP_QLTTB_KY_KIEMKE_LIST" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server Width="100%">
 <table  class = "ntp_table_main" width="100%">
     <tr>
         <td width="15%">
             <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
         <td width="85%">
             <asp:DropDownList ID="cboNam" runat="server" AutoPostBack="True">
             </asp:DropDownList></td>
     </tr>
     <tr>
         <td width="15%">
         </td>
         <td width="85%">
         </td>
     </tr>
     <tr>
         <td width="15%" valign=top colspan="2" >
             <cc3:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                 AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                 HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                 ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                 SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
                 <Columns>
                     <asp:TemplateColumn Visible="False">
                     </asp:TemplateColumn>
                     <asp:BoundColumn DataField="ID_KY_KIEMKE" HeaderText="ID Kỳ kiểm k&#234;" Visible="False">
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="TRANG_THAI" HeaderText="TRANG_THAI" Visible="False"></asp:BoundColumn>
                     <asp:BoundColumn DataField="TEN_KY_KIEMKE" HeaderText="M&#244; tả">
                         <headerstyle width="60%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn HeaderText="Trạng th&#225;i">
                         <headerstyle width="10%" />
                     </asp:BoundColumn>
                     <asp:TemplateColumn>
                         <itemtemplate>
<asp:Button id="cmdBaoCao" runat="server" Text="Báo cáo kiểm kê" CssClass="ntp_button" __designer:wfdid="w8" CommandName="baocao"></asp:Button> 
</itemtemplate>
                         <headerstyle width="10%" />
                     </asp:TemplateColumn>
                     <asp:TemplateColumn>
                         <itemtemplate>
<asp:Button id="cmdKetChuyen" runat="server" Text="Kết chuyển số liệu" CssClass="ntp_button" __designer:wfdid="w9" CommandName="ketchuyen"></asp:Button> 
</itemtemplate>
                         <headerstyle width="10%" />
                     </asp:TemplateColumn>
                 </Columns>
                 <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
                 <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                 <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                 <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                 <ItemStyle CssClass="ntp_grd_RowStyle" />
                 <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
             </cc3:MultiSelectGrid></td>
     </tr>
        <tr >
            <td width="15%">
            </td>
            <td width="85%">
                </td>
        </tr>
     <tr>
         <td colspan="2" width="85%" style="height: 21px">
         </td>
     </tr>
             
    </table>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal></asp:Panel>
    






