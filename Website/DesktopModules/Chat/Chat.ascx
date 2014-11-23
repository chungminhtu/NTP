<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Chat.ascx.vb" Inherits="DotNetNuke.Modules.Chat.DesktopModules_Chat_Chat" %>
<%@ Register Namespace="DotNetNuke.Modules.Chat" TagPrefix="chat" %>
<chat:DnnChat runat="server" ID="ChatControl" MessageCssClass="NormalBold" SenderCssClass="Normal" Width="100%">
    <SendAreaStyle CssClass="NormalTextBox" />
</chat:DnnChat>
