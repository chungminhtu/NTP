
Public Class NTP_QLVT_DM_VATTU_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_VATTU_BO
        Dim inf As New NTP_QLVT.NTP_QLVT_DM_VATTU_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                BindCombo()
                BindComboNuoc()
                If Not Request.QueryString("id") Is Nothing Then
                    Me.txtID_VATTU.Text = Request.QueryString("id")
                    inf = obj.SelectItem(Me.txtID_VATTU.Text)
                    Me.txtTEN_VATTU.Text = inf.TEN_VATTU
                    Me.cboDVT.SelectedValue = inf.ID_DVT
                    Me.txtID_VATTU.Enabled = False
                    Me.cboType.SelectedValue = inf.TYPE_HCVT
                    Me.cboNuoc.SelectedValue = inf.MA_NUOC
                End If
                NTP_Common.SetFormFocus(Me.txtTEN_VATTU, Me.ModuleConfiguration.SupportsPartialRendering)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Private Sub BindComboNuoc()
        Dim obj As New NTP_DANHMUC.NTP_DM_NUOC_BO
        Me.cboNuoc.DataSource = obj.SelectAllItems
        Me.cboNuoc.DataBind()
    End Sub

    Private Sub BindCombo()
        Dim obj As New NTP_DANHMUC.NTP_DM_DVT_BO
        Try
            Me.cboDVT.DataSource = obj.SelectAllItems
            Me.cboDVT.DataBind()
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
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_VATTU_BO
        Dim inf As New NTP_QLVT.NTP_QLVT_DM_VATTU_Info
        Try
            inf.TEN_VATTU = Me.txtTEN_VATTU.Text
            inf.ID_DVT = Me.cboDVT.SelectedValue
            inf.TYPE_HCVT = Me.cboType.SelectedValue
            inf.MA_NUOC = Me.cboNuoc.SelectedValue
            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)

                'Clear text box
                Me.txtTEN_VATTU.Text = ""
                Me.txtID_VATTU.Text = ""
                NTP_Common.SetFormFocus(Me.txtTEN_VATTU, Me.ModuleConfiguration.SupportsPartialRendering)
            Else
                'Update
                inf.ID_VATTU = Me.txtID_VATTU.Text
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
