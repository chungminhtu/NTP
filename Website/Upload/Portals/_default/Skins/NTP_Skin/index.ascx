<%@ Control language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register TagPrefix="dnn" TagName="CURRENTDATE" Src="~/Admin/Skins/CurrentDate.ascx" %>
<%@ Register TagPrefix="dnn" TagName="USER" Src="~/Admin/Skins/User.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LOGIN" Src="~/Admin/Skins/Login.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LOGO" Src="~/Admin/Skins/Logo.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SEARCH" Src="~/Admin/Skins/Search.ascx" %>
<%@ Register TagPrefix="dnn" TagName="VERTICAL_MENU" Src="~/DesktopModules/vertical_menu/vertical_menu.ascx" %>
<%@ Register TagPrefix="dnn" TagName="COPYRIGHT" Src="~/Admin/Skins/Copyright.ascx" %>
<%@ Register TagPrefix="dnn" TagName="BREADCRUMB" Src="~/Admin/Skins/BreadCrumb.ascx" %>
<script type ="text/javascript" src="<%=Request.ApplicationPath%>/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu.js" xmlns:fo="http://www.w3.org/1999/XSL/Format"></script>
<script language="javascript" src="<%=Request.ApplicationPath%>/js/common.js"></script>
<script src="<%=Request.ApplicationPath %>/js/jquery.calculation.min.js" type="text/javascript"></script> 
<%@ Register TagPrefix="cc1" TagName="CURRENTSTOCK" Src="~/DesktopModules/NTP_CURRENTSTOCK/NTP_CURRENTSTOCK.ascx" %>

<link href="/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-base.css" rel="stylesheet"
    type="text/css" />
<link href="/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-sidebar.css"  rel="stylesheet" type="text/css" />
<link href="/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-topbar.css"  rel="stylesheet" type="text/css" />
<div align=center>
<table style="border-left: 1px solid rgb(85, 85, 85); border-right: 1px solid rgb(85, 85, 85);" width="1024px" border="0" cellpadding="0" cellspacing="0" height="100%">
	<tbody>
	<tr>
		<td style="border-bottom: 1px solid rgb(85, 85, 85); background-repeat: repeat-x;" valign="top" background="<%= SkinPath %>images/topbar_bg.gif" height="21">
			<table width="100%" border="0" cellpadding="0" cellspacing="0" height="100%">
			<tbody><tr>
				<td valign="middle" align="left" nowrap="nowrap">
					<dnn:CURRENTDATE runat="server" id="dnnCURRENTDATE" />
				</td>
				<td valign="middle" align="right" nowrap="nowrap">
					<dnn:USER runat="server" id="dnnUSER" /> /&nbsp;<dnn:LOGIN runat="server" id="dnnLOGIN" />
				</td>
			</tr>
			</tbody>
			</table>
		</td>
	</tr>
	<tr>
		<td id="Banner_Bg" >
			<table id="Banner_Img" width="100%" border="0" cellpadding="0" cellspacing="0" height="100%" width=100%>
				<tbody>
					<tr>
						<td id="logo">
							<dnn:LOGO runat="server" id="dnnLOGO" />
						</td>
						<td align=right valign=bottom height=111 style="padding-bottom:10px;padding-right:10px;"  background="<%= SkinPath %>/images/Green-banner-1024.gif" width=95%>
						<font color="#ff6600">Trang chủ | Diễn đàn | Trao đổi trực tuyến | Thăm dò ý kiến | Câu hỏi | Trợ giúp</font> </td>
					</tr>
				</tbody>
			</table>
		</td>
	</tr>
	<tr>
		<td style="border-top: 1px solid rgb(102, 102, 102); border-bottom: 1px solid rgb(85, 85, 85); background-repeat: repeat-x;" background="<%= SkinPath %>/images/bread_bg.gif" height="25">
			<table width="100%" border="0" cellpadding="0" cellspacing="0" height="100%">
			<tbody><tr>
				<td style="padding-top: 3px;" valign="top" nowrap="nowrap">
					<dnn:SEARCH runat="server" id="dnnSEARCH" />
				</td>
				<td style="padding-top: 8px;" valign="top" width="100%" nowrap="nowrap">
				<span ><b>&nbsp;&nbsp;&nbsp;::&nbsp;</b></span>
					<dnn:BREADCRUMB runat="server" id="dnnBREADCRUMB" Separator="&nbsp;&raquo;&nbsp;" RootLevel="0" />
				
				</td>
			</tr>
		</tbody>
		</table>

		</td>	
	</tr>
	<tr>
		<td height="100%">
			<table width="100%" align="center" border="0" cellpadding="0" cellspacing="0" height="100%">
				<tbody>
					<tr>
						<td id="Left_Td" valign="top" background="<%=skinpath%>/images/left_bg.gif">
							<dnn:VERTICAL_MENU runat="server" id="dnnVERTICAL_MENU" />
						</td>
							
						<td  id="ContentPane" valign="top" style="padding-top:0px; border-left:solid 1px orange;width:100%" runat="server" >
							
						</td>
					</tr>
					
				</tbody>
			</table>
		</td>
	</tr>
	<tr>
		<td style="border-top: 1px solid rgb(102, 102, 102); border-bottom: 1px solid rgb(85, 85, 85); background-repeat: repeat-x;" valign="middle" align="center" background="<%= SkinPath %>images/botbar_bg.gif" height="25" nowrap="nowrap">
			<!-- Add Current Stock here-->
			<cc1:CURRENTSTOCK id="current" runat=server ></cc1:CURRENTSTOCK>
		</td>	
	</tr>
	<tr>
		<td valign="top" align="center" bgcolor="#dcdcdc" nowrap="nowrap">
			<dnn:COPYRIGHT runat="server" id="dnnCOPYRIGHT" />
		</td>
	</tr>
</tbody>
</table>

</div>