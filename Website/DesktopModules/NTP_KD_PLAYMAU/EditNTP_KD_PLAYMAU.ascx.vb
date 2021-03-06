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
Namespace YourCompany.Modules.NTP_KD_PLAYMAU

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_KD_PLAYMAU
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

#End Region


        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
                End If
                Literal1.Visible = False
                If Not IsPostBack Then
                    If txtId_PhieuLayMau.Text = "" Or txtId_PhieuLayMau.Text Is Nothing Then
                        pnlBaoCao1.Visible = False
                    Else
                        pnlBaoCao1.Visible = True
                    End If
                    CmdInPLM.Visible = False
                    CmdInKQKD.Visible = False
                    If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                        pnlLan2.Visible = True
                        pnlLan2.Visible = True
                    Else
                        pnlLan2.Visible = False
                        pnlLan2.Visible = False
                    End If

                    BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)

                    'cboLaoHIV.SelectedValue = Me.CurrentUserStock.ID_BENHVIEN

                    SetValue(Me.TxtNgayKDLan2, Now, enuDATA_TYPE.DATE_TYPE)
                    Dim obj As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
                    Dim inf As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUInfo
                    ' grdDSPhieuLayMau.Columns(0).Visible = False
                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtId_PhieuLayMau.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtId_PhieuLayMau.Text)
                        Me.CboDonviKD1.SelectedValue = inf.ID_BENHVIEN
                        Me.TxtNguoiKDLan1.Text = inf.KDVien1
                        Me.CboThang1.SelectedValue = inf.ThangLM
                        Me.TxtNam1.Text = inf.Nam
                        Me.txtNhanXetLan1.Text = inf.Nhanxet1
                        SetValue(Me.TxtNgayKDLan1, inf.NgayKD1, enuDATA_TYPE.DATE_TYPE)
                        BindGrdPhieuLayMau(Me.txtId_PhieuLayMau.Text)
                        pnlBaoCao1.Visible = True
                        If CType(Settings("KiemDinhView"), String) = "Lan1" Then
                            txtSoTieuBan.Enabled = False
                            cboKetQua.Enabled = False
                            cboKetQuaKDTinh2.Enabled = False
                            pnlLan1.Visible = True
                            pnlLan2.Visible = False
                            If TxtNgayKDLan1.Text = "" And TxtNguoiKDLan1.Text = "" Then
                                grdDSPhieuLayMau.Columns(4).Visible = False
                            Else
                                CmdInPLM.Visible = True
                                CmdInKQKD.Visible = True
                                'grdDSPhieuLayMau.Columns(1).Visible = False
                            End If
                        End If
                        If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                            If Not inf.NgayKD2.Date.ToString Is Nothing Then
                                SetValue(Me.TxtNgayKDLan2, inf.NgayKD2, enuDATA_TYPE.DATE_TYPE)
                            End If
                            Me.CboDonviKD2.SelectedValue = inf.ID_BENHVIEN
                            Me.TxtNguoiKDLan2.Text = inf.KDVien2
                            Me.CboThang2.SelectedValue = inf.ThangLM
                            Me.TxtNam2.Text = inf.Nam
                            Me.txtNhanXetLan2.Text = inf.Nhanxet2
                            SetValue(Me.TxtNgayKDLan2, inf.NgayKD2, enuDATA_TYPE.DATE_TYPE)
                            txtSoTieuBan.Enabled = False
                            cboKetQua.Enabled = False
                            cboKetQuaKDTinh1.Enabled = False
                            cboKetQuaKDTinh2.Visible = True
                            Label6.Visible = True
                            CmdInPLM.Visible = False
                            cboChatLuongBenhPham.Enabled = False
                            cboTayMau.Enabled = False
                            cboDoSach.Enabled = False
                            cboDoDay.Enabled = False
                            cboKichCo.Enabled = False
                            cboDoMin.Enabled = False
                            pnlLan1.Visible = False
                            pnlLan2.Visible = True
                        End If
                    End If
                    'NTP_Common.SetFormFocus(Me.cboDonVi, Me.ModuleConfiguration.SupportsPartialRendering)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                'obj = Nothing
                'inf = Nothing
            End Try

        End Sub



        Private Sub BindComboBenhVien(ByVal Id_BenhVien As String, ByVal Id_Tinh As String)
            Dim obj As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            '   Dim itm As ListItem
            Try
                'itm = New ListItem
                'itm.Value = Null.NullString
                'itm.Text = "--- Chọn cơ sở điều trị ---"
                If CType(Settings("KiemDinhView"), String) = "Lan1" Then
                    Me.CboDonviKD1.DataSource = obj.GetByBenVien(Id_BenhVien, Id_Tinh)
                    Me.CboDonviKD1.DataBind()
                    'Me.CboDonviKD1.Items.Insert(0, itm)
                Else
                    Me.CboDonviKD2.DataSource = obj.GetByBenVien(Id_BenhVien, Id_Tinh)
                    Me.CboDonviKD2.DataBind()
                    'Me.CboDonviKD2.Items.Insert(0, itm)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Private Sub cmdAdd_Click()
            Dim obj As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
            Dim inf As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUInfo
            Dim objBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo
            Try
                inf.ID_PLAYMAU = txtId_PhieuLayMau.Text
                If CType(Settings("KiemDinhView"), String) = "Lan1" Then
                    Dim dtNgayKiemDinhLan1 As Date
                    dtNgayKiemDinhLan1 = CType(NTP_Common.GetValue(Me.TxtNgayKDLan1, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                    inf.NgayKD1 = dtNgayKiemDinhLan1
                    inf.KDVien1 = Me.TxtNguoiKDLan1.Text
                    inf.Nhanxet1 = Me.txtNhanXetLan1.Text
                    obj.UpdateLan1(inf)
                ElseIf CType(Settings("KiemDinhView"), String) = "Lan2" Then
                    Dim dtNgayKiemDinhLan2 As Date
                    dtNgayKiemDinhLan2 = CType(NTP_Common.GetValue(Me.TxtNgayKDLan2, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                    inf.NgayKD2 = dtNgayKiemDinhLan2
                    inf.KDVien2 = Me.TxtNguoiKDLan2.Text
                    inf.Nhanxet2 = Me.txtNhanXetLan2.Text
                    obj.UpdateLan2(inf)
                End If
                ' DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                If txtId_PhieuLayMau.Text = "" Or txtId_PhieuLayMau.Text Is Nothing Then
                    pnlBaoCao1.Visible = False
                Else
                    pnlBaoCao1.Visible = True
                End If
            End Try


        End Sub

        Protected Sub cmdAdd1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd1.Click
            Dim obj1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
            Dim inf1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CInfo
            Try
                If Me.TxtNgayKDLan1.Text = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Ngày trả kết quả!", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                ElseIf Me.cboKetQuaKDTinh1.SelectedValue = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần nhập Kết quả kiểm định lần 1!", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Else
                    cmdAdd_Click()
                    inf1.Chatluong = cboChatLuongBenhPham.SelectedValue
                    inf1.Taymau = cboTayMau.SelectedValue
                    inf1.Dosach = cboDoSach.SelectedValue
                    inf1.DoDay = cboDoDay.SelectedValue
                    inf1.Kichco = cboKichCo.SelectedValue
                    inf1.Domin = cboDoMin.SelectedValue
                    inf1.Ghichu = txtGhiChu.Text
                    If txtId_PhieuXetNghiemC.Text = "" Or txtId_PhieuXetNghiemC.Text Is Nothing Then
                    Else
                        inf1.ID_Phieuxetnghiem_C = txtId_PhieuXetNghiemC.Text
                    End If


                    If txtId_PhieuLayMau.Text = "" Or txtId_PhieuLayMau.Text Is Nothing Then
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Chưa cập nhật thông tin chính", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    Else
                        inf1.ID_PLAYMAU = Me.txtId_PhieuLayMau.Text
                        inf1.ID_PLAYMAU_C = txtId_PhieuLayMau_C.Text
                        If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                            inf1.KiemDinhT2 = cboKetQuaKDTinh2.SelectedValue
                            obj1.UpdateLan2(inf1)
                            cboKetQuaKDTinh2.SelectedValue = ""
                        Else
                            inf1.KiemdinhT1 = cboKetQuaKDTinh1.SelectedValue
                            obj1.UpdateLan1(inf1)
                        End If
                        CmdInPLM.Visible = True
                        CmdInKQKD.Visible = True


                    End If

                    BindGrdPhieuLayMau(txtId_PhieuLayMau.Text)
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)

            End Try

        End Sub
        Protected Sub grdDSPhieuLayMau_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSPhieuLayMau.ItemCommand
            If e.CommandName = "edit" Then
                Try
                    Dim obj1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
                    Dim inf1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CInfo
                    inf1 = obj1.Get(txtId_PhieuLayMau.Text, e.Item.Cells(2).Text)
                    cboChatLuongBenhPham.SelectedValue = inf1.Chatluong
                    cboDoDay.SelectedValue = inf1.DoDay
                    cboDoMin.SelectedValue = inf1.Domin
                    cboDoSach.SelectedValue = inf1.Dosach
                    txtId_PhieuXetNghiemC.Text = inf1.ID_Phieuxetnghiem_C
                    cboKichCo.SelectedValue = inf1.Kichco
                    cboKetQua.SelectedValue = inf1.KiemdinhH
                    txtId_PhieuLayMau_C.Text = inf1.ID_PLAYMAU_C
                    cboKetQuaKDTinh1.SelectedValue = inf1.KiemdinhT1
                    cboTayMau.SelectedValue = inf1.Taymau
                    txtSoTieuBan.Text = inf1.SoTB
                    If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                        If inf1.KiemDinhT2.ToString Is Nothing Or inf1.KiemDinhT2.ToString = "" Then
                            txtGhiChu.Text = inf1.Ghichu1
                        Else
                            cboKetQuaKDTinh2.SelectedValue = inf1.KiemDinhT2
                            txtGhiChu.Text = inf1.Ghichu2
                        End If
                    End If
                    obj1 = Nothing
                Catch ex As Exception
                    ProcessModuleLoadException(Me, ex)
                End Try


            End If
        End Sub


        Protected Sub BindGrdPhieuLayMau(ByVal ID_PhieuLayMau As String)
            Dim obj1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
            Dim inf1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CInfo
            Try
                If CType(Settings("KiemDinhView"), String) = "Lan1" Then
                    grdDSPhieuLayMau.DataSource = obj1.ListLan1(CType(Me.txtId_PhieuLayMau.Text, Integer))
                End If
                If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                    grdDSPhieuLayMau.DataSource = obj1.ListLan2(CType(Me.txtId_PhieuLayMau.Text, Integer))
                End If
                grdDSPhieuLayMau.DataBind()
                obj1 = Nothing
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub




        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub



        Protected Sub cboKetQua_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKetQua.SelectedIndexChanged

            NTP_Common.SetFormFocus(Me.cboChatLuongBenhPham, Me.ModuleConfiguration.SupportsPartialRendering)
        End Sub

        Protected Sub grdDSPhieuLayMau_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSPhieuLayMau.PageIndexChanged
            grdDSPhieuLayMau.CurrentPageIndex = e.NewPageIndex
            Dim obj1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
            If CType(Settings("KiemDinhView"), String) = "Lan1" Then
                grdDSPhieuLayMau.DataSource = obj1.List(CType(Me.txtId_PhieuLayMau.Text, Integer))
            End If
            If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                grdDSPhieuLayMau.DataSource = obj1.ListLan2(CType(Me.txtId_PhieuLayMau.Text, Integer))
            End If
            grdDSPhieuLayMau.DataBind()
        End Sub

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdInPhieuPhanhoi.Click
            Dim url As String
            Dim Quybc As Integer, DK As String
            DK = ""
            If txtId_PhieuLayMau.Text <> "" Then
                If CboThang1.SelectedValue <= 3 Then
                    Quybc = 1
                ElseIf CboThang1.SelectedValue > 3 And CboThang1.SelectedValue <= 6 Then
                    Quybc = 2
                ElseIf CboThang1.SelectedValue > 6 And CboThang1.SelectedValue <= 9 Then
                    Quybc = 3
                Else
                    Quybc = 4
                End If

                url = Request.ApplicationPath & "/Report/form/BaoCaoKiemDinh.aspx?Opt=6&Tinh=" & Me.CboDonviKD1.SelectedValue & "&Huyen=" & Me.CboDonviKD1.Text & "&Mien=" & CboThang1.SelectedValue & "&Nam=" & Me.TxtNam1.Text & "&Quy=" & Quybc & "&Dieukien=" & DK     ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"


                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
            Else
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Chưa có số liệu.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            End If
        End Sub

        Protected Sub CmdInPLM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdInPLM.Click
            Dim url As String
            Dim Quybc As Integer
            If txtId_PhieuLayMau.Text <> "" Then
                If CboThang1.SelectedValue <= 3 Then
                    Quybc = 1
                ElseIf CboThang1.SelectedValue > 3 And CboThang1.SelectedValue <= 6 Then
                    Quybc = 2
                ElseIf CboThang1.SelectedValue > 6 And CboThang1.SelectedValue <= 9 Then
                    Quybc = 3
                Else
                    Quybc = 4
                End If
                url = Request.ApplicationPath & "/Report/form/BaoCaoKiemDinh.aspx?Opt=7&Tinh=" & Me.CboDonviKD1.SelectedValue & "&Huyen=" & Me.CboDonviKD1.Text & "&Mien=" & CboThang1.SelectedValue & "&Nam=" & Me.TxtNam1.Text & "&Quy=" & Quybc     ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"


                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
            Else
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Chưa có số liệu.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            End If
        End Sub

        Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdInKQKD.Click
            Dim url As String
            Dim Quybc As Integer
            If txtId_PhieuLayMau.Text <> "" Then
                If CboThang1.SelectedValue <= 3 Then
                    Quybc = 1
                ElseIf CboThang1.SelectedValue > 3 And CboThang1.SelectedValue <= 6 Then
                    Quybc = 2
                ElseIf CboThang1.SelectedValue > 6 And CboThang1.SelectedValue <= 9 Then
                    Quybc = 3
                Else
                    Quybc = 4
                End If
                If CType(Settings("KiemDinhView"), String) = "Lan1" Then
                    If CboThang1.SelectedValue <= 3 Then
                        Quybc = 1
                    ElseIf CboThang1.SelectedValue > 3 And CboThang1.SelectedValue <= 6 Then
                        Quybc = 2
                    ElseIf CboThang1.SelectedValue > 6 And CboThang1.SelectedValue <= 9 Then
                        Quybc = 3
                    Else
                        Quybc = 4
                    End If
                    url = Request.ApplicationPath & "/Report/form/BaoCaoKiemDinh.aspx?Opt=8&Tinh=" & Me.CboDonviKD1.SelectedValue & "&Huyen=" & Me.CboDonviKD1.Text & "&Mien=" & CboThang1.SelectedValue & "&Nam=" & Me.TxtNam1.Text & "&Quy=" & Quybc     ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
                Else
                    If CboThang2.SelectedValue <= 3 Then
                        Quybc = 1
                    ElseIf CboThang2.SelectedValue > 3 And CboThang2.SelectedValue <= 6 Then
                        Quybc = 2
                    ElseIf CboThang2.SelectedValue > 6 And CboThang2.SelectedValue <= 9 Then
                        Quybc = 3
                    Else
                        Quybc = 4
                    End If
                    url = Request.ApplicationPath & "/Report/form/BaoCaoKiemDinh.aspx?Opt=9&Tinh=" & Me.CboDonviKD2.SelectedValue & "&Huyen=" & Me.CboDonviKD2.Text & "&Mien=" & CboThang2.SelectedValue & "&Nam=" & Me.TxtNam2.Text & "&Quy=" & Quybc     ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
                End If

                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
            Else
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Chưa có số liệu.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            End If
        End Sub

        Protected Sub CmdXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXoa.Click
            Dim itm As DataGridItem
            Dim objKD As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
            Try
                If CType(Settings("KiemDinhView"), String) = "Lan1" Then ' neu da nhap KQKD lan 2 thi ko dc xoa
                    For Each itm In Me.grdDSPhieuLayMau.SelectedItems
                        If itm.Cells(5).Text = "" Then
                            objKD.DeleteNTP_KD_PLAYMAU_C_KQLAN1(txtId_PhieuLayMau.Text, itm.Cells(2).Text)
                        End If
                    Next
                    BindGrdPhieuLayMau(Me.txtId_PhieuLayMau.Text)
                End If
                If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                    For Each itm In Me.grdDSPhieuLayMau.SelectedItems
                        objKD.DeleteNTP_KD_PLAYMAU_C_KQLAN2(txtId_PhieuLayMau.Text, itm.Cells(2).Text)
                    Next
                    BindGrdPhieuLayMau(Me.txtId_PhieuLayMau.Text)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                Response.Write(ex.ToString)
            End Try
        End Sub
    End Class

End Namespace