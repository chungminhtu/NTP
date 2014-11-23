'
' DotNetNuke® - http://www.dotnetnuke.com
' Copyright (c) 2002-2006
' by Perpetual Motion Interactive Systems Inc. ( http://www.perpetualmotion.ca )
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'

Imports System
Imports System.Configuration
Imports System.Data

Namespace YourCompany.Modules.NTP_BN_BC_KETQUADT

    ''' <summary>
    ''' The Info class for NTP_BN_BC_KETQUADT
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_BC_KETQUADTInfo


#Region "Private Members"
        Dim _ngayBCIn As String
        Dim _iD_BC_KetquaDT As Integer
        Dim _quy As Byte
        Dim _nam As Integer
        Dim _dVBaocao As String
        Dim _mA_TINH As String
        Dim _mA_HUYEN As String
        Dim _nguoiBC As String
        Dim _ngayBC As DateTime
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _huyenXN As Boolean
        Dim _tinhXN As Boolean
        Dim _tinhXNTT As Boolean
        Dim _pTNhap As Boolean
        Dim _Ten_Huyen As String
        Dim _Ten_Tinh As String
        Dim _Ten_Benhvien As String

#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_BC_KetquaDT As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal Ten_Huyen As String, ByVal Ten_Tinh As String)
            Me.ID_BC_KetquaDT = iD_BC_KetquaDT
            Me.Quy = quy
            Me.Nam = nam
            Me.DVBaocao = dVBaocao
            Me.MA_TINH = mA_TINH
            Me.MA_HUYEN = mA_HUYEN
            Me.NguoiBC = nguoiBC
            Me.NgayBC = ngayBC
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.HuyenXN = huyenXN
            Me.TinhXN = tinhXN
            Me.PTNhap = pTNhap
            Me.Ten_Tinh = Ten_Tinh
            Me.Ten_Huyen = Ten_Huyen
        End Sub
#End Region

#Region "Public Properties"
        Public Property NgayBCIn() As String
            Get
                Return _ngayBCIn
            End Get
            Set(ByVal Value As String)
                _ngayBCIn = Value
            End Set
        End Property
        Public Property ID_BC_KetquaDT() As Integer
            Get
                Return _iD_BC_KetquaDT
            End Get
            Set(ByVal Value As Integer)
                _iD_BC_KetquaDT = Value
            End Set
        End Property

        Public Property Quy() As Byte
            Get
                Return _quy
            End Get
            Set(ByVal Value As Byte)
                _quy = Value
            End Set
        End Property

        Public Property Nam() As Integer
            Get
                Return _nam
            End Get
            Set(ByVal Value As Integer)
                _nam = Value
            End Set
        End Property

        Public Property DVBaocao() As String
            Get
                Return _dVBaocao
            End Get
            Set(ByVal Value As String)
                _dVBaocao = Value
            End Set
        End Property

        Public Property MA_TINH() As String
            Get
                Return _mA_TINH
            End Get
            Set(ByVal Value As String)
                _mA_TINH = Value
            End Set
        End Property

        Public Property MA_HUYEN() As String
            Get
                Return _mA_HUYEN
            End Get
            Set(ByVal Value As String)
                _mA_HUYEN = Value
            End Set
        End Property

        Public Property NguoiBC() As String
            Get
                Return _nguoiBC
            End Get
            Set(ByVal Value As String)
                _nguoiBC = Value
            End Set
        End Property

        Public Property NgayBC() As DateTime
            Get
                Return _ngayBC
            End Get
            Set(ByVal Value As DateTime)
                _ngayBC = Value
            End Set
        End Property

        Public Property NGAY_NM() As DateTime
            Get
                Return _nGAY_NM
            End Get
            Set(ByVal Value As DateTime)
                _nGAY_NM = Value
            End Set
        End Property

        Public Property NGUOI_NM() As Integer
            Get
                Return _nGUOI_NM
            End Get
            Set(ByVal Value As Integer)
                _nGUOI_NM = Value
            End Set
        End Property

        Public Property HuyenXN() As Boolean
            Get
                Return _huyenXN
            End Get
            Set(ByVal Value As Boolean)
                _huyenXN = Value
            End Set
        End Property

        Public Property TinhXN() As Boolean
            Get
                Return _tinhXN
            End Get
            Set(ByVal Value As Boolean)
                _tinhXN = Value
            End Set
        End Property
        Public Property TinhXNTT() As Boolean
            Get
                Return _tinhXNTT
            End Get
            Set(ByVal Value As Boolean)
                _tinhXNTT = Value
            End Set
        End Property
        Public Property PTNhap() As Boolean
            Get
                Return _pTNhap
            End Get
            Set(ByVal Value As Boolean)
                _pTNhap = Value
            End Set
        End Property
        Public Property Ten_Tinh() As String
            Get
                Return _Ten_Tinh
            End Get
            Set(ByVal Value As String)
                _Ten_Tinh = Value
            End Set
        End Property
        Public Property Ten_Huyen() As String
            Get
                Return _Ten_Huyen
            End Get
            Set(ByVal Value As String)
                _Ten_Huyen = Value
            End Set
        End Property
        Public Property Ten_Benhvien() As String
            Get
                Return _Ten_Benhvien
            End Get
            Set(ByVal Value As String)
                _Ten_Benhvien = Value
            End Set
        End Property
