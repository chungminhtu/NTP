Imports NTP_Common.mdlGlobal

Public Class NTP_QLT_BC_SUDUNGTHUOC_LIST
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboYear()
                '
                'Kiem tra cap cua kho hien tai de hien thi list
                Dim objBV As New NTP_DANHMUC.NTP_DM_BENHVIEN_Info
                objBV = (New NTP_DANHMUC.NTP_DM_BENHVIEN_BO).SelectItem(Me.CurrentUserStock.ID_KHO_THUOC)
                If Me.CurrentUserStock.USERID <> 1 Then
                    cmdReject.Visible = False
                    lblNguoiTao.Visible = False
                    cboUser.Visible = False
                Else
                    cmdReject.Visible = True
                    lblNguoiTao.Visible = True
                    cboUser.Visible = True
                    Dim obj As New NTP_DANHMUC.NTP_DM_THUOC_BO

                    Me.cboUser.DataSource = obj.GetAllUser()
                    Me.cboUser.DataValueField = "UserID"
                    Me.cboUser.DataTextField = "UserName"
                    Me.cboUser.DataBind()
                End If
                BindGrid()

                'If objBV.ID_CAP = 1 Then
                '    cmdApprove.Visible = True
                'Else
                '    cmdApprove.Visible = False
                'End If

            End If
            Me.Literal1.Visible = False
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub BindGrid()
        Dim ds As New DataSet
        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
        Dim strUser As String = Me.cboUser.SelectedValue
        If strUser Is Nothing Then strUser = ""
        'TK Host
        If Me.CurrentUserStock.USERID = 1 Then
            Try
                grdDS.DataSource = obj.SearchALL(Me.cboNam.Text, strUser)
                grdDS.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        Else    'TK Binh thuong
            Try
                grdDS.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Me.cboNam.Text)
                grdDS.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End If
        
    End Sub

    Private Sub BindComboYear()
        Me.cboNam.Items.Add(New ListItem(Now.Year, Now.Year))
        Me.cboNam.Items.Add(New ListItem(Now.Year - 1, Now.Year - 1))
        Me.cboNam.SelectedIndex = 0
    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        'CuongNH2: Bổ sung thêm nút báo cáo tuyến huyện
        If e.CommandName = "baocao_Mien" Then
            BaoCao(Me.CurrentUserStock.ID_KHO_THUOC, e.Item.Cells(2).Text, 1) ' Tuyến Miền
        ElseIf e.CommandName = "baocao_Huyen" Then
            BaoCao(Me.CurrentUserStock.ID_KHO_THUOC, e.Item.Cells(2).Text, 0) 'Tuyến Huyện
        ElseIf e.CommandName = "edit" Then
            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
        End If
    End Sub

    Private Sub BaoCao(ByVal ID_KHO As Integer, ByVal ID_BAOCAO As Integer, ByVal TypeBC As String)
        'Xem bao cao kiem ke
        Dim url As String
        url = Request.ApplicationPath & "/DesktopModules/NTP_NHAP_BAOCAO/NTP_QLT_BC_SUDUNGTHUOC_VIEW.aspx?ID_KHO=" & ID_KHO & "&TypeBC=" & TypeBC & "&ID_BC=" & ID_BAOCAO ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
        Literal1.Text = "<script language = 'javascript'>" & _
                                "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
        Literal1.Visible = True

    End Sub

    Protected Sub grdDS_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdDS.ItemDataBound
        If e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.Item Then

            If e.Item.Cells(3).Text = enuBILL_STATUS.LOCK Then
                Dim ctl As Control
                If Me.CurrentUserStock.USERID <> 1 Then
                    ctl = e.Item.Cells(1).FindControl("cmdEdit")
                    If Not ctl Is Nothing Then
                        ctl.Visible = False
                    End If

                    ctl = e.Item.Cells(0).FindControl("chkItem")
                    If Not ctl Is Nothing Then
                        ctl.Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub grdDS_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDS.PageIndexChanged
        Me.grdDS.CurrentPageIndex = e.NewPageIndex
        BindGrid()
    End Sub

    Protected Sub cboNam_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNam.SelectedIndexChanged
        BindGrid()
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId))
    End Sub

    Protected Sub cmdApprove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdApprove.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
        Dim bCheck As Boolean
        Dim iCount As Integer
        Try
            'If Me.grdDS.SelectedItems.Count > 1 Then
            '    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn chỉ được chọn 01 báo cáo để phê duyệt", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            '    Exit Sub
            'End If
            For Each itm In Me.grdDS.SelectedItems
                obj.PheDuyet(Me.CurrentUserStock.ID_KHO_THUOC, itm.Cells(2).Text, Me.UserId)
            Next
            grdDS.CurrentPageIndex = 0
            BindGrid()
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cmdDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            grdDS.CurrentPageIndex = 0
            BindGrid()
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Hủy phê duyệt báo cáo
    ''' Chỉ có tác dụng với ACC Host
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub cmdReject_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReject.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
        Dim bCheck As Boolean
        Dim iCount As Integer
        Try
            'If Me.grdDS.SelectedItems.Count > 1 Then
            '    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn chỉ được chọn 01 báo cáo để hủy phê duyệt", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            '    Exit Sub
            'End If
            For Each itm In Me.grdDS.SelectedItems
                obj.HuyPheDuyet(Me.CurrentUserStock.ID_KHO_THUOC, itm.Cells(2).Text, Me.UserId)
            Next
            grdDS.CurrentPageIndex = 0
            BindGrid()
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cboUser_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUser.SelectedIndexChanged
        BindGrid()
    End Sub
End Class
