<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_BC_KIEMDINHTB.EditNTP_KD_BC_KIEMDINHTB" CodeFile="EditNTP_KD_BC_KIEMDINHTB.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
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
  //            txtSaiDuongLon,txtSaiAmLon,txtDLLon,txtSaiDuongNho,txtSaiAmNho,txtDLNho,TxtLoiLon,TxtLoiNho

    $('input[id=<%=txtSaiDuongLon.ClientID %>]').bind('keyup',TongPH_D);
    $('input[id=<%=txtSaiAmLon.ClientID %>]').bind('keyup',TongPH_D);
    $('input[id=<%=txtDLLon.ClientID %>]').bind('keyup',TongPH_D);  
   
    $('input[id=<%=txtSaiDuongNho.ClientID %>]').bind('keyup',TongPH_A);
    $('input[id=<%=txtSaiAmNho.ClientID %>]').bind('keyup',TongPH_A);
    $('input[id=<%=txtDLNho.ClientID %>]').bind('keyup',TongPH_A);   
 
});

}


function TongPH_D()
{
$('input[id=<%=TxtLoiLon.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtSaiDuongLon.ClientID %>]'),
				s2: $('input[id^=<%=txtSaiAmLon.ClientID %>]'),
				s3: $('input[id^=<%=txtDLLon.ClientID %>]')
				
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
$('input[id=<%=TxtLoiNho.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 ",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtSaiDuongNho.ClientID %>]'),
				s2: $('input[id^=<%=txtSaiAmNho.ClientID %>]'),
				s3: $('input[id^=<%=txtDLNho.ClientID %>]')
				
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

initform();


</script>
 <table style="width: 74%">
              <tr>
                 <td style="height: 26px; width: 7px;">
                     <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
                 <td style="height: 0px; width: 25%;">
                      <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                          DataValueField="ID_BENHVIEN" TabIndex="1" Width="254px" AutoPostBack="True">
                      </asp:DropDownList></td>
                 <td style="width: 6%; height: 0px;">
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                          ControlToValidate="cboDonVi" ErrorMessage="Không được trống" Width="130px"></asp:RequiredFieldValidator></td>
                   <td colspan="1" style="width: 16%; height: 26px">
                       &nbsp;
                     <asp:TextBox ID="txtID_KiemdinhTB" runat="server" CssClass="ntp_textbox" MaxLength="50" Visible="False"></asp:TextBox></td>
                 <td colspan="6" style="height: 26px; width: 7%;">
                     </td>
             </tr>
              <tr>
                 <td style="width: 10%; height: 45px;">
                     <asp:Label ID="Label40" runat="server" CssClass="ntp_ label" Text="Quý" Width="74px"></asp:Label></td>
                 <td style="width: 25%; height: 45px;">
                     <asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="2"
                         Width="107px">
                         <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                         <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                         <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                         <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
                     </asp:DropDownList>
                 </td>
                 <td style="width: 6%; height: 45px;">
                     <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Năm" Width="76px"></asp:Label></td>
                  <td colspan="7" style="height: 45px">
                     <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3" Width="117px"></asp:TextBox><asp:RangeValidator ID="RangeValidator22" runat="server" ControlToValidate="txtNam"
                         ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator><asp:RequiredFieldValidator
                             ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNam" ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
                 
             </tr>
     <tr>
         <td style="width: 10%; height: 15px">
             <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Ngày báo cáo" Width="106px"></asp:Label></td>
         <td style="width: 25%; height: 15px">
             <asp:TextBox ID="txtNgayBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="4" Width="150px"></asp:TextBox></td>
         <td style="width: 6%; height: 15px">
             <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Người báo cáo" Width="106px"></asp:Label></td>
         <td colspan="7" style="height: 15px">
             <asp:TextBox ID="txtNguoiBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="5" Width="96%"></asp:TextBox></td>
     </tr>
     <tr>
         <td style="width: 10%; height: 15px">
         </td>
         <td style="width: 25%; height: 15px">
             <ajaxtoolkit:maskededitextender id="MaskedEditExtender1" runat="server" autocomplete="true"
                 culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtNgayBaoCao"> </ajaxtoolkit:maskededitextender>
         </td>
         <td style="width: 6%; height: 15px">
         </td>
         <td colspan="7" style="height: 15px">
             <asp:Button ID="CmdXem" runat="server" CssClass="ntp_button" TabIndex="5" Text="Xem"
                 Width="79px" /></td>
     </tr>
              <%--<tr>
                 <td style="height: 26px; width: 7px;">
                     <asp:Label ID="Label37" runat="server" CssClass="ntp_label" Text="Ngày báo cáo" Width="117px"></asp:Label></td>
                 <td style="height: 26px; width: 71px;">
                     <asp:TextBox ID="txtNgayBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="2" Width="150px"></asp:TextBox><ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                        runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                        promptcharacter="_" targetcontrolid="txtNgayBaoCao"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                            id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                            controltovalidate="txtNgayBaoCao" display="Dynamic" emptyvaluemessage="Bạn phải nhập ngày"
                            invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                            tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
                 <td style="width: 13%; height: 26px;">
                     <asp:Label ID="Label38" runat="server" CssClass="ntp_label" Text="Người báo cáo"></asp:Label></td>
                  <td colspan="7" style="height: 26px">
                      <asp:TextBox ID="txtNguoiBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11" Width="100%"></asp:TextBox><asp:RequiredFieldValidator
                          ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNguoiBaoCao" ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
                 
             </tr>--%>     
             
              
              </table> 

  <fieldset class="ntp_fieldset" style="width: 808px">
      <asp:Label ID="Label4" runat="server" ForeColor="Blue" Text="Phần 1: Phân loại lỗi và tỉ lệ lỗi"
          Width="275px" Font-Bold="True"></asp:Label><br />
      <table border="1" style="width: 794px">
          <tr>
              <td align="center" rowspan="2">
                     <asp:Label ID="Label25" runat="server" CssClass="ntp_label" Text="TSTB thực hiện" Width="63px" Font-Bold="True"></asp:Label></td>
              <td align="center" rowspan="2">
                     <asp:Label ID="Label26" runat="server" CssClass="ntp_label" Text="Số TB cần KĐ" Width="62px" Font-Bold="True"></asp:Label></td>
              <td align="center" rowspan="2">
                     <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Số TB kiểm định"
                         Width="66px" Font-Bold="True"></asp:Label></td>
              <td align="center" colspan="6">
                  <asp:Label ID="Label16" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Phân loại lỗi"
                      Width="421px"></asp:Label></td>
              <td align="center" colspan="1" rowspan="2">
                  <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Lỗi lớn"
                      Width="59px"></asp:Label></td>
              <td align="center" colspan="1" rowspan="2" style="width: 65px">
                  <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Lỗi nhỏ"
                      Width="59px" Height="12px"></asp:Label></td>
          </tr>
          <tr>
              <td align="center">
                     <asp:Label ID="Label33" runat="server" CssClass="ntp_label" Text="Sai (+) lớn" Width="62px"></asp:Label></td>
              <td align="center">
             <asp:Label ID="Label39" runat="server" CssClass="ntp_label" Text="Sai (-) lớn" Width="58px"></asp:Label></td>
              <td align="center">
                     <asp:Label ID="Label31" runat="server" CssClass="ntp_label" Text="Định lượng lớn" Width="57px" Height="20px"></asp:Label></td>
              <td align="center">
                     <asp:Label ID="Label27" runat="server" CssClass="ntp_label" Text="Sai (+) nhỏ"
                         Width="46px"></asp:Label></td>
              <td align="center">
                     <asp:Label ID="Label32" runat="server" CssClass="ntp_label" Text="Sai (-) nhỏ" Width="50px" Height="21px"></asp:Label></td>
              <td align="center">
                  <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Định lượng nhỏ"
                      Width="59px"></asp:Label></td>
          </tr>
          <tr>
              <td style="height: 42px">
                     <asp:TextBox ID="txtTSTBThucHien" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                     <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtTSTBThucHien"
                         ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer" Width="37px"></asp:RangeValidator></td>
              <td style="height: 42px">
                      <asp:TextBox ID="txtSoTBCanKD" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="7" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="txtSoTBCanKD"
                          ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer" Width="44px"></asp:RangeValidator></td>
              <td style="height: 42px">
                      <asp:TextBox ID="txtSoTBKiemDinh" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator12" runat="server" ControlToValidate="txtSoTBKiemDinh"
                         ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 42px">
                      <asp:TextBox ID="txtSaiDuongLon" runat="server" CssClass="ntp_textbox" MaxLength="50"
                          TabIndex="9" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtSaiDuongLon"
                          ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 42px">
                     <asp:TextBox ID="txtSaiAmLon" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="10" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="txtSaiAmLon"
                         ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 42px">
                     <asp:TextBox ID="txtDLLon" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtDLLon"
                           ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 42px">
                      <asp:TextBox ID="txtSaiDuongNho" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="txtSaiDuongNho"
                         ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 42px">
             <asp:TextBox ID="txtSaiAmNho" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="13" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator7"
                     runat="server" ControlToValidate="txtSaiAmNho" ErrorMessage="Là số" MaximumValue="999999"
                     MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 42px">
                     <asp:TextBox ID="txtDLNho" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="14" Width="60px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtDLNho"
                         ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 4px; height: 42px;">
                  <asp:TextBox ID="TxtLoiLon" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" MaxLength="50" TabIndex="15" Width="60px" Enabled="False"></asp:TextBox><br />
                  &nbsp;</td>
              <td style="width: 65px; height: 42px">
                  <asp:TextBox ID="TxtLoiNho" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" MaxLength="50" TabIndex="16" Width="60px" Enabled="False"></asp:TextBox><br />
                  &nbsp;</td>
          </tr>
      </table>
      <br />
     <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Blue" Text="Phần 2: Chất lượng tiêu bản"
         Width="275px"></asp:Label><br />
 <table border="1" style="width: 99%">
              <tr>
                  <td align="center" style="width: 5%; height: 36px">
                      <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Text="TSTB kiểm định"
                          Width="115px"></asp:Label></td>
                 <td style="width: 5%; height: 36px;" align="center">
                     <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="CLBP - SL đạt" Width="104px"></asp:Label></td>
                  <td align="center" style="width: 5%; height: 36px">
             <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Tẩy màu - SL đạt"
                 Width="88px"></asp:Label></td>
                  <td align="center" style="width: 5%; height: 36px">
             <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Độ sạch - SL đạt"
                 Width="92px"></asp:Label></td>
                  <td align="center" style="width: 5%; height: 36px">
                     <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Độ dày - SL đạt" Width="93px"></asp:Label></td>
                 <td style="width: 5%; height: 36px;" align="center">
                     <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Kích thước - SL đạt" Width="108px"></asp:Label></td>
                  <td style="width: 128px; height: 36px;" align="center">
             <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Độ mịn - SL đạt"
                 Width="116px"></asp:Label></td>
                 
             </tr>     
             
               <tr>
                   <td style="height: 39px">
                       <asp:TextBox ID="TxtTongsoTBKD" runat="server" BorderColor="White" BorderStyle="None"
                           CssClass="ntp_textbox" MaxLength="50" TabIndex="17" Width="103px"></asp:TextBox>
                       <asp:RangeValidator ID="RangeValidator13" runat="server" ControlToValidate="TxtTongsoTBKD"
                           ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                 <td style="height: 39px">
                    <asp:TextBox ID="txtCLBP" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="17" BorderColor="White" BorderStyle="None" Width="91px"></asp:TextBox><asp:RangeValidator ID="RangeValidator101" runat="server" ControlToValidate="txtCLBP"
                        ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                   <td style="height: 39px">
             <asp:TextBox ID="txtTayMau" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="18" BorderColor="White" BorderStyle="None" Width="88px"></asp:TextBox><asp:RangeValidator ID="RangeValidator131" runat="server"
                     ControlToValidate="txtTayMau" ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0"
                     Type="Integer"></asp:RangeValidator></td>
                   <td style="height: 39px">
             <asp:TextBox ID="txtDoSach" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="19" BorderColor="White" BorderStyle="None" Width="82px"></asp:TextBox><asp:RangeValidator ID="RangeValidator1" runat="server"
                     ControlToValidate="txtDoSach" ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0"
                     Type="Integer"></asp:RangeValidator></td>
                   <td style="height: 39px">
                    <asp:TextBox ID="txtDoDay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="20" BorderColor="White" BorderStyle="None" Width="84px"></asp:TextBox><asp:RangeValidator ID="RangeValidator14" runat="server" ControlToValidate="txtDoDay"
                        ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                 <td style="height: 39px">
                    <asp:TextBox ID="txtKichThuoc" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="21" BorderColor="White" BorderStyle="None" Width="91px"></asp:TextBox><asp:RangeValidator ID="RangeValidator15" runat="server" ControlToValidate="txtKichThuoc"
                        ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                   <td style="width: 128px; height: 39px">
             <asp:TextBox ID="txtDoMin" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="22" BorderColor="White" BorderStyle="None" Width="93px"></asp:TextBox><asp:RangeValidator ID="RangeValidator16" runat="server"
                     ControlToValidate="txtDoMin" ErrorMessage="Là số" MaximumValue="999999" MinimumValue="0"
                     Type="Integer" Width="58px"></asp:RangeValidator></td>
             </tr>
     <tr>
         <td colspan="7" style="height: 26px">
         </td>
     </tr>
              </table>
      &nbsp;

<asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="23" Text="Ghi"
                        Width="100px" /><asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False"
                            CssClass="ntp_button" TabIndex="24" Text="Tạo mới" Width="100px" /><asp:Button
                                ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                                Text="Thoát" Width="100px" TabIndex="25" /></fieldset> &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
