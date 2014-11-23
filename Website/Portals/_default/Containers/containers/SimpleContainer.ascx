<%@ Control language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Containers.Container" %>
<%@ Register TagPrefix="dnn" TagName="SOLPARTACTIONS" Src="~/Admin/Containers/SolPartActions.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ICON" Src="~/Admin/Containers/Icon.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TITLE" Src="~/Admin/Containers/Title.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONBUTTON" Src="~/Admin/Containers/ActionButton.ascx" %>
<table width="100%" cellspacing="0" cellpadding="8" class="c_all" border = 0px >

<tr>
<td class="c_header" colspan="2">
	<table width="100%" cellspacing="0" cellpadding="0">
	<tr>
		<td><dnn:SOLPARTACTIONS runat="server" id="dnnSOLPARTACTIONS" /></td>
		<td><dnn:ICON runat="server" id="dnnICON" /></td>
		<td style="width:100%;" class="c_header"><dnn:TITLE runat="server" id="dnnTITLE" CssClass="c_header_title" /></td>
	</tr>
	</table>
</td>
</tr>

<tr>
<td class="c_content" id="ContentPane" runat="server" colspan="2" valign=top ></td>
</tr>

<tr>
<td><dnn:ACTIONBUTTON runat="server" id="dnnACTIONBUTTON1" CommandName="AddContent.Action" DisplayIcon="True" DisplayLink="True" /></td>
<td><dnn:ACTIONBUTTON runat="server" id="dnnACTIONBUTTON2" CommandName="SyndicateModule.Action" DisplayIcon="True" DisplayLink="False" /></td>
</tr>
 
</table>

