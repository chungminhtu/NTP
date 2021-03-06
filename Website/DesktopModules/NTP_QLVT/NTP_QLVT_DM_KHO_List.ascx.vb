Imports NTP_Common.mdlGlobal

Public Class NTP_QLVT_DM_KHO_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                GetFilter()
                BindComboTinh()
                If Not Session(FILTER_STRING) Is Nothing Then
                    BindData(Me.txtTEN_KHO.Text, Me.cboTinh.SelectedValue, Me.cboHuyen.SelectedValue, IIf(Me.txtSearhKhoCapTren.SelectedValue = String.Empty, Null.NullInteger, Me.txtSearhKhoCapTren.SelectedValue))
                    ' setstate
                    SetViewState()
                    '
                Else
                    BindData(Me.txtTEN_KHO.Text, Me.cboTinh.SelectedValue, Me.cboHuyen.SelectedValue, IIf(Me.txtSearhKhoCapTren.SelectedValue = String.Empty, -1, Me.txtSearhKhoCapTren.SelectedValue))
                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindComboTinh()
        Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Không xác định ---"
            Me.cboTinh.DataSource = obj.SelectAllItems
            Me.cboTinh.DataBind()
            Me.cboTinh.Items.Insert(0, itm)

            BindComboHuyen(Me.cboTinh.SelectedValue)

        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboHuyen(ByVal sTinh As String)
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Không xác định ---"
            Me.cboHuyen.DataSource = obj.Search("", sTinh)
            Me.cboHuyen.DataBind()
            Me.cboHuyen.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Private Sub SetViewState()
        ViewState("SEARCH_VALUE_TEN_TINH") = Me.txtTEN_KHO.Text
        ViewState("SEARCH_VALUE_TINH") = Me.cboTinh.SelectedValue
        ViewState("SEARCH_VALUE_HUYEN") = Me.cboHuyen.SelectedValue

        'Chi set viewstate neu tim dung
        If Not Me.txtSearhKhoCapTren.SelectedValue Is Nothing Then
            ViewState("SEARCH_VALUE_KHO_CAPTREN_TEXT") = Me.txtSearhKhoCapTren.Text
            ViewState("SEARCH_VALUE_KHO_CAPTREN_VALUE") = Me.txtSearhKhoCapTren.SelectedValue
        End If
    End Sub

    Private Sub GetViewState()
        Me.txtTEN_KHO.Text = ViewState("SEARCH_VALUE_TEN_TINH")
        Me.cboTinh.SelectedValue = ViewState("SEARCH_VALUE_TINH")
        Me.cboHuyen.SelectedValue = ViewState("SEARCH_VALUE_HUYEN")
        Me.txtSearhKhoCapTren.Text = ViewState("SEARCH_VALUE_KHO_CAPTREN_TEXT")
        Me.txtSearhKhoCapTren.SelectedValue = ViewState("SEARCH_VALUE_KHO_CAPTREN_VALUE")
    End Sub

   
    Private Sub BindData(ByVal sTEN_KHO As String, ByVal sMA_TINH As String, ByVal sMA_HUYEN As String, ByVal iID_KHO_CAPTREN As Integer)
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_KHO_BO
        Try
            Me.grdDS.DataSource = obj.Search(sTEN_KHO, sMA_TINH, sMA_HUYEN, iID_KHO_CAPTREN)
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
            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
        End If
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        'Lay du lieu tu viewstate de check xem co phai la tim kiem khong
        GetViewState()

        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtTEN_KHO.Text, Me.cboTinh.SelectedValue, Me.cboHuyen.SelectedValue, IIf(Me.txtSearhKhoCapTren.SelectedValue = String.Empty, Null.NullInteger, Me.txtSearhKhoCapTren.SelectedValue))
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        SetViewState()
        Me.grdDS.CurrentPageIndex = 0
        BindData(Me.txtTEN_KHO.Text, Me.cboTinh.SelectedValue, Me.cboHuyen.SelectedValue, IIf(Me.txtSearhKhoCapTren.SelectedValue = String.Empty, -1, Me.txtSearhKhoCapTren.SelectedValue))
    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtTEN_KHO)
        AppendFilterString(sFilterString, Me.cboTinh)
        AppendFilterString(sFilterString, Me.cboHuyen)
        AppendFilterString(sFilterString, Me.txtSearhKhoCapTren)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
        End If

        GetFilterValue(sFilterString, Me.txtTEN_KHO)
        GetFilterValue(sFilterString, Me.cboTinh)
        GetFilterValue(sFilterString, Me.cboHuyen)
        GetFilterValue(sFilterString, Me.txtSearhKhoCapTren)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_KHO_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(Me.txtTEN_KHO.Text, Me.cboTinh.SelectedValue, Me.cboHuyen.SelectedValue, IIf(Me.txtSearhKhoCapTren.SelectedValue = String.Empty, Null.NullInteger, Me.txtSearhKhoCapTren.SelectedValue))
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


End Class
