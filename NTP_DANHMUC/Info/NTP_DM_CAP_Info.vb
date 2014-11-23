public class NTP_DM_CAP_Info

	private _ID_CAP as integer
	private _TEN_CAP as string

	public sub New()

	End sub

	Public Property  ID_CAP() as integer
		Get
			Return _ID_CAP
		End Get
		Set(ByVal Value as integer)
			_ID_CAP = Value
		End Set
	End Property

	Public Property  TEN_CAP() as string
		Get
			Return _TEN_CAP
		End Get
		Set(ByVal Value as string)
			_TEN_CAP = Value
		End Set
	End Property


End Class
