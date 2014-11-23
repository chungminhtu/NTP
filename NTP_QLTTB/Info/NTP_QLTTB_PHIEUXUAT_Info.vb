Public Class NTP_QLTTB_PHIEUXUAT_Info
    Private _ID_PHIEUXUAT As Int64
    Private _MA_PHIEUXUAT As String
    Private _NGAY_XUAT As DateTime
    Private _NGUOI_XUAT As String
    Private _ID_KHOXUAT As Int64
    Private _ID_KHONHAP As Int64
    Private _ID_NGUONKINHPHI As Int32
    Private _ID_LYDO_NHAPXUAT As Int32
    Private _GHI_CHU As String
    Private _NGAY_NM As DateTime
    Private _NGUOI_NM As Int32
    Private _ID_PHIEUNHAP As Int64
    Private _ID_KY_KIEMKE As Int32
    Private _TRANG_THAI As Int32
    Private _NAM As Int32

    Public Sub New()

    End Sub
    Public Property ID_PHIEUXUAT() As Int64
        Get
            Return _ID_PHIEUXUAT
        End Get
        Set(ByVal value As Int64)
            _ID_PHIEUXUAT = value
        End Set
    End Property

    

    Public Property MA_PHIEUXUAT() As String
        Get
            Return _MA_PHIEUXUAT
        End Get
        Set(ByVal value As String)
            _MA_PHIEUXUAT = value
        End Set
    End Property

    Public Property NGAY_XUAT() As DateTime
        Get
            Return _NGAY_XUAT
        End Get
        Set(ByVal value As DateTime)
            _NGAY_XUAT = value
        End Set
    End Property

    Public Property NGUOI_XUAT() As String
        Get
            Return _NGUOI_XUAT
        End Get
        Set(ByVal value As String)
            _NGUOI_XUAT = value
        End Set
    End Property

    Public Property ID_KHOXUAT() As Int64
        Get
            Return _ID_KHOXUAT
        End Get
        Set(ByVal value As Int64)
            _ID_KHOXUAT = value
        End Set
    End Property
    Public Property ID_KHONHAP() As Int64
        Get
            Return _ID_KHONHAP
        End Get
        Set(ByVal value As Int64)
            _ID_KHONHAP = value
        End Set
    End Property

    Public Property ID_NGUONKINHPHI() As Int32
        Get
            Return _ID_NGUONKINHPHI
        End Get
        Set(ByVal value As Int32)
            _ID_NGUONKINHPHI = value
        End Set
    End Property

    Public Property ID_LYDO_NHAPXUAT() As Int32
        Get
            Return _ID_LYDO_NHAPXUAT
        End Get
        Set(ByVal value As Int32)
            _ID_LYDO_NHAPXUAT = value
        End Set
    End Property

    Public Property GHI_CHU() As String
        Get
            Return _GHI_CHU
        End Get
        Set(ByVal value As String)
            _GHI_CHU = value
        End Set
    End Property

    Public Property NGAY_NM() As DateTime
        Get
            Return _NGAY_NM
        End Get
        Set(ByVal value As DateTime)
            _NGAY_NM = value
        End Set
    End Property

    Public Property NGUOI_NM() As Int32
        Get
            Return _NGUOI_NM
        End Get
        Set(ByVal value As Int32)
            _NGUOI_NM = value
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
    

    Public Property ID_KY_KIEMKE() As Int32
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal value As Int32)
            _ID_KY_KIEMKE = value
        End Set
    End Property

    Public Property TRANG_THAI() As Int32
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal value As Int32)
            _TRANG_THAI = value
        End Set
    End Property

    Public Property NAM() As Int32
        Get
            Return _NAM
        End Get
        Set(ByVal value As Int32)
            _NAM = value
        End Set
    End Property


End Class


