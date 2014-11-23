<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Control language="vb" CodeBehind="Forum_EmailTemplates.ascx.vb" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Forum.EmailTemplates" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%"
		align="center">
        <tr valign="middle">
		<td width="100%">
			<table id="tblEmailTemplates" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr id="rowDefaults" runat="server">
					<td class="Forum_Row_AdminL" width="25%"><span class="Forum_Row_AdminText">
							<dnn:label id="plDefaults" runat="server" suffix=":" controlname="rblstDefaults"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%">
						<asp:RadioButtonList id="rblstDefaults" runat="server" AutoPostBack="True"></asp:RadioButtonList></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="25%"><span class="Forum_Row_AdminText"><dnn:label id="plEmailTemplate" runat="server" controlname="ddlEmailTemplate" suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:dropdownlist id="ddlEmailTemplate" runat="server" CssClass="Forum_NormalTextBox" AutoPostBack="True" width="350px" DataTextField="EmailTemplateName" DataValueField="EmailTemplateID"></asp:dropdownlist></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="25%"><span class="Forum_Row_AdminText"><dnn:label id="plEmailSubject" runat="server" controlname="txtEmailSubject" suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtEmailSubject" runat="server" width="350px" Columns="26" cssclass="Forum_NormalTextBox"></asp:textbox>&nbsp;
						<asp:requiredfieldvalidator id="valSubject" runat="server" CssClass="NormalRed" resourcekey="valSubject" ControlToValidate="txtEmailSubject"></asp:requiredfieldvalidator></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" valign="top" width="25%"><span class="Forum_Row_AdminText"><dnn:label id="plEmailHTMLBody" runat="server" controlname="teContent" suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><span class="Forum_Row_AdminText"><dnn:texteditor id="teContent" runat="server" width="100%" height="250px"></dnn:texteditor>
						</span></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" valign="top" width="25%"><span class="Forum_Row_AdminText"><dnn:label id="plEmailTextBody" runat="server" controlname="txtEmailTextBody" suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtEmailTextBody" runat="server" width="100%" Columns="26" cssclass="Forum_NormalTextBox"
							TextMode="MultiLine" Height="160px"></asp:textbox></td>
				</tr>
				<tr>
					<td class="Forum_Row_AdminL" width="25%"><span class="Forum_Row_AdminText"></span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"></td>
				</tr>
			</table>
		</td>
	</tr>
					<tr>
		<td align="center" width="100%" class="Forum_Row_Admin">
			<asp:DataList id="dlKeywords" runat="server">
				<AlternatingItemStyle CssClass="DataGrid_AlternatingItem"></AlternatingItemStyle>
				<FooterStyle CssClass="DataGrid_Footer"></FooterStyle>
				<ItemStyle CssClass="DataGrid_Item"></ItemStyle>
				<HeaderStyle CssClass="DataGrid_Header"></HeaderStyle>
				<HeaderTemplate>
					<div align="center">Available Keywords</div>
				</HeaderTemplate>
				<ItemTemplate>
					<b>
						<asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Token") %>' Runat="server" ID="lblToken">
						</asp:Label></b>
					<asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Description") %>' Runat="server" ID="lblDescription">
					</asp:Label>
				</ItemTemplate>
				<FooterTemplate>
				</FooterTemplate>
			</asp:DataList></td>
	</tr>
  <tr>
		<td class="Forum_Row_Admin_Foot" align="center" width="100%">
			<asp:linkbutton cssclass="CommandButton" id="cmdUpdate" runat="server" resourcekey="cmdUpdate"></asp:linkbutton>&nbsp;
			<asp:linkbutton cssclass="CommandButton" id="cmdCPHome" runat="server" resourcekey="cmdCPHome" CausesValidation="False"></asp:linkbutton></td>
	</tr>
    <tr>
        <td align="center" width="100%">
            <asp:Label ID="lblSettingsSaved" runat="server" CssClass="NormalRed" resourcekey="lblSettingsSaved"></asp:Label></td>
    </tr>
</table>
