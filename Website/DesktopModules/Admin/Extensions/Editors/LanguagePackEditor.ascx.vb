'
' DotNetNuke® - http://www.dotnetnuke.com
' Copyright (c) 2002-2008
' by DotNetNuke Corporation
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

Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Services.Localization
Imports DotNetNuke.Services.Installer.Packages
Imports DotNetNuke.UI.WebControls
Imports System.Collections.Generic

Namespace DotNetNuke.Modules.Admin.Features

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The LanguagePackEditor ModuleUserControlBase is used to edit a Language
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cnurse]	02/14/2008  created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class LanguagePackEditor
        Inherits PackageEditorBase

#Region "Private Methods"

        Private _LanguagesModule As ModuleInfo = Nothing
        Private _LanguagePack As LanguagePackInfo = Nothing

#End Region

#Region "Protected Properties"

        Protected Overrides ReadOnly Property EditorID() As String
            Get
                Return "LanguagePackEditor"
            End Get
        End Property

        Protected ReadOnly Property Language() As Locale
            Get
                Return Localization.GetLocaleByID(LanguagePack.LanguageID)
            End Get
        End Property

        Protected ReadOnly Property LanguagePack() As LanguagePackInfo
            Get
                If _LanguagePack Is Nothing Then
                    _LanguagePack = LanguagePackController.GetLanguagePackByPackage(PackageID)
                End If
                Return _LanguagePack
            End Get
        End Property

#End Region

#Region "Private Methods"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This routine Binds the Language
        ''' </summary>
        ''' <history>
        ''' 	[cnurse]	02/14/2008  created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub BindLanguage()
            If Not Me.ModuleContext.PortalSettings.ActiveTab.IsSuperTab Then
                ctlLanguage.EditMode = UI.WebControls.PropertyEditorMode.View
                pnlHelp.Visible = False
                Dim enabledLanguages As Dictionary(Of String, Locale) = Localization.GetLocales(Me.ModuleContext.PortalId)
                Dim enabledLanguage As Locale = Nothing
                chkEnabled.Checked = enabledLanguages.TryGetValue(Language.Code, enabledLanguage)
                cmdUpdate.Visible = True
                trEnabled.Visible = True
            Else
                trEnabled.Visible = False
            End If

            If Language IsNot Nothing Then
                ctlLanguage.LocalResourceFile = LocalResourceFile
                ctlLanguage.DataSource = Language
                ctlLanguage.DataBind()

                Dim attributes(-1) As Object
                ReDim attributes(0)
                attributes(0) = New LanguagesListTypeAttribute(LanguagesListType.All)
                fldCode.Editor.CustomAttributes = attributes
                fldFallback.Editor.CustomAttributes = attributes
            End If
        End Sub

        Private Sub BindLanguagePack()
            If LanguagePack IsNot Nothing Then
                If LanguagePack.PackageType = LanguagePackType.Core Then
                    BindLanguage()
                    trCoreLanguage.Visible = True
                    trPackageLanguage.Visible = False
                    trPackage.Visible = False
                Else
                    trEnabled.Visible = False
                    trCoreLanguage.Visible = False

                    cboLanguage.DataSource = Localization.GetLocales(Null.NullInteger).Values
                    cboLanguage.DataBind()

                    'Get all the packages but only bind to combo if not a language package
                    Dim packages As List(Of PackageInfo) = New List(Of PackageInfo)
                    For Each package As PackageInfo In PackageController.GetPackages()
                        If package.PackageType <> "CoreLanguagePack" AndAlso package.PackageType <> "ExtensionLanguagePack" Then
                            packages.Add(package)
                        End If
                    Next
                    cboPackage.DataSource = packages
                    cboPackage.DataBind()

                    If cboLanguage.Items.FindByValue(LanguagePack.LanguageID) IsNot Nothing Then
                        cboLanguage.Items.FindByValue(LanguagePack.LanguageID).Selected = True
                    End If
                    If cboPackage.Items.FindByValue(LanguagePack.DependentPackageID) IsNot Nothing Then
                        cboPackage.Items.FindByValue(LanguagePack.DependentPackageID).Selected = True
                    End If

                    trPackageLanguage.Visible = True
                    trPackage.Visible = True
                End If
            End If
        End Sub

#End Region

        Protected Overrides Sub OnPreRender(ByVal e As System.EventArgs)
            MyBase.OnPreRender(e)

            If (Not IsWizard) AndAlso (fldCode.Editor IsNot Nothing) Then
                fldCode.Editor.EditMode = UI.WebControls.PropertyEditorMode.View
            End If
            pnlHelp.Visible = Not IsWizard
            cmdUpdate.Visible = Not IsWizard
            cmdEdit.Visible = Not IsWizard
        End Sub

#Region "Public Methods"

        Public Overrides Sub Initialize()
            BindLanguagePack()
        End Sub

        Public Overrides Sub UpdatePackage()
            If LanguagePack.PackageType = LanguagePackType.Core Then
                'Update Language
                If ctlLanguage.IsValid AndAlso ctlLanguage.IsDirty Then
                    Dim language As Locale = TryCast(ctlLanguage.DataSource, Locale)
                    If language IsNot Nothing Then
                        language.Text = CultureInfo.CreateSpecificCulture(language.Code).NativeName
                        Localization.SaveLanguage(language)
                    End If
                End If
            Else
                LanguagePack.LanguageID = Integer.Parse(cboLanguage.SelectedValue)
                LanguagePack.DependentPackageID = Integer.Parse(cboPackage.SelectedValue)
            End If

            LanguagePackController.SaveLanguagePack(LanguagePack)
        End Sub

#End Region

#Region "Event Handlers"

        Protected Sub cmdEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
            Response.Redirect(ModuleContext.EditUrl("Locale", Language.Code, "EditLanguage", "PackageID=" + PackageID.ToString()), True)
        End Sub

        Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
            If ModuleContext.PortalSettings.ActiveTab.IsSuperTab Then
                UpdatePackage()
            End If
            If chkEnabled.Checked Then
                Dim enabledLanguages As Dictionary(Of String, Locale) = Localization.GetLocales(Me.ModuleContext.PortalId)
                Dim enabledLanguage As Locale = Nothing
                If Not enabledLanguages.TryGetValue(Language.Code, enabledLanguage) Then
                    'Add language to portal
                    Localization.AddLanguageToPortal(Me.ModuleContext.PortalId, Language.LanguageID, True)
                End If
            Else
                'remove language from portal
                Localization.RemoveLanguageFromPortal(Me.ModuleContext.PortalId, Language.LanguageID)
            End If
        End Sub

#End Region

    End Class

End Namespace