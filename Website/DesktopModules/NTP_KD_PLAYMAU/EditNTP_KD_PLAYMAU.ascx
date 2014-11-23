<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_KD_PLAYMAU.EditNTP_KD_PLAYMAU" CodeFile="EditNTP_KD_PLAYMAU.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>

<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
 &nbsp;&nbsp;
<asp:Panel ID="pnlLan1" runat =server width="65%" Height="123px">
    <table style="width: 795px">
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
            <td style="width: 211px">
                <asp:DropDownList ID="CboDonviKD1" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                          DataValueField="ID_BENHVIEN" TabIndex="1" Width="213px" Enabled="False">
                </asp:DropDownList></td>
            <td style="width: 53px" align="left">
                <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Tháng " Width="54px"></asp:Label></td>
            <td style="width: 25px">
                <asp:DropDownList ID="CboThang1" runat="server" CssClass="ntp_combobox" TabIndex="1" Width="101px" Enabled="False">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 78px" align="right">
                <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Năm" Width="54px"></asp:Label></td>
            <td style="width: 151px">
                <asp:TextBox ID="TxtNam1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="2"
                    Width="78px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Text="Ngày trả kết quả"
                    Width="130px"></asp:Label></td>
            <td style="width: 211px">
                <asp:TextBox ID="TxtNgayKDLan1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="4" Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtNgayKDLan1"
                    ErrorMessage="Không được trống" Width="121px"></asp:RequiredFieldValidator>&nbsp;<ajaxtoolkit:maskededitextender
                        id="MaskedEditExtender1" runat="server" autocomplete="true" culturename="vi-VN"
                        mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayKDLan1"> </ajaxtoolkit:maskededitextender>
                <ajaxtoolkit:maskededitvalidator id="Maskededitvalidator1" runat="server" controlextender="MaskedEditExtender1"
                    controltovalidate="TxtNgayKDLan1" display="Dynamic" emptyvaluemessage="Bạn phải nhập ngày"
                    invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                    tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator>
                &nbsp; &nbsp;
            </td>
            <td colspan="2" style="width: 68px" align="left">
                <asp:Label ID="Label16" runat="server" CssClass="ntp_label" Text="Người kiểm định lần 1"
                    Width="153px"></asp:Label></td>
            <td colspan="2">
                <asp:TextBox ID="TxtNguoiKDLan1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="8" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Nhận xét " Width="117px"></asp:Label></td>
            <td colspan="5">
                <asp:TextBox ID="txtNhanXetLan1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="5" Width="99%"></asp:TextBox></td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="pnlLan2" runat =server width="65%" Height="123px">
    <table style="width: 795px">
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
            <td style="width: 211px">
                <asp:DropDownList ID="CboDonviKD2" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                          DataValueField="ID_BENHVIEN" TabIndex="1" Width="213px" Enabled="False">
                </asp:DropDownList></td>
            <td style="width: 53px" align="left">
                <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Tháng " Width="54px"></asp:Label></td>
            <td style="width: 25px">
                <asp:DropDownList ID="CboThang2" runat="server" CssClass="ntp_combobox" TabIndex="1" Width="101px" Enabled="False">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 78px" align="right">
                <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Text="Năm" Width="54px"></asp:Label></td>
            <td style="width: 151px">
                <asp:TextBox ID="TxtNam2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="2"
                    Width="78px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Ngày trả kết quả"
                    Width="130px"></asp:Label></td>
            <td style="width: 211px">
                <asp:TextBox ID="TxtNgayKDLan2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="4" Width="150px"></asp:TextBox>
                <ajaxtoolkit:maskededitextender id="Maskededitextender2" runat="server" autocomplete="true"
                    culturename="vi-VN" mask="99/99/9999" masktype="Date" promptcharacter="_" targetcontrolid="TxtNgayKDLan2"> </ajaxtoolkit:maskededitextender>
                &nbsp;<ajaxtoolkit:maskededitvalidator id="Maskededitvalidator2" runat="server" controlextender="MaskedEditExtender1"
                    controltovalidate="TxtNgayKDLan2" display="Dynamic" emptyvaluemessage="Bạn phải nhập ngày"
                    invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                    tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
            <td colspan="2" style="width: 68px" align="left">
                <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Người kiểm định lần 2"
                    Width="153px"></asp:Label></td>
            <td colspan="2">
                <asp:TextBox ID="TxtNguoiKDLan2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="8" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Nhận xét " Width="117px"></asp:Label></td>
            <td colspan="5">
                <asp:TextBox ID="txtNhanXetLan2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="5" Width="99%"></asp:TextBox></td>
        </tr>
    </table>
                     <asp:TextBox ID="txtId_PhieuLayMau" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="11" Visible="False" Width="97px"></asp:TextBox></asp:Panel>
