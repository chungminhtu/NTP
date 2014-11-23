<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM.ViewNTP_BN_PHIEUXETNGHIEM" CodeFile="ViewNTP_BN_PHIEUXETNGHIEM.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
&nbsp;&nbsp;<br />
 <asp:Panel ID="PnlPhieuXN" runat=server  Visible="true" >
<br />

<fieldset class="ntp_fieldset" style="width: 810px">
        &nbsp;
    <ajaxtoolkit:maskededitextender id="Maskededitextender2" runat="server" autocomplete="true"
        culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtTungay"> </ajaxtoolkit:maskededitextender>
    <ajaxtoolkit:maskededitextender id="Maskededitextender1" runat="server" autocomplete="true"
        culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtDenngay"> </ajaxtoolkit:maskededitextender>
    <table style="width: 804px">
        <tr>
            <td style="width: 82px">
                <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="66px"></asp:Label></td>
            <td colspan="2">
                <asp:DropDownList ID="cboTinh" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                    DataTextField="TEN_TINH" DataValueField="MA_TINH" TabIndex="3" Width="193px">
                </asp:DropDownList></td>
            <td style="width: 59px">
                <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Huyện" Width="66px"></asp:Label></td>
            <td colspan="2">
                <asp:DropDownList ID="CmbHuyen" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                    DataValueField="ID_BENHVIEN" TabIndex="2" Width="201px">
                </asp:DropDownList></td>
            <td colspan="3">
                <asp:RadioButtonList ID="OptDVDT" runat="server" AutoPostBack="True" Height="1px"
                    RepeatDirection="Horizontal" TabIndex="5" Width="244px">
                    <asp:ListItem Selected="True" Value="1">Tại ĐV điều trị</asp:ListItem>
                    <asp:ListItem Value="0">ĐV điều trị kh&#225;c</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td style="width: 82px">
                <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Từ Ngày XN" Width="86px"></asp:Label></td>
            <td style="width: 54px">
                <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="6" Width="90px"></asp:TextBox></td>
            <td style="width: 77px">
                <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="đến ngày" Width="64px"></asp:Label></td>
            <td style="width: 59px">
                <asp:TextBox ID="TxtDenngay" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="6" Width="90px"></asp:TextBox></td>
            <td style="width: 70px">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Mã BNQL" Width="79px"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TxtMaBN" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6"
                    Width="113px"></asp:TextBox></td>
            <td colspan="3">
                </td>
        </tr>
        <tr>
            <td style="width: 82px">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Họ tên BN" Width="85px"></asp:Label></td>
            <td colspan="3">
                <asp:TextBox ID="TxtHotenTK" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="6" Width="255px"></asp:TextBox></td>
            <td style="width: 70px">
                <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Số CMND" Width="79px"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TxtSoCMTTK" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="6" Width="113px"></asp:TextBox></td>
            <td style="width: 102px">
                </td>
            <td colspan="2">
                </td>
        </tr>
        <tr>
            <td style="width: 82px; height: 17px">
                <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Địa chỉ" Width="85px"></asp:Label></td>
            <td colspan="7" style="height: 17px">
                <asp:TextBox ID="TxtDiachiTK" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="6" Width="531px"></asp:TextBox></td>
            <td style="width: 125px; height: 17px">
                <asp:Button ID="cmdTim" runat="server" CausesValidation="False" CssClass="ntp_button"
                    Height="25px" Text="Tìm" Width="99px" /></td>
        </tr>
    </table>
    <br />

    <cc3:multiselectgrid id="grdDSBenhNhan" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
        autogeneratecolumns="False" edititemstyle-cssclass="ntp_grd_EditRowStyle"
        headerstyle-cssclass="ntp_grd_HeaderStyle"
        itemstyle-cssclass="ntp_grd_RowStyle" multiselect="False" pagerstyle-cssclass="ntp_grd_PagerStyle"
        selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="102%"><Columns>
