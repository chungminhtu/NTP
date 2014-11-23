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

Namespace YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM

    ''' <summary>
    ''' The Info class for NTP_BN_PHIEUXETNGHIEM
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_PHIEUXETNGHIEMInfo


#Region "Private Members"
        Dim _iD_Phieuxetnghiem As Integer
        Dim _iD_Benhnhan As String
        Dim _soXN As String
        Dim _iD_Benhvien As String
        Dim _iD_PhanloaiYte As Integer
        Dim _lydoXN As Integer
        Dim _soluong As Byte
        Dim _hIV As Boolean
        Dim _soDKDT As String
        Dim _xNVien As String
        Dim _ghichu As String
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _Ten_BenhVien As String
        Dim _ten_PhanLoaiYTe As String
        Dim _ten_LyDoXN As String
        Dim _DV_XETNGHIEM As String
        Dim _SoThangDT As Integer
        Dim _TEN_NGAYNM As String
        Dim _NGAYXN As DateTime
        Dim _huyenXN As Boolean
        Dim _Ketqua As String
        Dim _Quyen As Boolean
        Dim _DV_Tiepnhan As String
        Dim _MA_TINH As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Phieuxetnghiem As Integer, ByVal iD_Benhnhan As String, ByVal soXN As String, ByVal iD_Benhvien As String, ByVal iD_PhanloaiYte As Integer, ByVal lydoXN As Integer, ByVal soluong As Byte, ByVal hIV As Boolean, ByVal SoDKDT As String, ByVal xNVien As String, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal Ten_BenhVien As String, ByVal ten_PhanLoaiYTe As String, ByVal ten_LyDoXN As String, ByVal DV_XETNGHIEM As String, ByVal SoThangDT As Integer, ByVal Ngayxn As DateTime, ByVal DV_Tiepnhan As String)
            Me.ID_Phieuxetnghiem = iD_Phieuxetnghiem
            Me.ID_Benhnhan = iD_Benhnhan
            Me.SoXN = soXN
            Me.ID_Benhvien = iD_Benhvien
            Me.ID_PhanloaiYte = iD_PhanloaiYte
            Me.LydoXN = lydoXN
            Me.Soluong = soluong
            Me.HIV = hIV
            Me.SoDKDT = SoDKDT
            Me.XNVien = xNVien
            Me.Ghichu = ghichu
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.Ten_BenhVien = Ten_BenhVien
            Me.Ten_LyDoXN = ten_LyDoXN
            Me.Ten_PhanLoaiYTe = ten_PhanLoaiYTe
            Me.DV_XETNGHIEM = DV_XETNGHIEM
            Me.SoThangDT = SoThangDT
            Me.NGAYXN = Ngayxn
            Me.DV_Tiepnhan = DV_Tiepnhan
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_Phieuxetnghiem() As Integer
            Get
                Return _iD_Phieuxetnghiem
            End Get
            Set(ByVal Value As Integer)
                _iD_Phieuxetnghiem = Value
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

        Public Property SoXN() As String
            Get
                Return _soXN
            End Get
            Set(ByVal Value As String)
                _soXN = Value
            End Set
        End Property

        Public Property ID_Benhvien() As String
            Get
                Return _iD_Benhvien
            End Get
            Set(ByVal Value As String)
                _iD_Benhvien = Value
            End Set
        End Property

        Public Property ID_PhanloaiYte() As Integer
            Get
                Return _iD_PhanloaiYte
            End Get
            Set(ByVal Value As Integer)
                _iD_PhanloaiYte = Value
            End Set
        End Property

        Public Property LydoXN() As Integer
            Get
                Return _lydoXN
            End Get
            Set(ByVal Value As Integer)
                _lydoXN = Value
            End Set
        End Property

        Public Property Soluong() As Byte
            Get
                Return _soluong
            End Get
            Set(ByVal Value As Byte)
                _soluong = Value
            End Set
        End Property

        Public Property HIV() As Boolean
            Get
                Return _hIV
            End Get
            Set(ByVal Value As Boolean)
                _hIV = Value
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
        Public Property XNVien() As String
            Get
                Return _xNVien
            End Get
            Set(ByVal Value As String)
                _xNVien = Value
            End Set
        End Property

        Public Property Ghichu() As String
            Get
                Return _ghichu
            End Get
            Set(ByVal Value As String)
                _ghichu = Value
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
        Public Property Ten_BenhVien() As String
            Get
                Return _Ten_BenhVien
            End Get
            Set(ByVal Value As String)
                _Ten_BenhVien = Value
            End Set
        End Property
        Public Property Ten_LyDoXN() As String
            Get
                Return _ten_LyDoXN
            End Get
            Set(ByVal Value As String)
                _ten_LyDoXN = Value
            End Set
        End Property
        Public Property Ten_PhanLoaiYTe() As String
            Get
                Return _ten_PhanLoaiYTe
            End Get
            Set(ByVal Value As String)
                _ten_PhanLoaiYTe = Value
            End Set
        End Property

        Public Property DV_XETNGHIEM() As String
            Get
                Return _DV_XETNGHIEM
            End Get
            Set(ByVal Value As String)
                _DV_XETNGHIEM = Value
            End Set
        End Property
        Public Property SoThangDT() As Integer
            Get
                Return _SoThangDT
            End Get
            Set(ByVal Value As Integer)
                _SoThangDT = Value
            End Set
        End Property
        Public Property TEN_NGAYNM() As String
            Get
                Return _TEN_NGAYNM
            End Get
            Set(ByVal Value As String)
                _TEN_NGAYNM = Value
            End Set
        End Property
        Public Property NGAYXN() As DateTime
            Get
                Return _NGAYXN
            End Get
            Set(ByVal Value As DateTime)
                _NGAYXN = Value
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
        Public Property Ketqua() As String
            Get
                Return _Ketqua
            End Get
            Set(ByVal Value As String)
                _Ketqua = Value
            End Set
        End Property
        Public Property Quyen() As Boolean
            Get
                Return _Quyen
            End Get
            Set(ByVal Value As Boolean)
                _Quyen = Value
            End Set
        End Property
        Public Property DV_Tiepnhan() As String
            Get
                Return _DV_Tiepnhan
            End Get
            Set(ByVal Value As String)
                _DV_Tiepnhan = Value
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
#End Region

    End Class
    Public Class NTP_BN_PHIEUXETNGHIEM_CInfo

