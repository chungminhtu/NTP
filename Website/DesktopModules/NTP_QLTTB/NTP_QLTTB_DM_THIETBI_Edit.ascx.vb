
Public Class NTP_QLTTB_DM_THIETBI_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_Info
        Dim objSecu As New PortalSecurity
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
            End If
            If Not IsPostBack Then
                BindComboNuoc()
                BindComboDVT()
                If Not Request.QueryString("id") Is Nothing Then
                    'BindData()
                    '  Me.txtID_THIETBI.Text = objSecu.InputFilter(Request.QueryString("id"), PortalSecurity.FilterFlag.NoMarkup)

                    Me.txtID_THIETBI.Text = Request.QueryString("id")
                    inf = obj.SelectItem(Me.txtID_THIETBI.Text)
                    Me.txtTEN_THIETBI.Text = inf.TEN_THIETBI
                    Me.cboNUOC.SelectedValue = inf.MA_NUOC
                    Me.cboDVT.SelectedValue = inf.ID_DVT
                    Me.txtNhanHieu.Text = inf.NHAN_HIEU
                End If
                NTP_Common.SetFormFocus(Me.txtTEN_THIETBI, Me.ModuleConfiguration.SupportsPartialRendering)

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
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Chọn nước ---"
            Me.cboNUOC.DataSource = obj.SelectAllItems
            Me.cboNUOC.DataBind()
            Me.cboNUOC.Items.Insert(0, itm)

        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboDVT()
        Dim obj As New NTP_DANHMUC.NTP_DM_DVT_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Chọn đơn vị tính ---"
            Me.cboDVT.DataSource = obj.SelectAllItems
            Me.cboDVT.DataBind()
            Me.cboDVT.Items.Insert(0, itm)
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_Info
        Try
            inf.TEN_THIETBI = Me.txtTEN_THIETBI.Text
            inf.MA_NUOC = cboNUOC.SelectedValue
            inf.ID_DVT = cboDVT.SelectedValue
            inf.NHAN_HIEU = Me.txtNhanHieu.Text

            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)
                Me.txtTEN_THIETBI.Text = ""
                Me.txtNhanHieu.Text = ""

            Else
                'Update
                inf.ID_THIETBI = Me.txtID_THIETBI.Text
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
