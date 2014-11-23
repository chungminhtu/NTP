public class NTP_DM_DVT_Info

	private _ID_DVT as integer
	private _TEN_DVT as string

	public sub New()

	End sub

	Public Property  ID_DVT() as integer
		Get
			Return _ID_DVT
		End Get
		Set(ByVal Value as integer)
			_ID_DVT = Value
		End Set
	End Property

	Public Property  TEN_DVT() as string
		Get
			Return _TEN_DVT
		End Get
		Set(ByVal Value as string)
			_TEN_DVT = Value
		End Set
	End Property


End Class
