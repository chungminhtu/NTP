<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_KHOASO_KIEMKE.ascx.vb" Inherits="QLT_KHOASO_KIEMKE" %>
<asp:Panel ID="pnlAll" runat="server" Width="100%">
    <table class="ntp_table_main">
        <tr>
            <td width="15%">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Mô tả"></asp:Label></td>
            <td width="85%">
                <asp:TextBox ID="txtMO_TA" runat="server" CssClass="ntp_textbox" MaxLength="250"
                    TabIndex="1" Width="100%"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="15%">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
            <td width="85%">
                <asp:DropDownList ID="cboNam" runat="server" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td valign="top" width="15%">
                <asp:Label ID="lblThang" runat="server" CssClass="ntp_label" Text=" Chọn tháng khóa sổ"></asp:Label></td>
            <td valign="top" width="85%">
                <asp:CheckBoxList ID="chklThang" runat="server" CellPadding="3" CellSpacing="3" CssClass="ntp_checkbox"
                    RepeatColumns="6" RepeatDirection="Horizontal" Width="100%">
                    <asp:ListItem Value="1">Th&#225;ng 1</asp:ListItem>
                    <asp:ListItem Value="2">Th&#225;ng 2</asp:ListItem>
                    <asp:ListItem Value="3">Th&#225;ng 3</asp:ListItem>
                    <asp:ListItem Value="4">Th&#225;ng 4</asp:ListItem>
                    <asp:ListItem Value="5">Th&#225;ng 5</asp:ListItem>
                    <asp:ListItem Value="6">Th&#225;ng 6</asp:ListItem>
                    <asp:ListItem Value="7">Th&#225;ng 7</asp:ListItem>
                    <asp:ListItem Value="8">Th&#225;ng 8</asp:ListItem>
                    <asp:ListItem Value="9">Th&#225;ng 9</asp:ListItem>
                    <asp:ListItem Value="10">Th&#225;ng 10</asp:ListItem>
                    <asp:ListItem Value="11">Th&#225;ng 11</asp:ListItem>
                    <asp:ListItem Value="12">Th&#225;ng 12</asp:ListItem>
                </asp:CheckBoxList>
                <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="5000">
                </asp:Timer>
            </td>
        </tr>
        <tr>
            <td width="15%">
            </td>
            <td width="85%">
                <asp:Button ID="cmdLock" runat="server" CssClass="ntp_button" Text="Khóa sổ" Width="100px" />&nbsp;
                <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" /></td>
        </tr>
        <tr>
            <td colspan="2" width="85%">
            </td>
        </tr>
    </table>
    <asp:Panel ID="pnlDetail" runat="server" Width="100%">
        <asp:BulletedList ID="ListStatus" runat="server">
        </asp:BulletedList>
    </asp:Panel>
</asp:Panel>
