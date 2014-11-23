
Public Class NTP_QLVT_PHIEUXUAT_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_BO
        Dim inf As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                BindComboVATTU()
                BindComboLYDONHAPXUAT()
                BindComboNGUONKINHPHI()
                BindComboNuoc()
                Me.pnlHeader.Visible = True
                'Date now
                NTP_Common.SetValue(Me.txtNgayXuat, Now, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                If Not Request.QueryString("id") Is Nothing Then
                    Me.txtID_PHIEUXUAT.Text = Request.QueryString("id")
                    inf = obj.SelectItem(Me.txtID_PHIEUXUAT.Text)
                    Me.txtMA_PHIEU.Text = inf.MA_PHIEUXUAT
                    Me.txtNGUOI_XUAT.Text = inf.NGUOI_XUAT
                    Me.txtGhiChu.Text = inf.GHI_CHU
                    'Set text 
                    NTP_Common.SetValue(Me.txtNgayXuat, inf.NGAY_XUAT, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                    Me.cboNGUON_KINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
                    If inf.ID_KHOXUAT > 0 Then
                        Me.txtSearhKhoCapTren.SelectedValue = inf.ID_KHONHAP
                        Me.txtSearhKhoCapTren.Text = (New NTP_QLVT.NTP_QLVT_DM_KHO_BO).SelectItem(inf.ID_KHONHAP).TEN_KHO
                    End If
                    Me.txtID_PHIEUXUAT.Enabled = False
                    Me.pnlDetail.Visible = True
                    'BindDetail
                    BindGrid(Me.txtID_PHIEUXUAT.Text)
                    'Neu la sua thi ko cho tao phieu moi
                    Me.cmdCreateNew.Visible = False
                    'Neu trang thai da khoa so thi ko co nut sua, xoa
                    If inf.TRANG_THAI = NTP_Common.enuBILL_STATUS.LOCK Then
                        Me.cmdCreateNew.Enabled = False
                        Me.cmdAdd.Enabled = False
                        Me.cmdSave.Enabled = False
                        Me.cmdDelete.Enabled = False
                    End If
                Else
                    Me.pnlDetail.Visible = False
                End If
                NTP_Common.SetFormFocus(Me.txtMA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Private Sub BindComboNuoc()
        Dim obj As New NTP_DANHMUC.NTP_DM_NUOC_BO
        Try
            Me.cboNuoc.DataSource = obj.SelectAllItems
            Me.cboNuoc.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try

    End Sub

    Private Sub BindGrid(ByVal iID_PHIEUXUAT As Double)
        Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_CHITIET_BO
        Try
            Me.grdDS.DataSource = obj.Search(iID_PHIEUXUAT)
            Me.grdDS.DataBind()
            Me.grdDS.Visible = True
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboVATTU()
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_VATTU_BO
        Try
            Me.cboVATTU.DataSource = obj.SelectAllItems
            Me.cboVATTU.DataBind()
            ' Me.cboVung.Items.Insert(0, (New ListItem(-1, "")))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboNGUONKINHPHI()
        Dim obj As New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO
        Try
            Me.cboNGUON_KINHPHI.DataSource = obj.SelectAllItems
            Me.cboNGUON_KINHPHI.DataBind()
            ' Me.cboVung.Items.Insert(0, (New ListItem(-1, "")))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboLYDONHAPXUAT()
        Dim obj As New NTP_DANHMUC.NTP_DM_LYDO_NHAPXUAT_BO
        Try
            Me.cboLYDO_NHAPXUAT.DataSource = obj.Search("X")
            Me.cboLYDO_NHAPXUAT.DataBind()
            ' Me.cboVung.Items.Insert(0, (New ListItem(-1, "")))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If Request.QueryString("ctl") Is Nothing Then
            'return home
            Response.Redirect(NavigateURL(PortalSettings.HomeTabId))
        Else
            Response.Redirect(NavigateURL())
        End If
    End Sub

    'Ghi phieu
    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_BO
        Dim inf As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_Info
        Try
            Dim objKy As New NTP_QLVT.NTP_QLVT_KY_KIEMKE_BO
            Dim iStatus As NTP_Common.enuTRANGTHAI_KY_KIEMKE

            Dim dtNgayXuat As Date
            dtNgayXuat = CType(NTP_Common.GetValue(Me.txtNgayXuat, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)

            iStatus = objKy.KiemTraKy(Me.CurrentUserStock.ID_KHO_QLVT, CInt(dtNgayXuat.Month), CInt(dtNgayXuat.Year))
            If iStatus <> NTP_Common.enuTRANGTHAI_KY_KIEMKE.CHUA_KIEMKE Then
                Skins.Skin.AddModuleMessage(Me, "Bạn không thể nhập phiếu trong tháng này do đang tiến hành kiểm kê sổ sách", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Exit Sub
            End If

            inf.MA_PHIEUXUAT = Me.txtMA_PHIEU.Text
            inf.NGAY_XUAT = dtNgayXuat
            inf.ID_NGUONKINHPHI = Me.cboNGUON_KINHPHI.SelectedValue
            inf.ID_LYDO_NHAPXUAT = Me.cboLYDO_NHAPXUAT.SelectedValue
            inf.ID_KHOXUAT = Me.CurrentUserStock.ID_KHO_QLVT
            inf.NAM = dtNgayXuat.Year
            inf.NGUOI_XUAT = Me.txtNGUOI_XUAT.Text
            'Lay ID kho nhap
            If Me.txtSearhKhoCapTren.SelectedValue = String.Empty Then
                inf.ID_KHONHAP = Null.NullInteger
            Else
                inf.ID_KHONHAP = Me.txtSearhKhoCapTren.SelectedValue
            End If
            inf.GHI_CHU = Me.txtGhiChu.Text
            inf.NGUOI_NM = Me.UserId
            If Request.QueryString("id") Is Nothing Then
                'Add
                Me.txtID_PHIEUXUAT.Text = obj.InsertItem(inf)
                'Clear text box
                'Me.txtMA_PHIEU.Text = ""
                'Me.txtID_PHIEUNHAP.Text = ""
                Me.cmdAdd.Enabled = False
                'NTP_Common.SetFormFocus(Me.txtMA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
                'Hien panel detail
                Me.pnlDetail.Visible = True
                Me.grdDS.Visible = True
                'Chuyen sang panel detail
                NTP_Common.SetFormFocus(Me.cboVATTU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
                'Set 
            Else
                'Update
                inf.ID_PHIEUXUAT = Me.txtID_PHIEUXUAT.Text
                obj.UpdateItem(inf)
            End If
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_CHITIET_BO
        Dim inf As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_CHITIET_Info
        Try
            'Save detail
            inf.ID_VATTU = Me.cboVATTU.SelectedValue
            inf.SO_LUONG = Me.txtSoLuong.Text
            inf.LO_SANXUAT = Me.txtLoSX.Text
            inf.ID_PHIEUXUAT = Me.txtID_PHIEUXUAT.Text
            inf.MA_NUOC = Me.cboNuoc.SelectedItem.Value
            inf.HAN_SUDUNG = NTP_Common.GetValue(Me.txtHanSD, NTP_Common.enuDATA_TYPE.DATE_TYPE)

            If Me.txtID_PHIEUXUAT_CHITIET.Text.Trim = "" Then
                'Add
                obj.InsertItem(inf)
            Else
                'Update
                inf.ID_PHIEUXUAT_CHITIET = Me.txtID_PHIEUXUAT_CHITIET.Text
                obj.UpdateItem(inf)
            End If
            NTP_Common.SetFormFocus(Me.cboVATTU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            BindGrid(inf.ID_PHIEUXUAT)

            Me.txtSoLuong.Text = ""
            Me.txtLoSX.Text = ""
            Me.txtHanSD.Text = ""
            Me.txtID_PHIEUXUAT_CHITIET.Text = ""

        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub


    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            'Binddata
            Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_CHITIET_BO
            Dim inf As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_CHITIET_Info
            Try
                inf = obj.SelectItem(e.Item.Cells(2).Text)

                'Get detail
                Me.txtID_PHIEUXUAT_CHITIET.Text = inf.ID_PHIEUXUAT_CHITIET
                Me.cboVATTU.SelectedValue = inf.ID_VATTU
                Me.txtSoLuong.Text = inf.SO_LUONG
                Me.txtLoSX.Text = inf.LO_SANXUAT
                NTP_Common.SetValue(Me.txtHanSD, inf.HAN_SUDUNG, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                Me.cboNuoc.SelectedItem.Value = inf.MA_NUOC
                'Me.txtID_PHIEUNHAP.Text = inf.ID_PHIEUNHAP

                NTP_Common.SetFormFocus(Me.cboVATTU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
                inf = Nothing
            End Try
        End If
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUXUAT_CHITIET_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            grdDS.CurrentPageIndex = 0
            BindGrid(Me.txtID_PHIEUXUAT.Text)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
        'Tao phieu moi
        'Clear cac o text box
        Me.txtID_PHIEUXUAT.Text = ""
        Me.txtID_PHIEUXUAT_CHITIET.Text = ""
        Me.txtMA_PHIEU.Text = ""
        Me.txtNGUOI_XUAT.Text = ""
        Me.txtSearhKhoCapTren.Text = ""
        Me.txtSearhKhoCapTren.SelectedValue = ""
        Me.txtGhiChu.Text = ""
        Me.txtSoLuong.Text = ""
        Me.txtLoSX.Text = ""
        Me.txtHanSD.Text = ""

        'Hide panel detail
        Me.pnlDetail.Visible = False
        'enable nut ghi
        cmdAdd.Enabled = True
        'Clear list
        Me.grdDS.DataSource = Nothing
        Me.grdDS.DataBind()

        'Set focus
        NTP_Common.SetFormFocus(Me.txtMA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
    End Sub
End Class
