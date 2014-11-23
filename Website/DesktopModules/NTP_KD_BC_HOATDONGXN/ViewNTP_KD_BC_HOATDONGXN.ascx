<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_BC_HOATDONGXN.ViewNTP_KD_BC_HOATDONGXN" CodeFile="ViewNTP_KD_BC_HOATDONGXN.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<fieldset class="ntp_fieldset" style="width: 742px">
    <legend class="ntp_legend">Danh sách Báo cáo Hoạt động xét nghiệm</legend>
    <table style="width: 728px">
        <tr>
            <td style="width: 77px; height: 27px">
                <asp:Label ID="Label22" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="64px"></asp:Label></td>
            <td style="width: 211px; height: 27px">
                <asp:DropDownList ID="CboDMTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                    DataValueField="MA_TINH" TabIndex="1" Width="214px">
                </asp:DropDownList></td>
            <td style="width: 24px; height: 27px">
                <asp:Label ID="Label24" runat="server" CssClass="ntp_label" Text="Năm BC" Width="76px"></asp:Label></td>
            <td style="width: 40px; height: 27px">
                <asp:DropDownList ID="cboDieuKien" runat="server" CssClass="ntp_combobox" TabIndex="2"
                    Width="77px">
                    <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                    <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                    <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                    <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 47px; height: 27px">
                <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="3"
                    Width="58px"></asp:TextBox></td>
            <td style="width: 108px; height: 27px">
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtNam"
                    ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
            <td style="height: 27px">
                <asp:Button ID="cmdTim" runat="server" CausesValidation="False" CssClass="ntp_button"
                    Height="25px" TabIndex="4" Text="Xem" Width="89px" /></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 27px">
                <asp:Button ID="CmdDaBaocao" runat="server" BackColor="LightCyan" BorderColor="Gainsboro"
                    BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="18" Text="Danh sách Đơn vị báo cáo"
                    Width="297px" /></td>
            <td colspan="3" style="height: 27px">
                <asp:Button ID="CmdChuaBaocao" runat="server" BackColor="WhiteSmoke" BorderColor="PowderBlue"
                    BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="11" Text="Danh sách Đơn vị chưa báo cáo"
                    Width="238px" /></td>
            <td style="width: 108px; height: 27px">
            </td>
            <td style="height: 27px">
            </td>
        </tr>
    </table>
    <cc3:multiselectgrid id="grdDSBaoCao" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
        autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
        headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
        itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
        selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="100%"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False enabled='<%#Not(DataBinder.Eval(Container.DataItem, "TinhXN")) %>' ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_HOATDONGXN" HeaderText="ID_HOATDONGXN" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="Quy" HeaderText="Quý">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Nam" HeaderText="Năm b&#225;o c&#225;o">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NgayBCIn" HeaderText="Ng&#224;y báo cáo">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NguoiBC" HeaderText="Người b&#225;o c&#225;o">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_BenhVien" HeaderText="Cơ sở y tế">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Tinh" HeaderText="Tỉnh">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TinhXNTT" HeaderText="X&#225;c nhận" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="TinhXN" HeaderText="Tỉnh XN" Visible="False">
<HeaderStyle Width="5%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
    <cc3:multiselectgrid id="GrdDSChuaBC" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
        autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
        headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
        itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
        selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="100%"><Columns>
<asp:BoundColumn DataField="MA_TINH" HeaderText="M&#227; Tỉnh" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="TEN_TINH" HeaderText="T&#234;n Tỉnh">
<HeaderStyle Width="30%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TEN_BENHVIEN" HeaderText="Cơ sở điều trị">
<HeaderStyle Width="50%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
    <br />
    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="8" Text="Thêm"
        Width="100px" />
    <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" /></fieldset>
&nbsp;&nbsp; 