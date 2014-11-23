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
Imports System.IO
Imports System.Xml
Imports DotNetNuke.Entities.Tabs
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.Services.FileSystem
Imports DotNetNuke.UI.Skins

Namespace DotNetNuke.Modules.Admin.Tabs

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ManageTabs PortalModuleBase is used to manage a Tab/Page
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
    '''                       and localisation
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ManageTabs
        Inherits DotNetNuke.Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private strAction As String = ""

#End Region

#Region "Private Methods"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' BindData loads the Controls with Tab Data from the Database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub BindData()
            Dim objTabs As New TabController
            Dim objTab As TabInfo = objTabs.GetTab(TabId, PortalId, False)

            'Load TabControls
            BindTabControls(objTab)

            If Not objTab Is Nothing Then

                If strAction <> "copy" Then
                    txtTabName.Text = objTab.TabName
                    txtTitle.Text = objTab.Title
                    txtDescription.Text = objTab.Description
                    txtKeyWords.Text = objTab.KeyWords
                    ctlURL.Url = objTab.Url
                End If
                ctlIcon.Url = objTab.IconFile
                If Not cboParentTab.Items.FindByValue(objTab.ParentId.ToString) Is Nothing Then
                    cboParentTab.ClearSelection()
                    cboParentTab.Items.FindByValue(objTab.ParentId.ToString).Selected = True
                End If
                chkMenu.Checked = objTab.IsVisible

                If TabId <> PortalSettings.AdminTabId And TabId <> PortalSettings.SplashTabId And TabId <> PortalSettings.HomeTabId And TabId <> PortalSettings.LoginTabId And TabId <> PortalSettings.UserTabId Then
                    chkDisableLink.Checked = objTab.DisableLink
                Else
                    chkDisableLink.Enabled = False
                End If

                ctlSkin.SkinSrc = objTab.SkinSrc
                ctlContainer.SkinSrc = objTab.ContainerSrc

                If PortalSettings.SSLEnabled Then
                    chkSecure.Enabled = True
                    chkSecure.Checked = objTab.IsSecure
                Else
                    chkSecure.Enabled = False
                    chkSecure.Checked = objTab.IsSecure
                End If
                If Not Null.IsNull(objTab.StartDate) Then
                    txtStartDate.Text = objTab.StartDate.ToShortDateString
                End If
                If Not Null.IsNull(objTab.EndDate) Then
                    txtEndDate.Text = objTab.EndDate.ToShortDateString
                End If
                If objTab.RefreshInterval <> Null.NullInteger Then
                    txtRefreshInterval.Text = objTab.RefreshInterval.ToString
                End If

                txtPageHeadText.Text = objTab.PageHeadText

                ShowPermissions(Not objTab.IsSuperTab)
            End If

            ' copy page options
            cboCopyPage.DataSource = GetTabs(False)
            cboCopyPage.DataBind()
            rowModules.Visible = False
        End Sub

        Private Sub BindBeforeAfterTabControls()
            Dim listTabs As List(Of TabInfo)
            Dim parentTab As TabInfo = Nothing
            'Dim noneSpecified As String = "<" + Localization.GetString("None_Specified") + ">"

            If cboParentTab.SelectedItem IsNot Nothing Then
                Dim parentTabID As Integer = Int32.Parse(cboParentTab.SelectedItem.Value)
                Dim controller As New TabController()
                parentTab = controller.GetTab(parentTabID, PortalId, False)
            End If

            If parentTab IsNot Nothing Then
                listTabs = New TabController().GetTabsByPortal(parentTab.PortalID).WithParentId(parentTab.TabID)
            Else
                listTabs = New TabController().GetTabsByPortal(PortalId).WithParentId(Null.NullInteger)
            End If
            listTabs = TabController.GetPortalTabs(listTabs, Null.NullInteger, False, Null.NullString, False, False, False, False, True)
            cboPositionTab.DataSource = listTabs
            cboPositionTab.DataBind()

            rbInsertPosition.Items.Clear()
            rbInsertPosition.Items.Add(New ListItem(Localization.GetString("InsertBefore", LocalResourceFile), "Before"))
            rbInsertPosition.Items.Add(New ListItem(Localization.GetString("InsertAfter", LocalResourceFile), "After"))
            rbInsertPosition.Items.Add(New ListItem(Localization.GetString("InsertAtEnd", LocalResourceFile), "AtEnd"))
            rbInsertPosition.SelectedValue = "After"

            If parentTab IsNot Nothing AndAlso parentTab.IsSuperTab Then
                ShowPermissions(False)
            Else
                ShowPermissions(True)
            End If
        End Sub

        Private Sub BindTabControls(ByVal objTab As TabInfo)
            cboParentTab.DataSource = GetTabs(True)
            cboParentTab.DataBind()

            If strAction = "" OrElse strAction = "copy" Then
                ' tab administrators can only create children of the current tab
                cboParentTab.ClearSelection()
                If Not PortalSecurity.IsPageAdmin() Then
                    If Not cboParentTab.Items.FindByValue(TabId.ToString) Is Nothing Then
                        cboParentTab.Items.FindByValue(TabId.ToString).Selected = True
                    End If
                Else
                    If Not cboParentTab.Items.FindByValue(PortalSettings.ActiveTab.ParentId.ToString) Is Nothing Then
                        'Select the current tabs parent
                        cboParentTab.Items.FindByValue(PortalSettings.ActiveTab.ParentId.ToString).Selected = True
                    Else
                        ' select the <None Specified> option
                        cboParentTab.Items(0).Selected = True
                    End If
                End If

                BindBeforeAfterTabControls()
                If cboPositionTab.Items.Count > 0 Then
                    trInsertPositionRow.Visible = True
                Else
                    trInsertPositionRow.Visible = False
                End If
                cboParentTab.AutoPostBack = True
            Else
                trInsertPositionRow.Visible = False
                cboParentTab.AutoPostBack = False
            End If

            ' if editing a tab, load tab parent so parent link is not lost
            ' parent tab might not be loaded in cbotab if user does not have edit rights on it
            If Not PortalSecurity.IsPageAdmin() And Not objTab Is Nothing Then
                If cboParentTab.Items.FindByValue(objTab.ParentId.ToString) Is Nothing Then
                    Dim objtabs As New TabController
                    Dim objparent As TabInfo = objtabs.GetTab(objTab.ParentId, objTab.PortalID, False)
                    cboParentTab.Items.Add(New ListItem(objparent.LocalizedTabName, objparent.TabID.ToString))
                End If
            End If
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' CheckQuota checks whether the Page Quota will be exceeded
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	11/16/2006	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub CheckQuota()
            If PortalSettings.Pages < PortalSettings.PageQuota Or UserInfo.IsSuperUser Or PortalSettings.PageQuota = 0 Then
                cmdUpdate.Enabled = True
            Else
                cmdUpdate.Enabled = False
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, Localization.GetString("ExceededQuota", Me.LocalResourceFile), Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)
            End If
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Deletes Tab
        ''' </summary>
        ''' <param name="deleteTabId">ID of the parent tab</param>
        ''' <remarks>
        ''' Will delete tab
        ''' </remarks>
        ''' <history>
        ''' 	[VMasanas]	30/09/2004	Created
        '''     [VMasanas]  01/09/2005  A tab will be deleted only if all descendants can be deleted
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function DeleteTab(ByVal deleteTabId As Integer) As Boolean
            Dim bDeleted As Boolean = TabController.DeleteTab(deleteTabId, PortalSettings, UserId)

            If Not bDeleted Then
                UI.Skins.Skin.AddModuleMessage(Me, Services.Localization.Localization.GetString("DeleteSpecialPage", Me.LocalResourceFile), UI.Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            End If

            Return bDeleted
        End Function

        Private Sub DisplayTabModules()
            Select Case cboCopyPage.SelectedIndex
                Case 0
                    rowModules.Visible = False
                Case Else ' selected tab
                    grdModules.DataSource = LoadTabModules(Integer.Parse(cboCopyPage.SelectedItem.Value))
                    grdModules.DataBind()
                    rowModules.Visible = True
            End Select
        End Sub

        Private Function GetTabs(ByVal includeURL As Boolean)
            Dim noneSpecified As String = "<" + Localization.GetString("None_Specified") + ">"

            Dim tabs As List(Of TabInfo) = TabController.GetPortalTabs(PortalId, Null.NullInteger, True, noneSpecified, True, False, includeURL, False, True)
            If Me.UserInfo.IsSuperUser Then
                Dim hostTabs As Dictionary(Of Integer, TabInfo) = New TabController().GetTabsByPortal(Null.NullInteger)
                For Each kvp As KeyValuePair(Of Integer, TabInfo) In hostTabs
                    tabs.Add(kvp.Value)
                Next
            End If

            Return tabs
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' InitializeTab loads the Controls with default Tab Data
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub InitializeTab()
            'Load TabControls
            BindTabControls(Nothing)

            ' Populate Tab Names, etc.
            txtTabName.Text = ""
            txtTitle.Text = ""
            txtDescription.Text = ""
            txtKeyWords.Text = ""
            chkMenu.Checked = True

            BindBeforeAfterTabControls()

            If Not cboPositionTab.Items.FindByValue(TabId.ToString) Is Nothing Then
                cboPositionTab.ClearSelection()
                cboPositionTab.Items.FindByValue(TabId.ToString).Selected = True
            End If

            ' hide the upload new file link until the tab has been saved
            chkDisableLink.Checked = False

            cboFolders.Items.Insert(0, New ListItem("<" + Services.Localization.Localization.GetString("None_Specified") + ">", "-"))
            Dim folders As ArrayList = FileSystemUtils.GetFoldersByUser(PortalId, False, False, "READ, WRITE")
            For Each folder As FolderInfo In folders
                Dim FolderItem As New ListItem
                If folder.FolderPath = Null.NullString Then
                    FolderItem.Text = Localization.GetString("Root", Me.LocalResourceFile)
                Else
                    FolderItem.Text = folder.FolderPath
                End If
                FolderItem.Value = folder.FolderPath
                cboFolders.Items.Add(FolderItem)
                If FolderItem.Value = "Templates/" Then
                    FolderItem.Selected = True
                    LoadTemplates()
                End If
            Next

            ' copy page options
            cboCopyPage.DataSource = TabController.GetPortalTabs(PortalId, Null.NullInteger, True, "<" + Services.Localization.Localization.GetString("None_Specified") + ">", True, False, False, True, False)
            cboCopyPage.DataBind()
            rowModules.Visible = False
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Checks if parent tab will cause a circular reference
        ''' </summary>
        ''' <param name="intTabId">Tabid</param>
        ''' <returns></returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[VMasanas]	28/11/2004	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function IsCircularReference(ByVal intTabId As Integer) As Boolean
            If intTabId <> -1 Then
                Dim objTabs As New TabController
                Dim objtab As TabInfo = objTabs.GetTab(intTabId, PortalId, False)

                If objtab.Level = 0 Then
                    Return False
                Else
                    If TabId = objtab.ParentId Then
                        Return True
                    Else
                        Return IsCircularReference(objtab.ParentId)
                    End If
                End If
            Else
                Return False
            End If
        End Function

        Private Function LoadTabModules(ByVal TabID As Integer) As ArrayList
            Dim objModules As New ModuleController
            Dim arrModules As New ArrayList

            For Each kvp As KeyValuePair(Of Integer, ModuleInfo) In objModules.GetTabModules(TabID)
                Dim objModule As ModuleInfo = kvp.Value

                If PortalSecurity.IsInRoles(objModule.AuthorizedEditRoles) = True And objModule.IsDeleted = False And objModule.AllTabs = False Then
                    arrModules.Add(objModule)
                End If
            Next

            Return arrModules
        End Function

        Private Sub LoadTemplates()
            cboTemplate.Items.Clear()
            If cboFolders.SelectedIndex <> 0 Then
                Dim files As String() = Directory.GetFiles(PortalSettings.HomeDirectoryMapPath & cboFolders.SelectedValue, "*.page.template")
                For Each file As String In files
                    file = file.Replace(PortalSettings.HomeDirectoryMapPath & cboFolders.SelectedValue, "")
                    Dim FileItem As New ListItem
                    FileItem.Text = file.Replace(".page.template", "")
                    FileItem.Value = file
                    cboTemplate.Items.Add(FileItem)
                    If Not Page.IsPostBack AndAlso FileItem.Text = "Default" Then
                        FileItem.Selected = True
                    End If
                Next
                cboTemplate.Items.Insert(0, New ListItem(Localization.GetString("None_Specified"), "-1"))
                If cboTemplate.SelectedIndex = -1 Then
                    cboTemplate.SelectedIndex = 0
                End If
            End If
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' SaveTabData saves the Tab to the Database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="strAction">The action to perform "edit" or "add"</param>
        ''' <history>
        ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function SaveTabData(ByVal strAction As String) As Integer
            Dim objEventLog As New Services.Log.EventLog.EventLogController

            Dim strIcon As String = ""
            strIcon = ctlIcon.Url

            Dim objTabs As New TabController
            Dim objTab As New TabInfo

            objTab.TabID = TabId
            objTab.TabName = txtTabName.Text
            objTab.Title = txtTitle.Text
            objTab.Description = txtDescription.Text
            objTab.KeyWords = txtKeyWords.Text
            objTab.IsVisible = chkMenu.Checked
            If TabId <> PortalSettings.AdminTabId And TabId <> PortalSettings.SplashTabId And TabId <> PortalSettings.HomeTabId And TabId <> PortalSettings.LoginTabId And TabId <> PortalSettings.UserTabId Then
                objTab.DisableLink = chkDisableLink.Checked
            End If

            Dim parentTab As TabInfo = Nothing
            If cboParentTab.SelectedItem IsNot Nothing Then
                Dim parentTabID As Integer = Int32.Parse(cboParentTab.SelectedItem.Value)
                Dim controller As New TabController()
                parentTab = controller.GetTab(parentTabID, PortalId, False)
            End If

            If parentTab IsNot Nothing Then
                objTab.PortalID = parentTab.PortalID
                objTab.ParentId = parentTab.TabID
            Else
                objTab.PortalID = PortalId
                objTab.ParentId = Null.NullInteger
            End If
            objTab.IconFile = strIcon
            objTab.IsDeleted = False
            objTab.Url = ctlURL.Url

            objTab.TabPermissions.Clear()
            If objTab.PortalID <> Null.NullInteger Then
                objTab.TabPermissions.AddRange(dgPermissions.Permissions)
            End If

            objTab.SkinSrc = ctlSkin.SkinSrc
            objTab.ContainerSrc = ctlContainer.SkinSrc
            objTab.TabPath = GenerateTabPath(objTab.ParentId, objTab.TabName)

            'Check for invalid 
            If Regex.IsMatch(objTab.TabName, "^AUX$|^CON$|^LPT[1-9]$|^CON$|^COM[1-9]$|^NUL$|SITEMAP|LINKCLICK|KEEPALIVE|DEFAULT|ERRORPAGE", RegexOptions.IgnoreCase) Then
                Skin.AddModuleMessage(Me, Localization.GetString("InvalidTabName", Me.LocalResourceFile), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Return Null.NullInteger
            End If

            'Validate Tab Path
            If String.IsNullOrEmpty(strAction) Then
                Dim tabID As Integer = TabController.GetTabByTabPath(objTab.PortalID, objTab.TabPath)

                If tabID <> Null.NullInteger Then
                    Skin.AddModuleMessage(Me, Localization.GetString("TabExists", Me.LocalResourceFile), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                    Return Null.NullInteger
                End If

            End If

            If txtStartDate.Text <> "" Then
                objTab.StartDate = Convert.ToDateTime(txtStartDate.Text)
            Else
                objTab.StartDate = Null.NullDate
            End If
            If txtEndDate.Text <> "" Then
                objTab.EndDate = Convert.ToDateTime(txtEndDate.Text)
            Else
                objTab.EndDate = Null.NullDate
            End If
            If txtRefreshInterval.Text.Length > 0 AndAlso IsNumeric(txtRefreshInterval.Text) Then
                objTab.RefreshInterval = Convert.ToInt32(txtRefreshInterval.Text)
            End If
            objTab.PageHeadText = txtPageHeadText.Text
            objTab.IsSecure = chkSecure.Checked

            If strAction = "edit" Then
                ' trap circular tab reference
                If objTab.TabID <> Int32.Parse(cboParentTab.SelectedItem.Value) And Not IsCircularReference(Int32.Parse(cboParentTab.SelectedItem.Value)) Then
                    objTabs.UpdateTab(objTab)
                    If Me.IsHostMenu AndAlso objTab.PortalID <> Null.NullInteger Then
                        'Host Tab moved to Portal so clear Host cache
                        objTabs.ClearCache(Null.NullInteger)
                    End If
                    If Not Me.IsHostMenu AndAlso objTab.PortalID = Null.NullInteger Then
                        'Portal Tab moved to Host so clear portal cache
                        objTabs.ClearCache(PortalId)
                    End If
                    objEventLog.AddLog(objTab, PortalSettings, UserId, "", Services.Log.EventLog.EventLogController.EventLogType.TAB_UPDATED)
                End If
            Else ' add or copy
                If cboPositionTab.SelectedItem Is Nothing Then
                    objTab.TabID = objTabs.AddTab(objTab)
                Else

                    Dim positionTabID As Integer = Int32.Parse(cboPositionTab.SelectedItem.Value)

                    If rbInsertPosition.SelectedValue = "After" And positionTabID > Null.NullInteger Then
                        objTab.TabID = objTabs.AddTabAfter(objTab, positionTabID)
                    ElseIf rbInsertPosition.SelectedValue = "Before" And positionTabID > Null.NullInteger Then
                        objTab.TabID = objTabs.AddTabBefore(objTab, positionTabID)
                    Else
                        objTab.TabID = objTabs.AddTab(objTab)
                    End If
                End If

                objEventLog.AddLog(objTab, PortalSettings, UserId, "", Services.Log.EventLog.EventLogController.EventLogType.TAB_CREATED)

                Dim copyTabId As Integer = Int32.Parse(cboCopyPage.SelectedItem.Value)
                If copyTabId <> -1 Then
                    Dim objDataGridItem As DataGridItem
                    Dim objModules As New ModuleController
                    Dim objModule As ModuleInfo
                    Dim chkModule As CheckBox
                    Dim optNew As RadioButton
                    Dim optCopy As RadioButton
                    Dim optReference As RadioButton
                    Dim txtCopyTitle As TextBox

                    For Each objDataGridItem In grdModules.Items
                        chkModule = CType(objDataGridItem.FindControl("chkModule"), CheckBox)
                        If chkModule.Checked Then
                            Dim intModuleID As Integer = CType(grdModules.DataKeys(objDataGridItem.ItemIndex), Integer)
                            optNew = CType(objDataGridItem.FindControl("optNew"), RadioButton)
                            optCopy = CType(objDataGridItem.FindControl("optCopy"), RadioButton)
                            optReference = CType(objDataGridItem.FindControl("optReference"), RadioButton)
                            txtCopyTitle = CType(objDataGridItem.FindControl("txtCopyTitle"), TextBox)

                            objModule = objModules.GetModule(intModuleID, copyTabId, False)
                            If Not objModule Is Nothing Then
                                'Clone module as it exists in the cache and changes we make will update the cached object
                                Dim newModule As ModuleInfo = objModule.Clone()

                                If Not optReference.Checked Then
                                    newModule.ModuleID = Null.NullInteger
                                End If

                                newModule.TabID = objTab.TabID
                                newModule.ModuleTitle = txtCopyTitle.Text
                                newModule.ModuleID = objModules.AddModule(newModule)

                                If optCopy.Checked Then
                                    If newModule.DesktopModule.BusinessControllerClass <> "" Then
                                        Dim objObject As Object = Framework.Reflection.CreateObject(newModule.DesktopModule.BusinessControllerClass, newModule.DesktopModule.BusinessControllerClass)
                                        If TypeOf objObject Is IPortable Then
                                            Dim Content As String = CType(CType(objObject, IPortable).ExportModule(intModuleID), String)
                                            If Content <> "" Then
                                                CType(objObject, IPortable).ImportModule(newModule.ModuleID, Content, newModule.DesktopModule.Version, UserInfo.UserID)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Next
                Else
                    ' create the page from a template
                    If cboTemplate.SelectedItem IsNot Nothing AndAlso cboTemplate.SelectedItem.Value <> Null.NullInteger.ToString Then
                        ' open the XML file
                        Dim xmlDoc As New XmlDocument
                        xmlDoc.Load(PortalSettings.HomeDirectoryMapPath & cboFolders.SelectedValue & cboTemplate.SelectedValue)
                        TabController.DeserializePanes(xmlDoc.SelectSingleNode("//portal/tabs/tab/panes"), objTab.PortalID, objTab.TabID, PortalTemplateModuleAction.Ignore, New Hashtable)
                    End If
                End If
            End If

            ' url tracking
            Dim objUrls As New UrlController
            objUrls.UpdateUrl(PortalId, ctlURL.Url, ctlURL.UrlType, 0, Null.NullDate, Null.NullDate, ctlURL.Log, ctlURL.Track, Null.NullInteger, ctlURL.NewWindow)

            'Clear the Tab's Cached modules
            DotNetNuke.Common.Utilities.DataCache.ClearModuleCache(TabId)

            'Update Cached Tabs as TabPath may be needed before cache is cleared
            Dim tempTab As TabInfo = Nothing
            If New TabController().GetTabsByPortal(PortalId).TryGetValue(objTab.TabID, tempTab) Then
                tempTab.TabPath = objTab.TabPath
            End If
            Return objTab.TabID
        End Function

        Private Sub ShowPermissions(ByVal show As Boolean)
            rowPerm.Visible = show
        End Sub

#End Region

#Region "EventHandlers"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        '''     [VMasanas]  9/28/2004   Changed redirect to Access Denied
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Dim objModules As New ModuleController

                ' Verify that the current user has access to edit this module
                If Not PortalSecurity.IsPageAdmin() Then
                    Response.Redirect(NavigateURL("Access Denied"), True)
                End If

                If Not (Request.QueryString("action") Is Nothing) Then
                    strAction = Request.QueryString("action").ToLower
                End If

                'this needs to execute always to the client script code is registred in InvokePopupCal
                cmdStartCalendar.NavigateUrl = Common.Utilities.Calendar.InvokePopupCal(txtStartDate)
                cmdEndCalendar.NavigateUrl = Common.Utilities.Calendar.InvokePopupCal(txtEndDate)

                If Page.IsPostBack = False Then
                    'Set the tab id of the permissions grid to the TabId (Note If in add mode
                    'this means that the default permissions inherit from the parent)
                    If strAction = "edit" OrElse strAction = "delete" OrElse Not PortalSecurity.IsPageAdmin() Then
                        dgPermissions.TabID = TabId
                    Else
                        dgPermissions.TabID = -1
                    End If

                    ClientAPI.AddButtonConfirm(cmdDelete, Services.Localization.Localization.GetString("DeleteItem"))

                    ' load the list of files found in the upload directory
                    ctlIcon.ShowFiles = True
                    ctlIcon.ShowImages = True
                    ctlIcon.ShowTabs = False
                    ctlIcon.ShowUrls = False
                    ctlIcon.Required = False

                    ctlIcon.ShowLog = False
                    ctlIcon.ShowNewWindow = False
                    ctlIcon.ShowTrack = False
                    ctlIcon.FileFilter = glbImageFileTypes
                    ctlIcon.Width = "275px"

                    ' tab administrators can only manage their own tab
                    If Not PortalSecurity.IsPageAdmin() Then
                        cboParentTab.Enabled = False
                    End If

                    ctlSkin.Width = "275px"
                    ctlSkin.SkinRoot = SkinController.RootSkin
                    ctlContainer.Width = "275px"
                    ctlContainer.SkinRoot = SkinController.RootContainer

                    ctlURL.Width = "275px"

                    rowCopySkin.Visible = False
                    rowCopyPerm.Visible = False
                    cboCopyPage.ClearSelection()
                    Select Case strAction
                        Case ""       ' add
                            CheckQuota()
                            InitializeTab()
                            rowTemplate1.Visible = True
                            rowTemplate2.Visible = True
                            cboCopyPage.SelectedIndex = 0
                            cmdDelete.Visible = False
                        Case "edit"
                            BindData()
                            rowCopyPerm.Visible = True
                            rowCopySkin.Visible = True
                            dshCopy.Visible = False
                            tblCopy.Visible = False
                        Case "copy"
                            CheckQuota()
                            BindData()
                            If Not cboCopyPage.Items.FindByValue(TabId.ToString) Is Nothing Then
                                cboCopyPage.Items.FindByValue(TabId.ToString).Selected = True
                                DisplayTabModules()
                            End If
                            cmdDelete.Visible = False
                        Case "delete"
                            If DeleteTab(TabId) Then
                                Response.Redirect(AddHTTP(PortalAlias.HTTPAlias), True)
                            Else
                                strAction = "edit"
                                BindData()
                                dshCopy.Visible = False
                                tblCopy.Visible = False
                            End If
                    End Select

                End If

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Private Sub cboCopyPage_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCopyPage.SelectedIndexChanged
            DisplayTabModules()
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Protected Sub cboFolders_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFolders.SelectedIndexChanged
            LoadTemplates()
        End Sub

        Protected Sub cboParentTab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboParentTab.SelectedIndexChanged
            BindBeforeAfterTabControls()

            If cboPositionTab.Items.Count > 0 Then
                trInsertPositionRow.Visible = True
            Else
                trInsertPositionRow.Visible = False
            End If
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdCancel_Click runs when the Cancel Button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Try
                Dim strURL As String = NavigateURL()

                If Not Request.QueryString("returntabid") Is Nothing Then
                    ' return to admin tab
                    strURL = NavigateURL(Convert.ToInt32(Request.QueryString("returntabid")))
                End If

                Response.Redirect(strURL, True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub cmdCopyPerm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCopyPerm.Click
            Try
                TabController.CopyPermissionsToChildren(New TabController().GetTab(TabId, PortalId, False), dgPermissions.Permissions)
                UI.Skins.Skin.AddModuleMessage(Me, Services.Localization.Localization.GetString("PermissionsCopied", Me.LocalResourceFile), UI.Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch ex As Exception
                UI.Skins.Skin.AddModuleMessage(Me, Services.Localization.Localization.GetString("PermissionCopyError", Me.LocalResourceFile), UI.Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub

        Protected Sub cmdCopySkin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCopySkin.Click
            Try
                TabController.CopyDesignToChildren(New TabController().GetTab(TabId, PortalId, False), ctlSkin.SkinSrc, ctlContainer.SkinSrc)
                UI.Skins.Skin.AddModuleMessage(Me, Services.Localization.Localization.GetString("DesignCopied", Me.LocalResourceFile), UI.Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch ex As Exception
                UI.Skins.Skin.AddModuleMessage(Me, Services.Localization.Localization.GetString("DesignCopyError", Me.LocalResourceFile), UI.Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdDelete_Click runs when the Delete Button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        '''     [VMasanas]  30/09/2004  When a parent tab is deleted all child are also marked as deleted.
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdDelete_Click(ByVal Sender As Object, ByVal e As EventArgs) Handles cmdDelete.Click
            Try
                If DeleteTab(TabId) Then
                    Dim strURL As String = GetPortalDomainName(PortalAlias.HTTPAlias, Request)

                    If Not Request.QueryString("returntabid") Is Nothing Then
                        ' return to admin tab
                        strURL = NavigateURL(Convert.ToInt32(Request.QueryString("returntabid").ToString))
                    End If

                    Response.Redirect(strURL, True)
                End If
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdUpdate_Click runs when the Update Button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/10/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdUpdate_Click(ByVal Sender As Object, ByVal e As EventArgs) Handles cmdUpdate.Click
            Try
                If Page.IsValid Then
                    Dim intTabId As Integer = SaveTabData(strAction)

                    If intTabId <> Null.NullInteger Then
                        Dim strURL As String = NavigateURL(intTabId)

                        If Not Request.QueryString("returntabid") Is Nothing Then
                            ' return to admin tab
                            strURL = NavigateURL(Convert.ToInt32(Request.QueryString("returntabid").ToString))
                        Else
                            If ctlURL.Url <> "" Or chkDisableLink.Checked Then
                                ' redirect to current tab if URL was specified ( add or copy )
                                strURL = NavigateURL(TabId)
                            End If
                        End If

                        Response.Redirect(strURL, True)
                    End If
                End If
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub rbInsertPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbInsertPosition.SelectedIndexChanged
            If rbInsertPosition.SelectedValue = "AtEnd" Then
                cboPositionTab.Visible = False
                cboPositionTab.SelectedIndex = -1
            Else
                cboPositionTab.Visible = True
            End If
        End Sub

#End Region

    End Class

End Namespace
