Public Class QLT_KIEMKE_Info

    Private _ID_KIEMKE As Double
    Private _ID_KY_KIEMKE As Integer
    Private _NGAY_KIEMKE As Date
    Private _NGUOI_KIEM As Integer
    Private _ID_KHO As Integer
    Private _GHI_CHU As String

    Public Sub New()

    End Sub

    Public Property ID_KIEMKE() As Double
        Get
            Return _ID_KIEMKE
        End Get
        Set(ByVal Value As Double)
            _ID_KIEMKE = Value
        End Set
    End Property

    Public Property ID_KY_KIEMKE() As Integer
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Integer)
            _ID_KY_KIEMKE = Value
        End Set
    End Property

    Public Property NGAY_KIEMKE() As Date
        Get
            Return _NGAY_KIEMKE
        End Get
        Set(ByVal Value As Date)
            _NGAY_KIEMKE = Value
        End Set
    End Property

    Public Property NGUOI_KIEM() As Integer
        Get
            Return _NGUOI_KIEM
        End Get
        Set(ByVal Value As Integer)
            _NGUOI_KIEM = Value
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

    Public Property GHI_CHU() As String
        Get
            Return _GHI_CHU
        End Get
        Set(ByVal Value As String)
            _GHI_CHU = Value
        End Set
    End Property

End Class
