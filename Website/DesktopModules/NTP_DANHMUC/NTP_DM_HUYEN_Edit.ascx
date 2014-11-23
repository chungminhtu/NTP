<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_HUYEN_Edit.ascx.vb" Inherits="NTP_DM_HUYEN_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%" style="height: 26px">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Mã huyện"></asp:Label></td>
        <td colspan="2" width="80%" style="height: 26px" align="left">
            <asp:TextBox ID="txtID_HUYEN" runat="server" CssClass="ntp_textbox"
                Width="150px" MaxLength="10" TabIndex="1" Enabled="False"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID_HUYEN"
                Display="Dynamic" ErrorMessage="Bạn phải nhập mã huyện"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%" style="height: 26px">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên huyện"></asp:Label></td>
        <td colspan="2" width="80%" style="height: 26px">
            <asp:TextBox ID="txtTEN_HUYEN" runat="server" CssClass="ntp_textbox" Width="500px" TabIndex="3" MaxLength="50"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%" style="height: 24px">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Tỉnh</asp:Label></td>
        <td width="60%" style="height: 24px">
            <asp:DropDownList ID="cboVung" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                DataValueField="MA_TINH" Width="150px" TabIndex="4" AutoPostBack="true"></asp:DropDownList></td>
        <td style="width: 20%; height: 24px;">
            </td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" width="80%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="5" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" TabIndex="6" /></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
        </td>
    </tr>
</table>

