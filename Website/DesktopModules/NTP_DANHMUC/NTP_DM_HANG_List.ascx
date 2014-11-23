<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_HANG_List.ascx.vb" Inherits="NTP_DM_HANG_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<table  class = "ntp_table_main">

    <tr>
    
        <td width="20%" >
            </td>
        <td width = "80%" colspan = "2">
            &nbsp;</td>
        
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" Text="Tên hãng" CssClass="ntp_label"></asp:Label></td>
        <td width="60%">
            <asp:TextBox ID="txtHang" runat="server" CssClass="ntp_textbox" TabIndex="1" MaxLength="50"></asp:TextBox></td>
            <td width="20%"><asp:Button ID="cmdSearch" runat="server" Text="Tìm kiếm" CssClass="ntp_button" Width="100px" /></td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td width="80%" colspan="2">
            <asp:Button ID="cmdAdd" runat="server" Text="Thêm mới" CssClass="ntp_button" Width="100px" />&nbsp;
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="ntp_button" Width="100px" /></td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
            <cc3:MultiSelectGrid ID="grdDS" runat="server" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" Width="100%"
                CssClass="ntp_grd_GridViewStyle"
                HeaderStyle-CssClass="ntp_grd_HeaderStyle"
                AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle"
                EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                ItemStyle-CssClass = "ntp_grd_RowStyle"
                PagerStyle-CssClass = "ntp_grd_PagerStyle"
                HighlightCssClass="ntp_grd_SelectedRowStyle"
                >
                <Columns>
                    <asp:TemplateColumn>
                        <headerstyle width="2%"  />
                        
                    </asp:TemplateColumn>
                    <asp:TemplateColumn>
                        <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w4" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_HANG" HeaderText="ID_HANG" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_HANG" HeaderText="T&#234;n h&#227;ng sản xuất">
                        <headerstyle width="60%" />
                    </asp:BoundColumn>
                </Columns>
                <PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle" />
                <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                <ItemStyle CssClass="ntp_grd_RowStyle" />
                <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
            </cc3:MultiSelectGrid></td>
    </tr>
   
</table>




