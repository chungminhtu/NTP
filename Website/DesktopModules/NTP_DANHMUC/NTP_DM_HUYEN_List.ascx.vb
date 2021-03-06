Imports NTP_Common.mdlGlobal

Public Class NTP_DM_HUYEN_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                GetFilter()
                BindCombo()
                If Not Session(FILTER_STRING) Is Nothing Then
                    BindData(Me.txtTEN_TINH.Text, cboTinh.SelectedValue)
                    ' setstate
                    'ViewState.Add("SEARCH_VALUE_TEN_HUYEN", Me.txtTEN_TINH.Text)
                    'ViewState.Add("SEARCH_VALUE_TINH", Me.cboTinh.SelectedValue)
                Else
                    BindData(Me.txtTEN_TINH.Text, cboTinh.SelectedValue)
                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindCombo()
        Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Không xác định ---"
            Me.cboTinh.DataSource = obj.SelectAllItems
            Me.cboTinh.DataBind()
            Me.cboTinh.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Private Sub BindData(ByVal sTenHuyen As String, ByVal sTinh As String)
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Try
            Me.grdDS.DataSource = obj.Search(sTenHuyen, sTinh)
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
        'Me.txtTEN_TINH.Text = ViewState("SEARCH_VALUE_TEN_HUYEN")
        'Me.cboTinh.SelectedIndex = ViewState("SEARCH_VALUE_TINH")

        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtTEN_TINH.Text, Me.cboTinh.SelectedValue)
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        'ViewState.Add("SEARCH_VALUE_TEN_HUYEN", Me.txtTEN_TINH.Text)
        'ViewState.Add("SEARCH_VALUE_TINH", Me.cboTinh.SelectedValue)
        grdDS.CurrentPageIndex = 0
        BindData(Me.txtTEN_TINH.Text, Me.cboTinh.SelectedValue)
    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtTEN_TINH)
        AppendFilterString(sFilterString, Me.cboTinh)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
        End If

        GetFilterValue(sFilterString, Me.txtTEN_TINH)
        GetFilterValue(sFilterString, Me.cboTinh)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(Me.txtTEN_TINH.Text, Me.cboTinh.SelectedValue)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub
End Class
