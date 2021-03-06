Imports DotNetNuke
Imports NTP_Common.mdlGlobal
Imports NTP_DANHMUC

Namespace YourCompany.Modules.NTP_NEWS
    Partial Class DesktopModules_NTP_NEWS_NEWS_Edit
        Inherits Entities.Modules.PortalModuleBase

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                BindData()
            End If
        End Sub

        ''' <summary>
        ''' Load danh sách tin tức từ CSDL
        ''' </summary>
        ''' <remarks></remarks>
        Sub BindData()
            Dim objBO As NTP_NEWS_BO = New NTP_NEWS_BO

            dgvDanhSach.DataSource = objBO.SelectAllItem()
            dgvDanhSach.DataBind()

            ClearForm()
        End Sub

        ''' <summary>
        ''' Xóa trắng form nhập liệu
        ''' </summary>
        ''' <remarks></remarks>
        Sub ClearForm()
            txtTieuDe.Text = ""
            txtMoTa.Text = ""
            txtNoiDung.Text = ""
            txtNewID.Text = ""
        End Sub

        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim objinfo As NTP_NEWS_Info = New NTP_NEWS_Info
            Dim objBO As NTP_NEWS_BO = New NTP_NEWS_BO
            Try
                objinfo.NewID = txtNewID.Text
                objinfo.MoTa = txtMoTa.Text
                objinfo.TieuDe = txtTieuDe.Text
                objinfo.NoiDung = txtNoiDung.Text
                objinfo.UserID = Me.CurrentUserStock.USERID
                If txtNewID.Text <> "" Then
                    objBO.UpdateItem(objinfo)
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Đã cập nhật thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                Else
                    objBO.InsertItem(objinfo)
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Đã thêm mới thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                End If
                BindData()
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                objinfo = Nothing
                objBO = Nothing
            End Try
        End Sub

        Protected Sub dgvDanhSach_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgvDanhSach.ItemCommand
            Dim objinfo As NTP_NEWS_Info = New NTP_NEWS_Info
            'CuongNH2: Bổ sung thêm nút báo cáo tuyến huyện
            If e.CommandName = "edit" Then
                Dim objBO As NTP_NEWS_BO = New NTP_NEWS_BO

                Dim sNewID As String = e.Item.Cells(0).Text
                objinfo.NewID = sNewID
                objBO.SelectItemByID(objinfo)
                txtTieuDe.Text = objinfo.TieuDe
                txtMoTa.Text = objinfo.MoTa
                txtNoiDung.Text = objinfo.NoiDung
                txtNewID.Text = sNewID
            ElseIf e.CommandName = "delete" Then
                Dim sNewID As String = e.Item.Cells(0).Text
                Dim objBO As NTP_NEWS_BO = New NTP_NEWS_BO
                objinfo.NewID = sNewID
                objBO.DeleteItem(objinfo)
                BindData()
            End If
        End Sub
    End Class
End Namespace
