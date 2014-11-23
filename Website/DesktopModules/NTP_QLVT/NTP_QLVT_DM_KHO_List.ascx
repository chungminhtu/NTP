<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_QLVT_DM_KHO_List.ascx.vb" Inherits="NTP_QLVT_DM_KHO_List" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>

<asp:Panel ID="pnlAll" runat="server">
    <table class="ntp_table_main">
        <tr>
            <td width="20%">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên kho"></asp:Label></td>
            <td colspan="2" width="80%">
                <asp:TextBox ID="txtTEN_KHO" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="1"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 24px" width="20%">
                <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Tỉnh"></asp:Label></td>
            <td colspan="2" style="height: 24px" width="80%">
                <asp:DropDownList ID="cboTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                    DataValueField="MA_TINH" TabIndex="2" Width="150px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td width="20%">
                <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Huyện"></asp:Label></td>
            <td colspan="2" width="80%">
                <asp:DropDownList ID="cboHuyen" runat="server" CssClass="ntp_combobox" DataTextField="TEN_HUYEN"
                    DataValueField="MA_HUYEN" TabIndex="2" Width="150px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td width="20%">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Kho cấp trên"></asp:Label></td>
            <td width="60%">
                <cc4:autosuggestbox id="txtSearhKhoCapTren" runat="server" cssclass="ntp_textbox" DataPage="searchkho.aspx" ResourcesDir="/asb_includes"  ></cc4:autosuggestbox>
            </td>
            <td width="20%">
                <asp:Button ID="cmdSearch" runat="server" CssClass="ntp_button" Text="Tìm kiếm" Width="100px" /></td>
        </tr>
        <tr>
            <td width="20%">
            </td>
            <td colspan="2" width="80%">
                <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Thêm mới" Width="100px" />&nbsp;
                <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" /></td>
        </tr>
        <tr>
            <td colspan="3" width="20%">
                <cc3:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
                    AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
                    HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
                    ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
                    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
                    <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                    <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                    <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
                    <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
                    <ItemStyle CssClass="ntp_grd_RowStyle" />
                    <Columns>
                        <asp:TemplateColumn>
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <itemtemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
    
</itemtemplate>
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="ID_KHO" HeaderText="ID_KHO" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="MA_TINH" HeaderText="MA_TINH" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="MA_HUYEN" HeaderText="MA_HUYEN" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="MA_KHO" HeaderText="M&#227; kho">
                            <headerstyle width="10%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_KHO" HeaderText="T&#234;n kho">
                            <headerstyle width="20%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="DIA_CHI" HeaderText="Địa chỉ">
                            <headerstyle width="30%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_TINH" HeaderText="Tỉnh">
                            <headerstyle width="16%" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_HUYEN" HeaderText="Huyện">
                            <headerstyle width="20%" />
                        </asp:BoundColumn>
                    </Columns>
                    <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                </cc3:MultiSelectGrid></td>
        </tr>
    </table>
</asp:Panel>
