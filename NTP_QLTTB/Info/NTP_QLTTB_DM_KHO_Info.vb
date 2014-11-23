Public Class NTP_QLTTB_DM_KHO_Info

    Private _ID_KHO As Int64
    Private _MA_KHO As String
    Private _TEN_KHO As String
    Private _ID_VUNG As Integer
    Private _ID_KHO_CAPTREN As Int64
    Private _DIA_CHI As String
    Private _MA_TINH As String
    Private _MA_HUYEN As String


    Public Sub New()

    End Sub

    Public Property ID_KHO() As Int64
        Get
            Return _ID_KHO
        End Get
        Set(ByVal Value As Int64)
            _ID_KHO = Value
        End Set
    End Property

    Public Property MA_KHO() As String
        Get
            Return _MA_KHO
        End Get
        Set(ByVal Value As String)
            _MA_KHO = Value
        End Set
    End Property

    Public Property TEN_KHO() As String
        Get
            Return _TEN_KHO
        End Get
        Set(ByVal Value As String)
            _TEN_KHO = Value
        End Set
    End Property

    Public Property ID_VUNG() As Integer
        Get
            Return _ID_VUNG
        End Get
        Set(ByVal Value As Integer)
            _ID_VUNG = Value
        End Set
    End Property

    Public Property ID_KHO_CAPTREN() As Int64
        Get
            Return _ID_KHO_CAPTREN
        End Get
        Set(ByVal Value As Int64)
            _ID_KHO_CAPTREN = Value
        End Set
    End Property

    Public Property DIA_CHI() As String
        Get
            Return _DIA_CHI
        End Get
        Set(ByVal Value As String)
            _DIA_CHI = Value
        End Set
    End Property

    Public Property MA_TINH() As String
        Get
            Return _MA_TINH
        End Get
        Set(ByVal Value As String)
            _MA_TINH = Value
        End Set
    End Property


    Public Property MA_HUYEN() As String
        Get
            Return _MA_HUYEN
        End Get
        Set(ByVal Value As String)
            _MA_HUYEN = Value
        End Set
    End Property


End Class
