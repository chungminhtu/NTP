Imports NTP_Common.mdlGlobal

Public Class NTP_QLTTB_KHOASO_KIEMKE
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

    Protected Sub cmdLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Try
            'Lock cac combo
            Dim bolFirst As Boolean = False
            Dim bChecked As Boolean = False  ' Neu co check
            'Kiem tra xem nam nay da khoa so chua
            'Neu khoa roi thi thoi :D
            bChecked = CheckKhoaso(cboNam.SelectedValue)

            If bChecked Then
                Me.cboNam.Enabled = False
                Me.cmdLock.Enabled = False
                Me.ListStatus.Items.Add("Đang thực hiện khóa sổ năm '" & Me.cboNam.SelectedValue & "'................")

                Me.Timer1.Enabled = True
            Else
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Năm '" & Me.cboNam.SelectedValue & "' đã được thực hiện khóa sổ kiểm kê, bạn không thể thực hiện chức năng này", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub

    Private Function CheckKhoaso(ByVal iYear As Integer) As Boolean
        Dim obj As New NTP_QLTTB.NTP_QLTTB_KHOASO_BO
        Dim iStatus As NTP_Common.enuTRANGTHAI_KY_KIEMKE
        iStatus = obj.KiemTraKy(Me.CurrentUserStock.ID_KHO_TTBI, iYear)
        If iStatus = enuTRANGTHAI_KY_KIEMKE.CHUA_KIEMKE Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function KhoaSo(ByVal iYear As Integer, ByVal ID_KHO As Integer, ByVal sMoTa As String, ByVal NguoiNM As Integer, ByVal NgayKK As Date)
        Dim obj As New NTP_QLTTB.NTP_QLTTB_KHOASO_BO
        obj.KhoaSo(iYear, ID_KHO, sMoTa, NguoiNM, NgayKK)
    End Function

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim dtDate As Date
            dtDate = GetValue(Me.txtNgayKK, enuDATA_TYPE.DATE_TYPE)
            KhoaSo(Me.cboNam.SelectedValue, Me.CurrentUserStock.ID_KHO_TTBI, Me.txtMO_TA.Text, Me.UserId, dtDate)
            Me.Timer1.Enabled = False
            Me.ListStatus.Items.Clear()
            Me.ListStatus.Items.Add(CONST_MSGOK)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub
End Class
