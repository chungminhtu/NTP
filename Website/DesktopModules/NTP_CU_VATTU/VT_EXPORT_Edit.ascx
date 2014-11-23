<%@ Control Language="VB" AutoEventWireup="false" CodeFile="VT_EXPORT_Edit.ascx.vb" Inherits="VT_EXPORT_Edit" %>
<%@ Register Assembly="MetaBuilders.WebControls.ConfirmedButtons" Namespace="MetaBuilders.WebControls"
    TagPrefix="mbcb" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<script language= "javascript" >
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
    function EndRequestHandler(sender, args) {
        if (args.get_error() == undefined) {
            initform();
        }
 }
    function initform() {
//        alert('a');
	    $(document).ready(function(){

		    //alert('end request');
		    $("#<%=Me.cboLYDO_NHAPXUAT.ClientID%>").change(function() { 
		        ///alert($("#<%=Me.cboLYDO_NHAPXUAT.ClientID%>").val());
		        if ($("#<%=Me.cboLYDO_NHAPXUAT.ClientID%>").val()==7) {
		            //alert()
		            $("#<%=Me.cboDonVi.ClientID%>").removeAttr("disabled"); 
		        }
		        else
		        {
		            $("#<%=Me.cboDonVi.ClientID%>").attr("disabled", "disabled");
		        }
		    });
        });

    }
    initform();
</script>

<%--<script language= "javascript">
      $(document).ready(function(){
        alert('a');
      });
</script>--%>


    <fieldset class="ntp_fieldset">
        <legend class="ntp_legend">
        Phiếu xuất chi tiết </legend>
        <table class="ntp_table_main" width="100%">
            <tr>
                <td width="20%">
                    <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Mã phiếu xuất"></asp:Label>
                    <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="width: 30%">
                    <asp:TextBox ID="MA_PHIEU" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"
                        Width="50%"></asp:TextBox>
                    <asp:TextBox ID="ID_IMPORT" runat="server" CssClass="ntp_textbox" MaxLength="10"
                        TabIndex="1" Visible="False" Width="64px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="MA_PHIEU"
                        Display="Dynamic" ErrorMessage="Bạn phải nhập mã phiếu"></asp:RequiredFieldValidator></td>
                <td width="20%">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label">Ngày xuất kho (dd/mm/yyyy)</asp:Label>
                    <asp:Label ID="Label14" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td width="30%">
                    <asp:TextBox ID="NGAY_XUAT_KHO" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="2"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1"
                            runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                            PromptCharacter="_" TargetControlID="NGAY_XUAT_KHO">
                        </ajaxToolkit:MaskedEditExtender>
                    <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                        ControlToValidate="NGAY_XUAT_KHO" Display="Dynamic" EmptyValueMessage="Date is required"
                        InvalidValueMessage="Định dạng ngày không đúng" IsValidEmpty="False" MaximumValue="31/12/9999"
                        MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                        MinimumValue=" 1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                        SetFocusOnError="True" TooltipMessage="Nhập ngày"></ajaxToolkit:MaskedEditValidator></td>
            </tr>
            <tr>
                <td width="20%">
                    <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Nguồn kinh phí</asp:Label>
                    <asp:Label ID="Label12" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="width: 30%">
                    <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                        DataValueField="ID_NGUONKINHPHI" TabIndex="3" Width="100%">
                    </asp:DropDownList></td>
                <td width="20%">
                    <asp:Label ID="Label15" runat="server" CssClass="ntp_label">Người viết phiếu</asp:Label></td>
                <td width="30%">
                    <asp:TextBox ID="NGUOI_VIETPHIEU" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="4" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 24px" width="20%">
                    <asp:Label ID="Label8" runat="server" CssClass="ntp_label">Lý do xuất</asp:Label>
                    <asp:Label ID="Label16" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="height: 24px; width: 30%;">
                    <asp:DropDownList ID="cboLYDO_NHAPXUAT" runat="server" CssClass="ntp_combobox"
                        DataTextField="MO_TA" DataValueField="ID" TabIndex="5" Width="100%">
                    </asp:DropDownList></td>
                <td style="height: 24px" width="20%">
                </td>
                <td style="height: 24px" width="30%">
                </td>
            </tr>
            <tr>
                <td style="height: 21px" width="20%">
                    <asp:Label ID="Label18" runat="server" CssClass="ntp_label">Chọn đơn vị cấp dưới</asp:Label></td>
                <td colspan="3" style="height: 21px" width="30%">
                    <asp:DropDownList ID="cboDONVI" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                        DataValueField="ID_BENHVIEN" TabIndex="6" Width="100%">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td width="20%" style="height: 24px">
                    <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Vật tư"></asp:Label>
                    <asp:Label ID="Label10" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="width: 30%; height: 24px;">
                    <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VATTU"
                        DataValueField="ID_VATTU" TabIndex="10" Width="100%">
                    </asp:DropDownList></td>
                <td width="20%" style="height: 24px">
                </td>
                <td width="30%" style="height: 24px">
                </td>
            </tr>
            <tr>
                <td width="20%">
                    <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Số lượng</asp:Label>
                    <asp:Label ID="Label11" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
                <td style="width: 30%">
                    <asp:TextBox ID="SO_LUONG" runat="server" CssClass="ntp_textbox" MaxLength="10" TabIndex="18"
                        Width="100px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="SO_LUONG"
                        Display="Dynamic" ErrorMessage="Bạn phải nhập số lượng"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="SO_LUONG"
                        Display="Dynamic" ErrorMessage="Bạn phải nhập số từ 0-9999999999" MaximumValue="9999999999"
                        MinimumValue="0" Type="Double"></asp:RangeValidator></td>
                <td width="20%">
                    </td>
                <td width="30%">
                </td>
            </tr>
            <tr>
                <td width="20%">
                </td>
                <td colspan="3" width="60%">
                    <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" TabIndex="20" Text="Ghi lại"
                        Width="100px" />
                    <asp:Button ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                        Text="Thoát" Width="100px" />
                    <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn cần có chắc thông tin được nhập chính xác?"
                        TargetControlID="cmdSave">
                    </ajaxToolkit:ConfirmButtonExtender>
                </td>
            </tr>
        </table>
    </fieldset>



