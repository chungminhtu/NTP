
Public Class QLTTB_DM_KHO_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            If Not IsPostBack Then
                Me.txt_mathietbi.Text = Request.QueryString("id_thietbi")
                Me.txt_tenthietbi.Text = Request.QueryString("ten_thietbi")
                Me.txt_dvt.Text = Request.QueryString("id_dvt")
                Me.txt_manuoc.Text = Request.QueryString("ma_nuoc")
                Me.txt_nhanhieu.Text = Request.QueryString("nhan_hieu")
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub
End Class
