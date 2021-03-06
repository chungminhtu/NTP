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
Namespace YourCompany.Modules.NTP_KD_BC_KIEMDINHTB

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_KD_BC_KIEMDINHTB
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
                'Dim sm As System.Web.UI.ScriptManager = ScriptManager.GetCurrent(Control.Page)

                If Not IsPostBack Then
                    If Request.QueryString("id_Tinh") <> "" And (Me.CurrentUserStock.ID_BENHVIEN = "7210" Or Me.CurrentUserStock.ID_BENHVIEN = "3112") Then
                        BindComboHuyen(Request.QueryString("id_Tinh"))
                    Else
                        BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    End If
                    'cboLaoHIV.SelectedValue = Me.CurrentUserStock.ID_BENHVIEN

                    Dim obj As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBController
                    Dim inf As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBInfo

                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtID_KiemdinhTB.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtID_KiemdinhTB.Text)
                        Me.txtNam.Text = inf.Nam
                        ''Me.cboHuyen.SelectedValue = inf.MA_HUYEN
                        Me.cboDonVi.SelectedValue = inf.ID_Benhvien
                        Me.cboQuy.SelectedValue = inf.Quy
                        txtSaiDuongLon.Text = inf.SaiDlon
                        txtSaiDuongNho.Text = inf.SaiDNho
                        txtSaiAmLon.Text = inf.SaiAlon
                        txtSaiAmNho.Text = inf.SaiANho
                        txtDLLon.Text = inf.DLLon
                        txtDLNho.Text = inf.DLNho
                        txtTSTBThucHien.Text = inf.TSTBThuchien
                        txtSoTBKiemDinh.Text = inf.TSTBCanthuchien
                        txtSoTBCanKD.Text = inf.SoTBKiemdinh
                        txtTayMau.Text = inf.TaymauDat
                        txtDoDay.Text = inf.DodayDat
                        txtDoMin.Text = inf.DominDat
                        txtCLBP.Text = inf.CLBPDat
                        txtDoSach.Text = inf.DosachDat
                        txtKichThuoc.Text = inf.KichthuocDat
                        TxtLoiLon.Text = inf.Loilon
                        TxtLoiNho.Text = inf.Loinho
                        TxtTongsoTBKD.Text = inf.TongsoTBKiemdinh
                        txtNgayBaoCao.Text = inf.NgayBC
                        txtNguoiBaoCao.Text = inf.NguoiBC
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
            Dim obj As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBController
            Dim inf As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBInfo
            Dim objBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo

            Try
                If CInt(IIf(txtSoTBKiemDinh.Text = "", 0, txtSoTBKiemDinh.Text)) <> CInt(IIf(TxtTongsoTBKD.Text = "", 0, TxtTongsoTBKD.Text)) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tổng số TB kiểm định ở 2 phần cần phải bằng nhau.", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.TxtTongsoTBKD, Me.ModuleConfiguration.SupportsPartialRendering)
                Else
                    inf.Nam = Me.txtNam.Text
                    inf.Quy = cboQuy.SelectedValue
                    inf.ID_Benhvien = Me.cboDonVi.SelectedValue
                    Dim dtNgay As Date
                    dtNgay = CType(NTP_Common.GetValue(Me.txtNgayBaoCao, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                    inf.NgayBC = dtNgay
                    inf.NguoiBC = txtNguoiBaoCao.Text

                    inf.SaiDlon = IIf(txtSaiDuongLon.Text = "", 0, txtSaiDuongLon.Text)
                    inf.SaiDNho = IIf(txtSaiDuongNho.Text = "", 0, txtSaiDuongNho.Text)
                    inf.SaiAlon = IIf(txtSaiAmLon.Text = "", 0, txtSaiAmLon.Text)
                    inf.SaiANho = IIf(txtSaiAmNho.Text = "", 0, txtSaiAmNho.Text)
                    inf.DLLon = IIf(txtDLLon.Text = "", 0, txtDLLon.Text)
                    inf.DLNho = IIf(txtDLNho.Text = "", 0, txtDLNho.Text)
                    inf.TSTBThuchien = IIf(txtTSTBThucHien.Text = "", 0, txtTSTBThucHien.Text)
                    inf.TSTBCanthuchien = IIf(txtSoTBKiemDinh.Text = "", 0, txtSoTBKiemDinh.Text)
                    inf.SoTBKiemdinh = IIf(txtSoTBCanKD.Text = "", 0, txtSoTBCanKD.Text)
                    inf.TaymauDat = IIf(txtTayMau.Text = "", 0, txtTayMau.Text)
                    inf.DodayDat = IIf(txtDoDay.Text = "", 0, txtDoDay.Text)
                    inf.DominDat = IIf(txtDoMin.Text = "", 0, txtDoMin.Text)
                    inf.CLBPDat = IIf(txtCLBP.Text = "", 0, txtCLBP.Text)
                    inf.DosachDat = IIf(txtDoSach.Text = "", 0, txtDoSach.Text)
                    inf.KichthuocDat = IIf(txtKichThuoc.Text = "", 0, txtKichThuoc.Text)
                    inf.Loilon = IIf(TxtLoiLon.Text = "", 0, TxtLoiLon.Text)
                    inf.Loinho = IIf(TxtLoiNho.Text = "", 0, TxtLoiNho.Text)
                    inf.TongsoTBKiemdinh = IIf(TxtTongsoTBKD.Text = "", 0, TxtTongsoTBKD.Text)
                    If txtID_KiemdinhTB.Text = "" Or txtID_KiemdinhTB.Text Is Nothing Then
                        txtID_KiemdinhTB.Text = obj.Add(inf)
                    Else
                        inf.ID_KiemdinhTB = txtID_KiemdinhTB.Text
                        obj.Update(inf)
                    End If
                    cmdCreateNew.Enabled = True
                    NTP_Common.SetFormFocus(Me.cboDonVi, Me.ModuleConfiguration.SupportsPartialRendering)
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

        Protected Sub cboDonVi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDonVi.SelectedIndexChanged
            NTP_Common.SetFormFocus(Me.txtNam, Me.ModuleConfiguration.SupportsPartialRendering)
        End Sub


        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub

        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            Me.txtID_KiemdinhTB.Text = ""
            Me.txtNam.Text = Year(Now)
            Me.txtNguoiBaoCao.Text = ""
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
            SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
            ClearDetail()
            cmdCreateNew.Enabled = False
            cmdAdd.Enabled = True

        End Sub
        Private Sub ClearDetail()
            txtSaiDuongLon.Text = ""
            txtSaiDuongNho.Text = ""
            txtSaiAmLon.Text = ""
            txtSaiAmNho.Text = ""
            txtDLLon.Text = ""
            txtDLNho.Text = ""
            txtTSTBThucHien.Text = ""
            txtSoTBKiemDinh.Text = ""
            txtSoTBCanKD.Text = ""
            txtTayMau.Text = ""
            txtDoDay.Text = ""
            txtDoMin.Text = ""
            txtCLBP.Text = ""
            txtDoSach.Text = ""
            txtKichThuoc.Text = ""
            TxtLoiLon.Text = 0
            TxtLoiNho.Text = 0
            TxtTongsoTBKD.Text = ""
            
        End Sub

     

        Protected Sub CmdXem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXem.Click

            Dim obj As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBController
            Dim inf As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBInfo
            Dim obj1 As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBController
            Dim inf1 As New NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBInfo
            Try
                If Not Request.QueryString("id") Is Nothing Then
                    inf1 = obj1.GET_ID_BAOCAO(cboQuy.SelectedValue, txtNam.Text, cboDonVi.SelectedValue)
                    If Not inf1 Is Nothing Then
                        ClearDetail()
                        Me.txtID_KiemdinhTB.Text = inf1.ID_KiemdinhTB
                        inf = obj.Get(Me.txtID_KiemdinhTB.Text)
                        Me.txtNam.Text = inf.Nam
                        ''Me.cboHuyen.SelectedValue = inf.MA_HUYEN
                        Me.cboDonVi.SelectedValue = inf.ID_Benhvien
                        Me.cboQuy.SelectedValue = inf.Quy
                        txtSaiDuongLon.Text = inf.SaiDlon
                        txtSaiDuongNho.Text = inf.SaiDNho
                        txtSaiAmLon.Text = inf.SaiAlon
                        txtSaiAmNho.Text = inf.SaiANho
                        txtDLLon.Text = inf.DLLon
                        txtDLNho.Text = inf.DLNho
                        txtTSTBThucHien.Text = inf.TSTBThuchien
                        txtSoTBKiemDinh.Text = inf.TSTBCanthuchien
                        txtSoTBCanKD.Text = inf.SoTBKiemdinh
                        txtTayMau.Text = inf.TaymauDat
                        txtDoDay.Text = inf.DodayDat
                        txtDoMin.Text = inf.DominDat
                        txtCLBP.Text = inf.CLBPDat
                        txtDoSach.Text = inf.DosachDat
                        txtKichThuoc.Text = inf.KichthuocDat
                        TxtLoiLon.Text = inf.Loilon
                        TxtLoiNho.Text = inf.Loinho
                        TxtTongsoTBKD.Text = inf.TongsoTBKiemdinh
                        txtNgayBaoCao.Text = inf.NgayBC
                        txtNguoiBaoCao.Text = inf.NguoiBC
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
    End Class

End Namespace