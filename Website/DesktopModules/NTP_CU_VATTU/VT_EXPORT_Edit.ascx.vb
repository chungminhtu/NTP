
Public Class VT_EXPORT_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                BindComboThuoc()
                BindComboNGUONKINHPHI()
                BindComboLYDONHAPXUAT()
                BindComboDonVI()
                'Date now
                NTP_Common.SetValue(Me.NGAY_XUAT_KHO, Now, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                If Not Request.QueryString("id") Is Nothing Then
                    'Neu trang thai da khoa so thi ko co nut sua, xoa
                    SetInfo(Request.QueryString("id"))
                    'If inf.TRANG_THAI = NTP_Common.enuBILL_STATUS.LOCK Then
                    '    Me.cmdSave.Enabled = False
                    '    Me.cmdCancel.Enabled = False
                    'End If
                End If
                NTP_Common.SetFormFocus(Me.MA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            'obj = Nothing
            'inf = Nothing
        End Try
    End Sub

    Private Sub BindComboDonVI()
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Try
            Me.cboDONVI.DataSource = obj.DanhsachBVTheoDonVi(Me.CurrentUserStock.ID_KHO_THUOC)
            Me.cboDONVI.DataBind()
            'Me.cboDONVI.Items.Insert(0, (New ListItem("--- Tất cả ---", Null.NullInteger)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboThuoc()
        Dim ds As New DataSet
        Try
            ds = (New NTP_QLVT.NTP_QLVT_DM_VATTU_BO).SelectAllItems(NTP_Common.enuTYPE_VATTU_HOACHAT.VATTU)

            Me.cboThuoc.DataSource = ds.Tables(0)
            Me.cboThuoc.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            ds = Nothing
        End Try
    End Sub

    'Private Sub BindGrid(ByVal iID_PHIEUNHAP As Double)
    '    Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUNHAP_CHITIET_BO
    '    Try
    '        Me.grdDS.DataSource = obj.Search(iID_PHIEUNHAP)
    '        Me.grdDS.DataBind()
    '        Me.grdDS.Visible = True
    '    Catch ex As Exception
    '        ProcessModuleLoadException(Me, ex)
    '    Finally
    '        obj = Nothing
    '    End Try
    'End Sub

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
            'Me.cboLYDO_NHAPXUAT.Items.Insert(0, (New ListItem("--- Tất cả ---", Null.NullInteger)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Private Sub SetInfo(ByVal ID As Integer)
        Dim obj As New NTP_QLVT.NTP_CU_VT_EXPORT_BO
        Dim inf As New NTP_QLVT.NTP_CU_VT_EXPORT_Info

        inf = obj.SelectItem(ID)

        Me.CurrentUserStock.ID_KHO_THUOC = inf.ID_KHO
        Me.MA_PHIEU.Text = inf.MA_PHIEU
        NTP_Common.SetValue(Me.NGAY_XUAT_KHO, inf.NGAY_XUAT_KHO, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        Me.cboNGUON_KINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
        Me.NGUOI_VIETPHIEU.Text = inf.NGUOI_VIETPHIEU
        Me.cboThuoc.SelectedValue = inf.ID_VATTU
        'Me.LO_SX.Text = inf.LO_SX
        'NTP_Common.SetValue(Me.HAN_DUNG, inf.HAN_DUNG, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        Me.ID_IMPORT.Text = inf.ID_EXPORT
        Me.SO_LUONG.Text = inf.SO_LUONG
        Me.cboLYDO_NHAPXUAT.SelectedValue = inf.LOAI_XUAT
        If inf.LOAI_XUAT = 7 Then
            'Xuat cho don vi khac
            Me.cboDONVI.SelectedValue = inf.ID_KHO_NHAN
            Me.cboDONVI.Enabled = True
        Else
            'Xuat su dung
            Me.cboDONVI.Enabled = False
        End If

    End Sub

    Private Function GetInfo() As NTP_QLVT.NTP_CU_VT_EXPORT_Info
        Dim inf As New NTP_QLVT.NTP_CU_VT_EXPORT_Info
        inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC
        inf.MA_PHIEU = Me.MA_PHIEU.Text
        inf.NGAY_XUAT_KHO = NTP_Common.GetValue(Me.NGAY_XUAT_KHO, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        inf.ID_NGUONKINHPHI = Me.cboNGUON_KINHPHI.SelectedValue
        inf.NGUOI_VIETPHIEU = Me.NGUOI_VIETPHIEU.Text
        inf.ID_VATTU = Me.cboThuoc.SelectedValue
        'inf.LO_SX = Me.LO_SX.Text
        'inf.HAN_DUNG = NTP_Common.GetValue(Me.HAN_DUNG, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        inf.SO_LUONG = Me.SO_LUONG.Text
        inf.LOAI_XUAT = Me.cboLYDO_NHAPXUAT.SelectedValue
        If inf.LOAI_XUAT = 7 Then
            'Xuat cho don vi khac
            inf.ID_KHO_NHAN = Me.cboDONVI.SelectedValue
        Else
            'Xuat su dung
            inf.ID_KHO_NHAN = Null.NullInteger
        End If

        Return inf
    End Function

    Private Sub ClearTextBox()

        Me.MA_PHIEU.Text = ""
        'Me.NGAY_NHAP_KHO.Text = ""

        Me.NGUOI_VIETPHIEU.Text = ""
        'Me.LO_SX.Text = ""
        'Me.HAN_DUNG.Text = ""
        Me.SO_LUONG.Text = ""
        Me.ID_IMPORT.Text = ""

    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim obj As New NTP_QLVT.NTP_CU_VT_EXPORT_BO
        Dim inf As New NTP_QLVT.NTP_CU_VT_EXPORT_Info
        Try
            'Save detail
            inf = GetInfo()
            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)
                NTP_Common.SetFormFocus(Me.MA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
                'Set 
            Else
                'Update
                inf.ID_EXPORT = Me.ID_IMPORT.Text
                obj.UpdateItem(inf)
                '
                Response.Redirect(NavigateURL())
            End If
            NTP_Common.SetFormFocus(Me.MA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            '
            ClearTextBox()
            Skins.Skin.AddModuleMessage(Me, "Thông tin đã được ghi lại", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
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

    'Protected Sub cboLYDO_NHAPXUAT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLYDO_NHAPXUAT.SelectedIndexChanged
    '    If cboLYDO_NHAPXUAT.SelectedValue = 7 Then
    '        'Xuat cho don vi
    '        Me.cboDONVI.Enabled = True
    '        NTP_Common.SetFormFocus(Me.cboDONVI, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
    '    Else
    '        Me.cboDONVI.Enabled = False
    '        NTP_Common.SetFormFocus(Me.cboThuoc, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
    '    End If
    'End Sub

    'Protected Sub cmdCheckLo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCheckLo.Click
    '    Dim obj As New NTP_QLTTB.NTP_CU_Ttb_KHO_BO
    '    Dim dtNgayNhap As Date
    '    Dim Soluong As Double
    '    dtNgayNhap = NTP_Common.GetValue(Me.NGAY_XUAT_KHO, NTP_Common.enuDATA_TYPE.DATE_TYPE)
    '    Soluong = obj.CheckLoSX(Me.CurrentUserStock.ID_KHO_THUOC, dtNgayNhap.Month, dtNgayNhap.Year, cboNGUON_KINHPHI.SelectedValue, cboThuoc.SelectedValue, Me.LO_SX.Text.Trim, NTP_Common.GetValue(HAN_DUNG, NTP_Common.enuDATA_TYPE.DATE_TYPE))

    '    If Soluong = 0 Then
    '        Skins.Skin.AddModuleMessage(Me, "Lô sản xuất không tồn tại", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
    '    Else
    '        Skins.Skin.AddModuleMessage(Me, "Lô sản xuất hợp lệ", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
    '    End If
    'End Sub
End Class
