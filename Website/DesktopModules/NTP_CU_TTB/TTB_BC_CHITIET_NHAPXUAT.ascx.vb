
Partial Class TTB_BC_CHITIET_NHAPXUAT
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboThang()
                BindComboNguonKP()
                BindComboThuoc()
                Me.txtNam.Text = Now.Year
            End If
            Me.Literal1.Visible = False
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindComboNguonKP()
        Try
            cboNguonKP.DataSource = (New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO).SelectAllItems
            cboNguonKP.DataBind()
            cboNguonKP.Items.Insert(0, (New ListItem("--- Tất cả ---", -1)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindComboThuoc()
        Try
            cboThuoc.DataSource = (New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO).SelectAllItems()
            cboThuoc.DataBind()
            cboThuoc.Items.Insert(0, (New ListItem("--- Tất cả ---", -1)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindComboThang()
        Dim i As Integer
        Me.cboThang.Items.Clear()
        For i = 1 To 12
            Me.cboThang.Items.Add((New ListItem("Tháng " & i, i)))
        Next
    End Sub

    Private Sub BindComboQuy()
        Dim i As Integer
        Me.cboThang.Items.Clear()
        For i = 1 To 4
            Me.cboThang.Items.Add((New ListItem("Quý " & i, i)))
        Next
    End Sub

    Protected Sub cmdView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdView.Click
        'Xem bao cao kiem ke
        Dim url As String

        Dim id_loaiky As Integer
        Dim ky As Integer
        'For i As Integer = 0 To rblLoaiBC.Items.Count - 1
        '    If rblLoaiBC.Items(i).Selected = True Then
        '        id_loaiky = rblLoaiBC.Items(i).Value
        '        Exit For
        '    End If
        'Next
        ky = cboThang.SelectedValue

        url = Request.ApplicationPath & "/DesktopModules/NTP_CU_ttb/ttb_bc_chitiet_nhapxuat_view.aspx?ID_KHO=" & Me.CurrentUserStock.ID_KHO_THUOC & "&thang=" & ky & "&NAM=" & txtNam.Text.Trim & "&ID_NGUONKP=" & cboNguonKP.SelectedValue & "&ID_thietbi=" & cboThuoc.SelectedValue   ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
        Literal1.Text = "<script language = 'javascript'>" & _
                                "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
        Literal1.Visible = True

    End Sub

    'Protected Sub rblLoaiBC_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rblLoaiBC.SelectedIndexChanged
    '    If rblLoaiBC.Items(0).Selected = True Then
    '        BindComboThang()
    '    Else
    '        BindComboQuy()
    '    End If
    'End Sub
End Class