<asp:Panel ID="pnlBaoCao1" runat ="server" Visible=false Width="39%"  >

  <fieldset class="ntp_fieldset" style="width: 790px; height: 32px;">
        <legend class="ntp_legend">Danh sách kiểm định tiêu bản </legend>
                <cc3:multiselectgrid id="grdDSPhieuLayMau" runat="server" alternatingitemstyle-cssclass="ntp_grd_AltRowStyle"
                    autogeneratecolumns="False" cssclass="ntp_grd_GridViewStyle" edititemstyle-cssclass="ntp_grd_EditRowStyle"
                    headerstyle-cssclass="ntp_grd_HeaderStyle" highlightcssclass="ntp_grd_SelectedRowStyle"
                    itemstyle-cssclass="ntp_grd_RowStyle" pagerstyle-cssclass="ntp_grd_PagerStyle"
                    selecteditemstyle-cssclass="ntp_grd_SelectedRowStyle"
                    width="99%" allowpaging="True" pagesize="15"><Columns>
<asp:TemplateColumn>
<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:TemplateColumn><ItemTemplate>
    <asp:ImageButton id="cmdEdit3" runat="server" CommandName="edit" ImageUrl="~/images/edit.gif"  CausesValidation = False enabled='<%#Not(DataBinder.Eval(Container.DataItem, "Ketqua")) %>' ></asp:ImageButton>
    <%--<asp:HyperLink text="Tiếp nhận" id="lbEdit" runat="server" CommandName="edit"></asp:HyperLink>--%>
</ItemTemplate>

<HeaderStyle Width="2%"></HeaderStyle>
</asp:TemplateColumn>
<asp:BoundColumn DataField="ID_PLAYMAU_C" HeaderText="ID_PLAYMAU_C" Visible="False"></asp:BoundColumn>
<asp:BoundColumn DataField="SoTB" HeaderText="Số ti&#234;u bản">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KiemdinhH" HeaderText="Huyện">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KiemdinhT1" HeaderText="KĐ lần 1">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KiemdinhT2" HeaderText="KĐ lần 2">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Chatluong" HeaderText="CL bệnh phẩm">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Taymau" HeaderText="Tẩy mẫu">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_Dosach" HeaderText="Độ sạch">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_DoDay" HeaderText="Độ d&#224;y">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_KichCo" HeaderText="K&#237;ch cỡ">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="Ten_DoMin" HeaderText="Độ mịn">
<HeaderStyle Width="9%"></HeaderStyle>
</asp:BoundColumn>
<asp:BoundColumn DataField="KetquaKD" HeaderText="Kết quả KĐ" Visible="False">
<HeaderStyle Width="0%"></HeaderStyle>
</asp:BoundColumn>
</Columns>

<EditItemStyle CssClass="ntp_grd_EditRowStyle"></EditItemStyle>

<SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle"></SelectedItemStyle>

<PagerStyle Mode="NumericPages" CssClass="ntp_grd_PagerStyle"></PagerStyle>

<AlternatingItemStyle CssClass="ntp_grd_AltRowStyle"></AlternatingItemStyle>

