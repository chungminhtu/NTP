Imports NTP_Common.mdlGlobal

Partial Class QLT_KIEM_KE_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindComboBoxDM_Thuoc()
            BindComboBoxDM_TrangThai()
            SetValue(Me.txtTuNgay, Now(), enuDATA_TYPE.DATE_TYPE)
            Me.txtID_PHIEUNHAP.Text = ""
            '  Me.txtKiem_Ke_Chi_Tiet_Id.Text = "0"
        End If

    End Sub

    Private Sub BindComboBoxDM_Thuoc()
        Dim bibi As New NTP_DANHMUC.NTP_DM_THUOC_BO
        Me.cboThuoc.DataSource = bibi.SelectAllItems
        Me.cboThuoc.DataBind()
        'bibi = Nothing
    End Sub

    Private Sub BindComboBoxDM_TrangThai()
        Dim bibi As New NTP_QLT.QLT_DM_TRANG_THAI_BO
        Me.cboTrangThai.DataSource = bibi.SelectAllItems
        Me.cboTrangThai.DataBind()
        'bibi = Nothing
    End Sub

    'Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
    'Dim obj As New NTP_QLT.QLT_KIEMKE_BO
    'Dim inf As New NTP_QLT.QLT_KIEMKE_Info

    'Try
    '    inf.GHI_CHU = Me.txtGHI_CHU.Text
    '    inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC
    '    inf.NGAY_KIEMKE = GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE)
    '    inf.NGUOI_KIEM = Me.UserId
    '    inf.ID_KY_KIEMKE = 1

    '    Me.txtID_PHIEUNHAP.Text = CInt(obj.InsertItem(inf))

    '    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
    'Catch sqlex As SqlException
    '    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
    'Catch ex As Exception
    '    ProcessModuleLoadException(Me, ex)
    'Finally
    '    obj = Nothing
    '    inf = Nothing
    'End Try
    'End Sub

    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        'Check đã khóa sổ hay chưa
        '-------------------------
        Dim obj2 As New NTP_QLT.QLT_KY_KIEMKE_BO
        Dim Max_KyKiemKe As Integer

        Max_KyKiemKe = obj2.GetKyDaKiemKe(Me.CurrentUserStock.ID_KHO_THUOC, Year(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE)))
        If CInt(Me.txtTuNgay.Text.Substring(3, 2)) > Max_KyKiemKe Then
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu tháng này chưa được khóa, bạn không thể kiêm kê kho!", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            'Check tháng này đã được kiểm kê hay chưa
            'ElseIf obj2.CheckDaKiemKe(Me.CurrentUserStock.ID_KHO_THUOC, CInt(Me.txtTuNgay.Text.Substring(6, 4)), CInt(Me.txtTuNgay.Text.Substring(3, 2))) = 1 And Me.txtID_PHIEUNHAP.Text = "" Then
            '    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu tháng này đã được kiểm kê!", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Else
            '-------------------------
            'Ghi tieu de cua phieu kiem ke
            '--------------------------

            Dim obj As New NTP_QLT.QLT_KIEMKE_BO
            Dim inf As New NTP_QLT.QLT_KIEMKE_Info
            If Me.txtID_PHIEUNHAP.Text = "" Then
                Try
                    inf.GHI_CHU = Me.txtGHI_CHU.Text
                    inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC
                    inf.NGAY_KIEMKE = GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE)
                    inf.NGUOI_KIEM = Me.UserId
                    inf.ID_KY_KIEMKE = 1

                    Me.txtID_PHIEUNHAP.Text = CInt(obj.InsertItem(inf))

                    ' DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                Catch sqlex As SqlException
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Catch ex As Exception
                    ProcessModuleLoadException(Me, ex)
                    Exit Sub
                Finally
                    obj = Nothing
                    inf = Nothing
                End Try
            End If
            'Ghi chi tiet phieu kiem ke 
            '--------------------------
            Dim obj1 As New NTP_QLT.QLT_KIEMKE_CHITIET_BO
            Dim inf1 As New NTP_QLT.QLT_KIEMKE_CHITIET_Info
            Try
                inf1.HAN_SUDUNG = GetValue(Me.dtmHan_SuDung, enuDATA_TYPE.DATE_TYPE)
                inf1.ID_KIEMKE = CInt(Me.txtID_PHIEUNHAP.Text)
                inf1.ID_THUOC = Me.cboThuoc.SelectedValue
                inf1.LO_SX = Me.txtLO_SX.Text
                inf1.NGAY_SX = GetValue(Me.dtmNgay_SX, enuDATA_TYPE.DATE_TYPE)
                inf1.SO_LUONG = Me.txtSO_LUONG.Text
                inf1.ID_TRANGTHAI = Me.cboTrangThai.SelectedValue
                inf1.Loai_Phieu = Me.cboLoaiPhieu.SelectedValue
                'If Me.txtKiem_Ke_Chi_Tiet_Id.Text = "0" Then
                obj1.InsertItem(inf1)
                'Else
                'inf1.ID_KIEMKE_CHITIET = CInt(Me.txtKiem_Ke_Chi_Tiet_Id.Text)
                'obj1.UpdateItem(inf1)
                'End If

                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
                inf = Nothing
                Me.txtKiem_Ke_Chi_Tiet_Id.Text = "0"
            End Try
            BindDaTaGrid()
        End If
    End Sub
    Sub BindDaTaGrid()
        Try
            Dim a As New NTP_QLT.QLT_KIEMKE_CHITIET_BO
            Me.grdDS.DataSource = a.SearchItem(CInt(Me.txtID_PHIEUNHAP.Text))
            Me.grdDS.DataBind()
        Catch ex As Exception
            Me.grdDS.DataSource = Nothing
        End Try
    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        Try
            If e.CommandName = "edit" Then
                Me.cboThuoc.SelectedValue = e.Item.Cells(4).Text
                Me.txtLO_SX.Text = e.Item.Cells(5).Text
                SetValue(Me.dtmHan_SuDung, e.Item.Cells(6).Text, enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.dtmNgay_SX, e.Item.Cells(7).Text, enuDATA_TYPE.DATE_TYPE)
                Me.txtSO_LUONG.Text = e.Item.Cells(8).Text
                Me.cboTrangThai.SelectedValue = CInt(e.Item.Cells(10).Text)
                Me.txtKiem_Ke_Chi_Tiet_Id.Text = e.Item.Cells(2).Text
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        grdDS.CurrentPageIndex = e.NewPageIndex
        BindDaTaGrid()
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.QLT_KIEMKE_CHITIET_BO
        Try
            For Each itm In Me.grdDS.Items
                Dim ctl As CheckBox
                ctl = itm.Cells(0).FindControl("grdCmdSel")
                If Not ctl Is Nothing Then
                    If ctl.Checked Then
                        obj.DeleteItem(itm.Cells(3).Text)
                    End If
                End If

            Next
            '  BindData(sMa_Phieu, dtfromdate, dttodate, inguonkinhphi)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
        BindDaTaGrid()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect(NavigateURL())
    End Sub
End Class
