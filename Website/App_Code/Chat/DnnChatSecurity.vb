Imports Microsoft.VisualBasic

Namespace DotNetNuke.Modules.Chat

    Public Class Security

        Public Enum Permissions
            ChatPermission = 1
        End Enum
        Public Const ChatPermissionsCode As String = "MODULE_DNNCHAT" 'The group code for all permissions of this module
        Public Const HasChatPermissionName As String = "CANCHAT"
        Public Const ModuleName As String = "DNN_Chat"

        Public Shared Sub InitPermissions()
            Dim _chatPermissionExists As Boolean = False
            Dim moduleDefId As Integer

            'Find the permissions with the right name and key
            Dim _permissionCtrl As New DotNetNuke.Security.Permissions.PermissionController
            Dim _permissions As ArrayList = _permissionCtrl.GetPermissionByCodeAndKey(ChatPermissionsCode, HasChatPermissionName)

            'Now we need to hassle aroundto get the ModuleDefID
            Dim _dtmCtrl As New DotNetNuke.Entities.Modules.DesktopModuleController
            Dim _desktopInfo As DotNetNuke.Entities.Modules.DesktopModuleInfo
            _desktopInfo = _dtmCtrl.GetDesktopModuleByModuleName(ModuleName)
            Dim mc As New DotNetNuke.Entities.Modules.Definitions.ModuleDefinitionController
            Dim mInfo As DotNetNuke.Entities.Modules.Definitions.ModuleDefinitionInfo
            mInfo = mc.GetModuleDefinitionByName(_desktopInfo.DesktopModuleID, _desktopInfo.FriendlyName)
            moduleDefId = mInfo.ModuleDefID

            'To be fully sure, we'll check wether the permission exists for THIS moduledef
            For Each _permInfo As DotNetNuke.Security.Permissions.PermissionInfo In _permissions
                If _permInfo.PermissionKey = HasChatPermissionName And _permInfo.ModuleDefID = moduleDefId Then
                    _chatPermissionExists = True
                    'Since this is the only permission we're looking for a.t.m.
                    'we can stop looping
                    Exit For
                End If
            Next
            'Now add the Chat permission type if it's not already there...
            If Not _chatPermissionExists Then
                Dim _permInfo As New DotNetNuke.Security.Permissions.PermissionInfo
                With _permInfo
                    .ModuleDefID = moduleDefId
                    .PermissionCode = ChatPermissionsCode
                    .PermissionKey = HasChatPermissionName
                    .PermissionName = "Join Chat"
                End With
                _permissionCtrl.AddPermission(_permInfo)
            End If
        End Sub

        Public Shared Function GetPermissions(ByVal moduleID As Integer, ByVal tabID As Integer) As Integer
            Dim retval As Integer = 0

            Dim mc As New DotNetNuke.Entities.Modules.ModuleController
            Dim mp As DotNetNuke.Security.Permissions.ModulePermissionCollection = mc.GetModule(moduleID, tabID).ModulePermissions

            If DotNetNuke.Security.Permissions.ModulePermissionController.HasModulePermission(mp, HasChatPermissionName) Then retval += Permissions.ChatPermission

            Return retval
        End Function

        Public Shared Function HasPermission(ByVal userPermissions As Integer, ByVal checkPermission As Permissions) As Boolean
            Return userPermissions And CType(checkPermission, Integer)
        End Function
    End Class
End Namespace
