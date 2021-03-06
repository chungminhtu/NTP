<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLTTB_DM_THIETBI_Edit.ascx.vb" Inherits="NTP_QLTTB_DM_THIETBI_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register
Assembly="AjaxControlToolkit" 
Namespace="AjaxControlToolkit"
TagPrefix="ajaxToolkit" %>

<table class="ntp_table_main" width="100%">
    <tr>
        <td width="20%">
            </td>
        <td colspan="2" width="80%">
            &nbsp;
            <asp:TextBox ID="txtID_THIETBI" runat="server" Width="80px" Visible="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên thiết bị"></asp:Label>
            <asp:Label ID="Label8" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtTEN_THIETBI" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="2" Width="500px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTEN_THIETBI"
                Display="Dynamic" ErrorMessage="Bạn phải nhập tên thiết bị" CssClass="error"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Nước"></asp:Label>
            <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:DropDownList ID="cboNUOC" runat="server" CssClass="ntp_combobox" DataTextField="TEN_NUOC"
                DataValueField="MA_NUOC" TabIndex="3" Width="150px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cboNUOC"
                Display="Dynamic" ErrorMessage="Bạn phải chọn nước" CssClass="error"></asp:RequiredFieldValidator>
               
                </td>
    </tr>
    <tr>
        <td style="height: 21px" width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Đơn vị tính"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" style="height: 21px" width="80%">
            <asp:DropDownList ID="cboDVT" runat="server" CssClass="ntp_combobox" DataTextField="TEN_DVT"
                DataValueField="ID_DVT" TabIndex="4" Width="150px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="cboDVT"
                Display="Dynamic" ErrorMessage="Bạn phải chọn đơn vị tính" CssClass="error"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label6" runat="server" CssClass="ntp_label">Nhãn hiệu</asp:Label></td>
        <td width="60%">
            <asp:TextBox ID="txtNhanHieu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="6" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" width="80%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" TabIndex="7" Text="Ghi lại"
                Width="100px" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                Text="Thoát" Width="100px" /></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            &nbsp;
        </td>
    </tr>
</table>



