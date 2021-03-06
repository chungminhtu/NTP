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

Namespace YourCompany.Modules.NTP_BN_DM_PHANLOAIYTE

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_DM_PHANLOAIYTE
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

#End Region

#Region "Event Handlers"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim obj As New NTP_BN_DM_PHANLOAIYTEController
            Dim inf As New NTP_BN_DM_PHANLOAIYTEInfo
            Try
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
                End If
                If Not IsPostBack Then

                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtID_PHANLOAIYTE.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtID_PHANLOAIYTE.Text)
                        Me.txtPHANLOAIYTE.Text = inf.Ten_PHANLOAIYTE

                    End If
                    NTP_Common.SetFormFocus(Me.txtPHANLOAIYTE, Me.ModuleConfiguration.SupportsPartialRendering)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
                inf = Nothing
            End Try

        End Sub

        Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
            Dim obj As New NTP_BN_DM_PHANLOAIYTE.NTP_BN_DM_PHANLOAIYTEController
            Dim inf As New NTP_BN_DM_PHANLOAIYTE.NTP_BN_DM_PHANLOAIYTEInfo

            Try
                inf.Ten_PHANLOAIYTE = Me.txtPHANLOAIYTE.Text

                If Request.QueryString("id") Is Nothing Then
                    'Add
                    obj.Add(inf)
                    'Clear text box
                    Me.txtPHANLOAIYTE.Text = ""
                    NTP_Common.SetFormFocus(Me.txtPHANLOAIYTE, Me.ModuleConfiguration.SupportsPartialRendering)
                Else
                    'Update
                    inf.ID_PHANLOAIYTE = Me.txtID_PHANLOAIYTE.Text
                    obj.Update(inf)
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

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
            Response.Redirect(NavigateURL())
        End Sub
#End Region

    End Class

End Namespace