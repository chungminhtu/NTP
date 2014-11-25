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

Namespace YourCompany.Modules.NTP_BENHNHAN

    ''' <summary>
    ''' The Info class for NTP_BENHNHAN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BENHNHANInfo

#Region "Private Members"
        Dim _iD_Benhnhan As String
        Dim _iD_DoiTuong As Integer
        Dim _hoTen As String
        Dim _soCMND As String
        Dim _tuoi As Integer
        Dim _gioitinh As Boolean
        Dim _mA_TINH As String
        Dim _mA_HUYEN As String
        Dim _diachi As String
        Dim _sodienthoai As String
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _ngay_SD As DateTime
        Dim _nguoi_SD As String
        Dim _huy As Boolean
        Dim _huyenXN As Boolean
        Dim _tinhXN As Boolean
        ' Dim _tenGioiTinh As String
        Dim _tenTinh As String
        Dim _tenHuyen As String
        Dim _ten_PhanLoaiBN As String
        Dim _ten_PhanLoaiBenh As String
        Dim _ten_KetQuaDT As String
        Dim _ten_LyDoXN As String
        Dim _LydoXN As Byte
        Dim _NgayVV As String
        Dim _NgayRV As String
        Dim _SoDKDT As String
        Dim _GT As String
        Dim _ID_DIEUTRI As Integer
        Dim _RV As Boolean
        Dim _Ten_Benhvien As String
        Dim _MaBNQL As String ' MaBN_QL
        Dim _Tungay As DateTime
        Dim _Denngay As DateTime
        Dim _STT As Decimal
        Dim _Ketqua As Integer
        Dim _KetquaXN As String
        Dim _PhanloaiKQXN As Byte
        Dim _HIV As Byte
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Benhnhan As String, ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal TenTinh As String, ByVal TenHuyen As String, ByVal ten_PhanLoaiBN As String, ByVal ten_PhanLoaiBenh As String, ByVal ten_KetQuaDT As String, ByVal NgayVV As String, ByVal NgayRV As String, ByVal SoDKDT As String, ByVal MaBNQL As String, ByVal HIV As Byte)
            Me.ID_Benhnhan = iD_Benhnhan
            Me.ID_DoiTuong = iD_DoiTuong
            Me.HoTen = hoTen
            Me.SoCMND = soCMND
            Me.Tuoi = tuoi
            Me.Gioitinh = gioitinh
            Me.MA_TINH = mA_TINH
            Me.MA_HUYEN = mA_HUYEN
            Me.Diachi = diachi
            Me.Sodienthoai = sodienthoai
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.Ngay_SD = ngay_SD
            Me.Nguoi_SD = nguoi_SD
            Me.Huy = huy
            Me.HuyenXN = huyenXN
            Me.TinhXN = tinhXN
            Me.MaBNQL = MaBNQL
            Me.TenTinh = TenTinh
            Me.TenHuyen = TenHuyen
            Me.Ten_PhanLoaiBN = ten_PhanLoaiBN
            Me.Ten_PhanLoaiBenh = ten_PhanLoaiBenh
            Me.Ten_KetQuaDT = ten_KetQuaDT
            Me.NgayVV = NgayVV
            Me.NgayRV = NgayRV
            Me.HIV = HIV
        End Sub
#End Region

