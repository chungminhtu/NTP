public class NTP_CU_SUDUNGTHUOC_Info

	private _ID_BAOCAO as double
	private _NAM as integer
	private _QUY as integer
	private _NGUOI_TAO as integer
    Private _NGAY_TAO As Date
	private _ID_BENHVIEN_KHO as double
	private _ID_MATINH as string

	public sub New()

	End sub

	Public Property  ID_BAOCAO() as double
		Get
			Return _ID_BAOCAO
		End Get
		Set(ByVal Value as double)
			_ID_BAOCAO = Value
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

	Public Property  QUY() as integer
		Get
			Return _QUY
		End Get
		Set(ByVal Value as integer)
			_QUY = Value
		End Set
	End Property

	Public Property  NGUOI_TAO() as integer
		Get
			Return _NGUOI_TAO
		End Get
		Set(ByVal Value as integer)
			_NGUOI_TAO = Value
		End Set
	End Property

    Public Property NGAY_TAO() As Date
        Get
            Return _NGAY_TAO
        End Get
        Set(ByVal Value As Date)
            _NGAY_TAO = Value
        End Set
    End Property

	Public Property  ID_BENHVIEN_KHO() as double
		Get
			Return _ID_BENHVIEN_KHO
		End Get
		Set(ByVal Value as double)
			_ID_BENHVIEN_KHO = Value
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


End Class
