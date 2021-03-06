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
'Imports DotNetNuke
Imports DotNetNuke
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Reflection
Imports NTP_Common.mdlGlobal

Namespace YourCompany.Modules.NTP_BN_DIEUTRI

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_BN_DIEUTRI
        Inherits Entities.Modules.PortalModuleBase
        Implements Entities.Modules.IActionable
#Region "Private Members"

        Private strTemplate As String

#End Region

#Region "Event Handlers"

 

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

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()

                End If
                Literal1.Visible = False
                If Not IsPostBack Then
                    'panel Chuyển đến
                    
                    txtTuNgay.Text = "01/01/" & Year(Now)

			'TxtDenngay.text=""
                    SetValue(Me.TxtDenngay, Now, enuDATA_TYPE.DATE_TYPE)
                    If CType(Settings("ChuyenDenDieuTriView"), String) = "ChuyenDen" Then
                        pnlChuyenDen.Visible = False
                        pnlDieuTri.Visible = True
                        pnlDieuTri.Visible = True
                        CmdDSBenhnhan.BackColor = Color.LightCyan
                        CmdChuyenden.BackColor = Color.WhiteSmoke()
                        CmdChuyenden.Font.Underline = False
                        CmdDSBenhnhan.Font.Underline = True
                        BindComboPhanLoaiBenh()
                        cboPhanLoaiBenh.SelectedValue = 0

                        OptDVDT.SelectedValue = 1
                        cboTinh.Enabled = False
                        cboHuyen.Enabled = False

                        BindComboTinh()
                        BindComboHuyen(cboTinh.SelectedValue)
                        cmdTim_Click(sender, e)
                        Dim objPhieuChuyenBenhNhan As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
                        grdDSBenhNhan.DataSource = objPhieuChuyenBenhNhan.ListByDVTiepNhan(Me.CurrentUserStock.ID_BENHVIEN)
                        grdDSBenhNhan.DataBind()
                        'CmdChuyenden.Text = "Danh sách bệnh nhân chuyển đến (" & grdDSBenhNhan.Items.Count & ")"
			if grdDSBenhNhan.Items.Count>0 then
				 CmdChuyenden.ForeColor = Color.red
			else
				 CmdChuyenden.ForeColor= Color.blue
			end if

                    Else
                        If CType(Settings("ChuyenDenDieuTriView"), String) = "DieuTri" Then
                            'panel điều trị
                            BindComboTinh()
                            BindComboHuyen(cboTinh.SelectedValue)
                            pnlDieuTri.Visible = True
                            CmdChuyenden.Visible = False
                            cmdTim_Click(sender, e)

                        End If
                    End If
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
        Private Sub BindComboTinh()
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_TINHController

            Dim itm As ListItem
            Try
                If Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                    Me.cboTinh.DataSource = obj.ListNTP_DM_TINHforMIEN(3)
                Else
                    If OptDVDT.SelectedValue = 1 Then
                        Me.cboTinh.DataSource = obj.ListNTP_DM_TINH(Me.CurrentUserStock.ID_BENHVIEN)
                        Me.cboTinh.DataBind()
                    Else
                        itm = New ListItem
                        itm.Value = Null.NullString
                        itm.Text = "--- Chọn tỉnh ---"
                        Me.cboTinh.DataSource = obj.ListNTP_DM_TINHALL()
                        Me.cboTinh.DataBind()
                        Me.cboTinh.Items.Insert(0, itm)
                    End If
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        
        Private Sub BindComboHuyen(ByVal Id_Tinh As String)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENController
            Dim objH As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController

            Dim itm As ListItem
            Try
                If OptDVDT.SelectedValue = 1 Then
                    Me.CmbHuyen.DataSource = objH.GetByBenVien(Me.CurrentUserStock.ID_BENHVIEN, Id_Tinh)
                    Me.CmbHuyen.DataBind()
                Else
                    itm = New ListItem
                    itm.Value = Null.NullString
                    itm.Text = "--- Chọn cơ sở y tế ---"
                    Me.CmbHuyen.DataSource = obj.ListNTP_DM_BENHVIEN(Id_Tinh)
                    Me.CmbHuyen.DataBind()
                    Me.CmbHuyen.Items.Insert(0, itm)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub grdDSBenhNhan_ItemCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBenhNhan.ItemCommand
            ' Response.Write(e.Item.Cells(1).Text)
            If e.CommandName = "edit" Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(1).Text & "&ChonTab=1 &MaBN=" & e.Item.Cells(3).Text & "&idDieuTri=" & e.Item.Cells(2).Text))
            End If
        End Sub

      

        Protected Sub grdDSBenhNhanDieuTri_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBenhNhanDieuTri.ItemCommand
            If e.CommandName = "edit" Then
                txtMaBenhNhan.Text = e.Item.Cells(1).Text
                TxtSoDKDT.Text = e.Item.Cells(3).Text
                If Not txtMaBenhNhan.Text = "" Or txtMaBenhNhan.Text Is Nothing Then
                    Dim objBenhNhanh As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                    Dim infBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
                    infBenhNhan = objBenhNhanh.Get(txtMaBenhNhan.Text)
                    If Not infBenhNhan Is Nothing Then
                        LoadBenhNhan(infBenhNhan)
                        BindgrdDSDieuTri(txtMaBenhNhan.Text)
                    End If
                End If

            End If
        End Sub
        Protected Sub BindgrdDSDieuTri(ByVal MaBenhNhan As String)
            Try
                Dim objDieuTri As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIController
                '    If MaBenhNhan <> "" Then
                grdDSDieuTri.DataSource = objDieuTri.ListByID_BenhNhan(MaBenhNhan, Me.CurrentUserStock.ID_BENHVIEN)
                grdDSDieuTri.DataBind()


                '   End If

            Catch ex As Exception
                'Response.Write(ex.ToString)
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Protected Sub LoadBenhNhan(ByVal infBenhNhan As NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo)
            Try
                Me.txtDiaChi.Text = infBenhNhan.Diachi
                Me.txtTenBenhNhan.Text = infBenhNhan.HoTen
                Me.txtMaBenhNhan.Text = infBenhNhan.ID_Benhnhan
                '  BindComboHuyen(infBenhNhan.MA_TINH)
                ' Me.cboHuyen.SelectedValue = infBenhNhan.MA_HUYEN
                Me.txtSoCMT.Text = infBenhNhan.SoCMND
                Me.txtDienThoai.Text = infBenhNhan.Sodienthoai
                Me.txtTuoi.Text = infBenhNhan.Tuoi
                If infBenhNhan.Gioitinh = False Then
                    Me.optlistGioiTinh.SelectedValue = 0
                Else
                    Me.optlistGioiTinh.SelectedValue = 1
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        'Private Sub BindComboHuyen(ByVal sTinh As String)
        '    Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        '    Dim itm As ListItem
        '    Try
        '        itm = New ListItem
        '        itm.Value = Null.NullString
        '        itm.Text = "--- Chọn huyện ---"
        '        Me.cboHuyen.DataSource = obj.Search("", sTinh)
        '        Me.cboHuyen.DataBind()
        '        Me.cboHuyen.Items.Insert(0, itm)
        '    Catch ex As Exception
        '        ProcessModuleLoadException(Me, ex)
        '    Finally
        '        obj = Nothing
        '    End Try
        'End Sub


        Protected Sub grdDSDieuTri_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSDieuTri.ItemCommand
            If e.CommandName = "edit" Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&idBenhNhan=" & txtMaBenhNhan.Text & "&idDieuTri=" & e.Item.Cells(2).Text & "&ChonTab=0"))
            End If
        End Sub

        Protected Sub cmdTim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTim.Click
            BindSeach()
            Me.txtMaBenhNhan.Text = ""
            Me.TxtSoDKDT.Text = ""
            Me.txtDiaChi.Text = ""
            Me.txtTenBenhNhan.Text = ""
            Me.txtMaBenhNhan.Text = ""
            Me.txtSoCMT.Text = ""
            Me.txtDienThoai.Text = ""
            Me.txtTuoi.Text = ""
            Me.optlistGioiTinh.SelectedValue = 1
            BindgrdDSDieuTri("")
	  If OptDVDT.SelectedValue <> 1 Then
                If cboTinh.SelectedValue = Me.CurrentUserStock.ID_MATINH Then
                    If Me.CurrentUserStock.ID_BENHVIEN <> CmbHuyen.SelectedValue Then
                        cmdXoa.Enabled = False
                    Else
                        cmdXoa.Enabled = True
                    End If
                Else
                    cmdXoa.Enabled = False
                End If
            Else
                cmdXoa.Enabled = True
            End If
        End Sub
        Private Sub BindComboPhanLoaiBenh()
            Dim obj As New NTP_BN_DM_PHANLOAIBENH.NTP_BN_DM_PhanLoaiBenhController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn phân loại bệnh ---"
                Me.cboPhanLoaiBenh.DataSource = obj.List()
                Me.cboPhanLoaiBenh.DataBind()
                Me.cboPhanLoaiBenh.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub BindSeach()
            ' Dim DieuKien As String = Me.cboDieuKien.SelectedValue
            Dim DVDT As String, PLBN As Integer
		dim tngay as date
		Dim dtNgay As Date
            Try
                DVDT = ""
                If OptDVDT.SelectedValue = 1 Then
                    DVDT = Me.CurrentUserStock.ID_BENHVIEN
                Else
                    DVDT = CmbHuyen.SelectedValue
                End If
                If cboPhanLoaiBenh.SelectedValue <> "" Then
                    PLBN = cboPhanLoaiBenh.SelectedValue
                Else
                    PLBN = 0
                End If
                Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
