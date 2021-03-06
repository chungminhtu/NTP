<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLTTB_DM_THIETBI_List.ascx.vb" Inherits="NTP_QLTTB_DM_THIETBI_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>

<asp:Panel ID="pnlAll" runat="server">
    <table class="ntp_table_main">
        <tr>
            <td style="height: 19px" width="20%">
                </td>
            <td colspan="2" style="height: 19px" width="80%">
                </td>
        </tr>
        <tr>
            <td width="20%">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên thiết bị"></asp:Label></td>
            <td width="60%">
                <asp:TextBox ID="txtSearhThietBi" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox></td>
            <td width="20%">
                <asp:Button ID="cmdSearch" runat="server" CssClass="ntp_button" Text="Tìm kiếm" Width="100px" /></td>
        </tr>
        <tr>
            <td width="20%" style="height: 26px">
            </td>
            <td colspan="2" width="80%" style="height: 26px">
                <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Thêm mới" Width="100px" />&nbsp;
                <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" /></td>
        </tr>
        <tr>
            <td colspan="3" width="20%">
                <cc3:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                    AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                    HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                    ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
                    <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                    <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                    <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
                    <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                    <ItemStyle CssClass="ntp_grd_RowStyle" />
                    <Columns>
                        <asp:TemplateColumn>
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" ImageUrl="~/images/edit.gif" CommandName="edit" __designer:wfdid="w2"></asp:ImageButton> 
</itemtemplate>
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="ID_THIETBI" HeaderText="ID_THIETBI" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="MA_NUOC" HeaderText="MA_NUOC" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="ID_DVT" HeaderText="ID_DVT" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_THIETBI" HeaderText="T&#234;n thiết bị">
                            <headerstyle width="20%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_DVT" HeaderText="Đơn vị t&#237;nh">
                            <headerstyle width="30%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_NUOC" HeaderText="Nước">
                            <headerstyle width="16%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NHAN_HIEU" HeaderText="Nh&#227;n hiệu"></asp:BoundColumn>
                    </Columns>
                    <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                </cc3:MultiSelectGrid></td>
        </tr>
    </table>
</asp:Panel>
