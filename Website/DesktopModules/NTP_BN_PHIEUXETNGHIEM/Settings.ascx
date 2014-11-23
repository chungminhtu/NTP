<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table border="0" cellpadding="2" cellspacing="0" summary="NTP_BN_PHIEUXETNGHIEM Settings Design Table">
    <tr>
        <td class="SubHead" width="150"><dnn:label id="lblTemplate" runat="server" controlname="txtTemplate" suffix=":"></dnn:label></td>
        <td valign="bottom" >
          &nbsp;<asp:TextBox ID="txtTemplate" runat="server" Columns="30" CssClass="NormalTextBox"
                MaxLength="2000" Rows="10" TextMode="MultiLine" Width="390"></asp:TextBox>
        </td>
    </tr>
</table>
