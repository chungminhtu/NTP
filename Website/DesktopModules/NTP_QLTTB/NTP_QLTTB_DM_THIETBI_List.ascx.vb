Imports NTP_Common.mdlGlobal

Public Class NTP_QLTTB_DM_THIETBI_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                GetFilter()
                If Not Session(FILTER_STRING) Is Nothing Then
                    BindData(Me.txtSearhThietBi.Text.Trim)
                    ' setstate
                    'SetViewState()
                    '
                Else
                    BindData(Me.txtSearhThietBi.Text.Trim)
                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

  

 
    'Private Sub SetViewState()

    '    'Chi set viewstate neu tim dung
    '    If Not Me.txtSearhThietBi.SelectedValue Is Nothing Then
    '        ViewState("SEARCH_VALUE_TEN_THIETBI_TEXT") = Me.txtSearhThietBi.Text
    '        ViewState("SEARCH_VALUE_TEN_THIETBI_VALUE") = Me.txtSearhThietBi.SelectedValue
    '    End If
    'End Sub



    'Private Sub GetViewState()
    '    Me.txtSearhThietBi.Text = ViewState("SEARCH_VALUE_TEN_THIETBI_TEXT")
    '    Me.txtSearhThietBi.SelectedValue = ViewState("SEARCH_VALUE_TEN_THIETBI_VALUE")
    'End Sub

    Private Sub BindData(ByVal sTEN_THIETBI As String)
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO
        Try
            Me.grdDS.DataSource = obj.Search(sTEN_THIETBI)
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
        'GetViewState()
        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtSearhThietBi.Text.Trim)
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        'SetViewState()
        Me.grdDS.CurrentPageIndex = 0
        BindData(Me.txtSearhThietBi.Text.Trim)
    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtSearhThietBi)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
        End If

        GetFilterValue(sFilterString, Me.txtSearhThietBi)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(Me.txtSearhThietBi.Text.Trim)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

  


End Class
