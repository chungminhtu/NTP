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
Imports System.Web.Script
Imports NTP_Common.mdlGlobal
Namespace YourCompany.Modules.NTP_BN_BC_KETQUADT

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_BC_KETQUADT
        Inherits Entities.Modules.PortalModuleBase
        
    
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
                End If
                Dim sm As System.Web.UI.ScriptManager = ScriptManager.GetCurrent(Control.Page)

                If Not IsPostBack Then
                    Me.txtNam.Text = Year(Now) - 1
                    If Request.QueryString("id_Tinh") <> "" And (Me.CurrentUserStock.ID_BENHVIEN = "7210" Or Me.CurrentUserStock.ID_BENHVIEN = "3112") Then
                        BindComboHuyen(Request.QueryString("id_Tinh"))
                    Else
                        BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    End If
                    'cboLaoHIV.SelectedValue = Me.CurrentUserStock.ID_BENHVIEN
                    SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
                    Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
                    Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTInfo

                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtId_BCKetQuaDT.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtId_BCKetQuaDT.Text)
                        Me.txtNam.Text = inf.Nam
                        SetValue(Me.txtNgayBaoCao, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        Me.txtNguoiBaoCao.Text = inf.NguoiBC
                        Me.cboQuy.SelectedValue = inf.Quy
                        Me.cboDonVi.SelectedValue = inf.DVBaocao
                        BindKetQuaDT(Me.txtId_BCKetQuaDT.Text)
                        Panel1.Enabled = False
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

        Protected Sub BindKetQuaDT(ByVal ID_BCKetquaDT As Integer)
            Try
                BindKetQuaDT1(ID_BCKetquaDT, 1)
                BindKetQuaDT2(ID_BCKetquaDT, 2)
                BindKetQuaDT3(ID_BCKetquaDT, 3)
                BindKetQuaDT4(ID_BCKetquaDT, 4)
                BindKetQuaDT5(ID_BCKetquaDT, 5)
                BindKetQuaDT6(ID_BCKetquaDT, 6)
                BindKetQuaDT7(ID_BCKetquaDT, 7)
                BindKetQuaDT8(ID_BCKetquaDT, 8)
                BindKetQuaDT9(ID_BCKetquaDT, 9)
                BindKetQuaDT10(ID_BCKetquaDT, 10)
                BindKetQuaDTP21(ID_BCKetquaDT, 0)
                BindKetQuaDTP22(ID_BCKetquaDT, 1)
                Tinhtong()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT1(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.txtKhoi.Text = IIf(inf.Khoi = 0, "", inf.Khoi)
                    Me.txtHoanThanh.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.txtChet.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK.Text = inf.tongsoBNDK
                    Me.txtId_KetQuaDT.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT2(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.TxtKhoi1.Text = IIf(inf.Khoi = 0, "", inf.Khoi)
                    Me.TxtHoanThanh1.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.TxtThatbai1.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.TxtBo1.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet1.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.TxtChuyen1.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.TxtKhongDanhGia1.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.txtId_KetQuaDT1.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                    Me.TxtTONGBNDK1.Text = inf.tongsoBNDK
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT3(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.txtKhoi2.Text = IIf(inf.Khoi = 0, "", inf.Khoi)
                    Me.TxtHoanThanh2.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai2.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo2.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet2.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen2.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia2.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK2.Text = inf.tongsoBNDK
                    Me.txtId_KetQuaDT2.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT4(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.txtKhoi3.Text = IIf(inf.Khoi = 0, "", inf.Khoi)
                    Me.TxtHoanThanh3.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai3.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo3.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet3.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen3.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia3.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK3.Text = inf.tongsoBNDK
                    Me.txtId_KetQuaDT3.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT5(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.txtKhoi4.Text = IIf(inf.Khoi = 0, "", inf.Khoi)
                    Me.TxtHoanThanh4.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai4.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo4.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet4.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen4.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia4.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK4.Text = inf.tongsoBNDK
                    Me.txtId_KetQuaDT4.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT6(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.TxtHoanThanh5.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai5.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo5.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet5.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen5.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia5.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK5.Text = inf.tongsoBNDK
                    Me.txtId_KetQuaDT5.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT7(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.TxtHoanThanh6.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai6.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo6.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet6.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen6.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia6.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK6.Text = inf.tongsoBNDK
                    Me.txtId_KetQuaDT6.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT8(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.TxtHoanThanh7.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai7.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo7.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet7.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen7.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia7.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK7.Text = inf.tongsoBNDK
                    Me.txtId_KetQuaDT7.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT9(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.txtKhoi8.Text = IIf(inf.Khoi = 0, "", inf.Khoi)
                    Me.TxtHoanThanh8.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai8.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo8.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet8.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen8.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia8.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK8.Text = inf.SoBNDK
                    Me.txtId_KetQuaDT8.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDT10(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf = obj.ListKETQUADTP1(ID, Phanloai, cboDonVi.SelectedValue, cboQuy.SelectedValue, txtNam.Text)
                If Not inf Is Nothing Then
                    Me.txtKhoi9.Text = IIf(inf.Khoi = 0, "", inf.Khoi)
                    Me.TxtHoanThanh9.Text = IIf(inf.Hoanthanh = 0, "", inf.Hoanthanh)
                    Me.txtThatBai9.Text = IIf(inf.Thatbai = 0, "", inf.Thatbai)
                    Me.txtBo9.Text = IIf(inf.Bo = 0, "", inf.Bo)
                    Me.TxtChet9.Text = IIf(inf.Chet = 0, "", inf.Chet)
                    Me.txtChuyen9.Text = IIf(inf.Chuyen = 0, "", inf.Chuyen)
                    Me.txtKhongDanhGia9.Text = IIf(inf.Khongdanhgia = 0, "", inf.Khongdanhgia)
                    Me.TxtTONGBNDK9.Text = inf.SoBNDK
                    Me.txtId_KetQuaDT9.Text = IIf(inf.ID_BC_KetquaDTP1 = 0, "", inf.ID_BC_KetquaDTP1)

                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Private Sub Tinhtong()
            TxtTong.Text = CInt(IIf(txtBo.Text = "", 0, txtBo.Text)) + CInt(IIf(txtChet.Text = "", 0, txtChet.Text)) + CInt(IIf(txtChuyen.Text = "", 0, txtChuyen.Text)) + CInt(IIf(txtHoanThanh.Text = "", 0, txtHoanThanh.Text)) + CInt(IIf(txtKhoi.Text = "", 0, txtKhoi.Text)) + CInt(IIf(txtKhongDanhGia.Text = "", 0, txtKhongDanhGia.Text)) + CInt(IIf(txtThatBai.Text = "", 0, txtThatBai.Text))
            TxtTong1.Text = CInt(IIf(TxtBo1.Text = "", 0, TxtBo1.Text)) + CInt(IIf(TxtChet1.Text = "", 0, TxtChet1.Text)) + CInt(IIf(TxtChuyen1.Text = "", 0, TxtChuyen1.Text)) + CInt(IIf(TxtHoanThanh1.Text = "", 0, TxtHoanThanh1.Text)) + CInt(IIf(TxtKhoi1.Text = "", 0, TxtKhoi1.Text)) + CInt(IIf(TxtKhongDanhGia1.Text = "", 0, TxtKhongDanhGia1.Text)) + CInt(IIf(TxtThatbai1.Text = "", 0, TxtThatbai1.Text))
            TxtTong2.Text = CInt(IIf(txtBo2.Text = "", 0, txtBo2.Text)) + CInt(IIf(TxtChet2.Text = "", 0, TxtChet2.Text)) + CInt(IIf(txtChuyen2.Text = "", 0, txtChuyen2.Text)) + CInt(IIf(TxtHoanThanh2.Text = "", 0, TxtHoanThanh2.Text)) + CInt(IIf(txtKhoi2.Text = "", 0, txtKhoi2.Text)) + CInt(IIf(txtKhongDanhGia2.Text = "", 0, txtKhongDanhGia2.Text)) + CInt(IIf(txtThatBai2.Text = "", 0, txtThatBai2.Text))
            TxtTong3.Text = CInt(IIf(txtBo3.Text = "", 0, txtBo3.Text)) + CInt(IIf(TxtChet3.Text = "", 0, TxtChet3.Text)) + CInt(IIf(txtChuyen3.Text = "", 0, txtChuyen3.Text)) + CInt(IIf(TxtHoanThanh3.Text = "", 0, TxtHoanThanh3.Text)) + CInt(IIf(txtKhoi3.Text = "", 0, txtKhoi3.Text)) + CInt(IIf(txtKhongDanhGia3.Text = "", 0, txtKhongDanhGia3.Text)) + CInt(IIf(txtThatBai3.Text = "", 0, txtThatBai3.Text))
            TxtTong4.Text = CInt(IIf(txtBo4.Text = "", 0, txtBo4.Text)) + CInt(IIf(TxtChet4.Text = "", 0, TxtChet4.Text)) + CInt(IIf(txtChuyen4.Text = "", 0, txtChuyen4.Text)) + CInt(IIf(TxtHoanThanh4.Text = "", 0, TxtHoanThanh4.Text)) + CInt(IIf(txtKhoi4.Text = "", 0, txtKhoi4.Text)) + CInt(IIf(txtKhongDanhGia4.Text = "", 0, txtKhongDanhGia4.Text)) + CInt(IIf(txtThatBai4.Text = "", 0, txtThatBai4.Text))
            TxtTong5.Text = CInt(IIf(txtBo5.Text = "", 0, txtBo5.Text)) + CInt(IIf(TxtChet5.Text = "", 0, TxtChet5.Text)) + CInt(IIf(txtChuyen5.Text = "", 0, txtChuyen5.Text)) + CInt(IIf(TxtHoanThanh5.Text = "", 0, TxtHoanThanh5.Text)) + CInt(IIf(txtKhongDanhGia5.Text = "", 0, txtKhongDanhGia5.Text)) + CInt(IIf(txtThatBai5.Text = "", 0, txtThatBai5.Text))
            TxtTong6.Text = CInt(IIf(txtBo6.Text = "", 0, txtBo6.Text)) + CInt(IIf(TxtChet6.Text = "", 0, TxtChet6.Text)) + CInt(IIf(txtChuyen6.Text = "", 0, txtChuyen6.Text)) + CInt(IIf(TxtHoanThanh6.Text = "", 0, TxtHoanThanh6.Text)) + CInt(IIf(txtKhongDanhGia6.Text = "", 0, txtKhongDanhGia6.Text)) + CInt(IIf(txtThatBai6.Text = "", 0, txtThatBai6.Text))
            TxtTong7.Text = CInt(IIf(txtBo7.Text = "", 0, txtBo7.Text)) + CInt(IIf(TxtChet7.Text = "", 0, TxtChet7.Text)) + CInt(IIf(txtChuyen7.Text = "", 0, txtChuyen7.Text)) + CInt(IIf(TxtHoanThanh7.Text = "", 0, TxtHoanThanh7.Text)) + CInt(IIf(txtKhongDanhGia7.Text = "", 0, txtKhongDanhGia7.Text)) + CInt(IIf(txtThatBai7.Text = "", 0, txtThatBai7.Text))
            TxtTONGBNDK8.Text = CInt(IIf(txtBo8.Text = "", 0, txtBo8.Text)) + CInt(IIf(TxtChet8.Text = "", 0, TxtChet8.Text)) + CInt(IIf(txtChuyen8.Text = "", 0, txtChuyen8.Text)) + CInt(IIf(TxtHoanThanh8.Text = "", 0, TxtHoanThanh8.Text)) + CInt(IIf(txtKhoi8.Text = "", 0, txtKhoi8.Text)) + CInt(IIf(txtKhongDanhGia8.Text = "", 0, txtKhongDanhGia8.Text)) + CInt(IIf(txtThatBai8.Text = "", 0, txtThatBai8.Text))
            TxtTONGBNDK9.Text = CInt(IIf(txtBo9.Text = "", 0, txtBo9.Text)) + CInt(IIf(TxtChet9.Text = "", 0, TxtChet9.Text)) + CInt(IIf(txtChuyen9.Text = "", 0, txtChuyen9.Text)) + CInt(IIf(TxtHoanThanh9.Text = "", 0, TxtHoanThanh9.Text)) + CInt(IIf(txtKhoi9.Text = "", 0, txtKhoi9.Text)) + CInt(IIf(txtKhongDanhGia9.Text = "", 0, txtKhongDanhGia9.Text)) + CInt(IIf(txtThatBai9.Text = "", 0, txtThatBai9.Text))
            LblTongcongBNDK.Text = CInt(IIf(TxtTONGBNDK.Text = "", 0, TxtTONGBNDK.Text)) + CInt(IIf(TxtTONGBNDK1.Text = "", 0, TxtTONGBNDK1.Text)) + CInt(IIf(TxtTONGBNDK2.Text = "", 0, TxtTONGBNDK2.Text)) + CInt(IIf(TxtTONGBNDK3.Text = "", 0, TxtTONGBNDK3.Text)) + CInt(IIf(TxtTONGBNDK4.Text = "", 0, TxtTONGBNDK4.Text)) + CInt(IIf(TxtTONGBNDK5.Text = "", 0, TxtTONGBNDK5.Text)) + CInt(IIf(TxtTONGBNDK6.Text = "", 0, TxtTONGBNDK6.Text)) + CInt(IIf(TxtTONGBNDK7.Text = "", 0, TxtTONGBNDK7.Text))
            LblTongcongKhoi.Text = CInt(IIf(txtKhoi.Text = "", 0, txtKhoi.Text)) + CInt(IIf(TxtKhoi1.Text = "", 0, TxtKhoi1.Text)) + CInt(IIf(txtKhoi2.Text = "", 0, txtKhoi2.Text)) + CInt(IIf(txtKhoi3.Text = "", 0, txtKhoi3.Text)) + CInt(IIf(txtKhoi4.Text = "", 0, txtKhoi4.Text))
            LblTongcongBo.Text = CInt(IIf(txtBo.Text = "", 0, txtBo.Text)) + CInt(IIf(TxtBo1.Text = "", 0, TxtBo1.Text)) + CInt(IIf(txtBo2.Text = "", 0, txtBo2.Text)) + CInt(IIf(txtBo3.Text = "", 0, txtBo3.Text)) + CInt(IIf(txtBo4.Text = "", 0, txtBo4.Text)) + CInt(IIf(txtBo5.Text = "", 0, txtBo5.Text)) + CInt(IIf(txtBo6.Text = "", 0, txtBo6.Text)) + CInt(IIf(txtBo7.Text = "", 0, txtBo7.Text))
            LblTongcongThatbai.Text = CInt(IIf(txtThatBai.Text = "", 0, txtThatBai.Text)) + CInt(IIf(TxtThatbai1.Text = "", 0, TxtThatbai1.Text)) + CInt(IIf(txtThatBai2.Text = "", 0, txtThatBai2.Text)) + CInt(IIf(txtThatBai3.Text = "", 0, txtThatBai3.Text)) + CInt(IIf(txtThatBai4.Text = "", 0, txtThatBai4.Text)) + CInt(IIf(txtThatBai5.Text = "", 0, txtThatBai5.Text)) + CInt(IIf(txtThatBai6.Text = "", 0, txtThatBai6.Text)) + CInt(IIf(txtThatBai7.Text = "", 0, txtThatBai7.Text))
            LblTongcongHT.Text = CInt(IIf(txtHoanThanh.Text = "", 0, txtHoanThanh.Text)) + CInt(IIf(TxtHoanThanh1.Text = "", 0, TxtHoanThanh1.Text)) + CInt(IIf(TxtHoanThanh2.Text = "", 0, TxtHoanThanh2.Text)) + CInt(IIf(TxtHoanThanh3.Text = "", 0, TxtHoanThanh3.Text)) + CInt(IIf(TxtHoanThanh4.Text = "", 0, TxtHoanThanh4.Text)) + CInt(IIf(TxtHoanThanh5.Text = "", 0, TxtHoanThanh5.Text)) + CInt(IIf(TxtHoanThanh6.Text = "", 0, TxtHoanThanh6.Text)) + CInt(IIf(TxtHoanThanh7.Text = "", 0, TxtHoanThanh7.Text))
            LblTongcongChet.Text = CInt(IIf(txtChet.Text = "", 0, txtChet.Text)) + CInt(IIf(TxtChet1.Text = "", 0, TxtChet1.Text)) + CInt(IIf(TxtChet2.Text = "", 0, TxtChet2.Text)) + CInt(IIf(TxtChet3.Text = "", 0, TxtChet3.Text)) + CInt(IIf(TxtChet4.Text = "", 0, TxtChet4.Text)) + CInt(IIf(TxtChet5.Text = "", 0, TxtChet5.Text)) + CInt(IIf(TxtChet6.Text = "", 0, TxtChet6.Text)) + CInt(IIf(TxtChet7.Text = "", 0, TxtChet7.Text))
            LblTongcongChuyen.Text = CInt(IIf(txtChuyen.Text = "", 0, txtChuyen.Text)) + CInt(IIf(TxtChuyen1.Text = "", 0, TxtChuyen1.Text)) + CInt(IIf(txtChuyen2.Text = "", 0, txtChuyen2.Text)) + CInt(IIf(txtChuyen3.Text = "", 0, txtChuyen3.Text)) + CInt(IIf(txtChuyen4.Text = "", 0, txtChuyen4.Text)) + CInt(IIf(txtChuyen5.Text = "", 0, txtChuyen5.Text)) + CInt(IIf(txtChuyen6.Text = "", 0, txtChuyen6.Text)) + CInt(IIf(txtChuyen7.Text = "", 0, txtChuyen7.Text))
            LblTongcongKdanhgia.Text = CInt(IIf(txtKhongDanhGia.Text = "", 0, txtKhongDanhGia.Text)) + CInt(IIf(TxtKhongDanhGia1.Text = "", 0, TxtKhongDanhGia1.Text)) + CInt(IIf(txtKhongDanhGia2.Text = "", 0, txtKhongDanhGia2.Text)) + CInt(IIf(txtKhongDanhGia3.Text = "", 0, txtKhongDanhGia3.Text)) + CInt(IIf(txtKhongDanhGia4.Text = "", 0, txtKhongDanhGia4.Text)) + CInt(IIf(txtKhongDanhGia5.Text = "", 0, txtKhongDanhGia5.Text)) + CInt(IIf(txtKhongDanhGia6.Text = "", 0, txtKhongDanhGia6.Text)) + CInt(IIf(txtKhongDanhGia7.Text = "", 0, txtKhongDanhGia7.Text))
            LblTongcong.Text = CInt(IIf(TxtTong.Text = "", 0, TxtTong.Text)) + CInt(IIf(TxtTong1.Text = "", 0, TxtTong1.Text)) + CInt(IIf(TxtTong2.Text = "", 0, TxtTong2.Text)) + CInt(IIf(TxtTong3.Text = "", 0, TxtTong3.Text)) + CInt(IIf(TxtTong4.Text = "", 0, TxtTong4.Text)) + CInt(IIf(TxtTong5.Text = "", 0, TxtTong5.Text)) + CInt(IIf(TxtTong6.Text = "", 0, TxtTong6.Text)) + CInt(IIf(TxtTong7.Text = "", 0, TxtTong7.Text))


        End Sub
        Protected Sub BindKetQuaDTP21(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Controller
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Info
            Try
                inf = obj.ListKETQUADTP2(ID, Phanloai)
                If Not inf Is Nothing Then
                    Me.txtLaoHIV.Text = inf.XNHIV
                    Me.txtLaoHIVD.Text = inf.DuongHIV
                    Me.txtDieuTriCPT.Text = inf.CPT
                    Me.txtDieuTriARV.Text = inf.ARV
                    Me.txtId_LaoHIV.Text = inf.ID_BC_KetquaDT_P2
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub BindKetQuaDTP22(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Controller
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Info
            Try
                inf = obj.ListKETQUADTP2(ID, Phanloai)
                If Not inf Is Nothing Then
                    Me.txtLaoHIV1.Text = inf.XNHIV
                    Me.txtLaoHIVD1.Text = inf.DuongHIV
                    Me.txtDieuTriCPT1.Text = inf.CPT
                    Me.txtDieuTriARV1.Text = inf.ARV
                    Me.txtId_LaoHIV1.Text = inf.ID_BC_KetquaDT_P2
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
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
        Function KTKetQuaDT() As Boolean
            If CInt(IIf(TxtTONGBNDK.Text = "", 0, TxtTONGBNDK.Text)) <> CInt(IIf(TxtTong.Text = "", 0, TxtTong.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân Lao phổi AFB(+) Mới không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False
            ElseIf CInt(IIf(TxtTONGBNDK1.Text = "", 0, TxtTONGBNDK1.Text)) <> CInt(IIf(TxtTong1.Text = "", 0, TxtTong1.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân Lao phổi AFB(+) Tái phát không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong1, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False
            ElseIf CInt(IIf(TxtTONGBNDK2.Text = "", 0, TxtTONGBNDK2.Text)) <> CInt(IIf(TxtTong2.Text = "", 0, TxtTong2.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân Lao phổi AFB(+) Thất bại không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong2, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False
            ElseIf CInt(IIf(TxtTONGBNDK3.Text = "", 0, TxtTONGBNDK3.Text)) <> CInt(IIf(TxtTong3.Text = "", 0, TxtTong3.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân Lao phổi AFB(+) ĐT lại sau bỏ trị không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong3, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False
            ElseIf CInt(IIf(TxtTONGBNDK4.Text = "", 0, TxtTONGBNDK4.Text)) <> CInt(IIf(TxtTong4.Text = "", 0, TxtTong4.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân Lao phổi AFB(+) Khác không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong4, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False
            ElseIf CInt(IIf(TxtTONGBNDK5.Text = "", 0, TxtTONGBNDK5.Text)) <> CInt(IIf(TxtTong5.Text = "", 0, TxtTong5.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân Lao phổi AFB(-) Mới không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong5, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False
            ElseIf CInt(IIf(TxtTONGBNDK6.Text = "", 0, TxtTONGBNDK6.Text)) <> CInt(IIf(TxtTong6.Text = "", 0, TxtTong6.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân Lao ngoài phổi Mới không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong6, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False
            ElseIf CInt(IIf(TxtTONGBNDK7.Text = "", 0, TxtTONGBNDK7.Text)) <> CInt(IIf(TxtTong7.Text = "", 0, TxtTong7.Text)) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân AFB(-), Lao ngoài phổi khác không đúng với số Bệnh nhân ĐK trong quý", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                NTP_Common.SetFormFocus(Me.TxtTong7, Me.ModuleConfiguration.SupportsPartialRendering)
                Return False

            End If
            Return True
        End Function
        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTInfo
            Dim objBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo

            Try
                Tinhtong()
                If KTKetQuaDT() = False Then
                    Exit Sub
                End If
                If CInt(IIf(Me.LblTongcong.Text = "", 0, Me.LblTongcong.Text)) <> CInt(LblTongcongBNDK.Text) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số Bệnh nhân nhập kết quả ĐT không đúng với số Bệnh nhân Thu nhận", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                ElseIf CInt(IIf(Me.txtLaoHIVD.Text = "", 0, Me.txtLaoHIVD.Text)) <> CInt(TxtTONGBNDK8.Text) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số BN lao XN HIV(+) - Phần 3 phải bằng Tổng số BNĐK trong quý có HIV(+) các thể - Phần 2 ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtLaoHIVD, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf CInt(IIf(Me.txtLaoHIVD1.Text = "", 0, Me.txtLaoHIVD1.Text)) <> CInt(TxtTONGBNDK9.Text) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Số BN lao phổi AFB(+) Mới XN HIV(+) - Phần 3 phải bằng Tổng số Lao phổi AFB(+)Mới đăng ký trong quý có HIV(+) - Phần 2 ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.txtLaoHIVD1, Me.ModuleConfiguration.SupportsPartialRendering)
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
                    If txtId_BCKetQuaDT.Text = "" Or txtId_BCKetQuaDT.Text Is Nothing Then
                        txtId_BCKetQuaDT.Text = obj.Add(inf)
                    Else
                        inf.ID_BC_KetquaDT = txtId_BCKetQuaDT.Text
                        obj.Update(inf)
                    End If
                    UpdateKetQuaDT(txtId_BCKetQuaDT.Text)
                    cmdCreateNew.Enabled = True
                    cmdAdd.Enabled = True
                    Panel1.Enabled = False
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
            End Try


        End Sub
        Protected Sub UpdateKetQuaDT(ByVal ID_BCKetquaDT As Integer)
            Try
                UpdateKQDT(ID_BCKetquaDT, 1)
                UpdateKQDT1(ID_BCKetquaDT, 2)
                UpdateKQDT2(ID_BCKetquaDT, 3)
                UpdateKQDT3(ID_BCKetquaDT, 4)
                UpdateKQDT4(ID_BCKetquaDT, 5)
                UpdateKQDT5(ID_BCKetquaDT, 6)
                UpdateKQDT6(ID_BCKetquaDT, 7)
                UpdateKQDT7(ID_BCKetquaDT, 8)
                UpdateKQDT8(ID_BCKetquaDT, 9)
                UpdateKQDT9(ID_BCKetquaDT, 10)
                UpdateBCHDDT1(ID_BCKetquaDT, 0)
                UpdateBCHDDT2(ID_BCKetquaDT, 1)

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Private Sub UpdateKQDT(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo.Text = "", 0, txtBo.Text)
                inf1.Chet = IIf(txtChet.Text = "", 0, txtChet.Text)
                inf1.Chuyen = IIf(txtChuyen.Text = "", 0, txtChuyen.Text)
                inf1.Hoanthanh = IIf(txtHoanThanh.Text = "", 0, txtHoanThanh.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = IIf(txtKhoi.Text = "", 0, txtKhoi.Text)
                inf1.Khongdanhgia = IIf(txtKhongDanhGia.Text = "", 0, txtKhongDanhGia.Text)
                inf1.Thatbai = IIf(txtThatBai.Text = "", 0, txtThatBai.Text)
                inf1.SoBNDK = CInt(IIf(txtBo.Text = "", 0, txtBo.Text)) + CInt(IIf(txtChet.Text = "", 0, txtChet.Text)) + CInt(IIf(txtChuyen.Text = "", 0, txtChuyen.Text)) + CInt(IIf(txtHoanThanh.Text = "", 0, txtHoanThanh.Text)) + CInt(IIf(txtKhoi.Text = "", 0, txtKhoi.Text)) + CInt(IIf(txtKhongDanhGia.Text = "", 0, txtKhongDanhGia.Text)) + CInt(IIf(txtThatBai.Text = "", 0, txtThatBai.Text))
                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT.Text = "" Or txtId_KetQuaDT.Text Is Nothing Then
                    txtId_KetQuaDT.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT1(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(TxtBo1.Text = "", 0, TxtBo1.Text)
                inf1.Chet = IIf(TxtChet1.Text = "", 0, TxtChet1.Text)
                inf1.Chuyen = IIf(TxtChuyen1.Text = "", 0, TxtChuyen1.Text)
                inf1.Hoanthanh = IIf(TxtHoanThanh1.Text = "", 0, TxtHoanThanh1.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = IIf(TxtKhoi1.Text = "", 0, TxtKhoi1.Text)
                inf1.Khongdanhgia = IIf(TxtKhongDanhGia1.Text = "", 0, TxtKhongDanhGia1.Text)
                inf1.Thatbai = IIf(TxtThatbai1.Text = "", 0, TxtThatbai1.Text)
                inf1.SoBNDK = CInt(IIf(TxtBo1.Text = "", 0, TxtBo1.Text)) + CInt(IIf(TxtChet1.Text = "", 0, TxtChet1.Text)) + CInt(IIf(TxtChuyen1.Text = "", 0, TxtChuyen1.Text)) + CInt(IIf(TxtHoanThanh1.Text = "", 0, TxtHoanThanh1.Text)) + CInt(IIf(TxtKhoi1.Text = "", 0, TxtKhoi1.Text)) + CInt(IIf(TxtKhongDanhGia1.Text = "", 0, TxtKhongDanhGia1.Text)) + CInt(IIf(TxtThatbai1.Text = "", 0, TxtThatbai1.Text))
                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT1.Text = "" Or txtId_KetQuaDT1.Text Is Nothing Then
                    txtId_KetQuaDT1.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT1.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub


        Private Sub UpdateKQDT2(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo2.Text = "", 0, txtBo2.Text)
                inf1.Chet = IIf(TxtChet2.Text = "", 0, TxtChet2.Text)
                inf1.Chuyen = IIf(txtChuyen2.Text = "", 0, txtChuyen2.Text)

                inf1.Hoanthanh = IIf(TxtHoanThanh2.Text = "", 0, TxtHoanThanh2.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = IIf(txtKhoi2.Text = "", 0, txtKhoi2.Text)
                inf1.Khongdanhgia = IIf(txtKhongDanhGia2.Text = "", 0, txtKhongDanhGia2.Text)
                inf1.Thatbai = IIf(txtThatBai2.Text = "", 0, txtThatBai2.Text)
                inf1.SoBNDK = CInt(IIf(txtBo2.Text = "", 0, txtBo2.Text)) + CInt(IIf(TxtChet2.Text = "", 0, TxtChet2.Text)) + CInt(IIf(txtChuyen2.Text = "", 0, txtChuyen2.Text)) + CInt(IIf(TxtHoanThanh2.Text = "", 0, TxtHoanThanh2.Text)) + CInt(IIf(txtKhoi2.Text = "", 0, txtKhoi2.Text)) + CInt(IIf(txtKhongDanhGia2.Text = "", 0, txtKhongDanhGia2.Text)) + CInt(IIf(txtThatBai2.Text = "", 0, txtThatBai2.Text))

                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT2.Text = "" Or txtId_KetQuaDT2.Text Is Nothing Then
                    txtId_KetQuaDT2.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT2.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT3(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo3.Text = "", 0, txtBo3.Text)
                inf1.Chet = IIf(TxtChet3.Text = "", 0, TxtChet3.Text)
                inf1.Chuyen = IIf(txtChuyen3.Text = "", 0, txtChuyen3.Text)
                inf1.Hoanthanh = IIf(TxtHoanThanh3.Text = "", 0, TxtHoanThanh3.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = IIf(txtKhoi3.Text = "", 0, txtKhoi3.Text)
                inf1.Khongdanhgia = IIf(txtKhongDanhGia3.Text = "", 0, txtKhongDanhGia3.Text)
                inf1.Thatbai = IIf(txtThatBai3.Text = "", 0, txtThatBai3.Text)
                inf1.SoBNDK = CInt(IIf(txtBo3.Text = "", 0, txtBo3.Text)) + CInt(IIf(TxtChet3.Text = "", 0, TxtChet3.Text)) + CInt(IIf(txtChuyen3.Text = "", 0, txtChuyen3.Text)) + CInt(IIf(TxtHoanThanh3.Text = "", 0, TxtHoanThanh3.Text)) + CInt(IIf(txtKhoi3.Text = "", 0, txtKhoi3.Text)) + CInt(IIf(txtKhongDanhGia3.Text = "", 0, txtKhongDanhGia3.Text)) + CInt(IIf(txtThatBai3.Text = "", 0, txtThatBai3.Text))

                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT3.Text = "" Or txtId_KetQuaDT3.Text Is Nothing Then
                    txtId_KetQuaDT3.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT3.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT4(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo4.Text = "", 0, txtBo4.Text)
                inf1.Chet = IIf(TxtChet4.Text = "", 0, TxtChet4.Text)
                inf1.Chuyen = IIf(txtChuyen4.Text = "", 0, txtChuyen4.Text)

                inf1.Hoanthanh = IIf(TxtHoanThanh4.Text = "", 0, TxtHoanThanh4.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = IIf(txtKhoi4.Text = "", 0, txtKhoi4.Text)
                inf1.Khongdanhgia = IIf(txtKhongDanhGia4.Text = "", 0, txtKhongDanhGia4.Text)
                inf1.Thatbai = IIf(txtThatBai4.Text = "", 0, txtThatBai4.Text)
                inf1.SoBNDK = CInt(IIf(txtBo4.Text = "", 0, txtBo4.Text)) + CInt(IIf(TxtChet4.Text = "", 0, TxtChet4.Text)) + CInt(IIf(txtChuyen4.Text = "", 0, txtChuyen4.Text)) + CInt(IIf(TxtHoanThanh4.Text = "", 0, TxtHoanThanh4.Text)) + CInt(IIf(txtKhoi4.Text = "", 0, txtKhoi4.Text)) + CInt(IIf(txtKhongDanhGia4.Text = "", 0, txtKhongDanhGia4.Text)) + CInt(IIf(txtThatBai4.Text = "", 0, txtThatBai4.Text))

                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT4.Text = "" Or txtId_KetQuaDT4.Text Is Nothing Then
                    txtId_KetQuaDT4.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT4.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT5(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo5.Text = "", 0, txtBo5.Text)
                inf1.Chet = IIf(TxtChet5.Text = "", 0, TxtChet5.Text)
                inf1.Chuyen = IIf(txtChuyen5.Text = "", 0, txtChuyen5.Text)
                inf1.Hoanthanh = IIf(TxtHoanThanh5.Text = "", 0, TxtHoanThanh5.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = 0
                inf1.Khongdanhgia = IIf(txtKhongDanhGia5.Text = "", 0, txtKhongDanhGia5.Text)
                inf1.Thatbai = IIf(txtThatBai5.Text = "", 0, txtThatBai5.Text)
                inf1.SoBNDK = CInt(IIf(txtBo5.Text = "", 0, txtBo5.Text)) + CInt(IIf(TxtChet5.Text = "", 0, TxtChet5.Text)) + CInt(IIf(txtChuyen5.Text = "", 0, txtChuyen5.Text)) + CInt(IIf(TxtHoanThanh5.Text = "", 0, TxtHoanThanh5.Text)) + CInt(IIf(txtKhongDanhGia5.Text = "", 0, txtKhongDanhGia5.Text)) + CInt(IIf(txtThatBai5.Text = "", 0, txtThatBai5.Text))

                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT5.Text = "" Or txtId_KetQuaDT5.Text Is Nothing Then
                    txtId_KetQuaDT5.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT5.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT6(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo6.Text = "", 0, txtBo6.Text)
                inf1.Chet = IIf(TxtChet6.Text = "", 0, TxtChet6.Text)
                inf1.Chuyen = IIf(txtChuyen6.Text = "", 0, txtChuyen6.Text)

                inf1.Hoanthanh = IIf(TxtHoanThanh6.Text = "", 0, TxtHoanThanh6.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = 0
                inf1.Khongdanhgia = IIf(txtKhongDanhGia6.Text = "", 0, txtKhongDanhGia6.Text)
                inf1.Thatbai = IIf(txtThatBai6.Text = "", 0, txtThatBai6.Text)
                inf1.SoBNDK = CInt(IIf(txtBo6.Text = "", 0, txtBo6.Text)) + CInt(IIf(TxtChet6.Text = "", 0, TxtChet6.Text)) + CInt(IIf(txtChuyen6.Text = "", 0, txtChuyen6.Text)) + CInt(IIf(TxtHoanThanh6.Text = "", 0, TxtHoanThanh6.Text)) + CInt(IIf(txtKhongDanhGia6.Text = "", 0, txtKhongDanhGia6.Text)) + CInt(IIf(txtThatBai6.Text = "", 0, txtThatBai6.Text))


                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT6.Text = "" Or txtId_KetQuaDT6.Text Is Nothing Then
                    txtId_KetQuaDT6.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT6.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT7(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo7.Text = "", 0, txtBo7.Text)
                inf1.Chet = IIf(TxtChet7.Text = "", 0, TxtChet7.Text)
                inf1.Chuyen = IIf(txtChuyen7.Text = "", 0, txtChuyen7.Text)


                inf1.Hoanthanh = IIf(TxtHoanThanh7.Text = "", 0, TxtHoanThanh7.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = 0
                inf1.Khongdanhgia = IIf(txtKhongDanhGia7.Text = "", 0, txtKhongDanhGia7.Text)
                inf1.Thatbai = IIf(txtThatBai7.Text = "", 0, txtThatBai7.Text)
                inf1.SoBNDK = CInt(IIf(txtBo7.Text = "", 0, txtBo7.Text)) + CInt(IIf(TxtChet7.Text = "", 0, TxtChet7.Text)) + CInt(IIf(txtChuyen7.Text = "", 0, txtChuyen7.Text)) + CInt(IIf(TxtHoanThanh7.Text = "", 0, TxtHoanThanh7.Text)) + CInt(IIf(txtKhongDanhGia7.Text = "", 0, txtKhongDanhGia7.Text)) + CInt(IIf(txtThatBai7.Text = "", 0, txtThatBai7.Text))

                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT7.Text = "" Or txtId_KetQuaDT7.Text Is Nothing Then
                    txtId_KetQuaDT7.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT7.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT8(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo8.Text = "", 0, txtBo8.Text)
                inf1.Chet = IIf(TxtChet8.Text = "", 0, TxtChet8.Text)
                inf1.Chuyen = IIf(txtChuyen8.Text = "", 0, txtChuyen8.Text)

                inf1.Hoanthanh = IIf(TxtHoanThanh8.Text = "", 0, TxtHoanThanh8.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = IIf(txtKhoi8.Text = "", 0, txtKhoi8.Text)
                inf1.Khongdanhgia = IIf(txtKhongDanhGia8.Text = "", 0, txtKhongDanhGia8.Text)
                inf1.Thatbai = IIf(txtThatBai8.Text = "", 0, txtThatBai8.Text)
                inf1.SoBNDK = CInt(IIf(txtBo8.Text = "", 0, txtBo8.Text)) + CInt(IIf(TxtChet8.Text = "", 0, TxtChet8.Text)) + CInt(IIf(txtChuyen8.Text = "", 0, txtChuyen8.Text)) + CInt(IIf(TxtHoanThanh8.Text = "", 0, TxtHoanThanh8.Text)) + CInt(IIf(txtKhoi8.Text = "", 0, txtKhoi8.Text)) + CInt(IIf(txtKhongDanhGia8.Text = "", 0, txtKhongDanhGia8.Text)) + CInt(IIf(txtThatBai8.Text = "", 0, txtThatBai8.Text))
                'IIf(TxtTONGBNDK8.Text = "", 0, TxtTONGBNDK8.Text) ' CInt(IIf(txtBo8.Text = "", 0, txtBo8.Text)) + CInt(IIf(TxtChet8.Text = "", 0, TxtChet8.Text)) + CInt(IIf(txtChuyen8.Text = "", 0, txtChuyen8.Text)) + CInt(IIf(TxtHoanThanh8.Text = "", 0, TxtHoanThanh8.Text)) + CInt(IIf(txtKhoi8.Text = "", 0, txtKhoi8.Text)) + CInt(IIf(txtKhongDanhGia8.Text = "", 0, txtKhongDanhGia8.Text)) + CInt(IIf(txtThatBai8.Text = "", 0, txtThatBai8.Text))

                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT8.Text = "" Or txtId_KetQuaDT8.Text Is Nothing Then
                    txtId_KetQuaDT8.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT8.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub UpdateKQDT9(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTPInfo
            Try
                inf1.Bo = IIf(txtBo9.Text = "", 0, txtBo9.Text)
                inf1.Chet = IIf(TxtChet9.Text = "", 0, TxtChet9.Text)
                inf1.Chuyen = IIf(txtChuyen9.Text = "", 0, txtChuyen9.Text)

                inf1.Hoanthanh = IIf(TxtHoanThanh9.Text = "", 0, TxtHoanThanh9.Text)
                inf1.ID_Phanloai = Phanloai
                inf1.Khoi = IIf(txtKhoi9.Text = "", 0, txtKhoi9.Text)
                inf1.Khongdanhgia = IIf(txtKhongDanhGia9.Text = "", 0, txtKhongDanhGia9.Text)
                inf1.Thatbai = IIf(txtThatBai9.Text = "", 0, txtThatBai9.Text)
                inf1.SoBNDK = CInt(IIf(txtBo9.Text = "", 0, txtBo9.Text)) + CInt(IIf(TxtChet9.Text = "", 0, TxtChet9.Text)) + CInt(IIf(txtChuyen9.Text = "", 0, txtChuyen9.Text)) + CInt(IIf(TxtHoanThanh9.Text = "", 0, TxtHoanThanh9.Text)) + CInt(IIf(txtKhoi9.Text = "", 0, txtKhoi9.Text)) + CInt(IIf(txtKhongDanhGia9.Text = "", 0, txtKhongDanhGia9.Text)) + CInt(IIf(txtThatBai9.Text = "", 0, txtThatBai9.Text))
                inf1.ID_BC_KetquaDT = Me.txtId_BCKetQuaDT.Text

                If txtId_KetQuaDT9.Text = "" Or txtId_KetQuaDT9.Text Is Nothing Then
                    txtId_KetQuaDT9.Text = obj1.Add(inf1)
                Else
                    inf1.ID_BC_KetquaDTP1 = txtId_KetQuaDT9.Text
                    obj1.Update(inf1)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub

        Private Sub UpdateBCHDDT1(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj2 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Controller
            Dim inf2 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Info
            Try
               

                inf2.ARV = IIf(txtDieuTriARV.Text = "", 0, txtDieuTriARV.Text)
                inf2.CPT = IIf(txtDieuTriCPT.Text = "", 0, txtDieuTriCPT.Text)
                inf2.DuongHIV = IIf(txtLaoHIVD.Text = "", 0, txtLaoHIVD.Text)
                inf2.Phanloai = Phanloai
                inf2.XNHIV = IIf(txtLaoHIV.Text = "", 0, txtLaoHIV.Text)
                inf2.ID_BC_KetquaDT = ID

                If txtId_LaoHIV.Text = "" Or txtId_LaoHIV.Text Is Nothing Then
                    txtId_LaoHIV.Text = obj2.Add(inf2)
                Else
                    inf2.ID_BC_KetquaDT_P2 = txtId_LaoHIV.Text
                    obj2.Update(inf2)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Private Sub UpdateBCHDDT2(ByVal ID As Integer, ByVal Phanloai As Integer)
            Dim obj2 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Controller
            Dim inf2 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTP2Info
            Try
                
                inf2.ARV = IIf(txtDieuTriARV1.Text = "", 0, txtDieuTriARV1.Text)
                inf2.CPT = IIf(txtDieuTriCPT1.Text = "", 0, txtDieuTriCPT1.Text)
                inf2.DuongHIV = IIf(txtLaoHIVD1.Text = "", 0, txtLaoHIVD1.Text)
                inf2.Phanloai = Phanloai
                inf2.XNHIV = IIf(txtLaoHIV1.Text = "", 0, txtLaoHIV1.Text)
                inf2.ID_BC_KetquaDT = ID

                If txtId_LaoHIV1.Text = "" Or txtId_LaoHIV1.Text Is Nothing Then
                    txtId_LaoHIV1.Text = obj2.Add(inf2)
                Else
                    inf2.ID_BC_KetquaDT_P2 = txtId_LaoHIV1.Text
                    obj2.Update(inf2)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try


        End Sub
        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub

        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            Panel1.Enabled = True
            Me.txtId_BCKetQuaDT.Text = ""
            Me.txtNam.Text = Year(Now) - 1
            ' Me.txtNguoiBaoCao.Text = ""
            SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
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
            cboQuy.Enabled = True
            txtNam.Enabled = True
            ClearDetail()
            cmdCreateNew.Enabled = False
            cmdAdd.Enabled = True

        End Sub
        Private Sub ClearDetail()
            LblTongcongBNDK.Text = 0
            LblTongcongKhoi.Text = 0 : LblTongcongBo.Text = 0
            LblTongcongChet.Text = 0 : LblTongcongHT.Text = 0
            LblTongcongChuyen.Text = 0 : LblTongcongThatbai.Text = 0
            LblTongcongKdanhgia.Text = 0 : LblTongcong.Text = 0
            txtBo.Text = "" : txtChet.Text = ""
            txtHoanThanh.Text = "" : txtKhoi.Text = ""
            txtChuyen.Text = "" : txtKhongDanhGia.Text = ""
            txtThatBai.Text = "" : Me.txtId_KetQuaDT.Text = ""
            TxtTong.Text = 0 : TxtTONGBNDK.Text = 0

            TxtBo1.Text = "" : TxtChet1.Text = ""
            TxtHoanThanh1.Text = "" : TxtChuyen1.Text = ""
            TxtKhoi1.Text = "" : TxtKhongDanhGia1.Text = ""
            TxtThatbai1.Text = "" : Me.txtId_KetQuaDT1.Text = ""
            TxtTong1.Text = 0 : TxtTONGBNDK1.Text = 0

            txtBo2.Text = "" : TxtChet2.Text = ""
            TxtHoanThanh2.Text = "" : txtKhoi2.Text = ""
            txtChuyen2.Text = "" : txtKhongDanhGia2.Text = ""
            txtThatBai2.Text = "" : Me.txtId_KetQuaDT2.Text = ""
            TxtTong2.Text = 0 : TxtTONGBNDK2.Text = 0
            txtBo3.Text = "" : TxtChet3.Text = ""
            txtChuyen3.Text = "" : TxtHoanThanh3.Text = ""
            txtKhoi3.Text = "" : txtKhongDanhGia3.Text = ""
            txtThatBai3.Text = "" : Me.txtId_KetQuaDT3.Text = ""
            TxtTong3.Text = 0 : TxtTONGBNDK3.Text = 0
            txtBo4.Text = "" : TxtChet4.Text = ""
            TxtHoanThanh4.Text = "" : txtKhoi4.Text = ""
            txtChuyen4.Text = "" : txtKhongDanhGia4.Text = ""
            txtThatBai4.Text = "" : Me.txtId_KetQuaDT4.Text = ""
            TxtTong4.Text = 0 : TxtTONGBNDK4.Text = 0
            txtBo5.Text = "" : TxtChet5.Text = ""
            txtChuyen5.Text = "" : TxtHoanThanh5.Text = ""
            txtKhongDanhGia5.Text = "" : txtThatBai5.Text = ""
            Me.txtId_KetQuaDT5.Text = ""
            TxtTong5.Text = 0 : TxtTONGBNDK5.Text = 0
            txtBo6.Text = "" : TxtChet6.Text = ""
            txtChuyen6.Text = "" : TxtHoanThanh6.Text = ""
            txtKhongDanhGia6.Text = "" : txtThatBai6.Text = ""
            Me.txtId_KetQuaDT6.Text = "" : TxtTong6.Text = 0
            TxtTONGBNDK6.Text = 0 : txtBo7.Text = ""
            TxtChet7.Text = "" : txtChuyen7.Text = ""
            TxtHoanThanh7.Text = "" : txtKhongDanhGia7.Text = ""
            txtThatBai7.Text = "" : Me.txtId_KetQuaDT7.Text = ""
            TxtTong7.Text = 0 : TxtTONGBNDK7.Text = 0

            txtBo8.Text = "" : TxtChet8.Text = ""
            TxtHoanThanh8.Text = "" : txtKhoi8.Text = ""
            txtChuyen8.Text = "" : txtKhongDanhGia8.Text = ""
            txtThatBai8.Text = "" : Me.txtId_KetQuaDT8.Text = ""
            TxtTONGBNDK8.Text = 0

            txtBo9.Text = "" : TxtChet9.Text = ""
            TxtHoanThanh9.Text = "" : txtKhoi9.Text = ""
            txtKhongDanhGia9.Text = "" : txtChuyen9.Text = ""
            txtThatBai9.Text = "" : Me.txtId_KetQuaDT9.Text = ""
            TxtTONGBNDK9.Text = 0

            txtDieuTriARV.Text = "" : txtDieuTriCPT.Text = ""
            txtLaoHIVD.Text = "" : txtLaoHIV.Text = ""
            txtId_LaoHIV.Text = "" : txtDieuTriARV1.Text = ""
            txtDieuTriCPT1.Text = "" : txtLaoHIVD1.Text = ""
            txtLaoHIV1.Text = "" : txtId_LaoHIV1.Text = ""

        End Sub

       

        Protected Sub CmdXem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXem.Click
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTInfo
            Dim obj1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            Dim inf1 As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTInfo
            Try
                txtId_BCKetQuaDT.Text = ""
                ClearDetail()
                If txtNam.Text <> "" Or cboDonVi.SelectedValue <> "" Then
                    inf = obj.GET_ID_BAOCAO(cboQuy.SelectedValue, txtNam.Text, cboDonVi.SelectedValue)
                    If Not inf Is Nothing Then
                        Me.txtId_BCKetQuaDT.Text = inf.ID_BC_KetquaDT
                        inf1 = obj1.Get(inf.ID_BC_KetquaDT)
                        Me.txtNam.Text = inf1.Nam
                        SetValue(Me.txtNgayBaoCao, inf1.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        Me.txtNguoiBaoCao.Text = inf1.NguoiBC
                        Me.cboQuy.SelectedValue = inf1.Quy
                        Me.cboDonVi.SelectedValue = inf1.DVBaocao
                        BindKetQuaDT(Me.txtId_BCKetQuaDT.Text)
                        cboQuy.Enabled = False
                        txtNam.Enabled = False
                    Else
                        BindKetQuaDT(0)
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

       
    End Class

End Namespace