'                  Response.Write( IIf(TxtDenngay.Text = "", Now, TxtDenngay.Text))
		 tNgay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                
		 dtNgay = CType(NTP_Common.GetValue(Me.TxtDenngay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                ' response.write (tNgay )
 
                If OptDVDT.SelectedValue = 1 Then ' tim kiem tai dv logon
                    '                    grdDSBenhNhanDieuTri.DataSource = objBenhNhan.NTP_BN_DIEUTRI_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", txtTuNgay.Text), IIf(TxtDenngay.Text = "", Now, TxtDenngay.Text), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, "", PLBN, 1)
                    grdDSBenhNhanDieuTri.DataSource = objBenhNhan.NTP_BN_DIEUTRI_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tngay), IIf(TxtDenngay.Text = "", Now, dtNgay), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, PLBN, 0)
                Else
                    grdDSBenhNhanDieuTri.DataSource = objBenhNhan.NTP_BN_DIEUTRI_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tngay), IIf(TxtDenngay.Text = "", Now, dtNgay), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, PLBN, 1)
                End If
                grdDSBenhNhanDieuTri.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                Response.Write(ex.ToString)
            End Try
        End Sub

        Protected Sub cmdAddDieuTri_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAddDieuTri.Click
         '     Response.Write(TxtSoDKDT.Text)
            If txtMaBenhNhan.Text = "" Or txtMaBenhNhan.Text Is Nothing Then
                ' DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần chọn bệnh nhân trên danh sách", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
            Else
                
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&idBenhNhan=" & txtMaBenhNhan.Text & "&SoDangky=" & TxtSoDKDT.Text))
            End If
        End Sub

        Protected Sub grdDSBenhNhanDieuTri_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBenhNhanDieuTri.PageIndexChanged
            grdDSBenhNhanDieuTri.CurrentPageIndex = e.NewPageIndex
            Dim DVDT As String, PLBN As Integer
		dim tngay as date
		Dim dtNgay As Date
 		tNgay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                
		 dtNgay = CType(NTP_Common.GetValue(Me.TxtDenngay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                
            Try
                DVDT = ""
                If OptDVDT.SelectedValue = 1 Then
                    DVDT = Me.CurrentUserStock.ID_BENHVIEN
 		Else
                    DVDT = CmbHuyen.SelectedValue
                End If
                
                If cboPhanLoaiBenh.SelectedValue <> "" Then
                    PLBN = cboPhanLoaiBenh.SelectedValue
                Else
                    PLBN = 0
                End If
                Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                '  Response.Write(Me.cboRaVien.SelectedValue & "," & Me.CurrentUserStock.ID_BENHVIEN)
               ' grdDSBenhNhanDieuTri.DataSource = objBenhNhan.NTP_BN_DIEUTRI_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tNgay), IIf(TxtDenngay.Text = "", Now, dtNgay ), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, PLBN, 1)
		 If OptDVDT.SelectedValue = 1 Then ' tim kiem tai dv logon
'                    grdDSBenhNhanDieuTri.DataSource = objBenhNhan.NTP_BN_DIEUTRI_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", txtTuNgay.Text), IIf(TxtDenngay.Text = "", Now, TxtDenngay.Text), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, PLBN, 1)
                   grdDSBenhNhanDieuTri.DataSource = objBenhNhan.NTP_BN_DIEUTRI_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tngay), IIf(TxtDenngay.Text = "", Now,dtNgay ), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, PLBN, 0)
               Else
                    grdDSBenhNhanDieuTri.DataSource = objBenhNhan.NTP_BN_DIEUTRI_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tngay), IIf(TxtDenngay.Text = "", Now, dtngay), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, PLBN, 1)
               End If                
		grdDSBenhNhanDieuTri.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                Response.Write(ex.ToString)
            End Try
        End Sub

        Protected Sub grdDSBenhNhan_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBenhNhan.PageIndexChanged
            Dim objPhieuChuyenBenhNhan As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            grdDSBenhNhan.DataSource = objPhieuChuyenBenhNhan.ListByDVTiepNhan(Me.CurrentUserStock.ID_BENHVIEN)
            grdDSBenhNhan.DataBind()
        End Sub


        Protected Sub CmdDSBenhnhan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdDSBenhnhan.Click
            pnlChuyenDen.Visible = False
            pnlDieuTri.Visible = True
            pnlDieuTri.Visible = True
            CmdDSBenhnhan.BackColor = Color.LightCyan
            CmdChuyenden.BackColor = Color.WhiteSmoke()
            CmdChuyenden.Font.Underline = False
            CmdDSBenhnhan.Font.Underline = True
            cmdTim_Click(sender, e)
        End Sub

        Protected Sub CmdChuyenden_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdChuyenden.Click
            pnlChuyenDen.Visible = True
            pnlDieuTri.Visible = False
            pnlDieuTri.Visible = False
            pnlChuyenDen.Visible = True
            CmdDSBenhnhan.BackColor = Color.WhiteSmoke
            CmdChuyenden.BackColor = Color.LightCyan
            CmdChuyenden.Font.Underline = True
            CmdDSBenhnhan.Font.Underline = False
            Dim objPhieuChuyenBenhNhan As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController

            grdDSBenhNhan.DataSource = objPhieuChuyenBenhNhan.ListByDVTiepNhan(Me.CurrentUserStock.ID_BENHVIEN)
            grdDSBenhNhan.DataBind()
           ' CmdChuyenden.Text = "Danh sách bệnh nhân chuyển đến (" & grdDSBenhNhan.Items.Count & ")"
		if grdDSBenhNhan.Items.Count>0 then
			
			CmdChuyenden.ForeColor =color.red
		else
			 CmdChuyenden.ForeColor =color.blue
		end if

        End Sub

        Protected Sub cmdThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdXoa.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIController
            Dim inf As New NTP_BN_DIEUTRI.NTP_BN_DIEUTRIInfo

            Try
                For Each itm In Me.grdDSDieuTri.SelectedItems
                    inf = obj.NTP_BN_DIEUTRI_SelectByDVDieutri(itm.Cells(2).Text, Me.CurrentUserStock.ID_BENHVIEN)
                    If inf.RV = True Then
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bệnh nhân không điều trị tại cơ sở đang truy cập. Không thể xóa ", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
                        Exit Sub
                    End If
                    'Response.Write(itm.Cells(2).Text)
                    obj.Delete(itm.Cells(2).Text)
                Next
                BindgrdDSDieuTri(txtMaBenhNhan.Text)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub



        Protected Sub OptDVDT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptDVDT.SelectedIndexChanged
            BindComboTinh()
            BindComboHuyen(cboTinh.SelectedValue)
            If OptDVDT.SelectedValue = 1 Then
                cboTinh.Enabled = False
                cboHuyen.Enabled = False
            Else
                cboTinh.Enabled = True
                cboHuyen.Enabled = True
            End If
        End Sub

        Protected Sub cboTinh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTinh.SelectedIndexChanged
            If cboTinh.SelectedValue <> "" Then
                BindComboHuyen(cboTinh.SelectedValue)
                NTP_Common.SetFormFocus(CmbHuyen, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        End Sub

       
       
      

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles InDSach.Click
            Dim url As String
            Dim tngay As Date
            Dim dtNgay As Date
            Dim DK As String
            tngay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
            dtNgay = CType(NTP_Common.GetValue(Me.TxtDenngay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
            If cboPhanLoaiBenh.SelectedValue = "" Then
                DK = ""
            Else
                DK = " AND  DT.ID_PhanLoaiBenh=" & cboPhanLoaiBenh.SelectedValue
            End If

            If cboTinh.SelectedValue = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần chọn Tỉnh/ Thành phố khi in.", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
            Else
                url = Request.ApplicationPath & "/Report/form/BaoCaoKhac.aspx?&Opt=2&Matinh=" & cboTinh.SelectedValue & "&MaHuyen=" & IIf(CmbHuyen.SelectedValue = "", "ALL", CmbHuyen.SelectedValue) & "&Tungay=" & IIf(txtTuNgay.Text = "", "01/01/1800", tngay) & "&Denngay=" & IIf(TxtDenngay.Text = "", "01/01/1753", dtNgay) & "&Dieukien=" & DK
                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
            End If
        End Sub
    End Class

End Namespace
