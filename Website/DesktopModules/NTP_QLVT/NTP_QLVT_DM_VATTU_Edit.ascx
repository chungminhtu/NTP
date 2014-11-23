<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_DM_VATTU_Edit.ascx.vb" Inherits="NTP_QLVT_DM_VATTU_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên vật tư/hóa chất"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtTEN_VATTU" runat="server" CssClass="ntp_textbox" Width="500px" TabIndex="1" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTEN_VATTU"
                Display="Dynamic" ErrorMessage="Bạn phải nhập tên đơn vị tính"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtID_VATTU" runat="server" CssClass="ntp_textbox"
                Width="64px" MaxLength="10" TabIndex="1" Visible="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%" style="height: 24px">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Đơn vị tính</asp:Label></td>
        <td width="60%" style="height: 24px">
            <asp:DropDownList ID="cboDVT" runat="server" CssClass="ntp_combobox" DataTextField="TEN_DVT"
                DataValueField="ID_DVT" Width="150px" TabIndex="2"></asp:DropDownList></td>
        <td style="width: 20%; height: 24px;">
            </td>
    </tr>
    <tr>
        <td style="height: 24px" width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label">Loại</asp:Label></td>
        <td style="height: 24px" width="60%">
            <asp:DropDownList ID="cboType" runat="server" CssClass="ntp_combobox" Width="150px" TabIndex="2">
                <asp:ListItem Selected="True" Value="0">H&#243;a chất</asp:ListItem>
                <asp:ListItem Value="1">Vật tư</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 20%; height: 24px">
        </td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Nước sản xuất</asp:Label></td>
        <td width="60%">
            <asp:DropDownList ID="cboNuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_NUOC"
                DataValueField="MA_NUOC" Width="280px" TabIndex="2">
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
            &nbsp;
        </td>
    </tr>
</table>

