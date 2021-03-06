<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_CTCHONGLAO.EditNTP_BN_CTCHONGLAO" CodeFile="EditNTP_BN_CTCHONGLAO.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
 <table style="width: 74%">
              <tr>
                 <td style="width: 10%;">
                     <asp:Label ID="Label30" runat="server" CssClass="ntp_label" Text="Năm"></asp:Label></td>
                 <td style="width: 30%;">
                     <asp:TextBox ID="txtNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="1" Width="150px"></asp:TextBox><asp:RangeValidator ID="RangeValidator22" runat="server" ControlToValidate="txtNam"
                         ErrorMessage="Không đúng năm" MaximumValue="3000" MinimumValue="1900" Type="Integer"></asp:RangeValidator><asp:RequiredFieldValidator
                             ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNam" ErrorMessage="Không được trống"></asp:RequiredFieldValidator></td>
                 <td style="width: 10%;">
                     <asp:Label ID="Label36" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="84px"></asp:Label></td>
                  <td colspan="7" style="width: 390px">
                      <asp:DropDownList ID="cboDonVi" runat="server" CssClass="ntp_combobox" DataTextField="TEN_BENHVIEN"
                          DataValueField="ID_BENHVIEN" TabIndex="2" Width="240px">
                      </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                          ControlToValidate="cboDonVi" ErrorMessage="Không được trống"></asp:RequiredFieldValidator>&nbsp;</td>
                 
             </tr>
              <tr>
                 <td style="height: 26px; width: 7px;">
                     <asp:Label ID="Label37" runat="server" CssClass="ntp_label" Text="Ngày báo cáo" Width="107px"></asp:Label></td>
                 <td style="height: 26px; width: 71px;">
                     <asp:TextBox ID="txtNgayBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="3" Width="150px"></asp:TextBox><ajaxtoolkit:maskededitextender id="MaskedEditExtender1"
                        runat="server" autocomplete="true" culturename="vi-VN" mask="99/99/9999" masktype="Date"
                        promptcharacter="_" targetcontrolid="txtNgayBaoCao"> </ajaxtoolkit:maskededitextender><ajaxtoolkit:maskededitvalidator
                            id="MaskedEditValidator1" runat="server" controlextender="MaskedEditExtender1"
                            controltovalidate="txtNgayBaoCao" display="Dynamic" emptyvaluemessage="Bạn phải nhập ngày"
                            invalidvaluemessage="Định dạng ngày không đúng" isvalidempty="False" setfocusonerror="True"
                            tooltipmessage="Nhập ngày"></ajaxtoolkit:maskededitvalidator></td>
                 <td style="width: 13%; height: 26px;">
                     <asp:Label ID="Label38" runat="server" CssClass="ntp_label" Text="Người báo cáo" Width="105px"></asp:Label></td>
                  <td colspan="7" style="height: 26px; width: 390px;">
                      <asp:TextBox ID="txtNguoiBaoCao" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="4" Width="92%"></asp:TextBox><asp:RequiredFieldValidator
                          ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNguoiBaoCao" ErrorMessage="Không được trống"></asp:RequiredFieldValidator>
                     <asp:TextBox ID="txtId_CTChongLao" runat="server" CssClass="ntp_textbox" MaxLength="50"
                         TabIndex="111" Visible="False"></asp:TextBox></td>
                 
             </tr>     
              </table> &nbsp;   <asp:Panel ID="Panel2" runat="server" Height="50px"
    Width="676px"><asp:Button ID="Button1" runat="server" CssClass="ntp_button" TabIndex="5" Text="Phần 1+ Phần 2 + Phần 3"
                        Width="320px" />
    <asp:Button ID="Button2" runat="server" CssClass="ntp_button" TabIndex="32" Text="Phần 4"
                        Width="320px" /><br />
 <asp:Panel ID="pnlBaoCao1" runat ="server" Width="71%"  >

  <fieldset class="ntp_fieldset" style="width: 710px">
      <asp:Label ID="Label19" runat="server" CssClass="ntp_label" Text="Phần 1: Các cơ sở y tế tham gia hoạt động chống lao"
          Width="381px" Font-Bold="True" ForeColor="#C00000"></asp:Label><br />
      <br />
      <table style="width: 89%" border=1>
          <tr>
              <td rowspan="2" style="width: 116px" align="center">
                     <asp:Label ID="Label23" runat="server" CssClass="ntp_label" Text="Cơ sở y tế" Width="91px" Font-Bold="True"></asp:Label></td>
              <td rowspan="2" style="width: 66px">
                     <asp:Label ID="Label24" runat="server" CssClass="ntp_label" Text="Số CSYT trong Huyện" Width="80px" Font-Bold="True"></asp:Label></td>
              <td rowspan="2" style="width: 84px">
                     <asp:Label ID="Label32" runat="server" CssClass="ntp_label" Text="Số CSYT có triển khai công tác CL hiện có" Width="90px" Font-Bold="True"></asp:Label></td>
              <td align="center" colspan="4">
                  <asp:Label ID="Label15" runat="server" CssClass="ntp_label" Text="Cơ sở y tế có phòng xét nghiệm"
                      Width="280px" Font-Bold="True"></asp:Label></td>
              <td align="center" colspan="2">
                  <asp:Label ID="Label16" runat="server" CssClass="ntp_label" Text="Cơ sở y tế có dịch vụ HIV"
                      Width="131px" Font-Bold="True"></asp:Label></td>
          </tr>
          <tr>
              <td style="width: 72px">
                     <asp:Label ID="Label25" runat="server" CssClass="ntp_label" Text="Số điểm kính thực tế" Width="72px"></asp:Label></td>
              <td style="width: 74px">
                     <asp:Label ID="Label26" runat="server" CssClass="ntp_label" Text="Số điểm kính được kiểm định" Width="72px"></asp:Label></td>
              <td style="width: 88px">
                     <asp:Label ID="Label33" runat="server" CssClass="ntp_label" Text="Số CS có XN nuôi cấy" Width="67px"></asp:Label></td>
              <td style="width: 86px">
                      <asp:Label ID="Label39" runat="server" CssClass="ntp_label" Text="Số CS có XN kháng sinh đồ"
                          Width="69px"></asp:Label></td>
              <td style="width: 89px">
                     <asp:Label ID="Label31" runat="server" CssClass="ntp_label" Text="Số CS có TV và XNHIV" Width="70px"></asp:Label></td>
              <td style="width: 71px">
                     <asp:Label ID="Label27" runat="server" CssClass="ntp_label" Text="Số CS có cung cấp ART"
                         Width="72px"></asp:Label></td>
          </tr>
          <tr>
              <td style="width: 116px">
                  <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Cơ sở y tế công"
                      Width="103px"></asp:Label>
                  <asp:TextBox ID="txtId_CoSoYTe" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="115" Width="70px" Visible="False"></asp:TextBox></td>
              <td style="width: 66px">
                      <asp:TextBox ID="txtSoCSYTHuyen" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="6" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                      <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="txtSoCSYTHuyen"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 84px">
                      <asp:TextBox ID="txtCSYTCoChongLao" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="7" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                     <asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="txtCSYTCoChongLao"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 72px">
                     <asp:TextBox ID="txtSoDiemKinh" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="8" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                     <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtSoDiemKinh"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 74px">
                      <asp:TextBox ID="txtSoDiemKinhKiemDinh" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="9" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                      <asp:RangeValidator ID="RangeValidator9" runat="server" ControlToValidate="txtSoDiemKinhKiemDinh"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 88px">
                      <asp:TextBox ID="txtSoCSCoXNNuoiCay" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="10" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator12" runat="server" ControlToValidate="txtSoCSCoXNNuoiCay"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 86px">
                      <asp:TextBox ID="txtSoCSCoXnKhangSinh" runat="server" CssClass="ntp_textbox" MaxLength="50"
                          TabIndex="11" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtSoCSCoXnKhangSinh"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                     <asp:TextBox ID="txtSoCSCoHIV" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="12" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="txtSoCSCoHIV"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 71px">
                     <asp:TextBox ID="txtSoCSART" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="13" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtSoCSART"
                           ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
          </tr>
          <tr>
              <td style="width: 116px">
                  <asp:Label ID="Label18" runat="server" CssClass="ntp_label" Text="Cơ sở tư nhân"
                      Width="97px"></asp:Label>
                  <asp:TextBox ID="txtId_CoSoYTe1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="116" Width="70px" Visible="False"></asp:TextBox></td>
              <td style="width: 66px">
                  <asp:TextBox ID="txtSoCSYTHuyen1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="14" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator15" runat="server" ControlToValidate="txtSoCSYTHuyen1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 84px">
                  <asp:TextBox ID="txtCSYTCoChongLao1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="15" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator16" runat="server" ControlToValidate="txtCSYTCoChongLao1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 72px">
                  <asp:TextBox ID="txtSoDiemKinh1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="16" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator17" runat="server" ControlToValidate="txtSoDiemKinh1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 74px">
                  <asp:TextBox ID="txtSoDiemKinhKiemDinh1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="17" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator18" runat="server" ControlToValidate="txtSoDiemKinhKiemDinh1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 88px">
                  <asp:TextBox ID="txtSoCSCoXNNuoiCay1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="18" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator19" runat="server" ControlToValidate="txtSoCSCoXNNuoiCay1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 86px">
                  <asp:TextBox ID="txtSoCSCoXnKhangSinh1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="19" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator20" runat="server" ControlToValidate="txtSoCSCoXnKhangSinh1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 89px">
                  <asp:TextBox ID="txtSoCSCoHIV1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="20" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator21" runat="server" ControlToValidate="txtSoCSCoHIV1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
              <td style="width: 71px">
                  <asp:TextBox ID="txtSoCSART1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                      TabIndex="21" Width="70px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                  <asp:RangeValidator ID="RangeValidator23" runat="server" ControlToValidate="txtSoCSART1"
                      ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
          </tr>
      </table>
      <br />
      <table style="width: 698px" border =0>
          <tr>
              <td rowspan="1" style="width: 401px">
                  <asp:Label ID="Label20" runat="server" CssClass="ntp_label" Text="Phần 2: Phân bố các đơn vị chăm sóc y tế tham gia công tác chống lao"
                      Width="456px" Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
              <td style="width: 1127px">
              </td>
              <td rowspan="1" style="width: 295px">
                  <asp:Label ID="Label21" runat="server" CssClass="ntp_label" Text="Phần 3.  Đóng góp của cộng đồng trong công tác chống lao"
                      Width="291px" Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
          </tr>
          <tr>
              <td rowspan="4" style="width: 401px">
                  <table style="width: 468px" border =1>
                      <tr>
                          <td style="width: 91px">
                          </td>
                          <td align="center" colspan="2">
                              <asp:Label ID="Label13" runat="server" CssClass="ntp_label" Text="Số bệnh nhân lao phổi AFB(+) phát hiện trong năm"
                                  Width="148px" Font-Bold="True"></asp:Label></td>
                          <td align="center" style="width: 390px">
                              <asp:Label ID="Label14" runat="server" CssClass="ntp_label" Text="Số BN lao phổi AFB(+) được đăng ký điều trị trong năm"
                                  Width="116px" Font-Bold="True"></asp:Label></td>
                      </tr>
                      <tr>
                          <td style="width: 91px">
                              <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tổng số" Width="111px" Font-Bold="True" ForeColor="Blue"></asp:Label></td>
                          <td colspan="2" align="center">
             <asp:TextBox ID="TxtSoBNPhathien" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="21" Width="90px" BorderColor="White" BorderStyle="None" Font-Bold="True" ForeColor="Blue"></asp:TextBox>
                              <asp:RangeValidator ID="RangeValidator29" runat="server" ControlToValidate="TxtSoBNPhathien"
                                  ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                          <td style="width: 390px" align="center">
             <asp:TextBox ID="TxtSoBNDieutri" runat="server" CssClass="ntp_textbox" MaxLength="50"
                 TabIndex="22" Width="78px" BorderColor="White" BorderStyle="None" Font-Bold="True" ForeColor="Blue"></asp:TextBox>
                              <asp:RangeValidator ID="RangeValidator30" runat="server" ControlToValidate="TxtSoBNDieutri"
                                  ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                      </tr>
                      <tr>
                          <td style="width: 91px">
                              <asp:Label ID="Label8" runat="server" CssClass="ntp_label" Text="Loại hình y tế"
                                  Width="96px" Font-Bold="True"></asp:Label></td>
                          <td align="center" style="width: 157px">
                              <asp:Label ID="Label4" runat="server" CssClass="ntp_label" Text="Cơ sở chuyển"></asp:Label></td>
                          <td align="center" style="width: 61px">
                              <asp:Label ID="Label5" runat="server" CssClass="ntp_label" Text="Cơ sở chẩn đoán"
                                  Width="104px"></asp:Label></td>
                          <td align="center" style="width: 390px">
                              <asp:Label ID="Label6" runat="server" CssClass="ntp_label" Text="Cơ sở điều trị"
                                  Width="84px"></asp:Label></td>
                      </tr>
                      <tr>
                          <td style="width: 91px">
                              <asp:Label ID="Label9" runat="server" CssClass="ntp_label" Text="Tự đến" Width="93px"></asp:Label>
                              <asp:TextBox ID="txtId_DonVi" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="121" Width="70px" Visible="False"></asp:TextBox></td>
                          <td style="width: 157px">
                    <asp:TextBox ID="txtCSChuyen" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="23" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator71" runat="server" ControlToValidate="txtCSChuyen"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                          <td style="width: 61px">
                    </td>
                          <td style="width: 390px">
                    </td>
                      </tr>
                      <tr>
                          <td style="width: 91px">
                              <asp:Label ID="Label10" runat="server" CssClass="ntp_label" Text="Y tế công" Width="91px"></asp:Label>
                              <asp:TextBox ID="txtId_DonVi1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="122" Width="70px" Visible="False"></asp:TextBox></td>
                          <td style="width: 157px">
                              <asp:TextBox ID="txtCSChuyen1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="24" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                              <asp:RangeValidator ID="RangeValidator24" runat="server" ControlToValidate="txtCSChuyen1"
                                  ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                          <td style="width: 61px">
                              <asp:TextBox ID="txtCSChanDoan1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="25" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                              <asp:RangeValidator ID="RangeValidator101" runat="server" ControlToValidate="txtCSChanDoan1"
                                  ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                          <td style="width: 390px">
                    <asp:TextBox ID="txtCSDieuTri1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                        TabIndex="26" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator131" runat="server" ControlToValidate="txtCSDieuTri1"
                        ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="59px"></asp:RangeValidator></td>
                      </tr>
                      <tr>
                          <td style="width: 91px">
                              <asp:Label ID="Label12" runat="server" CssClass="ntp_label" Text="Y tế tư nhân" Width="88px"></asp:Label>
                              <asp:TextBox ID="txtId_DonVi2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="123" Width="70px" Visible="False"></asp:TextBox></td>
                          <td style="width: 157px">
                              <asp:TextBox ID="txtCSChuyen2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="27" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                              <asp:RangeValidator ID="RangeValidator25" runat="server" ControlToValidate="txtCSChuyen2"
                                  ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                          <td style="width: 61px">
                              <asp:TextBox ID="txtCSChanDoan2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="28" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                              <asp:RangeValidator ID="RangeValidator26" runat="server" ControlToValidate="txtCSChanDoan2"
                                  ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                          <td style="width: 390px">
                              <asp:TextBox ID="txtCSDieuTri2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                                  TabIndex="29" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                              <asp:RangeValidator ID="RangeValidator27" runat="server" ControlToValidate="txtCSDieuTri2"
                                  ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="53px"></asp:RangeValidator></td>
                      </tr>
                  </table>
              </td>
              <td style="width: 1127px">
              </td>
              <td rowspan="4" style="width: 295px">
                  <table style="width: 294px" border =1>
                      <tr>
                          <td colspan="1" rowspan="2" style="width: 140px; height: 108px" align="center">
                              <asp:Label ID="Label22" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số bệnh nhân AFB(+) do cộng đồng chuyển và tự đến"
                                  Width="119px"></asp:Label></td>
                          <td colspan="3" rowspan="2" style="width: 155px; height: 108px" align="center">
                              <asp:Label ID="Label28" runat="server" CssClass="ntp_label" Font-Bold="True" Text="Số bệnh nhân AFB(+) được cộng đồng hỗ trợ điều trị"
                                  Width="124px"></asp:Label></td>
                      </tr>
                      <tr>
                      </tr>
                      <tr>
                          <td colspan="1" rowspan="1" style="width: 140px; height: 68px" align="center">
                              &nbsp;<asp:TextBox ID="txtAFBChuyenDen" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="30" Width="110px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator28" runat="server" ControlToValidate="txtAFBChuyenDen"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
                          <td colspan="3" rowspan="1" style="width: 155px; height: 68px" align="center">
                     <asp:TextBox ID="txtAFBDieuTri" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="31" Width="110px" BorderColor="White" BorderStyle="None"></asp:TextBox><br />
                              <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAFBDieuTri"
                           ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer" Width="34px"></asp:RangeValidator></td>
                      </tr>
                      
                      <tr>
                      </tr>
                      <tr>
                      </tr>
                      <tr>
                      </tr>
                      <tr>
                      </tr>
                  </table>
              </td>
          </tr>
          <tr>
              <td style="width: 1127px">
              </td>
          </tr>
          <tr>
              <td style="width: 1127px">
                  <asp:TextBox ID="TextBox1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="117"
                      Width="21px" Visible="False"></asp:TextBox></td>
          </tr>
          <tr>
              <td style="width: 1127px; height: 52px">
              </td>
          </tr>
      </table>
