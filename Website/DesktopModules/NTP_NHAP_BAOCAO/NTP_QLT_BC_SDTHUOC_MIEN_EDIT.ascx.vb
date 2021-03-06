Imports NTP_Common.mdlGlobal
Imports NTP_Common.Common

Public Class NTP_QLT_BC_SDTHUOC_MIEN_EDIT
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                BindComboHuyen()
                BindComboThuoc()
                BindComboNGUONKINHPHI()
                Me.txtNam.Text = Now.Year
                Me.cboQuy.SelectedValue = Quy()
                If Not Request.QueryString("id") Is Nothing Then
                    'Update
                    Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
                    Dim inf As New NTP_QLT.NTP_CU_SUDUNGTHUOC_Info

                    inf = obj.SelectItem(Request.QueryString("id"))

                    Me.txtNam.Text = inf.NAM
                    Me.cboQuy.SelectedValue = inf.QUY
                    Me.txtID_BAOCAO.Text = inf.ID_BAOCAO

                    BindData()

                    Me.pnlDetail.Visible = True
                End If
            End If
            'Dim sm As System.Web.UI.ScriptManager = ScriptManager.GetCurrent(Control.Page)
            'sm.RegisterClientScriptBlock(Me.Page, GetType(String), "calc", GenerateJScript, True)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Function GenerateJScript() As String
        Dim s As String = ""
        s = s & vbCrLf & "$(document).ready("
        s = s & vbCrLf & "function (){"
        s = s & vbCrLf & "// bind the recalc function to the quantity fields"
        s = s & vbCrLf & "$(""input[id^=" & TD_SOLUONG.ClientID & "]"").bind(""keyup"", recalc);"
        s = s & vbCrLf & "$(""input[id^=" & N_SOLUONG.ClientID & "]"").bind(""keyup"", recalc);"
        s = s & vbCrLf & "$(""input[id^=" & X_SUDUNG.ClientID & "]"").bind(""keyup"", recalc);"
        s = s & vbCrLf & "// run the calculation function now"
        s = s & vbCrLf & "recalc();"
        s = s & vbCrLf & "}"
        s = s & vbCrLf & ");"
        s = s & vbCrLf & "function recalc(){"
        s = s & vbCrLf & "var s1;"
        s = s & vbCrLf & "s1 = parseInt($(""input[id^=" & TD_SOLUONG.ClientID & "]"").val());"
        s = s & vbCrLf & "var s2;"
        s = s & vbCrLf & "s2 = parseInt($(""input[id^=" & N_SOLUONG.ClientID & "]"").val());"
        s = s & vbCrLf & "var s3;"
        s = s & vbCrLf & "s3 = parseInt($(""input[id^=" & X_SUDUNG.ClientID & "]"").val());"
        s = s & vbCrLf & "var sum;"
        s = s & vbCrLf & "sum = s1 + s2 - s3;"
        s = s & vbCrLf & "$(""input[id^=" & TC_SOLUONG.ClientID & "]"").get(0).value = sum;"
        s = s & vbCrLf & ""
        s = s & vbCrLf & "}"
        s = s & vbCrLf & ""

        Return s
    End Function

    Private Sub BindComboThuoc()
        Dim obj As New NTP_QLT.QLT_DM_THUOC_BO
        Me.cboThuoc.DataSource = obj.SelectAllItems()
        Me.cboThuoc.DataBind()
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

    Private Sub BindComboHuyen()
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO

        '
        Dim itm As New ListItem
        itm.Value = "xxx"
        itm.Text = "Thuốc kho tỉnh"

        Me.cboHuyen.DataSource = obj.Search("", Me.CurrentUserStock.ID_MATINH)
        Me.cboHuyen.DataBind()

        Me.cboHuyen.Items.Insert(0, itm)

    End Sub

    Private Sub BindComboNGUONKINHPHI()
        Dim obj As New NTP_DANHMUC.NTP_DM_NGUONKINHPHI_BO
        Try
            Me.cboNGUON_KINHPHI.DataSource = obj.SelectAllItems
            Me.cboNGUON_KINHPHI.DataBind()
            'Me.cboNGUON_KINHPHI.Items.Insert(0, (New ListItem("--- Tất cả ---", Null.NullInteger)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub BindData()
        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_CHITIET_BO
        Try
            Me.grdDS.DataSource = obj.Search(Me.CurrentUserStock.ID_KHO_THUOC, Me.txtID_BAOCAO.Text, cboThuoc.SelectedValue, Me.cboNGUON_KINHPHI.SelectedValue)
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
            Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_CHITIET_BO
            Dim inf As New NTP_QLT.NTP_CU_SUDUNGTHUOC_CHITIET_Info

            inf = obj.SelectItem(ID_CHITIET)

            If Not inf Is Nothing Then
                'Me.txtID_BAOCAO.Text = inf.ID_BAOCAO
                If inf.TYPE = 0 Then
                    'Huyen
                    cboHuyen.SelectedValue = inf.ID_KHO
                Else
                    'Tinh
                    cboHuyen.SelectedValue = "xxx"
                End If


                Me.cboThuoc.SelectedValue = inf.ID_THUOC
                Me.cboNGUON_KINHPHI.SelectedValue = inf.ID_NGUONKINHPHI
                'Ton dau
                Me.TD_SOLUONG.Text = inf.TD_SOLUONG
                SetValue(Me.TD_HANDUNG, inf.TD_HANDUNG, enuDATA_TYPE.DATE_TYPE)
                'Nhap
                Me.N_SOLUONG.Text = inf.N_SOLUONG
                Me.N_LOSX.Text = inf.N_LOSX
                SetValue(Me.N_HANDUNG, inf.N_HANDUNG, enuDATA_TYPE.DATE_TYPE)
                Me.N_TRALAI.Text = inf.TRA_LAI
                Me.N_THUA.Text = inf.THUA
                'Xuat
                Me.X_SUDUNG.Text = inf.X_SUDUNG_TOANTINH
                If inf.TYPE = 1 Then
                    'Tinh
                    Me.X_HONG.Text = inf.X_TINH_THIEU
                    Me.X_DIEUCHUYEN.Text = inf.X_TINH_HONG_VO
                Else
                    'Huyen
                    Me.X_HONG.Text = inf.X_HUYEN_HONGVO
                    Me.X_DIEUCHUYEN.Text = inf.X_HUYEN_DIEUCHUYEN
                End If
                'Ton Cuoi
                Me.TC_SOLUONG.Text = inf.TC_SOLUONG
                Me.TC_LOSX.Text = inf.TC_LOSX
                SetValue(Me.TC_HANDUNG, inf.TC_HANDUNG, enuDATA_TYPE.DATE_TYPE)

                Me.txtID_CHITIET.Text = inf.ID_CHITIET

                Me.txtGhiChu.Text = inf.GHI_CHU

            End If
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
        Dim inf As New NTP_QLT.NTP_CU_SUDUNGTHUOC_Info
        Try
            inf.ID_BENHVIEN_KHO = Me.CurrentUserStock.ID_KHO_THUOC
            inf.ID_MATINH = Me.CurrentUserStock.ID_MATINH
            inf.NAM = Me.txtNam.Text
            inf.QUY = Me.cboQuy.SelectedValue
            inf.NGUOI_TAO = Me.UserId

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
            SetFormFocus(Me.cboHuyen, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Đã ghi lại thông tin báo cáo", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Protected Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub cmdSaveDetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSaveDetail.Click
        Try
            Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_CHITIET_BO
            Dim inf As New NTP_QLT.NTP_CU_SUDUNGTHUOC_CHITIET_Info

            inf.ID_BAOCAO = Me.txtID_BAOCAO.Text
            If cboHuyen.SelectedValue = "xxx" Then
                'Kho tinh
                inf.ID_KHO = Me.CurrentUserStock.ID_MATINH
                inf.TYPE = 1
            Else
                'Kho huyen
                inf.ID_KHO = Me.cboHuyen.SelectedValue
                inf.TYPE = 0
            End If
            inf.ID_THUOC = Me.cboThuoc.SelectedValue
            inf.ID_NGUONKINHPHI = Me.cboNGUON_KINHPHI.SelectedValue
            'Ton dau
            inf.TD_SOLUONG = IIf(Me.TD_SOLUONG.Text.Trim = "", Nothing, Me.TD_SOLUONG.Text)
            inf.TD_HANDUNG = GetValue(Me.TD_HANDUNG, enuDATA_TYPE.DATE_TYPE)
            'Nhap
            inf.N_SOLUONG = IIf(Me.N_SOLUONG.Text.Trim = "", Nothing, Me.N_SOLUONG.Text)
            inf.N_LOSX = Me.N_LOSX.Text
            inf.N_HANDUNG = GetValue(Me.N_HANDUNG, enuDATA_TYPE.DATE_TYPE)
            inf.TRA_LAI = IIf(Me.N_TRALAI.Text.Trim = "", Nothing, Me.N_TRALAI.Text)
            inf.THUA = IIf(Me.N_THUA.Text.Trim = "", Nothing, Me.N_THUA.Text)
            'Xuat
            inf.X_SUDUNG_TOANTINH = IIf(Me.X_SUDUNG.Text.Trim = "", Nothing, Me.X_SUDUNG.Text)
            If inf.TYPE = 1 Then
                'Tinh
                inf.X_TINH_THIEU = IIf(Me.X_HONG.Text.Trim = "", Nothing, Me.X_HONG.Text)
                inf.X_TINH_HONG_VO = IIf(Me.X_DIEUCHUYEN.Text.Trim = "", Nothing, Me.X_DIEUCHUYEN.Text)
            Else
                'Huyen
                inf.X_HUYEN_HONGVO = IIf(Me.X_HONG.Text.Trim = "", Nothing, Me.X_HONG.Text)
                inf.X_HUYEN_DIEUCHUYEN = IIf(Me.X_DIEUCHUYEN.Text.Trim = "", Nothing, Me.X_DIEUCHUYEN.Text)
            End If
            'Ton Cuoi
            inf.TC_SOLUONG = IIf(Me.TC_SOLUONG.Text.Trim = "", Nothing, Me.TC_SOLUONG.Text)
            inf.TC_LOSX = Me.TC_LOSX.Text
            inf.TC_HANDUNG = GetValue(Me.TC_HANDUNG, enuDATA_TYPE.DATE_TYPE)
            inf.GHI_CHU = Me.txtGhiChu.Text

            'Truong hop thuoc kho tinh thi bind vao luoi grdds_tinh
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
            SetFormFocus(Me.cboHuyen, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu của đơn vị '" & Me.cboHuyen.SelectedItem.Text & "' đã được ghi lại", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub ClearTextbox()
        'Me.txtID_BAOCAO.Text = inf.ID_BAOCAO

        'Ton dau
        Me.TD_SOLUONG.Text = ""
        Me.TD_HANDUNG.Text = ""
        'Nhap
        Me.N_SOLUONG.Text = ""
        Me.N_LOSX.Text = ""
        Me.N_HANDUNG.Text = ""
        Me.N_TRALAI.Text = ""
        Me.N_THUA.Text = ""
        'Xuat
        Me.X_SUDUNG.Text = ""
        Me.X_HONG.Text = ""
        Me.X_DIEUCHUYEN.Text = ""
        'Ton Cuoi
        Me.TC_SOLUONG.Text = ""
        Me.TC_LOSX.Text = ""
        Me.TC_HANDUNG.Text = ""
        Me.txtID_CHITIET.Text = ""
        Me.txtGhiChu.Text = ""

    End Sub

    Protected Sub cboHuyen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboHuyen.SelectedIndexChanged
        'Neu truong hop la thuoc kho tinh thi thay doi nhan
        If Me.cboHuyen.SelectedValue = "xxx" Then
            Me.lblNhap.Text = "Nhập (Trung ương)"
            Me.lblX_SUDUNG.Text = "Toàn tỉnh"
            Me.lblX_HONGVO.Text = "Thiếu"
            Me.lblX_DIEUCHUYEN.Text = "Hỏng,Vỡ"
        Else
            Me.lblNhap.Text = "Nhập (Tỉnh cấp hoặc điều chỉnh)"
            Me.lblX_SUDUNG.Text = "Sử dụng"
            Me.lblX_HONGVO.Text = "Hỏng vỡ,thiếu"
            Me.lblX_DIEUCHUYEN.Text = "Điều chuyển"
        End If

    End Sub

    Protected Sub cmdDelDetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelDetail.Click
        Dim itm As DataGridItem
        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_CHITIET_BO
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

    Protected Sub cboNGUON_KINHPHI_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNGUON_KINHPHI.SelectedIndexChanged
        BindData()
    End Sub

    Protected Sub cboThuoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboThuoc.SelectedIndexChanged
        BindData()
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender

    End Sub
End Class
