
Partial Class QLT_KHOASO_KIEMKE
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboYear()
                BindCheckList()
                SetCheckList()
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub cmdLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        'Check chỉ được khóa sổ 1 tháng 1
        '-------------
        Dim count As Int16 = 0
        For i As Int16 = 0 To 11
            If chklThang.Items(i).Selected = True And chklThang.Items(i).Enabled = True Then
                count = count + 1
            End If
        Next
        If count > 1 Then
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn chỉ được khóa sổ 1 tháng", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Exit Sub
        End If
        '---------------
        'Check phải khóa sổ tháng trước 
        '---------------
        For i As Int16 = 1 To 11
            If chklThang.Items(i).Selected = True And chklThang.Items(i).Enabled = True Then
                If chklThang.Items(i - 1).Selected = False Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Tháng " & i & " chưa được khóa", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    Exit Sub
                End If
            End If
        Next

        'Khóa sổ
        '--------------------------------
        'Lay thang khoa so
        Dim thang As Int16
        For i As Int16 = 0 To 11
            If chklThang.Items(i).Selected = True And chklThang.Items(i).Enabled = True Then
                thang = i + 1
                Exit For
            End If
        Next
        Dim obj As New NTP_QLT.QLT_KY_KIEMKE_BO
        Dim inf As New NTP_QLT.QLT_KY_KIEMKE_Info
        Try
            'Save detail
            inf.NAM = Me.cboNam.SelectedValue
            inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC
            inf.TEN_KY_KIEMKE = Me.txtMO_TA.Text
            inf.THANG = thang

            obj.InsertItem(inf)

        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try
        '--------------------------------

        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        SetCheckList()
    End Sub
    Private Sub BindComboYear()
        Me.cboNam.Items.Add(New ListItem(Now.Year, Now.Year))
        Me.cboNam.Items.Add(New ListItem(Now.Year - 1, Now.Year - 1))
        Me.cboNam.SelectedIndex = 0
    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub cboNam_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNam.SelectedIndexChanged
        SetCheckList()
    End Sub

    Private Sub SetCheckList()
        Dim obj As New NTP_QLT.QLT_KY_KIEMKE_BO
        Dim Max_KyKiemKe As Integer

        Max_KyKiemKe = obj.GetKyDaKiemKe(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboNam.SelectedValue)

        For i As Int16 = 0 To Max_KyKiemKe - 1
            chklThang.Items(i).Selected = True
            chklThang.Items(i).Enabled = False
        Next

        'Dim obj As New NTP_QLVT.NTP_QLVT_KY_KIEMKE_BO
        'Dim arrThangDaKiemKe As New ArrayList
        'Try
        '    'Clear all\
        '    For i As Int16 = 0 To chklThang.Items.Count - 1
        '        chklThang.Items(i).Selected = False
        '        chklThang.Items(i).Enabled = True
        '    Next
        '    arrThangDaKiemKe = obj.GetKyDaKiemKe(Me.CurrentUserStock.ID_KHO_QLVT, Me.cboNam.SelectedValue)
        '    If arrThangDaKiemKe.Count = 12 Then
        '        'enable all
        '        For i As Int16 = 0 To chklThang.Items.Count - 1
        '            chklThang.Items(i).Enabled = False
        '            chklThang.Items(i).Selected = True
        '        Next
        '    Else
        '        For i As Int16 = 0 To chklThang.Items.Count - 1
        '            For j As Int16 = 0 To arrThangDaKiemKe.Count - 1
        '                If chklThang.Items(i).Value = arrThangDaKiemKe(j) Then
        '                    chklThang.Items(i).Selected = True
        '                    chklThang.Items(i).Enabled = False
        '                End If
        '            Next
        '        Next
        '        BindCheckList()
        '    End If
        'Catch ex As Exception
        '    ProcessModuleLoadException(Me, ex)
        'Finally

        'End Try
    End Sub
    Private Sub BindCheckList()
        'Chi enable nhung cai thuoc thang nay
        '
        Dim i As Integer
        For i = Now.Month To chklThang.Items.Count - 1
            chklThang.Items(i).Enabled = False
        Next
    End Sub
End Class
