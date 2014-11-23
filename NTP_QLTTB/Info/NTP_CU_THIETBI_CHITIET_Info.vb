public class NTP_CU_THIETBI_CHITIET_Info

	private _ID_CHITIET as double
	private _ID_BAOCAO as double
	private _ID_KHO as string
	private _TYPE as integer
	private _ID_THIETBI as integer
	private _ID_NGUONKINHPHI as integer
	private _ID_MATINH as string
	private _TD_SOLUONG as double
    Private _N_SOLUONG As Double
    Private _N_NAM As Double
	private _XSD_TINH_SOLUONG as double
	private _XSD_TINH_NAM as double
	private _XSD_HUYEN_SOLUONG as double
	private _XSD_HUYEN_NAM as double
	private _HONG_TINH_SOLUONG as double
	private _HONG_TINH_NAM as double
	private _HONG_HUYEN_SOLUONG as double
	private _HONG_HUYEN_NAM as double
	private _CHO_THANHLY as double
	private _DA_THANHLY as double
    Private _GHI_CHU As String
    Private _NGUOI_NM As Integer
    Private _TC_SOLUONG As Double

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

	Public Property  ID_KHO() as string
		Get
			Return _ID_KHO
		End Get
		Set(ByVal Value as string)
			_ID_KHO = Value
		End Set
	End Property

	Public Property  TYPE() as integer
		Get
			Return _TYPE
		End Get
		Set(ByVal Value as integer)
			_TYPE = Value
		End Set
	End Property

	Public Property  ID_THIETBI() as integer
		Get
			Return _ID_THIETBI
		End Get
		Set(ByVal Value as integer)
			_ID_THIETBI = Value
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

	Public Property  ID_MATINH() as string
		Get
			Return _ID_MATINH
		End Get
		Set(ByVal Value as string)
			_ID_MATINH = Value
		End Set
	End Property

	Public Property  TD_SOLUONG() as double
		Get
			Return _TD_SOLUONG
		End Get
		Set(ByVal Value as double)
			_TD_SOLUONG = Value
		End Set
	End Property

    Public Property N_SOLUONG() As Double
        Get
            Return _N_SOLUONG
        End Get
        Set(ByVal Value As Double)
            _N_SOLUONG = Value
        End Set
    End Property

    Public Property N_NAM() As Double
        Get
            Return _N_NAM
        End Get
        Set(ByVal Value As Double)
            _N_NAM = Value
        End Set
    End Property

	Public Property  XSD_TINH_SOLUONG() as double
		Get
			Return _XSD_TINH_SOLUONG
		End Get
		Set(ByVal Value as double)
			_XSD_TINH_SOLUONG = Value
		End Set
	End Property

	Public Property  XSD_TINH_NAM() as double
		Get
			Return _XSD_TINH_NAM
		End Get
		Set(ByVal Value as double)
			_XSD_TINH_NAM = Value
		End Set
	End Property

	Public Property  XSD_HUYEN_SOLUONG() as double
		Get
			Return _XSD_HUYEN_SOLUONG
		End Get
		Set(ByVal Value as double)
			_XSD_HUYEN_SOLUONG = Value
		End Set
	End Property

	Public Property  XSD_HUYEN_NAM() as double
		Get
			Return _XSD_HUYEN_NAM
		End Get
		Set(ByVal Value as double)
			_XSD_HUYEN_NAM = Value
		End Set
	End Property

	Public Property  HONG_TINH_SOLUONG() as double
		Get
			Return _HONG_TINH_SOLUONG
		End Get
		Set(ByVal Value as double)
			_HONG_TINH_SOLUONG = Value
		End Set
	End Property

	Public Property  HONG_TINH_NAM() as double
		Get
			Return _HONG_TINH_NAM
		End Get
		Set(ByVal Value as double)
			_HONG_TINH_NAM = Value
		End Set
	End Property

	Public Property  HONG_HUYEN_SOLUONG() as double
		Get
			Return _HONG_HUYEN_SOLUONG
		End Get
		Set(ByVal Value as double)
			_HONG_HUYEN_SOLUONG = Value
		End Set
	End Property

	Public Property  HONG_HUYEN_NAM() as double
		Get
			Return _HONG_HUYEN_NAM
		End Get
		Set(ByVal Value as double)
			_HONG_HUYEN_NAM = Value
		End Set
	End Property

	Public Property  CHO_THANHLY() as double
		Get
			Return _CHO_THANHLY
		End Get
		Set(ByVal Value as double)
			_CHO_THANHLY = Value
		End Set
	End Property

	Public Property  DA_THANHLY() as double
		Get
			Return _DA_THANHLY
		End Get
		Set(ByVal Value as double)
			_DA_THANHLY = Value
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

    Public Property NGUOI_NM() As Integer
        Get
            Return _NGUOI_NM
        End Get
        Set(ByVal Value As Integer)
            _NGUOI_NM = Value
        End Set
    End Property

    Public Property TC_SOLUONG() As Double
        Get
            Return _TC_SOLUONG
        End Get
        Set(ByVal Value As Double)
            _TC_SOLUONG = Value
        End Set
    End Property

End Class
