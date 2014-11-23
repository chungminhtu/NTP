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

Imports System.Collections.Generic

Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Entities.Tabs
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.Entities.Portals.PortalSettings

Namespace DotNetNuke.UI.ControlPanels

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The IconBar ControlPanel provides an icon bar based Page/Module manager
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cnurse]	10/06/2004	Updated to reflect design changes for Help, 508 support
    '''                       and localisation
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class IconBar
        Inherits ControlPanelBase

#Region "Private Methods"

        Private Sub BindData()
            Select Case optModuleType.SelectedItem.Value
                Case "0" ' new module
                    cboTabs.Visible = False
                    cboModules.Visible = False
                    cboDesktopModules.Visible = True
                    txtTitle.Visible = True
                    lblModule.Text = Localization.GetString("Module", LocalResourceFile)
                    lblTitle.Text = Localization.GetString("Title", LocalResourceFile)
                    cboPermission.Enabled = True

                    cboDesktopModules.DataSource = DesktopModuleController.GetPortalDesktopModules(PortalSettings.PortalId).Values
                    cboDesktopModules.DataBind()
                    cboDesktopModules.Items.Insert(0, New ListItem("<" + Localization.GetString("SelectModule", LocalResourceFile) + ">", "-1"))
                Case "1" ' existing module
                    cboTabs.Visible = True
                    cboModules.Visible = True
                    cboDesktopModules.Visible = False
                    txtTitle.Visible = False
                    lblModule.Text = Localization.GetString("Tab", LocalResourceFile)
                    lblTitle.Text = Localization.GetString("Module", LocalResourceFile)
                    cboPermission.Enabled = False

                    cboTabs.DataSource = TabController.GetPortalTabs(PortalSettings.PortalId, PortalSettings.ActiveTab.TabID, True, "<" & Localization.GetString("SelectPage", LocalResourceFile) & ">", True, False, False, False, True)
                    cboTabs.DataBind()
            End Select

        End Sub

        Private Sub SetMode(ByVal Update As Boolean)
            If Update Then
                SetUserMode(optMode.SelectedValue)
            End If

            If Not PortalSecurity.IsPageAdmin() Then
                optMode.Items.Remove(optMode.Items.FindByValue("LAYOUT"))
            End If

            Select Case UserMode
                Case Mode.View
                    optMode.Items.FindByValue("VIEW").Selected = True
                Case Mode.Edit
                    optMode.Items.FindByValue("EDIT").Selected = True
                Case Mode.Layout
                    optMode.Items.FindByValue("LAYOUT").Selected = True
            End Select
        End Sub

        Private Sub SetVisibility(ByVal Toggle As Boolean)
            If Toggle Then
                SetVisibleMode(Not IsVisible)
            End If

        End Sub

#End Region

#Region "Event Handlers"

        Protected Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
            Me.ID = "IconBar.ascx"
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/06/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Protected Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                ' localization
                lblMode.Text = Localization.GetString("Mode", LocalResourceFile)
                lblPageFunctions.Text = Localization.GetString("PageFunctions", LocalResourceFile)
                lblCommonTasks.Text = Localization.GetString("CommonTasks", LocalResourceFile)
                imgAddTabIcon.AlternateText = Localization.GetString("AddTab.AlternateText", LocalResourceFile)
                cmdAddTab.Text = Localization.GetString("AddTab", LocalResourceFile)
                imgEditTabIcon.AlternateText = Localization.GetString("EditTab.AlternateText", LocalResourceFile)
                cmdEditTab.Text = Localization.GetString("EditTab", LocalResourceFile)
                imgDeleteTabIcon.AlternateText = Localization.GetString("DeleteTab.AlternateText", LocalResourceFile)
                cmdDeleteTab.Text = Localization.GetString("DeleteTab", LocalResourceFile)
                imgCopyTabIcon.AlternateText = Localization.GetString("CopyTab.AlternateText", LocalResourceFile)
                cmdCopyTab.Text = Localization.GetString("CopyTab", LocalResourceFile)
                imgExportTabIcon.AlternateText = Localization.GetString("ExportTab.AlternateText", LocalResourceFile)
                cmdExportTab.Text = Localization.GetString("ExportTab", LocalResourceFile)
                imgImportTabIcon.AlternateText = Localization.GetString("ImportTab.AlternateText", LocalResourceFile)
                cmdImportTab.Text = Localization.GetString("ImportTab", LocalResourceFile)
                lblModule.Text = Localization.GetString("Module", LocalResourceFile)
                lblPane.Text = Localization.GetString("Pane", LocalResourceFile)
                lblTitle.Text = Localization.GetString("Title", LocalResourceFile)
                lblAlign.Text = Localization.GetString("Align", LocalResourceFile)
                imgAddModuleIcon.AlternateText = Localization.GetString("AddModule.AlternateText", LocalResourceFile)
                cmdAddModule.Text = Localization.GetString("AddModule", LocalResourceFile)
                cmdInstallModules.Text = Localization.GetString("InstallModules", LocalResourceFile)
                imgSiteIcon.AlternateText = Localization.GetString("Site.AlternateText", LocalResourceFile)
                cmdSite.Text = Localization.GetString("Site", LocalResourceFile)
                imgUsersIcon.AlternateText = Localization.GetString("Users.AlternateText", LocalResourceFile)
                cmdUsers.Text = Localization.GetString("Users", LocalResourceFile)
                imgRolesIcon.AlternateText = Localization.GetString("Roles.AlternateText", LocalResourceFile)
                cmdRoles.Text = Localization.GetString("Roles", LocalResourceFile)
                imgFilesIcon.AlternateText = Localization.GetString("Files.AlternateText", LocalResourceFile)
                cmdFiles.Text = Localization.GetString("Files", LocalResourceFile)
                imgHelpIcon.AlternateText = Localization.GetString("Help.AlternateText", LocalResourceFile)
                cmdHelp.Text = Localization.GetString("Help", LocalResourceFile)
                imgSolutionsIcon.AlternateText = Localization.GetString("Solutions.AlternateText", LocalResourceFile)
                cmdSolutions.Text = Localization.GetString("Solutions", LocalResourceFile)

                ClientAPI.AddButtonConfirm(cmdDeleteTab, Localization.GetString("DeleteTabConfirm", LocalResourceFile))
                ClientAPI.AddButtonConfirm(cmdDeleteTabIcon, Localization.GetString("DeleteTabConfirm", LocalResourceFile))

                If IsAdminControl() Then
                    cmdAddModule.Enabled = False
                    imgAddModuleIcon.ImageUrl = "~/Admin/ControlPanel/images/iconbar_addmodule_bw.gif"
                    cmdAddModuleIcon.Enabled = False
                End If

                If Not Page.IsPostBack Then

                    optModuleType.Items.FindByValue("0").Selected = True

                    If GetModulePermission(PortalSettings.PortalId, "Site Settings") = False Then
                        imgSiteIcon.ImageUrl = "~/Admin/ControlPanel/images/iconbar_site_bw.gif"
                        cmdSite.Enabled = False
                        cmdSiteIcon.Enabled = False
                    End If
                    If GetModulePermission(PortalSettings.PortalId, "User Accounts") = False Then
                        imgUsersIcon.ImageUrl = "~/Admin/ControlPanel/images/iconbar_users_bw.gif"
                        cmdUsers.Enabled = False
                        cmdUsersIcon.Enabled = False
                    End If
                    If GetModulePermission(PortalSettings.PortalId, "Security Roles") = False Then
                        imgRolesIcon.ImageUrl = "~/Admin/ControlPanel/images/iconbar_roles_bw.gif"
                        cmdRoles.Enabled = False
                        cmdRolesIcon.Enabled = False
                    End If
                    If GetModulePermission(PortalSettings.PortalId, "File Manager") = False Then
                        imgFilesIcon.ImageUrl = "~/Admin/ControlPanel/images/iconbar_files_bw.gif"
                        cmdFiles.Enabled = False
                        cmdFilesIcon.Enabled = False
                    End If
                    If GetModulePermission(PortalSettings.PortalId, "Solutions") = False Then
                        imgSolutionsIcon.ImageUrl = "~/Admin/ControlPanel/images/iconbar_solutions_bw.gif"
                        cmdSolutions.Enabled = False
                        cmdSolutionsIcon.Enabled = False
                    End If

                    Dim objUser As UserInfo = UserController.GetCurrentUserInfo
                    If Not objUser Is Nothing Then
                        If objUser.IsSuperUser Then
                            hypUpgrade.ImageUrl = Upgrade.Upgrade.UpgradeIndicator(ApplicationVersion, Request.IsLocal, Request.IsSecureConnection)
                            If hypUpgrade.ImageUrl <> "" Then
                                hypUpgrade.ToolTip = Localization.GetString("hypUpgrade.Text", LocalResourceFile)
                                hypUpgrade.NavigateUrl = Upgrade.Upgrade.UpgradeRedirect()
                                hypUpgrade.Visible = True
                            End If
                            cmdInstallModules.Visible = True
                        End If
                    End If

                    BindData()

                    Dim intItem As Integer
                    For intItem = 0 To PortalSettings.ActiveTab.Panes.Count - 1
                        cboPanes.Items.Add(Convert.ToString(PortalSettings.ActiveTab.Panes(intItem)))
                    Next intItem
                    If Not cboPanes.Items.FindByValue(glbDefaultPane) Is Nothing Then
                        cboPanes.Items.FindByValue(glbDefaultPane).Selected = True
                    End If

                    If cboPermission.Items.Count > 0 Then
                        cboPermission.SelectedIndex = 0 ' view
                    End If

                    If cboAlign.Items.Count > 0 Then
                        cboAlign.SelectedIndex = 0 ' left
                    End If

                    If cboPosition.Items.Count > 0 Then
                        cboPosition.SelectedIndex = 1 ' bottom
                    End If

                    If Convert.ToString(PortalSettings.HostSettings("HelpURL")) <> "" Then
                        cmdHelp.NavigateUrl = FormatHelpUrl(Convert.ToString(PortalSettings.HostSettings("HelpURL")), PortalSettings, "")
                        cmdHelpIcon.NavigateUrl = cmdHelp.NavigateUrl
                        cmdHelp.Enabled = True
                        cmdHelpIcon.Enabled = True
                    Else
                        cmdHelp.Enabled = False
                        cmdHelpIcon.Enabled = False
                    End If

                    SetMode(False)
                    SetVisibility(False)

                    If Not PortalSecurity.IsPageAdmin() Then
                        lblVisibility.Visible = False
                        cmdVisibility.Visible = False
                        rowControlPanel.Visible = False
                    End If
                End If

                jQuery.RequestRegistration()

                Dim script As String = String.Format(glbScriptFormat, ResolveUrl("~/Resources/ControlPanel/ControlPanel.js"))
                ClientAPI.RegisterClientScriptBlock(Page, "controlPanel", script)

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            DotNetNuke.UI.Utilities.DNNClientAPI.EnableMinMax(imgVisibility, rowControlPanel, Not IsVisible, Common.Globals.ApplicationPath & "/images/collapse.gif", _
                Common.Globals.ApplicationPath & "/images/expand.gif", DNNClientAPI.MinMaxPersistanceType.Personalization, "Usability", "ControlPanelVisible" & Me.PortalSettings.PortalId.ToString)
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' PageFunctions_Click runs when any button in the Page toolbar is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/06/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub PageFunctions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAddTab.Click, cmdAddTabIcon.Click, cmdEditTab.Click, cmdEditTabIcon.Click, cmdDeleteTab.Click, cmdDeleteTabIcon.Click, cmdCopyTab.Click, cmdCopyTabIcon.Click, cmdExportTab.Click, cmdExportTabIcon.Click, cmdImportTab.Click, cmdImportTabIcon.Click
            Try
                Dim URL As String = Request.RawUrl
                Select Case CType(sender, LinkButton).ID
                    Case "cmdAddTab", "cmdAddTabIcon"
                        URL = NavigateURL("Tab")
                    Case "cmdEditTab", "cmdEditTabIcon"
                        URL = NavigateURL(PortalSettings.ActiveTab.TabID, "Tab", "action=edit")
                    Case "cmdDeleteTab", "cmdDeleteTabIcon"
                        URL = NavigateURL(PortalSettings.ActiveTab.TabID, "Tab", "action=delete")
                    Case "cmdCopyTab", "cmdCopyTabIcon"
                        URL = NavigateURL(PortalSettings.ActiveTab.TabID, "Tab", "action=copy")
                    Case "cmdExportTab", "cmdExportTabIcon"
                        URL = NavigateURL(PortalSettings.ActiveTab.TabID, "ExportTab")
                    Case "cmdImportTab", "cmdImportTabIcon"
                        URL = NavigateURL(PortalSettings.ActiveTab.TabID, "ImportTab")
                End Select
                Response.Redirect(URL, True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' CommonTasks_Click runs when any button in the Common Tasks toolbar is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/06/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub CommonTasks_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSite.Click, cmdSiteIcon.Click, cmdUsers.Click, cmdUsersIcon.Click, cmdRoles.Click, cmdRolesIcon.Click, cmdFiles.Click, cmdFilesIcon.Click, cmdSolutions.Click, cmdSolutionsIcon.Click
            Try
                Dim URL As String = Request.RawUrl
                Select Case CType(sender, LinkButton).ID
                    Case "cmdSite", "cmdSiteIcon"
                        URL = BuildURL(PortalSettings.PortalId, "Site Settings")
                    Case "cmdUsers", "cmdUsersIcon"
                        URL = BuildURL(PortalSettings.PortalId, "User Accounts")
                    Case "cmdRoles", "cmdRolesIcon"
                        URL = BuildURL(PortalSettings.PortalId, "Security Roles")
                    Case "cmdFiles", "cmdFilesIcon"
                        URL = BuildURL(PortalSettings.PortalId, "File Manager")
                    Case "cmdSolutions", "cmdSolutionsIcon"
                        URL = BuildURL(PortalSettings.PortalId, "Solutions")
                End Select

                Response.Redirect(URL, True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' AddModule_Click runs when the Add Module Icon or text button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/06/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        '''     [vmasanas]  01/07/2005  Modified to add view perm. to all roles with edit perm.
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub AddModule_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAddModule.Click, cmdAddModuleIcon.Click
            Try
                If PortalSecurity.IsPageAdmin() Then
                    Dim title As String = txtTitle.Text
                    Dim permissionType As ViewPermissionType = ViewPermissionType.View
                    Dim position As Integer = Null.NullInteger
                    If Not cboPosition.SelectedItem Is Nothing Then
                        position = Integer.Parse(cboPosition.SelectedItem.Value)
                    End If
                    If Not cboPermission.SelectedItem Is Nothing Then
                        permissionType = CType(cboPermission.SelectedItem.Value, ViewPermissionType)
                    End If

                    Select Case optModuleType.SelectedItem.Value
                        Case "0" ' new module
                            If cboDesktopModules.SelectedIndex > 0 Then
                                AddNewModule(title, Integer.Parse(cboDesktopModules.SelectedItem.Value), cboPanes.SelectedItem.Text, position, permissionType, cboAlign.SelectedItem.Value)

                                ' Redirect to the same page to pick up changes
                                Response.Redirect(Request.RawUrl, True)
                            End If
                        Case "1" ' existing module
                            If Not cboModules.SelectedItem Is Nothing Then
                                AddExistingModule(Integer.Parse(cboModules.SelectedItem.Value), Integer.Parse(cboTabs.SelectedItem.Value), cboPanes.SelectedItem.Text, position, cboAlign.SelectedItem.Value)

                                ' Redirect to the same page to pick up changes
                                Response.Redirect(Request.RawUrl, True)
                            End If
                    End Select
                End If

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Private Sub optModuleType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optModuleType.SelectedIndexChanged
            BindData()
        End Sub

        Private Sub cboTabs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTabs.SelectedIndexChanged
            Dim objModules As New ModuleController
            Dim arrModules As New ArrayList

            Dim objModule As ModuleInfo
            Dim arrPortalModules As Dictionary(Of Integer, ModuleInfo) = objModules.GetTabModules(Integer.Parse(cboTabs.SelectedItem.Value))
            For Each kvp As KeyValuePair(Of Integer, ModuleInfo) In arrPortalModules
                objModule = kvp.Value
                If PortalSecurity.IsInRoles(objModule.AuthorizedEditRoles) = True And objModule.IsDeleted = False Then
                    arrModules.Add(objModule)
                End If
            Next

            lblModule.Text = Localization.GetString("Tab", LocalResourceFile)
            lblTitle.Text = Localization.GetString("Module", LocalResourceFile)

            cboModules.DataSource = arrModules
            cboModules.DataBind()
        End Sub

        Protected Sub cmdInstallModules_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdInstallModules.Click
            Dim URL As String = "~/" & glbDefaultPage

            Dim objModules As New ModuleController
            Dim objModule As ModuleInfo = objModules.GetModuleByDefinition(Null.NullInteger, "Extensions")
            If Not objModule Is Nothing Then
                URL = NavigateURL(objModule.TabID, "BatchInstall", "mid=" & objModule.ModuleID.ToString())
            End If

            Response.Redirect(URL, True)
        End Sub

        Protected Sub cmdVisibility_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVisibility.Click
            SetVisibility(True)
            Response.Redirect(Request.RawUrl, True)
        End Sub

        Protected Sub optMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optMode.SelectedIndexChanged
            If Not Page.IsCallback Then
                SetMode(True)
                Response.Redirect(Request.RawUrl, True)
            End If
        End Sub

#End Region

    End Class

End Namespace
