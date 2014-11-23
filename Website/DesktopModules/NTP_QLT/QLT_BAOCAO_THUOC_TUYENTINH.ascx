<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_BAOCAO_THUOC_TUYENTINH.ascx.vb" Inherits="QLT_BAOCAO_THUOC_TUYENTINH" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat="server" Width="100%">
    <table class="ntp_table_main" width="100%">
        <tr>
            <td width="15%">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
            <td width="85%">
                <asp:DropDownList ID="cboNam" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Tìm kiếm" CssClass="ntp_button" /></td>
        </tr>
        <tr>
            <td width="15%">
            </td>
            <td width="85%">
            </td>
        </tr>
        <tr>
            <td colspan="2" valign="top" width="15%">
                <cc3:multiselectgrid id="grdDS" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                    autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                    headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                    itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                    selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="100%">
                    <EditItemStyle CssClass="ntp_grd_EditRowStyle"  />
                    <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"  />
                    <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages"  />
                    <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"  />
                    <ItemStyle CssClass="ntp_grd_RowStyle"  />
                    <Columns>
                        <asp:TemplateColumn Visible="False"></asp:TemplateColumn>
                        <asp:BoundColumn DataField="ID_KY_KIEMKE" HeaderText="ID Kỳ kiểm k&#234;" Visible="False">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="THANG" HeaderText="THANG" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="NAM" HeaderText="NAM" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="TRANG_THAI" HeaderText="TRANG_THAI" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="TEN_KY_KIEMKE" HeaderText="M&#244; tả">
                            <headerstyle width="60%" ></headerstyle>
                        </asp:BoundColumn>
                        <asp:BoundColumn HeaderText="Trạng th&#225;i">
                            <headerstyle width="10%" ></headerstyle>
                        </asp:BoundColumn>
                        <asp:TemplateColumn>
                            <itemtemplate>
<asp:Button id="cmdBaoCao" runat="server" Text="Xem Báo cáo" CssClass="ntp_button" CommandName="baocao" __designer:wfdid="w3"></asp:Button> 
</itemtemplate>
                            <headerstyle width="10%" ></headerstyle>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <itemtemplate>
<asp:Button id="cmdKetChuyenSoLieu" runat="server" Text="Kết chuyển số liệu" CssClass="ntp_button" CommandName="ketchuyen" __designer:wfdid="w4"></asp:Button>
</itemtemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <HeaderStyle CssClass="ntp_grd_HeaderStyle"  />
                </cc3:multiselectgrid>
            </td>
        </tr>
    </table>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal></asp:Panel>
