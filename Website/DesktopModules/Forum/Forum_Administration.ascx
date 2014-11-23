<%@ Control Inherits="DotNetNuke.Modules.Forum.Administration" CodeBehind="Forum_Administration.ascx.vb" language="vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
		<tr>
			<td class="Forum_Row_Admin" valign="top" align="center" width="100%">
			<table style="width: 90%;" align="center" border="0" cellpadding="5" cellspacing="1"><tbody>
<tr>
<td colspan="4" align="center">
							<table cellspacing="0" cellpadding="0" border="0">
								<tr>
									<td align="center"><asp:imagebutton id="imgForumHome" runat="server" resourcekey="imgForumHome"></asp:imagebutton></td>
								</tr>
                                <tr>
                                    <td align="center">
                                        <asp:linkbutton id="cmdForumHome" runat="server" resourcekey="cmdForumHome" CssClass="Forum_NormalBold"></asp:linkbutton></td>
                                </tr>
							</table>
</td>
</tr>
<tr>
<td valign="top" align="left"><asp:imagebutton id="imgGeneralSettings" runat="server" resourcekey="imgGeneralSettings"></asp:imagebutton></td>
<td valign="top" align="left"><asp:linkbutton id="cmdManageSettings" runat="server" resourcekey="cmdManageSettings" CssClass="Forum_NormalBold"></asp:linkbutton><br />
							<asp:label id="lblGeneralSettings" runat="server" resourcekey="lblGeneralSettings" CssClass="Forum_Normal"></asp:label></td>
<td valign="top" align="right"><asp:linkbutton id="cmdManageForums" runat="server" resourcekey="cmdManageForums" CssClass="Forum_NormalBold"></asp:linkbutton>
    <br />
							<asp:label id="lblManageForums" runat="server" resourcekey="lblManageForums" CssClass="Forum_Normal"></asp:label></td>
<td valign="top" align="right"><asp:imagebutton id="imgManageForums" runat="server" resourcekey="imgManageForums"></asp:imagebutton></td>
</tr>
<tr>
<td valign="top" align="left"><asp:imagebutton id="imgManageUsers" runat="server" resourcekey="imgManageUsers"></asp:imagebutton></td>
<td valign="top" align="left"><asp:linkbutton id="cmdManageUsers" runat="server" resourcekey="cmdManageUsers" CssClass="Forum_NormalBold"></asp:linkbutton><br />
							<asp:label id="lblManageUsers" runat="server" resourcekey="lblManageUsers" CssClass="Forum_Normal"></asp:label></td>
<td valign="top" align="right"><asp:linkbutton id="cmdWordFilter" runat="server" resourcekey="cmdWordFilter" CssClass="Forum_NormalBold"></asp:linkbutton><br />
							<asp:label id="lblWordFilter" runat="server" resourcekey="lblWordFilter" CssClass="Forum_Normal"></asp:label></td>
<td valign="top" align="right"><asp:imagebutton id="imgWordFilter" runat="server" resourcekey="imgWordFilter"></asp:imagebutton></td>
</tr>
<tr>
<td valign="top" align="left"><asp:imagebutton id="imgGallery" runat="server" resourcekey="imgGallery"></asp:imagebutton></td>
<td valign="top" align="left">
							<asp:linkbutton id="cmdGallery" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdGallery"></asp:linkbutton><br />
							<asp:label id="lblGallerySmile" runat="server" CssClass="Forum_Normal" resourcekey="lblGallerySmile"></asp:label></td>
<td valign="top" align="right">
							<asp:linkbutton id="cmdStatsRanks" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdStatsRanks"></asp:linkbutton><br />
							<asp:label id="lblRankings" runat="server" CssClass="Forum_Normal" resourcekey="lblRankings"></asp:label></td>
<td valign="top" align="right">
							<asp:imagebutton id="imgRankings" runat="server" resourcekey="imgRankings"></asp:imagebutton></td>
</tr>
<tr>
<td valign="top" align="left" style="height: 50px"><asp:imagebutton id="imgEmail" runat="server" resourcekey="imgGallery"></asp:imagebutton></td>
<td valign="top" align="left" style="height: 50px">
							<asp:linkbutton id="cmdEmail" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdEmail"></asp:linkbutton><br />
							<asp:label id="lblEmail" runat="server" CssClass="Forum_Normal" resourcekey="lblEmail"></asp:label></td>
<td valign="top" align="right" style="height: 50px">
							<asp:linkbutton id="cmdTemplates" runat="server" CssClass="Forum_NormalBold" resourcekey="cmdTemplates"></asp:linkbutton><br />
							<asp:label id="lblTemplates" runat="server" CssClass="Forum_Normal" resourcekey="lblTemplates"></asp:label></td>
<td valign="top" align="right" style="height: 50px">
							<asp:imagebutton id="imgTemplates" runat="server" resourcekey="imgTemplates"></asp:imagebutton></td>
</tr>
</tbody></table>
			</td>
		</tr>
		<tr>
			<td class="Forum_Row_Admin_Foot" valign="top" align="center" width="100%">&nbsp;</td>
</tr>
	</table>
