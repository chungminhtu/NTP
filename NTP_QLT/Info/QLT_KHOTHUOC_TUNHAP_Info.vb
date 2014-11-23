Public Class QLT_KHOTHUOC_TUNHAP_Info

    Private _ID_TUNHAP As Integer
    Private _ID_KHO As Integer
    Private _ID_KY_KIEMKE As Integer
    Private _ID_THUOC As Integer
    Private _LO_SX As String
    Private _TON_DAUKY As Double
    Private _NHAP As Double
    Private _XUAT As Double
    Private _TON_CUOIKY As Double
    Private _THUA As Double
    Private _THIEU As Double
    Private _HONG As Double
    Private _TOT As Double
    Private _Kem_PC As Double
    Private _Mat_PC As Double

    Public Sub New()

    End Sub

    Public Property ID_TUNHAP() As Integer
        Get
            Return _ID_TUNHAP
        End Get
        Set(ByVal Value As Integer)
            _ID_TUNHAP = Value
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

    Public Property ID_KY_KIEMKE() As Integer
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Integer)
            _ID_KY_KIEMKE = Value
        End Set
    End Property

    Public Property ID_THUOC() As Integer
        Get
            Return _ID_THUOC
        End Get
        Set(ByVal Value As Integer)
            _ID_THUOC = Value
        End Set
    End Property

    Public Property LO_SX() As String
        Get
            Return _LO_SX
        End Get
        Set(ByVal Value As String)
            _LO_SX = Value
        End Set
    End Property

    Public Property TON_DAUKY() As Double
        Get
            Return _TON_DAUKY
        End Get
        Set(ByVal Value As Double)
            _TON_DAUKY = Value
        End Set
    End Property

    Public Property NHAP() As Double
        Get
            Return _NHAP
        End Get
        Set(ByVal Value As Double)
            _NHAP = Value
        End Set
    End Property

    Public Property XUAT() As Double
        Get
            Return _XUAT
        End Get
        Set(ByVal Value As Double)
            _XUAT = Value
        End Set
    End Property

    Public Property TON_CUOIKY() As Double
        Get
            Return _TON_CUOIKY
        End Get
        Set(ByVal Value As Double)
            _TON_CUOIKY = Value
        End Set
    End Property

    Public Property THUA() As Double
        Get
            Return _THUA
        End Get
        Set(ByVal Value As Double)
            _THUA = Value
        End Set
    End Property

    Public Property THIEU() As Double
        Get
            Return _THIEU
        End Get
        Set(ByVal Value As Double)
            _THIEU = Value
        End Set
    End Property

    Public Property HONG() As Double
        Get
            Return _HONG
        End Get
        Set(ByVal Value As Double)
            _HONG = Value
        End Set
    End Property

    Public Property TOT() As Double
        Get
            Return _TOT
        End Get
        Set(ByVal Value As Double)
            _TOT = Value
        End Set
    End Property

    Public Property Kem_PC() As Double
        Get
            Return _Kem_PC
        End Get
        Set(ByVal Value As Double)
            _Kem_PC = Value
        End Set
    End Property

    Public Property Mat_PC() As Double
        Get
            Return _Mat_PC
        End Get
        Set(ByVal Value As Double)
            _Mat_PC = Value
        End Set
    End Property


End Class



