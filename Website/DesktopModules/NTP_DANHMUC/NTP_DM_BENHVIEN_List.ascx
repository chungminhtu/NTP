<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_DM_BENHVIEN_List.ascx.vb" Inherits="NTP_DM_BENHVIEN_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<table  class = "ntp_table_main" width="100%">

    <tr>
    
        <td width="20%" >
            <asp:Label ID="Label1" runat="server" Text="Tên bệnh viện" CssClass="ntp_label"></asp:Label></td>
        <td width = "80%" colspan = "2">
            <asp:TextBox ID="txtTenBenhVien" runat="server" CssClass="ntp_textbox" TabIndex="1" MaxLength="50"></asp:TextBox>
            </td>
        
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label2" runat="server" CssClass="ntp_label">Cấp</asp:Label></td>
        <td width="60%">
            <asp:DropDownList ID="cboCap" runat="server" CssClass="ntp_combobox" Width="150px" DataTextField="TEN_CAP" DataValueField="ID_CAP" TabIndex="2">
            </asp:DropDownList></td>
            <td style="width: 20%"><asp:Button ID="cmdSearch" runat="server" Text="Tìm kiếm" CssClass="ntp_button" Width="100px" /></td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td width="80%" colspan="2">
            <asp:Button ID="cmdAdd" runat="server" Text="Thêm mới" CssClass="ntp_button" Width="100px" />&nbsp;
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="ntp_button" Width="100px" />&nbsp;&nbsp;<asp:Button ID="cmdCapBenhVien" runat="server" Text="Cấp bệnh viện" CssClass="ntp_button" Width="100px" />&nbsp;
            <asp:Button ID="cmdDonvi" runat="server" Text="Đơn vị báo cáo" CssClass="ntp_button" Width="136px" /></td>
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
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
                    <asp:TemplateColumn><ItemTemplate>
<asp:ImageButton id="cmdEdit" runat="server" __designer:wfdid="w4" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_BENHVIEN" HeaderText="ID_BENHVIEN" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_VUNG" HeaderText="ID_VUNG" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="MA_BENHVIEN" HeaderText="M&#227; bệnh viện">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_BENHVIEN" HeaderText="T&#234;n bệnh viện">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
                    <asp:BoundColumn DataField="DIA_CHI" HeaderText="Địa chỉ">
<HeaderStyle Width="50%"></HeaderStyle>
</asp:BoundColumn>
                    <asp:BoundColumn DataField="TEN_CAP" HeaderText="Cấp">
<HeaderStyle Width="6%"></HeaderStyle>
</asp:BoundColumn>
                    <asp:BoundColumn DataField="Ten_LoaiBV" HeaderText="Loại BV"></asp:BoundColumn>
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




