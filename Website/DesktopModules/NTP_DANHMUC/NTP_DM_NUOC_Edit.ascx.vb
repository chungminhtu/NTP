Public Class NTP_DM_NUOC_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_DANHMUC.NTP_DM_NUOC_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_NUOC_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                'DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                If Not Request.QueryString("id") Is Nothing Then
                    Me.txtMA_NUOC.Text = Request.QueryString("id")
                    inf = obj.SelectItem(Me.txtMA_NUOC.Text)
                    Me.txtTEN_NUOC.Text = inf.TEN_NUOC
                    Me.txtMA_NUOC.Enabled = False
                End If
                NTP_Common.SetFormFocus(Me.txtMA_NUOC, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim obj As New NTP_DANHMUC.NTP_DM_NUOC_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_NUOC_Info
        Try
            inf.TEN_NUOC = Me.txtTEN_NUOC.Text
            inf.MA_NUOC = Me.txtMA_NUOC.Text
            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)
                'Clear text box
                Me.txtTEN_NUOC.Text = ""
                Me.txtMA_NUOC.Text = ""
                NTP_Common.SetFormFocus(Me.txtMA_NUOC, Me.ModuleConfiguration.SupportsPartialRendering)
            Else
                'Update
                obj.UpdateItem(inf)
            End If
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try
    End Sub


End Class
