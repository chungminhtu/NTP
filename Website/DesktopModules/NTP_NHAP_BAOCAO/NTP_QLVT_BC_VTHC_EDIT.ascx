<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_BC_VTHC_EDIT.ascx.vb" Inherits="NTP_QLVT_BC_VTHC_EDIT" %>
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

    // hoa chat
    $('input[id^=<%=TON_DAU.ClientID %>]').bind('keyup',recalcHC);
    $('input[id^=<%=NHAP.ClientID %>]').bind('keyup',recalcHC);
    $('input[id^=<%=XUAT.ClientID %>]').bind('keyup',recalcHC);
    $('input[id^=<%=THUA.ClientID %>]').bind('keyup',recalcHC);
    $('input[id^=<%=THIEU_HONG.ClientID %>]').bind('keyup',recalcHC);
    
    //vat tu
    $('input[id^=<%=TD_TINH.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id^=<%=N_TW.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id^=<%=X_TOANTINH.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id^=<%=THUA_TINH.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id^=<%=THIEU_TINH.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id^=<%=TRA_LAI_TINH.ClientID %>]').bind('keyup',recalcVT_TINH);
    $('input[id^=<%=HONG_TINH.ClientID %>]').bind('keyup',recalcVT_TINH);
    
    $('input[id^=<%=TD_HUYEN.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id^=<%=N_TINHCAP.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id^=<%=X_HUYEN.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id^=<%=THUA_HUYEN.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id^=<%=THIEU_HUYEN.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id^=<%=TRA_LAI_HUYEN.ClientID %>]').bind('keyup',recalcVT_HUYEN);
    $('input[id=<%=DIEU_CHUYEN.ClientID %>]').bind('keyup',recalcVT_HUYEN);
});

}

