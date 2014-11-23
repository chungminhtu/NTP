<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_PHIEU_XUAT_Edit.ascx.vb" Inherits="QLT_PHIEU_XUAT_Edit" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<table border="0" cellpadding="0" cellspacing="0" class="dialog_view" style="width: 100%">
    <tr>
        <td valign="top" width="100%" style="height: 537px">
            <table id="CollapsibleRegion" border="0" cellpadding="0" cellspacing="0" style="display: block"
                width="100%">
                <tr>
                    <td class="dialog_body" style="height: 137px">
                        <table border="0" cellpadding="0" cellspacing="3" width="100%">
                            <tr>
                                <td class="field_label_on_side" width="15%">
                                    <asp:Literal ID="MA_PHIEU_NHAPLabel" runat="server" Text="Mã phiếu xuất"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" width="35%">
                                    <asp:TextBox ID="txtMA_PHIEU_NHAP" runat="server" Columns="20" CssClass="ntp_textbox"
                                        MaxLength="20"></asp:TextBox>&nbsp;
                                    <asp:RequiredFieldValidator ID="MA_PHIEU_NHAPRequiredFieldValidator" runat="server"
                                        ControlToValidate="txtMA_PHIEU_NHAP" Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>&nbsp;
                                </td>
                                <td class="dialog_field_value" width="15%">
                                    <asp:Literal ID="ID_PHIEUXUATLabel" runat="server" Text="Phiếu nhập" Visible="False"></asp:Literal></td>
                                <td class="dialog_field_value" width="35%">
                                    <asp:TextBox ID="txtPhieu_Xuat" runat="server" Columns="0" CssClass="ntp_textbox"
                                        MaxLength="0" Visible="False"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side" style="height: 9px" width="15%">
                                    <asp:Literal ID="NGAY_NHAPLabel" runat="server" Text="Ngày xuất"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="height: 9px" width="35%">
                                    <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1"
                                            runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                                            PromptCharacter="_" TargetControlID="txtTuNgay">
                                        </ajaxToolkit:MaskedEditExtender>
                                    <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                        ControlToValidate="txtTuNgay" EmptyValueMessage="Date is required" InvalidValueMessage="Định dạng ngày không đúng"
                                        IsValidEmpty="False" SetFocusOnError="True" TooltipMessage="Nhập ngày"></ajaxToolkit:MaskedEditValidator>
                                </td>
                                <td class="dialog_field_value" style="height: 9px" width="15%">
                                    <asp:Literal ID="NGUOI_NHAPLabel" runat="server" Text="Người xuất"></asp:Literal></td>
                                <td class="dialog_field_value" style="height: 9px" width="35%">
                                    <asp:TextBox ID="txtNGUOI_NHAP" runat="server" Columns="50" CssClass="ntp_textbox"
                                        MaxLength="50" Width="100%"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="Nguoi_XuatRequiredFieldValidator1" runat="server"
                                        ControlToValidate="txtNGUOI_NHAP" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side" width="15%">
                                    <asp:Literal ID="ID_LYDO_NHAPXUATLabel" runat="server" Text="Lý do xuất"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" width="35%">
                                    <asp:DropDownList ID="cboLYDO_NHAPXUAT" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                                        DataValueField="ID">
                                        <asp:ListItem Value="12">Xuất Nội tr&#250;</asp:ListItem>
                                        <asp:ListItem Value="13">Xuất Bệnh nh&#226;n ngoại tr&#250;</asp:ListItem>
                                        <asp:ListItem Value="14">Xuất c&#225;c huyện</asp:ListItem>
                                        <asp:ListItem Value="15">Xuất thiếu</asp:ListItem>
                                        <asp:ListItem Value="16">Xuất hỏng, vỡ</asp:ListItem>
                                    </asp:DropDownList>&nbsp;
                                    <asp:RequiredFieldValidator ID="ID_LYDO_NHAPXUATRequiredFieldValidator" runat="server"
                                        ControlToValidate="cboLYDO_NHAPXUAT" Enabled="True" ErrorMessage="Phải nhập "></asp:RequiredFieldValidator></td>
                                <td class="dialog_field_value" width="15%">
                                    <asp:Literal ID="ID_NGUONKINHPHILabel" runat="server" Text="Nguồn kinh phí"></asp:Literal></td>
                                <td class="dialog_field_value" width="35%">
                                    <asp:DropDownList ID="cboNGUONKINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="Mo_Ta"
                                        DataValueField="ID_NGUONKINHPHI" Width="155px">
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side" width="15%">
                                    <asp:Literal ID="GHI_CHULabel" runat="server" Text="Ghi chú"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" colspan="3">
                                    <asp:TextBox ID="txtGHI_CHU" runat="server" Columns="100" CssClass="ntp_textbox"
                                        MaxLength="500" Width="100%"></asp:TextBox></td>
                            </tr>
                        </table>
                        <asp:Button ID="cmdSave" runat="server" Text="Ghi lại" Width="87px" CssClass="ntp_button" />&nbsp;
                        <asp:Button
                            ID="cmdCancel" runat="server" Text="Thoát" Width="87px" CausesValidation="False" CssClass="ntp_button" />&nbsp;
                        <asp:Button ID="Button1"
                                runat="server" Text="Chi tiết phiếu" Visible="False" Width="87px" CssClass="ntp_button" />
                        <asp:TextBox ID="txtID_PHIEUXUAT" runat="server" Columns="0" CssClass="field_input"
                            MaxLength="0" Visible="False" Width="59px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="dialog_body" style="height: 8px">
                        <table id="Table1" border="0" cellpadding="0" cellspacing="0" style="display: block;
                            height: 224px" width="100%">
                            <tr>
                                <td class="dialog_body" style="height: 61px" valign="top">
                                    <table border="0" cellpadding="0" cellspacing="3" id="Table2">
                                        <tr>
                                            <td class="field_label_on_side" width="15%">
                                                <asp:Literal ID="ID_THUOCLabel" runat="server" Text="Tên thuốc"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" valign="top" width="35%">
                                                <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_THUOC"
                                                    DataValueField="ID_THUOC" Width="155px" AutoPostBack="True"></asp:DropDownList>&nbsp;
                                                <asp:RequiredFieldValidator ID="ID_THUOCRequiredFieldValidator" runat="server" ControlToValidate="cboThuoc" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>&nbsp;
                                            </td>
                                            <td class="dialog_field_value" valign="top" width="15%">
                                                <asp:Literal ID="LO_SXLabel" runat="server" Text="Lô sản xuất"></asp:Literal></td>
                                            <td class="dialog_field_value" valign="top" width="35%"><asp:DropDownList ID="cboLoSX" runat="server" CssClass="ntp_combobox" DataTextField="LoSX"
                                                    DataValueField="LoSX" Width="155px">
                                            </asp:DropDownList>
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" style="height: 19px" width="15%">
                                                <asp:Literal ID="HAN_SUDUNGLabel" runat="server" Text="Hạn dùng"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" style="height: 19px" width="35%">
                                                <asp:TextBox ID="dtmHan_SuDung" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="Maskededitextender3"
                                                        runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                                                        PromptCharacter="_" TargetControlID="dtmHan_SuDung">
                                                    </ajaxToolkit:MaskedEditExtender>
                                                <ajaxToolkit:MaskedEditValidator ID="Maskededitvalidator3" runat="server" ControlExtender="MaskedEditExtender1"
                                                    ControlToValidate="dtmHan_SuDung" EmptyValueMessage="Date is required" Enabled="False"
                                                    InvalidValueMessage="Định dạng ngày không đúng" IsValidEmpty="False" SetFocusOnError="True"
                                                    TooltipMessage="Nhập ngày"></ajaxToolkit:MaskedEditValidator></td>
                                            <td class="dialog_field_value" style="height: 19px" width="15%">
                                                <asp:Literal ID="NGAY_SXLabel" runat="server" Text="Ngày sản xuất"></asp:Literal></td>
                                            <td class="dialog_field_value" style="height: 19px" width="35%">
                                                <asp:TextBox ID="dtmNgay_SX" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="Maskededitextender4"
                                                        runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                                                        PromptCharacter="_" TargetControlID="dtmNgay_SX">
                                                    </ajaxToolkit:MaskedEditExtender>
                                                <ajaxToolkit:MaskedEditValidator ID="Maskededitvalidator4" runat="server" ControlExtender="MaskedEditExtender1"
                                                    ControlToValidate="dtmNgay_SX" EmptyValueMessage="Date is required" Enabled="False"
                                                    InvalidValueMessage="Định dạng ngày không đúng" IsValidEmpty="False" SetFocusOnError="True"
                                                    TooltipMessage="Nhập ngày"></ajaxToolkit:MaskedEditValidator></td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" width="15%">
                                                <asp:Literal ID="SO_LUONGLabel" runat="server" Text="Số lượng"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" valign="top" width="35%">
                                                <asp:TextBox ID="txtSO_LUONG" runat="server" Columns="0" CssClass="ntp_textbox" MaxLength="0">0</asp:TextBox>&nbsp;
                                                <asp:RequiredFieldValidator ID="SO_LUONGRequiredFieldValidator" runat="server" ControlToValidate="txtSO_LUONG" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
                                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSO_LUONG"
                                                    ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                                                    Type="Double"></asp:RangeValidator>&nbsp;
                                            </td>
                                            <td class="dialog_field_value" valign="top" colspan="2">
                                                <asp:Button ID="cmdOK" runat="server" CssClass="ntp_button" Text="Ghi lại" />&nbsp;
                                                <asp:Button
                                                    ID="Button2" runat="server" CausesValidation="false" CssClass="ntp_button" Text="Thoát"
                                                    Width="54px" Visible="False" />&nbsp;
                                                <asp:Button ID="cmdDelete" runat="server" CausesValidation="false" CssClass="ntp_button"
                                                    Text="Xóa" Width="65px" Visible="False" /><asp:TextBox ID="txtPhieu_Xuat_Chi_Tiet_Id" runat="server" Columns="0" CssClass="ntp_textbox"
                                                    MaxLength="0" Visible="False"></asp:TextBox>
                                                <asp:TextBox ID="txtLO_SX" runat="server" Columns="50" CssClass="ntp_textbox" MaxLength="50"
                                                    Width="154px" Visible="False">0</asp:TextBox></td>
                                        </tr>
                                    </table>
                                    <asp:DataGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                                        AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                                        HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                                        ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                                        SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" Width="100%">
                                      
