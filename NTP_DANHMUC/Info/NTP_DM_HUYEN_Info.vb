public class NTP_DM_HUYEN_Info

	private _MA_HUYEN as string
	private _TEN_HUYEN as string
	private _MA_TINH as string

	public sub New()

	End sub

	Public Property  MA_HUYEN() as string
		Get
			Return _MA_HUYEN
		End Get
		Set(ByVal Value as string)
			_MA_HUYEN = Value
		End Set
	End Property

	Public Property  TEN_HUYEN() as string
		Get
			Return _TEN_HUYEN
		End Get
		Set(ByVal Value as string)
			_TEN_HUYEN = Value
		End Set
	End Property

	Public Property  MA_TINH() as string
		Get
			Return _MA_TINH
		End Get
		Set(ByVal Value as string)
			_MA_TINH = Value
		End Set
	End Property


End Class
