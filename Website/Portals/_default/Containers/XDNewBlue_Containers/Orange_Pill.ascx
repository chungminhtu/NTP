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
<link href="Orange_Pill.css" rel="stylesheet" type="text/css">
      <table width="100%" height="21" border="0" cellpadding="0" cellspacing="0" class="Orange_Pill02">
        <tr>
          <td width="5" valign="middle" nowrap >&nbsp;</td>
          <td valign="middle" nowrap><dnn:ACTIONS runat="server" id="dnnACTIONS" /></td>
          <td width="1" valign="middle"><dnn:ICON runat="server" id="dnnICON" /></td>
          <td height="22" valign="top">&nbsp;<dnn:TITLE runat="server" id="dnnTITLE" CssClass="Orange_Pill_Title" /></td>
          <td width="10" valign="top"><dnn:VISIBILITY runat="server" id="dnnVISIBILITY" /></td>
          <td width="15" valign="middle">&nbsp;</td>
        </tr>
</table>
      <table width="100%" border="0" cellPadding="0" cellSpacing="0" Class="Orange_Pill_Master">
        <tr>
          <td valign="top" id="ContentPane" runat="server" CssClass="Orange_Pill_Content"></td>
        </tr>
</table>
      <table width="100%" height="3" border="0" cellpadding="0" cellspacing="0">
              <tr valign="bottom">
                <td align="left" nowrap><dnn:ACTIONBUTTON1 runat="server" id="dnnACTIONBUTTON1" CommandName="AddContent.Action" DisplayIcon="True" DisplayLink="True" /></td>
                <td height="22" align="right" nowrap><dnn:ACTIONBUTTON2 runat="server" id="dnnACTIONBUTTON2" CommandName="SyndicateModule.Action" DisplayIcon="True" DisplayLink="False" />&nbsp;<dnn:ACTIONBUTTON3 runat="server" id="dnnACTIONBUTTON3" CommandName="PrintModule.Action" DisplayIcon="True" DisplayLink="False" />&nbsp;<dnn:ACTIONBUTTON4 runat="server" id="dnnACTIONBUTTON4" CommandName="ModuleSettings.Action" DisplayIcon="True" DisplayLink="False" /><dnn:ACTIONBUTTON5 runat="server" id="dnnACTIONBUTTON5" CommandName="ModuleHelp.Action" DisplayIcon="True" DisplayLink="False" /></td>
        </tr>
      </table>

