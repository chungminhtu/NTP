Public Class QLT_DM_KHO_BO
    Public Sub InsertItem(ByVal objData As NTP_QLT_DM_KHOTHUOC_Info)
        Dim bibi As New NTP_QLT_DM_KHOTHUOC_DAL
        bibi.InsertItem(objData)
        bibi = Nothing
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLT_DM_KHOTHUOC_Info)
        Dim bibi As New NTP_QLT_DM_KHOTHUOC_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID as Integer)
        Dim bibi As New NTP_QLT_DM_KHOTHUOC_DAL
        bibi.DeleteItem(ID)
        bibi = Nothing
    End Sub

    Public Function SelectAllItems() As DataSet
        Return (New NTP_QLT_DM_KHOTHUOC_DAL).SelectAllItems()
    End Function

End Class


Public Class NTP_QLT_DM_KHOTHUOC_Info

    Private _ID As Integer
    Private _MA_KHO As String
    Private _TEN_KHO As String
    Private _CAP_KHO As Integer
    Private _ID_KHO_CAPTREN As Integer
    Private _DIA_CHI As String

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

    Public Property CAP_KHO() As Integer
        Get
            Return _CAP_KHO
        End Get
        Set(ByVal Value As Integer)
            _CAP_KHO = Value
        End Set
    End Property

    Public Property ID_KHO_CAPTREN() As Integer
        Get
            Return _ID_KHO_CAPTREN
        End Get
        Set(ByVal Value As Integer)
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

End Class
