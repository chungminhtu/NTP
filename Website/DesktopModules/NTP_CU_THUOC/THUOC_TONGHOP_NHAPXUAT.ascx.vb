
Partial Class THUOC_TONGHOP_NHAPXUAT
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        'Tong hop so lieu cua thang
        Dim obj As New NTP_QLT.NTP_CU_THUOC_KHO_BO
        obj.TongHopSoLieu(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboThang.SelectedValue, Val(txtNam.Text), Me.UserId)
        Skins.Skin.AddModuleMessage(Me, "Đã tổng hợp xong số liệu tháng " & Me.cboThang.SelectedValue & " năm " & Me.txtNam.Text.Trim, Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        BindData()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                Me.txtNam.Text = Now.Year
                BindComboThang()
                BindData()
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindData()
        '
        Dim ds As New DataSet
        grdDS.DataSource = (New NTP_QLT.NTP_CU_THUOC_KHO_BO).ListSolieu(Me.CurrentUserStock.ID_KHO_THUOC, Me.txtNam.Text)
        grdDS.DataBind()
    End Sub

    Private Sub BindComboThang()
        Dim i As Integer
        For i = 1 To 12
            Me.cboThang.Items.Add((New ListItem("Tháng " & i, i)))
        Next
    End Sub

    Protected Sub cmdKhoaSoLieu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdKhoaSoLieu.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.NTP_CU_THUOC_KHO_BO
        Try
            'For Each itm In Me.grdDS.SelectedItems

            'Next
            'grdDS.CurrentPageIndex = 0
            obj.KhoaSo(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboThang.SelectedValue, Me.txtNam.Text, Me.UserId)
            BindData()
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub
End Class
