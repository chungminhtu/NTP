<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_SOKHAMBENH.ViewNTP_SOKHAMBENH" CodeFile="ViewNTP_SOKHAMBENH.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
     <asp:Button ID="CmdDSBenhnhan" runat="server" BackColor="LightCyan"
             BorderColor="Gainsboro" BorderStyle="None" Font-Bold="True" ForeColor="#0000C0"
             TabIndex="18" Text="Danh sách bệnh nhân" Width="180px" />
     <asp:Button ID="CmdChuyenden" runat="server" BackColor="WhiteSmoke" BorderColor="PowderBlue"
         BorderStyle="None" Font-Bold="True" ForeColor="#0000C0" TabIndex="11" Text="Danh sách bệnh nhân chuyển đến"
         Width="256px" /><br />
 <asp:Panel ID="pnlChuyenDen" runat=server Width="759px"  Visible="False" >
 <fieldset class="ntp_fieldset" style="width: 748px">
     <br />
        <table class="ntp_table_main" style="width: 728px">
          <tr>
          <td style="width: 110%;">
        
                <cc3:multiselectgrid id="grdDSBenhNhan" runat="server" allowpaging="True" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                    autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                    headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                    itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                    selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" showfooter="True"
                    width="94%" multiselect="False"><Columns>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False  ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="5%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_Phieuchuyen" HeaderText="ID_Phieuchuyen" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="ID_Dieutri" HeaderText="ID_Dieutri" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="ID_BenhNhan" HeaderText="M&#227; bệnh nh&#226;n" Visible="False">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TEN_DVCHUYEN" HeaderText="ĐV chuyển">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TenNgaychuyen" HeaderText="Ng&#224;y chuyển">
