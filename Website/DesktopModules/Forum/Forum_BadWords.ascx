<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Control Inherits="DotNetNuke.Modules.Forum.BadWords" CodeBehind="Forum_BadWords.ascx.vb" language="vb" AutoEventWireup="false" Explicit="True" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
		<tr id="rowContent" runat="server">
			<td valign="top" align="center" class="Forum_Row_Admin">
				<asp:panel id="plLetterSearch" Runat="server" HorizontalAlign="Center">
					<asp:Repeater id="rptLetterSearch" Runat="server">
						<ItemTemplate>
							<asp:HyperLink runat="server" CssClass="Forum_NormalBold" NavigateUrl='<%# FilterURL(Container.DataItem) %>' Text='<%# Container.DataItem %>'>
							</asp:HyperLink>&nbsp;&nbsp;
						</ItemTemplate>
					</asp:Repeater>
				</asp:panel>
				<asp:datagrid id="grdBadWords" runat="server" EnableViewState="false" AutoGenerateColumns="false"
					width="100%" CellPadding="4" Border="0">
					<Columns>
						<asp:TemplateColumn ItemStyle-Width="20">
							<ItemTemplate>
								<asp:HyperLink NavigateUrl='<%# FormatURL(Container.DataItem) %>' runat="server" ID="Hyperlink1">
									<asp:Image ImageUrl="<%# EditImage %>" AlternateText="Edit" runat="server" ID="Hyperlink1Image"
										resourcekey="Edit" />
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn HeaderText="Word To Filter" DataField="BadWord" ItemStyle-CssClass="Forum_Row_AdminText"
							HeaderStyle-Cssclass="Forum_AltHeaderText" />
						<asp:BoundColumn HeaderText="Replacement For Filtered Word" DataField="ReplacedWord" ItemStyle-CssClass="Forum_Row_AdminText"
							HeaderStyle-Cssclass="Forum_AltHeaderText" />
						<asp:TemplateColumn HeaderText="Created By" ItemStyle-CssClass="Forum_Row_AdminText" HeaderStyle-Cssclass="Forum_AltHeaderText">
							<ItemTemplate>
								<asp:Label ID="lblAuthor" Runat="server" Text='<%# DisplayAuthor(Container.DataItem) %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Created Date" ItemStyle-CssClass="Forum_Row_AdminText" HeaderStyle-Cssclass="Forum_AltHeaderText">
							<ItemTemplate>
								<asp:Label ID="lblDate" Runat="server" Text='<%# DisplayDate(Container.DataItem) %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
				</asp:datagrid></td>
		</tr>
		<tr valign="middle">
			<td class="Forum_Admin_SectionHead" valign="middle" align="left"><dnn:sectionhead id="dshBadWordFilter" runat="server" section="tblBadWordFilter" resourcekey="BadWordFilter" isExpanded="False" width="100%"></dnn:sectionhead>
				<table id="tblBadWordFilter" cellspacing="0" cellpadding="0" width="100%" runat="server">
					<tr>
						<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plBadWord" runat="server" Suffix=":" controlname="chkBadWord"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%"><asp:checkbox id="chkBadWord" runat="server" CssClass="Forum_NormalTextBox" AutoPostBack="True"></asp:checkbox>
						</td>
					</tr>
					<tr id="rowSubjectFilter" runat="server">
						<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plFilterSubject" runat="server" Suffix=":" controlname="chkFilterSubject"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="middle" align="left" width="70%"><asp:checkbox id="chkFilterSubject" runat="server" CssClass="Forum_NormalTextBox"></asp:checkbox>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr id="rowFooter" runat="server">
			<td class="Forum_Row_Admin_Foot" align="center" width="100%">
				<table cellpadding="0" cellspacing="0" border="0" width="100%">
					<tr>
						<td width="100%" align="center">
							<asp:linkbutton id="cmdAdd" resourcekey="cmdAdd" runat="server" cssclass="CommandButton"
								causesvalidation="False" borderstyle="none"></asp:linkbutton>&nbsp;
							<asp:linkbutton id="cmdUpdate" runat="server" resourcekey="cmdUpdate" borderstyle="none" causesvalidation="False"
								cssclass="CommandButton"></asp:linkbutton>&nbsp;
							<asp:linkbutton id="cmdCancel" resourcekey="cmdCancel" runat="server" cssclass="CommandButton" 
								causesvalidation="False" borderstyle="none" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
