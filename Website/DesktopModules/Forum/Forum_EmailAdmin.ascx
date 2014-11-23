<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Control language="vb" CodeBehind="Forum_EmailAdmin.ascx.vb" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Forum.EmailAdmin" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
        <tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left"><dnn:sectionhead id="shEmailGeneral" runat="server" section="tblEmailGeneral" isExpanded="True" width="100%" ResourceKey="shEmailGeneral"></dnn:sectionhead>
			<table id="tblEmailGeneral" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plNofify" runat="server" controlname="chkNotify" suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:checkbox id="chkNotify" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plEnableEditEmails" runat="server" ControlName="chkEnableEditEmails" Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:CheckBox ID="chkEnableEditEmails" runat="server" CssClass="Forum_NormalTextBox" /></td>
                </tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plAutomatedAddress" runat="server" controlname="txtAutomatedAddress" suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtAutomatedAddress" runat="server" cssclass="Forum_NormalTextBox" width="250px"
							Columns="26"></asp:textbox></td>
				</tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plEmailAddressDisplayName" runat="server" ControlName="txtEmailAddressDisplayName" Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:TextBox ID="txtEmailAddressDisplayName" runat="server" Columns="26" CssClass="Forum_NormalTextBox"
                            Width="250px"></asp:TextBox></td>
                </tr>
			</table>
		</td>
	</tr>
		<tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left"><dnn:sectionhead id="shAdvanced" runat="server" section="tblAdvanced" isExpanded="False" width="100%" ResourceKey="shAdvanced"></dnn:sectionhead>
			<table id="tblAdvanced" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plEmailQueueTask" runat="server" Suffix=":" controlname="chkEmailQueueTask"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%"><asp:checkbox id="chkEmailQueueTask" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox>
					</td>
				</tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                    </td>
                    <td align="left" class="Forum_Row_AdminR" valign="middle" width="70%">
                        <asp:LinkButton ID="cmdHostEmail" runat="server" class="Forum_Link" resourcekey="cmdHostEmail"></asp:LinkButton></td>
                </tr>
			</table>
		</td>
	</tr>
  <tr>
		<td class="Forum_Row_Admin_Foot" align="center" width="100%">
		    <asp:linkbutton class="CommandButton" id="cmdManageTemplates" runat="server" resourcekey="cmdManageTemplates"></asp:linkbutton>&nbsp;
	        <asp:linkbutton class="CommandButton" id="cmdUpdate" runat="server" resourcekey="cmdUpdate"></asp:linkbutton>&nbsp;
			<asp:linkbutton class="CommandButton" id="cmdCancel" runat="server" resourcekey="cmdCancel" CausesValidation="False"></asp:linkbutton>
		</td>
	</tr>
</table>
