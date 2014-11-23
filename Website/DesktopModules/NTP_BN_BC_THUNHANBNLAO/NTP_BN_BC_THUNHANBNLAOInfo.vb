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

Namespace YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO

    ''' <summary>
    ''' The Info class for NTP_BN_BC_THUNHANBNLAO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_BC_THUNHANBNLAOInfo

#Region "Private Members"
        Dim _iD_BCThunhanBNLao As Integer

        Dim _quy As Byte
        Dim _nam As Integer
        Dim _dVBaocao As String
        Dim _nguoiBC As String
        Dim _ngayBC As DateTime
        Dim _huyenXN As Boolean
        Dim _tinhXN As Boolean
        Dim _pTNhap As Boolean
        Dim _mA_TINH As String
        Dim _mA_HUYEN As String
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _Ten_Huyen As String
        Dim _Ten_Tinh As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_BCThunhanBNLao As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal Ten_Huyen As String, ByVal Ten_Tinh As String)
            Me.ID_BCThunhanBNLao = iD_BCThunhanBNLao
            Me.Quy = quy
            Me.Nam = nam
            Me.DVBaocao = dVBaocao
            Me.NguoiBC = nguoiBC
            Me.NgayBC = ngayBC
            Me.HuyenXN = huyenXN
            Me.TinhXN = tinhXN
            Me.PTNhap = pTNhap
            Me.MA_TINH = mA_TINH
            Me.MA_HUYEN = mA_HUYEN
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.Ten_Tinh = Ten_Tinh
            Me.Ten_Huyen = Ten_Huyen
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_BCThunhanBNLao() As Integer
            Get
                Return _iD_BCThunhanBNLao
            End Get
            Set(ByVal Value As Integer)
                _iD_BCThunhanBNLao = Value
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

        Public Property PTNhap() As Boolean
            Get
                Return _pTNhap
            End Get
            Set(ByVal Value As Boolean)
                _pTNhap = Value
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
#End Region

    End Class
    Public Class NTP_BN_BC_THUNHANBNLAOP1Info

