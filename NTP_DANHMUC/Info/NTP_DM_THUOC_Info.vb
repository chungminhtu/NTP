public class NTP_DM_THUOC_Info

    Private _ID_THUOC As Integer
	private _MA_THUOC as string
	private _TEN_THUOC as string
	private _HAM_LUONG as string
	private _MA_NUOC as string
	private _ID_DVT as integer

	public sub New()

	End sub

    Public Property ID_THUOC() As Integer
        Get
            Return _ID_THUOC
        End Get
        Set(ByVal Value As Integer)
            _ID_THUOC = Value
        End Set
    End Property

	Public Property  MA_THUOC() as string
		Get
			Return _MA_THUOC
		End Get
		Set(ByVal Value as string)
			_MA_THUOC = Value
		End Set
	End Property

	Public Property  TEN_THUOC() as string
		Get
			Return _TEN_THUOC
		End Get
		Set(ByVal Value as string)
			_TEN_THUOC = Value
		End Set
	End Property

	Public Property  HAM_LUONG() as string
		Get
			Return _HAM_LUONG
		End Get
		Set(ByVal Value as string)
			_HAM_LUONG = Value
		End Set
	End Property

	Public Property  MA_NUOC() as string
		Get
			Return _MA_NUOC
		End Get
		Set(ByVal Value as string)
			_MA_NUOC = Value
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


End Class
