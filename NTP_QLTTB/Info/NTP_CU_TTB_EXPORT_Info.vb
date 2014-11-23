Public Class NTP_CU_TTB_EXPORT_Info

    Private _ID_EXPORT As Double
    Private _ID_KHO As Integer
    Private _ID_THIETBI As Integer
    Private _ID_NGUONKINHPHI As String
    Private _ID_KHO_NHAN As Integer
    Private _NGAY_XUAT_KHO As Date
    Private _LOAI_XUAT As Integer
    'Private _LO_SX As String
    'Private _HAN_DUNG As Date
    Private _SO_LUONG As Double
    Private _NGAY_NM As Date
    Private _NGUOI_NM As Integer
    Private _TRANG_THAI As Integer
    Private _MA_PHIEU As String
    Private _NGUOI_VIETPHIEU As String

    Public Sub New()

    End Sub

    Public Property ID_EXPORT() As Double
        Get
            Return _ID_EXPORT
        End Get
        Set(ByVal Value As Double)
            _ID_EXPORT = Value
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

    Public Property ID_THIETBI() As Integer
        Get
            Return _ID_THIETBI
        End Get
        Set(ByVal Value As Integer)
            _ID_THIETBI = Value
        End Set
    End Property

    Public Property ID_NGUONKINHPHI() As String
        Get
            Return _ID_NGUONKINHPHI
        End Get
        Set(ByVal Value As String)
            _ID_NGUONKINHPHI = Value
        End Set
    End Property

    Public Property ID_KHO_NHAN() As Integer
        Get
            Return _ID_KHO_NHAN
        End Get
        Set(ByVal Value As Integer)
            _ID_KHO_NHAN = Value
        End Set
    End Property

    Public Property NGAY_XUAT_KHO() As Date
        Get
            Return _NGAY_XUAT_KHO
        End Get
        Set(ByVal Value As Date)
            _NGAY_XUAT_KHO = Value
        End Set
    End Property

    Public Property LOAI_XUAT() As Integer
        Get
            Return _LOAI_XUAT
        End Get
        Set(ByVal Value As Integer)
            _LOAI_XUAT = Value
        End Set
    End Property

    'Public Property LO_SX() As String
    '    Get
    '        Return _LO_SX
    '    End Get
    '    Set(ByVal Value As String)
    '        _LO_SX = Value
    '    End Set
    'End Property

    'Public Property HAN_DUNG() As Date
    '    Get
    '        Return _HAN_DUNG
    '    End Get
    '    Set(ByVal Value As Date)
    '        _HAN_DUNG = Value
    '    End Set
    'End Property

    Public Property SO_LUONG() As Double
        Get
            Return _SO_LUONG
        End Get
        Set(ByVal Value As Double)
            _SO_LUONG = Value
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

    Public Property TRANG_THAI() As Integer
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal Value As Integer)
            _TRANG_THAI = Value
        End Set
    End Property

    Public Property MA_PHIEU() As String
        Get
            Return _MA_PHIEU
        End Get
        Set(ByVal value As String)
            _MA_PHIEU = value
        End Set
    End Property

    Public Property NGUOI_VIETPHIEU() As String
        Get
            Return _NGUOI_VIETPHIEU
        End Get
        Set(ByVal value As String)
            _NGUOI_VIETPHIEU = value
        End Set
    End Property

End Class
