
Public Class NTP_DM_DVT_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_DANHMUC.NTP_DM_DVT_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_DVT_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                If Not Request.QueryString("id") Is Nothing Then
                    Me.txtID_DVT.Text = Request.QueryString("id")
                    inf = obj.SelectItem(Me.txtID_DVT.Text)
                    Me.txtTEN_DVT.Text = inf.TEN_DVT
                End If
                NTP_Common.SetFormFocus(Me.txtTEN_DVT, Me.ModuleConfiguration.SupportsPartialRendering)
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
        Dim obj As New NTP_DANHMUC.NTP_DM_DVT_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_DVT_Info
        Try
            inf.TEN_DVT = Me.txtTEN_DVT.Text
            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)
                'Clear text box
                Me.txtTEN_DVT.Text = ""
                NTP_Common.SetFormFocus(Me.txtTEN_DVT, Me.ModuleConfiguration.SupportsPartialRendering)
            Else
                'Update
                inf.ID_DVT = Me.txtID_DVT.Text
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
