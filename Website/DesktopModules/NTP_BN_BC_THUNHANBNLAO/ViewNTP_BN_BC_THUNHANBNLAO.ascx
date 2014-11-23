<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO.ViewNTP_BN_BC_THUNHANBNLAO" CodeFile="ViewNTP_BN_BC_THUNHANBNLAO.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

&nbsp;<asp:Panel ID="pnlNhapBaoCao" runat="server" Height="221px" Width="790px">

<fieldset class="ntp_fieldset" style="width: 782px">
        <legend class="ntp_legend">Danh sách báo cáo tình hình thu nhận bệnh nhân lao</legend>
    <table style="width: 749px">
        <tr>
            <td style="width: 82px; height: 27px">
                <asp:Label ID="Label22" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="80px"></asp:Label></td>
            <td style="width: 230px; height: 27px">
                <asp:DropDownList ID="CboDMTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                    DataValueField="MA_TINH" TabIndex="1" Width="224px">
                </asp:DropDownList></td>
            <td style="width: 24px; height: 27px">
                <asp:Label ID="Label24" runat="server" CssClass="ntp_label" Text="Năm BC" Width="61px"></asp:Label></td>
            <td style="width: 51px; height: 27px">
                <asp:DropDownList ID="cboDieuKien" runat="server" CssClass="ntp_combobox" TabIndex="2"
                    Width="80px">
                <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 47px; height: 27px">
                <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3"
                    Width="58px"></asp:TextBox></td>
            <td style="width: 108px; height: 27px">
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtNam"
                    ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
            <td style="height: 27px">
                <asp:Button ID="cmdTim" runat="server" CausesValidation="False" CssClass="ntp_button"
                    Height="25px" TabIndex="4" Text="Xem" Width="99px" /></td>
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
        
                <cc3:multiselectgrid id="grdDSBaoCao" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                    autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                    headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                    itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                    selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True"
                    width="97%" ><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False enabled='<%#Not(DataBinder.Eval(Container.DataItem, "TinhXN")) %>' ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_BCThunhanBNLao" HeaderText="ID_BCThunhanBNLao" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="Quy" HeaderText="Qu&#253;">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Nam" HeaderText="Năm b&#225;o c&#225;o">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NgayBCIn" HeaderText="Ng&#224;y b&#225;o c&#225;o">
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
</cc3:multiselectgrid>
    <cc3:multiselectgrid id="GrdDSChuaBC" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
        autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
        headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
        itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
        selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="97%"><Columns>
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
    <br />
    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="8" Text="Thêm"
        Width="100px" />
    <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa "
                 Width="100px" />&nbsp;
            
             <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa báo cáo này?"
                 TargetControlID="cmdDelete">
             </ajaxToolkit:ConfirmButtonExtender>
            </fieldset>
