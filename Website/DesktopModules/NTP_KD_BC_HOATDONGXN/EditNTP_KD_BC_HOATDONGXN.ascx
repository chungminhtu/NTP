<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_BC_HOATDONGXN.EditNTP_KD_BC_HOATDONGXN" CodeFile="EditNTP_KD_BC_HOATDONGXN.ascx.vb" AutoEventWireup="false" Explicit="True" %>
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

    $('input[id=<%=txtAFBDuong1.ClientID %>]').bind('keyup',TongPH_D);
    $('input[id=<%=txtAFBDuong2.ClientID %>]').bind('keyup',TongPH_D);
    $('input[id=<%=txtAFBDuong3.ClientID %>]').bind('keyup',TongPH_D);  
   
    $('input[id=<%=txtAFBAm1.ClientID %>]').bind('keyup',TongPH_A);
    $('input[id=<%=txtAFBAm2.ClientID %>]').bind('keyup',TongPH_A);
    $('input[id=<%=txtAFBAm3.ClientID %>]').bind('keyup',TongPH_A);
    
    $('input[id=<%=txtAFBDuong11.ClientID %>]').bind('keyup',TongHTEST_D);
    $('input[id=<%=txtAFBDuong21.ClientID %>]').bind('keyup',TongHTEST_D);
    $('input[id=<%=txtAFBDuong31.ClientID %>]').bind('keyup',TongHTEST_D);  
      
    $('input[id=<%=txtAFBAm11.ClientID %>]').bind('keyup',TongHTEST_A);
    $('input[id=<%=txtAFBAm21.ClientID %>]').bind('keyup',TongHTEST_A);
    $('input[id=<%=txtAFBAm31.ClientID %>]').bind('keyup',TongHTEST_A);
     
    $('input[id=<%=txtSoTBPhatHienAm.ClientID %>]').bind('keyup',Tongcong_PH);
    $('input[id=<%=txtSoTBPhatHienDuong.ClientID %>]').bind('keyup',Tongcong_PH);
    $('input[id=<%=txtSoTBTheoDoiAm.ClientID %>]').bind('keyup',Tongcong_TD);
    $('input[id=<%=txtSoTBTheoDoiDuong.ClientID %>]').bind('keyup',Tongcong_TD);
    
    $('input[id=<%=txtAFBDuong1.ClientID %>]').bind('keyup',Tongcong1);
    $('input[id=<%=txtAFBDuong2.ClientID %>]').bind('keyup',Tongcong1);
    $('input[id=<%=txtAFBDuong3.ClientID %>]').bind('keyup',Tongcong1);
    $('input[id=<%=txtAFBAm1.ClientID %>]').bind('keyup',Tongcong1);
    $('input[id=<%=txtAFBAm2.ClientID %>]').bind('keyup',Tongcong1);
    $('input[id=<%=txtAFBAm3.ClientID %>]').bind('keyup',Tongcong1);
    
    $('input[id=<%=txtAFBDuong11.ClientID %>]').bind('keyup',Tongcong2);
    $('input[id=<%=txtAFBDuong21.ClientID %>]').bind('keyup',Tongcong2);
    $('input[id=<%=txtAFBDuong31.ClientID %>]').bind('keyup',Tongcong2);        
    $('input[id=<%=txtAFBAm11.ClientID %>]').bind('keyup',Tongcong2);
    $('input[id=<%=txtAFBAm21.ClientID %>]').bind('keyup',Tongcong2);
    $('input[id=<%=txtAFBAm31.ClientID %>]').bind('keyup',Tongcong2);
    
     $('input[id=<%=txtSoTBPhatHienAm.ClientID %>]').bind('keyup',Tongcong);
    $('input[id=<%=txtSoTBPhatHienDuong.ClientID %>]').bind('keyup',Tongcong);
    $('input[id=<%=txtSoTBTheoDoiAm.ClientID %>]').bind('keyup',Tongcong);
    $('input[id=<%=txtSoTBTheoDoiDuong.ClientID %>]').bind('keyup',Tongcong);
});

}
function Tongcong()
{
$('input[id=<%=LblTongcong.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtSoTBPhatHienAm.ClientID %>]'),
				s2: $('input[id^=<%=txtSoTBPhatHienDuong.ClientID %>]'),
				
				s3: $('input[id^=<%=txtSoTBTheoDoiAm.ClientID %>]'),
				s4: $('input[id^=<%=txtSoTBTheoDoiDuong.ClientID %>]')				
				
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
function Tongcong1()
{
$('input[id=<%=LblTong1.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtAFBDuong1.ClientID %>]'),
				s2: $('input[id^=<%=txtAFBDuong2.ClientID %>]'),
				s3: $('input[id^=<%=txtAFBDuong3.ClientID %>]'),
				s4: $('input[id^=<%=txtAFBAm1.ClientID %>]'),
				s5: $('input[id^=<%=txtAFBAm2.ClientID %>]'),
				s6: $('input[id^=<%=txtAFBAm3.ClientID %>]')
				
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
function Tongcong2()
{
$('input[id=<%=LblTong2.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtAFBDuong11.ClientID %>]'),
				s2: $('input[id^=<%=txtAFBDuong21.ClientID %>]'),
				s3: $('input[id^=<%=txtAFBDuong31.ClientID %>]'),
				s4: $('input[id^=<%=txtAFBAm11.ClientID %>]'),
				s5: $('input[id^=<%=txtAFBAm21.ClientID %>]'),
				s6: $('input[id^=<%=txtAFBAm31.ClientID %>]')
				
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
function TongPH_D()
{
$('input[id=<%=TxtTong1.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtAFBDuong1.ClientID %>]'),
				s2: $('input[id^=<%=txtAFBDuong2.ClientID %>]'),
				s3: $('input[id^=<%=txtAFBDuong3.ClientID %>]')
				
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
function TongPH_A()
{
$('input[id=<%=TxtTong2.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtAFBAm1.ClientID %>]'),
				s2: $('input[id^=<%=txtAFBAm2.ClientID %>]'),
				s3: $('input[id^=<%=txtAFBAm3.ClientID %>]')
				
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
function TongHTEST_D()
{
$('input[id=<%=TxtTong11.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtAFBDuong11.ClientID %>]'),
				s2: $('input[id^=<%=txtAFBDuong21.ClientID %>]'),
				s3: $('input[id^=<%=txtAFBDuong31.ClientID %>]')
				
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
function TongHTEST_A()
{
$('input[id=<%=TxtTong21.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtAFBAm11.ClientID %>]'),
				s2: $('input[id^=<%=txtAFBAm21.ClientID %>]'),
				s3: $('input[id^=<%=txtAFBAm31.ClientID %>]')
				
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
function Tongcong_PH(){
 $('input[id=<%=LblTongPH.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 ',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtSoTBPhatHienDuong.ClientID %>]'),
				s2: $('input[id^=<%=txtSoTBPhatHienAm.ClientID %>]')
				
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
function Tongcong_TD(){
 $('input[id=<%=LblTongTD.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 ',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtSoTBTheoDoiAm.ClientID %>]'),
				s2: $('input[id^=<%=txtSoTBTheoDoiDuong.ClientID %>]')
				
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
function TABLE1_onclick() {

}

</script>
<asp:Panel ID="Panel1" runat="server" Height="400px" Width="801px">
  
  
     <table class="ntp_table_main" width="801">
        <tr>
            <td style="width: 133px">
                     <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
            <td style="width: 270px">
                      <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                          DataValueField="ID_BENHVIEN" TabIndex="1" Width="265px" AutoPostBack="True">
                      </asp:DropDownList></td>
            <td style="width: 116px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                          ControlToValidate="cboDonVi" ErrorMessage="Không được trống" Width="112px"></asp:RequiredFieldValidator></td>
            <td style="width: 328px">
                &nbsp;<asp:TextBox ID="txtID_HOATDONGXN" runat="server" AutoCompleteType="Disabled"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="38" Visible="False" Width="49px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                     <asp:Label ID="Label40" runat="server" CssClass="ntp_ label" Text="Quý" Width="58px"></asp:Label></td>
            <td style="width: 270px">
                <asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="2"
                    Width="107px">
                    <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                    <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                    <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                    <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 116px">
                     <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Năm" Width="58px"></asp:Label></td>
            <td style="width: 328px">
                     <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3" Width="98px"></asp:TextBox><asp:RangeValidator ID="RangeValidator22" runat="server" ControlToValidate="txtNam"
                         ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 133px">
                     <asp:Label ID="Label37" runat="server" CssClass="ntp_label" Text="Ngày báo cáo" Width="123px"></asp:Label></td>
            <td style="width: 270px">
                     <asp:TextBox ID="txtNgayBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="4" Width="150px"></asp:TextBox></td>
            <td style="width: 116px">
                     <asp:Label ID="Label38" runat="server" CssClass="ntp_label" Text="Người báo cáo"></asp:Label></td>
            <td style="width: 328px">
                      <asp:TextBox ID="txtNguoiBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="5" Width="100%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 133px; height: 16px;">
                     </td>
            <td style="width: 270px; height: 16px;">
                &nbsp;<ajaxtoolkit:maskededitvalidator
                            id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                            controltovalidate="txtNgayBaoCao" display="Dynamic" emptyvaluemessage="Bạn phải nhập ngày"
                            invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                            tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator>
                     <ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                        runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                        promptcharacter="_" targetcontrolid="txtNgayBaoCao"> </ajaxtoolkit:maskededitextender></td>
            <td style="width: 116px; height: 16px;">
                     </td>
            <td style="width: 328px; height: 16px;">
                &nbsp;<asp:RequiredFieldValidator
                          ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNguoiBaoCao" ErrorMessage="Không được trống"></asp:RequiredFieldValidator>
                      </td>
        </tr>
        <tr>
            <td style="width: 133px; height: 16px">
            </td>
            <td style="width: 270px; height: 16px">
            </td>
            <td style="width: 116px; height: 16px">
            </td>
            <td style="width: 328px; height: 16px">
                <asp:Button ID="CmdXem" runat="server" CssClass="ntp_button" TabIndex="5" Text="Xem"
                    Width="79px" /></td>
        </tr>
    </table>
    <br />

    <asp:Label ID="Label21" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="Blue"
        Text="Phần 1: Tình hình xét nghiệm phát hiện" Width="303px"></asp:Label><br />
    
    <br /><table border =1 class="ntp_table_main" width="801">
        <tr>
            <td align="center" colspan="10" style="height: 38px">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#C00000"
                    Text="Số người XN phát hiện" Width="352px"></asp:Label></td>
            <td align="center" rowspan="3" style="width: 95px">
                <asp:Label ID="Label8" runat="server" Text="Số BN lao phổi AFB(+) được ĐK điều trị"
                    Width="88px" Font-Bold="True"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2" rowspan="2">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Tổng số người XN phát hiện" Width="153px"></asp:Label></td>
            <td align="center" colspan="4" style="height: 38px">
                <asp:Label ID="Label25" runat="server" CssClass="ntp_label" Text="Số người XN AFB(+)"
                    Width="205px" Font-Bold="True"></asp:Label></td>
            <td align="center" colspan="4" style="height: 38px">
                <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Số người XN AFB(-)"
                    Width="218px" Font-Bold="True"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" style="width: 50px">
                <asp:Label ID="Label12" runat="server" Text="1 mẫu" Width="43px"></asp:Label></td>
            <td align="center" style="width: 58px">
                <asp:Label ID="Label9" runat="server" Text="2 mẫu" Width="50px"></asp:Label></td>
            <td align="center" style="width: 35px">
                <asp:Label ID="Label13" runat="server" Text="3 mẫu" Width="50px"></asp:Label></td>
            <td align="center" style="width: 86px">
                <asp:Label ID="Label4" runat="server" Text="Tổng" Width="52px"></asp:Label></td>
            <td align="center" style="width: 93px">
                <asp:Label ID="Label14" runat="server" Text="1 mẫu" Width="50px"></asp:Label></td>
            <td align="center" style="width: 84px">
                <asp:Label ID="Label15" runat="server" Text="2 mẫu" Width="50px"></asp:Label></td>
            <td align="center" style="width: 45px">
                <asp:Label ID="Label16" runat="server" Text="3 mẫu" Width="50px"></asp:Label></td>
            <td align="center" style="width: 45px">
                <asp:Label ID="Label5" runat="server" Text="Tổng" Width="50px"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" style="height: 24px" colspan="2">
                <asp:TextBox ID="LblTong1" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="4" Width="145px" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="txtID_HOATDONGXNC" runat="server" CssClass="ntp_textbox" MaxLength="50"
                          TabIndex="30" Width="60px" Visible="False"></asp:TextBox></td>
            <td style="width: 50px; height: 24px" align="center">
                     <asp:TextBox ID="txtAFBDuong1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6" Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                     <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtAFBDuong1"
                         ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td style="width: 58px; height: 24px" align="center">
                      <asp:TextBox ID="txtAFBDuong2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="7" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                      <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtAFBDuong2"
                          ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td style="width: 35px; height: 24px" align="center">
                      <asp:TextBox ID="txtAFBDuong3" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8" Width="45px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator12" runat="server" ControlToValidate="txtAFBDuong3"
                         ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td align="center" style="width: 86px; height: 24px">
                <asp:TextBox ID="TxtTong1" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="47px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator19" runat="server" ControlToValidate="TxtTong11"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td style="width: 93px; height: 24px" align="center">
                     <asp:TextBox ID="txtAFBAm1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="9" Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="txtAFBAm1"
                         ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td style="width: 84px; height: 24px" align="center">
                     <asp:TextBox ID="txtAFBAm2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="10" Width="46px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtAFBAm2"
                           ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td style="width: 45px; height: 24px" align="center">
                      <asp:TextBox ID="txtAFBAm3" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11" Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="txtAFBAm3"
                         ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td align="center" style="width: 45px; height: 24px">
                <asp:TextBox ID="TxtTong2" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="48px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator21" runat="server" ControlToValidate="TxtTong2"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
            <td style="width: 95px; height: 24px" align="center">
                <asp:TextBox ID="txtSoBNDK" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12"
                    Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtSoBNDK"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
        </tr>
    </table>
    <br />
     <table border =1 class="ntp_table_main" width="801">
         <tr>
             <td align="center" colspan="10" style="height: 38px">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#C00000"
                    Text="Số người XN phát hiện có Htest(+)" Width="337px"></asp:Label></td>
             <td align="center" rowspan="3" style="width: 95px">
                 <asp:Label ID="Label44" runat="server" Font-Bold="True" Text="Số BN lao phổi AFB(+) được ĐK điều trị"
                     Width="88px"></asp:Label></td>
         </tr>
         <tr>
             <td align="center" colspan="2" rowspan="2" style="width: 126px">
                 <asp:Label ID="Label45" runat="server" Font-Bold="True" Text="Tổng số người XN phát hiện"
                     Width="129px"></asp:Label></td>
             <td align="center" colspan="4" style="height: 38px">
                 <asp:Label ID="Label46" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số người XN AFB(+)"
                     Width="205px"></asp:Label></td>
             <td align="center" colspan="4" style="height: 38px">
                 <asp:Label ID="Label47" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số người XN AFB(-)"
                     Width="218px"></asp:Label></td>
         </tr>
         <tr>
             <td align="center" style="width: 42px">
                 <asp:Label ID="Label48" runat="server" Text="1 mẫu" Width="43px"></asp:Label></td>
             <td align="center" style="width: 50px">
                 <asp:Label ID="Label49" runat="server" Text="2 mẫu" Width="50px"></asp:Label></td>
             <td align="center" style="width: 35px">
                 <asp:Label ID="Label50" runat="server" Text="3 mẫu" Width="50px"></asp:Label></td>
             <td align="center" style="width: 59px">
                 <asp:Label ID="Label51" runat="server" Text="Tổng" Width="52px"></asp:Label></td>
             <td align="center" style="width: 55px">
                 <asp:Label ID="Label52" runat="server" Text="1 mẫu" Width="50px"></asp:Label></td>
             <td align="center" style="width: 60px">
                 <asp:Label ID="Label53" runat="server" Text="2 mẫu" Width="50px"></asp:Label></td>
             <td align="center" style="width: 45px">
                 <asp:Label ID="Label54" runat="server" Text="3 mẫu" Width="50px"></asp:Label></td>
             <td align="center" style="width: 45px">
                 <asp:Label ID="Label55" runat="server" Text="Tổng" Width="50px"></asp:Label></td>
         </tr>
         <tr>
             <td align="left" style="height: 19px; width: 126px;" colspan="2">
                 <asp:TextBox ID="LblTong2" runat="server" BorderColor="White" BorderStyle="None"
                     CssClass="ntp_textbox" MaxLength="50" TabIndex="4" Width="135px" Enabled="False"></asp:TextBox>
                 <asp:TextBox ID="txtID_HOATDONGXNC1" runat="server" AutoCompleteType="Disabled" CssClass="ntp_textbox"
                    MaxLength="50" TabIndex="39" Width="57px" Visible="False"></asp:TextBox></td>
             <td style="width: 42px; height: 19px" align="center">
                 <asp:TextBox ID="txtAFBDuong11" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="13"
                    Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="txtAFBDuong11"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td style="width: 50px; height: 19px" align="center">
                <asp:TextBox ID="txtAFBDuong21" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="14"
                    Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="txtAFBDuong21"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator>&nbsp;</td>
             <td style="width: 35px; height: 19px" align="center">
                <asp:TextBox ID="txtAFBDuong31" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="15"
                    Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="txtAFBDuong31"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td align="center" style="width: 59px; height: 19px">
                <asp:TextBox ID="TxtTong11" runat="server" BorderColor="White" BorderStyle="Dotted"
                    CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="60px"></asp:TextBox><asp:RangeValidator ID="RangeValidator20" runat="server" ControlToValidate="TxtTong11"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator>&nbsp;</td>
             <td style="width: 55px; height: 19px" align="center">
                <asp:TextBox ID="txtAFBAm11" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="16"
                    Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator10" runat="server" ControlToValidate="txtAFBAm11"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td style="width: 60px; height: 19px" align="center">
                <asp:TextBox ID="txtAFBAm21" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="17"
                    Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator13" runat="server" ControlToValidate="txtAFBAm21"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td style="width: 45px; height: 19px" align="center">
                <asp:TextBox ID="txtAFBAm31" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="18"
                    Width="50px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator17" runat="server" ControlToValidate="txtAFBAm31"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td align="center" style="width: 45px; height: 19px">
                <asp:TextBox ID="TxtTong21" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="60px"></asp:TextBox><asp:RangeValidator ID="RangeValidator23" runat="server" ControlToValidate="TxtTong21"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator>&nbsp;</td>
             <td style="width: 95px; height: 19px" align="center">
                <asp:TextBox ID="txtSoBNDK1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="19"
                    Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator18" runat="server" ControlToValidate="txtSoBNDK1"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator>&nbsp;</td>
         </tr>
     </table>
    <br />
<asp:Label ID="Label22" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="Blue"
        Text="Phần 2: Số tiêu bản thực hiện" Width="293px"></asp:Label><br />
    <br />
     <table border="1" width="801">
         <tr>
             <td align="center" colspan="3">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Black"
                    Text="Số tiêu bản phát hiện" Width="293px"></asp:Label></td>
             <td align="center" colspan="3">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Black"
                    Text="Số tiêu bản theo dõi điều trị" Width="254px"></asp:Label></td>
             <td align="center" rowspan="2">
                <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Tổng cộng" Width="77px"></asp:Label></td>
         </tr>
         <tr>
             <td align="center">
                <asp:Label ID="Label18" runat="server" Text="TB dương" Width="81px"></asp:Label></td>
             <td align="center">
                <asp:Label ID="Label17" runat="server" Text="TB âm" Width="84px"></asp:Label></td>
             <td align="center">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Tổng " Width="94px"></asp:Label></td>
             <td align="center">
                <asp:Label ID="Label19" runat="server" Text="TB dương" Width="83px"></asp:Label></td>
             <td align="center">
                <asp:Label ID="Label20" runat="server" Text="TB âm" Width="81px"></asp:Label></td>
             <td align="center">
                <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Tổng" Width="97px"></asp:Label></td>
         </tr>
         <tr>
             <td>
             <asp:TextBox ID="txtSoTBPhatHienDuong" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="20"
                 Width="85px" BorderColor="White" BorderStyle="None"></asp:TextBox>
             <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSoTBPhatHienDuong"
                 ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td>
             <asp:TextBox ID="txtSoTBPhatHienAm" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="21"
                 Width="85px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator14" runat="server"
                     ControlToValidate="txtSoTBPhatHienAm" ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0"
                     Type="Double"></asp:RangeValidator></td>
             <td>
                 <asp:TextBox ID="LblTongPH" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="21" Width="91px" Enabled="False"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator24" runat="server" ControlToValidate="LblTongPH"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td>
             <asp:TextBox ID="txtSoTBTheoDoiDuong" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="22"
                 Width="85px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator15" runat="server"
                     ControlToValidate="txtSoTBTheoDoiDuong" ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0"
                     Type="Double"></asp:RangeValidator></td>
             <td>
             <asp:TextBox ID="txtSoTBTheoDoiAm" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="23"
                 Width="85px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator16" runat="server"
                     ControlToValidate="txtSoTBTheoDoiAm" ErrorMessage="Là số" MaximumValue="999999999"
                     MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td>
                 <asp:TextBox ID="LblTongTD" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="21" Width="89px" Enabled="False"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator26" runat="server" ControlToValidate="LblTongTD"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
             <td>
                <asp:TextBox ID="LblTongcong" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="21" Width="64px" Enabled="False"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator25" runat="server" ControlToValidate="LblTongcong"
                    ErrorMessage="Là số" MaximumValue="999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
         </tr>
     </table>
    <br />
    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="24" Text="Ghi"
                        Width="101px" /><asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False"
                            CssClass="ntp_button" TabIndex="25" Text="Tạo mới" Width="101px" /><asp:Button
                                ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                                Text="Thoát" Width="101px" TabIndex="28" /></asp:Panel>
&nbsp;<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
&nbsp;<br />
    <br />
<br />
<br />
&nbsp; &nbsp;&nbsp;<br />
<br />
&nbsp;&nbsp;<br />
<br />
                            <br />
 
