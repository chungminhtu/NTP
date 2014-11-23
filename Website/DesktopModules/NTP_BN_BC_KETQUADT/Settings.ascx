<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="YourCompany.Modules.NTP_BN_BC_KETQUADT.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table cellspacing="0" cellpadding="2" border="0" summary="NTP_BN_BC_KETQUADT Settings Design Table">
    <tr>
        <td class="SubHead" width="150"><dnn:label id="lblTemplate" runat="server" controlname="txtTemplate" suffix=":"></dnn:label></td>
        <td valign="bottom" >
            <asp:radiobuttonlist id="optBCKetQuaDTView" Runat="server" Width="200" CssClass="NormalTextBox" RepeatDirection="Horizontal">
				<asp:ListItem resourcekey="NhapBC" Value="NhapBC">Nhập báo cáo</asp:ListItem>
				<asp:ListItem resourcekey="BaoCao" Value="BaoCao">Báo cáo</asp:ListItem>
				
			</asp:radiobuttonlist>
        </td>
    </tr>
</table>
