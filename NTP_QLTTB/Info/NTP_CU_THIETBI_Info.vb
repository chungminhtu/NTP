public class NTP_CU_THIETBI_Info

	private _ID_BAOCAO as double
	private _NAM as integer
    Private _QUY As String
	private _NGUOI_TAO as integer
	private _NGAY_TAO as date
	private _ID_BENHVIEN_KHO as double
	private _ID_MATINH as string
	private _TRANG_THAI as integer
	private _NGUOI_PHEDUYET as integer
	private _NGAY_PHEDUYET as date

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

    Public Property QUY() As String
        Get
            Return _QUY
        End Get
        Set(ByVal Value As String)
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

	Public Property  NGAY_TAO() as date
		Get
			Return _NGAY_TAO
		End Get
		Set(ByVal Value as date)
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

	Public Property  TRANG_THAI() as integer
		Get
			Return _TRANG_THAI
		End Get
		Set(ByVal Value as integer)
			_TRANG_THAI = Value
		End Set
	End Property

	Public Property  NGUOI_PHEDUYET() as integer
		Get
			Return _NGUOI_PHEDUYET
		End Get
		Set(ByVal Value as integer)
			_NGUOI_PHEDUYET = Value
		End Set
	End Property

	Public Property  NGAY_PHEDUYET() as date
		Get
			Return _NGAY_PHEDUYET
		End Get
		Set(ByVal Value as date)
			_NGAY_PHEDUYET = Value
		End Set
	End Property


End Class
