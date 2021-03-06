'
' DotNetNuke® - http://www.dotnetnuke.com
' Copyright (c) 2002-2006
' by Perpetual Motion Interactive Systems Inc. ( http://www.perpetualmotion.ca )
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'
Imports DotNetNuke
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Reflection

Namespace YourCompany.Modules.NTP_BN_BC_KETQUADT

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_BN_BC_KETQUADT
        Inherits Entities.Modules.PortalModuleBase


#Region "Private Members"

        Private strTemplate As String

#End Region

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                    txtNam.Text = Year(Now) - 1
                End If
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()

                End If
                Literal1.Visible = False
                pnlNhapBaoCao.Visible = False
                pnlBaoCao.Visible = False
                If CType(Settings("BaoCaoKQDTView"), String) = "NhapBC" Then
                    pnlNhapBaoCao.Visible = True
                    grdDSBaoCao.Visible = True
                    GrdDSChuaBC.Visible = False
                    If Me.CurrentUserStock.ID_BENHVIEN = "7210" Or Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                        '========= 7210: user CTLQG; 3112: user Pham Ngoc Thach (tuyen mien nam)
                        CmdDaBaocao.BackColor = Color.LightCyan
                        CmdChuaBaocao.BackColor = Color.WhiteSmoke()
                        CmdChuaBaocao.Font.Underline = False
                        CmdDaBaocao.Font.Underline = True
                        CmdChuaBaocao.Visible = True
                        CmdDaBaocao.Visible = True
                    Else
                        CmdChuaBaocao.Visible = False
                        CmdDaBaocao.Visible = False
                    End If
                Else
                    If CType(Settings("BaoCaoKQDTView"), String) = "BaoCao" Then

                        pnlBaoCao.Visible = True

                    End If
                End If
                If Not IsPostBack Then

                    If CType(Settings("BaoCaoKQDTView"), String) = "NhapBC" Then
                        pnlNhapBaoCao.Visible = True
                        BindComboDMTinh()
                        cmdTim_Click(sender, e)
                    Else
                        If CType(Settings("BaoCaoKQDTView"), String) = "BaoCao" Then
                            pnlBaoCao.Visible = True
                            BindComboMien()
                            If Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                                '   BindComboMien()
                            Else
                                BindComboTinh(0)
                            End If
                            BindComboDMLOAIBV()
                            Me.txtNamBC.Text = Year(Now) - 1
                           
                        End If
                    End If
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                Response.Write(ex.ToString)
            End Try
        End Sub

        Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBaoCao.ItemCommand
            If e.CommandName = "edit" Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
            ElseIf e.CommandName = "In" Then
                Response.Write("In tuyen huyen" & "&id=" & e.Item.Cells(2).Text)
            End If
        End Sub
        Private Sub BindComboDMTinh()
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_TINHController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn tỉnh ---"
                If Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                    Me.CboDMTinh.DataSource = obj.ListNTP_DM_TINHforMIEN(3)
                Else
                    Me.CboDMTinh.DataSource = obj.ListNTP_DM_TINH(Me.CurrentUserStock.ID_BENHVIEN)
                End If
                Me.CboDMTinh.DataBind()
                If CboDMTinh.Items.Count <= 1 Then
                Else
                    Me.CboDMTinh.Items.Insert(0, itm)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboDMTinhforMien(ByVal Mien As Integer)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_TINHController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn tỉnh ---"
                Me.cboTinh.DataSource = obj.ListNTP_DM_TINHforMIEN(Mien)
                Me.cboTinh.DataBind()
                Me.cboTinh.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboTinh(ByVal Vung As Integer)
            Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn tỉnh ---"
                Me.cboTinh.DataSource = obj.Search("", Vung)
                Me.cboTinh.DataBind()
                Me.cboTinh.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboVung(ByVal Mien As String)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_VUNGController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn vùng ---"
                Me.cboVung.DataSource = obj.ListByMien(CType(Mien, Integer))
                Me.cboVung.DataBind()
                Me.cboVung.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Private Sub BindComboMien()
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_MIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn miền ---"
                If Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                    Me.cboMien.DataSource = obj.NTP_DM_MIEN_Select(3)
                Else
                    Me.cboMien.DataSource = obj.List()
                End If
                Me.cboMien.DataBind()
                If Me.cboMien.Items.Count <= 1 Then
                    BindComboVung(3)
                    BindComboDMTinhforMien(3)
                Else
                    Me.cboMien.Items.Insert(0, itm)
                    BindComboVungALL()
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub BindComboVungALL()
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_VUNGController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn vùng ---"
                Me.cboVung.DataSource = obj.ListNTP_DM_VUNGALL()
                Me.cboVung.DataBind()
                Me.cboVung.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            'Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BCKETQUADIEUTRILAOINController
            'Dim ds As New DataSet
            'ds = obj.ListBaoCao("", 1, 1, 1)
            'ds.WriteXmlSchema(Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\NTP_BN_BCKETQUADIEUTRILAOIN.xsd")
            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id_Tinh=" & Me.CboDMTinh.SelectedValue))
           

            'Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id_Tinh=" &""&"id_Mien=" &"1"&"id_Vung=" &"1"&"id_Nam=" &"1" )
        End Sub


        Protected Sub cmdTim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTim.Click
            Dim DieuKien As String = Me.cboDieuKien.SelectedValue
            If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                txtNam.Text = Now.Year
            End If
            Dim ThangNam As String
            ThangNam = txtNam.Text

            If CmdChuaBaocao.Font.Underline = True Then
                CmdChuaBaocao_Click(sender, e)
            Else
                Me.grdDSBaoCao.CurrentPageIndex = 0
                Dim objSBaoCao As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
                grdDSBaoCao.DataSource = objSBaoCao.ListByDieuKien(ThangNam, Me.CurrentUserStock.ID_BENHVIEN, DieuKien, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue))
                grdDSBaoCao.DataBind()
            End If

        End Sub

        Protected Sub grdDSBaoCao_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBaoCao.PageIndexChanged
            grdDSBaoCao.CurrentPageIndex = e.NewPageIndex
            Dim DieuKien As String = Me.cboDieuKien.SelectedValue
            If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                txtNam.Text = Now.Year
            End If
            Dim ThangNam As String
            ThangNam = txtNam.Text
            Dim objSBaoCao As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            grdDSBaoCao.DataSource = objSBaoCao.ListByDieuKien(ThangNam, Me.CurrentUserStock.ID_BENHVIEN, DieuKien, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue))
            grdDSBaoCao.DataBind()
        End Sub

        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDel.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTInfo

            Try
                For Each itm In Me.grdDSBaoCao.SelectedItems
                    inf = obj.Get(itm.Cells(2).Text)
                    If inf.TinhXN = True Then
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Báo cáo đã được xác nhận", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
                        Exit Sub
                    End If
                    obj.Delete(itm.Cells(2).Text)
                Next
                cmdTim_Click(sender, e)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub grdDSBaoCao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDSBaoCao.SelectedIndexChanged
            Dim ThangNam As String
            ThangNam = txtNam.Text

            Dim objSBaoCao As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            Dim inf As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTInfo
            inf = objSBaoCao.Get(grdDSBaoCao.SelectedItem.Cells(2).Text)
            If inf.TinhXN = True Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Báo cáo đã được xác nhận", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
            End If
        End Sub

        Private Sub BindComboDMLOAIBV()
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_LOAIBVController
            Try
                Me.CboPhanloai.DataSource = obj.List()
                Me.CboPhanloai.DataBind()

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
            Dim url As String
            Dim sQuy As String, DK As string
            DK = CboPhanloai.SelectedValue

            sQuy = ""
            If ChkNam.Checked = True Then
                sQuy = "1,2,3,4"
            Else
                If chkQuy1.Checked = True Then
                    sQuy = sQuy + "1,"
                End If
                If chkQuy2.Checked = True Then
                    sQuy = sQuy + "2,"
                End If
                If chkQuy3.Checked = True Then
                    sQuy = sQuy + "3,"
                End If
                If chkQuy4.Checked = True Then
                    sQuy = sQuy + "4,"
                End If
                If sQuy <> "" Then
                    sQuy = Left(sQuy, Len(sQuy) - 1)
                End If
            End If
            If sQuy = "" Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Bạn cần chọn thời gian báo cáo ", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Else
                If optlistBaoCao.SelectedValue = "1" Then
                    url = Request.ApplicationPath & "/Report/form/BaoCao.aspx?Opt=1&Tinh=" & Me.cboTinh.SelectedValue & "&Mien=" & Me.cboMien.SelectedValue & "&Vung=" & Me.cboVung.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Dieukien=" & DK & "&Kieuin=" & optlisLuachonIn.SelectedValue      ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"

                ElseIf optlistBaoCao.SelectedValue = "2" Then
                    url = Request.ApplicationPath & "/Report/form/BaoCao.aspx?&Opt=2&Tinh=" & Me.cboTinh.SelectedValue & "&Mien=" & Me.cboMien.SelectedValue & "&Vung=" & Me.cboVung.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Dieukien=" & DK & "&Kieuin=" & optlisLuachonIn.SelectedValue      ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
                ElseIf optlistBaoCao.SelectedValue = "3" Then
                    url = Request.ApplicationPath & "/Report/form/BaoCao.aspx?&Opt=3&Tinh=" & Me.cboTinh.SelectedValue & "&Mien=" & Me.cboMien.SelectedValue & "&Vung=" & Me.cboVung.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Dieukien=" & DK & "&Kieuin=" & optlisLuachonIn.SelectedValue   ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
                ElseIf optlistBaoCao.SelectedValue = "4" Then
                    url = Request.ApplicationPath & "/Report/form/BaoCao.aspx?&Opt=4&Tinh=" & Me.cboTinh.SelectedValue & "&Mien=" & Me.cboMien.SelectedValue & "&Vung=" & Me.cboVung.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Dieukien=" & DK & "&Kieuin=" & optlisLuachonIn.SelectedValue   ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
                End If
                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
            End If
        End Sub

       
        Protected Sub cboMien_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMien.SelectedIndexChanged
            If cboMien.SelectedValue <> "" Then
                BindComboVung(Me.cboMien.SelectedValue)
                BindComboDMTinhforMien(Me.cboMien.SelectedValue)
                NTP_Common.SetFormFocus(cboVung, Me.ModuleConfiguration.SupportsPartialRendering)
            Else
                BindComboTinh(0)
            End If

        End Sub

        Protected Sub cboVung_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVung.SelectedIndexChanged
            If cboVung.SelectedValue <> "" Then
                BindComboTinh(Me.cboVung.SelectedValue)
                NTP_Common.SetFormFocus(cboTinh, Me.ModuleConfiguration.SupportsPartialRendering)
            Else
                If cboMien.SelectedValue <> "" Then
                    BindComboVung(Me.cboMien.SelectedValue)
                    BindComboDMTinhforMien(Me.cboMien.SelectedValue)
                    NTP_Common.SetFormFocus(cboVung, Me.ModuleConfiguration.SupportsPartialRendering)
                Else
                    BindComboTinh(0)
                End If
            End If

        End Sub
       
        Protected Sub CmdDaBaocao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdDaBaocao.Click
            grdDSBaoCao.Visible = True
            GrdDSChuaBC.Visible = False

            CmdDaBaocao.BackColor = Color.LightCyan
            CmdChuaBaocao.BackColor = Color.WhiteSmoke()
            CmdChuaBaocao.Font.Underline = False
            CmdDaBaocao.Font.Underline = True
        End Sub

        Protected Sub CmdChuaBaocao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdChuaBaocao.Click
            CmdDaBaocao.BackColor = Color.WhiteSmoke()
            CmdChuaBaocao.BackColor = Color.LightCyan
            CmdChuaBaocao.Font.Underline = True
            CmdDaBaocao.Font.Underline = False
            grdDSBaoCao.Visible = False
            GrdDSChuaBC.Visible = True
            Dim DieuKien As String = Me.cboDieuKien.SelectedValue
            If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                txtNam.Text = Now.Year
            End If
            Dim ThangNam As String
            ThangNam = txtNam.Text
            Me.GrdDSChuaBC.CurrentPageIndex = 0
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            '          'GrdDSChuaBC.DataSource = objSBaoCao.ListNTP_BN_DONVICHUABC(DieuKien, ThangNam, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue), 2)
            GrdDSChuaBC.DataSource = obj.ListNTP_BN_DONVICHUABC(DieuKien, ThangNam, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue), 1, Me.CurrentUserStock.ID_BENHVIEN)

            GrdDSChuaBC.DataBind()
        End Sub

        Protected Sub GrdDSChuaBC_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles GrdDSChuaBC.PageIndexChanged
            GrdDSChuaBC.CurrentPageIndex = e.NewPageIndex
            CmdDaBaocao.BackColor = Color.WhiteSmoke()
            CmdChuaBaocao.BackColor = Color.LightCyan
            CmdChuaBaocao.Font.Underline = True
            CmdDaBaocao.Font.Underline = False
            grdDSBaoCao.Visible = False
            GrdDSChuaBC.Visible = True
            Dim DieuKien As String = Me.cboDieuKien.SelectedValue
            If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                txtNam.Text = Now.Year
            End If
            Dim ThangNam As String
            ThangNam = txtNam.Text
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_BN_BC_KETQUADTController
            '          'GrdDSChuaBC.DataSource = objSBaoCao.ListNTP_BN_DONVICHUABC(DieuKien, ThangNam, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue), 2)
            GrdDSChuaBC.DataSource = obj.ListNTP_BN_DONVICHUABC(DieuKien, ThangNam, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue), 1, Me.CurrentUserStock.ID_BENHVIEN)
            GrdDSChuaBC.DataBind()
        End Sub


        Protected Sub ChkNam_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkNam.CheckedChanged
            chkQuy1.Checked = False
            chkQuy2.Checked = False
            chkQuy3.Checked = False
            chkQuy4.Checked = False
            If ChkNam.Checked = True Then
                chkQuy1.Enabled = False
                chkQuy2.Enabled = False
                chkQuy3.Enabled = False
                chkQuy4.Enabled = False
            Else
                chkQuy1.Enabled = True
                chkQuy2.Enabled = True
                chkQuy3.Enabled = True
                chkQuy4.Enabled = True
            End If
        End Sub
    End Class

End Namespace
