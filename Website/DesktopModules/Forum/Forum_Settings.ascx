<%@ Control language="vb" CodeBehind="Forum_Settings.ascx.vb" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Forum.Settings" %>
<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" align="center"
		width="100%">
		<tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" width="100%"><dnn:sectionhead id="dshGeneral" runat="server" section="tblGeneral" resourcekey="GeneralSettings"></dnn:sectionhead>
			<table id="tblGeneral" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plForumName" runat="server" Suffix=":" controlname="txtName"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtName" runat="server" cssclass="Forum_NormalTextBox" Columns="26" width="250px"></asp:textbox></td>
				</tr>
				<tr visible="False">
					<td class="Forum_Row_AdminL" width="30%" visible="False"><span class="Forum_Row_AdminText"><dnn:label id="plSourceDirectory" runat="server" Suffix=":" controlname="txtSourceDirectory"></dnn:label></span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtSourceDirectory" runat="server" cssclass="Forum_NormalTextBox" Columns="26"
							width="250px" ReadOnly="True"></asp:textbox></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plAggregatedForums" runat="server" Suffix=":" controlname="chkAggregatedForums"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:checkbox id="chkAggregatedForums" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plTimeZone" runat="server" controlname="chkTimeZone" Suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%">
						<asp:checkbox id="chkTimeZone" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
					<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
						<dnn:label id="plEnableThreadStatus" runat="server" Suffix=":" controlname="chkEnableThreadStatus"></dnn:label></span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%">
						<asp:checkbox id="chkEnableThreadStatus" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
						<dnn:label id="plEnablePostAbuse" runat="server" Suffix=":" controlname="chkEnablePostAbuse"></dnn:label></span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%">
						<asp:checkbox id="chkEnablePostAbuse" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plDisableHTMLPosting" runat="server" ControlName="chkDisableHTMLPosting"
                            Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:CheckBox ID="chkDisableHTMLPosting" runat="server" CssClass="Forum_NormalTextBox" /></td>
                </tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plSearchIndexDate" runat="server" Suffix=":" controlname="chkShowNavigator"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%">
						<asp:Label id="lblDateIndexed" runat="server" CssClass="Forum_Normal"></asp:Label>&nbsp;
						<asp:linkbutton id="cmdResetDate" runat="server" CssClass="Forum_Profile" resourcekey="cmdResetDate"
							text="Reset Date"></asp:linkbutton></td>
				</tr>
			</table>
		</td>
	</tr>
	<tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left" width="100%"><dnn:sectionhead id="dshUserInterface" runat="server" section="tblUserInterface" resourcekey="dshUserInterface" isExpanded="False"></dnn:sectionhead>
			<table id="tblUserInterface" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plThreadsPerPage" runat="server" Suffix=":" controlname="txtThreadsPerPage"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtTheardsPerPage" runat="server" cssclass="Forum_NormalTextBox" Columns="26"
							width="250px"></asp:textbox>&nbsp;<asp:regularexpressionvalidator id="Regularexpressionvalidator6" runat="server" resourcekey="NumericValidation.ErrorMessage"
							ValidationExpression="[0-9]{1,}" ErrorMessage="Needs to be numeric!" ControlToValidate="txtTheardsPerPage" CssClass="Forum_NormalTextBox"></asp:regularexpressionvalidator></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plPostsPerPage" runat="server" Suffix=":" controlname="txtPostsPerPage"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtPostsPerPage" runat="server" cssclass="Forum_NormalTextBox" width="250px"></asp:textbox>&nbsp;<asp:regularexpressionvalidator id="Regularexpressionvalidator7" runat="server" resourcekey="NumericValidation.ErrorMessage"
							ValidationExpression="[0-9]{1,}" ErrorMessage="Needs to be numeric!" ControlToValidate="txtPostsPerPage" CssClass="Forum_NormalTextBox"></asp:regularexpressionvalidator></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plSkin" runat="server" Suffix=":" controlname="ddlSkins"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:dropdownlist id="ddlSkins" runat="server" CssClass="Forum_NormalTextBox" width="250px" AutoPostBack="False"></asp:dropdownlist></td>
				</tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plImageExtension" runat="server" ControlName="txtImageExtension" Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:TextBox ID="txtImageExtension" runat="server" Columns="26" CssClass="Forum_NormalTextBox"
                            Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                   <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plEnableScripts" runat="server" ControlName="chkEnableScripts" Suffix=":"/></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
						<asp:checkbox id="chkEnableScripts" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
                </tr>
                <tr>
                   <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plEnableIconBarAsImages" runat="server" ControlName="chkEnableIconBarAsImages" Suffix=":"/></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
						<asp:checkbox id="chkEnableIconBarAsImages" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
                </tr>
                <tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plDisplayPosterLocation" runat="server" Suffix=":" controlname="chkUserCountry"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:dropdownlist id="ddlDisplayPosterLocation" tabIndex="32" runat="server" cssclass="Forum_NormalTextBox"
							width="250px"></asp:dropdownlist></td>
				</tr>
			</table>
		</td>
	</tr>
	<tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left" width="100%"><dnn:sectionhead id="dshUsers" runat="server" section="tblUsers" resourcekey="dshUsers" isExpanded="False"></dnn:sectionhead>
			<table id="tblUsers" cellspacing="0" cellpadding="0" width="100%" runat="server">
			   <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plNameDisplay" runat="server" ControlName="chkUserCountry" Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:dropdownlist id="ddlNameDisplay" tabIndex="32" runat="server" cssclass="Forum_NormalTextBox"
							width="250px">
                        </asp:dropdownlist></td>
                </tr>
                <tr id="rowUserSkinSelect" runat="server">
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plPerUserTheme" runat="server" ControlName="chkUserSkin" Suffix=":"/></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
						<asp:checkbox id="chkUserSkin" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
                </tr>
			    <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plTrustNewUsers" runat="server" ControlName="chkTrustNewUsers"
                            Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:CheckBox ID="chkTrustNewUsers" runat="server" CssClass="Forum_NormalTextBox" /></td>
                </tr>
                                <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plAutoLockTrust" runat="server" ControlName="chkAutoLockTrust"
                            Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:CheckBox ID="chkAutoLockTrust" runat="server" CssClass="Forum_NormalTextBox" /></td>
                </tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
					        <dnn:label id="plEnableUserSignatures" runat="server" controlname="chkEnableUserSignatures" Suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
					    <asp:checkbox id="chkEnableUserSignatures" runat="server" CssClass="Forum_NormalTextBox" AutoPostBack="True"></asp:checkbox>&nbsp;
					</td>
				</tr>
				<tr id="rowModSigUpdates" runat="server">
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plEnableModSigUpdates" runat="server" Suffix=":" controlname="chkEnableModSigUpdates"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
						<asp:checkbox id="chkEnableModSigUpdates" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
				<tr id="rowHTMLSignatures" runat="server">
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plEnableHTMLSignatures" runat="server" Suffix=":" controlname="chkEnableHTMLSignatures"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
						<asp:checkbox id="chkEnableHTMLSignatures" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
				<tr id="rowUserBanning" runat="server" visible="false">
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plEnableUserBanning" runat="server" Suffix=":" controlname="chkEnableUserBanning"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
						<asp:checkbox id="chkEnableUserBanning" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
			</table>
		</td>
	</tr>
	<tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left" width="100%"><dnn:sectionhead id="dshCommunity" runat="server" section="tblCommunity" resourcekey="dshCommunity" isExpanded="False"></dnn:sectionhead>
			<table id="tblCommunity" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr id="rowUserOnline" runat="server" visible="false">
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plUserOnline" runat="server" text="Enable User Online?" controlname="chkUserOnline"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%"><asp:checkbox id="chkUserOnline" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox>&nbsp;
					</td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plEnablePMSystem" runat="server" Suffix=":" controlname="chkEnablePMSystem"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
						<asp:checkbox id="chkEnablePMSystem" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plEnableMemberList" runat="server" Suffix=":" controlname="chkEnableMemberList"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
						<asp:checkbox id="chkEnableMemberList" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
			</table>
		</td>
	</tr>
	<tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left"><dnn:sectionhead id="dshAttachments" runat="server" section="tblAttachments" resourcekey="PostAttachments" isExpanded="False" width="100%"></dnn:sectionhead>
			<table id="tblAttachments" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr id="rowAttachment" runat="server">
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plAttachment" runat="server" Suffix=":" controlname="chkAttachment"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%"><asp:checkbox id="chkAttachment" runat="server" CssClass="Forum_NormalTextBox"
							AutoPostBack="True"></asp:checkbox>
					</td>
				</tr>
				<tr id="rowAnonDownloads" runat="server">
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
							<dnn:label id="plAnonDownloads" runat="server" Suffix=":" controlname="chkAnonDownloads"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
						<asp:checkbox id="chkAnonDownloads" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
				</tr>
				<tr id="rowAttachmentPath" runat="server" visible="false">
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
						<dnn:label id="plAttachmentPath" runat="server" Suffix=":" controlname="chkAnonDownloads"></dnn:label></span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%"></td>
				</tr>
			</table>
		</td>
	</tr>
		<tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left"><dnn:sectionhead id="dshRSS" runat="server" section="tblRSS"
				resourcekey="RSSFeeds" isExpanded="False" width="100%"></dnn:sectionhead>
			<table id="tblRSS" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plRSSFeeds" runat="server" Suffix=":" controlname="chkRSSFeeds"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%"><asp:checkbox id="chkRSSFeeds" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox>&nbsp;
					</td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plRSSThreadsPerFeed" runat="server" Suffix=":" controlname="txtRSSThreadsPerFeed"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtRSSThreadsPerFeed" runat="server" cssclass="Forum_NormalTextBox" width="250px"></asp:textbox>&nbsp;<asp:regularexpressionvalidator id="Regularexpressionvalidator11" runat="server" resourcekey="NumericValidation.ErrorMessage"
							ValidationExpression="[0-9]{1,}" ErrorMessage="Needs to be numeric!" ControlToValidate="txtRSSThreadsPerFeed" CssClass="NormalRed"></asp:regularexpressionvalidator></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plTTL" runat="server" Suffix=":" controlname="txtTTL"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtTTL" runat="server" cssclass="Forum_NormalTextBox" width="250px"></asp:textbox>&nbsp;<asp:regularexpressionvalidator id="valTTLNumeric" runat="server" resourcekey="NumericValidation.ErrorMessage"
							ValidationExpression="[0-9]{1,}" ErrorMessage="Needs to be numeric!" ControlToValidate="txtTTL" CssClass="NormalRed"></asp:regularexpressionvalidator></td>
				</tr>
			</table>
		</td>
	</tr>
        <tr valign="middle">
            <td align="left" class="Forum_Admin_SectionHead" valign="middle">
                <dnn:sectionhead id="shSpider" runat="server" section="tblSpider" resourcekey="shSpider" isExpanded="False" width="100%"></dnn:sectionhead>
                <table id="tblSpider" cellspacing="0" cellpadding="0" width="100%" runat="server">
				    <tr>
					    <td class="Forum_Row_AdminL" width="30%">
					        <span class="Forum_Row_AdminText">
					            <dnn:label id="plNoFollowWeb" runat="server" Suffix=":" controlname="chkNoFollowWeb"></dnn:label>
						    </span>
						</td>
					    <td class="Forum_Row_AdminR" valign="middle" align="left" width="70%">
					        <asp:checkbox id="chkNoFollowWeb" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox>
					    </td>
				    </tr>
                    <tr>
                        <td class="Forum_Row_AdminL" width="30%">
                            <dnn:label id="plOverrideTitle" runat="server" Suffix=":" controlname="chkOverrideTitle"></dnn:label>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="middle" width="70%">
                            <asp:checkbox id="chkOverrideTitle" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox>
                        </td>
                    </tr>
			    </table>
			</td>
        </tr>
			<tr>
		<td class="Forum_Row_Admin_Foot" align="center" width="100%">
						<asp:linkbutton cssclass="CommandButton" id="cmdUpdate" runat="server" text="Update" resourcekey="cmdUpdate"></asp:linkbutton>&nbsp;
						<asp:linkbutton cssclass="CommandButton" id="cmdCancel" runat="server" text="Cancel" resourcekey="cmdCancel"
							CausesValidation="False"></asp:linkbutton>&nbsp;
        </td>
	</tr>
</table>

