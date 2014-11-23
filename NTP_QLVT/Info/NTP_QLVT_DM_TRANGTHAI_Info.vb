public class NTP_QLVT_DM_TRANGTHAI_Info

	private _ID_TRANGTHAI as integer
	private _TEN_TRANGTHAI as string

	public sub New()

	End sub

	Public Property  ID_TRANGTHAI() as integer
		Get
			Return _ID_TRANGTHAI
		End Get
		Set(ByVal Value as integer)
			_ID_TRANGTHAI = Value
		End Set
	End Property

	Public Property  TEN_TRANGTHAI() as string
		Get
			Return _TEN_TRANGTHAI
		End Get
		Set(ByVal Value as string)
			_TEN_TRANGTHAI = Value
		End Set
	End Property


End Class
