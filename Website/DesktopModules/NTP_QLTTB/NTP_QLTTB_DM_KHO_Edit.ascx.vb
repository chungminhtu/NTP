
Public Class NTP_QLTTB_DM_KHO_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_KHO_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_DM_KHO_Info
        Dim objSecu As New PortalSecurity
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
            End If
            If Not IsPostBack Then
                BindComboTinh()
                BindComboKho("", "")
                If Not Request.QueryString("id") Is Nothing Then
                    'BindData()
                    Me.txtID_KHO.Text = objSecu.InputFilter(Request.QueryString("id"), PortalSecurity.FilterFlag.NoMarkup)
                    inf = obj.SelectItem(Me.txtID_KHO.Text)
                    Me.txtMA_KHO.Text = inf.MA_KHO
                    Me.txtTEN_KHO.Text = inf.TEN_KHO
                    Me.cboTINH.SelectedValue = inf.MA_TINH
                    BindComboHuyen(Me.cboTINH.SelectedValue)
                    Me.cboHuyen.SelectedValue = inf.MA_HUYEN
                    Me.cboKho.SelectedValue = inf.ID_KHO_CAPTREN
                    Me.txtDiaChi.Text = inf.DIA_CHI

                    Me.txtMA_KHO.Enabled = False
                    NTP_Common.SetFormFocus(Me.txtTEN_KHO, Me.ModuleConfiguration.SupportsPartialRendering)
                Else
                    NTP_Common.SetFormFocus(Me.txtMA_KHO, Me.ModuleConfiguration.SupportsPartialRendering)
                End If

            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Private Sub BindComboTinh()
        Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Chọn tỉnh ---"
            Me.cboTinh.DataSource = obj.SelectAllItems
            Me.cboTinh.DataBind()
            Me.cboTinh.Items.Insert(0, itm)

            'BindComboHuyen(Me.cboTinh.SelectedValue)

        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboHuyen(ByVal sTinh As String)
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullString
            itm.Text = "--- Chọn huyện ---"
            Me.cboHuyen.DataSource = obj.Search("", sTinh)
            Me.cboHuyen.DataBind()
            Me.cboHuyen.Items.Insert(0, itm)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindComboKho(ByVal sMaTinh As String, ByVal sMaHuyen As String)
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_KHO_BO
        Dim itm As ListItem
        Try
            itm = New ListItem
            itm.Value = Null.NullInteger
            itm.Text = "--- Không xác định ---"
            Me.cboKho.DataSource = obj.Search("", sMaTinh, sMaHuyen, Null.NullInteger)
            Me.cboKho.DataBind()
            Me.cboKho.Items.Insert(0, itm)
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
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_KHO_BO
        Dim inf As New NTP_QLTTB.NTP_QLTTB_DM_KHO_Info
        Try

            inf.MA_KHO = Me.txtMA_KHO.Text
            inf.TEN_KHO = Me.txtTEN_KHO.Text
            inf.MA_TINH = cboTINH.SelectedValue 'ccddlTinh.SelectedValue.Split(":")(0)
            inf.MA_HUYEN = cboHuyen.SelectedValue 'ccddlHuyen.SelectedValue.Split(":")(0)
            'If ccddlKho.SelectedValue.Split(":")(0) <> "" Then
            '    inf.ID_KHO_CAPTREN = ccddlKho.SelectedValue.Split(":")(0)
            'End If
            inf.ID_KHO_CAPTREN = cboKho.SelectedValue

            inf.DIA_CHI = Me.txtDiaChi.Text

            If Request.QueryString("id") Is Nothing Then
                'Add
                obj.InsertItem(inf)

                'Clear text box
                Me.txtMA_KHO.Text = ""
                Me.txtTEN_KHO.Text = ""
                Me.txtDiaChi.Text = ""

                NTP_Common.SetFormFocus(Me.txtMA_KHO, Me.ModuleConfiguration.SupportsPartialRendering)
            Else
                'Update
                inf.ID_KHO = Me.txtID_KHO.Text
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

    Protected Sub cboTINH_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTINH.SelectedIndexChanged
        BindComboHuyen(Me.cboTINH.SelectedValue)
        NTP_Common.SetFormFocus(cboHuyen, Me.ModuleConfiguration.SupportsPartialRendering)
    End Sub
End Class
