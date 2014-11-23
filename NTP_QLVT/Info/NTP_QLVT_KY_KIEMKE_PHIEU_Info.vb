public class NTP_QLVT_KY_KIEMKE_PHIEU_Info

    Private _ID_KY_KIEMKE As Int64
	private _ID_PHIEU as double
	private _LOAI_PHIEU as string
	private _NGAY_NM as date
	private _NGUOI_NM as integer

	public sub New()

	End sub

    Public Property ID_KY_KIEMKE() As Int64
        Get
            Return _ID_KY_KIEMKE
        End Get
        Set(ByVal Value As Int64)
            _ID_KY_KIEMKE = Value
        End Set
    End Property

	Public Property  ID_PHIEU() as double
		Get
			Return _ID_PHIEU
		End Get
		Set(ByVal Value as double)
			_ID_PHIEU = Value
		End Set
	End Property

	Public Property  LOAI_PHIEU() as string
		Get
			Return _LOAI_PHIEU
		End Get
		Set(ByVal Value as string)
			_LOAI_PHIEU = Value
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


End Class
