<%@ Control Inherits="DotNetNuke.Modules.Forum.GroupEdit" CodeBehind="Forum_GroupEdit.ascx.vb" language="vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<script language="javascript" type="text/javascript" src='<%= Page.ResolveUrl("DesktopModules/Forum/Popup/forumpopup.js") %>'></script>
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%"
		align="center">
		<tr>
			<td valign="top" align="left" width="100%">
				<table id="tblGroup" cellspacing="0" cellpadding="0" width="100%" border="0" class="">
					<tr id="rowGroupID" runat="server">
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><DNN:LABEL id="plGroupID" runat="server" controlname="txtGroupID"  Suffix=":"></DNN:LABEL>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtGroupID" runat="server" Enabled="False" width="250px" cssclass="Forum_NormalTextBox"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><DNN:LABEL id="plGroupName" runat="server" controlname="txtGroupName"  Suffix=":"></DNN:LABEL>
							</span></td>
						<td class="Forum_Row_AdminR"><asp:textbox id="txtGroupName" runat="server" width="250px" cssclass="Forum_NormalTextBox"></asp:textbox><asp:label id="lblForumCount" runat="server" CssClass="Forum_NormalBold"></asp:label></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><DNN:LABEL id="plGroupCreatedBy" runat="server" controlname="txtGroupCreatorName" Suffix=":"></DNN:LABEL>
							</span></td>
						<td class="Forum_Row_AdminR"><asp:textbox id="txtGroupCreatorName" runat="server" Enabled="False" width="250px" cssclass="Forum_NormalTextBox"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><DNN:LABEL id="plGroupCreatedDate" runat="server" controlname="txtGroupCreatedDate" Suffix=":"></DNN:LABEL>
							</span></td>
						<td class="Forum_Row_AdminR"><asp:textbox id="txtGroupCreatedDate" runat="server" Enabled="False" width="250px" cssclass="Forum_NormalTextBox"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><DNN:LABEL id="plGroupUpdatedBy" runat="server" controlname="txtGroupCreatorName"  Suffix=":"></DNN:LABEL>
							</span></td>
						<td class="Forum_Row_AdminR"><asp:textbox id="txtUpdatedByUser" runat="server" Enabled="False" width="250px" cssclass="Forum_NormalTextBox"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><DNN:LABEL id="plGroupUpdatedDate" runat="server" controlname="txtGroupCreatorName"  Suffix=":"></DNN:LABEL>
							</span></td>
						<td class="Forum_Row_AdminR"><asp:textbox id="txtUpdatedDate" runat="server" Enabled="False" width="250px" cssclass="Forum_NormalTextBox"></asp:textbox></td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td align="center" width="100%" class="Forum_Row_Admin_Foot">
				<ASP:LINKBUTTON class="CommandButton" id="cmdAdd" runat="server" resourcekey="cmdAdd"></ASP:LINKBUTTON>
				<ASP:LINKBUTTON class="CommandButton" id="cmdUpdate" runat="server" resourcekey="cmdUpdate"></ASP:LINKBUTTON>&nbsp;
				<ASP:LINKBUTTON class="CommandButton" id="cmdCancel" resourcekey="cmdCancel" runat="server" text="Cancel"></ASP:LINKBUTTON>&nbsp;
				<ASP:LINKBUTTON class="CommandButton" id="cmdDelete" runat="server" resourcekey="cmdDelete"></ASP:LINKBUTTON>
			</td>
		</tr>
	</table>
