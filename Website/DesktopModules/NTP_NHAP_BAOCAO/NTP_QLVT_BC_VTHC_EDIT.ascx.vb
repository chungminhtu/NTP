Imports NTP_Common.mdlGlobal
Imports NTP_Common.Common

Public Class NTP_QLVT_BC_VTHC_EDIT
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboHCVT(True)
                BindComboHCVT(False)
                BindComboNguonKP()
                BindComboHuyen()
                Me.txtNam.Text = Now.Year
                Me.cboQuy.SelectedValue = Quy()
                If Not Request.QueryString("id") Is Nothing Then
                    'Update
                    Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_BO
                    Dim inf As New NTP_QLVT.NTP_CU_VATTUHOACHAT_Info

                    inf = obj.SelectItem(Request.QueryString("id"))

                    Me.txtNam.Text = inf.NAM
                    Me.cboQuy.SelectedValue = inf.QUY
                    Me.txtID_BAOCAO.Text = inf.ID_BAOCAO

                    'BindData()

                    Me.pnlDetail.Visible = True

                    Me.pnlHC.Visible = False
                    Me.pnlVT.Visible = False

                End If
                'Me.pnlDetail.Visible = True
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindComboHuyen()
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO

        '
        'Kiem tra cap cua kho hien tai de hien thi list
        Dim objBV As New NTP_DANHMUC.NTP_DM_BENHVIEN_Info
        objBV = (New NTP_DANHMUC.NTP_DM_BENHVIEN_BO).SelectItem(Me.CurrentUserStock.ID_KHO_THUOC)
        If objBV.ID_CAP = 1 Then
            'Cap Miền 
            Dim itm As New ListItem
            itm.Value = Me.CurrentUserStock.ID_KHO_THUOC
            itm.Text = "Kho Miền"
            'Me.cboHuyen.DataSource = obj.DanhsachBVTheoDonVi(Me.CurrentUserStock.ID_KHO_THUOC)
            'Me.cboHuyen.DataBind()
            Me.cboHuyen.Items.Insert(0, itm)
        ElseIf objBV.ID_CAP = 2 Then
            'Cap Tỉnh 
            Dim itm As New ListItem
            itm.Value = Me.CurrentUserStock.ID_KHO_THUOC
            itm.Text = "Kho Tỉnh"

            'If objBV.MA_BENHVIEN = 65 Then
            '    cboHuyen.Enabled = False
            'Else
            '    Me.cboHuyen.DataSource = obj.DanhsachBVTheoDonVi(Me.CurrentUserStock.ID_KHO_THUOC)
            '    Me.cboHuyen.DataBind()
            'End If

            Me.cboHuyen.Items.Insert(0, itm)
        Else
            'Huyen
            Dim itm As New ListItem
            itm.Value = Me.CurrentUserStock.ID_KHO_THUOC
            itm.Text = "Thuốc kho Huyện"

            Me.cboHuyen.Items.Insert(0, itm)
        End If

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

    Private Sub BindComboHCVT(ByVal isVattu As Boolean)
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_VATTU_BO

        If isVattu Then
            Me.cboHC.DataSource = obj.SelectAllItems(enuTYPE_VATTU_HOACHAT.HOACHAT)
            Me.cboHC.DataBind()
        Else
            Me.cboVATTU.DataSource = obj.SelectAllItems(enuTYPE_VATTU_HOACHAT.VATTU)
            Me.cboVATTU.DataBind()
        End If
    End Sub

    Private Sub BindComboNguonKP()
        Dim ds As New DataSet
        ds = (New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO).SelectAllItems

        Me.cboNGUONKP_HC.DataSource = ds.Tables(0)
        Me.cboNGUONKP_HC.DataBind()

        Me.cboNGUONKP_VT.DataSource = ds.Tables(0)
        Me.cboNGUONKP_VT.DataBind()
    End Sub


    Private Sub BindData(ByVal isVT As Boolean)
        If isVT Then
            Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_VT_BO
            Try
                Me.grdDS_VT.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Me.txtID_BAOCAO.Text, Me.cboNGUONKP_VT.SelectedValue)
                Me.grdDS_VT.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        Else
            Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_HC_BO
            'Kiem tra cap cua kho hien tai de hien thi list
            Dim objBV As New NTP_DANHMUC.NTP_DM_BENHVIEN_Info
            objBV = (New NTP_DANHMUC.NTP_DM_BENHVIEN_BO).SelectItem(Me.CurrentUserStock.ID_KHO_THUOC)

            If objBV.ID_CAP = 3 Then
                Me.grdDS_HC.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Me.txtID_BAOCAO.Text, Me.cboNGUONKP_HC.SelectedValue)
                grdDS_HC.DataBind()
            End If
            Try
                Me.grdDS_HC.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Me.txtID_BAOCAO.Text, Me.cboNGUONKP_HC.SelectedValue)
                Me.grdDS_HC.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End If

    End Sub

    Protected Sub grdDS_HC_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS_HC.ItemCommand
        If e.CommandName = "edit" Then
            'Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
            GetInfo(CDbl(e.Item.Cells(2).Text), False)
        End If
    End Sub

    Protected Sub grdDS_VT_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS_VT.ItemCommand
        If e.CommandName = "edit" Then
            'Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
            GetInfo(CDbl(e.Item.Cells(2).Text), True)
        End If
    End Sub

    Private Sub GetInfo(ByVal ID_CHITIET As Double, ByVal isVT As Boolean)
        If isVT Then
            Try
                Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_VT_BO
                Dim inf As New NTP_QLVT.NTP_CU_VATTUHOACHAT_VT_Info

                inf = obj.SelectItem(ID_CHITIET)

                If Not inf Is Nothing Then
                    'Me.txtID_BAOCAO.Text = inf.ID_BAOCAO
                    Me.cboVATTU.SelectedValue = inf.ID_VATTU

                    Me.TD_TINH.Text = inf.TD_TINH
                    Me.TD_HUYEN.Text = inf.TD_BVHUYENTINH

                    Me.N_TINHCAP.Text = inf.N_TINH_CAP
                    Me.N_TW.Text = inf.N_TW_CAP

                    Me.X_TOANTINH.Text = inf.X_TOANTINH
                    Me.X_HUYEN.Text = inf.X_SUDUNG

                    Me.THUA_TINH.Text = inf.THUA_TINH
                    Me.THUA_HUYEN.Text = inf.THUA_HUYEN

                    Me.THIEU_TINH.Text = inf.THIEU_TINH
                    Me.THIEU_HUYEN.Text = inf.THIEU_HUYEN

                    Me.TC_TINH.Text = inf.TC_TINH
                    Me.TC_HUYEN.Text = inf.TC_HUYEN

                    Me.txtID_CHITIET_VT.Text = inf.ID_CHITIET

                    Me.cboNGUONKP_VT.SelectedValue = inf.ID_NGUONKINHPHI
                    Me.cboHuyen.SelectedValue = inf.ID_DONVI

                    Me.TRA_LAI_TINH.Text = inf.TRA_LAI
                    Me.TRA_LAI_HUYEN.Text = inf.TRA_LAI

                    Me.HONG_TINH.Text = inf.HONG_TINH
                    Me.DIEU_CHUYEN.Text = inf.DIEU_CHUYEN
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        Else
            Try
                Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_HC_BO
                Dim inf As New NTP_QLVT.NTP_CU_VATTUHOACHAT_HC_Info

                inf = obj.SelectItem(ID_CHITIET)

                If Not inf Is Nothing Then
                    'Me.txtID_BAOCAO.Text = inf.ID_BAOCAO
                    Me.cboHC.SelectedValue = inf.ID_VATTU

                    Me.TON_DAU.Text = inf.TON_DAU
                    Me.NHAP.Text = inf.NHAP

                    Me.XUAT.Text = inf.XUAT
                    Me.THUA.Text = inf.THUA
                    Me.THIEU_HONG.Text = inf.THIEU_HONG

                    Me.TON_CUOI.Text = inf.TON_CUOI

                    SetValue(Me.HAN_DUNG, inf.HAN_SUDUNG, enuDATA_TYPE.DATE_TYPE)
                    Me.LO_SX.Text = inf.LO_SX
                    Me.txtID_CHITIET_HC.Text = inf.ID_CHITIET
                    Me.GHI_CHU.Text = inf.GHI_CHU
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End If
        
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_BO
        Dim inf As New NTP_QLVT.NTP_CU_VATTUHOACHAT_Info
        Try
            inf.ID_BENHVIEN_KHO = Me.CurrentUserStock.ID_KHO_THUOC
            inf.ID_MATINH = Me.CurrentUserStock.ID_MATINH
            inf.NAM = Me.txtNam.Text
            inf.QUY = Me.cboQuy.SelectedValue
            inf.NGUOI_TAO = Me.UserId
            inf.NGAY_TAO = Now

            If Request.QueryString("id") Is Nothing Then
                'Add
                Me.txtID_BAOCAO.Text = obj.InsertItem(inf)
            Else
                'Update
                inf.ID_BAOCAO = Me.txtID_BAOCAO.Text
                obj.UpdateItem(inf)
            End If
            'Hien panel detail
            Me.pnlDetail.Visible = True
            Me.cmdAdd.Enabled = False
            Me.pnlHC.Visible = False
            Me.pnlVT.Visible = False
            SetFormFocus(Me.cboHC, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Đã ghi lại thông tin báo cáo", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub cmdSaveHC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSaveHC.Click
        Try
            Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_HC_BO
            Dim inf As New NTP_QLVT.NTP_CU_VATTUHOACHAT_HC_Info

            inf.ID_BAOCAO = Me.txtID_BAOCAO.Text
            inf.ID_VATTU = cboHC.SelectedValue
            inf.NGAY_NM = Now
            inf.NGUOI_NM = Me.UserId

            inf.TON_DAU = IIf(Me.TON_DAU.Text.Trim = "", 0, Me.TON_DAU.Text.Trim)
            inf.NHAP = IIf(Me.NHAP.Text.Trim = "", 0, Me.NHAP.Text.Trim)
            inf.XUAT = IIf(Me.XUAT.Text.Trim = "", 0, Me.XUAT.Text.Trim)
            inf.THUA = IIf(Me.THUA.Text.Trim = "", 0, Me.THUA.Text.Trim)
            inf.THIEU_HONG = IIf(Me.THIEU_HONG.Text.Trim = "", 0, Me.THIEU_HONG.Text.Trim)
            inf.TON_CUOI = IIf(Me.TON_CUOI.Text.Trim = "", 0, Me.TON_CUOI.Text.Trim)

            inf.HAN_SUDUNG = GetValue(Me.HAN_DUNG, enuDATA_TYPE.DATE_TYPE)
            inf.GHI_CHU = Me.GHI_CHU.Text
            inf.ID_NGUONKINHPHI = Me.cboNGUONKP_HC.SelectedValue
            inf.LO_SX = Me.LO_SX.Text.Trim.ToUpper
            If Me.txtID_CHITIET_HC.Text.Trim <> "" Then
                'Update
                inf.ID_CHITIET = Me.txtID_CHITIET_HC.Text
                obj.UpdateItem(inf)
            Else
                'Add
                obj.InsertItem(inf)
            End If
            ClearTextbox(False)
            'bind lai grid
            BindData(False)
            SetFormFocus(Me.cboHC, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu của hóa chất '" & Me.cboHC.SelectedItem.Text & "' đã được ghi lại", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub cmdSaveVT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSaveVT.Click
        Try
            Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_VT_BO
            Dim inf As New NTP_QLVT.NTP_CU_VATTUHOACHAT_VT_Info

            inf.ID_BAOCAO = Me.txtID_BAOCAO.Text
            inf.ID_VATTU = cboVATTU.SelectedValue

            inf.TD_TINH = IIf(Me.TD_TINH.Text.Trim = "", 0, Me.TD_TINH.Text.Trim)
            inf.TD_BVHUYENTINH = IIf(Me.TD_HUYEN.Text.Trim = "", 0, Me.TD_HUYEN.Text.Trim)

            inf.N_TINH_CAP = IIf(Me.N_TINHCAP.Text.Trim = "", 0, Me.N_TINHCAP.Text.Trim)
            inf.N_TW_CAP = IIf(Me.N_TW.Text.Trim = "", 0, Me.N_TW.Text.Trim)

            inf.X_TOANTINH = IIf(Me.X_TOANTINH.Text.Trim = "", 0, Me.X_TOANTINH.Text.Trim)
            inf.X_SUDUNG = IIf(Me.X_HUYEN.Text.Trim = "", 0, Me.X_HUYEN.Text.Trim)

            inf.THUA_TINH = IIf(Me.THUA_TINH.Text.Trim = "", 0, Me.THUA_TINH.Text.Trim)
            inf.THUA_HUYEN = IIf(Me.THUA_HUYEN.Text.Trim = "", 0, Me.THUA_HUYEN.Text.Trim)

            inf.THIEU_TINH = IIf(Me.THIEU_TINH.Text.Trim = "", 0, Me.THIEU_TINH.Text.Trim)
            inf.THIEU_HUYEN = IIf(Me.THIEU_HUYEN.Text.Trim = "", 0, Me.THIEU_HUYEN.Text.Trim)

            inf.TC_TINH = IIf(Me.TC_TINH.Text.Trim = "", 0, Me.TC_TINH.Text.Trim)
            inf.TC_HUYEN = IIf(Me.TC_HUYEN.Text.Trim = "", 0, Me.TC_HUYEN.Text.Trim)
            inf.ID_NGUONKINHPHI = Me.cboNGUONKP_VT.SelectedValue
            inf.ID_DONVI = Me.cboHuyen.SelectedValue

            If Me.cboHuyen.SelectedValue = Me.CurrentUserStock.ID_KHO_THUOC Then
                inf.TRA_LAI = IIf(Me.TRA_LAI_TINH.Text.Trim = "", 0, Me.TRA_LAI_TINH.Text.Trim)
            Else
                inf.TRA_LAI = IIf(Me.TRA_LAI_HUYEN.Text.Trim = "", 0, Me.TRA_LAI_HUYEN.Text.Trim)
            End If
          
            inf.HONG_TINH = IIf(Me.HONG_TINH.Text.Trim = "", 0, Me.HONG_TINH.Text)
            inf.DIEU_CHUYEN = IIf(Me.DIEU_CHUYEN.Text.Trim = "", 0, Me.DIEU_CHUYEN.Text.Trim)

            If Me.txtID_CHITIET_VT.Text.Trim <> "" Then
                'Update
                inf.ID_CHITIET = Me.txtID_CHITIET_VT.Text
                obj.UpdateItem(inf)
            Else
                'Add
                obj.InsertItem(inf)
            End If
            ClearTextbox(True)
            'bind lai grid
            BindData(True)
            SetFormFocus(Me.cboVATTU, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu của vật tư '" & Me.cboVATTU.SelectedItem.Text & "' đã được ghi lại", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Private Sub ClearTextbox(ByVal isVT As Boolean)

        If isVT Then
            'Tinh
            Me.TD_TINH.Text = ""
            Me.N_TW.Text = ""
            Me.X_TOANTINH.Text = ""
            Me.THUA_TINH.Text = ""
            Me.THIEU_TINH.Text = ""

            Me.TC_TINH.Text = ""
            'Huyen
            Me.TD_HUYEN.Text = ""
            Me.N_TINHCAP.Text = ""
            Me.X_HUYEN.Text = ""
            Me.THUA_HUYEN.Text = ""
            Me.THIEU_HUYEN.Text = ""

            Me.TC_HUYEN.Text = ""

            Me.TRA_LAI_HUYEN.Text = ""
            Me.TRA_LAI_TINH.Text = ""
            Me.HONG_TINH.Text = ""
            Me.DIEU_CHUYEN.Text = ""
        Else
            'Ton dau
            Me.TON_DAU.Text = ""
            'Nhap
            Me.NHAP.Text = ""
            'Xuat
            Me.XUAT.Text = ""
            'Ton Cuoi
            Me.TON_CUOI.Text = ""
            Me.THUA.Text = ""
            Me.THIEU_HONG.Text = ""
            Me.txtID_CHITIET_HC.Text = ""
            Me.GHI_CHU.Text = ""
            Me.LO_SX.Text = ""

        End If
        
    End Sub


    Protected Sub cmdDelHC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelHC.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_HC_BO
        Try
            For Each itm In Me.grdDS_HC.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            grdDS_HC.CurrentPageIndex = 0
            BindData(False)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        'MultiView1.ActiveViewIndex = Int32.Parse(e.Item.Value)
        Dim i As Integer
        'Make the selected menu item reflect the correct imageurl

        'For i = 0 To Menu1.Items.Count - 1
        '    If i = e.Item.Value Then
        '        Menu1.Items(i).ImageUrl = "selectedtab.gif"
        '    Else
        '        Menu1.Items(i).ImageUrl = "unselectedtab.gif"
        '    End If
        'Next
        Me.pnlDetail.Visible = True
        If e.Item.Value = 1 Then
            Me.pnlVT.Visible = False
            Me.pnlHC.Visible = True
            BindData(False)
        Else
            Me.pnlVT.Visible = True
            Me.pnlHC.Visible = False
            Me.pnlVT_Tinh.Visible = True
            Me.pnlVT_Huyen.Visible = False
            BindData(True)
        End If
    End Sub

    Protected Sub cmdDel_VT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDel_VT.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_VT_BO
        Try
            For Each itm In Me.grdDS_VT.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            grdDS_VT.CurrentPageIndex = 0
            BindData(True)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cboNGUONKP_HC_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNGUONKP_HC.SelectedIndexChanged
        BindData(False)
    End Sub

    Protected Sub cboNGUONKP_VT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNGUONKP_VT.SelectedIndexChanged
        BindData(True)
    End Sub

    Protected Sub cboHuyen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboHuyen.SelectedIndexChanged
        If Me.pnlVT.Visible = True Then
            If Me.cboHuyen.SelectedValue = Me.CurrentUserStock.ID_KHO_THUOC Then
                Me.pnlVT_Huyen.Visible = False
                Me.pnlVT_Tinh.Visible = True
            Else
                Me.pnlVT_Huyen.Visible = True
                Me.pnlVT_Tinh.Visible = False
            End If
        End If
    End Sub
End Class