<asp:TemplateColumn><ItemTemplate>
<asp:ImageButton id="cmdEdit" runat="server" CausesValidation="False" ImageUrl="~/images/edit.gif" CommandName="edit" __designer:wfdid="w2"></asp:ImageButton> <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="5%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_Benhnhan" HeaderText="ID_Benhnhan" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="ID_BenhNhan" HeaderText="M&#227; BN" Visible="False">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="STT" HeaderText="STT">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="HoTen" HeaderText="Họ t&#234;n bệnh nh&#226;n">
<HeaderStyle Width="25%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SoCMND" HeaderText="Số CMTND">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Tuoi" HeaderText="Tuổi">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="GT" HeaderText="Giới t&#237;nh">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="ten_LyDoXN" HeaderText="L&#253; do XN">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="KetquaXN" HeaderText="Kếtquả XN"></asp:BoundColumn>
<asp:BoundColumn DataField="PhanloaiKQXN" HeaderText="Ketqua"  Visible="False" ></asp:BoundColumn>
<asp:BoundColumn DataField="MaBNQL" HeaderText="MaBNQL">
<HeaderStyle Width="8%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle" Font-Italic="False" Font-Strikeout="False" Font-Underline="False" Font-Overline="False" Font-Bold="False"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" Font-Italic="False" Font-Strikeout="False" Font-Underline="False" Font-Overline="False" Font-Bold="False"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle" Font-Italic="False" Font-Strikeout="False" Font-Underline="False" Font-Overline="False" Font-Bold="False"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
      &nbsp;<br />
    <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Ghi chú: (*) Bệnh nhân từ nơi khác chuyển đến"
        Width="492px"></asp:Label>
              </fieldset>
<fieldset class="ntp_fieldset" style="width: 828px; height: 541px;">
         <table class="ntp_table_main">
         <tr>
            <td style="height: 24px; width: 14%;">
                <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Họ tên bệnh nhân" Width="118px"></asp:Label></td>
            <td colspan="2" width="80%" style="width: 50%">
                <asp:TextBox ID="txtTenBenhNhan" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="4" Width="100%" Enabled="False"></asp:TextBox>
                </td>
            <td colspan="2" valign="top">
                <asp:TextBox ID="txtMaBenhNhan" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="5" Width="136px" Enabled="False"></asp:TextBox>
                </td>
            <td colspan="2" valign="top" style="width: 6px">
                <asp:TextBox ID="txtSoCMT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8"
                    Width="100%" Enabled="False" Visible="False"></asp:TextBox></td>
        </tr>
             <tr>
                 <td style="width: 14%; height: 24px">
                 </td>
                 <td align="center" colspan="2" style="width: 50%" width="80%">
                     <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="8" Text="Thêm"
    Width="100px" CausesValidation="False" />
<asp:Button ID="CmdIn" runat="server" CssClass="ntp_button" TabIndex="8" Text="In  XNBN"
    Width="100px" CausesValidation="False" />
    
              <asp:Button ID="cmdDelete" runat="server" CausesValidation="False" CssClass="ntp_button"
                  TabIndex="10" Text="Xoá" Width="100px" />
                   <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa Phiếu xét nghiệm này?"
                 TargetControlID="cmdDelete">
             </ajaxToolkit:ConfirmButtonExtender>
                  
                  </td>
                 <td colspan="2" valign="top">
                 </td>
                 <td colspan="2" style="width: 6px" valign="top">
                 </td>
             </tr>
          <tr>
          <td style="width: 100%;" colspan="7">
        <cc3:multiselectgrid id="grdDSXetNghiem" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True" width="100%"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False  enabled='<%#Not(DataBinder.Eval(Container.DataItem, "Quyen")) %>'  ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="5%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_Phieuxetnghiem" HeaderText="ID_Phieuxetnghiem" Visible="False">
<HeaderStyle Width="2px"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SoXN" HeaderText="Số XN">
<HeaderStyle Width="5%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TEN_NGAYNM" HeaderText="Ng&#224;y nhận mẫu">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_LyDoXN" HeaderText="L&#253; do x&#233;t nghiệm">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_PhanLoaiYTe" HeaderText="Ph&#226;n loại y tế">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ketqua" HeaderText="Kết quả XN">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_BenhVien" HeaderText="Đơn vị XN">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SoDKDT" HeaderText="Số ĐKĐT">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="huyenXN" HeaderText="X&#225;c nhận" Visible="False">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Quyen" HeaderText="Quyen ds" Visible="false">
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
              &nbsp;&nbsp;
              <asp:Literal ID="Literal1" runat="server"></asp:Literal></td>
              </tr>
              </table>
    <br />
    <br />
    <br />
    &nbsp;<br />
              </fieldset>
              </asp:Panel> 