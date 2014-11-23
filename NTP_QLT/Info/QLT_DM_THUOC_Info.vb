Public Class QLT_DM_THUOC_Info
    Private _ID_THUOC As Integer
    Private _MA_THUOC As String
    Private _TEN_THUOC As String
    Private _HAM_LUONG As String
    Private _MA_NUOC As String
    Private _ID_DVT As Integer

    Public Sub New()

    End Sub

    Public Property ID_THUOC() As Integer
        Get
            Return _ID_THUOC
        End Get
        Set(ByVal Value As Integer)
            _ID_THUOC = Value
        End Set
    End Property

    Public Property MA_THUOC() As String
        Get
            Return _MA_THUOC
        End Get
        Set(ByVal Value As String)
            _MA_THUOC = Value
        End Set
    End Property

    Public Property TEN_THUOC() As String
        Get
            Return _TEN_THUOC
        End Get
        Set(ByVal Value As String)
            _TEN_THUOC = Value
        End Set
    End Property

    Public Property HAM_LUONG() As String
        Get
            Return _HAM_LUONG
        End Get
        Set(ByVal Value As String)
            _HAM_LUONG = Value
        End Set
    End Property

    Public Property MA_NUOC() As String
        Get
            Return _MA_NUOC
        End Get
        Set(ByVal Value As String)
            _MA_NUOC = Value
        End Set
    End Property

    Public Property ID_DVT() As Integer
        Get
            Return _ID_DVT
        End Get
        Set(ByVal Value As Integer)
            _ID_DVT = Value
        End Set
    End Property
End Class
