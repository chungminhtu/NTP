<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_PHIEU_NHAP_Edit.ascx.vb" Inherits="QLT_PHIEU_NHAP_Edit" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<table border="0" cellpadding="0" cellspacing="0" class="dialog_view" width="100%">
    <tr>
        <td style="width: 100%;" valign="top">
            <table id="CollapsibleRegion" border="0" cellpadding="0" cellspacing="0" style="display: block"
                width="100%">
                <tr>
                    <td class="dialog_body" style="height: 148px" width="100%">
                        <table border="0" cellpadding="0" cellspacing="3" width="100%">
                            <tr>
                                <td class="field_label_on_side" width="15%">
                                    <asp:Literal ID="MA_PHIEU_NHAPLabel" runat="server" Text="Mã phiếu nhập"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 35%">
                                    <asp:TextBox ID="txtMA_PHIEU_NHAP" runat="server" Columns="20" CssClass="field_input"
                                        MaxLength="20"></asp:TextBox>&nbsp;
                                    <asp:RequiredFieldValidator ID="MA_PHIEU_NHAPRequiredFieldValidator" runat="server"
                                        ControlToValidate="txtMA_PHIEU_NHAP" Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>&nbsp;
                                </td>
                                <td class="dialog_field_value" width="15%">
                                    <asp:Literal ID="ID_PHIEUXUATLabel" runat="server" Text="Phiếu xuất" Visible="False"></asp:Literal></td>
                                <td class="dialog_field_value" width="35%">
                                    <asp:TextBox ID="txtPhieu_Xuat" runat="server" Columns="0" CssClass="field_input"
                                        MaxLength="0" Visible="False"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side" style="height: 19px" width="15%">
                                    <asp:Literal ID="NGAY_NHAPLabel" runat="server" Text="Ngày nhập"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="height: 19px; width: 35%;">
             <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="2"></asp:TextBox><ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                     runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                     promptcharacter="_" targetcontrolid="txtTuNgay"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                         id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                         controltovalidate="txtTuNgay" emptyvaluemessage="Date is required" invalidvaluemessage="Định dạng ngày không đúng"
                         isvalidempty="False" setfocusonerror="True" tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator>
                                </td>
                                <td class="dialog_field_value" style="height: 19px" width="15%">
                                    <asp:Literal ID="NGUOI_NHAPLabel" runat="server" Text="Người nhập"></asp:Literal></td>
                                <td class="dialog_field_value" style="height: 19px" width="35%">
                                    <asp:TextBox ID="txtNGUOI_NHAP" runat="server" Columns="50" CssClass="ntp_textbox"
                                        MaxLength="50" Width="155px" TabIndex="3"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side" width="15%">
                                    <asp:Literal ID="ID_LYDO_NHAPXUATLabel" runat="server" Text="Lý do nhập"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 35%">
                                    <asp:DropDownList ID="cboLYDO_NHAPXUAT" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                                        DataValueField="ID" Width="150px" TabIndex="4">
                                        <asp:ListItem Value="8">Kho trung ương cấp</asp:ListItem>
                                        <asp:ListItem Value="10">Thừa</asp:ListItem>
                                        <asp:ListItem Value="11">Trả lại</asp:ListItem>
                                    </asp:DropDownList>&nbsp;
                                    <asp:RequiredFieldValidator ID="ID_LYDO_NHAPXUATRequiredFieldValidator" runat="server"
                                        ControlToValidate="cboLYDO_NHAPXUAT" Enabled="True" ErrorMessage="Phải nhập "></asp:RequiredFieldValidator>&nbsp;
                                </td>
                                <td class="dialog_field_value" width="15%">
                                    <asp:Literal ID="ID_NGUONKINHPHILabel" runat="server" Text="Nguồn kinh phí"></asp:Literal></td>
                                <td class="dialog_field_value" width="35%">
                                    <asp:DropDownList ID="cboNGUONKINHPHI" runat="server" CssClass="field_input" DataTextField="Mo_Ta"
                                        DataValueField="ID_NGUONKINHPHI" Width="155px" TabIndex="5">
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side" style="height: 24px" width="15%">
                                    <asp:Literal ID="GHI_CHULabel" runat="server" Text="Ghi chú"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" colspan="3">
                                    <asp:TextBox ID="txtGHI_CHU" runat="server" Columns="100" CssClass="ntp_textbox"
                                        MaxLength="500" Width="100%" TabIndex="6"></asp:TextBox></td>
                            </tr>
                        </table>
            <asp:Button ID="cmdSave" runat="server" Text="Ghi lại" Width="87px" CssClass="ntp_button" TabIndex="7" />&nbsp;
                        <asp:Button ID="cmdCancel" runat="server" Text="Thoát" Width="87px" CausesValidation="False" CssClass="ntp_button" TabIndex="8" />&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Chi tiết phiếu" Width="87px" Visible="False" CssClass="ntp_button" TabIndex="9" />
                                    <asp:TextBox ID="txtID_PHIEUNHAP" runat="server" Columns="0" CssClass="field_input"
                                        MaxLength="0" Visible="False" Width="59px"></asp:TextBox>
                                                <asp:TextBox ID="txtPhieu_Nhap_Chi_Tiet_Id" runat="server" Columns="0" CssClass="field_input" MaxLength="0"
                                                    Visible="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="dialog_body" style="height: 8px" width="100%">
                        <table id="Table1" border="0" cellpadding="0" cellspacing="0" style="display: block;
                            height: 224px" width="100%">
                            <tr>
                                <td class="dialog_body" style="height: 352px" valign="top" colspan="4">
                                    <table border="0" cellpadding="0" cellspacing="3">
                                        <tr>
                                            <td class="field_label_on_side" width="15%">
                                                <asp:Literal ID="ID_THUOCLabel" runat="server" Text="Tên thuốc"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" valign="top" width="35%">
                                                <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_THUOC"
                                                    DataValueField="ID_THUOC" Width="155px" TabIndex="10">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="ID_THUOCRequiredFieldValidator" runat="server" ControlToValidate="cboThuoc" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>&nbsp;
                                            </td>
                                            <td class="dialog_field_value" valign="top" width="15%">
                                                <asp:Literal ID="LO_SXLabel" runat="server" Text="Lô sản xuất"></asp:Literal></td>
                                            <td class="dialog_field_value" valign="top" width="35%">
                                                <asp:TextBox ID="txtLO_SX" runat="server" Columns="50" CssClass="ntp_textbox" MaxLength="50"
                                                    Width="154px" TabIndex="11">0</asp:TextBox><asp:RequiredFieldValidator ID="LO_SXRequiredFieldValidator"
                                                        runat="server" ControlToValidate="txtLO_SX" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" style="height: 19px;" width="15%">
                                                <asp:Literal ID="HAN_SUDUNGLabel" runat="server" Text="Hạn dùng"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" style="height: 19px" width="35%">
                                                <asp:TextBox ID="dtmHan_SuDung" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12"></asp:TextBox><ajaxtoolkit:maskededitextender
                                                    id="Maskededitextender3" runat="server" autocomplete="true" culturename="vi-VN"
                                                    mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="dtmHan_SuDung"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                                                        id="Maskededitvalidator3" runat="server" controlextender="MaskedEditExtender1"
                                                        controltovalidate="dtmHan_SuDung" emptyvaluemessage="Date is required" invalidvaluemessage="Định dạng ngày không đúng"
                                                        isvalidempty="False" setfocusonerror="True" tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
                                            <td class="dialog_field_value" style="height: 19px;" width="15%">
                                                <asp:Literal ID="NGAY_SXLabel" runat="server" Text="Ngày sản xuất"></asp:Literal></td>
                                            <td class="dialog_field_value" style="height: 19px" width="35%">
                                                <asp:TextBox ID="dtmNgay_SX" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="13"></asp:TextBox><ajaxtoolkit:maskededitextender
                                                    id="Maskededitextender4" runat="server" autocomplete="true" culturename="vi-VN"
                                                    mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="dtmNgay_SX"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                                                        id="Maskededitvalidator4" runat="server" controlextender="MaskedEditExtender1"
                                                        controltovalidate="dtmNgay_SX" emptyvaluemessage="Date is required" invalidvaluemessage="Định dạng ngày không đúng"
                                                        isvalidempty="False" setfocusonerror="True" tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" style="height: 24px;" width="15%">
                                                <asp:Literal ID="SO_LUONGLabel" runat="server" Text="Số lượng"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="35%">
                                                <asp:TextBox ID="txtSO_LUONG" runat="server" Columns="0" CssClass="ntp_textbox" MaxLength="0" TabIndex="14">0</asp:TextBox>&nbsp;
                                                <asp:RequiredFieldValidator ID="SO_LUONGRequiredFieldValidator" runat="server" ControlToValidate="txtSO_LUONG" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>&nbsp;
                                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSO_LUONG"
                                                    ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                                                    Type="Double"></asp:RangeValidator></td>
                                            <td class="dialog_field_value" style="height: 24px;" valign="top" width="15%">
                                                </td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="35%">
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" style="height: 24px" width="15%">
                                            </td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="35%">
                                                <asp:Button ID="cmdOK" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="59px" TabIndex="15" />&nbsp;
                                                <asp:Button
                                                    ID="cmdDelete" runat="server" CausesValidation="false" CssClass="ntp_button" Text="Xóa"
                                                    Width="65px" />&nbsp;
                                                <asp:Button
                                                    ID="Button2" runat="server" CausesValidation="false" CssClass="ntp_button" Text="Thoát"
                                                    Width="66px" /></td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="15%">
                                            </td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="35%">
                                            </td>
                                        </tr>
                                    </table>
                                     <asp:DataGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                                        AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                                        HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                                        ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                                        SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" Width="100%">
                                      
   <Columns>
                                            <asp:TemplateColumn>
                                                <HeaderTemplate>
                                                    <asp:CheckBox ID="NTP_QLT_PHIEUNHAP_CHITIETToggleAll" runat="server" onclick="toggleAllCheckboxes(this);" />
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="grdCmdSel" runat="server" />
                                                </ItemTemplate>
                                               
                                            </asp:TemplateColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="ID_PHIEUNHAP_CHITIET" HeaderText="ID_PHIEUNHAP_CHITIET"
                                                Visible="False">
                                               
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ID_PHIEUNHAP" HeaderText="ID_PHIEUNHAP" Visible="False">
                                               
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ID_THUOC" HeaderText="ID_THUOC" Visible="False">
                                              
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="Ten_Thuoc" HeaderText="T&#234;n thuốc"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="LO_SX" HeaderText="L&#244; sản xuất">
                                                
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="HAN_SUDUNG" HeaderText="Hạn sử dụng" DataFormatString="{0:dd/MM/yyyy}">
                                                
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="NGAY_SX" HeaderText="Ng&#224;y sản xuất" DataFormatString="{0:dd/MM/yyyy}">
                                                
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="SO_LUONG" HeaderText="Số lượng">
                                              
                                            </asp:BoundColumn>
                                        </Columns>
                                        <PagerStyle CssClass="ntp_grd_PagerStyle" HorizontalAlign="Center" Mode="NumericPages" />
                                        <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                                        <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                                        <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                                        <ItemStyle CssClass="ntp_grd_RowStyle" />
                                        <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                                    </asp:DataGrid>
                                   </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
                                    <asp:Literal ID="ID_KY_KIEMKELabel" runat="server" Text="Kỳ kiểm kê" Visible="False"></asp:Literal><asp:TextBox ID="txtKY_KIEMKE" runat="server" Columns="0" CssClass="field_input"
                                        MaxLength="0" Visible="False"></asp:TextBox><asp:Literal ID="TRANG_THAILabel" runat="server" Text="Trạng thái" Visible="False"></asp:Literal><asp:TextBox ID="txtTRANG_THAI" runat="server" Columns="0" CssClass="field_input"
                                        MaxLength="0" Visible="False"></asp:TextBox><asp:Literal ID="NAMLabel" runat="server" Text="Năm" Visible="False"></asp:Literal><asp:TextBox ID="txtNAM" runat="server" Columns="0" CssClass="field_input" MaxLength="0" Visible="False"></asp:TextBox><asp:Literal ID="Literal1" runat="server" Text="Đơn vị nhập" Visible="False"></asp:Literal><asp:DropDownList ID="cboDONVI_NHAP" runat="server" CssClass="field_input" DataTextField="TEN_KHO"
                                        DataValueField="ID_KHO" Width="148px" Visible="False">
                                    </asp:DropDownList>
