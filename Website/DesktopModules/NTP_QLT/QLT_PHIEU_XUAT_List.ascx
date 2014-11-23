<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_PHIEU_XUAT_List.ascx.vb" Inherits="QLT_PHIEU_XUAT_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat="server" Width="100%">
    <table class="ntp_table_main" width="100%" style="width: 100%">
        <tr>
            <td width="20%">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Mã phiếu"></asp:Label></td>
            <td width="30%">
                <asp:TextBox ID="txtMA_PHIEU" runat="server" CssClass="ntp_textbox" MaxLength="20"></asp:TextBox></td>
            <td width="20%">
                <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
            <td width="30%">
                <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                    DataValueField="ID_NGUONKINHPHI" Width="100%">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td width="20%">
                <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Ngày xuất (từ ngày)"></asp:Label></td>
            <td width="30%">
                <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server" AutoComplete="true"
                    CultureName="vi-VN" Mask="99/99/9999" MaskType="Date" PromptCharacter="_" TargetControlID="txtTuNgay">
                </ajaxToolkit:MaskedEditExtender>
                <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                    ControlToValidate="txtTuNgay" Display="Dynamic" EmptyValueMessage="Date is required"
                    InvalidValueMessage="Định dạng ngày không đúng" SetFocusOnError="True" TooltipMessage="Nhập ngày"></ajaxToolkit:MaskedEditValidator>
            </td>
            <td width="20%">
                <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Đến ngày</asp:Label></td>
            <td width="30%">
                <asp:TextBox ID="txtDenNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender2" runat="server" AutoComplete="true"
                    CultureName="vi-VN" Mask="99/99/9999" MaskType="Date" PromptCharacter="_" TargetControlID="txtDenNgay">
                </ajaxToolkit:MaskedEditExtender>
                <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                    ControlToValidate="txtDenNgay" Display="Dynamic" EmptyValueMessage="Date is required"
                    InvalidValueMessage="Định dạng ngày không đúng" SetFocusOnError="True" TooltipMessage="Nhập ngày"></ajaxToolkit:MaskedEditValidator>
            </td>
        </tr>
        <tr display="Static">
            <td width="20%">
            </td>
            <td colspan="3" width="30%">
                <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Thêm mới" />&nbsp;
                <asp:Button
                    ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" />&nbsp;
                <asp:Button ID="cmdSearch" runat="server" CssClass="ntp_button" Text="Tìm kiếm" Width="100px" />
                <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa phiếu nhập này?"
                    TargetControlID="cmdDelete">
                </ajaxToolkit:ConfirmButtonExtender>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;<asp:DataGrid ID="grdDS" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                     
                    
                     CssClass="ntp_grd_GridViewStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                ItemStyle-CssClass = "ntp_grd_RowStyle"
                PagerStyle-CssClass = "ntp_grd_PagerStyle"
                HighlightCssClass="ntp_grd_SelectedRowStyle">
                    <Columns>
                        <asp:TemplateColumn>
                            <HeaderTemplate>
                                <asp:CheckBox ID="NTP_QLT_PHIEUNHAPToggleAll" runat="server" onclick="toggleAllCheckboxes(this);" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="grdCmdSel" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle CssClass="header_cell" Width="2%" />
                            <ItemStyle CssClass="icon_cell" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <asp:ImageButton ID="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" />
                            </ItemTemplate>
                            <HeaderStyle Width="2%" />
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="ID_PHIEUXUAT" HeaderText="ID_PHIEUXUAT" Visible="False">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="MA_PHIEUXUAT" HeaderText="M&#227; phiếu xuất">
                            <HeaderStyle CssClass="header_cell" />
                            <ItemStyle CssClass="table_cell" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="ID_DONVI_XUAT" HeaderText="Đơn vị xuất" Visible="False">
                            <HeaderStyle CssClass="header_cell" />
                            <ItemStyle CssClass="table_cell" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NGAY_XUAT" HeaderText="Ng&#224;y xuất" DataFormatString="{0:dd/MM/yyyy}">
                            <HeaderStyle CssClass="header_cell" />
                            <ItemStyle CssClass="table_cell" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NGUOI_XUAT" HeaderText="Người xuất">
                            <HeaderStyle CssClass="header_cell" />
                            <ItemStyle CssClass="table_cell" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="LYDO_NHAPXUAT" HeaderText="L&#253; do xuất">
                            <HeaderStyle CssClass="header_cell" Width="30%" />
                            <ItemStyle CssClass="table_cell" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                Font-Strikeout="False" Font-Underline="False" Wrap="False" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="ID_NGUONKINHPHI" HeaderText="Nguồn kinh ph&#237;">
                            <HeaderStyle CssClass="header_cell" />
                            <ItemStyle CssClass="table_cell" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TRANG_THAI" HeaderText="Trạng th&#225;i" Visible="False">
                            <HeaderStyle CssClass="header_cell" />
                            <ItemStyle CssClass="table_cell" />
                        </asp:BoundColumn>
                        <asp:TemplateColumn Visible="False">
                            <ItemTemplate>
                                <em><span style="text-decoration: underline"></span></em>
                                <asp:Button ID="cmdXem" runat="server" CommandName="cmdXem" Text="Xem" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle" HorizontalAlign="Center" />
                <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                <ItemStyle CssClass="ntp_grd_RowStyle" />
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                
                </asp:DataGrid></td>
        </tr>
    </table>
</asp:Panel>
