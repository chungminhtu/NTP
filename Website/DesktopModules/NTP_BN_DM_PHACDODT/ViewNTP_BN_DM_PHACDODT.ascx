<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_DM_PHACDODT.ViewNTP_BN_DM_PHACDODT" CodeFile="ViewNTP_BN_DM_PHACDODT.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>

<table class="ntp_table_main">

    <tr>
        <td width="20%" style="height: 26px">
        </td>
        <td colspan="2" width="80%" style="height: 26px">
            <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Thêm mới" Width="100px" OnClick="cmdAdd_Click" />&nbsp;
            <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" /></td>
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
                PagerStyle-CssClass = "ntp_grd_PagerStyle"                HighlightCssClass="ntp_grd_SelectedRowStyle"
                >
                <Columns>
                    <asp:TemplateColumn>
                        <headerstyle width="2%"  />
                        
                    </asp:TemplateColumn>
                    <asp:TemplateColumn>
                        <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"></asp:ImageButton>
</itemtemplate>
                        <headerstyle width="2%" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_PhacDoDT" HeaderText="ID_PhacDoDT" Visible="False"></asp:BoundColumn>
                 
                    <asp:BoundColumn DataField="ten_PhacDoDT" HeaderText="T&#234;n phác đồ điều trị">
                        <headerstyle width="90%" />
                    </asp:BoundColumn>
                   
                </Columns>
                <PagerStyle Mode="NumericPages" />
            </cc3:MultiSelectGrid>
            &nbsp;</td>
    </tr>
</table>
