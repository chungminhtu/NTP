<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Control Inherits="DotNetNuke.Modules.Forum.TemplateAdmin" CodeBehind="Forum_TemplateAdmin.ascx.vb" language="vb" AutoEventWireup="false" Explicit="True" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%"
		align="center">
		<tr>
			<td class="Forum_Row_Admin" valign="top" align="center" width="100%">
				<table id="Table4" cellspacing="0" cellpadding="0" width="400" border="0">
					<tr>
						<td></td>
						<td></td>
					</tr>
					<tr>
						<td width="260"><asp:linkbutton id="cmdEmailTemplates" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdEmailTemplates"></asp:linkbutton></td>
						<td width="260"><asp:linkbutton id="cmdWhatsNewTemplates" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdWhatsNewTemplates"></asp:linkbutton></td>
					</tr>
					<tr>
						<td width="260"><asp:linkbutton id="cmdRSSTemplates" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdRSSTemplates"></asp:linkbutton></td>
						<td width="260"><asp:linkbutton id="cmdSkinTemplates" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdSkinTemplates"></asp:linkbutton></td>
					</tr>
					<tr>
						<td height="10"><asp:linkbutton id="cmdPostStatsTemplates" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdPostStatsTemplates"></asp:linkbutton></td>
						<td height="10">
                            <asp:LinkButton ID="cmdModeratorStats" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdModeratorStats"></asp:LinkButton></td>
					</tr>
					<tr>
						<td width="260">
                            <asp:LinkButton ID="cmdPostMoveTemplates" runat="server" CssClass="Forum_NormalBold"
                                resourcekey="cmdPostMoveTemplates"></asp:LinkButton></td>
						<td width="260">
                            <asp:LinkButton ID="cmdPostDeleteTemplates" runat="server" CssClass="Forum_NormalBold"
                                resourcekey="cmdPostDeleteTemplates"></asp:LinkButton></td>
					</tr>
					<tr>
						<td></td>
						<td></td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td class="Forum_Row_Admin_Foot" align="center" width="100%">
                            <asp:LinkButton ID="cmdCancel" runat="server" class="CommandButton" resourcekey="cmdCancel"
                                Text="Cancel"></asp:LinkButton></td>
		</tr>
	</table>
