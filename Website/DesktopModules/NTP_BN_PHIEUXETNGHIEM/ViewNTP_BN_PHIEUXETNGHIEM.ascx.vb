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

Namespace YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_BN_PHIEUXETNGHIEM
        Inherits Entities.Modules.PortalModuleBase
        Implements Entities.Modules.IActionable

#Region "Private Members"

        Private strTemplate As String
        Private ID_PhieuXetNghiem As Integer

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
                    BindComboTinh()
                    BindComboHuyen(cboTinh.SelectedValue)
       		  
 		    If Month(Now) - 1 = 0 Then
                        txtTuNgay.Text = "01/12" & "/" & Year(Now) - 1
                    Else
                        txtTuNgay.Text = "01/" & Month(Now) - 1 & "/" & Year(Now)

                    End If
                    'txtTuNgay.Text = "01/01/" & Year(Now)

                    If Month(Now) - 1 = 0 Then
                        SetValue(Me.txtTuNgay, "12/01" & "/" & Year(Now) - 1, enuDATA_TYPE.DATE_TYPE)
                    Else
                        SetValue(Me.txtTuNgay, Month(Now) - 1 & "/01" & "/" & Year(Now), enuDATA_TYPE.DATE_TYPE)
                    End If
                    SetValue(Me.TxtDenngay, Now, enuDATA_TYPE.DATE_TYPE)
                    cmdTim_Click(sender, e)

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
        Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBenhNhan.ItemCommand
            If e.CommandName = "edit" Then
                txtMaBenhNhan.Text = e.Item.Cells(1).Text

                If Not txtMaBenhNhan.Text = "" Or txtMaBenhNhan.Text Is Nothing Then
                    Dim objBenhNhanh As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                    Dim infBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo
                    infBenhNhan = objBenhNhanh.Get(txtMaBenhNhan.Text)
                    If Not infBenhNhan Is Nothing Then
                        LoadBenhNhan(infBenhNhan)
                        BindgrdDSXetNghiem(txtMaBenhNhan.Text)
                    End If
                End If

            End If
        End Sub
        Protected Sub BindgrdDSXetNghiem(ByVal MaBenhNhan As String)
            Try
                Dim objXetNghiem As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMController
                 If OptDVDT.SelectedValue = 1 Then                   
			grdDSXetNghiem.DataSource = objXetNghiem.List(MaBenhNhan, Me.CurrentUserStock.ID_BENHVIEN)
		 else
			grdDSXetNghiem.DataSource = objXetNghiem.List(MaBenhNhan, "")
		end if
                grdDSXetNghiem.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        Protected Sub LoadBenhNhan(ByVal infBenhNhan As NTP_BN_BENHNHAN.NTP_BN_BENHNHANInfo)
            Try
                'Me.txtDiaChi.Text = infBenhNhan.Diachi
                Me.txtTenBenhNhan.Text = infBenhNhan.HoTen
                Me.txtMaBenhNhan.Text = infBenhNhan.ID_Benhnhan
                ' BindComboHuyen(infBenhNhan.MA_TINH)
                ' Me.cboHuyen.SelectedValue = infBenhNhan.MA_HUYEN
                Me.txtSoCMT.Text = infBenhNhan.SoCMND
                'Me.txtDienThoai.Text = infBenhNhan.Sodienthoai
                'Me.txtTuoi.Text = infBenhNhan.Tuoi
                'If infBenhNhan.Gioitinh = False Then
                '    Me.optlistGioiTinh.SelectedValue = 0
                'Else
                '    Me.optlistGioiTinh.SelectedValue = 1
                'End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
        

        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

            If txtMaBenhNhan.Text = "" Or txtMaBenhNhan.Text Is Nothing Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
            Else
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&idBenhNhan=" & txtMaBenhNhan.Text))
            End If
        End Sub
        Protected Sub grdDSXetNghiem_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSXetNghiem.ItemCommand
            If e.CommandName = "edit" Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&idBenhNhan=" & txtMaBenhNhan.Text & "&idXetNghiem=" & e.Item.Cells(2).Text))
            End If
        End Sub

        Protected Sub BindSeach()
            ' Dim DieuKien As String = Me.cboDieuKien.SelectedValue
            Dim DVDT As String ', PLBN As Integer
		dim tngay as date
		Dim dtNgay As Date
            tngay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
		 dtNgay = CType(NTP_Common.GetValue(Me.TxtDenngay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                
            Try
              
                DVDT = ""
                If OptDVDT.SelectedValue = 1 Then
                    DVDT = Me.CurrentUserStock.ID_BENHVIEN
                Else
                    DVDT = CmbHuyen.SelectedValue
                End If
                'If cboPhanLoaiBenh.SelectedValue <> "" Then
                '    PLBN = cboPhanLoaiBenh.SelectedValue
                'Else
                '    PLBN = 0
                'End If


                Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController

                If OptDVDT.SelectedValue = 1 Then
                    grdDSBenhNhan.DataSource = objBenhNhan.NTP_BN_XETNGHIEM_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tngay), IIf(TxtDenngay.Text = "", Now, dtNgay), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, "", 0)
                    
                Else
                    grdDSBenhNhan.DataSource = objBenhNhan.NTP_BN_XETNGHIEM_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tngay), IIf(TxtDenngay.Text = "", Now, dtNgay), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, 0)
                End If

                grdDSBenhNhan.DataBind()

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
               Response.Write(ex.ToString)
            End Try
        End Sub


        Protected Sub grdDSBenhNhan_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBenhNhan.PageIndexChanged
            grdDSBenhNhan.CurrentPageIndex = e.NewPageIndex
            Dim DVDT As String ', PLBN As Integer
		dim tngay as date
		Dim dtNgay As Date
            Try
                tngay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                dtNgay = CType(NTP_Common.GetValue(Me.TxtDenngay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                DVDT = ""
                If OptDVDT.SelectedValue = 1 Then
                    DVDT = Me.CurrentUserStock.ID_BENHVIEN
                Else
                    DVDT = CmbHuyen.SelectedValue
                End If
                Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                If OptDVDT.SelectedValue = 1 Then
		    grdDSBenhNhan.DataSource = objBenhNhan.NTP_BN_XETNGHIEM_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tNgay), IIf(TxtDenngay.Text = "", Now, dtNgay ), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, "", 0)
                Else
	            grdDSBenhNhan.DataSource = objBenhNhan.NTP_BN_XETNGHIEM_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/1753", tNgay), IIf(TxtDenngay.Text = "", Now,dtNgay ), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, 0)
                End If
		 grdDSBenhNhan.DataBind()
  Dim itm As DataGridItem
                For Each itm In Me.grdDSBenhNhan.Items
                    If itm.Cells(10).Text = 1 Then
                        itm.Cells(9).ControlStyle.Font.Bold = True
                        itm.Cells(9).ControlStyle.ForeColor = Color.Red
                    End If
                Next
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
               ' Response.Write(ex.ToString)
            End Try
           
        End Sub

       
     
        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMController
            Dim inf As New NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMInfo
            Try

                For Each itm In Me.grdDSXetNghiem.SelectedItems

                    inf = obj.NTP_BN_PHIEUXETNGHIEM_SelectByDVDieutri(itm.Cells(2).Text, Me.CurrentUserStock.ID_BENHVIEN)
                    If inf.Quyen = True Then
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bệnh nhân không Xét nghiệm tại cơ sở đang truy cập. Không thể xóa ", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
                        Exit Sub
                    End If
                    Response.Write(itm.Cells(2).Text)
                    obj.Delete(itm.Cells(2).Text)
                Next
                BindgrdDSXetNghiem(txtMaBenhNhan.Text)

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub grdDSXetNghiem_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSXetNghiem.PageIndexChanged
            If txtMaBenhNhan.Text <> "" Then
                grdDSXetNghiem.CurrentPageIndex = e.NewPageIndex
                BindgrdDSXetNghiem(txtMaBenhNhan.Text)
            End If
        End Sub
     

        Protected Sub cmdTim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTim.Click

           ' BindSeach()

