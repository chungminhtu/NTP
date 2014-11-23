<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_KHOASO_KIEMKE.ascx.vb" Inherits="NTP_QLVT_KHOASO_KIEMKE" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server Width="100%">
 <table  class = "ntp_table_main">
     <tr>
         <td width="15%">
             <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Mô tả"></asp:Label>
             <asp:Label ID="Label14" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
         <td width="85%">
                <asp:TextBox ID="txtMO_TA" runat="server" CssClass="ntp_textbox" TabIndex="1" MaxLength="250" Width="100%"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMO_TA"
                 Display="Dynamic" ErrorMessage="Bạn phải nhập phần mô tả" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
     </tr>
     <tr>
         <td width="15%">
             <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
         <td width="85%">
             <asp:DropDownList ID="cboNam" runat="server" AutoPostBack="True">
             </asp:DropDownList>
             <asp:TextBox ID="txtLAN_KIEMKE" runat="server" Visible="False" Width="56px"></asp:TextBox></td>
     </tr>
     <tr>
         <td width="15%" valign=top >
             <asp:Label ID="lblThang" runat="server" CssClass="ntp_label" Text=" Chọn tháng khóa sổ"></asp:Label></td>
         <td width="85%" valign = top >
               <asp:CheckBoxList ID="chklThang"   runat="server" RepeatDirection =Horizontal CssClass="ntp_checkbox" Width="100%" CellPadding="3" CellSpacing="3" RepeatColumns="6">
                 <asp:ListItem Value="1">Th&#225;ng 1 - Th&#225;ng 6</asp:ListItem>
                   <asp:ListItem Value="2">Th&#225;ng 7 - Th&#225;ng 12</asp:ListItem>
                 
             </asp:CheckBoxList>
             <asp:Timer ID="Timer1" runat="server" Interval="5000" Enabled="False">
             </asp:Timer>
             </td>
     </tr>
        <tr >
            <td width="15%">
            </td>
            <td width="85%">
                <asp:Button ID="cmdLock" runat="server" Text="Khóa sổ" CssClass="ntp_button" Width="100px" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" Text="Thoát" CssClass="ntp_button" Width="100px" /></td>
        </tr>
     <tr>
         <td colspan="2" width="85%">
         </td>
     </tr>
             
    </table>
    <asp:Panel ID="pnlDetail" runat="server" Width="100%">
        <asp:BulletedList ID="ListStatus" runat="server">
        </asp:BulletedList>
    </asp:Panel>
</asp:Panel>
    






