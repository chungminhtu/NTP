<%@ Control Language="VB" AutoEventWireup="false" CodeFile="VT_IMPORT_Edit.ascx.vb" Inherits="VT_IMPORT_Edit" %>
<%@ Register Assembly="MetaBuilders.WebControls.ConfirmedButtons" Namespace="MetaBuilders.WebControls"
    TagPrefix="mbcb" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc4" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<fieldset class="ntp_fieldset">
    <legend class="ntp_legend">
        Phiếu nhập chi tiết
    </legend>
    <table width="100%" class = "ntp_table_main">
        <tr>
            <td  width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Mã phiếu nhập"></asp:Label>
            <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
            <td  width="30%">
            <asp:TextBox ID="MA_PHIEU" runat="server" CssClass="ntp_textbox" Width="50%" TabIndex="1" MaxLength="50"></asp:TextBox>
            <asp:TextBox ID="ID_IMPORT" runat="server" CssClass="ntp_textbox"
                Width="64px" MaxLength="10" TabIndex="1" Visible="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="MA_PHIEU"
                Display="Dynamic" ErrorMessage="Bạn phải nhập mã phiếu"></asp:RequiredFieldValidator></td>
            <td width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label">Ngày nhập kho (dd/mm/yyyy)</asp:Label>
            <asp:Label ID="Label14" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
            <td width="30%">
             <asp:TextBox ID="NGAY_NHAP_KHO" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="2"></asp:TextBox><ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                     runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                     promptcharacter="_" targetcontrolid="NGAY_NHAP_KHO"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                         id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                         controltovalidate="NGAY_NHAP_KHO" emptyvaluemessage="Date is required" invalidvaluemessage="Định dạng ngày không đúng"
                         isvalidempty="False" setfocusonerror="True" tooltipmessage="Nhập ngày" MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" MinimumValue=" 1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)" Display="Dynamic"></ajaxtoolkit:maskededitvalidator></td>
        </tr>
        <tr>
            <td  width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Nguồn kinh phí</asp:Label>
                <asp:Label ID="Label12" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
            <td  width="30%">
            <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                DataValueField="ID_NGUONKINHPHI" Width="100%" TabIndex="3"></asp:DropDownList></td>
            <td width="20%">
            <asp:Label ID="Label15" runat="server" CssClass="ntp_label">Người viết phiếu</asp:Label></td>
            <td width="30%">
            <asp:TextBox ID="NGUOI_VIETPHIEU" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="5" Width="100%"></asp:TextBox></td>
        </tr>
        <tr>
            <td  width="20%">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Vật tư"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
            <td  width="30%">
                <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VATTU"
                DataValueField="ID_VATTU" Width="100%" TabIndex="10">
        </asp:DropDownList></td>
            <td width="20%">
                <asp:Label ID="Label6" runat="server" CssClass="ntp_label">Lý do nhập</asp:Label></td>
            <td width="30%">
                <asp:DropDownList ID="cboLYDO_NHAPXUAT" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                    DataValueField="ID" TabIndex="11" Width="100%">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td  width="20%">
            <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Số lượng</asp:Label>
            <asp:Label ID="Label11" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
            <td  width="30%">
                &nbsp;<asp:TextBox ID="SO_LUONG" runat="server" CssClass="ntp_textbox" MaxLength="10" TabIndex="18"
                Width="100px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Bạn phải nhập số từ 0-9999999999"
                MaximumValue="9999999999" MinimumValue="0" Type="Double" ControlToValidate="SO_LUONG" Display="Dynamic"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="SO_LUONG"
                Display="Dynamic" ErrorMessage="Bạn phải nhập số lượng" ></asp:RequiredFieldValidator></td>
            <td width="20%">
            </td>
            <td width="30%">
            </td>
        </tr>
    <tr>
        <td width="20%">
            &nbsp;</td>
        <td width="60%" colspan="3">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="20" />
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" />
  <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server"
    TargetControlID="cmdSave"
    ConfirmText="Bạn cần có chắc thông tin về trang thiết bị được nhập chính xác?"
     />
            </td>
    </tr>
</table>
</fieldset>