<Columns>
<asp:TemplateColumn><HeaderTemplate>
                                                    <asp:CheckBox ID="NTP_QLT_PHIEUNHAP_CHITIETToggleAll" runat="server" onclick="toggleAllCheckboxes(this);" />
                                                
</HeaderTemplate>
<ItemTemplate>
                                                    <asp:CheckBox ID="grdCmdSel" runat="server" />
                                                
</ItemTemplate>

<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="icon_cell"></ItemStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
                                                    <asp:ImageButton ID="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" />
                                                
</ItemTemplate>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_PHIEUXUAT_CHITIET" HeaderText="ID_PHIEUNHAP_CHITIET" Visible="False">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="ID_PHIEUXUAT" HeaderText="ID_PHIEUXUAT" Visible="False">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="ID_THUOC" HeaderText="ID_THUOC" Visible="False">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Thuoc" HeaderText="T&#234;n thuốc"></asp:BoundColumn>
<asp:BoundColumn DataField="LO_SX" HeaderText="L&#244; sản xuất">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="HAN_SUDUNG" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Hạn sử dụng">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NGAY_SX" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ng&#224;y sản xuất">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SO_LUONG" HeaderText="Số lượng">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
</Columns>
                                        <PagerStyle CssClass="ntp_grd_PagerStyle" HorizontalAlign="Center" Mode="NumericPages" />
                                        <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                                        <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                                        <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                                        <ItemStyle CssClass="ntp_grd_RowStyle" />
                                        <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                                    </asp:DataGrid></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
                                    <asp:Literal ID="TRANG_THAILabel" runat="server" Text="Trạng thái" Visible="False"></asp:Literal><asp:TextBox ID="txtTRANG_THAI" runat="server" Columns="0" CssClass="field_input"
                                        MaxLength="0" Visible="False"></asp:TextBox><asp:Literal ID="Literal1" runat="server" Text="Đơn vị xuất" Visible="False"></asp:Literal><asp:DropDownList ID="cboDONVI_NHAP" runat="server" CssClass="field_input" DataTextField="TEN_KHO"
                                        DataValueField="ID_KHO" Width="148px" Visible="False">
                                    </asp:DropDownList><asp:Literal ID="NAMLabel" runat="server" Text="Năm" Visible="False"></asp:Literal><asp:TextBox ID="txtNAM" runat="server" Columns="0" CssClass="field_input" MaxLength="0" Visible="False"></asp:TextBox><asp:Literal ID="ID_KY_KIEMKELabel" runat="server" Text="Kỳ kiểm kê" Visible="False"></asp:Literal><asp:TextBox ID="txtKY_KIEMKE" runat="server" Columns="0" CssClass="field_input"
                                        MaxLength="0" Visible="False"></asp:TextBox>
