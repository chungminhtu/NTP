<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="YourCompany.Modules.NTP_BN_BC_KETQUAXN.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table border="0" cellpadding="2" cellspacing="0" summary="NTP_BN_BC_KETQUADT Settings Design Table">
    <tr>
        <td class="SubHead" width="150">
            <dnn:Label ID="lblTemplate" runat="server" ControlName="txtTemplate" Suffix=":" />
        </td>
        <td valign="bottom">
            <asp:RadioButtonList ID="optBCKQXetnghiem" runat="server" CssClass="NormalTextBox"
                RepeatDirection="Horizontal" Width="200">
                <asp:ListItem resourcekey="NhapBC" Value="NhapBC">Nhập báo cáo</asp:ListItem>
                <asp:ListItem resourcekey="BaoCao" Value="BaoCao">Báo cáo</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
</table>