#End Region


    End Class
    Public Class NTP_BN_BC_KETQUADTPInfo

#Region "Private Members"
        Dim _iD_BC_KetquaDTP1 As Integer
        Dim _iD_BC_KetquaDT As Integer
        Dim _iD_Phanloai As Byte
        Dim _soBNDK As Integer
        Dim _tongsoBNDK As Integer
        Dim _khoi As Integer
        Dim _hoanthanh As Integer
        Dim _chet As Integer
        Dim _thatbai As Integer
        Dim _bo As Integer
        Dim _chuyen As Integer
        Dim _khongdanhgia As Integer
        Dim _TEN_PHANLOAIBN As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_BC_KetquaDTP1 As Integer, ByVal iD_BC_KetquaDT As Integer, ByVal iD_Phanloai As Byte, ByVal soBNDK As Integer, ByVal khoi As Integer, ByVal hoanthanh As Integer, ByVal chet As Integer, ByVal thatbai As Integer, ByVal bo As Integer, ByVal chuyen As Integer, ByVal khongdanhgia As Integer, ByVal TEN_PHANLOAIBN As String)
            Me.ID_BC_KetquaDTP1 = iD_BC_KetquaDTP1
            Me.ID_BC_KetquaDT = iD_BC_KetquaDT
            Me.ID_Phanloai = iD_Phanloai
            Me.SoBNDK = soBNDK
            Me.Khoi = khoi
            Me.Hoanthanh = hoanthanh
            Me.Chet = chet
            Me.Thatbai = thatbai
            Me.Bo = bo
            Me.Chuyen = chuyen
            Me.Khongdanhgia = khongdanhgia
            Me.TEN_PHANLOAIBN = TEN_PHANLOAIBN
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_BC_KetquaDTP1() As Integer
            Get
                Return _iD_BC_KetquaDTP1
            End Get
            Set(ByVal Value As Integer)
                _iD_BC_KetquaDTP1 = Value
            End Set
        End Property

        Public Property ID_BC_KetquaDT() As Integer
            Get
                Return _iD_BC_KetquaDT
            End Get
            Set(ByVal Value As Integer)
                _iD_BC_KetquaDT = Value
            End Set
        End Property

        Public Property ID_Phanloai() As Byte
            Get
                Return _iD_Phanloai
            End Get
            Set(ByVal Value As Byte)
                _iD_Phanloai = Value
            End Set
        End Property

        Public Property SoBNDK() As Integer
            Get
                Return _soBNDK
            End Get
            Set(ByVal Value As Integer)
                _soBNDK = Value
            End Set
        End Property
        Public Property tongsoBNDK() As Integer
            Get
                Return _tongsoBNDK
            End Get
            Set(ByVal Value As Integer)
                _tongsoBNDK = Value
            End Set
        End Property
        Public Property Khoi() As Integer
            Get
                Return _khoi
            End Get
            Set(ByVal Value As Integer)
                _khoi = Value
            End Set
        End Property

        Public Property Hoanthanh() As Integer
            Get
                Return _hoanthanh
            End Get
            Set(ByVal Value As Integer)
                _hoanthanh = Value
            End Set
        End Property

        Public Property Chet() As Integer
            Get
                Return _chet
            End Get
            Set(ByVal Value As Integer)
                _chet = Value
            End Set
        End Property

        Public Property Thatbai() As Integer
            Get
                Return _thatbai
            End Get
            Set(ByVal Value As Integer)
                _thatbai = Value
            End Set
        End Property

        Public Property Bo() As Integer
            Get
                Return _bo
            End Get
            Set(ByVal Value As Integer)
                _bo = Value
            End Set
        End Property

        Public Property Chuyen() As Integer
            Get
                Return _chuyen
            End Get
            Set(ByVal Value As Integer)
                _chuyen = Value
            End Set
        End Property

        Public Property Khongdanhgia() As Integer
            Get
                Return _khongdanhgia
            End Get
            Set(ByVal Value As Integer)
                _khongdanhgia = Value
            End Set
        End Property
        Public Property TEN_PHANLOAIBN() As String
            Get
                Return _TEN_PHANLOAIBN
            End Get
            Set(ByVal Value As String)
                _TEN_PHANLOAIBN = Value
            End Set
        End Property