Dim DVDT As String ', PLBN As Integer
		dim tngay as Date
		Dim dtNgay As Date

	 	tNgay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                
		dtNgay = CType(NTP_Common.GetValue(Me.TxtDenngay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)               
           
               ' tngay = CType(NTP_Common.GetValue(Me.txtTuNgay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
               ' dtNgay = CType(NTP_Common.GetValue(Me.TxtDenngay, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                DVDT = ""
                If OptDVDT.SelectedValue = 1 Then
                    DVDT = Me.CurrentUserStock.ID_BENHVIEN
                Else
                    DVDT = CmbHuyen.SelectedValue
                End If
            Dim objBenhNhan As New NTP_BN_BENHNHAN.NTP_BN_BENHNHANController

        '       response.write (tNgay )
	' response.write (txtTuNgay.text)
	            grdDSBenhNhan.DataSource = objBenhNhan.NTP_BN_XETNGHIEM_Finds(TxtDiachiTK.Text, IIf(txtTuNgay.Text = "", "01/01/2000", tNgay), IIf(TxtDenngay.Text = "", Now,dtNgay ), TxtMaBN.Text, TxtHotenTK.Text, TxtSoCMTTK.Text, DVDT, cboTinh.SelectedValue, 0)
               
		 grdDSBenhNhan.DataBind()

 


            Dim itm As DataGridItem
            For Each itm In Me.grdDSBenhNhan.Items
                If itm.Cells(10).Text = 1 Then
                    itm.Cells(9).ControlStyle.Font.Bold = True
		    itm.Cells(9).ControlStyle.ForeColor = Color.Red
                End If
            Next
            Me.txtMaBenhNhan.Text = ""
            BindgrdDSXetNghiem(txtMaBenhNhan.Text)
            'Me.txtDiaChi.Text = ""
            Me.txtTenBenhNhan.Text = ""
            Me.txtMaBenhNhan.Text = ""
            Me.txtSoCMT.Text = ""
            ' Me.txtDienThoai.Text = ""
            ' Me.txtTuoi.Text = ""
            ' Me.optlistGioiTinh.SelectedValue = 1
            ' BindgrdDSXetNghiem("")
  		If OptDVDT.SelectedValue <> 1 Then
                If cboTinh.SelectedValue = Me.CurrentUserStock.ID_MATINH Then
                    If Me.CurrentUserStock.ID_BENHVIEN <> CmbHuyen.SelectedValue Then
                        cmdDelete.Enabled = False
                    Else
                        cmdDelete.Enabled = True
                    End If
                Else
                    cmdDelete.Enabled = False
                End If
            Else
                cmdDelete.Enabled = True
            End If
        End Sub

        Protected Sub OptDVDT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptDVDT.SelectedIndexChanged
            BindComboTinh()
            BindComboHuyen(cboTinh.SelectedValue)
            If OptDVDT.SelectedValue = 1 Then
                cboTinh.Enabled = False
                CmbHuyen.Enabled = False
            Else
                cboTinh.Enabled = True
                CmbHuyen.Enabled = True
            End If
        End Sub

        Protected Sub cboTinh_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTinh.SelectedIndexChanged
            If cboTinh.SelectedValue <> "" Then
                BindComboHuyen(cboTinh.SelectedValue)
                NTP_Common.SetFormFocus(CmbHuyen, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        End Sub

        Protected Sub CmdIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdIn.Click
            Dim url As String
            If txtMaBenhNhan.Text = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần chọn bệnh nhân để in.", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)

            Else

                url = Request.ApplicationPath & "/Report/form/BaoCaoKhac.aspx?&Opt=1&ID_maBN=" & txtMaBenhNhan.Text


                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
            End If
        End Sub


    End Class

End Namespace
