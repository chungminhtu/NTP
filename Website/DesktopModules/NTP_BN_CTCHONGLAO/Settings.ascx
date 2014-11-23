<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="YourCompany.Modules.NTP_BN_CTCHONGLAO.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table cellspacing="0" cellpadding="2" border="0" summary="NTP_BN_CTCHONGLAO Settings Design Table">
    <tr>
        <td class="SubHead" width="150"><dnn:label id="lblTemplate" runat="server" controlname="txtTemplate" suffix=":"></dnn:label></td>
        <td valign="bottom" >
          &nbsp;<asp:RadioButtonList ID="BaocaoCTCL"  runat="server" CssClass="NormalTextBox"
                RepeatDirection="Horizontal" Width="200">
                <asp:ListItem resourcekey="NhapBC" Value="NhapBC">Nhập báo cáo</asp:ListItem>
                <asp:ListItem resourcekey="BaoCao" Value="BaoCao">Báo cáo</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
</table>
