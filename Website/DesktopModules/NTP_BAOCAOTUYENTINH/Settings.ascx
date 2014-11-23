<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="YourCompany.Modules.NTP_BAOCAOTUYENTINH.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table cellspacing="0" cellpadding="2" border="0" summary="NTP_BAOCAOTUYENTINH Settings Design Table">
     <tr>
        <td class="SubHead" width="150"><dnn:label id="Label1" runat="server" controlname="txtTemplate" suffix=":"></dnn:label></td>
        <td valign="bottom" >
            <asp:radiobuttonlist id="optBCKetQuaDTView" Runat="server" Width="200" CssClass="NormalTextBox" RepeatDirection="Horizontal">
				<asp:ListItem resourcekey="NhapBC" Value="NhapBC">BaocaoTinh</asp:ListItem>
				<asp:ListItem resourcekey="BaoCao" Value="BaoCao">BaocaoHuyen</asp:ListItem>
				
			</asp:radiobuttonlist>
        </td>
    </tr>
    
</table>
