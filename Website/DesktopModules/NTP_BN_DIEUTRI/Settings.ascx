<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="YourCompany.Modules.NTP_BN_DIEUTRI.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table cellspacing="0" cellpadding="2" border="0" summary="NTP_BN_DIEUTRI Settings Design Table">
    <tr>
        <td class="SubHead" width="150"><dnn:label id="lblTemplate" runat="server" controlname="txtTemplate" suffix=":"></dnn:label></td>
        <td valign="bottom" >
           <asp:radiobuttonlist id="optDieuTriView" Runat="server" Width="200" CssClass="NormalTextBox" RepeatDirection="Horizontal">
				<asp:ListItem resourcekey="ChuyenDen" Value="ChuyenDen">Chuyển đến</asp:ListItem>
				<asp:ListItem resourcekey="DieuTri" Value="DieuTri">Điều trị</asp:ListItem>
				
			</asp:radiobuttonlist>
        </td>
    </tr>
</table>
