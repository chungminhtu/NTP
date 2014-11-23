Imports NTP_Common.mdlGlobal

Partial Class QLT_BAOCAO_THUOC_TUYENTINH
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboYear()
                BindGrid()
                '
            End If
            Me.Literal1.Visible = False
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindComboYear()
        Me.cboNam.Items.Add(New ListItem(Now.Year, Now.Year))
        Me.cboNam.Items.Add(New ListItem(Now.Year - 1, Now.Year - 1))
        Me.cboNam.SelectedIndex = 0
    End Sub
    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        Me.grdDS.CurrentPageIndex = e.NewPageIndex
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim ds As New DataSet
        Dim obj As New NTP_QLT.QLT_KY_KIEMKE_BO
        Try
            grdDS.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboNam.Text)
            grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub
    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "baocao" Then
            BaoCao(Me.CurrentUserStock.ID_KHO_THUOC, e.Item.Cells(1).Text)
        End If
    End Sub

    Private Sub BaoCao(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Integer)
        'Xem bao cao kiem ke
        Dim url As String
        url = Request.ApplicationPath & "/DesktopModules/NTP_QLT/QLT_BAOCAO_SUDUNGTHUOC.aspx?ID_KHO=" & ID_KHO & "&ID_KY_KIEMKE=" & ID_KY_KIEMKE ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
        Literal1.Text = "<script language = 'javascript'>" & _
                                "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
        Literal1.Visible = True
    End Sub
End Class
