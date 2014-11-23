<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_BAOCAOTUYENTINH.ViewNTP_KD_BAOCAOTUYENTINH" CodeFile="ViewNTP_KD_BAOCAOTUYENTINH.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<fieldset class="ntp_fieldset" style="width: 772px">
    <legend class="ntp_legend">Báo cáo thống kê tuyến Tỉnh</legend>
    <table class="ntp_table_main">
        <tbody>
            <tr>
                <td style="width: 3%; height: 24px">
                </td>
                <td style="width: 3%; height: 24px">
                </td>
                <td colspan="3" style="height: 24px">
                    &nbsp;<asp:RadioButtonList ID="optlistBaoCao" runat="server" Width="362px" AutoPostBack="True">
                        <asp:ListItem Selected="True" Value="HoatdongXN">B&#225;o c&#225;o hoạt động x&#233;t nghiệm</asp:ListItem>
                        <asp:ListItem Value="KiemdinhTB">B&#225;o c&#225;o kết quả kiểm định ti&#234;u bản</asp:ListItem>
                         <asp:ListItem Value="11">Số ti&#234;u bản thực hiện theo huyện</asp:ListItem>
                        <asp:ListItem Value="44">T&#236;nh h&#236;nh thừ đờm ph&#225;t hiện theo Huyện</asp:ListItem>

                    </asp:RadioButtonList>
                    &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cboTinh"
                        ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 3%">
                </td>
                <td style="width: 3%">
                    <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="51px"></asp:Label></td>
                <td style="width: 28%">
                    <asp:DropDownList ID="cboTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                        DataValueField="MA_TINH" TabIndex="3" Width="263px" AutoPostBack="True">
                    </asp:DropDownList>
                    </td>
                <td style="width: 3%">
                    <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Huyện" Width="55px"></asp:Label></td>
                <td style="width: 20%">
                    <asp:DropDownList ID="CmbHuyen" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                        DataValueField="ID_BENHVIEN" TabIndex="2" Width="201px">
                    </asp:DropDownList>
                    <asp:TextBox ID="TxtNgaybc" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="4" Visible="false" Width="96px" Wrap="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 3%">
                </td>
                <td style="width: 3%">
                    <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Quý" Width="50px"></asp:Label></td>
                <td style="width: 28%">
                    <asp:CheckBox ID="chkQuy1" runat="server" TabIndex="13" Text="Quý 1" Width="66px" /><asp:CheckBox
                        ID="chkQuy2" runat="server" TabIndex="13" Text="Quý 2" Width="66px" /><asp:CheckBox
                            ID="chkQuy3" runat="server" TabIndex="13" Text="Quý 3" Width="66px" /><asp:CheckBox
                                ID="chkQuy4" runat="server" TabIndex="13" Text="Quý 4" Width="66px" />
                    <asp:CheckBox ID="ChkNam" runat="server" TabIndex="13" Text="Năm" Width="56px" AutoPostBack="True" /></td>
                <td style="width: 3%">
                    <asp:Label ID="Label8" runat="server" CssClass="ntp_label"
                            Text="Năm" Width="52px"></asp:Label></td>
                <td style="width: 20%">
                <asp:TextBox ID="txtNamBC" runat="server" CssClass="ntp_textbox"
                                MaxLength="50" TabIndex="5" Width="85px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNamBC"
                        ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td colspan="2">
                </td>
                <td style="width: 28%">
                    <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="#C00000"
                        Text="Lựa chọn số liệu báo cáo" Width="221px"></asp:Label></td>
                <td style="width: 3%">
                </td>
                <td style="width: 20%">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                </td>
                <td style="width: 28%">
                    <asp:RadioButtonList ID="optPLBaocao" runat="server" ForeColor="Blue" Height="18px"
                        RepeatDirection="Horizontal" TabIndex="44" Width="383px">
                        <asp:ListItem Value="0">Từ Phiếu lấy mẫu</asp:ListItem>
                        <asp:ListItem Selected="True" Value="1">Từ số liệu BC Nhập</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td style="width: 3%">
                </td>
                <td style="width: 20%">
                    <asp:CheckBox ID="ChkCapnhatDL" runat="server" TabIndex="13" Text="Cập nhật vào BC Quý"
                        Width="197px" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Người báo cáo"
                        Width="112px"></asp:Label></td>
                <td style="width: 28%">
                    <asp:TextBox ID="TxtNguoiBC" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="4" Width="198px"></asp:TextBox></td>
                <td style="width: 3%">
                </td>
                <td style="width: 20%">
                </td>
            </tr>
        </tbody>
    </table>
    <asp:Button ID="Button1" runat="server" CssClass="ntp_button" Height="25px" Text="In báo cáo"
        Width="144px" />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal><br />
</fieldset>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
&nbsp;
