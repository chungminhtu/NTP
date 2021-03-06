<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_XACNHANBAOCAO.ViewNTP_BN_XACNHANBAOCAO" CodeFile="ViewNTP_BN_XACNHANBAOCAO.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
&nbsp;<FIELDSET class="ntp_fieldset" style="width: 692px"><LEGEND class="ntp_legend">Danh sách báo cáo</LEGEND>
    <table style="width: 683px">
        <tr>
            <td style="width: 69px">
            <asp:Label ID="Label40" runat="server" CssClass="ntp_label" Text="Quý" Width="65px"></asp:Label></td>
            <td style="width: 63px">
            <asp:DropDownList ID="cboDieuKien" runat="server" CssClass="ntp_combobox" TabIndex="2"
                Width="88px">
                <asp:ListItem Value="1">Qu&#253; I</asp:ListItem>
                <asp:ListItem Value="2">Qu&#253; II</asp:ListItem>
                <asp:ListItem Value="3">Qu&#253; III</asp:ListItem>
                <asp:ListItem Value="4">Qu&#253; IV</asp:ListItem>
            </asp:DropDownList></td>
            <td style="width: 21px">
            <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Năm" Width="37px"></asp:Label></td>
            <td style="width: 101px">
            <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11"
                Width="91px"></asp:TextBox></td>
            <td>
                <asp:RangeValidator ID="RangeValidator22" runat="server"
                    ControlToValidate="txtNam" ErrorMessage="Không đúng năm" MaximumValue="3000"
                    MinimumValue="1900" Type="Integer"></asp:RangeValidator><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNam" ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 69px; height: 27px">
            <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="61px"></asp:Label></td>
            <td colspan="2" style="height: 27px">
            <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox"
                DataTextField="TEN_TINH" DataValueField="MA_TINH" TabIndex="2" Width="194px">
            </asp:DropDownList></td>
            <td style="width: 101px; height: 27px">
            </td>
            <td style="height: 27px">
                <asp:Button id="cmdTim" Width="99px" runat="server" Text="Tìm" CssClass="ntp_button" Height="25px"></asp:Button></td>
        </tr>
        <tr>
            <td style="width: 69px; height: 15px">
            </td>
            <td style="width: 63px; height: 15px">
            </td>
            <td style="width: 21px; height: 15px">
            </td>
            <td style="width: 101px; height: 15px">
            </td>
            <td style="height: 15px">
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <cc3:multiselectgrid id="grdDSBaoCao" runat="server" width="100%" showfooter="True" selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle" itemstyle-cssclass="ntp_grd_RowStyle" highlightcssclass="ntp_grd_SelectedRowStyle" headerstyle-cssclass="ntp_grd_HeaderStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle" cssclass="ntp_grd_GridViewStyle" autogeneratecolumns="False" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle" allowpaging="True"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="MA_TINH" HeaderText="Matinh" Visible="FALSE"></asp:BoundColumn>
<asp:BoundColumn DataField="TEN_TINH" HeaderText="Tên tỉnh">
<HeaderStyle Width="27%"></HeaderStyle></asp:BoundColumn>
<asp:BoundColumn DataField="Quy" HeaderText="Qu&#253; b&#225;o c&#225;o">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Nam" HeaderText="Năm b&#225;o c&#225;o">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>

</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid> 
            </td>
        </tr>
    </table>
    <br />
    <asp:Button id="cmdAdd" tabIndex=8 Width="100px" runat="server" Text="Ghi" CssClass="ntp_button"></asp:Button>&nbsp;
</FIELDSET>