<%@ Control Language="VB" AutoEventWireup="false" CodeFile="THUOC_TONGHOP_NHAPXUAT.ascx.vb" Inherits="THUOC_TONGHOP_NHAPXUAT" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<table class="ntp_table_main" width="100%">
    <tr>
        <td width="15%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
        <td width="85%">
            <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="4" TabIndex="2"
                Width="100px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNam"
                ErrorMessage="Bạn phải nhập số" MaximumValue="9999" MinimumValue="0" SetFocusOnError="True"
                Type="Integer"></asp:RangeValidator>
            <asp:Button ID="cmdSearch" runat="server" CssClass="ntp_button" Text="Tìm kiếm"
                Width="121px" /></td>
    </tr>
    <tr>
        <td style="height: 24px" width="15%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tháng"></asp:Label></td>
        <td style="height: 24px" width="85%">
            <asp:DropDownList ID="cboThang" runat="server" CssClass="ntp_combobox" TabIndex="2"
                Width="150px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="height: 24px" width="15%">
        </td>
        <td style="height: 24px" width="85%">
            <asp:Button ID="cmdTongHop" runat="server" CssClass="ntp_button" Text="Tổng hợp số liệu"
                Width="121px" />&nbsp;
            <asp:Button ID="cmdKhoaSoLieu" runat="server" CssClass="ntp_button" Text="Khóa sổ dữ liệu"
                Width="121px" /></td>
    </tr>
    <tr>
        <td colspan="2" style="height: 24px" width="15%">
            <cc3:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle" ItemStyle-CssClass="ntp_grd_RowStyle"
                PagerStyle-CssClass="ntp_grd_PagerStyle" SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                ShowFooter="True" Width="100%">
                <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
                <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                <ItemStyle CssClass="ntp_grd_RowStyle" />
                <Columns>
                    <asp:TemplateColumn>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn Visible="False">
                        <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w6" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_BAOCAO_NX" HeaderText="ID_BAOCAO_NX" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TRANG_THAI" HeaderText="TRANG_THAI" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="THANG" HeaderText="Th&#225;ng">
                        <headerstyle width="16%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="NAM" HeaderText="Năm"></asp:BoundColumn>
                    <asp:BoundColumn DataField="NGAY_TAO" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ng&#224;y tổng hợp">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_NGUOI_TAO" HeaderText="Người tổng hợp">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="NGAY_KHOASO" HeaderText="Ng&#224;y kh&#243;a sổ">
                        <headerstyle width="20%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_NGUOI_KHOASO" HeaderText="Người kh&#243;a sổ">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:TemplateColumn></asp:TemplateColumn>
                </Columns>
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
            </cc3:MultiSelectGrid></td>
    </tr>
</table>
