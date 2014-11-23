Imports Microsoft.VisualBasic

Namespace DotNetNuke.Modules.Chat
    Public Class DnnChatUser

        Public Sub New()

        End Sub

        Public Sub New(ByVal chatSessionGuid As Guid, ByVal userID As Integer, ByVal nickname As String)
            Me.ChatSessionGuid = chatSessionGuid
            Me.UserID = userID
            Me.Nickname = nickname
        End Sub

        Private _ChatSessionGuid As Guid = Guid.Empty
        Public Property ChatSessionGuid() As Guid
            Get
                Return _ChatSessionGuid
            End Get
            Set(ByVal value As Guid)
                _ChatSessionGuid = value
            End Set
        End Property

        Private _UserID As Integer = Null.NullInteger
        Public Property UserID() As Integer
            Get
                Return _UserID
            End Get
            Set(ByVal value As Integer)
                _UserID = value
            End Set
        End Property

        Private _Nickname As String
        Public Property Nickname() As String
            Get
                Return _Nickname
            End Get
            Set(ByVal value As String)
                _Nickname = value
            End Set
        End Property
    End Class

End Namespace
