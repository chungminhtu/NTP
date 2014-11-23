<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_PHIEUXUAT_Edit.ascx.vb" Inherits="NTP_QLVT_PHIEUXUAT_Edit" %>
<%@ Register Assembly="MetaBuilders.WebControls.ConfirmedButtons" Namespace="MetaBuilders.WebControls"
    TagPrefix="mbcb" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Panel ID="pnlHeader" runat="server" Width="100%">
    <fieldset class="ntp_fieldset">
        <legend class="ntp_legend">Thông tin phiếu xuất</legend>
        <table class="ntp_table_main" width="100%">
            <tr>
                <td width="20%">
                    <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Mã phiếu"></asp:Label>
                    <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="width: 30%">
                    <asp:TextBox ID="txtMA_PHIEU" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="1" Width="50%"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMA_PHIEU"
                        Display="Dynamic" ErrorMessage="Bạn phải nhập mã phiếu"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="txtID_PHIEUXUAT" runat="server" CssClass="ntp_textbox" MaxLength="10"
                        TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
                <td width="20%">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label">Ngày xuất (dd/mm/yyyy)</asp:Label>
                    <asp:Label ID="Label14" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td width="30%">
                    <asp:TextBox ID="txtNgayXuat" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="2" Width="100px"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1"
                            runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                            PromptCharacter="_" TargetControlID="txtNgayXuat">
                        </ajaxToolkit:MaskedEditExtender>
                    <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                        ControlToValidate="txtNgayXuat" EmptyValueMessage="Date is required" InvalidValueMessage="Định dạng ngày không đúng"
                        IsValidEmpty="False" SetFocusOnError="True" TooltipMessage="Nhập ngày" MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" MinimumValue="1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"></ajaxToolkit:MaskedEditValidator></td>
            </tr>
            <tr>
                <td width="20%">
                    <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Nguồn kinh phí</asp:Label>
                    <asp:Label ID="Label12" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="width: 30%">
                    <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                        DataValueField="ID_NGUONKINHPHI" TabIndex="3" Width="100%">
                    </asp:DropDownList></td>
                <td width="20%">
                    <asp:Label ID="Label6" runat="server" CssClass="ntp_label">Lý do xuất</asp:Label>
                    <asp:Label ID="Label13" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td width="30%">
                    <asp:DropDownList ID="cboLYDO_NHAPXUAT" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                        DataValueField="ID" TabIndex="4" Width="100%">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td width="20%">
                    &nbsp;<asp:Label ID="Label15" runat="server" CssClass="ntp_label">Người viết phiếu</asp:Label>
                    <asp:Label ID="Label16" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="width: 30%">
                    <asp:TextBox ID="txtNGUOI_XUAT" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="5" Width="50%"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNGUOI_XUAT"
                        Display="Dynamic" ErrorMessage="Bạn phải nhập tên người viết phiếu"></asp:RequiredFieldValidator></td>
                <td width="20%">
                    <asp:Label ID="Label7" runat="server" CssClass="ntp_label">Xuất cho kho</asp:Label></td>
                <td width="30%">
                    <cc3:AutoSuggestBox ID="txtSearhKhoCapTren" runat="server" CssClass="ntp_textbox"
                        DataPage="searchkho.aspx" TabIndex="6" Width="100%"></cc3:AutoSuggestBox></td>
            </tr>
            <tr>
                <td width="20%">
                    <asp:Label ID="Label8" runat="server" CssClass="ntp_label">Ghi chú</asp:Label></td>
                <td colspan="3" style="width: 30%">
                    <asp:TextBox ID="txtGhiChu" runat="server" CssClass="ntp_textbox" MaxLength="250"
                        TabIndex="7" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td width="20%">
                </td>
                <td colspan="3" style="width: 30%">
                    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="8" Text="Ghi phiếu"
                        Width="100px" />&nbsp;
                    <asp:Button ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                        Text="Thoát" Width="100px" />&nbsp;
                    <asp:Button ID="cmdCreateNew" runat="server" CssClass="ntp_button" TabIndex="8" Text="Tạo phiếu mới"
                        Width="100px" CausesValidation="False" /></td>
            </tr>
        </table>
    </fieldset>
