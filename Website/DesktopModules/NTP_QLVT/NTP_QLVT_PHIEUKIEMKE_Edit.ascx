<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_PHIEUKIEMKE_Edit.ascx.vb" Inherits="NTP_QLVT_PHIEUKIEMKE_Edit" %>
<%@ Register Assembly="MetaBuilders.WebControls.ConfirmedButtons" Namespace="MetaBuilders.WebControls"
    TagPrefix="mbcb" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Panel ID="pnlHeader" runat="server" Width="100%">
<fieldset class="ntp_fieldset">
<legend class="ntp_legend">Thông tin phiếu kiểm kê</legend>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label">Ngày kiểm kê (dd/mm/yyyy)</asp:Label>
            <asp:Label ID="Label14" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td style="width: 30%">
             <asp:TextBox ID="txtNgayKK" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="1"></asp:TextBox>
            <asp:TextBox ID="txtID_PHIEUKIEMKE" runat="server" CssClass="ntp_textbox"
                Width="64px" MaxLength="10" TabIndex="1" Visible="False"></asp:TextBox>
            <ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                     runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                     promptcharacter="_" targetcontrolid="txtNgayKK"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                         id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                         controltovalidate="txtNgayKK" emptyvaluemessage="Bạn phải nhập ngày" invalidvaluemessage="Định dạng ngày không đúng"
                         isvalidempty="False" setfocusonerror="True" tooltipmessage="Nhập ngày" Display="Dynamic" MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" MinimumValue="1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"></ajaxtoolkit:maskededitvalidator></td>
        <td  width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Nguồn kinh phí</asp:Label>
            <asp:Label ID="Label12" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
         <td width="30%">
            <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                DataValueField="ID_NGUONKINHPHI" Width="100%" TabIndex="2"></asp:DropDownList></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label8" runat="server" CssClass="ntp_label">Ghi chú</asp:Label></td>
        <td style="width: 30%" colspan="3">
            <asp:TextBox ID="txtGhiChu" runat="server" CssClass="ntp_textbox" MaxLength="250"
                TabIndex="3" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td width ="20%">
            </td>
        <td style="width: 30%" colspan="3">
            <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Ghi phiếu" Width="100px" TabIndex="4" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" TabIndex="5" />&nbsp;
            <asp:Button ID="cmdCreateNew" runat="server" CssClass="ntp_button" Text="Tạo phiếu mới" Width="100px" TabIndex="6" /></td>
    </tr>
</table>
</fieldset>

</asp:Panel>
<asp:Panel ID="pnlDetail" runat="server" Width="100%" DefaultButton="cmdSave">
<fieldset class="ntp_fieldset">
    <legend class="ntp_legend">
        Phiếu kiểm kê chi tiết
    </legend>
    <table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%" style="height: 26px">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Vật tư"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%" style="height: 26px"><asp:DropDownList ID="cboVATTU" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VATTU"
                DataValueField="ID_VATTU" Width="50%" TabIndex="7">
        </asp:DropDownList>
            <asp:TextBox ID="txtID_PHIEUKIEMKE_CHITIET" runat="server" CssClass="ntp_textbox" MaxLength="10"
                TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
    </tr>
        <tr>
            <td style="height: 26px" width="20%">
                <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Lô sản xuất"></asp:Label></td>
            <td colspan="2" style="height: 26px" width="80%">
                <asp:TextBox ID="txtLO_SANXUAT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8"
                    Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 26px" width="20%">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Trạng thái"></asp:Label>
                <asp:Label ID="Label6" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
            <td colspan="2" style="height: 26px" width="80%">
                <asp:DropDownList ID="cboTrangThai" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TRANGTHAI"
                DataValueField="ID_TRANGTHAI" Width="50%" TabIndex="9">
                </asp:DropDownList></td>
        </tr>
    <tr>
        <td width="20%" style="height: 26px">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Số lượng thực tế</asp:Label>
            <asp:Label ID="Label11" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td width="60%" style="height: 26px">
            <asp:TextBox ID="txtSoLuong" runat="server" CssClass="ntp_textbox" MaxLength="10" TabIndex="10"
                Width="100px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSoLuong"
                Display="Dynamic" ErrorMessage="Bạn phải nhập số lượng" ></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Bạn phải nhập số từ 0-9999999999"
                MaximumValue="9999999999" MinimumValue="0" Type="Double" ControlToValidate="txtSoLuong"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td width="20%" >
        </td>
        <td width="60%" >
        </td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" width="80%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="11" />&nbsp;
            <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa vật tư" Width="100px" CausesValidation="False" TabIndex="12" />
            <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server"
    TargetControlID="cmdDelete"
    ConfirmText="Bạn thực sự muốn xóa vật tư này trên phiếu?"
     />
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
<asp:ImageButton id="cmdEdit" runat="server" CausesValidation="False" ImageUrl="~/images/edit.gif" CommandName="edit" __designer:wfdid="w2"></asp:ImageButton> 
</itemtemplate>
            <headerstyle width="2%" />
        </asp:TemplateColumn>
        <asp:BoundColumn DataField="ID_KIEMKE_CHITIET" HeaderText="ID_CHITIET" Visible="False">
        </asp:BoundColumn>
        <asp:BoundColumn DataField="ID_VATTU" HeaderText="ID_VATTU" Visible="False"></asp:BoundColumn>
        <asp:BoundColumn DataField="TEN_VATTU" HeaderText="T&#234;n Vật tư">
            <headerstyle width="30%" />
        </asp:BoundColumn>
        <asp:BoundColumn DataField="TEN_DVT" HeaderText="Đơn vị t&#237;nh">
            <headerstyle width="10%" />
        </asp:BoundColumn>
        <asp:BoundColumn DataField="SO_LUONG" HeaderText="Số lượng thực tế">
            <headerstyle width="20%" />
        </asp:BoundColumn>
        <asp:BoundColumn DataField="LO_SANXUAT" HeaderText="L&#244; sản xuất">
            <headerstyle width="16%" />
        </asp:BoundColumn>
        <asp:BoundColumn DataField="TEN_TRANGTHAI" HeaderText="Chất lượng">
            <headerstyle width="10%" />
        </asp:BoundColumn>
    </Columns>
    <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
</cc4:MultiSelectGrid>
        </td>
    </tr>
</table>
</fieldset>

</asp:Panel>


