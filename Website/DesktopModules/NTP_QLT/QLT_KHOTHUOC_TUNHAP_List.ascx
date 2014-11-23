<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_KHOTHUOC_TUNHAP_List.ascx.vb" Inherits="QLT_KHOTHUOC_TUNHAP_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc3" %>
<table class="ntp_table_main" style="width: 100%">
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Kỳ kiểm kê"></asp:Label></td>
        <td colspan="2" width="20%">
            <asp:DropDownList ID="cboKykiemKe" runat="server" CssClass="ntp_combobox" DataTextField="Ten_Ky_KiemKe"
                DataValueField="ID_Ky_KiemKe" Width="155px">
        </asp:DropDownList></td>
        <td colspan="1" width="20%">
            <asp:Button ID="cmdSearch" runat="server" CssClass="ntp_button" Text="Tìm kiếm" Width="100px" Visible="False" /></td>
        <td colspan="1" style="width: 20%">
        </td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tên thuốc"></asp:Label></td>
        <td colspan="2" width="20%">
            <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_THUOC"
                DataValueField="ID_THUOC" Width="155px">
            </asp:DropDownList></td>
        <td colspan="1" width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Lô SX"></asp:Label></td>
        <td colspan="1" style="width: 20%">
            <asp:TextBox ID="txtLoSX" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1" Width="137px"></asp:TextBox>&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLoSX"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="height: 21px" width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Tồn đầu kỳ"></asp:Label></td>
        <td colspan="2" style="height: 21px" width="20%">
            <asp:TextBox ID="txtTonDauKy" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="MA_PHIEU_NHAPRequiredFieldValidator" runat="server"
                ControlToValidate="txtTonDauKy" Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtTonDauKy"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
        <td colspan="1" style="height: 21px" width="20%">
            <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Tồn cuối kỳ"></asp:Label></td>
        <td colspan="1" style="height: 21px; width: 20%;">
            <asp:TextBox ID="txtTon_CuoiKy" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="1" Width="137px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTon_CuoiKy"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="txtTon_CuoiKy"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td style="height: 26px" width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Nhập trong kỳ"></asp:Label></td>
        <td colspan="2" style="height: 26px" width="20%">
            <asp:TextBox ID="txtNhapTrongKy" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNhapTrongKy"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtNhapTrongKy"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
        <td colspan="1" style="height: 26px" width="20%">
            <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Xuất trong kỳ"></asp:Label></td>
        <td colspan="1" style="height: 26px; width: 20%;">
            <asp:TextBox ID="txtXuatTrongKy" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="1" Width="137px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtXuatTrongKy"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="txtXuatTrongKy"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td style="height: 21px" width="20%">
            <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Thừa"></asp:Label></td>
        <td colspan="2" style="height: 21px" width="20%">
            <asp:TextBox ID="txtThua" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtThua"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtThua"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
        <td colspan="1" style="height: 21px" width="20%">
            <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Thiếu"></asp:Label></td>
        <td colspan="1" style="height: 21px; width: 20%;">
            <asp:TextBox ID="txtThieu" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1" Width="138px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtThieu"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="txtThieu"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td style="height: 21px" width="20%">
            <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Tốt"></asp:Label></td>
        <td colspan="2" style="height: 21px" width="20%">
            <asp:TextBox ID="txtTot" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTot"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtTot"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
        <td colspan="1" style="height: 21px" width="20%">
            <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Hỏng"></asp:Label></td>
        <td colspan="1" style="height: 21px; width: 20%;">
            <asp:TextBox ID="txtHong" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1" Width="136px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtHong"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator10" runat="server" ControlToValidate="txtHong"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td style="height: 21px" width="20%">
            <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Kém P/C"></asp:Label></td>
        <td colspan="2" style="height: 21px" width="20%">
            <asp:TextBox ID="txtKemPC" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtKemPC"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtKemPC"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
        <td colspan="1" style="height: 21px" width="20%">
            <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Mất P/C"></asp:Label></td>
        <td colspan="1" style="height: 21px; width: 20%;">
            <asp:TextBox ID="txtMatPC" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1" Width="140px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtMatPC"
                Enabled="True" ErrorMessage="Phải nhập"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="txtMatPC"
                ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td style="height: 26px" width="20%">
        </td>
        <td colspan="4" style="height: 26px">
            <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Thêm mới" Width="100px" /><asp:Button ID="cmdUpdate" runat="server" CssClass="ntp_button" Text="Sửa đổi" Width="100px" />
            <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" /><asp:TextBox ID="txtID_TuNhap" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="1" Visible="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="5" width="20%" style="width: 100%">
            &nbsp;
            <asp:DataGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" Width="100%">
                <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                <PagerStyle CssClass="ntp_grd_PagerStyle" HorizontalAlign="Center" Mode="NumericPages" />
                <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                <ItemStyle CssClass="ntp_grd_RowStyle" />
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
                   <asp:BoundColumn DataField="ID_THUOC" HeaderText="ID_THUOC" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_THUOC" HeaderText="T&#234;n thuốc"></asp:BoundColumn>
                    <asp:BoundColumn DataField="LO_SX" HeaderText="L&#244; sản xuất"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Ton_DauKy" HeaderText="Tồn đầu kỳ"></asp:BoundColumn>
                    <asp:BoundColumn DataField="NHAP" HeaderText="Nhập trong ky"></asp:BoundColumn>
                    <asp:BoundColumn DataField="XUAT" HeaderText="Xuất trong kỳ"></asp:BoundColumn>
                    <asp:BoundColumn DataField="THUA" HeaderText="Thừa"></asp:BoundColumn>
                    <asp:BoundColumn DataField="THIEU" HeaderText="Thiếu"></asp:BoundColumn>
                    <asp:BoundColumn DataField="HONG" HeaderText="Hỏng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TOT" HeaderText="Tốt"></asp:BoundColumn>
                    <asp:BoundColumn DataField="KEM_PC" HeaderText="K&#233;m P/C"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Mat_PC" HeaderText="Mất P/C"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_TUNHAP" HeaderText="ID_TUNHAP" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TON_CUOIKY" HeaderText="Tồn cuối kỳ"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_Ky_KiemKe" HeaderText="ID_KyKiemKe" Visible="False"></asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
            </asp:DataGrid></td>
    </tr>
</table>
