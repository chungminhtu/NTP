<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_CapNhatLoSX.ascx.vb" Inherits="QLT_CapNhatLoSX" %>
<table id="Table1" border="0" cellpadding="0" cellspacing="0" style="display: block;
    height: 224px" width="100%">
    <tr>
        <td class="dialog_body" colspan="" style="width: 100%; height: 61px" valign="top">
            <table id="Table2" border="0" cellpadding="0" cellspacing="3" width="100%">
                <tr>
                    <td class="field_label_on_side" style="height: 24px" width="25%">
                        &nbsp;<asp:Literal ID="ID_THUOCLabel" runat="server" Text="Tên thuốc"></asp:Literal></td>
                    <td class="dialog_field_value" style="height: 24px" valign="top" width="50%">
                        <asp:DropDownList ID="cboThuoc" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                            DataTextField="TEN_THUOC" DataValueField="ID_THUOC" TabIndex="11" Width="217px">
                        </asp:DropDownList></td>
                    <td class="dialog_field_value" style="width: 25%; height: 24px" valign="top">
                        &nbsp; &nbsp;&nbsp;
                        <asp:TextBox ID="txtLo_SXCu" runat="server" Columns="0" CssClass="ntp_textbox" MaxLength="0"
                            Visible="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="field_label_on_side" width="25%">
                        <asp:Literal ID="Literal1" runat="server" Text="Lô SX"></asp:Literal></td>
                    <td class="dialog_field_value" valign="top" width="50%">
                        <asp:TextBox ID="txtLoSX" runat="server" Columns="0" CssClass="ntp_textbox" MaxLength="0"
                            Width="216px"></asp:TextBox></td>
                    <td class="dialog_field_value" style="width: 25%" valign="top">
                        &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="field_label_on_side" width="25%">
                    </td>
                    <td class="dialog_field_value" valign="top" width="50%">
                        <asp:Button ID="cmdOK" runat="server" CssClass="ntp_button" TabIndex="16" Text="Ghi lại"
                            Width="57px" />
                        &nbsp;
                        <asp:Button ID="Button2" runat="server" CausesValidation="False" CssClass="ntp_button"
                            TabIndex="17" Text="Thoát" Width="57px" /></td>
                    <td class="dialog_field_value" style="width: 25%" valign="top">
                    </td>
                </tr>
                <tr>
                    <td class="field_label_on_side" style="height: 180px" width="25%">
                    </td>
                    <td class="dialog_field_value" style="height: 180px" valign="top" width="50%">
                        <asp:DataGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                            AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                            HeaderStyle-CssClass="ntp_grd_HeaderStyle" Height="1px" HighlightCssClass="ntp_grd_SelectedRowStyle"
                            ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                            PageSize="5" SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" Width="100%">
                            <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                            <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                            <PagerStyle CssClass="ntp_grd_PagerStyle" HorizontalAlign="Center" Mode="NumericPages" />
                            <AlternatingItemStyle CssClass="table_cell" />
                            <ItemStyle CssClass="ntp_grd_RowStyle" />
                            <Columns>
                                <asp:TemplateColumn Visible="False">
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
                                <asp:BoundColumn DataField="LOSX" HeaderText="L&#244; sản xuất">
                                    <HeaderStyle CssClass="header_cell" />
                                    <ItemStyle CssClass="table_cell" />
                                </asp:BoundColumn>
                            </Columns>
                            <HeaderStyle CssClass="column_header" />
                        </asp:DataGrid></td>
                    <td class="dialog_field_value" style="width: 25%; height: 180px" valign="top">
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
