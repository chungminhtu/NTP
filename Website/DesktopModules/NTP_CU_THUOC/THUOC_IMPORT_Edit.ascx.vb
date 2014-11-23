
Public Class THUOC_IMPORT_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim obj As New NTP_QLVT.NTP_QLVT_PHIEUNHAP_BO
        'Dim inf As New NTP_QLVT.NTP_QLVT_PHIEUNHAP_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                BindComboThuoc()
                BindComboNGUONKINHPHI()
                BindComboLYDONHAPXUAT()
                'Date now
                NTP_Common.SetValue(Me.NGAY_NHAP_KHO, Now, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                If Not Request.QueryString("id") Is Nothing Then
                    'Neu trang thai da khoa so thi ko co nut sua, xoa
                    SetInfo(Request.QueryString("id"))
                End If
                NTP_Common.SetFormFocus(Me.MA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
           
        End Try
    End Sub

    Private Sub BindComboLYDONHAPXUAT()
        Dim obj As New NTP_DANHMUC.NTP_DM_LYDO_NHAPXUAT_BO
        Try
            Me.cboLYDO_NHAPXUAT.DataSource = obj.Search("N")
            Me.cboLYDO_NHAPXUAT.DataBind()
            'Me.cboLYDO_NHAPXUAT.Items.Insert(0, (New ListItem("--- Tất cả ---", Null.NullInteger)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Private Sub BindComboThuoc()
        Dim ds As New DataSet
        Try
            ds = (New NTP_DANHMUC.NTP_DM_THUOC_BO).SelectAllItems

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


    Private Sub SetInfo(ByVal ID As Integer)
        Dim obj As New NTP_QLT.NTP_CU_THUOC_IMPORT_BO
        Dim inf As New NTP_QLT.NTP_CU_THUOC_IMPORT_Info

        inf = obj.SelectItem(ID)

        Me.CurrentUserStock.ID_KHO_THUOC = inf.ID_KHO
        Me.MA_PHIEU.Text = inf.MA_PHIEU
        NTP_Common.SetValue(Me.NGAY_NHAP_KHO, inf.NGAY_NHAP_KHO, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        Me.cboNGUON_KINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
        Me.NGUOI_VIETPHIEU.Text = inf.NGUOI_VIETPHIEU
        Me.cboThuoc.SelectedValue = inf.ID_THUOC
        Me.LO_SX.Text = inf.LO_SX
        NTP_Common.SetValue(Me.HAN_DUNG, inf.HAN_DUNG, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        NTP_Common.SetValue(Me.NGAY_SX, inf.NGAY_SX, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        Me.ID_IMPORT.Text = inf.ID_IMPORT
        Me.SO_LUONG.Text = inf.SO_LUONG
        Me.cboLYDO_NHAPXUAT.SelectedValue = inf.LOAI_NHAP
        If inf.TRANG_THAI = NTP_Common.enuBILL_STATUS.LOCK Then
            Me.cmdSave.Enabled = False
            Me.cmdCancel.Enabled = False
        End If
    End Sub

    Private Function GetInfo() As NTP_QLT.NTP_CU_THUOC_IMPORT_Info
        Dim inf As New NTP_QLT.NTP_CU_THUOC_IMPORT_Info
        inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC
        inf.MA_PHIEU = Me.MA_PHIEU.Text
        inf.NGAY_NHAP_KHO = NTP_Common.GetValue(Me.NGAY_NHAP_KHO, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        inf.ID_NGUONKINHPHI = Me.cboNGUON_KINHPHI.SelectedValue
        inf.NGUOI_VIETPHIEU = Me.NGUOI_VIETPHIEU.Text
        inf.ID_THUOC = Me.cboThuoc.SelectedValue
        inf.LO_SX = Me.LO_SX.Text
        inf.HAN_DUNG = NTP_Common.GetValue(Me.HAN_DUNG, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        inf.NGAY_SX = NTP_Common.GetValue(Me.NGAY_SX, NTP_Common.enuDATA_TYPE.DATE_TYPE)
        inf.SO_LUONG = Me.SO_LUONG.Text
        inf.LOAI_NHAP = cboLYDO_NHAPXUAT.SelectedValue
        Return inf
    End Function

    Private Sub ClearTextBox()

        Me.MA_PHIEU.Text = ""
        'Me.NGAY_NHAP_KHO.Text = ""

        Me.NGUOI_VIETPHIEU.Text = ""
        Me.LO_SX.Text = ""
        Me.HAN_DUNG.Text = ""
        Me.NGAY_SX.Text = ""
        Me.SO_LUONG.Text = ""
        Me.ID_IMPORT.Text = ""

    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim obj As New NTP_QLT.NTP_CU_THUOC_IMPORT_BO
        Dim inf As New NTP_QLT.NTP_CU_THUOC_IMPORT_Info
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
                inf.ID_IMPORT = Me.ID_IMPORT.Text
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

End Class
