<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_BENHVIEN_Edit.ascx.vb" Inherits="NTP_DM_BENHVIEN_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Mã bệnh viện"></asp:Label>
            <asp:Label ID="Label8" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtMaBenhVien" runat="server" CssClass="ntp_textbox" MaxLength="10"
                TabIndex="1" Width="150px" Enabled="False"></asp:TextBox>
            <asp:TextBox ID="txtID_BENHVIEN" runat="server" CssClass="ntp_textbox" Visible="False"
                Width="72px"></asp:TextBox>&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMaBenhVien"
                CssClass="ntp_error" Display="Dynamic" ErrorMessage="Bạn phải nhập mã bệnh viện"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên bệnh viện"></asp:Label>
            <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:DropDownList ID="cboType" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>BV</asp:ListItem>
                <asp:ListItem>T</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtTenBenhVien" runat="server" CssClass="ntp_textbox" Width="92%" TabIndex="2" MaxLength="250"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="ntp_error"
                Display="Dynamic" ErrorMessage="Bạn phải nhập tên bệnh viện" ControlToValidate="txtTenBenhVien"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Địa chỉ"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtDiaChi" runat="server" CssClass="ntp_textbox" MaxLength="1000"
                Rows="2" TabIndex="3" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Phân loại y tế"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:DropDownList ID="cboPHANLOAIYTE" runat="server" Width="150px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Phân loại bệnh viện"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:DropDownList ID="cboLoaiBV" runat="server" Width="150px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Quận (Huyện)"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:DropDownList ID="cboHuyen" runat="server" DataTextField="ten_huyen"
                DataValueField="ma_huyen" Width="300px" AutoPostBack="True">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" width="80%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="4" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" /></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
        </td>
    </tr>
</table>

