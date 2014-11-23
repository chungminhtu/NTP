Public Class NTP_QLTTB_PHIEUNHAP_CHITIET_Info
    Private _ID_PHIEUNHAP_CHITIET As Int64
    Private _ID_PHIEUNHAP As Int64
    Private _ID_THIETBI As Int32
    Private _SO_LUONG As Int64

    Public Sub New()

    End Sub

    Public Property ID_PHIEUNHAP_CHITIET() As Int64
        Get
            Return _ID_PHIEUNHAP_CHITIET
        End Get
        Set(ByVal value As Int64)
            _ID_PHIEUNHAP_CHITIET = value
        End Set
    End Property

    Public Property ID_PHIEUNHAP() As Int64
        Get
            Return _ID_PHIEUNHAP
        End Get
        Set(ByVal value As Int64)
            _ID_PHIEUNHAP = value
        End Set
    End Property
    Public Property ID_THIETBI() As Int32
        Get
            Return _ID_THIETBI
        End Get
        Set(ByVal value As Int32)
            _ID_THIETBI = value
        End Set
    End Property

    Public Property SO_LUONG() As Int64
        Get
            Return _SO_LUONG
        End Get
        Set(ByVal value As Int64)
            _SO_LUONG = value
        End Set
    End Property

End Class
