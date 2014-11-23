
Partial Public Class DesktopModules__Template_Blank
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                ' Dim obj As New NTP_QLVT.Blank_BO
                Me.TextBox1.Text = Me.UserId
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
       
    End Sub
End Class
