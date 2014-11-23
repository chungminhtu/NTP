<%@ Control Inherits="DotNetNuke.Modules.Forum.ForumManage" CodeBehind="Forum_ForumManage.ascx.vb" language="vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<script language="javascript" type="text/javascript" src='<%= Page.ResolveUrl("DesktopModules/Forum/Popup/forumpopup.js") %>'></script>
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
		<tr>
			<td valign="top" align="left" width="100%"><ASP:DATALIST id="lstGroup" cellspacing="0" cellpadding="0" gridlines="None" borderwidth="0" datakeyfield="GroupID"
					width="100%" runat="server">
					<ITEMTEMPLATE>
						<table width="100%" cellpadding="0" cellspacing="0" border="0" runat="server" id="tblGroup" class="">
							<tr>
								<td class="Forum_AltHeader">
									<table cellspacing="0" cellpadding="0" width="100%" runat="server" id="tblGroupEditHeaderClosed">
										<tr>
											<td width="20px" align="center">
												<asp:ImageButton id="btnExpand" resourcekey="btnExpand.AlternateText" ImageUrl="<%# PlusImage %>" runat="server" CommandName='<%# GetEditCommand %>' CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) %>' />
											</td>
											<td width="2px">
											    <asp:Image id="imgHeadSpacer" runat="server" ImageUrl='<%# SpacerImage %>' />
											</td>
											<td align="left">
												<asp:Label CssClass="Forum_AltHeaderText" Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>' runat="server" ID="lblGroupName">
												</asp:Label>
											</td>
											<td align="right">
												<asp:ImageButton id="btnGroupDelete2" resourcekey="btnGroupDelete2.AlternateText" Visible='<%# GroupCanDelete %>' ImageUrl="<%# DeleteImage %>" runat="server" CommandName="delete" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) %>' />
												<asp:ImageButton id="lblGroupEdit" resourcekey="lblGroupEdit.AlternateText" ImageUrl="<%# EditImage %>" runat="server" CommandName="groupedit" OnClick="GroupEdit_Click" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) %>' />
												<asp:ImageButton id="btnGroupUp2" resourcekey="btnGroupUp2.AlternateText" ImageUrl="<%# UpImage %>" runat="server" CommandName="up" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) %>' />
												<asp:ImageButton id="btnGroupDown2" resourcekey="btnGroupDown2.AlternateText" ImageUrl="<%# DownImage %>" runat="server" CommandName="down" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) %>' />
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</ITEMTEMPLATE>
					<EDITITEMTEMPLATE>
						<table id="tblGroupEdit" cellspacing="0" cellpadding="0" width="100%">
							<tr>
								<td width="100%" class="Forum_AltHeader">
									<table cellspacing="0" cellpadding="0" width="100%" runat="server" id="tblGroupEditHeaderOpen">
										<tr>
											<td width="20px" align="center">
												<asp:ImageButton id="btnCloseGroup" resourcekey="btnCloseGroup.AlternateText" ImageUrl="<%# MinusImage %>" runat="server" CommandName="cancel" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) %>' />
											</td>
											<td width="2px"><asp:Image id="imgHeadSpacer2" runat="server" ImageUrl='<%# SpacerImage %>' /></td>
											<td align="left">
												<asp:Label id="Label1" CssClass="Forum_AltHeaderText" Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>' Width="100%" runat="server">
												</asp:Label>
											</td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td width="100%" class="Forum_Row_Admin">
									<table id="tblGroupEditDetails" cellspacing="0" cellpadding="0" width="100%">
										<tr>
											<td width="100%">
												<table id="tblGroupDetails" cellspacing="0" cellpadding="0" width="100%">
													<tr>
														<td align="left" valign="top" class="">
															<asp:DataList ID="lstForum" runat="server" CellPadding="0" CellSpacing="0" DataSource="<%# BindForum() %>"
                                                                GridLines="None" OnItemDataBound="lstForum_ItemDataBound" Width="100%" ShowFooter="true">
																<ITEMTEMPLATE>
																	<table width="100%" cellpadding="0" cellspacing="0" runat="server" id="tblForumList">
																		<tr>
																			<td valign="top" width="30px">
																				<asp:image id="Spacer" runat="server" ImageUrl="<%# SpacerImage() %>"></asp:image></td>
																			<td>
																				<asp:Label CssClass="Forum_NormalBold" Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>' runat="server" ID="lblForumName" />
																				<span class="Forum_NormalBold">(<%# DataBinder.Eval(Container.DataItem,"TotalPosts") %> Posts)</span>
																			</td>
																			<td align="right">
																				<asp:Image id="btnForumEnable" alt='<%# EnabledImageText(DataBinder.Eval(Container.DataItem, "ForumID")) %>' ImageUrl='<%# EnabledImage(DataBinder.Eval(Container.DataItem, "ForumID")) %>' runat="server" />
																				<asp:ImageButton id="btnForumEdit" resourcekey="btnForumEdit.AlternateText" ImageUrl="<%# EditImage %>" runat="server" CommandName="edit" OnClick="EditForum_Click" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "ForumID"), String) %>' />
																				<asp:ImageButton id="btnForumDelete" resourcekey="btnForumDelete.AlternateText" ImageUrl="<%# DeleteImage %>" runat="server" CommandName="delete" OnClick="deleteForum_Click" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) + "|" + CType(DataBinder.Eval(Container.DataItem, "ForumID"), String) %>' />
																				<asp:ImageButton id="btnForumUp" resourcekey="btnForumUp.AlternateText" ImageUrl="<%# UpImage %>" runat="server" CommandName="up" OnClick="ForumUp_Click" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "ForumID"), String) %>' />
																				<asp:ImageButton id="btnForumDown" resourcekey="btnForumDown.AlternateText" ImageUrl="<%# DownImage %>" runat="server" CommandName="down" OnClick="ForumDown_Click" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "ForumID"), String) %>' />
																			</td>
																		</tr>
																	</table>
																</ITEMTEMPLATE>
																<FOOTERTEMPLATE>
																	<table width="100%" cellpadding="0" cellspacing="0" runat="server" id="Table1">
																		<tr>
																			<td width="100%">
																				<table width="100%" cellpadding="0" cellspacing="0" runat="server" id="tblAddForum">
																					<tr>
																						<td width="100%" align="center" height="20px" class="">
																							<ASP:LINKBUTTON class="Forum_Link" id="cmdAddForum" resourcekey="cmdAddForum" runat="server" text="Add Forum" onclick="AddForum_Click" CommandArgument='<%# CType(DataBinder.Eval(Container.DataItem, "GroupID"), String) %>' >
																							</ASP:LINKBUTTON></td>
																					</tr>
																				</table>
																			</td>
																		</tr>
																	</table>
																</FOOTERTEMPLATE>
															</asp:DataList>
														</td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</EDITITEMTEMPLATE>
				</ASP:DATALIST></td>
		</tr>
		<tr>
			<td class="Forum_Row_Admin_Foot" align="center" width="100%">
				<table cellspacing="0" cellpadding="0" width="100%" border="0">
					<tr>
						<td align="center" width="100%"><ASP:LINKBUTTON class="CommandButton" id="cmdAddGroup" resourcekey="cmdAddGroup" runat="server" text="Add Group"></ASP:LINKBUTTON>&nbsp;
							<ASP:LINKBUTTON class="CommandButton" id="cmdCancel" resourcekey="cmdCancel" runat="server" text="Cancel"></ASP:LINKBUTTON></td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
