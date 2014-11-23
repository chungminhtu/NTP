<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_TINHHINHTRIENKHAI_CTCL.ViewNTP_BN_TINHHINHTRIENKHAI_CTCL" CodeFile="ViewNTP_BN_TINHHINHTRIENKHAI_CTCL.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

&nbsp;
    <fieldset class="ntp_fieldset" style="width: 770px">
        <legend class="ntp_legend">Tình hình triển khai Chương trình Chống lao Quốc gia</legend>
        <table style="width: 761px">
            <tr>
                <td style="width: 45px">
                    <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Năm" Width="48px"></asp:Label></td>
                <td style="width: 79px">
                    <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        Width="85px"></asp:TextBox></td>
                <td style="width: 69px">
                    <asp:RangeValidator ID="RangeValidator22" runat="server" ControlToValidate="txtNam"
                        ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"
                        Width="125px"></asp:RangeValidator></td>
                <td style="width: 115px">
                    <asp:TextBox ID="TxtID" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1"
                        Width="82px" Visible="False"></asp:TextBox></td>
                <td style="width: 115px">
                    <asp:RadioButtonList ID="optlisLuachonIn" runat="server" Height="1px" RepeatDirection="Horizontal"
                        TabIndex="5" Width="187px">
                        <asp:ListItem Selected="True" Value="0">Theo Miền</asp:ListItem>
                        <asp:ListItem Value="1">Theo v&#249;ng</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td style="width: 269px">
                    <asp:Button ID="cmdTim" runat="server" CausesValidation="False" CssClass="ntp_button"
                        Height="25px" TabIndex="1" Text="Xem" Width="63px" />
                    <asp:Button ID="CmdIn" runat="server" CausesValidation="False" CssClass="ntp_button"
                        Height="25px" TabIndex="1" Text="In báo cáo" Width="84px" />
                </td>
            </tr>
        </table>
        <cc3:multiselectgrid id="grdDSBaoCao" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
            autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
            headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
            itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
            selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="100%"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False  ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_TrienKhai" HeaderText="ID" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="TEN_TINH" HeaderText="Tỉnh/Th&#224;nh phố">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SLHuyen" HeaderText="Số Huyện">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SLHuyenTK" HeaderText="Số huyệnTK">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SLXaTK" HeaderText="Số x&#227; TK">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SoDVQL" HeaderText="Số ĐVQLĐT">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="DansoTinh" HeaderText="D&#226;n số Tỉnh">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SodanTK" HeaderText="D&#226;n số TK">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
        <br />
        <table border="1" style="width: 760px">
            <tr>
                <td style="width: 226px">
                    <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tỉnh/Thành phố" Width="148px"></asp:Label></td>
                <td align="center" style="width: 103px">
                    <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Số huyện của tỉnh"
                        Width="71px"></asp:Label></td>
                <td align="center" style="width: 103px">
                    <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Số huyện triển khai"
                        Width="71px"></asp:Label></td>
                <td align="center" style="width: 102px">
                    <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="TS xã của tỉnh"
                        Width="69px"></asp:Label></td>
                <td align="center" style="width: 101px">
                    <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="TS xã triển khai"
                        Width="70px"></asp:Label></td>
                <td align="center" style="width: 101px">
                    <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Số ĐVQL ĐT BN" Width="71px"></asp:Label></td>
                <td align="center" style="width: 101px">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="TS dân số của tỉnh"
                        Width="81px"></asp:Label></td>
                <td align="center" style="width: 100px">
                    <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Số dân triển khai"
                        Width="68px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 226px; height: 24px">
                    <asp:DropDownList ID="cboTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                        DataValueField="MA_TINH" TabIndex="2" Width="194px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="cboTinh"
                        ErrorMessage="Không được để trống"></asp:RequiredFieldValidator></td>
                <td style="width: 103px; height: 24px">
                    <asp:TextBox ID="TxtSLHuyen" runat="server" BorderColor="White" BorderStyle="None"
                        CssClass="ntp_textbox" MaxLength="50" TabIndex="3" Width="71px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="TxtSLHuyen"
                        ErrorMessage="Là số" MaximumValue="99999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
                <td style="width: 103px; height: 24px">
                    <asp:TextBox ID="txtSLHuyenTK" runat="server" BorderColor="White" BorderStyle="None"
                        CssClass="ntp_textbox" MaxLength="50" TabIndex="3" Width="68px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtSLHuyenTK"
                        ErrorMessage="Là số" MinimumValue="0" Type="Double" MaximumValue="99999999999"></asp:RangeValidator></td>
                <td style="width: 102px; height: 24px">
                    <asp:TextBox ID="TxtTSXa" runat="server" BorderColor="White" BorderStyle="None" CssClass="ntp_textbox"
                        MaxLength="50" TabIndex="4" Width="70px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TxtTSXa"
                        ErrorMessage="Là số" MinimumValue="0" Type="Double" MaximumValue="99999999999"></asp:RangeValidator></td>
                <td style="width: 101px; height: 24px">
                    <asp:TextBox ID="TxtTSXaTK" runat="server" BorderColor="White" BorderStyle="None"
                        CssClass="ntp_textbox" MaxLength="50" TabIndex="5" Width="70px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TxtTSXaTK"
                        ErrorMessage="Là số" MinimumValue="0" Type="Double" MaximumValue="99999999999"></asp:RangeValidator></td>
                <td style="width: 101px; height: 24px">
                    <asp:TextBox ID="TxtSoDV" runat="server" BorderColor="White" BorderStyle="None" CssClass="ntp_textbox"
                        MaxLength="50" TabIndex="5" Width="70px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="TxtSoDV"
                        ErrorMessage="Là số" MaximumValue="99999999999" MinimumValue="0" Type="Double"></asp:RangeValidator></td>
                <td style="width: 101px; height: 24px">
                    <asp:TextBox ID="TxtDansoTinh" runat="server" BorderColor="White" BorderStyle="None"
                        CssClass="ntp_textbox" MaxLength="50" TabIndex="6" Width="70px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TxtDansoTinh"
                        ErrorMessage="Là số" MinimumValue="0" Type="Double" MaximumValue="99999999999"></asp:RangeValidator></td>
                <td style="width: 100px; height: 24px">
                    <asp:TextBox ID="TxtDansoTK" runat="server" BorderColor="White" BorderStyle="None"
                        CssClass="ntp_textbox" MaxLength="50" TabIndex="7" Width="70px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="TxtDansoTK"
                        ErrorMessage="Là số" MinimumValue="0" Type="Double" MaximumValue="99999999999"></asp:RangeValidator></td>
            </tr>
        </table>
        <br />
        &nbsp;<asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="8"
            Text="Ghi" Width="100px" /><asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False"
                CssClass="ntp_button" TabIndex="9" Text="Tạo mới" Width="100px" /><asp:Button ID="CmdXoa" runat="server" CausesValidation="False"
                CssClass="ntp_button" TabIndex="10" Text="Xóa" Width="100px" />&nbsp;
        <asp:Literal ID="Literal1" runat="server"></asp:Literal></fieldset>
&nbsp;
