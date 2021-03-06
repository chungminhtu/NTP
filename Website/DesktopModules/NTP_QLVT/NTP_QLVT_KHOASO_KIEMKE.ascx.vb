Imports NTP_Common.mdlGlobal

Public Class NTP_QLVT_KHOASO_KIEMKE
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Private CONST_MSGOK As String = "...Đã hoàn thành"
    Private gThang As Integer
    Private gNam As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboYear()
                SetCheckList()
                '
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindComboYear()
        Me.cboNam.Items.Add(New ListItem(Now.Year, Now.Year))
        Me.cboNam.Items.Add(New ListItem(Now.Year - 1, Now.Year - 1))
        Me.cboNam.SelectedIndex = 0
    End Sub

    Private Sub SetCheckList()
        Dim obj As New NTP_QLVT.NTP_QLVT_KY_KIEMKE_BO
        Dim arrThangDaKiemKe As New ArrayList
        Dim i As Int16
        Try
            'Clear all
            '
            arrThangDaKiemKe = obj.GetKyDaKiemKe(Me.CurrentUserStock.ID_KHO_QLVT, Me.cboNam.SelectedItem.Value)
            If arrThangDaKiemKe.Count = 2 Then
                For i = 0 To chklThang.Items.Count - 1
                    chklThang.Items(i).Selected = True
                    chklThang.Items(i).Enabled = False
                Next
            Else
                For i = 0 To chklThang.Items.Count - 1
                    For j As Int16 = 0 To arrThangDaKiemKe.Count - 1
                        If arrThangDaKiemKe(j) = chklThang.Items(i).Value Then
                            chklThang.Items(i).Selected = True
                            chklThang.Items(i).Enabled = False
                        End If
                    Next
                Next
            End If
          
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub

    Private Sub KhoaSoThang(ByVal iThang As Integer, ByVal iNam As Integer)
        Dim obj As New NTP_QLVT.NTP_QLVT_KY_KIEMKE_BO
        Try
            obj.KhoaSoKiemKe(Me.CurrentUserStock.ID_KHO_QLVT, iThang, iNam, Me.txtMO_TA.Text, Me.UserId, Me.txtLAN_KIEMKE.Text)
            'system.Threading.Thread.Sleep(10000)
            'OK, update status tren list:
            Dim itm As ListItem
            For Each itm In Me.ListStatus.Items
                If itm.Value = iThang Then
                    itm.Text = "Khóa sổ tháng: " & iThang & CONST_MSGOK
                    Exit For
                End If
            Next
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cmdLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Try
            'Lock cac combo
            Dim bolFirst As Boolean = False
            Dim bChecked As Boolean = False  ' Neu co check
            Dim arrList As New ArrayList
            'Add danh sach label control hien thi status
            '-----------
            For i As Integer = 0 To chklThang.Items.Count - 1
                If chklThang.Items(i).Selected = True And chklThang.Items(i).Enabled = True Then
                    bChecked = True
                    If i = 0 Then
                        For j As Int16 = 1 To 6
                            Me.ListStatus.Items.Add(New ListItem("Khóa sổ tháng: " & j & "... Đang thực hiện", j))
                            arrList.Add(j)
                        Next
                    ElseIf i = 1 Then
                        For j As Int16 = 7 To 12
                            Me.ListStatus.Items.Add(New ListItem("Khóa sổ tháng: " & j & "... Đang thực hiện", j))
                            arrList.Add(j)
                        Next
                    End If
                    Me.txtLAN_KIEMKE.Text = chklThang.Items(i).Value
                    Exit Sub
                End If
            Next

            '
            If bChecked = False Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn phải chọn ít nhất 1 kỳ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Exit Sub
            End If

            Dim bCheckKhoaSo As Boolean
           
            bCheckKhoaSo = CheckKhoaSo(arrList)

            If bCheckKhoaSo = False Then
                'Clear List
                ListStatus.Items.Clear()
                Exit Sub
            End If
            If bChecked Then
                Me.cboNam.Enabled = False
                Me.cmdLock.Enabled = False
                Me.chklThang.Enabled = False

                Me.Timer1.Enabled = True
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub

    Private Function CheckKhoaSo(ByVal arrList As ArrayList) As Boolean
        Dim iThang As Int16
        Dim iNam As Int16
        Dim iTrangThai As Int16
        Try
            ' Lay thang cua ky khoa so gan nhat
            ' Neu khong co --> Lan dau tien chay --> ok, chay thoai mai
            ' Neu co --> Kiem tra
            'Check xem co duoc khoa so khong
            Dim obj As New NTP_QLVT.NTP_QLVT_KY_KIEMKE_BO
            obj.GET_LASTEST_KY_KIEMKE(Me.CurrentUserStock.ID_KHO_QLVT, iThang, iNam, iTrangThai)
            If Not (iThang = -1 And iNam = -1) Then
                ' Neu da co ky kiem ke thi kiem tra trang thai
                ' Neu = 0 --> ko duoc chay
                ' Neu = 1 --> ok
                If iTrangThai = NTP_Common.enuTRANGTHAI_KY_KIEMKE.DA_KHOA_SO Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn không thể tiến hành khóa sổ khi đang có 1 kỳ kiểm kê khác đang thực hiện khóa sổ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    Return False
                Else
                    'Kiem tra viec chon thang
                    '- thang truoc chua khoa so thi bao loi
                    '- khong duoc chon nhay coc thang
                    '- vd:chon thang 1/2009 -> thang 12/2008 phai khoa so roi
                    '-----chon thang 3/2009 -> thang 2/2009 phai khoa so
                    Dim iNextMonth As Int16
                    Dim iNextYear As Int16

                    iNextMonth = IIf(iThang = 12, 1, iThang + 1)
                    iNextYear = IIf(iThang = 12, iNam + 1, iNam)

                    If arrList(0) = iNextMonth And Me.cboNam.Text = iNextYear Then
                        ' Ok
                        'Check gia tri tiep theo
                        'Kiem tra xem co cach quang khong 
                        Dim j As Integer
                        j = arrList(0)
                        For i As Integer = 1 To arrList.Count - 1
                            j = j + 1
                            If j <> arrList(i) Then
                                'Fail
                                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn phải chọn các tháng liên tiếp nhau", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                                Return False
                            End If
                        Next
                    Else
                        'Not OK
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, String.Format("Bạn không thể khóa sổ tháng '{0}' khi tháng '{1}' chưa được khóa sổ", arrList(0) & "/" & cboNam.SelectedValue, iNextMonth & "/" & iNextYear), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                        Return False
                    End If
                End If
            Else
                Dim j As Integer
                j = arrList(0)
                For i As Integer = 1 To arrList.Count - 1
                    j = j + 1
                    If j <> arrList(i) Then
                        'Fail
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn phải chọn các tháng liên tiếp nhau", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                        Return False
                    End If
                Next
                Return True
            End If
            '---end check---------
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Protected Sub cboNam_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNam.SelectedIndexChanged
        SetCheckList()
    End Sub

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Int16
        Dim iNextMonth As Int16
        Dim bOK As Boolean = False
        For i = Me.ListStatus.Items.Count - 1 To 0 Step -1
            If Me.ListStatus.Items(i).Text.IndexOf(CONST_MSGOK) > 0 Then
                bOK = True
                Exit For
            End If
            iNextMonth = i
        Next
        If bOK = True Then
            If i = Me.ListStatus.Items.Count - 1 Then
                'Finish
                Me.Timer1.Enabled = False
            Else
                'next month
                KhoaSoThang(Me.ListStatus.Items(iNextMonth).Value, cboNam.SelectedValue)
            End If
        Else
            'Chay phat dau tien ne
            KhoaSoThang(Me.ListStatus.Items(0).Value, cboNam.SelectedValue)
        End If

    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())
    End Sub
End Class