#Region "Private Members"
        Dim _iD_Phieuxetnghiem_C As Integer
        Dim _iD_Phieuxetnghiem As Integer
        Dim _ngayNhanMau As DateTime
        Dim _TEN_NGAYNM As String
        Dim _soXN As String
        Dim _trangthaiDom As String
        Dim _maudom As Byte
        Dim _ketqua As Byte
        Dim _Ten_KetQua As String
        Dim _SoTB As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal _iD_Phieuxetnghiem_C As Integer, ByVal _iD_Phieuxetnghiem As Integer, ByVal ngayNhanMau As DateTime, ByVal trangthaiDom As String, ByVal maudom As Byte, ByVal ketqua As Byte, ByVal Ten_KetQua As String, ByVal SoTB As String, ByVal SoXN As String)
            Me.ID_Phieuxetnghiem_C = ID_Phieuxetnghiem_C
            Me.ID_Phieuxetnghiem = ID_Phieuxetnghiem
            Me.NgayNhanMau = ngayNhanMau
            Me.TrangthaiDom = trangthaiDom
            Me.Maudom = maudom
            Me.Ketqua = ketqua
            Me.Ten_KetQua = Ten_KetQua
            Me.SoTB = SoTB
            Me.SoXN = SoXN
        End Sub
#End Region

