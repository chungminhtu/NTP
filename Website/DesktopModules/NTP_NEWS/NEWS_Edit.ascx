<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NEWS_Edit.ascx.vb" Inherits="YourCompany.Modules.NTP_NEWS.DesktopModules_NTP_NEWS_NEWS_Edit" %>
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
<table style="width: 100%">
    <tr>
        <td style="width: 15%;">
            <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Text="Tiêu đề" Width="130px"></asp:Label>&nbsp;
            </td>
        <td>
            <asp:TextBox ID="txtTieuDe" runat="server" Width="80%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTieuDe"
                ErrorMessage="Chưa nhập nội dung tiêu đề"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Mô tả" Width="130px"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtNewID" runat="server" Visible="False" Width="80%"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:TextBox ID="txtMoTa" runat="server" Height="116px" TextMode="MultiLine" Width="768px"></asp:TextBox></td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Nội dung" Width="130px"></asp:Label></td>
        <td style="height: 21px">
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:TextBox ID="txtNoiDung" runat="server" Height="183px" TextMode="MultiLine" Width="769px"></asp:TextBox></td>
    </tr>
    <tr>
        <td >
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td >
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td >
        </td>
        <td>
            &nbsp;<asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="20"
                Text="Lưu" Width="100px" />&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <cc3:multiselectgrid id="dgvDanhSach" runat="server" autogeneratecolumns="False"
                cssclass="ntp_grd_GridViewStyle" width="100%" highlightcssclass="ntp_grd_SelectedRowStyle">
<PagerStyle CssClass="ntp_grd_PagerStyle"></PagerStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>
<Columns>
<asp:BoundColumn DataField="NewID" HeaderText="[NewID]" Visible="False"></asp:BoundColumn>
<asp:TemplateColumn HeaderText="X&#243;a"><ItemTemplate>
<asp:ImageButton id="cmdDelete" runat="server" __designer:wfdid="w20" CommandName="delete" ImageUrl="~/images/delete.gif" CausesValidation="False"></asp:ImageButton>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn HeaderText="Sửa"><ItemTemplate>
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w19" CommandName="edit" ImageUrl="~/images/edit.gif" CausesValidation="False"></asp:ImageButton> 
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="TieuDe" HeaderText="Ti&#234;u đề"></asp:BoundColumn>
<asp:BoundColumn DataField="MoTa" HeaderText="M&#244; tả"></asp:BoundColumn>
<asp:BoundColumn DataField="NoiDung" HeaderText="Nội dung"></asp:BoundColumn>
<asp:BoundColumn DataField="ThoiGian" HeaderText="Ng&#224;y tạo"></asp:BoundColumn>
<asp:BoundColumn DataField="UserName" HeaderText="Người tạo"></asp:BoundColumn>
</Columns>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
        </td>
    </tr>
</table>
</asp:Panel>