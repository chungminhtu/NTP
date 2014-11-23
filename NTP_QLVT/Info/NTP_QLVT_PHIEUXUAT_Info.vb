public class NTP_QLVT_PHIEUXUAT_Info

    Private _ID_PHIEUXUAT As Double
    Private _MA_PHIEUXUAT As String
    Private _NGAY_XUAT As Date
    Private _NGUOI_XUAT As String
    Private _ID_KHOXUAT As Int64
    Private _ID_KHONHAP As Int64
    Private _ID_LYDO_NHAPXUAT As Integer
    Private _GHI_CHU As String
    Private _NGAY_NM As Date
    Private _NGUOI_NM As Integer
    Private _ID_PHIEUNHAP As Double
    Private _ID_KY_KIEMKE As Int64
    Private _TRANG_THAI As Integer
    Private _NAM As Integer
    Private _ID_NGUONKINHPHI As Integer

    Public Sub New()

    End Sub

    Public Property ID_PHIEUXUAT() As Double
        Get
            Return _ID_PHIEUXUAT
        End Get
        Set(ByVal Value As Double)
            _ID_PHIEUXUAT = Value
        End Set
    End Property

    Public Property MA_PHIEUXUAT() As String
        Get
            Return _MA_PHIEUXUAT
        End Get
        Set(ByVal Value As String)
            _MA_PHIEUXUAT = Value
        End Set
    End Property

    Public Property NGAY_XUAT() As Date
        Get
            Return _NGAY_XUAT
        End Get
        Set(ByVal Value As Date)
            _NGAY_XUAT = Value
        End Set
    End Property

    Public Property NGUOI_XUAT() As String
        Get
            Return _NGUOI_XUAT
        End Get
        Set(ByVal Value As String)
            _NGUOI_XUAT = Value
        End Set
    End Property

    Public Property ID_KHOXUAT() As Int64
        Get
            Return _ID_KHOXUAT
        End Get
        Set(ByVal Value As Int64)
            _ID_KHOXUAT = Value
        End Set
    End Property

    Public Property ID_KHONHAP() As Int64
        Get
            Return _ID_KHONHAP
        End Get
        Set(ByVal Value As Int64)
            _ID_KHONHAP = Value
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

    Public Property ID_PHIEUNHAP() As Double
        Get
            Return _ID_PHIEUNHAP
        End Get
        Set(ByVal Value As Double)
            _ID_PHIEUNHAP = Value
        End Set
    End Property

    Public Property ID_KY_KIEMKE() As Int64
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Int64)
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

    Public Property NAM() As Integer
        Get
            Return _NAM
        End Get
        Set(ByVal Value As Integer)
            _NAM = Value
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



End Class
