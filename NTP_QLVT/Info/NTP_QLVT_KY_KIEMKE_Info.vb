public class NTP_QLVT_KY_KIEMKE_Info

    Private _ID_KY_KIEMKE As Int64
    Private _ID_KHO As Int64
	private _NGAY_BATDAU as date
	private _NGAY_KETTHUC as date
	private _TRANG_THAI as integer
    Private _TEN_KY_KIEMKE As String
    Private _NAM As Int16
    Private _LAN_KIEMKE As Int16

	public sub New()

	End sub

    Public Property ID_KY_KIEMKE() As Int64
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Int64)
            _ID_KY_KIEMKE = Value
        End Set
    End Property

    Public Property ID_KHO() As Int64
        Get
            Return _ID_KHO
        End Get
        Set(ByVal Value As Int64)
            _ID_KHO = Value
        End Set
    End Property

	Public Property  NGAY_BATDAU() as date
		Get
			Return _NGAY_BATDAU
		End Get
		Set(ByVal Value as date)
			_NGAY_BATDAU = Value
		End Set
	End Property

	Public Property  NGAY_KETTHUC() as date
		Get
			Return _NGAY_KETTHUC
		End Get
		Set(ByVal Value as date)
			_NGAY_KETTHUC = Value
		End Set
	End Property

	Public Property  TRANG_THAI() as integer
		Get
			Return _TRANG_THAI
		End Get
		Set(ByVal Value as integer)
			_TRANG_THAI = Value
		End Set
	End Property

	Public Property  TEN_KY_KIEMKE() as string
		Get
			Return _TEN_KY_KIEMKE
		End Get
		Set(ByVal Value as string)
			_TEN_KY_KIEMKE = Value
		End Set
	End Property

End Class
