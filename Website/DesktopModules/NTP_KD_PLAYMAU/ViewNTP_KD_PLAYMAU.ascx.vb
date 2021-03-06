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

Namespace YourCompany.Modules.NTP_KD_PLAYMAU

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_KD_PLAYMAU
        Inherits Entities.Modules.PortalModuleBase


#Region "Private Members"

        Private strTemplate As String

#End Region


        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
               
                If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                    ' cmdAdd.Visible = False
                    ' cmdDelete.Visible = False
                Else
                    ' cmdAdd.Visible = True
                    ' cmdDelete.Visible = True
                End If
                If Not IsPostBack Then
                    If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                        txtNam.Text = Now.Year
                    End If
                    Me.cboQuy.SelectedValue = Now.Month - 1
                    If DotNetNuke.Framework.AJAX.IsInstalled Then
                        DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    End If
                    BindComboDMTinh()
                    cmdTim_Click(sender, e)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
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
        Protected Sub grdDS_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBaoCao.ItemCommand
            If e.CommandName = "edit" Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))

            End If
        End Sub

        Protected Sub cmdTim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTim.Click

            If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                txtNam.Text = Now.Year
            End If
            Dim ThangNam As String
            ThangNam = txtNam.Text
            Dim objSBaoCao As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
            Response.Write(Me.CurrentUserStock.USERID)
            'Response.Write(Me.CurrentUserStock.ID_MATINH)
            If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                grdDSBaoCao.DataSource = objSBaoCao.ListByDieuKien(Me.CurrentUserStock.ID_BENHVIEN, ThangNam, cboQuy.SelectedValue, 2, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue))
            Else
                grdDSBaoCao.DataSource = objSBaoCao.ListByDieuKien(Me.CurrentUserStock.ID_BENHVIEN, ThangNam, cboQuy.SelectedValue, 1, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue))
            End If
            grdDSBaoCao.DataBind()
        End Sub

        Protected Sub grdDSBaoCao_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBaoCao.PageIndexChanged
            grdDSBaoCao.CurrentPageIndex = e.NewPageIndex

            If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                txtNam.Text = Now.Year
            End If
            Dim ThangNam As String
            ThangNam = txtNam.Text
            Dim objSBaoCao As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
            If CType(Settings("KiemDinhView"), String) = "Lan2" Then
                grdDSBaoCao.DataSource = objSBaoCao.ListByDieuKien(Me.CurrentUserStock.ID_BENHVIEN, ThangNam, cboQuy.SelectedValue, 2, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue))
            Else
                grdDSBaoCao.DataSource = objSBaoCao.ListByDieuKien(Me.CurrentUserStock.ID_BENHVIEN, ThangNam, cboQuy.SelectedValue, 1, IIf(CboDMTinh.SelectedValue = "", "ALL", CboDMTinh.SelectedValue))
            End If
            grdDSBaoCao.DataBind()
        End Sub

        'Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        '    Dim itm As DataGridItem
        '    Dim obj As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
        '    Dim inf As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUInfo

        '    Try
        '        For Each itm In Me.grdDSBaoCao.SelectedItems
        '            inf = obj.Get(itm.Cells(2).Text)
        '            If inf.TinhXN = True Then
        '                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Báo cáo đã được xác nhận", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
        '                Exit Sub
        '            End If
        '            obj.Delete(itm.Cells(2).Text)
        '        Next
        '        cmdTim_Click(sender, e)
        '    Catch sqlex As SqlException
        '        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
        '    Catch ex As Exception
        '        ProcessModuleLoadException(Me, ex)
        '    Finally
        '        obj = Nothing
        '    End Try
        'End Sub

        Protected Sub grdDSBaoCao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDSBaoCao.SelectedIndexChanged
            Dim ThangNam As String
            ThangNam = txtNam.Text

            Dim objSBaoCao As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
            Dim inf As New NTP_KD_PLAYMAU.NTP_KD_PLAYMAUInfo
            inf = objSBaoCao.Get(grdDSBaoCao.SelectedItem.Cells(2).Text)
            If inf.TinhXN = True Then
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Báo cáo đã được xác nhận", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
            End If
        End Sub

    End Class

End Namespace
