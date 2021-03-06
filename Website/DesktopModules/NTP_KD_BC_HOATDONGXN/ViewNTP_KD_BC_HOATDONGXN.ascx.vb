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
Imports NTP_Common.mdlGlobal

Namespace YourCompany.Modules.NTP_KD_BC_HOATDONGXN

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_KD_BC_HOATDONGXN
        Inherits Entities.Modules.PortalModuleBase
      
#Region "Private Members"

        Private strTemplate As String

#End Region

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()

                End If

              
                If Not IsPostBack Then
                    If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                        txtNam.Text = Now.Year
                    End If
                    If Month(Now) >= 1 And Month(Now) <= 3 Then
                        Me.cboDieuKien.SelectedValue = 1
                    ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                        Me.cboDieuKien.SelectedValue = 2
                    ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                        Me.cboDieuKien.SelectedValue = 3
                    ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                        Me.cboDieuKien.SelectedValue = 4
                    End If
                    grdDSBaoCao.Visible = True
                    GrdDSChuaBC.Visible = False
                    Response.Write(Me.CurrentUserStock.ID_BENHVIEN)
                    If Me.CurrentUserStock.ID_BENHVIEN = "7210" Or Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                        CmdDaBaocao.BackColor = Color.LightCyan
                        CmdChuaBaocao.BackColor = Color.WhiteSmoke()
                        CmdChuaBaocao.Font.Underline = False
                        CmdDaBaocao.Font.Underline = True
                        CmdChuaBaocao.Visible = True
                    Else
                        CmdChuaBaocao.Visible = False
                        CmdDaBaocao.Visible = False
                    End If
                    BindComboDMTinh()
                    cmdTim_Click(sender, e)
                End If



            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub
      
        Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBaoCao.ItemCommand
            If e.CommandName = "edit" Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))

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


        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

            Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id_Tinh=" & Me.CboDMTinh.SelectedValue))
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

                Dim objSBaoCao As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
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
            Dim objSBaoCao As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
            grdDSBaoCao.DataSource = objSBaoCao.ListByDieuKien(ThangNam, Me.CurrentUserStock.ID_BENHVIEN, DieuKien, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue))
            grdDSBaoCao.DataBind()
        End Sub

        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
            Dim inf As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNInfo

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

            Dim objSBaoCao As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
            Dim inf As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNInfo
            inf = objSBaoCao.Get(grdDSBaoCao.SelectedItem.Cells(2).Text)
            If inf.TinhXN = True Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Báo cáo đã được xác nhận", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
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
            GrdDSChuaBC.DataSource = obj.ListNTP_BN_DONVICHUABC(DieuKien, ThangNam, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue), 3, Me.CurrentUserStock.ID_BENHVIEN)

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
            GrdDSChuaBC.DataSource = obj.ListNTP_BN_DONVICHUABC(DieuKien, ThangNam, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue), 3, Me.CurrentUserStock.ID_BENHVIEN)
            GrdDSChuaBC.DataBind()
        End Sub


    End Class

End Namespace
