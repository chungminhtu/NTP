public class NTP_CU_THUOC_IMPORT_Info

	private _ID_IMPORT as double
	private _ID_KHO as double
	private _ID_THUOC as integer
	private _ID_NGUONKINHPHI as integer
	private _NGAY_NHAP_KHO as date
	private _LO_SX as string
	private _HAN_DUNG as date
	private _SO_LUONG as double
	private _NGAY_NM as date
    Private _NGUOI_NM As Integer
    Private _TRANG_THAI As Integer
    Private _MA_PHIEU As String
    Private _NGAY_SX As Date
    Private _NGUOI_VIETPHIEU As String
    Private _LOAI_NHAP As Integer

	public sub New()

	End sub

	Public Property  ID_IMPORT() as double
		Get
			Return _ID_IMPORT
		End Get
		Set(ByVal Value as double)
			_ID_IMPORT = Value
		End Set
	End Property

	Public Property  ID_KHO() as double
		Get
			Return _ID_KHO
		End Get
		Set(ByVal Value as double)
			_ID_KHO = Value
		End Set
	End Property

	Public Property  ID_THUOC() as integer
		Get
			Return _ID_THUOC
		End Get
		Set(ByVal Value as integer)
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

	Public Property  NGAY_NHAP_KHO() as date
		Get
			Return _NGAY_NHAP_KHO
		End Get
		Set(ByVal Value as date)
			_NGAY_NHAP_KHO = Value
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

	Public Property  SO_LUONG() as double
		Get
			Return _SO_LUONG
		End Get
		Set(ByVal Value as double)
			_SO_LUONG = Value
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

    Public Property TRANG_THAI() As Integer
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal Value As Integer)
            _TRANG_THAI = Value
        End Set
    End Property

    Public Property MA_PHIEU() As String
        Get
            Return _MA_PHIEU
        End Get
        Set(ByVal value As String)
            _MA_PHIEU = value
        End Set
    End Property

    Public Property NGAY_SX() As Date
        Get
            Return _NGAY_SX
        End Get
        Set(ByVal value As Date)
            _NGAY_SX = value
        End Set
    End Property

    Public Property NGUOI_VIETPHIEU() As String
        Get
            Return _NGUOI_VIETPHIEU
        End Get
        Set(ByVal value As String)
            _NGUOI_VIETPHIEU = value
        End Set
    End Property

    Public Property LOAI_NHAP() As Integer
        Get
            Return _LOAI_NHAP
        End Get
        Set(ByVal value As Integer)
            _LOAI_NHAP = value
        End Set
    End Property
End Class
