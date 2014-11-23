<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NEWS_List.ascx.vb" Inherits="YourCompany.Modules.NTP_NEWS.DesktopModules_NTP_NEWS_NEWS_List" %>
<%@ Register Assembly="MetaBuilders.WebControls.ConfirmedButtons" Namespace="MetaBuilders.WebControls"
    TagPrefix="mbcb" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>

<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server Width="100%">
    <asp:Label ID="lblTieuDe" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="ActiveCaption"></asp:Label><br />
    <asp:Label ID="lblMoTa" runat="server"></asp:Label><br />
    <br />
    <asp:Label ID="lblNoiDung" runat="server"></asp:Label><br />
    <br />
    <hr />
    <asp:Label ID="lblNguoiLap" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            &nbsp;-
    <asp:Label ID="lblNgayLap" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label></asp:Panel>
