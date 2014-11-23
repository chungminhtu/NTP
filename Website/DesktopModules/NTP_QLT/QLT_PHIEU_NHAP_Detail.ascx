<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_PHIEU_NHAP_Detail.ascx.vb" Inherits="QLT_PHIEU_NHAP_Detail" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<table border="0" cellpadding="0" cellspacing="0" class="dialog_view" style="height: 203px"
    width="100%">
    <tr>
        <td style="height: 216px">
            <table id="CollapsibleRegion" border="0" cellpadding="0" cellspacing="0" style="display: block"
                width="100%">
                <tr>
                    <td class="dialog_body" style="height: 197px">
                        <table border="0" cellpadding="0" cellspacing="3">
                            <tr>
                                <td class="field_label_on_side">
                                    <asp:Literal ID="ID_PHIEUNHAP_CHITIETLabel" runat="server" Text="ID_PHIEUNHAP_CHITIET"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 461px">
                                    <asp:TextBox ID="ID_PHIEUNHAP_CHITIET" runat="server" Columns="0" CssClass="field_input"
                                        MaxLength="0"></asp:TextBox>
                                    &nbsp;&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side">
                                    <asp:Literal ID="ID_PHIEUNHAPLabel" runat="server" Text="ID_PHIEUNHAP"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 461px">
                                    <asp:DropDownList ID="ID_PHIEUNHAP" runat="server" CssClass="field_input" DataTextField="ID_PHIEUNHAP"
                                        DataValueField="ID_PHIEUNHAP" Width="156px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side">
                                    <asp:Literal ID="ID_THUOCLabel" runat="server" Text="Tên thuốc"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 461px">
                                    <asp:DropDownList ID="cboThuoc" runat="server" CssClass="field_input" DataTextField="TEN_THUOC"
                                        DataValueField="ID_THUOC" Width="155px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="ID_THUOCRequiredFieldValidator" runat="server" ControlToValidate="cboThuoc"
                                        Enabled="True" ErrorMessage="Phải nhập ID_THUOC"></asp:RequiredFieldValidator>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side">
                                    <asp:Literal ID="LO_SXLabel" runat="server" Text="Lô sản xuất"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 461px">
                                    <asp:TextBox ID="txtLO_SX" runat="server" Columns="50" CssClass="field_input" MaxLength="50"></asp:TextBox>&nbsp;
                                    <asp:RequiredFieldValidator ID="LO_SXRequiredFieldValidator" runat="server" ControlToValidate="txtLO_SX"
                                        Enabled="True" ErrorMessage="Phải nhập LO_SX"></asp:RequiredFieldValidator>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side">
                                    <asp:Literal ID="HAN_SUDUNGLabel" runat="server" Text="Hạn sử dụng"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 461px">
                                    <cc1:datetimeeditcontrol id="dtmHan_SUDUNG" runat="server" width="151px"></cc1:datetimeeditcontrol>
                                    <asp:RequiredFieldValidator ID="HAN_SUDUNGRequiredFieldValidator" runat="server"
                                        ControlToValidate="dtmHan_SUDUNG" Enabled="True" ErrorMessage="Phải nhập HAN_SUDUNG"></asp:RequiredFieldValidator>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side">
                                    <asp:Literal ID="NGAY_SXLabel" runat="server" Text="Ngày sản xuất"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 461px">
                                    <cc1:datetimeeditcontrol id="dtmNgay_SX" runat="server" width="151px"></cc1:datetimeeditcontrol>
                                </td>
                            </tr>
                            <tr>
                                <td class="field_label_on_side">
                                    <asp:Literal ID="SO_LUONGLabel" runat="server" Text="Số lượng"></asp:Literal>
                                </td>
                                <td class="dialog_field_value" style="width: 461px">
                                    <asp:TextBox ID="txtSO_LUONG" runat="server" Columns="0" CssClass="field_input" MaxLength="0"></asp:TextBox>&nbsp;
                                    <asp:RequiredFieldValidator ID="SO_LUONGRequiredFieldValidator" runat="server" ControlToValidate="txtSO_LUONG"
                                        Enabled="True" ErrorMessage="Phải nhập SO_LUONG"></asp:RequiredFieldValidator>&nbsp;
                                </td>
                            </tr>
                        </table>
                        <asp:Button ID="cmdOK" runat="server" CssClass="button" Text="Ghi lại" /><asp:Button
                            ID="cmdCancel" runat="server" CausesValidation="false" CssClass="button" Text="Thoát"
                            Width="58px" /></td>
                </tr>
            </table>
            <asp:DataGrid ID="grdDS" runat="server" AllowPaging="true" AutoGenerateColumns="False"
                CssClass="table_cell" Height="1px" Width="100%">
                <PagerStyle HorizontalAlign="Center" Mode="NumericPages" />
                <AlternatingItemStyle CssClass="table_cell" />
                <Columns>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:ImageButton ID="grdCmdEdit" runat="server" CommandName="EditCommand" CssClass="button_link"
                                ImageUrl="../../Images/icon_edit.gif" ToolTip="Sửa NTP_QLT_PHIEUNHAP_CHITIET" />
                        </ItemTemplate>
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="icon_cell" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:ImageButton ID="grdCmdView" runat="server" CommandName="ViewCommand" CssClass="button_link"
                                ImageUrl="../../Images/icon_view.gif" ToolTip="Xem NTP_QLT_PHIEUNHAP_CHITIET" />
                        </ItemTemplate>
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="icon_cell" />
                    </asp:TemplateColumn>
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
                    <asp:BoundColumn DataField="ID_PHIEUNHAP_CHITIET" HeaderText="ID_PHIEUNHAP_CHITIET"
                        Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_PHIEUNHAP_CHITIET" HeaderText="ID_PHIEUNHAP_CHITIET">
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="table_cell" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_PHIEUNHAP" HeaderText="ID_PHIEUNHAP">
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="table_cell" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_THUOC" HeaderText="ID_THUOC">
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="table_cell" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="LO_SX" HeaderText="LO_SX">
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="table_cell" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="HAN_SUDUNG" HeaderText="HAN_SUDUNG">
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="table_cell" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="NGAY_SX" HeaderText="NGAY_SX">
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="table_cell" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="SO_LUONG" HeaderText="SO_LUONG">
                        <HeaderStyle CssClass="header_cell" />
                        <ItemStyle CssClass="table_cell" />
                    </asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="column_header" />
            </asp:DataGrid></td>
    </tr>
</table>
