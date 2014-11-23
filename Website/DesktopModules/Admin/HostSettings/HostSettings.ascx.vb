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

Imports System.IO
Imports System.Net

Imports DotNetNuke.Entities.Host
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.UI.Skins
Imports DotNetNuke.Framework.Providers
Imports DotNetNuke.Services.FileSystem
Imports DotNetNuke.Services.Mail
Imports System.Xml
Imports System.Xml.XPath
Imports DotNetNuke.Services.Log.EventLog

Namespace DotNetNuke.Modules.Admin.Host

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The HostSettings PortalModuleBase is used to edit the host settings
    ''' for the application.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
    '''                       and localisation
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class HostSettings
        Inherits DotNetNuke.Entities.Modules.PortalModuleBase

#Region "Private Methods"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' BindData fetches the data from the database and updates the controls
        ''' </summary>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub BindData()

            lblVersion.Text = ApplicationVersion.ToString(3)
            chkUpgrade.Checked = Entities.Host.Host.CheckUpgrade
            hypUpgrade.ImageUrl = Upgrade.Upgrade.UpgradeIndicator(ApplicationVersion, Request.IsLocal, Request.IsSecureConnection)
            If hypUpgrade.ImageUrl = "" Then
                hypUpgrade.Visible = False
            Else
                hypUpgrade.NavigateUrl = Upgrade.Upgrade.UpgradeRedirect()
            End If
            lblDataProvider.Text = ProviderConfiguration.GetProviderConfiguration("data").DefaultProvider
            lblFramework.Text = System.Environment.Version.ToString

            'Try and load a 3.0 Assembly
            Dim assembly As System.Reflection.Assembly
            Try
                assembly = AppDomain.CurrentDomain.Load("System.Runtime.Serialization, Version=3.0.0.0, Culture=neutral, PublicKeyToken=B77A5C561934E089")
                lblFramework.Text += ", (3.0)"
            Catch ex As Exception

            End Try

            'Try and load a 3.5 Assembly
            Try
                assembly = AppDomain.CurrentDomain.Load("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=B77A5C561934E089")
                lblFramework.Text += ", (3.5)"
                'Check if .NET 3.5 is enabled in web.config
                If Framework.Reflection.CreateType("System.Data.Linq.DataContext") Is Nothing Then
                    cmdUpgradeFramework.Visible = True
                End If
            Catch ex As Exception

            End Try

            lblIdentity.Text = System.Security.Principal.WindowsIdentity.GetCurrent.Name
            lblHostName.Text = Dns.GetHostName()
            lblPermissions.Text = Framework.SecurityPolicy.Permissions
            If String.IsNullOrEmpty(lblPermissions.Text) Then
                lblPermissions.Text = Localization.GetString("None", Me.LocalResourceFile)
            End If
            If String.IsNullOrEmpty(Common.ApplicationPath) Then
                lblApplicationPath.Text = "/"
            Else
                lblApplicationPath.Text = Common.ApplicationPath
            End If
            lblApplicationMapPath.Text = Common.ApplicationMapPath
            lblServerTime.Text = Now.ToString()
            chkWebFarm.Checked = Common.Globals.WebFarmEnabled
            lblGUID.Text = DotNetNuke.Entities.Host.Host.GUID

            Dim objPortals As New PortalController
            cboHostPortal.DataSource = objPortals.GetPortals
            cboHostPortal.DataBind()
            If Entities.Host.Host.HostPortalID > Null.NullInteger Then
                If Not cboHostPortal.Items.FindByValue(Entities.Host.Host.HostPortalID.ToString()) Is Nothing Then
                    cboHostPortal.Items.FindByValue(Entities.Host.Host.HostPortalID.ToString()).Selected = True
                End If
            End If
            txtHostTitle.Text = DotNetNuke.Entities.Host.Host.HostTitle
            txtHostURL.Text = DotNetNuke.Entities.Host.Host.HostURL
            txtHostEmail.Text = DotNetNuke.Entities.Host.Host.HostEmail
            valHostEmail.ValidationExpression = glbEmailRegEx

            Dim objSkins As New UI.Skins.SkinController
            Dim objSkin As UI.Skins.SkinInfo

            ctlHostSkin.Width = "252px"
            ctlHostSkin.SkinRoot = SkinController.RootSkin
            ctlHostSkin.SkinSrc = Entities.Host.Host.DefaultPortalSkin

            ctlHostContainer.Width = "252px"
            ctlHostContainer.SkinRoot = SkinController.RootContainer
            ctlHostContainer.SkinSrc = Entities.Host.Host.DefaultPortalContainer

            ctlAdminSkin.Width = "252px"
            ctlAdminSkin.SkinRoot = SkinController.RootSkin
            ctlAdminSkin.SkinSrc = Entities.Host.Host.DefaultAdminSkin

            ctlAdminContainer.Width = "252px"
            ctlAdminContainer.SkinRoot = SkinController.RootContainer
            ctlAdminContainer.SkinSrc = Entities.Host.Host.DefaultAdminContainer

            Dim arrModuleControls As ArrayList = ModuleControlController.GetModuleControls(Null.NullInteger)
            Dim objModuleControl As ModuleControlInfo
            Dim intModuleControl As Integer
            For intModuleControl = 0 To arrModuleControls.Count - 1
                objModuleControl = DirectCast(arrModuleControls(intModuleControl), ModuleControlInfo)
                If objModuleControl.ControlType = SecurityAccessLevel.ControlPanel Then
                    cboControlPanel.Items.Add(New ListItem(objModuleControl.ControlKey.Replace("CONTROLPANEL:", ""), objModuleControl.ControlSrc))
                End If
            Next intModuleControl
            If String.IsNullOrEmpty(Entities.Host.Host.ControlPanel) Then
                If Not cboControlPanel.Items.FindByValue(glbDefaultControlPanel) Is Nothing Then
                    cboControlPanel.Items.FindByValue(glbDefaultControlPanel).Selected = True
                End If
            Else
                If Not cboControlPanel.Items.FindByValue(Entities.Host.Host.ControlPanel) Is Nothing Then
                    cboControlPanel.Items.FindByValue(Entities.Host.Host.ControlPanel).Selected = True
                End If
            End If

            Dim ctlList As New Common.Lists.ListController
            Dim colProcessor As Common.Lists.ListEntryInfoCollection = ctlList.GetListEntryInfoCollection("Processor", "")

            cboProcessor.DataSource = colProcessor
            cboProcessor.DataBind()
            cboProcessor.Items.Insert(0, New ListItem("<" + Services.Localization.Localization.GetString("None_Specified") + ">", ""))

            If Not cboProcessor.Items.FindByText(Common.Globals.HostSettings("PaymentProcessor").ToString) Is Nothing Then
                cboProcessor.Items.FindByText(Common.Globals.HostSettings("PaymentProcessor").ToString).Selected = True
            End If
            txtUserId.Text = Convert.ToString(Common.Globals.HostSettings("ProcessorUserId"))
            txtPassword.Attributes.Add("value", Convert.ToString(Common.Globals.HostSettings("ProcessorPassword")))

            txtHostFee.Text = Entities.Host.Host.HostFee

            Dim colCurrency As Common.Lists.ListEntryInfoCollection = ctlList.GetListEntryInfoCollection("Currency", "")

            cboHostCurrency.DataSource = colCurrency
            cboHostCurrency.DataBind()
            If Not cboHostCurrency.Items.FindByValue(Entities.Host.Host.HostCurrency) Is Nothing Then
                cboHostCurrency.Items.FindByValue(Entities.Host.Host.HostCurrency).Selected = True
            Else
                cboHostCurrency.Items.FindByValue("USD").Selected = True
            End If
            If Not cboSchedulerMode.Items.FindByValue(Convert.ToString(Common.Globals.HostSettings("SchedulerMode"))) Is Nothing Then
                cboSchedulerMode.Items.FindByValue(Common.Globals.HostSettings("SchedulerMode").ToString).Selected = True
            Else
                cboSchedulerMode.Items.FindByValue("1").Selected = True
            End If

            txtHostSpace.Text = Entities.Host.Host.HostSpace
            txtPageQuota.Text = Entities.Host.Host.PageQuota
            txtUserQuota.Text = Entities.Host.Host.UserQuota
            If Entities.Host.Host.SiteLogStorage = "" Then
                optSiteLogStorage.Items.FindByValue("D").Selected = True
            Else
                optSiteLogStorage.Items.FindByValue(Entities.Host.Host.SiteLogStorage).Selected = True
            End If
            txtSiteLogBuffer.Text = Entities.Host.Host.SiteLogBuffer.ToString()
            txtSiteLogHistory.Text = Entities.Host.Host.SiteLogHistory.ToString()

            cboPageState.Items.FindByValue(Entities.Host.Host.PageStatePersister).Selected = True
            If Convert.ToString(Common.Globals.HostSettings("ModuleCaching")) = "" Then
                cboCacheMethod.Items.FindByValue("M").Selected = True
            Else
                cboCacheMethod.Items.FindByValue(Convert.ToString(Common.Globals.HostSettings("ModuleCaching"))).Selected = True
            End If
            If Not cboPerformance.Items.FindByValue(Convert.ToString(Common.Globals.HostSettings("PerformanceSetting"))) Is Nothing Then
                cboPerformance.Items.FindByValue(Common.Globals.HostSettings("PerformanceSetting").ToString).Selected = True
            Else
                cboPerformance.Items.FindByValue("3").Selected = True
            End If
            If Not cboCacheability.Items.FindByValue(Convert.ToString(Common.Globals.HostSettings("AuthenticatedCacheability"))) Is Nothing Then
                cboCacheability.Items.FindByValue(Common.Globals.HostSettings("AuthenticatedCacheability").ToString).Selected = True
            Else
                cboCacheability.Items.FindByValue("4").Selected = True
            End If
            If Not cboCompression.Items.FindByValue(Convert.ToString(Common.Globals.HostSettings("HttpCompression"))) Is Nothing Then
                cboCompression.Items.FindByValue(Common.Globals.HostSettings("HttpCompression").ToString).Selected = True
            Else
                cboCompression.Items.FindByValue("0").Selected = True
            End If
            If Convert.ToString(Common.Globals.HostSettings("WhitespaceFilter")) = "Y" Then
                chkWhitespace.Checked = True
            Else
                chkWhitespace.Checked = False
            End If
            If cboHostDefaultDocType.Items.FindByValue(Common.Globals.HostSettings("DefaultDocType")) IsNot Nothing Then
                cboHostDefaultDocType.Items.FindByValue(Common.Globals.HostSettings("DefaultDocType")).Selected = True
            Else
                cboHostDefaultDocType.Items.FindByValue("0").Selected = True
            End If
            If Convert.ToString(Common.Globals.HostSettings("RememberCheckbox")) = "Y" OrElse Convert.ToString(Common.Globals.HostSettings("RememberCheckbox")) = "" Then
                chkRemember.Checked = True
            Else
                chkRemember.Checked = False
            End If

            Dim filePath As String = Common.Globals.ApplicationMapPath + "\Compression.config"
            If File.Exists(filePath) Then
                Dim fileReader As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim doc As XPathDocument = New XPathDocument(fileReader)
                For Each nav As XPathNavigator In doc.CreateNavigator.Select("compression/excludedPaths/path")
                    txtExcludedPaths.Text += nav.Value.ToLower & vbCrLf
                Next
                txtWhitespaceFilter.Text = doc.CreateNavigator.SelectSingleNode("compression/whitespace").Value
            End If

            txtDemoPeriod.Text = Convert.ToString(Common.Globals.HostSettings("DemoPeriod"))
            If Convert.ToString(Common.Globals.HostSettings("DemoSignup")) = "Y" Then
                chkDemoSignup.Checked = True
            Else
                chkDemoSignup.Checked = False
            End If
            If GetHashValue(Common.Globals.HostSettings("Copyright"), "Y") = "Y" Then
                chkCopyright.Checked = True
            Else
                chkCopyright.Checked = False
            End If
            If Common.Globals.HostSettings.ContainsKey("DisableUsersOnline") Then
                If Common.Globals.HostSettings("DisableUsersOnline").ToString = "Y" Then
                    chkUsersOnline.Checked = True
                Else
                    chkUsersOnline.Checked = False
                End If
            Else
                chkUsersOnline.Checked = False
            End If
            If Common.Globals.HostSettings.ContainsKey("EnableAJAX") Then
                If Common.Globals.HostSettings("EnableAJAX").ToString = "Y" Then
                    chkAJAX.Checked = True
                Else
                    chkAJAX.Checked = False
                End If
            Else
                chkAJAX.Checked = True
            End If
            txtUsersOnlineTime.Text = Convert.ToString(Common.Globals.HostSettings("UsersOnlineTime"))
            txtAutoAccountUnlock.Text = Convert.ToString(Common.Globals.HostSettings("AutoAccountUnlockDuration"))
            txtProxyServer.Text = Convert.ToString(Common.Globals.HostSettings("ProxyServer"))
            txtProxyPort.Text = Convert.ToString(Common.Globals.HostSettings("ProxyPort"))
            txtProxyUsername.Text = Convert.ToString(Common.Globals.HostSettings("ProxyUsername"))
            txtProxyPassword.Attributes.Add("value", Convert.ToString(Common.Globals.HostSettings("ProxyPassword")))
            txtWebRequestTimeout.Text = Convert.ToString(Common.Globals.HostSettings("WebRequestTimeout"))
            txtSMTPServer.Text = Convert.ToString(Common.Globals.HostSettings("SMTPServer"))
            If Convert.ToString(Common.Globals.HostSettings("SMTPAuthentication")) <> "" Then
                optSMTPAuthentication.Items.FindByValue(Common.Globals.HostSettings("SMTPAuthentication").ToString).Selected = True
            Else
                optSMTPAuthentication.Items.FindByValue("0").Selected = True
            End If
            ShowHideSMTPCredentials()

            If Convert.ToString(Common.Globals.HostSettings("SMTPEnableSSL")) = "Y" Then
                chkSMTPEnableSSL.Checked = True
            Else
                chkSMTPEnableSSL.Checked = False
            End If

            txtSMTPUsername.Text = Convert.ToString(Common.Globals.HostSettings("SMTPUsername"))
            txtSMTPPassword.Attributes.Add("value", Convert.ToString(Common.Globals.HostSettings("SMTPPassword")))
            txtFileExtensions.Text = Convert.ToString(Common.Globals.HostSettings("FileExtensions"))

            If Common.Globals.HostSettings.ContainsKey("UseCustomErrorMessages") Then
                If Common.Globals.HostSettings("UseCustomErrorMessages").ToString = "Y" Then
                    chkUseCustomErrorMessages.Checked = True
                Else
                    chkUseCustomErrorMessages.Checked = False
                End If
            Else
                chkUseCustomErrorMessages.Checked = False
            End If

            If Common.Globals.HostSettings.ContainsKey("UseFriendlyUrls") Then
                If Common.Globals.HostSettings("UseFriendlyUrls").ToString = "Y" Then
                    chkUseFriendlyUrls.Checked = True
                Else
                    chkUseFriendlyUrls.Checked = False
                End If
            Else
                chkUseFriendlyUrls.Checked = False
            End If
            rowFriendlyUrls.Visible = chkUseFriendlyUrls.Checked

            If Common.Globals.HostSettings.ContainsKey("EnableRequestFilters") Then
                If Common.Globals.HostSettings("EnableRequestFilters").ToString = "Y" Then
                    chkEnableRequestFilters.Checked = True
                Else
                    chkEnableRequestFilters.Checked = False
                End If
            Else
                chkEnableRequestFilters.Checked = False
            End If
            rowRequestFilters.Visible = chkEnableRequestFilters.Checked

            If Common.Globals.HostSettings.ContainsKey("EventLogBuffer") Then
                If Common.Globals.HostSettings("EventLogBuffer").ToString = "Y" Then
                    chkLogBuffer.Checked = True
                Else
                    chkLogBuffer.Checked = False
                End If
            Else
                chkLogBuffer.Checked = False
            End If

            If Convert.ToString(Common.Globals.HostSettings("SkinUpload")) <> "" Then
                optSkinUpload.Items.FindByValue(Common.Globals.HostSettings("SkinUpload").ToString).Selected = True
            Else
                optSkinUpload.Items.FindByValue("G").Selected = True
            End If

            txtHelpURL.Text = Convert.ToString(Common.Globals.HostSettings("HelpURL"))
            If Common.Globals.HostSettings.ContainsKey("EnableModuleOnLineHelp") Then
                If Common.Globals.HostSettings("EnableModuleOnLineHelp").ToString = "Y" Then
                    chkEnableHelp.Checked = True
                Else
                    chkEnableHelp.Checked = False
                End If
            Else
                chkEnableHelp.Checked = True
            End If

            If Common.Globals.HostSettings.ContainsKey("EnableFileAutoSync") Then
                If Common.Globals.HostSettings("EnableFileAutoSync").ToString = "Y" Then
                    chkAutoSync.Checked = True
                Else
                    chkAutoSync.Checked = False
                End If
            Else
                chkAutoSync.Checked = False
            End If

            'jQuery Support
            jQueryVersion.Text = jQuery.Version
            chkJQueryDebugVersion.Checked = jQuery.UseDebugScript
            chkJQueryUseHosted.Checked = jQuery.UseHostedScript
            txtJQueryHostedUrl.Text = jQuery.HostedUrl

            ViewState.Item("SelectedSchedulerMode") = cboSchedulerMode.SelectedItem.Value
            ViewState.Item("SelectedLogBufferEnabled") = chkLogBuffer.Checked
            ViewState.Item("SelectedUsersOnlineEnabled") = chkUsersOnline.Checked

            ' Get the name of the data provider
            Dim objProviderConfiguration As Framework.Providers.ProviderConfiguration = Framework.Providers.ProviderConfiguration.GetProviderConfiguration("data")

            ' get list of script files
            Dim strProviderPath As String = Entities.Portals.PortalSettings.GetProviderPath()
            Dim arrScriptFiles As New ArrayList
            Dim strFile As String
            Dim arrFiles As String() = Directory.GetFiles(strProviderPath, "*." & objProviderConfiguration.DefaultProvider)
            For Each strFile In arrFiles
                arrScriptFiles.Add(Path.GetFileNameWithoutExtension(strFile))
            Next
            arrScriptFiles.Sort()

            cboVersion.DataSource = arrScriptFiles
            cboVersion.DataBind()

        End Sub

        Private Function SkinChanged(ByVal SkinRoot As String, ByVal PortalId As Integer, ByVal SkinType As DotNetNuke.UI.Skins.SkinType, ByVal PostedSkinSrc As String) As Boolean
            Dim objSkins As New UI.Skins.SkinController
            Dim objSkinInfo As UI.Skins.SkinInfo
            Dim strSkinSrc As String = Null.NullString
            'objSkinInfo = SkinController.GetSkin(SkinRoot, PortalId, SkinType.Admin)
            If Not objSkinInfo Is Nothing Then strSkinSrc = objSkinInfo.SkinSrc
            If strSkinSrc Is Nothing Then strSkinSrc = ""
            Return strSkinSrc <> PostedSkinSrc
        End Function

        Private Sub ShowHideSMTPCredentials()
            If optSMTPAuthentication.SelectedValue = "1" Then
                trSMTPPassword.Visible = True
                trSMTPUserName.Visible = True
            Else
                trSMTPPassword.Visible = False
                trSMTPUserName.Visible = False
            End If
        End Sub

#End Region

#Region "Event Handlers"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        '''     [VMasanas]  9/28/2004   Changed redirect to Access Denied
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                ' Verify that the current user has access to access this page
                If Not UserInfo.IsSuperUser Then
                    Response.Redirect(NavigateURL("Access Denied"), True)
                End If

                ' If this is the first visit to the page, populate the site data
                If Page.IsPostBack = False Then
                    BindData()
                End If

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try

        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' chkUseFriendlyUrls_CheckedChanged runs when the use friendly urls checkbox's
        ''' value is changed.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	07/06/2006 Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Protected Sub chkUseFriendlyUrls_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseFriendlyUrls.CheckedChanged
            rowFriendlyUrls.Visible = chkUseFriendlyUrls.Checked
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' chkEnableRequestFilters_CheckedChanged runs when the use friendly urls checkbox's
        ''' value is changed.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	07/06/2006 Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Protected Sub chkEnableRequestFilters_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEnableRequestFilters.CheckedChanged
            rowRequestFilters.Visible = chkEnableRequestFilters.Checked
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdEmail_Click runs when the test email button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdEmail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEmail.Click
            Try
                If txtHostEmail.Text <> "" Then
                    txtSMTPPassword.Attributes.Add("value", Convert.ToString(Common.Globals.HostSettings("SMTPPassword")))

                    Dim strMessage As String = Mail.SendMail(txtHostEmail.Text, txtHostEmail.Text, "", "", MailPriority.Normal, _
                        Services.Localization.Localization.GetSystemMessage(PortalSettings, "EMAIL_SMTP_TEST_SUBJECT"), MailFormat.Text, _
                        System.Text.Encoding.UTF8, "", "", txtSMTPServer.Text, optSMTPAuthentication.SelectedItem.Value, _
                        txtSMTPUsername.Text, txtSMTPPassword.Text, chkSMTPEnableSSL.Checked)

                    If strMessage <> "" Then
                        lblEmail.Text = "<br>" & String.Format(Services.Localization.Localization.GetString("EmailErrorMessage", Me.LocalResourceFile), strMessage)
                    Else
                        lblEmail.Text = "<br>" & Services.Localization.Localization.GetString("EmailSentMessage", Me.LocalResourceFile)
                    End If
                Else
                    lblEmail.Text = "<br>" & Services.Localization.Localization.GetString("SpecifyHostEmailMessage", Me.LocalResourceFile)
                End If

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdProcessor_Click runs when the processor Go button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdProcessor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdProcessor.Click
            Try
                Response.Redirect(AddHTTP(cboProcessor.SelectedItem.Value), True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdEmail_Click runs when the clear cache button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdCache_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCache.Click
            ' clear entire cache
            DataCache.ClearHostCache(True)

            Response.Redirect(Request.RawUrl, True)
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdUpdate_Click runs when the Upgrade button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdUpdate.Click
            If Page.IsValid Then
                Try
                    Dim objHostSettings As New Entities.Host.HostSettingsController

                    objHostSettings.UpdateHostSetting("CheckUpgrade", Convert.ToString(IIf(chkUpgrade.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("HostPortalId", cboHostPortal.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("HostTitle", txtHostTitle.Text)
                    objHostSettings.UpdateHostSetting("HostURL", txtHostURL.Text)
                    objHostSettings.UpdateHostSetting("HostEmail", txtHostEmail.Text)
                    objHostSettings.UpdateHostSetting("PaymentProcessor", cboProcessor.SelectedItem.Text)
                    objHostSettings.UpdateHostSetting("ProcessorUserId", txtUserId.Text, True)
                    objHostSettings.UpdateHostSetting("ProcessorPassword", txtPassword.Text, True)
                    objHostSettings.UpdateHostSetting("HostFee", txtHostFee.Text)
                    objHostSettings.UpdateHostSetting("HostCurrency", cboHostCurrency.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("HostSpace", txtHostSpace.Text)
                    objHostSettings.UpdateHostSetting("PageQuota", txtPageQuota.Text)
                    objHostSettings.UpdateHostSetting("UserQuota", txtUserQuota.Text)
                    objHostSettings.UpdateHostSetting("SiteLogStorage", optSiteLogStorage.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("SiteLogBuffer", txtSiteLogBuffer.Text)
                    objHostSettings.UpdateHostSetting("SiteLogHistory", txtSiteLogHistory.Text)
                    objHostSettings.UpdateHostSetting("DemoPeriod", txtDemoPeriod.Text)
                    objHostSettings.UpdateHostSetting("DemoSignup", Convert.ToString(IIf(chkDemoSignup.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("Copyright", Convert.ToString(IIf(chkCopyright.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("DefaultDocType", cboHostDefaultDocType.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("RememberCheckbox", Convert.ToString(IIf(chkRemember.Checked, "Y", "N")))

                    Dim OriginalUsersOnline As Boolean
                    OriginalUsersOnline = CType(ViewState.Item("SelectedUsersOnlineEnabled"), Boolean)
                    If OriginalUsersOnline <> chkUsersOnline.Checked Then
                        Dim objScheduleItem As Services.Scheduling.ScheduleItem
                        objScheduleItem = Services.Scheduling.SchedulingProvider.Instance.GetSchedule("DotNetNuke.Entities.Users.PurgeUsersOnline, DOTNETNUKE", Null.NullString)
                        If Not objScheduleItem Is Nothing Then
                            If Not chkUsersOnline.Checked Then
                                If Not objScheduleItem.Enabled Then
                                    objScheduleItem.Enabled = True
                                    Services.Scheduling.SchedulingProvider.Instance.UpdateSchedule(objScheduleItem)
                                    If CType(cboSchedulerMode.SelectedItem.Value, Services.Scheduling.SchedulerMode) = Services.Scheduling.SchedulerMode.TIMER_METHOD Then
                                        Services.Scheduling.SchedulingProvider.Instance.ReStart("Host Settings")
                                    End If
                                End If
                            Else
                                If objScheduleItem.Enabled Then
                                    objScheduleItem.Enabled = False
                                    Services.Scheduling.SchedulingProvider.Instance.UpdateSchedule(objScheduleItem)
                                    If CType(cboSchedulerMode.SelectedItem.Value, Services.Scheduling.SchedulerMode) = Services.Scheduling.SchedulerMode.TIMER_METHOD Then
                                        Services.Scheduling.SchedulingProvider.Instance.ReStart("Host Settings")
                                    End If
                                End If
                            End If
                        End If
                    End If
                    objHostSettings.UpdateHostSetting("DisableUsersOnline", Convert.ToString(IIf(chkUsersOnline.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("EnableAJAX", Convert.ToString(IIf(chkAJAX.Checked, "Y", "N")))

                    objHostSettings.UpdateHostSetting("AutoAccountUnlockDuration", txtAutoAccountUnlock.Text)
                    objHostSettings.UpdateHostSetting("UsersOnlineTime", txtUsersOnlineTime.Text)
                    objHostSettings.UpdateHostSetting("ProxyServer", txtProxyServer.Text)
                    objHostSettings.UpdateHostSetting("ProxyPort", txtProxyPort.Text)
                    objHostSettings.UpdateHostSetting("ProxyUsername", txtProxyUsername.Text, True)
                    objHostSettings.UpdateHostSetting("ProxyPassword", txtProxyPassword.Text, True)
                    objHostSettings.UpdateHostSetting("WebRequestTimeout", txtWebRequestTimeout.Text)
                    objHostSettings.UpdateHostSetting("SMTPServer", txtSMTPServer.Text)
                    objHostSettings.UpdateHostSetting("SMTPAuthentication", optSMTPAuthentication.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("SMTPUsername", txtSMTPUsername.Text, True)
                    objHostSettings.UpdateHostSetting("SMTPPassword", txtSMTPPassword.Text, True)
                    objHostSettings.UpdateHostSetting("SMTPEnableSSL", Convert.ToString(IIf(chkSMTPEnableSSL.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("FileExtensions", txtFileExtensions.Text)
                    objHostSettings.UpdateHostSetting("SkinUpload", optSkinUpload.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("UseCustomErrorMessages", Convert.ToString(IIf(chkUseCustomErrorMessages.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("UseFriendlyUrls", Convert.ToString(IIf(chkUseFriendlyUrls.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("EnableRequestFilters", Convert.ToString(IIf(chkEnableRequestFilters.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("ControlPanel", cboControlPanel.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("SchedulerMode", cboSchedulerMode.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("PerformanceSetting", cboPerformance.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("AuthenticatedCacheability", cboCacheability.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("PageStatePersister", cboPageState.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("ModuleCaching", cboCacheMethod.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("HttpCompression", cboCompression.SelectedItem.Value)
                    objHostSettings.UpdateHostSetting("WhitespaceFilter", Convert.ToString(IIf(chkWhitespace.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("EnableModuleOnLineHelp", Convert.ToString(IIf(chkEnableHelp.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("EnableFileAutoSync", Convert.ToString(IIf(chkAutoSync.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("HelpURL", txtHelpURL.Text)

                    Dim OriginalLogBuffer As Boolean
                    OriginalLogBuffer = CType(ViewState.Item("SelectedLogBufferEnabled"), Boolean)
                    If OriginalLogBuffer <> chkLogBuffer.Checked Then
                        Dim objScheduleItem As Services.Scheduling.ScheduleItem
                        objScheduleItem = Services.Scheduling.SchedulingProvider.Instance.GetSchedule("DotNetNuke.Services.Log.EventLog.PurgeLogBuffer, DOTNETNUKE", Null.NullString)
                        If Not objScheduleItem Is Nothing Then
                            If chkLogBuffer.Checked Then
                                If Not objScheduleItem.Enabled Then
                                    objScheduleItem.Enabled = True
                                    Services.Scheduling.SchedulingProvider.Instance.UpdateSchedule(objScheduleItem)
                                    If CType(cboSchedulerMode.SelectedItem.Value, Services.Scheduling.SchedulerMode) = Services.Scheduling.SchedulerMode.TIMER_METHOD Then
                                        Services.Scheduling.SchedulingProvider.Instance.ReStart("Host Settings")
                                    End If
                                End If
                            Else
                                If objScheduleItem.Enabled Then
                                    objScheduleItem.Enabled = False
                                    Services.Scheduling.SchedulingProvider.Instance.UpdateSchedule(objScheduleItem)
                                    If CType(cboSchedulerMode.SelectedItem.Value, Services.Scheduling.SchedulerMode) = Services.Scheduling.SchedulerMode.TIMER_METHOD Then
                                        Services.Scheduling.SchedulingProvider.Instance.ReStart("Host Settings")
                                    End If
                                End If
                            End If
                        End If
                    End If
                    objHostSettings.UpdateHostSetting("EventLogBuffer", Convert.ToString(IIf(chkLogBuffer.Checked, "Y", "N")))

                    objHostSettings.UpdateHostSetting("DefaultPortalSkin", ctlHostSkin.SkinSrc)
                    objHostSettings.UpdateHostSetting("DefaultAdminSkin", ctlAdminSkin.SkinSrc)
                    objHostSettings.UpdateHostSetting("DefaultPortalContainer", ctlHostContainer.SkinSrc)
                    objHostSettings.UpdateHostSetting("DefaultAdminContainer", ctlAdminContainer.SkinSrc)

                    'jQuery Settings
                    objHostSettings.UpdateHostSetting("jQueryDebug", Convert.ToString(IIf(chkJQueryDebugVersion.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("jQueryHosted", Convert.ToString(IIf(chkJQueryUseHosted.Checked, "Y", "N")))
                    objHostSettings.UpdateHostSetting("jQueryUrl", txtJQueryHostedUrl.Text)

                    ' clear host settings cache
                    DataCache.ClearHostCache(True)

                    Dim OriginalSchedulerMode As Services.Scheduling.SchedulerMode
                    OriginalSchedulerMode = CType(ViewState.Item("SelectedSchedulerMode"), Services.Scheduling.SchedulerMode)

                    If CType(cboSchedulerMode.SelectedItem.Value, Services.Scheduling.SchedulerMode) = Services.Scheduling.SchedulerMode.DISABLED Then
                        If OriginalSchedulerMode <> Services.Scheduling.SchedulerMode.DISABLED Then
                            Services.Scheduling.SchedulingProvider.Instance.Halt("Host Settings")
                        End If
                    ElseIf CType(cboSchedulerMode.SelectedItem.Value, Services.Scheduling.SchedulerMode) = Services.Scheduling.SchedulerMode.TIMER_METHOD Then
                        If OriginalSchedulerMode = Services.Scheduling.SchedulerMode.DISABLED Or OriginalSchedulerMode = Services.Scheduling.SchedulerMode.REQUEST_METHOD Then
                            Dim newThread As New Threading.Thread(AddressOf Services.Scheduling.SchedulingProvider.Instance.Start)
                            newThread.IsBackground = True
                            newThread.Start()
                        End If
                    ElseIf CType(cboSchedulerMode.SelectedItem.Value, Services.Scheduling.SchedulerMode) <> Services.Scheduling.SchedulerMode.TIMER_METHOD Then
                        If OriginalSchedulerMode = Services.Scheduling.SchedulerMode.TIMER_METHOD Then
                            Services.Scheduling.SchedulingProvider.Instance.Halt("Host Settings")
                        End If
                    End If

                    ' this is needed in order to fully flush the cache after changing FriendlyURL
                    Response.Redirect(Request.RawUrl, True)

                    ' Redirect to this site to refresh only if admin skin changed
                    'If blnAdminSkinChanged Then Response.Redirect(Request.RawUrl, True)

                Catch exc As Exception    'Module failed to load
                    ProcessModuleLoadException(Me, exc)
                End Try
            End If
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdUpgrade_Click runs when the Upgrade Log Go button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdUpgrade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpgrade.Click
            Try
                ' get path to provider
                Dim strProviderPath As String = Entities.Portals.PortalSettings.GetProviderPath()

                If File.Exists(strProviderPath & cboVersion.SelectedItem.Text & ".log") Then
                    Dim objStreamReader As StreamReader
                    objStreamReader = File.OpenText(strProviderPath & cboVersion.SelectedItem.Text & ".log")
                    Dim upgradeText As String = objStreamReader.ReadToEnd
                    If upgradeText.Trim = "" Then
                        upgradeText = Localization.GetString("LogEmpty", Me.LocalResourceFile)
                    End If
                    lblUpgrade.Text = Replace(upgradeText, ControlChars.Lf, "<br>")
                    objStreamReader.Close()
                Else
                    lblUpgrade.Text = Localization.GetString("NoLog", Me.LocalResourceFile)
                End If

            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub cmdUpgradeFramework_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpgradeFramework.Click

            'Call the Upgrade.UpdateConfig method
            Dim strMessage As String = Upgrade.Upgrade.UpdateConfig("Net35")
            If String.IsNullOrEmpty(strMessage) Then
                'Remove old AJAX file
                FileSystemUtils.DeleteFile(Path.Combine(ApplicationMapPath, "bin\System.Web.Extensions.dll"))

                cmdUpgradeFramework.Visible = False
            Else
                Skin.AddModuleMessage(Me, strMessage, Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            End If

        End Sub

        Protected Sub cmdUploadSkinContainer(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUploadContainer.Click, cmdUploadSkin.Click
            Dim FileManagerModule As ModuleInfo = (New ModuleController).GetModuleByDefinition(Null.NullInteger, "File Manager")

            Dim params(2) As String

            params(0) = "mid=" & FileManagerModule.ModuleID
            If sender Is cmdUploadSkin Then
                params(1) = "ftype=" & UploadType.Skin.ToString
            Else
                params(1) = "ftype=" & UploadType.Container.ToString
            End If
            params(2) = "rtab=" & Me.TabId

            Response.Redirect(NavigateURL(FileManagerModule.TabID, "Edit", params), True)
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdRestart_Click runs when the Restart button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cnurse]	9/27/2004	Updated to reflect design changes for Help, 508 support
        '''                       and localisation
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdRestart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRestart.Click
            Dim objEv As New EventLogController
            Dim objEventLogInfo As New LogInfo
            objEventLogInfo.BypassBuffering = True
            objEventLogInfo.LogTypeKey = Services.Log.EventLog.EventLogController.EventLogType.HOST_ALERT.ToString
            objEventLogInfo.AddProperty("Message", Localization.GetString("UserRestart", Me.LocalResourceFile))
            objEv.AddLog(objEventLogInfo)

            Config.Touch()
            Response.Redirect(NavigateURL(), True)
        End Sub

        Protected Sub cmdUpdateCompression_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdateCompression.Click

            'Create XML Document
            Dim xmlCompression As New XmlDocument

            'Root Element
            Dim nodeRoot As XmlNode = xmlCompression.CreateElement("compression")

            'ExcludedPaths Element
            Dim nodeExcludedPaths As XmlNode = xmlCompression.CreateElement("excludedPaths")
            nodeRoot.AppendChild(nodeExcludedPaths)

            'Add ExcludedPaths
            For Each strItem As String In txtExcludedPaths.Text.Split(vbCrLf)
                If strItem.Trim <> "" Then
                    XmlUtils.AppendElement(xmlCompression, nodeExcludedPaths, "path", strItem.Trim, False)
                End If
            Next

            'Whitespace Element
            XmlUtils.AppendElement(xmlCompression, nodeRoot, "whitespace", txtWhitespaceFilter.Text, False, True)

            'Add Root element to document
            xmlCompression.AppendChild(nodeRoot)

            'Create XML declaration. 
            Dim xmlDeclaration As XmlDeclaration
            xmlDeclaration = xmlCompression.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            xmlCompression.InsertBefore(xmlDeclaration, nodeRoot)

            'Save Compression file
            Dim strFile As String = Common.Globals.ApplicationMapPath + "\Compression.config"
            File.SetAttributes(strFile, FileAttributes.Normal)
            xmlCompression.Save(strFile)

        End Sub

        Protected Sub optSMTPAuthentication_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optSMTPAuthentication.SelectedIndexChanged
            ShowHideSMTPCredentials()
        End Sub

#End Region

    End Class

End Namespace

