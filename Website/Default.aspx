<%@ Page Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.Framework.DefaultPage" CodeFile="Default.aspx.vb" %>

<%@ Register Assembly="AjaxControls" Namespace="AjaxControls" TagPrefix="cc1" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Common.Controls" Assembly="DotNetNuke" %>
<asp:literal id="skinDocType" runat="server"></asp:literal>
<html <%=xmlns%> <%=LanguageCode%>>
<head id="Head" runat="server">
    <meta content="text/html; charset=UTF-8" http-equiv="Content-Type"/>
    <meta content="text/javascript" http-equiv="Content-Script-Type"/>
    <meta content="text/css" http-equiv="Content-Style-Type"/>
    <meta id="MetaRefresh" runat="Server" http-equiv="Refresh" name="Refresh" />
    <meta id="MetaDescription" runat="Server" name="DESCRIPTION" />
    <meta id="MetaKeywords" runat="Server" name="KEYWORDS" />
    <meta id="MetaCopyright" runat="Server" name="COPYRIGHT" />
    <meta id="MetaGenerator" runat="Server" name="GENERATOR" />
    <meta id="MetaAuthor" runat="Server" name="AUTHOR" />
    <meta name="RESOURCE-TYPE" content="DOCUMENT" />
    <meta name="DISTRIBUTION" content="GLOBAL" />
    <meta name="ROBOTS" content="INDEX, FOLLOW" />
    <meta name="REVISIT-AFTER" content="1 DAYS" />
    <meta name="RATING" content="GENERAL" />
    <meta http-equiv="PAGE-ENTER" content="RevealTrans(Duration=0,Transition=1)" />
        
    <style type="text/css" id="StylePlaceholder" runat="server"></style>
    
    <asp:placeholder id="CSS" runat="server" /> 
  

	<style type="text/css">
		#dnn_ctr_ctl00_imgIcon
{
	display:none;
}

		#dnn_ctr_dnnTITLE_lblTitle
		{
		display:none;
}
	</style>


</head>

<body id="Body" runat="server">
    <noscript></noscript>
    <dnn:Form id="Form" runat="server" ENCTYPE="multipart/form-data" >
      
        <asp:Label ID="SkinError" runat="server" CssClass="NormalRed" Visible="False"></asp:Label>
        <asp:PlaceHolder ID="SkinPlaceHolder" runat="server" />
        <input id="ScrollTop" runat="server" name="ScrollTop" type="hidden" />
        <input id="__dnnVariable" runat="server" name="__dnnVariable" type="hidden" />
         
   <script language="javascript">
    
//$('input[type="text"], textarea, select').css('border', '1px solid #033773');
$('input[type="text"], textarea, select').focus(function(){
//$(this).css('border', '1px solid #013773');
$(this).css('background-color', '#ffde8b');
});
$('input[type="text"], textarea, select').blur(function(){
//$(this).css('border', '1px solid #7790b9');
$(this).css('background-color', '#ffffff');
});
</script>

    </dnn:Form>
</body>
</html>
