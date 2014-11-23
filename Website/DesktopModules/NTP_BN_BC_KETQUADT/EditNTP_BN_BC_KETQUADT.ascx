<%@ Control language="vb"  Inherits="YourCompany.Modules.NTP_BN_BC_KETQUADT.EditNTP_BN_BC_KETQUADT" CodeFile="EditNTP_BN_BC_KETQUADT.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
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

    // 
    $('input[id=<%=txtKhoi.ClientID %>]').bind('keyup',recalcHC);
    $('input[id=<%=TxtChet.ClientID %>]').bind('keyup',recalcHC);
    $('input[id=<%=TxtHoanThanh.ClientID %>]').bind('keyup',recalcHC);
    $('input[id=<%=txtThatBai.ClientID %>]').bind('keyup',recalcHC);
    $('input[id=<%=TxtBo.ClientID %>]').bind('keyup',recalcHC);
    $('input[id=<%=txtChuyen.ClientID %>]').bind('keyup',recalcHC);
    $('input[id=<%=txtKhongDanhGia.ClientID %>]').bind('keyup',recalcHC);
    
    //
    $('input[id=<%=txtKhoi1.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id=<%=TxtChet1.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id=<%=TxtHoanThanh1.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id=<%=txtThatBai1.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id=<%=TxtBo1.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id=<%=txtChuyen1.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id=<%=txtKhongDanhGia1.ClientID %>]').bind('keyup',recalcVT_TINH);
    
    $('input[id=<%=txtKhoi2.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id=<%=TxtChet2.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id=<%=TxtHoanThanh2.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id=<%=txtThatBai2.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id=<%=TxtBo2.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id=<%=txtChuyen2.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id=<%=txtKhongDanhGia2.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    
    $('input[id=<%=txtKhoi3.ClientID %>]').bind('keyup',recalcVT_HUYEN3);
    $('input[id=<%=TxtChet3.ClientID %>]').bind('keyup',recalcVT_HUYEN3);
    $('input[id=<%=TxtHoanThanh3.ClientID %>]').bind('keyup',recalcVT_HUYEN3);
    $('input[id=<%=txtThatBai3.ClientID %>]').bind('keyup',recalcVT_HUYEN3);
    $('input[id=<%=TxtBo3.ClientID %>]').bind('keyup',recalcVT_HUYEN3);
    $('input[id=<%=txtChuyen3.ClientID %>]').bind('keyup',recalcVT_HUYEN3);
    $('input[id=<%=txtKhongDanhGia3.ClientID %>]').bind('keyup',recalcVT_HUYEN3);
    
    $('input[id=<%=txtKhoi4.ClientID %>]').bind('keyup',recalcVT_HUYEN4);
    $('input[id=<%=TxtChet4.ClientID %>]').bind('keyup',recalcVT_HUYEN4);
    $('input[id=<%=TxtHoanThanh4.ClientID %>]').bind('keyup',recalcVT_HUYEN4);
    $('input[id=<%=txtThatBai4.ClientID %>]').bind('keyup',recalcVT_HUYEN4);
    $('input[id=<%=TxtBo4.ClientID %>]').bind('keyup',recalcVT_HUYEN4);
    $('input[id=<%=txtChuyen4.ClientID %>]').bind('keyup',recalcVT_HUYEN4);
    $('input[id=<%=txtKhongDanhGia4.ClientID %>]').bind('keyup',recalcVT_HUYEN4);
        
    $('input[id=<%=TxtChet5.ClientID %>]').bind('keyup',recalcVT_HUYEN5);
    $('input[id=<%=TxtHoanThanh5.ClientID %>]').bind('keyup',recalcVT_HUYEN5);
    $('input[id=<%=txtThatBai5.ClientID %>]').bind('keyup',recalcVT_HUYEN5);
    $('input[id=<%=TxtBo5.ClientID %>]').bind('keyup',recalcVT_HUYEN5);
    $('input[id=<%=txtChuyen5.ClientID %>]').bind('keyup',recalcVT_HUYEN5);
    $('input[id=<%=txtKhongDanhGia5.ClientID %>]').bind('keyup',recalcVT_HUYEN5);
    
    $('input[id=<%=TxtChet6.ClientID %>]').bind('keyup',recalcVT_HUYEN6);
    $('input[id=<%=TxtHoanThanh6.ClientID %>]').bind('keyup',recalcVT_HUYEN6);
    $('input[id=<%=txtThatBai6.ClientID %>]').bind('keyup',recalcVT_HUYEN6);
    $('input[id=<%=TxtBo6.ClientID %>]').bind('keyup',recalcVT_HUYEN6);
    $('input[id=<%=txtChuyen6.ClientID %>]').bind('keyup',recalcVT_HUYEN6);
    $('input[id=<%=txtKhongDanhGia6.ClientID %>]').bind('keyup',recalcVT_HUYEN6);
    
    $('input[id=<%=TxtChet7.ClientID %>]').bind('keyup',recalcVT_HUYEN7);
    $('input[id=<%=TxtHoanThanh7.ClientID %>]').bind('keyup',recalcVT_HUYEN7);
    $('input[id=<%=txtThatBai7.ClientID %>]').bind('keyup',recalcVT_HUYEN7);
    $('input[id=<%=TxtBo7.ClientID %>]').bind('keyup',recalcVT_HUYEN7);
    $('input[id=<%=txtChuyen7.ClientID %>]').bind('keyup',recalcVT_HUYEN7);
    $('input[id=<%=txtKhongDanhGia7.ClientID %>]').bind('keyup',recalcVT_HUYEN7);
    
    $('input[id=<%=txtKhoi8.ClientID %>]').bind('keyup',recalc21);
    $('input[id=<%=TxtChet8.ClientID %>]').bind('keyup',recalc21);
    $('input[id=<%=TxtHoanThanh8.ClientID %>]').bind('keyup',recalc21);
    $('input[id=<%=txtThatBai8.ClientID %>]').bind('keyup',recalc21);
    $('input[id=<%=TxtBo8.ClientID %>]').bind('keyup',recalc21);
    $('input[id=<%=txtChuyen8.ClientID %>]').bind('keyup',recalc21);
    $('input[id=<%=txtKhongDanhGia8.ClientID %>]').bind('keyup',recalc21);
    
    $('input[id=<%=txtKhoi9.ClientID %>]').bind('keyup',recalc22);
    $('input[id=<%=TxtChet9.ClientID %>]').bind('keyup',recalc22);
    $('input[id=<%=TxtHoanThanh9.ClientID %>]').bind('keyup',recalc22);
    $('input[id=<%=txtThatBai9.ClientID %>]').bind('keyup',recalc22);
    $('input[id=<%=TxtBo9.ClientID %>]').bind('keyup',recalc22);
    $('input[id=<%=txtChuyen9.ClientID %>]').bind('keyup',recalc22);
    $('input[id=<%=txtKhongDanhGia9.ClientID %>]').bind('keyup',recalc22);
    
    
});

}