</asp:Panel>
<asp:Panel ID="pnlDetail" runat="server" DefaultButton="cmdSave" Width="100%">
    <fieldset class="ntp_fieldset">
        <legend class="ntp_legend">
        Phiếu xuất chi tiết </legend>
        <table class="ntp_table_main" width="100%">
            <tr>
                <td style="height: 26px" width="20%">
                    <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Vật tư"></asp:Label>
                    <asp:Label ID="Label10" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td colspan="2" style="height: 26px" width="80%">
                    <asp:DropDownList ID="cboVATTU" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VATTU"
                        DataValueField="ID_VATTU" TabIndex="10" Width="50%">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtID_PHIEUXUAT_CHITIET" runat="server" CssClass="ntp_textbox" MaxLength="10"
                        TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 26px" width="20%">
                    <asp:Label ID="Label17" runat="server" CssClass="ntp_label">Lô sản xuất</asp:Label>
                    <asp:Label ID="Label20" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td colspan="2" style="height: 26px" width="80%">
                    <asp:TextBox ID="txtLoSX" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11"
                        Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 26px" width="20%">
                    <asp:Label ID="Label19" runat="server" CssClass="ntp_label" Text="Hạn sử dụng (dd/mm/yyyy)"></asp:Label></td>
                <td colspan="2" style="height: 26px" width="80%">
                    <asp:TextBox ID="txtHanSD" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12"></asp:TextBox><ajaxToolkit:MaskedEditExtender
                        ID="Maskededitextender2" runat="server" AutoComplete="true" CultureName="vi-VN"
                        Mask="99/99/9999" MaskType="Date" PromptCharacter="_" TargetControlID="txtHanSD">
                    </ajaxToolkit:MaskedEditExtender>
                    <ajaxToolkit:MaskedEditValidator ID="Maskededitvalidator2" runat="server" ControlExtender="Maskededitextender2"
                        ControlToValidate="txtHanSD" EmptyValueMessage="Bạn phải nhập ngày" InvalidValueMessage="Định dạng ngày không đúng"
                        SetFocusOnError="True" TooltipMessage="Nhập ngày" MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" MinimumValue="1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"></ajaxToolkit:MaskedEditValidator></td>
            </tr>
            <tr>
                <td style="height: 26px" width="20%">
                    <asp:Label ID="Label18" runat="server" CssClass="ntp_label">Nước sản xuất</asp:Label></td>
                <td colspan="2" style="height: 26px" width="80%">
                    <asp:DropDownList ID="cboNuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_NUOC"
                        DataValueField="MA_NUOC" TabIndex="13" Width="50%">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="height: 26px" width="20%">
                    <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Số lượng</asp:Label>
                    <asp:Label ID="Label11" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="height: 26px" width="60%">
                    <asp:TextBox ID="txtSoLuong" runat="server" CssClass="ntp_textbox" MaxLength="10"
                        TabIndex="12" Width="100px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSoLuong"
                        Display="Dynamic" ErrorMessage="Bạn phải nhập số lượng"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSoLuong"
                        ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                        Type="Double"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td width="20%">
                </td>
                <td width="60%">
                </td>
            </tr>
            <tr>
                <td width="20%">
                </td>
                <td colspan="2" width="80%">
                    <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" TabIndex="13" Text="Ghi lại"
                        Width="100px" />&nbsp;
                    <asp:Button ID="cmdDelete" runat="server" CausesValidation="False" CssClass="ntp_button"
                        Text="Xóa vật tư" Width="100px" />
                    <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa vật tư này trên phiếu?"
                        TargetControlID="cmdDelete">
                    </ajaxToolkit:ConfirmButtonExtender>
                </td>
            </tr>
            <tr>
                <td colspan="3" width="20%">
                    <cc4:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                        AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                        HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                        ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                        SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
                        <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                        <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                        <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
                        <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                        <ItemStyle CssClass="ntp_grd_RowStyle" />
                        <Columns>
                            <asp:TemplateColumn>
                                <headerstyle width="2%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn>
                                <itemtemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton>
    
</itemtemplate>
                                <headerstyle width="2%" />
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="ID_PHIEUXUAT_CHITIET" HeaderText="ID_CHITIET" Visible="False">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="ID_VATTU" HeaderText="ID_VATTU" Visible="False"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TEN_VATTU" HeaderText="T&#234;n Vật tư">
                                <headerstyle width="56%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="TEN_DVT" HeaderText="Đơn vị t&#237;nh">
                                <headerstyle width="10%" />
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="SO_LUONG" HeaderText="Số lượng">
                                <headerstyle width="20%" />
                            </asp:BoundColumn>
                        </Columns>
                        <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                    </cc4:MultiSelectGrid>
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Panel>


