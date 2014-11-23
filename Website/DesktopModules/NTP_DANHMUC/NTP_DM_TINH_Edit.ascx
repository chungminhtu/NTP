<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_TINH_Edit.ascx.vb" Inherits="NTP_DM_TINH_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Mã tỉnh"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtID_TINH" runat="server" CssClass="ntp_textbox"
                Width="150px" MaxLength="10" TabIndex="1" Enabled="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID_TINH"
                Display="Dynamic" ErrorMessage="Bạn phải nhập mã tỉnh"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên tỉnh"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtTEN_TINH" runat="server" CssClass="ntp_textbox" Width="500px" TabIndex="2" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTEN_TINH"
                Display="Dynamic" ErrorMessage="Bạn phải nhập tên tỉnh"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Vùng</asp:Label></td>
        <td width="60%">
            <asp:DropDownList ID="cboVung" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VUNG"
                DataValueField="ID_VUNG" Width="150px" TabIndex="3"></asp:DropDownList></td>
        <td style="width: 20%">
            </td>
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
            &nbsp;
        </td>
    </tr>
</table>

