<%@ Register TagPrefix="dnnforum" Namespace="DotNetNuke.Modules.Forum.WebControls"
    Assembly="DotNetNuke.Modules.Forum" %>
<%@ Control Inherits="DotNetNuke.Modules.Forum.PMInbox" Codebehind="Forum_PMInbox.ascx.vb"
    Language="vb" AutoEventWireup="false" Explicit="True" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
	<tr>
	    <td width="100%" class="">
			<table cellspacing="0" cellpadding="0" width="100%" border="0">
	            <tr>
	                <td class="Forum_HeaderCapLeft"><asp:Image ID="imgHeadSpacer" runat="server" /></td>
	                <td class="Forum_Header">
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                               <td align="left" colspan="2" width="50%">
                                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td>
                                                &nbsp;<asp:Label ID="lblInbox" runat="server" CssClass="Forum_HeaderText" resourcekey="lblInbox"></asp:Label></td>
                                            <td align="right">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                                <td width="17%" align="center">
                                    &nbsp;<asp:Label ID="lblRecipient" runat="server" CssClass="Forum_HeaderText" resourcekey="lblRecipient"></asp:Label></td>
                                <td width="10%" align="center">
                                    &nbsp;<asp:Label ID="lblReplies" runat="server" CssClass="Forum_HeaderText" resourcekey="lblReplies"></asp:Label></td>
                                <td width="23%" align="center">
                                    &nbsp;<asp:Label ID="lblLastPost" runat="server" CssClass="Forum_HeaderText" resourcekey="lblLastPost"></asp:Label></td>                         
                            </tr>
                        </table>
	                </td>
	                <td class="Forum_HeaderCapRight"><asp:Image ID="imgHeadSpacer2" runat="server" /></td>
	            </tr>
	        </table>
	    </td>
    </tr>
    <tr>
        <td class="" valign="top" align="left" width="100%">
            <asp:DataList ID="lstPMThreads" runat="server" DataKeyField="PMThreadID" CellPadding="0" Width="100%">
                <ItemTemplate>
                    <td id="chkColumn" class='<%# CssClass() %>' width="3%">
                        <asp:CheckBox ID="chkThread" runat="server" /></td>
                    <td id="StatusSubjectColumn" class='<%# CssClass1() %>' width="47%" valign="top">
                        <table id="Table2" runat="server" border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td width="5px" valign="top">
                                    <asp:HyperLink ID="hlStatus" runat="server"><asp:Image ID="imgStatus" runat="server" /></asp:HyperLink>
                                </td>
                                <td width="100%" valign="top">
                                    &nbsp;<asp:HyperLink ID="hlSubject" runat="server" CssClass="Forum_NormalBold" /><br />
                                    &nbsp;<asp:Label ID="lblStarter" runat="server" CssClass="Forum_Normal" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td id="RecipientColumn" align="center" class='<%# CssClass2() %>' width="17%">
                        <asp:Label ID="lblPMRecipient" runat="server" CssClass="Forum_Normal" />
                    </td>
                    <td id="RepliesColumn" align="center" class='<%# CssClass3() %>' width="10%">
                        <asp:Label ID="lblPMReplies" runat="server" CssClass="Forum_Normal" />
                    </td>
                    <td id="LastPostColumn" align="right" class='<%# CssClass4() %>' width="23%">
                        <asp:Label ID="lblLastPMInfo" runat="server" class="Forum_Normal" />
                    </td>
                </ItemTemplate>
            </asp:DataList>
         </td>
    </tr>
	<tr>
	    <td width="100%" class="">
			<table cellspacing="0" cellpadding="0" width="100%" border="0">
	            <tr>
	                <td class="Forum_FooterCapLeft"><asp:Image ID="imgFootSpacer" runat="server" /></td>
	                <td class="Forum_Footer">
	                    <dnnforum:pagingcontrol id="ctlPagingControl" runat="server"></dnnforum:pagingcontrol>
                        <asp:Label ID="lblNoMessages" runat="server" CssClass="Forum_HeaderText" resourcekey="lblNoMessages"></asp:Label>
	                </td>
	                <td class="Forum_FooterCapRight"><asp:Image ID="imgFootSpacer2" runat="server" /></td>
	            </tr>
	        </table>
	    </td>
    </tr>
    <tr>
        <td valign="middle" align="center" width="100%">
            <asp:LinkButton ID="cmdDelete" CssClass="CommandButton" runat="server" resourcekey="cmdDelete"></asp:LinkButton>&nbsp;
            <asp:LinkButton ID="cmdForumHome" CssClass="CommandButton" runat="server" resourcekey="cmdForumHome"></asp:LinkButton></td>
    </tr>
</table>
