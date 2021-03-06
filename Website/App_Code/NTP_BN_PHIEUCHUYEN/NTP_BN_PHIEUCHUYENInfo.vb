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

Namespace YourCompany.Modules.NTP_BN_PHIEUCHUYEN

    ''' <summary>
    ''' The Info class for NTP_BN_PHIEUCHUYEN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_PHIEUCHUYENInfo

#Region "Private Members"
        Dim _iD_Phieuchuyen As Integer
        Dim _iD_Dieutri As Integer
        Dim _phanLoai As Byte
        Dim _dVChuyen As String
        Dim _dVTiepnhan As String
        Dim _tinhTrangBN As String
        Dim _lydo As String
        Dim _ngayChuyen As DateTime
        Dim _soDKDT As String
        Dim _tiepnhan As Byte
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _TEN_DVTIEPNHAN As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Phieuchuyen As Integer, ByVal iD_Dieutri As Integer, ByVal phanLoai As Boolean, ByVal dVChuyen As String, ByVal dVTiepnhan As String, ByVal tinhTrangBN As String, ByVal lydo As String, ByVal ngayChuyen As DateTime, ByVal soDKDT As String, ByVal tiepnhan As Byte, ByVal nGUOI_NM As Integer)
            Me.ID_Phieuchuyen = iD_Phieuchuyen
            Me.ID_Dieutri = iD_Dieutri
            Me.PhanLoai = phanLoai
            Me.DVChuyen = dVChuyen
            Me.DVTiepnhan = dVTiepnhan
            Me.TinhTrangBN = tinhTrangBN
            Me.Lydo = lydo
            Me.NgayChuyen = ngayChuyen
            Me.SoDKDT = soDKDT
            Me.Tiepnhan = tiepnhan
            Me.NGUOI_NM = nGUOI_NM
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_Phieuchuyen() As Integer
            Get
                Return _iD_Phieuchuyen
            End Get
            Set(ByVal Value As Integer)
                _iD_Phieuchuyen = Value
            End Set
        End Property

        Public Property ID_Dieutri() As Integer
            Get
                Return _iD_Dieutri
            End Get
            Set(ByVal Value As Integer)
                _iD_Dieutri = Value
            End Set
        End Property

        Public Property PhanLoai() As Byte
            Get
                Return _phanLoai
            End Get
            Set(ByVal Value As Byte)
                _phanLoai = Value
            End Set
        End Property
      
        Public Property DVChuyen() As String
            Get
                Return _dVChuyen
            End Get
            Set(ByVal Value As String)
                _dVChuyen = Value
            End Set
        End Property

        Public Property DVTiepnhan() As String
            Get
                Return _dVTiepnhan
            End Get
            Set(ByVal Value As String)
                _dVTiepnhan = Value
            End Set
        End Property

        Public Property TinhTrangBN() As String
            Get
                Return _tinhTrangBN
            End Get
            Set(ByVal Value As String)
                _tinhTrangBN = Value
            End Set
        End Property

        Public Property Lydo() As String
            Get
                Return _lydo
            End Get
            Set(ByVal Value As String)
                _lydo = Value
            End Set
        End Property

        Public Property NgayChuyen() As DateTime
            Get
                Return _ngayChuyen
            End Get
            Set(ByVal Value As DateTime)
                _ngayChuyen = Value
            End Set
        End Property

        Public Property SoDKDT() As String
            Get
                Return _soDKDT
            End Get
            Set(ByVal Value As String)
                _soDKDT = Value
            End Set
        End Property

        Public Property Tiepnhan() As Byte
            Get
                Return _tiepnhan
            End Get
            Set(ByVal Value As Byte)
                _tiepnhan = Value
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
        Public Property TEN_DVTIEPNHAN() As String
            Get

                Return _TEN_DVTIEPNHAN
            End Get
            Set(ByVal value As String)

                If _TEN_DVTIEPNHAN <> value Then
                    _TEN_DVTIEPNHAN = value

                End If
            End Set
        End Property


#End Region

    End Class
    Public Class NTP_BN_PHIEUCHUYENBENHNHANInfo
