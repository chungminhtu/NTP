<%@ Control language="vb" CodeBehind="~/admin/Containers/container.vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Containers.Container" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONS" Src="~/Admin/Containers/SolPartActions.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ICON" Src="~/Admin/Containers/Icon.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TITLE" Src="~/Admin/Containers/Title.ascx" %>
<%@ Register TagPrefix="dnn" TagName="VISIBILITY" Src="~/Admin/Containers/Visibility.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONBUTTON1" Src="~/Admin/Containers/ActionButton.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONBUTTON2" Src="~/Admin/Containers/ActionButton.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONBUTTON3" Src="~/Admin/Containers/ActionButton.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONBUTTON4" Src="~/Admin/Containers/ActionButton.ascx" %>
<%@ Register TagPrefix="dnn" TagName="ACTIONBUTTON5" Src="~/Admin/Containers/ActionButton.ascx" %>
<!-- XDMediaMadness Theme - http://www.xd.com.au -->
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="Orange_Curved_Master">
  <tr>
    <td class="Orange_Curved03">
      <table height="27" border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td valign="top" class="Orange_Curved01"><dnn:ACTIONS runat="server" id="dnnACTIONS" /></TD>
          <td valign="top" class="Orange_Curved01"><dnn:ICON runat="server" id="dnnICON" /></TD>
          <td valign="top" class="Orange_Curved01">&nbsp;<dnn:TITLE runat="server" id="dnnTITLE" CssClass="Orange_Curved_Title"/></TD>
          <td valign="top" class="Orange_Curved02">&nbsp;</TD>
          <td valign="bottom" class="Orange_Curved03">&nbsp;</TD>
        </tr>
</table>
      <table width="100%" border="0" align="center" cellPadding="0" cellSpacing="0">
        <tr>
          <td class="Orange_Curved_Content"><div runat="server" id="ContentPane"></div>
</TD>
        </tr>
</table>
      <table width="100%" height="21" border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td valign="middle" class="Orange_Curved04">&nbsp;</TD>
          <td valign="middle" class="Orange_Curved05">&nbsp;</TD>
        </tr>
</table>
    </td>
  </tr>
</table>
<table width="100%" height="25" border="0" cellpadding="2" cellspacing="0">
              <tr valign="bottom">
                <td align="left" ><dnn:ACTIONBUTTON1 runat="server" id="dnnACTIONBUTTON1" CommandName="AddContent.Action" DisplayIcon="True" DisplayLink="True" /></TD>
                <td height="22" align="right" ><dnn:ACTIONBUTTON2 runat="server" id="dnnACTIONBUTTON2" CommandName="SyndicateModule.Action" DisplayIcon="True" DisplayLink="False" />&nbsp;<dnn:ACTIONBUTTON3 runat="server" id="dnnACTIONBUTTON3" CommandName="PrintModule.Action" DisplayIcon="True" DisplayLink="False" />&nbsp;<dnn:ACTIONBUTTON4 runat="server" id="dnnACTIONBUTTON4" CommandName="ModuleSettings.Action" DisplayIcon="True" DisplayLink="False" /><dnn:ACTIONBUTTON5 runat="server" id="dnnACTIONBUTTON5" CommandName="ModuleHelp.Action" DisplayIcon="True" DisplayLink="False" /></TD>
        </tr>
</table>

