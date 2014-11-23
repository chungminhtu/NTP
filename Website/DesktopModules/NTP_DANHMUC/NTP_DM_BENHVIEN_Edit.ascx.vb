Imports System.Collections.Generic
Public Class NTP_DM_BENHVIEN_Edit
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_BENHVIEN_Info
        Try
            If DotNetNuke.Framework.AJAX.IsInstalled Then
                DotNetNuke.Framework.AJAX.RegisterScriptManager()
                'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
            End If
            Dim ID_Tinh As String = ""
            Dim newID As String = "" 'obj.GetID(ID_Tinh)
            If Not IsPostBack Then
                BindComboPhanLoaiYTe()
                BindComboHuyen()
                BindComboLoaiBV()
                If Not Request.QueryString("id") Is Nothing Then
                    Me.txtID_BENHVIEN.Text = Request.QueryString("id")
                    inf = obj.SelectItem(Me.txtID_BENHVIEN.Text)
                    Me.txtTenBenhVien.Text = inf.TEN_BENHVIEN
                    Me.txtMaBenhVien.Text = inf.MA_BENHVIEN
                    If txtMaBenhVien.Text.StartsWith("BV") Then
                        cboType.SelectedIndex = 1
                    ElseIf txtMaBenhVien.Text.StartsWith("T") Then
                        cboType.SelectedIndex = 2
                    End If
                    Me.txtDiaChi.Text = inf.DIA_CHI
                    Me.cboPHANLOAIYTE.SelectedValue = inf.PHANLOAIYTE
                    Me.cboHuyen.SelectedValue = inf.ID_HUYEN
                    Me.cboLoaiBV.SelectedValue = inf.ID_LOAIBV

                    Me.txtMaBenhVien.Enabled = False
                Else
                    ID_Tinh = cboHuyen.SelectedValue.Substring(0, 2)
                    newID = obj.GetID(ID_Tinh)
                    txtMaBenhVien.Text = newID
                End If
                NTP_Common.SetFormFocus(Me.txtMaBenhVien, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            Else
                AutoGenMaBenhVien()
            End If

        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try

    End Sub

    Private Sub BindComboHuyen()
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Me.cboHuyen.DataSource = obj.SelectAllItems()
        Me.cboHuyen.DataBind()
    End Sub

    Private Sub BindComboLoaiBV()
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Me.cboLoaiBV.DataTextField = "Ten_LoaiBV"
        Me.cboLoaiBV.DataValueField = "ID_LoaiBV"
        Me.cboLoaiBV.DataSource = obj.LoadDMLoaiBV()
        Me.cboLoaiBV.DataBind()
    End Sub

    Private Sub BindComboPhanLoaiYTe()

        Dim objNTP_BN_DM_PHANLOAIYTEs As New YourCompany.Modules.NTP_BN_DM_PHANLOAIYTE.NTP_BN_DM_PHANLOAIYTEController
        Dim colNTP_BN_DM_PHANLOAIYTEs As List(Of YourCompany.Modules.NTP_BN_DM_PHANLOAIYTE.NTP_BN_DM_PHANLOAIYTEInfo)

        ' get the content from the NTP_BN_DM_PHANLOAIYTE table
        colNTP_BN_DM_PHANLOAIYTEs = objNTP_BN_DM_PHANLOAIYTEs.List()
        Dim i As Int16
        Dim itm As ListItem
        For i = 0 To colNTP_BN_DM_PHANLOAIYTEs.Count - 1
            itm = New ListItem
            itm.Value = colNTP_BN_DM_PHANLOAIYTEs(i).ID_PHANLOAIYTE
            itm.Text = colNTP_BN_DM_PHANLOAIYTEs(i).Ten_PHANLOAIYTE
            Me.cboPHANLOAIYTE.Items.Add(itm)
        Next

    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect(NavigateURL())
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_BENHVIEN_Info
        Try
            inf.TEN_BENHVIEN = Me.txtTenBenhVien.Text
            inf.MA_BENHVIEN = Me.txtMaBenhVien.Text
            inf.DIA_CHI = Me.txtDiaChi.Text
            inf.PHANLOAIYTE = Me.cboPHANLOAIYTE.SelectedValue
            inf.ID_HUYEN = Me.cboHuyen.SelectedValue
            inf.ID_LOAIBV = Me.cboLoaiBV.SelectedValue
            If Request.QueryString("id") Is Nothing Then
                'Add
                'Kiem tra ma benh vien co trung khong
                obj.InsertItem(inf)
                'Clear text box
                Me.txtTenBenhVien.Text = ""
                Me.txtDiaChi.Text = ""
                'Me.txtMaBenhVien.Text = ""
                AutoGenMaBenhVien()
                NTP_Common.SetFormFocus(Me.txtMaBenhVien, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
            Else
                'Update
                inf.ID_BENHVIEN = Me.txtID_BENHVIEN.Text
                obj.UpdateItem(inf)
            End If
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        Catch sqlex As SqlException
            DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
            inf = Nothing
        End Try
    End Sub

    Sub AutoGenMaBenhVien()
        Dim obj As New NTP_DANHMUC.NTP_DM_BENHVIEN_BO
        Dim inf As New NTP_DANHMUC.NTP_DM_BENHVIEN_Info

        Dim ID_Tinh As String = ""
        Dim newID As String = "" 'obj.GetID(ID_Tinh)

        'Đổi type ?
        Dim tmpLength As Integer = 0
        If cboType.Text.Equals("") Then ' Type=""

            If txtMaBenhVien.Text.StartsWith("BV") Then
                tmpLength = txtMaBenhVien.Text.Length - 2
                txtMaBenhVien.Text = txtMaBenhVien.Text.Substring(2, tmpLength)
            ElseIf txtMaBenhVien.Text.StartsWith("T") Then
                tmpLength = txtMaBenhVien.Text.Length - 1
                txtMaBenhVien.Text = txtMaBenhVien.Text.Substring(1, 4)
            Else
                ID_Tinh = cboHuyen.SelectedValue.Substring(0, 2)
                newID = obj.GetID(ID_Tinh)
                txtMaBenhVien.Text = newID.ToString
            End If
        ElseIf txtMaBenhVien.Text.Substring(0, 1) = cboType.Text.Substring(0, 1) Then
            ID_Tinh = cboHuyen.SelectedValue.Substring(0, 2)
            newID = obj.GetID(ID_Tinh)
            If newID.StartsWith("BV") Then
                tmpLength = txtMaBenhVien.Text.Length - 2
                txtMaBenhVien.Text = cboType.Text & newID.Substring(2, tmpLength)
            ElseIf newID.StartsWith("T") Then
                tmpLength = txtMaBenhVien.Text.Length - 1
                txtMaBenhVien.Text = cboType.Text & newID.Substring(1, tmpLength)
            Else
                txtMaBenhVien.Text = cboType.Text & newID
            End If
        Else
            'Cắt chuỗi
            If txtMaBenhVien.Text.StartsWith("BV") Then
                tmpLength = txtMaBenhVien.Text.Length - 2
                txtMaBenhVien.Text = "T" & txtMaBenhVien.Text.Substring(2, tmpLength)
            ElseIf txtMaBenhVien.Text.StartsWith("T") Then
                tmpLength = txtMaBenhVien.Text.Length - 1
                txtMaBenhVien.Text = "BV" & txtMaBenhVien.Text.Substring(1, tmpLength)
            Else
                txtMaBenhVien.Text = cboType.Text & txtMaBenhVien.Text
            End If
        End If
        NTP_Common.SetFormFocus(Me.txtMaBenhVien, Me.ModuleConfiguration.ModuleControl.SupportsPartialRendering)
    End Sub
End Class