#Region "Public Properties"
      
        Public Property SoXN() As String
            Get
                Return _soXN
            End Get
            Set(ByVal Value As String)
                _soXN = Value
            End Set
        End Property
        Public Property TEN_NGAYNM() As String
            Get
                Return _TEN_NGAYNM
            End Get
            Set(ByVal Value As String)
                _TEN_NGAYNM = Value
            End Set
        End Property
        Public Property ID_Phieuxetnghiem_C() As Integer
            Get
                Return _iD_Phieuxetnghiem_C
            End Get
            Set(ByVal Value As Integer)
                _iD_Phieuxetnghiem_C = Value
            End Set
        End Property

        Public Property ID_Phieuxetnghiem() As Integer
            Get
                Return _iD_Phieuxetnghiem
            End Get
            Set(ByVal Value As Integer)
                _iD_Phieuxetnghiem = Value
            End Set
        End Property

        Public Property NgayNhanMau() As DateTime
            Get
                Return _ngayNhanMau
            End Get
            Set(ByVal Value As DateTime)
                _ngayNhanMau = Value
            End Set
        End Property


        Public Property TrangthaiDom() As String
            Get
                Return _trangthaiDom
            End Get
            Set(ByVal Value As String)
                _trangthaiDom = Value
            End Set
        End Property

        Public Property Maudom() As Byte
            Get
                Return _maudom
            End Get
            Set(ByVal Value As Byte)
                _maudom = Value
            End Set
        End Property

        Public Property Ketqua() As Byte
            Get
                Return _ketqua
            End Get
            Set(ByVal Value As Byte)
                _ketqua = Value
            End Set
        End Property
        Public Property Ten_KetQua() As String
            Get
                Return _Ten_KetQua
            End Get
            Set(ByVal Value As String)
                _Ten_KetQua = Value
            End Set
        End Property
        Public Property SoTB() As String
            Get
                Return _SoTB
            End Get
            Set(ByVal Value As String)
                _SoTB = Value
            End Set
        End Property

#End Region

    End Class
    Public Class NTP_BN_XETNGHIEM_GDInfo

#Region "Private Members"
        Dim _iD_Xetnghiem_GD As Integer
        Dim _iD_Dieutri As Integer
        Dim _iD_Phieuxetnghiem_C As Integer
        Dim _thoiGianDT As Byte
        Dim _NgayXN As DateTime
        Dim _SoXN As String
        Dim _KetquaXN As Integer
        Dim _canNang As Integer
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _Nuoicay As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Xetnghiem_GD As Integer, ByVal iD_Dieutri As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal thoiGianDT As Byte, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal canNang As Integer, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal Nuoicay As String)
            Me.ID_Xetnghiem_GD = iD_Xetnghiem_GD
            Me.ID_Dieutri = iD_Dieutri
            Me.ID_Phieuxetnghiem_C = iD_Phieuxetnghiem_C
            Me.ThoiGianDT = thoiGianDT
            Me.NgayXN = NgayXN
            Me.SoXN = SoXN
            Me.KetquaXN = KetquaXN
            Me.CanNang = canNang
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.Nuoicay = Nuoicay
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_Xetnghiem_GD() As Integer
            Get
                Return _iD_Xetnghiem_GD
            End Get
            Set(ByVal Value As Integer)
                _iD_Xetnghiem_GD = Value
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

        Public Property ID_Phieuxetnghiem_C() As Integer
            Get
                Return _iD_Phieuxetnghiem_C
            End Get
            Set(ByVal Value As Integer)
                _iD_Phieuxetnghiem_C = Value
            End Set
        End Property

        Public Property ThoiGianDT() As Byte
            Get
                Return _thoiGianDT
            End Get
            Set(ByVal Value As Byte)
                _thoiGianDT = Value
            End Set
        End Property
        Public Property NgayXN() As DateTime
            Get
                Return _NgayXN
            End Get
            Set(ByVal Value As DateTime)
                _NgayXN = Value
            End Set
        End Property
        Public Property SoXN() As String
            Get
                Return _SoXN
            End Get
            Set(ByVal Value As String)
                _SoXN = Value
            End Set
        End Property
        Public Property KetquaXN() As Integer
            Get
                Return _KetquaXN
            End Get
            Set(ByVal Value As Integer)
                _KetquaXN = Value
            End Set
        End Property
        Public Property CanNang() As Integer
            Get
                Return _canNang
            End Get
            Set(ByVal Value As Integer)
                _canNang = Value
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
        Public Property Nuoicay() As String
            Get
                Return _Nuoicay
            End Get
            Set(ByVal Value As String)
                _Nuoicay = Value
            End Set
        End Property
