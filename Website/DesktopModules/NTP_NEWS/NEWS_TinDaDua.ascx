<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NEWS_TinDaDua.ascx.vb" Inherits="YourCompany.Modules.NTP_NEWS.DesktopModules_NTP_NEWS_NEWS_TinDaDua" %>
<%@ Register Assembly="MetaBuilders.WebControls.ConfirmedButtons" Namespace="MetaBuilders.WebControls"
    TagPrefix="mbcb" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>

<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAllTinTuc" runat=server Width="100%">
    <asp:DataList ID="dtlAllNews" runat="server" Width="100%">
        <ItemTemplate>
            <asp:HyperLink ID="lblTieuDe" NavigateUrl='<%# "~/Default.aspx?tabid=204&NewID="& DataBinder.Eval(Container, "DataItem.NewID").ToString()%>' runat="server"><%#DataBinder.Eval(Container, "DataItem.TieuDe")%></asp:HyperLink>
            (<asp:Label ID="lblNgay" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ThoiGian") %>' Font-Bold="True"></asp:Label>-<asp:Label ID="lblNguoiTao"
                runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Username") %>' Font-Bold="True"></asp:Label>)<br />
            <asp:Label ID="lblMoTa" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.Mota")%>'></asp:Label><br />
            <hr />
        </ItemTemplate>
    </asp:DataList></asp:Panel>
