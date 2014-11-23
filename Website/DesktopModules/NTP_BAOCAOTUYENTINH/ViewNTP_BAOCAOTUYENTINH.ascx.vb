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

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared




Namespace YourCompany.Modules.NTP_BAOCAOTUYENTINH

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_BAOCAOTUYENTINH
        Inherits Entities.Modules.PortalModuleBase
        Implements Entities.Modules.IActionable

#Region "Private Members"

        Private strTemplate As String

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
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                PnlTinh.Visible = False
                PnlHuyen.Visible = False
                If CType(Settings("optBCKetQuaDTView"), String) = "NhapBC" Then
                    Literal1.Visible = False
                    PnlTinh.Visible = True
                Else
                    PnlHuyen.Visible = True
                End If
         '       Response.Write("Me:" + Me.CurrentUserStock.ID_BENHVIEN)
                If Not IsPostBack Then
                    If CType(Settings("optBCKetQuaDTView"), String) = "NhapBC" Then ' BC TINH
                        PnlTinh.Visible = True
                        BindComboTinh()
                        BindComboHuyen(cboTinh.SelectedValue)
	                Me.txtNamBC.Text = Year(Now)


                       
                    Else ' BC HUYEN
                        PnlHuyen.Visible = True
                        BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                        Me.tctNamBC.Text = Year(Now)
                        SetValue(Me.txtTuNgay, Now, enuDATA_TYPE.DATE_TYPE)
                        SetValue(Me.TxtDenngay, Now, enuDATA_TYPE.DATE_TYPE)
			 optPLBaocao.SelectedValue = 0
			'optPLBaocao.Items(1).enabled=false
                        'If Month(Now) >= 1 And Month(Now) <= 3 Then
                        '    Me.CboQuyBC.SelectedValue = 1
                        'ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                        '    Me.CboQuyBC.SelectedValue = 2
                        'ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                        '    Me.CboQuyBC.SelectedValue = 3
                        'ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                        '    Me.CboQuyBC.SelectedValue = 4
                        'End If
                    End If
                End If
            Catch exc As Exception        'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

#End Region

#Region "Optional Interfaces"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Registers the module actions required for interfacing with the portal framework
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property ModuleActions() As Entities.Modules.Actions.ModuleActionCollection Implements Entities.Modules.IActionable.ModuleActions
            Get
                Dim Actions As New Entities.Modules.Actions.ModuleActionCollection
                Actions.Add(GetNextActionID, Localization.GetString(Entities.Modules.Actions.ModuleActionType.AddContent, LocalResourceFile), Entities.Modules.Actions.ModuleActionType.AddContent, "", "", EditUrl(), False, Security.SecurityAccessLevel.Edit, True, False)
                Return Actions
            End Get
        End Property

