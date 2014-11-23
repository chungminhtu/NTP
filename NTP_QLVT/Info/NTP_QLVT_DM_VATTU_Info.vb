public class NTP_QLVT_DM_VATTU_Info

	private _ID_VATTU as integer
	private _TEN_VATTU as string
    Private _ID_DVT As Integer
    Private _TYPE_HCVT As Int16
    Private _MA_NUOC As String

	public sub New()

	End sub

	Public Property  ID_VATTU() as integer
		Get
			Return _ID_VATTU
		End Get
		Set(ByVal Value as integer)
			_ID_VATTU = Value
		End Set
	End Property

	Public Property  TEN_VATTU() as string
		Get
			Return _TEN_VATTU
		End Get
		Set(ByVal Value as string)
			_TEN_VATTU = Value
		End Set
	End Property

	Public Property  ID_DVT() as integer
		Get
			Return _ID_DVT
		End Get
		Set(ByVal Value as integer)
			_ID_DVT = Value
		End Set
    End Property

    Public Property TYPE_HCVT() As Int16
        Get
            Return _TYPE_HCVT
        End Get
        Set(ByVal Value As Int16)
            _TYPE_HCVT = Value
        End Set
    End Property

    Public Property MA_NUOC() As String
        Get
            Return _MA_NUOC
        End Get
        Set(ByVal Value As String)
            _MA_NUOC = Value
        End Set
    End Property

End Class
