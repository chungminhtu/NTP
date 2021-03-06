Imports NTP_Common.mdlGlobal

Public Class NTP_QLT_BC_SDTHUOC_TW_LIST
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboYear()
                cboQuy.SelectedValue = Quy()
            End If
            Me.Literal1.Visible = False
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindComboYear()
        Me.cboNam.Items.Add(New ListItem(Now.Year, Now.Year))
        Me.cboNam.Items.Add(New ListItem(Now.Year - 1, Now.Year - 1))
        Me.cboNam.SelectedIndex = 0
    End Sub

    Private Function Quy() As Int16
        Dim iMonth As Int16
        iMonth = Now.Month
        If iMonth >= 1 And iMonth <= 3 Then
            Return 1
        End If
        If iMonth >= 4 And iMonth < 6 Then
            Return 2
        End If
        If iMonth >= 7 And iMonth <= 9 Then
            Return 3
        End If
        If iMonth >= 10 And iMonth <= 12 Then
            Return 4
        End If
    End Function

    Private Sub BaoCao(ByVal ID_KHO As Integer, ByVal ID_KY As Integer, ByVal NAM As Int16)
        'Xem bao cao kiem ke
        Dim url As String
        url = Request.ApplicationPath & "/DesktopModules/NTP_NHAP_BAOCAO/NTP_QLT_BC_SDTHUOC_TW_VIEW.aspx?ID_KHO=" & ID_KHO & "&ID_KY=" & ID_KY & "&NAM=" & NAM ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
        Literal1.Text = "<script language = 'javascript'>" & _
                                "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
        Literal1.Visible = True
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        BaoCao(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboQuy.SelectedValue, cboNam.SelectedValue)
    End Sub

End Class
