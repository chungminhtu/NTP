<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_NUOC_Edit.ascx.vb" Inherits="NTP_DM_NUOC_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc4" %>

<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Mã nước</asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtMA_NUOC" runat="server" CssClass="ntp_textbox"
                Width="72px" MaxLength="10" TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMA_NUOC"
                Display="Dynamic" ErrorMessage="Bạn phải nhập mã nước"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên nước"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtTEN_NUOC" runat="server" CssClass="ntp_textbox" Width="500px" TabIndex="2" MaxLength="250"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTEN_NUOC"
                Display="Dynamic" ErrorMessage="Bạn phải nhập tên nước"></asp:RequiredFieldValidator></td>
            
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" width="80%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="3" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" /></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
        </td>
    </tr>
</table>

