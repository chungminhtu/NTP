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
Namespace YourCompany.Modules.NTP_BN_PHIEUCHUYEN

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_PHIEUCHUYEN
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

#End Region

     

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim objDieutri As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIController
            Dim infDieutri As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIInfo
            Dim objPhieuChuyen As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Dim infPhieuChuyen As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENInfo
            BindgrdDS(Me.CurrentUserStock.ID_BENHVIEN)

            Try
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                If Not IsPostBack Then
                    BindComboDVTiepnhan()
                    If Not Request.QueryString("id") Is Nothing Then
                        infPhieuChuyen = objPhieuChuyen.Get(Request.QueryString("id"))
                        Me.TxtID_Phieuchuyen.Text = infPhieuChuyen.ID_Phieuchuyen
                        Me.TxtID_Dieutri.Text = infPhieuChuyen.ID_Dieutri
                        infDieutri = objDieutri.Get(TxtID_Dieutri.Text)
                        Me.TxtTinhtrangBN.Text = infPhieuChuyen.TinhTrangBN
                        Me.TxtLydo.Text = infPhieuChuyen.Lydo
                        Me.TxtNgaychuyen.Text = infPhieuChuyen.NgayChuyen
                        If infPhieuChuyen.PhanLoai = False Then
                            Me.optlistLoaiYTe.SelectedValue = 0
                        Else
                            Me.optlistLoaiYTe.SelectedValue = 1
                        End If
                        LoadBenhnhan(infDieutri)
                    Else

                    End If

                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Protected Sub LoadBenhnhan(ByVal infDieutri As NTP_BN_DIEUTRI.NTP_BN_DIEUTRIInfo)
            Try
                Me.TxtTenBenhnhan.Text = infDieutri.Hoten
                Me.TxtMabenhnhan.Text = infDieutri.ID_BENHNHAN
                Me.TxtSoDKDT.Text = infDieutri.SoDKDT
                Me.txtTuoi.Text = infDieutri.Tuoi
                If infDieutri.Gioitinh = False Then
                    Me.optlistGioiTinh.SelectedValue = 0
                Else
                    Me.optlistGioiTinh.SelectedValue = 1
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Protected Sub LoadPhieuchuyen(ByVal infPhieuchuyen As NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENInfo)
            Try
                SetValue(txtNgayChuyen, infPhieuchuyen.Ngaychuyen, enuDATA_TYPE.DATE_TYPE)
                If infPhieuchuyen.Phanloai = False Then
                    Me.optlistLoaiYTe.SelectedValue = 0
                Else
                    Me.optlistLoaiYTe.SelectedValue = 1
                End If

                CboDVTiepnhan.SelectedValue = infPhieuchuyen.DVTiepnhan
                TxtTinhtrangBN.Text = infPhieuchuyen.TinhtrangBN
                TxtLydo.Text = infPhieuchuyen.Lydo
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub BindComboDVTiepnhan()
            Dim obj As New NTP_BN_KETQUADT.NTP_BN_KETQUADTController
            Try
                Me.cboDVTiepnhan.DataSource = obj.ListNTP_BN_DMBENHVIENCHUYEN(Me.CurrentUserStock.ID_BENHVIEN)
                Me.cboDVTiepnhan.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub


        Protected Sub BindgrdDS(ByVal Ma_BV As String)
            Dim obj As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Dim inf As New List(Of NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENBENHNHANInfo)
            inf = obj.ListbyNTP_BN_DIEUTRI(0, Ma_BV)
            Try
                'Me.grdDSDieutri.DataSource = inf
                'Me.grdDSDieutri.DataBind()

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub

        Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
            Dim obj As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Dim inf As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENInfo

            Try
                inf.ID_Dieutri = Me.TxtID_Dieutri.Text
                Dim dtNgayChuyen
                dtNgayChuyen = CType(NTP_Common.GetValue(Me.TxtNgaychuyen, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                inf.NgayChuyen = dtNgayChuyen
                inf.Lydo = Me.TxtLydo.Text
                inf.TinhTrangBN = Me.TxtTinhtrangBN.Text
                inf.PhanLoai = Me.optlistLoaiYTe.SelectedItem.Value
                If Request.QueryString("id") Is Nothing Then
                    'Add
                    ' obj.Add(inf)
                    ClearForm()
                    ' NTP_Common.SetFormFocus(Me.txtNgayChuyen, Me.ModuleConfiguration.SupportsPartialRendering)
                Else
                    'Update
                    inf.ID_Phieuchuyen = Me.TxtID_Phieuchuyen.Text
                    obj.Update(inf)
                End If
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "D? li?u dã du?c ghi l?i thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
                inf = Nothing
            End Try
        End Sub


        Protected Sub ClearForm()
            Me.TxtID_Phieuchuyen.Text = ""
            Me.TxtID_Dieutri.Text = "" : Me.TxtSoDKDT.Text = "" : Me.TxtID_Dieutri.Text = ""
            Me.TxtNgaychuyen.Text = "" : Me.TxtMabenhnhan.Text = ""
            Me.TxtLydo.Text = ""
            Me.TxtTinhtrangBN.Text = ""
            Me.optlistLoaiYTe.SelectedItem.Value = 0
            SetValue(TxtNgaychuyen, Now, enuDATA_TYPE.DATE_TYPE)

        End Sub


    End Class

End Namespace