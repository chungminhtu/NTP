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

Namespace YourCompany.Modules.NTP_BN_CTCHONGLAO

    ''' <summary>
    ''' The Info class for NTP_BN_CTCHONGLAO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_CTCHONGLAOInfo

#Region "Private Members"
        Dim _iD_CTChonglao As Integer
        Dim _nam As Integer
        Dim _mA_TINH As String
        Dim _mA_HUYEN As String
        Dim _mADV As String
        Dim _aFBcongdong As Integer
        Dim _aFBhotro As Integer
        Dim _ngayBC As DateTime
        Dim _nguoiBC As String
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _huyenXN As Boolean
        Dim _tinhXN As Boolean
        Dim _tinhXNTT As Boolean
        Dim _pTNhap As Boolean
        Dim _Ten_Huyen As String
        Dim _Ten_Tinh As String
        Dim _SoBNPhathien As Integer
        Dim _SoBNDKDT As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_CTChonglao As Integer, ByVal nam As Integer, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal mADV As String, ByVal aFBcongdong As Integer, ByVal aFBhotro As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal Ten_Huyen As String, ByVal Ten_Tinh As String, ByVal SoBNPhathien As Integer, ByVal SoBNDKDT As Integer)
            Me.ID_CTChonglao = iD_CTChonglao
            Me.Nam = nam
            Me.MA_TINH = mA_TINH
            Me.MA_HUYEN = mA_HUYEN
            Me.MADV = mADV
            Me.AFBcongdong = aFBcongdong
            Me.AFBhotro = aFBhotro
            Me.NgayBC = ngayBC
            Me.NguoiBC = nguoiBC
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.HuyenXN = huyenXN
            Me.TinhXN = tinhXN
            Me.PTNhap = pTNhap
            Me.Ten_Tinh = Ten_Tinh
            Me.Ten_Huyen = Ten_Huyen
            Me.SoBNDKDT = SoBNDKDT
            Me.SoBNPhathien = SoBNPhathien
        End Sub
#End Region

#Region "Public Properties"
        Public Property SoBNDKDT() As Integer
            Get
                Return _SoBNDKDT
            End Get
            Set(ByVal Value As Integer)
                _SoBNDKDT = Value
            End Set
        End Property
        Public Property SoBNPhathien() As Integer
            Get
                Return _SoBNPhathien
            End Get
            Set(ByVal Value As Integer)
                _SoBNPhathien = Value
            End Set
        End Property
        Public Property ID_CTChonglao() As Integer
            Get
                Return _iD_CTChonglao
            End Get
            Set(ByVal Value As Integer)
                _iD_CTChonglao = Value
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

        Public Property MADV() As String
            Get
                Return _mADV
            End Get
            Set(ByVal Value As String)
                _mADV = Value
            End Set
        End Property

        Public Property AFBcongdong() As Integer
            Get
                Return _aFBcongdong
            End Get
            Set(ByVal Value As Integer)
                _aFBcongdong = Value
            End Set
        End Property

        Public Property AFBhotro() As Integer
            Get
                Return _aFBhotro
            End Get
            Set(ByVal Value As Integer)
                _aFBhotro = Value
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

        Public Property NguoiBC() As String
            Get
                Return _nguoiBC
            End Get
            Set(ByVal Value As String)
                _nguoiBC = Value
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
#End Region

    End Class
    Public Class NTP_BN_CTCHONGLAOP1Info

