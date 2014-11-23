<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BAOCAOTUYENTINH.ViewNTP_BAOCAOTUYENTINH" CodeFile="ViewNTP_BAOCAOTUYENTINH.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="PnlTinh" runat="server" Height="400px" Width="787px">

<fieldset class="ntp_fieldset" style="width: 772px">
    <table class="ntp_table_main" style="width: 774px"><tbody>
        <tr>
            <td style="width: 3%; height: 24px">
            </td>
            <td colspan="4" style="height: 24px">
                <asp:Label ID="Label1" runat="server" BorderColor="GhostWhite" CssClass="ntp_label"
                    Font-Bold="True" ForeColor="#0000C0" Text="BÁO CÁO  TUYẾN TỈNH" Width="328px"></asp:Label></td>
        </tr>
            <tr>
                <td style="width: 3%; height: 24px">
                </td>
                <td style="width: 3%; height: 24px">
                </td>
                <td colspan="3" style="height: 24px">
                    &nbsp;<asp:RadioButtonList ID="OptBCTuyenTinh" runat="server" Width="473px" AutoPostBack="True">
                        <asp:ListItem Selected="True" Value="Thunhan">1.T&#236;nh h&#236;nh thu nhận bệnh nh&#226;n Lao</asp:ListItem>
                         <asp:ListItem Value="Thunhantheohuyenquy">2. T&#236;nh h&#236;nh thu nhận Bệnh nh&#226;n Lao theo Huyện</asp:ListItem>
                        <asp:ListItem Value="Dieutri">3. Kết quả điều trị Lao</asp:ListItem>
                        <asp:ListItem Value="4">4. Kết quả điều trị Bệnh nh&#226;n theo huyện</asp:ListItem>
                        <asp:ListItem Value="Amhoadom">5. Kết quả &#226;m ho&#225; đờm sau 2(3) th&#225;ng điều trị</asp:ListItem>
                        <asp:ListItem Value="AmhoadomH">6. Kết quả &#226;m h&#243;a đờm theo Huyện</asp:ListItem>
                        <asp:ListItem Value="ChuongtrinhCL">7. Quản l&#253; chương tr&#236;nh chống Lao</asp:ListItem>
                    </asp:RadioButtonList>
                    &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cboTinh"
                        ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 3%">
                </td>
                <td style="width: 3%">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="54px"></asp:Label></td>
                <td style="width: 25%">
                    <asp:DropDownList ID="cboTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                        DataValueField="MA_TINH" TabIndex="1" Width="201px" AutoPostBack="True">
                    </asp:DropDownList>
                    </td>
                <td style="width: 3%">
                    <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Huyện" Width="66px"></asp:Label></td>
                <td style="width: 20%"><asp:DropDownList id="CmbHuyen" tabIndex="2" Width="201px" runat="server" CssClass="ntp_combobox" DataValueField="ID_BENHVIEN" DataTextField="TEN_BENHVIEN">
                </asp:DropDownList>
                    <asp:TextBox ID="TxtNgaybc" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="4" Width="96px" Wrap="False"  Visible="false" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 3%">
                </td>
                <td style="width: 3%">
                    <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Quý" Width="54px"></asp:Label></td>
                <td style="width: 25%">
                    <asp:CheckBox ID="chkQuy1" runat="server" TabIndex="13" Text="Quý 1" Width="60px" /><asp:CheckBox
                        ID="chkQuy2" runat="server" TabIndex="13" Text="Quý 2" Width="66px" /><asp:CheckBox
                            ID="chkQuy3" runat="server" TabIndex="13" Text="Quý 3" Width="66px" /><asp:CheckBox
                                ID="chkQuy4" runat="server" TabIndex="13" Text="Quý 4" Width="66px" />
                    <asp:CheckBox
                                ID="ChkNam" runat="server" TabIndex="13" Text="Năm" Width="55px" AutoPostBack="True" /></td>
                <td style="width: 3%">
                    <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Năm" Width="66px"></asp:Label></td>
                <td style="width: 20%">
                <asp:TextBox ID="txtNamBC" runat="server" CssClass="ntp_textbox"
                                MaxLength="50" TabIndex="4" Width="96px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNamBC"
                        ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
            </tr>
        <tr>
            <td align="center" colspan="2" style="height: 26px">
                <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Người báo cáo"
                    Width="112px"></asp:Label></td>
            <td style="width: 25%; height: 26px;">
                <asp:TextBox ID="TxtNguoiBC" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="4"
                    Width="198px"></asp:TextBox></td>
            <td style="width: 3%; height: 26px;">
            </td>
            <td style="width: 20%; height: 26px;">
            </td>
        </tr>
        </tbody>
    </table>
    <asp:Button ID="CmdIN_Tinh" runat="server" CssClass="ntp_button" Height="25px" Text="In báo cáo"
        Width="127px" TabIndex="4" />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal><br />
    <br />
