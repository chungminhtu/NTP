Imports NTP_Common.mdlGlobal

Public Class NTP_QLT_DM_THUOC_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                'If DotNetNuke.Framework.AJAX.IsInstalled Then
                '    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'End If
                'GetFilter()
                'If Not Session(FILTER_STRING) Is Nothing Then
                '    ' setstate
                '    ViewState.Add("SEARCH_VALUE_TEN_VATTU", Me.txtTEN_THUOC.Text)
                '    '
                'Else
                BindData("")
                'End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindData(ByVal sTEN_THUOC As String)
        Dim obj As New NTP_QLT.QLT_DM_THUOC_BO
        Try
            Me.grdDS.DataSource = obj.Search(sTEN_THUOC)
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try

    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            'SetFilter()
            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
        End If
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged

        'Lay du lieu tu viewstate de check xem co phai la tim kiem khong
        ' Me.txtTEN_THUOC.Text = ViewState("SEARCH_VALUE_TEN_VATTU")

        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtTEN_VATTU.Text)
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        'ViewState.Add("SEARCH_VALUE_TEN_VATTU", Me.txtTEN_THUOC.Text)

        BindData(Me.txtTEN_VATTU.Text)
    End Sub

    'Private Sub SetFilter()
    '    Dim sFilterString As String
    '    sFilterString = ""
    '    AppendFilterString(sFilterString, Me.txtTEN_THUOC)
    '    Session(FILTER_STRING) = sFilterString
    'End Sub

    'Private Sub GetFilter()
    '    Dim sFilterString As String
    '    If Not Session(FILTER_STRING) Is Nothing Then
    '        sFilterString = Session(FILTER_STRING)
    '    End If

    '    GetFilterValue(sFilterString, Me.txtTEN_THUOC)
    'End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.QLT_DM_THUOC_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(Me.txtTEN_VATTU.Text)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

End Class
