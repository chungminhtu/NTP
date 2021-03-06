Imports NTP_Common.mdlGlobal
Imports Anthem

Public Class NTP_DM_NUOC_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                GetFilter()
                If Not Session(FILTER_STRING) Is Nothing Then
                    BindData(Me.txtTEN_NUOC.Text)
                    ' setstate
                    ViewState.Add("SEARCH_VALUE_TEN_NUOC", Me.txtTEN_NUOC.Text)
                Else
                    BindData(Me.txtTEN_NUOC.Text)
                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindData(ByVal sTenNuoc As String)
        Dim obj As New NTP_DANHMUC.NTP_DM_NUOC_BO
        Try
            Me.grdDS.DataSource = obj.Search(sTenNuoc)
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
        Me.txtTEN_NUOC.Text = ViewState("SEARCH_VALUE_TEN_NUOC")

        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtTEN_NUOC.Text)
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        ViewState.Add("SEARCH_VALUE_TEN_NUOC", Me.txtTEN_NUOC.Text)
        BindData(Me.txtTEN_NUOC.Text)
    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtTEN_NUOC)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
        End If

        GetFilterValue(sFilterString, Me.txtTEN_NUOC)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_DANHMUC.NTP_DM_NUOC_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(Me.txtTEN_NUOC.Text)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Private Function SearchData(ByVal sTenNuoc As String) As DataTable
        Dim obj As New NTP_DANHMUC.NTP_DM_NUOC_BO
        Dim ds As New DataSet
        Try
            ds = obj.Search(sTenNuoc)
            Return ds.Tables(0)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Function


End Class
