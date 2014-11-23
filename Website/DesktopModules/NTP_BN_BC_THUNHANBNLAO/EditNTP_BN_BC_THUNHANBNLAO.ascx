


<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO.EditNTP_BN_BC_THUNHANBNLAO" CodeFile="EditNTP_BN_BC_THUNHANBNLAO.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<script language= "javascript" >

Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
function EndRequestHandler(sender, args) {
    if (args.get_error() == undefined) {
        initform();
    }
}

function initform()
{

$(document).ready(function(){

    $('input[id=<%=txtMoi.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txtTaiPhat.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txtThatBai.ClientID %>]').bind('keyup',recalc_D1);    
    $('input[id=<%=txtDTLaiBoTri.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txtAFBDuongKhac.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txt04AFB.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txt415AFB.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txt15AFB.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txt04NP.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txt514NP.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txt15NP.ClientID %>]').bind('keyup',recalc_D1);
    $('input[id=<%=txtAFBAmLaoNgoaiPhoiKhac.ClientID %>]').bind('keyup',recalc_D1);
  
    $('input[id=<%=txtMoi1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txtTaiPhat1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txtThatBai1.ClientID %>]').bind('keyup',recalc_D2); 
    $('input[id=<%=txtDTLaiBoTri1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txtAFBDuongKhac1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txt04AFB1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txt415AFB1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txt15AFB1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txt04NP1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txt514NP1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txt15NP1.ClientID %>]').bind('keyup',recalc_D2);
    $('input[id=<%=txtAFBAmLaoNgoaiPhoiKhac1.ClientID %>]').bind('keyup',recalc_D2);
    
    $('input[id=<%=txtMoi2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txtTaiPhat2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txtThatBai2.ClientID %>]').bind('keyup',recalc_D3); 
    $('input[id=<%=txtDTLaiBoTri2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txtAFBDuongKhac2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txt04AFB2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txt415AFB2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txt15AFB2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txt04NP2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txt514NP2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txt15NP2.ClientID %>]').bind('keyup',recalc_D3);
    $('input[id=<%=txtAFBAmLaoNgoaiPhoiKhac2.ClientID %>]').bind('keyup',recalc_D3); 
    
    $('input[id=<%=txt04Nam.ClientID %>]').bind('keyup',recalcNam_D4);
    $('input[id=<%=txt5Nam.ClientID %>]').bind('keyup',recalcNam_D4);
    $('input[id=<%=txt15Nam.ClientID %>]').bind('keyup',recalcNam_D4);
    $('input[id=<%=txt25nam.ClientID %>]').bind('keyup',recalcNam_D4);
    $('input[id=<%=txt35Nam.ClientID %>]').bind('keyup',recalcNam_D4);
    $('input[id=<%=txt45Nam.ClientID %>]').bind('keyup',recalcNam_D4);
    $('input[id=<%=txt55Nam.ClientID %>]').bind('keyup',recalcNam_D4);
     $('input[id=<%=txt65Nam.ClientID %>]').bind('keyup',recalcNam_D4);
    
    $('input[id=<%=txt04Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    $('input[id=<%=txt5Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    $('input[id=<%=txt15Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    $('input[id=<%=txt25Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    $('input[id=<%=txt35Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    $('input[id=<%=txt45Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    $('input[id=<%=txt55Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    $('input[id=<%=txt65Nu.ClientID %>]').bind('keyup',recalcNu_D4);
    
    $('input[id=<%=txt04Nam1.ClientID %>]').bind('keyup',recalcNam_D5);
    $('input[id=<%=txt5Nam1.ClientID %>]').bind('keyup',recalcNam_D5);
    $('input[id=<%=txt15Nam1.ClientID %>]').bind('keyup',recalcNam_D5);
    $('input[id=<%=txt25nam1.ClientID %>]').bind('keyup',recalcNam_D5);
    $('input[id=<%=txt35Nam1.ClientID %>]').bind('keyup',recalcNam_D5);
    $('input[id=<%=txt45Nam1.ClientID %>]').bind('keyup',recalcNam_D5);
    $('input[id=<%=txt55Nam1.ClientID %>]').bind('keyup',recalcNam_D5);
     $('input[id=<%=txt65Nam1.ClientID %>]').bind('keyup',recalcNam_D5);
    
    $('input[id=<%=txt04Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    $('input[id=<%=txt5Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    $('input[id=<%=txt15Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    $('input[id=<%=txt25Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    $('input[id=<%=txt35Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    $('input[id=<%=txt45Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    $('input[id=<%=txt55Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    $('input[id=<%=txt65Nu1.ClientID %>]').bind('keyup',recalcNu_D5);
    
});

}
function recalc_D1()
{
$('input[id=<%=TxtTongBNThunhan.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + a + b + c  ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtMoi.ClientID %>]'),
				s2: $('input[id^=<%=txtTaiPhat.ClientID %>]'),
				s3: $('input[id^=<%=txtThatBai.ClientID %>]'),
				s4: $('input[id^=<%=txtDTLaiBoTri.ClientID %>]'),
				s5: $('input[id^=<%=txtAFBDuongKhac.ClientID %>]'),
				s6: $('input[id^=<%=txt04AFB.ClientID %>]'),
				s7: $('input[id^=<%=txt415AFB.ClientID %>]'),
				s8: $('input[id^=<%=txt15AFB.ClientID %>]'),
				s9: $('input[id^=<%=txt04NP.ClientID %>]'),
				a: $('input[id^=<%=txt514NP.ClientID %>]'),
				b: $('input[id^=<%=txt15NP.ClientID %>]'),
				c: $('input[id^=<%=txtAFBAmLaoNgoaiPhoiKhac.ClientID %>]')
			},
			// define the formatting callback, the results of the calculation are passed to this function
			function (s){
				// return the number as a dollar amount
				return s.toFixed(0);
			},
			// define the finish callback, this runs after the calculation has been complete
			function ($this){
				
				var sum = $this.sum();			
			}
		);
}
function recalc_D2(){
$('input[id=<%=TxtTongBNXNHIV.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + a + b + c  ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtMoi1.ClientID %>]'),
				s2: $('input[id^=<%=txtTaiPhat1.ClientID %>]'),
				s3: $('input[id^=<%=txtThatBai1.ClientID %>]'),
				s4: $('input[id^=<%=txtDTLaiBoTri1.ClientID %>]'),
				s5: $('input[id^=<%=txtAFBDuongKhac1.ClientID %>]'),
				s6: $('input[id^=<%=txt04AFB1.ClientID %>]'),
				s7: $('input[id^=<%=txt415AFB1.ClientID %>]'),
				s8: $('input[id^=<%=txt15AFB1.ClientID %>]'),
				s9: $('input[id^=<%=txt04NP1.ClientID %>]'),
				a: $('input[id^=<%=txt514NP1.ClientID %>]'),
				b: $('input[id^=<%=txt15NP1.ClientID %>]'),
				c: $('input[id^=<%=txtAFBAmLaoNgoaiPhoiKhac1.ClientID %>]')
			},
			// define the formatting callback, the results of the calculation are passed to this function
			function (s){
				// return the number as a dollar amount
				return s.toFixed(0);
			},
			// define the finish callback, this runs after the calculation has been complete
			function ($this){
				
				var sum = $this.sum();			
			}
		);
}
function recalc_D3(){
$('input[id=<%=TxtTongBNHIV.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + a + b + c  ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtMoi2.ClientID %>]'),
				s2: $('input[id^=<%=txtTaiPhat2.ClientID %>]'),
				s3: $('input[id^=<%=txtThatBai2.ClientID %>]'),
				s4: $('input[id^=<%=txtDTLaiBoTri2.ClientID %>]'),
				s5: $('input[id^=<%=txtAFBDuongKhac2.ClientID %>]'),
				s6: $('input[id^=<%=txt04AFB2.ClientID %>]'),
				s7: $('input[id^=<%=txt415AFB2.ClientID %>]'),
				s8: $('input[id^=<%=txt15AFB2.ClientID %>]'),
				s9: $('input[id^=<%=txt04NP2.ClientID %>]'),
				a: $('input[id^=<%=txt514NP2.ClientID %>]'),
				b: $('input[id^=<%=txt15NP2.ClientID %>]'),
				c: $('input[id^=<%=txtAFBAmLaoNgoaiPhoiKhac2.ClientID %>]')
			},
			// define the formatting callback, the results of the calculation are passed to this function
			function (s){
				// return the number as a dollar amount
				return s.toFixed(0);
			},
			// define the finish callback, this runs after the calculation has been complete
			function ($this){
				
				var sum = $this.sum();			
			}
		);
}

function recalcNam_D4(){
$('input[id=<%=TxtNamHIVA.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s3 + s4 + s5 + s6 + s7 + s8',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txt04Nam.ClientID %>]'),
				s2: $('input[id^=<%=txt5Nam.ClientID %>]'),
				s3: $('input[id^=<%=txt15Nam.ClientID %>]'),
				s4: $('input[id^=<%=txt25nam.ClientID %>]'),
				s5: $('input[id^=<%=txt35Nam.ClientID %>]'),
				s6: $('input[id^=<%=txt45Nam.ClientID %>]'),
				s7: $('input[id^=<%=txt55Nam.ClientID %>]'),
				s8: $('input[id^=<%=txt65Nam.ClientID %>]')
			},
			// define the formatting callback, the results of the calculation are passed to this function
			function (s){
				// return the number as a dollar amount
				return s.toFixed(0);
			},
			// define the finish callback, this runs after the calculation has been complete
			function ($this){
				
				var sum = $this.sum();			
			}
		);

}
function recalcNu_D4(){
 $('input[id=<%=TxtNuHIVA.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s3 + s4 + s5 + s6 + s7 + s8',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txt04Nu.ClientID %>]'),
				s2: $('input[id^=<%=txt5Nu.ClientID %>]'),
				s3: $('input[id^=<%=txt15Nu.ClientID %>]'),
				s4: $('input[id^=<%=txt25Nu.ClientID %>]'),
				s5: $('input[id^=<%=txt35Nu.ClientID %>]'),
				s6: $('input[id^=<%=txt45Nu.ClientID %>]'),
				s7: $('input[id^=<%=txt55Nu.ClientID %>]'),
				s8: $('input[id^=<%=txt65Nu.ClientID %>]')
			},
			// define the formatting callback, the results of the calculation are passed to this function
			function (s){
				// return the number as a dollar amount
				return s.toFixed(0);
			},
			// define the finish callback, this runs after the calculation has been complete
			function ($this){
				// sum the total of the $("[id^=total_item]") selector
				var sum = $this.sum();
			}
		);
}
function recalcNam_D5(){
 $('input[id=<%=TxtNamHIVD.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s3 + s4 + s5 + s6 + s7 + s8',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txt04Nam1.ClientID %>]'),
				s2: $('input[id^=<%=txt5Nam1.ClientID %>]'),
				s3: $('input[id^=<%=txt15Nam1.ClientID %>]'),
				s4: $('input[id^=<%=txt25nam1.ClientID %>]'),
				s5: $('input[id^=<%=txt35Nam1.ClientID %>]'),
				s6: $('input[id^=<%=txt45Nam1.ClientID %>]'),
				s7: $('input[id^=<%=txt55Nam1.ClientID %>]'),
				s8: $('input[id^=<%=txt65Nam1.ClientID %>]')
			},
			// define the formatting callback, the results of the calculation are passed to this function
			function (s){
				// return the number as a dollar amount
				return s.toFixed(0);
			},
			// define the finish callback, this runs after the calculation has been complete
			function ($this){
				// sum the total of the $("[id^=total_item]") selector
				var sum = $this.sum();
			}
		);
}
function recalcNu_D5(){
 $('input[id=<%=TxtNuHIVD.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s3 + s4 + s5 + s6 + s7 + s8',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txt04Nu1.ClientID %>]'),
				s2: $('input[id^=<%=txt5Nu1.ClientID %>]'),
				s3: $('input[id^=<%=txt15Nu1.ClientID %>]'),
				s4: $('input[id^=<%=txt25Nu1.ClientID %>]'),
				s5: $('input[id^=<%=txt35Nu1.ClientID %>]'),
				s6: $('input[id^=<%=txt45Nu1.ClientID %>]'),
				s7: $('input[id^=<%=txt55Nu1.ClientID %>]'),
				s8: $('input[id^=<%=txt65Nu1.ClientID %>]')
			},
			// define the formatting callback, the results of the calculation are passed to this function
			function (s){
				// return the number as a dollar amount
				return s.toFixed(0);
			},
			// define the finish callback, this runs after the calculation has been complete
			function ($this){
				// sum the total of the $("[id^=total_item]") selector
				var sum = $this.sum();
			}
		);
}
initform();
</script>
<table style="width: 71%">
    <tr>
        <td style="width: 7px; height: 26px">
            <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
        <td style="width: 346px; height: 26px">
            <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox"
                DataTextField="TEN_BENHVIEN" DataValueField="ID_BENHVIEN" TabIndex="1" Width="292px">
            </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                ControlToValidate="cboDonVi" ErrorMessage="Không được trống" Width="148px"></asp:RequiredFieldValidator></td>
        <td style="width: 13%; height: 26px">
        </td>
        <td colspan="1" style="width: 16%; height: 26px">
            &nbsp;
                     <asp:TextBox ID="txtId_BCThuNhan" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="111" Visible="False" Width="71px"></asp:TextBox></td>
        <td colspan="6" style="width: 15%; height: 26px">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 10%">
            <asp:Label ID="Label40" runat="server" CssClass="ntp_ label" Text="Quý" Width="80px"></asp:Label></td>
        <td style="width: 346px">
            <asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="2"
                Width="89px">
                <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 10%">
            <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Năm" Width="51px"></asp:Label></td>
        <td colspan="1" style="width: 20%">
            <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3"
                Width="113px"></asp:TextBox><asp:RangeValidator ID="RangeValidator22" runat="server"
                    ControlToValidate="txtNam" ErrorMessage="Không đúng năm" MaximumValue="3000"
                    MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
        <td colspan="6" style="width: 15%">
            &nbsp;<asp:RequiredFieldValidator
                        ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNam" ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 7px; height: 26px">
            <asp:Label ID="Label37" runat="server" CssClass="ntp_label" Text="Ngày báo cáo" Width="117px"></asp:Label></td>
        <td style="width: 346px; height: 26px">
            <asp:TextBox ID="txtNgayBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="4" Width="150px"></asp:TextBox><ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                    runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                    promptcharacter="_" targetcontrolid="txtNgayBaoCao"> </ajaxtoolkit:maskededitextender></td>
        <td style="width: 13%; height: 26px">
            <asp:Label ID="Label38" runat="server" CssClass="ntp_label" Text="Người báo cáo" Width="97px"></asp:Label></td>
        <td colspan="7" style="height: 26px">
            <asp:TextBox ID="txtNguoiBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="5" Width="260px"></asp:TextBox></td>
    </tr>
