<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLTTB_PHIEUXUAT_List.ascx.vb" Inherits="NTP_QLTTB_PHIEUXUAT_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
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
             <cc4:autosuggestbox id="txtMaPhieu" runat="server" cssclass="ntp_textbox" datapage="NTP_QLTTB_PHIEUXUAT_Search.aspx"></cc4:autosuggestbox>
         </td>
         <td style="width: 20%">
             <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
          <td style="width: 30%">
              <asp:DropDownList ID="cboNguonKinhPhi" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                  DataValueField="ID_NGUONKINHPHI" TabIndex="2" Width="150px">
              </asp:DropDownList></td>
     </tr>
     <tr>
         <td width="20%">
             <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Ngày nhập (từ ngày)"></asp:Label></td>
         <td width="30%">
             <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="1"></asp:TextBox>
                 <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server" Mask="99/99/9999" MaskType="Date" TargetControlID="txtTuNgay" PromptCharacter="_"  AutoComplete="true"  CultureName="vi-VN"     > </ajaxToolkit:MaskedEditExtender>
                <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1" ControlToValidate="txtTuNgay"  InvalidValueMessage="Date is invalid" IsValidEmpty="True"  TooltipMessage="Input a Date" SetFocusOnError="True" ></ajaxToolkit:MaskedEditValidator>
                 </td>
         <td style="width: 20%">
             <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Đến ngày</asp:Label></td>
          <td style="width: 30%">
              <asp:TextBox ID="txtDenNgay" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"></asp:TextBox><br />
              <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender2" runat="server" Mask="99/99/9999" MaskType="Date" TargetControlID="txtDenNgay" PromptCharacter="_"  AutoComplete="true"  CultureName="vi-VN"     >
              </ajaxToolkit:MaskedEditExtender>
              <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender1"
                  ControlToValidate="txtDenNgay" InvalidValueMessage="Date is invalid" IsValidEmpty="True"
                  SetFocusOnError="True" TooltipMessage="Input a Date"></ajaxToolkit:MaskedEditValidator></td>
     </tr>
        <tr>
            <td width="20%">
            </td>
            <td width="30%"  colspan=3>
                <asp:Button ID="cmdAdd" runat="server" Text="Thêm mới" CssClass="ntp_button" Width="100px" />&nbsp;
            <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="ntp_button" Width="100px" />&nbsp;
         <asp:Button ID="cmdSearch" runat="server" Text="Tìm kiếm" CssClass="ntp_button" Width="100px" /></td>
        </tr>
        <tr>
            <td colspan="4" width="100%">
                <cc3:MultiSelectGrid ID="grdDS" runat="server" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" Width="100%"
                    CssClass="ntp_grd_GridViewStyle"
                    HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                    AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                    EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                    ItemStyle-CssClass = "ntp_grd_RowStyle"
                    PagerStyle-CssClass = "ntp_grd_PagerStyle"
                    HighlightCssClass="ntp_grd_SelectedRowStyle"
                    >
                    <Columns>
                        <asp:TemplateColumn>
                            <headerstyle width="2%"  />
                            
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <itemtemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
    
</itemtemplate>
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="ID_PHIEUXUAT" HeaderText="ID_PHIEUXUAT" Visible="False">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="MA_PHIEUXUAT" HeaderText="M&#227; phiếu xuất">
                            <headerstyle width="16%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NGAY_XUAT" HeaderText="Ng&#224;y xuất" DataFormatString="{0:dd/MM/yyyy}">
                            <headerstyle width="15%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NGUOI_XUAT" HeaderText="Người xuất">
                            <headerstyle width="15%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="MO_TA" HeaderText="Nguồn kinh ph&#237;">
                            <headerstyle width="20%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="KHONHAP" HeaderText="Kho nhập">
                            <headerstyle width="15%" />
                        </asp:BoundColumn>
                    </Columns>
                    <PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle" />
                    <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                    <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                    <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                    <ItemStyle CssClass="ntp_grd_RowStyle" />
                    <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                </cc3:MultiSelectGrid></td>
        </tr>
       
    </table>
</asp:Panel>       
