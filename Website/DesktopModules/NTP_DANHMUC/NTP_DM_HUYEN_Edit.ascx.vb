
Public Class NTP_DM_HUYEN_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_HUYEN_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If

            If Not IsPostBack Then
                BindCombo()
                If Not Request.QueryString("id") Is Nothing Then
                    Me.txtID_HUYEN.Text = Request.QueryString("id").ToString
                    inf = obj.SelectItem(Me.txtID_HUYEN.Text)
                    Me.txtTEN_HUYEN.Text = inf.TEN_HUYEN
                    Me.cboVung.SelectedValue = inf.MA_TINH
                    Me.txtID_HUYEN.Enabled = False
                End If
                NTP_Common.SetFormFocus(Me.txtID_HUYEN, Me.ModuleConfiguration.SupportsPartialRendering)
            End If

            If Not cboVung.SelectedValue Is Nothing Then
                txtID_HUYEN.Text = obj.GetID(cboVung.SelectedValue.ToString)
            End If

        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Private Sub BindCombo()
        Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
        Try
            Me.cboVung.DataSource = obj.SelectAllItems
            Me.cboVung.DataBind()
            ' Me.cboVung.Items.Insert(0, (New ListItem(-1, "")))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub


    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_HUYEN_Info
        Try
            inf.TEN_HUYEN = Me.txtTEN_HUYEN.Text
            inf.MA_TINH = Me.cboVung.SelectedValue
            inf.MA_HUYEN = Me.txtID_HUYEN.Text
            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)

                'Clear text box
                Me.txtTEN_HUYEN.Text = ""
                Me.txtID_HUYEN.Text = obj.GetID(cboVung.SelectedValue.ToString)

                NTP_Common.SetFormFocus(Me.txtID_HUYEN, Me.ModuleConfiguration.SupportsPartialRendering)
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
