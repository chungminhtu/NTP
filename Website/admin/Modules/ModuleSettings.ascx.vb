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

Imports DotNetNuke.UI.Skins
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Entities.Modules.Definitions
Imports DotNetNuke.UI.Modules
Imports System.Collections.Generic


Namespace DotNetNuke.Modules.Admin.Modules

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ModuleSettingsPage PortalModuleBase is used to edit the settings for a 
    ''' module.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cnurse]	10/18/2004	documented
    ''' 	[cnurse]	10/19/2004	modified to support custm module specific settings
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ModuleSettingsPage
        Inherits DotNetNuke.Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private _Control As Control
        Private Shadows ModuleId As Integer = -1
        Private Shadows TabModuleId As Integer = -1
        Private _Module As ModuleInfo

#End Region

        Protected ReadOnly Property [Module]() As ModuleInfo
            Get
                If _Module Is Nothing Then
                    _Module = New ModuleController().GetModule(ModuleId, TabId, False)
                End If
                Return _Module
            End Get
        End Property

        Protected ReadOnly Property SettingsControl() As ISettingsControl
            Get
                Return TryCast(_Control, ISettingsControl)
            End Get
        End Property

#Region "Private Methods"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' BindData loads the settings from the Database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/18/2004	documented
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub BindData()
            If Not [Module] Is Nothing Then
                ' configure grid
                Dim objDeskMod As New DesktopModuleController
                Dim desktopModule As DesktopModuleInfo = DesktopModuleController.GetDesktopModule([Module].DesktopModuleID, PortalId)
                dgPermissions.ResourceFile = Common.Globals.ApplicationPath + "/DesktopModules/" + desktopModule.FolderName + "/" + Localization.LocalResourceDirectory + "/" + Localization.LocalSharedResourceFile

                chkInheritPermissions.Checked = [Module].InheritViewPermissions
                dgPermissions.InheritViewPermissionsFromTab = [Module].InheritViewPermissions

                txtFriendlyName.Text = [Module].DesktopModule.FriendlyName
                txtTitle.Text = [Module].ModuleTitle
                ctlIcon.Url = [Module].IconFile

                If Not cboTab.Items.FindByValue([Module].TabID.ToString) Is Nothing Then
                    cboTab.Items.FindByValue([Module].TabID.ToString).Selected = True
                    lblTab.Text = cboTab.SelectedItem.Text
                End If
                If cboTab.Items.Count = 1 Then
                    cboTab.Visible = False
                    lblTab.Visible = True
                Else
                    cboTab.Visible = True
                    lblTab.Visible = False
                End If

                chkAllTabs.Checked = [Module].AllTabs
                cboVisibility.SelectedIndex = [Module].Visibility

                Dim objModuleDef As ModuleDefinitionInfo = ModuleDefinitionController.GetModuleDefinitionByID([Module].ModuleDefID)
                If objModuleDef.DefaultCacheTime = Null.NullInteger Then
                    rowCache.Visible = False
                Else
                    txtCacheTime.Text = [Module].CacheTime.ToString
                End If

                cboAlign.Items.FindByValue([Module].Alignment).Selected = True
                txtColor.Text = [Module].Color
                txtBorder.Text = [Module].Border

                txtHeader.Text = [Module].Header
                txtFooter.Text = [Module].Footer

                If Not Null.IsNull([Module].StartDate) Then
                    txtStartDate.Text = [Module].StartDate.ToShortDateString
                End If
                If Not Null.IsNull([Module].EndDate) Then
                    txtEndDate.Text = [Module].EndDate.ToShortDateString
                End If

                ctlModuleContainer.Width = "250px"
                ctlModuleContainer.SkinRoot = SkinController.RootContainer
                ctlModuleContainer.SkinSrc = [Module].ContainerSrc

                chkDisplayTitle.Checked = [Module].DisplayTitle
                chkDisplayPrint.Checked = [Module].DisplayPrint
                chkDisplaySyndicate.Checked = [Module].DisplaySyndicate
                chkWebSlice.Checked = [Module].IsWebSlice
                tblWebSlice.Visible = [Module].IsWebSlice
                txtWebSliceTitle.Text = [Module].WebSliceTitle
                If Not Null.IsNull([Module].WebSliceExpiryDate) Then
                    txtWebSliceExpiry.Text = [Module].WebSliceExpiryDate.ToShortDateString
                End If
                If Not Null.IsNull([Module].WebSliceTTL) Then
                    txtWebSliceTTL.Text = [Module].WebSliceTTL
                End If

                If [Module].ModuleID = PortalSettings.Current.DefaultModuleId AndAlso [Module].TabID = PortalSettings.Current.DefaultTabId Then
                    chkDefault.Checked = True
                End If
            End If
        End Sub

