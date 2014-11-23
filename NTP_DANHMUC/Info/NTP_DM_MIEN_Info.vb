public class NTP_DM_MIEN_Info

	private _ID_MIEN as integer
	private _TEN_MIEN as string

	public sub New()

	End sub

	Public Property  ID_MIEN() as integer
		Get
			Return _ID_MIEN
		End Get
		Set(ByVal Value as integer)
			_ID_MIEN = Value
		End Set
	End Property

	Public Property  TEN_MIEN() as string
		Get
			Return _TEN_MIEN
		End Get
		Set(ByVal Value as string)
			_TEN_MIEN = Value
		End Set
	End Property


End Class