</fieldset>
</asp:Panel>
<asp:Panel ID="PnlHuyen" runat="server" Height="400px" Width="786px"><table style="WIDTH: 774px" class="ntp_table_main"><tbody><tr><td style="WIDTH: 6%; HEIGHT: 24px"></td><td style="HEIGHT: 24px" colspan="4"><asp:Label id="Label2" Width="328px" runat="server" Text="BÁO CÁO  TUYẾN HUYỆN" ForeColor="#0000C0" Font-Bold="True" CssClass="ntp_label" BorderColor="GhostWhite"></asp:Label></td></tr><tr><td style="WIDTH: 6%; HEIGHT: 24px"></td><td style="WIDTH: 4%; HEIGHT: 24px"></td><td style="HEIGHT: 24px" colspan="3">&nbsp;<asp:RadioButtonList id="OptBCTuyenHuyen" tabIndex="5" Width="425px" runat="server" AutoPostBack="True"><asp:ListItem Selected="True" Value="Thunhan">T&#236;nh h&#236;nh thu nhận bệnh nh&#226;n Lao</asp:ListItem>
<asp:ListItem Value="Dieutri">Kết quả điều trị Lao</asp:ListItem>
<asp:ListItem Value="Amhoadom">Kết quả &#226;m ho&#225; đờm sau 2(3) th&#225;ng điều trị</asp:ListItem>
    <asp:ListItem Value="HoatdongXN">B&#225;o c&#225;o hoạt động x&#233;t nghiệm</asp:ListItem>
    <asp:ListItem Value="Xetnghiem_PHDuong">Danh s&#225;ch BN x&#233;t nghiệm Ph&#225;t hiện dương t&#237;nh</asp:ListItem>
    <asp:ListItem Value="Xetnghiem_AM">Danh s&#225;ch BN x&#233;t nghiệm Ph&#225;t hiện &#226;m t&#237;nh</asp:ListItem>
</asp:RadioButtonList> &nbsp;&nbsp;<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Không được trống" ControlToValidate="CboDonviBC"></asp:RequiredFieldValidator>
    <asp:RangeValidator id="RangeValidator2" runat="server" Type="Integer" MinimumValue="1900" MaximumValue="3000" ErrorMessage="Không đúng năm" ControlToValidate="tctNamBC"></asp:RangeValidator></td></tr><tr><td style="WIDTH: 6%"></td><td style="WIDTH: 4%"><asp:Label id="Label3" Width="91px" runat="server" Text="Cơ sở điều trị" CssClass="ntp_label"></asp:Label></td><td style="WIDTH: 10%"><asp:DropDownList id="CboDonviBC" tabIndex="6" Width="208px" runat="server" CssClass="ntp_combobox" DataValueField="ID_BENHVIEN" DataTextField="TEN_BENHVIEN">
                </asp:DropDownList> </td><td style="WIDTH: 3%"><asp:Label id="Label4" Width="66px" runat="server" Text="Quý" CssClass="ntp_label"></asp:Label></td><td style="WIDTH: 20%"><asp:DropDownList id="CboQuyBC" tabIndex="7" Width="89px" runat="server" CssClass="ntp_combobox" AutoPostBack="True">
                    <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                    <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                    <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                    <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
                </asp:DropDownList> <asp:Label id="Label7" Width="46px" runat="server" Text="Năm" CssClass="ntp_label"></asp:Label><asp:TextBox id="tctNamBC" tabIndex="8" Width="96px" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox> </td></tr>
    <tr>
        <td style="width: 6%">
        </td>
        <td style="width: 4%">
            <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Từ ngày" Width="91px"></asp:Label></td>
        <td style="width: 10%">
            <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                TabIndex="12" Width="106px"></asp:TextBox></td>
        <td style="width: 3%">
            <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Đến ngày" Width="65px"></asp:Label></td>
        <td style="width: 20%">
            <asp:TextBox ID="TxtDenngay" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12"
                Width="106px"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="5">
            <br />
            <ajaxtoolkit:maskededitextender id="MaskedEditExtender1" runat="server" autocomplete="true"
                culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtTuNgay"> </ajaxtoolkit:maskededitextender>
            <ajaxtoolkit:maskededitextender id="Maskededitextender2" runat="server" autocomplete="true"
                culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtDenngay"> </ajaxtoolkit:maskededitextender>
        </td>
    </tr>
    <tr><td style="WIDTH: 6%"></td><td align="center" colspan="3">
        &nbsp;<asp:Label ID="Label13" runat="server" CssClass="ntp_label" Font-Bold="True"
            ForeColor="#C00000" Text="Lựa chọn số liệu báo cáo" Width="221px"></asp:Label></td><td style="WIDTH: 20%">
        &nbsp;</td></tr>
    <tr>
        <td style="width: 6%">
        </td>
        <td colspan="3">
            <asp:RadioButtonList ID="optPLBaocao" runat="server" ForeColor="Blue" Height="18px"
                RepeatDirection="Horizontal" TabIndex="44" Width="383px">
                <asp:ListItem Value="0">Từ phiếu ĐK bệnh nh&#226;n</asp:ListItem>
                <asp:ListItem Selected="True" Value="1">Từ số liệu BC Nhập</asp:ListItem>
            </asp:RadioButtonList></td>
        <td style="width: 20%">
            <asp:CheckBox ID="ChkCapnhatDL" runat="server" TabIndex="13" Text="Cập nhật vào BC Quý" Width="197px" Visible="False"/></td>
    </tr>
</tbody></table><asp:Button id="CmdIN_Huyen" tabIndex="9" Width="127px" Height="25px" runat="server" Text="In báo cáo" CssClass="ntp_button"></asp:Button><asp:Literal id="Literal2" runat="server"></asp:Literal>
    </asp:Panel>
