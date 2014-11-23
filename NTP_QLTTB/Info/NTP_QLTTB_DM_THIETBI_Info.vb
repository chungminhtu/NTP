Public Class NTP_QLTTB_DM_THIETBI_Info

    Private _ID_THIETBI As Int32
    Private _TEN_THIETBI As String
    Private _ID_DVT As Int32
    Private _MA_NUOC As String
    Private _NHAN_HIEU As String


    Public Sub New()

    End Sub

    Public Property ID_THIETBI() As Int32
        Get
            Return _ID_THIETBI
        End Get
        Set(ByVal Value As Int32)
            _ID_THIETBI = Value
        End Set
    End Property

    Public Property TEN_THIETBI() As String
        Get
            Return _TEN_THIETBI
        End Get
        Set(ByVal Value As String)
            _TEN_THIETBI = Value
        End Set
    End Property

    Public Property ID_DVT() As Int32
        Get
            Return _ID_DVT
        End Get
        Set(ByVal Value As Int32)
            _ID_DVT = Value
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

    Public Property NHAN_HIEU() As String
        Get
            Return _NHAN_HIEU
        End Get
        Set(ByVal Value As String)
            _NHAN_HIEU = Value
        End Set
    End Property


End Class
