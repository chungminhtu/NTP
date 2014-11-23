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

Namespace YourCompany.Modules.NTP_BN_BC_KETQUAXN

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_BC_KETQUAXN
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

#End Region

#Region "Event Handlers"

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                If Not IsPostBack Then
                    If Request.QueryString("id_Tinh") <> "" And (Me.CurrentUserStock.ID_BENHVIEN = "7210" Or Me.CurrentUserStock.ID_BENHVIEN = "3112") Then
                        BindComboHuyen(Request.QueryString("id_Tinh"))
                    Else
                        BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    End If
                    SetValue(Me.TxtNgayBC, Now, enuDATA_TYPE.DATE_TYPE)
                    Dim obj As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNController
                    Dim inf As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNInfo
                    If Not Request.QueryString("id") Is Nothing Then
                        Me.TxtID_Ketqua.Text = Request.QueryString("id")
                        inf = obj.Get(Me.TxtID_Ketqua.Text)
                        Me.TxtNam.Text = inf.Nam
                        SetValue(Me.TxtNgayBC, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        Me.cboDonvi.SelectedValue = inf.DVBaocao
                        Me.cboQuy.SelectedValue = inf.Quy
                        Me.TxtNguoiBC.Text = inf.NguoiBC
                        Me.TxtMoi.Text = inf.LaoDTMoi
                        ' LblTongMoi.Text = inf.LaoDTMoi
                        Me.TxtTaitri.Text = inf.LaoTaitri
                        ' LblDieutriLai.Text = inf.LaoTaitri
                        Me.TxtDuongHai.Text = inf.DuongHaiT
                        Me.TxtAmHai.Text = inf.AmHaiT
                        Me.TxtKhongHai.Text = inf.KhongHaiT
                        Me.TxtDuongBa.Text = inf.DuongBaT
                        Me.TxtAmBa.Text = inf.AmBaT
                        Me.TxtKhongBa.Text = inf.KhongBaT
                    Else
                        CmdAddNew_Click(sender, e)
                    End If
                    NTP_Common.SetFormFocus(Me.TxtNam, Me.ModuleConfiguration.SupportsPartialRendering)
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
            Dim obj As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.cboDonvi.DataSource = obj.ListCOSODIEUTRI(Id_BenhVien, Id_Tinh)
                Me.cboDonvi.DataBind()
                Me.cboDonvi.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub


        Protected Sub CmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdSave.Click
            Dim objKQ As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNController
            Dim infKQ As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNInfo
            Dim objBV As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBV As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo
            Dim SLMoi As Integer
            Dim SLDTL As Integer
            SLMoi = CInt(IIf(Me.TxtDuongHai.Text = "", 0, Me.TxtDuongHai.Text)) + CInt(IIf(Me.TxtAmHai.Text = "", 0, Me.TxtAmHai.Text)) + IIf(Me.TxtKhongHai.Text = "", 0, Me.TxtKhongHai.Text)
            SLDTL = CInt(IIf(Me.TxtAmBa.Text = "", 0, Me.TxtAmBa.Text)) + CInt(IIf(Me.TxtDuongBa.Text = "", 0, Me.TxtDuongBa.Text)) + CInt(IIf(Me.TxtKhongBa.Text = "", 0, Me.TxtKhongBa.Text))

            Try
                If CInt(IIf(Me.TxtMoi.Text = "", 0, Me.TxtMoi.Text)) <> SLMoi Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Số bệnh nhân Xét nghiệm sau 2 tháng phải bằng số BNĐK Mới. ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.TxtDuongHai, Me.ModuleConfiguration.SupportsPartialRendering)
                ElseIf CInt(IIf(Me.TxtTaitri.Text = "", 0, Me.TxtTaitri.Text)) <> SLDTL Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Số bệnh nhân Xét nghiệm sau 3 tháng phải bằng số BNĐK Điều trị lại. ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    NTP_Common.SetFormFocus(Me.TxtDuongBa, Me.ModuleConfiguration.SupportsPartialRendering)
                Else
                    Dim dtNgay As Date
                    dtNgay = CType(NTP_Common.GetValue(Me.TxtNgayBC, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                    infKQ.NgayBC = dtNgay
                    infKQ.DVBaocao = Me.cboDonvi.SelectedValue
                    infBV = objBV.Get(infKQ.DVBaocao)
                    infKQ.Quy = Me.cboQuy.SelectedValue
                    infKQ.NguoiBC = Replace(Me.TxtNguoiBC.Text, "'", "")
                    infKQ.Nam = Me.TxtNam.Text
                    infKQ.DuongHaiT = IIf(Me.TxtDuongHai.Text = "", 0, Me.TxtDuongHai.Text)
                    infKQ.AmHaiT = IIf(Me.TxtAmHai.Text = "", 0, Me.TxtAmHai.Text)
                    infKQ.KhongHaiT = IIf(Me.TxtKhongHai.Text = "", 0, Me.TxtKhongHai.Text)
                    infKQ.LaoDTMoi = CInt(IIf(Me.TxtDuongHai.Text = "", 0, Me.TxtDuongHai.Text)) + CInt(IIf(Me.TxtAmHai.Text = "", 0, Me.TxtAmHai.Text)) + IIf(Me.TxtKhongHai.Text = "", 0, Me.TxtKhongHai.Text)
                    'TxtMoi.Text = CInt(IIf(Me.TxtDuongHai.Text = "", 0, Me.TxtDuongHai.Text)) + CInt(IIf(Me.TxtAmHai.Text = "", 0, Me.TxtAmHai.Text)) + IIf(Me.TxtKhongHai.Text = "", 0, Me.TxtKhongHai.Text)
                    infKQ.DuongBaT = IIf(Me.TxtDuongBa.Text = "", 0, Me.TxtDuongBa.Text)
                    infKQ.AmBaT = IIf(Me.TxtAmBa.Text = "", 0, Me.TxtAmBa.Text)
                    infKQ.KhongBaT = IIf(Me.TxtKhongBa.Text = "", 0, Me.TxtKhongBa.Text)
                    infKQ.LaoTaitri = CInt(IIf(Me.TxtAmBa.Text = "", 0, Me.TxtAmBa.Text)) + CInt(IIf(Me.TxtDuongBa.Text = "", 0, Me.TxtDuongBa.Text)) + CInt(IIf(Me.TxtKhongBa.Text = "", 0, Me.TxtKhongBa.Text))
                    ' TxtTaitri.Text = CInt(IIf(Me.TxtAmBa.Text = "", 0, Me.TxtAmBa.Text)) + CInt(IIf(Me.TxtDuongBa.Text = "", 0, Me.TxtDuongBa.Text)) + CInt(IIf(Me.TxtKhongBa.Text = "", 0, Me.TxtKhongBa.Text))
                    infKQ.MA_TINH = infBV.ID_MATINH
                    infKQ.MA_HUYEN = infBV.ID_HUYEN
                    infKQ.PTNhap = True
                    infKQ.Nguoi_NM = Me.CurrentUserStock.USERID

                    If Me.TxtID_Ketqua.Text = "" Or Me.TxtID_Ketqua.Text Is Nothing Then
                        objKQ.AddNTP_BN_BC_KETQUAXN(infKQ)
                    Else
                        infKQ.IDKetquaXN = TxtID_Ketqua.Text
                        objKQ.UpdateNTP_BN_BC_KETQUAXN(infKQ)
                    End If
                    CmdAddNew.Enabled = True
                    CmdSave.Enabled = True
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                End If
        Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                objKQ = Nothing
                infKQ = Nothing
            End Try

        End Sub

        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Try
                Response.Redirect(NavigateURL(), True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub CmdAddNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdAddNew.Click
            Me.TxtNam.Text = Year(Now)
            SetValue(Me.TxtNgayBC, Now, enuDATA_TYPE.DATE_TYPE)
            Me.TxtNguoiBC.Text = ""
            If Month(Now) >= 1 And Month(Now) <= 3 Then
                Me.cboQuy.SelectedValue = 1
            ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                Me.cboQuy.SelectedValue = 2
            ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                Me.cboQuy.SelectedValue = 3
            ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                Me.cboQuy.SelectedValue = 4
            End If
            SetValue(Me.TxtNgayBC, Now, enuDATA_TYPE.DATE_TYPE)
            Me.cboDonvi.SelectedValue = ""
            ClearDetail()
            CmdAddNew.Enabled = False
            CmdSave.Enabled = True
        End Sub
        Private Sub ClearDetail()
            Me.TxtMoi.Text = ""
            Me.TxtTaitri.Text = ""
            Me.TxtDuongHai.Text = ""
            Me.TxtAmHai.Text = ""
            Me.TxtKhongHai.Text = ""
            Me.TxtDuongBa.Text = ""
            Me.TxtAmBa.Text = ""
            Me.TxtKhongBa.Text = ""
            Me.TxtID_Ketqua.Text = ""
        End Sub
        Protected Sub CmdXem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXem.Click
            Dim obj As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNController
            Dim inf As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNInfo
            Dim obj1 As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNController
            Dim inf1 As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNInfo
            Try
                If TxtNam.Text <> "" Or cboDonvi.SelectedValue <> "" Then
                    inf1 = obj1.GET_ID_BAOCAO(cboQuy.SelectedValue, TxtNam.Text, cboDonvi.SelectedValue)

                    If Not inf1 Is Nothing Then
                        Me.TxtID_Ketqua.Text = inf1.IDKetquaXN
                        inf = obj.Get(Me.TxtID_Ketqua.Text)
                        Me.TxtNam.Text = inf.Nam
                        SetValue(Me.TxtNgayBC, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        Me.cboDonvi.SelectedValue = inf.DVBaocao
                        Me.cboQuy.SelectedValue = inf.Quy
                        Me.TxtNguoiBC.Text = inf.NguoiBC
                        ClearDetail()
                        Me.TxtMoi.Text = inf.LaoDTMoi
                        Me.TxtTaitri.Text = inf.LaoTaitri
                        Me.TxtDuongHai.Text = inf.DuongHaiT
                        Me.TxtAmHai.Text = inf.AmHaiT
                        Me.TxtKhongHai.Text = inf.KhongHaiT
                        Me.TxtDuongBa.Text = inf.DuongBaT
                        Me.TxtAmBa.Text = inf.AmBaT
                        Me.TxtKhongBa.Text = inf.KhongBaT
                    Else
                        Dim obj3 As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNController
                        Dim inf3 As New NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNInfo
                        inf3 = obj3.LISTKETQUAXN_BYID(0, cboDonvi.SelectedValue, cboQuy.SelectedValue, TxtNam.Text)
                        If Not inf3 Is Nothing Then
                            Me.TxtMoi.Text = inf3.LaoDTMoi
                            Me.TxtTaitri.Text = inf3.LaoTaitri
                        End If
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