function recalcHC(){
    $('input[id^=<%=TON_CUOI.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 + s4 - s3 - s5',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=TON_DAU.ClientID %>]'),
				s2: $('input[id^=<%=NHAP.ClientID %>]'),
				s3: $('input[id^=<%=XUAT.ClientID %>]'),
				s4: $('input[id^=<%=THUA.ClientID %>]'),
				s5: $('input[id^=<%=THIEU_HONG.ClientID %>]')
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
$('input[id^=<%=TC_TINH.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s4 + s0 - s3 - s5 -s6",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=TD_TINH.ClientID %>]'),
				s2: $('input[id^=<%=N_TW.ClientID %>]'),
				s3: $('input[id^=<%=X_TOANTINH.ClientID %>]'),
				s4: $('input[id^=<%=THUA_TINH.ClientID %>]'),
				s5: $('input[id^=<%=THIEU_TINH.ClientID %>]'),
				s0: $('input[id=<%=TRA_LAI_TINH.ClientID %>]'),
				s6: $('input[id^=<%=HONG_TINH.ClientID %>]')
				
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
$('input[id^=<%=TC_HUYEN.ClientID %>]').calc(
			// the equation to use for the calculation
			"s1 + s2 + s4 + s0 - s3 - s5 - s6",
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id^=<%=TD_HUYEN.ClientID %>]'),
				s2: $('input[id^=<%=N_TINHCAP.ClientID %>]'),
				s3: $('input[id^=<%=X_HUYEN.ClientID %>]'),
				s4: $('input[id^=<%=THUA_HUYEN.ClientID %>]'),
				s5: $('input[id^=<%=THIEU_HUYEN.ClientID %>]'),
				s0: $('input[id^=<%=TRA_LAI_HUYEN.ClientID %>]'),
				s6: $('input[id^=<%=DIEU_CHUYEN.ClientID %>]')
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

<asp:Panel ID="pnlAll" runat=server Width="100%">
<fieldset class="ntp_fieldset">
    <legend class="ntp_legend">Thông tin chung báo cáo</legend>
 <table  class = "ntp_table_main">
     <tr>
         <td width="15%">
         </td>
         <td width="35%">
         </td>
         <td>
         </td>
         <td>
         </td>
     </tr>
     <tr>
         <td width="15%" style="height: 25px">
             <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Quý"></asp:Label></td>
         <td width="35%" style="height: 25px"><asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="1" Width="100%">
             <asp:ListItem Value="đầu năm">6 th&#225;ng đầu năm</asp:ListItem>
             <asp:ListItem Value="cuối năm">6 th&#225;ng cuối năm</asp:ListItem>
         </asp:DropDownList></td>
         <td style="width: 15%; height: 25px;">
             <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Năm</asp:Label></td>
          <td style="width: 35%; height: 25px;">
              
              <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="2" Width="64px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNam"
                  Display="Dynamic" ErrorMessage="Bạn phải nhập năm" SetFocusOnError="True"></asp:RequiredFieldValidator>
              <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNam"
                  Display="Dynamic" ErrorMessage="Bạn phải nhập số" MaximumValue="9999" MinimumValue="0"
                  SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
     </tr>
        <tr display="Static">
            <td width="15%">
            </td>
            <td width="35%"  colspan=3>
                <asp:Button ID="cmdAdd" runat="server" Text="Ghi lại" CssClass="ntp_button" Width="100px" TabIndex="3" />&nbsp;
            <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="ntp_button" Width="100px" />
                <asp:TextBox ID="txtID_BAOCAO" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
        </tr>
       
    </table>
    </fieldset>
</asp:Panel>       
<asp:Panel ID="pnlDetail" runat="server" Width="100%" Visible="False">
<fieldset class="ntp_fieldset">
    <legend class="ntp_legend">Thông tin chi tiết báo cáo chọn vật tư hoặc hóa chất</legend><br />
    <asp:Menu
        ID="Menu1"
        Width="150px"
        runat="server"
        Orientation="Horizontal"
        StaticEnableDefaultPopOutImage="False"
        OnMenuItemClick="Menu1_MenuItemClick" Height="40px" >
    <Items>
        <asp:MenuItem 
                      Text="Vật tư" Value="0"  ></asp:MenuItem>
        <asp:MenuItem  
                      Text="H&#243;a chất" Value="1"></asp:MenuItem>
    </Items>
        <StaticSelectedStyle CssClass="ntp_tab_selected" />
        <DynamicSelectedStyle BackColor="MediumAquamarine" BorderColor="Red" />
</asp:Menu>
    <asp:Panel ID="pnlHC" runat="server" Width="100%" Visible="True">
    <table  class = "ntp_table_main" width = 100% >
    <tr>
        <td colspan="2" width="100%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_comment" Text="Chú ý: <br>Số lượng tồn cuối sẽ tự tính theo công thức : tồn cuối = (tồn đầu + nhập + thừa) - (xuất + thiếu/hỏng)"></asp:Label></td>
    </tr>
        <tr>
            <td width="25%">
                <asp:Label ID="Label32" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
            <td width="75%">
                <asp:DropDownList ID="cboNGUONKP_HC" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                  DataValueField="ID_NGUONKINHPHI" TabIndex="3" Width="100%" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
     <tr>
        <td width=25%>
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Hóa chất"></asp:Label>
            <asp:TextBox ID="txtID_CHITIET_HC" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="1" Visible="False" Width="20px"></asp:TextBox></td>
         <td width="75%">
         <asp:DropDownList ID="cboHC" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VATTU"
                  DataValueField="ID_VATTU" TabIndex="4" Width="100%">
        </asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2" rowspan="1" width="100%">
            <table border=1px width = 100%>
                <tr>
                    <td width=10%>
                        <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tồn đầu"></asp:Label></td>
                    <td style="width: 10%">
                        <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Nhập"></asp:Label></td>
                    <td style="width: 10%">
                        <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Xuất"></asp:Label></td>
                    <td  width=10%>
                        <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Thừa"></asp:Label></td>
                    <td  width=10%>
                        <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Thiếu hỏng"></asp:Label></td>
                    <td  width=10%>
                        <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Tồn cuối"></asp:Label></td>
                    <td width="10%">
                        <asp:Label ID="Label34" runat="server" CssClass="ntp_label" Text="Lô SX"></asp:Label></td>
                    <td  width=10%>
                         <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Hạn sử dụng"></asp:Label></td>
                    <td  width=10%>
                        <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Ghi chú"></asp:Label></td>
                </tr>
                <tr>
                    <td with=10% style="height: 26px">
                        <asp:TextBox ID="TON_DAU" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="5"
                            Width="64px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TON_DAU"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Double"></asp:RangeValidator></td>
                    <td style="width: 10%; height: 26px" >
                        <asp:TextBox ID="NHAP" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6"
                            Width="64px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="NHAP"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                            Type="Double"></asp:RangeValidator></td>
                    <td style="width: 10%; height: 26px" >
                        <asp:TextBox ID="XUAT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="7"
                            Width="64px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="XUAT"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                            Type="Double"></asp:RangeValidator></td>
                    <td  width=10% style="height: 26px" >
                        <asp:TextBox ID="THUA" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8"
                            Width="64px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="THUA"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                            Type="Double"></asp:RangeValidator></td>
                    <td  width=10% style="height: 26px" >
                        <asp:TextBox ID="THIEU_HONG" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="9" Width="64px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="THIEU_HONG"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                            Type="Double"></asp:RangeValidator></td>
                    <td  width=10% style="height: 26px" >
                        <asp:TextBox ID="TON_CUOI" runat="server" CssClass="ntp_textbox" MaxLength="50" ReadOnly="False"
                            TabIndex="10" Width="64px" Enabled =  "false" ></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="TON_CUOI"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                            Type="Double"></asp:RangeValidator></td>
                    <td style="height: 26px" width="10%">
                        &nbsp;<asp:TextBox ID="LO_SX" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            ReadOnly="False" TabIndex="10" Width="64px"></asp:TextBox>
                        <!-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="LO_SX"
                            ErrorMessage="Nhập lô SX"></asp:RequiredFieldValidator> -->
</td>
                    <td  width=10% style="height: 26px" >
                        <asp:TextBox ID="HAN_DUNG" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11"
                            Width="104px"></asp:TextBox>&nbsp;
                        <ajaxToolkit:MaskedEditExtender ID="Maskededitextender2" runat="server" AutoComplete="true"
                            CultureName="vi-VN" Mask="99/99/9999" MaskType="Date" PromptCharacter="_" TargetControlID="HAN_DUNG">
                        </ajaxToolkit:MaskedEditExtender>
                        <ajaxToolkit:MaskedEditValidator ID="Maskededitvalidator2" runat="server" ControlExtender="Maskededitextender2"
                            ControlToValidate="HAN_DUNG" Display="Dynamic"
                            InvalidValueMessage="Định dạng ngày không đúng" IsValidEmpty="False" MaximumValue="31/12/9999"
                            MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                            MinimumValue=" 1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                            SetFocusOnError="True" TooltipMessage="Nhập ngày"></ajaxToolkit:MaskedEditValidator></td>
                    <td  width=10% style="height: 26px" >
                        <asp:TextBox ID="GHI_CHU" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12"
                            Width="100%"></asp:TextBox></td>
                </tr>
                
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="2" rowspan="1">
            <asp:Button ID="cmdSaveHC" runat="server" Text="Ghi chi tiết" CssClass="ntp_button" Width="100px" TabIndex="13" />
            <asp:Button ID="cmdDelHC" runat="server" Text="Xóa chi tiết" CssClass="ntp_button" Width="100px" CausesValidation="False" />
            <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server"
    TargetControlID="cmdDelHC"
    ConfirmText="Bạn thực sự muốn xóa dữ liệu này?"
     />
        </td>
    </tr>
    <tr>
        <td colspan="2" rowspan="1">
            <cc3:MultiSelectGrid ID="grdDS_HC" runat="server" AutoGenerateColumns="False" ShowFooter="True" Width="100%"
                    CssClass="ntp_grd_GridViewStyle"
                    HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                    AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                    EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                    ItemStyle-CssClass = "ntp_grd_RowStyle"
                    PagerStyle-CssClass = "ntp_grd_PagerStyle"
                    HighlightCssClass="ntp_grd_SelectedRowStyle"
                    >
                <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                <PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle" />
                <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                <ItemStyle CssClass="ntp_grd_RowStyle" />
                <Columns>
                    <asp:TemplateColumn>
                        <headerstyle width="2%"  />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn>
                        <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_CHITIET" HeaderText="ID_CHITIET" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_VATTU" HeaderText="ID_VATTU" Visible="False">
                        <headerstyle width="0%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_VATTU" HeaderText="T&#234;n vật tư">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TON_DAU" HeaderText="Tồn đầu">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="NHAP" HeaderText="Nhập">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="XUAT" HeaderText="Xuất">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn HeaderText="Thừa" DataField="THUA">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="THIEU_HONG" HeaderText="Thiếu hỏng">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TON_CUOI" HeaderText="Tồn cuối">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="HAN_SUDUNG" HeaderText="Hạn d&#249;ng" DataFormatString="{0:dd/MM/yyyy}">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="GHI_CHU" HeaderText="Ghi ch&#250;">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
            </cc3:MultiSelectGrid>
            </td>
    </tr>
      
</table>
    </asp:Panel>
    <asp:Panel ID="pnlVT" runat="server" Width="100%" Visible="true">
        <table  class = "ntp_table_main" width = 100% >
            <tr>
                <td colspan="2" width="25%">
                    <asp:Label ID="Label19" runat="server" CssClass="ntp_comment" Text="Chú ý: <br>Số lượng tồn cuối sẽ tự tính theo công thức : tồn cuối = (tồn đầu + nhập + thừa) - (xuất + thiếu/hỏng)"></asp:Label></td>
            </tr>
            <tr>
                <td width="25%">
                    <asp:Label ID="Label33" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
                <td width="75%">
                    <asp:DropDownList ID="cboNGUONKP_VT" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                  DataValueField="ID_NGUONKINHPHI" TabIndex="3" Width="100%" AutoPostBack="True">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td width="25%">
                    <asp:Label ID="Label35" runat="server" CssClass="ntp_label" Text="Đơn vị"></asp:Label></td>
                <td width="75%">
                    <asp:DropDownList ID="cboHuyen" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                        DataTextField="TEN_BENHVIEN" DataValueField="ID_BENHVIEN" TabIndex="2" Width="100%">
                    </asp:DropDownList></td>
            </tr>
                <tr>
                    <td width="25%">
                        <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Vật tư"></asp:Label>
                        <asp:TextBox ID="txtID_CHITIET_VT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"
                            Visible="False" Width="20px"></asp:TextBox></td>
                    <td width="75%"><asp:DropDownList ID="cboVATTU" runat="server" CssClass="ntp_combobox" DataTextField="TEN_VATTU"
                  DataValueField="ID_VATTU" TabIndex="15" Width="100%">
                    </asp:DropDownList></td>                   
                </tr>
            <tr>
                <td width="100%" colspan="2">
                    <asp:Panel ID="pnlVT_Tinh" runat="server" Width="100%">
                        <table class="ntp_table_withborder"  border = 1 width="100%" cellpadding=1 cellspacing = 0>
                            <tr >
                                <td align="center" style="width: 8%; height: 23px" rowspan="2" >
                                    <asp:Label ID="Label26" runat="server" CssClass="ntp_label" Text="Tồn đầu kỳ"></asp:Label></td>
                                <td align="center" colspan="3" width="8%" style="height: 23px">
                                    <asp:Label ID="Label27" runat="server" CssClass="ntp_label" Text="Nhập"></asp:Label></td>
                                <td align="center" colspan="3" width="8%" style="height: 23px">
                                    <asp:Label ID="Label28" runat="server" CssClass="ntp_label" Text="Xuất"></asp:Label></td>
                                <td align="center" width="8%" style="height: 23px" rowspan="2">
                                    <asp:Label ID="Label31" runat="server" CssClass="ntp_label" Text="Tồn cuối kỳ"></asp:Label></td>
                                <td align="center" width="8%" style="height: 23px">
                                    </td>
                            </tr>
                            <tr>
                                <td style="width: 8%" align="center">
                                    <asp:Label ID="Label16" runat="server" CssClass="ntp_label" Text="TW cấp"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label48" runat="server" CssClass="ntp_label" Text="Trả lại"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Thừa"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label18" runat="server" CssClass="ntp_label" Text="Toàn tỉnh"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="lblX_SUDUNG" runat="server" CssClass="ntp_label" Text="Thiếu"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label20" runat="server" CssClass="ntp_label" Text="Hỏng vỡ"></asp:Label></td>
                                <td width="8%">
                                    </td>
                            </tr>
                            <tr>
                                <td style="width: 8%;">
                                    <asp:TextBox ID="TD_TINH" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="16"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="TD_TINH"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td style=" width: 8%;">
                                    <asp:TextBox ID="N_TW" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="18"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator10" runat="server" ControlToValidate="N_TW"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="TRA_LAI_TINH" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="20" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator18" runat="server" ControlToValidate="TRA_LAI_TINH"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="THUA_TINH" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="22" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator14" runat="server" ControlToValidate="THUA_TINH"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="X_TOANTINH" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="24" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator12" runat="server" ControlToValidate="X_TOANTINH"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="THIEU_TINH" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="26" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator16" runat="server" ControlToValidate="THIEU_TINH"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="HONG_TINH" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="28" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator20" runat="server" ControlToValidate="THIEU_TINH"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="TC_TINH" runat="server" CssClass="ntp_textbox" Enabled="False" MaxLength="50"
                                        TabIndex="30" Width="100%"></asp:TextBox></td>
                                <td width="8%" >
                                    &nbsp;</td>
                            </tr>
                        </table>
                        
                    </asp:Panel>
                    <asp:Panel ID="pnlVT_Huyen" runat="server" Width="100%">
                         <table class="ntp_table_withborder"  border = 1 width="100%" cellpadding=1 cellspacing = 0>
                            <tr >
                                <td align="center" style="width: 8%; height: 23px" rowspan="2" >
                                    <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Text="Tồn đầu kỳ"></asp:Label></td>
                                <td align="center" colspan="3" width="8%" style="height: 23px">
                                    <asp:Label ID="Label29" runat="server" CssClass="ntp_label" Text="Nhập"></asp:Label></td>
                                <td align="center" colspan="3" width="8%" style="height: 23px">
                                    <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Xuất"></asp:Label></td>
                                <td align="center" width="8%" style="height: 23px" rowspan="2">
                                    <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Tồn cuối kỳ"></asp:Label></td>
                                <td align="center" width="8%" style="height: 23px">
                                    </td>
                            </tr>
                            <tr>
                                <td style="width: 8%" align="center">
                                    <asp:Label ID="Label38" runat="server" CssClass="ntp_label" Text="Tỉnh cấp. Điều chuyển"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label49" runat="server" CssClass="ntp_label" Text="Trả lại"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label39" runat="server" CssClass="ntp_label" Text="Thừa"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label40" runat="server" CssClass="ntp_label" Text="Toàn tỉnh"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label41" runat="server" CssClass="ntp_label" Text="Hỏng vỡ thiếu"></asp:Label></td>
                                <td width="8%" align="center">
                                    <asp:Label ID="Label42" runat="server" CssClass="ntp_label" Text="Điều chuyển"></asp:Label></td>
                                <td width="8%">
                                    </td>
                            </tr>
                            <tr>
                                <td style="width: 8%;">
                                    <asp:TextBox ID="TD_HUYEN" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="17"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="TD_HUYEN"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td style=" width: 8%;">
                                    <asp:TextBox ID="N_TINHCAP" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="19" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="N_TINHCAP"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" style="height: 45px">
                                    <asp:TextBox ID="TRA_LAI_HUYEN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="21" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator19" runat="server" ControlToValidate="TRA_LAI_HUYEN"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="THUA_HUYEN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="23" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator15" runat="server" ControlToValidate="THUA_HUYEN"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="X_HUYEN" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="25"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator13" runat="server" ControlToValidate="X_HUYEN"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="THIEU_HUYEN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="27" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator17" runat="server" ControlToValidate="THIEU_HUYEN"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                                        Type="Double"></asp:RangeValidator></td>
                                <td width="8%" >
                                    <asp:TextBox ID="DIEU_CHUYEN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="29" Width="100%"></asp:TextBox><asp:RangeValidator ID="RangeValidator21"
                                            runat="server" ControlToValidate="THIEU_TINH" Display="Dynamic" ErrorMessage="Nhập số"
                                            MaximumValue="99999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
                                <td width="8%">
                                    <asp:TextBox ID="TC_HUYEN" runat="server" CssClass="ntp_textbox" Enabled="False"
                                        MaxLength="50" TabIndex="31" Width="100%"></asp:TextBox></td>
                                <td width="8%" style="height: 45px">
                                    </td>
                            </tr>
                        </table>
                        </asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="2" width="100%">
                    <asp:Button ID="cmdSaveVT" runat="server" Text="Ghi chi tiết" CssClass="ntp_button" Width="100px" TabIndex="35" />
                    <asp:Button ID="cmdDel_VT" runat="server" Text="Xóa chi tiết" CssClass="ntp_button" Width="100px" CausesValidation="False" />
                    <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server"
    TargetControlID="cmdDel_VT"
    ConfirmText="Bạn thực sự muốn xóa dữ liệu này?"
     />
                </td>
            </tr>
        </table><cc3:MultiSelectGrid ID="grdDS_VT" runat="server" AutoGenerateColumns="False" ShowFooter="True" Width="100%"
                    CssClass="ntp_grd_GridViewStyle"
                    HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                    AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                    EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                    ItemStyle-CssClass = "ntp_grd_RowStyle"
                    PagerStyle-CssClass = "ntp_grd_PagerStyle"
                    HighlightCssClass="ntp_grd_SelectedRowStyle"
                    >
            <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
            <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
            <PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle" />
            <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
            <ItemStyle CssClass="ntp_grd_RowStyle" />
            <Columns>
                <asp:TemplateColumn>
                    <headerstyle width="2%"  />
                </asp:TemplateColumn>
                <asp:TemplateColumn>
                    <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                    <headerstyle width="2%" />
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="ID_CHITIET" HeaderText="ID_CHITIET" Visible="False"></asp:BoundColumn>
                <asp:BoundColumn DataField="ID_VATTU" HeaderText="ID_VATTU" Visible="False">
                    <headerstyle width="0%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="TEN_BENHVIEN" HeaderText="Kho">
                  <headerstyle width="22%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="TEN_VATTU" HeaderText="T&#234;n vật tư">
                    <headerstyle width="12%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="TON_DAU" HeaderText="Tồn đầu">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="NHAP" HeaderText="Nhập">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="TRA_LAI" HeaderText="Trả lại">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="THUA" HeaderText="Thừa">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="XUAT" HeaderText="Xuất">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="THIEU" HeaderText="Thiếu">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="HONG_TINH" HeaderText="Hỏng vỡ">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="DIEU_CHUYEN" HeaderText="Điều chuyển">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="TON_CUOI" HeaderText="Tồn cuối">
                    <headerstyle width="7%" />
                </asp:BoundColumn>
                
            </Columns>
            <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
        </cc3:MultiSelectGrid></asp:Panel>
    </fieldset>
    </asp:Panel>       






