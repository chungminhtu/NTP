﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_LYDO_NHAPXUAT_Edit.ascx.vb" Inherits="NTP_DM_LYDO_NHAPXUAT_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Mô tả"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtMO_TA" runat="server" CssClass="ntp_textbox" Width="500px" TabIndex="1" MaxLength="250"></asp:TextBox>
            <asp:TextBox ID="txtID" runat="server" CssClass="ntp_textbox" Visible="False"
                Width="72px"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Loại</asp:Label></td>
        <td width="60%">
            <asp:DropDownList ID="cboVung" runat="server" CssClass="ntp_combobox" Width="150px" TabIndex="2">
                <asp:ListItem Value="N">Nhập</asp:ListItem>
                <asp:ListItem Value="X">Xuất</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 20%">
            </td>
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