<ItemStyle CssClass="ntp_grd_RowStyle"></ItemStyle>

<HeaderStyle CssClass="ntp_grd_HeaderStyle"></HeaderStyle>
</cc3:multiselectgrid>
      <table style="width: 779px" border="1">
          <tr>
              <td align="center" style="width: 60px; height: 26px">
                  <asp:Label ID="Label23" runat="server" CssClass="ntp_label" Text="Số tiêu bản" Width="52px"></asp:Label></td>
              <td align="center" style="width: 13px; height: 26px">
                  <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Huyện" Width="62px" Visible="False"></asp:Label></td>
              <td align="center" style="width: 73px; height: 26px">
                  <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Kiểm định (1) "
                      Width="63px"></asp:Label></td>
              <td align="center" style="width: 76px; height: 26px">
                  <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Kiểm đinh(2)" Width="63px" Visible="False"></asp:Label></td>
              <td align="center" style="width: 78px; height: 26px">
                     <asp:Label ID="Label33" runat="server" CssClass="ntp_label" Text="CL Bệnh phẩm" Width="63px"></asp:Label></td>
              <td align="center" style="width: 78px; height: 26px">
                      <asp:Label ID="Label39" runat="server" CssClass="ntp_label" Text="Tẩy màu"
                          Width="64px"></asp:Label></td>
              <td align="center" style="height: 26px">
                     <asp:Label ID="Label31" runat="server" CssClass="ntp_label" Text="Độ sạch" Width="64px"></asp:Label></td>
              <td align="center" style="width: 117px; height: 26px">
                     <asp:Label ID="Label27" runat="server" CssClass="ntp_label" Text="Độ dày"
                         Width="64px"></asp:Label></td>
              <td align="center" style="height: 26px">
                     <asp:Label ID="Label32" runat="server" CssClass="ntp_label" Text="Kích cỡ " Width="64px"></asp:Label></td>
              <td align="center" style="height: 26px">
                  <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Độ mịn " Width="64px"></asp:Label></td>
              <td align="center" style="width: 79px; height: 26px">
                     <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Ghi chú" Width="76px"></asp:Label></td>
          </tr>
          <tr>
              <td style="width: 60px; height: 26px">
                      <asp:TextBox ID="txtSoTieuBan" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11" Width="58px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                     </td>
              <td style="width: 13px; height: 26px">
                      <asp:DropDownList ID="cboKetQua" runat="server" CssClass="ntp_combobox" TabIndex="12"
                          Width="64px" Visible="False">
                          <asp:ListItem Selected="True" Value="0">&#194;m</asp:ListItem>
                          <asp:ListItem Value="1">1AFB</asp:ListItem>
                          <asp:ListItem Value="2">2AFB</asp:ListItem>
                          <asp:ListItem Value="3">3AFB</asp:ListItem>
                          <asp:ListItem Value="4">4AFB</asp:ListItem>
                          <asp:ListItem Value="5">5AFB</asp:ListItem>
                          <asp:ListItem Value="6">6AFB</asp:ListItem>
                          <asp:ListItem Value="7">7AFB</asp:ListItem>
                          <asp:ListItem Value="8">8AFB</asp:ListItem>
                          <asp:ListItem Value="9">9AFB</asp:ListItem>
                          <asp:ListItem Value="10">1+</asp:ListItem>
                          <asp:ListItem Value="11">2+</asp:ListItem>
                          <asp:ListItem Value="12">3+</asp:ListItem>
                      </asp:DropDownList>
                      </td>
              <td style="width: 73px; height: 26px">
             <asp:DropDownList ID="cboKetQuaKDTinh1" runat="server" CssClass="ntp_combobox" TabIndex="12"
                          Width="64px">
                 <asp:ListItem Value="0">&#194;m</asp:ListItem>
                 <asp:ListItem Value="1">1AFB</asp:ListItem>
                 <asp:ListItem Value="2">2AFB</asp:ListItem>
                 <asp:ListItem Value="3">3AFB</asp:ListItem>
                 <asp:ListItem Value="4">4AFB</asp:ListItem>
                 <asp:ListItem Value="5">5AFB</asp:ListItem>
                 <asp:ListItem Value="6">6AFB</asp:ListItem>
                 <asp:ListItem Value="7">7AFB</asp:ListItem>
                 <asp:ListItem Value="8">8AFB</asp:ListItem>
                 <asp:ListItem Value="9">9AFB</asp:ListItem>
                 <asp:ListItem Value="10">1+</asp:ListItem>
                 <asp:ListItem Value="11">2+</asp:ListItem>
                 <asp:ListItem Value="12">3+</asp:ListItem>
                 <asp:ListItem Selected="True"></asp:ListItem>
             </asp:DropDownList>
                  </td>
              <td style="width: 76px; height: 26px">
                          <asp:DropDownList ID="cboKetQuaKDTinh2" runat="server" CssClass="ntp_combobox" TabIndex="12"
                          Width="64px" Visible="False">
                              <asp:ListItem Value="0">&#194;m</asp:ListItem>
                              <asp:ListItem Value="1">1AFB</asp:ListItem>
                              <asp:ListItem Value="2">2AFB</asp:ListItem>
                              <asp:ListItem Value="3">3AFB</asp:ListItem>
                              <asp:ListItem Value="4">4AFB</asp:ListItem>
                              <asp:ListItem Value="5">5AFB</asp:ListItem>
                              <asp:ListItem Value="6">6AFB</asp:ListItem>
                              <asp:ListItem Value="7">7AFB</asp:ListItem>
                              <asp:ListItem Value="8">8AFB</asp:ListItem>
                              <asp:ListItem Value="9">9AFB</asp:ListItem>
                              <asp:ListItem Value="10">1+</asp:ListItem>
                              <asp:ListItem Value="11">2+</asp:ListItem>
                              <asp:ListItem Value="12">3+</asp:ListItem>
                              <asp:ListItem Selected="True"></asp:ListItem>
                          </asp:DropDownList>
                  </td>
              <td style="width: 78px; height: 26px">
                  <asp:DropDownList ID="cboChatLuongBenhPham" runat="server" CssClass="ntp_combobox" TabIndex="13" Width="64px">
                      <asp:ListItem></asp:ListItem>
                     <asp:ListItem Value="1">Đạt</asp:ListItem>
                     <asp:ListItem Value="2">Kh&#244;ng đạt</asp:ListItem>
                 </asp:DropDownList>
                     </td>
              <td style="width: 78px; height: 26px">
                      <asp:DropDownList ID="cboTayMau" runat="server" CssClass="ntp_combobox" TabIndex="14" Width="64px">
                          <asp:ListItem Selected="True"></asp:ListItem>
                     <asp:ListItem Value="1">Đạt</asp:ListItem>
                     <asp:ListItem Value="2">Chưa đạt</asp:ListItem>
                     <asp:ListItem Value="3">Qu&#225;</asp:ListItem>
                 </asp:DropDownList>
                     </td>
              <td style="height: 26px">
                  <asp:DropDownList ID="cboDoSach" runat="server" CssClass="ntp_combobox" TabIndex="15" Width="64px">
                      <asp:ListItem></asp:ListItem>
             <asp:ListItem Value="1">Đạt</asp:ListItem>
             <asp:ListItem Value="2">Kh&#244;ng đạt</asp:ListItem>
         </asp:DropDownList>
             </td>
              <td style="width: 117px; height: 26px">
                  <asp:DropDownList ID="cboDoDay" runat="server" CssClass="ntp_combobox" TabIndex="16" Width="64px">
                      <asp:ListItem></asp:ListItem>
             <asp:ListItem Value="1">Đạt</asp:ListItem>
             <asp:ListItem Value="2">Mỏng</asp:ListItem>
             <asp:ListItem Value="3">D&#224;y</asp:ListItem>
         </asp:DropDownList>
             </td>
              <td style="height: 26px">
                  <asp:DropDownList ID="cboKichCo" runat="server" CssClass="ntp_combobox" TabIndex="17" Width="64px">
                      <asp:ListItem></asp:ListItem>
             <asp:ListItem Value="1">Đạt</asp:ListItem>
             <asp:ListItem Value="2">Nhỏ</asp:ListItem>
             <asp:ListItem Value="3">To</asp:ListItem>
         </asp:DropDownList>
             </td>
              <td style="height: 26px">
                  <asp:DropDownList ID="cboDoMin" runat="server" CssClass="ntp_combobox" TabIndex="18" Width="64px">
                      <asp:ListItem></asp:ListItem>
             <asp:ListItem Value="1">Đạt</asp:ListItem>
             <asp:ListItem Value="2">Kh&#244;ng đạt</asp:ListItem>
         </asp:DropDownList>
             </td>
              <td style="height: 26px; width: 79px;">
                     <asp:TextBox ID="txtGhiChu" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="19" Width="76px" BorderColor="White" BorderStyle="None"></asp:TextBox></td>
          </tr>
      </table>
      <table style="width: 788px" border="0">
          <tr>
              <td style="width: 59px; height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                     ControlToValidate="txtSoTieuBan" ErrorMessage="Không được trống" Width="66px"></asp:RequiredFieldValidator></td>
              <td style="width: 13px; height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="cboKetQua"
                          ErrorMessage="Không được trống" Width="72px"></asp:RequiredFieldValidator></td>
              <td style="width: 73px; height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server"
                 ControlToValidate="cboKetQuaKDTinh1" ErrorMessage="Không được trống" Width="66px"></asp:RequiredFieldValidator></td>
              <td style="width: 42px; height: 17px">
                  &nbsp;</td>
              <td style="width: 78px; height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="cboChatLuongBenhPham"
                          ErrorMessage="Không được trống" Width="51px"></asp:RequiredFieldValidator></td>
              <td style="width: 56px; height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="cboTayMau"
                          ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
              <td style="height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="cboDoSach"
                         ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
              <td style="width: 117px; height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="cboDoDay"
                           ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
              <td style="height: 17px">
                  &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="cboKichCo"
                          ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
              <td style="height: 17px">
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cboDoMin"
                 ErrorMessage="Không được trống"></asp:RequiredFieldValidator>&nbsp;</td>
              <td style="height: 17px; width: 79px;">
                 
             <asp:TextBox ID="txtId_PhieuLayMau_C" runat="server" CssClass="ntp_textbox" MaxLength="50"
                          TabIndex="11" Visible="False" Width="54px"></asp:TextBox>
                     <asp:TextBox ID="txtId_PhieuXetNghiemC" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11"
                         Visible="False" Width="54px"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 59px; height: 25px">
              </td>
              <td align="center" colspan="9" style="height: 25px">
     <asp:Button ID="cmdAdd1" runat="server" CssClass="ntp_button" TabIndex="20" Text="Ghi"
                        Width="81px" /><asp:Button id="CmdXoa" tabIndex=20 runat="server" Width="77px" Text="Xóa" CssClass="ntp_button"></asp:Button><asp:Button ID="CmdInPhieuPhanhoi" runat="server" CssClass="ntp_button" TabIndex="21" Text="In Phiếu phản hồi KQKĐ"
                        Width="168px" /><asp:Button ID="CmdInPLM" runat="server" CssClass="ntp_button" Height="25px" TabIndex="22"
                      Text="In Phiếu LM" Width="114px" /><asp:Button ID="CmdInKQKD" runat="server" CssClass="ntp_button" Height="25px" TabIndex="23"
                      Text="In KQKĐ" Width="114px" /><asp:Button
                                ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                                Text="Thoát" Width="85px" TabIndex="24" /></td>
              <td style="width: 79px; height: 25px">
              </td>
          </tr>
      </table>
      <asp:Literal ID="Literal1" runat="server"></asp:Literal>
 </asp:Panel>
