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

Namespace YourCompany.Modules.NTP_BN_KETQUADT

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_KETQUADT
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

#End Region

#Region "Event Handlers"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
   


#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim objKetquaDT As New NTP_BN_KETQUADT.NTP_BN_KETQUADTController
            Dim infKetquaDT As New NTP_BN_KETQUADT.NTP_BN_KETQUADTInfo
            Dim objDieutri As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIController
            Dim infDieutri As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIInfo
            Try
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                If Not IsPostBack Then
                    BindComboKetquaDT()
                    BindComboDVTiepnhan()
                    Me.Panel1.Visible = False
                    'Response.Write(Request.QueryString("id"))
                    If Not Request.QueryString("id") Is Nothing Then
                        infKetquaDT = objKetquaDT.Get(Request.QueryString("id"))
                        Me.TxtID_Dieutri.Text = infKetquaDT.ID_Dieutri
                        Me.TxtMabenhnhan.Text = infKetquaDT.ID_Benhnhan
                        infDieutri = objDieutri.Get(TxtID_Dieutri.Text)
                        Me.TxtTenBenhnhan.Text = infDieutri.Hoten
                        SetValue(TxtNgayVV, infDieutri.NgayVV, enuDATA_TYPE.DATE_TYPE)
                        Me.TxtPhanloaiBN.Text = infDieutri.PhanloaiBN
                        Me.txtTuoi.Text = infDieutri.Tuoi
                        Me.TxtSoDKDT.Text = infDieutri.SoDKDT
                        If infDieutri.Gioitinh = False Then
                            Me.optlistGioiTinh.SelectedValue = 0
                        Else
                            Me.optlistGioiTinh.SelectedValue = 1
                        End If
                        LoadKetquaDT(infKetquaDT)

                    End If
                End If

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub
        Protected Sub LoadKetquaDT(ByVal infDieutri As NTP_BN_KETQUADT.NTP_BN_KETQUADTInfo)
            Try
                SetValue(TxtNgayRV, infDieutri.NgayRV, enuDATA_TYPE.DATE_TYPE)
                cboKetquaDT.SelectedValue = infDieutri.KetquaDT
                TxtGhichu.Text = infDieutri.Ghichu
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Private Sub BindComboKetquaDT()
            Dim obj As New NTP_BN_DM_KETQUADT.NTP_BN_DM_KETQUADTController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn kết quả ĐT ---"
                Me.cboKetquaDT.DataSource = obj.List
                Me.cboKetquaDT.DataBind()
                Me.cboKetquaDT.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboDVTiepnhan()
            'Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
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
        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCancel.Click
            Try
                Response.Redirect(NavigateURL(), True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
            Dim objKQ As New NTP_BN_KETQUADT.NTP_BN_KETQUADTController
            Dim infKQ As New NTP_BN_KETQUADT.NTP_BN_KETQUADTInfo
            Dim objPC As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Dim infPC As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENInfo
            Try
                infKQ.KetquaDT = Me.cboKetquaDT.SelectedValue
                Dim dtNgayRV As Date
                dtNgayRV = CType(NTP_Common.GetValue(Me.TxtNgayRV, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                infKQ.NgayRV = dtNgayRV
                infKQ.Ghichu = Me.TxtGhichu.Text
                infKQ.ID_Dieutri = Me.TxtID_Dieutri.Text
                objKQ.UpdateNTP_BN_KETQUADT(infKQ)
                '---------Insert Phieuchuyen---------
                If Me.cboKetquaDT.SelectedValue = 6 Then
                    infPC.ID_Dieutri = Me.TxtID_Dieutri.Text
                    infPC.PhanLoai = Me.optlistLoaiYTe.SelectedItem.Value
                    infPC.DVTiepnhan = Me.cboDVTiepnhan.SelectedValue
                    infPC.DVChuyen = Me.CurrentUserStock.ID_BENHVIEN
                    infPC.Lydo = Me.TxtLydo.Text
                    infPC.TinhTrangBN = Me.TxtTinhtrangBN.Text
                    dtNgayRV = CType(NTP_Common.GetValue(Me.TxtNgaychuyen, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                    infPC.NgayChuyen = dtNgayRV
                    infPC.SoDKDT = Me.TxtSoDKDT.Text
                    infPC.NGUOI_NM = Me.CurrentUserStock.USERID
                    infPC.Tiepnhan = False
                    Response.Write(Me.cboDVTiepnhan.SelectedValue & "---" & infPC.Tiepnhan)
                    ' Add()
                    objPC.AddNTP_BN_PHIEUCHUYEN(infPC)
                End If
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "D? li?u dã du?c ghi l?i thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                objKQ = Nothing
                infKQ = Nothing
            End Try
        End Sub

        Protected Sub cboKetquaDT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKetquaDT.SelectedIndexChanged
            If Me.cboKetquaDT.SelectedValue = 6 Then
                Me.Panel1.Visible = True
            Else
                Me.Panel1.Visible = False
            End If

        End Sub
    End Class

End Namespace