<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_SO_THEODOI_HC.ascx.vb" Inherits="NTP_QLVT_SO_THEODOI_VT" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server>
 <table  class = "ntp_table_main">
     <tr>
         <td width="20%">
             <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Vật tư"></asp:Label></td>
         <td width="30%">
              <asp:DropDownList ID="cboVattu" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VATTU"
                  DataValueField="ID_VATTU" TabIndex="2" Width="100%">
              </asp:DropDownList></td>
         <td style="width: 20%">
             </td>
          <td style="width: 30%">
              </td>
     </tr>
     <tr>
         <td width="20%">
             <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Ngày báo cáo (từ ngày)"></asp:Label></td>
         <td width="30%">
             <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="1"></asp:TextBox>
                 <ajaxtoolkit:maskededitextender id="MaskedEditExtender1" runat="server" targetcontrolid="txtTuNgay" promptcharacter="_" masktype="Date" mask="99/99/9999" culturename="vi-VN" autocomplete="true"> </ajaxtoolkit:maskededitextender>
                 <ajaxtoolkit:maskededitvalidator id="MaskedEditValidator1" runat="server" tooltipmessage="Nhập ngày" setfocusonerror="True" invalidvaluemessage="Định dạng ngày không đúng" emptyvaluemessage="Date is required" controltovalidate="txtTuNgay" controlextender="MaskedEditExtender1" Display="Dynamic" MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" MinimumValue="1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"></ajaxtoolkit:maskededitvalidator></td>
         <td style="width: 20%">
             <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Đến ngày</asp:Label></td>
          <td style="width: 30%">
              
              <asp:TextBox ID="txtDenNgay" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"></asp:TextBox>
               <ajaxtoolkit:maskededitextender id="MaskedEditExtender2" runat="server" targetcontrolid="txtDenNgay" promptcharacter="_" masktype="Date" mask="99/99/9999" culturename="vi-VN" autocomplete="true"> </ajaxtoolkit:maskededitextender>
                 <ajaxtoolkit:maskededitvalidator id="MaskedEditValidator2" runat="server" tooltipmessage="Nhập ngày" setfocusonerror="True" invalidvaluemessage="Định dạng ngày không đúng" emptyvaluemessage="Date is required" controltovalidate="txtDenNgay" controlextender="MaskedEditExtender2" Display="Dynamic" MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" MinimumValue="1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" ></ajaxtoolkit:maskededitvalidator>
              </td>
     </tr>
        <tr display="Static">
            <td width="20%">
            </td>
            <td width="30%"  colspan=3>
                <asp:Button ID="cmdView" runat="server" Text="Xem báo cáo" CssClass="ntp_button" Width="100px" />&nbsp;
            &nbsp;<asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="ntp_button" Width="100px" CausesValidation="False" /></td>
        </tr>
        <tr>
            <td colspan="4" width="100%">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal></td>
        </tr>
       
    </table>
</asp:Panel>       






