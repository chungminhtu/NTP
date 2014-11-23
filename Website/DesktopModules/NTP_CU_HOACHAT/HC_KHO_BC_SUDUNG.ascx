<%@ Control Language="VB" AutoEventWireup="false" CodeFile="HC_KHO_BC_SUDUNG.ascx.vb" Inherits="HC_KHO_BC_SUDUNG" %>
<table  class = "ntp_table_main" width=100%>
    <tr>
        <td  width=15%>
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
        <td width=85%>
            <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="4"
                TabIndex="2" Width="100px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Bạn phải nhập số"
                MaximumValue="9999" MinimumValue="0" SetFocusOnError="True" Type="Integer" ControlToValidate="txtNam"></asp:RangeValidator>
            </td>
      
    </tr>
    <tr>
        <td width=15% style="height: 9px">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Kỳ báo cáo"></asp:Label></td>
        <td width=85% style="height: 9px">
            <asp:RadioButtonList ID="rblLoaiBC" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="1">Th&#225;ng</asp:ListItem>
                <asp:ListItem Value="2">Qu&#253;</asp:ListItem>
            </asp:RadioButtonList></td>
    </tr>
    <tr>
        <td style="height: 24px" width="15%">
        </td>
        <td style="height: 24px" width="85%">
            <asp:DropDownList ID="cboThang" runat="server" CssClass="ntp_combobox" TabIndex="2" Width="100px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="height: 24px" width="15%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
        <td style="height: 24px" width="85%">
            <asp:DropDownList ID="cboNguonKP" runat="server" CssClass="ntp_combobox" TabIndex="2" Width="400px" DataTextField="MO_TA" DataValueField="ID_NGUONKINHPHI">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="height: 24px" width="15%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Loại thuốc"></asp:Label></td>
        <td style="height: 24px" width="85%">
            <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" TabIndex="2" Width="400px" DataTextField="TEN_vattu" DataValueField="ID_vattu">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="height: 24px" width="15%">
        </td>
        <td style="height: 24px" width="85%">
            <asp:Button ID="cmdView" runat="server" CssClass="ntp_button" Text="Xem báo cáo" Width="100px" />&nbsp;<asp:Literal
                ID="Literal1" runat="server"></asp:Literal></td>
    </tr>
    <tr>
        <td colspan="2" style="height: 24px" width="15%">
        </td>
    </tr>
  
</table>
