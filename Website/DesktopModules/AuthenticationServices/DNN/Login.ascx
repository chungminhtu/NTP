<%@ Control language="vb" Inherits="DotNetNuke.Modules.Admin.Authentication.Login" CodeFile="Login.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls"%>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>

<table class ="AuthenticationContent" cellspacing="0" cellpadding="3" border="0px" style="width:100%;" >
	<tr>
		<td class="SubHead" align="center" ><dnn:label id="plUsername" controlname="txtUsername" runat="server" resourcekey="Username" /></td>
	</tr>
	<tr>
		<td align="center" ><asp:textbox id="txtUsername" columns="9" width="150" cssclass="NormalTextBox" runat="server" /></td>
	</tr>
	<tr>
		<td class="SubHead" align="center"><dnn:label id="plPassword" controlname="txtPassword" runat="server" resourcekey="Password" /></td>
	</tr>
	<tr>
		<td align="center" ><asp:textbox id="txtPassword" columns="9" width="150" textmode="Password" cssclass="NormalTextBox" runat="server" /></td>
	</tr>
	<tr id="rowVerification1" runat="server" visible="false">
		<td class="SubHead" align="center" ><dnn:label id="plVerification" controlname="txtVerification" runat="server"/></td>
	</tr>
	<tr id="rowVerification2" runat="server" visible="false">
		<td><asp:textbox id="txtVerification" columns="9" width="150" cssclass="NormalTextBox" runat="server" /></td>
	</tr>
    <tr id="trCaptcha1" runat="server">
	    <td class="SubHead" align="center" style="height: 27px"><dnn:label id="plCaptcha" controlname="ctlCaptcha" runat="server" resourcekey="Captcha" /></td>
    </tr>
    <tr id="trCaptcha2" runat="server">
	    <td align="center" ><dnn:captchacontrol id="ctlCaptcha" captchawidth="130" captchaheight="40" cssclass="Normal" runat="server" errorstyle-cssclass="NormalRed" textboxstyle-cssclass="NormalTextBox" /></td>
    </tr>
	<tr>
		<td align="center" ><asp:button id="cmdLogin" resourcekey="cmdLogin" cssclass="StandardButton" text="Login" runat="server" /></td>
	</tr>
</table>
