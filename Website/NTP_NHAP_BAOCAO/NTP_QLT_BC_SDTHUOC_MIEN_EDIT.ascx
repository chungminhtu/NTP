<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLT_BC_SDTHUOC_MIEN_EDIT.ascx.vb" Inherits="NTP_QLT_BC_SDTHUOC_MIEN_EDIT" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


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
         <td width="35%" style="height: 25px"><asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="2" Width="100%">
             <asp:ListItem Value="1">Qu&#253; 1</asp:ListItem>
             <asp:ListItem Value="2">Qu&#253; 2</asp:ListItem>
             <asp:ListItem Value="3">Qu&#253; 3</asp:ListItem>
             <asp:ListItem Value="4">Qu&#253; 4</asp:ListItem>
         </asp:DropDownList></td>
         <td style="width: 15%; height: 25px;">
             <asp:Label ID="Label4" runat="server" CssClass="ntp_label">Năm</asp:Label></td>
          <td style="width: 35%; height: 25px;">
              
              <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1" Width="64px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNam"
                  Display="Dynamic" ErrorMessage="Bạn phải nhập năm" SetFocusOnError="True" ValidationGroup="MASTER"></asp:RequiredFieldValidator>
              <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNam"
                  Display="Dynamic" ErrorMessage="Bạn phải nhập số" MaximumValue="9999" MinimumValue="0"
                  SetFocusOnError="True" Type="Integer" ValidationGroup="MASTER"></asp:RangeValidator></td>
     </tr>
        <tr display="Static">
            <td width="15%">
            </td>
            <td width="35%"  colspan=3>
                <asp:Button ID="cmdAdd" runat="server" Text="Ghi lại" CssClass="ntp_button" Width="100px" ValidationGroup="MASTER" />&nbsp;
            <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="ntp_button" Width="100px" CausesValidation="False" />
                <asp:TextBox ID="txtID_BAOCAO" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
        </tr>
       
    </table>
    </fieldset>
</asp:Panel>       
<asp:Panel ID="pnlDetail" runat="server" Width="100%" Visible="False">
<fieldset class="ntp_fieldset">
    <legend class="ntp_legend">Thông tin chi tiết báo cáo</legend>
