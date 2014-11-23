<%@ Control language="vb" CodeBehind="~/admin/Skins/skin.vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register TagPrefix="dnn" TagName="LOGO" Src="~/Admin/Skins/Logo.ascx" %>
<%@ Register TagPrefix="dnn" TagName="NAV" Src="~/Admin/Skins/Nav.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LINKS" Src="~/Admin/Skins/Links.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LANGUAGE" Src="~/Admin/Skins/Language.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SEARCH" Src="~/Admin/Skins/Search.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LOGIN" Src="~/Admin/Skins/Login.ascx" %>
<%@ Register TagPrefix="dnn" TagName="USER" Src="~/Admin/Skins/User.ascx" %>
<%@ Register TagPrefix="dnn" TagName="BREADCRUMB" Src="~/Admin/Skins/BreadCrumb.ascx" %>
<%@ Register TagPrefix="dnn" TagName="CURRENTDATE" Src="~/Admin/Skins/CurrentDate.ascx" %>
<%@ Register TagPrefix="dnn" TagName="COPYRIGHT" Src="~/Admin/Skins/Copyright.ascx" %>
<%@ Register TagPrefix="dnn" TagName="PRIVACY" Src="~/Admin/Skins/Privacy.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TERMS" Src="~/Admin/Skins/Terms.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SOLPARTMENU" Src="~/Admin/Skins/SolPartMenu.ascx" %>
<%@ Register TagPrefix="dnn" TagName="CanhBaoTopic" Src="~/Admin/Skins/CanhBaoTopic.ascx" %>

<script language="javascript" src="<%=Request.ApplicationPath%>/js/common.js"></script>
<script src="<%=Request.ApplicationPath %>/js/jquery.calculation.min.js" type="text/javascript"></script> 

<%@ Register TagPrefix="cc1" TagName="CURRENTSTOCK" Src="~/DesktopModules/NTP_CURRENTSTOCK/NTP_CURRENTSTOCK.ascx" %>

<link href="<%= SkinPath %>skin.css" rel="stylesheet" type="text/css" />
<link href="<%= SkinPath %>Portal_Flash.css" rel="stylesheet" type="text/css" />
<!--
Designed & Created by Nina Meiers - created for the DNN Community - http://www.xd.com.au / 
-->  

<div class="pagemaster" align="center" >
  <div class="topspace"></div>
  <div class="header01">
    <div class="banner">
    <div class="header">  <table border="0" align="center" cellpadding="0" cellspacing="0" id="flashtable">
  <tr>
    <td ><div class="logo"><dnn:LOGO runat="server" id="dnnLOGO" /></div>
          </td>
    <td>     <div class="bannerright"> <div class="dateholder"> 
      <dnn:CURRENTDATE runat="server" id="dnnCURRENTDATE" CssClass="darkbg" /></div>
      <div class="langholder"><dnn:LANGUAGE runat="server" id="dnnLANGUAGE" showMenu="False" showLinks="True" /></div>
      <div class="search"></div>   </div> 
      </td>
  </tr>
</table>

</div>
  </div>
  </div>
  <div class="menubg">
    <div class="menu">
    <div id="skingradient">
     <dnn:SOLPARTMENU runat="server" id="dnnSOLPARTMENU"  />
    </div>  </div>
  </div>
  <div class="userlogin01">
    <div class="userlogin02">
      <div class="userlogin">
      <dnn:USER runat="server" ID="dnnUSER" CssClass="lightbg" />&nbsp;|&nbsp;<dnn:LOGIN runat="server" ID="dnnLOGIN" CssClass="lightbg" />&nbsp;|&nbsp;<dnn:CanhBaoTopic runat="server" ID="CanhBaoTopic" CssClass="lightbg" /></div>
      <div class="breadcrumb">
        <dnn:BREADCRUMB runat="server" id="dnnBREADCRUMB" Separator="&nbsp;&#187;&nbsp;" RootLevel="0" CssClass="lightbg" />
      </div>
    </div>
  </div>
  <div class="content01"><!-- start content -->
    <div class="content">
                  <table border="0" width="100%" cellpadding="0" cellspacing="0" summary="Design Table">
        <tr valign="top">   
          <td colspan="3" id="TopPane" runat="server" class="toppane" align="left" valign="top"></td>
        </tr>
        <tr valign="top">
          <td rowspan="3" class="leftpane" id="LeftPane" runat="server" visible="false" align="left" valign="top"></td>
          <td colspan="2" class="contentpanetop" id="ContentPaneTop" runat="server" visible="false" align="left" valign="top"></td>
          </tr>
        <tr valign="top">
          <td id="ContentPane" runat="server" class="contentpane" visible="false" align="center" valign="top"  width=100%></td>
          <td id="RightPane" runat="server" class="rightpane" visible="false" align="left" valign="top"></td>
        </tr>
        <tr valign="top">
          <td colspan="2" class="contentpanebottom" id="ContentPaneBottom" runat="server" visible="false" align="left" valign="top"></td>
          </tr>
        <tr valign="top">
          <td colspan="3" id="BottomPane" runat="server" class="bottompane" align="left" valign="top"></td>
        </tr>
</table>      
      
    </div>
  </div><!-- end content -->
  <div class="footer01">
    <div class="footer">
      <div class="terms">
       <cc1:CURRENTSTOCK id="current" runat="server" ></cc1:CURRENTSTOCK>
      </div>
      <div class="copyright">
        <dnn:COPYRIGHT runat="server" id="dnnCOPYRIGHT" CssClass="lightbg" />
      </div>
    </div>
  </div>
</div>
<div align="center"><a href="http://www.dnnskins.com"><font color="#CCCCCC" size="1" face="Tahoma, verdana, geneva, sans-serif">Inspired by Nina</font></a></div>

