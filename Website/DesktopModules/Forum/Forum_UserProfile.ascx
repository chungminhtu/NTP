<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Forum_UserProfile.ascx.vb" Inherits="DotNetNuke.Modules.Forum.User.Profile" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" align="center"
		width="100%">
		<tr id="rowContent" runat="server">
			<td valign="top" align="center" width="100%">
				<table class="Border" id="tblContent" width="100%" align="center" cellspacing="0" cellpadding="0"
					border="0">
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plAlias" runat="server" controlname="txtAlias" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:label id="txtAlias" runat="server" cssclass="Forum_Normal"></asp:label>&nbsp;&nbsp;
						</td>
					</tr>
                    <tr id="rowPMUser" runat="server">
                        <td class="Forum_Row_AdminL">
                            <dnn:Label ID="plPMUser" runat="server" ControlName="txtAlias" Suffix=":" />
                        </td>
                        <td align="left" class="Forum_Row_AdminR">
							<asp:linkbutton id="cmdPMUser" runat="server" CssClass="Forum_Link" resourcekey="cmdPMUser"></asp:linkbutton></td>
                    </tr>
					<tr id="rowEmail" runat="server">
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plEmail" runat="server" controlname="txtEmail" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left">
							<asp:hyperlink id="lnkEmail" runat="server" CssClass="Forum_Normal"></asp:hyperlink></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plURL" runat="server" controlname="txtURL" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left">
							<asp:hyperlink id="lnkWWW" runat="server" CssClass="Forum_Normal" Target="_blank"></asp:hyperlink></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plMSN" runat="server" controlname="txtMSN" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:label id="txtMSN" runat="server" cssclass="Forum_Normal"></asp:label></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plYahoo" runat="server" controlname="txtYahoo" text="Yahoo:"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:label id="txtYahoo" runat="server" cssclass="Forum_Normal"></asp:label>&nbsp;</td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plAIM" runat="server" controlname="txtAIM" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:label id="txtAIM" runat="server" cssclass="Forum_Normal"></asp:label>&nbsp;</td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="ICQ" runat="server" controlname="txtICQ" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:label id="txtICQ" runat="server" cssclass="Forum_Normal"></asp:label>&nbsp;</td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plStatistic" runat="server" controlname="lblStatistic" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left">
							<p><asp:label id="lblStatistic" Runat="server" CssClass="Forum_Normal"></asp:label><br/>
								<asp:label id="lblJoinedDate" CssClass="Forum_Normal" Runat="server"></asp:label></p>
						</td>
					</tr>
                    <tr>
                        <td class="Forum_Row_AdminL"><dnn:Label ID="plPostCount" runat="server" ControlName="txtAlias" Suffix=":" />
                        </td>
                        <td align="left" class="Forum_Row_AdminR"><asp:label id="lblPostCount" CssClass="Forum_Normal" Runat="server" />
                        </td>
                    </tr>
					<tr>
						<td class="Forum_Row_AdminL"><dnn:Label ID="plViewPosts" runat="server" ControlName="txtAlias" Suffix=":" /></td>
						<td class="Forum_Row_AdminR" align="left">
							<p>
								<asp:hyperlink id="lnkUserPosts" runat="server" CssClass="Forum_Link" resourcekey="lnkUserPosts">[lnkUserPosts]</asp:hyperlink></p>
						</td>
					</tr>
                    <tr id="rowUserAvatar" runat="server">
                        <td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plAvatar" runat="server" ControlName="imgAvatar" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR">
                            <asp:Image ID="imgAvatar" runat="server" /></td>
                    </tr>
                     <tr id="rowSystemAvatar" runat="server">
                        <td class="Forum_Row_AdminL" style="height: 38px"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plSystemAvatar" runat="server" ControlName="" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" style="height: 38px">
                            </td>
                    </tr>
                     <tr id="rowRanking" runat="server">
                        <td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plRanking" runat="server" ControlName="imgRanking" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR">
                            <table border="0" cellpadding="1" cellspacing="0">
                                <tr>
                                    <td><asp:Label ID="lblRankTitle" runat="server" CssClass="Forum_Normal"></asp:Label></td>
                                    <td><asp:Image ID="imgRanking" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr id="rowUserSignature" runat="server">
                        <td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText">
                            <dnn:Label ID="plSignature" runat="server" ControlName="lblSignature" Suffix=":" /></span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR">
                            <asp:Label ID="lblSignature" runat="server" CssClass="Forum_NormalBold"></asp:Label></td>
                    </tr>
				</table>
			</td>
		</tr>
		<tr id="rowModeratorAdmin" valign="top" runat="server">
			<td class="Forum_AltHeader" align="left" width="100%"><dnn:sectionhead id="dshModeratorSettings" runat="server" cssclass="Forum_AltHeaderText"
					resourcekey="ModeratorSettings" isExpanded="False" section="tblModerator"></dnn:sectionhead>
				<table id="tblModerator" cellspacing="0" cellpadding="0" width="100%" runat="server">
					<tr>
						<td class="Forum_Row_AdminL" width="160px"><span class="Forum_Row_AdminText"><dnn:label id="plIsTrusted" runat="server" controlname="chkIsTrusted" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:checkbox id="chkIsTrusted" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
					</tr>
                    <tr id="rowEditUserSig" runat="server">
                        <td class="Forum_Row_AdminL" width="160"><span class="Forum_Row_AdminText"><dnn:label id="plEditUserSig" runat="server" controlname="txtSignature" Suffix=":"></dnn:label>
                        </span></td>
                        <td align="left" class="Forum_Row_AdminR">
                            <asp:TextBox ID="txtSignature" runat="server" CssClass="Forum_NormalTextBox" Rows="4"
                                TextMode="MultiLine" Width="250px"></asp:TextBox></td>
                    </tr>
					<tr id="rowUserBanning" runat="server">
						<td class="Forum_Row_AdminL" width="160px"><span class="Forum_Row_AdminText"><dnn:label id="plUserBanned" runat="server" controlname="chkUserBanned" Suffix=":"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:checkbox id="chkUserBanned" runat="server" CssClass="Forum_NormalTextBox" Enabled="False"></asp:checkbox>&nbsp;<asp:Label ID="lblLiftBan" runat="server" CssClass="Forum_Normal"></asp:Label></td>
					</tr>
				</table>
					</td>
		</tr>
		<tr id="rowFooter" runat="server">
			<td class="Forum_Row_Admin_Foot" valign="top" align="center" width="100%">
							<asp:linkbutton id="cmdUpdate" runat="server" resourcekey="cmdUpdate"
								CssClass="CommandButton"></asp:linkbutton>&nbsp;
							<asp:linkbutton id="cmdCancel" runat="server" resourcekey="cmdCancel"
								CssClass="CommandButton"></asp:linkbutton>&nbsp;
							<asp:linkbutton cssclass="CommandButton" id="cmdManageUser" runat="server" resourcekey="cmdManageUser"></asp:linkbutton>
			</td>
		</tr>
	</table>
