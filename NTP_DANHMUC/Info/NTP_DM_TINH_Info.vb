public class NTP_DM_TINH_Info

	private _MA_TINH as string
	private _TEN_TINH as string
	private _ID_VUNG as integer

	public sub New()

	End sub

	Public Property  MA_TINH() as string
		Get
			Return _MA_TINH
		End Get
		Set(ByVal Value as string)
			_MA_TINH = Value
		End Set
	End Property

	Public Property  TEN_TINH() as string
		Get
			Return _TEN_TINH
		End Get
		Set(ByVal Value as string)
			_TEN_TINH = Value
		End Set
	End Property

	Public Property  ID_VUNG() as integer
		Get
			Return _ID_VUNG
		End Get
		Set(ByVal Value as integer)
			_ID_VUNG = Value
		End Set
	End Property


End Class
