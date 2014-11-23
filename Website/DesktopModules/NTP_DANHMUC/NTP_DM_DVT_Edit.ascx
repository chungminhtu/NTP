<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_DVT_Edit.ascx.vb" Inherits="NTP_DM_DVT_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên đơn vị tính"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtTEN_DVT" runat="server" CssClass="ntp_textbox" Width="500px" TabIndex="1" MaxLength="50"></asp:TextBox>
            <asp:TextBox ID="txtID_DVT" runat="server" CssClass="ntp_textbox" Visible="False"
                Width="72px"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%">
            </td>
        <td width="60%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="3" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" /></td>
        <td style="width: 20%">
            </td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" width="80%">
            </td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
        </td>
    </tr>
</table>

