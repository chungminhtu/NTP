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

Namespace YourCompany.Modules.NTP_KD_BAOCAOHDXN

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_KD_BAOCAOHDXN
        Inherits Entities.Modules.PortalModuleBase
        Implements Entities.Modules.IActionable

#Region "Private Members"

        Private strTemplate As String

#End Region

#Region "Event Handlers"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
               
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()

                End If
                Literal1.Visible = False
                If Not Page.IsPostBack Then
                    BindComboMien()
                    '  BindComboVung()
                    If Me.CurrentUserStock.ID_BENHVIEN = "3112" Then
                        '  BindComboMien()
                    Else
                        BindComboTinh(0)
                    End If
                    BindComboDMLOAIBV()
                    Me.txtNamBC.Text = Year(Now)
                    'If Month(Now) >= 1 And Month(Now) <= 3 Then
                    '    Me.chkQuy1.Checked = True
                    'ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                    '    Me.chkQuy2.Checked = 2
                    'ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                    '    Me.chkQuy3.Checked = 3
                    'ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                    '    Me.chkQuy4.Checked = 4
                    'End If
                End If

            Catch exc As Exception        'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        

#End Region

#Region "Optional Interfaces"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Registers the module actions required for interfacing with the portal framework
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property ModuleActions() As Entities.Modules.Actions.ModuleActionCollection Implements Entities.Modules.IActionable.ModuleActions
            Get
                Dim Actions As New Entities.Modules.Actions.ModuleActionCollection
                Actions.Add(GetNextActionID, Localization.GetString(Entities.Modules.Actions.ModuleActionType.AddContent, LocalResourceFile), Entities.Modules.Actions.ModuleActionType.AddContent, "", "", EditUrl(), False, Security.SecurityAccessLevel.Edit, True, False)
                Return Actions
            End Get
        End Property

#End Region

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
            Dim sQuy As String, DK As String
            DK = CboPhanloai.SelectedValue
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
                url = Request.ApplicationPath & "/Report/form/BaocaoKiemDinh.aspx?Opt=" & optlistBaoCao.SelectedValue & " &Tinh=" & Me.cboTinh.SelectedValue & "&Mien=" & Me.cboMien.SelectedValue & "&Vung=" & Me.cboVung.SelectedValue & "&Nam=" & Me.txtNamBC.Text & "&Quy=" & sQuy & "&Dieukien=" & DK & "&Kieuin=" & optlisLuachonIn.SelectedValue     ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"

                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
            End If
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
