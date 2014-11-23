Imports NTP_Common.mdlGlobal
Partial Class QLT_PHIEU_XUAT_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase
    Dim ID_PhieuXuat As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLT.QLT_PHIEU_XUAT_BO
        Dim inf As New NTP_QLT.QLT_PHIEU_XUAT_Info
        '  Dim a As DataSet

     
        If Not IsPostBack Then
           


            Me.txtPhieu_Xuat_Chi_Tiet_Id.Text = "0"
            If Not Request.QueryString("id") Is Nothing Then
                inf = obj.SelectItem(Request.QueryString("id"))

                BindComboBoxID_NGUONKINHPHI()
                BindComboBoxID_DONVI_NHAP()
                'BindComboBoxLyDo_Nhap()
                BindComboBoxDM_Thuoc()

                Me.txtMA_PHIEU_NHAP.Text = inf.MA_PHIEUXUAT.ToString
                SetValue(Me.txtTuNgay, inf.NGAY_XUAT, enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.dtmHan_SuDung, Now, enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.dtmNgay_SX, Now, enuDATA_TYPE.DATE_TYPE)
                Me.txtNAM.Text = inf.NAM
                Me.txtTRANG_THAI.Text = inf.TRANG_THAI
                Me.cboDONVI_NHAP.SelectedValue = inf.ID_DONVI_XUAT
                Me.cboLYDO_NHAPXUAT.SelectedValue = inf.ID_LYDO_NHAPXUAT
                Me.cboNGUONKINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
                Me.txtNGUOI_NHAP.Text = inf.NGUOI_XUAT
                Me.txtPhieu_Xuat.Text = inf.ID_PHIEUXUAT
                Me.txtKY_KIEMKE.Text = inf.ID_KY_KIEMKE
                Me.txtID_PHIEUXUAT.Text = Request.QueryString("id")
                BindDaTaGrid()
                SetVisible()
            Else
                Me.txtID_PHIEUXUAT.Text = "0"
                SetValue(Me.txtTuNgay, Now, enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.dtmHan_SuDung, Now, enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.dtmNgay_SX, Now, enuDATA_TYPE.DATE_TYPE)
                BindComboBoxID_NGUONKINHPHI()
                BindComboBoxID_DONVI_NHAP()
                ' BindComboBoxLyDo_Nhap()
                BindComboBoxDM_Thuoc()
                BindDaTaGrid()
                SetInvisible()
            End If
            'If Request.QueryString("TrangThai") = "1" Then
            '    Me.cmdSave.Enabled = False
            '    Me.cmdOK.Enabled = False
            '    Me.cmdDelete.Enabled = False
            'End If
        End If
    End Sub
    Private Sub BindComboBoxDM_Thuoc()
        Dim bibi As New NTP_DANHMUC.NTP_DM_THUOC_BO
        Me.cboThuoc.DataSource = bibi.SelectAllItems
        Me.cboThuoc.DataBind()
        'bibi = Nothing
    End Sub
    Private Sub BindComboBoxID_NGUONKINHPHI()
        Dim bibi As New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO
        If Request.QueryString("id") Is Nothing Then
            Me.cboNGUONKINHPHI.DataSource = bibi.SelectAllItems
        Else
            Me.cboNGUONKINHPHI.DataSource = bibi.SelectAllItems
            '  Me.cboNGUONKINHPHI.DataSource = bibi.SelectItem(Request.QueryString("ID_NGUONKINHPHI"))
        End If
        Me.cboNGUONKINHPHI.DataBind()
        bibi = Nothing
    End Sub

    Private Sub BindComboBoxID_DONVI_NHAP()
        Dim bibi As New NTP_QLT.QLT_DM_KHO_BO
        If Request.QueryString("id") Is Nothing Then
            Me.cboDONVI_NHAP.DataSource = bibi.SelectAllItems
        Else
            Me.cboDONVI_NHAP.DataSource = bibi.SelectAllItems
            'Me.cboDONVI_NHAP.DataSource = bibi.SelectAllItems
        End If
        Me.cboDONVI_NHAP.DataBind()
        bibi = Nothing
    End Sub
    Private Sub BindComboBoxLyDo_Nhap()
        Dim bibi As New NTP_DANHMUC.NTP_DM_LYDO_NHAPXUAT_BO
        If Request.QueryString("id") Is Nothing Then
            Me.cboLYDO_NHAPXUAT.DataSource = bibi.Search("X")
        Else
            Me.cboLYDO_NHAPXUAT.DataSource = bibi.Search("X")
            'Me.cboLYDO_NHAPXUAT.DataSource = bibi.SelectAllItems
        End If

        Me.cboLYDO_NHAPXUAT.DataBind()
        bibi = Nothing
    End Sub
    Private Sub BindDaTaGrid()
        Try
            Dim a As New NTP_QLT.QLT_PHIEU_XUAT_CHI_TIET_BO
            Me.grdDS.DataSource = a.SearchItem(CInt(Me.txtID_PHIEUXUAT.Text))
            Me.grdDS.DataBind()
        Catch ex As Exception
            Me.grdDS.DataSource = Nothing
        End Try
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim obj As New NTP_QLT.QLT_PHIEU_XUAT_BO
        Dim inf As New NTP_QLT.QLT_PHIEU_XUAT_Info
        'Check đã khóa sổ hay chưa
        '-------------------------
        Dim obj1 As New NTP_QLT.QLT_KY_KIEMKE_BO
        Dim Max_KyKiemKe As Integer

        Max_KyKiemKe = obj1.GetKyDaKiemKe(Me.CurrentUserStock.ID_KHO_THUOC, Year(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE)))
        If CInt(Me.txtTuNgay.Text.Substring(3, 2)) <= Max_KyKiemKe Then
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu tháng này đã được khóa", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Else
            '-------------------------

            Try
                inf.GHI_CHU = Me.txtGHI_CHU.Text
                'inf.ID_DONVI_NHAP = 1 ' Doan nay co phai bo di ko ???
                inf.ID_DONVI_NHAP = Me.CurrentUserStock.ID_KHO_THUOC
                inf.ID_LYDO_NHAPXUAT = Me.cboLYDO_NHAPXUAT.SelectedValue
                inf.ID_NGUONKINHPHI = Me.cboNGUONKINHPHI.SelectedValue
                inf.ID_KY_KIEMKE = 1 'Me.txtKY_KIEMKE.Text
                inf.NAM = CInt(Me.txtTuNgay.Text.Substring(6, 4))
                inf.NGAY_XUAT = GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE)
                'inf.NGAY_NM = GetValue(Me.Ngay_NM, enuDATA_TYPE.DATE_TYPE)
                inf.NGUOI_XUAT = Me.txtNGUOI_NHAP.Text
                inf.TRANG_THAI = 0
                inf.MA_PHIEUXUAT = Me.txtMA_PHIEU_NHAP.Text
                'inf.ID_DONVI_XUAT = Me.cboDONVI_NHAP.SelectedItem.Value
                inf.ID_DONVI_XUAT = Me.CurrentUserStock.ID_KHO_THUOC
                inf.NGUOI_NM = Me.UserId
                'inf.ID_PHIEUNHAP = Request.QueryString("id")

                If (Request.QueryString("id") Is Nothing) And (Me.txtID_PHIEUXUAT.Text = "0") Then
                    'Add
                    Me.txtID_PHIEUXUAT.Text = CInt(obj.InsertItem(inf))
                ElseIf Request.QueryString("id") IsNot Nothing Then
                    'Update
                    inf.ID_PHIEUXUAT = Request.QueryString("id")
                    obj.UpdateItem(inf)
                Else
                    inf.ID_PHIEUXUAT = CInt(Me.txtID_PHIEUXUAT.Text)
                    obj.UpdateItem(inf)
                End If
                'If Request.QueryString("id") Is Nothing Then
                '    'Add
                '    Me.txtID_PHIEUXUAT.Text = CInt(obj.InsertItem(inf))
                'Else
                '    'Update
                '    inf.ID_PHIEUXUAT = Request.QueryString("id")
                '    obj.UpdateItem(inf)
                'End If
                SetVisible()
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
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

    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Request.QueryString("TrangThai") = "1" Then
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu tháng này đã được khóa", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Exit Sub
        End If
        If Me.cboLoSX.SelectedValue = Nothing Then
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Lô sản xuất không hợp lệ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Exit Sub
        End If
        Dim obj As New NTP_QLT.QLT_PHIEU_XUAT_CHI_TIET_BO
        Dim inf As New NTP_QLT.QLT_PHIEU_XUAT_CHI_TIET_Info
        Try
            inf.HAN_SUDUNG = GetValue(Me.dtmHan_SuDung, enuDATA_TYPE.DATE_TYPE)
            inf.ID_PHIEUXUAT = CInt(Me.txtID_PHIEUXUAT.Text)
            inf.ID_THUOC = Me.cboThuoc.SelectedValue
            'inf.LO_SX = Me.txtLO_SX.Text
            inf.LO_SX = Me.cboLoSX.SelectedItem.Text
            inf.NGAY_SX = GetValue(Me.dtmNgay_SX, enuDATA_TYPE.DATE_TYPE)
            inf.SO_LUONG = Me.txtSO_LUONG.Text
            If Me.txtPhieu_Xuat_Chi_Tiet_Id.Text = "0" Then
                'Add
                obj.InsertItem(inf)
            Else
                'Update
                inf.ID_PHIEUXUAT_CHITIET = CInt(Me.txtPhieu_Xuat_Chi_Tiet_Id.Text)
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
            Me.txtPhieu_Xuat_Chi_Tiet_Id.Text = "0"
        End Try
        BindDaTaGrid()
    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            Me.cboThuoc.SelectedValue = e.Item.Cells(4).Text
            Try
                BindLoSX(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)
            Catch ex As Exception

            End Try

            Me.cboLoSX.SelectedValue = e.Item.Cells(6).Text
            Me.dtmHan_SuDung.Text = e.Item.Cells(7).Text
            Me.dtmNgay_SX.Text = e.Item.Cells(8).Text
            'SetValue(Me.dtmHan_SuDung, e.Item.Cells(7).Text, enuDATA_TYPE.DATE_TYPE)
            'SetValue(Me.dtmNgay_SX, e.Item.Cells(8).Text, enuDATA_TYPE.DATE_TYPE)
            Me.txtSO_LUONG.Text = e.Item.Cells(9).Text
            Me.txtPhieu_Xuat_Chi_Tiet_Id.Text = e.Item.Cells(2).Text
        End If
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Request.QueryString("TrangThai") = "1" Then
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu tháng này đã được khóa", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Exit Sub
        End If

        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.QLT_PHIEU_XUAT_CHI_TIET_BO
        Try
            For Each itm In Me.grdDS.Items
                Dim ctl As CheckBox
                ctl = itm.Cells(0).FindControl("grdCmdSel")
                If Not ctl Is Nothing Then
                    If ctl.Checked Then
                        obj.DeleteItem(itm.Cells(2).Text)
                    End If
                End If

            Next
            BindDaTaGrid()
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub
    Private Sub SetVisible()
        Me.grdDS.Visible = True
        Me.ID_THUOCLabel.Visible = True
        Me.HAN_SUDUNGLabel.Visible = True
        Me.SO_LUONGLabel.Visible = True
        Me.LO_SXLabel.Visible = True
        Me.NGAY_SXLabel.Visible = True
        ' Me.LO_SXRequiredFieldValidator.Visible = True
        Me.cboLoSX.Visible = True
        Me.ID_THUOCRequiredFieldValidator.Visible = True
        Me.SO_LUONGRequiredFieldValidator.Visible = True
        Me.ID_THUOCRequiredFieldValidator.Visible = True
        Me.dtmHan_SuDung.Visible = True
        Me.dtmNgay_SX.Visible = True
        Me.cboThuoc.Visible = True
        Me.dtmNgay_SX.Visible = True
        Me.dtmHan_SuDung.Visible = True
        Me.txtSO_LUONG.Visible = True
        Me.cmdOK.Visible = True
        'Me.Button2.Visible = True
        'Me.cmdDelete.Visible = True
        'Me.txtLO_SX.Visible = True

    End Sub

    Private Sub SetInvisible()
        Me.grdDS.Visible = False
        Me.ID_THUOCLabel.Visible = False
        Me.HAN_SUDUNGLabel.Visible = False
        Me.SO_LUONGLabel.Visible = False
        Me.LO_SXLabel.Visible = False
        Me.NGAY_SXLabel.Visible = False
        'Me.LO_SXRequiredFieldValidator.Visible = False
        Me.cboLoSX.Visible = False
        Me.ID_THUOCRequiredFieldValidator.Visible = False
        Me.SO_LUONGRequiredFieldValidator.Visible = False
        Me.ID_THUOCRequiredFieldValidator.Visible = False
        Me.dtmHan_SuDung.Visible = False
        Me.dtmNgay_SX.Visible = False
        Me.cboThuoc.Visible = False
        Me.dtmNgay_SX.Visible = False
        Me.dtmHan_SuDung.Visible = False
        Me.txtSO_LUONG.Visible = False
        Me.cmdOK.Visible = False
        'Me.Button2.Visible = False
        'Me.cmdDelete.Visible = False
        Me.txtLO_SX.Visible = False

    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())

    End Sub

    Protected Sub cboThuoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboThuoc.SelectedIndexChanged

        BindLoSX(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)

    End Sub

    Protected Sub BindLoSX(ByVal ID_Thuoc As Integer, ByVal ID_Kho As Integer)
        Dim bibi As New NTP_QLT.QLT_DM_THUOC_BO
        Try
            'Me.cboLoSX.DataSource = bibi.searchLo(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)
            Me.cboLoSX.DataSource = bibi.searchLo(ID_Thuoc, ID_Kho)
            Me.cboLoSX.DataBind()
        Catch ex As Exception
            Me.cboLoSX.DataSource = Nothing
        End Try
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        grdDS.CurrentPageIndex = e.NewPageIndex
        BindDaTaGrid()
    End Sub
End Class
