public class NTP_DM_NGUONKINHPHI_Info

	private _ID_NGUONKINHPHI as integer
	private _MO_TA as string

	public sub New()

	End sub

	Public Property  ID_NGUONKINHPHI() as integer
		Get
			Return _ID_NGUONKINHPHI
		End Get
		Set(ByVal Value as integer)
			_ID_NGUONKINHPHI = Value
		End Set
	End Property

	Public Property  MO_TA() as string
		Get
			Return _MO_TA
		End Get
		Set(ByVal Value as string)
			_MO_TA = Value
		End Set
	End Property


End Class
