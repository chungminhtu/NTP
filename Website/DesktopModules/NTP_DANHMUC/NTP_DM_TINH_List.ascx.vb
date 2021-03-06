Imports NTP_Common.mdlGlobal

Public Class NTP_DM_TINH_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.WrapUpdatePanelControl(Me.grdDS, True)
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.cmdSearch)
                    'Add ID
                End If
                GetFilter()
                BindCombo()
                If Not Session(FILTER_STRING) Is Nothing Then
                    BindData(Me.txtTEN_TINH.Text, cboVung.SelectedValue)
                    ' setstate
                    'ViewState.Add("SEARCH_VALUE_TEN_TINH", Me.txtTEN_TINH.Text)
                    'ViewState.Add("SEARCH_VALUE_VUNG", Me.cboVung.SelectedValue)
                    '
                Else
                    BindData(Me.txtTEN_TINH.Text, cboVung.SelectedValue)
                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindCombo()
        Dim obj As New NTP_DANHMUC.NTP_DM_VUNG_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullInteger
            itm.Text = "--- Không xác định ---"
            Me.cboVung.DataSource = obj.SelectAllItems
            Me.cboVung.DataBind()
            Me.cboVung.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Private Sub BindData(ByVal sTenTinh As String, ByVal iVung As Integer)
        Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
        Try
            Me.grdDS.DataSource = obj.Search(sTenTinh, iVung)
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
        'Me.txtTEN_TINH.Text = ViewState("SEARCH_VALUE_TEN_TINH")
        'Me.cboVung.SelectedIndex = ViewState("SEARCH_VALUE_VUNG")

        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtTEN_TINH.Text, Me.cboVung.SelectedValue)
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        'ViewState.Add("SEARCH_VALUE_TEN_TINH", Me.txtTEN_TINH.Text)
        'ViewState.Add("SEARCH_VALUE_VUNG", Me.cboVung.SelectedValue)
        grdDS.CurrentPageIndex = 0
        BindData(Me.txtTEN_TINH.Text, Me.cboVung.SelectedValue)
        'System.Threading.Thread.Sleep(10000)
    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtTEN_TINH)
        AppendFilterString(sFilterString, Me.cboVung)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String = ""
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
        End If

        GetFilterValue(sFilterString, Me.txtTEN_TINH)
        GetFilterValue(sFilterString, Me.cboVung)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(Me.txtTEN_TINH.Text, Me.cboVung.SelectedValue)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

End Class
