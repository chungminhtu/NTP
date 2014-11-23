public class NTP_DM_BENHVIEN_Info

    Private _ID_BENHVIEN As Integer
    Private _TEN_BENHVIEN As String
    Private _ID_MIEN As Integer
    Private _ID_VUNG As Integer
    Private _ID_CAP As Integer
    Private _DIA_CHI As String
    Private _MA_BENHVIEN As String
    Private _MA_BENHVIEN_CAPTREN As String
    Private _ID_BENHVIEN_CAPTREN As Integer
    Private _PHANLOAIYTE As Int16
    Private _ID_HUYEN As String

    Public Property ID_BENHVIEN() As Integer
        Get
            Return _ID_BENHVIEN
        End Get
        Set(ByVal Value As Integer)
            _ID_BENHVIEN = Value
        End Set
    End Property

	Public Property  TEN_BENHVIEN() as string
		Get
			Return _TEN_BENHVIEN
		End Get
		Set(ByVal Value as string)
			_TEN_BENHVIEN = Value
		End Set
    End Property

    Public Property ID_MIEN() As Integer
        Get
            Return _ID_MIEN
        End Get
        Set(ByVal Value As Integer)
            _ID_MIEN = Value
        End Set
    End Property


	Public Property  ID_VUNG() as integer
		Get
			Return _ID_VUNG
		End Get
		Set(ByVal Value as integer)
			_ID_VUNG = Value
		End Set
	End Property

    Public Property ID_CAP() As Integer
        Get
            Return _ID_CAP
        End Get
        Set(ByVal Value As Integer)
            _ID_CAP = Value
        End Set
    End Property


    Public Property ID_BENHVIEN_CAPTREN() As Integer
        Get
            Return _ID_BENHVIEN_CAPTREN
        End Get
        Set(ByVal Value As Integer)
            _ID_BENHVIEN_CAPTREN = Value
        End Set
    End Property

    Public Property MA_BENHVIEN() As String
        Get
            Return _MA_BENHVIEN
        End Get
        Set(ByVal Value As String)
            _MA_BENHVIEN = Value
        End Set
    End Property

    Public Property MA_BENHVIEN_CAPTREN() As String
        Get
            Return _MA_BENHVIEN_CAPTREN
        End Get
        Set(ByVal Value As String)
            _MA_BENHVIEN_CAPTREN = Value
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

    Public Property PHANLOAIYTE() As Int16
        Get
            Return _PHANLOAIYTE
        End Get
        Set(ByVal value As Int16)
            _PHANLOAIYTE = value
        End Set
    End Property

    Public Property ID_HUYEN() As String
        Get
            Return _ID_HUYEN
        End Get
        Set(ByVal Value As String)
            _ID_HUYEN = Value
        End Set
    End Property
End Class
