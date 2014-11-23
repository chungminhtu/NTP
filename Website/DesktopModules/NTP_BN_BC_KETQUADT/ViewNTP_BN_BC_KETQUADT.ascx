<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_BC_KETQUADT.ViewNTP_BN_BC_KETQUADT" CodeFile="ViewNTP_BN_BC_KETQUADT.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<asp:panel ID="pnlNhapBaoCao" runat="server" Width="56%"><FIELDSET class="ntp_fieldset" style="width: 770px"><LEGEND class="ntp_legend">Danh sách báo cáo kết quả điều trị</LEGEND>
    <table style="width: 772px">
        <tr>
            <td style="width: 82px; height: 27px;">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="80px"></asp:Label></td>
            <td style="width: 215px; height: 27px;">
                <asp:DropDownList ID="CboDMTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                            DataValueField="MA_TINH" TabIndex="1" Width="215px">
                </asp:DropDownList></td>
            <td style="width: 24px; height: 27px;">
                <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Quý BC" Width="60px"></asp:Label></td>
            <td style="width: 51px; height: 27px;">
                <asp:DropDownList id="cboDieuKien" tabIndex=2 Width="88px" runat="server" CssClass="ntp_combobox">
                <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
          </asp:DropDownList></td>
            <td style="width: 47px; height: 27px;">
                <asp:TextBox id="txtNam" tabIndex=3 Width="58px" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox></td>
            <td style="width: 108px; height: 27px;">
                <asp:RangeValidator id="RangeValidator2" runat="server" Type="Integer" MinimumValue="1900" MaximumValue="3000" ErrorMessage="Không đúng năm" ControlToValidate="txtNam"></asp:RangeValidator></td>
            <td style="height: 27px">
                <asp:Button id="cmdTim" Width="99px" runat="server" Text="Xem" CssClass="ntp_button" Height="25px" CausesValidation="False" TabIndex="4"></asp:Button></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 27px">
                <asp:Button ID="CmdDaBaocao" runat="server" BackColor="LightCyan" BorderColor="Gainsboro"
                    BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="18" Text="Danh sách Đơn vị báo cáo"
                    Width="297px" /></td>
            <td colspan="3" style="height: 27px">
                <asp:Button ID="CmdChuaBaocao" runat="server" BackColor="WhiteSmoke" BorderColor="PowderBlue"
                    BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="11" Text="Danh sách Đơn vị chưa báo cáo"
                    Width="238px" /></td>
            <td style="width: 108px; height: 27px">
            </td>
            <td style="height: 27px">
            </td>
        </tr>
    </table>
    <TABLE class="ntp_table_main" style="width: 771px"><TBODY><TR><TD style="WIDTH: 100%" colSpan=5>
    <cc3:multiselectgrid id="grdDSBaoCao" runat="server" width="100%" showfooter="True" selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle" itemstyle-cssclass="ntp_grd_RowStyle" highlightcssclass="ntp_grd_SelectedRowStyle" headerstyle-cssclass="ntp_grd_HeaderStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle" cssclass="ntp_grd_GridViewStyle" autogeneratecolumns="False" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle" allowpaging="True"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False enabled='<%#Not(DataBinder.Eval(Container.DataItem, "TinhXN")) %>' ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_BC_KetquaDT" HeaderText="ID_BC_KetquaDT" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="Quy" HeaderText="Qu&#253;">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Nam" HeaderText="Năm b&#225;o c&#225;o">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="ngayBCIn" HeaderText="Ng&#224;y b&#225;o c&#225;o">
<HeaderStyle Width="15%"></HeaderStyle>
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
<asp:BoundColumn DataField="TinhXNTT" HeaderText="Tỉnh XN" Visible="False">
<HeaderStyle Width="5%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TinhXN" HeaderText="Tỉnh XN" Visible="False">
<HeaderStyle Width="5%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid> &nbsp;&nbsp;
        <cc3:multiselectgrid id="GrdDSChuaBC" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
            autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
            headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
            itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
            selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="100%"><Columns>
<asp:BoundColumn DataField="MA_TINH" HeaderText="M&#227; Tỉnh" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="TEN_TINH" HeaderText="T&#234;n Tỉnh">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TEN_BENHVIEN" HeaderText="T&#234;n đơn vị"></asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
    </TD></TR><TR><TD width="100%" colSpan=4>
    <asp:TextBox ID="TxtCapQL" runat="server" Visible="False" Width="49px"></asp:TextBox></TD></TR></TBODY></TABLE> <asp:Button id="cmdAdd" tabIndex=8 Width="100px" runat="server" Text="Thêm" CssClass="ntp_button"></asp:Button> 
 
     <asp:Button ID="cmdDel" runat="server" CssClass="ntp_button" Text="Xóa "
                 Width="100px" />&nbsp;
            
             <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa báo cáo này?"
                 TargetControlID="cmdDel">
             </ajaxToolkit:ConfirmButtonExtender>
            
