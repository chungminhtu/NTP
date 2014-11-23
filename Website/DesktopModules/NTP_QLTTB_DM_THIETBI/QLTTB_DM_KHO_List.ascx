<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLTTB_DM_KHO_List.ascx.vb" Inherits="QLTTB_DM_KHO_List" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<fieldset   class="ntp_fieldset" style="height: 69px; width: 528px;">
<legend>Quản lý thông tin trang thiết bị</legend>
<li><asp:Label runat="server" ID="label1"></asp:Label><asp:TextBox ID="txtMaKho" runat="server"> </asp:TextBox>&nbsp;
    <asp:Button ID="btn_thongtin" runat="server" Text="Button" Width="78px" /></li>
    <li></li>
    <li>
   
<asp:GridView ID="MultiSelectGrid1" runat="server" AutoGenerateColumns="False" Width="514px" CssClass="ntp_grd_GridViewStyle"><Columns>
<asp:BoundField DataField="ID_THIETBI" SortExpression="matrangthietbi" HeaderText="M&#227; thiết bị"></asp:BoundField>
<asp:BoundField DataField="TEN_THIETBI" SortExpression="tentrangthietbi" HeaderText="T&#234;n thiết bị"></asp:BoundField>
<asp:BoundField DataField="MA_NUOC" SortExpression="nuocsanxuat" HeaderText="Nước sản xuất"></asp:BoundField>
<asp:BoundField DataField="ID_DVT" SortExpression="donvitinh" HeaderText="Đơn vị t&#237;nh"></asp:BoundField>
<asp:BoundField DataField="NHAN_HIEU" SortExpression="nhanhieu" HeaderText="Nh&#227;n hiệu"></asp:BoundField>
</Columns>
</asp:GridView>
    </li>
</fieldset>
