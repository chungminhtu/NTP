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


Namespace YourCompany.Modules.NTP_KD_BAOCAOTUYENTINH

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_KD_BAOCAOTUYENTINH
        Inherits Entities.Modules.PortalModuleBase
       
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
            Try
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                Literal1.Visible = False
                If Not IsPostBack Then
                    BindComboTinh()
                    BindComboHuyen(cboTinh.SelectedValue)
                    Me.txtNamBC.Text = Year(Now)
                    'If Month(Now) >= 1 And Month(Now) <= 3 Then
                    '    Me.chkQuy1.Checked = True
                    'ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                    '    Me.chkQuy2.Checked = 2
                    'ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                    '    Me.chkQuy3.Checked = 3
                    'ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                    '    Me.chkQuy4.Checked = 4
                    'End If
                End If
            Catch exc As Exception        'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Private Sub BindComboHuyen(ByVal Id_Tinh As String)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.CmbHuyen.DataSource = obj.ListNTP_DM_BENHVIEN(Id_Tinh)
                Me.CmbHuyen.DataBind()
                Me.CmbHuyen.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Private Sub BindComboTinh()
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_TINHController

            Try
                If Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                    Me.cboTinh.DataSource = obj.ListNTP_DM_TINHforMIEN(3)
                Else
                    Me.cboTinh.DataSource = obj.ListNTP_DM_TINH(Me.CurrentUserStock.ID_BENHVIEN)
                End If
                Me.cboTinh.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub cboTinh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTinh.SelectedIndexChanged
            If cboTinh.SelectedValue <> "" Then
                BindComboHuyen(cboTinh.SelectedValue)
                NTP_Common.SetFormFocus(CmbHuyen, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        End Sub
        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
            Dim obj As New NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHController
            Dim inf As New NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHInfo
            Dim sNguoiBC As String
            Dim sQuy As String

            sQuy = ""
            If ChkNam.Checked = True Then
                sQuy = "1,2,3,4"
            Else
                If chkQuy1.Checked = True Then
                    sQuy = sQuy + "1,"
                End If
                If chkQuy2.Checked = True Then
                    sQuy = sQuy + "2,"
                End If
                If chkQuy3.Checked = True Then
                    sQuy = sQuy + "3,"
                End If
                If chkQuy4.Checked = True Then
                    sQuy = sQuy + "4,"
                End If
                If sQuy <> "" Then
                    sQuy = Left(sQuy, Len(sQuy) - 1)
                End If
            End If
            Dim url As String
            Try
                If sQuy = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần chọn thời gian báo cáo ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Else
                   
                    sNguoiBC = ""
                    If Len(sQuy) = 1 Then
                        If optlistBaoCao.SelectedValue = "HoatdongXN" Then
                            inf = obj.GetNguoBC(CmbHuyen.SelectedValue, cboTinh.SelectedValue, txtNamBC.Text, CInt(sQuy), 3)
                        Else
                            inf = obj.GetNguoBC(CmbHuyen.SelectedValue, cboTinh.SelectedValue, txtNamBC.Text, CInt(sQuy), 5)
                        End If
                        If Not inf Is Nothing Then
                            sNguoiBC = inf.NguoiBC
                            SetValue(TxtNgaybc, inf.Ngaybc, enuDATA_TYPE.DATE_TYPE)
                        End If
                        obj = Nothing
                    End If
                    'If CmbHuyen.SelectedValue = "" Then
                    If sNguoiBC = "" Then
                        sNguoiBC = TxtNguoiBC.Text
                    End If
                    If optlistBaoCao.SelectedValue = "HoatdongXN" Then
                        url = Request.ApplicationPath & "/Report/form/BaocaoTinh.aspx?Opt=5 &Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tinh=" & Me.cboTinh.SelectedValue & "&DVBaocao=" & CmbHuyen.SelectedValue & "&ID_Vung="" &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Nguoibc=" & TxtNguoiBC.Text & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                    ElseIf optlistBaoCao.SelectedValue = "KiemdinhTB" Then
                        url = Request.ApplicationPath & "/Report/form/BaocaoTinh.aspx?Opt=6 &Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tinh=" & Me.cboTinh.SelectedValue & "&DVBaocao=" & CmbHuyen.SelectedValue & "&ID_Vung="" &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Nguoibc=" & TxtNguoiBC.Text & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                    Else
                        url = Request.ApplicationPath & "/Report/form/BaocaoKiemDinh.aspx?Opt=" & optlistBaoCao.SelectedValue & " &Tinh=" & Me.cboTinh.SelectedValue & "&Mien=0 &Vung=0 &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=3" & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                    End If
                    'Else ' BC tuyen huyen

                    'If optlistBaoCao.SelectedValue = "HoatdongXN" Then
                    '    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=4&Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tenhuyen=" & "" & "&Tinh=" & Me.CmbHuyen.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & Me.cboQuyBC.SelectedValue & "&Kieuin=0" & "&Nguoibc=" & sNguoiBC
                    'Else
                    '    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=5&Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tenhuyen=" & "" & "&Tinh=" & Me.CmbHuyen.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & Me.cboQuyBC.SelectedValue & "&Kieuin=0" & "&Nguoibc=" & sNguoiBC
                    'End If
                    'End If
                    'Response.Write(url)
                    Literal1.Text = "<script language = 'javascript'>" & _
                                                          "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                    Literal1.Visible = True
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
            End Try
        End Sub


       
        Protected Sub ChkNam_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkNam.CheckedChanged
            chkQuy1.Checked = False
            chkQuy2.Checked = False
            chkQuy3.Checked = False
            chkQuy4.Checked = False
            If ChkNam.Checked = True Then
                chkQuy1.Enabled = False
                chkQuy2.Enabled = False
                chkQuy3.Enabled = False
                chkQuy4.Enabled = False
            Else
                chkQuy1.Enabled = True
                chkQuy2.Enabled = True
                chkQuy3.Enabled = True
                chkQuy4.Enabled = True
            End If
        End Sub

        Protected Sub optlistBaoCao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optlistBaoCao.SelectedIndexChanged
            If optlistBaoCao.SelectedValue = "11" Then
                CmbHuyen.SelectedValue = ""
                CmbHuyen.Enabled = False
            Else
                CmbHuyen.Enabled = True
            End If
        End Sub
    End Class

End Namespace
