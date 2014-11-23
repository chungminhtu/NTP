Namespace DotNetNuke.Modules.Chat
    Public Class DnnChatEmoticon
#Region " Public Properties "


        Private _alternateText As String = String.Empty
        Public Property AlternateText() As String
            Get
                Return _alternateText
            End Get
            Set(ByVal value As String)
                _alternateText = value
            End Set
        End Property
        Private _imageName As String = String.Empty
        Public Property ImageName() As String
            Get
                Return _imageName
            End Get
            Set(ByVal value As String)
                _imageName = value
            End Set
        End Property
        Private _imageDirectoryRoot As String = String.Empty
        Public Property ImageDirectoryRoot() As String
            Get
                Return _imageDirectoryRoot
            End Get
            Set(ByVal value As String)
                _imageDirectoryRoot = value
            End Set
        End Property
        Private _replacementText As String = String.Empty
        Public Property RepacementText() As String
            Get
                Return _replacementText
            End Get
            Set(ByVal value As String)
                _replacementText = value
            End Set
        End Property
        Private _regex As String = String.Empty
        Public Property RegularExpression() As String
            Get
                Return _regex
            End Get
            Set(ByVal value As String)
                If value.Length > 0 Then
                    _regex = value
                Else
                    _regex = String.Empty
                    For Each _char As Char In Me.RepacementText
                        If Char.IsLetterOrDigit(_char) Then
                            _regex += _char
                        Else
                            _regex += "\" + _char
                        End If
                    Next
                End If

            End Set
        End Property
#End Region
#Region " Constructors "
        Public Sub New()

        End Sub
        Public Sub New(ByVal pImageName As String, _
                        ByVal pImageDirectoryRoot As String, _
                        ByVal pAlternateText As String, _
                        ByVal pReplacementText As String, _
                        Optional ByVal pRegularExpression As String = "")
            Me.ImageName = pImageName
            Me.ImageDirectoryRoot = pImageDirectoryRoot
            Me.AlternateText = pAlternateText
            Me.RepacementText = pReplacementText
            Me.RegularExpression = pRegularExpression
        End Sub

#End Region
    End Class
End Namespace
