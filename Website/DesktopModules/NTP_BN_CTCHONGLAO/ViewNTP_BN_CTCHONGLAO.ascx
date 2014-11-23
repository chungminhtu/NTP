<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_CTCHONGLAO.ViewNTP_BN_CTCHONGLAO" CodeFile="ViewNTP_BN_CTCHONGLAO.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:panel ID="pnlNhapBaoCao" runat="server" Width="61%">

<fieldset class="ntp_fieldset" style="width: 745px">
        <legend class="ntp_legend">Danh sách báo cáo</legend>
                <asp:DropDownList ID="cboDieuKien" runat="server" CssClass="ntp_combobox" TabIndex="10" Width="50px" Visible="False">
              <asp:ListItem>&gt;=</asp:ListItem>
              <asp:ListItem>=</asp:ListItem>
              <asp:ListItem>&lt;=</asp:ListItem>
          </asp:DropDownList>
    <table style="width: 772px">
        <tr>
            <td style="width: 82px; height: 27px">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="80px"></asp:Label></td>
            <td style="width: 215px; height: 27px">
                <asp:DropDownList ID="CboDMTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                    DataValueField="MA_TINH" TabIndex="1" Width="215px">
                </asp:DropDownList></td>
            <td style="width: 24px; height: 27px">
              <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="năm "
                  Width="38px"></asp:Label></td>
            <td style="width: 51px; height: 27px">
               <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6"
                   Width="88px"></asp:TextBox></td>
            <td style="width: 47px; height: 27px">
               </td>
            <td style="width: 108px; height: 27px">
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtNam"
                    ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
            <td style="height: 27px">
                <asp:Button ID="cmdXem" runat="server" CausesValidation="False"
                        CssClass="ntp_button" Text="Xem" Width="99px" Height="25px" /></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 27px">
                     <asp:Button ID="CmdDaBaocao" runat="server" BackColor="LightCyan" BorderColor="Gainsboro"
                         BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="18" Text="Danh sách Đơn vị báo cáo"
                         Width="297px" /></td>
            <td colspan="4" style="height: 27px">
                     <asp:Button ID="CmdChuaBaocao" runat="server" BackColor="WhiteSmoke" BorderColor="PowderBlue"
                         BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="11" Text="Danh sách Đơn vị chưa báo cáo"
                         Width="238px" /></td>
            <td style="height: 27px">
            </td>
        </tr>
    </table>
         <table class="ntp_table_main" style="width: 770px">
          <tr>
          <td style="width: 100%;" colspan="5">
        
                <cc3:multiselectgrid id="grdDSBaoCao" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                    autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                    headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                    itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                    selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True"
                    width="100%" ><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False enabled='<%#Not(DataBinder.Eval(Container.DataItem, "TinhXN")) %>' ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_CTChonglao" HeaderText="ID_CTChonglao" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="Nam" HeaderText="Năm báo cáo">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NgayBC" HeaderText="Ng&#224;y b&#225;o c&#225;o">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NguoiBC" HeaderText="Người b&#225;o c&#225;o">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Huyen" HeaderText="Cơ sở y tế">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Tinh" HeaderText="Tỉnh">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TinhXN" HeaderText="Tỉnh XN"  Visible="False">
<HeaderStyle Width="5%"></HeaderStyle></asp:BoundColumn>

<asp:BoundColumn DataField="TinhXNTT" HeaderText="Tỉnh XN"   Visible="False">
<HeaderStyle Width="5%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
              &nbsp;&nbsp;
              <cc3:multiselectgrid id="GrdDSChuaBC" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                  autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                  headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                  itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                  selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="97%"><Columns>
<asp:BoundColumn DataField="MA_TINH" HeaderText="M&#227; Tỉnh" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="TEN_TINH" HeaderText="T&#234;n Tỉnh">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_benhvien" HeaderText="T&#234;n đơn vị"></asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
              </td>
              </tr>
              </table>
    <br />
    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="8" Text="Thêm"
        Width="100px" />
    <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa "
                 Width="100px" />&nbsp;
            
             <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa báo cáo này?"
                 TargetControlID="cmdDelete">
             </ajaxToolkit:ConfirmButtonExtender>
            </fieldset>
    </asp:panel> &nbsp;<asp:Panel ID="pnlBaoCao" runat="server" Visible="False" Width="59%"><FIELDSET style="WIDTH: 744px" class="ntp_fieldset"><LEGEND class="ntp_legend">Báo cáo Quản lý chương trình chống Lao</LEGEND><TABLE style="WIDTH: 741px" class="ntp_table_main"><TBODY><TR><TD style="WIDTH: 5%; HEIGHT: 24px"></TD><TD style="HEIGHT: 24px" colSpan=4>&nbsp;<asp:RadioButtonList id="optlistBaoCao" Width="605px" runat="server"><asp:ListItem Selected="True" Value="1">1. Sự tham gia của y tế trong chương tr&#236;nh chống Lao</asp:ListItem>
