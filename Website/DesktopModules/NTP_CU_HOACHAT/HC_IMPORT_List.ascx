<%@ Control Language="VB" AutoEventWireup="false" CodeFile="HC_IMPORT_List.ascx.vb" Inherits="HC_IMPORT_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server>
 <table  class = "ntp_table_main">
     <tr>
         <td width="20%">
             <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Mã phiếu"></asp:Label></td>
         <td width="30%">
                <asp:TextBox ID="txtMA_PHIEU" runat="server" CssClass="ntp_textbox" TabIndex="1" MaxLength="20"></asp:TextBox></td>
         <td style="width: 20%">
             <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
          <td style="width: 30%">
              <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                  DataValueField="ID_NGUONKINHPHI" TabIndex="2" Width="100%">
              </asp:DropDownList></td>
     </tr>
     <tr>
         <td width="20%">
             <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Ngày nhập (từ ngày)"></asp:Label></td>
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
                <asp:Button ID="cmdAdd" runat="server" Text="Thêm mới" CssClass="ntp_button" Width="100px" />&nbsp;
            <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="ntp_button" Width="100px" />&nbsp;
         <asp:Button ID="cmdSearch" runat="server" Text="Tìm kiếm" CssClass="ntp_button" Width="100px" /><ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server"
    TargetControlID="cmdDelete"
    ConfirmText="Bạn thực sự muốn xóa phiếu nhập này?"
     />
         </td>
        </tr>
        <tr>
            <td colspan="4" width="100%">
                <cc3:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                    AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                    HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                    ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
                    <Columns>
                        <asp:TemplateColumn>
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w6" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="ID_IMPORT" HeaderText="ID_IMPORT" Visible="False">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TRANG_THAI" HeaderText="TRANG_THAI" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="MA_PHIEU" HeaderText="M&#227; phiếu">
                            <headerstyle width="16%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NGAY_NHAP_KHO" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ng&#224;y nhập kho">
                            <headerstyle width="15%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NGUOI_VIETPHIEU" HeaderText="Người viết phiếu">
                            <headerstyle width="15%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="MO_TA" HeaderText="Nguồn kinh ph&#237;">
                            <headerstyle width="20%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_VATTU" HeaderText="T&#234;n vật tư"></asp:BoundColumn>
                        <asp:BoundColumn DataField="LO_SX" HeaderText="L&#244; SX"></asp:BoundColumn>
                        <asp:BoundColumn DataField="HAN_DUNG" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Hạn d&#249;ng">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="SO_LUONG" HeaderText="Số lượng"></asp:BoundColumn>
                        <asp:TemplateColumn>
                           
                        </asp:TemplateColumn>
                    </Columns>
                    <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
                    <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                    <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                    <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                    <ItemStyle CssClass="ntp_grd_RowStyle" />
                    <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                </cc3:MultiSelectGrid></td>
        </tr>
       
    </table>
</asp:Panel>       






