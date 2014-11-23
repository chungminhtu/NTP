<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.UI.WebControls" Assembly="DotNetNuke" %>
<%@ Register TagPrefix="dnnforum" Namespace="DotNetNuke.Modules.Forum.WebControls" Assembly="DotNetNuke.Modules.Forum" %>
<%@ Control Inherits="DotNetNuke.Modules.Forum.UserManage" CodeBehind="Forum_UserManage.ascx.vb" language="vb" AutoEventWireup="false" Explicit="True" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%"
		align="center">
		<tr>
			<td class="Forum_Row_Admin" valign="middle" width="100%">
				<table width="475" border="0">
					<tr>
						<td align="left" width="75" valign="middle"><asp:label id="lblSearch" cssclass="Forum_HeaderText" resourcekey="Search" runat="server"></asp:label></td>
						<td align="left" width="*" valign="middle">
						    <table>
						        <tr>
						            <td align="left"><asp:textbox id="txtSearch" Runat="server" class="Forum_NormalTextBox"></asp:textbox></td>
						            <td align="left"><asp:dropdownlist id="ddlSearchType" Runat="server" class="Forum_NormalTextBox"/></td>
						            <td align="left"><asp:imagebutton id="btnSearch" Runat="server" resourcekey="FilterImage"></asp:imagebutton></td>
						        </tr>
						    </table>
                        </td>
					</tr>
					<tr>
						<td colspan="2"></td>
					</tr>
				</table>
				<asp:panel id="plLetterSearch" Runat="server" HorizontalAlign="Center">
					<asp:Repeater id="rptLetterSearch" Runat="server">
						<itemtemplate>
							<asp:HyperLink runat="server" CssClass="Forum_Link" NavigateUrl='<%# FilterURL(Container.DataItem,"1") %>' Text='<%# Container.DataItem %>' ID="Hyperlink1">
							</asp:HyperLink>&nbsp;&nbsp;
						</itemtemplate>
					</asp:Repeater>
				</asp:panel>
				<asp:datagrid id="grdUsers" Runat="server" GridLines="None" width="100%" cssclass="DataGrid_Container"
					CellPadding="2" AutoGenerateColumns="false">
					<headerstyle cssclass="Forum_AltHeaderText" verticalalign="Top" horizontalalign="left" />
					<itemstyle cssclass="Forum_Row_AdminText" horizontalalign="Left" />
					<alternatingitemstyle cssclass="Forum_Row_AdminText" />
					<edititemstyle cssclass="Forum_NormalTextBox" />
					<selecteditemstyle cssclass="Forum_Row_AdminText" />
					<footerstyle cssclass="DataGrid_Footer" />
					<pagerstyle cssclass="DataGrid_Pager" />
					<columns>
						<dnn:imagecommandcolumn CommandName="Edit" KeyField="UserID" EditMode="URL" />
						<asp:templatecolumn>
							<itemtemplate>
								<asp:image id="imgOnline" runat="Server" resourcekey="UserOnline"/>
							</itemtemplate>
						</asp:templatecolumn>
						<dnn:textcolumn datafield="UserName" headertext="Username" />
						<dnn:textcolumn datafield="Email" headertext="Email" />
						<dnn:textcolumn datafield="DisplayName" headertext="DisplayName" />
						<asp:TemplateColumn HeaderText="CreatedDate">
							<itemtemplate>
								<asp:Label ID="lblLastLogin" Runat="server" Text='<%# DisplayDate(CType(Container.DataItem, DotNetNuke.Entities.Users.UserInfo).Membership.CreatedDate) %>'>
								</asp:Label>
							</itemtemplate>
						</asp:TemplateColumn>
					</columns>
				</asp:datagrid>
			</td>
		</tr>
		<tr>
		    <td width="100%" valign="middle">
		        <table cellspacing="0" cellpadding="0">
		            <tr>
		                <td width="1px" class="Forum_FooterCapLeft"><asp:Image ID="imgFootSpacer" runat="server" /></td>
		                <td width="100%" class="Forum_Footer"><dnnforum:pagingcontrol id="ctlPagingControl" runat="server"></dnnforum:pagingcontrol></td>
		                <td width="1px" class="Forum_FooterCapRight"><asp:Image ID="imgFootSpacer2" runat="server" /></td>
		            </tr>
		        </table>
		    </td>
	    </tr>
		<tr>
			<td valign="middle" align="center" width="100%">
				<asp:linkbutton id="cmdCancel" CssClass="CommandButton" runat="server" resourcekey="cmdCancel"></asp:linkbutton></td>

		</tr>
	</table>
