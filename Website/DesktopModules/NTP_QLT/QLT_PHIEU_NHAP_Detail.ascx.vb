
Partial Class QLT_PHIEU_NHAP_Detail
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindComboBoxDM_Thuoc()
        If Request.QueryString("ID_PhieuNhap") <> "" Then
            '  (Request.Item("MA_PHIEUGUI"))
        End If
        If Request.Item("ID_PhieuNhap") <> "" Then
            '  (Request.Item("MA_PHIEUGUI"))
        End If
    End Sub

    Private Sub BindComboBoxDM_Thuoc()
        Dim bibi As New NTP_DANHMUC.NTP_DM_THUOC_BO
        Me.cboThuoc.DataSource = bibi.SelectAllItems
        Me.cboThuoc.DataBind()
        'bibi = Nothing

    End Sub
    Private Sub BindDaTaGrid()
        Dim a As New NTP_QLT.QLT_PHIEU_NHAP_CHI_TIET_BO
        Me.grdDS.DataSource = a.SelectAllItems
        Me.grdDS.DataBind()
    End Sub
    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim obj As New NTP_QLT.QLT_PHIEU_NHAP_CHI_TIET_BO
        Dim inf As New NTP_QLT.QLT_PHIEU_NHAP_CHI_TIET_Info
        Try

            inf.HAN_SUDUNG = Me.dtmHan_SUDUNG.Value
            inf.ID_PHIEUNHAP = Request.Item("ID_PhieuNhap")

            inf.ID_THUOC = Me.cboThuoc.SelectedValue
            inf.LO_SX = Me.txtLO_SX.Text
            inf.NGAY_SX = Me.dtmNgay_SX.Value
            inf.SO_LUONG = Me.txtSO_LUONG.Text

            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)
            Else
                'Update
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
        BindDaTaGrid()
    End Sub
End Class
