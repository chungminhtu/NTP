<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLT_PHIEU_NHAP_List.ascx.vb" Inherits="QLT_PHIEU_NHAP_List" %>
&nbsp;
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat="server"><TABLE class="ntp_table_main"><TBODY><TR><TD width="20%"><asp:Label id="Label2" runat="server" Text="Mã phiếu" CssClass="ntp_label"></asp:Label></TD><TD width="30%"><asp:TextBox id="txtMA_PHIEU" runat="server" CssClass="ntp_textbox" MaxLength="20"></asp:TextBox></TD><TD width="20%"><asp:Label id="Label5" runat="server" Text="Nguồn kinh phí" CssClass="ntp_label"></asp:Label></TD><TD style="WIDTH: 30%"><asp:DropDownList id="cboNGUON_KINHPHI" runat="server" CssClass="ntp_combobox" Width="100%" DataValueField="ID_NGUONKINHPHI" DataTextField="MO_TA">
                </asp:DropDownList></TD></TR><TR><TD width="20%"><asp:Label id="Label3" runat="server" Text="Ngày nhập (từ ngày)" CssClass="ntp_label"></asp:Label></TD><TD width="30%"><asp:TextBox id="txtTuNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox> <ajaxtoolkit:maskededitextender id="MaskedEditExtender1" runat="server" targetcontrolid="txtTuNgay" promptcharacter="_" masktype="Date" mask="99/99/9999" culturename="vi-VN" autocomplete="true"> </ajaxtoolkit:maskededitextender> <ajaxtoolkit:maskededitvalidator id="MaskedEditValidator1" runat="server" tooltipmessage="Nhập ngày" setfocusonerror="True" invalidvaluemessage="Định dạng ngày không đúng" emptyvaluemessage="Date is required" display="Dynamic" controltovalidate="txtTuNgay" controlextender="MaskedEditExtender1"></ajaxtoolkit:maskededitvalidator> </TD><TD width="20%"><asp:Label id="Label4" runat="server" CssClass="ntp_label">Đến ngày</asp:Label></TD><TD style="WIDTH: 30%"><asp:TextBox id="txtDenNgay" runat="server" CssClass="ntp_textbox" MaxLength="50"></asp:TextBox> <ajaxtoolkit:maskededitextender id="MaskedEditExtender2" runat="server" targetcontrolid="txtDenNgay" promptcharacter="_" masktype="Date" mask="99/99/9999" culturename="vi-VN" autocomplete="true"> </ajaxtoolkit:maskededitextender> <ajaxtoolkit:maskededitvalidator id="MaskedEditValidator2" runat="server" tooltipmessage="Nhập ngày" setfocusonerror="True" invalidvaluemessage="Định dạng ngày không đúng" emptyvaluemessage="Date is required" display="Dynamic" controltovalidate="txtDenNgay" controlextender="MaskedEditExtender2"></ajaxtoolkit:maskededitvalidator> </TD></TR><TR display="Static"><TD width="20%"></TD><TD width="30%" colSpan=3><asp:Button id="cmdAdd" runat="server" Text="Thêm mới" CssClass="ntp_button"></asp:Button>&nbsp; <asp:Button id="cmdDelete" runat="server" Text="Xóa" CssClass="ntp_button" Width="100px"></asp:Button>&nbsp; <asp:Button id="cmdSearch" runat="server" Text="Tìm kiếm" CssClass="ntp_button" Width="100px"></asp:Button> <ajaxtoolkit:confirmbuttonextender id="cbe" runat="server" targetcontrolid="cmdDelete" confirmtext="Bạn thực sự muốn xóa phiếu nhập này?"></ajaxtoolkit:confirmbuttonextender> </TD></TR><TR><TD width="100%" colSpan=4>&nbsp;<asp:DataGrid id="grdDS" runat="server" CssClass="ntp_grd_GridViewStyle" Width="100%" Height="120px" AutoGenerateColumns="False" AllowPaging="True"  HighlightCssClass="ntp_grd_SelectedRowStyle" >
<PagerStyle Mode="NumericPages" HorizontalAlign="Center" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>
<Columns>
<asp:TemplateColumn><HeaderTemplate>
                                        <asp:CheckBox ID="NTP_QLT_PHIEUNHAPToggleAll" runat="server" onclick="toggleAllCheckboxes(this);" />
                                    
</HeaderTemplate>
<ItemTemplate>
                                        <asp:CheckBox ID="grdCmdSel" runat="server" />
                                    
</ItemTemplate>

<HeaderStyle CssClass="header_cell" Width="2%"></HeaderStyle>

<ItemStyle CssClass="icon_cell"></ItemStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
                                        <asp:ImageButton ID="cmdEdit" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif" />
                                    
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_PHIEUNHAP" HeaderText="ID_PHIEUNHAP" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="MA_PHIEU_NHAP" HeaderText="M&#227; phiếu nhập">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="ID_DONVI_NHAP" HeaderText="Đơn vị nhập">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NGAY_NHAP" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ng&#224;y nhập">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NAM" HeaderText="Năm">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="NGUOI_NHAP" HeaderText="Người nhập">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="LYDO_NHAPXUAT" HeaderText="L&#253; do nhập">
<HeaderStyle CssClass="header_cell" Width="30%"></HeaderStyle>

<ItemStyle Wrap="False" CssClass="table_cell" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="ID_NGUONKINHPHI" HeaderText="Nguồn kinh ph&#237;">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="TRANG_THAI" HeaderText="Trạng th&#225;i">
<HeaderStyle CssClass="header_cell"></HeaderStyle>

<ItemStyle CssClass="table_cell"></ItemStyle>
</asp:BoundColumn>
<asp:TemplateColumn Visible="False"><ItemTemplate>
                                        <em><span style="text-decoration: underline"></span></em>
                                        <asp:Button ID="cmdXem" runat="server" CommandName="cmdXem" 
                                            Text="Xem" />
                                    
</ItemTemplate>
</asp:TemplateColumn>
</Columns>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
                    <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
                    <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
                    <ItemStyle CssClass="ntp_grd_RowStyle" />
</asp:DataGrid></TD></TR></TBODY></TABLE></asp:Panel>
&nbsp;
