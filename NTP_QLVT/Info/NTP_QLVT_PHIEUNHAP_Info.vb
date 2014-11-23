public class NTP_QLVT_PHIEUNHAP_Info

	private _ID_PHIEUNHAP as double
	private _MA_PHIEUNHAP as string
	private _NGAY_NHAP as date
	private _NGUOI_NHAP as string
    Private _ID_KHONHAP As Integer
    Private _ID_KHOXUAT As Integer
	private _ID_NGUONKINHPHI as integer
	private _ID_LYDO_NHAPXUAT as integer
	private _GHI_CHU as string
	private _NGAY_NM as date
	private _NGUOI_NM as integer
	private _ID_PHIEUXUAT as double
    Private _ID_KY_KIEMKE As Integer
	private _TRANG_THAI as integer
    Private _NAM As Integer
    Private _SO_PHIEUXUAT As String

	public sub New()

	End sub

	Public Property  ID_PHIEUNHAP() as double
		Get
			Return _ID_PHIEUNHAP
		End Get
		Set(ByVal Value as double)
			_ID_PHIEUNHAP = Value
		End Set
	End Property

	Public Property  MA_PHIEUNHAP() as string
		Get
			Return _MA_PHIEUNHAP
		End Get
		Set(ByVal Value as string)
			_MA_PHIEUNHAP = Value
		End Set
	End Property

	Public Property  NGAY_NHAP() as date
		Get
			Return _NGAY_NHAP
		End Get
		Set(ByVal Value as date)
			_NGAY_NHAP = Value
		End Set
	End Property

	Public Property  NGUOI_NHAP() as string
		Get
			Return _NGUOI_NHAP
		End Get
		Set(ByVal Value as string)
			_NGUOI_NHAP = Value
		End Set
	End Property

    Public Property ID_KHONHAP() As Integer
        Get
            Return _ID_KHONHAP
        End Get
        Set(ByVal Value As Integer)
            _ID_KHONHAP = Value
        End Set
    End Property

    Public Property ID_KHOXUAT() As Integer
        Get
            Return _ID_KHOXUAT
        End Get
        Set(ByVal Value As Integer)
            _ID_KHOXUAT = Value
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

	Public Property  ID_LYDO_NHAPXUAT() as integer
		Get
			Return _ID_LYDO_NHAPXUAT
		End Get
		Set(ByVal Value as integer)
			_ID_LYDO_NHAPXUAT = Value
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

	Public Property  NGAY_NM() as date
		Get
			Return _NGAY_NM
		End Get
		Set(ByVal Value as date)
			_NGAY_NM = Value
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

	Public Property  ID_PHIEUXUAT() as double
		Get
			Return _ID_PHIEUXUAT
		End Get
		Set(ByVal Value as double)
			_ID_PHIEUXUAT = Value
		End Set
	End Property

    Public Property ID_KY_KIEMKE() As Integer
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Integer)
            _ID_KY_KIEMKE = Value
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

	Public Property  NAM() as integer
		Get
			Return _NAM
		End Get
		Set(ByVal Value as integer)
			_NAM = Value
		End Set
	End Property

    Public Property SO_PHIEUXUAT() As String
        Get
            Return _SO_PHIEUXUAT
        End Get
        Set(ByVal Value As String)
            _SO_PHIEUXUAT = Value
        End Set
    End Property
End Class
