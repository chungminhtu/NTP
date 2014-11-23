<%@ Control language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register TagPrefix="dnn" TagName="LOGO" Src="~/Admin/Skins/Logo.ascx" %>
<%@ Register TagPrefix="dnn" TagName="BREADCRUMB" Src="~/Admin/Skins/BreadCrumb.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LOGIN" Src="~/Admin/Skins/Login.ascx" %>
<%@ Register TagPrefix="dnn" TagName="VERTICAL_MENU" Src="~/DesktopModules/vertical_menu/vertical_menu.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SEARCH" Src="~/Admin/Skins/Search.ascx" %>
<%@ Register TagPrefix="dnn" TagName="USER" Src="~/Admin/Skins/User.ascx" %>
<%@ Register TagPrefix="dnn" TagName="CURRENTDATE" Src="~/Admin/Skins/currentdate.ascx" %>
<script type ="text/javascript" src="<%=request.applicationpath%>/js/common.js"></script>
<script type ="text/javascript" src="<%=Request.ApplicationPath%>/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu.js"
        xmlns:fo="http://www.w3.org/1999/XSL/Format"></script>


<link href="/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-base.css" rel="stylesheet"
    type="text/css" />
<link href="/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-sidebar.css"
    rel="stylesheet" type="text/css" />
<link href="/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-topbar.css"
    rel="stylesheet" type="text/css" />


<table class="ss_header" width="100%" border="0px">
<tr>
	<td colspan="2" class="ntp_banner"><table width="100%"> <tr><td width="30%"><dnn:LOGO runat="server" id="dnnLOGO" /></td> 
	<td align="right" >
	    <a href="http://localhost/ntp/Home/tabid/38/Default.aspx">Home</a>|<a href="">Forum</a>|<a href="">Chat</a>|<a href="">Survey</a>|<a href="">FAQs</a>|<a href="">Online Help</a></td></tr></table> 
	
</td>
</tr>
<tr>
	<td colspan="2"></td>
</tr>
<tr>
	<td colspan="2" align="right"><dnn:USER runat="server" id="dnnUSER"  CssClass="user" /> &nbsp;&nbsp; <dnn:LOGIN runat="server" id="dnnLOGIN" CssClass="user" /></td>
</tr>
    <tr>
        <td valign="top" width="15%">
             <dnn:currentdate runat="server" id="dnncurrendate" /></td>
        <td width="85%">
            <dnn:BREADCRUMB runat="server" id="dnnBREADCRUMB" Separator="&nbsp;&raquo;&nbsp;" RootLevel="0" />
        </td>
    </tr>
    <tr>
        <td width = "15%" valign="top" >
            <dnn:VERTICAL_MENU runat="server" id="dnnVERTICAL_MENU" /></td>
        <td width = "85%"  valign=top > 
	<table width ="100%">
		<tr>
			
                                        <td width="100%" align="center"  valign="top" id="ContentPane" class="ContentPane" runat="server">
                                        </td>
                                        
		</tr>
	</table>
	
	
            	</td>
    </tr>
    <tr>
        <td colspan = "2"></td>
    </tr>
</table>


