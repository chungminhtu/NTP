<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_DM_KHO_Edit.ascx.vb" Inherits="NTP_QLVT_DM_KHO_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register
Assembly="AjaxControlToolkit" 
Namespace="AjaxControlToolkit"
TagPrefix="ajaxToolkit" %>

<table class="ntp_table_main" width="100%">
    <tr>
        <td width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Mã kho"></asp:Label>
            <asp:Label ID="Label7" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtMA_KHO" runat="server" CssClass="ntp_textbox" MaxLength="10"
                TabIndex="1" Width="150px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMA_KHO"
                Display="Dynamic" ErrorMessage="Bạn phải nhập mã kho" CssClass="error"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtID_KHO" runat="server" Width="80px" Visible="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên kho"></asp:Label>
            <asp:Label ID="Label8" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:TextBox ID="txtTEN_KHO" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="2" Width="500px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTEN_KHO"
                Display="Dynamic" ErrorMessage="Bạn phải nhập tên kho" CssClass="error"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Tỉnh"></asp:Label>
            <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%">
            <asp:DropDownList ID="cboTINH" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                DataValueField="MA_TINH" TabIndex="3" Width="150px" AutoPostBack="True">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cboTINH"
                Display="Dynamic" ErrorMessage="Bạn phải chọn tỉnh" CssClass="error"></asp:RequiredFieldValidator>
               
                </td>
    </tr>
    <tr>
        <td style="height: 21px" width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Huyện"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" style="height: 21px" width="80%">
            <asp:DropDownList ID="cboHuyen" runat="server" CssClass="ntp_combobox" DataTextField="TEN_HUYEN"
                DataValueField="MA_HUYEN" TabIndex="4" Width="150px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="cboHuyen"
                Display="Dynamic" ErrorMessage="Bạn phải chọn huyện" CssClass="error"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Kho cấp trên</asp:Label></td>
        <td width="60%"><asp:DropDownList ID="cboKho" runat="server" CssClass="ntp_combobox" DataTextField="TEN_KHO"
                DataValueField="ID_KHO" TabIndex="4" Width="100%">
        </asp:DropDownList></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label6" runat="server" CssClass="ntp_label">Địa chỉ</asp:Label></td>
        <td width="60%">
            <asp:TextBox ID="txtDiaChi" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="6" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
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


