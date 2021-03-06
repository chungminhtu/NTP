<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_BC_KETQUAXN.EditNTP_BN_BC_KETQUAXN" CodeFile="EditNTP_BN_BC_KETQUAXN.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<asp:Panel ID="pnlMain" runat="server" Height="217px" Width="758px">
    <fieldset class="ntp_fieldset" style="width: 739px">
        <table style="width: 789px">
            <tbody>
                <tr>
                    <td style="width: 131px">
                    </td>
                    <td style="width: 42px">
                    </td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                        &nbsp;<asp:TextBox ID="TxtID_Ketqua" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            Visible="False" Width="29px"></asp:TextBox>
                    </td>
                    <td style="width: 144px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 131px">
                        <asp:Label ID="Label11" runat="server" Text="Cơ sở y tế" Width="109px"></asp:Label></td>
                    <td style="width: 42px">
                        <asp:DropDownList ID="cboDonvi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                            DataValueField="ID_BENHVIEN" TabIndex="1" Width="275px">
                        </asp:DropDownList></td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                    </td>
                    <td style="width: 144px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 131px">
                        <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Quý" Width="103px"></asp:Label></td>
                    <td style="width: 42px">
                        <asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="2"
                            Width="89px">
                            <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                            <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                            <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                            <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
                        </asp:DropDownList></td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                        <asp:Label ID="Label4" runat="server" Text="Năm" Width="109px"></asp:Label></td>
                    <td style="width: 144px">
                        <asp:TextBox ID="TxtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3"
                            Width="103px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 131px">
                        <asp:Label ID="Label9" runat="server" Text="Ngày báo cáo" Width="109px"></asp:Label></td>
                    <td style="width: 42px">
                        <asp:TextBox ID="TxtNgayBC" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="4" Width="87px"></asp:TextBox>
                        <ajaxtoolkit:maskededitextender id="MaskedEditExtender1" runat="server" autocomplete="true"
                            culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayBC"> </ajaxtoolkit:maskededitextender>
                        <ajaxtoolkit:maskededitvalidator id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                            controltovalidate="TxtNgayBC" display="Dynamic" emptyvaluemessage="Bạn phải nhập ngày"
                            invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                            tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator>
                    </td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                        <asp:Label ID="Label3" runat="server" Text="Người báo cáo" Width="109px"></asp:Label></td>
                    <td style="width: 144px">
                        <asp:TextBox ID="TxtNguoiBC" runat="server" CssClass="ntp_textbox" ForeColor="Black"
                            MaxLength="50" TabIndex="5" Width="187px"></asp:TextBox></td>
                </tr>
            </tbody>
        </table><table style="width: 787px" border="0">
            <tr>
                <td align="center" colspan="2" style="height: 28px">
                </td>
                <td align="center" style="height: 28px">
                </td>
                <td align="left" style="height: 28px">
                </td>
                <td align="left" style="width: 620px; height: 28px">
                </td>
                <td align="left" style="height: 28px">
                    <asp:Button ID="CmdXem" runat="server" CssClass="ntp_button" TabIndex="5" Text="Xem"
                        Width="79px" /></td>
            </tr>
        </table>
        &nbsp;&nbsp;
        <table style="width: 789px" border="1">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label19" runat="server" ForeColor="#0000C0" Text="Số BN dương tính đăng ký trong quý"
                        Width="268px" Font-Bold="True"></asp:Label></td>
                <td align="center">
                    <asp:Label ID="Label15" runat="server" ForeColor="#0000C0" Text="Tháng XN" Width="83px" Font-Bold="True"></asp:Label></td>
                <td align="left">
                    <asp:Label ID="Label16" runat="server" ForeColor="#0000C0" Text="Dương tính" Width="119px" Font-Bold="True"></asp:Label></td>
                <td align="left">
                    <asp:Label ID="Label17" runat="server" ForeColor="#0000C0" Text="Âm tính" Width="122px" Font-Bold="True"></asp:Label></td>
                <td align="left">
                    <asp:Label ID="Label18" runat="server" ForeColor="#0000C0" Text="Không xét nghiệm"
                        Width="124px" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 66px; height: 38px">
                    <asp:Label ID="Label2" runat="server" Text="Mới" Width="81px" Font-Bold="True"></asp:Label></td>
                <td style="width: 106px; height: 38px">
                                <asp:Label ID="TxtMoi" runat="server" BorderWidth="0px" Font-Bold="True" ForeColor="Black" Width="123px"></asp:Label></td>
                <td style="height: 38px">
                    <asp:Label ID="Label20" runat="server" Text="Sau 2 tháng đtrị" Width="109px" Font-Bold="True"></asp:Label></td>
                <td style="height: 38px">
                    <asp:TextBox ID="TxtDuongHai" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="8" Width="79px" BorderColor="White" BorderStyle="None"   ></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TxtDuongHai"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="38px"></asp:RangeValidator></td>
                <td style="height: 38px">
                    <asp:TextBox ID="TxtAmHai" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="9"
                        Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="TxtAmHai"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                <td style="height: 38px">
                    <asp:TextBox ID="TxtKhongHai" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="10" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="TxtKhongHai"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td style="width: 66px; height: 38px">
    <asp:Label ID="Label6" runat="server" Text="Điều trị lại" Width="82px" Font-Bold="True"></asp:Label></td>
                <td style="width: 106px; height: 38px">
                                <asp:Label ID="TxtTaitri" runat="server" BorderWidth="0px" Font-Bold="True" ForeColor="Black" Width="121px"></asp:Label></td>
                <td style="height: 38px">
                    <asp:Label ID="Label21" runat="server" Text="Sau 3 tháng đtrị" Width="109px" Font-Bold="True"></asp:Label></td>
                <td style="height: 38px">
                    <asp:TextBox ID="TxtDuongBa" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="11" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="TxtDuongBa"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                <td style="height: 38px">
                    <asp:TextBox ID="TxtAmBa" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12"
                        Width="80px" ForeColor="Black" BorderColor="White" BorderStyle="None"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="TxtAmBa"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                <td style="height: 38px">
                    <asp:TextBox ID="TxtKhongBa" runat="server" CssClass="ntp_textbox" ForeColor="Black"
                        MaxLength="50" TabIndex="13" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="TxtKhongBa"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            </tr>
        </table>
                    </fieldset>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <table style="width: 803px">
        <tbody>
            <tr>
                <td style="width: 205px; height: 26px">
                    </td>
                <td colspan="4" style="height: 26px; width: 611px;">
                    <asp:Button ID="CmdSave" runat="server" CssClass="ntp_button" TabIndex="14" Text="Ghi"
                        Width="100px" />
                    <asp:Button ID="CmdAddNew" runat="server" CssClass="ntp_button" TabIndex="15" Text="Tạo mới"
                        Width="100px" />
                    <asp:Button ID="cmdCancel" runat="server" CausesValidation="False"
                            CssClass="ntp_button" TabIndex="16" Text="Thoát" Width="100px" /></td>
            </tr>
        </tbody>
    </table>
</asp:Panel>
&nbsp; &nbsp;