#End Region

    End Class

    Public Class NTP_BN_XETNGHIEM_GDViewInfo

#Region "Private Members"
        Private _iD_XETNGHIEM_GD As Int32 = 0
        Private _thoigian As String = String.Empty
        Private _ngaynhanmau As String = String.Empty
        Private _sOXN As String = String.Empty
        Private _tEN_KETQUAXN As String = String.Empty

#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Xetnghiem_GD As Integer, ByVal thoiGian As String, ByVal _sOXN As String, ByVal tEN_KETQUAXN As String)
            Me.ID_XETNGHIEM_GD = iD_Xetnghiem_GD
            Me.Thoigian = thoiGian
            Me.Ngaynhanmau = Ngaynhanmau
            Me.SOXN = SOXN
            Me.TEN_KETQUAXN = tEN_KETQUAXN
        End Sub
#End Region

#Region " Business Properties and Methods "


        Public Property ID_XETNGHIEM_GD() As Int32
            Get
                'CanReadProperty("ID_XETNGHIEM_GD", True)
                Return _iD_XETNGHIEM_GD
            End Get
            Set(ByVal value As Int32)
                'CanWriteProperty("ID_XETNGHIEM_GD", True)
                If _iD_XETNGHIEM_GD <> value Then
                    _iD_XETNGHIEM_GD = value
                    'PropertyHasChanged("ID_XETNGHIEM_GD")
                End If
            End Set
        End Property


        Public Property Thoigian() As String
            Get
                'CanReadProperty("Thoigian", True)
                Return _thoigian
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("Thoigian", True)
                If _thoigian <> value Then
                    _thoigian = value
                    'PropertyHasChanged("Thoigian")
                End If
            End Set
        End Property


        Public Property Ngaynhanmau() As String
            Get
                'CanReadProperty("Ngaynhanmau", True)
                Return _ngaynhanmau
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("Ngaynhanmau", True)
                If _ngaynhanmau <> value Then
                    _ngaynhanmau = value
                    'PropertyHasChanged("Ngaynhanmau")
                End If
            End Set
        End Property


        Public Property SOXN() As String
            Get
                'CanReadProperty("SOXN", True)
                Return _sOXN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("SOXN", True)
                If _sOXN <> value Then
                    _sOXN = value
                    'PropertyHasChanged("SOXN")
                End If
            End Set
        End Property


        Public Property TEN_KETQUAXN() As String
            Get
                'CanReadProperty("TEN_KETQUAXN", True)
                Return _tEN_KETQUAXN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TEN_KETQUAXN", True)
                If _tEN_KETQUAXN <> value Then
                    _tEN_KETQUAXN = value
                    'PropertyHasChanged("TEN_KETQUAXN")
                End If
            End Set
        End Property


#End Region

    End Class
    Public Class NTP_BN_PHIEUXETNGHIEM_CViewInfo

