<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_KIEM_KE_Edit.ascx.vb" Inherits="QLT_KIEM_KE_Edit" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<table border="0" cellpadding="0" cellspacing="0" class="dialog_view" style="width: 79%">
    <tr>
        <td style="width: 1192px; height: 415px" valign="top">
            <table id="CollapsibleRegion" border="0" cellpadding="0" cellspacing="0" style="display: block"
                width="100%">
                <tr>
                    <td class="dialog_body" style="height: 49px" width="15%">
                        <table border="0" cellpadding="0" cellspacing="3" width="100%">
                            <tr>
                                <td class="field_label_on_side" style="height: 19px" width="15%">
                                    <asp:Literal ID="NGAY_NHAPLabel" runat="server" Text="Ngày kiểm kê"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="height: 19px" width="40%">
                                    <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="2"></asp:TextBox><ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                                            runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                                            promptcharacter="_" targetcontrolid="txtTuNgay"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                                                id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                                                controltovalidate="txtTuNgay" emptyvaluemessage="Date is required" invalidvaluemessage="Định dạng ngày không đúng"
                                                isvalidempty="False" setfocusonerror="True" tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
                                <td class="dialog_field_value" style="height: 19px" width="15%">
                                    <asp:Literal ID="Literal2" runat="server" Text="Loại phiếu"></asp:Literal></td>
                                <td class="dialog_field_value" style="height: 19px" width="30%"><asp:DropDownList ID="cboLoaiPhieu" runat="server" CssClass="field_input" Width="155px">
                                    <asp:ListItem Value="0">Ghi nhận trạng th&#225;i</asp:ListItem>
                                    <asp:ListItem Value="1">Điều chỉnh tăng</asp:ListItem>
                                    <asp:ListItem Value="2">Điều chỉnh giảm</asp:ListItem>
                                </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side" style="height: 19px" width="15%">
                                    <asp:Literal ID="GHI_CHULabel" runat="server" Text="Ghi chú"></asp:Literal></td>
                                <td class="dialog_field_value" style="height: 19px" width="40%">
                                    <asp:TextBox ID="txtGHI_CHU" runat="server" Columns="100" CssClass="ntp_textbox"
                                        MaxLength="500" Width="325px"></asp:TextBox></td>
                                <td class="dialog_field_value" style="height: 19px" width="15%">
                                </td>
                                <td class="dialog_field_value" style="height: 19px" width="30%">
                                </td>
                            </tr>
                        </table>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="dialog_body" style="height: 8px">
                        <table id="Table1" border="0" cellpadding="0" cellspacing="0" style="display: block;
                            height: 224px" width="100%">
                            <tr>
                                <td class="dialog_body" style="height: 61px" valign="top">
                                    <table border="0" cellpadding="0" cellspacing="3" width="100%">
                                        <tr>
                                            <td class="field_label_on_side" style="height: 24px;" width="15%">
                                                <asp:Literal ID="ID_THUOCLabel" runat="server" Text="Tên thuốc"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" style="height: 24px;" valign="top" width="40%">
                                                <asp:DropDownList ID="cboThuoc" runat="server" CssClass="field_input" DataTextField="TEN_THUOC"
                                                    DataValueField="ID_THUOC" Width="155px">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="ID_THUOCRequiredFieldValidator" runat="server" ControlToValidate="cboThuoc"
                                                    Enabled="False" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>&nbsp;
                                            </td>
                                            <td class="dialog_field_value" style="height: 24px;" valign="top" width="15%">
                                                <asp:Literal ID="LO_SXLabel" runat="server" Text="Lô sản xuất"></asp:Literal></td>
                                            <td class="dialog_field_value" style="height: 24px;" valign="top" width="30%">
                                                <asp:TextBox ID="txtLO_SX" runat="server" Columns="50" CssClass="ntp_textbox" MaxLength="50"
                                                    Width="154px"></asp:TextBox><asp:RequiredFieldValidator ID="LO_SXRequiredFieldValidator"
                                                        runat="server" ControlToValidate="txtLO_SX" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" style="height: 19px" width="15%">
                                                <asp:Literal ID="HAN_SUDUNGLabel" runat="server" Text="Hạn dùng"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" style="height: 19px" width="40%">
                                                <asp:TextBox ID="dtmHan_SuDung" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                                    TabIndex="2"></asp:TextBox><ajaxtoolkit:maskededitextender id="Maskededitextender3"
                                                        runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                                                        promptcharacter="_" targetcontrolid="dtmHan_SuDung"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                                                            id="Maskededitvalidator3" runat="server" controlextender="MaskedEditExtender1"
                                                            controltovalidate="dtmHan_SuDung" emptyvaluemessage="Date is required"
                                                            invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                                                            tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
                                            <td class="dialog_field_value" style="height: 19px" width="15%">
                                                <asp:Literal ID="NGAY_SXLabel" runat="server" Text="Ngày sản xuất"></asp:Literal></td>
                                            <td class="dialog_field_value" style="height: 19px" width="30%">
                                                <asp:TextBox ID="dtmNgay_SX" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                                    TabIndex="2"></asp:TextBox><ajaxtoolkit:maskededitextender id="Maskededitextender4"
                                                        runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                                                        promptcharacter="_" targetcontrolid="dtmNgay_SX"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                                                            id="Maskededitvalidator4" runat="server" controlextender="MaskedEditExtender1"
                                                            controltovalidate="dtmNgay_SX" emptyvaluemessage="Date is required"
                                                            invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                                                            tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" style="height: 24px" width="15%">
                                                <asp:Literal ID="SO_LUONGLabel" runat="server" Text="Số lượng"></asp:Literal>
                                            </td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="40%">
                                                <asp:TextBox ID="txtSO_LUONG" runat="server" Columns="0" CssClass="ntp_textbox" MaxLength="0"></asp:TextBox>&nbsp;
                                                <asp:RequiredFieldValidator ID="SO_LUONGRequiredFieldValidator" runat="server" ControlToValidate="txtSO_LUONG" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>&nbsp;
                                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSO_LUONG"
                                                    ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                                                    Type="Double"></asp:RangeValidator></td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="15%">
                                                <asp:Literal ID="Literal1" runat="server" Text="Trạng thái"></asp:Literal></td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="30%"><asp:DropDownList ID="cboTrangThai" runat="server" CssClass="field_input" DataTextField="MO_TA"
                                                    DataValueField="ID_TRANGTHAI" Width="155px">
                                            </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td class="field_label_on_side" style="height: 24px" width="15%">
                                            </td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="40%">
                                                <asp:Button ID="cmdOK" runat="server" CssClass="ntp_button" Text="Ghi lại" /><asp:Button
                                                    ID="Button2" runat="server" CausesValidation="false" CssClass="ntp_button" Text="Thoát"
                                                    Width="55px" /><asp:Button ID="cmdDelete" runat="server" CausesValidation="false" CssClass="ntp_button"
                                                    Text="Xóa" Width="65px" /></td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="15%">
                                                <asp:TextBox ID="txtKiem_Ke_Chi_Tiet_Id" runat="server" Columns="0" CssClass="ntp_textbox"
                                                    MaxLength="0" Visible="False" Width="125px"></asp:TextBox></td>
                                            <td class="dialog_field_value" style="height: 24px" valign="top" width="30%">
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:DataGrid ID="grdDS" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                        CssClass="ntp_grd_GridViewStyle" Height="1px" PageSize="5" Width="100%">
                                        <PagerStyle HorizontalAlign="Center" Mode="NumericPages" />
                                        <AlternatingItemStyle CssClass="table_cell" />
                                        <Columns>
                                            <asp:TemplateColumn>
                                                <HeaderTemplate>
                                                    <asp:CheckBox ID="NTP_QLT_PHIEUNHAP_CHITIETToggleAll" runat="server" onclick="toggleAllCheckboxes(this);" />
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="grdCmdSel" runat="server" />
                                                </ItemTemplate>
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="icon_cell" />
                                            </asp:TemplateColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="Ten_Thuoc" HeaderText="T&#234;n thuốc"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ID_KIEMKE_CHITIET" HeaderText="ID_KIEMKE_CHITIET"
                                                Visible="False">
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="table_cell" />
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ID_KIEMKE" HeaderText="ID_KIEMKE" Visible="False">
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="table_cell" />
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ID_THUOC" HeaderText="ID_THUOC" Visible="False">
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="table_cell" />
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="LO_SX" HeaderText="L&#244; sản xuất">
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="table_cell" />
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="HAN_SUDUNG" HeaderText="Hạn sử dụng">
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="table_cell" />
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="NGAY_SX" HeaderText="Ng&#224;y sản xuất">
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="table_cell" />
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="SO_LUONG" HeaderText="Số lượng">
                                                <HeaderStyle CssClass="header_cell" />
                                                <ItemStyle CssClass="table_cell" />
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="TRANG_THAI" HeaderText="Trạng th&#225;i"></asp:BoundColumn>
                                        </Columns>
                                        <HeaderStyle CssClass="column_header" />
                                    </asp:DataGrid></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
                        <asp:TextBox ID="txtID_PHIEUNHAP" runat="server" Columns="0" CssClass="field_input"
                            MaxLength="0" Visible="False" Width="59px"></asp:TextBox><asp:Button ID="cmdSave" runat="server" Text="Ghi lại" Width="87px" Visible="False" CssClass="ntp_button" /><asp:Button
                            ID="cmdCancel" runat="server" Text="Thoát" Width="87px" Visible="False" CssClass="ntp_button" /><asp:Button ID="Button1"
                                runat="server" Text="Chi tiết phiếu" Visible="False" Width="87px" CssClass="ntp_button" />
