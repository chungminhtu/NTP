public class NTP_QLVT_PHIEUNHAP_CHITIET_Info

	private _ID_PHIEUNHAP_CHITIET as double
	private _ID_PHIEUNHAP as double
	private _ID_VATTU as integer
    Private _SO_LUONG As Double
    Private _LO_SANXUAT As String
    Private _HAN_SUDUNG As Date
    Private _MA_NUOC As String

	public sub New()

	End sub

	Public Property  ID_PHIEUNHAP_CHITIET() as double
		Get
			Return _ID_PHIEUNHAP_CHITIET
		End Get
		Set(ByVal Value as double)
			_ID_PHIEUNHAP_CHITIET = Value
		End Set
	End Property

	Public Property  ID_PHIEUNHAP() as double
		Get
			Return _ID_PHIEUNHAP
		End Get
		Set(ByVal Value as double)
			_ID_PHIEUNHAP = Value
		End Set
	End Property

	Public Property  ID_VATTU() as integer
		Get
			Return _ID_VATTU
		End Get
		Set(ByVal Value as integer)
			_ID_VATTU = Value
		End Set
	End Property

	Public Property  SO_LUONG() as double
		Get
			Return _SO_LUONG
		End Get
		Set(ByVal Value as double)
			_SO_LUONG = Value
		End Set
	End Property

    Public Property LO_SANXUAT() As String
        Get
            Return _LO_SANXUAT
        End Get
        Set(ByVal value As String)
            _LO_SANXUAT = value
        End Set
    End Property


    Public Property HAN_SUDUNG() As Date
        Get
            Return _HAN_SUDUNG
        End Get
        Set(ByVal value As Date)
            _HAN_SUDUNG = value
        End Set
    End Property

    Public Property MA_NUOC() As String
        Get
            Return _MA_NUOC
        End Get
        Set(ByVal value As String)
            _MA_NUOC = value
        End Set
    End Property
End Class
