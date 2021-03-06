Imports NTP_Common.mdlGlobal

Public Class NTP_QLTTB_PHIEUNHAP_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                GetFilter()
                BindComboKinhPhi()
                If Not Session(FILTER_STRING) Is Nothing Then
                    BindData(IIf(Me.txtMaPhieu.SelectedValue = String.Empty, Null.NullString, Me.txtMaPhieu.SelectedValue), _
                    IIf(cboNguonKinhPhi.SelectedValue = String.Empty, -1, cboNguonKinhPhi.SelectedValue), _
                    IIf(txtTuNgay.Text = String.Empty, Null.NullDate, txtTuNgay.Text), _
                    IIf(txtDenNgay.Text = String.Empty, Null.NullDate, txtDenNgay.Text))
                    ' setstate
                    SetViewState()
                Else
                    BindData(IIf(Me.txtMaPhieu.SelectedValue = String.Empty, Null.NullString, Me.txtMaPhieu.SelectedValue), _
                    IIf(cboNguonKinhPhi.SelectedValue = String.Empty, -1, cboNguonKinhPhi.SelectedValue), IIf(txtTuNgay.Text = String.Empty, Null.NullDate, txtTuNgay.Text), IIf(txtDenNgay.Text = String.Empty, Null.NullDate, txtDenNgay.Text))

                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindComboKinhPhi()
        Dim obj As New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Không xác định ---"
            Me.cboNguonKinhPhi.DataSource = obj.SelectAllItems
            Me.cboNguonKinhPhi.DataBind()
            Me.cboNguonKinhPhi.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    


    Private Sub SetViewState()

        ViewState("SEARCH_VALUE_NGUONKINHPHI") = Me.cboNguonKinhPhi.SelectedValue
        ViewState("SEARCH_TU_NGAY") = Me.txtTuNgay.Text
        ViewState("SEARCH_DEN_NGAY") = Me.txtDenNgay.Text
        'Chi set viewstate neu tim dung
        If Not Me.txtMaPhieu.SelectedValue Is Nothing Then
            ViewState("SEARCH_VALUE_MA_PHIEUNHAP_TEXT") = Me.txtMaPhieu.Text
            ViewState("SEARCH_VALUE_MA_PHIEUNHAP_VALUE") = Me.txtMaPhieu.SelectedValue
        End If
    End Sub

    Private Sub GetViewState()
        Me.txtTuNgay.Text = ViewState("SEARCH_TU_NGAY")
        Me.txtDenNgay.Text = ViewState("SEARCH_DEN_NGAY")
        Me.cboNguonKinhPhi.SelectedValue = ViewState("SEARCH_VALUE_NGUONKINHPHI")
        Me.txtMaPhieu.Text = ViewState("SEARCH_VALUE_MA_PHIEUNHAP_TEXT")
        Me.txtMaPhieu.SelectedValue = ViewState("SEARCH_VALUE_MA_PHIEUNHAP_VALUE")
    End Sub


    Private Sub BindData(ByVal sPHIEUNHAP As String, ByVal iID_NGUONKINHPHI As Int32, ByVal dTU_NGAY As DateTime, ByVal dDEN_NGAY As DateTime)
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_BO
        Try
            Me.grdDS.DataSource = obj.Search(sPHIEUNHAP, iID_NGUONKINHPHI, dTU_NGAY, dDEN_NGAY)
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            SetFilter()
            Dim Id As Integer = CInt(e.Item.Cells(2).Text)
            'Kiem tra trang thai phieu
            If CheckStatus(Id) Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Phiếu đang kiểm kê. Bạn không được sửa", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Exit Sub
            End If
            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
        End If
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        'Lay du lieu tu viewstate de check xem co phai la tim kiem khong
        GetViewState()

        grdDS.CurrentPageIndex = e.NewPageIndex
   
        BindData(IIf(Me.txtMaPhieu.SelectedValue = String.Empty, Null.NullString, Me.txtMaPhieu.SelectedValue), _
                  IIf(cboNguonKinhPhi.SelectedValue = String.Empty, -1, cboNguonKinhPhi.SelectedValue), IIf(txtTuNgay.Text = String.Empty, Null.NullDate, txtTuNgay.Text), IIf(txtDenNgay.Text = String.Empty, Null.NullDate, txtDenNgay.Text))


    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        SetViewState()
        Me.grdDS.CurrentPageIndex = 0
        BindData(IIf(Me.txtMaPhieu.SelectedValue = String.Empty, Null.NullString, Me.txtMaPhieu.Text), _
        IIf(cboNguonKinhPhi.SelectedValue = String.Empty, -1, cboNguonKinhPhi.SelectedValue), _
        IIf(txtTuNgay.Text = String.Empty, Null.NullDate, GetValue(txtTuNgay, enuDATA_TYPE.DATE_TYPE)), _
        IIf(txtDenNgay.Text = String.Empty, Null.NullDate, GetValue(txtDenNgay, enuDATA_TYPE.DATE_TYPE)))


    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtMaPhieu)
        AppendFilterString(sFilterString, Me.txtTuNgay)
        AppendFilterString(sFilterString, Me.txtDenNgay)
        AppendFilterString(sFilterString, Me.cboNguonKinhPhi)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
        End If

        GetFilterValue(sFilterString, Me.txtMaPhieu)
        GetFilterValue(sFilterString, Me.txtTuNgay)
        GetFilterValue(sFilterString, Me.txtDenNgay)
        GetFilterValue(sFilterString, Me.cboNguonKinhPhi)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                'kiem tra trang thai phieu
                Dim Id As Integer = CInt(itm.Cells(2).Text)
                If CheckStatus(Id) Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Phiếu đang kiểm kê. Ban không được xóa", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    Exit Sub
                End If

                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(IIf(Me.txtMaPhieu.SelectedValue = String.Empty, Null.NullString, Me.txtMaPhieu.SelectedValue), _
            IIf(cboNguonKinhPhi.SelectedValue = String.Empty, -1, cboNguonKinhPhi.SelectedValue), IIf(txtTuNgay.Text = String.Empty, Null.NullDate, txtTuNgay.Text), IIf(txtDenNgay.Text = String.Empty, Null.NullDate, txtDenNgay.Text))
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Ham kiem tra trang thai phieu  nhap. Tra ve false neu TRANG_THAI=0
    ''' </summary>
    ''' <param name="ID_PHIEUNHAP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function CheckStatus(ByVal ID_PHIEUNHAP As Integer) As Boolean
        Dim obj As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_Info
        inf = obj.SelectItem(ID_PHIEUNHAP)
        If inf.TRANG_THAI = 0 Then
            Return False
        Else
            Return True

        End If


    End Function

End Class