#Region "Private Members"
        Dim _iD_Phieuxetnghiem_C As Integer
        Dim _iD_Phieuxetnghiem As Integer
        Dim _ngayNhanMau As DateTime
        Dim _trangthaiDom As String
        Dim _maudom As Byte
        Dim _ketqua As Byte
        Dim _soXN As String
        Dim _tENKETQUA As String = String.Empty
        Dim _nGAYNM As String = String.Empty
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal ID_Phieuxetnghiem_C As Integer, ByVal ID_Phieuxetnghiem As Integer, ByVal ngayNhanMau As DateTime, ByVal trangthaiDom As String, ByVal maudom As Byte, ByVal ketqua As Byte, ByVal TENKETQUA As String, ByVal NgayNM As String)
            Me.ID_Phieuxetnghiem_C = ID_Phieuxetnghiem_C
            Me.ID_Phieuxetnghiem = ID_Phieuxetnghiem
            Me.NgayNhanMau = ngayNhanMau
            Me.TrangthaiDom = trangthaiDom
            Me.Maudom = maudom
            Me.Ketqua = ketqua
            Me.TENKETQUA = TENKETQUA
            Me.NGAYNM = NgayNM
        End Sub
#End Region
#Region " Business Properties and Methods "
        Public Property SoXN() As String
            Get
                Return _SoXN
            End Get
            Set(ByVal Value As String)
                _SoXN = Value
            End Set
        End Property
        Public Property ID_Phieuxetnghiem_C() As Integer
            Get
                Return _iD_Phieuxetnghiem_C
            End Get
            Set(ByVal Value As Integer)
                _iD_Phieuxetnghiem_C = Value
            End Set
        End Property

        Public Property ID_Phieuxetnghiem() As Integer
            Get
                Return _iD_Phieuxetnghiem
            End Get
            Set(ByVal Value As Integer)
                _iD_Phieuxetnghiem = Value
            End Set
        End Property

        Public Property NgayNhanMau() As DateTime
            Get
                Return _ngayNhanMau
            End Get
            Set(ByVal Value As DateTime)
                _ngayNhanMau = Value
            End Set
        End Property

        Public Property TrangthaiDom() As String
            Get
                Return _trangthaiDom
            End Get
            Set(ByVal Value As String)
                _trangthaiDom = Value
            End Set
        End Property

        Public Property Maudom() As Byte
            Get
                Return _maudom
            End Get
            Set(ByVal Value As Byte)
                _maudom = Value
            End Set
        End Property

        Public Property Ketqua() As Byte
            Get
                Return _ketqua
            End Get
            Set(ByVal Value As Byte)
                _ketqua = Value
            End Set
        End Property


        Public Property TENKETQUA() As String
            Get
                Return _tENKETQUA
            End Get
            Set(ByVal value As String)
                _tENKETQUA = value
            End Set
        End Property


        Public Property NGAYNM() As String
            Get
                Return _nGAYNM
            End Get
            Set(ByVal value As String)
                _nGAYNM = value
            End Set
        End Property


#End Region
        '#Region "Public Properties"
        '        Public Property ID_XetnghiemBN_C() As Integer
        '            Get
        '                Return _iD_XetnghiemBN_C
        '            End Get
        '            Set(ByVal Value As Integer)
        '                _iD_XetnghiemBN_C = Value
        '            End Set
        '        End Property

        '        Public Property ID_XetnghiemBN() As Integer
        '            Get
        '                Return _iD_XetnghiemBN
        '            End Get
        '            Set(ByVal Value As Integer)
        '                _iD_XetnghiemBN = Value
        '            End Set
        '        End Property

        '        Public Property NgayNhanMau() As DateTime
        '            Get
        '                Return _ngayNhanMau
        '            End Get
        '            Set(ByVal Value As DateTime)
        '                _ngayNhanMau = Value
        '            End Set
        '        End Property

        '        Public Property TrangthaiDom() As String
        '            Get
        '                Return _trangthaiDom
        '            End Get
        '            Set(ByVal Value As String)
        '                _trangthaiDom = Value
        '            End Set
        '        End Property

        '        Public Property Maudom() As Byte
        '            Get
        '                Return _maudom
        '            End Get
        '            Set(ByVal Value As Byte)
        '                _maudom = Value
        '            End Set
        '        End Property

        '        Public Property Ketqua() As Byte
        '            Get
        '                Return _ketqua
        '            End Get
        '            Set(ByVal Value As Byte)
        '                _ketqua = Value
        '            End Set
        '        End Property
        '#End Region

    End Class
End Namespace