#End Region

    End Class

    Public Class NTP_BN_BC_KETQUADTP2Info

#Region "Private Members"
        Dim _iD_BC_KetquaDT_P2 As Integer
        Dim _iD_BC_KetquaDT As Integer
        Dim _phanloai As Byte
        Dim _xNHIV As Integer
        Dim _duongHIV As Integer
        Dim _cPT As Integer
        Dim _aRV As Integer
        Dim _TEN_PHANLOAIBN As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_BC_KetquaDT_P2 As Integer, ByVal iD_BC_KetquaDT As Integer, ByVal phanloai As Byte, ByVal xNHIV As Decimal, ByVal duongHIV As Integer, ByVal cPT As Integer, ByVal aRV As Integer, ByVal TEN_PHANLOAIBN As String)
            Me.ID_BC_KetquaDT_P2 = iD_BC_KetquaDT_P2
            Me.ID_BC_KetquaDT = iD_BC_KetquaDT
            Me.Phanloai = phanloai
            Me.XNHIV = xNHIV
            Me.DuongHIV = duongHIV
            Me.CPT = cPT
            Me.ARV = aRV
            Me.TEN_PHANLOAIBN = TEN_PHANLOAIBN
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_BC_KetquaDT_P2() As Integer
            Get
                Return _iD_BC_KetquaDT_P2
            End Get
            Set(ByVal Value As Integer)
                _iD_BC_KetquaDT_P2 = Value
            End Set
        End Property

        Public Property ID_BC_KetquaDT() As Integer
            Get
                Return _iD_BC_KetquaDT
            End Get
            Set(ByVal Value As Integer)
                _iD_BC_KetquaDT = Value
            End Set
        End Property

        Public Property Phanloai() As Byte
            Get
                Return _phanloai
            End Get
            Set(ByVal Value As Byte)
                _phanloai = Value
            End Set
        End Property

        Public Property XNHIV() As Integer
            Get
                Return _xNHIV
            End Get
            Set(ByVal Value As Integer)
                _xNHIV = Value
            End Set
        End Property

        Public Property DuongHIV() As Integer
            Get
                Return _duongHIV
            End Get
            Set(ByVal Value As Integer)
                _duongHIV = Value
            End Set
        End Property

        Public Property CPT() As Integer
            Get
                Return _cPT
            End Get
            Set(ByVal Value As Integer)
                _cPT = Value
            End Set
        End Property

        Public Property ARV() As Integer
            Get
                Return _aRV
            End Get
            Set(ByVal Value As Integer)
                _aRV = Value
            End Set
        End Property
        Public Property TEN_PHANLOAIBN() As String
            Get
                Return _TEN_PHANLOAIBN
            End Get
            Set(ByVal Value As String)
                _TEN_PHANLOAIBN = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_BN_BCKETQUADIEUTRILAOINInfo