#Region "Private Members"

        Dim _iD_PHIEUCHUYEN As Int32 = 0
        Dim _iD_DIEUTRI As Integer
        Dim _pHANLOAI As Boolean
        Dim _phanLoaiDT As String
        Dim _TEN_DVCHUYEN As String = String.Empty
        Dim _dVCHUYEN As String = String.Empty
        Dim _dVTIEPNHAN As String
        Dim _tINHTRANGBN As String = String.Empty
        Dim _lYDO As String = String.Empty
        Dim _nGAYCHUYEN As DateTime
        Dim _TennGAYCHUYEN As String
        Dim _sODKDT As String = String.Empty
        Dim _bVCHUYEN As String = String.Empty
        Dim _bVNHAN As String = String.Empty
        Dim _tEN_TINH As String = String.Empty
        Dim _tEN_HUYEN As String = String.Empty
        Dim _iD_Benhnhan As String = String.Empty
        Dim _iD_Doituong As Int32 = 0
        Dim _hoTen As String = String.Empty
        Dim _soCMND As String = String.Empty
        Dim _tuoi As Int32 = 0
        Dim _gt As Boolean
        Dim _gioitinh As String
        Dim _mA_TINH As String = String.Empty
        Dim _mA_HUYEN As String = String.Empty
        Dim _diachi As String = String.Empty
        Dim _sodienthoai As String = String.Empty
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Int32 = 0
        Dim _ngay_SD As DateTime
        Dim _nguoi_SD As String = String.Empty
        Dim _huy As Boolean = False
        Dim _huyenXN As Boolean = False
        Dim _tinhXN As Boolean = False
        Dim _NgayVV As String
        Dim _Phanloaibenh As String
        Dim _PhanloaiBN As String

#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Benhnhan As String, ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal iD_Phieuchuyen As Integer, ByVal iD_Dieutri As Integer, ByVal phanLoai As Boolean, ByVal dVChuyen As String, ByVal dVTiepnhan As String, ByVal tinhTrangBN As String, ByVal lydo As String, ByVal ngayChuyen As DateTime, ByVal soDKDT As String, ByVal tiepnhan As Byte)

            iD_Phieuchuyen = iD_Phieuchuyen
            iD_Dieutri = iD_Dieutri
            phanLoai = phanLoai
            dVChuyen = dVChuyen
            dVTiepnhan = dVTiepnhan
            tinhTrangBN = tinhTrangBN
            lydo = lydo
            ngayChuyen = ngayChuyen
            soDKDT = soDKDT
            BVCHUYEN = BVCHUYEN
            BVNHAN = BVNHAN
            TEN_TINH = TEN_TINH
            TEN_HUYEN = TEN_HUYEN
            iD_Benhnhan = iD_Benhnhan
            iD_DoiTuong = iD_DoiTuong
            hoTen = hoTen
            soCMND = soCMND
            tuoi = tuoi
            gioitinh = gioitinh
            mA_TINH = mA_TINH
            mA_HUYEN = mA_HUYEN
            diachi = diachi
            sodienthoai = sodienthoai
            nGAY_NM = nGAY_NM
            nGUOI_NM = nGUOI_NM
            ngay_SD = ngay_SD
            nguoi_SD = nguoi_SD
            huy = huy
            huyenXN = huyenXN
            tinhXN = tinhXN

        End Sub
#End Region

