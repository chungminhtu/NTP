Imports NTP_Common.mdlGlobal

Public Class NTP_QLVT_PHIEUKIEMKE_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                SetValue(Me.txtTuNgay, Now, enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.txtDenNgay, Now, enuDATA_TYPE.DATE_TYPE)
                BindComboNGUONKINHPHI()
                GetFilter()
                If Not Session(FILTER_STRING) Is Nothing Then
                    ' setstate
                    SetViewState()
                    '
                    BindData(Me.txtMA_PHIEU.Text, CType(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date), CType(GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Date), cboNGUON_KINHPHI.SelectedValue)
                Else
                    'BindData(Me.txtMA_PHIEU.Text, CType(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date), CType(GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Date), cboNGUON_KINHPHI.SelectedValue)
                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

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
        Dim obj As New NTP_QLVT.NTP_QLVT_KIEMKE_BO
        Try
            Me.grdDS.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_QLVT, dtFromDate, dtToDate, iNguonKinhPhi)
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub SetViewState()
        'ViewState("SEARCH_VALUE_T") = Me.txtTEN_KHO.Text
        'ViewState("SEARCH_VALUE_TINH") = Me.cboTinh.SelectedValue
        'ViewState("SEARCH_VALUE_HUYEN") = Me.cboHuyen.SelectedValue

        ''Chi set viewstate neu tim dung
        'If Not Me.txtSearhKhoCapTren.SelectedValue Is Nothing Then
        '    ViewState("SEARCH_VALUE_KHO_CAPTREN_TEXT") = Me.txtSearhKhoCapTren.Text
        '    ViewState("SEARCH_VALUE_KHO_CAPTREN_VALUE") = Me.txtSearhKhoCapTren.SelectedValue
        'End If
    End Sub

    Private Sub GetViewState()
        'Me.txtTEN_KHO.Text = ViewState("SEARCH_VALUE_TEN_TINH")
        'Me.cboTinh.SelectedValue = ViewState("SEARCH_VALUE_TINH")
        'Me.cboHuyen.SelectedValue = ViewState("SEARCH_VALUE_HUYEN")
        'Me.txtSearhKhoCapTren.Text = ViewState("SEARCH_VALUE_KHO_CAPTREN_TEXT")
        'Me.txtSearhKhoCapTren.SelectedValue = ViewState("SEARCH_VALUE_KHO_CAPTREN_VALUE")
    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            SetFilter()
            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
        End If
    End Sub

    Protected Sub grdDS_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdDS.ItemDataBound
        'Khong cho sua, xoa phieu da khoa so
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            '
            If e.Item.Cells(3).Text = enuBILL_STATUS.LOCK Then
                Dim ctl As Control
                ctl = e.Item.Cells(0).FindControl("chkItem")
                'Khong cho xoa, chi duoc xem
                If Not ctl Is Nothing Then
                    ctl.Visible = False
                End If
                'ctl = e.Item.Cells(0).FindControl("cmdEdit")
                'If Not ctl Is Nothing Then
                '    ctl.Visible = False
                'End If
                e.Item.Cells(7).ForeColor = Color.Red
                e.Item.Cells(7).Font.Bold = True
            End If
            e.Item.Cells(7).Text = GetStatusComment(e.Item.Cells(3).Text)
        End If
    End Sub


    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged

        'Lay du lieu tu viewstate de check xem co phai la tim kiem khong
        GetViewState()
        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtMA_PHIEU.Text, CType(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date), CType(GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Date), cboNGUON_KINHPHI.SelectedValue)
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        SetViewState()
        grdDS.CurrentPageIndex = 0
        BindData(Me.txtMA_PHIEU.Text, CType(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date), CType(GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Date), cboNGUON_KINHPHI.SelectedValue)
    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtMA_PHIEU)
        AppendFilterString(sFilterString, Me.txtTuNgay)
        AppendFilterString(sFilterString, Me.txtDenNgay)
        AppendFilterString(sFilterString, Me.cboNGUON_KINHPHI)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
            GetFilterValue(sFilterString, Me.txtMA_PHIEU)
            GetFilterValue(sFilterString, Me.txtTuNgay)
            GetFilterValue(sFilterString, Me.txtDenNgay)
            GetFilterValue(sFilterString, Me.cboNGUON_KINHPHI)
        End If
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLVT.NTP_QLVT_KIEMKE_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            grdDS.CurrentPageIndex = 0
            BindData(Me.txtMA_PHIEU.Text, CType(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date), CType(GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Date), cboNGUON_KINHPHI.SelectedValue)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

End Class
