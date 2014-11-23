<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_KETQUADT.ViewNTP_BN_KETQUADT" CodeFile="ViewNTP_BN_KETQUADT.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register Assembly="DotNetNuke.WebControls" Namespace="DotNetNuke.UI.WebControls"
    TagPrefix="DNN" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Size="X-Small" ForeColor="Maroon"
    Width="552px">Danh s&#225;ch bệnh nh&#226;n điều trị</asp:TextBox>&nbsp;<table style="width: 800px">
    <tr>
        <td colspan="3">
            &nbsp;&nbsp;
<cc3:MultiSelectGrid ID="grdDSBenhnhan1" runat="server" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" Width="100%"
                CssClass="ntp_grd_GridViewStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                ItemStyle-CssClass = "ntp_grd_RowStyle"
                PagerStyle-CssClass = "ntp_grd_PagerStyle"                HighlightCssClass="ntp_grd_SelectedRowStyle" font-bold="False" multiselect="False"
                ><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
<asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_Dieutri" HeaderText="Dieutri" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="NgayVV" HeaderText="Ng&#224;y ĐKĐT">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Hoten" HeaderText="Họ t&#234;n bệnh nh&#226;n">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Tuoi" HeaderText="Tuổi">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="gioitinh" HeaderText="Giới t&#237;nh">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SoDKDT" HeaderText="Số ĐKĐT">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Phanloaibenh" HeaderText="Ph&#226;n loại bệnh">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="PhanloaiBN" HeaderText="Ph&#226;n loại BN">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle" Font-Italic="False" Font-Strikeout="False" Font-Underline="False" Font-Overline="False" Font-Bold="True"></HeaderStyle>
</cc3:MultiSelectGrid>
<br />
        </td>
    </tr>
</table>
&nbsp;&nbsp;