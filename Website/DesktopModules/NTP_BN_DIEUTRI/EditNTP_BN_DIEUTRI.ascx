<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_DIEUTRI.EditNTP_BN_DIEUTRI" CodeFile="EditNTP_BN_DIEUTRI.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>


&nbsp;<FIELDSET class="ntp_fieldset" style="width: 768px; height: 906px">
    <table style="width: 788px">
        <tr>
            <td colspan="2" style="height: 26px">
                <asp:Label ID="Label52" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="#0000C0"
                    Text="Thông tin hành chính" Width="306px"></asp:Label></td>
            <td align="right" style="width: 91px; height: 26px">
            </td>
            <td style="width: 154px; height: 26px">
                &nbsp;<asp:TextBox ID="TxtID_DieutriBNC" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="117" Width="51px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TxtID_chuyenden" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="117" Width="51px" Visible="False"></asp:TextBox></td>
            <td style="width: 154px; height: 26px">
                <asp:TextBox ID="txtMaPhieuDieuTri" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="117" Width="47px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="txtMaPhieuChuyen" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="117" Visible="False" Width="47px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 138px; height: 26px">
                <asp:Label ID="Label148" runat="server" CssClass="ntp_label" Text="Ngày tháng ĐK" Width="96px"></asp:Label></td>
            <td style="width: 154px; height: 26px">
                <asp:TextBox id="txtNgayVaoVien" tabIndex=1 runat="server" CssClass="ntp_textbox" MaxLength="50" Width="114px" Font-Bold="False"></asp:TextBox>
                <ajaxtoolkit:maskededitextender id="MaskedEditExtender1" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtNgayVaoVien"> </ajaxtoolkit:maskededitextender>
                </td>
            <td align="right" style="width: 91px; height: 26px">
                &nbsp;<asp:Label ID="Label153" runat="server" CssClass="ntp_label" Text="Số CMND" Width="87px"></asp:Label></td>
            <td style="width: 154px; height: 26px">
                <asp:TextBox ID="txtSoCMT" runat="server" CssClass="ntp_textbox" MaxLength="20" TabIndex="2"
                    Width="146px"></asp:TextBox>&nbsp;
                <asp:TextBox id="txtMaBenhNhan" tabIndex=2 Width="146px" runat="server" CssClass="ntp_textbox" MaxLength="14" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 154px; height: 26px"><asp:Button ID="CmdLoadThongtinBN" runat="server" CssClass="ntp_button" Font-Bold="True" TabIndex="3"
                    Text="..." Width="32px" /></td>
        </tr>
        <tr>
            <td style="width: 138px; height: 26px">
                <asp:Label ID="Label150" runat="server" CssClass="ntp_label" Text="Họ tên bệnh nhân"
                    Width="118px"></asp:Label></td>
            <td style="height: 26px;">
                <asp:TextBox ID="txtTenBN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="4" Width="232px"></asp:TextBox></td>
            <td style="width: 91px; height: 26px;" align="right">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Mã BNQL" Width="88px"></asp:Label></td>
            <td style="height: 26px;">
                <asp:TextBox ID="TxtMaBNQL" runat="server" CssClass="ntp_textbox" MaxLength="14" TabIndex="5" Width="146px"></asp:TextBox></td>
            <td style="height: 26px;">
            </td>
        </tr>
        <tr>
            <td style="width: 138px; height: 26px">
                <asp:Label ID="Label66" runat="server" CssClass="ntp_label" Text="Giới tính" Width="108px"></asp:Label></td>
            <td style="height: 26px">
                <asp:RadioButtonList id="optlistGioiTinh" tabIndex=5 Width="114px" runat="server" RepeatDirection="Horizontal" Height="1px">
                <asp:ListItem Value="1" Selected="True">Nam</asp:ListItem>
                <asp:ListItem Value="0">Nữ</asp:ListItem>
            </asp:RadioButtonList></td>
            <td align="right" style="width: 91px; height: 26px">
                <asp:Label ID="Label152" runat="server" CssClass="ntp_label" Text="Tuổi" Width="57px"></asp:Label></td>
            <td style="height: 26px">
                <asp:TextBox ID="txtTuoi" runat="server" CssClass="ntp_textbox" MaxLength="3" TabIndex="6"
                    Width="76px"></asp:TextBox></td>
            <td style="height: 26px">
            <asp:RangeValidator id="RangeValidator1" runat="server" ErrorMessage="Là số" ControlToValidate="txtSoCMT" Type="Double" MinimumValue="10000000" MaximumValue="9999999999" Width="61px"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 138px; height: 26px">
                <asp:Label ID="Label154" runat="server" CssClass="ntp_label" Text="Địa chỉ" Width="102px"></asp:Label></td>
            <td colspan="4" style="height: 26px">
                <asp:TextBox ID="txtDiaChi" runat="server" CssClass="ntp_textbox" MaxLength="150"
                    TabIndex="7" Width="495px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 138px; height: 26px">
            <asp:Label id="Label16" Width="102px" runat="server" Text="Ghi chú" CssClass="ntp_label"></asp:Label></td>
            <td style="height: 26px" colspan="4">
            <asp:TextBox id="txtDienThoai" tabIndex=8 runat="server" CssClass="ntp_textbox" MaxLength="50" Width="495px"></asp:TextBox> </td>
        </tr>
    </table>
    &nbsp;<br />
    &nbsp;<br />
    <asp:Button ID="CmdDieutri" runat="server" BackColor="WhiteSmoke" BorderColor="PowderBlue"
        BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="11" Text="Thông tin điều trị"
        Width="187px" />
    <asp:Button ID="CmdXetnghiem" runat="server" BackColor="LightCyan" BorderColor="Gainsboro"
        BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="18" Text="Kết quả xét nghiệm"
        Width="180px" />
    <asp:Button ID="CmdKetquaDT" runat="server" BackColor="#C0FFFF" BorderColor="White" BorderStyle="None"
        Font-Bold="True" ForeColor="#0000C0" TabIndex="26" Text="Kết quả điều trị"
        Width="185px" />
    <asp:Button ID="CmdHIV" runat="server" BackColor="#C0FFFF" BorderColor="White" BorderStyle="None"
        Font-Bold="True" ForeColor="#0000C0" TabIndex="26" Text="Lao/ HIV"
        Width="180px" /><br />
    <br />
    <asp:Panel ID="PanelDieutri" runat="server" Height="250px" Width="571px">
        <br />
        <table style="width: 790px">
            <tr>
                <td style="width: 94px">
                <asp:Label ID="Label48" runat="server" CssClass="ntp_label" Text="Đơn vị điều trị"
                    Width="96px"></asp:Label></td>
                <td style="width: 195px">
                <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox"
                    TabIndex="10" Width="193px" DataTextField="TEN_BENHVIEN" DataValueField="ID_BENHVIEN">
                </asp:DropDownList></td>
                <td align="right" style="width: 144px">
                <asp:Label ID="Label49" runat="server" CssClass="ntp_label" Text="Nơi chuyển đến"
                    Width="100px"></asp:Label></td>
                <td style="width: 123px">
                <asp:DropDownList ID="CboNoiChuyenden" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                    DataTextField="Ten_PhacdoDT" DataValueField="ID_PhacdoDT" TabIndex="11" Width="133px">
                <asp:ListItem Value="1">Tự đến</asp:ListItem>
                <asp:ListItem Value="2">Cơ sở c&#244;ng</asp:ListItem>
                <asp:ListItem Value="3">Cơ sở thầy thuốc tư</asp:ListItem>
                <asp:ListItem Value="4">Kh&#225;c</asp:ListItem>
            </asp:DropDownList></td>
                <td style="width: 177px">
                    <asp:TextBox ID="TxtNoidenKhac" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="11" Width="162px" Visible="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px; height: 26px">
                <asp:Label ID="Label50" runat="server" CssClass="ntp_label" Text="Ngày bắt đầu ĐT"
                    Width="106px"></asp:Label></td>
                <td style="width: 195px; height: 26px">
                <asp:TextBox ID="txtNgayBDDT" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="12" Width="115px"></asp:TextBox></td>
                <td align="right" style="width: 144px; height: 26px">
                <asp:Label ID="Label149" runat="server" CssClass="ntp_label" Text="Số ĐK ĐT" Width="89px"></asp:Label></td>
                <td style="width: 123px; height: 26px">
                <asp:TextBox id="txtSoDKDT" tabIndex=13 runat="server" CssClass="ntp_textbox" MaxLength="50" Width="126px"></asp:TextBox></td>
                <td style="width: 177px; height: 26px">
                </td>
            </tr>
            <tr>
                <td colspan="5">
                <ajaxtoolkit:maskededitextender id="Maskededitextender122" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtNgayBDDT"> </ajaxtoolkit:maskededitextender>
                </td>
            </tr>
            <tr>
                <td style="width: 94px">
                <asp:Label ID="Label51" runat="server" CssClass="ntp_label" Text="Phác đồ điều trị"
                    Width="107px"></asp:Label></td>
                <td style="width: 195px">
                <asp:DropDownList ID="cboPhacDoDT" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                    DataTextField="Ten_PhacdoDT" DataValueField="ID_PhacdoDT" TabIndex="14" Width="195px">
                </asp:DropDownList></td>
                <td style="width: 144px">
                <asp:TextBox ID="txtPhacDoKhac" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="15" Width="148px"></asp:TextBox></td>
                <td style="width: 123px">
                </td>
                <td style="width: 177px">
                </td>
            </tr>
            <tr>
                <td style="width: 94px">
                    <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Thay đổi phác đồ"
                        Width="107px"></asp:Label></td>
                <td style="width: 195px">
                    <asp:DropDownList ID="CboPhacdoTD" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                    DataTextField="Ten_PhacdoDT" DataValueField="ID_PhacdoDT" TabIndex="14" Width="195px">
                    </asp:DropDownList></td>
                <td style="width: 144px">
                    <asp:TextBox ID="TxtPhacdoTDKhac" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="15"
                        Width="148px"></asp:TextBox></td>
                <td style="width: 123px">
                </td>
                <td style="width: 177px">
                </td>
            </tr>
            <tr>
                <td style="width: 94px">
                <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Tên, địa chỉ người giám sát"
                    Width="123px"></asp:Label></td>
                <td colspan="4">
                <asp:TextBox ID="txtNguoiGiamSat" runat="server" CssClass="ntp_textbox" Height="36px"
                    MaxLength="50" TabIndex="16" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px">
                <asp:Label ID="Label55" runat="server" CssClass="ntp_label" Text="Phân loại bệnh"
                    Width="121px"></asp:Label></td>
                <td style="width: 195px">
                <asp:DropDownList ID="cboPhanLoaiBenh" runat="server" CssClass="ntp_combobox" DataTextField="Ten_PhanLoaiBenh"
                    DataValueField="ID_PhanLoaiBenh" TabIndex="17" Width="197px" AutoPostBack="True">
                </asp:DropDownList></td>
                <td style="width: 144px">
                <asp:TextBox ID="TxtChandoanLNP" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="15" Width="146px"></asp:TextBox></td>
                <td style="width: 123px">
                <asp:Label ID="Label56" runat="server" CssClass="ntp_label" Text="Phân loại bệnh nhân"
                    Width="129px"></asp:Label></td>
                <td style="width: 177px">
                <asp:DropDownList ID="cboPhanLoaiBenhNhan" runat="server" CssClass="ntp_combobox"
                    DataTextField="Ten_PhanLoaiBN" DataValueField="ID_PhanLoaiBN" TabIndex="18" Width="166px">
                </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 94px">
                </td>
                <td style="width: 195px">
                </td>
                <td style="width: 144px">
                </td>
                <td style="width: 123px">
                </td>
                <td style="width: 177px">
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="PanelXetnghiem" runat="server" Height="400px" Width="745px" >
    <br />
        <table style="width: 805px">
            <tr>
                <td style="width: 97px">
                </td>
                <td align="center" style="width: 2px">
                <asp:Label ID="Label253" runat="server" CssClass="ntp_label" Text="Ngày chụp XQ"
                    Width="102px"></asp:Label></td>
                <td style="width: 56px">
                <asp:TextBox ID="txtNgayXQuangPhoi" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="19" Width="100px"></asp:TextBox></td>
                <td align="right" style="width: 35px">
                <asp:Label ID="Label57" runat="server" CssClass="ntp_label" Text="Kết quả XQ" Width="86px"></asp:Label></td>
                <td align="left" colspan="4">
                <asp:DropDownList ID="cboKetQuaXQuang" runat="server" CssClass="ntp_combobox" TabIndex="20"
                    Width="282px">
                    <asp:ListItem Value="0">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                    <asp:ListItem Value="1">Kh&#244;ng chụp XQ</asp:ListItem>
                    <asp:ListItem Value="2">Kết quả XQ b&#236;nh thường</asp:ListItem>
                    <asp:ListItem Value="3">Kết quả XQ bất thường kh&#244;ng nghi lao</asp:ListItem>
                    <asp:ListItem Value="4">Kết quả XQ bất thường nghi lao</asp:ListItem>
                </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="3">
                <asp:Label ID="Label62" runat="server" CssClass="ntp_label" Font-Bold="True" Font-Italic="False"
                    Text="Trước điều trị" Width="129px"></asp:Label>
                    <asp:Button ID="CmdTruocDT" runat="server" CssClass="ntp_button" Font-Bold="True" TabIndex="21"
                    Text="..." Width="32px" />
                    &nbsp;<ajaxtoolkit:maskededitextender id="Maskededitextender22" runat="server" autocomplete="true"
                        culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtNgayXQuangPhoi"> </ajaxtoolkit:maskededitextender></td>
                <td align="right" style="width: 35px">
                    <asp:TextBox ID="txtId_XNGD0" runat="server" CssClass="ntp_textbox" Enabled="False"
                        MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox></td>
                <td align="left" colspan="4">
                <asp:TextBox ID="txtId_PhieuXetNghiemC0" runat="server" CssClass="ntp_textbox" Enabled="False"
                    MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox>
                    <asp:TextBox ID="txtId_PhieuXetNghiemC2" runat="server" CssClass="ntp_textbox" Enabled="False"
                        MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox>
                    <asp:TextBox ID="txtId_PhieuXetNghiemC5" runat="server" CssClass="ntp_textbox" Enabled="False"
                        MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox>
                        <asp:TextBox ID="txtId_PhieuXetNghiemC7" runat="server" CssClass="ntp_textbox" Enabled="False"
                        MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox>
                        </td>
            </tr>
        <tr>
            <td style="width: 97px">
                </td>
            <td style="width: 2px" align="center">
                <asp:Label ID="Label59" runat="server" CssClass="ntp_label" Text="Ngày XN" Width="97px"></asp:Label></td>
            <td style="width: 56px">
                <asp:TextBox ID="TxtNgayXN0" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="21"
                    Width="100px"></asp:TextBox></td>
            <td style="width: 35px" align="right">
                <asp:Label ID="Label61" runat="server" CssClass="ntp_label" Text="Số XN" Width="55px"></asp:Label>
                </td>
            <td align="center" style="width: 35px">
                <asp:TextBox ID="TxtSoXN0" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="22"
                    Width="64px"></asp:TextBox></td>
            <td style="width: 65px" align="center">
                <asp:Label ID="Label60" runat="server" CssClass="ntp_label" Text="Kết quả" Width="68px"></asp:Label></td>
            <td colspan="2">
                <asp:DropDownList ID="cboKetQua0" runat="server" CssClass="ntp_combobox"
                    TabIndex="23" Width="140px">
                    <asp:ListItem Selected="True" Value="15">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                    <asp:ListItem Value="0">&#194;m</asp:ListItem>
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
        </tr>
            <tr>
                <td style="width: 97px">
                </td>
                <td align="center" style="width: 2px">
                    <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Text="Nuôi cấy" Width="99px"></asp:Label></td>
                <td colspan="6">
                    <asp:TextBox ID="TxtNuoicay0" runat="server" CssClass="ntp_textbox" MaxLength="100"
                        TabIndex="24" Width="470px"></asp:TextBox></td>
            </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="Label263" runat="server" CssClass="ntp_label" Font-Bold="True" Font-Italic="False"
                    Text="Sau 2(3) tháng" Width="132px"></asp:Label>
                <asp:Button ID="CmdXN2T" runat="server" CssClass="ntp_button" Font-Bold="True" TabIndex="25"
                    Text="..." Width="32px" />
                <ajaxtoolkit:maskededitextender id="Maskededitextender3" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayXN0"> </ajaxtoolkit:maskededitextender>
            </td>
            <td style="width: 35px" align="right">
                <asp:TextBox ID="TxtID_XNGD2" runat="server" CssClass="ntp_textbox" Enabled="False"
                    MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox>&nbsp;</td>
            <td align="center" style="width: 35px">
            </td>
            <td style="width: 65px" align="center">
            </td>
            <td style="width: 125px">
            </td>
            <td style="width: 163px">
            </td>
        </tr>
        <tr>
            <td style="width: 97px; height: 26px;">
                </td>
            <td style="width: 2px; height: 26px;" align="center">
                <asp:Label ID="Label268" runat="server" CssClass="ntp_label" Text="Ngày XN" Width="99px"></asp:Label></td>
            <td style="width: 56px; height: 26px;">
                <asp:TextBox ID="TxtNgayXN2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="26"
                    Width="100px"></asp:TextBox></td>
            <td style="width: 35px; height: 26px;" align="right">
                <asp:Label ID="Label269" runat="server" CssClass="ntp_label" Text="Số XN" Width="53px"></asp:Label>
                </td>
            <td align="center" style="width: 35px; height: 26px">
                <asp:TextBox ID="TxtSoXN2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="27"
                    Width="64px"></asp:TextBox></td>
            <td style="width: 65px; height: 26px;" align="center">
                <asp:Label ID="Label270" runat="server" CssClass="ntp_label" Text="Kết quả" Width="68px"></asp:Label></td>
            <td colspan="2" style="height: 26px">
                <asp:DropDownList ID="cboKetQua2" runat="server" CssClass="ntp_combobox"
                    TabIndex="28" Width="140px">
                    <asp:ListItem Selected="True" Value="15">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                    <asp:ListItem Value="0">&#194;m</asp:ListItem>
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
        </tr>
            <tr>
                <td style="width: 97px; height: 26px">
                </td>
                <td align="center" style="width: 2px; height: 26px">
                    <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Nuôi cấy" Width="99px"></asp:Label></td>
                <td colspan="6" style="height: 26px">
                    <asp:TextBox ID="TxtNuoicay1" runat="server" CssClass="ntp_textbox" MaxLength="100"
                        TabIndex="28" Width="470px"></asp:TextBox></td>
            </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="Label363" runat="server" CssClass="ntp_label" Font-Bold="True" Font-Italic="False"
                    Text="Sau 4*,5 tháng" Width="132px"></asp:Label>
                <asp:Button ID="CmdXN5T" runat="server" CssClass="ntp_button" Font-Bold="True" TabIndex="29"
                    Text="..." Width="33px" />
                <ajaxtoolkit:maskededitextender id="Maskededitextender4" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayXN2"> </ajaxtoolkit:maskededitextender>
            </td>
            <td style="width: 35px" align="right">
                <asp:TextBox ID="TxtID_XNGD5" runat="server" CssClass="ntp_textbox" Enabled="False"
                    MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox></td>
            <td align="center" style="width: 35px">
            </td>
            <td style="width: 65px" align="center">
            </td>
            <td style="width: 125px">
            </td>
            <td style="width: 163px">
            </td>
        </tr>
        <tr>
            <td style="width: 97px">
                </td>
            <td style="width: 2px" align="center">
                <asp:Label ID="Label68" runat="server" CssClass="ntp_label" Text="Ngày XN" Width="100px"></asp:Label></td>
            <td style="width: 56px">
                <asp:TextBox ID="TxtNgayXN5" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="30"
                    Width="100px"></asp:TextBox></td>
            <td style="width: 35px" align="right">
                <asp:Label ID="Label369" runat="server" CssClass="ntp_label" Text="Số XN" Width="54px"></asp:Label>
                </td>
            <td align="center" style="width: 35px">
                <asp:TextBox ID="TxtSoXN5" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="31"
                    Width="64px"></asp:TextBox></td>
            <td style="width: 65px" align="center">
                <asp:Label ID="Label370" runat="server" CssClass="ntp_label" Text="Kết quả" Width="68px"></asp:Label></td>
            <td colspan="2">
                <asp:DropDownList ID="cboKetQua5" runat="server" CssClass="ntp_combobox"
                    TabIndex="32" Width="140px">
                    <asp:ListItem Selected="True" Value="15">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                    <asp:ListItem Value="0">&#194;m</asp:ListItem>
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
        </tr>
            <tr>
                <td style="width: 97px">
                </td>
                <td align="center" style="width: 2px">
                    <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Nuôi cấy" Width="99px"></asp:Label></td>
                <td colspan="6">
                    <asp:TextBox ID="TxtNuoicay2" runat="server" CssClass="ntp_textbox" MaxLength="100"
                        TabIndex="32" Width="470px"></asp:TextBox></td>
            </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="Label463" runat="server" CssClass="ntp_label" Font-Bold="True" Font-Italic="False"
                    Text="Sau 6*,7(8) tháng" Width="131px"></asp:Label>
                <asp:Button ID="CmdXN7T" runat="server" CssClass="ntp_button" Font-Bold="True" TabIndex="26"
                    Text="..." Width="33px" />
                <ajaxtoolkit:maskededitextender id="Maskededitextender5" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayXN5"> </ajaxtoolkit:maskededitextender>
            </td>
            <td style="width: 35px" align="right">
                <asp:TextBox ID="TxtID_XNGD7" runat="server" CssClass="ntp_textbox" Enabled="False"
                    MaxLength="50" TabIndex="1" Visible="False" Width="47px"></asp:TextBox></td>
            <td align="center" style="width: 35px">
            </td>
            <td style="width: 65px" align="center">
            </td>
            <td style="width: 125px">
            </td>
            <td style="width: 163px">
            </td>
        </tr>
        <tr>
            <td style="width: 97px">
                </td>
            <td style="width: 2px" align="center">
                <asp:Label ID="Label368" runat="server" CssClass="ntp_label" Text="Ngày XN" Width="98px"></asp:Label></td>
            <td style="width: 56px">
                <asp:TextBox ID="TxtNgayXN7" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="33"
                    Width="100px"></asp:TextBox></td>
            <td style="width: 35px" align="right">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Số XN" Width="54px"></asp:Label>&nbsp;</td>
            <td align="center" style="width: 35px">
                <asp:TextBox ID="TxtSoXN7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="34" Width="64px"></asp:TextBox></td>
            <td style="width: 65px" align="center">
                <asp:Label ID="Label70" runat="server" CssClass="ntp_label" Text="Kết quả" Width="68px"></asp:Label></td>
            <td colspan="2">
                <asp:DropDownList ID="cboKetQua7" runat="server" CssClass="ntp_combobox"
                    TabIndex="35" Width="140px">
                    <asp:ListItem Selected="True" Value="15">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                    <asp:ListItem Value="0">&#194;m</asp:ListItem>
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
        </tr>
            <tr>
                <td style="width: 97px">
                </td>
                <td align="center" style="width: 2px">
                    <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Text="Nuôi cấy" Width="99px"></asp:Label></td>
                <td colspan="6">
                    <asp:TextBox ID="TxtNuoicay3" runat="server" CssClass="ntp_textbox" MaxLength="100"
                        TabIndex="35" Width="470px"></asp:TextBox></td>
            </tr>
        <tr>
            <td style="width: 97px; height: 21px;">
            </td>
            <td style="width: 2px; height: 21px;" align="center">
                <asp:TextBox ID="TxtChon" runat="server" CssClass="ntp_textbox" Visible ="False" MaxLength="50"
                    TabIndex="1" Width="47px" ></asp:TextBox></td>
            <td style="width: 56px; height: 21px;">
                <ajaxtoolkit:maskededitextender id="Maskededitextender6" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayXN7"> </ajaxtoolkit:maskededitextender>
            </td>
            <td style="width: 35px; height: 21px;" align="right">
            </td>
            <td align="center" style="width: 35px; height: 21px">
            </td>
            <td style="width: 65px; height: 21px;" align="center">
            </td>
            <td style="width: 125px; height: 21px;">
            </td>
            <td style="width: 163px; height: 21px">
            </td>
        </tr>
    </table>
    </asp:Panel>
    <asp:Panel ID="PanelHIV" runat="server" Height="200px" Width="778px">
    <table style="width: 795px">
        <tr>
            <td align="left" style="width: 81px; height: 32px">
                <asp:Label ID="Label65" runat="server" CssClass="ntp_label" Text="Trong quý" Width="127px"></asp:Label></td>
            <td align="left" style="width: 8px; height: 32px">
                <asp:DropDownList ID="cboHIVQuy" runat="server" CssClass="ntp_combobox" TabIndex="36"
                    Width="270px">
                    <asp:ListItem Value="0">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                    <asp:ListItem Value="1">1. Kh&#244;ng tư vấn</asp:ListItem>
                    <asp:ListItem Value="2">2. Tư vấn nhưng kh&#244;ng XN HIV</asp:ListItem>
                    <asp:ListItem Value="3">3. Tư vấn, XN HIV kh&#244;ng r&#245; kết quả</asp:ListItem>
                    <asp:ListItem Value="4">4. HIV(-)</asp:ListItem>
                    <asp:ListItem Value="5">5. Kết quả HIV(+) trước khi kh&#225;m &amp; ĐKĐT Lao</asp:ListItem>
                    <asp:ListItem Value="6">6. HIV(+)</asp:ListItem>
                </asp:DropDownList></td>
            <td align="right" rowspan="1" style="width: 78px; height: 32px">
            </td>
            <td align="left" rowspan="1" style="width: 135px; height: 32px">
            </td>
        </tr>
        <tr>
            <td align="left" style="width: 81px; height: 33px;">
                <asp:Label ID="Label71" runat="server" CssClass="ntp_label" Text="Trong QT ĐT lao"
                    Width="108px"></asp:Label></td>
            <td align="left" style="width: 8px; height: 33px;">
                <asp:DropDownList ID="CboHIVLao" runat="server" CssClass="ntp_combobox" TabIndex="36"
                    Width="270px"  AutoPostBack="True">
                <asp:ListItem Value="0">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                <asp:ListItem Value="1">1. Kh&#244;ng tư vấn</asp:ListItem>
                <asp:ListItem Value="2">2. Tư vấn nhưng kh&#244;ng XN HIV</asp:ListItem>
                <asp:ListItem Value="3">3. Tư vấn, XN HIV kh&#244;ng r&#245; kết quả</asp:ListItem>
                <asp:ListItem Value="4">4. HIV(-)</asp:ListItem>
                <asp:ListItem Value="5">5. Kết quả HIV(+) trước khi kh&#225;m &amp; ĐKĐT Lao</asp:ListItem>
                <asp:ListItem Value="6">6. HIV(+)</asp:ListItem>
            </asp:DropDownList></td>
            <td align="right" rowspan="1" style="width: 78px; height: 33px;">
                </td>
            <td align="left" rowspan="1" style="width: 135px; height: 33px;"></td>
        </tr>
        <tr>
            <td align="left" style="width: 81px">
                <asp:Label ID="Label364" runat="server" CssClass="ntp_label" Text="Điều trị ART" Width="124px"></asp:Label></td>
            <td align="left" colspan="3"><asp:DropDownList ID="OptART" runat="server" CssClass="ntp_combobox" TabIndex="36"
                    Width="270px">
                <asp:ListItem Value="0">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                <asp:ListItem Value="1">1. Kh&#244;ng điều trị ARV</asp:ListItem>
                <asp:ListItem Value="2">2. Điều trị ARV trước ĐK điều trị Lao</asp:ListItem>
                <asp:ListItem Value="3">3. Điều trị ARV trong khi điều trị Lao</asp:ListItem>
            </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left" style="width: 81px">
                <asp:Label ID="Label372" runat="server" CssClass="ntp_label" Text="Điều trị CPT" Width="119px"></asp:Label></td>
            <td align="left" colspan="3"><asp:DropDownList ID="OptCPT" runat="server" CssClass="ntp_combobox" TabIndex="36"
                    Width="270px">
                <asp:ListItem Value="0">&quot;--- Chọn kết quả ---&quot;</asp:ListItem>
                <asp:ListItem Value="1">1. Kh&#244;ng ĐT Contrimoxazole </asp:ListItem>
                <asp:ListItem Value="2">2. Điều trị Contrimoxazole trước ĐK điều trị Lao</asp:ListItem>
                <asp:ListItem Value="3">3. Điều trị Contrimoxazole trong khi ĐK điều trị Lao</asp:ListItem>
            </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left" style="width: 81px; height: 33px;">
                <asp:Label ID="Label373" runat="server" CssClass="ntp_label" Text="CD4/ tổng số lympho"
                    Width="130px"></asp:Label></td>
            <td align="left" style="width: 8px; height: 33px;">
                <asp:TextBox ID="txtCD4" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="25"
                    Width="267px"></asp:TextBox></td>
            <td align="right" rowspan="1" style="width: 78px; height: 33px;">
            </td>
            <td align="left" rowspan="1" style="width: 135px; height: 33px;">
            </td>
        </tr>
        <tr>
            <td style="width: 81px; height: 21px;" align="left">
                </td>
            <td style="width: 8px; height: 21px;" align="left">
                </td>
            <td style="width: 78px; height: 21px;" align="right">
                </td>
            <td style="width: 135px; height: 21px;" align="left">
                </td>
        </tr>
    </table>
        &nbsp; &nbsp; &nbsp;
        <br />
    </asp:Panel>
    <asp:Panel ID="PanelKetquaDT" runat="server" Height="250px" Width="176px">
        <table style="width: 799px; height: 51px;">
            <tr>
                <td style="width: 104px; height: 12px;">
                        <asp:Label ID="Label3" runat="server" Text="Ngày kết thúc ĐT" Width="110px"></asp:Label></td>
                <td style="width: 1px; height: 12px;">
                        <asp:TextBox ID="TxtNgayRV" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="40" Width="103px"></asp:TextBox>
                </td>
                <td style="width: 108px; height: 12px;">
                        <asp:Label ID="Label4" runat="server" Text="Kết quả điều trị" Width="101px"></asp:Label></td>
                <td colspan="2" style="width: 395px; height: 12px;">
                    <asp:DropDownList id="CboKetquaDT" tabIndex=4 Width="132px" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" Height="28px">
                        <asp:ListItem Selected="True" Value="0">---Chọn kết quả ĐT---</asp:ListItem>
                        <asp:ListItem Value="1">Khỏi</asp:ListItem>
                        <asp:ListItem Value="2">Ho&#224;n th&#224;nh ĐT</asp:ListItem>
                        <asp:ListItem Value="3">Chết</asp:ListItem>
                        <asp:ListItem Value="4">Thất bại</asp:ListItem>
                        <asp:ListItem Value="5">Bỏ</asp:ListItem>
                        <asp:ListItem Value="6">Chuyển</asp:ListItem>
                        <asp:ListItem Value="7">Kh&#244;ng đ&#225;nh gi&#225;</asp:ListItem>
                    </asp:DropDownList>&nbsp;
                        <asp:TextBox ID="TxtTiepnhanBN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="117" Width="51px" Visible="False"></asp:TextBox>&nbsp;
                    <ajaxtoolkit:maskededitextender id="Maskededitextender7" runat="server" autocomplete="true"
                        culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayRV"> </ajaxtoolkit:maskededitextender>
                </td>
            </tr>
            <tr>
                <td style="width: 104px; height: 12px">
                        <asp:Label ID="Label7" runat="server" Text="Nhận xét" Width="109px"></asp:Label></td>
                <td colspan="4" style="height: 12px">
                        <asp:TextBox ID="TxtGhichu" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="42" Width="643px"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Panel ID="PanelPC" runat="server" Height="50px" Width="797px">
            <table style="width: 793px">
                <tr>
                    <td style="width: 108px; height: 33px">
                        <asp:Label ID="Label10" runat="server" Text="Ngày chuyển" Width="109px"></asp:Label></td>
                    <td style="width: 8px; height: 33px">
                        <asp:TextBox ID="TxtNgaychuyen" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="43" Width="103px"></asp:TextBox>
                    </td>
                    <td colspan="4" style="height: 33px">
                        <asp:RadioButtonList ID="optlistLoaiYTe" runat="server" ForeColor="Blue" Height="18px"
                            RepeatDirection="Horizontal" TabIndex="44" Width="256px" AutoPostBack="True">
                            <asp:ListItem Value="1">BN Chuyển tuyến</asp:ListItem>
                            <asp:ListItem Value="0">BN Chuyển tiếp</asp:ListItem>
                        </asp:RadioButtonList>
                        <ajaxtoolkit:maskededitextender id="Maskededitextender8" runat="server" autocomplete="true"
                            culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgaychuyen"> </ajaxtoolkit:maskededitextender>
                    </td>
                    <td style="height: 33px; width: 278px;">
                    <asp:DropDownList ID="cboTinh" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                        DataTextField="TEN_TINH" DataValueField="MA_TINH" TabIndex="1" Width="179px">
                    </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 108px; height: 33px">
                        <asp:Label ID="Label11" runat="server" Text="Cơ sở tiếp nhận" Width="112px"></asp:Label></td>
                    <td colspan="2" style="height: 33px">
                        <asp:DropDownList ID="cboDVTiepnhan" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                            DataValueField="ID_BENHVIEN" TabIndex="45" Width="229px">
                        </asp:DropDownList></td>
                    <td align="right" colspan="3" style="width: 140px; height: 33px">
                        <asp:Label ID="Label5" runat="server" Text="KQĐT nơi tiếp nhận" Width="127px"></asp:Label></td>
                    <td style="width: 278px; height: 33px">
                        <asp:TextBox ID="TxtKQTiepnhan" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="43"
                            Width="177px" Enabled="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 108px; height: 33px">
                        <asp:Label ID="Label13" runat="server" Text="Tình trạng BN" Width="109px"></asp:Label></td>
                    <td colspan="6" style="height: 33px">
                        <asp:TextBox ID="TxtTinhtrangBN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="46" Width="645px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 108px; height: 33px">
                        <asp:Label ID="Label12" runat="server" Text="Lý do chuyển" Width="109px"></asp:Label></td>
                    <td colspan="6" style="height: 33px">
                        <asp:TextBox ID="TxtLydo" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="47"
                            Width="645px"></asp:TextBox></td>
                </tr>
            </table>
        </asp:Panel>
        <br />
    </asp:Panel>

      <asp:Panel ID="Panelcmd" runat="server"  style="height: 468px Width="798px">
     <asp:Button id="cmdAdd" tabIndex=48 Width="100px" runat="server" Text="Ghi phiếu" CssClass="ntp_button"></asp:Button><asp:Button id="cmdCreateNew" tabIndex=49 Width="100px" runat="server" Text="Tạo mới" CssClass="ntp_button" CausesValidation="False"></asp:Button><asp:Button id="cmdCancel" Width="100px" runat="server" Text="Thoát" CssClass="ntp_button" CausesValidation="False" TabIndex="50"></asp:Button></asp:Panel>
 <br />
    <br />
    <cc3:multiselectgrid id="grdDS" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
        autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
        headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
        itemstyle-cssclass="ntp_grd_RowStyle" multiselect="False" pagerstyle-cssclass="ntp_grd_PagerStyle"
        selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="100%"><Columns>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation = False ></asp:ImageButton>
    
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_Phieuxetnghiem_C" HeaderText="ID_Phieuxetnghiem_C" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="NGAYNM" HeaderText="Ng&#224;y nhận mẫu đờm">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="soXN" HeaderText="Số XN">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Maudom" HeaderText="Mẫu đờm">
<HeaderStyle Width="8%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TrangthaiDom" HeaderText="Trạng th&#225;i đờm đại thể">
<HeaderStyle Width="28%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TENKETQUA" HeaderText="Kết quả">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
    </FIELDSET>

