Imports NTP_Common.mdlGlobal

Partial Class QLT_BAOCAO_SUDUNGTHUOC_TUYENHUYEN
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Private Sub BindComboQuy()
        Me.cboThang.Items.Add(New ListItem("Quý I", 1))
        Me.cboThang.Items.Add(New ListItem("Quý II", 2))
        Me.cboThang.Items.Add(New ListItem("Quý III", 3))
        Me.cboThang.Items.Add(New ListItem("Quý IV", 4))
        'Me.cboThang.Items.Add(New ListItem("Thang 5", 5))
        'Me.cboThang.Items.Add(New ListItem("Thang 6", 6))
        'Me.cboThang.Items.Add(New ListItem("Thang 7", 7))
        'Me.cboThang.Items.Add(New ListItem("Thang 8", 8))
        'Me.cboThang.Items.Add(New ListItem("Thang 9", 9))
        'Me.cboThang.Items.Add(New ListItem("Thang 10", 10))
        'Me.cboThang.Items.Add(New ListItem("Thang 11", 11))
        'Me.cboThang.Items.Add(New ListItem("Thang 12", 12))
        Me.cboThang.SelectedIndex = 0
    End Sub
    Private Sub BindComboYear()
        Me.cboNam.Items.Add(New ListItem(Now.Year, Now.Year))
        Me.cboNam.Items.Add(New ListItem(Now.Year - 1, Now.Year - 1))
        Me.cboNam.SelectedIndex = 0
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboQuy()
                BindComboYear()
                '
            End If
            Me.Literal1.Visible = False
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        BaoCao(Me.cboNam.SelectedValue, Me.cboThang.SelectedValue)
    End Sub
    Private Sub BaoCao(ByVal Nam As Integer, ByVal Thang As Integer)
        'Xem bao cao kiem ke
        Dim url As String
        url = Request.ApplicationPath & "/DesktopModules/NTP_QLT/QLT_BAOCAO_SuDungThuoc_TuyenHuyen.aspx?Nam=" & Nam & "&Quy=" & Thang & "&ID_KHO=" & Me.CurrentUserStock.ID_KHO_THUOC
        ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
        Literal1.Text = "<script language = 'javascript'>" & _
                                "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
        Literal1.Visible = True
    End Sub

End Class
