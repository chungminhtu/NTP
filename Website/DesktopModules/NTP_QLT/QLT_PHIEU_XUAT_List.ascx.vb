Imports NTP_Common.mdlGlobal
Partial Class QLT_PHIEU_XUAT_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            BindData(Me.txtMA_PHIEU.Text, CType(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date), CType(GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Date), Me.cboNGUON_KINHPHI.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindComboNGUONKINHPHI()
            'BindData(Me.txtMA_PHIEU.Text, GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Me.cboNGUON_KINHPHI.SelectedValue)
        End If
    End Sub
    Private Sub BindComboNGUONKINHPHI()
        Dim obj As New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO
        Try
            Me.cboNGUON_KINHPHI.DataSource = obj.SelectAllItems
            Me.cboNGUON_KINHPHI.DataBind()
            Me.cboNGUON_KINHPHI.Items.Insert(0, (New ListItem("--- Tất cả ---", Null.NullInteger)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub
    Private Sub BindData(ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer)
        Dim obj As New NTP_QLT.QLT_PHIEU_XUAT_BO
        Try
            'Me.grdDS.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, sMA_PHIEU, dtFromDate, dtToDate, iNguonKinhPhi)
            Me.grdDS.DataSource = obj.Search(sMA_PHIEU, dtFromDate, dtToDate, iNguonKinhPhi)
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub
    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text & "&TrangThai=" & e.Item.Cells(9).Text))  '_
            '& "txtMa_PhieuNhap=" & e.Item.Cells(3).Text _
            '& "ID_DonVi_Nhap=" & e.Item.Cells(4).Text _
            '& "NGAY_NHAP = " & e.Item.Cells(5).Text _
            '& "NAM=" & e.Item.Cells(6).Text _
            '& "LYDO_NHAPXUAT=" & e.Item.Cells(8).Text _
            '& "ID_NGUONKINHPHI" & e.Item.Cells(9).Text _
            '& "TRANG_THAI" & e.Item.Cells(9).Text))

        End If
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(DotNetNuke.Common.NavigateURL("Edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.QLT_PHIEU_NHAP_CHI_TIET_BO
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
            '  BindData(sMa_Phieu, dtfromdate, dttodate, inguonkinhphi)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtMA_PHIEU.Text, CType(Me.txtTuNgay.Text, Date), CType(Me.txtDenNgay.Text, Date), Me.cboNGUON_KINHPHI.SelectedValue)
    End Sub
End Class
