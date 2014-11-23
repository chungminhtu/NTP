
Public Class NTP_QLTTB_PHIEUKIEMKE_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLTTB.NTP_QLTTB_KIEMKE_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_KIEMKE_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                BindComboVATTU()
                BindComboNGUONKINHPHI()
                BindComboTRANGTHAI()
                Me.pnlHeader.Visible = True
                'Date now
                NTP_Common.SetValue(Me.txtNgayKK, Now, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                If Not Request.QueryString("id") Is Nothing Then
                    Me.txtID_PHIEUKIEMKE.Text = Request.QueryString("id")
                    inf = obj.SelectItem(Me.txtID_PHIEUKIEMKE.Text)
                    Me.txtGhiChu.Text = inf.GHI_CHU
                    'Set text 
                    NTP_Common.SetValue(Me.txtNgayKK, inf.NGAY_KIEMKE, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                    Me.cboNGUON_KINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
                    Me.txtID_PHIEUKIEMKE.Enabled = False
                    Me.pnlDetail.Visible = True
                    'BindDetail
                    BindGrid(Me.txtID_PHIEUKIEMKE.Text)
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
                NTP_Common.SetFormFocus(Me.txtNgayKK, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Private Sub BindGrid(ByVal iID_PHIEUKIEMKE As Double)
        Dim obj As New NTP_QLTTB.NTP_QLTTB_KIEMKE_CHITIET_BO
        Try
            Me.grdDS.DataSource = obj.Search(iID_PHIEUKIEMKE)
            Me.grdDS.DataBind()
            Me.grdDS.Visible = True
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboVATTU()
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO
        Try
            Me.cboTHIETBI.DataSource = obj.SelectAllItems
            Me.cboTHIETBI.DataBind()
            ' Me.cboVung.Items.Insert(0, (New ListItem(-1, "")))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboTRANGTHAI()
        Dim obj As New NTP_QLTTB.NTP_QLttb_DM_TRANGTHAI_BO
        Try
            Me.cboTrangThai.DataSource = obj.SelectAllItems
            Me.cboTrangThai.DataBind()
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_KIEMKE_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_KIEMKE_Info
        Try
            'Kiem tra thang, nam xem co nhap duoc khong.
            Dim objKy As New NTP_QLTTB.NTP_QLTTB_KHOASO_BO
            Dim iStatus As NTP_Common.enuTRANGTHAI_KY_KIEMKE

            Dim dtNgayKK As Date
            dtNgayKK = CType(NTP_Common.GetValue(Me.txtNgayKK, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)

            'Kiem tra khong cho nhap phieu neu nhu dang khoa so
            iStatus = objKy.KiemTraKy(Me.CurrentUserStock.ID_KHO_TTBI, CInt(dtNgayKK.Year))
            If iStatus <> NTP_Common.enuTRANGTHAI_KY_KIEMKE.DA_KHOA_SO Then
                Skins.Skin.AddModuleMessage(Me, "Bạn không thể nhập phiếu trong tháng này do chưa tiến hành khóa sổ kiểm kê", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Exit Sub
            End If
            inf.NGAY_KIEMKE = dtNgayKK
            inf.ID_NGUONKINHPHI = Me.cboNGUON_KINHPHI.SelectedValue
            inf.ID_KHO = Me.CurrentUserStock.ID_KHO_TTBI
            inf.NGUOI_KIEMKE = Me.UserId
            inf.GHI_CHU = Me.txtGhiChu.Text
            If Request.QueryString("id") Is Nothing Then
                'Add
                Me.txtID_PHIEUKIEMKE.Text = obj.InsertItem(inf)
                'Clear text box
                'Me.txtMA_PHIEU.Text = ""
                'Me.txtID_PHIEUNHAP.Text = ""
                Me.cmdAdd.Enabled = False
                'NTP_Common.SetFormFocus(Me.txtMA_PHIEU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
                'Hien panel detail
                Me.pnlDetail.Visible = True
                Me.grdDS.Visible = True
                'Chuyen sang panel detail
                NTP_Common.SetFormFocus(Me.cboTHIETBI, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
                'Set 
            Else
                'Update
                inf.ID_KIEMKE = Me.txtID_PHIEUKIEMKE.Text
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_KIEMKE_CHITIET_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_KIEMKE_CHITIET_Info
        Try
            'Save detail
            inf.ID_THIETBI = Me.cboTHIETBI.SelectedValue
            inf.SO_LUONG = Me.txtSoLuong.Text
            inf.ID_KIEMKE = Me.txtID_PHIEUKIEMKE.Text
            inf.ID_TRANGTHAI = Me.cboTrangThai.SelectedItem.Value
            inf.ID_KIEMKE = Me.txtID_PHIEUKIEMKE.Text
            If Me.txtID_PHIEUKIEMKE_CHITIET.Text.Trim = "" Then
                'Add
                obj.InsertItem(inf)
            Else
                'Update
                inf.ID_KIEMKE_CHITIET = Me.txtID_PHIEUKIEMKE_CHITIET.Text
                obj.UpdateItem(inf)
            End If
            NTP_Common.SetFormFocus(Me.cboTHIETBI, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            BindGrid(inf.ID_KIEMKE)
            'Clear 
            Me.txtSoLuong.Text = ""
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
            Dim obj As New NTP_QLTTB.NTP_QLTTB_KIEMKE_CHITIET_BO
            Dim inf As New NTP_QLTTB.NTP_QLTTB_KIEMKE_CHITIET_Info
            Try
                inf = obj.SelectItem(e.Item.Cells(2).Text)

                'Get detail
                Me.txtID_PHIEUKIEMKE_CHITIET.Text = inf.ID_KIEMKE_CHITIET
                Me.cboTHIETBI.SelectedValue = inf.ID_THIETBI
                Me.txtSoLuong.Text = inf.SO_LUONG
                Me.cboTrangThai.SelectedItem.Value = inf.ID_TRANGTHAI

                NTP_Common.SetFormFocus(Me.cboTHIETBI, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)

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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_KIEMKE_CHITIET_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            grdDS.CurrentPageIndex = 0
            BindGrid(Me.txtID_PHIEUKIEMKE.Text)
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
        Me.txtID_PHIEUKIEMKE.Text = ""
        Me.txtID_PHIEUKIEMKE_CHITIET.Text = ""
        Me.txtGhiChu.Text = ""
        Me.txtSoLuong.Text = ""
        Me.txtNgayKK.Text = ""

        'Hide panel detail
        Me.pnlDetail.Visible = False
        'enable nut ghi
        cmdAdd.Enabled = True
        'Clear list
        Me.grdDS.DataSource = Nothing
        Me.grdDS.DataBind()

        'Set focus
        NTP_Common.SetFormFocus(Me.txtNgayKK, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
    End Sub
End Class
