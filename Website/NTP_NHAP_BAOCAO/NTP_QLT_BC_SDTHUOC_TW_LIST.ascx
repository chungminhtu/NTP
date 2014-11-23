<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLT_BC_SDTHUOC_TW_LIST.ascx.vb" Inherits="NTP_QLT_BC_SDTHUOC_TW_LIST" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server Width="100%">
 <table  class = "ntp_table_main" width="100%">
     <tr>
         <td width="15%">
             <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
         <td width="85%">
             <asp:DropDownList ID="cboNam" runat="server">
             </asp:DropDownList>
             <asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="2"
                 Width="150px">
                 <asp:ListItem Value="1">Qu&#253; 1</asp:ListItem>
                 <asp:ListItem Value="2">Qu&#253; 2</asp:ListItem>
                 <asp:ListItem Value="3">Qu&#253; 3</asp:ListItem>
                 <asp:ListItem Value="4">Qu&#253; 4</asp:ListItem>
             </asp:DropDownList></td>
     </tr>
     <tr>
         <td width="15%" style="height: 26px">
         </td>
         <td width="85%" style="height: 26px">
             <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Xem báo cáo"
                 Width="100px" /></td>
     </tr>
     <tr>
         <td colspan="2" width="85%" style="height: 21px">
         </td>
     </tr>
             
    </table>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal></asp:Panel>
    






