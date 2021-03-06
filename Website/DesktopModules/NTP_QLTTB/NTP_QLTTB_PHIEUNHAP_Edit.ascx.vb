Imports NTP_Common.mdlGlobal
Public Class NTP_QLTTB_PHIEUNHAP_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase
    Public CST_NULL_VALUE As String = "--- Không xác định ---"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_Info
        Dim objSecu As New PortalSecurity
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
            End If
            If Not IsPostBack Then
                BindComboKinhPhi()
                BindComboLyDoNhap()
                BindComboThietBi()
                Me.pnlHeader.Visible = True
                'Date now
                'NTP_Common.SetValue(Me.txtNgayNhap, Now, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.txtNgayNhap, Now, enuDATA_TYPE.DATE_TYPE)
                If Not Request.QueryString("id") Is Nothing Then
                    'BindData()
                    Dim infKho As New NTP_QLTTB.NTP_QLTTB_DM_KHO_Info
                    Dim objKho As New NTP_QLTTB.NTP_QLTTB_DM_KHO_BO
                    Me.txtID_PHIEUNHAP.Text = objSecu.InputFilter(Request.QueryString("id"), PortalSecurity.FilterFlag.NoMarkup)
                    inf = obj.SelectItem(Me.txtID_PHIEUNHAP.Text)
                    Me.txtMA_PHIEU.Text = inf.MA_PHIEUNHAP
                    'Me.txtTuNgay.Text = inf.NGAY_NHAP
                    SetValue(txtNgayNhap, inf.NGAY_NHAP, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                    Me.cboNGUON_KINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
                    Me.cboLYDO_NHAP.SelectedValue = inf.ID_LYDO_NHAPXUAT
                    Me.txtNguoiNhap.Text = inf.NGUOI_NHAP

                    Me.txtSearchKhoXuatHang.SelectedValue = inf.ID_KHOXUAT
                    infKho = objKho.SelectItem(inf.ID_KHONHAP)

                    infKho = objKho.SelectItem(inf.ID_KHOXUAT)
                    Me.txtSearchKhoXuatHang.Text = infKho.TEN_KHO
                    Me.txtID_PHIEUNHAP.Enabled = False
                    Me.pnlDetail.Visible = True
                    '   Me.cmdAdd.Text = "Cập nhật"
                    'Neu la sua thi ko cho tao phieu moi
                    Me.cmdCreateNew.Visible = False


                    BindData()

                Else
                    Me.pnlDetail.Visible = False


                End If
                SetFormFocus(Me.txtMA_PHIEU, Me.ModuleConfiguration.SupportsPartialRendering)

            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Private Sub BindComboKinhPhi()
        Dim obj As New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullInteger
            itm.Text = CST_NULL_VALUE
            Me.cboNGUON_KINHPHI.DataSource = obj.SelectAllItems
            Me.cboNGUON_KINHPHI.DataBind()
            Me.cboNGUON_KINHPHI.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboLyDoNhap()
        Dim obj As New NTP_DANHMUC.NTP_DM_LYDO_NHAPXUAT_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullInteger
            itm.Text = CST_NULL_VALUE
            Me.cboLYDO_NHAP.DataSource = obj.Search("N")
            Me.cboLYDO_NHAP.DataBind()
            Me.cboLYDO_NHAP.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboThietBi()
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullInteger
            itm.Text = CST_NULL_VALUE
            Me.cboThietbi.DataSource = obj.SelectAllItems
            Me.cboThietbi.DataBind()
            Me.cboThietbi.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub



    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())
    End Sub



    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_Info
        Try
            If Request.QueryString("id") Is Nothing Then
                If CheckMaPhieu(txtMA_PHIEU.Text) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn đã nhập trùng mã", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    Exit Sub
                End If
            End If

            inf.MA_PHIEUNHAP = UCase(Me.txtMA_PHIEU.Text)

            inf.ID_NGUONKINHPHI = cboNGUON_KINHPHI.SelectedValue
            inf.ID_LYDO_NHAPXUAT = cboLYDO_NHAP.SelectedValue

            'inf.NGAY_NHAP = GetValue(txtNgayNhap, NTP_Common.enuDATA_TYPE.DATE_TYPE)
            Dim dtNgayNhap As Date
            dtNgayNhap = CType(NTP_Common.GetValue(Me.txtNgayNhap, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
            inf.NGAY_NHAP = dtNgayNhap
            inf.NAM = dtNgayNhap.Year

            inf.ID_KHOXUAT = IIf(Me.txtSearchKhoXuatHang.SelectedValue = "", Null.NullInteger, Me.txtSearchKhoXuatHang.SelectedValue)
            'inf.ID_KHONHAP = Me.txtSearchKhoNhap.SelectedValue
            inf.ID_KHONHAP = Me.CurrentUserStock.ID_KHO_TTBI
            inf.NGUOI_NHAP = Me.txtNguoiNhap.Text
            inf.NGUOI_NM = Me.UserId
            inf.NGAY_NM = Now.Date.ToShortDateString()
            inf.SO_PHIEUXUAT = UCase(Me.txtSoPhieuXuat.Text)



            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)
                txtID_PHIEUNHAP.Text = obj.SelectItemByMa(txtMA_PHIEU.Text).ID_PHIEUNHAP

                'Disable cmdAdd
                Me.cmdAdd.Enabled = False

                'Chuyen sang phan chi tiet
                Me.pnlDetail.Visible = True
                SetFormFocus(Me.txtMA_PHIEU, Me.ModuleConfiguration.SupportsPartialRendering)
            Else
                'Update
                inf.ID_PHIEUNHAP = Me.txtID_PHIEUNHAP.Text
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_CHITIET_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_CHITIET_Info
        Dim bibi As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_BO

        Try
           
            inf.ID_PHIEUNHAP = CLng(txtID_PHIEUNHAP.Text)
            inf.ID_THIETBI = CInt(cboThietbi.SelectedValue)
            inf.SO_LUONG = CLng(txtSoLuong.Text)
            If Me.txtID_PHIEUNHAP_CHITIET.Text.Trim = "" Then
                'Add
                obj.InsertItem(inf)
            Else
                'Update
                inf.ID_PHIEUNHAP_CHITIET = Me.txtID_PHIEUNHAP_CHITIET.Text
                obj.UpdateItem(inf)
            End If

            ' Clear textbox
            cboThietbi.SelectedIndex = 0
            txtSoLuong.Text = ""
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try
        BindData()

    End Sub

    Private Sub BindData()
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_CHITIET_BO
        Try
            Me.grdDS.DataSource = obj.SelectItemById(CLng(txtID_PHIEUNHAP.Text))
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_CHITIET_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData()
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    ''' <summary>
    ''' ham kiem tra maphieu. tra ve true neu da co, false neu chua co
    ''' </summary>
    ''' <param name="MA_PHIEUNHAP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function CheckMaPhieu(ByVal MA_PHIEUNHAP As String) As Boolean
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_BO
        Dim ds As New DataSet
        ds = obj.Search(MA_PHIEUNHAP, Null.NullInteger, Null.NullDate, Null.NullDate)
        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function



    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            'Binddata
            Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_CHITIET_BO
            Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_CHITIET_Info
            Try
                inf = obj.SelectItem(e.Item.Cells(2).Text)

                'Get detail
                Me.txtID_PHIEUNHAP_CHITIET.Text = inf.ID_PHIEUNHAP_CHITIET
                Me.cboThietbi.SelectedValue = inf.ID_THIETBI
                Me.txtSoLuong.Text = inf.SO_LUONG
                'Me.txtID_PHIEUNHAP.Text = inf.ID_PHIEUNHAP

                NTP_Common.SetFormFocus(Me.cboThietbi, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)

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

    Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click

        'Tao phieu moi
        'Clear cac o text box
        Me.txtID_PHIEUNHAP.Text = ""
        Me.txtID_PHIEUNHAP_CHITIET.Text = ""
        Me.txtMA_PHIEU.Text = ""
        Me.txtNguoiNhap.Text = ""
        Me.txtSearchKhoXuatHang.Text = ""
        Me.txtSearchKhoXuatHang.SelectedValue = ""
        Me.txtGhiChu.Text = ""
        Me.txtSoLuong.Text = ""
        Me.cboLYDO_NHAP.SelectedIndex = 0
        Me.cboNGUON_KINHPHI.SelectedIndex = 0
        Me.txtNgayNhap.Text = ""
        Me.txtSoPhieuXuat.Text = ""
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
