<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_PHIEUCHUYEN.EditNTP_BN_PHIEUCHUYEN" CodeFile="EditNTP_BN_PHIEUCHUYEN.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<table class="ntp_table_main">
    <tr>
        <td colspan="3" style="width: 100%">
            &nbsp;&nbsp;<br /><br /><br />
            <asp:RadioButtonList ID="optlistLoaiYTe" runat="server" Height="18px" RepeatDirection="Horizontal"
                            TabIndex="6" Width="379px" ForeColor="Blue">
                <asp:ListItem Selected="True" Value="1">Bệnh nh&#226;n Chuyển tuyến</asp:ListItem>
                <asp:ListItem Value="0">Bệnh nh&#226;n Chuyển tiếp</asp:ListItem>
            </asp:RadioButtonList>
            <table style="width: 800px">
                <tr>
                    <td style="width: 111px">
                        <asp:Label ID="Label1" runat="server" Text="Ngày chuyển" Width="109px"></asp:Label></td>
                    <td style="width: 52px">
                        <asp:TextBox ID="TxtNgaychuyen" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="1" Width="103px"></asp:TextBox></td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                        <asp:TextBox ID="TxtMabenhnhan" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="1" Width="15px" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="TxtID_Dieutri" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="1" Width="15px" Visible="False"></asp:TextBox>
                    </td>
                    <td style="width: 159px">
                        <asp:TextBox ID="TxtID_Phieuchuyen" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="1" Width="11px" Visible="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <asp:Label ID="Label2" runat="server" Text="Cơ sở tiếp nhận" Width="109px"></asp:Label></td>
                    <td style="width: 52px">
                        <asp:DropDownList ID="cboDVTiepnhan" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                            DataValueField="ID_BENHVIEN" TabIndex="2" Width="218px">
                        </asp:DropDownList></td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                    </td>
                    <td style="width: 159px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <asp:Label ID="Label3" runat="server" Text="Họ tên BN" Width="109px"></asp:Label></td>
                    <td style="width: 52px">
                        <asp:TextBox ID="TxtTenBenhnhan" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="3" Width="392px"></asp:TextBox></td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                        <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Tuổi" Width="38px"></asp:Label></td>
                    <td style="width: 159px">
                        <asp:TextBox ID="txtTuoi" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="4"
                            Width="103px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <asp:Label ID="Label4" runat="server" Text="Số ĐKĐT" Width="109px"></asp:Label></td>
                    <td style="width: 52px">
                        <asp:TextBox ID="TxtSoDKDT" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="5" Width="389px"></asp:TextBox></td>
                    <td style="width: 24px">
                    </td>
                    <td style="width: 56px">
                        <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Giới tính" Width="78px"></asp:Label></td>
                    <td style="width: 159px">
                        <asp:RadioButtonList ID="optlistGioiTinh" runat="server" Height="18px" RepeatDirection="Horizontal"
                            TabIndex="6" Width="101px">
                            <asp:ListItem Selected="True" Value="1">Nam</asp:ListItem>
                            <asp:ListItem Value="0">Nu</asp:ListItem>
                        </asp:RadioButtonList></td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        Tình trạng BN</td>
                    <td colspan="4">
                        <asp:TextBox ID="TxtTinhtrangBN" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="7" Width="670px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <asp:Label ID="Label7" runat="server" Text="Lý do chuyển" Width="109px"></asp:Label></td>
                    <td colspan="4">
                        <asp:TextBox ID="TxtLydo" runat="server" CssClass="ntp_textbox" MaxLength="50"
                            TabIndex="8" Width="670px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 111px">
                    </td>
                    <td colspan="4">
                        <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" TabIndex="9" Text="Ghi phiếu"
                            Width="100px" /><asp:Button ID="cmdCancel" runat="server" CausesValidation="False"
                                CssClass="ntp_button" TabIndex="10" Text="Thoát" Width="100px" /></td>
                </tr>
                <tr>
                    <td style="width: 111px">
                    </td>
                    <td style="width: 52px">
                        &nbsp;&nbsp;
                    </td>
                    <td style="width: 24px">
                        &nbsp;
                    </td>
                    <td style="width: 56px">
                    </td>
                    <td style="width: 159px">
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