#Region "Private Members"
        Dim _iD_CTChonglaoP1 As Integer
        Dim _iD_CTChonglao As Integer
        Dim _phanloai As Boolean
        Dim _soCShienco As Integer
        Dim _soCSTrienkhai As Integer
        Dim _diemkinhTT As Integer
        Dim _diemkinhKD As Integer
        Dim _xNNC As Integer
        Dim _xNKSD As Integer
        Dim _tuvanHIV As Integer
        Dim _cungcapART As Integer
        Dim _Ten_PhanLoai As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_CTChonglaoP1 As Integer, ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal soCShienco As Integer, ByVal soCSTrienkhai As Integer, ByVal diemkinhTT As Integer, ByVal diemkinhKD As Integer, ByVal xNNC As Integer, ByVal xNKSD As Integer, ByVal tuvanHIV As Integer, ByVal cungcapART As Integer, ByVal Ten_PhanLoai As String)
            Me.ID_CTChonglaoP1 = iD_CTChonglaoP1
            Me.ID_CTChonglao = iD_CTChonglao
            Me.Phanloai = phanloai
            Me.SoCShienco = soCShienco
            Me.SoCSTrienkhai = soCSTrienkhai
            Me.DiemkinhTT = diemkinhTT
            Me.DiemkinhKD = diemkinhKD
            Me.XNNC = xNNC
            Me.XNKSD = xNKSD
            Me.TuvanHIV = tuvanHIV
            Me.CungcapART = cungcapART
            Me.Ten_PhanLoai = Ten_PhanLoai
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_CTChonglaoP1() As Integer
            Get
                Return _iD_CTChonglaoP1
            End Get
            Set(ByVal Value As Integer)
                _iD_CTChonglaoP1 = Value
            End Set
        End Property

        Public Property ID_CTChonglao() As Integer
            Get
                Return _iD_CTChonglao
            End Get
            Set(ByVal Value As Integer)
                _iD_CTChonglao = Value
            End Set
        End Property

        Public Property Phanloai() As Boolean
            Get
                Return _phanloai
            End Get
            Set(ByVal Value As Boolean)
                _phanloai = Value
            End Set
        End Property

        Public Property SoCShienco() As Integer
            Get
                Return _soCShienco
            End Get
            Set(ByVal Value As Integer)
                _soCShienco = Value
            End Set
        End Property

        Public Property SoCSTrienkhai() As Integer
            Get
                Return _soCSTrienkhai
            End Get
            Set(ByVal Value As Integer)
                _soCSTrienkhai = Value
            End Set
        End Property

        Public Property DiemkinhTT() As Integer
            Get
                Return _diemkinhTT
            End Get
            Set(ByVal Value As Integer)
                _diemkinhTT = Value
            End Set
        End Property

        Public Property DiemkinhKD() As Integer
            Get
                Return _diemkinhKD
            End Get
            Set(ByVal Value As Integer)
                _diemkinhKD = Value
            End Set
        End Property

        Public Property XNNC() As Integer
            Get
                Return _xNNC
            End Get
            Set(ByVal Value As Integer)
                _xNNC = Value
            End Set
        End Property

        Public Property XNKSD() As Integer
            Get
                Return _xNKSD
            End Get
            Set(ByVal Value As Integer)
                _xNKSD = Value
            End Set
        End Property

        Public Property TuvanHIV() As Integer
            Get
                Return _tuvanHIV
            End Get
            Set(ByVal Value As Integer)
                _tuvanHIV = Value
            End Set
        End Property

        Public Property CungcapART() As Integer
            Get
                Return _cungcapART
            End Get
            Set(ByVal Value As Integer)
                _cungcapART = Value
            End Set
        End Property
        Public Property Ten_PhanLoai() As String
            Get
                Return _Ten_PhanLoai
            End Get
            Set(ByVal Value As String)
                _Ten_PhanLoai = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_BN_CTCHONGLAOP2Info

#Region "Private Members"
        Dim _iD_CTChonglaoP2 As Integer
        Dim _iD_CTChonglao As Integer
        Dim _loaihinhYte As Integer
        Dim _duocChuyen As Integer
        Dim _chandoan As Integer
        Dim _dieuTri As Integer
        Dim _Ten_PhanLoaiYTe As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_CTChonglaoP2 As Integer, ByVal iD_CTChonglao As Integer, ByVal loaihinhYte As Long, ByVal duocChuyen As Integer, ByVal chandoan As Integer, ByVal dieuTri As Integer, ByVal Ten_PhanLoaiYTe As String)
            Me.ID_CTChonglaoP2 = iD_CTChonglaoP2
            Me.ID_CTChonglao = iD_CTChonglao
            Me.LoaihinhYte = loaihinhYte
            Me.DuocChuyen = duocChuyen
            Me.Chandoan = chandoan
            Me.DieuTri = dieuTri
            Me.Ten_PhanLoaiYTe = Ten_PhanLoaiYTe
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_CTChonglaoP2() As Integer
            Get
                Return _iD_CTChonglaoP2
            End Get
            Set(ByVal Value As Integer)
                _iD_CTChonglaoP2 = Value
            End Set
        End Property

        Public Property ID_CTChonglao() As Integer
            Get
                Return _iD_CTChonglao
            End Get
            Set(ByVal Value As Integer)
                _iD_CTChonglao = Value
            End Set
        End Property

        Public Property LoaihinhYte() As Integer
            Get
                Return _loaihinhYte
            End Get
            Set(ByVal Value As Integer)
                _loaihinhYte = Value
            End Set
        End Property

        Public Property DuocChuyen() As Integer
            Get
                Return _duocChuyen
            End Get
            Set(ByVal Value As Integer)
                _duocChuyen = Value
            End Set
        End Property

        Public Property Chandoan() As Integer
            Get
                Return _chandoan
            End Get
            Set(ByVal Value As Integer)
                _chandoan = Value
            End Set
        End Property

        Public Property DieuTri() As Integer
            Get
                Return _dieuTri
            End Get
            Set(ByVal Value As Integer)
                _dieuTri = Value
            End Set
        End Property
        Public Property Ten_PhanLoaiYTe() As String
            Get
                Return _Ten_PhanLoaiYTe
            End Get
            Set(ByVal Value As String)
                _Ten_PhanLoaiYTe = Value
            End Set
        End Property

