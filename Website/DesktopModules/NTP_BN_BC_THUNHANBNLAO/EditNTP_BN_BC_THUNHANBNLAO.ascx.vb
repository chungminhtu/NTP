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

Namespace YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_BC_THUNHANBNLAO
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

#End Region
#Region "Event Handlers"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
                End If
                If Not IsPostBack Then
                    If Request.QueryString("id_Tinh") <> "" And (Me.CurrentUserStock.ID_BENHVIEN = "7210" Or Me.CurrentUserStock.ID_BENHVIEN = "3112") Then
                        BindComboHuyen(Request.QueryString("id_Tinh"))
                    Else
                        BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    End If
                    SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
                    Dim obj As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOController
                    Dim inf As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOInfo

                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtId_BCThuNhan.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtId_BCThuNhan.Text)
                        Me.txtNam.Text = inf.Nam
                        SetValue(Me.txtNgayBaoCao, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        ''Me.cboHuyen.SelectedValue = inf.MA_HUYEN
                        Me.cboDonVi.SelectedValue = inf.DVBaocao
                        Me.txtNguoiBaoCao.Text = inf.NguoiBC
                        Me.cboQuy.SelectedValue = inf.Quy
                        BindKetQuaDT(Me.txtId_BCThuNhan.Text)
                        BindLaoHIV(Me.txtId_BCThuNhan.Text)
                        TinhtongP1()
                    Else
                        cmdCreateNew_Click(sender, e)
                    End If
                    NTP_Common.SetFormFocus(Me.cboDonVi, Me.ModuleConfiguration.SupportsPartialRendering)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                'obj = Nothing
                'inf = Nothing
            End Try

        End Sub
        Private Sub BindComboHuyen(ByVal Id_Tinh As String)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.cboDonVi.DataSource = obj.ListNTP_DM_BENHVIEN(Id_Tinh)
                Me.cboDonVi.DataBind()
                Me.cboDonVi.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboBenhVien(ByVal Id_BenhVien As String, ByVal Id_Tinh As String)
            Dim obj As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.cboDonVi.DataSource = obj.GetByBenVien(Id_BenhVien, Id_Tinh)
                Me.cboDonVi.DataBind()
                Me.cboDonVi.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim obj As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOController
            Dim inf As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOInfo
            Dim objBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo

            Try
                TinhtongP1()
                If CInt(IIf(Me.txtMoi1.Text = "", 0, Me.txtMoi1.Text)) > CInt(IIf(Me.txtMoi.Text = "", 0, Me.txtMoi.Text)) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Số BN Có XNHIV không được lớn hơn số BN Lao Thu nhận.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                ElseIf CInt(IIf(Me.txtMoi2.Text = "", 0, Me.txtMoi2.Text)) <> CInt(IIf(TxtNamHIVD.Text = "", 0, TxtNamHIVD.Text)) + CInt(IIf(TxtNuHIVD.Text = "", 0, TxtNuHIVD.Text)) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số BN Có XNHIV(+) ở Phần II không đúng với số BN có XN HIV(+)Mới ở Phần I.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                ElseIf CInt(IIf(Me.txtMoi.Text = "", 0, Me.txtMoi.Text)) <> CInt(LblNam.Text) + CInt(LblNu.Text) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân AFB(+) Mới theo tuổi giới không đúng với số Bệnh nhân Thu nhận.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Else

                    inf.Nam = Me.txtNam.Text
                    Dim dtNgay As Date
                    dtNgay = CType(NTP_Common.GetValue(Me.txtNgayBaoCao, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                    inf.NgayBC = dtNgay
                    'inf.MA_HUYEN = Me.cboHuyen.SelectedValue
                    inf.DVBaocao = Me.cboDonVi.SelectedValue
                    infBenhVien = objBenhVien.Get(inf.DVBaocao)
                    inf.MA_HUYEN = infBenhVien.ID_HUYEN
                    inf.MA_TINH = infBenhVien.ID_MATINH
                    inf.NguoiBC = Me.txtNguoiBaoCao.Text
                    inf.Quy = Me.cboQuy.SelectedValue

                    If txtId_BCThuNhan.Text = "" Or txtId_BCThuNhan.Text Is Nothing Then
                        txtId_BCThuNhan.Text = obj.Add(inf)
                    Else
                        inf.ID_BCThunhanBNLao = txtId_BCThuNhan.Text
                        obj.Update(inf)
                    End If
                    UpdatePhan1(txtId_BCThuNhan.Text)
                    UpdatePhan2(txtId_BCThuNhan.Text)

                    cmdCreateNew.Enabled = True
                    cmdAdd.Enabled = True
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally

            End Try


        End Sub

        Protected Sub UpdatePhan1(ByVal ID_BCThunhan As Integer)
            Dim obj0 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Controller
            Dim inf0 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Info
            Dim obj1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Controller
            Dim inf1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Info
            Dim obj2 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Controller
            Dim inf2 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Info
            Try
                inf0.Phanloai = 0 ' BN LAO thu nhan
                inf0.ID_BCThunhanBNLao = ID_BCThunhan
                inf0.AFBKhac = IIf(Me.txtAFBDuongKhac.Text = "", 0, Me.txtAFBDuongKhac.Text)
                inf0.AmLon = IIf(Me.txt15AFB.Text = "", 0, Me.txt15AFB.Text)
                inf0.AmNho = IIf(Me.txt04AFB.Text = "", 0, Me.txt04AFB.Text)
                inf0.AmTrung = IIf(Me.txt415AFB.Text = "", 0, Me.txt415AFB.Text)
                inf0.Moi = IIf(Me.txtMoi.Text = "", 0, Me.txtMoi.Text)
                inf0.NgoaiphoiKhac = IIf(Me.txtAFBAmLaoNgoaiPhoiKhac.Text = "", 0, Me.txtAFBAmLaoNgoaiPhoiKhac.Text)
                inf0.NgoaiPhoiLon = IIf(txt15NP.Text = "", 0, txt15NP.Text)
                inf0.NgoaiPhoiNho = IIf(txt04NP.Text = "", 0, txt04NP.Text)
                inf0.NgoaiPhoiTrung = IIf(txt514NP.Text = "", 0, txt514NP.Text)
                inf0.Taiphat = IIf(txtTaiPhat.Text = "", 0, txtTaiPhat.Text)
                inf0.Taitri = IIf(txtDTLaiBoTri.Text = "", 0, txtDTLaiBoTri.Text)
                inf0.Thatbai = IIf(txtThatBai.Text = "", 0, txtThatBai.Text)
                '' inf0.Tong = CInt(IIf(txtAFBDuongKhac.Text = "", 0, txtAFBDuongKhac.Text)) + CInt(IIf(txt15AFB.Text = "", 0, txt15AFB.Text)) _
                '                + CInt(IIf(txt04AFB.Text = "", 0, txt04AFB.Text)) _
                '                + CInt(IIf(txt415AFB.Text = "", 0, txt415AFB.Text)) _
                '                + CInt(IIf(txtMoi.Text = "", 0, txtMoi.Text)) _
                '                + CInt(IIf(txtAFBAmLaoNgoaiPhoiKhac.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac.Text)) _
                '                + CInt(IIf(txt15NP.Text = "", 0, txt15NP.Text)) _
                '                + CInt(IIf(txt04NP.Text = "", 0, txt04NP.Text)) _
                '                + CInt(IIf(txt514NP.Text = "", 0, txt514NP.Text)) _
                '                + CInt(IIf(txtTaiPhat.Text = "", 0, txtTaiPhat.Text)) _
                '                + CInt(IIf(txtDTLaiBoTri.Text = "", 0, txtDTLaiBoTri.Text)) _
                '                + CInt(IIf(txtThatBai.Text = "", 0, txtThatBai.Text))

                inf0.ID_BCThunhanBNLao = ID_BCThunhan
                If txtId_LaoHIV.Text = "" Or txtId_LaoHIV.Text Is Nothing Then
                    txtId_LaoHIV.Text = obj0.Add(inf0)
                Else
                    inf0.ID_BCThunhanBNLaoP1 = txtId_LaoHIV.Text
                    obj0.Update(inf0)
                End If

                inf1.Phanloai = 1 ' Co XN HIV
                inf1.ID_BCThunhanBNLao = ID_BCThunhan
                inf1.AFBKhac = IIf(txtAFBDuongKhac1.Text = "", 0, txtAFBDuongKhac1.Text)
                inf1.AmLon = IIf(txt15AFB1.Text = "", 0, txt15AFB1.Text)
                inf1.AmNho = IIf(txt04AFB1.Text = "", 0, txt04AFB1.Text)
                inf1.AmTrung = IIf(txt415AFB1.Text = "", 0, txt415AFB1.Text)
                inf1.Moi = IIf(txtMoi1.Text = "", 0, txtMoi1.Text)
                inf1.NgoaiphoiKhac = IIf(txtAFBAmLaoNgoaiPhoiKhac1.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac1.Text)
                inf1.NgoaiPhoiLon = IIf(txt15NP1.Text = "", 0, txt15NP1.Text)
                inf1.NgoaiPhoiNho = IIf(txt04NP1.Text = "", 0, txt04NP1.Text)
                inf1.NgoaiPhoiTrung = IIf(txt514NP1.Text = "", 0, txt514NP1.Text)
                inf1.Taiphat = IIf(txtTaiPhat1.Text = "", 0, txtTaiPhat1.Text)
                inf1.Taitri = IIf(txtDTLaiBoTri1.Text = "", 0, txtDTLaiBoTri1.Text)
                inf1.Thatbai = IIf(txtThatBai1.Text = "", 0, txtThatBai1.Text)
                ''   inf1.Tong = CInt(IIf(txtAFBDuongKhac1.Text = "", 0, txtAFBDuongKhac1.Text)) + CInt(IIf(txt15AFB1.Text = "", 0, txt15AFB1.Text)) _
                '               + CInt(IIf(txt04AFB1.Text = "", 0, txt04AFB1.Text)) _
                '               + CInt(IIf(txt415AFB1.Text = "", 0, txt415AFB1.Text)) _
                '               + CInt(IIf(txtMoi1.Text = "", 0, txtMoi1.Text)) _
                '               + CInt(IIf(txtAFBAmLaoNgoaiPhoiKhac1.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac1.Text)) _
                '               + CInt(IIf(txt15NP1.Text = "", 0, txt15NP1.Text)) _
                '               + CInt(IIf(txt04NP1.Text = "", 0, txt04NP1.Text)) _
                '               + CInt(IIf(txt514NP1.Text = "", 0, txt514NP1.Text)) _
                '               + CInt(IIf(txtTaiPhat1.Text = "", 0, txtTaiPhat1.Text)) _
                '               + CInt(IIf(txtDTLaiBoTri1.Text = "", 0, txtDTLaiBoTri1.Text)) _
                '               + CInt(IIf(txtThatBai1.Text = "", 0, txtThatBai1.Text))

                inf1.ID_BCThunhanBNLao = ID_BCThunhan
                If txtId_LaoHIV1.Text = "" Or txtId_LaoHIV1.Text Is Nothing Then
                    txtId_LaoHIV1.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BCThunhanBNLaoP1 = txtId_LaoHIV1.Text
                    obj1.Update(inf1)
                End If

                inf2.Phanloai = 2 ' XN HIV(+)
                inf2.ID_BCThunhanBNLao = ID_BCThunhan
                inf2.AFBKhac = IIf(txtAFBDuongKhac2.Text = "", 0, txtAFBDuongKhac2.Text)
                inf2.AmLon = IIf(txt15AFB2.Text = "", 0, txt15AFB2.Text)
                inf2.AmNho = IIf(txt04AFB2.Text = "", 0, txt04AFB2.Text)
                inf2.AmTrung = IIf(txt415AFB2.Text = "", 0, txt415AFB2.Text)
                inf2.Moi = IIf(txtMoi2.Text = "", 0, txtMoi2.Text)
                inf2.NgoaiphoiKhac = IIf(txtAFBAmLaoNgoaiPhoiKhac2.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac2.Text)
                inf2.NgoaiPhoiLon = IIf(txt15NP2.Text = "", 0, txt15NP2.Text)
                inf2.NgoaiPhoiNho = IIf(txt04NP2.Text = "", 0, txt04NP2.Text)
                inf2.NgoaiPhoiTrung = IIf(txt514NP2.Text = "", 0, txt514NP2.Text)
                inf2.Taiphat = IIf(txtTaiPhat2.Text = "", 0, txtTaiPhat2.Text)
                inf2.Taitri = IIf(txtDTLaiBoTri2.Text = "", 0, txtDTLaiBoTri2.Text)
                inf2.Thatbai = IIf(txtThatBai2.Text = "", 0, txtThatBai2.Text)
                inf2.ID_BCThunhanBNLao = ID_BCThunhan
                'inf2.Tong = CInt(IIf(txtAFBDuongKhac2.Text = "", 0, txtAFBDuongKhac2.Text)) + CInt(IIf(txt15AFB2.Text = "", 0, txt15AFB2.Text)) _
                '                            + CInt(IIf(txt04AFB2.Text = "", 0, txt04AFB2.Text)) _
                '                            + CInt(IIf(txt415AFB2.Text = "", 0, txt415AFB2.Text)) _
                '                            + CInt(IIf(txtMoi2.Text = "", 0, txtMoi2.Text)) _
                '                            + CInt(IIf(txtAFBAmLaoNgoaiPhoiKhac2.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac2.Text)) _
                '                            + CInt(IIf(txt15NP2.Text = "", 0, txt15NP2.Text)) _
                '                            + CInt(IIf(txt04NP2.Text = "", 0, txt04NP2.Text)) _
                '                            + CInt(IIf(txt514NP2.Text = "", 0, txt514NP2.Text)) _
                '                            + CInt(IIf(txtTaiPhat2.Text = "", 0, txtTaiPhat2.Text)) _
                '                            + CInt(IIf(txtDTLaiBoTri2.Text = "", 0, txtDTLaiBoTri2.Text)) _
                '                            + CInt(IIf(txtThatBai2.Text = "", 0, txtThatBai2.Text))

                If txtId_LaoHIV2.Text = "" Or txtId_LaoHIV2.Text Is Nothing Then
                    txtId_LaoHIV2.Text = obj2.Add(inf2)
                Else
                    inf2.ID_BCThunhanBNLaoP1 = txtId_LaoHIV2.Text
                    obj2.Update(inf2)
                End If


            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)

            End Try

        End Sub

        Protected Sub UpdatePhan2(ByVal ID_BCThunhan As Integer)
            Dim obj1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Controller
            Dim inf1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Info

            Dim obj2 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Controller
            Dim inf2 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Info
            Try
                inf1.Phanloai = 0 'HIV(-)
                inf1.Nam0 = IIf(txt04Nam.Text = "", 0, txt04Nam.Text)
                inf1.Nam5 = IIf(txt5Nam.Text = "", 0, txt5Nam.Text)
                inf1.Nam15 = IIf(txt15Nam.Text = "", 0, txt15Nam.Text)
                inf1.Nam25 = IIf(txt25nam.Text = "", 0, txt25nam.Text)
                inf1.Nam35 = IIf(txt35Nam.Text = "", 0, txt35Nam.Text)
                inf1.Nam45 = IIf(txt45Nam.Text = "", 0, txt45Nam.Text)
                inf1.Nam55 = IIf(txt55Nam.Text = "", 0, txt55Nam.Text)
                inf1.Nam65 = IIf(txt65Nam.Text = "", 0, txt65Nam.Text)
                inf1.Nu0 = IIf(txt04Nu.Text = "", 0, txt04Nu.Text)
                inf1.Nu5 = IIf(txt5Nu.Text = "", 0, txt5Nu.Text)
                inf1.Nu15 = IIf(txt15Nu.Text = "", 0, txt15Nu.Text)
                inf1.Nu25 = IIf(txt25Nu.Text = "", 0, txt25Nu.Text)
                inf1.Nu35 = IIf(txt35Nu.Text = "", 0, txt35Nu.Text)
                inf1.Nu45 = IIf(txt45Nu.Text = "", 0, txt45Nu.Text)
                inf1.Nu55 = IIf(txt55Nu.Text = "", 0, txt55Nu.Text)
                inf1.Nu65 = IIf(txt65Nu.Text = "", 0, txt65Nu.Text)
                inf1.ID_BCThunhanBNLao = ID_BCThunhan
                If Trim(Me.txtId_LaoPhoiAFB.Text) = "" Or txtId_LaoPhoiAFB.Text Is Nothing Then
                    txtId_LaoPhoiAFB.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BCThunhanBNLaoP2 = Me.txtId_LaoPhoiAFB.Text
                    obj1.Update(inf1)
                End If

                inf2.Phanloai = 1 ' HIV(+)
                inf2.Nam0 = IIf(txt04Nam1.Text = "", 0, txt04Nam1.Text)
                inf2.Nam5 = IIf(txt5Nam1.Text = "", 0, txt5Nam1.Text)
                inf2.Nam15 = IIf(txt15Nam1.Text = "", 0, txt15Nam1.Text)
                inf2.Nam25 = IIf(txt25nam1.Text = "", 0, txt25nam1.Text)
                inf2.Nam35 = IIf(txt35Nam1.Text = "", 0, txt35Nam1.Text)
                inf2.Nam45 = IIf(txt45Nam1.Text = "", 0, txt45Nam1.Text)
                inf2.Nam55 = IIf(txt55Nam1.Text = "", 0, txt55Nam1.Text)
                inf2.Nam65 = IIf(txt65Nam1.Text = "", 0, txt65Nam1.Text)
                inf2.Nu0 = IIf(txt04Nu1.Text = "", 0, txt04Nu1.Text)
                inf2.Nu5 = IIf(txt5Nu1.Text = "", 0, txt5Nu1.Text)
                inf2.Nu15 = IIf(txt15Nu1.Text = "", 0, txt15Nu1.Text)
                inf2.Nu25 = IIf(txt25Nu1.Text = "", 0, txt25Nu1.Text)
                inf2.Nu35 = IIf(txt35Nu1.Text = "", 0, txt35Nu1.Text)
                inf2.Nu45 = IIf(txt45Nu1.Text = "", 0, txt45Nu1.Text)
                inf2.Nu55 = IIf(txt55Nu1.Text = "", 0, txt55Nu1.Text)
                inf2.Nu65 = IIf(txt65Nu1.Text = "", 0, txt65Nu1.Text)
                inf2.ID_BCThunhanBNLao = ID_BCThunhan
                If Me.txtId_LaoPhoiAFB1.Text = "" Or Me.txtId_LaoPhoiAFB1.Text Is Nothing Then
                    Me.txtId_LaoPhoiAFB1.Text = obj2.Add(inf2)
                Else
                    inf2.ID_BCThunhanBNLaoP2 = Me.txtId_LaoPhoiAFB1.Text
                    obj2.Update(inf2)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try


        End Sub



        Protected Sub BindKetQuaDT(ByVal ID_BCThunhanBNLao As Integer)

            Dim obj0 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Controller
            Dim inf0 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Info
            Dim obj1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Controller
            Dim inf1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Info
            Dim obj2 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Controller
            Dim inf2 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP1Info
            Try
                inf0 = obj0.ListTHUNHANBNLAOP1(ID_BCThunhanBNLao, 0)
                If Not inf0 Is Nothing Then
                    Me.txtMoi.Text = inf0.Moi
                    Me.txtTaiPhat.Text = inf0.Taiphat
                    Me.txtThatBai.Text = inf0.Thatbai
                    Me.txtDTLaiBoTri.Text = inf0.Taitri
                    Me.txtAFBDuongKhac.Text = inf0.AFBKhac
                    Me.txt04AFB.Text = inf0.AmNho
                    Me.txt415AFB.Text = inf0.AmTrung
                    Me.txt15AFB.Text = inf0.AmLon
                    Me.txt04NP.Text = inf0.NgoaiPhoiNho
                    Me.txt514NP.Text = inf0.NgoaiPhoiTrung
                    Me.txt15NP.Text = inf0.NgoaiPhoiLon
                    Me.txtAFBAmLaoNgoaiPhoiKhac.Text = inf0.NgoaiphoiKhac
                    Me.txtId_LaoHIV.Text = inf0.ID_BCThunhanBNLaoP1
                    ' LabelTongBNThuNhan.Text = inf0.Tong
                End If
                inf1 = obj1.ListTHUNHANBNLAOP1(ID_BCThunhanBNLao, CInt(1))
                If Not inf1 Is Nothing Then
                    Me.txtMoi1.Text = inf1.Moi
                    Me.txtTaiPhat1.Text = inf1.Taiphat
                    Me.txtThatBai1.Text = inf1.Thatbai
                    Me.txtDTLaiBoTri1.Text = inf1.Taitri
                    Me.txtAFBDuongKhac1.Text = inf1.AFBKhac
                    Me.txt04AFB1.Text = inf1.AmNho
                    Me.txt415AFB1.Text = inf1.AmTrung
                    Me.txt15AFB1.Text = inf1.AmLon
                    Me.txt04NP1.Text = inf1.NgoaiPhoiNho
                    Me.txt514NP1.Text = inf1.NgoaiPhoiTrung
                    Me.txt15NP1.Text = inf1.NgoaiPhoiLon
                    Me.txtAFBAmLaoNgoaiPhoiKhac1.Text = inf1.NgoaiphoiKhac
                    Me.txtId_LaoHIV1.Text = inf1.ID_BCThunhanBNLaoP1
                    '  LabelTongBNXNHIV.Text = inf1.Tong
                End If
                inf2 = obj2.ListTHUNHANBNLAOP1(ID_BCThunhanBNLao, CInt(2))
                If Not inf2 Is Nothing Then
                    Me.txtMoi2.Text = inf2.Moi
                    Me.txtTaiPhat2.Text = inf2.Taiphat
                    Me.txtThatBai2.Text = inf2.Thatbai
                    Me.txtDTLaiBoTri2.Text = inf2.Taitri
                    Me.txtAFBDuongKhac2.Text = inf2.AFBKhac
                    Me.txt04AFB2.Text = inf2.AmNho
                    Me.txt415AFB2.Text = inf2.AmTrung
                    Me.txt15AFB2.Text = inf2.AmLon
                    Me.txt04NP2.Text = inf2.NgoaiPhoiNho
                    Me.txt514NP2.Text = inf2.NgoaiPhoiTrung
                    Me.txt15NP2.Text = inf2.NgoaiPhoiLon
                    Me.txtAFBAmLaoNgoaiPhoiKhac2.Text = inf2.NgoaiphoiKhac
                    Me.txtId_LaoHIV2.Text = inf2.ID_BCThunhanBNLaoP1
                    ' LabelTongHIVDuongtinh.Text = inf2.Tong
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub

        Protected Sub BindLaoHIV(ByVal ID_BCThunhanBNLao As String)
            Try
                Dim obj0 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Controller
                Dim inf0 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Info
                Dim obj1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Controller
                Dim inf1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOP2Info
                inf0 = obj0.ListTHUNHANBNLAOP2(ID_BCThunhanBNLao, 0)
                If (inf0 Is Nothing) = False Then
                    txt04Nam.Text = inf0.Nam0 : txt04Nu.Text = inf0.Nu0
                    txt5Nam.Text = inf0.Nam5 : txt5Nu.Text = inf0.Nu5
                    txt15Nam.Text = inf0.Nam15 : txt15Nu.Text = inf0.Nu15
                    txt25nam.Text = inf0.Nam25 : txt25Nu.Text = inf0.Nu25
                    txt35Nam.Text = inf0.Nam35 : txt35Nu.Text = inf0.Nu35
                    txt45Nam.Text = inf0.Nam45 : txt45Nu.Text = inf0.Nu45
                    txt55Nam.Text = inf0.Nam55 : txt55Nu.Text = inf0.Nu55
                    txt65Nam.Text = inf0.Nam65 : txt65Nu.Text = inf0.Nu65
                    txtId_LaoPhoiAFB.Text = inf0.ID_BCThunhanBNLaoP2
                End If
                inf1 = obj1.ListTHUNHANBNLAOP2(ID_BCThunhanBNLao, 1)
                If (inf1 Is Nothing) = False Then
                    Me.txtId_LaoPhoiAFB1.Text = inf1.ID_BCThunhanBNLaoP2
                    Me.txt04Nam1.Text = inf1.Nam0 : Me.txt04Nu1.Text = inf1.Nu0
                    Me.txt5Nam1.Text = inf1.Nam5 : Me.txt5Nu1.Text = inf1.Nu5
                    Me.txt15Nam1.Text = inf1.Nam15 : Me.txt15Nu1.Text = inf1.Nu15
                    Me.txt25nam1.Text = inf1.Nam25 : Me.txt25Nu1.Text = inf1.Nu25
                    Me.txt35Nam1.Text = inf1.Nam35 : Me.txt35Nu1.Text = inf1.Nu35
                    Me.txt45Nam1.Text = inf1.Nam45 : Me.txt45Nu1.Text = inf1.Nu45
                    Me.txt55Nam1.Text = inf1.Nam55 : Me.txt55Nu1.Text = inf1.Nu55
                    Me.txt65Nam1.Text = inf1.Nam65 : Me.txt65Nu1.Text = inf1.Nu65

                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub




        Protected Sub cboDonVi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDonVi.SelectedIndexChanged
            NTP_Common.SetFormFocus(Me.txtNam, Me.ModuleConfiguration.SupportsPartialRendering)
        End Sub

        'Protected Sub cboPhanLoaiBN_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPhanLoaiBN.SelectedIndexChanged
        '    NTP_Common.SetFormFocus(Me.txtMoi, Me.ModuleConfiguration.SupportsPartialRendering)
        'End Sub

        'Protected Sub cboLoaiBenhNhan1_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLoaiBenhNhan1.SelectedIndexChanged
        '    NTP_Common.SetFormFocus(Me.txt04Nam, Me.ModuleConfiguration.SupportsPartialRendering)
        'End Sub

        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub

        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            Me.txtId_BCThuNhan.Text = ""
            SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
            'Me.txtNguoiBaoCao.Text = ""
            Me.txtNam.Text = Year(Now)
            If Month(Now) >= 1 And Month(Now) <= 3 Then
                Me.cboQuy.SelectedValue = 1
            ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                Me.cboQuy.SelectedValue = 2
            ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                Me.cboQuy.SelectedValue = 3
            ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                Me.cboQuy.SelectedValue = 4
            End If
            Me.cboDonVi.SelectedValue = ""
            ClearDetail()
            cmdCreateNew.Enabled = False
            cmdAdd.Enabled = True
        End Sub
        Private Sub ClearDetail()
            Me.txtMoi.Text = "" : Me.txtTaiPhat.Text = ""
            Me.txtThatBai.Text = "" : Me.txtDTLaiBoTri.Text = ""
            Me.txtAFBDuongKhac.Text = "" : Me.txt04AFB.Text = ""
            Me.txt415AFB.Text = "" : Me.txt15AFB.Text = ""
            Me.txt04NP.Text = "" : Me.txt514NP.Text = ""
            Me.txt15NP.Text = "" : Me.txtAFBAmLaoNgoaiPhoiKhac.Text = ""
            Me.txtId_LaoHIV.Text = "" : Me.txtMoi1.Text = ""
            Me.txtTaiPhat1.Text = "" : Me.txtThatBai1.Text = ""
            Me.txtDTLaiBoTri1.Text = "" : Me.txtAFBDuongKhac1.Text = ""
            Me.txt04AFB1.Text = "" : Me.txt415AFB1.Text = ""
            Me.txt15AFB1.Text = "" : Me.txt04NP1.Text = ""
            Me.txt514NP1.Text = "" : Me.txt15NP1.Text = ""
            Me.txtAFBAmLaoNgoaiPhoiKhac1.Text = ""
            Me.txtId_LaoHIV1.Text = "" : Me.txtMoi2.Text = ""
            Me.txtTaiPhat2.Text = "" : Me.txtThatBai2.Text = ""
            Me.txtDTLaiBoTri2.Text = "" : Me.txtAFBDuongKhac2.Text = ""
            Me.txt04AFB2.Text = "" : Me.txt415AFB2.Text = ""
            Me.txt15AFB2.Text = "" : Me.txt04NP2.Text = ""
            Me.txt514NP2.Text = "" : Me.txt15NP2.Text = ""
            Me.txtAFBAmLaoNgoaiPhoiKhac2.Text = "" : Me.txtId_LaoHIV2.Text = ""
            Me.TxtTongBNThunhan.Text = "" : Me.TxtTongBNXNHIV.Text = "" : Me.TxtTongBNHIV.Text = ""
            txt04Nam.Text = "" : txt04Nu.Text = "" : txt5Nam.Text = "" : txt5Nu.Text = ""
            txt15Nam.Text = "" : txt15Nu.Text = "" : txt25nam.Text = "" : txt25Nu.Text = ""
            txt35Nam.Text = "" : txt35Nu.Text = "" : txt45Nam.Text = "" : txt45Nu.Text = ""
            txt55Nam.Text = "" : txt55Nu.Text = "" : txt65Nam.Text = "" : txt65Nu.Text = ""
            txtId_LaoPhoiAFB.Text = "" : Me.txtId_LaoPhoiAFB1.Text = ""
            Me.txt04Nam1.Text = "" : Me.txt04Nu1.Text = "" : Me.txt5Nam1.Text = ""
            Me.txt5Nu1.Text = "" : Me.txt15Nam1.Text = "" : Me.txt15Nu1.Text = "" : Me.txt25nam1.Text = ""
            Me.txt25Nu1.Text = "" : Me.txt35Nam1.Text = "" : Me.txt35Nu1.Text = "" : Me.txt45Nam1.Text = ""
            Me.txt45Nu1.Text = "" : Me.txt55Nam1.Text = "" : Me.txt55Nu1.Text = "" : Me.txt65Nam1.Text = ""
            Me.txt65Nu1.Text = ""
            Me.TxtNamHIVA.Text = "" : TxtNuHIVA.Text = ""
            Me.TxtNamHIVD.Text = "" : TxtNuHIVD.Text = ""
            LblNu0.Text = 0 : LblNu5.Text = 0
            LblNu15.Text = 0 : LblNu25.Text = 0 : LblNu35.Text = 0 : LblNu45.Text = 0
            LblNu55.Text = 0 : LblNu64.Text = 0 : LblNam0.Text = 0
            LblNam5.Text = 0 : LblNam15.Text = 0 : LblNam25.Text = 0
            LblNam35.Text = 0 : LblNam45.Text = 0 : LblNam55.Text = 0
            LblNam64.Text = 0 : LblNam.Text = 0 : LblNu.Text = 0
            
        End Sub

        Private Sub TinhtongP1()
            TxtTongBNHIV.Text = CInt(IIf(txtAFBDuongKhac2.Text = "", 0, txtAFBDuongKhac2.Text)) + CInt(IIf(txt15AFB2.Text = "", 0, txt15AFB2.Text)) _
                             + CInt(IIf(txt04AFB2.Text = "", 0, txt04AFB2.Text)) _
                             + CInt(IIf(txt415AFB2.Text = "", 0, txt415AFB2.Text)) _
                             + CInt(IIf(txtMoi2.Text = "", 0, txtMoi2.Text)) _
                             + CInt(IIf(txtAFBAmLaoNgoaiPhoiKhac2.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac2.Text)) _
                             + CInt(IIf(txt15NP2.Text = "", 0, txt15NP2.Text)) _
                             + CInt(IIf(txt04NP2.Text = "", 0, txt04NP2.Text)) _
                             + CInt(IIf(txt514NP2.Text = "", 0, txt514NP2.Text)) _
                             + CInt(IIf(txtTaiPhat2.Text = "", 0, txtTaiPhat2.Text)) _
                             + CInt(IIf(txtDTLaiBoTri2.Text = "", 0, txtDTLaiBoTri2.Text)) _
                             + CInt(IIf(txtThatBai2.Text = "", 0, txtThatBai2.Text))
            TxtTongBNXNHIV.Text = CInt(IIf(txtAFBDuongKhac1.Text = "", 0, txtAFBDuongKhac1.Text)) + CInt(IIf(txt15AFB1.Text = "", 0, txt15AFB1.Text)) _
                             + CInt(IIf(txt04AFB1.Text = "", 0, txt04AFB1.Text)) _
                             + CInt(IIf(txt415AFB1.Text = "", 0, txt415AFB1.Text)) _
                             + CInt(IIf(txtMoi1.Text = "", 0, txtMoi1.Text)) _
                             + CInt(IIf(txtAFBAmLaoNgoaiPhoiKhac1.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac1.Text)) _
                             + CInt(IIf(txt15NP1.Text = "", 0, txt15NP1.Text)) _
                             + CInt(IIf(txt04NP1.Text = "", 0, txt04NP1.Text)) _
                             + CInt(IIf(txt514NP1.Text = "", 0, txt514NP1.Text)) _
                             + CInt(IIf(txtTaiPhat1.Text = "", 0, txtTaiPhat1.Text)) _
                             + CInt(IIf(txtDTLaiBoTri1.Text = "", 0, txtDTLaiBoTri1.Text)) _
                             + CInt(IIf(txtThatBai1.Text = "", 0, txtThatBai1.Text))
            TxtTongBNThunhan.Text = CInt(IIf(txtAFBDuongKhac.Text = "", 0, txtAFBDuongKhac.Text)) + CInt(IIf(txt15AFB.Text = "", 0, txt15AFB.Text)) _
                             + CInt(IIf(txt04AFB.Text = "", 0, txt04AFB.Text)) _
                             + CInt(IIf(txt415AFB.Text = "", 0, txt415AFB.Text)) _
                             + CInt(IIf(txtMoi.Text = "", 0, txtMoi.Text)) _
                             + CInt(IIf(txtAFBAmLaoNgoaiPhoiKhac.Text = "", 0, txtAFBAmLaoNgoaiPhoiKhac.Text)) _
                             + CInt(IIf(txt15NP.Text = "", 0, txt15NP.Text)) _
                             + CInt(IIf(txt04NP.Text = "", 0, txt04NP.Text)) _
                             + CInt(IIf(txt514NP.Text = "", 0, txt514NP.Text)) _
                             + CInt(IIf(txtTaiPhat.Text = "", 0, txtTaiPhat.Text)) _
                             + CInt(IIf(txtDTLaiBoTri.Text = "", 0, txtDTLaiBoTri.Text)) _
                             + CInt(IIf(txtThatBai.Text = "", 0, txtThatBai.Text))
            TxtNamHIVD.Text = CInt(IIf(txt04Nam1.Text = "", 0, txt04Nam1.Text)) _
                            + CInt(IIf(txt5Nam1.Text = "", 0, txt5Nam1.Text)) _
                            + CInt(IIf(txt15Nam1.Text = "", 0, txt15Nam1.Text)) _
                            + CInt(IIf(txt25nam1.Text = "", 0, txt25nam1.Text)) _
                           + CInt(IIf(txt35Nam1.Text = "", 0, txt35Nam1.Text)) _
                           + CInt(IIf(txt45Nam1.Text = "", 0, txt45Nam1.Text)) _
                            + CInt(IIf(txt55Nam1.Text = "", 0, txt55Nam1.Text)) _
                            + CInt(IIf(txt65Nam1.Text = "", 0, txt65Nam1.Text))

            TxtNuHIVD.Text = CInt(IIf(txt04Nu1.Text = "", 0, txt04Nu1.Text)) _
                        + CInt(IIf(txt5Nu1.Text = "", 0, txt5Nu1.Text)) _
                       + CInt(IIf(txt15Nu1.Text = "", 0, txt15Nu1.Text)) _
                        + CInt(IIf(txt25Nu1.Text = "", 0, txt25Nu1.Text)) _
                       + CInt(IIf(txt35Nu1.Text = "", 0, txt35Nu1.Text)) _
                       + CInt(IIf(txt45Nu1.Text = "", 0, txt45Nu1.Text)) _
                        + CInt(IIf(txt55Nu1.Text = "", 0, txt55Nu1.Text)) _
                       + CInt(IIf(txt65Nu1.Text = "", 0, txt65Nu1.Text))
            TxtNamHIVA.Text = CInt(IIf(txt04Nam.Text = "", 0, txt04Nam.Text)) _
                        + CInt(IIf(txt5Nam.Text = "", 0, txt5Nam.Text)) _
                        + CInt(IIf(txt15Nam.Text = "", 0, txt15Nam.Text)) _
                        + CInt(IIf(txt25nam.Text = "", 0, txt25nam.Text)) _
                       + CInt(IIf(txt35Nam.Text = "", 0, txt35Nam.Text)) _
                       + CInt(IIf(txt45Nam.Text = "", 0, txt45Nam.Text)) _
                        + CInt(IIf(txt55Nam.Text = "", 0, txt55Nam.Text)) _
                        + CInt(IIf(txt65Nam.Text = "", 0, txt65Nam.Text))
            TxtNuHIVA.Text = CInt(IIf(txt04Nu.Text = "", 0, txt04Nu.Text)) _
                        + CInt(IIf(txt5Nu.Text = "", 0, txt5Nu.Text)) _
                       + CInt(IIf(txt15Nu.Text = "", 0, txt15Nu.Text)) _
                        + CInt(IIf(txt25Nu.Text = "", 0, txt25Nu.Text)) _
                       + CInt(IIf(txt35Nu.Text = "", 0, txt35Nu.Text)) _
                       + CInt(IIf(txt45Nu.Text = "", 0, txt45Nu.Text)) _
                        + CInt(IIf(txt55Nu.Text = "", 0, txt55Nu.Text)) _
                       + CInt(IIf(txt65Nu.Text = "", 0, txt65Nu.Text))
            LblNu0.Text = CInt(IIf(txt04Nu.Text = "", 0, txt04Nu.Text)) + CInt(IIf(txt04Nu1.Text = "", 0, txt04Nu1.Text))
            LblNu5.Text = CInt(IIf(txt5Nu.Text = "", 0, txt5Nu.Text)) + CInt(IIf(txt5Nu1.Text = "", 0, txt5Nu1.Text))
            LblNu15.Text = CInt(IIf(txt15Nu.Text = "", 0, txt15Nu.Text)) + CInt(IIf(txt15Nu1.Text = "", 0, txt15Nu1.Text))
            LblNu25.Text = CInt(IIf(txt25Nu.Text = "", 0, txt25Nu.Text)) + +CInt(IIf(txt25Nu1.Text = "", 0, txt25Nu1.Text))
            LblNu35.Text = CInt(IIf(txt35Nu.Text = "", 0, txt35Nu.Text)) + CInt(IIf(txt35Nu1.Text = "", 0, txt35Nu1.Text))
            LblNu45.Text = CInt(IIf(txt45Nu.Text = "", 0, txt45Nu.Text)) + CInt(IIf(txt45Nu1.Text = "", 0, txt45Nu1.Text))
            LblNu55.Text = CInt(IIf(txt55Nu.Text = "", 0, txt55Nu.Text)) + CInt(IIf(txt55Nu1.Text = "", 0, txt55Nu1.Text))
            LblNu64.Text = CInt(IIf(txt65Nu.Text = "", 0, txt65Nu.Text)) + CInt(IIf(txt65Nu1.Text = "", 0, txt65Nu1.Text))

            LblNam0.Text = CInt(IIf(txt04Nam.Text = "", 0, txt04Nam.Text)) + CInt(IIf(txt04Nam1.Text = "", 0, txt04Nam1.Text))
            LblNam5.Text = CInt(IIf(txt5Nam.Text = "", 0, txt5Nam.Text)) + CInt(IIf(txt5Nam1.Text = "", 0, txt5Nam1.Text))
            LblNam15.Text = CInt(IIf(txt15Nam.Text = "", 0, txt15Nam.Text)) + CInt(IIf(txt15Nam1.Text = "", 0, txt15Nam1.Text))
            LblNam25.Text = CInt(IIf(txt25nam.Text = "", 0, txt25nam.Text)) + +CInt(IIf(txt25nam1.Text = "", 0, txt25nam1.Text))
            LblNam35.Text = CInt(IIf(txt35Nam.Text = "", 0, txt35Nam.Text)) + CInt(IIf(txt35Nam1.Text = "", 0, txt35Nam1.Text))
            LblNam45.Text = CInt(IIf(txt45Nam.Text = "", 0, txt45Nam.Text)) + CInt(IIf(txt45Nam1.Text = "", 0, txt45Nam1.Text))
            LblNam55.Text = CInt(IIf(txt55Nam.Text = "", 0, txt55Nam.Text)) + CInt(IIf(txt55Nam1.Text = "", 0, txt55Nam1.Text))
            LblNam64.Text = CInt(IIf(txt65Nam.Text = "", 0, txt65Nam.Text)) + CInt(IIf(txt65Nam1.Text = "", 0, txt65Nam1.Text))
            LblNam.Text = CInt(IIf(TxtNamHIVA.Text = "", 0, TxtNamHIVA.Text)) + CInt(IIf(TxtNamHIVD.Text = "", 0, TxtNamHIVD.Text))
            LblNu.Text = CInt(IIf(TxtNuHIVA.Text = "", 0, TxtNuHIVA.Text)) + CInt(IIf(TxtNuHIVD.Text = "", 0, TxtNuHIVD.Text))
        End Sub



        Protected Sub CmdXem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXem.Click
            Dim obj As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOController
            Dim inf As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOInfo
            Dim obj1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOController
            Dim inf1 As New NTP_BN_BC_THUNHANBNLAO.NTP_BN_BC_THUNHANBNLAOInfo
            Try

                If txtNam.Text <> "" And cboDonVi.SelectedValue <> "" Then
                    inf1 = obj.GET_ID_BAOCAO(cboQuy.SelectedValue, txtNam.Text, cboDonVi.SelectedValue)

                    If Not inf1 Is Nothing Then
                        Me.txtId_BCThuNhan.Text = inf1.ID_BCThunhanBNLao
                        inf = obj.Get(Me.txtId_BCThuNhan.Text)
                        Me.txtNam.Text = inf.Nam
                        SetValue(Me.txtNgayBaoCao, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        ''Me.cboHuyen.SelectedValue = inf.MA_HUYEN
                        Me.cboDonVi.SelectedValue = inf.DVBaocao
                        Me.txtNguoiBaoCao.Text = inf.NguoiBC
                        Me.cboQuy.SelectedValue = inf.Quy
                        ClearDetail()
                        BindKetQuaDT(Me.txtId_BCThuNhan.Text)
                        BindLaoHIV(Me.txtId_BCThuNhan.Text)
                        TinhtongP1()
                    Else
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Không có số liệu. ", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
                    End If
                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
                inf = Nothing
                obj1 = Nothing
                inf1 = Nothing
            End Try
        End Sub
#End Region
    End Class

End Namespace