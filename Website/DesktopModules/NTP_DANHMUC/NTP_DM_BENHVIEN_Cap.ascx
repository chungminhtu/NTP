<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_BENHVIEN_Cap.ascx.vb" Inherits="NTP_DM_BENHVIEN_Cap" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<table  class = "ntp_table_main" width="100%">
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Cấp</asp:Label></td>
        <td width="60%">
            <asp:DropDownList ID="cboCap" runat="server" CssClass="ntp_combobox" Width="250px" DataTextField="TEN_CAP" DataValueField="ID_CAP" TabIndex="2" AutoPostBack="True">
            </asp:DropDownList></td>
            <td style="width: 20%"></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Danh sách bệnh viện đã phân cấp"></asp:Label></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            <cc3:MultiSelectGrid ID="grdCurrent" runat="server" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" Width="100%"
                CssClass="ntp_grd_GridViewStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                ItemStyle-CssClass = "ntp_grd_RowStyle"
                PagerStyle-CssClass = "ntp_grd_PagerStyle"
                HighlightCssClass="ntp_grd_SelectedRowStyle"
                >
                <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                <PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle" />
                <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                <ItemStyle CssClass="ntp_grd_RowStyle" />
                <Columns>
                    <asp:TemplateColumn>
                        <headerstyle width="2%"  />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn Visible="False">
                        <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w4" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_BENHVIEN" HeaderText="ID_BENHVIEN" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_VUNG" HeaderText="ID_VUNG" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="MA_BENHVIEN" HeaderText="M&#227; bệnh viện">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_BENHVIEN" HeaderText="T&#234;n bệnh viện">
                        <headerstyle width="30%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DIA_CHI" HeaderText="Địa chỉ">
                        <headerstyle width="50%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_CAP" HeaderText="Cấp">
                        <headerstyle width="6%" />
                    </asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
            </cc3:MultiSelectGrid>
        </td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="ntp_button" Width="100px" /></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Danh sách bệnh viện chưa phân cấp"></asp:Label></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            <cc3:MultiSelectGrid ID="grdDS" runat="server" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" Width="100%"
                CssClass="ntp_grd_GridViewStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                ItemStyle-CssClass = "ntp_grd_RowStyle"
                PagerStyle-CssClass = "ntp_grd_PagerStyle"
                HighlightCssClass="ntp_grd_SelectedRowStyle"
                >
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" /><EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                <PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle" />
                <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                <ItemStyle CssClass="ntp_grd_RowStyle" />
                <Columns>
                    <asp:TemplateColumn>
                        <headerstyle width="2%"  />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn Visible="False">
                        <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w4" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_BENHVIEN" HeaderText="ID_BENHVIEN" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_VUNG" HeaderText="ID_VUNG" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="MA_BENHVIEN" HeaderText="M&#227; bệnh viện">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_BENHVIEN" HeaderText="T&#234;n bệnh viện">
                        <headerstyle width="30%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DIA_CHI" HeaderText="Địa chỉ">
                        <headerstyle width="50%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_CAP" HeaderText="Cấp">
                        <headerstyle width="6%" />
                    </asp:BoundColumn>
                </Columns>
            </cc3:MultiSelectGrid></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            <asp:Button ID="cmdAdd" runat="server" Text="Thêm vào" CssClass="ntp_button" Width="100px" /></td>
    </tr>
   
</table>