#Region "Private Members"
        Dim _iD_BCThunhanBNLao As Integer
        Dim _phanloai As Long
        Dim _iD_BCThunhanBNLaoP1 As Integer
        Dim _Moi As Integer
        Dim _taiphat As Integer
        Dim _thatbai As Integer
        Dim _taitri As Integer
        Dim _aFBKhac As Integer
        Dim _amNho As Integer
        Dim _amTrung As Integer
        Dim _amLon As Integer
        Dim _ngoaiPhoiNho As Integer
        Dim _ngoaiPhoiTrung As Integer
        Dim _ngoaiPhoiLon As Integer
        Dim _ngoaiphoiKhac As Integer
        Dim _TEN_PHANLOAI As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal iD_BCThunhanBNLaoP1 As Integer, ByVal moi As Integer, ByVal taiphat As Integer, ByVal thatbai As Integer, ByVal taitri As Integer, ByVal aFBKhac As Integer, ByVal amNho As Integer, ByVal amTrung As Integer, ByVal amLon As Integer, ByVal ngoaiPhoiNho As Integer, ByVal ngoaiPhoiTrung As Integer, ByVal ngoaiPhoiLon As Integer, ByVal ngoaiphoiKhac As Integer, ByVal TEN_PHANLOAI As String)
            Me.ID_BCThunhanBNLaoP1 = iD_BCThunhanBNLaoP1
            Me.ID_BCThunhanBNLao = iD_BCThunhanBNLao
            Me.Phanloai = phanloai
            Me.Moi = moi
            Me.Taiphat = taiphat
            Me.Thatbai = thatbai
            Me.Taitri = taitri
            Me.AFBKhac = aFBKhac
            Me.AmNho = amNho
            Me.AmTrung = amTrung
            Me.AmLon = amLon
            Me.NgoaiPhoiNho = ngoaiPhoiNho
            Me.NgoaiPhoiTrung = ngoaiPhoiTrung
            Me.NgoaiPhoiLon = ngoaiPhoiLon
            Me.NgoaiphoiKhac = ngoaiphoiKhac
            Me.TEN_PHANLOAI = TEN_PHANLOAI
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_BCThunhanBNLao() As Integer
            Get
                Return _iD_BCThunhanBNLao
            End Get
            Set(ByVal Value As Integer)
                _iD_BCThunhanBNLao = Value
            End Set
        End Property

        Public Property Phanloai() As Long
            Get
                Return _phanloai
            End Get
            Set(ByVal Value As Long)
                _phanloai = Value
            End Set
        End Property

        Public Property ID_BCThunhanBNLaoP1() As Integer
            Get
                Return _iD_BCThunhanBNLaoP1
            End Get
            Set(ByVal Value As Integer)
                _iD_BCThunhanBNLaoP1 = Value
            End Set
        End Property

        Public Property Moi() As Integer
            Get
                Return _moi
            End Get
            Set(ByVal Value As Integer)
                _moi = Value
            End Set
        End Property

        Public Property Taiphat() As Integer
            Get
                Return _taiphat
            End Get
            Set(ByVal Value As Integer)
                _taiphat = Value
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

        Public Property Taitri() As Integer
            Get
                Return _taitri
            End Get
            Set(ByVal Value As Integer)
                _taitri = Value
            End Set
        End Property

        Public Property AFBKhac() As Integer
            Get
                Return _aFBKhac
            End Get
            Set(ByVal Value As Integer)
                _aFBKhac = Value
            End Set
        End Property

        Public Property AmNho() As Integer
            Get
                Return _amNho
            End Get
            Set(ByVal Value As Integer)
                _amNho = Value
            End Set
        End Property

        Public Property AmTrung() As Integer
            Get
                Return _amTrung
            End Get
            Set(ByVal Value As Integer)
                _amTrung = Value
            End Set
        End Property

        Public Property AmLon() As Integer
            Get
                Return _amLon
            End Get
            Set(ByVal Value As Integer)
                _amLon = Value
            End Set
        End Property

        Public Property NgoaiPhoiNho() As Integer
            Get
                Return _ngoaiPhoiNho
            End Get
            Set(ByVal Value As Integer)
                _ngoaiPhoiNho = Value
            End Set
        End Property

        Public Property NgoaiPhoiTrung() As Integer
            Get
                Return _ngoaiPhoiTrung
            End Get
            Set(ByVal Value As Integer)
                _ngoaiPhoiTrung = Value
            End Set
        End Property

        Public Property NgoaiPhoiLon() As Integer
            Get
                Return _ngoaiPhoiLon
            End Get
            Set(ByVal Value As Integer)
                _ngoaiPhoiLon = Value
            End Set
        End Property

        Public Property NgoaiphoiKhac() As Integer
            Get
                Return _ngoaiphoiKhac
            End Get
            Set(ByVal Value As Integer)
                _ngoaiphoiKhac = Value
            End Set
        End Property
        Public Property TEN_PHANLOAI() As String
            Get
                Return _TEN_PHANLOAI
            End Get
            Set(ByVal Value As String)
                _TEN_PHANLOAI = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_BN_BC_THUNHANBNLAOP2Info