</FIELDSET></asp:panel>
<asp:Panel ID="pnlBaoCao" runat="server" Visible="False" Width="55%">
    <fieldset class="ntp_fieldset" style="width: 772px">
        <legend class="ntp_legend">Báo cáo Kết quả điều trị Lao</legend>
        <table class="ntp_table_main" style="width: 773px">
            <tbody>
                <tr>
                    <td style="width: 5%; height: 24px">
                    </td>
                    <td style="width: 4%; height: 24px">
                    </td>
                    <td colspan="3" style="height: 24px">
                        &nbsp;<asp:RadioButtonList ID="optlistBaoCao" runat="server" Width="362px" TabIndex="5">
                            <asp:ListItem Selected="True" Value="1">1. Kết quả điều trị theo ph&#226;n loại bệnh nhận</asp:ListItem>
                            <asp:ListItem Value="4">2. Kết quả điều trị bệnh nh&#226;n theo huyện</asp:ListItem>
                            <asp:ListItem Value="2">3. Kết quả điều trị chung c&#225;c thể đ&#227; thu nhận</asp:ListItem>
                            <asp:ListItem Value="3">4. C&#225;c hoạt động phối hợp Lao/HIV</asp:ListItem>
                        </asp:RadioButtonList>
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <table style="width: 777px">
            <tr>
                <td style="width: 65px">
                </td>
                <td style="width: 64px">
                </td>
                <td colspan="4">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNamBC"
                        ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNamBC"
                        ErrorMessage="Không được để trống"></asp:RequiredFieldValidator></td>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td style="width: 65px">
                </td>
                <td style="width: 64px">
                    <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Năm" Width="66px"></asp:Label></td>
                <td colspan="4">
                    <asp:TextBox ID="txtNamBC" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="5"
                        Width="82px"></asp:TextBox>
                    <asp:CheckBox ID="chkQuy1" runat="server" TabIndex="13" Text="Quý 1" Width="66px" />
                    <asp:CheckBox ID="chkQuy2" runat="server" TabIndex="13" Text="Quý 2" Width="66px" />
                    <asp:CheckBox ID="chkQuy3" runat="server" TabIndex="13" Text="Quý 3" Width="66px" />
                    <asp:CheckBox ID="chkQuy4" runat="server" TabIndex="13" Text="Quý 4" Width="66px" />
                    <asp:CheckBox ID="ChkNam" runat="server" TabIndex="13" Text="Năm" Width="69px" AutoPostBack="True" /></td>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td style="width: 65px">
                </td>
                <td style="width: 64px">
                    <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Miền" Width="66px"></asp:Label></td>
                <td colspan="2">
                    <asp:DropDownList ID="cboMien" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                        DataTextField="TEN_MIEN" DataValueField="ID_Mien" TabIndex="1" Width="193px">
                    </asp:DropDownList></td>
                <td style="width: 12px">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Vùng" Width="39px"></asp:Label></td>
                <td style="width: 226px">
                    <asp:DropDownList ID="cboVung" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                        DataTextField="TEN_VUNG" DataValueField="ID_VUNG" TabIndex="2" Width="212px">
                    </asp:DropDownList></td>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td style="width: 65px">
                </td>
                <td style="width: 64px">
                    <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="66px"></asp:Label></td>
                <td colspan="2">
                    <asp:DropDownList ID="cboTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                        DataValueField="MA_TINH" TabIndex="3" Width="193px">
                    </asp:DropDownList></td>
                <td style="width: 12px">
                    <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Phân loại BV" Width="85px"></asp:Label></td>
                <td style="width: 226px">
                    <asp:DropDownList ID="CboPhanloai" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                        DataTextField="TEN_LOAIBV" DataValueField="ID_LOAIBV" TabIndex="2" Width="212px">
                    </asp:DropDownList></td>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td style="width: 65px">
                </td>
                <td style="width: 64px">
                </td>
                <td colspan="3">
                    <asp:RadioButtonList ID="optlisLuachonIn" runat="server" Height="1px" RepeatDirection="Horizontal"
                        TabIndex="5" Width="311px">
                        <asp:ListItem Selected="False" Value="0">Nh&#243;m theo Miền</asp:ListItem>
                        <asp:ListItem Selected="True" Value="1">Nh&#243;m theo v&#249;ng</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td style="width: 226px">
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" CssClass="ntp_button" Height="25px" Text="In báo cáo"
            Width="99px" TabIndex="11" /></fieldset>
    <br />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal><td width="85%">
    </td>
    &nbsp; &nbsp; &nbsp; &nbsp;</asp:Panel>
