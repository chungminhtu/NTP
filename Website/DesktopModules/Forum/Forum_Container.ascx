<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Modules.Forum" Assembly="DotNetNuke.Modules.Forum" %>
<%@ Control language="vb" Inherits="DotNetNuke.Modules.Forum.Container" CodeBehind="Forum_Container.ascx.vb" AutoEventWireup="false" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
	<table id="tblMain" width="100%" cellpadding="0" cellspacing="0" border="0">		
		<tr>
			<td valign="top" align="center">
				<dnn:DNNFORUM id="DNNForum" Runat="server"></dnn:DNNFORUM>
			</td>
		</tr>
	</table>
