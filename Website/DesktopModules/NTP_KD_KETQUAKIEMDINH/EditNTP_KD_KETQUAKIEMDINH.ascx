<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_KETQUAKIEMDINH.EditNTP_KD_KETQUAKIEMDINH" CodeFile="EditNTP_KD_KETQUAKIEMDINH.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>

<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<br />

<asp:Panel ID="Panel" runat="server" Height="112px" Width="65%">
    <table style="width: 796px">
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
            <td style="width: 211px">
                <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                    DataValueField="ID_BENHVIEN" TabIndex="1" Width="213px">
                </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                    ControlToValidate="cboDonVi" ErrorMessage="Không được trống" Width="148px"></asp:RequiredFieldValidator></td>
            <td align="right" style="width: 53px">
                <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Tháng " Width="54px"></asp:Label></td>
            <td style="width: 22px">
                <asp:DropDownList ID="CboThang" runat="server" CssClass="ntp_combobox" TabIndex="2"
                    Width="71px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList></td>
            <td align="right" style="width: 78px">
                <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Năm" Width="54px"></asp:Label></td>
            <td style="width: 151px">
                <asp:TextBox ID="TxtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3"
                    Width="78px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Text="Ngày lấy mẫu" Width="86px"></asp:Label></td>
            <td style="width: 211px">
                <asp:TextBox ID="txtNgayLM" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="4" Width="109px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                        runat="server" ControlToValidate="txtNgayLM" ErrorMessage="Không được trống"
                        Width="121px"></asp:RequiredFieldValidator>
                <ajaxtoolkit:maskededitextender id="Maskededitextender1" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtNgayLM"> </ajaxtoolkit:maskededitextender>
                <ajaxtoolkit:maskededitvalidator id="Maskededitvalidator1" runat="server" controlextender="MaskedEditExtender1"
                    controltovalidate="txtNgayLM" display="Dynamic" emptyvaluemessage="Bạn phải nhập ngày"
                    invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                    tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator>
            </td>
            <td align="left" colspan="2">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Người cung cấp mẫu"
                    Width="136px"></asp:Label></td>
            <td align="left" colspan="2">
                <asp:TextBox ID="TxtNguoiLM" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="5" Width="241px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="TSTB thực hiện"
                    Width="104px"></asp:Label></td>
            <td style="width: 211px">
                <asp:TextBox ID="TxtTSTBThuchien" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="6" Width="148px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="TxtTSTBThuchien"
                    ErrorMessage="Là số" MaximumValue="99999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td align="left" colspan="2">
                <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Số TB cần KĐ" Width="104px"></asp:Label></td>
            <td align="left" colspan="2">
                &nbsp;<asp:TextBox ID="TxtSoTBCanKD" runat="server" CssClass="ntp_textbox"
                    MaxLength="50" TabIndex="7" Width="148px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TxtSoTBCanKD"
                    ErrorMessage="Là số" MaximumValue="99999999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Nhận xét" Width="86px"></asp:Label></td>
            <td colspan="5">
                <asp:TextBox ID="TxtNhanxet" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="8" Width="653px"></asp:TextBox></td>
        </tr>
    </table>
    <br />
    &nbsp;&nbsp;
    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="7" Text="Ghi"
        Width="100px" />
    <asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False" CssClass="ntp_button"
        TabIndex="7" Text="Tạo mới" Width="100px" />
    <asp:Button ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
        Text="Thoát" Width="100px" TabIndex="7" />
    <asp:TextBox ID="txtId_PhieuLayMau" runat="server" CssClass="ntp_textbox" MaxLength="50"
        TabIndex="44" Width="97px" Visible="False"></asp:TextBox>
    <asp:TextBox ID="NgayKD1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="44"
        Width="109px" Visible="False"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="44"
        Width="109px" Visible="False"></asp:TextBox><br />
    <asp:Panel ID="pnlBaoCao1" runat="server" Visible="false" Width="75%">
        <fieldset class="ntp_fieldset" style="width: 799px; height: 32px">
            <legend class="ntp_legend">Danh sách kiểm định tiêu bản </legend>
            <cc3:multiselectgrid id="grdDSPhieuLayMau" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" width="99%"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit3" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False enabled='<%#Not(DataBinder.Eval(Container.DataItem, "Ketqua")) %>' ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_PLAYMAU_C" HeaderText="ID_PLAYMAU_C" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="SoTB" HeaderText="Số ti&#234;u bản">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KiemdinhH" HeaderText="KĐ Huyện">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KiemdinhT1" HeaderText="KĐ lần 1">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KiemdinhT2" HeaderText="KĐ lần 2">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ghichu" HeaderText="Ghi ch&#250;">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ketqua" HeaderText="Ketqua" Visible="False"></asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
            <br />
            <table style="width: 777px" border="1">
                <tr>
                    <td style="width: 119px">
                        <asp:Label ID="Label23" runat="server" CssClass="ntp_label" Text="Số tiêu bản" Width="122px"></asp:Label></td>
                    <td style="width: 136px">
                        <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Kết quả soi kính Huyện"
                            Width="142px"></asp:Label></td>
                    <td colspan="2">
                        <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Ghi chú" Width="84px"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 119px">
                        <asp:TextBox ID="txtSoTieuBan" runat="server" BorderColor="White" BorderStyle="None"
                            CssClass="ntp_textbox" MaxLength="50" TabIndex="9" Width="111px"></asp:TextBox></td>
                    <td style="width: 136px">
                        <asp:DropDownList ID="cboKetQua" runat="server" CssClass="ntp_combobox" TabIndex="10"
                            Width="135px">
                            <asp:ListItem Selected="True" Value="0">&#194;m</asp:ListItem>
                            <asp:ListItem Value="1">1AFB</asp:ListItem>
                            <asp:ListItem Value="2">2AFB</asp:ListItem>
                            <asp:ListItem Value="3">3AFB</asp:ListItem>
                            <asp:ListItem Value="4">4AFB</asp:ListItem>
                            <asp:ListItem Value="5">5AFB</asp:ListItem>
                            <asp:ListItem Value="6">6AFB</asp:ListItem>
                            <asp:ListItem Value="7">7AFB</asp:ListItem>
                            <asp:ListItem Value="8">8AFB</asp:ListItem>
                            <asp:ListItem Value="9">9AFB</asp:ListItem>
                            <asp:ListItem Value="10">1+</asp:ListItem>
                            <asp:ListItem Value="11">2+</asp:ListItem>
                            <asp:ListItem Value="12">3+</asp:ListItem>
                        </asp:DropDownList></td>
                    <td colspan="2">
                        <asp:TextBox ID="TxtGhichu" runat="server" BorderColor="White" BorderStyle="None"
                            CssClass="ntp_textbox" MaxLength="50" TabIndex="11" Width="383px"></asp:TextBox></td>
                </tr>
            </table>
            <asp:RequiredFieldValidator
                                ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSoTieuBan"
                                ErrorMessage="Không được trống" Width="148px"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtId_PhieuXetNghiemC" runat="server" CssClass="ntp_textbox"
                            MaxLength="50" TabIndex="11" Width="75px" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="txtId_PhieuLayMau_C" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="11" Width="86px" Visible="False"></asp:TextBox><br />
            <table border="0" style="width: 773px">
                <tr>
                    <td style="width: 37px; height: 26px">
                    </td>
                    <td align="center" colspan="9" style="height: 26px; width: 587px;">
                        <asp:Button ID="cmdAddDetail" runat="server" CssClass="ntp_button" TabIndex="11" Text="Ghi"
                            Width="100px" /><asp:Button ID="cmdDelete1"
                                    runat="server" CausesValidation="False" CssClass="ntp_button" TabIndex="13" Text="Xóa"
                                    Width="100px" /></td>
                    <td style="width: 79px; height: 26px">
                    </td>
                </tr>
            </table>
            &nbsp;
        </fieldset>
    </asp:Panel>
</asp:Panel>
