<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_BC_VTHC_LIST.ascx.vb" Inherits="NTP_QLVT_BC_VTHC_LIST" %>
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
             <asp:Label ID="lblNguoiTao" runat="server" CssClass="ntp_label" Text="Người tạo"></asp:Label></td>
         <td width="85%">
             <asp:DropDownList ID="cboUser" runat="server" AutoPostBack="True" Width="205px">
             </asp:DropDownList></td>
     </tr>     
     <tr>
         <td width="15%">
         </td>
         <td width="85%">
             <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Nhập báo cáo"
                 Width="100px" />&nbsp;
             <asp:Button ID="cmdDel" runat="server" CssClass="ntp_button" Text="Xóa báo cáo" Width="144px" />&nbsp;
             <asp:Button ID="cmdApprove" runat="server" CssClass="ntp_button" Text="Phê duyệt báo cáo"
                 Width="144px" />
             <asp:Button ID="cmdReject" runat="server" CssClass="ntp_button" Text="Hủy phê duyệt báo cáo"
                 Width="144px" />
             <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa báo cáo này?"
                     TargetControlID="cmdDel">
                 </ajaxToolkit:ConfirmButtonExtender>
             <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Bạn thực sự muốn phê duyệt báo cáo đã chọn ?"
                 TargetControlID="cmdApprove">
             </ajaxToolkit:ConfirmButtonExtender>
         </td>
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
                     <asp:BoundColumn HeaderText="6 th&#225;ng" DataField="QUY">
                         <headerstyle width="8%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="TEN_NGUOITAO" HeaderText="Người tạo">
                         <headerstyle width="17%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="NGAY_TAO" DataFormatString="{0:dd/MM/yyyy hh:mm}" HeaderText="Ng&#224;y tạo">
                         <headerstyle width="15%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="TEN_PHEDUYET" HeaderText="Người ph&#234; duyệt">
                         <headerstyle width="15%" />
                     </asp:BoundColumn>
                     <asp:BoundColumn DataField="NGAY_PHEDUYET" HeaderText="Ng&#224;y ph&#234; duyệt"  DataFormatString="{0:dd/MM/yyyy hh:mm}">
                         <headerstyle width="15%" />
                     </asp:BoundColumn>
                     <asp:TemplateColumn>
                         <itemtemplate>
&nbsp;<asp:LinkButton id="cmdVT" runat="server" __designer:wfdid="w2" CommandName="vt">BC Vật tư</asp:LinkButton>
</itemtemplate>
                         <headerstyle width="10%" />
                     </asp:TemplateColumn>
                     <asp:TemplateColumn>
                         <itemtemplate>
<asp:LinkButton id="cmdHC" runat="server" __designer:wfdid="w3" CommandName="hc">BC Hóa chất</asp:LinkButton>
</itemtemplate> <headerstyle width="10%" />
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
    






