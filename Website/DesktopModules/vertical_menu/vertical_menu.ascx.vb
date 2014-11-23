
Imports DotNetNuke.Entities.Tabs
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.UI.WebControls

Namespace DotNetNuke.UI.Skins.Controls

	''' -----------------------------------------------------------------------------
	''' Project	 : DotNetNuke
    ''' Class	 : TransMenu
	''' -----------------------------------------------------------------------------
	''' <summary>
    ''' TransMenu implements the transmenu.
	''' </summary>
	''' <remarks></remarks>
	''' <history>
    ''' </history>
	''' -----------------------------------------------------------------------------
    Partial Class vertical_menu

        Inherits UI.Skins.NavObjectBase

#Region " Web Form Designer Generated Code "


        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub

        Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
            'CODEGEN: This method call is required by the Web Form Designer
            'Do not modify it using the code editor.
            InitializeComponent()
        End Sub

#End Region

#Region "Private Members"
        Private _menuJavaScript As String
        Private _menuRootItems As String
        Private _itemID As Integer
#End Region

#Region "Public Properties"
        Public ReadOnly Property MenuJavaScript() As String
            Get
                Return _menuJavaScript
            End Get
        End Property

        Public ReadOnly Property MenuRootItems() As String
            Get
                Return _menuRootItems
            End Get
        End Property
#End Region

#Region "Private Methods"
        Private Sub BuildTransMenu(ByVal objNode As DNNNode)

            Dim objNodes As DNNNodeCollection
            objNodes = DotNetNuke.UI.Navigation.GetNavigationNodes(ClientID)

            If objNodes.Count = 0 Then
                Me.Visible = False
                Exit Sub
            End If
            _menuRootItems = ""
            _menuJavaScript = ""
            _itemID = 10

            Dim objPNode As DNNNode
            Dim index As Integer = 0

            _menuRootItems = "<div id=""ddsidemenubar"" class=""markermenu"">" & vbCrLf & "<ul>" & vbCrLf

            '_menuRootItems = "<li><a href="http://www.dynamicdrive.com/">Dynamic Drive</a></li>"
            Dim _subMenuItem As String = ""
            Dim iCount As Integer
            iCount = 0
            For Each objPNode In objNodes

                If objPNode.HasNodes Then
                    Dim sRelID As String
                    sRelID = GenerateChildNodeID(objPNode.HasNodes, objPNode.ClientID, iCount)
                    _menuRootItems &= "<li ><a rel=" & sRelID & ">" & objPNode.Text & "</a></li>" & vbCrLf
                    _subMenuItem &= ProcessChildNodes(objPNode, sRelID, True)
                    iCount = iCount + 1
                Else
                    _menuRootItems &= "<li ><a href=""" & objPNode.NavigateURL & """ >" & objPNode.Text & "</a></li>" & vbCrLf
                End If
            Next
            _menuRootItems &= "</ul>" & vbCrLf & _subMenuItem & "</div>"
        End Sub

        Private Function GenerateChildNodeID(ByVal HasChildNode As Boolean, ByVal parentNodeID As String, ByVal icount As Integer) As String
            If HasChildNode Then
                Return parentNodeID & "_" & (icount + 1).ToString
            End If
        End Function

        Private Function ProcessChildNodes(ByVal objParentNode As DNNNode, ByVal sRelID As String, ByVal hasClassOnMenu As Boolean) As String
            If objParentNode.HasNodes Then
                'Dim objNodes As DNNNodeCollection
                'objNodes = DotNetNuke.UI.Navigation.GetNavigationNodes(objParentNode.ClientID)
                Dim objNode As DNNNode
                Dim _menuItem As String
                If hasClassOnMenu Then
                    _menuItem = "<ul id=""" & sRelID & """ class=""ddsubmenustyle blackwhite"">" & vbCrLf
                Else
                    _menuItem = "<ul>" & vbCrLf 'id=""" & sRelID & "
                End If

                For Each objNode In objParentNode.DNNNodes

                    If objNode.HasNodes Then
                        _menuItem &= "<li ><a>" & objNode.Text & "</a>" & vbCrLf
                        Dim iCount As Integer = 0
                        Dim sCRelID As String
                        sCRelID = GenerateChildNodeID(objNode.HasNodes, objNode.ClientID, iCount)
                        _menuItem &= ProcessChildNodes(objNode, sCRelID, False)
                        iCount = iCount + 1
                        _menuItem &= "</li>"
                    Else
                        _menuItem &= "<li ><a href=""" & objNode.NavigateURL & """>" & objNode.Text & "</a></li>" & vbCrLf
                    End If
                Next
                _menuItem &= "</ul>" & vbCrLf
                Return _menuItem
            End If
        End Function



#End Region

#Region "Event Handlers"

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                BuildTransMenu(Nothing)
            Catch exc As Exception           'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try

        End Sub

#End Region

    End Class

End Namespace
