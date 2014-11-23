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

Namespace YourCompany.Modules.NTP_BN_TINHHINHTRIENKHAI_CTCL

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_BN_TINHHINHTRIENKHAI_CTCL
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
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                Literal1.Visible = False

                If Not IsPostBack Then
                    BindComboTinh()
                    txtNam.Text = Year(Now)
                    LoadGrid(txtNam.Text)
                End If
            Catch exc As Exception        'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub
      
        Private Sub BindComboTinh()
            Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn tỉnh ---"
                Me.cboTinh.DataSource = obj.Search("", 0)
                Me.cboTinh.DataBind()
                Me.cboTinh.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

#End Region

        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim obj1 As New NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLController
            Dim inf1 As New NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLInfo
            Try
                inf1.Nam = txtNam.Text
                inf1.MA_TINH = cboTinh.SelectedValue
                inf1.SLHuyen = IIf(TxtSLHuyen.Text = "", 0, TxtSLHuyen.Text)
                inf1.SLHuyenTK = IIf(txtSLHuyenTK.Text = "", 0, txtSLHuyenTK.Text)
                inf1.SLXa = IIf(TxtTSXa.Text = "", 0, TxtTSXa.Text)
                inf1.SLXaTK = IIf(TxtTSXaTK.Text = "", 0, TxtTSXaTK.Text)
                inf1.SodanTK = IIf(TxtDansoTK.Text = "", 0, TxtDansoTK.Text)
                inf1.DansoTinh = IIf(TxtDansoTinh.Text = "", 0, TxtDansoTinh.Text)
                inf1.SoDVQL = IIf(TxtSoDV.Text = "", 0, TxtSoDV.Text)
                ' inf1.ID_TRIENKHAI = Me.TxtID.Text

                If TxtID.Text = "" Or TxtID.Text Is Nothing Then
                    TxtID.Text = obj1.AddNTP_BN_TINHHINHTRIENKHAI_CTCL(inf1)
                Else
                    inf1.ID_TRIENKHAI = TxtID.Text
                    obj1.UpdateNTP_BN_TINHHINHTRIENKHAI_CTCL(inf1)
                End If
                cmdTim_Click(sender, e)
                TxtSLHuyen.Text = ""
                txtSLHuyenTK.Text = ""
                TxtTSXa.Text = ""
                TxtTSXaTK.Text = ""
                TxtDansoTK.Text = ""
                TxtID.Text = ""
                TxtDansoTinh.Text = ""
                TxtSoDV.Text = ""
                cboTinh.SelectedValue = ""

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
                Response.Write(ex.ToString)
            Finally
                obj1 = Nothing
            End Try
        End Sub

        Protected Sub grdDSBaoCao_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBaoCao.ItemCommand
            Try
                If e.CommandName = "edit" Then

                    Dim obj As New NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLController
                    Dim inf As New NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLInfo
                    TxtID.Text = e.Item.Cells(2).Text
                    inf = obj.List(TxtID.Text)
                    If Not inf Is Nothing Then
                        Me.TxtSLHuyen.Text = inf.SLHuyen
                        Me.txtSLHuyenTK.Text = inf.SLHuyenTK
                        Me.TxtTSXa.Text = inf.SLXa
                        Me.TxtTSXaTK.Text = inf.SLXaTK
                        Me.TxtDansoTinh.Text = inf.DansoTinh
                        Me.TxtDansoTK.Text = inf.SodanTK
                        Me.TxtSoDV.Text = inf.SoDVQL
                        Me.cboTinh.SelectedValue = inf.MA_TINH
                    End If
                    obj = Nothing
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub

        Protected Sub CmdXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXoa.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLController

            Try
                For Each itm In Me.grdDSBaoCao.SelectedItems

                    obj.DeleteNTP_BN_TINHHINHTRIENKHAI_CTCL(itm.Cells(2).Text)
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

        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            Me.txtNam.Text = ""
            TxtSLHuyen.Text = ""
            txtSLHuyenTK.Text = ""
            TxtTSXa.Text = ""
            TxtTSXaTK.Text = ""
            TxtDansoTK.Text = ""
            TxtID.Text = ""
            TxtDansoTinh.Text = ""
            TxtSoDV.Text = ""
            cboTinh.SelectedValue = ""
            LoadGrid(IIf(txtNam.Text = "", 0, txtNam.Text))
        End Sub

        Protected Sub cmdTim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTim.Click
            
           LoadGrid(IIf(txtNam.Text = "", 0, txtNam.Text))

        End Sub
        Private Sub LoadGrid(ByVal Nam As Integer)
            Dim objSBaoCao As New NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLController
            grdDSBaoCao.DataSource = objSBaoCao.Get(Nam)
            grdDSBaoCao.DataBind()
            objSBaoCao = Nothing
        End Sub

        Protected Sub CmdIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdIn.Click
            Dim url As String
            If txtNam.Text <> "" Then
                url = Request.ApplicationPath & "/Report/form/Baocao.aspx?Opt=7&Nam=" & Me.txtNam.Text & "&Kieuin=" & optlisLuachonIn.SelectedValue

                Literal1.Text = "<script language = 'javascript'>" & _
                                                      "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
                Literal1.Visible = True
                url = ""
            End If
        End Sub

        Protected Sub grdDSBaoCao_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBaoCao.PageIndexChanged
            grdDSBaoCao.CurrentPageIndex = e.NewPageIndex
            If txtNam.Text = "" Or txtNam.Text Is Nothing Then
                txtNam.Text = Now.Year
            End If
            Dim objSBaoCao As New NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLController
            grdDSBaoCao.DataSource = objSBaoCao.Get(txtNam.Text)
            grdDSBaoCao.DataBind()
            objSBaoCao = Nothing
        End Sub

        
    End Class

End Namespace
