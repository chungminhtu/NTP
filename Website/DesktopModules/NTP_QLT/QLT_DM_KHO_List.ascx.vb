Imports QLT_DM_KHO_List
Partial Public Class QLT_DM_KHO_List
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then

                Dim bibi As New NTP_QLT.QLT_DM_KHO_BO



                Dim ds As New DataSet
                ds = bibi.SelectAllItems()
                Me.dgv_DM_Kho_Duoc.DataSource = ds.Tables(0)
                Me.dgv_DM_Kho_Duoc.DataBind()

            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect(DotNetNuke.Common.NavigateURL("Edit", "mid=" & Me.ModuleId & "&id=1"))
        '  Response.Redirect(DotNetNuke.Common.Globals.NavigateURL(PortalSettings.ActiveTab.TabID, "QLTEdit", "mid=" + ModuleId.ToString()))
    End Sub
End Class
