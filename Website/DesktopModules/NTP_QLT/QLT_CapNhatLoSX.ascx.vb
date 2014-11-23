Imports NTP_Common.mdlGlobal
Partial Class QLT_CapNhatLoSX
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindComboBoxDM_Thuoc()
        End If
    End Sub

    Protected Sub cboThuoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboThuoc.SelectedIndexChanged
        BindDaTaGrid(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)
    End Sub

    Private Sub BindComboBoxDM_Thuoc()
        Dim bibi As New NTP_DANHMUC.NTP_DM_THUOC_BO
        Me.cboThuoc.DataSource = bibi.SelectAllItems
        Me.cboThuoc.DataBind()
        'bibi = Nothing
    End Sub

    Private Sub BindDaTaGrid(ByVal ID_Thuoc As Integer, ByVal ID_Kho As Integer)
        Dim bibi As New NTP_QLT.QLT_DM_THUOC_BO
        Try
            'Me.cboLoSX.DataSource = bibi.searchLo(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)
            Me.grdDS.DataSource = bibi.searchLo(ID_Thuoc, ID_Kho)
            Me.grdDS.DataBind()
        Catch ex As Exception
            Me.grdDS.DataSource = Nothing
        End Try
    End Sub

    Protected Sub grdDS_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.EditCommand
        If e.CommandName = "edit" Then
            Me.txtLoSX.Text = e.Item.Cells(2).Text
            Me.txtLo_SXCu.Text = e.Item.Cells(2).Text
        End If
    End Sub

    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim bibi As New NTP_QLT.QLT_DM_THUOC_BO
        Try
            'Me.cboLoSX.DataSource = bibi.searchLo(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)
            bibi.Update_LoSX(Me.cboThuoc.SelectedValue, Me.txtLoSX.Text, Me.txtLo_SXCu.Text, Me.CurrentUserStock.ID_KHO_THUOC)
            BindDaTaGrid(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)
        Catch ex As Exception
            Me.grdDS.DataSource = Nothing
        End Try
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        grdDS.CurrentPageIndex = e.NewPageIndex
        BindDaTaGrid(Me.cboThuoc.SelectedValue, Me.CurrentUserStock.ID_KHO_THUOC)

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect(NavigateURL())
    End Sub
End Class