#Region "Private Members"
        Dim _iD_PHANLOAI As Byte
        Dim _tEN_VUNG As String
        Dim _tEN_MIEN As String
        Dim _tEN_TINH As String
        Dim _tEN_PHANLOAI As String
        Dim _kHOI As Integer
        Dim _hOANTHANH As Integer
        Dim _cHET As Integer
        Dim _tHATBAI As Integer
        Dim _bOTRI As Integer
        Dim _cHUYEN As Integer
        Dim _kHONGDANHGIA As Integer
        Dim _tONGSOBNDK As Integer
        Dim _Dieukien As String

#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_PHANLOAI As Byte, ByVal tEN_VUNG As String, ByVal tEN_MIEN As String, ByVal tEN_TINH As String, ByVal tEN_PHANLOAI As String, ByVal kHOI As Integer, ByVal hOANTHANH As Integer, ByVal cHET As Integer, ByVal tHATBAI As Integer, ByVal bOTRI As Integer, ByVal cHUYEN As Integer, ByVal kHONGDANHGIA As Integer, ByVal tONGSOBNDK As Integer)
            Me.ID_PHANLOAI = ID_PHANLOAI
            Me.TEN_VUNG = TEN_VUNG
            Me.TEN_MIEN = TEN_MIEN
            Me.TEN_TINH = TEN_TINH
            Me.TEN_PHANLOAI = TEN_PHANLOAI
            Me.KHOI = KHOI
            Me.HOANTHANH = HOANTHANH
            Me.CHET = CHET
            Me.THATBAI = THATBAI
            Me.BOTRI = BOTRI
            Me.CHUYEN = CHUYEN
            Me.KHONGDANHGIA = KHONGDANHGIA
            Me.TONGSOBNDK = TONGSOBNDK
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_PHANLOAI() As Byte
            Get
                Return _iD_PHANLOAI
            End Get
            Set(ByVal Value As Byte)
                _iD_PHANLOAI = Value
            End Set
        End Property

        Public Property TEN_VUNG() As String
            Get
                Return _tEN_VUNG
            End Get
            Set(ByVal Value As String)
                _tEN_VUNG = Value
            End Set
        End Property

        Public Property TEN_MIEN() As String
            Get
                Return _tEN_MIEN
            End Get
            Set(ByVal Value As String)
                _tEN_MIEN = Value
            End Set
        End Property

        Public Property TEN_TINH() As String
            Get
                Return _tEN_TINH
            End Get
            Set(ByVal Value As String)
                _tEN_TINH = Value
            End Set
        End Property

        Public Property TEN_PHANLOAI() As String
            Get
                Return _tEN_PHANLOAI
            End Get
            Set(ByVal Value As String)
                _tEN_PHANLOAI = Value
            End Set
        End Property

        Public Property KHOI() As Integer
            Get
                Return _kHOI
            End Get
            Set(ByVal Value As Integer)
                _kHOI = Value
            End Set
        End Property

        Public Property HOANTHANH() As Integer
            Get
                Return _hOANTHANH
            End Get
            Set(ByVal Value As Integer)
                _hOANTHANH = Value
            End Set
        End Property

        Public Property CHET() As Integer
            Get
                Return _cHET
            End Get
            Set(ByVal Value As Integer)
                _cHET = Value
            End Set
        End Property

        Public Property THATBAI() As Integer
            Get
                Return _tHATBAI
            End Get
            Set(ByVal Value As Integer)
                _tHATBAI = Value
            End Set
        End Property

        Public Property BOTRI() As Integer
            Get
                Return _bOTRI
            End Get
            Set(ByVal Value As Integer)
                _bOTRI = Value
            End Set
        End Property

        Public Property CHUYEN() As Integer
            Get
                Return _cHUYEN
            End Get
            Set(ByVal Value As Integer)
                _cHUYEN = Value
            End Set
        End Property

        Public Property KHONGDANHGIA() As Integer
            Get
                Return _kHONGDANHGIA
            End Get
            Set(ByVal Value As Integer)
                _kHONGDANHGIA = Value
            End Set
        End Property

        Public Property TONGSOBNDK() As Integer
            Get
                Return _tONGSOBNDK
            End Get
            Set(ByVal Value As Integer)
                _tONGSOBNDK = Value
            End Set
        End Property
        Public Property Dieukien() As String
            Get
                Return _Dieukien
            End Get
            Set(ByVal Value As String)
                _Dieukien = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_DM_MIENInfo

