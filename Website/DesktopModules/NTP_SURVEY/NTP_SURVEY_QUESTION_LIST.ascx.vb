Imports NTP_Common.mdlGlobal

Public Class NTP_SURVEY_EDIT
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then

            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

End Class
