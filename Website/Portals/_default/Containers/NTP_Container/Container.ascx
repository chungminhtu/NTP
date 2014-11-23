<%@ Control language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Containers.Container" %>
<%@ Register TagPrefix="dnn" TagName="SOLPARTACTIONS" Src="~/Admin/Containers/SolPartActions.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ICON" Src="~/Admin/Containers/Icon.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TITLE" Src="~/Admin/Containers/Title.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONBUTTON" Src="~/Admin/Containers/ActionButton.ascx" %>

<link href="/Portals/_default/Containers/NTP_Container/container.css"  rel="stylesheet" type="text/css" />
<table style="border: 0px solid rgb(102, 102, 102);" width="100%" align="center" border="0" cellpadding="0" cellspacing="0" height=100%>

	<tbody><tr>
		<td height=21px>
			<table width="100%" border="0" cellpadding="0" cellspacing="0" height="100%">
				<tbody><tr>
					<td valign="middle" nowrap="nowrap" class ="c_header_title" height=21px><dnn:SOLPARTACTIONS runat="server" id="dnnSOLPARTACTIONS" /></td>
					<td valign="middle" nowrap="nowrap" class ="c_header_title" height=21px></td>
					<td class ="c_header_title" height=21px nowrap="nowrap" height=21px>&nbsp;&nbsp;<dnn:TITLE runat="server" id="dnnTITLE"  cssclass="c_header_title_text" />
					</td>
				</tr>
				</tbody>
			</table>
		</td>
	</tr>
	<tr valign="top">
		<td id="ContentPane" style="padding: 5px;" align="left" runat="server">
		</td>
	</tr>
<tr>
<td>
	<table>
		<tr>
		<td><dnn:ACTIONBUTTON runat="server" id="dnnACTIONBUTTON1" CommandName="AddContent.Action" DisplayIcon="True" DisplayLink="True" /></td>
		<td><dnn:ACTIONBUTTON runat="server" id="dnnACTIONBUTTON2" CommandName="SyndicateModule.Action" DisplayIcon="True" DisplayLink="False" /></td>
		<tr>
	</table>
</td>
</tr>
</tbody>
</table>

