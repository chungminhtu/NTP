<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="YourCompany.Modules.NTP_KD_PLAYMAU.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table cellspacing="0" cellpadding="2" border="0" summary="NTP_KD_PLAYMAU Settings Design Table">
    <tr>
        <td class="SubHead" width="150"><dnn:label id="lblTemplate" runat="server" controlname="txtTemplate" suffix=":"></dnn:label></td>
        <td valign="bottom" >
            <asp:radiobuttonlist id="optKiemDinhView" Runat="server" Width="200" CssClass="NormalTextBox" RepeatDirection="Horizontal">
				<asp:ListItem Value="Lan1">Lần 1</asp:ListItem>
				<asp:ListItem Value="Lan2">Lần 2</asp:ListItem>
				
			</asp:radiobuttonlist>
        </td>
    </tr>
</table>
