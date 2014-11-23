public class NTP_DM_LYDO_NHAPXUAT_Info

    Private _ID As Integer
    Private _MO_TA As String
    Private _TYPE As String

    Public Sub New()

    End Sub

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal Value As Integer)
            _ID = Value
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

    Public Property TYPE() As String
        Get
            Return _TYPE
        End Get
        Set(ByVal Value As String)
            _TYPE = Value
        End Set
    End Property

End Class