#Region "Public Properties"


        Public Property ID_PHIEUCHUYEN() As Int32
            Get
                'CanReadProperty("ID_PHIEUCHUYEN", True)
                Return _iD_PHIEUCHUYEN
            End Get
            Set(ByVal value As Int32)
                'CanWriteProperty("ID_PHIEUCHUYEN", True)
                If _iD_PHIEUCHUYEN <> value Then
                    _iD_PHIEUCHUYEN = value
                    'PropertyHasChanged("ID_PHIEUCHUYEN")
                End If
            End Set
        End Property


        Public Property ID_DIEUTRI() As Integer
            Get
                'CanReadProperty("ID_DIEUTRI", True)
                Return _iD_DIEUTRI
            End Get
            Set(ByVal value As Integer)
                'CanWriteProperty("ID_DIEUTRI", True)
                If _iD_DIEUTRI <> value Then
                    _iD_DIEUTRI = value
                    'PropertyHasChanged("ID_DIEUTRI")
                End If
            End Set
        End Property


        Public Property PhanLoai() As Boolean
            Get
                Return _pHANLOAI
            End Get
            Set(ByVal Value As Boolean)
                _pHANLOAI = Value
            End Set
        End Property
        Public Property PhanLoaiDT() As String
            Set(ByVal value As String)

                If _phanLoaiDT <> value Then
                    _phanLoaiDT = value

                End If
            End Set
            Get
                If _pHANLOAI = True Then
                    'Return "Nam"
                    PhanLoaiDT = "Chuyển tuyến"
                Else
                    'Return " N? "
                    PhanLoaiDT = "Chuyển tiếp"
                End If

            End Get
        End Property
        Public Property TEN_DVCHUYEN() As String
            Get
                'CanReadProperty("DVCHUYEN", True)
                Return _TEN_DVCHUYEN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("DVCHUYEN", True)
                If _TEN_DVCHUYEN <> value Then
                    _TEN_DVCHUYEN = value
                    'PropertyHasChanged("DVCHUYEN")
                End If
            End Set
        End Property

        Public Property DVCHUYEN() As String
            Get
                'CanReadProperty("DVCHUYEN", True)
                Return _dVCHUYEN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("DVCHUYEN", True)
                If _dVCHUYEN <> value Then
                    _dVCHUYEN = value
                    'PropertyHasChanged("DVCHUYEN")
                End If
            End Set
        End Property


        Public Property DVTIEPNHAN() As String
            Get
                'CanReadProperty("DVTIEPNHAN", True)
                Return _dVTIEPNHAN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("DVTIEPNHAN", True)
                If _dVTIEPNHAN <> value Then
                    _dVTIEPNHAN = value
                    'PropertyHasChanged("DVTIEPNHAN")
                End If
            End Set
        End Property


        Public Property TINHTRANGBN() As String
            Get
                'CanReadProperty("TINHTRANGBN", True)
                Return _tINHTRANGBN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TINHTRANGBN", True)
                If _tINHTRANGBN <> value Then
                    _tINHTRANGBN = value
                    'PropertyHasChanged("TINHTRANGBN")
                End If
            End Set
        End Property


        Public Property LYDO() As String
            Get
                'CanReadProperty("LYDO", True)
                Return _lYDO
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("LYDO", True)
                If _lYDO <> value Then
                    _lYDO = value
                    'PropertyHasChanged("LYDO")
                End If
            End Set
        End Property


        Public Property NGAYCHUYEN() As DateTime
            Get
                'CanReadProperty("NGAYCHUYEN", True)
                Return _nGAYCHUYEN
            End Get
            Set(ByVal value As DateTime)
                'CanWriteProperty("NGAYCHUYEN", True)
                If _nGAYCHUYEN <> value Then
                    _nGAYCHUYEN = value
                    'PropertyHasChanged("NGAYCHUYEN")
                End If
            End Set
        End Property

        Public Property TenNGAYCHUYEN() As String
            Get
                'CanReadProperty("NGAYCHUYEN", True)
                Return _TenNGAYCHUYEN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("NGAYCHUYEN", True)
                If _TenNGAYCHUYEN <> value Then
                    _TenNGAYCHUYEN = value
                    'PropertyHasChanged("NGAYCHUYEN")
                End If
            End Set
        End Property
        Public Property SODKDT() As String
            Get
                'CanReadProperty("SODKDT", True)
                Return _sODKDT
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("SODKDT", True)
                If _sODKDT <> value Then
                    _sODKDT = value
                    'PropertyHasChanged("SODKDT")
                End If
            End Set
        End Property


        Public Property BVCHUYEN() As String
            Get
                'CanReadProperty("BVCHUYEN", True)
                Return _bVCHUYEN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("BVCHUYEN", True)
                If _bVCHUYEN <> value Then
                    _bVCHUYEN = value
                    'PropertyHasChanged("BVCHUYEN")
                End If
            End Set
        End Property


        Public Property BVNHAN() As String
            Get
                Return _bVNHAN
            End Get
            Set(ByVal value As String)
                If _bVNHAN <> value Then
                    _bVNHAN = value
                End If
            End Set
        End Property


        Public Property TEN_TINH() As String
            Get

                Return _tEN_TINH
            End Get
            Set(ByVal value As String)

                If _tEN_TINH <> value Then
                    _tEN_TINH = value

                End If
            End Set
        End Property


        Public Property TEN_HUYEN() As String
            Get

                Return _tEN_HUYEN
            End Get
            Set(ByVal value As String)

                If _tEN_HUYEN <> value Then
                    _tEN_HUYEN = value

                End If
            End Set
        End Property


        Public Property ID_Benhnhan() As String
            Get

                Return _iD_Benhnhan
            End Get
            Set(ByVal value As String)

                If _iD_Benhnhan <> value Then
                    _iD_Benhnhan = value

                End If
            End Set
        End Property


        Public Property ID_Doituong() As Int32
            Get

                Return _iD_Doituong
            End Get
            Set(ByVal value As Int32)

                If _iD_Doituong <> value Then
                    _iD_Doituong = value

                End If
            End Set
        End Property


        Public Property HoTen() As String
            Get

                Return _hoTen
            End Get
            Set(ByVal value As String)

                If _hoTen <> value Then
                    _hoTen = value

                End If
            End Set
        End Property


        Public Property SoCMND() As String
            Get

                Return _soCMND
            End Get
            Set(ByVal value As String)

                If _soCMND <> value Then
                    _soCMND = value

                End If
            End Set
        End Property


        Public Property Tuoi() As Int32
            Get

                Return _tuoi
            End Get
            Set(ByVal value As Int32)

                If _tuoi <> value Then
                    _tuoi = value

                End If
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
                If _Gioitinh = True Then
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
            Set(ByVal value As String)

                If _mA_TINH <> value Then
                    _mA_TINH = value

                End If
            End Set
        End Property


        Public Property MA_HUYEN() As String
            Get

                Return _mA_HUYEN
            End Get
            Set(ByVal value As String)

                If _mA_HUYEN <> value Then
                    _mA_HUYEN = value

                End If
            End Set
        End Property


        Public Property Diachi() As String
            Get

                Return _diachi
            End Get
            Set(ByVal value As String)

                If _diachi <> value Then
                    _diachi = value

                End If
            End Set
        End Property


        Public Property Sodienthoai() As String
            Get

                Return _sodienthoai
            End Get
            Set(ByVal value As String)

                If _sodienthoai <> value Then
                    _sodienthoai = value

                End If
            End Set
        End Property


        Public Property NGAY_NM() As DateTime
            Get

                Return _nGAY_NM
            End Get
            Set(ByVal value As DateTime)

                If _nGAY_NM <> value Then
                    _nGAY_NM = value

                End If
            End Set
        End Property


        Public Property NGUOI_NM() As Int32
            Get

                Return _nGUOI_NM
            End Get
            Set(ByVal value As Int32)

                If _nGUOI_NM <> value Then
                    _nGUOI_NM = value

                End If
            End Set
        End Property


        Public Property Ngay_SD() As DateTime
            Get

                Return _ngay_SD
            End Get
            Set(ByVal value As DateTime)

                If _ngay_SD <> value Then
                    _ngay_SD = value

                End If
            End Set
        End Property


        Public Property Nguoi_SD() As String
            Get

                Return _nguoi_SD
            End Get
            Set(ByVal value As String)

                If _nguoi_SD <> value Then
                    _nguoi_SD = value

                End If
            End Set
        End Property


        Public Property Huy() As Boolean
            Get

                Return _huy
            End Get
            Set(ByVal value As Boolean)

                If _huy <> value Then
                    _huy = value

                End If
            End Set
        End Property


        Public Property HuyenXN() As Boolean
            Get

                Return _huyenXN
            End Get
            Set(ByVal value As Boolean)

                If _huyenXN <> value Then
                    _huyenXN = value

                End If
            End Set
        End Property


        Public Property TinhXN() As Boolean
            Get

                Return _tinhXN
            End Get
            Set(ByVal value As Boolean)

                If _tinhXN <> value Then
                    _tinhXN = value

                End If
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
        Public Property Phanloaibenh() As String
            Get
                Return _Phanloaibenh
            End Get
            Set(ByVal value As String)
                If _Phanloaibenh <> value Then
                    _Phanloaibenh = value
                End If
            End Set
        End Property
        Public Property PhanloaiBN() As String
            Get
                Return _PhanloaiBN
            End Get
            Set(ByVal value As String)
                If _PhanloaiBN <> value Then
                    _PhanloaiBN = value
                End If
            End Set
        End Property
     
#End Region
    End Class
End Namespace
