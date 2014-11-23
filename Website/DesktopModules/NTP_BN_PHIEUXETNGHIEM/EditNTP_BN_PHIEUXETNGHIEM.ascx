<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM.EditNTP_BN_PHIEUXETNGHIEM" CodeFile="EditNTP_BN_PHIEUXETNGHIEM.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<fieldset class="ntp_fieldset" style="height: 868px; width: 800px;">
    <fieldset class="ntp_fieldset" style="height: 600px; width: 791px;">
        <legend class="ntp_legend">
        Phiếu xét nghiệm đờm soi trực tiếp </legend>
                    <asp:Label ID="Label52" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="#0000C0"
                        Text="Thông tin hành chính" Width="348px"></asp:Label>
                    <asp:TextBox ID="txtMaPhieuChuyen" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="116" Visible="False" Width="103px"></asp:TextBox>
                    <asp:TextBox ID="txtMaPhieuDieuTri" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="117" Visible="False" Width="103px"></asp:TextBox>
        <ajaxtoolkit:maskededitextender id="Maskededitextender1" runat="server" autocomplete="true"
            culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtNgayXN"> </ajaxtoolkit:maskededitextender>
        <table style="width: 767px">
            <tr>
                <td style="width: 121px; height: 20px">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="ĐV gửi bệnh nhân "
                    Width="111px"></asp:Label></td>
                <td colspan="2" style="height: 20px">
                  <asp:TextBox ID="cboDonVi" runat="server" CssClass="ntp_textbox" MaxLength="100"
                        TabIndex="1" Width="229px"></asp:TextBox></td>
                <td style="height: 20px" colspan="2">
                <asp:RadioButtonList ID="optlistLoaiYTe" runat="server" RepeatDirection="Horizontal"
                    Width="223px" TabIndex="1">
                    <asp:ListItem Value="2">Y tế c&#244;ng</asp:ListItem>
                    <asp:ListItem Value="3">Y tế tư</asp:ListItem>
                    <asp:ListItem Value="1" Selected="True">Tự đến</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label148" runat="server" CssClass="ntp_label" Text="Ngày tháng" Width="96px"></asp:Label></td>
                <td style="width: 79px">
                    <asp:TextBox ID="txtNgayXN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="2" Width="126px"></asp:TextBox></td>
                <td style="width: 98px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNgayXN"
                        ErrorMessage="Không được trống" Width="117px"></asp:RequiredFieldValidator></td>
                <td style="width: 85px">
                <asp:Label ID="Label153" runat="server" CssClass="ntp_label" Text="Số CMND" Width="75px"></asp:Label></td>
                <td style="width: 238px">
                    <asp:TextBox ID="txtSoCMT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="2"
                        Width="134px"></asp:TextBox>
                    <asp:Button ID="CmdLoadThongtinBN" runat="server" CssClass="ntp_button" Font-Bold="True"
                        TabIndex="3" Text="..." Width="32px" />
                    <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="txtSoCMT"
                        ErrorMessage="Là số" MaximumValue="9999999999" MinimumValue="10000000" Type="Double"
                        Width="61px"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label150" runat="server" CssClass="ntp_label" Text="Họ tên bệnh nhân"
                        Width="123px"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txtTenBN" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3"
                        Width="229px"></asp:TextBox></td>
                <td style="width: 85px">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Mã BNQL" Width="81px"></asp:Label></td>
                <td style="width: 238px">
                    <asp:TextBox ID="TxtMaBNQL" runat="server" CssClass="ntp_textbox" MaxLength="15"
                        TabIndex="4" Width="72px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label66" runat="server" CssClass="ntp_label" Text="Giới tính" Width="84px"></asp:Label></td>
                <td colspan="2">
                    <asp:RadioButtonList ID="optlistGioiTinh" runat="server" Height="1px" RepeatDirection="Horizontal"
                        TabIndex="5" Width="171px">
                        <asp:ListItem Selected="True" Value="1">Nam</asp:ListItem>
                        <asp:ListItem Value="0">Nu</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td style="width: 85px">
                    <asp:Label ID="Label152" runat="server" CssClass="ntp_label" Text="Tuổi" Width="57px"></asp:Label></td>
                <td style="width: 238px">
                    <asp:TextBox ID="TxtTuoi" runat="server" CssClass="ntp_textbox" MaxLength="3" TabIndex="6"
                        Width="72px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label154" runat="server" CssClass="ntp_label" Text="Địa chỉ" Width="97px"></asp:Label></td>
                <td colspan="4">
                    <asp:TextBox ID="TxtDiachi" runat="server" CssClass="ntp_textbox" MaxLength="150" TabIndex="7"
                        Width="544px"></asp:TextBox>
                    <asp:TextBox ID="txtMaBenhNhan" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="114"
                        Width="45px" Visible="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label20" runat="server" CssClass="ntp_label" Text="Ghi chú" Width="107px"></asp:Label></td>
                <td colspan="4">
                    <asp:TextBox ID="txtDienThoai" runat="server" CssClass="ntp_textbox" MaxLength="150" TabIndex="8"
                        Width="544px"></asp:TextBox></td>
            </tr>
        </table>
        <table style="width: 768px">
            <tr>
                <td style="width: 135px; height: 68px">
                <asp:Label ID="Label100" runat="server" CssClass="ntp_label" Text="Lý do xét nghiệm" Width="107px"></asp:Label><br />
                    <br />
                </td>
                <td colspan="2" style="height: 68px; width: 96px;">
                <asp:RadioButtonList ID="optlistLyDo" runat="server"
                    Width="112px" Height="44px" TabIndex="9" AutoPostBack="True">
                    <asp:ListItem Value="0" Selected="True">Ph&#225;t hiện </asp:ListItem>
                    <asp:ListItem Value="1">theo d&#245;i:</asp:ListItem>
                </asp:RadioButtonList></td>
                <td style="width: 140px; height: 68px">
                    <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Số mẫu đờm yêu cầu"
                        Width="146px"></asp:Label><br />
                    <br />
                    <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Số tháng điều trị"
                        Width="153px"></asp:Label><br />
                </td>
                <td style="width: 123px; height: 68px">
                <asp:TextBox ID="txtSoMauDom" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="10" Width="67px" Height="24px"></asp:TextBox><asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtSoMauDom"
                    ErrorMessage="Là số" Type="Double" MaximumValue="9999" MinimumValue="0" Width="35px">Là số</asp:RangeValidator><br />
                 <asp:DropDownList ID="txtSoThangDT" runat="server" CssClass="ntp_combobox" Width="106px" TabIndex="11" Enabled="False">
                        <asp:ListItem></asp:ListItem>                       
                        <asp:ListItem Value="2">2,(3) th&#225;ng</asp:ListItem>
                        <asp:ListItem Value="3">4*,5 (th&#225;ng)</asp:ListItem>
                        <asp:ListItem Value="4">6*,7,(8) th&#225;ng</asp:ListItem>
                    </asp:DropDownList><br />
                </td>
                <td style="height: 68px; width: 318px;" colspan="2">
                    &nbsp;<asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Htest(+)"></asp:Label>
                <asp:CheckBox ID="chkHtest" runat="server" TabIndex="12" Width="96px" /><br />
                    &nbsp;<asp:Label ID="Label149" runat="server" CssClass="ntp_label" Text="Số ĐKĐT" Width="73px"></asp:Label><asp:TextBox ID="txtSoDKDT" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="13" Width="70px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 135px; height: 24px;">
                    <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="ĐVTiếp nhận" Width="111px"></asp:Label></td>
                <td colspan="5" style="height: 24px;"><asp:DropDownList ID="CboTinh" runat="server" CssClass="ntp_combobox" TabIndex="14"
                        Width="195px" AutoPostBack="True" DataTextField="TEN_TINH" DataValueField="MA_TINH">
                </asp:DropDownList><asp:DropDownList ID="CboHuyen" runat="server" CssClass="ntp_combobox" TabIndex="15"
                        Width="196px" DataTextField="TEN_BENHVIEN" DataValueField="ID_BENHVIEN">
                </asp:DropDownList>&nbsp;</td>
                <td style="width: 144px; height: 24px;">
                </td>
            </tr>
        </table>
        &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <br />
          <asp:Panel   ID="Panel1" runat="server"   style="width: 700px; height: 280px"><table style="width: 764px">
            <tr>
                    <td style="width: 76px">
                    </td>
                    <td colspan="2" align="center">
            <asp:Label ID="Label22" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="#0000C0"
                Text="KẾT QUẢ XÉT NGHIỆM" Width="223px"></asp:Label></td>
                    <td style="width: 150px">
                <asp:TextBox ID="txtId_PhieuXetNghiemC" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="111" Width="74px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="txtId_PhieuXetNghiem" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="112" Width="49px" Visible="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 76px">
                <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Text="Số xét nghiệm" Width="98px"></asp:Label></td>
                <td align="left" colspan="2">
                            <asp:TextBox ID="txtSoXetNghiem" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="16" Width="73px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSoXetNghiem"
                    ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
                <td style="width: 50px">
                </td>
            </tr>
        </table>
            <asp:Panel ID="Panel2" runat="server" Height="91px" Width="762px">
           
                <cc3:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                    AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                    HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                    ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%" height="150px" pagesize="5" bordercolor="Teal" borderwidth="1px" cellpadding="0" tabindex="17"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton>
    
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_Phieuxetnghiem_C" HeaderText="ID_Phieuxetnghiem_C" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="TEN_NGAYNM" HeaderText="Ng&#224;y nhận mẫu ">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Maudom" HeaderText="Mẫu đờm">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TrangthaiDom" HeaderText="Trạng th&#225;i đờm đại thể">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KetQua" HeaderText="Kết quả">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" PageButtonCount="5" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:MultiSelectGrid>
            <table style="width: 764px; height: 100px;" border="0">
                <tr>
                    <td style="width: 145px; height: 12px">
                <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Ngày nhận mẫu"
                    Width="126px"></asp:Label></td>
                    <td style="width: 191px; height: 12px">
                <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="18" Width="96px"></asp:TextBox>
                        <ajaxtoolkit:maskededitextender id="Maskededitextender11" runat="server" autocomplete="true"
                            culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtTungay"> </ajaxtoolkit:maskededitextender>
                    </td>
                    <td style="width: 58px; height: 12px">
                        <asp:Label ID="Label18" runat="server" CssClass="ntp_label" Text="Mẫu đờm" Width="64px"></asp:Label></td>
                    <td style="width: 291px; height: 12px">
                <asp:TextBox ID="txtMauDom" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="20"
                    Width="97px"></asp:TextBox><asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSoMauDom"
                    ErrorMessage="Là số" Type="Integer" MaximumValue="99" MinimumValue="0"></asp:RangeValidator></td>
                </tr>
                <tr>
                    <td style="height: 12px;">
                <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Trạng thái đờm đại thể"
                    Width="142px"></asp:Label></td>
                    <td style="width: 191px">
                    <asp:DropDownList ID="cboTrangThaiDom" runat="server" CssClass="ntp_combobox"
                        TabIndex="19" Width="191px">
                        <asp:ListItem Selected="True" Value="0">&quot;--- Chọn trạng th&#225;i ---&quot;</asp:ListItem>
                        <asp:ListItem Value="M&#225;u">M&#225;u</asp:ListItem>
                        <asp:ListItem Value="Nh&#224;y mủ">Nh&#224;y mủ</asp:ListItem>
                        <asp:ListItem Value="Nước bọt">Nước bọt</asp:ListItem>
                    </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="cboTrangThaiDom"
                        ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
                    <td style="width: 58px">
                <asp:Label ID="Label131" runat="server" CssClass="ntp_label" Text="Kết quả" Width="58px"></asp:Label></td>
                    <td style="width: 291px">
                    <asp:DropDownList ID="cboKetQua" runat="server" CssClass="ntp_combobox" TabIndex="21"
                        Width="143px">
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
                    </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="cboKetQua"
                        ErrorMessage="Không được trống" Width="143px"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="height: 26px">
                    </td>
                    <td style="width: 191px; height: 26px;">
                    </td>
                    <td style="width: 58px; height: 26px;">
                    </td>
                    <td align="right" style="width: 291px; height: 26px;">
                        <asp:Button ID="CmdNewC" runat="server" CausesValidation="False" CssClass="ntp_button"
                            TabIndex="22" Text="Ghi KQ" Width="74px" />
                        <asp:Button ID="cmdDeleteC" runat="server" CausesValidation="False"
            CssClass="ntp_button" Text="Xóa KQ" Width="70px" TabIndex="23" /></td>
                </tr>
            </table>
            </asp:Panel>
</asp:Panel>
    </fieldset>
                    <table style="width: 766px">
                        <tr>
                            <td style="width: 158px; height: 16px">
                            </td>
                            <td colspan="2" style="height: 16px; width: 531px;">
                    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="24" Text="Ghi "
                            Width="100px" />
                                <asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False" CssClass="ntp_button"
                            TabIndex="25" Text="Tạo mới" Width="100px" />
                    <asp:Button ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                            Text="Thoát" Width="100px" TabIndex="26" /></td>
                        </tr>
                    </table>
</fieldset>