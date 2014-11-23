<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Forum_BadWordEdit.ascx.vb" Inherits="DotNetNuke.Modules.Forum.BadWordEdit" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
		<tr>
			<td class="Forum_Row_AdminL" valign="top" align="left" width="200px">
                <dnn:label id="plBadWord" runat="server" controlname="txtBadWord" Suffix=":"></dnn:label>
            </td>
			<td align="left" class="Forum_Row_AdminR" width="80%"><asp:textbox id="txtBadWord" runat="server" Width="250px" cssclass="Forum_NormalTextBox"></asp:textbox>
                <asp:RequiredFieldValidator ID="valBadWord" runat="server" resourcekey="valRequired" ControlToValidate="txtBadWord"></asp:RequiredFieldValidator></td>
		</tr>
		<tr>
			<td class="Forum_Row_AdminL" valign="top" align="left" width="200px">
                <dnn:label id="plReplacedWord" runat="server" controlname="txtReplacedWord" Suffix=":"></dnn:label>  
            </td>
			<td align="left" class="Forum_Row_AdminR" width="80%"><asp:textbox id="txtReplacedWord" runat="server" cssclass="Forum_NormalTextBox" width="250px"></asp:textbox>
                <asp:RequiredFieldValidator ID="valReplaceWord" runat="server" resourcekey="valRequired" ControlToValidate="txtReplacedWord"></asp:RequiredFieldValidator></td>
		</tr>
		<tr id="rowFooter" runat="server">
			<td class="Forum_Row_Admin_Foot" align="center" width="100%" colspan="2">
							<asp:linkbutton class="CommandButton" id="cmdUpdate" resourcekey="cmdUpdate" runat="server"></asp:linkbutton>&nbsp;
							<asp:linkbutton class="CommandButton" id="cmdCancel" resourcekey="cmdCancel" runat="server" CausesValidation="False"></asp:linkbutton>&nbsp;
							<asp:linkbutton class="CommandButton" id="cmdDelete" resourcekey="cmdDelete" runat="server" CausesValidation="False"></asp:linkbutton>
			</td>
		</tr>
	</table>
