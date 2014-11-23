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

Namespace DotNetNuke.Modules.Chat

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The Settings class manages Module Settings
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class Settings
        Inherits Entities.Modules.ModuleSettingsBase

#Region "Base Method Implementations"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' LoadSettings loads the settings from the Database and displays them
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Overrides Sub LoadSettings()
            Try
                If (Page.IsPostBack = False) Then
                    txtHistoryCapacity.Text = GetSetting(Of Integer)("dnnChat_History", 500)
                    txtDisplayCapacity.Text = GetSetting(Of Integer)("dnnChat_DisplayCapacity", 100)
                    txtHeight.Text = GetSetting(Of String)("dnnChat_Height", "200px")
                    txtEnteredMessage.Text = GetSetting(Of String)("dnnChat_EnteredMessage", "[entered]")
                    txtExitedMessage.Text = GetSetting(Of String)("dnnChat_ExitedMessage", "[left]")
                    txtMessageCssClass.Text = GetSetting(Of String)("dnnChat_MessageCssClass", "Normal")
                    txtSenderCssClass.Text = GetSetting(Of String)("dnnChat_SenderCssClass", "NormalBold")
                    txtPollingInterval.Text = GetSetting(Of String)("dnnChat_PollingInterval", 2000)
                    txtSenderText.Text = GetSetting(Of String)("dnnChat_SenderText", "{0} says:")
                    chkAllowFormatting.Checked = GetSetting(Of Boolean)("dnnChat_AllowFormatting", True)
                End If
            Catch exc As Exception           'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' UpdateSettings saves the modified settings to the Database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Overrides Sub UpdateSettings()
            Try
                If Page.IsValid Then
                    ' Non-SuperUsers can change TabModuleSettings (display settings)
                    Dim objModuleController As New DotNetNuke.Entities.Modules.ModuleController
                    Dim objSecurity As New PortalSecurity
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_History", Convert.ToInt32(txtHistoryCapacity.Text))
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_DisplayCapacity", Convert.ToInt32(txtDisplayCapacity.Text))
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_Height", txtHeight.Text)
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_EnteredMessage", _
                        objSecurity.InputFilter(txtEnteredMessage.Text, PortalSecurity.FilterFlag.NoScripting))
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_ExitedMessage", _
                        objSecurity.InputFilter(txtExitedMessage.Text, PortalSecurity.FilterFlag.NoScripting))
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_MessageCssClass", txtMessageCssClass.Text)
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_SenderCssClass", txtSenderCssClass.Text)
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_PollingInterval", txtPollingInterval.Text)
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_SenderText", txtSenderText.Text)
                    objModuleController.UpdateModuleSetting(ModuleId, "dnnChat_AllowFormatting", chkAllowFormatting.Checked)

                    ' refresh cache
                    DotNetNuke.Entities.Modules.ModuleController.SynchronizeModule(ModuleId)
                End If
            Catch exc As Exception           'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

#End Region

        Protected Function GetSetting(Of TSetting)(ByVal strSetting As String, ByVal defaultValue As TSetting) As TSetting
            Dim obj As Object = Me.Settings.Item(strSetting)
            If obj Is Nothing Then
                Return defaultValue
            Else
                Return Convert.ChangeType(obj, GetType(TSetting))
            End If
        End Function

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
            'Temporarily run initpermissions from here
            'TODO: Remove before release
            Chat.Security.InitPermissions()
        End Sub
    End Class

End Namespace