</asp:Panel>
&nbsp;<asp:Panel ID="pnlBaoCao" runat="server" Visible="False" Width="63%">
    <fieldset class="ntp_fieldset" style="width: 785px">
        <legend class="ntp_legend">Thống kê Tình hình thu nhận bệnh nhân Lao</legend>
        <table class="ntp_table_main" style="width: 776px">
            <tbody>
                <tr>
                    <td style="width: 3%; height: 24px">
                    </td>
                    <td style="width: 3%; height: 24px">
                    </td>
                    <td colspan="3" style="height: 24px">
                        &nbsp;<asp:RadioButtonList ID="optlistBaoCao" runat="server" Width="615px">
                            <asp:ListItem Selected="True" Value="Thunhanchung">1. T&#236;nh h&#236;nh thu nhận Bệnh nh&#226;n Lao</asp:ListItem>
                            <asp:ListItem Value="Thunhantheohuyenquy">2. T&#236;nh h&#236;nh thu nhận Bệnh nh&#226;n Lao theo Huyện</asp:ListItem>
                            <asp:ListItem Value="Thunhantheotinhquy">3. T&#236;nh h&#236;nh thu nhận Bệnh nh&#226;n Lao theo Tỉnh, Qu&#253; </asp:ListItem>
                            <asp:ListItem Value="ThunhanBNLao AFB(+)MoitheoHuyen,Quy">4. T&#236;nh h&#236;nh thu nh&#226;n Bệnh nh&#226;n Lao AFB(+) Mới theo Huyện, Qu&#253;</asp:ListItem>
                            <asp:ListItem Value="BNLaoPhoiAFB(+)Moitheotuoivagioi">5. Bệnh nh&#226;n Lao phổi AFB(+) Mới  theo tuổi v&#224; giới</asp:ListItem>
                            <asp:ListItem Value="LaophoiAFB(+)Moi/HIV(+)Theotuoivagioi">6. Bệnh nh&#226;n Lao phổi AFB(+) Mới /HIV(+) Theo tuổi v&#224; giới</asp:ListItem>
                            <asp:ListItem Value="LaophoiAFB(-)MoivaLNPMoiTheotuoi">7. Bệnh nh&#226;n Lao phổi AFB(-) Mới v&#224; lao ngo&#224;i phổi mới theo tuổi  </asp:ListItem>
                            <asp:ListItem Value="ThunhanTreem">8. T&#236;nh h&#236;nh thu nhận Bệnh nh&#226;n Lao trẻ em (0 - 14 tuổi)</asp:ListItem>
                            <asp:ListItem Value="ThunhanTreemTinh">9. T&#236;nh h&#236;nh thu nhận Bệnh nh&#226;n Lao trẻ em (0 - 14 tuổi) theo tỉnh</asp:ListItem>


                        </asp:RadioButtonList>&nbsp;</td>
                </tr>
            </tbody>
        </table>
        <table style="width: 777px">
            <tr>
                <td style="width: 44px">
                </td>
                <td style="width: 64px">
                </td>
                <td colspan="4">
                    <asp:RangeValidator ID="RangeValidator1" runat="server"
                                ControlToValidate="txtNamBC" ErrorMessage="Không đúng năm" MaximumValue="3000"
                                MinimumValue="1900" Type="Integer"></asp:RangeValidator>
                    <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNamBC" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator></td>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td style="width: 44px">
                </td>
                <td style="width: 64px">
                        <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Năm" Width="66px"></asp:Label></td>
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
                <td style="width: 44px">
                </td>
                <td style="width: 64px">
                        <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Miền" Width="66px"></asp:Label></td>
                <td colspan="2">
                        <asp:DropDownList ID="cboMien" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                            DataTextField="TEN_MIEN" DataValueField="ID_Mien" TabIndex="1" Width="193px">
                        </asp:DropDownList></td>
                <td style="width: 69px">
                        <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Vùng" Width="66px"></asp:Label></td>
                <td style="width: 226px">
                        <asp:DropDownList ID="cboVung" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                            DataTextField="TEN_VUNG" DataValueField="ID_VUNG" TabIndex="2" Width="212px">
                        </asp:DropDownList></td>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td style="width: 44px">
                </td>
                <td style="width: 64px">
                        <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="66px"></asp:Label></td>
                <td colspan="2">
                        <asp:DropDownList ID="cboTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                            DataValueField="MA_TINH" TabIndex="3" Width="193px">
                        </asp:DropDownList></td>
                <td style="width: 69px">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Phân loại BV" Width="85px"></asp:Label></td>
                <td style="width: 226px">
                    <asp:DropDownList ID="CboPhanloai" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                            DataTextField="TEN_LOAIBV" DataValueField="ID_LOAIBV" TabIndex="2" Width="212px">
                    </asp:DropDownList></td>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td style="width: 44px">
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
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="ntp_button" Height="25px" Text="In báo cáo"
            Width="99px" TabIndex="6" /></fieldset>
    </asp:Panel>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>&nbsp;<br />
<br />
 
