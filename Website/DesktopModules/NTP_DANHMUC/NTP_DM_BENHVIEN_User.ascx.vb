Imports NTP_Common.mdlGlobal

Public Class NTP_DM_BENHVIEN_User

    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                BindCombo()
                BindDataCurrent(cboBV.SelectedValue)
                BindDataDS("", Me.cboBV.SelectedValue)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindCombo()
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Dim itm As ListItem
        Try
            'itm = New ListItem
            'itm.Value = Null.NullInteger
            'itm.Text = "--- Không xác định ---"
            Me.cboBV.DataSource = obj.SelectAllItems
            Me.cboBV.DataBind()
            ' Me.cboCap.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindDataCurrent(ByVal iID_BenhVien As Integer)
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Try
            Me.grdCurrent.DataSource = obj.GetUserInBV(iID_BenhVien)
            Me.grdCurrent.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindDataDS(ByVal sSearch As String, ByVal ID_BENHVIEN_KHO As Integer)
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Try
            Me.grdDS.DataSource = obj.SearchUser(sSearch, ID_BENHVIEN_KHO)
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        'Lay du lieu tu viewstate de check xem co phai la tim kiem khong
        grdDS.CurrentPageIndex = e.NewPageIndex
        BindDataDS(Me.txtSearch.Text, Me.cboBV.SelectedValue)
    End Sub

    Protected Sub grdCurrent_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdCurrent.PageIndexChanged
        'Lay du lieu tu viewstate de check xem co phai la tim kiem khong
        grdCurrent.CurrentPageIndex = e.NewPageIndex
        BindDataCurrent(Me.cboBV.SelectedValue)
    End Sub

    Protected Sub cboCap_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBV.SelectedIndexChanged
        grdCurrent.CurrentPageIndex = 0
        BindDataCurrent(Me.cboBV.SelectedValue)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.CapNhatUser_BV(cboBV.SelectedValue, itm.Cells(2).Text)
            Next
            BindDataDS("", Me.cboBV.SelectedValue)
            BindDataCurrent(cboBV.SelectedValue)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Try
            For Each itm In Me.grdCurrent.SelectedItems
                obj.CapNhatUser_BV(Null.NullInteger, itm.Cells(2).Text)
            Next
            BindDataDS("", Me.cboBV.SelectedValue)
            BindDataCurrent(cboBV.SelectedValue)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Me.grdDS.CurrentPageIndex = 0
        BindDataDS(Me.txtSearch.Text.Trim, Me.cboBV.SelectedValue)
    End Sub
End Class
