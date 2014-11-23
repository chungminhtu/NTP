public class NTP_DM_HANG_Info

	private _ID_HANG as integer
	private _MA_HANG as string
	private _TEN_HANG as string

	public sub New()

	End sub

	Public Property  ID_HANG() as integer
		Get
			Return _ID_HANG
		End Get
		Set(ByVal Value as integer)
			_ID_HANG = Value
		End Set
	End Property

	Public Property  MA_HANG() as string
		Get
			Return _MA_HANG
		End Get
		Set(ByVal Value as string)
			_MA_HANG = Value
		End Set
	End Property

	Public Property  TEN_HANG() as string
		Get
			Return _TEN_HANG
		End Get
		Set(ByVal Value as string)
			_TEN_HANG = Value
		End Set
	End Property


End Class