function recalcHC(){
    $('input[id=<%=TxtTong.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s3 + s4 + s5 + s6 + s7',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtKhoi.ClientID %>]'),
				s2: $('input[id^=<%=TxtChet.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia.ClientID %>]')
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

function recalcVT_TINH()
{
$('input[id=<%=TxtTong1.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6 + s7",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtKhoi1.ClientID %>]'),
				s2: $('input[id^=<%=TxtChet1.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh1.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai1.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo1.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen1.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia1.ClientID %>]')

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

function recalcVT_HUYEN()
{
$('input[id=<%=TxtTong2.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6 + s7",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtKhoi2.ClientID %>]'),
				s2: $('input[id^=<%=TxtChet2.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh2.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai2.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo2.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen2.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia2.ClientID %>]')
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
function recalcVT_HUYEN3()
{
$('input[id=<%=TxtTong3.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6 + s7",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtKhoi3.ClientID %>]'),
				s2: $('input[id^=<%=TxtChet3.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh3.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai3.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo3.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen3.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia3.ClientID %>]')

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

function recalcVT_HUYEN4()
{
$('input[id=<%=TxtTong4.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s3 + s4 + s5 + s6 + s7",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtKhoi4.ClientID %>]'),
				s2: $('input[id^=<%=TxtChet4.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh4.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai4.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo4.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen4.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia4.ClientID %>]')

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
function recalcVT_HUYEN5()
{
$('input[id=<%=TxtTong5.ClientID %>]').calc(
			// the equation to use for the calculation
			" s2 + s3 + s4 + s5 + s6 + s7",
			// define the variables used in the equation, these can be a jQuery object
			{
				s2: $('input[id^=<%=TxtChet5.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh5.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai5.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo5.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen5.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia5.ClientID %>]')

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
function recalcVT_HUYEN6()
{
$('input[id=<%=TxtTong6.ClientID %>]').calc(
			// the equation to use for the calculation
			" s2 + s3 + s4 + s5 + s6 + s7",
			// define the variables used in the equation, these can be a jQuery object
			{
				s2: $('input[id^=<%=TxtChet6.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh6.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai6.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo6.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen6.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia6.ClientID %>]')

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
function recalcVT_HUYEN7()
{
$('input[id=<%=TxtTong7.ClientID %>]').calc(
			// the equation to use for the calculation
			" s2 + s3 + s4 + s5 + s6 + s7",
			// define the variables used in the equation, these can be a jQuery object
			{
				s2: $('input[id^=<%=TxtChet7.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh7.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai7.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo7.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen7.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia7.ClientID %>]')

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

function recalc21(){
    $('input[id=<%=TxtTONGBNDK8.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s3 + s4 + s5 + s6 + s7',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtKhoi8.ClientID %>]'),
				s2: $('input[id^=<%=TxtChet8.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh8.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai8.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo8.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen8.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia8.ClientID %>]')
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
function recalc22(){
    $('input[id=<%=TxtTONGBNDK9.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s3 + s4 + s5 + s6 + s7',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=txtKhoi9.ClientID %>]'),
				s2: $('input[id^=<%=TxtChet9.ClientID %>]'),
				s3: $('input[id^=<%=TxtHoanThanh9.ClientID %>]'),
				s4: $('input[id^=<%=txtThatBai9.ClientID %>]'),
				s5: $('input[id^=<%=TxtBo9.ClientID %>]'),
				s6: $('input[id^=<%=txtChuyen9.ClientID %>]'),
				s7: $('input[id^=<%=txtKhongDanhGia9.ClientID %>]')
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
<asp:Panel ID="Panel1" runat="server" Height="160px" Width="767px">


<table style="width: 761px">
    <tr>
        <td style="width: 104px">
                     <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
        <td style="width: 278px">
                      <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                          DataValueField="ID_BENHVIEN" TabIndex="2" Width="279px">
                      </asp:DropDownList></td>
        <td style="width: 69px">
        </td>
        <td style="width: 115px">
        </td>
        <td style="width: 269px">
            <asp:RequiredFieldValidator
                             ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNam" ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 104px">
                     <asp:Label ID="Label40" runat="server" CssClass="ntp_label" Text="Quý" Width="80px"></asp:Label></td>
        <td style="width: 278px">
                     <asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox"
                TabIndex="3" Width="89px">
                <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 69px">
            </td>
        <td style="width: 115px">
                     <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Năm" Width="48px"></asp:Label></td>
        <td style="width: 269px">
                     <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="4" Width="99px"></asp:TextBox><asp:RangeValidator ID="RangeValidator22" runat="server" ControlToValidate="txtNam"
                         ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td style="width: 104px">
                     <asp:Label ID="Label37" runat="server" CssClass="ntp_label" Text="Ngày báo cáo" Width="96px"></asp:Label></td>
        <td style="width: 278px">
                     <asp:TextBox ID="txtNgayBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="5" Width="137px"></asp:TextBox>&nbsp;&nbsp;
        </td>
        <td style="width: 69px">
        </td>
        <td style="width: 115px">
                     <asp:Label ID="Label38" runat="server" CssClass="ntp_label" Text="Người báo cáo" Width="104px"></asp:Label></td>
        <td style="width: 269px">
                      <asp:TextBox ID="txtNguoiBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 104px; height: 4px">
            &nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtId_KetQuaDT" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="120" Width="85px" Visible="False"></asp:TextBox></td>
        <td style="width: 278px; height: 4px">
            <ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                        runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                        promptcharacter="_" targetcontrolid="txtNgayBaoCao"> </ajaxtoolkit:maskededitextender>
        </td>
        <td style="width: 69px; height: 4px">
            </td>
        <td style="width: 115px; height: 4px">
            &nbsp;&nbsp;
            <asp:TextBox ID="txtId_KetQuaDT1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="119" Width="90px" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtId_KetQuaDT3" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="117" Width="85px" Visible="False"></asp:TextBox>
            </td>
        <td style="width: 269px; height: 4px">
            &nbsp;
                     <asp:TextBox ID="txtId_BCKetQuaDT" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="121" Width="158px" Visible="False"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td style="width: 104px; height: 4px">
            <asp:TextBox ID="txtId_KetQuaDT8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="111" Width="63px" Visible="False"></asp:TextBox></td>
        <td style="width: 278px; height: 4px">
            <asp:TextBox ID="txtId_KetQuaDT6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="114" Width="66px" Visible="False"></asp:TextBox><asp:TextBox ID="txtId_KetQuaDT7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="112" Width="60px" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtId_KetQuaDT9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="113" Width="72px" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtId_KetQuaDT5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="115" Width="68px" Visible="False"></asp:TextBox></td>
        <td style="width: 69px; height: 4px">
        </td>
        <td style="width: 115px; height: 4px">
            <asp:TextBox ID="txtId_KetQuaDT2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="118" Width="87px" Visible="False"></asp:TextBox></td>
        <td style="width: 269px; height: 4px">
            <asp:Button ID="CmdXem" runat="server" CssClass="ntp_button" TabIndex="5" Text="Xem"
                        Width="81px" />
            <asp:TextBox ID="txtId_KetQuaDT4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="116" Width="81px" Visible="False"></asp:TextBox></td>
    </tr>
</table>
    <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="#C00000"
        Text="Phần 1: Kết quả điều trị" Width="322px"></asp:Label></asp:Panel>
      <asp:Label ID="Label105" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Phần 1: Kết quả điều trị"
          Width="322px" ForeColor="#C00000"></asp:Label><br />
<fieldset class="ntp_fieldset" style="width: 75%">
      <table border="1" style="width: 739px" >
          <tr>
              <td style="width: 187px; height: 21px" align="center">
                  <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Loại bệnh nhân"
                      Width="113px"></asp:Label></td>
              <td align="center" style="width: 90px; height: 21px">
                  <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Font-Bold="True" Text="TSBN đăng ký trong quý"
                      Width="64px"></asp:Label></td>
              <td style="width: 78px; height: 21px" align="center">
                  <asp:Label ID="Label25" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Khỏi"
                      Width="55px"></asp:Label></td>
              <td style="width: 89px; height: 21px" align="center">
                  <asp:Label ID="Label26" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Hoàn thành" Width="56px"></asp:Label></td>
              <td style="width: 27px; height: 21px" align="center">
                  <asp:Label ID="Label33" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Chết"
                      Width="58px"></asp:Label></td>
              <td style="width: 27px; height: 21px" align="center">
                  <asp:Label ID="Label39" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Thất bại"
                      Width="64px"></asp:Label></td>
              <td style="width: 89px; height: 21px" align="center">
                  <asp:Label ID="Label31" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Bỏ"
                      Width="59px"></asp:Label></td>
              <td style="width: 27px; height: 21px" align="center">
                  <asp:Label ID="Label27" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Chuyển"
                      Width="62px"></asp:Label></td>
              <td style="width: 93px; height: 21px" align="center">
                  <asp:Label ID="Label32" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Không đánh giá"
                      Width="64px"></asp:Label></td>
              <td align="center" style="width: 93px; height: 21px">
                  <asp:Label ID="Tong" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Tổng"
                      Width="62px"></asp:Label></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px;">
                  <asp:Label ID="Label7" runat="server" Text="Lao phổi AFB(+) mới" Width="112px"></asp:Label></td>
              <td style="width: 90px">
                  <asp:TextBox ID="TxtTONGBNDK" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" MaxLength="50" TabIndex="8" Width="70px" Enabled="False" BackColor="White" Font-Bold="True" ></asp:TextBox></td>
              <td style="width: 78px">
                     <asp:TextBox ID="txtKhoi" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="7" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtKhoi"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                      <asp:TextBox ID="txtHoanThanh" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="txtHoanThanh"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                      <asp:TextBox ID="txtChet" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="9" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator12" runat="server" ControlToValidate="txtChet"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                      <asp:TextBox ID="txtThatBai" runat="server" CssClass="ntp_textbox" MaxLength="50"
                          TabIndex="10" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtThatBai"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="42px"></asp:RangeValidator></td>
              <td style="width: 89px">
                     <asp:TextBox ID="txtBo" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="txtBo"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="34px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtChuyen" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtChuyen"
                           ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px">
                      <asp:TextBox ID="txtKhongDanhGia" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="13" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="txtKhongDanhGia"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="41px"></asp:RangeValidator></td>
              <td style="width: 93px">
                  <asp:TextBox ID="TxtTong" runat="server" BorderColor="White" BorderStyle="None" CssClass="ntp_textbox"
                      Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label8" runat="server" Text="Lao phổi AFB(+) tái phát" Width="112px"></asp:Label></td>
              <td style="width: 90px; height: 36px">
                  <asp:TextBox ID="TxtTONGBNDK1" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="70px"
                      Wrap="False" BackColor="White" Font-Bold="True"></asp:TextBox></td>
              <td style="width: 78px; height: 36px">
                  <asp:TextBox ID="TxtKhoi1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="14"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator7" runat="server"
                          ControlToValidate="TxtKhoi1" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px; height: 36px">
                  <asp:TextBox ID="TxtHoanThanh1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="15"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator18" runat="server"
                          ControlToValidate="TxtHoanThanh1" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer"></asp:RangeValidator></td>
              <td style="height: 36px">
                  <asp:TextBox ID="TxtChet1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="16"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator26" runat="server"
                          ControlToValidate="TxtChet1" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer"></asp:RangeValidator></td>
              <td style="height: 36px">
                  <asp:TextBox ID="TxtThatbai1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="17"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator33" runat="server"
                          ControlToValidate="txtThatBai1" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer"></asp:RangeValidator></td>
              <td style="height: 36px; width: 89px;">
                  <asp:TextBox ID="TxtBo1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="18"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator40" runat="server"
                          ControlToValidate="txtBo1" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="36px"></asp:RangeValidator></td>
              <td style="height: 36px">
                  <asp:TextBox ID="TxtChuyen1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="19"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator47" runat="server"
                          ControlToValidate="txtChuyen1" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px; height: 36px">
                  <asp:TextBox ID="TxtKhongDanhGia1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="20"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator54" runat="server"
                          ControlToValidate="txtKhongDanhGia1" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="42px"></asp:RangeValidator></td>
              <td style="width: 93px; height: 36px">
                  <asp:TextBox ID="TxtTong1" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label9" runat="server" Text="Lao phổi AFB(+) thất bại" Width="112px"></asp:Label></td>
              <td style="width: 90px">
                  <asp:TextBox ID="TxtTONGBNDK2" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="70px"
                      Wrap="False" BackColor="White" Font-Bold="True"></asp:TextBox></td>
              <td style="width: 78px;">
                  <asp:TextBox ID="txtKhoi2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="21"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator10" runat="server"
                          ControlToValidate="txtKhoi2" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="70px"></asp:RangeValidator></td>
              <td style="width: 89px;">
                  <asp:TextBox ID="TxtHoanThanh2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="22" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator19"
                          runat="server" ControlToValidate="TxtHoanThanh2" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer" Width="53px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="TxtChet2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="23"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator27" runat="server" ControlToValidate="TxtChet2"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtThatBai2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="24" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator34"
                          runat="server" ControlToValidate="txtThatBai2" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                  <asp:TextBox ID="txtBo2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="25"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator41" runat="server"
                          ControlToValidate="txtBo2" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="36px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtChuyen2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="26" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator48"
                          runat="server" ControlToValidate="txtChuyen2" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px;">
                  <asp:TextBox ID="txtKhongDanhGia2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="27" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator55"
                          runat="server" ControlToValidate="txtKhongDanhGia2" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer" Width="47px"></asp:RangeValidator></td>
              <td style="width: 93px">
                  <asp:TextBox ID="TxtTong2" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label10" runat="server" Text="Lao phổi AFB(+) ĐT lại sau bỏ trị" Width="112px"></asp:Label></td>
              <td style="width: 90px">
                  <asp:TextBox ID="TxtTONGBNDK3" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="70px"
                      Wrap="False" BackColor="White" Font-Bold="True"></asp:TextBox></td>
              <td style="width: 78px;">
                  <asp:TextBox ID="txtKhoi3" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="28"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator13" runat="server"
                          ControlToValidate="txtKhoi3" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="49px"></asp:RangeValidator></td>
              <td style="width: 89px;">
                  <asp:TextBox ID="TxtHoanThanh3" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="29" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator20"
                          runat="server" ControlToValidate="TxtHoanThanh3" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="TxtChet3" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="30"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator28" runat="server" ControlToValidate="TxtChet3"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="58px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtThatBai3" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="31" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator35"
                          runat="server" ControlToValidate="txtThatBai3" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                  <asp:TextBox ID="txtBo3" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="32"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator42" runat="server"
                          ControlToValidate="txtBo3" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="39px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtChuyen3" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="33" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator49"
                          runat="server" ControlToValidate="txtChuyen3" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px;">
                  <asp:TextBox ID="txtKhongDanhGia3" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="34" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator56"
                          runat="server" ControlToValidate="txtKhongDanhGia3" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer" Width="44px"></asp:RangeValidator></td>
              <td style="width: 93px">
                  <asp:TextBox ID="TxtTong3" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label11" runat="server" Text="AFB(+) khác" Width="108px"></asp:Label></td>
              <td style="width: 90px">
                  <asp:TextBox ID="TxtTONGBNDK4" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="70px"
                      Wrap="False" BackColor="White" Font-Bold="True"></asp:TextBox></td>
              <td style="width: 78px;">
                  <asp:TextBox ID="txtKhoi4" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="35"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator14" runat="server"
                          ControlToValidate="txtKhoi4" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px;">
                  <asp:TextBox ID="TxtHoanThanh4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="36" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator21"
                          runat="server" ControlToValidate="TxtHoanThanh4" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="TxtChet4" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="37"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator29" runat="server" ControlToValidate="TxtChet4"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtThatBai4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="38" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator36"
                          runat="server" ControlToValidate="txtThatBai4" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                  <asp:TextBox ID="txtBo4" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="39"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator43" runat="server"
                          ControlToValidate="txtBo4" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="37px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtChuyen4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="40" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator50"
                          runat="server" ControlToValidate="txtChuyen4" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px;">
                  <asp:TextBox ID="txtKhongDanhGia4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="41" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator57"
                          runat="server" ControlToValidate="txtKhongDanhGia4" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer" Width="44px"></asp:RangeValidator></td>
              <td style="width: 93px">
                  <asp:TextBox ID="TxtTong4" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label12" runat="server" Text="Lao phổi AFB(-) mới" Width="110px"></asp:Label></td>
              <td style="width: 90px">
                  <asp:TextBox ID="TxtTONGBNDK5" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="70px"
                      Wrap="False" BackColor="White" Font-Bold="True"></asp:TextBox></td>
              <td style="width: 78px;">
                  </td>
              <td style="width: 89px;">
                  <asp:TextBox ID="TxtHoanThanh5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="42" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator23"
                          runat="server" ControlToValidate="TxtHoanThanh5" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="TxtChet5" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="43"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator30" runat="server" ControlToValidate="TxtChet5"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtThatBai5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="44" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator37"
                          runat="server" ControlToValidate="txtThatBai5" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                  <asp:TextBox ID="txtBo5" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="45"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator44" runat="server"
                          ControlToValidate="txtBo5" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="38px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtChuyen5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="46" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator51"
                          runat="server" ControlToValidate="txtChuyen5" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px;">
                  <asp:TextBox ID="txtKhongDanhGia5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="47" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator58"
                          runat="server" ControlToValidate="txtKhongDanhGia5" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer" Width="44px"></asp:RangeValidator></td>
              <td style="width: 93px">
                  <asp:TextBox ID="TxtTong5" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label13" runat="server" Text="Lao ngoài phổi mới" Width="113px"></asp:Label></td>
              <td style="width: 90px">
                  <asp:TextBox ID="TxtTONGBNDK6" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="70px"
                      Wrap="False" BackColor="White" Font-Bold="True"></asp:TextBox></td>
              <td style="width: 78px;">
                  </td>
              <td style="width: 89px;">
                  <asp:TextBox ID="TxtHoanThanh6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="48" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator24"
                          runat="server" ControlToValidate="TxtHoanThanh6" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="TxtChet6" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="49"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator31" runat="server" ControlToValidate="TxtChet6"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtThatBai6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="50" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator38"
                          runat="server" ControlToValidate="txtThatBai6" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                  <asp:TextBox ID="txtBo6" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="51"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator45" runat="server"
                          ControlToValidate="txtBo6" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="39px"></asp:RangeValidator></td>
              <td>
                  <asp:TextBox ID="txtChuyen6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="52" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator52"
                          runat="server" ControlToValidate="txtChuyen6" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px;">
                  <asp:TextBox ID="txtKhongDanhGia6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="53" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator59"
                          runat="server" ControlToValidate="txtKhongDanhGia6" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer" Width="43px"></asp:RangeValidator></td>
              <td style="width: 93px">
                  <asp:TextBox ID="TxtTong6" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label14" runat="server" Text="AFB(-), lao ngoài phổi khác" Width="114px"></asp:Label></td>
              <td style="width: 90px; height: 36px">
                  <asp:TextBox ID="TxtTONGBNDK7" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="70px"
                      Wrap="False" BackColor="White" Font-Bold="True"></asp:TextBox></td>
              <td style="width: 78px; height: 36px;">
                  </td>
              <td style="width: 89px; height: 36px;">
                  <asp:TextBox ID="TxtHoanThanh7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="54" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator25"
                          runat="server" ControlToValidate="TxtHoanThanh7" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 36px">
                  <asp:TextBox ID="TxtChet7" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="55"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator32" runat="server" ControlToValidate="TxtChet7"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 36px">
                  <asp:TextBox ID="txtThatBai7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="56" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator39"
                          runat="server" ControlToValidate="txtThatBai7" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="height: 36px; width: 89px;">
                  <asp:TextBox ID="txtBo7" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="57"
                      Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator46" runat="server"
                          ControlToValidate="txtBo7" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                          Type="Integer" Width="44px"></asp:RangeValidator></td>
              <td style="height: 36px">
                  <asp:TextBox ID="txtChuyen7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="58" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator53"
                          runat="server" ControlToValidate="txtChuyen7" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 93px; height: 36px;">
                  <asp:TextBox ID="txtKhongDanhGia7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="59" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator60"
                          runat="server" ControlToValidate="txtKhongDanhGia7" ErrorMessage="Là số" MaximumValue="9999"
                          MinimumValue="0" Type="Integer" Width="43px"></asp:RangeValidator></td>
              <td style="width: 93px; height: 36px">
                  <asp:TextBox ID="TxtTong7" runat="server" BorderColor="White" BorderStyle="None"
                      CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="8" Width="61px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 187px; height: 36px">
                  <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Tổng cộng"
                      Width="98px"></asp:Label></td>
              <td style="width: 90px; height: 36px">
                  <asp:Label ID="LblTongcongBNDK" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="width: 78px; height: 36px">
                  <asp:Label ID="LblTongcongKhoi" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="width: 89px; height: 36px">
                  <asp:Label ID="LblTongcongHT" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="height: 36px">
                  <asp:Label ID="LblTongcongChet" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="height: 36px">
                  <asp:Label ID="LblTongcongThatbai" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="width: 89px; height: 36px">
                  <asp:Label ID="LblTongcongBo" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="height: 36px">
                  <asp:Label ID="LblTongcongChuyen" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="width: 93px; height: 36px">
                  <asp:Label ID="LblTongcongKdanhgia" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
              <td style="width: 93px; height: 36px">
                  <asp:Label ID="LblTongcong" runat="server" CssClass="ntp_label" Font-Bold="True" Text="0"
                      Width="62px"></asp:Label></td>
          </tr>
      </table>
     <br />
     <asp:Label ID="Label16" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Phần 2: Kết quả điều trị BN Lao/HIV"
         Width="322px" ForeColor="#C00000"></asp:Label><br />
     <table style="width: 794px" border="1">
         <tr>
             <td style="width: 160px; height: 21px" align="center">
                 <asp:Label ID="Label113" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Loại bệnh nhân"
                     Width="129px"></asp:Label></td>
             <td align="center" style="width: 86px; height: 21px">
                 <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Font-Bold="True" Text="TSBN Lao đăng ký trong quý có HIV(+)"
                     Width="97px"></asp:Label></td>
             <td style="width: 83px; height: 21px" align="center">
                 <asp:Label ID="Label125" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Khỏi"
                     Width="75px"></asp:Label></td>
             <td style="width: 89px; height: 21px" align="center">
                 <asp:Label ID="Label126" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Hoàn thành" Width="72px"></asp:Label></td>
             <td style="width: 104px; height: 21px" align="center">
                 <asp:Label ID="Label133" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Chết"
                     Width="64px"></asp:Label></td>
             <td style="width: 27px; height: 21px" align="center">
                 <asp:Label ID="Label139" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Thất bại"
                     Width="64px"></asp:Label></td>
             <td style="width: 27px; height: 21px" align="center">
                 <asp:Label ID="Label131" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Bỏ"
                     Width="64px"></asp:Label></td>
             <td style="width: 27px; height: 21px" align="center">
                 <asp:Label ID="Label127" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Chuyển"
                     Width="64px"></asp:Label></td>
             <td style="width: 93px; height: 21px" align="center">
                 <asp:Label ID="Label132" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Không đánh giá"
                     Width="64px"></asp:Label></td>
         </tr>
         <tr>
             <td style="width: 160px; height: 47px;">
                 <asp:Label ID="Label17" runat="server" Text="TS Bệnh nhân Lao/HIV các thể" Width="133px"></asp:Label></td>
             <td style="width: 86px; height: 47px">
                 <asp:TextBox ID="TxtTONGBNDK8" runat="server" BorderColor="White" BorderStyle="None"
                     CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="60" Width="63px"></asp:TextBox>
                 </td>
             <td style="width: 83px; height: 47px;">
                 <asp:TextBox ID="txtKhoi8" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="60"
                     Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="txtKhoi8"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="width: 89px; height: 47px;">
                 <asp:TextBox ID="TxtHoanThanh8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="61" Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator62" runat="server" ControlToValidate="TxtHoanThanh8"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="width: 104px; height: 47px;">
                 <asp:TextBox ID="TxtChet8" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="62"
                     Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator64" runat="server" ControlToValidate="TxtChet8"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="height: 47px;">
                 <asp:TextBox ID="txtThatBai8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="63" Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator66" runat="server" ControlToValidate="txtThatBai8"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="height: 47px;">
                 <asp:TextBox ID="txtBo8" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="64"
                     Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator68" runat="server" ControlToValidate="txtBo8"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="height: 47px;">
                 <asp:TextBox ID="txtChuyen8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="65" Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator70" runat="server" ControlToValidate="txtChuyen8"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="width: 93px; height: 47px;">
                 <asp:TextBox ID="txtKhongDanhGia8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="66" Width="76px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator73" runat="server" ControlToValidate="txtKhongDanhGia8"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="39px"></asp:RangeValidator></td>
         </tr>
         <tr>
             <td style="width: 160px; height: 36px">
                 <asp:Label ID="Label118" runat="server" Text="Lao phổi AFB(+) mới" Width="133px"></asp:Label></td>
             <td style="width: 86px">
                 <asp:TextBox ID="TxtTONGBNDK9" runat="server" BorderColor="White" BorderStyle="None"
                     CssClass="ntp_textbox" Enabled="False" MaxLength="50" TabIndex="67" Width="68px"></asp:TextBox>
                 </td>
             <td style="width: 83px;">
                 <asp:TextBox ID="txtKhoi9" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="67"
                     Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator61" runat="server" ControlToValidate="txtKhoi9"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="width: 89px;">
                 <asp:TextBox ID="TxtHoanThanh9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="68" Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator63" runat="server" ControlToValidate="txtHoanThanh9"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="width: 104px;">
                 <asp:TextBox ID="TxtChet9" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="69"
                     Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator65" runat="server" ControlToValidate="TxtChet9"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td>
                 <asp:TextBox ID="txtThatBai9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="70" Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator67" runat="server" ControlToValidate="txtThatBai9"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td>
                 <asp:TextBox ID="txtBo9" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="71"
                     Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator69" runat="server" ControlToValidate="txtBo9"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td>
                 <asp:TextBox ID="txtChuyen9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="72" Width="63px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator72" runat="server" ControlToValidate="txtChuyen9"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="width: 93px;">
                 <asp:TextBox ID="txtKhongDanhGia9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="73" Width="77px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator74" runat="server" ControlToValidate="txtKhongDanhGia9"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="41px"></asp:RangeValidator></td>
         </tr>
     </table>
     <br />
     &nbsp;<asp:Label ID="Label117" runat="server" CssClass="ntp_label" Font-Bold="True"
         Text="Phần 3: Báo cáo hoạt động phối hợp Lao/HIV" Width="322px" ForeColor="#C00000"></asp:Label>
     <table style="width: 796px" border="1">
         <tr>
             <td style="width: 162px; height: 21px" align="center">
                 <asp:Label ID="Label28" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Loại bệnh nhân"
                     Width="172px"></asp:Label></td>
             <td style="width: 133px; height: 21px" align="center">
                 <asp:Label ID="Label29" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số BN lao XN HIV"
                     Width="92px"></asp:Label></td>
             <td style="width: 27px; height: 21px" align="center">
                 <asp:Label ID="Label34" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số BN lao XN HIV(+)"
                     Width="118px"></asp:Label></td>
             <td style="width: 27px; height: 21px" align="center">
                 <asp:Label ID="Label35" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số BN được điều trị CPT"
                     Width="125px"></asp:Label></td>
             <td style="width: 150px; height: 21px" align="center">
                 <asp:Label ID="Label41" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số BN được điều trị ARV"
                     Width="145px"></asp:Label></td>
         </tr>
         <tr>
             <td style="width: 162px; height: 36px;">
                 <asp:Label ID="Label45" runat="server" Text="Tổng số BN lao" Width="130px"></asp:Label>
                 <asp:TextBox ID="txtId_LaoHIV" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="131" Width="36px" Visible="False"></asp:TextBox></td>
             <td style="width: 133px">
                    <asp:TextBox ID="txtLaoHIV" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="74" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator71" runat="server" ControlToValidate="txtLaoHIV"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td>
                    <asp:TextBox ID="txtLaoHIVD" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="75" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator101" runat="server" ControlToValidate="txtLaoHIVD"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td>
             <asp:TextBox ID="txtDieuTriCPT" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="76" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator131" runat="server"
                     ControlToValidate="txtDieuTriCPT" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                     Type="Integer"></asp:RangeValidator></td>
             <td style="width: 150px">
             <asp:TextBox ID="txtDieuTriARV" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="77" Width="109px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator1" runat="server"
                     ControlToValidate="txtDieuTriARV" ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0"
                     Type="Integer"></asp:RangeValidator></td>
         </tr>
         <tr>
             <td style="width: 162px; height: 36px">
                 <asp:Label ID="Label46" runat="server" Text="Lao phổi AFB(+) mới" Width="150px"></asp:Label>
                 <asp:TextBox ID="txtId_LaoHIV1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="131"
                     Width="37px" Visible="False"></asp:TextBox></td>
             <td style="width: 133px;">
                 <asp:TextBox ID="txtLaoHIV1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="78" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator75" runat="server" ControlToValidate="txtLaoHIV1"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td>
                 <asp:TextBox ID="txtLaoHIVD1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="79" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator76" runat="server" ControlToValidate="txtLaoHIVD1"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td>
                 <asp:TextBox ID="txtDieuTriCPT1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="80" Width="77px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator77" runat="server" ControlToValidate="txtDieuTriCPT1"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
             <td style="width: 150px">
                 <asp:TextBox ID="txtDieuTriARV1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                     TabIndex="81" Width="107px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                 <asp:RangeValidator ID="RangeValidator78" runat="server" ControlToValidate="txtDieuTriARV1"
                     ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
         </tr>
     </table>
     <br />
     &nbsp;&nbsp;
<asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="82" Text="Ghi"
                        Width="100px" /><asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False"
                            CssClass="ntp_button" TabIndex="83" Text="Tạo mới" Width="100px" /><asp:Button
                                ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                                Text="Thoát" Width="100px" TabIndex="84" /></fieldset> &nbsp; &nbsp;
&nbsp;&nbsp;&nbsp;<br />
<script language="javascript" type="text/javascript">
var oldValue = 0; // it will save our old values

function getValue( v ) {
if(v.value == '')
v.value = oldValue;
}

</script>

