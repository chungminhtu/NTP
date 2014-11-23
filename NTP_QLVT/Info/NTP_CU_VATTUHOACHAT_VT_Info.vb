public class NTP_CU_VATTUHOACHAT_VT_Info

	private _ID_CHITIET as double
	private _ID_BAOCAO as double
    Private _ID_VATTU As Int64
	private _TD_TINH as double
	private _TD_BVHUYENTINH as double
	private _N_TW_CAP as double
	private _N_TINH_CAP as double
	private _X_TOANTINH as double
	private _X_SUDUNG as double
	private _THUA_TINH as double
	private _THUA_HUYEN as double
	private _THIEU_TINH as double
	private _THIEU_HUYEN as double
	private _TC_TINH as double
    Private _TC_HUYEN As Double
    Private _ID_NGUONKINHPHI As Int16
    Private _ID_DONVI As Integer
    Private _TRA_LAI As Double
    Private _HONG_TINH As Double
    Private _DIEU_CHUYEN As Double

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

	Public Property  ID_BAOCAO() as double
		Get
			Return _ID_BAOCAO
		End Get
		Set(ByVal Value as double)
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

	Public Property  TD_TINH() as double
		Get
			Return _TD_TINH
		End Get
		Set(ByVal Value as double)
			_TD_TINH = Value
		End Set
	End Property

	Public Property  TD_BVHUYENTINH() as double
		Get
			Return _TD_BVHUYENTINH
		End Get
		Set(ByVal Value as double)
			_TD_BVHUYENTINH = Value
		End Set
	End Property

	Public Property  N_TW_CAP() as double
		Get
			Return _N_TW_CAP
		End Get
		Set(ByVal Value as double)
			_N_TW_CAP = Value
		End Set
	End Property

	Public Property  N_TINH_CAP() as double
		Get
			Return _N_TINH_CAP
		End Get
		Set(ByVal Value as double)
			_N_TINH_CAP = Value
		End Set
	End Property

	Public Property  X_TOANTINH() as double
		Get
			Return _X_TOANTINH
		End Get
		Set(ByVal Value as double)
			_X_TOANTINH = Value
		End Set
	End Property

	Public Property  X_SUDUNG() as double
		Get
			Return _X_SUDUNG
		End Get
		Set(ByVal Value as double)
			_X_SUDUNG = Value
		End Set
	End Property

	Public Property  THUA_TINH() as double
		Get
			Return _THUA_TINH
		End Get
		Set(ByVal Value as double)
			_THUA_TINH = Value
		End Set
	End Property

	Public Property  THUA_HUYEN() as double
		Get
			Return _THUA_HUYEN
		End Get
		Set(ByVal Value as double)
			_THUA_HUYEN = Value
		End Set
	End Property

	Public Property  THIEU_TINH() as double
		Get
			Return _THIEU_TINH
		End Get
		Set(ByVal Value as double)
			_THIEU_TINH = Value
		End Set
	End Property

	Public Property  THIEU_HUYEN() as double
		Get
			Return _THIEU_HUYEN
		End Get
		Set(ByVal Value as double)
			_THIEU_HUYEN = Value
		End Set
	End Property

	Public Property  TC_TINH() as double
		Get
			Return _TC_TINH
		End Get
		Set(ByVal Value as double)
			_TC_TINH = Value
		End Set
	End Property

	Public Property  TC_HUYEN() as double
		Get
			Return _TC_HUYEN
		End Get
		Set(ByVal Value as double)
			_TC_HUYEN = Value
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

    Public Property ID_DONVI() As Integer
        Get
            Return _ID_DONVI
        End Get
        Set(ByVal value As Integer)
            _ID_DONVI = value
        End Set
    End Property

    Public Property TRA_LAI() As Double
        Get
            Return _TRA_LAI
        End Get
        Set(ByVal value As Double)
            _TRA_LAI = value
        End Set
    End Property

    Public Property HONG_TINH() As Double
        Get
            Return _HONG_TINH
        End Get
        Set(ByVal value As Double)
            _HONG_TINH = value
        End Set
    End Property

    Public Property DIEU_CHUYEN() As Double
        Get
            Return _DIEU_CHUYEN
        End Get
        Set(ByVal value As Double)
            _DIEU_CHUYEN = value
        End Set
    End Property

End Class
