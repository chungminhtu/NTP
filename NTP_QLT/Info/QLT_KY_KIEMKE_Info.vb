Public Class QLT_KY_KIEMKE_Info

    Private _ID_KY_KIEMKE As Integer
    Private _TEN_KY_KIEMKE As String
    Private _ID_KHO As Integer
    Private _NGAY_BATDAU As Date
    Private _NGAY_KETTHUC As Date
    Private _TRANG_THAI As Integer
    Private _NAM As Integer
    Private _THANG As Integer

    Public Sub New()

    End Sub

    Public Property ID_KY_KIEMKE() As Integer
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Integer)
            _ID_KY_KIEMKE = Value
        End Set
    End Property

    Public Property TEN_KY_KIEMKE() As String
        Get
            Return _TEN_KY_KIEMKE
        End Get
        Set(ByVal Value As String)
            _TEN_KY_KIEMKE = Value
        End Set
    End Property

    Public Property ID_KHO() As Integer
        Get
            Return _ID_KHO
        End Get
        Set(ByVal Value As Integer)
            _ID_KHO = Value
        End Set
    End Property

    Public Property NGAY_BATDAU() As Date
        Get
            Return _NGAY_BATDAU
        End Get
        Set(ByVal Value As Date)
            _NGAY_BATDAU = Value
        End Set
    End Property

    Public Property NGAY_KETTHUC() As Date
        Get
            Return _NGAY_KETTHUC
        End Get
        Set(ByVal Value As Date)
            _NGAY_KETTHUC = Value
        End Set
    End Property

    Public Property TRANG_THAI() As Integer
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal Value As Integer)
            _TRANG_THAI = Value
        End Set
    End Property

    Public Property NAM() As Integer
        Get
            Return _NAM
        End Get
        Set(ByVal Value As Integer)
            _NAM = Value
        End Set
    End Property

    Public Property THANG() As Integer
        Get
            Return _THANG
        End Get
        Set(ByVal Value As Integer)
            _THANG = Value
        End Set
    End Property

End Class
