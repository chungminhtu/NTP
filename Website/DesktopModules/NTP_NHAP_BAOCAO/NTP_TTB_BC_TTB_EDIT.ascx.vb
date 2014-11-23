Imports NTP_Common.mdlGlobal
Imports NTP_Common.Common

Partial Class NTP_TTB_BC_TTB_EDIT
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboTTB()
                BindComboNguonKP()
                Me.txtNam.Text = Now.Year
                'Me.cboQuy.SelectedValue = Quy()
                BindComboHuyen()
                If Not Request.QueryString("id") Is Nothing Then
                    'Update
                    Dim obj As New NTP_QLTTB.NTP_CU_THIETBI_BO
                    Dim inf As New NTP_QLTTB.NTP_CU_THIETBI_Info

                    inf = obj.SelectItem(Request.QueryString("id"))

                    Me.txtNam.Text = inf.NAM
                    'Me.cboQuy.SelectedValue = inf.QUY
                    Me.txtID_BAOCAO.Text = inf.ID_BAOCAO

                    Me.pnlDetail.Visible = True
                    Me.grdDS.Visible = True

                    BindData()
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

            If objBV.MA_BENHVIEN = "65" Then
                cboHuyen.Enabled = False
            Else
                Me.cboHuyen.DataSource = obj.DanhsachBVTheoDonVi(Me.CurrentUserStock.ID_KHO_THUOC)
                Me.cboHuyen.DataBind()
            End If

            Me.cboHuyen.Items.Insert(0, itm)
        Else
            'Huyen
            Dim itm As New ListItem
            itm.Value = Me.CurrentUserStock.ID_KHO_THUOC
            itm.Text = "Thuốc kho Huyện"

            Me.cboHuyen.Items.Insert(0, itm)
        End If

    End Sub

    Private Sub BindComboTTB()
        Dim obj As New NTP_QLTTB.NTP_QLTTB_DM_THIETBI_BO
        Try
            Me.cboThietbi.DataSource = obj.SelectAllItems
            Me.cboThietbi.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
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

    Private Sub BindComboNguonKP()
        Dim ds As New DataSet
        ds = (New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO).SelectAllItems

        Me.cboNGUONKP_HC.DataSource = ds.Tables(0)
        Me.cboNGUONKP_HC.DataBind()

    End Sub


    Private Sub BindData()
        Dim obj As New NTP_QLTTB.NTP_CU_THIETBI_CHITIET_BO
        Try
            Me.grdDS.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Me.txtID_BAOCAO.Text, Me.cboNGUONKP_HC.SelectedValue)
            Me.grdDS.DataBind()
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try

    End Sub

    Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDS.ItemCommand
        If e.CommandName = "edit" Then
            'Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
            GetInfo(CDbl(e.Item.Cells(2).Text))
        End If
    End Sub

    Private Sub GetInfo(ByVal ID_CHITIET As Double)
        Try
            Dim obj As New NTP_QLTTB.NTP_CU_THIETBI_CHITIET_BO
            Dim inf As New NTP_QLTTB.NTP_CU_THIETBI_CHITIET_Info

            inf = obj.SelectItem(ID_CHITIET)

            If Not inf Is Nothing Then
                'Me.txtID_BAOCAO.Text = inf.ID_BAOCAO
                Me.cboThietbi.SelectedValue = inf.ID_THIETBI
                Me.cboHuyen.SelectedValue = inf.ID_KHO


                Me.TD_SOLUONG.Text = inf.TD_SOLUONG


                If inf.ID_KHO = Me.CurrentUserStock.ID_KHO_THUOC Then
                    ' Kho tinh 
                    Me.NHAP.Text = inf.N_SOLUONG
                    Me.NHAP_NAM.Text = inf.N_NAM

                    Me.XUAT.Text = inf.XSD_TINH_SOLUONG
                    Me.XUAT_NAM.Text = inf.XSD_TINH_NAM

                    Me.HONG.Text = inf.HONG_TINH_SOLUONG
                    Me.HONG_NAM.Text = inf.HONG_TINH_NAM
                Else
                    ' Kho huyen
                    Me.NHAP.Text = inf.N_SOLUONG
                    Me.NHAP_NAM.Text = inf.N_NAM

                    Me.XUAT.Text = inf.XSD_HUYEN_SOLUONG
                    Me.XUAT_NAM.Text = inf.XSD_HUYEN_NAM

                    Me.HONG.Text = inf.HONG_HUYEN_SOLUONG
                    Me.HONG_NAM.Text = inf.HONG_HUYEN_NAM
                End If

                Me.TC_SOLUONG.Text = inf.TC_SOLUONG
                Me.CHO_THANHLY.Text = inf.CHO_THANHLY
                Me.DA_THANHLY.Text = inf.DA_THANHLY

                Me.txtGhiChu.Text = inf.GHI_CHU

                Me.txtID_CHITIET.Text = inf.ID_CHITIET

                Me.cboNGUONKP_HC.SelectedValue = inf.ID_NGUONKINHPHI

                Me.TC_SOLUONG.Text = inf.TC_SOLUONG
            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim obj As New NTP_QLTTB.NTP_CU_THIETBI_BO
        Dim inf As New NTP_QLTTB.NTP_CU_THIETBI_Info
        Try
            inf.ID_BENHVIEN_KHO = Me.CurrentUserStock.ID_KHO_THUOC
            inf.ID_MATINH = Me.CurrentUserStock.ID_MATINH
            inf.NAM = Me.txtNam.Text
            inf.QUY = "đầu năm"
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
            SetFormFocus(Me.cboThietbi, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Đã ghi lại thông tin báo cáo", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim obj As New NTP_QLTTB.NTP_CU_THIETBI_CHITIET_BO
            Dim inf As New NTP_QLTTB.NTP_CU_THIETBI_CHITIET_Info

            inf.ID_BAOCAO = Me.txtID_BAOCAO.Text
            inf.ID_THIETBI = cboThietbi.SelectedValue
            'inf.NGAY_NM = Now
            inf.NGUOI_NM = Me.UserId

            inf.ID_KHO = Me.cboHuyen.SelectedValue

            inf.TD_SOLUONG = IIf(Me.TD_SOLUONG.Text.Trim = "", 0, Me.TD_SOLUONG.Text.Trim)

            inf.N_SOLUONG = IIf(Me.NHAP.Text.Trim = "", 0, Me.NHAP.Text.Trim)
            inf.N_NAM = IIf(Me.NHAP_NAM.Text.Trim = "", 0, Me.NHAP_NAM.Text.Trim)

            If Me.cboHuyen.SelectedValue = Me.CurrentUserStock.ID_KHO_THUOC Then
                'Tinh
                inf.XSD_TINH_SOLUONG = IIf(Me.XUAT.Text.Trim = "", 0, Me.XUAT.Text.Trim)
                inf.XSD_TINH_NAM = IIf(Me.XUAT_NAM.Text.Trim = "", 0, Me.XUAT_NAM.Text.Trim)


                inf.HONG_TINH_SOLUONG = IIf(Me.HONG.Text.Trim = "", 0, Me.HONG.Text.Trim)
                inf.HONG_TINH_NAM = IIf(Me.HONG_NAM.Text.Trim = "", 0, Me.HONG_NAM.Text.Trim)
            Else
                'Huyen 
                inf.XSD_HUYEN_SOLUONG = IIf(Me.XUAT.Text.Trim = "", 0, Me.XUAT.Text.Trim)
                inf.XSD_HUYEN_NAM = IIf(Me.XUAT_NAM.Text.Trim = "", 0, Me.XUAT_NAM.Text.Trim)


                inf.HONG_HUYEN_SOLUONG = IIf(Me.HONG.Text.Trim = "", 0, Me.HONG.Text.Trim)
                inf.HONG_HUYEN_NAM = IIf(Me.HONG_NAM.Text.Trim = "", 0, Me.HONG_NAM.Text.Trim)
            End If

            inf.DA_THANHLY = IIf(Me.DA_THANHLY.Text.Trim = "", 0, Me.DA_THANHLY.Text.Trim)
            inf.CHO_THANHLY = IIf(Me.CHO_THANHLY.Text.Trim = "", 0, Me.CHO_THANHLY.Text.Trim)
            inf.GHI_CHU = Me.txtGhiChu.Text

            inf.ID_NGUONKINHPHI = Me.cboNGUONKP_HC.SelectedValue
            inf.TC_SOLUONG = IIf(Me.TC_SOLUONG.Text.Trim = "", 0, Me.TC_SOLUONG.Text.Trim)

            If Me.txtID_CHITIET.Text.Trim <> "" Then
                'Update
                inf.ID_CHITIET = Me.txtID_CHITIET.Text
                obj.UpdateItem(inf)
            Else
                'Add
                obj.InsertItem(inf)
            End If
            ClearTextbox()
            'bind lai grid
            BindData()
            SetFormFocus(Me.cboThietbi, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu của thiết bị '" & Me.cboThietbi.SelectedItem.Text & "' đã được ghi lại", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub


    Private Sub ClearTextbox()

        Me.TD_SOLUONG.Text = ""

        Me.NHAP.Text = ""
        Me.NHAP_NAM.Text = ""

        Me.NHAP.Text = ""
        Me.NHAP_NAM.Text = ""

        Me.XUAT.Text = ""
        Me.XUAT_NAM.Text = ""

        Me.HONG.Text = ""
        Me.HONG_NAM.Text = ""

        Me.CHO_THANHLY.Text = ""
        Me.DA_THANHLY.Text = ""
        Me.TC_SOLUONG.Text = ""

        Me.txtGhiChu.Text = ""

    End Sub


    Protected Sub cmdDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLTTB.NTP_CU_THIETBI_CHITIET_BO
        Try
            For Each itm In Me.grdDS.SelectedItems
                obj.DeleteItem(itm.Cells(2).Text)
            Next
            grdDS.CurrentPageIndex = 0
            BindData()
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cboNGUONKP_HC_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNGUONKP_HC.SelectedIndexChanged
        BindData()
        SetFormFocus(Me.cboThietbi, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
    End Sub
End Class