#Region "Private Members"
        Dim _iD_BCThunhanBNLao As Integer
        Dim _phanloai As Long
        Dim _iD_BCThunhanBNLaoP2 As Integer
        Dim _nam0 As Integer
        Dim _nu0 As Integer
        Dim _nam5 As Integer
        Dim _nu5 As Integer
        Dim _nam15 As Integer
        Dim _nu15 As Integer
        Dim _nam25 As Integer
        Dim _nu25 As Integer
        Dim _nam35 As Integer
        Dim _nu35 As Integer
        Dim _nam45 As Integer
        Dim _nu45 As Integer
        Dim _nam55 As Integer
        Dim _nu55 As Integer
        Dim _nam65 As Integer
        Dim _nu65 As Integer
        Dim _TEN_PHANLOAI As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal iD_BCThunhanBNLaoP2 As Integer, ByVal nam0 As Integer, ByVal nu0 As Integer, ByVal nam5 As Integer, ByVal nu5 As Integer, ByVal nam15 As Integer, ByVal nu15 As Integer, ByVal nam25 As Integer, ByVal nu25 As Integer, ByVal nam35 As Integer, ByVal nu35 As Integer, ByVal nam45 As Integer, ByVal nu45 As Integer, ByVal nam55 As Integer, ByVal nu55 As Integer, ByVal nam65 As Integer, ByVal nu65 As Integer, ByVal TEN_PHANLOAI As String)
            Me.ID_BCThunhanBNLaoP2 = iD_BCThunhanBNLaoP2
            Me.ID_BCThunhanBNLao = iD_BCThunhanBNLao
            Me.Phanloai = phanloai
            Me.Nam0 = nam0
            Me.Nu0 = nu0
            Me.Nam5 = nam5
            Me.Nu5 = nu5
            Me.Nam15 = nam15
            Me.Nu15 = nu15
            Me.Nam25 = nam25
            Me.Nu25 = nu25
            Me.Nam35 = nam35
            Me.Nu35 = nu35
            Me.Nam45 = nam45
            Me.Nu45 = nu45
            Me.Nam55 = nam55
            Me.Nu55 = nu55
            Me.Nam65 = nam65
            Me.Nu65 = nu65
            Me.TEN_PHANLOAI = TEN_PHANLOAI
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_BCThunhanBNLao() As Integer
            Get
                Return _iD_BCThunhanBNLao
            End Get
            Set(ByVal Value As Integer)
                _iD_BCThunhanBNLao = Value
            End Set
        End Property

        Public Property Phanloai() As Long
            Get
                Return _phanloai
            End Get
            Set(ByVal Value As Long)
                _phanloai = Value
            End Set
        End Property

        Public Property ID_BCThunhanBNLaoP2() As Integer
            Get
                Return _iD_BCThunhanBNLaoP2
            End Get
            Set(ByVal Value As Integer)
                _iD_BCThunhanBNLaoP2 = Value
            End Set
        End Property

        Public Property Nam0() As Integer
            Get
                Return _nam0
            End Get
            Set(ByVal Value As Integer)
                _nam0 = Value
            End Set
        End Property

        Public Property Nu0() As Integer
            Get
                Return _nu0
            End Get
            Set(ByVal Value As Integer)
                _nu0 = Value
            End Set
        End Property

        Public Property Nam5() As Integer
            Get
                Return _nam5
            End Get
            Set(ByVal Value As Integer)
                _nam5 = Value
            End Set
        End Property

        Public Property Nu5() As Integer
            Get
                Return _nu5
            End Get
            Set(ByVal Value As Integer)
                _nu5 = Value
            End Set
        End Property

        Public Property Nam15() As Integer
            Get
                Return _nam15
            End Get
            Set(ByVal Value As Integer)
                _nam15 = Value
            End Set
        End Property

        Public Property Nu15() As Integer
            Get
                Return _nu15
            End Get
            Set(ByVal Value As Integer)
                _nu15 = Value
            End Set
        End Property

        Public Property Nam25() As Integer
            Get
                Return _nam25
            End Get
            Set(ByVal Value As Integer)
                _nam25 = Value
            End Set
        End Property

        Public Property Nu25() As Integer
            Get
                Return _nu25
            End Get
            Set(ByVal Value As Integer)
                _nu25 = Value
            End Set
        End Property

        Public Property Nam35() As Integer
            Get
                Return _nam35
            End Get
            Set(ByVal Value As Integer)
                _nam35 = Value
            End Set
        End Property

        Public Property Nu35() As Integer
            Get
                Return _nu35
            End Get
            Set(ByVal Value As Integer)
                _nu35 = Value
            End Set
        End Property

        Public Property Nam45() As Integer
            Get
                Return _nam45
            End Get
            Set(ByVal Value As Integer)
                _nam45 = Value
            End Set
        End Property

        Public Property Nu45() As Integer
            Get
                Return _nu45
            End Get
            Set(ByVal Value As Integer)
                _nu45 = Value
            End Set
        End Property

        Public Property Nam55() As Integer
            Get
                Return _nam55
            End Get
            Set(ByVal Value As Integer)
                _nam55 = Value
            End Set
        End Property

        Public Property Nu55() As Integer
            Get
                Return _nu55
            End Get
            Set(ByVal Value As Integer)
                _nu55 = Value
            End Set
        End Property

        Public Property Nam65() As Integer
            Get
                Return _nam65
            End Get
            Set(ByVal Value As Integer)
                _nam65 = Value
            End Set
        End Property

        Public Property Nu65() As Integer
            Get
                Return _nu65
            End Get
            Set(ByVal Value As Integer)
                _nu65 = Value
            End Set
        End Property
        Public Property TEN_PHANLOAI() As String
            Get
                Return _TEN_PHANLOAI
            End Get
            Set(ByVal Value As String)
                _TEN_PHANLOAI = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_BN_BCTHUNHANBNLAOINInfo

