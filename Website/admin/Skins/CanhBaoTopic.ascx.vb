Imports DotNetNuke
Imports NTP_DANHMUC

Namespace YourCompany.Modules.NTP_NEWS
    Partial Class CanhBaoTopic
        Inherits Entities.Modules.PortalModuleBase

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim objBO As NTP_CanhBao_BO = New NTP_CanhBao_BO
            hrefCanhBao.Visible = objBO.CanhBao
        End Sub
    End Class
End Namespace
