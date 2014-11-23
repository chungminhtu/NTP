public class NTP_DM_VUNG_Info

	private _ID_VUNG as integer
	private _TEN_VUNG as string

	public sub New()

	End sub

	Public Property  ID_VUNG() as integer
		Get
			Return _ID_VUNG
		End Get
		Set(ByVal Value as integer)
			_ID_VUNG = Value
		End Set
	End Property

	Public Property  TEN_VUNG() as string
		Get
			Return _TEN_VUNG
		End Get
		Set(ByVal Value as string)
			_TEN_VUNG = Value
		End Set
	End Property


End Class
