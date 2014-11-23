<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_KETQUAKIEMDINH.ViewNTP_KD_KETQUAKIEMDINH" CodeFile="ViewNTP_KD_KETQUAKIEMDINH.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>

<fieldset class="ntp_fieldset" style="width: 850px">
        <legend class="ntp_legend">Danh sách phiếu lấy mẫu kiểm định tiêu bản </legend>
         <table class="ntp_table_main">
             <tr>
                 <td style="width: 11%">
                     <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="80px"></asp:Label></td>
                 <td colspan="2">
                     <asp:DropDownList ID="CboDMTinh" runat="server" CssClass="ntp_combobox" DataTextField="TEN_TINH"
                         DataValueField="MA_TINH" TabIndex="1" Width="215px">
                     </asp:DropDownList></td>
                 <td colspan="2" style="width: 352px">
                 </td>
                 <td style="width: 20%">
                 </td>
             </tr>
          <tr>
          <td style="width: 11%" >
              <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Lọc theo tháng năm"
                  Width="128px"></asp:Label></td>
          <td style="width: 8%">
              &nbsp;<asp:DropDownList ID="cboQuy" runat="server" CssClass="ntp_combobox" TabIndex="2"
                  Width="57px">
                  <asp:ListItem Value="1">1</asp:ListItem>
                  <asp:ListItem Value="2">2</asp:ListItem>
                  <asp:ListItem Value="3">3</asp:ListItem>
                  <asp:ListItem Value="4">4</asp:ListItem>
                  <asp:ListItem>5</asp:ListItem>
                  <asp:ListItem>6</asp:ListItem>
                  <asp:ListItem>7</asp:ListItem>
                  <asp:ListItem>8</asp:ListItem>
                  <asp:ListItem>9</asp:ListItem>
                  <asp:ListItem>10</asp:ListItem>
                  <asp:ListItem>11</asp:ListItem>
                  <asp:ListItem>12</asp:ListItem>
              </asp:DropDownList>
          </td>
              <td style="width: 14%">
               <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6"
                   Width="96px"></asp:TextBox></td>
              <td colspan="2" style="width: 352px">
                  &nbsp;
               &nbsp;<asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtNam"
                    ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator></td>
          <td style="width: 20%">
                <asp:Button ID="cmdTim" runat="server" CausesValidation="False"
                        CssClass="ntp_button" Text="Tìm" Width="99px" Height="25px" /></td>
          </tr>
          <tr>
          <td style="width: 100%;" colspan="6">
        
                <cc3:multiselectgrid id="grdDSBaoCao" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                    autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                    headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                    itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                    selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True"
                    width="100%" ><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False  ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_PLAYMAU" HeaderText="ID_PLAYMAU" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="ThangLM" HeaderText="Th&#225;ng">
<HeaderStyle Width="10px"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Nam" HeaderText="Năm b&#225;o c&#225;o">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_BenhVien" HeaderText="Cơ sở điều trị">
<HeaderStyle Width="25%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Tinh" HeaderText="Tỉnh">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="KTVien" HeaderText="Người cung cấp">
<HeaderStyle Width="25%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ketqua" HeaderText="Ketqua" visible=false>
<HeaderStyle Width="5%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="KetquaKD" HeaderText="Kết quả KĐ">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
              &nbsp;
              </td>
              </tr>
              </table>
    <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="8" Text="Thêm"
        Width="100px" />
    <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa" Width="100px" /></fieldset>


