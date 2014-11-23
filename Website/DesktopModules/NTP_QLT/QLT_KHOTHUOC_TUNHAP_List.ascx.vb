Imports NTP_Common.mdlGlobal

Partial Class QLT_KHOTHUOC_TUNHAP_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim obj As New NTP_QLT.QLT_KHOTHUOC_TUNHAP_BO
        Dim inf As New NTP_QLT.QLT_KHOTHUOC_TUNHAP_Info
        Try
            inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC
            inf.ID_KY_KIEMKE = Me.cboKykiemKe.SelectedValue
            inf.HONG = CInt(Me.txtHong.Text)
            inf.ID_THUOC = Me.cboThuoc.SelectedValue
            inf.Kem_PC = CInt(Me.txtKemPC.Text)
            inf.LO_SX = Me.txtLoSX.Text
            inf.Mat_PC = CInt(Me.txtMatPC.Text)
            inf.THIEU = CInt(Me.txtThieu.Text)
            inf.THUA = CInt(Me.txtThua.Text)
            inf.TON_CUOIKY = CInt(Me.txtTon_CuoiKy.Text)
            inf.TOT = CInt(Me.txtTot.Text)
            inf.NHAP = CInt(Me.txtNhapTrongKy.Text)
            inf.XUAT = CInt(Me.txtXuatTrongKy.Text)

            'If Request.QueryString("id") Is Nothing Then
            '    'Add
            obj.InsertItem(inf)

            BindDataList(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboKykiemKe.SelectedValue)

            ' obj.UpdateItem(inf)
            'End If
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

    Protected Sub bindComboThuoc()
        Dim bibi As New NTP_DANHMUC.NTP_DM_THUOC_BO
        Me.cboThuoc.DataSource = bibi.SelectAllItems
        Me.cboThuoc.DataBind()
    End Sub

    Protected Sub bindComboKyKiemKe()
        Dim ds As New DataSet
        Dim obj As New NTP_QLT.QLT_KY_KIEMKE_BO
        Try
            Me.cboKykiemKe.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Now.Year)
            Me.cboKykiemKe.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub
    Protected Sub BindDataList(ByVal ID_KhoThuoc As Integer, ByVal ID_KyKiemKe As Integer)
        Dim obj As New NTP_QLT.QLT_KHOTHUOC_TUNHAP_BO
        Me.grdDS.DataSource = obj.Search(ID_KhoThuoc, ID_KyKiemKe)
        Me.grdDS.DataBind()

    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            bindComboThuoc()
            bindComboKyKiemKe()
        End If
    End Sub

    Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim obj As New NTP_QLT.QLT_KHOTHUOC_TUNHAP_BO
        Dim inf As New NTP_QLT.QLT_KHOTHUOC_TUNHAP_Info
        inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC
        inf.ID_KY_KIEMKE = Me.cboKykiemKe.SelectedValue
        inf.HONG = CInt(Me.txtHong.Text)
        inf.ID_THUOC = Me.cboThuoc.SelectedValue
        inf.Kem_PC = CInt(Me.txtKemPC.Text)
        inf.LO_SX = Me.txtLoSX.Text
        inf.Mat_PC = CInt(Me.txtMatPC.Text)
        inf.THIEU = CInt(Me.txtThieu.Text)
        inf.THUA = CInt(Me.txtThua.Text)
        inf.TON_CUOIKY = CInt(Me.txtTon_CuoiKy.Text)
        inf.TOT = CInt(Me.txtTot.Text)
        inf.NHAP = CInt(Me.txtNhapTrongKy.Text)
        inf.XUAT = CInt(Me.txtXuatTrongKy.Text)
        inf.ID_TUNHAP = CInt(Me.txtID_TuNhap.Text)
        'If Request.QueryString("id") Is Nothing Then
        '    'Add
        obj.UpdateItem(inf)

        BindDataList(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboKykiemKe.SelectedValue)

    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.QLT_KHOTHUOC_TUNHAP_BO
        Try
            For Each itm In Me.grdDS.Items
                Dim ctl As CheckBox
                ctl = itm.Cells(0).FindControl("grdCmdSel")
                If Not ctl Is Nothing Then
                    If ctl.Checked Then
                        obj.DeleteItem(itm.Cells(14).Text)
                    End If
                End If
            Next
            BindDataList(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboKykiemKe.SelectedValue)

        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            Me.txtHong.Text = e.Item.Cells(10).Text
            Me.txtID_TuNhap.Text = e.Item.Cells(14).Text
            Me.txtKemPC.Text = e.Item.Cells(12).Text
            Me.txtLoSX.Text = e.Item.Cells(4).Text
            Me.txtMatPC.Text = e.Item.Cells(13).Text
            Me.txtNhapTrongKy.Text = e.Item.Cells(6).Text
            Me.txtThieu.Text = e.Item.Cells(9).Text
            Me.txtThua.Text = e.Item.Cells(8).Text
            Me.txtTon_CuoiKy.Text = e.Item.Cells(15).Text
            Me.txtTonDauKy.Text = e.Item.Cells(5).Text
            Me.txtTot.Text = e.Item.Cells(11).Text
            Me.txtXuatTrongKy.Text = e.Item.Cells(7).Text
            Me.cboKykiemKe.SelectedValue = e.Item.Cells(16).Text
            Me.cboThuoc.SelectedValue = e.Item.Cells(2).Text

        End If
    End Sub

 
    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        BindDataList(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboKykiemKe.SelectedValue)
    End Sub

    Protected Sub cboKykiemKe_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKykiemKe.SelectedIndexChanged
        BindDataList(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboKykiemKe.SelectedValue)
    End Sub
End Class
