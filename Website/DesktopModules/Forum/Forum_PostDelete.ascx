<%@ Control language="vb" CodeBehind="Forum_PostDelete.ascx.vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.Modules.Forum.PostDelete" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%"
		align="center">
		<tr>
			<td class="Forum_Row_AdminL" valign="top">
				<span class="Forum_Row_AdminText">
					<dnn:label id="plDeleteTemplate" runat="server" controlname="ddlDeleteTemplate"
						resourcekey="plDeleteTemplate" Suffix=":"></dnn:label>
				</span></td>
			<td class="Forum_Row_AdminR">
				<asp:DropDownList id="ddlDeleteTemplate" runat="server" Width="250px" AutoPostBack="True" CssClass="Forum_NormalTextBox"></asp:DropDownList></td>
		</tr>
		<tr>
			<td class="Forum_Row_AdminL" valign="top">
				<span class="Forum_Row_AdminText">
					<dnn:label id="plReason" runat="server" controlname="txtReason" Suffix=":"></dnn:label>
				</span>
			</td>
			<td class="Forum_Row_AdminR"><asp:textbox id="txtReason" runat="server" Width="350px" Height="150px" TextMode="MultiLine"></asp:textbox>
				<asp:requiredfieldvalidator id="valEmailedResponse" runat="server" resourcekey="valEmailedResponse" CssClass="NormalRed"
					ControlToValidate="txtReason"></asp:requiredfieldvalidator></td>
		</tr>
		<tr>
			<td class="Forum_AltHeader" align="left" colspan="2">
				<table cellspacing="0" cellpadding="0" border="0" width="100%">
					<tr>
						<td><asp:label id="lblSubject" runat="server" CssClass="Forum_AltHeaderText"></asp:label></td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td class="Forum_Row_Admin" align="left" colspan="2"><asp:label id="lblAuthor" runat="server" CssClass="Forum_Normal"></asp:label></td>
		</tr>
		<tr>
			<td class="Forum_Row_Admin" align="left" colspan="2"><asp:label id="lblMessage" runat="server" CssClass="Forum_Normal"></asp:label></td>
		</tr>
		<tr>
			<td class="Forum_Row_Admin_Foot" align="center" colspan="2">
				<asp:linkbutton cssclass="CommandButton" id="cmdCancel" runat="server" resourcekey="cmdCancel" CausesValidation="False">
				</asp:linkbutton>&nbsp;<asp:linkbutton cssclass="CommandButton" id="cmdDelete" runat="server" resourcekey="cmdDelete"></asp:linkbutton></td>
		</tr>
	</table>
