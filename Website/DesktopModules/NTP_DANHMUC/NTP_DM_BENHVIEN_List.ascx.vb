Imports NTP_Common.mdlGlobal

Public Class NTP_DM_BENHVIEN_List
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
                    BindData(Me.txtTenBenhVien.Text, cboCap.SelectedValue)
                    ' setstate
                    ViewState.Add("SEARCH_VALUE_TEN_BENHVIEN", Me.txtTenBenhVien.Text)
                    ViewState.Add("SEARCH_VALUE_VUNG", Me.cboCap.SelectedValue)
                Else
                    BindData(Me.txtTenBenhVien.Text, cboCap.SelectedValue)
                End If
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindCombo()
        Dim obj As New NTP_DANHMUC.NTP_DM_CAP_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullInteger
            itm.Text = "--- Không xác định ---"
            Me.cboCap.DataSource = obj.SelectAllItems
            Me.cboCap.DataBind()
            Me.cboCap.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Private Sub BindData(ByVal sTenBenhVien As String, ByVal iVung As Integer)
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Try
            Me.grdDS.DataSource = obj.Search(sTenBenhVien, iVung)
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
        Me.txtTenBenhVien.Text = ViewState("SEARCH_VALUE_TEN_BENHVIEN")
        Me.cboCap.SelectedIndex = ViewState("SEARCH_VALUE_VUNG")

        grdDS.CurrentPageIndex = e.NewPageIndex
        BindData(Me.txtTenBenhVien.Text, Me.cboCap.SelectedValue)
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Luu state de tim kiem 
        ViewState.Add("SEARCH_VALUE_TEN_BENHVIEN", Me.txtTenBenhVien.Text)
        ViewState.Add("SEARCH_VALUE_VUNG", Me.cboCap.SelectedValue)
        Me.grdDS.CurrentPageIndex = 0
        BindData(Me.txtTenBenhVien.Text, Me.cboCap.SelectedValue)
    End Sub

    Private Sub SetFilter()
        Dim sFilterString As String
        sFilterString = ""
        AppendFilterString(sFilterString, Me.txtTenBenhVien)
        AppendFilterString(sFilterString, Me.cboCap)
        Session(FILTER_STRING) = sFilterString
    End Sub

    Private Sub GetFilter()
        Dim sFilterString As String
        If Not Session(FILTER_STRING) Is Nothing Then
            sFilterString = Session(FILTER_STRING)
        End If

        GetFilterValue(sFilterString, Me.txtTenBenhVien)
        GetFilterValue(sFilterString, Me.cboCap)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            BindData(Me.txtTenBenhVien.Text, Me.cboCap.SelectedValue)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cmdCapBenhVien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCapBenhVien.Click
        Response.Redirect(NavigateURL("cap", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdDonvi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDonvi.Click
        Response.Redirect(NavigateURL("donvi", "mid=" & Me.ModuleId))
    End Sub
End Class
