<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLTTB_PHIEUXUAT_Edit.ascx.vb" Inherits="NTP_QLTTB_PHIEUXUAT_Edit" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>


<asp:Panel ID="pnlHeader" runat="server" Width="100%">
<fieldset>
<legend>Thông tin phiếu xuất</legend>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Mã phiếu"></asp:Label>
            <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td style="width: 30%">
            <asp:TextBox ID="txtMA_PHIEU" runat="server" CssClass="ntp_textbox" Width="50%" TabIndex="1" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMA_PHIEU"
                Display="Dynamic" ErrorMessage="Bạn phải nhập mã phiếu"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtID_PHIEUXUAT" runat="server" CssClass="ntp_textbox"
                Width="64px" MaxLength="10" TabIndex="1" Visible="False"></asp:TextBox></td>
        <td  width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label">Ngày xuất (dd/mm/yyyy)</asp:Label></td>
         <td width="30%">
             <asp:TextBox ID="txtNgayXuat" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="2"></asp:TextBox><ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                     runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                     promptcharacter="_" targetcontrolid="txtNgayXuat"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                         id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                         controltovalidate="txtNgayXuat" emptyvaluemessage="Date is required" invalidvaluemessage="Định dạng ngày không đúng"
                         isvalidempty="False" setfocusonerror="True" tooltipmessage="Nhập ngày" Display="Dynamic"></ajaxtoolkit:maskededitvalidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label6" runat="server" CssClass="ntp_label">Lý do xuất</asp:Label></td>
        <td style="width: 30%">
        <asp:DropDownList ID="cboLYDO_XUAT" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                DataValueField="ID" Width="100%" TabIndex="4">
        </asp:DropDownList><br />
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="cboLYDO_XUAT"
                Display="Dynamic" ErrorMessage="Bạn phải chọn" MaximumValue="999999999" MinimumValue="0"
                Type="Integer"></asp:RangeValidator></td>
        <td width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label">Người xuất</asp:Label></td>
        <td width="30%">
            <asp:TextBox ID="txtNguoiXuat" runat="server" CssClass="ntp_textbox" TabIndex="3"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNguoiXuat"
                ErrorMessage="Bạn phải nhập tên" Display="Dynamic"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Nguồn kinh phí</asp:Label></td>
        <td style="width: 30%">
            <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                DataValueField="ID_NGUONKINHPHI" Width="100%" TabIndex="5"></asp:DropDownList><br />
            <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="cboNGUON_KINHPHI"
                Display="Dynamic" ErrorMessage="Bạn phải chọn" MaximumValue="99999999" MinimumValue="0"
                Type="Integer"></asp:RangeValidator></td>
        <td width ="20%">
            </td>
        <td width="30%"></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Kho nhập hàng</asp:Label></td>
        <td  colspan=3 style="width: 30%">
            &nbsp;<cc3:AutoSuggestBox ID="txtSearchKhoNhap" runat="server" DataPage="NTP_QLTTB_DM_KHO_Search.aspx"
                Width="100%" TabIndex="7"></cc3:AutoSuggestBox></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label8" runat="server" CssClass="ntp_label">Ghi chú</asp:Label></td>
        <td style="width: 30%" colspan="3">
            <asp:TextBox ID="txtGhiChu" runat="server" CssClass="ntp_textbox" MaxLength="250"
                TabIndex="8" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td width ="20%">
            </td>
        <td style="width: 30%" colspan="3">
            <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Ghi phiếu" Width="100px" TabIndex="9" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" TabIndex="10" />&nbsp;
            <asp:Button ID="cmdCreateNew" runat="server" CssClass="ntp_button" Text="Tạo phiếu mới" Width="100px" TabIndex="9" /></td>
    </tr>
</table>
</fieldset>

</asp:Panel>

<asp:Panel ID="pnlDetail" runat="server" Width="100%">
<fieldset>
    <legend>
        Phiếu xuất chi tiết
    </legend>
    <table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%" style="height: 26px">
            <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Thiết bị"></asp:Label>
            <asp:Label ID="Label11" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" style="height: 26px; width: 80%;"><asp:DropDownList ID="cboThietbi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_THIETBI"
                DataValueField="ID_THIETBI" Width="50%" TabIndex="11">
        </asp:DropDownList>
            <asp:TextBox ID="txtID_PHIEUXUAT_CHITIET" runat="server" CssClass="ntp_textbox" Visible="False"
                Width="64px"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%" style="height: 26px">
            <asp:Label ID="Label12" runat="server" CssClass="ntp_label">Số lượng</asp:Label>
            <asp:Label ID="Label13" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td width="60%" style="height: 26px">
            <asp:TextBox ID="txtSoLuong" runat="server" CssClass="ntp_textbox" MaxLength="10" TabIndex="12"
                Width="100px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMA_PHIEU"
                Display="Dynamic" ErrorMessage="Bạn phải nhập số lượng" ></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Bạn phải nhập số từ 0-9999999999"
                MaximumValue="9999999999" MinimumValue="0" Type="Double" ControlToValidate="txtSoLuong"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td width="20%" style="height: 21px" >
        </td>
        <td width="60%" style="height: 21px" >
        </td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" style="width: 80%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="13" />&nbsp;
            <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa thiết bị" Width="100px" CausesValidation="False" TabIndex="14" /><br />
            <ajaxToolkit:ConfirmButtonExtender ID="cbeDelete" runat="server" TargetControlID="cmdDelete" ConfirmText="Bạn thực sự muốn xóa thiết bị này trên phiếu?">
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
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
    
</itemtemplate>
            <headerstyle width="2%" />
        </asp:TemplateColumn>
        <asp:BoundColumn DataField="ID_PHIEUXUAT_CHITIET" HeaderText="ID_CHITIET" Visible="False">
        </asp:BoundColumn>
        <asp:BoundColumn DataField="ID_THIETBI" HeaderText="ID_THIETBI" Visible="False"></asp:BoundColumn>
        <asp:BoundColumn DataField="TEN_THIETBI" HeaderText="T&#234;n thiết bị">
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