#End Region

#Region "Event Handlers"

        Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
            Dim objModules As New ModuleController
            Dim objModuleControlInfo As ModuleControlInfo
            Dim arrModuleControls As New ArrayList

            ' get ModuleId
            If Not (Request.QueryString("ModuleId") Is Nothing) Then
                ModuleId = Int32.Parse(Request.QueryString("ModuleId"))
            End If

            ' get module
            If Not [Module] Is Nothing Then
                TabModuleId = [Module].TabModuleID

                'get Settings Control
                objModuleControlInfo = ModuleControlController.GetModuleControlByControlKey("Settings", [Module].ModuleDefID)

                If objModuleControlInfo IsNot Nothing Then
                    _Control = ControlUtilites.LoadControl(Of Control)(Me.Page, objModuleControlInfo.ControlSrc)

                    Dim SettingsControl As ISettingsControl = TryCast(_Control, ISettingsControl)
                    If SettingsControl IsNot Nothing Then
                        'Set ID
                        _Control.ID = System.IO.Path.GetFileNameWithoutExtension(objModuleControlInfo.ControlSrc).Replace("."c, "-"c)

                        ' add module settings
                        SettingsControl.ModuleContext.Configuration = [Module]

                        dshSpecific.Text = Localization.LocalizeControlTitle(SettingsControl)
                        pnlSpecific.Controls.Add(_Control)

                        If Localization.GetString(Entities.Modules.Actions.ModuleActionType.HelpText, SettingsControl.LocalResourceFile) <> "" Then
                            rowspecifichelp.Visible = True
                            imgSpecificHelp.AlternateText = Localization.GetString(Entities.Modules.Actions.ModuleActionType.ModuleHelp, Localization.GlobalResourceFile)
                            lnkSpecificHelp.Text = Localization.GetString(Entities.Modules.Actions.ModuleActionType.ModuleHelp, Localization.GlobalResourceFile)
                            lnkSpecificHelp.NavigateUrl = NavigateURL(TabId, "Help", "ctlid=" & objModuleControlInfo.ModuleControlID.ToString, "moduleid=" & ModuleId)
                        Else
                            rowspecifichelp.Visible = False
                        End If
                    End If
                End If
            End If
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/18/2004	documented
        ''' 	[cnurse]	10/19/2004	modified to support custm module specific settings
        '''     [vmasanas]  11/28/2004  modified to support modules in admin tabs
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                ' Verify that the current user has access to edit this module
                If Not PortalSecurity.IsPageAdmin() Then
                    Response.Redirect(NavigateURL("Access Denied"), True)
                End If

                'this needs to execute always to the client script code is registred in InvokePopupCal
                cmdStartCalendar.NavigateUrl = Common.Utilities.Calendar.InvokePopupCal(txtStartDate)
                cmdEndCalendar.NavigateUrl = Common.Utilities.Calendar.InvokePopupCal(txtEndDate)
                cmdWebSliceExpiry.NavigateUrl = Common.Utilities.Calendar.InvokePopupCal(txtWebSliceExpiry)

                If Page.IsPostBack = False Then
                    ctlIcon.FileFilter = glbImageFileTypes

                    dgPermissions.TabId = PortalSettings.ActiveTab.TabID
                    dgPermissions.ModuleID = ModuleId

                    DotNetNuke.UI.Utilities.ClientAPI.AddButtonConfirm(cmdDelete, Localization.GetString("DeleteItem"))

                    cboTab.DataSource = TabController.GetPortalTabs(PortalId, -1, False, Null.NullString, True, False, True, False, True)
                    cboTab.DataBind()
                    'if is and admin or host tab, then add current tab
                    If PortalSettings.ActiveTab.ParentId = PortalSettings.SuperTabId Then
                        cboTab.Items.Insert(0, New ListItem(PortalSettings.ActiveTab.LocalizedTabName, PortalSettings.ActiveTab.TabID.ToString))
                    End If

                    ' tab administrators can only manage their own tab
                    If Not PortalSecurity.IsPageAdmin() Then
                        chkAllTabs.Enabled = False
                        chkDefault.Enabled = False
                        chkAllModules.Enabled = False
                        cboTab.Enabled = False
                    End If

                    If ModuleId <> -1 Then
                        BindData()
                    Else
                        cboVisibility.SelectedIndex = 0       ' maximized
                        chkAllTabs.Checked = False
                        cmdDelete.Visible = False
                    End If

                    'Set visibility of Specific Settings
                    If SettingsControl Is Nothing = False Then
                        'Get the module settings from the PortalSettings and pass the
                        'two settings hashtables to the sub control to process
                        SettingsControl.LoadSettings()
                        dshSpecific.Visible = True
                        tblSpecific.Visible = True
                    Else
                        dshSpecific.Visible = False
                        tblSpecific.Visible = False
                    End If

                End If

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub chkAllTabs_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllTabs.CheckedChanged
            If (Not [Module].AllTabs = chkAllTabs.Checked) Then
                trnewPages.Visible = chkAllTabs.Checked
            End If
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' chkInheritPermissions_CheckedChanged runs when the Inherit View Permissions
        '''	check box is changed
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/18/2004	documented
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub chkInheritPermissions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInheritPermissions.CheckedChanged
            If chkInheritPermissions.Checked Then
                dgPermissions.InheritViewPermissionsFromTab = True
            Else
                dgPermissions.InheritViewPermissionsFromTab = False
            End If
        End Sub

        Protected Sub chkWebSlice_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkWebSlice.CheckedChanged
            tblWebSlice.Visible = chkWebSlice.Checked
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdCancel_Click runs when the Cancel LinkButton is clicked.  It returns the user
        ''' to the referring page
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/18/2004	documented
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Try
                Response.Redirect(NavigateURL(), True)

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdDelete_Click runs when the Delete LinkButton is clicked.
        ''' It deletes the current portal form the Database.  It can only run in Host
        ''' (SuperUser) mode
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/18/2004	documented
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            Try
                Dim objModules As New ModuleController
                objModules.DeleteTabModule(TabId, ModuleId)
                Response.Redirect(NavigateURL(), True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdUpdate_Click runs when the Update LinkButton is clicked.
        ''' It saves the current Site Settings
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	10/18/2004	documented
        ''' 	[cnurse]	10/19/2004	modified to support custm module specific settings
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdUpdate_Click(ByVal Sender As Object, ByVal e As EventArgs) Handles cmdUpdate.Click
            Try
                If Page.IsValid Then
                    Dim objModules As New ModuleController
                    Dim AllTabsChanged As Boolean = False

                    ' tab administrators can only manage their own tab
                    If Not PortalSecurity.IsPageAdmin() Then
                        chkAllTabs.Enabled = False
                        chkDefault.Enabled = False
                        chkAllModules.Enabled = False
                        cboTab.Enabled = False
                    End If

                    ' update module
                    Dim objModule As ModuleInfo = objModules.GetModule(ModuleId, TabId, False)

                    objModule.ModuleID = ModuleId
                    objModule.ModuleTitle = txtTitle.Text
                    objModule.Alignment = cboAlign.SelectedItem.Value
                    objModule.Color = txtColor.Text
                    objModule.Border = txtBorder.Text
                    objModule.IconFile = ctlIcon.Url
                    If txtCacheTime.Text <> "" Then
                        objModule.CacheTime = Int32.Parse(txtCacheTime.Text)
                    Else
                        objModule.CacheTime = 0
                    End If
                    objModule.TabID = TabId
                    If Not objModule.AllTabs = chkAllTabs.Checked Then
                        AllTabsChanged = True
                    End If
                    objModule.AllTabs = chkAllTabs.Checked
                    Select Case Int32.Parse(cboVisibility.SelectedItem.Value)
                        Case 0 : objModule.Visibility = VisibilityState.Maximized
                        Case 1 : objModule.Visibility = VisibilityState.Minimized
                        Case 2 : objModule.Visibility = VisibilityState.None
                    End Select
                    objModule.IsDeleted = False
                    objModule.Header = txtHeader.Text
                    objModule.Footer = txtFooter.Text
                    If Not String.IsNullOrEmpty(txtStartDate.Text) Then
                        objModule.StartDate = Convert.ToDateTime(txtStartDate.Text)
                    Else
                        objModule.StartDate = Null.NullDate
                    End If
                    If Not String.IsNullOrEmpty(txtEndDate.Text) Then
                        objModule.EndDate = Convert.ToDateTime(txtEndDate.Text)
                    Else
                        objModule.EndDate = Null.NullDate
                    End If
                    objModule.ContainerSrc = ctlModuleContainer.SkinSrc

                    objModule.ModulePermissions.Clear()
                    objModule.ModulePermissions.AddRange(dgPermissions.Permissions)

                    objModule.InheritViewPermissions = chkInheritPermissions.Checked
                    objModule.DisplayTitle = chkDisplayTitle.Checked
                    objModule.DisplayPrint = chkDisplayPrint.Checked
                    objModule.DisplaySyndicate = chkDisplaySyndicate.Checked
                    objModule.IsWebSlice = chkWebSlice.Checked
                    objModule.WebSliceTitle = txtWebSliceTitle.Text
                    If Not String.IsNullOrEmpty(txtWebSliceExpiry.Text) Then
                        objModule.WebSliceExpiryDate = Convert.ToDateTime(txtWebSliceExpiry.Text)
                    Else
                        objModule.WebSliceExpiryDate = Null.NullDate
                    End If
                    objModule.WebSliceTTL = Convert.ToInt32(txtWebSliceTTL.Text)
                    objModule.IsDefaultModule = chkDefault.Checked
                    objModule.AllModules = chkAllModules.Checked
                    objModules.UpdateModule(objModule)

                    'Update Custom Settings
                    If SettingsControl IsNot Nothing Then
                        Try
                            SettingsControl.UpdateSettings()
                        Catch ex As System.Threading.ThreadAbortException
                            System.Threading.Thread.ResetAbort() ' necessary
                        Catch ex As Exception
                            Exceptions.LogException(ex)
                        End Try
                    End If

                    'These Module Copy/Move statements must be 
                    'at the end of the Update as the Controller code assumes all the 
                    'Updates to the Module have been carried out.

                    'Check if the Module is to be Moved to a new Tab
                    If Not chkAllTabs.Checked Then
                        Dim newTabId As Integer = Int32.Parse(cboTab.SelectedItem.Value)
                        If TabId <> newTabId Then
                            objModules.MoveModule(ModuleId, TabId, newTabId, "")
                        End If
                    End If

                    ''Check if Module is to be Added/Removed from all Tabs
                    If AllTabsChanged Then
                        Dim listTabs As List(Of Entities.Tabs.TabInfo) = TabController.GetPortalTabs(PortalSettings.PortalId, Null.NullInteger, False, True)
                        If chkAllTabs.Checked Then
                            If Not chkNewTabs.Checked Then
                                objModules.CopyModule(ModuleId, TabId, listTabs, True)
                            End If
                        Else
                            objModules.DeleteAllModules(ModuleId, TabId, listTabs, False, False)
                        End If
                    End If

                    ' Navigate back to admin page
                    Response.Redirect(NavigateURL(), True)

                End If
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

#End Region

    End Class

End Namespace
