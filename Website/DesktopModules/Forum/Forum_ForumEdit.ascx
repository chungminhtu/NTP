<%@ Register TagPrefix="dnnforum" Namespace="DotNetNuke.Modules.Forum.Controls" Assembly="DotNetNuke.Modules.Forum" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="Portal" TagName="URL" Src="~/controls/URLControl.ascx" %>
<%@ Register TagPrefix="Portal" TagName="Tracking" Src="~/controls/URLTrackingControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="sectionhead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Control language="vb" CodeBehind="Forum_ForumEdit.ascx.vb" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Forum.ForumEdit" %>
<%@ Register TagPrefix="DNN" Namespace="DotNetNuke.UI.WebControls" Assembly="DotNetNuke.WebControls" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center" class="">
		<tr valign="top">
			<td class="Forum_Admin_SectionHead" valign="top" align="left" width="100%"><dnn:sectionhead id="dshGeneralInformation" runat="server" resourcekey="GeneralInformation" section="tblGeneralInformation"></dnn:sectionhead>
				<table id="tblGeneralInformation" cellspacing="0" cellpadding="0" width="100%" runat="server">
					<tr id="rowForumID" runat="server" visible="False">
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plForumID" runat="server" controlname="txtForumID"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtForumID" runat="server" cssclass="Forum_NormalTextBox" width="250px" Enabled="False"></asp:textbox>&nbsp;</td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:Label id="plEnableForum" runat="server" Suffix=":" controlname="chkActive"></dnn:Label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:checkbox id="chkActive" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plGroupName" runat="server" Suffix=":" controlname="ddlGroup"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:dropdownlist id="ddlGroup" Runat="server" CssClass="Forum_NormalTextBox" Width="250px"></asp:dropdownlist></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plForumName" runat="server" Suffix=":" controlname="txtForumName"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtForumName" runat="server" cssclass="Forum_NormalTextBox" width="250px"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plForumDescription" runat="server" Suffix=":" controlname="txtForumDescription"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtForumDescription" runat="server" cssclass="Forum_NormalTextBox" width="250px"
								Rows="3" TextMode="MultiLine"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plForumCreatorName" runat="server" Suffix=":" controlname="txtForumCreatorName"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtForumCreatorName" runat="server" cssclass="Forum_NormalTextBox" Enabled="False"
								Width="250px"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plCreatedDate" runat="server" Suffix=":" controlname="txtCreatedDate"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtCreatedDate" runat="server" cssclass="Forum_NormalTextBox" Enabled="False"
								Width="250px"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plUpdatedName" runat="server" Suffix=":" controlname="txtUpdatedName"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtUpdatedName" runat="server" cssclass="Forum_NormalTextBox" width="250px"
								Enabled="False"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText"><dnn:label id="plUpdatedDate" runat="server" Suffix=":" controlname="txtUpdatedDate"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" align="left"><asp:textbox id="txtUpdatedDate" runat="server" cssclass="Forum_NormalTextBox" width="250px"
								Enabled="False"></asp:textbox></td>
					</tr>
                    <tr>
                        <td class="Forum_Row_AdminL">
                            <span class="Forum_Row_AdminText">
                                <dnn:label id="plAllowPolls" runat="server" Suffix=":" controlname="chkAllowPolls"></dnn:label>
							</span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR">
                            <asp:checkbox id="chkAllowPolls" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox>
                        </td>
                    </tr>
				</table>
			</td>
		</tr>
		<tr valign="top">
			<td class="Forum_Admin_SectionHead" valign="top" align="left" width="100%"><dnn:SectionHead id="dshForumSettings" runat="server" resourcekey="GeneralSettings" section="tblForumSettings" isExpanded="False"></dnn:SectionHead>
				<table id="tblForumSettings" cellspacing="0" cellpadding="0" width="100%" runat="server">
						<tr>
							<td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plForumType" runat="server" Suffix=":" controlname="ddlForumType"></dnn:label>
								</span></td>
							<td class="Forum_Row_AdminR" align="left"><asp:dropdownlist id="ddlForumType" runat="server" CssClass="Forum_NormalTextBox" Width="250px" AutoPostBack="True"></asp:dropdownlist></td>
						</tr>
                    <tr id="rowForumBehavior" runat="server"> 
                        <td class="Forum_Row_AdminL">
                            <dnn:label id="plForumBehavior" runat="server" Suffix=":" controlname="ddlForumBehavior"></dnn:label>
                        </td>
                        <td align="left" class="Forum_Row_AdminR">
                            <asp:dropdownlist id="ddlForumBehavior" runat="server" CssClass="Forum_NormalTextBox" Width="250px" AutoPostBack="True"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr id="rowForumLink" runat="server">
                        <td class="Forum_Row_AdminL"><span class="Forum_Row_AdminText"><dnn:label id="plForumLink" runat="server" Suffix=":" controlname="txtForumLink"></dnn:label></span></td>
                        <td align="left" class="Forum_Row_AdminR">
                            <portal:url id="ctlURL" runat="server" showtabs="False" urltype="F" shownewwindow="True"></portal:url></td>
                    </tr>
                    <tr id="rowLinkTracking" runat="server">
                         <td align="center" class="Forum_Row_Admin" colspan="2">
                            <portal:tracking id="ctlTracking" runat="server"></portal:tracking></td>
                    </tr>
						<tr id="rowThreadStatus" runat="server">
							<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText">
									<dnn:label id="plEnableForumsThreadStatus" runat="server" Suffix=":" controlname="chkEnableForumsThreadStatus"></dnn:label>
								</span></td>
							<td class="Forum_Row_AdminR" align="left">
								<asp:checkbox id="chkEnableForumsThreadStatus" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
						</tr>
						<tr id="rowRating" runat="server">
							<td class="Forum_Row_AdminL" ><span class="Forum_Row_AdminText">
									<dnn:label id="plEnableForumsRating" runat="server" Suffix=":" controlname="chkEnableForumsRating"></dnn:label>
								</span></td>
							<td class="Forum_Row_AdminR" align="left">
								<asp:checkbox id="chkEnableForumsRating" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox></td>
						</tr>
						<tr id="rowPermissions" runat="server">
							<td class="Forum_Row_Admin" align="center" valign="top" colspan="2" width="100%">
								<table border="0" cellspacing="0" cellpadding="0">
									<tr>
										<td align="center" width="100%">
											<dnnforum:forumpermissionsgrid id="dgPermissions" runat="server"></dnnforum:forumpermissionsgrid></td>
									</tr>
									<tr>
										<td align="center">
										    <table>
										        <tr>
										            <td colspan="2" align="center"><asp:Label id="lblPrivateNote" runat="server" CssClass="Normal" resourcekey="lblPrivateNote"></asp:Label></td>
										        </tr>
										        <tr>
										            <td><span class="Forum_Row_AdminText">
															<dnn:label id="plForumPermTemplate" runat="server" resourcekey="plForumPermTemplate" controlname="ddlForumPermTemplate" suffix=":"></dnn:label>
														</span>
													</td>
										            <td><asp:dropdownlist id="ddlForumPermTemplate" runat="server" CssClass="Forum_NormalTextBox" Width="250px" AutoPostBack="True" DataTextField="Name" DataValueField="ForumID">
                                            </asp:dropdownlist></td>
										        </tr>
										    </table>
										</td>
									</tr>
								</table>
							</td>
						</tr>
					</table>
			</td>
		</tr>
							<tr>
						<td align="center" width="100%" class="Forum_Row_Admin_Foot">
							<asp:linkbutton class="CommandButton" id="cmdAdd" runat="server" resourcekey="cmdAdd"></asp:linkbutton>
							<asp:linkbutton class="CommandButton" id="cmdUpdate" runat="server" resourcekey="cmdUpdate"></asp:linkbutton>&nbsp;
							<asp:linkbutton class="CommandButton" id="cmdCancel" runat="server" resourcekey="cmdCancel"></asp:linkbutton>&nbsp;
							<asp:linkbutton class="CommandButton" id="cmdDelete" runat="server" resourcekey="cmdDelete"></asp:linkbutton></td>
					</tr>
	</table>
	