<HeaderStyle Width="15%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="HoTen" HeaderText="Họ t&#234;n bệnh nh&#226;n" >
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="SoCMND" HeaderText="Số CMTND">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Tuoi" HeaderText="Tuổi">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="GT" HeaderText="Giới t&#237;nh">
<HeaderStyle Width="10%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="PhanloaiBenh" HeaderText="Ph&#226;n loại bệnh">
<HeaderStyle Width="20%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="PhanLoaiBN" HeaderText="Ph&#226;n loại BN">
<HeaderStyle Width="20%"></HeaderStyle>
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
              </td>
              </tr>
              </table>
     &nbsp;
            
              </fieldset>
     <br />
              </asp:Panel>
 <asp:Panel ID="pnlDieuTri" runat="server" Width="57%" Visible="False" ><FIELDSET style="WIDTH: 805px" class="ntp_fieldset"><asp:Label id="Label7" Width="209px" Text="Điều kiện tìm kiếm:" ForeColor="#C00000" runat="server" CssClass="ntp_label" Font-Overline="False"></asp:Label>&nbsp;
     <asp:DropDownList id="cboRaVien" tabIndex=10 Width="51px" runat="server" Visible="False" CssClass="ntp_combobox">
                                  <asp:ListItem Value="0">Danh s&#225;ch BN</asp:ListItem>
                   <asp:ListItem Value="1">Đang điều trị</asp:ListItem>
                   <asp:ListItem Value="2">Ra viện</asp:ListItem>
               </asp:DropDownList>
     <ajaxtoolkit:maskededitextender id="Maskededitextender2" runat="server" autocomplete="true"
         culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtTungay"></ajaxtoolkit:maskededitextender>
     <ajaxtoolkit:maskededitextender id="Maskededitextender1" runat="server" autocomplete="true"
         culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="txtDenngay"></ajaxtoolkit:maskededitextender>
     <BR /><TABLE style="WIDTH: 804px"><TBODY>
         <tr>
             <td style="width: 82px; height: 11px">
                 <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Tỉnh" Width="66px"></asp:Label></td>
             <td colspan="2" style="height: 11px">
                 <asp:DropDownList ID="cboTinh" runat="server" AutoPostBack="True" CssClass="ntp_combobox"
                     DataTextField="TEN_TINH" DataValueField="MA_TINH" TabIndex="3" Width="170px">
                 </asp:DropDownList></td>
             <td style="width: 59px; height: 11px">
                 <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Huyện" Width="66px"></asp:Label></td>
             <td colspan="2" style="height: 11px">
                 <asp:DropDownList ID="CmbHuyen" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                     DataValueField="ID_BENHVIEN" TabIndex="2" Width="196px">
                 </asp:DropDownList></td>
             <td colspan="2" style="height: 11px">
                 <asp:RadioButtonList id="OptDVDT" tabIndex=5 Width="242px" runat="server" RepeatDirection="Horizontal" Height="1px" AutoPostBack="True">
                                  <asp:ListItem Selected="True" Value="1">Tại ĐV điều trị</asp:ListItem>
                                  <asp:ListItem Value="0">ĐV điều trị kh&#225;c</asp:ListItem>
                              </asp:RadioButtonList></td>
         </tr>
         <TR><TD style="WIDTH: 82px; height: 18px;"><asp:Label id="Label11" Width="81px" Text="NgàyĐKĐT" runat="server" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 51px; height: 18px;">
                   <asp:TextBox ID="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6"
                       Width="87px"></asp:TextBox></TD><TD style="WIDTH: 76px; height: 18px;">
                   <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="đến ngày" Width="68px"></asp:Label></TD><TD style="WIDTH: 59px; height: 18px;">
                   <asp:TextBox ID="TxtDenngay" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6"
                       Width="83px"></asp:TextBox></TD><TD style="WIDTH: 70px; height: 18px;"><asp:Label id="Label1" Width="79px" Text="Mã BNQL" runat="server" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 94px; height: 18px;"><asp:TextBox id="TxtMaBN" tabIndex=6 Width="113px" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox></TD><TD colSpan=2 style="height: 18px"></TD></TR><TR><TD style="WIDTH: 82px"><asp:Label id="Label2" Width="79px" Text="Họ tên BN" runat="server" CssClass="ntp_label"></asp:Label></TD><TD colSpan=3><asp:TextBox id="TxtHotenTK" tabIndex=6 Width="257px" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox></TD><TD style="WIDTH: 70px"><asp:Label id="Label8" Width="79px" Text="Số CMND" runat="server" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 94px"><asp:TextBox id="TxtSoCMTTK" tabIndex=6 Width="113px" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox></TD><TD style="WIDTH: 86px"><asp:Label id="Label12" Width="94px" Text="Phân loại bệnh" runat="server" CssClass="ntp_label"></asp:Label></TD>
         <TD style="width: 125px"><asp:DropDownList id="cboPhanLoaiBenh" tabIndex=17 Width="134px" runat="server" CssClass="ntp_combobox" DataValueField="ID_PhanLoaiBenh" DataTextField="Ten_PhanLoaiBenh">
                              </asp:DropDownList></TD></TR>
         <tr>
             <td style="width: 82px; height: 27px;">
                 <asp:Label id="Label10" Width="79px" Text="Địa chỉ" runat="server" CssClass="ntp_label"></asp:Label></td>
             <td colspan="5" style="height: 27px">
                 <asp:TextBox id="TxtDiachiTK" tabIndex=6 Width="460px" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox></td>
             <td style="width: 86px; height: 27px;">
                 <asp:Button ID="cmdTim" runat="server" CausesValidation="False" CssClass="ntp_button"
                     Height="25px" Text="Tìm" Width="85px" /></td>
             <td style="width: 125px; height: 27px;">
                 <asp:Button ID="InDSach" runat="server" CausesValidation="False" CssClass="ntp_button"
                     Height="25px" Text="In DSBN" Width="78px" /></td>
         </tr>
     </TBODY></TABLE><TABLE style="WIDTH: 808px" class="ntp_table_main"><TBODY><TR><TD style="WIDTH: 100%"><cc3:multiselectgrid id="grdDSBenhNhanDieuTri" runat="server" multiselect="False" width="100%" showfooter="True" selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle" itemstyle-cssclass="ntp_grd_RowStyle" highlightcssclass="ntp_grd_SelectedRowStyle" headerstyle-cssclass="ntp_grd_HeaderStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle" cssclass="ntp_grd_GridViewStyle" autogeneratecolumns="False" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle" allowpaging="True"><Columns><asp:TemplateColumn><ItemTemplate><asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False   ></asp:ImageButton><%--enabled='<%#Not(DataBinder.Eval(Container.DataItem, "RV")) %>'--%></ItemTemplate><HeaderStyle Width="2%"></HeaderStyle></asp:TemplateColumn><asp:BoundColumn DataField="ID_BenhNhan" HeaderText="M&#227; bệnh nh&#226;n" Visible="False"><HeaderStyle Width="10%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="STT" HeaderText="STT"><HeaderStyle Width="7%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="HoTen" HeaderText="Họ t&#234;n bệnh nh&#226;n"><HeaderStyle Width="15%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="SoDKDT" HeaderText="Số ĐKĐT" Visible="False"><HeaderStyle Width="15%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="SoCMND" HeaderText="Số CMT"><HeaderStyle Width="8%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="Tuoi" HeaderText="Tuổi"><HeaderStyle Width="5%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="GT" HeaderText="Giới t&#237;nh"><HeaderStyle Width="5%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="Diachi" HeaderText="Địa chỉ"><HeaderStyle Width="20%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="Sodienthoai" HeaderText="Ghi chu" Visible="False"><HeaderStyle Width="10%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="MaBNQL" HeaderText="MaBNQL" ><HeaderStyle Width="8%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="ten_PhanLoaiBenh" HeaderText="Phân loại BN" ><HeaderStyle Width="15%"></HeaderStyle></asp:BoundColumn></Columns><EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle><SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle><PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle><AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle><ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle><HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle></cc3:multiselectgrid> &nbsp; </TD></TR></TBODY></TABLE><FIELDSET style="WIDTH: 805px" class="ntp_fieldset"><LEGEND class="ntp_legend">Thông tin bệnh nhân&nbsp;</LEGEND>
    <TABLE style="WIDTH: 789px"><TBODY>
        <tr>
            <td style="width: 122px">
                <asp:Label id="Label3" Width="118px" Text="Họ tên bệnh nhân" runat="server" CssClass="ntp_label"></asp:Label></td>
            <td style="width: 189px">
                <asp:TextBox id="txtTenBenhNhan" tabIndex=4 Width="98%" runat="server" CssClass="ntp_textbox" MaxLength="50" Enabled="False"></asp:TextBox></td>
            <td style="width: 108px">
                <asp:TextBox id="txtMaBenhNhan" tabIndex=5 Width="105px" runat="server" CssClass="ntp_textbox" MaxLength="50" Enabled="False"></asp:TextBox></td>
            <td style="width: 60px">
                <asp:Label id="Label6" Width="67px" Text="Giới tính" runat="server" CssClass="ntp_label"></asp:Label></td>
            <td>
                <asp:RadioButtonList id="optlistGioiTinh" tabIndex=7 Width="112px" runat="server" RepeatDirection="Horizontal" Height="18px" Enabled="False">
                <asp:ListItem Value="1" Selected="True">Nam</asp:ListItem>
                <asp:ListItem Value="0">Nu</asp:ListItem>
            </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td style="width: 122px">
            </td>
            <td style="width: 189px">
        <asp:TextBox id="txtSoCMT" tabIndex=8 Width="12%" runat="server" CssClass="ntp_textbox" MaxLength="50" Enabled="False" Visible="False"></asp:TextBox> <asp:DropDownList id="cboHuyen" tabIndex=10 Width="25px" runat="server" Visible="False" CssClass="ntp_combobox" DataValueField="MA_HUYEN" DataTextField="TEN_HUYEN" Enabled="False">
                </asp:DropDownList> <asp:TextBox id="TxtSoDKDT" tabIndex=8 Width="3%" runat="server" Visible="False" CssClass="ntp_textbox" MaxLength="50" Enabled="False"></asp:TextBox></td>
            <td style="width: 108px">
                <asp:TextBox id="txtDiaChi" tabIndex=1 Width="4%" runat="server" Visible="False" CssClass="ntp_textbox" MaxLength="50" Enabled="False"></asp:TextBox></td>
            <td style="width: 60px">
                <asp:TextBox id="txtDienThoai" tabIndex=11 Width="3px" runat="server" Visible="False" CssClass="ntp_textbox" MaxLength="50" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:TextBox id="txtTuoi" tabIndex=6 Width="35px" runat="server" CssClass="ntp_textbox" MaxLength="50" Enabled="False" Visible="False"></asp:TextBox></td>
        </tr>
    </TBODY></TABLE><TABLE style="WIDTH: 808px" class="ntp_table_main"><TBODY><TR><TD style="HEIGHT: 23px">
