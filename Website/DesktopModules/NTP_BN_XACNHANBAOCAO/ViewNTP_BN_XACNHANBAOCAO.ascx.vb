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

Namespace YourCompany.Modules.NTP_BN_XACNHANBAOCAO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_BN_XACNHANBAOCAO
        Inherits Entities.Modules.PortalModuleBase


#Region "Private Members"

        Private strTemplate As String



        Protected Sub cmdTim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTim.Click
            Dim objSBaoCao As New NTP_BN_XACNHANBAOCAOController
                Try   
                    Me.grdDSBaoCao.CurrentPageIndex = 0

	'grdDSBaoCao.DataSource = objSBaoCao.GetNTP_BN_XACNHANBAOCAOs(cboDieuKien.SelectedValue, Me.txtNam.Text, cboDonVi.SelectedValue, "8", "8")
            grdDSBaoCao.DataSource = objSBaoCao.GetNTP_BN_XACNHANBAOCAOs(cboDieuKien.SelectedValue, Me.txtNam.Text, cboDonVi.SelectedValue, cboDonVi.SelectedValue, Me.CurrentUserStock.ID_BENHVIEN)
            grdDSBaoCao.DataBind()
	  Finally
                objSBaoCao = Nothing
            End Try
        End Sub

 Protected Sub grdDSBaoCao_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBaoCao.PageIndexChanged
            grdDSBaoCao.CurrentPageIndex = e.NewPageIndex
            Dim objSBaoCao As New NTP_BN_XACNHANBAOCAOController
            grdDSBaoCao.DataSource = objSBaoCao.GetNTP_BN_XACNHANBAOCAOs(cboDieuKien.SelectedValue, Me.txtNam.Text, cboDonVi.SelectedValue, cboDonVi.SelectedValue, Me.CurrentUserStock.ID_BENHVIEN)
            grdDSBaoCao.DataBind()
        End Sub

        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_BN_XACNHANBAOCAOController
            Try
                For Each itm In Me.grdDSBaoCao.SelectedItems
                    'Response.Write(itm.Cells(3).Text)
                    obj.UpdateNTP_BN_XACNHANBAOCAO(itm.Cells(1).Text, itm.Cells(3).Text, itm.Cells(4).Text, Me.CurrentUserStock.ID_BENHVIEN)
                Next
                cmdTim_Click(sender, e)
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được xác nhận thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub


        Private Sub BindComboBenhVien(ByVal Id_BenhVien As String, ByVal Id_Tinh As String)
            Dim obj As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.cboDonVi.DataSource = obj.GetByBenVien(Id_BenhVien, Id_Tinh)
                Me.cboDonVi.DataBind()
                Me.cboDonVi.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
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
                    Me.cboDonVi.DataSource = obj.ListNTP_DM_TINHforMIEN(3)
                Else
                    Me.cboDonVi.DataSource = obj.ListNTP_DM_TINH(Me.CurrentUserStock.ID_BENHVIEN)
                End If
                Me.cboDonVi.DataBind()
                If cboDonVi.Items.Count <= 1 Then
                Else
                    Me.cboDonVi.Items.Insert(0, itm)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try

                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
                End If
                '  Response.Write(CurrentUserStock.ID_BENHVIEN)
                If Not IsPostBack Then
                    txtNam.Text = Year(Now)
                    If Month(Now) >= 1 And Month(Now) <= 3 Then
                        Me.cboDieuKien.SelectedValue = 1
                    ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                        Me.cboDieuKien.SelectedValue = 2
                    ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                        Me.cboDieuKien.SelectedValue = 3
                    ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                        Me.cboDieuKien.SelectedValue = 4
                    End If
                    BindComboDMTinh()
                    cmdTim_Click(sender, e)
                    '  NTP_Common.SetFormFocus(Me.cboDonVi, Me.ModuleConfiguration.SupportsPartialRendering)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                'obj = Nothing
                'inf = Nothing
            End Try
        End Sub
#End Region
    End Class

End Namespace
