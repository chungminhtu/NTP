
Public Class NTP_CURRENTSTOCK
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim s As String
            If Me.UserId <> -1 Then
                s = "{0}"
                Try
                    Me.Label1.Text = String.Format(s, Me.CurrentUserStock.TEN_TINH)
                Catch ex As Exception
                    Me.Label1.Text = "host"
                End Try
            End If
        End If
    End Sub
End Class