<asp:ListItem Value="2">2. Sự tham gia của y tế trong hoạt động ph&#225;t hiện bệnh nh&#226;n</asp:ListItem>
<asp:ListItem Value="3">3. Sự tham gia của y tế trong hoạt động chẩn đo&#225;n bệnh nh&#226;n</asp:ListItem>
<asp:ListItem Value="4">4. Sự tham gia của y tế trong hoạt động điều trị bệnh nh&#226;n</asp:ListItem>
<asp:ListItem Value="5">5. Sự tham gia của cộng đồng trong c&#244;ng t&#225;c ph&#225;t hiện bệnh nh&#226;n</asp:ListItem>
<asp:ListItem Value="6">6. Sự tham gia của cộng đồng trong c&#244;ng t&#225;c quản l&#253; điều trị bệnh nh&#226;n</asp:ListItem>
<asp:ListItem Value="7">7. T&#236;nh h&#236;nh c&#225;n bộ Quản l&#253; chương tr&#236;nh chống Lao trong to&#224;n Tỉnh</asp:ListItem>
<asp:ListItem Value="8">8. T&#236;nh h&#236;nh c&#225;n bộ Trung học, Đại học tham gia CTCL tại c&#225;c cơ sở y tế trong Tỉnh</asp:ListItem>
<asp:ListItem Value="9">9. T&#236;nh h&#236;nh c&#225;n bộ Sơ cấp v&#224; C&#225;n bộ kh&#225;c tham gia CTCL tại c&#225;c cơ sở y tế trong Tỉnh</asp:ListItem>
<asp:ListItem Value="10">10. T&#236;nh h&#236;nh c&#225;n bộ x&#233;t nghiệm Lao trong to&#224;n Tỉnh</asp:ListItem>
<asp:ListItem Value="11">11. T&#236;nh h&#236;nh c&#225;n bộ chống Lao kh&#225;c trong to&#224;n Tỉnh</asp:ListItem>
</asp:RadioButtonList> &nbsp;</TD></TR><TR><TD style="WIDTH: 5%; HEIGHT: 24px"></TD><TD style="WIDTH: 4%; HEIGHT: 24px"><asp:Label id="Label1" Width="66px" runat="server" Text="Miền" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 10%; HEIGHT: 24px"><asp:DropDownList id="cboMien" tabIndex=10 Width="235px" runat="server" CssClass="ntp_combobox" DataValueField="ID_Mien" DataTextField="TEN_MIEN" AutoPostBack="True">
                        </asp:DropDownList> </TD><TD style="WIDTH: 3%; HEIGHT: 24px"><asp:Label id="Label3" Width="66px" runat="server" Text="Vùng" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 20%; HEIGHT: 24px"><asp:DropDownList id="cboVung" tabIndex=10 Width="234px" runat="server" CssClass="ntp_combobox" DataValueField="ID_VUNG" DataTextField="TEN_VUNG" AutoPostBack="True">
                        </asp:DropDownList> <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Không được để trống" ControlToValidate="txtNamBC"></asp:RequiredFieldValidator> </TD></TR><TR><TD style="WIDTH: 3%"></TD><TD style="WIDTH: 3%"><asp:Label id="Label5" Width="66px" runat="server" Text="Tỉnh" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 10%"><asp:DropDownList id="cboTinh" tabIndex=3 Width="235px" runat="server" CssClass="ntp_combobox" DataValueField="MA_TINH" DataTextField="TEN_TINH">
                        </asp:DropDownList></TD><TD style="WIDTH: 3%"><asp:Label id="Label8" Width="66px" runat="server" Text="Năm" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 20%"><asp:TextBox id="txtNamBC" tabIndex=5 Width="96px" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox> <asp:RangeValidator id="RangeValidator1" runat="server" Type="Integer" MinimumValue="1900" MaximumValue="3000" ErrorMessage="Không đúng năm" ControlToValidate="txtNamBC"></asp:RangeValidator></TD></TR><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 4%"></TD><TD colspan="2">
                            <asp:RadioButtonList ID="optlisLuachonIn" runat="server" Height="1px" RepeatDirection="Horizontal"
                                TabIndex="5" Width="311px">
                                <asp:ListItem Selected="False" Value="0">Nh&#243;m theo Miền</asp:ListItem>
                                <asp:ListItem  Selected="True" Value="1">Nh&#243;m theo v&#249;ng</asp:ListItem>
                            </asp:RadioButtonList></TD><TD style="WIDTH: 20%"></TD></TR></TBODY></TABLE><asp:Button id="Button1" Width="136px" runat="server" Text="In báo cáo" CssClass="ntp_button" Height="25px"></asp:Button></FIELDSET> <asp:Literal id="Literal1" runat="server"></asp:Literal></asp:Panel> 