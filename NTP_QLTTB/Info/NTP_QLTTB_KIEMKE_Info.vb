public class NTP_QLTTB_KIEMKE_Info

	private _ID_KIEMKE as double
    Private _ID_KHO As Int64
	private _NGAY_KIEMKE as date
	private _NGUOI_KIEMKE as integer
    Private _ID_KY_KIEMKE As Int64
    Private _GHI_CHU As String
    Private _TRANG_THAI As Int16
    Private _ID_NGUONKINHPHI As Int16

	public sub New()

	End sub

	Public Property  ID_KIEMKE() as double
		Get
			Return _ID_KIEMKE
		End Get
		Set(ByVal Value as double)
			_ID_KIEMKE = Value
		End Set
	End Property

    Public Property ID_KHO() As Int64
        Get
            Return _ID_KHO
        End Get
        Set(ByVal Value As Int64)
            _ID_KHO = Value
        End Set
    End Property

	Public Property  NGAY_KIEMKE() as date
		Get
			Return _NGAY_KIEMKE
		End Get
		Set(ByVal Value as date)
			_NGAY_KIEMKE = Value
		End Set
	End Property

	Public Property  NGUOI_KIEMKE() as integer
		Get
			Return _NGUOI_KIEMKE
		End Get
		Set(ByVal Value as integer)
			_NGUOI_KIEMKE = Value
		End Set
	End Property

    Public Property ID_KY_KIEMKE() As Int64
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Int64)
            _ID_KY_KIEMKE = Value
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

    Public Property TRANG_THAI() As Int16
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal Value As Int16)
            _TRANG_THAI = Value
        End Set
    End Property

    Public Property ID_NGUONKINHPHI() As Int16
        Get
            Return _ID_NGUONKINHPHI
        End Get
        Set(ByVal Value As Int16)
            _ID_NGUONKINHPHI = Value
        End Set
    End Property
End Class
