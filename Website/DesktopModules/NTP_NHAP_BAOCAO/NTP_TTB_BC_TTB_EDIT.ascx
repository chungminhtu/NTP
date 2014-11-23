<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_TTB_BC_TTB_EDIT.ascx.vb" Inherits="NTP_TTB_BC_TTB_EDIT" %>
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
    $('input[id=<%=TD_SOLUONG.ClientID %>]').bind('keyup',recalc);
    $('input[id=<%=NHAP.ClientID %>]').bind('keyup',recalc);
    $('input[id=<%=XUAT.ClientID %>]').bind('keyup',recalc);
});
}

function recalc() {
    $('input[id=<%=TC_SOLUONG.ClientID %>]').calc(
			// the equation to use for the calculation
			's1 + s2 - s3',
			// define the variables used in the equation, these can be a jQuery object
			{
				s1: $('input[id=<%=TD_SOLUONG.ClientID %>]'),
				s2: $('input[id=<%=NHAP.ClientID %>]'),
				s3: $('input[id=<%=XUAT.ClientID %>]')
				
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

<asp:Panel ID="pnlAll" runat=server Width="100%">
<fieldset class="ntp_fieldset">
    <legend class="ntp_legend">Thông tin chung báo cáo</legend>
 <table  class = "ntp_table_main">
     <tr>
         <td style="width: 2%">
         </td>
         <td>
         </td>
         <td>
         </td>
         <td style="width: 294px">
         </td>
     </tr>
     <tr>
         <td colspan="4" style="height: 25px">
             <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Width="48px">Năm</asp:Label><asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="2" Width="64px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNam"
                  Display="Dynamic" ErrorMessage="Bạn phải nhập năm" SetFocusOnError="True"></asp:RequiredFieldValidator>
              <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNam"
                  Display="Dynamic" ErrorMessage="Bạn phải nhập số" MaximumValue="9999" MinimumValue="0"
                  SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
     </tr>
        <tr display="Static">
            <td style="width: 2%">
            </td>
            <td width="35%"  colspan=3>
                <asp:Button ID="cmdAdd" runat="server" Text="Ghi lại" CssClass="ntp_button" Width="100px" TabIndex="3" />&nbsp;
            <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="ntp_button" Width="100px" />
                <asp:TextBox ID="txtID_BAOCAO" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="1" Width="64px" Visible="False"></asp:TextBox></td>
        </tr>
       
    </table>
    </fieldset>
</asp:Panel>       
<asp:Panel ID="pnlDetail" runat="server" Width="100%" Visible="False">
<fieldset class="ntp_fieldset">
    <legend class="ntp_legend" style="width: 163px">Thông tin chi tiết báo cáo</legend><br />
     <table  class = "ntp_table_main" width = 100% >
    <tr>
        <td colspan="2" width="100%">
                        <asp:Label ID="Label2" runat="server" CssClass="ntp_comment" Text="Chú ý: <br>Số lượng tồn cuối sẽ tự tính theo công thức : tồn cuối = (tồn đầu + số lượng tỉnh nhập) - (số lượng xuất của tỉnh + số lượng xuất của huyện + số lượng đã thanh lý) "></asp:Label></td>
    </tr>
        <tr>
            <td width="20%">
                <asp:Label ID="Label32" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
            <td style="width: 75%">
                <asp:DropDownList ID="cboNGUONKP_HC" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                  DataValueField="ID_NGUONKINHPHI" TabIndex="6" Width="100%" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
         <tr>
             <td width="20%">
                 <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Chọn đơn vị"></asp:Label></td>
             <td style="width: 75%">
                 <asp:DropDownList ID="cboHuyen" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                     DataTextField="TEN_BENHVIEN" DataValueField="ID_BENHVIEN" TabIndex="2" Width="100%">
                 </asp:DropDownList></td>
         </tr>
     <tr>
        <td width=20% style="height: 24px">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Trang thiết bị"></asp:Label></td>
         <td style="height: 24px; width: 75%;">
             <asp:DropDownList ID="cboThietbi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_THIETBI"
                 DataValueField="ID_THIETBI" TabIndex="7" Width="100%">
             </asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2" rowspan="1" width="100%" style="height: 116px">
            <table class="ntp_table_main" width="100%">
                <tr>
                    <td align="center" rowspan="2" width="10%">
                        <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Tồn đầu"></asp:Label></td>
                    <td align="center" colspan="2" width="10%">
                        <asp:Label ID="lblNhap" runat="server" CssClass="ntp_label" Text="Nhập"></asp:Label>
                        <asp:TextBox ID="txtID_CHITIET" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
                    <td align="center" colspan="2" width="10%">
                        <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Xuất"></asp:Label></td>
                    <td align="center" rowspan="2" width="10%">
                        <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Tồn cuối"></asp:Label></td>
                    <td align="center" rowspan="" style="width: 10%" colspan="2">
                        <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Hỏng"></asp:Label></td>
                    <td align="center" rowspan="2" width="10%">
                        <asp:Label ID="Label28" runat="server" CssClass="ntp_label" Text="Chờ thanh lý"></asp:Label></td>
                    <td align="center" rowspan="2" style="width: 10%">
                                    <asp:Label ID="Label29" runat="server" CssClass="ntp_label" Text="Đã thanh lý"></asp:Label></td>
                </tr>
                <tr>
                    <td width="10%" style="height: 21px" align="center">
                        <asp:Label ID="Label35" runat="server" CssClass="ntp_label" Text="Số lượng"></asp:Label></td>
                    <td width="10%" style="height: 21px" align="center">
                                    <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
                    <td align="center" style="height: 21px" width="10%">
                        <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Số lượng"></asp:Label></td>
                    <td align="center" style="height: 21px" width="10%">
                                    <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
                                    <td align="center">
                                        <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Text="Số lượng"></asp:Label></td>
                                    <td align="center">
                        <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
                </tr>
                <tr>
                    <td width="10%" >
                        <asp:TextBox ID="TD_SOLUONG" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="8" Width="100%"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TD_SOLUONG"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                            SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td width="10%" >
                                    <asp:TextBox ID="NHAP" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="NHAP"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                                        SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td width="10%" >
                                    <asp:TextBox ID="NHAP_NAM" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="NHAP_NAM"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                                        SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td  width="10%">
                                    <asp:TextBox ID="XUAT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="15"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="XUAT"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                                        SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td  width="10%">
                                    <asp:TextBox ID="XUAT_NAM" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="16"
                                        Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator10" runat="server" ControlToValidate="XUAT_NAM"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                                        SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td  width="10%">
                        <asp:TextBox ID="TC_SOLUONG" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="21"
                            Width="100%" Enabled="False"></asp:TextBox></td>
                    <td style="width: 10%; ">
                        <asp:TextBox ID="HONG" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="17"
                            Width="100%"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="HONG"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                            SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td style="width: 10%; ">
                        <asp:TextBox ID="HONG_NAM" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="17"
                            Width="100%"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="HONG_NAM"
                            Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                            SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td width="10%" >
                                    <asp:TextBox ID="CHO_THANHLY" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="19" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator13" runat="server" ControlToValidate="CHO_THANHLY"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                                        SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                    <td style="width: 10%; ;">
                                    <asp:TextBox ID="DA_THANHLY" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                        TabIndex="20" Width="100%"></asp:TextBox>
                                    <asp:RangeValidator ID="RangeValidator14" runat="server" ControlToValidate="DA_THANHLY"
                                        Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="999999999" MinimumValue="0"
                                        SetFocusOnError="True" Type="Integer"></asp:RangeValidator></td>
                </tr>
              
                <tr>
                    <td colspan="1">
                        <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Ghi chú"></asp:Label></td>
                    <td colspan="10">
                        <asp:TextBox ID="txtGhiChu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="22" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="10">
                        </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="2" rowspan="1">
            <asp:Button ID="cmdSave" runat="server" Text="Ghi chi tiết" CssClass="ntp_button" Width="100px" TabIndex="23" />
            <asp:Button ID="cmdDel" runat="server" Text="Xóa chi tiết" CssClass="ntp_button" Width="100px" CausesValidation="False" TabIndex="24" />
            <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server"
    TargetControlID="cmdDel"
    ConfirmText="Bạn thực sự muốn xóa dữ liệu này?"
     />
        </td>
    </tr>
    <tr>
        <td colspan="2" rowspan="1">
            <cc3:MultiSelectGrid ID="grdDS" runat="server" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                 AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                 HeaderStyle-CssClass="ntp_grd_HeaderStyle" 
                 ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                 SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
                 <Columns>
                     <asp:TemplateColumn>
                         <headerstyle width="2%" />
                     </asp:TemplateColumn>
                     <asp:TemplateColumn>
                         <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                         <headerstyle width="2%" />
                     </asp:TemplateColumn>
                     <asp:BoundColumn DataField="ID_CHITIET" HeaderText="ID_CHITIET" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_THIETBI" HeaderText="ID_THIETBI" Visible="False">
                        <headerstyle width="0%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_BENHVIEN" HeaderText="Kho">
                        <headerstyle width="25%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_THIETBI" HeaderText="T&#234;n thiết bị">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TD_SOLUONG" HeaderText="Tồn đầu">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="N_SOLUONG" HeaderText="Nhập">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="N_NAM" HeaderText="Năm nhập">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn HeaderText="Xuất" DataField="XUAT">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="XUAT_NAM" HeaderText="Năm xuất">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                     <asp:BoundColumn DataField="TC_SOLUONG" HeaderText="Tồn cuối"></asp:BoundColumn>
                    <asp:BoundColumn DataField="HONG" HeaderText="Hỏng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="HONG_NAM" HeaderText="Hỏng-năm"></asp:BoundColumn>
                    <asp:BoundColumn DataField="CHO_THANHLY" HeaderText="Chờ TL"></asp:BoundColumn>
                    <asp:BoundColumn DataField="DA_THANHLY" HeaderText="Đ&#227; TL"></asp:BoundColumn>
                    
                    <asp:BoundColumn DataField="GHI_CHU" HeaderText="Ghi ch&#250;">                       <headerstyle width="10%" />
                    </asp:BoundColumn>
                 </Columns>
                 <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
                 <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                 <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                 <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                 <ItemStyle CssClass="ntp_grd_RowStyle" />
                 <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
             </cc3:MultiSelectGrid>
            </td>
    </tr>
      
</table>
       </fieldset>
    </asp:Panel>       