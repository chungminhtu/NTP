<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_DM_KHO_List.ascx.vb" Inherits="QLT_DM_KHO_List" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
&nbsp;<cc2:ActionsMenu ID="ActionsMenu1" runat="server">
</cc2:ActionsMenu>
<fieldset   class="ntp_fieldset">
<legend>Quản lý thông tin kho</legend>
<li><asp:Label runat="server" ID="label1"></asp:Label><asp:TextBox ID="txtMaKho" runat="server"> </asp:TextBox></li>
</fieldset>
<asp:Button ID="Button1" runat="server" Text="Edit" />
<asp:GridView ID="dgv_DM_Kho_Duoc" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Ma_Kho" HeaderText="M&#227; kho" />
        <asp:BoundField DataField="Ten_Kho" HeaderText="T&#234;n kho" />
        <asp:BoundField DataField="Cap_Kho" HeaderText="Cấp kho" />
        <asp:BoundField DataField="ID_Kho_CapTren" HeaderText="T&#234;n kho cấp tr&#234;n" />
        <asp:BoundField DataField="Dia_Chi" HeaderText="Địa chỉ" />
    </Columns>
</asp:GridView>
<cc1:DNNDataGrid ID="DNNDataGrid1" runat="server" Height="74px" Width="436px">
    <Columns>
        <asp:BoundColumn DataField="Ma_Kho" HeaderText="M&#227; kho"></asp:BoundColumn>
        <asp:BoundColumn DataField="T&#234;n kho" HeaderText="T&#234;n kho"></asp:BoundColumn>
        <asp:BoundColumn DataField="Cap_Kho" HeaderText="Cấp kho"></asp:BoundColumn>
        <asp:BoundColumn DataField="ID_Kho_CapTren" HeaderText="Kho cấp tr&#234;n"></asp:BoundColumn>
        <asp:BoundColumn DataField="Dia_Chi" HeaderText="Địa chỉ"></asp:BoundColumn>
    </Columns>
</cc1:DNNDataGrid>
<asp:Label ID="ABC" runat="server"></asp:Label>