Imports DotNetNuke
Imports NTP_Common.mdlGlobal
Imports NTP_DANHMUC

Namespace YourCompany.Modules.NTP_NEWS
    Partial Class DesktopModules_NTP_NEWS_NEWS_TinDaDua
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

            dtlAllNews.DataSource = objBO.TinDaDua()
            dtlAllNews.DataBind()

            ClearForm()
        End Sub

        ''' <summary>
        ''' Xóa trắng form nhập liệu
        ''' </summary>
        ''' <remarks></remarks>
        Sub ClearForm()

        End Sub

    End Class
End Namespace