<table  class = "ntp_table_main" width = 100% >
    <tr>
        <td colspan="6" width="15%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_comment" Text="Chú ý: <br>Số lượng tồn cuối sẽ tự tính theo công thức : tồn cuối = (tồn đầu + số lượng nhập + trả lại + thừa) - (xuất sử dụng + hỏng vỡ/thiếu + điều chuyển) <br> Hạn dùng của tồn cuối sẽ bằng giá trị nhỏ nhất của hạn dùng tồn đầu và hạn dùng số lượng nhập <br> Tồn cuối: Số lô sản xuất = số lô sản xuất của phần nhập"></asp:Label></td>
    </tr>
     <tr>
        <td width=25%>
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Chọn đơn vị"></asp:Label></td>
         <td width="15%" colspan="5">
         <asp:DropDownList ID="cboHuyen" runat="server" CssClass="ntp_combobox" DataTextField="TEN_HUYEN"
                  DataValueField="MA_HUYEN" TabIndex="2" Width="100%" AutoPostBack="True">
        </asp:DropDownList></td>
    </tr>
    <tr>
        <td width="25%">
             <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Chọn thuốc"></asp:Label></td>
        <td colspan="5" width="15%">
            <asp:DropDownList ID="cboThuoc" runat="server" CssClass="ntp_combobox" DataTextField="TEN_THUOC"
                  DataValueField="ID_THUOC" TabIndex="3" Width="100%" AutoPostBack="True">
         </asp:DropDownList></td>
    </tr>
    <tr>
        <td width="25%">
             <asp:Label ID="Label16" runat="server" CssClass="ntp_label" Text="Nguồn kinh phí"></asp:Label></td>
        <td colspan="5" width="15%">
              <asp:DropDownList ID="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" DataTextField="MO_TA"
                  DataValueField="ID_NGUONKINHPHI" TabIndex="4" Width="100%" AutoPostBack="True">
              </asp:DropDownList></td>
    </tr>
    <tr>
        <td width=25% rowspan="2">
            <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Tồn đầu quý"></asp:Label>&nbsp;
        </td>
        <td width="15%">
            <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Số lượng"></asp:Label></td>
        <td width="15%">
            <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Hạn dùng"></asp:Label></td>
        <td width="15%">
            <asp:TextBox ID="txtID_CHITIET" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
            <td width="15%">
                </td>
            <td width="15%">
                </td>
    </tr>
    <tr>
        <td width="15%">
            <asp:TextBox ID="TD_SOLUONG" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="5"
                Width="100px">5</asp:TextBox>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TD_SOLUONG"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
        <td width="15%">
            <asp:TextBox ID="TD_HANDUNG" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="6" Width="100px"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="Maskededitextender2"
                    runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                    PromptCharacter="_" TargetControlID="TD_HANDUNG">
                </ajaxToolkit:MaskedEditExtender>
            <ajaxToolkit:MaskedEditValidator ID="Maskededitvalidator2" runat="server" ControlExtender="Maskededitextender2"
                ControlToValidate="TD_HANDUNG" EmptyValueMessage="Bạn phải nhập ngày" InvalidValueMessage="Định dạng ngày không đúng"
                MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                MinimumValue=" 1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                SetFocusOnError="True" TooltipMessage="Nhập ngày" ValidationGroup="DETAIL"></ajaxToolkit:MaskedEditValidator></td>
        <td width="15%">
            </td>
                <td  width="15%"></td>
                <td  width="15%"></td>
               
    </tr>
    <tr>
        <td width="25%" rowspan="2">
            <asp:Label ID="lblNhap" runat="server" CssClass="ntp_label" Text="Nhập (tỉnh cấp hoặc điều chỉnh)"></asp:Label></td>
        <td width="15%">
            <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Số lượng"></asp:Label></td>
        <td width="15%">
            <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Lô sản xuất"></asp:Label></td>
        <td width="15%">
            <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Hạn dùng"></asp:Label></td>
        <td width="15%">
            <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Text="Trả lại"></asp:Label></td>
        <td width="15%">
            <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Text="Thừa"></asp:Label></td>
    </tr>
    <tr>
        <td width="15%">
            <asp:TextBox ID="N_SOLUONG" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="7" Width="100px">8</asp:TextBox>
            <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="N_SOLUONG"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
        <td width="15%">
            <asp:TextBox ID="N_LOSX" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8"
                Width="100px"></asp:TextBox></td>
        <td width="15%">
            <asp:TextBox ID="N_HANDUNG" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="9" Width="100px"></asp:TextBox><ajaxToolkit:MaskedEditExtender ID="Maskededitextender1"
                    runat="server" AutoComplete="true" CultureName="vi-VN" Mask="99/99/9999" MaskType="Date"
                    PromptCharacter="_" TargetControlID="N_HANDUNG">
                </ajaxToolkit:MaskedEditExtender>
            <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="Maskededitextender1"
                ControlToValidate="N_HANDUNG" EmptyValueMessage="Bạn phải nhập ngày" InvalidValueMessage="Định dạng ngày không đúng"
                MaximumValue="31/12/9999" MaximumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                MinimumValue=" 1/1/1753" MinimumValueMessage="Bạn chỉ được nhập ngày trong khoảng (1/1/1753 - 31/12/9999)"
                SetFocusOnError="True" TooltipMessage="Nhập ngày" ValidationGroup="DETAIL"></ajaxToolkit:MaskedEditValidator></td>
        <td width="15%">
            <asp:TextBox ID="N_TRALAI" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"
                Width="100px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="N_TRALAI"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
        <td width="15%">
            <asp:TextBox ID="N_THUA" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"
                Width="100px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="N_THUA"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td rowspan="2" width="25%">
            <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Xuất"></asp:Label></td>
        <td width="15%" style="height: 21px">
            <asp:Label ID="lblX_SUDUNG" runat="server" CssClass="ntp_label" Text="Sử dụng"></asp:Label></td>
        <td width="15%" style="height: 21px">
            <asp:Label ID="lblX_HONGVO" runat="server" CssClass="ntp_label" Text="Hỏng vỡ thiếu"></asp:Label></td>
        <td width="15%" style="height: 21px">
            <asp:Label ID="lblX_DIEUCHUYEN" runat="server" CssClass="ntp_label" Text="Điều chuyển"></asp:Label></td>
        <td width="15%" style="height: 21px">
        </td>
        <td width="15%" style="height: 21px">
        </td>
    </tr>
    <tr>
        <td width="15%">
            <asp:TextBox ID="X_SUDUNG" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="10"
                Width="100px">2</asp:TextBox>
            <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="X_SUDUNG"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
        <td width="15%">
            <asp:TextBox ID="X_HONG" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11"
                Width="100px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="X_HONG"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
        <td width="15%">
            <asp:TextBox ID="X_DIEUCHUYEN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="12" Width="100px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="X_DIEUCHUYEN"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
        <td width="15%">
        </td>
        <td width="15%">
        </td>
    </tr>
    <tr >
        <td rowspan="2" width="25%" style="display:none;">
            <asp:Label ID="Label21" runat="server" CssClass="ntp_label" Text="Tồn cuối quý"></asp:Label></td>
        <td width="15%"  style="display:none;">
            <asp:Label ID="Label22" runat="server" CssClass="ntp_label" Text="Số lượng"></asp:Label></td>
        <td width="15%" style="display:none;">
            <asp:Label ID="Label23" runat="server" CssClass="ntp_label" Text="Lô sản xuất"></asp:Label></td>
        <td width="15%"  style="display:none;">
            <asp:Label ID="Label24" runat="server" CssClass="ntp_label" Text="Hạn dùng"></asp:Label></td>
        <td width="15%"  style="display:none;">
        </td>
        <td width="15%" style="display:none;">
        </td>
    </tr>
    <tr >
        <td width="15%" style="display:none;">
            <asp:TextBox ID="TC_SOLUONG" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="13" Width="100px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="N_TRALAI"
                Display="Dynamic" ErrorMessage="Nhập số" MaximumValue="99999999" MinimumValue="0"
                Type="Integer" ValidationGroup="DETAIL"></asp:RangeValidator></td>
        <td width="15%" style="display:none;">
            <asp:TextBox ID="TC_LOSX" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="14"
                Width="100px" Visible="False"></asp:TextBox>
        </td>
        <td  width="15%" style="display:none;">
            <asp:TextBox ID="TC_HANDUNG" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="15" Width="100px" Visible="False"></asp:TextBox></td>
        <td width="15%" style="display:none;">
        </td>
        <td width="15%" style="display:none;">
        </td>
    </tr>
    <tr>
        <td rowspan="1" width="25%">
            <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Ghi chú"></asp:Label></td>
        <td colspan="5">
            <asp:TextBox ID="txtGhiChu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="16" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td rowspan="1" width="25%">
        </td>
        <td colspan="5">
            <asp:Button ID="cmdSaveDetail" runat="server" Text="Ghi chi tiết" CssClass="ntp_button" Width="100px" TabIndex="17" ValidationGroup="DETAIL" />&nbsp;
            <asp:Button ID="cmdDelDetail" runat="server" Text="Xóa chi tiết" CssClass="ntp_button" Width="100px" CausesValidation="False" />
            <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server"
    TargetControlID="cmdDelDetail"
    ConfirmText="Bạn thực sự muốn xóa dữ liệu này?"
     />
         </td>
    </tr>
    <tr>
        <td colspan="6" rowspan="1">
            <cc3:MultiSelectGrid ID="grdDS_Tinh" runat="server" AutoGenerateColumns="False" ShowFooter="True" Width="100%"
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
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w5" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_CHITIET" HeaderText="ID_CHITIET" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_DONVI" HeaderText="Đơn vị">
                        <headerstyle width="16%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TD_SOLUONG" HeaderText="Số lượng">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TD_HANDUNG" HeaderText="Hạn d&#249;ng">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="N_SOLUONG" HeaderText="Số lượng">
                        <headerstyle width="20%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="N_LOSX" HeaderText="L&#244; SX">
                        <headerstyle width="20%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn HeaderText="Hạn d&#249;ng" DataField="N_HANDUNG">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="N_TRALAI" HeaderText="Trả lại"></asp:BoundColumn>
                    <asp:BoundColumn DataField="N_THUA" HeaderText="Thừa"></asp:BoundColumn>
                    <asp:BoundColumn DataField="X_SUDUNG_TOANTINH" HeaderText="To&#224;n tỉnh"></asp:BoundColumn>
                    <asp:BoundColumn DataField="X_TINH_THIEU" HeaderText="Thiếu"></asp:BoundColumn>
                    <asp:BoundColumn DataField="X_TINH_HONG_VO" HeaderText="Hỏng vỡ"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TC_SOLUONG" HeaderText="Số lượng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TC_LOSX" HeaderText="L&#244; SX"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TC_HANDUNG" HeaderText="Hạn sử dụng"></asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
            </cc3:MultiSelectGrid>
            <cc3:MultiSelectGrid ID="grdDS" runat="server" AutoGenerateColumns="False" ShowFooter="True" Width="100%"
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
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w5" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_CHITIET" HeaderText="ID_CHITIET" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_DONVI" HeaderText="Đơn vị">
                        <headerstyle width="16%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TD_SOLUONG" HeaderText="TD:Số lượng">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TD_HANDUNG" HeaderText="TD:Hạn d&#249;ng"  DataFormatString="{0:dd/MM/yyyy}">
                        <headerstyle width="15%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="N_SOLUONG" HeaderText="N:Số lượng">
                        <headerstyle width="20%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="N_LOSX" HeaderText="N:L&#244; SX">
                        <headerstyle width="20%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn HeaderText="N:Hạn d&#249;ng" DataField="N_HANDUNG"  DataFormatString="{0:dd/MM/yyyy}">
                        <headerstyle width="10%" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TRA_LAI" HeaderText="Trả lại"></asp:BoundColumn>
                    <asp:BoundColumn DataField="THUA" HeaderText="Thừa"></asp:BoundColumn>
                    <asp:BoundColumn DataField="X_SUDUNG_TOANTINH" HeaderText="X:Sử dụng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="X_HUYEN_HONGVO" HeaderText="X:Hỏng,vỡ thiếu"></asp:BoundColumn>
                    <asp:BoundColumn DataField="X_HUYEN_DIEUCHUYEN" HeaderText="X:Điều chuyển"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TC_SOLUONG" HeaderText="TC:Số lượng"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TC_LOSX" HeaderText="TC:L&#244; SX"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TC_HANDUNG" HeaderText="TC:Hạn sử dụng" DataFormatString="{0:dd/MM/yyyy}"></asp:BoundColumn>
                    <asp:BoundColumn DataField="GHI_CHU" HeaderText="Ghi chú"></asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
            </cc3:MultiSelectGrid></td>
    </tr>  
</table>
</fieldset>
</asp:Panel>       