#End Region
      
     
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
        Private Sub BindComboBenhVien(ByVal Id_BenhVien As String, ByVal Id_Tinh As String)
            Dim obj As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Try
                Me.CboDonviBC.DataSource = obj.GetByBenVien(Id_BenhVien, Id_Tinh)
                Me.CboDonviBC.DataBind()

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub CmdIN_Tinh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdIN_Tinh.Click
            Dim obj As New NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHController
            Dim inf As New NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHInfo
            Dim sNguoiBC As String
            Dim sQuy As String
           
            Try
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
                If sQuy = "" Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần chọn thời gian báo cáo ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Else
                    sNguoiBC = ""
                    If Len(sQuy) = 1 Then
                        If CmbHuyen.SelectedValue <> "" Then ' Lay ten nguoi BC Tuyen Huyen
                            If OptBCTuyenTinh.SelectedValue = "Thunhan" Then
                                inf = obj.GetNguoBC(CmbHuyen.SelectedValue, cboTinh.SelectedValue, txtNamBC.Text, CInt(sQuy), 0)
                            ElseIf OptBCTuyenTinh.SelectedValue = "Dieutri" Then
                                inf = obj.GetNguoBC(CmbHuyen.SelectedValue, cboTinh.SelectedValue, txtNamBC.Text, CInt(sQuy), 1)
                            ElseIf OptBCTuyenTinh.SelectedValue = "Amhoadom" Then
                                inf = obj.GetNguoBC(CmbHuyen.SelectedValue, cboTinh.SelectedValue, txtNamBC.Text, CInt(sQuy), 2)
                            ElseIf OptBCTuyenTinh.SelectedValue = "ChuongtrinhCL" Then
                                inf = obj.GetNguoBC(CmbHuyen.SelectedValue, cboTinh.SelectedValue, txtNamBC.Text, CInt(sQuy), 3)
                            End If
                            If Not inf Is Nothing Then
                                sNguoiBC = inf.NguoiBC
                                SetValue(TxtNgaybc, inf.Ngaybc, enuDATA_TYPE.DATE_TYPE)
                            End If
                            obj = Nothing
                        End If
                    End If
                    Dim url As String ' In BC
                    If CmbHuyen.SelectedValue <> "" Then ' BC Tuyen Huyen

                        If OptBCTuyenTinh.SelectedValue = "Thunhan" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=1&Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tenhuyen=" & Me.CmbHuyen.SelectedItem.Text & "&Tinh=" & Me.CmbHuyen.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=0" & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text & "&capin=1"
                        ElseIf OptBCTuyenTinh.SelectedValue = "Dieutri" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=2&Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tenhuyen=" & Me.CmbHuyen.SelectedItem.Text & "&Tinh=" & Me.CmbHuyen.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=0" & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text & "&capin=1"
                        ElseIf OptBCTuyenTinh.SelectedValue = "Amhoadom" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=3&Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tenhuyen=" & Me.CmbHuyen.SelectedItem.Text & "&Tinh=" & Me.CmbHuyen.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=0" & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text & "&capin=1"
                        ElseIf OptBCTuyenTinh.SelectedValue = "AmhoadomH" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoKiemDinh.aspx?Opt=44 &Tinh=" & Me.cboTinh.SelectedValue & "&Mien=0&Vung=0&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=0"     ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
                        ElseIf OptBCTuyenTinh.SelectedValue = "ChuongtrinhCL" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=6 &Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tenhuyen=" & Me.CmbHuyen.SelectedItem.Text & "&Tinh=" & Me.CmbHuyen.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=0" & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text
                        End If
                    Else
                        If sNguoiBC = "" Then
                            sNguoiBC = TxtNguoiBC.Text
                        End If
                        If OptBCTuyenTinh.SelectedValue = "Thunhan" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoTinh.aspx?Opt=1 &Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tinh=" & Me.cboTinh.SelectedValue & "&DVBaocao=" & CmbHuyen.SelectedValue & "&ID_Vung="" &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text
                        ElseIf OptBCTuyenTinh.SelectedValue = "Dieutri" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoTinh.aspx?Opt=2 &Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tinh=" & Me.cboTinh.SelectedValue & "&DVBaocao=" & CmbHuyen.SelectedValue & "&ID_Vung="" &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text
                        ElseIf OptBCTuyenTinh.SelectedValue = "Amhoadom" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoTinh.aspx?Opt=3 &Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tinh=" & Me.cboTinh.SelectedValue & "&DVBaocao=" & CmbHuyen.SelectedValue & "&ID_Vung="" &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text
                        ElseIf OptBCTuyenTinh.SelectedValue = "ChuongtrinhCL" Then
                            url = Request.ApplicationPath & "/Report/form/BaocaoTinh.aspx?Opt=4 &Tentinh=" & Me.cboTinh.SelectedItem.Text & "&Tinh=" & Me.cboTinh.SelectedValue & "&DVBaocao=" & CmbHuyen.SelectedValue & "&ID_Vung="" &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Nguoibc=" & sNguoiBC & "&Ngaybc=" & TxtNgaybc.Text
                        ElseIf OptBCTuyenTinh.SelectedValue = "4" Then ' KQDT cua tinh theo huyen
                            url = Request.ApplicationPath & "/Report/form/BaoCao.aspx?&Opt=4&Tinh=" & Me.cboTinh.SelectedValue & "&Mien=0 &Vung=0 &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=3"
                        ElseIf OptBCTuyenTinh.SelectedValue = "Thunhantheohuyenquy" Then
                            url = Request.ApplicationPath & "/Report/form/ThuNhanBNLao.aspx?&Opt=8 &PhanloaiBC=1 &ID_Tinh=" & Me.cboTinh.SelectedValue & "&ID_Mien=0 &ID_Vung=0 &Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=3"
                        ElseIf OptBCTuyenTinh.SelectedValue = "AmhoadomH" Then '
                            url = Request.ApplicationPath & "/Report/form/BaocaoKQXN.aspx?Opt=44 &Tinh=" & Me.cboTinh.SelectedValue & "&Mien=0&Vung=0&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Kieuin=0"     ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"

                        End If

                    End If

                    Literal1.Text = "<script language = 'javascript'>" & _
                                                          "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                    Literal1.Visible = True
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub


        Protected Sub optlistBaoCao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptBCTuyenTinh.SelectedIndexChanged
            If OptBCTuyenTinh.SelectedItem.Value = "ChuongtrinhCL" Then
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
            If OptBCTuyenTinh.SelectedValue = "Dieutri" Or OptBCTuyenTinh.SelectedValue = "4" Then
                Me.txtNamBC.Text = Year(Now) - 1
            Else
                Me.txtNamBC.Text = Year(Now)
            End If
            If OptBCTuyenTinh.SelectedValue = "4" Or OptBCTuyenTinh.SelectedValue = "Thunhantheohuyenquy" Then
                CmbHuyen.SelectedValue = ""
                CmbHuyen.Enabled = False
            Else
                CmbHuyen.Enabled = True
            End If
        End Sub
     
        Protected Sub CmdIN_Huyen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdIN_Huyen.Click
            Dim url As String
            Dim Tentinh As String
            Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
            Dim inf As New NTP_DANHMUC.NTP_DM_TINH_Info
            Dim Tungay As String
            Dim Denngay As String
            Tungay = CType(GetValue(txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date)
            Denngay = CType(GetValue(TxtDenngay, enuDATA_TYPE.DATE_TYPE), Date)
            inf = obj.SelectItem(Left(Me.CboDonviBC.SelectedValue, 2))
            Tentinh = ""
            If Not inf Is Nothing Then
                Tentinh = inf.TEN_TINH
            End If
            obj = Nothing

            Try
                If OptBCTuyenHuyen.SelectedValue = "Thunhan" Then
                    '       Response.Write(CboDonviBC.SelectedItem.Text)
                    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=1&Tentinh=" & Tentinh & "&Tenhuyen=" & Me.CboDonviBC.SelectedItem.Text & "&Tinh=" & Me.CboDonviBC.SelectedValue & "&Nam=" & Me.tctNamBC.Text & "&Quy=" & Me.CboQuyBC.SelectedValue & "&Tungay=" & Tungay & "&Denngay=" & Denngay & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                ElseIf OptBCTuyenHuyen.SelectedValue = "Dieutri" Then
                    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=2&Tentinh=" & Tentinh & "&Tenhuyen=" & Me.CboDonviBC.SelectedItem.Text & "&Tinh=" & Me.CboDonviBC.SelectedValue & "&Nam=" & Me.tctNamBC.Text & "&Quy=" & Me.CboQuyBC.SelectedValue & "&Tungay=" & Tungay & "&Denngay=" & Denngay & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                ElseIf OptBCTuyenHuyen.SelectedValue = "Amhoadom" Then
                    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=3&Tentinh=" & Tentinh & "&Tenhuyen=" & Me.CboDonviBC.SelectedItem.Text & "&Tinh=" & Me.CboDonviBC.SelectedValue & "&Nam=" & Me.tctNamBC.Text & "&Quy=" & Me.CboQuyBC.SelectedValue & "&Tungay=" & Tungay & "&Denngay=" & Denngay & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                ElseIf OptBCTuyenHuyen.SelectedValue = "HoatdongXN" Then
                    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=4&Tentinh=" & Tentinh & "&Tenhuyen=" & Me.CboDonviBC.SelectedItem.Text & "&Tinh=" & Me.CboDonviBC.SelectedValue & "&Nam=" & Me.tctNamBC.Text & "&Quy=" & Me.CboQuyBC.SelectedValue & "&Tungay=" & Tungay & "&Denngay=" & Denngay & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                    'ElseIf OptBCTuyenHuyen.SelectedValue = "KetquaKDTB" Then
                    '    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=5&Tentinh=" & Tentinh & "&Tenhuyen=" & Me.CboDonviBC.SelectedItem.Text & "&Tinh=" & Me.CboDonviBC.SelectedValue & "&Nam=" & Me.tctNamBC.Text & "&Quy=" & Me.CboQuyBC.SelectedValue & "&Tungay=" & Tungay & "&Denngay=" & Denngay & "&Capnhatdl=" & IIf(ChkCapnhatDL.Checked = True, "1", "0") & "&capin=" & optPLBaocao.SelectedValue
                ElseIf OptBCTuyenHuyen.SelectedValue = "Xetnghiem_PHDuong" Then
                    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=7&Tentinh=" & Tentinh & "&Tenhuyen=" & Me.CboDonviBC.SelectedItem.Text & "&Tinh=" & Me.CboDonviBC.SelectedValue & "&Nam=" & Me.tctNamBC.Text & "&Quy=" & Me.CboQuyBC.SelectedValue & "&Tungay=" & Tungay & "&Denngay=" & Denngay & "&ngay1=" & txtTuNgay.Text & "&ngay2=" & TxtDenngay.Text
                ElseIf OptBCTuyenHuyen.SelectedValue = "Xetnghiem_AM" Then
                    url = Request.ApplicationPath & "/Report/form/BaocaoHuyen.aspx?Opt=8&Tentinh=" & Tentinh & "&Tenhuyen=" & Me.CboDonviBC.SelectedItem.Text & "&Tinh=" & Me.CboDonviBC.SelectedValue & "&Nam=" & Me.tctNamBC.Text & "&Quy=" & Me.CboQuyBC.SelectedValue & "&Tungay=" & Tungay & "&Denngay=" & Denngay & "&ngay1=" & txtTuNgay.Text & "&ngay2=" & TxtDenngay.Text

                End If
              
                Literal2.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal2.Visible = True
                ' Response.Write(url)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub

        Protected Sub cboTinh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTinh.SelectedIndexChanged
            If cboTinh.SelectedValue <> "" Then
                BindComboHuyen(cboTinh.SelectedValue)
                NTP_Common.SetFormFocus(CmbHuyen, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
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

         Protected Sub CboQuyBC_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboQuyBC.SelectedIndexChanged
            If OptBCTuyenHuyen.SelectedValue = "Amhoadom" Then
                If CboQuyBC.SelectedValue = 1 Then
                    txtTuNgay.Text = "01/10" & "/" & CStr(CInt(tctNamBC.Text) - 1)
                    TxtDenngay.Text = "31/12" & "/" & CStr(CInt(tctNamBC.Text) - 1)
                ElseIf CboQuyBC.SelectedValue = 2 Then
                    txtTuNgay.Text = "01/01" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "31/03" & "/" & tctNamBC.Text
                ElseIf CboQuyBC.SelectedValue = 3 Then
                    txtTuNgay.Text = "01/04" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "30/06" & "/" & tctNamBC.Text
                ElseIf CboQuyBC.SelectedValue = 4 Then
                    txtTuNgay.Text = "01/07" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "30/09" & "/" & tctNamBC.Text
                End If
            End If
        End Sub
 Protected Sub OptBCTuyenHuyen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptBCTuyenHuyen.SelectedIndexChanged
            If OptBCTuyenHuyen.SelectedValue = "Amhoadom" Then
                If CboQuyBC.SelectedValue = 1 Then
                    txtTuNgay.Text = "01/10" & "/" & CStr(CInt(tctNamBC.Text) - 1)
                    TxtDenngay.Text = "31/12" & "/" & CStr(CInt(tctNamBC.Text) - 1)
                ElseIf CboQuyBC.SelectedValue = 2 Then
                    txtTuNgay.Text = "01/01" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "31/03" & "/" & tctNamBC.Text
                ElseIf CboQuyBC.SelectedValue = 3 Then
                    txtTuNgay.Text = "01/04" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "30/06" & "/" & tctNamBC.Text
                ElseIf CboQuyBC.SelectedValue = 4 Then
                    txtTuNgay.Text = "01/07" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "30/09" & "/" & tctNamBC.Text
                End If
	   Else
                tctNamBC.Text= Year(Now)
                 If CboQuyBC.SelectedValue = 1 Then
                    txtTuNgay.Text = "01/01" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "31/03" & "/" & tctNamBC.Text
                ElseIf CboQuyBC.SelectedValue = 2 Then
                    txtTuNgay.Text = "01/04" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "30/06" & "/" & tctNamBC.Text
                ElseIf CboQuyBC.SelectedValue = 3 Then
                    txtTuNgay.Text = "01/07" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "30/09" & "/" & tctNamBC.Text
                ElseIf CboQuyBC.SelectedValue = 4 Then
                    txtTuNgay.Text = "01/10" & "/" & tctNamBC.Text
                    TxtDenngay.Text = "31/12" & "/" & tctNamBC.Text
                End If

            End If
        End Sub
    End Class

End Namespace
