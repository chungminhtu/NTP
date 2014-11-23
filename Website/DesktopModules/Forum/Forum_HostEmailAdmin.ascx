<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Control language="vb" CodeBehind="Forum_HostEmailAdmin.ascx.vb" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Forum.HostEmailAdmin" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
        <tr valign="middle">
		<td class="Forum_Admin_SectionHead" valign="middle" align="left">
			<table id="tblEmailGeneral" cellspacing="0" cellpadding="0" width="100%" runat="server">
				<tr>
					<td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText"><dnn:label id="plTaskDeleteDays" runat="server" controlname="txtTaskDeleteDays" suffix=":"></dnn:label>
						</span></td>
					<td class="Forum_Row_AdminR" align="left" width="70%"><asp:textbox id="txtTaskDeleteDays" runat="server" cssclass="Forum_NormalTextBox" width="250px"
							Columns="26"></asp:textbox></td>
				</tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%"><span class="Forum_Row_AdminText">
                        <dnn:Label ID="plEmailDeleteDays" runat="server" ControlName="txtEmailDeleteDays" Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:TextBox ID="txtEmailDeleteDays" runat="server" Columns="26" CssClass="Forum_NormalTextBox"
                            Width="250px"></asp:TextBox></td>
                </tr>
			</table>
		</td>
	</tr>
  <tr>
		<td class="Forum_Row_Admin_Foot" align="center" width="100%">
	        <asp:linkbutton class="CommandButton" id="cmdUpdate" runat="server" resourcekey="cmdUpdate"></asp:linkbutton>&nbsp;
			<asp:linkbutton class="CommandButton" id="cmdCancel" runat="server" resourcekey="cmdCancel" CausesValidation="False"></asp:linkbutton>
		</td>
	</tr>
</table>
