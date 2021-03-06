'
' DotNetNuke® - http://www.dotnetnuke.com
' Copyright (c) 2002-2006
' by Perpetual Motion Interactive Systems Inc. ( http://www.perpetualmotion.ca )
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'

Imports DotNetNuke
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Reflection
Imports NTP_Common.mdlGlobal

Namespace YourCompany.Modules.NTP_BN_DIEUTRI

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_DIEUTRI
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"



#End Region

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
              
                If Not IsPostBack Then
                    TxtChon.Text = ""
                    CmdXetnghiem.BackColor = Color.WhiteSmoke()
                    CmdHIV.BackColor = Color.WhiteSmoke()
                    CmdDieutri.BackColor = Color.WhiteSmoke
                    CmdKetquaDT.BackColor = Color.WhiteSmoke
                    CmdDieutri.Font.Underline = True
                    PanelDieutri.Visible = True
                    PanelXetnghiem.Visible = False
                    PanelHIV.Visible = False
                    PanelKetquaDT.Visible = False
                    TxtChandoanLNP.Visible = False
                    PanelPC.Visible = False
                    ' SetValue(Me.txtNgayBDDT, Now, enuDATA_TYPE.DATE_TYPE)
                    SetValue(Me.txtNgayVaoVien, Now, enuDATA_TYPE.DATE_TYPE)
                    '' BindComboTinh()
                    ' BindComboHuyen(Me.CurrentUserStock.ID_MATINH)
                    BindComboPhanLoaiBenh()
                    BindComboPhacDo()
                    BindComboPhacdoTD()
                    BindComboPhanLoaiBenhNhan()
                    BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    BindComboDVTiepnhan()
                    cboDonVi.SelectedValue = Me.CurrentUserStock.ID_BENHVIEN
                    If Request.QueryString("ChonTab") = 1 Then ' update BN chuyen
                        If Not Request.QueryString("id") Is Nothing Then
                            Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                            Dim infBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
                            TxtID_chuyenden.Text = Request.QueryString("id")
                            '   infPhieuChuyen = objPhieuChuyen.GetBenhNhan(txtMaPhieuChuyen.Text)
                            Me.txtMaBenhNhan.Text = Request.QueryString("MaBN")
                            infBenhNhan = objBenhNhan.Get(txtMaBenhNhan.Text)
                            LoadBenhNhan(infBenhNhan)
                            TxtID_DieutriBNC.Text = Request.QueryString("idDieuTri")
                            LoadThongtinDT(TxtID_DieutriBNC.Text)
                        End If
                    Else
                        If Not Request.QueryString("idBenhNhan") Is Nothing Then
                            'Load thông tin bệnh nhân
                            Dim objBenhNhanh As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                            Dim infBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
                            infBenhNhan = objBenhNhanh.Get(Request.QueryString("idBenhNhan"))
                            ' txtSoDKDT.Text = Request.QueryString("SoDangky")
