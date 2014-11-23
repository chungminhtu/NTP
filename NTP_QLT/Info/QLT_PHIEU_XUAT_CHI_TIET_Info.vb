Public Class QLT_PHIEU_XUAT_CHI_TIET_Info


    Private _ID_PHIEUXUAT_CHITIET As Double
    Private _ID_PHIEUXUAT As Double
    Private _ID_THUOC As Integer
    Private _LO_SX As String
    Private _HAN_SUDUNG As Date
    Private _NGAY_SX As Date
    Private _SO_LUONG As Double

    Public Sub New()

    End Sub

    Public Property ID_PHIEUXUAT_CHITIET() As Double
        Get
            Return _ID_PHIEUXUAT_CHITIET
        End Get
        Set(ByVal Value As Double)
            _ID_PHIEUXUAT_CHITIET = Value
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

    Public Property HAN_SUDUNG() As Date
        Get
            Return _HAN_SUDUNG
        End Get
        Set(ByVal Value As Date)
            _HAN_SUDUNG = Value
        End Set
    End Property

    Public Property NGAY_SX() As Date
        Get
            Return _NGAY_SX
        End Get
        Set(ByVal Value As Date)
            _NGAY_SX = Value
        End Set
    End Property

    Public Property SO_LUONG() As Double
        Get
            Return _SO_LUONG
        End Get
        Set(ByVal Value As Double)
            _SO_LUONG = Value
        End Set
    End Property

End Class
