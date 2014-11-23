Public Class QLT_DM_TRANG_THAI_Info
    Private _ID_TRANGTHAI As Integer
    Private _MO_TA As String

    Public Sub New()

    End Sub

    Public Property ID_TRANGTHAI() As Integer
        Get
            Return _ID_TRANGTHAI
        End Get
        Set(ByVal Value As Integer)
            _ID_TRANGTHAI = Value
        End Set
    End Property

    Public Property MO_TA() As String
        Get
            Return _MO_TA
        End Get
        Set(ByVal Value As String)
            _MO_TA = Value
        End Set
    End Property

End Class