'response.write ("SoDK" & Request.QueryString("SoDangky"))
                            If infBenhNhan Is Nothing Then
                            Else
                                LoadBenhNhan(infBenhNhan)
                            End If
                            If Not Request.QueryString("idDieuTri") Is Nothing Then
                                LoadThongtinDT(Request.QueryString("idDieuTri"))
                            Else
                                Dim ObjXNTB As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
                                Dim InfXNTB As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
                                InfXNTB = ObjXNTB.NTP_BN_XETNGHIEMBNTHATBAI(txtMaBenhNhan.Text)
                                If Not InfXNTB Is Nothing Then
                                    SetValue(Me.TxtNgayXN0, InfXNTB.NgayXN, enuDATA_TYPE.DATE_TYPE)
                                    TxtSoXN0.Text = InfXNTB.SoXN
                                    cboKetQua0.SelectedValue = InfXNTB.KetquaXN
                                End If
                                Me.TxtTiepnhanBN.Text = 0
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally

            End Try
        End Sub

        Protected Sub LoadBenhNhan(ByVal infBenhNhan As NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo)
            Try
                Me.txtDiaChi.Text = infBenhNhan.Diachi
                Me.txtTenBN.Text = infBenhNhan.HoTen
                Me.txtMaBenhNhan.Text = infBenhNhan.ID_Benhnhan
                Me.TxtMaBNQL.Text = infBenhNhan.MaBNQL
                ' BindComboTinh()
                'Me.cboTinh.SelectedValue = infBenhNhan.MA_TINH
                ' BindComboHuyen(Me.cboTinh.SelectedValue)
                'Me.cboHuyen.SelectedValue = infBenhNhan.MA_HUYEN
                Me.txtSoCMT.Text = infBenhNhan.SoCMND
                Me.txtDienThoai.Text = infBenhNhan.Sodienthoai
                Me.txtMaBenhNhan.Text = infBenhNhan.ID_Benhnhan
                Me.txtTuoi.Text = infBenhNhan.Tuoi
                Me.txtSoDKDT.Text = IIf(txtSoDKDT.Text = "", infBenhNhan.SoDKDT, txtSoDKDT.Text)
                If infBenhNhan.Gioitinh = False Then
                    Me.optlistGioiTinh.SelectedValue = 0
                Else
                    Me.optlistGioiTinh.SelectedValue = 1
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub

        Private Sub LoadThongtinDT(ByVal ID_Dieutri As Integer)
            Dim ObjDT As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIController
            Dim InfDT As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIInfo
            Try
                InfDT = ObjDT.Get(ID_Dieutri)
                txtMaPhieuDieuTri.Text = ID_Dieutri
                txtMaPhieuChuyen.Text = InfDT.ID_PhieuChuyen
                TxtTiepnhanBN.Text = InfDT.Tiepnhan
                txtTuoi.Text = InfDT.Tuoi
                If Request.QueryString("ChonTab") = 1 Then ' Tiep nhan BN chuyen den
                    CboNoiChuyenden.SelectedValue = 2
                    txtMaPhieuDieuTri.Text = ""
                    cboDonVi.SelectedValue = InfDT.DVTIEPNHAN
                    cboPhanLoaiBenhNhan.SelectedValue = 5
                    cboPhanLoaiBenhNhan.Enabled = False
                    cboPhanLoaiBenh.Enabled = False
		    SetValue(Me.txtNgayBDDT, InfDT.NgayDT, enuDATA_TYPE.DATE_TYPE)
  		    txtngayBDDT.Enabled=false
		    Label148.text="Ngày tiếp nhận"
                Else
                    CboNoiChuyenden.SelectedValue = InfDT.ID_PHANLOAIYTE
                    If Val(CboNoiChuyenden.SelectedValue) = 4 Then
                        TxtNoidenKhac.Visible = True
                    Else
                        TxtNoidenKhac.Visible = False
                    End If
                    cboDonVi.SelectedValue = InfDT.DVDieutri
                    cboPhanLoaiBenhNhan.SelectedValue = InfDT.ID_PhanLoaiBN
                    TxtNoidenKhac.Text = InfDT.DVGioiThieu
                    SetValue(Me.txtNgayVaoVien, InfDT.NgayVV, enuDATA_TYPE.DATE_TYPE)
	            SetValue(Me.txtNgayBDDT, InfDT.NgayDT, enuDATA_TYPE.DATE_TYPE)
                    txtSoDKDT.Text = InfDT.SoDKDT
                    txtNguoiGiamSat.Text = InfDT.GiamSatDT
                End If
                cboPhanLoaiBenh.SelectedValue = InfDT.ID_PhanLoaiBenh
                If InfDT.ID_PhanLoaiBenh = 4 Then 
                    TxtChandoanLNP.Visible = True
                    TxtChandoanLNP.Text = InfDT.Chandoan
                End If

                txtPhacDoKhac.Text = InfDT.PhacdoKhac
                If InfDT.ID_PhacdoDT < 1 Then
                    cboPhacDoDT.SelectedValue = ""
                    txtPhacDoKhac.Visible = True
                Else
                    cboPhacDoDT.SelectedValue = InfDT.ID_PhacdoDT
                    txtPhacDoKhac.Visible = False
                End If
                TxtPhacdoTDKhac.Text = InfDT.PhacdoTDKhac
                If InfDT.ID_PhacdoTD < 1 Then
                    CboPhacdoTD.SelectedValue = ""
                    TxtPhacdoTDKhac.Visible = True
                Else
                    CboPhacdoTD.SelectedValue = InfDT.ID_PhacdoTD
                    TxtPhacdoTDKhac.Visible = False
                End If

                If InfDT.Tuoi <> 0 Then
                    Me.txtTuoi.Text = InfDT.Tuoi
                End If
                If InfDT.MaBNQL <> "" Then
                    TxtMaBNQL.Text = InfDT.MaBNQL
                End If
                SetValue(Me.txtNgayXQuangPhoi, InfDT.NgayChupXQ, enuDATA_TYPE.DATE_TYPE)
                cboKetQuaXQuang.SelectedValue = InfDT.KetquaXQ
                ' cboDonVi.SelectedValue = InfDT.DVDieutri
                OptART.SelectedValue = InfDT.ART
                OptCPT.SelectedValue = InfDT.CPT
                txtCD4.Text = InfDT.LymPho
                cboHIVQuy.SelectedValue = InfDT.XNHIV1
                CboHIVLao.SelectedValue = InfDT.XNHIV2
                LoadTTXetnghiem(ID_Dieutri)
                '-- ket qua DT
                If Request.QueryString("ChonTab") = 0 Then ' Dang ky BN moi
                    SetValue(TxtNgayRV, InfDT.NgayRV, enuDATA_TYPE.DATE_TYPE)
                    CboKetquaDT.SelectedValue = InfDT.ID_KetquaDT
                    TxtGhichu.Text = InfDT.Ghichu
                    If CboKetquaDT.SelectedValue = 6 Then

                        PanelPC.Visible = True
                        LoadTTPhieuchuyen(ID_Dieutri)
                        TxtKQTiepnhan.Text = InfDT.TN_KetQuaDT
                    End If
                End If

                If (Me.CurrentUserStock.ID_BENHVIEN = InfDT.DVDieutri And InfDT.Tiepnhan = 0) Or CboKetquaDT.SelectedValue = 0 Then
                    cmdAdd.Enabled = True
                    PanelXetnghiem.Enabled = True

                    PanelKetquaDT.Enabled = True
                    PanelDieutri.Enabled = True
                Else
                    ' If CboKetquaDT.SelectedValue > 0 Or Me.CurrentUserStock.ID_BENHVIEN <> InfDT.DVDieutri Then
                    PanelXetnghiem.Enabled = False

                    PanelKetquaDT.Enabled = False
                    PanelDieutri.Enabled = False
                    'cmdAdd.Enabled = False
                End If

                ObjDT = Nothing
                InfDT = Nothing
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally

            End Try
        End Sub
        Private Sub LoadTTPhieuchuyen(ByVal ID_DIEUTRI As Integer)
            Dim obj As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Dim infPC As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENInfo
            Try
                infPC = obj.GetNTP_BN_PHIEUCHUYENByID_Dieutri(ID_DIEUTRI)
                If Not infPC Is Nothing Then
                    SetValue(Me.TxtNgaychuyen, infPC.NgayChuyen, enuDATA_TYPE.DATE_TYPE)
                    Me.optlistLoaiYTe.SelectedValue = infPC.PhanLoai
                    cboTinh.Visible = False
                    Me.cboDVTiepnhan.SelectedValue = infPC.DVTiepnhan
                    Me.CurrentUserStock.ID_BENHVIEN = infPC.DVChuyen
                    Me.TxtLydo.Text = infPC.Lydo
                    Me.TxtTinhtrangBN.Text = infPC.TinhTrangBN
                    infPC.Tiepnhan = infPC.Tiepnhan()
                    If infPC.Tiepnhan = 1 Then

                    End If
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally

            End Try
        End Sub
        Private Sub LoadTTXetnghiem(ByVal ID_Dieutri As Integer)
            Dim ObjXN As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim InfXN As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
            Dim ObjXN2 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim InfXN2 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
            Dim ObjXN5 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim InfXN5 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
            Dim ObjXN7 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim InfXN7 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo

            InfXN = ObjXN.GetNTP_BN_XETNGHIEM_GDByThoigianDT(ID_Dieutri, 0)
            If Not InfXN Is Nothing Then
                SetValue(Me.TxtNgayXN0, InfXN.NgayXN, enuDATA_TYPE.DATE_TYPE)
                TxtSoXN0.Text = InfXN.SoXN
                cboKetQua0.SelectedValue = InfXN.KetquaXN
                txtId_PhieuXetNghiemC0.Text = InfXN.ID_Phieuxetnghiem_C
                txtId_XNGD0.Text = InfXN.ID_Xetnghiem_GD
                TxtNuoicay0.Text = InfXN.Nuoicay
            Else
                Dim ObjXNTB As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
                Dim InfXNTB As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
                InfXNTB = ObjXNTB.NTP_BN_XETNGHIEMBNTHATBAI(txtMaBenhNhan.Text)
                If Not InfXNTB Is Nothing Then
                    SetValue(Me.TxtNgayXN0, InfXNTB.NgayXN, enuDATA_TYPE.DATE_TYPE)
                    TxtSoXN0.Text = InfXNTB.SoXN
                    cboKetQua0.SelectedValue = InfXNTB.KetquaXN
                End If
                ObjXNTB = Nothing
                InfXNTB = Nothing
            End If
            InfXN2 = ObjXN2.GetNTP_BN_XETNGHIEM_GDByThoigianDT(ID_Dieutri, 1)
            If Not InfXN2 Is Nothing Then
                SetValue(Me.TxtNgayXN2, InfXN2.NgayXN, enuDATA_TYPE.DATE_TYPE)
                TxtSoXN2.Text = InfXN2.SoXN
                cboKetQua2.SelectedValue = InfXN2.KetquaXN
                txtId_PhieuXetNghiemC2.Text = InfXN2.ID_Phieuxetnghiem_C
                TxtID_XNGD2.Text = InfXN2.ID_Xetnghiem_GD
                TxtNuoicay1.Text = InfXN2.Nuoicay
            End If
            InfXN5 = ObjXN5.GetNTP_BN_XETNGHIEM_GDByThoigianDT(ID_Dieutri, 2)
            If Not InfXN5 Is Nothing Then
                SetValue(Me.TxtNgayXN5, InfXN5.NgayXN, enuDATA_TYPE.DATE_TYPE)
                TxtSoXN5.Text = InfXN5.SoXN
                cboKetQua5.SelectedValue = InfXN5.KetquaXN
                txtId_PhieuXetNghiemC5.Text = InfXN5.ID_Phieuxetnghiem_C
                TxtID_XNGD5.Text = InfXN5.ID_Xetnghiem_GD
                TxtNuoicay2.Text = InfXN5.Nuoicay
            End If
            InfXN7 = ObjXN7.GetNTP_BN_XETNGHIEM_GDByThoigianDT(ID_Dieutri, 3)
            If Not InfXN7 Is Nothing Then
                SetValue(Me.TxtNgayXN7, InfXN7.NgayXN, enuDATA_TYPE.DATE_TYPE)
                TxtSoXN7.Text = InfXN7.SoXN
                cboKetQua7.SelectedValue = InfXN7.KetquaXN
                txtId_PhieuXetNghiemC7.Text = InfXN7.ID_Phieuxetnghiem_C
                TxtID_XNGD7.Text = InfXN7.ID_Xetnghiem_GD
                TxtNuoicay3.Text = InfXN7.Nuoicay
            End If
            ObjXN = Nothing
            InfXN = Nothing
            ObjXN2 = Nothing
            InfXN2 = Nothing
            ObjXN5 = Nothing
            InfXN5 = Nothing
            ObjXN7 = Nothing
            InfXN7 = Nothing


        End Sub
        Function CheckBeforeUpdate() As Boolean
            CheckBeforeUpdate = False

            If txtTenBN.Text = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Tên bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtTenBN, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf CType(NTP_Common.GetValue(Me.txtNgayVaoVien, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date) > DateTime.Now Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Ngày ĐK không được lớn hơn ngày hiện tại.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtNgayVaoVien, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf CInt(IIf(txtTuoi.Text = "", 0, txtTuoi.Text)) = 0 Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Tuổi bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtSoCMT, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf Me.txtDiaChi.Text = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Địa chỉ của bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtDiaChi, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf Me.txtNgayBDDT.Text = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Ngày bắt đầu điều trị của bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtNgayBDDT, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf CType(NTP_Common.GetValue(Me.txtNgayBDDT, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date) > DateTime.Now Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Ngày Bắt đầu điều trị không được lớn hơn ngày hiện tại.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtNgayBDDT, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf Trim(txtSoDKDT.Text) = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Số đăng ký điều trị của bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtSoDKDT, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf cboPhanLoaiBenh.SelectedValue = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Phân loại bệnh.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.cboPhanLoaiBenh, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf (cboPhacDoDT.SelectedValue = "" And txtPhacDoKhac.Text = "") Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Phác đồ điều trị của bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.txtPhacDoKhac, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf cboPhanLoaiBenhNhan.SelectedValue = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Phân loại bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.cboPhanLoaiBenhNhan, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf TxtID_chuyenden.Text = "" And cboHIVQuy.SelectedValue = 0 Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Kết quả tư vấn hoặc Xét nghiệm HIV trong quý.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.cboHIVQuy, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf CboKetquaDT.SelectedValue = 1 And (cboPhanLoaiBenh.SelectedValue = 2 Or cboPhanLoaiBenh.SelectedValue = 4) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bệnh nhân có KQ Âm tính LNP không được chọn kết quả ĐT là Khỏi.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.CboKetquaDT, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            ElseIf CboKetquaDT.SelectedValue = 1 And cboPhanLoaiBenhNhan.SelectedValue = 6 Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bệnh nhân chuyển đến không được chọn kết quả ĐT là Khỏi.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.CboKetquaDT, Me.ModuleConfiguration.SupportsPartialRendering)
                Exit Function
            End If
            CheckBeforeUpdate = True
        End Function
        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
            Dim infBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
            Dim obj As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
            Dim inf As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
            Try

                If CheckBeforeUpdate() = True Then
                    'Thong tin benh nhan
                    infBenhNhan.HoTen = Me.txtTenBN.Text
                    infBenhNhan.ID_Benhnhan = Me.txtMaBenhNhan.Text
                    infBenhNhan.SoCMND = IIf(Me.txtSoCMT.Text = "", "", Me.txtSoCMT.Text)
                    infBenhNhan.Sodienthoai = IIf(Me.txtDienThoai.Text = "", 0, Me.txtDienThoai.Text)
                    infBenhNhan.Tuoi = IIf(Me.txtTuoi.Text = "", 0, Me.txtTuoi.Text)
                    infBenhNhan.Diachi = IIf(Me.txtDiaChi.Text = "", "", Me.txtDiaChi.Text)
                    infBenhNhan.Gioitinh = Me.optlistGioiTinh.SelectedItem.Value
                    infBenhNhan.MA_TINH = Me.CurrentUserStock.ID_MATINH
                    infBenhNhan.MA_HUYEN = Me.CurrentUserStock.ID_BENHVIEN
                    infBenhNhan.MaBNQL = TxtMaBNQL.Text
                    response.write(Me.CurrentUserStock.ID_MATINH)
                    If txtMaBenhNhan.Text = "" Then
                        If Trim(TxtMaBNQL.Text) <> "" Then
                            inf = obj.ListFind(TxtMaBNQL.Text, "", "", False, CurrentUserStock.ID_MATINH, "")
                            If Not inf Is Nothing Then
                                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Đã tồn tại Mã Bệnh nhân Quản lý. Không thể nhập trùng.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                                NTP_Common.SetFormFocus(Me.TxtMaBNQL, Me.ModuleConfiguration.SupportsPartialRendering)
                                Exit Sub
                            Else
                                Me.txtMaBenhNhan.Text = objBenhNhan.Add(infBenhNhan)
                            End If
                            obj = Nothing
                            inf = Nothing
                        Else
                            Me.txtMaBenhNhan.Text = objBenhNhan.Add(infBenhNhan)
                        End If
                    Else
                        'Update
                        infBenhNhan.ID_Benhnhan = txtMaBenhNhan.Text
                        objBenhNhan.Update(infBenhNhan)
                    End If
                    UpdateTTDieutri(txtMaBenhNhan.Text)
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally

                objBenhNhan = Nothing
                infBenhNhan = Nothing

                'BindgrdDS(txtId_PhieuXetNghiem.Text)
                'pnlDetail.Visible = True
            End Try
        End Sub
     
        Private Sub UpdateTTDieutri(ByVal sMaBN As String)
            Dim objDieuTri As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIController
            Dim infDieuTri As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIInfo
            Dim dtNgayVaoVien As Date
            Dim dtNgayDBDT As Date
            Try
                infDieuTri.ID_BENHNHAN = sMaBN
                dtNgayVaoVien = CType(GetValue(txtNgayVaoVien, enuDATA_TYPE.DATE_TYPE), Date)
                infDieuTri.NgayVV = dtNgayVaoVien
                dtNgayDBDT = CType(GetValue(txtNgayBDDT, enuDATA_TYPE.DATE_TYPE), Date)
                infDieuTri.NgayDT = dtNgayDBDT
                infDieuTri.SoDKDT = txtSoDKDT.Text
                infDieuTri.DVDieutri = cboDonVi.SelectedValue
                infDieuTri.GiamSatDT = txtNguoiGiamSat.Text
                infDieuTri.ID_PhanLoaiBN = cboPhanLoaiBenhNhan.SelectedValue
                infDieuTri.ID_PHANLOAIYTE = CboNoiChuyenden.SelectedValue
                infDieuTri.DVGioiThieu = IIf(CboNoiChuyenden.SelectedValue = 4, "", Me.TxtNoidenKhac.Text)
                infDieuTri.ID_PhanLoaiBenh = IIf(cboPhanLoaiBenh.SelectedValue = "", 0, cboPhanLoaiBenh.SelectedValue)
                infDieuTri.Chandoan = TxtChandoanLNP.Text
                infDieuTri.ID_PhacdoDT = IIf(cboPhacDoDT.SelectedValue = "", 0, cboPhacDoDT.SelectedValue)
                infDieuTri.PhacdoKhac = IIf(txtPhacDoKhac.Text = "", "", txtPhacDoKhac.Text)

                infDieuTri.ID_PhacdoTD = IIf(CboPhacdoTD.SelectedValue = "", 0, CboPhacdoTD.SelectedValue)
                infDieuTri.PhacdoTDKhac = IIf(TxtPhacdoTDKhac.Text = "", "", TxtPhacdoTDKhac.Text)
                infDieuTri.MaBNQL = IIf(TxtMaBNQL.Text = "", "", TxtMaBNQL.Text)

                Dim dtNgayXQ As Date
                dtNgayXQ = CType(GetValue(txtNgayXQuangPhoi, enuDATA_TYPE.DATE_TYPE), Date)
                infDieuTri.NgayChupXQ = dtNgayXQ
                infDieuTri.KetquaXQ = cboKetQuaXQuang.SelectedValue
                infDieuTri.DVDieutri = cboDonVi.SelectedValue
                infDieuTri.ART = OptART.SelectedValue
                infDieuTri.CPT = OptCPT.SelectedValue
                infDieuTri.LymPho = txtCD4.Text
                infDieuTri.XNHIV1 = cboHIVQuy.SelectedValue
                infDieuTri.XNHIV2 = CboHIVLao.SelectedValue
                infDieuTri.Tuoi = IIf(Me.txtTuoi.Text = "", 0, Me.txtTuoi.Text)

                If txtMaPhieuDieuTri.Text = "" Or txtMaPhieuDieuTri.Text Is Nothing Then
                    infDieuTri.ID_PhieuChuyen = IIf(txtMaPhieuChuyen.Text = "", 0, txtMaPhieuChuyen.Text)
                    txtMaPhieuDieuTri.Text = objDieuTri.Add(infDieuTri)

                Else
                    'Update
                    infDieuTri.ID_Dieutri = txtMaPhieuDieuTri.Text
                    objDieuTri.Update(infDieuTri)
                End If
                UpdateTTXETNGHIEM(txtMaPhieuDieuTri.Text)
                If CboKetquaDT.SelectedValue <> 0 Then
                    UpdateKQDT(txtMaPhieuDieuTri.Text)
                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                objDieuTri = Nothing
                infDieuTri = Nothing
            End Try
        End Sub
        Private Sub UpdateTTXETNGHIEM(ByVal PhieuDT As String)
            Dim objXN0 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim infXN0 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
            Dim objXN2 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim infXN2 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
            Dim objXN5 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim infXN5 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
            Dim objXN7 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDController
            Dim infXN7 As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_XETNGHIEM_GDInfo
            Try
                Dim dtNgayXN1 As Date
                If TxtNgayXN0.Text <> "" Or Trim(TxtNuoicay0.Text) <> "" Then
                    infXN0.ID_Dieutri = PhieuDT
                    dtNgayXN1 = CType(GetValue(TxtNgayXN0, enuDATA_TYPE.DATE_TYPE), Date)
                    infXN0.NgayXN = dtNgayXN1
                    infXN0.SoXN = TxtSoXN0.Text
                    infXN0.KetquaXN = cboKetQua0.SelectedValue
                    infXN0.ThoiGianDT = 0
                    infXN0.ID_Phieuxetnghiem_C = IIf(txtId_PhieuXetNghiemC0.Text = "", 0, txtId_PhieuXetNghiemC0.Text)
                    infXN0.CanNang = 0
                    infXN0.NGAY_NM = Now
                    infXN0.NGUOI_NM = Me.CurrentUserStock.USERID
                    infXN0.Nuoicay = Me.TxtNuoicay0.Text
                    ' Response.Write("sgsdhs" & txtId_XNGD0.Text)
                    If txtId_XNGD0.Text = "" Then
                        txtId_XNGD0.Text = objXN0.Add(infXN0)
                    Else
                        infXN0.ID_Xetnghiem_GD = txtId_XNGD0.Text
                        objXN0.Update(infXN0)
                    End If
                ElseIf TxtNgayXN0.Text = "" And txtId_XNGD0.Text <> "" Then
                    objXN0.Delete(txtId_XNGD0.Text)
                End If
                If TxtNgayXN2.Text <> "" Or Trim(TxtNuoicay1.Text) <> "" Then
                    infXN2.ID_Dieutri = PhieuDT
                    dtNgayXN1 = CType(GetValue(TxtNgayXN2, enuDATA_TYPE.DATE_TYPE), Date)
                    infXN2.NgayXN = dtNgayXN1
                    infXN2.SoXN = TxtSoXN2.Text
                    infXN2.KetquaXN = cboKetQua2.SelectedValue
                    infXN2.ID_Phieuxetnghiem_C = IIf(txtId_PhieuXetNghiemC2.Text = "", 0, txtId_PhieuXetNghiemC2.Text)
                    infXN2.ThoiGianDT = 1
                    infXN2.CanNang = 0
                    infXN2.NGAY_NM = Now
                    infXN2.NGUOI_NM = Me.CurrentUserStock.USERID
                    infXN2.Nuoicay = Me.TxtNuoicay1.Text
                    If TxtID_XNGD2.Text = "" Then
                        TxtID_XNGD2.Text = objXN2.Add(infXN2)
                    Else
                        infXN2.ID_Xetnghiem_GD = TxtID_XNGD2.Text
                        objXN2.Update(infXN2)
                    End If
                ElseIf TxtNgayXN2.Text = "" And TxtID_XNGD2.Text <> "" Then
                    objXN0.Delete(TxtID_XNGD2.Text)
                End If
                If TxtNgayXN5.Text <> "" Or Trim(TxtNuoicay2.Text) <> "" Then
                    infXN5.ID_Dieutri = PhieuDT
                    dtNgayXN1 = CType(GetValue(TxtNgayXN5, enuDATA_TYPE.DATE_TYPE), Date)
                    infXN5.NgayXN = dtNgayXN1
                    infXN5.SoXN = TxtSoXN5.Text
                    infXN5.KetquaXN = cboKetQua5.SelectedValue
                    infXN5.ID_Phieuxetnghiem_C = IIf(txtId_PhieuXetNghiemC5.Text = "", 0, txtId_PhieuXetNghiemC5.Text)
                    infXN5.ThoiGianDT = 2
                    infXN5.CanNang = 0
                    infXN5.NGAY_NM = Now
                    infXN5.NGUOI_NM = Me.CurrentUserStock.USERID
                    infXN5.Nuoicay = Me.TxtNuoicay2.Text
                    If TxtID_XNGD5.Text = "" Then
                        TxtID_XNGD5.Text = objXN5.Add(infXN5)
                    Else
                        infXN5.ID_Xetnghiem_GD = TxtID_XNGD5.Text
                        objXN5.Update(infXN5)
                    End If
                ElseIf TxtNgayXN5.Text = "" And TxtID_XNGD5.Text <> "" Then
                    objXN0.Delete(TxtID_XNGD5.Text)

                End If
                If TxtNgayXN7.Text <> "" Or Trim(TxtNuoicay3.Text) <> "" Then
                    infXN7.ID_Dieutri = PhieuDT
                    dtNgayXN1 = CType(GetValue(TxtNgayXN7, enuDATA_TYPE.DATE_TYPE), Date)
                    infXN7.NgayXN = dtNgayXN1
                    infXN7.SoXN = TxtSoXN7.Text
                    infXN7.KetquaXN = cboKetQua7.SelectedValue
                    infXN7.ID_Phieuxetnghiem_C = IIf(txtId_PhieuXetNghiemC7.Text = "", 0, txtId_PhieuXetNghiemC7.Text)
                    infXN7.ThoiGianDT = 3
                    infXN7.CanNang = 0
                    infXN7.NGAY_NM = Now
                    infXN7.NGUOI_NM = Me.CurrentUserStock.USERID
                    infXN7.Nuoicay = Me.TxtNuoicay3.Text
                    If TxtID_XNGD7.Text = "" Then
                        TxtID_XNGD7.Text = objXN7.Add(infXN7)
                    Else
                        infXN7.ID_Xetnghiem_GD = TxtID_XNGD7.Text
                        objXN7.Update(infXN7)
                    End If
                ElseIf TxtNgayXN7.Text = "" And TxtID_XNGD7.Text <> "" Then
                    objXN0.Delete(TxtID_XNGD7.Text)

                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                objXN0 = Nothing : infXN0 = Nothing
                objXN2 = Nothing : infXN2 = Nothing
                objXN5 = Nothing : infXN5 = Nothing
                objXN7 = Nothing : infXN7 = Nothing
            End Try
        End Sub
        Private Sub UpdateKQDT(ByVal ID_Dieutri As Integer)
            Dim objKQ As New NTP_BN_DIEUTRI.NTP_BN_KETQUADTController
            Dim infKQ As New NTP_BN_DIEUTRI.NTP_BN_KETQUADTInfo
            Dim objPC As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Dim infPC As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENInfo
            Try
                infKQ.KetquaDT = Me.CboKetquaDT.SelectedValue
                Dim dtNgayRV As Date
                dtNgayRV = CType(NTP_Common.GetValue(Me.TxtNgayRV, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                infKQ.NgayRV = dtNgayRV
                infKQ.Ghichu = Me.TxtGhichu.Text
                infKQ.ID_Dieutri = ID_Dieutri
                infKQ.KetquaDT = CboKetquaDT.SelectedValue

                'If  Then
                objKQ.UpdateNTP_BN_KETQUADT(infKQ)
                '---------Insert Phieuchuyen---------
                If Me.CboKetquaDT.SelectedValue = 6 Then ' tao phieu chuyen
                    If Me.TxtNgaychuyen.Text = "" Then
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Ngày chuyển điều trị của bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                        NTP_Common.SetFormFocus(Me.TxtNgaychuyen, Me.ModuleConfiguration.SupportsPartialRendering)
                    ElseIf Me.cboDVTiepnhan.SelectedValue = "" Then
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Đơn vị tiếp nhận bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                        NTP_Common.SetFormFocus(Me.cboDVTiepnhan, Me.ModuleConfiguration.SupportsPartialRendering)
                    Else
                        infPC.ID_Dieutri = ID_Dieutri
                        infPC.PhanLoai = Me.optlistLoaiYTe.SelectedItem.Value
                        infPC.DVTiepnhan = Me.cboDVTiepnhan.SelectedValue
                        infPC.DVChuyen = Me.CurrentUserStock.ID_BENHVIEN
                        infPC.Lydo = Me.TxtLydo.Text
                        infPC.TinhTrangBN = Me.TxtTinhtrangBN.Text
                        dtNgayRV = CType(NTP_Common.GetValue(Me.TxtNgaychuyen, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                        infPC.NgayChuyen = dtNgayRV
                        infPC.SoDKDT = Me.txtSoDKDT.Text
                        infPC.NGUOI_NM = Me.CurrentUserStock.USERID
                        If Me.TxtTiepnhanBN.Text = "" Or Me.TxtTiepnhanBN.Text = "0" Then
                            If txtMaPhieuChuyen.Text = "0" Or txtMaPhieuChuyen.Text = "" Then
                                infPC.Tiepnhan = 0
                                txtMaPhieuChuyen.Text = objPC.AddNTP_BN_PHIEUCHUYEN(infPC)
                            Else
                                infPC.ID_Phieuchuyen = txtMaPhieuChuyen.Text
                                infPC.Tiepnhan = 0
                                objPC.Update(infPC)
                            End If
                        End If
                    End If
                ElseIf CInt(IIf(Me.TxtTiepnhanBN.Text = "", 0, Me.TxtTiepnhanBN.Text)) = 0 Then
                    If txtMaPhieuChuyen.Text <> "0" Or txtMaPhieuChuyen.Text <> "" Then
                        infPC.ID_Phieuchuyen = txtMaPhieuChuyen.Text
                        infPC.ID_Dieutri = ID_Dieutri
                        infPC.Tiepnhan = 1
                        ' infPC.IDDieutri_DVTN = ID_Dieutri
                        objPC.Update(infPC)
                    Else
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bệnh nhân đã được tiếp nhận. Không thể sửa phiếu chuyển BN.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    End If
                End If
                '  End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                ' Response.Write(ex.ToString)
            Finally
                objKQ = Nothing
                infKQ = Nothing
            End Try
        End Sub


        Private Sub UpdatePhieuChuyen(ByVal sMaBN As String)
            Dim objPhieuChuyen As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Dim infPhieuChuyen As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENInfo
            If txtMaPhieuChuyen.Text = "" Or txtMaPhieuChuyen.Text Is Nothing Then

            Else
                infPhieuChuyen = objPhieuChuyen.Get(txtMaPhieuChuyen.Text)
                infPhieuChuyen.Tiepnhan = 1
                objPhieuChuyen.Update(infPhieuChuyen)
            End If
        End Sub
        Private Sub BindComboBenhVien(ByVal Id_BenhVien As String, ByVal Id_Tinh As String)
            Dim obj As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController

            Try
                Me.cboDonVi.DataSource = obj.GetByBenVien(Id_BenhVien, Id_Tinh)
                Me.cboDonVi.DataBind()

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboDVTiepnhan()
            Dim obj As New NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế---"
                Me.cboDVTiepnhan.DataSource = obj.ListCocoDT(Me.CurrentUserStock.ID_BENHVIEN)
                Me.cboDVTiepnhan.DataBind()
                Me.cboDVTiepnhan.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Private Sub BindComboTinh()
            Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn tỉnh ---"
                'Me.cboTinh.DataSource = obj.Search("", 0)
                'Me.cboTinh.DataBind()
                'Me.cboTinh.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Private Sub BindComboHuyen(ByVal Id_Tinh As String)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.cboDVTiepnhan.DataSource = obj.ListNTP_DM_BENHVIEN(Id_Tinh)
                Me.cboDVTiepnhan.DataBind()
                Me.cboDVTiepnhan.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboPhanLoaiBenh()
            Dim obj As New NTP_BN_DM_PHANLOAIBENH.NTP_BN_DM_PhanLoaiBenhController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn phân loại bệnh ---"
                Me.cboPhanLoaiBenh.DataSource = obj.List()
                Me.cboPhanLoaiBenh.DataBind()
                Me.cboPhanLoaiBenh.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboPhanLoaiBenhNhan()
            Dim obj As New NTP_BN_DM_PHANLOAIBN.NTP_BN_DM_PhanLoaiBNController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn phân loại BN ---"
                Me.cboPhanLoaiBenhNhan.DataSource = obj.List()
                Me.cboPhanLoaiBenhNhan.DataBind()
                Me.cboPhanLoaiBenhNhan.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboPhacDo()
            Dim obj As New NTP_BN_DM_PHACDODT.NTP_BN_DM_PHACDODTController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Phác đồ khác ---"
                Me.cboPhacDoDT.DataSource = obj.List()
                Me.cboPhacDoDT.DataBind()
                Me.cboPhacDoDT.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboPhacdoTD()
            Dim obj As New NTP_BN_DM_PHACDODT.NTP_BN_DM_PHACDODTController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Phác đồ khác ---"
                Me.CboPhacdoTD.DataSource = obj.List()
                Me.CboPhacdoTD.DataBind()
                Me.CboPhacdoTD.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub cboPhacDoDT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPhacDoDT.SelectedIndexChanged
            If cboPhacDoDT.SelectedValue <> "" Then
                txtPhacDoKhac.Visible = False
                'If cboGiaDoanDT.SelectedValue = 0 Then
                '    NTP_Common.SetFormFocus(txtRHZE, Me.ModuleConfiguration.SupportsPartialRendering)
                'Else
                '    NTP_Common.SetFormFocus(txtE1, Me.ModuleConfiguration.SupportsPartialRendering)
                'End If
            Else
                txtPhacDoKhac.Visible = True
                NTP_Common.SetFormFocus(txtPhacDoKhac, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        End Sub
        Protected Sub CmdXetnghiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXetnghiem.Click
            CmdXetnghiem.BackColor = Color.LightCyan
            CmdHIV.BackColor = Color.WhiteSmoke()
            CmdDieutri.BackColor = Color.WhiteSmoke()
            CmdXetnghiem.Font.Underline = True
            CmdDieutri.Font.Underline = False
            CmdKetquaDT.Font.Underline = False
            CmdKetquaDT.BackColor = Color.WhiteSmoke()
            CmdHIV.Font.Underline = False
            PanelDieutri.Visible = False
            PanelXetnghiem.Visible = True
            PanelHIV.Visible = False
            PanelKetquaDT.Visible = False
            ' cmdAdd_Click(sender, e)
        End Sub

        Protected Sub CmdHIV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdHIV.Click
            CmdXetnghiem.BackColor = Color.WhiteSmoke()
            CmdHIV.BackColor = Color.LightCyan
            CmdDieutri.BackColor = Color.WhiteSmoke()
            CmdXetnghiem.Font.Underline = False
            CmdDieutri.Font.Underline = False
            CmdHIV.Font.Underline = True
            CmdKetquaDT.Font.Underline = False
            CmdKetquaDT.BackColor = Color.WhiteSmoke()

            PanelDieutri.Visible = False
            PanelXetnghiem.Visible = False
            PanelHIV.Visible = True
            PanelKetquaDT.Visible = False
		 grdDS.Visible = False
        End Sub

        Protected Sub CmdDieutri_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdDieutri.Click
            CmdXetnghiem.BackColor = Color.WhiteSmoke()
            CmdXetnghiem.Font.Underline = False
            CmdHIV.BackColor = Color.WhiteSmoke()
            CmdHIV.Font.Underline = False
            CmdDieutri.BackColor = Color.LightCyan
            CmdDieutri.Font.Underline = True
            CmdKetquaDT.Font.Underline = False
            CmdKetquaDT.BackColor = Color.WhiteSmoke()
            PanelDieutri.Visible = True
            PanelXetnghiem.Visible = False
            PanelHIV.Visible = False
            PanelKetquaDT.Visible = False
		 grdDS.Visible = False
        End Sub

        Protected Sub CmdKetquaDT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdKetquaDT.Click
            CmdXetnghiem.BackColor = Color.WhiteSmoke()
            CmdXetnghiem.Font.Underline = False
            CmdHIV.BackColor = Color.WhiteSmoke()
            CmdHIV.Font.Underline = False
            CmdDieutri.BackColor = Color.WhiteSmoke
            CmdDieutri.Font.Underline = False
            CmdKetquaDT.Font.Underline = True
            CmdKetquaDT.BackColor = Color.LightCyan()

            PanelDieutri.Visible = False
            PanelXetnghiem.Visible = False
            PanelHIV.Visible = False
            PanelKetquaDT.Visible = True
 		grdDS.Visible = False
        End Sub

        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            SetValue(Me.txtNgayVaoVien, Now, enuDATA_TYPE.DATE_TYPE)
            TxtMaBNQL.Text = ""
            txtSoDKDT.Text = "" : txtTenBN.Text = "" : txtMaBenhNhan.Text = ""
            TxtID_DieutriBNC.Text = "" : txtMaPhieuDieuTri.Text = "" : txtMaPhieuChuyen.Text = 0
            TxtTiepnhanBN.Text = "" : TxtID_chuyenden.Text = ""
            optlistGioiTinh.SelectedValue = 1
            txtTuoi.Text = "" : txtSoCMT.Text = ""
            ' cboHuyen.SelectedValue = ""
            txtDiaChi.Text = ""
            txtDienThoai.Text = "" : CboNoiChuyenden.SelectedValue = 1
            ' SetValue(Me.txtNgayBDDT, Now, enuDATA_TYPE.DATE_TYPE)
            txtNgayBDDT.Enabled = True
            Label148.Text = "Ngày tháng ĐK"
            cboPhacDoDT.SelectedValue = "" : txtNguoiGiamSat.Text = ""
            cboPhanLoaiBenh.SelectedValue = "" : cboPhanLoaiBenhNhan.SelectedValue = ""
            txtNgayXQuangPhoi.Text = "" : cboKetQuaXQuang.SelectedValue = 0
            TxtNgayXN0.Text = "" : TxtSoXN0.Text = ""
            cboKetQua0.SelectedValue = 0 : TxtNgayXN2.Text = ""
            TxtSoXN2.Text = "" : cboKetQua2.SelectedValue = 0
            TxtNgayXN5.Text = "" : TxtSoXN5.Text = ""
            cboKetQua5.SelectedValue = 0 : TxtNgayXN7.Text = ""
            TxtSoXN7.Text = "" : cboKetQua7.SelectedValue = 0
            cboHIVQuy.SelectedValue = 0 : CboHIVLao.SelectedValue = 0
            OptART.SelectedValue = 0 : OptCPT.SelectedValue = 0
            txtCD4.Text = "" : TxtNgayRV.Text = ""
            CboKetquaDT.SelectedValue = 0 : TxtGhichu.Text = ""
            TxtNgaychuyen.Text = "" : optlistLoaiYTe.SelectedValue = 1
            cboDVTiepnhan.SelectedValue = "" : TxtLydo.Text = ""
            TxtTinhtrangBN.Text = ""
            txtId_PhieuXetNghiemC0.Text = "" : txtId_PhieuXetNghiemC2.Text = ""
            txtId_PhieuXetNghiemC5.Text = "" : txtId_PhieuXetNghiemC7.Text = ""
            TxtNuoicay0.Text = "" : TxtNuoicay1.Text = ""
            TxtNuoicay2.Text = "" : TxtNuoicay3.Text = ""
            TxtTiepnhanBN.Text = 0
            CmdXetnghiem.BackColor = Color.WhiteSmoke()
            CmdHIV.BackColor = Color.WhiteSmoke()
            CmdDieutri.BackColor = Color.WhiteSmoke
            CmdKetquaDT.BackColor = Color.WhiteSmoke
            CmdDieutri.Font.Underline = True
            PanelDieutri.Visible = True
            PanelXetnghiem.Visible = False
            PanelHIV.Visible = False
            PanelKetquaDT.Visible = False
            cmdAdd.Enabled = True
            PanelPC.Visible = False

            
        End Sub

     

        Protected Sub CboNoiChuyenden_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboNoiChuyenden.SelectedIndexChanged
            If CboNoiChuyenden.SelectedValue <> "4" Then
                TxtNoidenKhac.Visible = False
                'If cboGiaDoanDT.SelectedValue = 0 Then
                '    NTP_Common.SetFormFocus(txtRHZE, Me.ModuleConfiguration.SupportsPartialRendering)
                'Else
                '    NTP_Common.SetFormFocus(txtE1, Me.ModuleConfiguration.SupportsPartialRendering)
                'End If
            Else
                TxtNoidenKhac.Visible = True
                NTP_Common.SetFormFocus(TxtNoidenKhac, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        End Sub

        Protected Sub txtSoCMT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSoCMT.TextChanged
            Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
            Dim infBenhNhans As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
            Try
                If txtTenBN.Text = "" And txtSoCMT.Text <> "" Then
                    infBenhNhans = objBenhNhan.ListFind(txtMaBenhNhan.Text, txtTenBN.Text, txtSoCMT.Text, False, "", "")
                    If Not infBenhNhans Is Nothing Then
                        Me.txtMaBenhNhan.Text = infBenhNhans.ID_Benhnhan
                        '  Me.cboTinh.SelectedValue = infBenhNhans.MA_TINH
                        ' BindComboHuyen(Me.cboTinh.SelectedValue)
                        ' Me.cboHuyen.SelectedValue = infBenhNhans.MA_HUYEN
                        Me.txtDienThoai.Text = infBenhNhans.Sodienthoai
                        Me.txtTuoi.Text = infBenhNhans.Tuoi
                        If infBenhNhans.Gioitinh = False Then
                            Me.optlistGioiTinh.SelectedValue = 0
                        Else
                            Me.optlistGioiTinh.SelectedValue = 1
                        End If
                    End If
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                infBenhNhans = Nothing
            End Try


        End Sub

        Protected Sub OptKetquaDT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboKetquaDT.SelectedIndexChanged
            If CboKetquaDT.SelectedValue = 6 Then
                PanelPC.Visible = True
                TxtNgaychuyen.Text = TxtNgayRV.Text
                optlistLoaiYTe.SelectedValue = 0
                optlistLoaiYTe_SelectedIndexChanged(sender, e)
                'BindComboDVTiepnhan()
            Else
                PanelPC.Visible = False
            End If
        End Sub

        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub
        Private Sub LoadDSXetnghiem(ByVal sMaBN As String, ByVal GiaidoanDT As Byte)
            Dim objPhieuXetNghiemC As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEM_CController
            Try
                grdDS.Visible = True
                grdDS.DataSource = objPhieuXetNghiemC.ListByIDBENHNHAN(sMaBN, GiaidoanDT)
                grdDS.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                '  Response.Write(ex.ToString)
            Finally
                objPhieuXetNghiemC = Nothing
            End Try
        End Sub
        Protected Sub CmdTruocDT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdTruocDT.Click
            Me.TxtChon.Text = 0
            LoadDSXetnghiem(txtMaBenhNhan.Text, 0)
           
        End Sub
        Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand

            If e.CommandName = "edit" Then
                Try
                    Dim objXN_C As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEM_CController
                    Dim infXN_C As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEM_CInfo
                    infXN_C = objXN_C.Get(e.Item.Cells(1).Text)
'response.write (e.Item.Cells(1).Text)
                    If TxtChon.Text = 0 Then
                        SetValue(Me.TxtNgayXN0, infXN_C.NgayNhanMau, enuDATA_TYPE.DATE_TYPE)
                        TxtSoXN0.Text = CStr(infXN_C.SoXN) & "." & CStr(infXN_C.Maudom)
                        cboKetQua0.SelectedValue = infXN_C.Ketqua
                        txtId_PhieuXetNghiemC0.Text = infXN_C.ID_Phieuxetnghiem_C
                    ElseIf TxtChon.Text = 2 Then
                        SetValue(Me.TxtNgayXN2, infXN_C.NgayNhanMau, enuDATA_TYPE.DATE_TYPE)
                        TxtSoXN2.Text = CStr(infXN_C.SoXN) & "." & CStr(infXN_C.Maudom)
                        cboKetQua2.SelectedValue = infXN_C.Ketqua
                        txtId_PhieuXetNghiemC2.Text = infXN_C.ID_Phieuxetnghiem_C
                    ElseIf TxtChon.Text = 5 Then
                        SetValue(Me.TxtNgayXN5, infXN_C.NgayNhanMau, enuDATA_TYPE.DATE_TYPE)
                        TxtSoXN5.Text = CStr(infXN_C.SoXN) & "." & CStr(infXN_C.Maudom)
                        cboKetQua5.SelectedValue = infXN_C.Ketqua

                        txtId_PhieuXetNghiemC5.Text = infXN_C.ID_Phieuxetnghiem_C
                    ElseIf TxtChon.Text = 7 Then
                        SetValue(Me.TxtNgayXN7, infXN_C.NgayNhanMau, enuDATA_TYPE.DATE_TYPE)
                        TxtSoXN7.Text = CStr(infXN_C.SoXN) & "." & CStr(infXN_C.Maudom)
                        cboKetQua7.SelectedValue = infXN_C.Ketqua

                        txtId_PhieuXetNghiemC7.Text = infXN_C.ID_Phieuxetnghiem_C
                    End If
                    grdDS.Visible = False
                Catch ex As Exception
                    ProcessModuleLoadException(Me, ex)
                Finally

                End Try
                'Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
            End If
        End Sub

        Protected Sub CmdXN2T_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXN2T.Click

            'Dim s As String
            's = ""
            'If txtId_PhieuXetNghiemC0.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC0.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC2.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC2.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC5.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC5.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC7.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC7.Text & ","
            'End If
            'If s = "" Then
            '    s = "0"
            'Else
            '    s = Left(s, Len(s) - 1)
            'End If
            Me.TxtChon.Text = 2

            LoadDSXetnghiem(txtMaBenhNhan.Text, 1)
        End Sub

        Protected Sub CmdXN5T_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXN5T.Click
            Me.TxtChon.Text = 5
            'Dim s As String
            's = ""
            'If txtId_PhieuXetNghiemC0.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC0.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC2.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC2.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC5.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC5.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC7.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC7.Text & ","
            'End If
            'If s = "" Then
            '    s = "0"
            'Else
            '    s = Left(s, Len(s) - 1)
            'End If
            LoadDSXetnghiem(txtMaBenhNhan.Text, 2)

        End Sub

        Protected Sub CmdXN7T_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXN7T.Click
            Me.TxtChon.Text = 7
            'Dim s As String
            's = ""
            'If txtId_PhieuXetNghiemC0.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC0.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC2.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC2.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC5.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC5.Text & ","
            'End If
            'If txtId_PhieuXetNghiemC7.Text <> "" Then
            '    s = s & txtId_PhieuXetNghiemC7.Text & ","
            'End If
            'If s = "" Then
            '    s = "0"
            'Else
            '    s = Left(s, Len(s) - 1)
            'End If
            LoadDSXetnghiem(txtMaBenhNhan.Text, 3)
        End Sub

        Protected Sub CmdLoadThongtinBN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdLoadThongtinBN.Click
            Dim obj As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
            Dim inf As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
            inf = obj.ListFind(TxtMaBNQL.Text, "", txtSoCMT.Text, False, "", Me.CurrentUserStock.ID_BENHVIEN)
            If Not inf Is Nothing Then
                LoadBenhNhan(inf)
                Dim objBNDT As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                Dim infBNDT As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
                infBNDT = objBNDT.GetBENHNHAN_DIEUTRI(txtMaBenhNhan.Text)
                If Not infBNDT Is Nothing Then
                    txtMaPhieuDieuTri.Text = infBNDT.ID_DIEUTRI
                    LoadThongtinDT(txtMaPhieuDieuTri.Text)
                End If
            Else
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Không tìm thấy Bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)

            End If
            obj = Nothing
            inf = Nothing

        End Sub

        Protected Sub optlistLoaiYTe_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optlistLoaiYTe.SelectedIndexChanged
            Dim obj As New NTP_BN_DIEUTRI.NTP_BN_KETQUADTController
            Dim OBJTINH As New NTP_DANHMUC.NTP_DM_TINH_BO
            Dim obj1 As New NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHController
            Dim itm As ListItem
            Try
               
                If optlistLoaiYTe.SelectedValue = 1 Then ' 
                    cboTinh.Visible = True
                    itm = New ListItem
                    itm.Value = Null.NullString
                    itm.Text = "--- Chọn Tỉnh/Thành phố ---"
                    cboTinh.DataSource = OBJTINH.SelectAllItems
                    cboTinh.DataBind()
                    Me.cboTinh.Items.Insert(0, itm)
                    Me.cboDVTiepnhan.DataSource = obj.ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(Me.CurrentUserStock.ID_BENHVIEN, cboTinh.SelectedValue)
                    Me.cboDVTiepnhan.DataBind()
                Else 'chuyen TUYEN:các CSYT trong tỉnh
                    itm = New ListItem
                    itm.Value = Null.NullString
                    itm.Text = "--- Chọn cơ sở y tế---"
                    Me.cboDVTiepnhan.DataSource = obj.ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    cboTinh.Visible = False
                    Me.cboDVTiepnhan.DataBind()
                    Me.cboDVTiepnhan.Items.Insert(0, itm)
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub CboHIVLao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboHIVLao.SelectedIndexChanged

            If CboHIVLao.SelectedValue <= 4 Then
                OptART.Enabled = False
                OptCPT.Enabled = False
            Else
                OptART.Enabled = True
                OptCPT.Enabled = True
            End If
        End Sub

        Protected Sub cboTinh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTinh.SelectedIndexChanged
            If cboTinh.SelectedValue <> "" Then
                BindComboHuyen(cboTinh.SelectedValue)
                NTP_Common.SetFormFocus(cboDVTiepnhan, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        End Sub

        Protected Sub cboPhanLoaiBenh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPhanLoaiBenh.SelectedIndexChanged
            If cboPhanLoaiBenh.SelectedValue = "" Then cboPhanLoaiBenh.SelectedValue = 0
            If cboPhanLoaiBenh.SelectedValue = 4 Then
                TxtChandoanLNP.Visible = True
            Else
                TxtChandoanLNP.Visible = False
            End If
        End Sub
    End Class
End Namespace