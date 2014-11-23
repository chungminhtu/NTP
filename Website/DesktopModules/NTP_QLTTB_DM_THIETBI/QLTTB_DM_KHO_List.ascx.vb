Imports QLTTB_DM_KHO_List
Public Class QLTTB_DM_KHO_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'If DotNetNuke.Framework.AJAX.IsInstalled Then
            '    DotNetNuke.Framework.AJAX.RegisterScriptManager()
            '    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            'End If
            'If Not IsPostBack Then
            '    Dim tb As New NTP_QLTTB.QLTT_DM_THIETBI_BO
            '    Dim ds As New DataSet
            '    ds = tb.SelectAllItems
            '    Me.MultiSelectGrid1.DataSource = ds.Tables(0)
            '    Me.MultiSelectGrid1.DataBind()

            'End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_thongtin.Click
        Response.Redirect(DotNetNuke.Common.NavigateURL("Edit", "mid=" & Me.ModuleId & "&id=1"))
    End Sub
End Class
