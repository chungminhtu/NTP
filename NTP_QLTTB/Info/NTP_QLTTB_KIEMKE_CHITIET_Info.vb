public class NTP_QLTTB_KIEMKE_CHITIET_Info

	private _ID_KIEMKE_CHITIET as double
	private _ID_KIEMKE as double
	private _ID_THIETBI as integer
	private _ID_TRANGTHAI as integer
	private _SO_LUONG as double

	public sub New()

	End sub

	Public Property  ID_KIEMKE_CHITIET() as double
		Get
			Return _ID_KIEMKE_CHITIET
		End Get
		Set(ByVal Value as double)
			_ID_KIEMKE_CHITIET = Value
		End Set
	End Property

	Public Property  ID_KIEMKE() as double
		Get
			Return _ID_KIEMKE
		End Get
		Set(ByVal Value as double)
			_ID_KIEMKE = Value
		End Set
	End Property

	Public Property  ID_THIETBI() as integer
		Get
			Return _ID_THIETBI
		End Get
		Set(ByVal Value as integer)
			_ID_THIETBI = Value
		End Set
	End Property

	Public Property  ID_TRANGTHAI() as integer
		Get
			Return _ID_TRANGTHAI
		End Get
		Set(ByVal Value as integer)
			_ID_TRANGTHAI = Value
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


End Class
