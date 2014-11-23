public class NTP_DM_NUOC_Info

	private _MA_NUOC as string
	private _TEN_NUOC as string

	public sub New()

	End sub

	Public Property  MA_NUOC() as string
		Get
			Return _MA_NUOC
		End Get
		Set(ByVal Value as string)
			_MA_NUOC = Value
		End Set
	End Property

	Public Property  TEN_NUOC() as string
		Get
			Return _TEN_NUOC
		End Get
		Set(ByVal Value as string)
			_TEN_NUOC = Value
		End Set
	End Property


End Class