</table>
<table border="0" style="width: 789px">
    <tr>
        <td align="center" colspan="2" style="height: 28px">
        </td>
        <td align="center" style="height: 28px">
        </td>
        <td align="left" style="height: 28px">
        </td>
        <td align="left" style="width: 478px; height: 28px">
        </td>
        <td align="left" style="height: 28px">
            <asp:Button ID="CmdXem" runat="server" CssClass="ntp_button" TabIndex="5" Text="Xem"
                Width="81px" /></td>
    </tr>
</table>
&nbsp;<br />
&nbsp;
&nbsp; &nbsp;<asp:Label ID="Label15" runat="server" CssClass="ntp_label" Font-Bold="True"
    ForeColor="#C00000" Text="Phần 1: Toàn bộ bệnh nhân Lao và Lao/HIV đăng ký điều trị trong quý"
    Width="486px"></asp:Label><br />
<br />
 <asp:Panel ID="pnlBaoCao1" runat ="server" Width="35%"  >

  <fieldset class="ntp_fieldset" style="width: 100%">
      <table border="1" style="width: 101%">
          <tr>
              <td align="left" style="height: 21px; width: 49px;">
                  <asp:TextBox ID="txtId_LaoHIV1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="110" Width="36px" Visible="False"></asp:TextBox></td>
              <td align="center" colspan="5" style="height: 21px">
                  <asp:Label ID="Label10" runat="server" ForeColor="Brown" Height="17px" Text="Lao phổi AFB dương tính"
                      Width="211px" Font-Bold="True"></asp:Label></td>
              <td align="center" colspan="3" style="height: 21px">
                  <asp:Label ID="Label11" runat="server" ForeColor="#C00000" Height="22px" Text="Lao phổi AFB âm tính mới"
                      Width="129px" Font-Bold="True"></asp:Label></td>
              <td align="center" colspan="3" style="height: 21px">
                  <asp:Label ID="Label12" runat="server" ForeColor="#C00000" Height="20px" Text="Lao ngoài phổi mới"
                      Width="136px" Font-Bold="True"></asp:Label></td>
              <td align="center" rowspan="3" style="width: 5px">
                  <asp:Label ID="Label13" runat="server" ForeColor="Brown" Text="AFB(-)lao ngoài phổi khác"
                      Width="51px" Font-Bold="True"></asp:Label></td>
              <td align="center" rowspan="3" style="width: 1px">
                  <asp:Label ID="Label14" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="Tổng cộng" Width="42px"></asp:Label></td>
          </tr>
          <tr>
              <td style="height: 21px; width: 49px;">
                  <asp:TextBox ID="txtId_LaoHIV2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="110" Width="51px" Visible="False"></asp:TextBox></td>
              <td rowspan="2" style="width: 13px">
                  <asp:Label ID="Label16" runat="server" Text="Mới" Width="42px"></asp:Label></td>
              <td align="center" colspan="4" style="height: 21px">
                  <asp:Label ID="Label23" runat="server" Text="Điều trị lại" Width="214px"></asp:Label></td>
              <td rowspan="2" style="width: 8px">
                  <asp:Label ID="Label24" runat="server" Text="0-4 tuổi" Width="38px"></asp:Label></td>
              <td rowspan="2" style="width: 15px">
                  <asp:Label ID="Label25" runat="server" Text="5-14 tuổi" Width="40px"></asp:Label></td>
              <td rowspan="2" style="width: 18px">
                  <asp:Label ID="Label26" runat="server" Text=">=15 tuổi" Width="40px"></asp:Label></td>
              <td rowspan="2" style="width: 7px">
                  <asp:Label ID="Label27" runat="server" Text="0-4 tuổi" Width="38px"></asp:Label></td>
              <td rowspan="2" style="width: 4px">
                  <asp:Label ID="Label28" runat="server" Text="5-14 tuổi" Width="40px"></asp:Label></td>
              <td rowspan="2" style="width: 4px">
                  <asp:Label ID="Label29" runat="server" Text=">=15 tuổi" Width="40px"></asp:Label></td>
          </tr>
          <tr>
              <td style="height: 21px; width: 49px;">
                  <asp:TextBox ID="txtId_LaoHIV" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="110" Width="54px" Visible="False"></asp:TextBox></td>
              <td style="width: 62px; height: 21px">
                  <asp:Label ID="Label17" runat="server" Text="Tái phát" Width="50px"></asp:Label></td>
              <td style="width: 66px; height: 21px">
                  <asp:Label ID="Label18" runat="server" Text="Thất bại" Width="51px"></asp:Label></td>
              <td style="width: 3px; height: 21px">
                  <asp:Label ID="Label19" runat="server" Text="Điều trị lại sau bỏ trị" Width="51px"></asp:Label></td>
              <td style="width: 14px; height: 21px">
                  <asp:Label ID="Label20" runat="server" Text="AFB(+) khác" Width="48px"></asp:Label></td>
          </tr>
          <tr>
              <td style="width: 49px">
                  <asp:Label ID="Label21" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="BN Lao thu nhận"
                      Width="58px"></asp:Label></td>
              <td style="width: 13px">
                      <asp:TextBox ID="txtMoi"  runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6" Width="45px" BorderColor="White" BorderStyle="None"  ></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="txtMoi" 
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 62px">
                     <asp:TextBox ID="txtTaiPhat" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="7" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtTaiPhat"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 66px">
              <asp:TextBox ID="txtThatBai" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                     <asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="txtThatBai"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 3px">
                      <asp:TextBox ID="txtDTLaiBoTri" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="9" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator12" runat="server" ControlToValidate="txtDTLaiBoTri"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="37px"></asp:RangeValidator></td>
              <td style="width: 14px">
                      <asp:TextBox ID="txtAFBDuongKhac" runat="server" CssClass="ntp_textbox" MaxLength="50"
                          TabIndex="10" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtAFBDuongKhac"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="40px"></asp:RangeValidator></td>
              <td style="width: 8px">
                     <asp:TextBox ID="txt04AFB" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="txt04AFB"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="47px"></asp:RangeValidator></td>
              <td style="width: 15px">
                     <asp:TextBox ID="txt415AFB" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txt415AFB"
                           ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="48px"></asp:RangeValidator></td>
              <td style="width: 18px">
                  <asp:TextBox ID="txt15AFB" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="13" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="txt15AFB"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="41px"></asp:RangeValidator></td>
              <td style="width: 7px">
                     <asp:TextBox ID="txt04NP" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="14" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txt04NP"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="45px"></asp:RangeValidator></td>
              <td style="width: 4px">
                     <asp:TextBox ID="txt514NP" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="15" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="txt514NP"
                           ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="42px"></asp:RangeValidator></td>
              <td style="width: 4px">
                      <asp:TextBox ID="txt15NP" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="16" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator10" runat="server" ControlToValidate="txt15NP"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="47px"></asp:RangeValidator></td>
              <td style="width: 5px">
                      <asp:TextBox ID="txtAFBAmLaoNgoaiPhoiKhac" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="17" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator13" runat="server" ControlToValidate="txtAFBAmLaoNgoaiPhoiKhac"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="42px" ></asp:RangeValidator></td>
              <td style="width: 1px">
                  <asp:TextBox ID="TxtTongBNThunhan" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="111" Width="57px" Wrap="False" BorderColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></td>
          </tr>
          
          <tr>
              <td style="height: 33px; width: 49px;">
                  <asp:Label ID="Label42" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Overline="False" Font-Underline="False" ForeColor="Black"
                      Text="Có XN HIV" Width="56px"></asp:Label></td>
              <td style="height: 33px; width: 13px;">
                  <asp:TextBox ID="txtMoi1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="18"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator47" runat="server" ControlToValidate="txtMoi1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 62px; height: 33px">
                  <asp:TextBox ID="txtTaiPhat1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="19" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator48" runat="server" ControlToValidate="txtTaiPhat1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 66px; height: 33px">
                  <asp:TextBox ID="txtThatBai1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="20" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator49" runat="server" ControlToValidate="txtThatBai1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 3px; height: 33px">
                  <asp:TextBox ID="txtDTLaiBoTri1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="21"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator50" runat="server" ControlToValidate="txtDTLaiBoTri1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="46px"></asp:RangeValidator></td>
              <td style="width: 14px; height: 33px">
                  <asp:TextBox ID="txtAFBDuongKhac1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="22"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator51" runat="server" ControlToValidate="txtAFBDuongKhac1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="44px"></asp:RangeValidator></td>
              <td style="width: 8px; height: 33px">
                  <asp:TextBox ID="txt04AFB1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="23"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator52" runat="server" ControlToValidate="txt04AFB1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="38px"></asp:RangeValidator></td>
              <td style="width: 15px; height: 33px">
                  <asp:TextBox ID="txt415AFB1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="24"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator53" runat="server" ControlToValidate="txt04Nam"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="37px"></asp:RangeValidator></td>
              <td style="width: 18px; height: 33px">
                  <asp:TextBox ID="txt15AFB1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="25"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator54" runat="server" ControlToValidate="txt15AFB1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="43px"></asp:RangeValidator></td>
              <td style="width: 7px; height: 33px">
                  <asp:TextBox ID="txt04NP1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="26"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator55" runat="server" ControlToValidate="txt04NP1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="44px"></asp:RangeValidator></td>
              <td style="width: 4px; height: 33px">
                  <asp:TextBox ID="txt514NP1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="27" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator56" runat="server" ControlToValidate="txt514NP1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="48px"></asp:RangeValidator></td>
              <td style="width: 4px; height: 33px">
                  <asp:TextBox ID="txt15NP1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="28" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator57" runat="server" ControlToValidate="txt15NP1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="40px"></asp:RangeValidator></td>
              <td style="width: 5px; height: 33px">
                  <asp:TextBox ID="txtAFBAmLaoNgoaiPhoiKhac1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="29" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator58" runat="server" ControlToValidate="txtAFBAmLaoNgoaiPhoiKhac1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="48px"></asp:RangeValidator></td>
              <td style="width: 1px; height: 33px">
                  <asp:TextBox ID="TxtTongBNXNHIV" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="111" Width="58px" BorderColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="height: 35px; width: 49px;">
                  <asp:Label ID="Label22" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Overline="False" Font-Underline="False" ForeColor="Black"
                      Text="XN HIV(+)" Width="56px"></asp:Label></td>
              <td style="height: 35px; width: 13px;">
                  <asp:TextBox ID="txtMoi2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="30"
                      Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator46" runat="server" ControlToValidate="txtMoi2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 62px; height: 35px">
                  <asp:TextBox ID="txtTaiPhat2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="31" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator59" runat="server" ControlToValidate="txtTaiPhat2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 66px; height: 35px">
                  <asp:TextBox ID="txtThatBai2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="32" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator60" runat="server" ControlToValidate="txtThatBai2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 3px; height: 35px">
                  <asp:TextBox ID="txtDTLaiBoTri2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="33" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator61" runat="server" ControlToValidate="txtDTLaiBoTri2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="43px"></asp:RangeValidator></td>
              <td style="width: 14px; height: 35px">
                  <asp:TextBox ID="txtAFBDuongKhac2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="34" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator62" runat="server" ControlToValidate="txtAFBDuongKhac2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="43px"></asp:RangeValidator></td>
              <td style="width: 8px; height: 35px">
                  <asp:TextBox ID="txt04AFB2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="35" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator63" runat="server" ControlToValidate="txt04AFB2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="38px"></asp:RangeValidator></td>
              <td style="width: 15px; height: 35px">
                  <asp:TextBox ID="txt415AFB2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="36" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator64" runat="server" ControlToValidate="txt04Nam"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="39px"></asp:RangeValidator></td>
              <td style="width: 18px; height: 35px">
                  <asp:TextBox ID="txt15AFB2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="37" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator65" runat="server" ControlToValidate="txt15AFB2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 7px; height: 35px">
                  <asp:TextBox ID="txt04NP2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="38" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator66" runat="server" ControlToValidate="txt04NP2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="38px"></asp:RangeValidator></td>
              <td style="width: 4px; height: 35px">
                  <asp:TextBox ID="txt514NP2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="39" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator67" runat="server" ControlToValidate="txt514NP2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="42px"></asp:RangeValidator></td>
              <td style="width: 4px; height: 35px">
                  <asp:TextBox ID="txt15NP2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="40" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator68" runat="server" ControlToValidate="txt15NP2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="43px"></asp:RangeValidator></td>
              <td style="width: 5px; height: 35px">
                  <asp:TextBox ID="txtAFBAmLaoNgoaiPhoiKhac2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="41" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator69" runat="server" ControlToValidate="txtAFBAmLaoNgoaiPhoiKhac2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="43px"></asp:RangeValidator></td>
              <td style="width: 1px; height: 35px">
                  <asp:TextBox ID="TxtTongBNHIV" runat="server" CssClass="ntp_textbox" Enabled="False"
                      MaxLength="50" TabIndex="111" Width="57px" BorderColor="White" BorderStyle="None"></asp:TextBox></td>
          </tr>
      </table>
      <br />
      <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="#C00000"
          Text="Phần 2: Bệnh nhân lao phổi AFB dương tính mới theo tuổi, giới" Width="486px"></asp:Label><br />
      <br />
      <table border="1" style="width: 87%  ">
          <tr>
              <td rowspan="3" style="width: 28px" align="center">
                  <asp:Label ID="Label5" runat="server" Text="XN HIV" Width="53px"></asp:Label></td>
              <td align="center" colspan="16" rowspan="1">
                  &nbsp;<asp:TextBox ID="txtId_LaoPhoiAFB" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="110" Visible="False" Width="54px"></asp:TextBox>
                  <asp:Label ID="Label44" runat="server" Font-Bold="True" ForeColor="Brown" Height="17px"
                      Text="Nhóm tuổi" Width="353px"></asp:Label>
                          <asp:TextBox ID="txtId_LaoPhoiAFB1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="110" Width="61px" Visible="False"></asp:TextBox></td>
              <td align="center" colspan="2" rowspan="2">
                  <asp:Label ID="Label9" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="Tổng cộng" Width="62px"></asp:Label></td>
          </tr>
          <tr>
              <td align="center" colspan="2" rowspan="1">
                          <asp:Label ID="Label71" runat="server" Height="34px" Text="0 -4 " Width="52px"></asp:Label></td>
              <td align="center" colspan="2" rowspan="1">
                          <asp:Label ID="Label47" runat="server" Height="34px" Text="5-14 " Width="53px"></asp:Label></td>
              <td align="center" colspan="2" rowspan="1">
                          <asp:Label ID="Label48" runat="server" Height="34px" Text="15-24 " Width="58px"></asp:Label></td>
              <td rowspan="1" align="center" colspan="2">
                          <asp:Label ID="Label50" runat="server" Height="34px" Text="25-34" Width="61px"></asp:Label></td>
              <td style="height: 21px" align="center" colspan="2">
                          <asp:Label ID="Label49" runat="server" Height="34px" Text="35-44" Width="54px"></asp:Label></td>
              <td style="height: 21px" align="center" colspan="2">
                          <asp:Label ID="Label52" runat="server" Height="34px" Text="45-54 " Width="59px"></asp:Label></td>
              <td rowspan="1" align="center" colspan="2">
                          <asp:Label ID="Label54" runat="server" Height="34px" Text="55-64 " Width="57px"></asp:Label></td>
              <td rowspan="1" align="center" colspan="2">
                          <asp:Label ID="Label56" runat="server" Height="34px" Text=">=65" Width="53px"></asp:Label></td>
          </tr>
          <tr>
              <td align="center" style="width: 36px">
                  <asp:Label ID="Label51" runat="server" Height="18px" Text="Nam" Width="23px"></asp:Label></td>
              <td align="center" style="width: 36px">
                  <asp:Label ID="Label32" runat="server" Height="18px" Text="Nữ" Width="23px"></asp:Label></td>
              <td align="center" style="width: 36px">
                  <asp:Label ID="Label34" runat="server" Text="Nam" Width="23px"></asp:Label></td>
              <td align="center" style="width: 36px">
                  <asp:Label ID="Label57" runat="server" Text="Nữ" Width="23px"></asp:Label></td>
              <td align="center" style="width: 36px">
                  <asp:Label ID="Label46" runat="server" Text="Nam" Width="23px"></asp:Label></td>
              <td align="center" style="width: 36px">
                  <asp:Label ID="Label45" runat="server" Text="Nữ" Width="23px"></asp:Label></td>
              <td style="width: 36px" align="center">
                  &nbsp;<asp:Label ID="Label1" runat="server" Text="Nam" Width="23px"></asp:Label></td>
              <td style="width: 33px" align="center">
                  &nbsp;<asp:Label ID="Label2" runat="server" Text="Nữ" Width="23px"></asp:Label></td>
              <td style="width: 20px" align="center">
                  &nbsp;<asp:Label ID="Label6" runat="server" Text="Nam" Width="23px"></asp:Label></td>
              <td style="width: 3px" align="center">
                  <asp:Label ID="Label35" runat="server" Text="Nữ" Width="23px"></asp:Label></td>
              <td style="width: 14px" align="center">
                  <asp:Label ID="Label8" runat="server" Text="Nam" Width="23px"></asp:Label></td>
              <td style="width: 7px" align="center">
                  <asp:Label ID="Label39" runat="server" Text="Nữ" Width="23px"></asp:Label></td>
              <td style="width: 15px" align="center">
                  <asp:Label ID="Label31" runat="server" Text="Nam" Width="23px"></asp:Label></td>
              <td style="width: 18px" align="center">
                  <asp:Label ID="Label41" runat="server" Text="Nữ" Width="23px"></asp:Label></td>
              <td style="width: 7px" align="center">
                  <asp:Label ID="Label33" runat="server" Text="Nam" Width="23px"></asp:Label></td>
              <td style="width: 4px" align="center">
                  <asp:Label ID="Label43" runat="server" Text="Nữ" Width="23px"></asp:Label></td>
              <td align="center" style="width: 2px">
                  <asp:Label ID="Label53" runat="server" Text="Nam" Width="35px"></asp:Label></td>
              <td align="center" style="width: 2px">
                  <asp:Label ID="Label55" runat="server" Text="Nữ" Width="35px"></asp:Label></td>
          </tr>
          <tr>
              <td style="height: 36px; width: 28px;"><asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Underline="False"
                              Text="HIV(-) hoặc không rõ" Width="52px"></asp:Label></td>
              <td style="width: 36px">
                    <asp:TextBox ID="txt04Nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="42" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator71" runat="server" ControlToValidate="txt04Nam"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Height="1px" Width="34px"></asp:RangeValidator></td>
              <td style="width: 36px">
                    <asp:TextBox ID="txt04Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="43" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator27" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="36px"></asp:RangeValidator></td>
              <td style="width: 36px">
             <asp:TextBox ID="txt5Nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="44" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="37px"></asp:RangeValidator></td>
              <td style="width: 36px">
             <asp:TextBox ID="txt5Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="45" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator14" runat="server" ControlToValidate="txt04Nam"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="34px"></asp:RangeValidator></td>
              <td style="width: 36px">
                    <asp:TextBox ID="txt15Nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="46" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator15" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px">
                    <asp:TextBox ID="txt15Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="47" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator16" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px;">
             <asp:TextBox ID="txt25nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="48" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator17" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="34px"></asp:RangeValidator></td>
              <td style="width: 33px;">
             <asp:TextBox ID="txt25Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="49" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator18" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="36px"></asp:RangeValidator></td>
              <td style="width: 20px;">
                    <asp:TextBox ID="txt35Nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="50" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator19" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 3px;">
                    <asp:TextBox ID="txt35Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="51" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator20" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="34px"></asp:RangeValidator></td>
              <td style="width: 14px;">
             <asp:TextBox ID="txt45Nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="52" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator21" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 7px;">
             <asp:TextBox ID="txt45Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="53" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator23" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="34px"></asp:RangeValidator></td>
              <td style="width: 15px;">
                    <asp:TextBox ID="txt55Nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="54" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator24" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="36px"></asp:RangeValidator></td>
              <td style="width: 18px;">
                    <asp:TextBox ID="txt55Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="55" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator25" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 7px;">
             <asp:TextBox ID="txt65Nam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="56" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator26" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="37px"></asp:RangeValidator></td>
              <td style="width: 4px;">
             <asp:TextBox ID="txt65Nu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="57" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator29" runat="server" ControlToValidate="txt04Nam"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 2px">
                  <asp:TextBox ID="TxtNamHIVA" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="111" Width="40px" Wrap="False" BorderColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></td>
              <td style="width: 2px">
                  <asp:TextBox ID="TxtNuHIVA" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="111" Width="40px" Wrap="False" BorderColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="height: 36px; width: 28px;"><asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Underline="False"
                              Text="HIV (+)" Width="53px"></asp:Label></td>
              <td style="width: 36px">
                          <asp:TextBox ID="txt04Nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="58" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator30" runat="server" ControlToValidate="txt04Nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px">
                          <asp:TextBox ID="txt04Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="59" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator31" runat="server" ControlToValidate="txt04Nu1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px">
                          <asp:TextBox ID="txt5Nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="60" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator32" runat="server" ControlToValidate="txt5Nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px">
                  <asp:TextBox ID="txt5Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="61" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator33" runat="server" ControlToValidate="txt5Nu1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px">
                          <asp:TextBox ID="txt15Nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="62" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator34" runat="server" ControlToValidate="txt15Nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px">
                          <asp:TextBox ID="txt15Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="3" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator35" runat="server" ControlToValidate="txt15Nu1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 36px;">
                          <asp:TextBox ID="txt25nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="64" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator36" runat="server" ControlToValidate="txt25nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 33px;">
                          <asp:TextBox ID="txt25Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="65" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator37" runat="server" ControlToValidate="txt25Nu1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 20px;">
                          <asp:TextBox ID="txt35Nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="66" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator38" runat="server" ControlToValidate="txt35Nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 3px;">
                          <asp:TextBox ID="txt35Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="67" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator39" runat="server" ControlToValidate="txt35Nu1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 14px;">
                          <asp:TextBox ID="txt45Nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="68" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator40" runat="server" ControlToValidate="txt45Nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 7px;">
                          <asp:TextBox ID="txt45Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="69" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator41" runat="server" ControlToValidate="txt45Nu1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="37px"></asp:RangeValidator></td>
              <td style="width: 15px;">
                          <asp:TextBox ID="txt55Nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="70" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator42" runat="server" ControlToValidate="txt55Nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="38px"></asp:RangeValidator></td>
              <td style="width: 18px;">
                          <asp:TextBox ID="txt55Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="71" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator43" runat="server" ControlToValidate="txt55Nu1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 7px;">
                          <asp:TextBox ID="txt65Nam1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="72" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator44" runat="server" ControlToValidate="txt65Nam1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="34px"></asp:RangeValidator></td>
              <td style="width: 4px;">
                          <asp:TextBox ID="txt65Nu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                              TabIndex="73" Width="35px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator45" runat="server" ControlToValidate="txt65Nu1"
                              ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="35px"></asp:RangeValidator></td>
              <td style="width: 2px">
                  <asp:TextBox ID="TxtNamHIVD" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="111" Width="40px" Wrap="False" BorderColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></td>
              <td style="width: 2px">
                  <asp:TextBox ID="TxtNuHIVD" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="111" Width="40px" Wrap="False" BorderColor="White" BorderStyle="None" Enabled="False"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="height: 36px; width: 28px;">
                  <asp:Label ID="Label58" runat="server" Font-Bold="True" Font-Underline="False" Text="T.số"
                      Width="52px"></asp:Label></td>
              <td style="width: 36px">
                  <asp:Label ID="LblNam0" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 36px">
                  <asp:Label ID="LblNu0" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 36px">
                  <asp:Label ID="LblNam5" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 36px">
                  <asp:Label ID="LblNu5" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 36px">
                  <asp:Label ID="LblNam15" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 36px">
                  <asp:Label ID="LblNu15" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 36px">
                  <asp:Label ID="LblNam25" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 33px">
                  <asp:Label ID="LblNu25" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 20px">
                  <asp:Label ID="LblNam35" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 3px">
                  <asp:Label ID="LblNu35" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 14px">
                  <asp:Label ID="LblNam45" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 7px">
                  <asp:Label ID="LblNu45" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 15px">
                  <asp:Label ID="LblNam55" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 18px">
                  <asp:Label ID="LblNu55" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 7px">
                  <asp:Label ID="LblNam64" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 4px">
                  <asp:Label ID="LblNu64" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 2px">
                  <asp:Label ID="LblNam" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
              <td style="width: 2px">
                  <asp:Label ID="LblNu" runat="server" CssClass="ntp_label" EnableTheming="False"
                      Font-Bold="True" Font-Underline="False" ForeColor="Black" Text="0" Width="35px"></asp:Label></td>
          </tr>
      </table>
      <br />
<asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="73" Text="Ghi"
                        Width="90px" /><asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False"
                            CssClass="ntp_button" TabIndex="74" Text="Tạo mới" Width="90px" /><asp:Button
                                ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                                Text="Thoát" Width="90px" TabIndex="75" /><br />
</fieldset> &nbsp;&nbsp;
 </asp:Panel>
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
