<%@ Register TagPrefix="DNN" Namespace="DotNetNuke.UI.WebControls" Assembly="DotNetNuke.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Forum_Search.ascx.vb" Inherits="DotNetNuke.Modules.Forum.SearchPage" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table class="Forum_Container" id="tblMain" cellspacing="0" cellpadding="0" width="100%"
		align="center">
		<tr>
			<td valign="top" align="center" width="100%">
				<table id="tblContent" cellspacing="0" cellpadding="4" width="100%">
					<tr>
						<td class="Forum_Row_AdminL" valign="top" width="150"><span class="Forum_Row_AdminText"><dnn:label id="plFromDate" Suffix=":" runat="server" controlname="txtFromDate"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="middle" align="left">
						    <table>
						        <tr>
						            <td valign="middle" align="left">
						                <asp:textbox id="txtFromDate" cssclass="Forum_NormalTextBox" runat="server" width="250px"></asp:textbox>&nbsp;
						    	    </td>
						    	    <td valign="middle" align="left">
						    	        <asp:hyperlink id="cmdCalFrom" resourcekey="cmdCalFrom" runat="server"></asp:hyperlink>
						    	    </td>
						    	</tr>
						    </table>
						 </td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" valign="top" width="150"><span class="Forum_Row_AdminText"><dnn:label id="plToDate" Suffix=":" runat="server" controlname="txtToDate"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="middle" align="left">
							<table>
						        <tr>
						            <td valign="middle" align="left">
						                <asp:textbox id="txtToDate" cssclass="Forum_NormalTextBox" runat="server" width="250px"></asp:textbox>&nbsp;
						            						    	    </td>
						    	    <td valign="middle" align="left">
						    	        <asp:hyperlink id="cmdCalTo" resourcekey="cmdCalTo" runat="server"></asp:hyperlink>
						    	    </td>
						    	 </tr>
						    </table>
						 </td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" valign="top" width="150">
							<span class="Forum_Row_AdminText">
								<dnn:label id="plUserSuggest" runat="server"  Suffix=":" controlname="txtForumUserSuggest"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="top" align="left"><DNN:DNNTEXTSUGGEST id="txtForumUserSuggest" runat="server" DefaultNodeCssClassSelected="SelClass" DefaultNodeCssClassOver="HoverClass"
								DefaultNodeCssClass="NodeDefault" DefaultChildNodeCssClass="ChildNodeDefault" TextSuggestCssClass="MenuBarClass" Width="250px" LookupDelay="250" IDToken="Brackets"
								MaxSuggestRows="20" CssClass="Forum_NormalTextBox"></DNN:DNNTEXTSUGGEST><br />
							<br />
						</td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" valign="top" width="150"><span class="Forum_Row_AdminText"><dnn:label id="plSubject" Suffix=":" runat="server" controlname="txtSubject"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="top" align="left"><asp:textbox id="txtSubject" cssclass="Forum_NormalTextBox" runat="server" width="250"></asp:textbox></td>
					</tr>
					<tr>
						<td class="Forum_Row_AdminL" valign="top" width="150"><span class="Forum_Row_AdminText"><dnn:label id="plBody" Suffix=":" runat="server" controlname="txtSearch"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="top" align="left"><asp:textbox id="txtSearch" cssclass="Forum_NormalTextBox" runat="server" width="250" rows="2"
								height="48px"></asp:textbox></td>
					</tr>
                    <tr>
                        <td class="Forum_Row_AdminL" valign="top" width="150"><span class="Forum_Row_AdminText"><dnn:label id="plThreadStatus" Suffix=":" runat="server" controlname="ddlThreadStatus"></dnn:label>
							</span>
                        </td>
                        <td align="left" class="Forum_Row_AdminR" valign="top">
                            <asp:DropDownList ID="ddlThreadStatus" runat="server" CssClass="Forum_NormalTextBox"
                                Width="250px">
                            </asp:DropDownList></td>
                    </tr>
					<tr>
						<td class="Forum_Row_AdminL" valign="top" width="150"><span class="Forum_Row_AdminText"><dnn:label id="plForums" Suffix=":" runat="server" controlname="txtForumID"></dnn:label>
							</span></td>
						<td class="Forum_Row_AdminR" valign="top" align="left">
							<DNN:DNNTree id="ForumTree" runat="server"></DNN:DNNTree>
						</td>
					</tr>
				</table>
				<asp:label id="lblInfo" cssclass="NormalRed" runat="server"></asp:label></td>
		</tr>
		<tr>
			<td valign="middle" align="center" class="Forum_Row_Admin_Foot">
				<asp:linkbutton class="CommandButton" id="cmdSearch" resourcekey="cmdSearch" runat="server"></asp:linkbutton>&nbsp;
                <asp:linkbutton class="CommandButton" id="cmdCancel" resourcekey="cmdCancel" runat="server"></asp:linkbutton></td>
		</tr>
	</table>

