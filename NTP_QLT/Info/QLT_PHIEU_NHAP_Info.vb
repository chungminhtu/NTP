Public Class QLT_PHIEU_NHAP_Info

    Private _ID_PHIEUNHAP As Double
    Private _MA_PHIEU_NHAP As String
    Private _ID_DONVI_NHAP As Integer
    Private _NGAY_NHAP As Date
    Private _NAM As Integer
    Private _NGUOI_NHAP As String
    Private _ID_PHIEUXUAT As Double
    Private _ID_LYDO_NHAPXUAT As Integer
    Private _ID_NGUONKINHPHI As Integer
    Private _ID_KY_KIEMKE As Integer
    Private _TRANG_THAI As Integer
    Private _GHI_CHU As String
    Private _NGAY_NM As Date
    Private _NGUOI_NM As Integer
    Private _SO_PHIEUXUAT As String

    Public Sub New()

    End Sub

    Public Property ID_PHIEUNHAP() As Double
        Get
            Return _ID_PHIEUNHAP
        End Get
        Set(ByVal Value As Double)
            _ID_PHIEUNHAP = Value
        End Set
    End Property

    Public Property MA_PHIEU_NHAP() As String
        Get
            Return _MA_PHIEU_NHAP
        End Get
        Set(ByVal Value As String)
            _MA_PHIEU_NHAP = Value
        End Set
    End Property

    Public Property ID_DONVI_NHAP() As Integer
        Get
            Return _ID_DONVI_NHAP
        End Get
        Set(ByVal Value As Integer)
            _ID_DONVI_NHAP = Value
        End Set
    End Property

    Public Property NGAY_NHAP() As Date
        Get
            Return _NGAY_NHAP
        End Get
        Set(ByVal Value As Date)
            _NGAY_NHAP = Value
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

    Public Property NGUOI_NHAP() As String
        Get
            Return _NGUOI_NHAP
        End Get
        Set(ByVal Value As String)
            _NGUOI_NHAP = Value
        End Set
    End Property

    Public Property ID_PHIEUXUAT() As Double
        Get
            Return _ID_PHIEUXUAT
        End Get
        Set(ByVal Value As Double)
            _ID_PHIEUXUAT = Value
        End Set
    End Property

    Public Property ID_LYDO_NHAPXUAT() As Integer
        Get
            Return _ID_LYDO_NHAPXUAT
        End Get
        Set(ByVal Value As Integer)
            _ID_LYDO_NHAPXUAT = Value
        End Set
    End Property

    Public Property ID_NGUONKINHPHI() As Integer
        Get
            Return _ID_NGUONKINHPHI
        End Get
        Set(ByVal Value As Integer)
            _ID_NGUONKINHPHI = Value
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

    Public Property TRANG_THAI() As Integer
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal Value As Integer)
            _TRANG_THAI = Value
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

    Public Property NGAY_NM() As Date
        Get
            Return _NGAY_NM
        End Get
        Set(ByVal Value As Date)
            _NGAY_NM = Value
        End Set
    End Property

    Public Property NGUOI_NM() As Integer
        Get
            Return _NGUOI_NM
        End Get
        Set(ByVal Value As Integer)
            _NGUOI_NM = Value
        End Set
    End Property

    Public Property SO_PHIEUXUAT() As String
        Get
            Return _SO_PHIEUXUAT
        End Get
        Set(ByVal Value As String)
            _SO_PHIEUXUAT = Value
        End Set
    End Property

End Class
