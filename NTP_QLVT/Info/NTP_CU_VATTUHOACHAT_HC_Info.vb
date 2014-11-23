public class NTP_CU_VATTUHOACHAT_HC_Info

	private _ID_CHITIET as double
    Private _ID_BAOCAO As Int64
    Private _ID_VATTU As Int64
	private _TON_DAU as double
	private _NHAP as double
	private _XUAT as double
	private _THUA as double
	private _THIEU_HONG as double
	private _TON_CUOI as double
	private _HAN_SUDUNG as date
	private _NGUOI_NM as integer
	private _NGAY_NM as date
    Private _GHI_CHU As String
    Private _ID_NGUONKINHPHI As Int16
    Private _LO_SX As String

	public sub New()

	End sub

	Public Property  ID_CHITIET() as double
		Get
			Return _ID_CHITIET
		End Get
		Set(ByVal Value as double)
			_ID_CHITIET = Value
		End Set
	End Property

    Public Property ID_BAOCAO() As Int64
        Get
            Return _ID_BAOCAO
        End Get
        Set(ByVal Value As Int64)
            _ID_BAOCAO = Value
        End Set
    End Property

    Public Property ID_VATTU() As Int64
        Get
            Return _ID_VATTU
        End Get
        Set(ByVal Value As Int64)
            _ID_VATTU = Value
        End Set
    End Property

	Public Property  TON_DAU() as double
		Get
			Return _TON_DAU
		End Get
		Set(ByVal Value as double)
			_TON_DAU = Value
		End Set
	End Property

	Public Property  NHAP() as double
		Get
			Return _NHAP
		End Get
		Set(ByVal Value as double)
			_NHAP = Value
		End Set
	End Property

	Public Property  XUAT() as double
		Get
			Return _XUAT
		End Get
		Set(ByVal Value as double)
			_XUAT = Value
		End Set
	End Property

	Public Property  THUA() as double
		Get
			Return _THUA
		End Get
		Set(ByVal Value as double)
			_THUA = Value
		End Set
	End Property

	Public Property  THIEU_HONG() as double
		Get
			Return _THIEU_HONG
		End Get
		Set(ByVal Value as double)
			_THIEU_HONG = Value
		End Set
	End Property

	Public Property  TON_CUOI() as double
		Get
			Return _TON_CUOI
		End Get
		Set(ByVal Value as double)
			_TON_CUOI = Value
		End Set
	End Property

	Public Property  HAN_SUDUNG() as date
		Get
			Return _HAN_SUDUNG
		End Get
		Set(ByVal Value as date)
			_HAN_SUDUNG = Value
		End Set
	End Property

	Public Property  NGUOI_NM() as integer
		Get
			Return _NGUOI_NM
		End Get
		Set(ByVal Value as integer)
			_NGUOI_NM = Value
		End Set
	End Property

	Public Property  NGAY_NM() as date
		Get
			Return _NGAY_NM
		End Get
		Set(ByVal Value as date)
			_NGAY_NM = Value
		End Set
	End Property

	Public Property  GHI_CHU() as string
		Get
			Return _GHI_CHU
		End Get
		Set(ByVal Value as string)
			_GHI_CHU = Value
		End Set
	End Property

    Public Property ID_NGUONKINHPHI() As Int16
        Get
            Return _ID_NGUONKINHPHI
        End Get
        Set(ByVal value As Int16)
            _ID_NGUONKINHPHI = value
        End Set
    End Property

    Public Property LO_SX() As String
        Get
            Return _LO_SX
        End Get
        Set(ByVal value As String)
            _LO_SX = value
        End Set
    End Property
End Class
