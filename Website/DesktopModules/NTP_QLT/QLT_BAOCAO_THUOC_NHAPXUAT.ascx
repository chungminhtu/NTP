<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_BAOCAO_THUOC_NHAPXUAT.ascx.vb" Inherits="QLT_BAOCAO_THUOC_NHAPXUAT" %>
<table class="ntp_table_main" width="100%">
    <tr>
        <td width="15%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
        <td width="85%">
            <asp:DropDownList ID="cboNam" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td width="15%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tháng"></asp:Label></td>
        <td width="85%">
            <asp:DropDownList ID="cboThang" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Xem báo cáo" CssClass="ntp_button" /></td>
    </tr>
    <tr>
        <td colspan="2" valign="top" width="15%">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal></td>
    </tr>
</table>
