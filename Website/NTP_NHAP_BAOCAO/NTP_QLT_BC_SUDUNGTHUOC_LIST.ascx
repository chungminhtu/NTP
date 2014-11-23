<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLT_BC_SUDUNGTHUOC_LIST.ascx.vb" Inherits="NTP_QLT_BC_SUDUNGTHUOC_LIST" %>
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
             <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Nhập báo cáo"
                 Width="100px" />&nbsp;
             <asp:Button ID="cmdDel" runat="server" CssClass="ntp_button" Text="Xóa báo cáo"
                 Width="144px" />&nbsp;
             <asp:Button ID="cmdApprove" runat="server" CssClass="ntp_button" Text="Phê duyệt báo cáo"
                 Width="144px" />&nbsp;
             <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa báo cáo này?"
                 TargetControlID="cmdDel">
             </ajaxToolkit:ConfirmButtonExtender><ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Bạn thực sự muốn phê duyệt báo cáo đã chọn ?"
                 TargetControlID="cmdApprove">
             </ajaxToolkit:ConfirmButtonExtender>
         </td>
     </tr>
     <tr>
         <td colspan="2" width="15%">
             <asp:Label ID="Label5" runat="server" CssClass="ntp_comment" Text="Chú ý: <br>Chỉ được phép chọn 1 báo cáo để phê duyệt"></asp:Label></td>
     </tr>
     <tr>
         <td width="15%" valign=top colspan="2" >
             <cc3:MultiSelectGrid ID="grdDS" runat="server" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                 AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                 HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                 ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                 SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
                 <Columns>
                     <asp:TemplateColumn>
                         <headerstyle width="2%" />
                     </asp:TemplateColumn>
                     <asp:TemplateColumn>
                         <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                         <headerstyle width="2%" />
                     </asp:TemplateColumn>
                     <asp:BoundColumn DataField="ID_BAOCAO" HeaderText="ID b&#225;o c&#225;o" Visible="False">
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="TRANG_THAI" HeaderText="TRANG_THAI" Visible="False"></asp:BoundColumn>
                     <asp:BoundColumn DataField="NAM" HeaderText="Năm">
                         <headerstyle width="5%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn HeaderText="Qu&#253;" DataField="QUY">
                         <headerstyle width="5%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="TEN_NGUOITAO" HeaderText="Người tạo">
                         <headerstyle width="20%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="NGAY_TAO" DataFormatString="{0:dd/MM/yyyy hh:mm}" HeaderText="Ng&#224;y tạo">
                         <headerstyle width="15%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="TEN_PHEDUYET" HeaderText="Người ph&#234; duyệt">
                         <headerstyle width="20%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="NGAY_PHEDUYET" HeaderText="Ng&#224;y ph&#234; duyệt"  DataFormatString="{0:dd/MM/yyyy}">
                         <headerstyle width="15%" />
                     </asp:BoundColumn>
                     <asp:TemplateColumn>
                         <itemtemplate>
<asp:Button id="cmdBaoCao" runat="server" Text="Xem Báo cáo " CssClass="ntp_button" CommandName="baocao" __designer:wfdid="w2"></asp:Button> 
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
             
    </table>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal></asp:Panel>
    






