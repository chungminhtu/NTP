<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Blank.ascx.vb" Inherits="DesktopModules__Template_Blank" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<cc2:ActionsMenu ID="ActionsMenu1" runat="server">
</cc2:ActionsMenu>
&nbsp;
<asp:Button ID="Button1" runat="server" Text="Button" />
<cc1:DNNRichTextEditControl ID="DNNRichTextEditControl1" runat="server" />