<cc3:multiselectgrid id="grdDSDieuTri" runat="server" width="100%" showfooter="True" selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle" itemstyle-cssclass="ntp_grd_RowStyle" highlightcssclass="ntp_grd_SelectedRowStyle" headerstyle-cssclass="ntp_grd_HeaderStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle" cssclass="ntp_grd_GridViewStyle" autogeneratecolumns="False" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle" allowpaging="True" pagesize="5" height="118px"><Columns><asp:TemplateColumn><HeaderStyle Width="2%"></HeaderStyle></asp:TemplateColumn><asp:TemplateColumn><ItemTemplate><asp:ImageButton id="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False  enabled='<%#Not(DataBinder.Eval(Container.DataItem, "RV")) %>'></asp:ImageButton></ItemTemplate><HeaderStyle Width="2%"></HeaderStyle></asp:TemplateColumn><asp:BoundColumn DataField="ID_DieuTri" HeaderText="ID_DieuTri" Visible="False"></asp:BoundColumn><asp:BoundColumn DataField="MaBNQL" HeaderText="Ma BNQL"><HeaderStyle Width="10%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="ten_PhanLoaiBenh" HeaderText="Ph&#226;n loại bệnh"><HeaderStyle Width="15%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="ten_PhanLoaiBN" HeaderText="Ph&#226;n loại BN"><HeaderStyle Width="15%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="PHACDODIEUTRI" HeaderText="Ph&#225;c đồ ĐT"><HeaderStyle Width="12%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="Ten_ngayVV" HeaderText="Ng&#224;y ĐKĐT"><HeaderStyle Width="12%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="TEN_NGAYRV" HeaderText="Ng&#224;y KTĐT"><HeaderStyle Width="12%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="ten_KetQuaDT" HeaderText="Kết quả ĐT"><HeaderStyle Width="10%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="huyenXN" HeaderText="X&#225;c nhận" Visible="False"><HeaderStyle Width="0%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="Ten_Benhvien" HeaderText="Cơ sở ĐT"><HeaderStyle Width="10%"></HeaderStyle></asp:BoundColumn><asp:BoundColumn DataField="RV" HeaderText="RV" Visible="False"><HeaderStyle Width="10%"></HeaderStyle></asp:BoundColumn></Columns><EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle><SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle><PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle><AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle><ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle><HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle></cc3:multiselectgrid> <BR /></TD></TR><TR>
         <TD style="WIDTH: 100%">&nbsp;<asp:Button id="cmdAddDieuTri" tabIndex=8 Width="100px" Text="Thêm" runat="server" CssClass="ntp_button" CausesValidation="False" EnableTheming="True"></asp:Button>
     <asp:Button ID="cmdXoa" runat="server" CssClass="ntp_button" Text="Xóa "
                 Width="100px" />&nbsp;
            
             <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server" ConfirmText="Bạn thực sự muốn xóa Đợt điều trị này?"
                 TargetControlID="cmdXoa"></ajaxToolkit:ConfirmButtonExtender>
 
 </TD></TR></TBODY></TABLE>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal></FIELDSET> </FIELDSET></asp:Panel>