#Region "Private Members"
        Dim _iD_Mien As Integer
        Dim _tEN_MIEN As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Mien As Integer, ByVal tEN_MIEN As String)
            Me.ID_Mien = ID_Mien
            Me.TEN_MIEN = TEN_MIEN
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_Mien() As Integer
            Get
                Return _iD_Mien
            End Get
            Set(ByVal Value As Integer)
                _iD_Mien = Value
            End Set
        End Property

        Public Property TEN_MIEN() As String
            Get
                Return _tEN_MIEN
            End Get
            Set(ByVal Value As String)
                _tEN_MIEN = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_DM_VUNGInfo

#Region "Private Members"
        Dim _iD_VUNG As Integer
        Dim _tEN_VUNG As String
        Dim _iD_MIEN As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_VUNG As Integer, ByVal tEN_VUNG As String, ByVal iD_MIEN As Integer)
            Me.ID_VUNG = ID_VUNG
            Me.TEN_VUNG = TEN_VUNG
            Me.ID_MIEN = ID_MIEN
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_VUNG() As Integer
            Get
                Return _iD_VUNG
            End Get
            Set(ByVal Value As Integer)
                _iD_VUNG = Value
            End Set
        End Property

        Public Property TEN_VUNG() As String
            Get
                Return _tEN_VUNG
            End Get
            Set(ByVal Value As String)
                _tEN_VUNG = Value
            End Set
        End Property

        Public Property ID_MIEN() As Integer
            Get
                Return _iD_MIEN
            End Get
            Set(ByVal Value As Integer)
                _iD_MIEN = Value
            End Set
        End Property
#End Region
    End Class
    Public Class NTP_DM_TINHInfo

#Region "Private Members"
        Dim _MA_TINH As String
        Dim _TEN_TINH As String
        Dim _ID_BENHVIEN As String
#End Region


#Region "Public Properties"
        Public Property TEN_TINH() As String
            Get
                Return _TEN_TINH
            End Get
            Set(ByVal Value As String)
                _TEN_TINH = Value
            End Set
        End Property

        Public Property MA_TINH() As String
            Get
                Return _MA_TINH
            End Get
            Set(ByVal Value As String)
                _MA_TINH = Value
            End Set
        End Property
        Public Property ID_BENHVIEN() As String
            Get
                Return _ID_BENHVIEN
            End Get
            Set(ByVal Value As String)
                _ID_BENHVIEN = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_DM_BENHVIENInfo

#Region "Private Members"
        Dim _ID_BENHVIEN As String
        Dim _TEN_BENHVIEN As String

#End Region


#Region "Public Properties"
        Public Property TEN_BENHVIEN() As String
            Get
                Return _TEN_BENHVIEN
            End Get
            Set(ByVal Value As String)
                _TEN_BENHVIEN = Value
            End Set
        End Property

  Public Property ID_BENHVIEN() As String
            Get
                Return _ID_BENHVIEN
            End Get
            Set(ByVal Value As String)
                _ID_BENHVIEN = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_DM_LOAIBVInfo

#Region "Private Members"
        Dim _iD_LoaiBV As String
        Dim _tEN_LoaiBV As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_LOAIBV As String, ByVal tEN_LOAIBV As String)
            Me.iD_LOAIBV = iD_LOAIBV
            Me.tEN_LOAIBV = tEN_LOAIBV
        End Sub
#End Region

#Region "Public Properties"
        Public Property iD_LOAIBV() As String
            Get
                Return _iD_LoaiBV
            End Get
            Set(ByVal Value As String)
                _iD_LoaiBV = Value
            End Set
        End Property

        Public Property tEN_LOAIBV() As String
            Get
                Return _tEN_LoaiBV
            End Get
            Set(ByVal Value As String)
                _tEN_LoaiBV = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
