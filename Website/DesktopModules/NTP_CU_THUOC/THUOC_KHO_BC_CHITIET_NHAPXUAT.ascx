<%@ Control Language="VB" AutoEventWireup="false" CodeFile="THUOC_KHO_BC_CHITIET_NHAPXUAT.ascx.vb" Inherits="THUOC_KHO_BC_CHITIET_NHAPXUAT" %>
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
        <td style="height: 24px" width="15%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tháng"></asp:Label></td>
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
            <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" TabIndex="2" Width="400px" DataTextField="TEN_THUOC" DataValueField="ID_THUOC">
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
