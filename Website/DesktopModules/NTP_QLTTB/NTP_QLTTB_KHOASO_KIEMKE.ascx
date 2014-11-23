<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLTTB_KHOASO_KIEMKE.ascx.vb" Inherits="NTP_QLTTB_KHOASO_KIEMKE" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server Width="100%">
 <table  class = "ntp_table_main">
     <tr>
         <td width="15%">
             <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Ngày kiểm kê"></asp:Label>
             <asp:Label ID="Label4" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
         <td width="85%">
             <asp:TextBox ID="txtNgayKK" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="1"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender2"
                     runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                     PromptCharacter="_" TargetControlID="txtNgayKK">
                 </ajaxToolkit:MaskedEditExtender>
             <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender2"
                 ControlToValidate="txtNgayKK" Display="Dynamic" EmptyValueMessage="Bạn phải nhập ngày"
                 InvalidValueMessage="Định dạng ngày không đúng" IsValidEmpty="False" MaximumValue="31/12/9999"
                 MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                 MinimumValue="1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                 SetFocusOnError="True" TooltipMessage="Nhập ngày (dd/MM/yyyy)"></ajaxToolkit:MaskedEditValidator></td>
     </tr>
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
             <asp:TextBox ID="txtLAN_KIEMKE" runat="server" Visible="False" Width="56px"></asp:TextBox>
             <asp:Timer ID="Timer1" runat="server" Interval="5000" Enabled="False">
             </asp:Timer>
             </td>
     </tr>
     <tr>
         <td width="15%" valign=top >
             </td>
         <td width="85%" valign = top >
             </td>
     </tr>
        <tr >
            <td width="15%" style="height: 26px">
            </td>
            <td width="85%" style="height: 26px">
                <asp:Button ID="cmdLock" runat="server" Text="Khóa sổ" CssClass="ntp_button" Width="100px" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" Text="Thoát" CssClass="ntp_button" Width="100px" CausesValidation="False" /></td>
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
    