#Region "Public Properties"
        Public Property HIV() As String
            Get
                Return _HIV
            End Get
            Set(ByVal Value As String)
                _HIV = Value
            End Set
        End Property

        Public Property ID_Benhnhan() As String
            Get
                Return _iD_Benhnhan
            End Get
            Set(ByVal Value As String)
                _iD_Benhnhan = Value
            End Set
        End Property
        Public Property STT() As Decimal
            Get
                Return _STT
            End Get
            Set(ByVal Value As Decimal)
                _STT = Value
            End Set
        End Property
        Public Property ID_DIEUTRI() As Integer
            Get
                Return _ID_DIEUTRI
            End Get
            Set(ByVal Value As Integer)
                _ID_DIEUTRI = Value
            End Set
        End Property

        Public Property ID_DoiTuong() As Integer
            Get
                Return _iD_DoiTuong
            End Get
            Set(ByVal Value As Integer)
                _iD_DoiTuong = Value
            End Set
        End Property

        Public Property HoTen() As String
            Get
                Return _hoTen
            End Get
            Set(ByVal Value As String)
                _hoTen = Value
            End Set
        End Property

        Public Property SoCMND() As String
            Get
                Return _soCMND
            End Get
            Set(ByVal Value As String)
                _soCMND = Value
            End Set
        End Property

        Public Property Tuoi() As Integer
            Get
                Return _tuoi
            End Get
            Set(ByVal Value As Integer)
                _tuoi = Value
            End Set
        End Property

        Public Property Gioitinh() As Boolean
            Get
                Return _gioitinh
            End Get
            Set(ByVal Value As Boolean)
                _gioitinh = Value
            End Set
        End Property

        Public Property GT() As String
            Set(ByVal value As String)

                If _GT <> value Then
                    _GT = value

                End If
            End Set
            Get
                If _gioitinh = True Then
                    'Return "Nam"
                    GT = "Nam"
                Else
                    'Return " N? "
                    GT = "Nữ"
                End If

            End Get
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

        Public Property Diachi() As String
            Get
                Return _diachi
            End Get
            Set(ByVal Value As String)
                _diachi = Value
            End Set
        End Property

        Public Property Sodienthoai() As String
            Get
                Return _sodienthoai
            End Get
            Set(ByVal Value As String)
                _sodienthoai = Value
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

        Public Property Ngay_SD() As DateTime
            Get
                Return _ngay_SD
            End Get
            Set(ByVal Value As DateTime)
                _ngay_SD = Value
            End Set
        End Property

        Public Property Nguoi_SD() As String
            Get
                Return _nguoi_SD
            End Get
            Set(ByVal Value As String)
                _nguoi_SD = Value
            End Set
        End Property

        Public Property Huy() As Boolean
            Get
                Return _huy
            End Get
            Set(ByVal Value As Boolean)
                _huy = Value
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

        Public Property TenTinh() As String
            Get
                Return _tenTinh
            End Get
            Set(ByVal Value As String)
                _tenTinh = Value
            End Set
        End Property
        Public Property TenHuyen() As String
            Get
                Return _tenHuyen
            End Get
            Set(ByVal Value As String)
                _tenHuyen = Value
            End Set
        End Property
        Public Property Ten_PhanLoaiBN() As String
            Get
                Return _ten_PhanLoaiBN
            End Get
            Set(ByVal Value As String)
                _ten_PhanLoaiBN = Value
            End Set
        End Property
        Public Property Ten_PhanLoaiBenh() As String
            Get
                Return _ten_PhanLoaiBenh
            End Get
            Set(ByVal Value As String)
                _ten_PhanLoaiBenh = Value
            End Set
        End Property
        Public Property Ten_KetQuaDT() As String
            Get
                Return _ten_KetQuaDT
            End Get
            Set(ByVal Value As String)
                _ten_KetQuaDT = Value
            End Set
        End Property
        Public Property NgayVV() As String
            Get
                Return _NgayVV
            End Get
            Set(ByVal Value As String)
                _NgayVV = Value
            End Set
        End Property
        Public Property NgayRV() As String
            Get
                Return _NgayRV
            End Get
            Set(ByVal Value As String)
                _NgayRV = Value
            End Set
        End Property
        Public Property SoDKDT() As String
            Get
                Return _SoDKDT
            End Get
            Set(ByVal Value As String)
                _SoDKDT = Value
            End Set
        End Property
        Public Property RV() As Boolean
            Get
                Return _RV
            End Get
            Set(ByVal Value As Boolean)
                _RV = Value
            End Set
        End Property
        Public Property LyDoXN() As Byte
            Get
                Return _LydoXN
            End Get
            Set(ByVal Value As Byte)
                _LydoXN = Value
            End Set
        End Property

        Public Property Ten_LyDoXN() As String
            Set(ByVal value As String)

                If _ten_LyDoXN <> value Then
                    _ten_LyDoXN = value

                End If
            End Set
            Get
                If _LydoXN = 0 Then

                    Ten_LyDoXN = "Phát hiện"
                Else

                    Ten_LyDoXN = "Theo dõi"
                End If

            End Get
        End Property
        Public Property Ten_Benhvien() As String
            Get
                Return _Ten_Benhvien
            End Get
            Set(ByVal Value As String)
                _Ten_Benhvien = Value
            End Set
        End Property
        Public Property MaBNQL() As String
            Get
                Return _MaBNQL
            End Get
            Set(ByVal Value As String)
                _MaBNQL = Value
            End Set
        End Property

        Public Property Tungay() As DateTime
            Get
                Return _Tungay
            End Get
            Set(ByVal Value As DateTime)
                _Tungay = Value
            End Set
        End Property
        Public Property Denngay() As DateTime
            Get
                Return _Denngay
            End Get
            Set(ByVal Value As DateTime)
                _Denngay = Value
            End Set
        End Property
        Public Property Ketqua() As Integer
            Get
                Return _Ketqua
            End Get
            Set(ByVal Value As Integer)
                _Ketqua = Value
            End Set
        End Property
        Public Property KetquaXN() As String
            Set(ByVal value As String)

                If _KetquaXN <> value Then
                    _KetquaXN = value

                End If
            End Set
            Get
                Select Case _Ketqua
                    Case 0
                        KetquaXN = "Âm"
                    Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                        KetquaXN = _Ketqua.ToString + "AFB"
                    Case 10
                        KetquaXN = "1+"
                    Case 11
                        KetquaXN = "2+"
                    Case 12
                        KetquaXN = "3+"
                    Case 15
                        KetquaXN = "-"
                End Select

            End Get
        End Property
        Public Property PhanloaiKQXN() As Byte
            Set(ByVal value As Byte)
                If _PhanloaiKQXN <> value Then
                    _PhanloaiKQXN = value
                End If
            End Set
            Get
                Select Case _Ketqua
                    Case 0, 15
                        PhanloaiKQXN = 0
                    Case Else
                        PhanloaiKQXN = 1
                End Select

            End Get
        End Property

#End Region

    End Class

End Namespace
