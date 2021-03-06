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

Namespace YourCompany.Modules.NTP_KD_KETQUAKIEMDINH

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_KD_KETQUAKIEMDINH
        Inherits Entities.Modules.PortalModuleBase


        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
                End If
                'Literal1.Visible = False
                If Not IsPostBack Then
                    BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    Dim obj As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
                    Dim inf As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUInfo
                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtId_PhieuLayMau.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtId_PhieuLayMau.Text)
                        SetValue(Me.txtNgayLM, inf.NgayLM, enuDATA_TYPE.DATE_TYPE)
                        Me.cboDonVi.SelectedValue = inf.ID_BENHVIEN
                        Me.TxtNguoiLM.Text = inf.KTVien
                        Me.TxtNam.Text = (inf.Nam)
                        Me.CboThang.SelectedValue = inf.ThangLM
                        Me.TxtNhanxet.Text = inf.Nhanxet
                        Me.TxtTSTBThuchien.Text = inf.SoTBThuchien
                        Me.TxtSoTBCanKD.Text = inf.SoTBCanKD
                        BindGrdPhieuLayMau(Me.txtId_PhieuLayMau.Text)
                        pnlBaoCao1.Visible = True
                        SetValue(Me.NgayKD1, inf.NgayKD1, enuDATA_TYPE.DATE_TYPE)
                        'If inf.KDVien1 <> "" And NgayKD1.Text <> "" Then
                        '    grdDSPhieuLayMau.Columns(1).Visible = False
                        '    grdDSPhieuLayMau.Columns(0).Visible = False
                        'End If

                    Else
                        cmdCreateNew_Click(sender, e)
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
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở điều trị ---"
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
            Dim obj As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
            Dim inf As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUInfo
            Dim objBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo

            Try

                Dim dtNgayLM As Date
                dtNgayLM = CType(NTP_Common.GetValue(Me.txtNgayLM, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                inf.NgayLM = dtNgayLM
                inf.ThangLM = CboThang.SelectedValue
                inf.Nam = TxtNam.Text
                inf.ID_BENHVIEN = Me.cboDonVi.SelectedValue
                inf.KTVien = Me.TxtNguoiLM.Text
                inf.MA_TINH = Me.CurrentUserStock.ID_MATINH
                inf.Nhanxet = IIf(Me.TxtNhanxet.Text = "", "", Me.TxtNhanxet.Text)
                inf.SoTBThuchien = IIf(TxtTSTBThuchien.Text = "", 0, TxtTSTBThuchien.Text)
                inf.SoTBCanKD = IIf(TxtSoTBCanKD.Text = "", 0, TxtSoTBCanKD.Text)
                If txtId_PhieuLayMau.Text = "" Or txtId_PhieuLayMau.Text Is Nothing Then
                    txtId_PhieuLayMau.Text = obj.Add(inf)

                Else
                    inf.ID_PLAYMAU = txtId_PhieuLayMau.Text
                    obj.Update(inf)
                End If

                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
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

        Protected Sub cmdAddDetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAddDetail.Click
            Dim obj1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
            Dim inf1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CInfo
            Try
                inf1.ID_Phieuxetnghiem_C = 0
                inf1.KiemdinhH = cboKetQua.SelectedValue
                inf1.SoTB = txtSoTieuBan.Text
                inf1.Ghichu = IIf(TxtGhichu.Text = "", "", TxtGhichu.Text)
                inf1.ID_PLAYMAU = txtId_PhieuLayMau.Text
                If txtId_PhieuLayMau_C.Text = "" Then
                    txtId_PhieuLayMau_C.Text = obj1.Add(inf1)
                Else
                    inf1.ID_PLAYMAU_C =txtId_PhieuLayMau_C.Text 
                    obj1.Update(inf1)
                End If

                BindGrdPhieuLayMau(txtId_PhieuLayMau.Text)
                cboKetQua.SelectedValue = "0"
                txtSoTieuBan.Text = ""
                TxtGhichu.Text = ""
                txtId_PhieuLayMau_C.Text = ""
                txtId_PhieuXetNghiemC.Text = ""
                NTP_Common.SetFormFocus(Me.txtSoTieuBan, Me.ModuleConfiguration.SupportsPartialRendering)
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)

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
                    txtId_PhieuXetNghiemC.Text = IIf(Val(inf1.ID_Phieuxetnghiem_C) = 0, "", inf1.ID_Phieuxetnghiem_C)
                    txtId_PhieuLayMau_C.Text = inf1.ID_PLAYMAU_C
                    TxtGhichu.Text = inf1.Ghichu
                    cboKetQua.SelectedValue = inf1.KiemdinhH
                    txtSoTieuBan.Text = inf1.SoTB
                   
                Catch ex As Exception
                    ProcessModuleLoadException(Me, ex)
                End Try


            End If
        End Sub
        Protected Sub grdDSPhieuLayMau_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSPhieuLayMau.PageIndexChanged
            grdDSPhieuLayMau.CurrentPageIndex = e.NewPageIndex
            BindGrdPhieuLayMau(Me.txtId_PhieuLayMau.Text)
        End Sub

        Protected Sub BindGrdPhieuLayMau(ByVal ID_PhieuLayMau As String)
            Dim obj1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
            Dim inf1 As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CInfo
            Try
                grdDSPhieuLayMau.DataSource = obj1.List(CType(ID_PhieuLayMau, Integer))
                grdDSPhieuLayMau.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub

        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub

        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            SetValue(Me.txtNgayLM, Now, enuDATA_TYPE.DATE_TYPE)
            Me.txtId_PhieuLayMau.Text = ""
            Me.cboDonVi.SelectedValue = ""
            CboThang.SelectedValue = Month(Now)
            TxtNam.Text = Year(Now)
            Me.txtNgayLM.Text = ""
            Me.TxtNhanxet.Text = ""
            Me.TxtNguoiLM.Text = ""
            TxtTSTBThuchien.Text = ""
            TxtSoTBCanKD.Text = ""
            BindGrdPhieuLayMau(0)
            pnlBaoCao1.Visible = False
            NTP_Common.SetFormFocus(Me.cboDonVi, Me.ModuleConfiguration.SupportsPartialRendering)
        End Sub
      

        Protected Sub cmdDelete1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete1.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAU_CController
            Try
                For Each itm In Me.grdDSPhieuLayMau.SelectedItems
                    obj.Delete(txtId_PhieuLayMau.Text, itm.Cells(2).Text)
                Next
                BindGrdPhieuLayMau(txtId_PhieuLayMau.Text)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub

       
    End Class

End Namespace