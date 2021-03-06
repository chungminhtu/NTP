﻿<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_BAOCAOKQKD_IN.ViewNTP_KD_BAOCAOKQKD_IN" CodeFile="ViewNTP_KD_BAOCAOKQKD_IN.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<asp:Panel ID="pnlBaoCao" runat="server" Height="162px" Width="797px">
    <fieldset class="ntp_fieldset" style="width: 803px">
        <legend class="ntp_legend">Báo cáo Kết quả kiểm định</legend>
        <table class="ntp_table_main" style="width: 774px">
            <tbody>
                <tr>
                    <td style="width: 9%; height: 24px">
                    </td>
                    <td style="width: 9%; height: 24px">
                    </td>
                    <td colspan="3" style="height: 24px">
                        &nbsp;<asp:RadioButtonList ID="optlistBaoCao" runat="server" Width="362px">
                            <asp:ListItem Selected="True" Value="1">1. Ph&#226;n loại lỗi v&#224; tỉ lệ lỗi</asp:ListItem>
                            <asp:ListItem Value="55">2. Ph&#226;n loại lỗi v&#224; tỷ lệ lỗi theo Huyện</asp:ListItem>
                            <asp:ListItem Value="2">3. Chất lượng ti&#234;u bản</asp:ListItem>
                            <asp:ListItem Value="66">4. Chất lượng ti&#234;u bản theo Huyện</asp:ListItem>
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
                <td colspan="2" style="width: 219px">
                    <asp:DropDownList ID="cboMien" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                        DataTextField="TEN_MIEN" DataValueField="ID_Mien" TabIndex="1" Width="193px">
                    </asp:DropDownList></td>
                <td style="width: 9px">
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
                <td colspan="2" style="width: 219px">
                    <asp:DropDownList ID="cboTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                        DataValueField="MA_TINH" TabIndex="3" Width="193px">
                    </asp:DropDownList></td>
                <td style="width: 9px">
                    <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Phân loại BV" Width="85px"></asp:Label></td>
                <td style="width: 226px">
                    <asp:DropDownList ID="CboPhanloai" runat="server" CssClass="ntp_combobox" DataTextField="TEN_LOAIBV"
                        DataValueField="ID_LOAIBV" TabIndex="2" Width="212px">
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
                        TabIndex="5" Width="301px">
                        <asp:ListItem Selected="True" Value="0">Nh&#243;m theo Miền</asp:ListItem>
                        <asp:ListItem Value="1">Nh&#243;m theo v&#249;ng</asp:ListItem>
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
            Width="99px" />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal></fieldset>
</asp:Panel>
&nbsp;&nbsp;
