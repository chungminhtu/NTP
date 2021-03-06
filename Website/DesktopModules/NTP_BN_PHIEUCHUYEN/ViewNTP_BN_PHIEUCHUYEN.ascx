<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_PHIEUCHUYEN.ViewNTP_BN_PHIEUCHUYEN" CodeFile="ViewNTP_BN_PHIEUCHUYEN.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>


<table class="ntp_table_main" style="width: 800px">
    <tr>
        <td style="width: 1%; height: 26px">
            </td>
        <td style="width: 1%; height: 26px">
            <asp:Label ID="Label1" runat="server" Text="Năm chuyển" Width="92px"></asp:Label>
            <asp:TextBox ID="TxtNam" runat="server" CssClass="ntp_textbox"></asp:TextBox></td>
        <td colspan="2" style="height: 26px; width: 1%;">
            &nbsp; &nbsp;&nbsp;
            <asp:Button ID="CmdXem" runat="server" CssClass="ntp_button" Text="Xem" Width="100px" />
            <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" /></td>
    </tr>
    <tr>
        <td style="width: 1%; height: 26px">
        </td>
        <td style="width: 1%; height: 26px">
        </td>
        <td colspan="2" style="width: 1%; height: 26px">
        </td>
    </tr>
    <tr>
        <td colspan="4" style="height: 26px">
         <cc3:MultiSelectGrid ID="grdDSBenhnhan1" runat="server" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" Width="100%"
                CssClass="ntp_grd_GridViewStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                ItemStyle-CssClass = "ntp_grd_RowStyle"
                PagerStyle-CssClass = "ntp_grd_PagerStyle"                HighlightCssClass="ntp_grd_SelectedRowStyle"
                ><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
<asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_Phieuchuyen" HeaderText="Phieuchuyen" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="Hoten" HeaderText="Họ t&#234;n bệnh nh&#226;n">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Tuoi" HeaderText="Tuổi">
<HeaderStyle Width="8%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Gioitinh" HeaderText="Giới t&#237;nh">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="PhanloaiDT" HeaderText="Ph&#226;n loại">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="DVTIEPNHAN" HeaderText="ĐV.Tiếp nhận">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TinhtrangBN" HeaderText="TinhtrangBN">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Lydo" HeaderText="L&#253; do chuyển">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ngaychuyen" HeaderText="Ng&#224;y chuyển">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SoDKDT" HeaderText="Số ĐKĐT">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:MultiSelectGrid>
        </td>
    </tr>
</table>
<br />

