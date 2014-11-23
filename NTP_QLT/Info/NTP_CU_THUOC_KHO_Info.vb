public class NTP_CU_THUOC_KHO_Info

	private _ID_KY as double
    Private _ID_KHO As Integer
	private _THANG as integer
	private _NAM as integer
    Private _ID_THUOC As Integer
	private _ID_NGUONKINHPHI as integer
	private _LO_SX as string
	private _HAN_DUNG as date
	private _TON_DAU as double
	private _NHAP as double
	private _XUAT as double
	private _TON_CUOI as double
    Private _NGAY_KHOA_SO As Date
    Private _TRANG_THAI As Integer

	public sub New()

	End sub

	Public Property  ID_KY() as double
		Get
			Return _ID_KY
		End Get
		Set(ByVal Value as double)
			_ID_KY = Value
		End Set
	End Property

    Public Property ID_KHO() As Integer
        Get
            Return _ID_KHO
        End Get
        Set(ByVal Value As Integer)
            _ID_KHO = Value
        End Set
    End Property

	Public Property  THANG() as integer
		Get
			Return _THANG
		End Get
		Set(ByVal Value as integer)
			_THANG = Value
		End Set
	End Property

	Public Property  NAM() as integer
		Get
			Return _NAM
		End Get
		Set(ByVal Value as integer)
			_NAM = Value
		End Set
	End Property

    Public Property ID_THUOC() As Integer
        Get
            Return _ID_THUOC
        End Get
        Set(ByVal Value As Integer)
            _ID_THUOC = Value
        End Set
    End Property

	Public Property  ID_NGUONKINHPHI() as integer
		Get
			Return _ID_NGUONKINHPHI
		End Get
		Set(ByVal Value as integer)
			_ID_NGUONKINHPHI = Value
		End Set
	End Property

	Public Property  LO_SX() as string
		Get
			Return _LO_SX
		End Get
		Set(ByVal Value as string)
			_LO_SX = Value
		End Set
	End Property

	Public Property  HAN_DUNG() as date
		Get
			Return _HAN_DUNG
		End Get
		Set(ByVal Value as date)
			_HAN_DUNG = Value
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

	Public Property  TON_CUOI() as double
		Get
			Return _TON_CUOI
		End Get
		Set(ByVal Value as double)
			_TON_CUOI = Value
		End Set
	End Property

	Public Property  NGAY_KHOA_SO() as date
		Get
			Return _NGAY_KHOA_SO
		End Get
		Set(ByVal Value as date)
			_NGAY_KHOA_SO = Value
		End Set
	End Property

    Public Property TRANG_THAI() As Integer
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal value As Integer)
            _TRANG_THAI = value
        End Set
    End Property

End Class
