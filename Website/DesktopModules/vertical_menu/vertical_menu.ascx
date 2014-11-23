<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Controls.vertical_menu"
    CodeFile="vertical_menu.ascx.vb" %>
<!-- Begin menu <div id="transmenu"> -->

    <!--<link href="<%=Request.ApplicationPath%>/admin/skins/Vertical_Menu/ddlevelsfiles/ddlevelsmenu.css" type="text/css"
        rel="stylesheet" xmlns:fo="http://www.w3.org/1999/XSL/Format"> -->
    <link rel="stylesheet" type="text/css" href="<%=Request.ApplicationPath%>/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-base.css" />
    <link rel="stylesheet" type="text/css" href="<%=Request.ApplicationPath%>/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-topbar.css" />
    <link rel="stylesheet" type="text/css" href="<%=Request.ApplicationPath%>/desktopmodules/Vertical_Menu/ddlevelsfiles/ddlevelsmenu-sidebar.css" />

    
    <input type="hidden" id ="serverpath" value ="<%=Request.ApplicationPath%>/desktopmodules/Vertical_Menu/ddlevelsfiles/" />
 <%=MenuRootItems%>

<script type="text/javascript">
var t 
t =document.getElementById("serverpath").value 
//alert(t);
ddlevelsmenu.setup("ddsidemenubar", "sidebar",t) //ddlevelsmenu.setup("mainmenuid", "topbar|sidebar")
</script>
