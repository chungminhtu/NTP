Imports DotNetNuke
Imports NTP_Common.mdlGlobal
Imports NTP_Common.Common
Imports NTP_DANHMUC

Namespace YourCompany.Modules.NTP_NEWS
    Partial Class DesktopModules_NTP_NEWS_NEWS_List
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
            Dim objinfo As NTP_NEWS_Info = New NTP_NEWS_Info
            Dim sNewID As String = ""
            Try
                If Not Request.QueryString("NewID") Is Nothing Then sNewID = Request.QueryString("NewID")
                objinfo.NewID = sNewID
                objBO.GetNewsShow(objinfo)
                lblTieuDe.Text = objinfo.TieuDe
                lblMoTa.Text = objinfo.MoTa
                lblNoiDung.Text = objinfo.NoiDung
                lblNguoiLap.Text = objinfo.Username
                lblNgayLap.Text = objinfo.ThoiGian
            Catch ex As Exception

            End Try

        End Sub
 
 
    End Class
End Namespace
