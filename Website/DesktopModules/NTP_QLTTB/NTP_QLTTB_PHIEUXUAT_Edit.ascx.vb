Imports NTP_Common.mdlGlobal
Public Class NTP_QLTTB_PHIEUXUAT_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase
    Public CST_NULL_VALUE As String = "--- Không xác định ---"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_Info
        Dim objSecu As New PortalSecurity
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
            End If
            If Not IsPostBack Then
                BindComboKinhPhi()
                BindComboLyDoXuat()
                BindComboThietBi()
                SetValue(Me.txtNgayXuat, Now, enuDATA_TYPE.DATE_TYPE)
                If Not Request.QueryString("id") Is Nothing Then
                    'BindData()
                    Dim infKho As New NTP_QLTTB.NTP_QLTTB_DM_KHO_Info
                    Dim objKho As New NTP_QLTTB.NTP_QLTTB_DM_KHO_BO
                    Me.txtID_PHIEUXUAT.Text = objSecu.InputFilter(Request.QueryString("id"), PortalSecurity.FilterFlag.NoMarkup)
                    inf = obj.SelectItem(Me.txtID_PHIEUXUAT.Text)
                    Me.txtMA_PHIEU.Text = inf.MA_PHIEUXUAT
                    'Me.txtTuNgay.Text = inf.NGAY_XUAT
                    SetValue(txtNgayXuat, inf.NGAY_XUAT, NTP_Common.enuDATA_TYPE.DATE_TYPE)
                    Me.cboNGUON_KINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
                    Me.cboLYDO_XUAT.SelectedValue = inf.ID_LYDO_NHAPXUAT
                    Me.txtNguoiXuat.Text = inf.NGUOI_XUAT
                    '   Me.txtSearchKhoXuatHang.SelectedValue = inf.ID_KHOXUAT
                    Me.txtSearchKhoNhap.SelectedValue = inf.ID_KHONHAP
                    infKho = objKho.SelectItem(inf.ID_KHOXUAT)
                    '  Me.txtSearchKhoXuatHang.Text = infKho.TEN_KHO
                    infKho = objKho.SelectItem(inf.ID_KHONHAP)
                    Me.txtSearchKhoNhap.Text = infKho.TEN_KHO
                    Me.txtID_PHIEUXUAT.Enabled = False
                    Me.pnlDetail.Visible = True

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

    Private Sub BindComboLyDoXuat()
        Dim obj As New NTP_DANHMUC.NTP_DM_LYDO_NHAPXUAT_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullInteger
            itm.Text = CST_NULL_VALUE
            Me.cboLYDO_XUAT.DataSource = obj.Search("X")
            Me.cboLYDO_XUAT.DataBind()
            Me.cboLYDO_XUAT.Items.Insert(0, itm)
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_Info
        Try
            If Request.QueryString("id") Is Nothing Then
                If CheckMaPhieu(txtMA_PHIEU.Text) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn đã nhập trùng mã", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    Exit Sub
                End If
            End If
            inf.MA_PHIEUXUAT = UCase(Me.txtMA_PHIEU.Text)


            inf.ID_NGUONKINHPHI = cboNGUON_KINHPHI.SelectedValue
            inf.ID_LYDO_NHAPXUAT = cboLYDO_XUAT.SelectedValue
            Dim dtNgayXuat As Date
            dtNgayXuat = CType(NTP_Common.GetValue(Me.txtNgayXuat, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
            inf.NGAY_XUAT = dtNgayXuat
            inf.NAM = dtNgayXuat.Year
            'inf.NGAY_XUAT = GetValue(txtNgayXuat, NTP_Common.enuDATA_TYPE.DATE_TYPE)
            inf.ID_KHONHAP = IIf(Me.txtSearchKhoNhap.SelectedValue = "", 0, Me.txtSearchKhoNhap.SelectedValue)
            inf.ID_KHOXUAT = Me.CurrentUserStock.ID_KHO_TTBI
            'inf.ID_KHONHAP = Me.CurrentUserStock.ID_KHO_TTBI
            inf.NGUOI_XUAT = Me.txtNguoiXuat.Text
            inf.NGUOI_NM = Me.UserId
            inf.NGAY_NM = Now.Date.ToShortDateString()
            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)
                Me.txtID_PHIEUXUAT.Text = obj.SelectItemByMa(txtMA_PHIEU.Text).ID_PHIEUXUAT
                ' Disable cmdAdd
                Me.cmdAdd.Enabled = False

                'Chuyen sang phan chi tiet
                Me.pnlDetail.Visible = True



                SetFormFocus(Me.txtMA_PHIEU, Me.ModuleConfiguration.SupportsPartialRendering)
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_CHITIET_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_CHITIET_Info
        Try
            inf.ID_PHIEUXUAT = CLng(txtID_PHIEUXUAT.Text)
            inf.ID_THIETBI = CInt(cboThietbi.SelectedValue)
            inf.SO_LUONG = CLng(txtSoLuong.Text)
            obj.InsertItem(inf)
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_CHITIET_BO
        Try
            Me.grdDS.DataSource = obj.SelectItemById(CLng(txtID_PHIEUXUAT.Text))
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_CHITIET_BO
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
    ''' Ham kiem tra Ma phieu nhap. Tra ve true neu da co, false neu chua co
    ''' </summary>
    ''' <param name="MA_PHIEUXUAT"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function CheckMaPhieu(ByVal MA_PHIEUXUAT As String) As Boolean
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_BO
        Dim ds As New DataSet
        ds = obj.Search(MA_PHIEUXUAT, Null.NullInteger, Null.NullDate, Null.NullDate)
        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
        'Tao phieu moi
        'Clear cac o text box
        Me.txtID_PHIEUXUAT.Text = ""
        Me.txtID_PHIEUXUAT_CHITIET.Text = ""
        Me.txtMA_PHIEU.Text = ""
        Me.txtNguoiXuat.Text = ""
        Me.txtSearchKhoNhap.Text = ""
        Me.txtSearchKhoNhap.SelectedValue = ""
        Me.txtGhiChu.Text = ""
        Me.txtSoLuong.Text = ""
        Me.cboLYDO_XUAT.SelectedIndex = 0
        Me.cboNGUON_KINHPHI.SelectedIndex = 0
        Me.txtNgayXuat.Text = ""

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

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            'Binddata
            Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_CHITIET_BO
            Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_CHITIET_Info
            Try
                inf = obj.SelectItem(e.Item.Cells(2).Text)

                'Get detail
                Me.txtID_PHIEUXUAT_CHITIET.Text = inf.ID_PHIEUXUAT_CHITIET
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
End Class