</fieldset> &nbsp;&nbsp;
 </asp:Panel>
&nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Panel ID="PanelPhan4" runat="server" Height="50px"
    Width="772px">
     <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="#C00000"
         Text="Phần 4: Tình hình nhân lực và đào tạo" Width="381px"></asp:Label><br />
    <table style="width: 772px" border="1">
        <tr>
            <td style="width: 354px">
                    <asp:Label ID="Label11" runat="server" CssClass="ntp_label" Text="Phân loại cán bộ tham gia CTCL" Width="311px" ForeColor="Blue"></asp:Label></td>
            <td style="width: 143px">
                <asp:Label ID="Label411" runat="server" CssClass="ntp_label" Text="Nhân lực hiện có" ForeColor="Blue"></asp:Label></td>
            <td style="width: 145px">
                    <asp:Label ID="Label51" runat="server" CssClass="ntp_label" Text="Số nhân lực được đào tạo CTCL trong năm" Width="135px" ForeColor="Blue"></asp:Label></td>
            <td style="width: 146px">
                    <asp:Label ID="Label61" runat="server" CssClass="ntp_label" Text="Tổng số nhân lực đã được đào tạo CTCL"
                        Width="130px" ForeColor="Blue"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label46" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="Black"
                    Text="A. Các cơ sở y tế trong huyện" Width="260px"></asp:Label>
                &nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label55" runat="server" CssClass="ntp_label" Text="Trên đại học" Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc17" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="128" Visible="False" Width="42px"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo17" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="33" Width="80px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator78" runat="server" ControlToValidate="txtNhanLucHienCo17"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam17" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="33" Width="80px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator79" runat="server" ControlToValidate="txtNhanLucDTTrongNam17"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT17" runat="server" BorderColor="White" BorderStyle="None"
                    CssClass="ntp_textbox" MaxLength="50" TabIndex="33" Width="80px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator80" runat="server" ControlToValidate="txtNhanLucDaDT17"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Bác sỹ" Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="128" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                     <asp:TextBox ID="txtNhanLucHienCo" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="33" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="txtNhanLucHienCo"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                      <asp:TextBox ID="txtNhanLucDTTrongNam" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="34" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox><asp:RangeValidator ID="RangeValidator10" runat="server" ControlToValidate="txtNhanLucDTTrongNam"
                          ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                      <asp:TextBox ID="txtNhanLucDaDT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="35" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator13" runat="server" ControlToValidate="txtNhanLucDaDT"
                         ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label7" runat="server" CssClass="ntp_label" Text="Y sỹ" Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="129" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="36"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtNhanLucHienCo1"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="37"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator31" runat="server" ControlToValidate="txtNhanLucDTTrongNam1"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT1" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="38"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator33" runat="server" ControlToValidate="txtNhanLucDaDT1"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label29" runat="server" CssClass="ntp_label" Text="Y tá / nữ hộ sinh"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="130" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="39"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator14" runat="server" ControlToValidate="txtNhanLucHienCo2"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="40"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator32" runat="server" ControlToValidate="txtNhanLucDTTrongNam2"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT2" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="41"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator34" runat="server" ControlToValidate="txtNhanLucDaDT2"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label34" runat="server" CssClass="ntp_label" Text="Xét nghiệm viên"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc3" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="131" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo3" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="42"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator35" runat="server" ControlToValidate="txtNhanLucHienCo3"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam3" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="43"
                    Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator36" runat="server" ControlToValidate="txtNhanLucDTTrongNam3"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT3" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="44" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator37" runat="server" ControlToValidate="txtNhanLucDaDT3"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label35" runat="server" CssClass="ntp_label" Text="Dược sĩ" Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="132" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="45" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator38" runat="server" ControlToValidate="txtNhanLucHienCo4"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="46" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator39" runat="server" ControlToValidate="txtNhanLucDTTrongNam4"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT4" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="47" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator40" runat="server" ControlToValidate="txtNhanLucDaDT4"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label40" runat="server" CssClass="ntp_label" Text="Dược trung" Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="133" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="48" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator41" runat="server" ControlToValidate="txtNhanLucHienCo5"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="49" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator42" runat="server" ControlToValidate="txtNhanLucDTTrongNam5"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT5" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="50" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator43" runat="server" ControlToValidate="txtNhanLucDaDT5"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label41" runat="server" CssClass="ntp_label" Text="Dược tá" Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="134" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="51" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator44" runat="server" ControlToValidate="txtNhanLucHienCo6"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="52" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator45" runat="server" ControlToValidate="txtNhanLucDTTrongNam6"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT6" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="53" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator46" runat="server" ControlToValidate="txtNhanLucDaDT6"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px; height: 28px;">
                <asp:Label ID="Label42" runat="server" CssClass="ntp_label" Text="Tư vấn viên" Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="135" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px; height: 28px;">
                <asp:TextBox ID="txtNhanLucHienCo7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="54" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator47" runat="server" ControlToValidate="txtNhanLucHienCo7"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px; height: 28px;">
                <asp:TextBox ID="txtNhanLucDTTrongNam7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="55" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator48" runat="server" ControlToValidate="txtNhanLucDTTrongNam7"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px; height: 28px;">
                <asp:TextBox ID="txtNhanLucDaDT7" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="56" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator49" runat="server" ControlToValidate="txtNhanLucDaDT7"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label43" runat="server" CssClass="ntp_label" Text="Cán bộ phụ trách lao/HIV"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="136" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="57" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator50" runat="server" ControlToValidate="txtNhanLucHienCo8"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="58" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator51" runat="server" ControlToValidate="txtNhanLucDTTrongNam8"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT8" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="59" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator52" runat="server" ControlToValidate="txtNhanLucDaDT8"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px;" rowspan="2">
                <asp:Label ID="Label44" runat="server" CssClass="ntp_label" Text="Khác (ghi rõ)" Width="84px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="137" Width="42px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TxtGhichu1" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="59" Width="306px"></asp:TextBox>
            </td>
            <td style="width: 143px; height: 21px">
                <asp:TextBox ID="txtNhanLucHienCo9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="60" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator53" runat="server" ControlToValidate="txtNhanLucHienCo9"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px; height: 21px">
                <asp:TextBox ID="txtNhanLucDTTrongNam9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="61" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator54" runat="server" ControlToValidate="txtNhanLucDTTrongNam9"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="height: 21px; width: 146px;">
                <asp:TextBox ID="txtNhanLucDaDT9" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="62" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator55" runat="server" ControlToValidate="txtNhanLucDaDT9"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 143px; height: 19px">
            </td>
            <td style="width: 145px; height: 19px">
            </td>
            <td style="width: 146px; height: 19px">
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label45" runat="server" CssClass="ntp_label" Font-Bold="True" ForeColor="Black"
                    Text="B. Cán bộ chống lao tuyến huyện" Width="260px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label47" runat="server" CssClass="ntp_label" Text="Cán bộ chống lao ( chuyên trách)"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc10" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="138" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo10" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="63" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator56" runat="server" ControlToValidate="txtNhanLucHienCo10"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam10" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="64" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator57" runat="server" ControlToValidate="txtNhanLucDTTrongNam10"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT10" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="65" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator58" runat="server" ControlToValidate="txtNhanLucDaDT10"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px; height: 21px">
                <asp:Label ID="Label48" runat="server" CssClass="ntp_label" Text="Cán bộ chống lao (kiêm nhiệm)"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc11" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="139" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px; height: 21px">
                <asp:TextBox ID="txtNhanLucHienCo11" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="66" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator59" runat="server" ControlToValidate="txtNhanLucHienCo11"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px; height: 21px">
                <asp:TextBox ID="txtNhanLucDTTrongNam11" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="67" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator60" runat="server" ControlToValidate="txtNhanLucDTTrongNam11"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="height: 21px; width: 146px;">
                <asp:TextBox ID="txtNhanLucDaDT11" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="68" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator61" runat="server" ControlToValidate="txtNhanLucDaDT11"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label49" runat="server" CssClass="ntp_label" Text="Kỹ thuật viên xét nghiệm chuyên trách"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc12" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="140" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo12" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="69" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator62" runat="server" ControlToValidate="txtNhanLucHienCo12"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam12" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="70" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator63" runat="server" ControlToValidate="txtNhanLucDTTrongNam12"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT12" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="71" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator64" runat="server" ControlToValidate="txtNhanLucDaDT12"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label50" runat="server" CssClass="ntp_label" Text="Kỹ thuật viện xét nghiệm kiêm nhiệm"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc13" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="141" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo13" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="72" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator65" runat="server" ControlToValidate="txtNhanLucHienCo13"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam13" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="73" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator66" runat="server" ControlToValidate="txtNhanLucDTTrongNam13"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT13" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="74" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator67" runat="server" ControlToValidate="txtNhanLucDaDT13"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label52" runat="server" CssClass="ntp_label" Text="Cán bộ giám sát - thống kê báo cáo"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc14" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="142" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo14" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="75" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator68" runat="server" ControlToValidate="txtNhanLucHienCo14"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam14" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="76" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator69" runat="server" ControlToValidate="txtNhanLucDTTrongNam14"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT14" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="77" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator70" runat="server" ControlToValidate="txtNhanLucDaDT14"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px">
                <asp:Label ID="Label53" runat="server" CssClass="ntp_label" Text="Cán bộ quản lý dược (kiêm nhiệm)"
                    Width="260px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc15" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="143" Width="42px" Visible="False"></asp:TextBox></td>
            <td style="width: 143px">
                <asp:TextBox ID="txtNhanLucHienCo15" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="78" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator72" runat="server" ControlToValidate="txtNhanLucHienCo15"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px">
                <asp:TextBox ID="txtNhanLucDTTrongNam15" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="79" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator73" runat="server" ControlToValidate="txtNhanLucDTTrongNam15"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px">
                <asp:TextBox ID="txtNhanLucDaDT15" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="80" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator74" runat="server" ControlToValidate="txtNhanLucDaDT15"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 354px;" rowspan="2">
                <asp:Label ID="Label54" runat="server" CssClass="ntp_label" Text="Khác (cụ thể)" Width="92px"></asp:Label>
                <asp:TextBox ID="txtId_NhanLuc16" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="144" Width="42px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TxtGhichu2" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="80" Width="306px"></asp:TextBox>
            </td>
            <td style="width: 143px; height: 26px;">
                <asp:TextBox ID="txtNhanLucHienCo16" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="81" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator75" runat="server" ControlToValidate="txtNhanLucHienCo16"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 145px; height: 26px;">
                <asp:TextBox ID="txtNhanLucDTTrongNam16" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="82" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator76" runat="server" ControlToValidate="txtNhanLucDTTrongNam16"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
            <td style="width: 146px; height: 26px">
                <asp:TextBox ID="txtNhanLucDaDT16" runat="server" CssClass="ntp_textbox" MaxLength="50"
                    TabIndex="83" Width="80px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator77" runat="server" ControlToValidate="txtNhanLucDaDT16"
                    ErrorMessage="Là số" MaximumValue="9999" MinimumValue="0" Type="Integer"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 143px; height: 26px">
            </td>
            <td style="width: 145px; height: 26px">
            </td>
            <td style="width: 146px; height: 26px">
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" TabIndex="84" Text="Ghi"
                        Width="100px" /><asp:Button ID="cmdCreateNew" runat="server" CausesValidation="False"
                            CssClass="ntp_button" TabIndex="85" Text="Tạo mới" Width="100px" /><asp:Button
                                ID="cmdCancel" runat="server" CausesValidation="False" CssClass="ntp_button"
                                Text="Thoát" Width="100px" TabIndex="86" /></asp:Panel>
<br />