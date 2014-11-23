Imports Microsoft.VisualBasic

Namespace DotNetNuke.Modules.Chat

    Public Class ChatController
        Implements DotNetNuke.Entities.Modules.IUpgradeable

        Public Function UpgradeModule(ByVal Version As String) As String Implements Entities.Modules.IUpgradeable.UpgradeModule
            Security.InitPermissions()

            Return Version
        End Function

    End Class
End Namespace
