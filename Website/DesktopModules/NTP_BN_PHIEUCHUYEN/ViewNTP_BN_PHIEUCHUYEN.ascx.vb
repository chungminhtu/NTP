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

Namespace YourCompany.Modules.NTP_BN_PHIEUCHUYEN

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewDynamicModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewNTP_BN_PHIEUCHUYEN
        Inherits Entities.Modules.PortalModuleBase
        '  Implements Entities.Modules.IActionable

#Region "Private Members"

        Private strTemplate As String

#End Region

#Region "Event Handlers"

   

#End Region

#Region "Optional Interfaces"

#End Region
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
           
            If Not Page.IsPostBack Then
                If TxtNam.Text Is Nothing Or TxtNam.Text = "" Then TxtNam.Text = Year(Now)
                BindData(Me.CurrentUserStock.ID_BENHVIEN, TxtNam.Text)
            End If
        End Sub

        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Dim itm As DataGridItem
            Dim obj As New NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENController
            Try
                For Each itm In Me.grdDSBenhnhan1.SelectedItems
                    obj.Delete(itm.Cells(2).Text)
                Next
                BindData(Me.CurrentUserStock.ID_BENHVIEN, TxtNam.Text)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Private Sub BindData(ByVal ID_BENHVIEN As String, ByVal Nam As Integer)
            Dim objPhieuChuyen As New NTP_BN_PHIEUCHUYENController

            Try
                Me.grdDSBenhnhan1.DataSource = objPhieuChuyen.ListByDVTNam(ID_BENHVIEN, Nam)
                Me.grdDSBenhnhan1.DataBind()
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
            End Try

        End Sub


        Protected Sub grdDSBenhNhan1_ItemCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDSBenhnhan1.ItemCommand

            If e.CommandName = "edit" Then
                Response.Redirect(NavigateURL("edit", "mid=" & Me.ModuleId & "&id=" & e.Item.Cells(2).Text))
            End If
        End Sub

       

        Protected Sub grdDSBenhnhan1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdDSBenhnhan1.PageIndexChanged
            grdDSBenhnhan1.CurrentPageIndex = e.NewPageIndex
            BindData(Me.CurrentUserStock.ID_BENHVIEN, TxtNam.Text)
        End Sub

      
       
        Protected Sub CmdXem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXem.Click
            BindData(Me.CurrentUserStock.ID_BENHVIEN, TxtNam.Text)
        End Sub
    End Class
   
End Namespace
