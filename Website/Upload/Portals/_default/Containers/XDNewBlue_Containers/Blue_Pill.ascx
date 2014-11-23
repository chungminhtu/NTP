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
<link href="Blue_Pill.css" rel="stylesheet" type="text/css">
      <TABLE width="100%" height="21" border="0" cellpadding="0" cellspacing="0" class="Blue_Pill02">
        <TR>
          <TD width="5" valign="middle" nowrap >&nbsp;</TD>
          <TD valign="middle" nowrap ><dnn:ACTIONS runat="server" id="dnnACTIONS" /></TD>
          <TD width="1" valign="middle"><dnn:ICON runat="server" id="dnnICON" /></TD>
          <TD height="22" valign="top">&nbsp;<dnn:TITLE runat="server" id="dnnTITLE" CssClass="Blue_Pill_Title" /></TD>
          <TD width="10" valign="top"><dnn:VISIBILITY runat="server" id="dnnVISIBILITY" /></TD>
          <TD width="15" valign="middle">&nbsp;</TD>
        </TR>
</TABLE>
      <TABLE width="100%" border="0" cellPadding="0" cellSpacing="0" Class="Blue_Pill_Master">
        <TR>
          <TD valign="top" id="ContentPane" runat="server" CssClass="Blue_Pill_Content"></TD>
        </TR>
</TABLE>
      <TABLE width="100%" height="3" border="0" cellpadding="0" cellspacing="0">
              <TR valign="bottom">
                <TD align="left" nowrap><dnn:ACTIONBUTTON1 runat="server" id="dnnACTIONBUTTON1" CommandName="AddContent.Action" DisplayIcon="True" DisplayLink="True" /></TD>
                <TD height="22" align="right" nowrap><dnn:ACTIONBUTTON2 runat="server" id="dnnACTIONBUTTON2" CommandName="SyndicateModule.Action" DisplayIcon="True" DisplayLink="False" />&nbsp;<dnn:ACTIONBUTTON3 runat="server" id="dnnACTIONBUTTON3" CommandName="PrintModule.Action" DisplayIcon="True" DisplayLink="False" />&nbsp;<dnn:ACTIONBUTTON4 runat="server" id="dnnACTIONBUTTON4" CommandName="ModuleSettings.Action" DisplayIcon="True" DisplayLink="False" /><dnn:ACTIONBUTTON5 runat="server" id="dnnACTIONBUTTON5" CommandName="ModuleHelp.Action" DisplayIcon="True" DisplayLink="False" /></TD>
        </TR>
      </TABLE>


