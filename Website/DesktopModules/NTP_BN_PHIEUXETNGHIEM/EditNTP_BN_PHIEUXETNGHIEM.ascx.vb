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
Imports NTP_Common.mdlGlobal
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Reflection
Namespace YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_PHIEUXETNGHIEM
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private strTemplate As String
        Private ID_PhieuXetNghiem As Integer

#End Region

#Region "Event Handlers"

#End Region

#Region "Optional Interfaces"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If

                grdDS.Visible = True
                If Not IsPostBack Then

                    BindComboTinh()
                    CboTinh.SelectedValue = Me.CurrentUserStock.ID_MATINH
                    BindComboHuyen(CboTinh.SelectedValue)
                    'SetValue(Me.txtNgayXN, Now, enuDATA_TYPE.DATE_TYPE)
                    Panel1.Visible = False
                    If Not Request.QueryString("idBenhNhan") Is Nothing Then
                        'Load thông tin bệnh nhân
                        Dim objBenhNhanh As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                        Dim infBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
                        infBenhNhan = objBenhNhanh.Get(Request.QueryString("idBenhNhan"))
                        If infBenhNhan Is Nothing Then
                        Else
                            Panel1.Height = 300
                            LoadBenhNhan(infBenhNhan)
                        End If
                        If Not Request.QueryString("idXetNghiem") Is Nothing Then
                            LoadPhieuXetNghiem(Request.QueryString("idXetNghiem"))
                            '    Response.Write(txtId_PhieuXetNghiem.Text)
                            BindgrdDS(txtId_PhieuXetNghiem.Text)
                            Panel1.Visible = True
                            Panel1.Height = 600
                        End If
                    Else

                    End If

                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Protected Sub LoadBenhNhan(ByVal infBenhNhan As NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo)
            Try
                Me.txtDiaChi.Text = infBenhNhan.Diachi
                Me.txtTenBN.Text = infBenhNhan.HoTen
                Me.txtMaBenhNhan.Text = infBenhNhan.ID_Benhnhan
                Me.TxtMaBNQL.Text = infBenhNhan.MaBNQL
                BindComboTinh()
                'Me.cboTinh.SelectedValue = infBenhNhan.MA_TINH
                'BindComboHuyen(Me.cboTinh.SelectedValue)
                'Me.cboHuyen.SelectedValue = infBenhNhan.MA_HUYEN
                Me.txtSoCMT.Text = infBenhNhan.SoCMND
                Me.txtDienThoai.Text = infBenhNhan.Sodienthoai
                Me.txtSoDKDT.Text = infBenhNhan.SoDKDT
                Me.txtTuoi.Text = infBenhNhan.Tuoi
                'If infBenhNhan.ID_DoiTuong > 0 And infBenhNhan.ID_DoiTuong < 4 Then
                '    optlistLoaiYTe.SelectedValue = infBenhNhan.ID_DoiTuong
                'End If
                If infBenhNhan.Gioitinh = False Then
                    Me.optlistGioiTinh.SelectedValue = 0
                Else
                    Me.optlistGioiTinh.SelectedValue = 1
                End If
                Me.chkHtest.Checked = infBenhNhan.HIV

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Protected Sub LoadPhieuXetNghiem(ByVal idXetNghiem As String)
            Try
                Dim objPhieuXetNghiem As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMController
                Dim infPhieuXetNghiem As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMInfo
                infPhieuXetNghiem = objPhieuXetNghiem.Get(idXetNghiem)
                If Not infPhieuXetNghiem Is Nothing Then
                    Me.txtMaBenhNhan.Text = infPhieuXetNghiem.ID_Benhnhan
                    Me.cboDonVi.Text = infPhieuXetNghiem.ID_Benhvien
                    Me.TxtMaBNQL.Text = infPhieuXetNghiem.XNVien
                    ' Me.txtNgayXN.Text = infPhieuXetNghiem.NGAYXN
                    SetValue(txtNgayXN, infPhieuXetNghiem.NGAYXN, enuDATA_TYPE.DATE_TYPE)
                    Me.txtSoXetNghiem.Text = infPhieuXetNghiem.SoXN
                    optlistLyDo.SelectedValue = infPhieuXetNghiem.LydoXN
                    Me.txtId_PhieuXetNghiem.Text = infPhieuXetNghiem.ID_Phieuxetnghiem
                    ' Me.txtNguoiLapPhieu.Text = infPhieuXetNghiem.XNVien
                    Me.txtSoMauDom.Text = IIf(infPhieuXetNghiem.Soluong = 0, "", infPhieuXetNghiem.Soluong)
                    Me.chkHtest.Checked = infPhieuXetNghiem.HIV
                    Me.txtSoThangDT.SelectedValue = IIf(infPhieuXetNghiem.SoThangDT = 0, "", infPhieuXetNghiem.SoThangDT)
                    If txtSoThangDT.Text <> "" Then
                        optlistLoaiYTe.Enabled = False
                    End If
                    Me.txtSoDKDT.Text = infPhieuXetNghiem.SoDKDT
                    Me.CboTinh.SelectedValue = infPhieuXetNghiem.MA_TINH
                    BindComboHuyen(CboTinh.SelectedValue)
                    Me.CboHuyen.SelectedValue = infPhieuXetNghiem.DV_Tiepnhan
                    If infPhieuXetNghiem.ID_PhanloaiYte > 0 And infPhieuXetNghiem.ID_PhanloaiYte < 4 Then
                        optlistLoaiYTe.SelectedValue = infPhieuXetNghiem.ID_PhanloaiYte
                    End If
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindgrdDS(ByVal ID_PhieuXetNghiem As String)
            Dim objPhieuXetNghiemC As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEM_CController
            Try
                grdDS.DataSource = objPhieuXetNghiemC.ListByID(ID_PhieuXetNghiem)
                grdDS.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                Response.Write(ex.ToString)
            Finally
                objPhieuXetNghiemC = Nothing
            End Try
        End Sub
        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
            Dim infBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
            Dim obj As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
            Dim inf As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
            Try
                'Thong tin benh nhan
                If txtTenBN.Text = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Tên bệnh nhân..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtTenBN, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf CInt(IIf(TxtTuoi.Text = "", 0, TxtTuoi.Text)) = 0 Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Tuổi bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtSoCMT, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf txtNgayXN.Text = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Ngày xét nghiệm..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtNgayXN, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf CType(NTP_Common.GetValue(Me.txtNgayXN, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date) > DateTime.Now Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Ngày Xét nghiệm không được lớn hơn ngày hiện tại.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtNgayXN, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf Me.TxtDiachi.Text = "" And optlistLyDo.SelectedValue = 0 Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Địa chỉ của bệnh nhân.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.TxtDiachi, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf txtSoMauDom.Text = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Số lượng mẫu..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtSoMauDom, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf optlistLyDo.SelectedValue = 1 And Trim(txtSoThangDT.Text) = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Số tháng điều trị..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtSoThangDT, Me.ModuleConfiguration.SupportsPartialRendering)
                Else

                    infBenhNhan.Diachi = Me.TxtDiachi.Text
                    infBenhNhan.Gioitinh = Me.optlistGioiTinh.SelectedItem.Value
                    infBenhNhan.HoTen = Me.txtTenBN.Text
                    infBenhNhan.ID_Benhnhan = Me.txtMaBenhNhan.Text
                    infBenhNhan.SoCMND = Me.txtSoCMT.Text
                    infBenhNhan.Sodienthoai = Me.txtDienThoai.Text
                    infBenhNhan.Tuoi = CInt(IIf(Me.TxtTuoi.Text = "", 0, Me.TxtTuoi.Text))
                    infBenhNhan.ID_DoiTuong = 0 ' optlistLoaiYTe.SelectedValue
                    infBenhNhan.MA_TINH = Me.CurrentUserStock.ID_MATINH
                    infBenhNhan.MA_HUYEN = Me.CurrentUserStock.ID_BENHVIEN
                    infBenhNhan.MaBNQL = TxtMaBNQL.Text
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
                        UpdatePhieuXetNghiem(txtMaBenhNhan.Text)
                        'Response.Write(txtId_PhieuXetNghiem.Text)
                    Panel1.Visible = True
                    Panel1.Height = 600
                        BindgrdDS(txtId_PhieuXetNghiem.Text)
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                    End If
                'End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally

                objBenhNhan = Nothing
                infBenhNhan = Nothing
                ' grdDSBenhNhan.Visible = False

                ' pnlDetail.Visible = True
            End Try
        End Sub
        Private Sub UpdatePhieuXetNghiem(ByVal sMaBN As String)
            Dim objPhieuXetNghiem As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMController
            Dim infPhieuXetNghiem As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMInfo
            'Thông tin Phiếu xét nghiệm
            Dim dtTuNgay As Date
            Try
                dtTuNgay = CType(NTP_Common.GetValue(Me.txtNgayXN, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                infPhieuXetNghiem.NGAYXN = dtTuNgay
                '  If Me.cboDonVi.SelectedValue <> "" Then
                infPhieuXetNghiem.ID_Benhvien = Me.cboDonVi.Text
                ' End If
                infPhieuXetNghiem.ID_PhanloaiYte = Me.optlistLoaiYTe.SelectedItem.Value
                infPhieuXetNghiem.NGUOI_NM = Me.CurrentUserStock.USERID

                infPhieuXetNghiem.SoXN = Me.txtSoXetNghiem.Text
                infPhieuXetNghiem.LydoXN = optlistLyDo.SelectedItem.Value
                infPhieuXetNghiem.DV_XETNGHIEM = Me.CurrentUserStock.ID_BENHVIEN
                If optlistLyDo.SelectedValue = 1 Then
                    infPhieuXetNghiem.ID_PhanloaiYte = 0
                Else
                    infPhieuXetNghiem.ID_PhanloaiYte = optlistLoaiYTe.SelectedValue
                End If
                infPhieuXetNghiem.Soluong = IIf(Me.txtSoMauDom.Text = "", 0, Me.txtSoMauDom.Text)
                infPhieuXetNghiem.HIV = Me.chkHtest.Checked
                infPhieuXetNghiem.DV_Tiepnhan = CboHuyen.SelectedValue
                'If txtSoThangDT.Text = "" Or txtSoThangDT.Text Is Nothing Then
                ' Else
                infPhieuXetNghiem.SoThangDT = IIf(txtSoThangDT.Text = "", 0, txtSoThangDT.SelectedValue) ' Integer.Parse(Me.txtSoThangDT.Text)
                'End If
                infPhieuXetNghiem.XNVien = TxtMaBNQL.Text
                If txtSoDKDT.Text = "" Or txtSoDKDT.Text Is Nothing Then
                Else
                    infPhieuXetNghiem.SoDKDT = Me.txtSoDKDT.Text
                End If
                infPhieuXetNghiem.ID_Benhnhan = sMaBN
                If txtId_PhieuXetNghiem.Text = "" Or txtId_PhieuXetNghiem.Text Is Nothing Then
                    txtId_PhieuXetNghiem.Text = objPhieuXetNghiem.Add(infPhieuXetNghiem)
                Else
                    infPhieuXetNghiem.ID_Phieuxetnghiem = txtId_PhieuXetNghiem.Text
                    objPhieuXetNghiem.Update(infPhieuXetNghiem)
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                objPhieuXetNghiem = Nothing
                infPhieuXetNghiem = Nothing
            End Try
        End Sub
        Protected Sub CmdNewC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdNewC.Click
            Dim objPhieuXetNghiem_C As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEM_CController
            Dim infPhieuXetNghiem_C As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEM_CInfo
            'Thông tin Phiếu xét nghiệm_C
            Dim dtNgay As Date
            If txtId_PhieuXetNghiem.Text <> "" Then
                UpdatePhieuXetNghiem(txtMaBenhNhan.Text)
                If txtSoXetNghiem.Text = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Số xét nghiệm..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtSoXetNghiem, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf Trim(txtTuNgay.Text) = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Ngày nhận mẫu..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtTuNgay, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date) > DateTime.Now Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Ngày Nhận mẫu không được lớn hơn ngày hiện tại.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtTuNgay, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf cboTrangThaiDom.SelectedValue = "0" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Trạng thái đờm thể..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.cboTrangThaiDom, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf Trim(txtMauDom.Text) = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Mẫu đờm..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtMauDom, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf CInt(txtMauDom.Text) > CInt(txtSoMauDom.Text) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Mẫu đờm không được lớn hơn số lượng mẫu..", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtMauDom, Me.ModuleConfiguration.SupportsPartialRendering)
                Else
                    dtNgay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                    infPhieuXetNghiem_C.NgayNhanMau = dtNgay
                    infPhieuXetNghiem_C.SoXN = txtSoXetNghiem.Text
                    infPhieuXetNghiem_C.TrangthaiDom = Me.cboTrangThaiDom.SelectedValue
                    infPhieuXetNghiem_C.Ketqua = Me.cboKetQua.SelectedValue
                    infPhieuXetNghiem_C.Maudom = Me.txtMauDom.Text
                    infPhieuXetNghiem_C.ID_Phieuxetnghiem = txtId_PhieuXetNghiem.Text
                    If txtId_PhieuXetNghiemC.Text = "" Or txtId_PhieuXetNghiemC.Text Is Nothing Then
                        objPhieuXetNghiem_C.Add(infPhieuXetNghiem_C)
                    Else
                        infPhieuXetNghiem_C.ID_Phieuxetnghiem_C = txtId_PhieuXetNghiemC.Text
                        objPhieuXetNghiem_C.Update(infPhieuXetNghiem_C)
                    End If
                    BindgrdDS(txtId_PhieuXetNghiem.Text)
                    cboTrangThaiDom.SelectedValue = 0
                    cboKetQua.SelectedValue = 0
                    txtTuNgay.Text = ""
                    txtMauDom.Text = ""
                    txtId_PhieuXetNghiemC.Text = ""
                    NTP_Common.SetFormFocus(Me.txtTuNgay, Me.ModuleConfiguration.SupportsPartialRendering)
                End If
            End If
        End Sub
        Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand


            If e.CommandName = "edit" Then
                Try
                    Dim objphieuxetnghiem_ch As New NTP_BN_PHIEUXETNGHIEM_CController
                    Dim infphieuxetnghiem_c As New NTP_BN_PHIEUXETNGHIEM_CInfo
                    infphieuxetnghiem_c = objphieuxetnghiem_ch.Get(e.Item.Cells(2).Text)
                    LoadPhieuXetNghiemC(infphieuxetnghiem_c)
                Catch ex As Exception
                    ProcessModuleLoadException(Me, ex)
                Finally

                End Try
                'Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
            End If
        End Sub
        Protected Sub cmdDeleteC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDeleteC.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_BN_PHIEUXETNGHIEM_CController
            Try
                For Each itm In Me.grdDS.SelectedItems
                    obj.Delete(txtId_PhieuXetNghiem.Text, itm.Cells(2).Text)
                Next
                BindgrdDS(txtId_PhieuXetNghiem.Text)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub LoadPhieuXetNghiemC(ByVal infPhieuXuatC As NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEM_CInfo)
            NTP_Common.SetValue(Me.txtTuNgay, infPhieuXuatC.NgayNhanMau, NTP_Common.enuDATA_TYPE.DATE_TYPE)
            txtMauDom.Text = infPhieuXuatC.Maudom
            cboKetQua.SelectedValue = infPhieuXuatC.Ketqua
            cboTrangThaiDom.SelectedValue = infPhieuXuatC.TrangthaiDom
            txtId_PhieuXetNghiemC.Text = infPhieuXuatC.ID_Phieuxetnghiem_C

        End Sub


        Private Sub BindComboBenhVien()
            'Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENController
            'Dim itm As ListItem
            'Try
            '    itm = New ListItem
            '    itm.Value = Null.NullString
            '    itm.Text = "--- Chọn cơ sở y tế---"
            '    Me.cboDonVi.DataSource = obj.ListNTP_DM_BENHVIEN_BY_VUNG("", 0)
            '    Me.cboDonVi.DataBind()
            '    Me.cboDonVi.Items.Insert(0, itm)
            'Catch ex As Exception
            '    ProcessModuleLoadException(Me, ex)
            'Finally
            '    obj = Nothing
            'End Try
        End Sub
        Private Sub BindComboTinh()
            Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn tỉnh ---"
                Me.CboTinh.DataSource = obj.Search("", 0)
                Me.CboTinh.DataBind()
                Me.CboTinh.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub cboTinh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboTinh.SelectedIndexChanged
            If cboTinh.SelectedValue <> "" Then
                BindComboHuyen(cboTinh.SelectedValue)
                NTP_Common.SetFormFocus(CboHuyen, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        End Sub
        Private Sub BindComboHuyen(ByVal Id_Tinh As String)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"

                Me.CboHuyen.DataSource = obj.ListNTP_DM_BENHVIEN(Id_Tinh)
               
                Me.CboHuyen.DataBind()
                Me.CboHuyen.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        'Protected Sub cboTinh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboTinh.SelectedIndexChanged
        '    If Me.cboTinh.SelectedValue > 0 Then
        '        BindComboHuyen(Me.cboTinh.SelectedValue)
        '        NTP_Common.SetFormFocus(cboHuyen, Me.ModuleConfiguration.SupportsPartialRendering)
        '    End If

        'End Sub
        Protected Sub ResetPhieuXetNghiem()
            txtDiaChi.Text = ""
            txtDienThoai.Text = ""
            txtMaBenhNhan.Text = "" : TxtMaBNQL.Text = ""
            txtSoCMT.Text = ""
            txtSoDKDT.Text = ""
            txtSoXetNghiem.Text = ""
            txtId_PhieuXetNghiem.Text = ""
            txtId_PhieuXetNghiemC.Text = ""
            txtMauDom.Text = ""
            chkHtest.Checked = False
            '  txtNguoiLapPhieu.Text = ""
            txtSoMauDom.Text = ""
            txtSoThangDT.SelectedValue = ""
            txtSoXetNghiem.Text = ""
            txtTenBN.Text = ""
            txtNgayXN.Text = ""
            Me.txtTuNgay.Text = ""
            'SetValue(Me.txtTuNgay, Now, enuDATA_TYPE.DATE_TYPE)
            BindgrdDS("00")
            txtTuoi.Text = ""
            cboDonVi.Text = ""
            'CboHuyen.SelectedValue = ""
            ' cboKetQua.SelectedValue = ""
            ' cboTrangThaiDom.SelectedValue = ""
            'cboVung.SelectedValue = 0
            optlistLyDo.SelectedValue = 0
            optlistGioiTinh.SelectedValue = 1
            optlistLoaiYTe.SelectedValue =0
            Panel1.Visible = False
        End Sub
        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            ResetPhieuXetNghiem()
        End Sub
        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub
        Protected Sub CmdLoadThongtinBN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdLoadThongtinBN.Click

            ' DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Số lượng mẫu..", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)

            Dim obj As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
            Dim inf As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
            inf = obj.ListFind(TxtMaBNQL.Text, "", txtSoCMT.Text, False, "", Me.CurrentUserStock.ID_BENHVIEN)
            If Not inf Is Nothing Then
                LoadBenhNhan(inf)

            End If
            obj = Nothing
            inf = Nothing
        End Sub
        Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
            grdDS.CurrentPageIndex = e.NewPageIndex
            BindgrdDS(txtId_PhieuXetNghiem.Text)
        End Sub
        Protected Sub optlistLyDo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optlistLyDo.SelectedIndexChanged
            If optlistLyDo.SelectedValue = 0 Then
                optlistLoaiYTe.Enabled = True
                optlistLoaiYTe.SelectedValue = 1
                txtSoThangDT.Enabled = False
                txtSoThangDT.SelectedValue = ""
            Else
                optlistLoaiYTe.Enabled = False
                optlistLoaiYTe.SelectedValue = 1
                txtSoThangDT.Enabled = True
            End If
        End Sub
#End Region

    End Class

End Namespace