#Region "Private Members"
        Dim _iD_PHANLOAI As Byte
        Dim _tEN_VUNG As String
        Dim _tEN_MIEN As String
        Dim _tEN_TINH As String
        Dim _Moi As Integer
        Dim _Taiphat As Integer
        Dim _Thatbai As Integer
        Dim _DTLai As Integer
        Dim _AFBDuongKhac As Integer
        Dim _AFBAm As Integer
        Dim _LaoNP As Integer
        Dim _AFBAmNPKhac As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_PHANLOAI As Byte, ByVal tEN_VUNG As String, ByVal tEN_MIEN As String, ByVal tEN_TINH As String, ByVal LaoNP As String, ByVal Moi As Integer, ByVal TaiPhat As Integer, ByVal ThatBai As Integer, ByVal DTLai As Integer, ByVal AFBDuongKhac As Integer, ByVal AFBAm As Integer, ByVal AFBAmNPKhac As Integer)
            Me.ID_PHANLOAI = iD_PHANLOAI
            Me.TEN_VUNG = tEN_VUNG
            Me.TEN_MIEN = tEN_MIEN
            Me.TEN_TINH = tEN_TINH
            Me.LaoNP = LaoNP
            Me.Moi = Moi
            Me.TaiPhat = TaiPhat
            Me.ThatBai = ThatBai
            Me.DTLai = DTLai
            Me.AFBDuongKhac = AFBDuongKhac
            Me.AFBAm = AFBAm
            Me.AFBAmNPKhac = AFBAmNPKhac
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

        Public Property LaoNP() As String
            Get
                Return _LaoNP
            End Get
            Set(ByVal Value As String)
                _LaoNP = Value
            End Set
        End Property

        Public Property Moi() As Integer
            Get
                Return _Moi
            End Get
            Set(ByVal Value As Integer)
                _Moi = Value
            End Set
        End Property

        Public Property TaiPhat() As Integer
            Get
                Return _Taiphat
            End Get
            Set(ByVal Value As Integer)
                _Taiphat = Value
            End Set
        End Property

        Public Property ThatBai() As Integer
            Get
                Return _Thatbai
            End Get
            Set(ByVal Value As Integer)
                _Thatbai = Value
            End Set
        End Property


        Public Property DTLai() As Integer
            Get
                Return _DTLai
            End Get
            Set(ByVal Value As Integer)
                _DTLai = Value
            End Set
        End Property

        Public Property AFBDuongKhac() As Integer
            Get
                Return _AFBDuongKhac
            End Get
            Set(ByVal Value As Integer)
                _AFBDuongKhac = Value
            End Set
        End Property

        Public Property AFBAm() As Integer
            Get
                Return _AFBAm
            End Get
            Set(ByVal Value As Integer)
                _AFBAm = Value
            End Set
        End Property

        Public Property AFBAmNPKhac() As Integer
            Get
                Return _AFBAmNPKhac
            End Get
            Set(ByVal Value As Integer)
                _AFBAmNPKhac = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