#End Region

    End Class
    Public Class NTP_BN_CTCHONGLAOP3Info

#Region "Private Members"
        Dim _iD_CTChonglaoP3 As Integer
        Dim _iD_CTChonglao As Integer
        Dim _phanloai As Boolean
        Dim _iD_NguonNhanLuc As Integer
        Dim _nLHienco As Integer
        Dim _nLDaotao As Integer
        Dim _TongsoNLDaotao As Integer
        Dim _Ten_NguonNhanLuc As String
        Dim _Ghichu As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_CTChonglaoP3 As Integer, ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal iD_NguonNhanLuc As Integer, ByVal nLHienco As Integer, ByVal nLDaotao As Integer, ByVal TongsoNLDaotao As Integer, ByVal Ten_NguonNhanLuc As String, ByVal Ghichu As String)
            Me.ID_CTChonglaoP3 = iD_CTChonglaoP3
            Me.ID_CTChonglao = iD_CTChonglao
            Me.Phanloai = phanloai
            Me.ID_NguonNhanLuc = iD_NguonNhanLuc
            Me.NLHienco = nLHienco
            Me.NLDaotao = nLDaotao
            Me.TongsoNLDaotao = TongsoNLDaotao
            Me.Ten_NguonNhanLuc = Ten_NguonNhanLuc
            Me.Ghichu = Ghichu
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_CTChonglaoP3() As Integer
            Get
                Return _iD_CTChonglaoP3
            End Get
            Set(ByVal Value As Integer)
                _iD_CTChonglaoP3 = Value
            End Set
        End Property

        Public Property ID_CTChonglao() As Integer
            Get
                Return _iD_CTChonglao
            End Get
            Set(ByVal Value As Integer)
                _iD_CTChonglao = Value
            End Set
        End Property

        Public Property Phanloai() As Boolean
            Get
                Return _phanloai
            End Get
            Set(ByVal Value As Boolean)
                _phanloai = Value
            End Set
        End Property

        Public Property ID_NguonNhanLuc() As Integer
            Get
                Return _iD_NguonNhanLuc
            End Get
            Set(ByVal Value As Integer)
                _iD_NguonNhanLuc = Value
            End Set
        End Property

        Public Property NLHienco() As Integer
            Get
                Return _nLHienco
            End Get
            Set(ByVal Value As Integer)
                _nLHienco = Value
            End Set
        End Property

        Public Property NLDaotao() As Integer
            Get
                Return _nLDaotao
            End Get
            Set(ByVal Value As Integer)
                _nLDaotao = Value
            End Set
        End Property
        Public Property TongsoNLDaotao() As Integer
            Get
                Return _TongsoNLDaotao
            End Get
            Set(ByVal Value As Integer)
                _TongsoNLDaotao = Value
            End Set
        End Property
        Public Property Ten_NguonNhanLuc() As String
            Get
                Return _Ten_NguonNhanLuc
            End Get
            Set(ByVal Value As String)
                _Ten_NguonNhanLuc = Value
            End Set
        End Property
        Public Property Ghichu() As String
            Get
                Return _Ghichu
            End Get
            Set(ByVal Value As String)
                _Ghichu = Value
            End Set
        End Property

#End Region

    End Class
End Namespace
