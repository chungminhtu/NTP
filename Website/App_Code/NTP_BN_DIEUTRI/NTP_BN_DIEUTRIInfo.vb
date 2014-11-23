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

Namespace YourCompany.Modules.NTP_BN_DIEUTRI



    Public Class NTP_BN_DIEUTRIInfo

#Region "Private Members"
        Dim _Ten_Benhvien As String
        Dim _iD_Dieutri As Integer
        Dim _iD_BENHNHAN As String
        Dim _soDKDT As String
        Dim _dVDieutri As String
        Dim _ngayVV As DateTime
        Dim _ngayDT As DateTime
        Dim _iD_PHANLOAIYTE As Integer
        Dim _dVGioiThieu As String
        Dim _iD_PhanLoaiBenh As Integer
        Dim _iD_PhanLoaiBN As Integer
        Dim _iD_PhacdoDT As Integer
        Dim _ngayChupXQ As DateTime
        Dim _ketquaXQ As Byte
        Dim _xNHIV1 As Byte
        Dim _xNHIV2 As Byte
        Dim _aRT As Byte
        Dim _cPT As Byte
        Dim _lymPho As String
        Dim _giamSatDT As String
        Dim _iD_KetquaDT As Integer
        Dim _ngayRV As DateTime
        Dim _ghichu As String
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _id_PhieuChuyen As Integer
        Dim _ngay_SD As DateTime
        Dim _nguoi_SD As Integer
        Dim _huyenXN As Boolean
        Dim _tinhXN As Boolean
        Dim _ten_PhanLoaiBenh As String
        Dim _ten_PhanLoaiBN As String
        Dim _Ten_ngayVV As String
        Dim _Ten_ngayRV As String
        Dim _ten_KetQuaDT As String
        Dim _TEN_PHACDODT As String
        Dim _Hoten As String
        Dim _Tuoi As Integer
        Dim _Gioitinh As Boolean
        Dim _PhanloaiBN As String
        Dim _PhacdoKhac As String
        Dim _KetquaDT As Integer
        Dim _RV As Boolean
        Dim _PHACDODIEUTRI As String
        Dim _GT As String
        Dim _Tiepnhan As Byte
        Dim _Chandoan As String
        Dim _DVTIEPNHAN As String
        Dim _TN_KetQuaDT As String
        Dim _ID_PhacdoTD As Integer
        Dim _Ten_PhacdoTD As String
        Dim _PhacdoTDKhac As String
        Dim _MaBNQL As String

#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Dieutri As Integer, ByVal iD_BENHNHAN As String, ByVal soDKDT As String, ByVal dVDieutri As String, ByVal ngayVV As DateTime, ByVal ngayDT As DateTime, ByVal iD_PHANLOAIYTE As Integer, ByVal dVGioiThieu As String, ByVal iD_PhanLoaiBenh As Integer, ByVal iD_PhanLoaiBN As Integer, ByVal ngayChupXQ As DateTime, ByVal ketquaXQ As Byte, ByVal xNHIV1 As Byte, ByVal xNHIV2 As Byte, ByVal aRT As Byte, ByVal cPT As Byte, ByVal lymPho As String, ByVal giamSatDT As String, ByVal iD_KetquaDT As Integer, ByVal ngayRV As DateTime, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal ten_PhanLoaiBenh As String, ByVal ten_PhanLoaiBN As String, ByVal Ten_ngayVV As String, ByVal Ten_ngayRV As String, ByVal ten_KetQuaDT As String, ByVal TEN_PHACDODT As String, ByVal ID_PhacdoDT As Integer, ByVal Phacdokhac As String, ByVal Chandoan As String, ByVal ID_PhacdoTD As Integer, ByVal Ten_PhacdoTD As String, ByVal PhacdoTDKhac As String, ByVal MaBNQL As String, ByVal Tuoi As Integer)
            Me.ID_Dieutri = iD_Dieutri
            Me.ID_BENHNHAN = iD_BENHNHAN
            Me.SoDKDT = soDKDT
            Me.DVDieutri = dVDieutri
            Me.NgayVV = ngayVV
            Me.NgayDT = ngayDT
            Me.ID_PHANLOAIYTE = iD_PHANLOAIYTE
            Me.DVGioiThieu = dVGioiThieu
            Me.ID_PhanLoaiBenh = iD_PhanLoaiBenh
            Me.ID_PhanLoaiBN = iD_PhanLoaiBN
            Me.NgayChupXQ = ngayChupXQ
            Me.KetquaXQ = ketquaXQ
            Me.XNHIV1 = xNHIV1
            Me.XNHIV2 = xNHIV2
            Me.ART = aRT
            Me.CPT = cPT
            Me.LymPho = lymPho
            Me.GiamSatDT = giamSatDT
            Me.ID_KetquaDT = iD_KetquaDT
            Me.NgayRV = ngayRV
            Me.Ghichu = ghichu
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.Ngay_SD = ngay_SD
            Me.Nguoi_SD = nguoi_SD
            Me.HuyenXN = huyenXN
            Me.TinhXN = tinhXN
            Me.ten_PhanLoaiBenh = ten_PhanLoaiBenh
            Me.ten_PhanLoaiBN = ten_PhanLoaiBN
            Me.Ten_ngayVV = Ten_ngayVV
            Me.Ten_ngayRV = Ten_ngayRV
            Me.ten_KetQuaDT = ten_KetQuaDT
            Me.TEN_PHACDODT = TEN_PHACDODT
            Me.ID_PhacdoDT = ID_PhacdoDT
            Me.PhacdoKhac = Phacdokhac
            Me.Chandoan = Chandoan
            Me.ID_PhacdoTD = ID_PhacdoTD
            Me.Ten_PhacdoTD = Ten_PhacdoTD
            Me.PhacdoTDKhac = PhacdoTDKhac
            Me.MaBNQL = MaBNQL
		Me.Tuoi = Tuoi

        End Sub
#End Region

#Region "Public Properties"
        Public Property Ten_Benhvien() As String
            Get
                Return _Ten_Benhvien
            End Get
            Set(ByVal Value As String)
                _Ten_Benhvien = Value
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

        Public Property PHACDODIEUTRI() As String
            Get
                Return _PHACDODIEUTRI
            End Get
            Set(ByVal Value As String)
                _PHACDODIEUTRI = Value
            End Set
        End Property
        Public Property ID_BENHNHAN() As String
            Get
                Return _iD_BENHNHAN
            End Get
            Set(ByVal Value As String)
                _iD_BENHNHAN = Value
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

        Public Property DVDieutri() As String
            Get
                Return _dVDieutri
            End Get
            Set(ByVal Value As String)
                _dVDieutri = Value
            End Set
        End Property

        Public Property NgayVV() As DateTime
            Get
                Return _ngayVV
            End Get
            Set(ByVal Value As DateTime)
                _ngayVV = Value
            End Set
        End Property

        Public Property NgayDT() As DateTime
            Get
                Return _ngayDT
            End Get
            Set(ByVal Value As DateTime)
                _ngayDT = Value
            End Set
        End Property

        Public Property ID_PHANLOAIYTE() As Integer
            Get
                Return _iD_PHANLOAIYTE
            End Get
            Set(ByVal Value As Integer)
                _iD_PHANLOAIYTE = Value
            End Set
        End Property
        Public Property ID_PhieuChuyen() As Integer
            Get
                Return _id_PhieuChuyen
            End Get
            Set(ByVal Value As Integer)
                _id_PhieuChuyen = Value
            End Set
        End Property

        Public Property DVGioiThieu() As String
            Get
                Return _dVGioiThieu
            End Get
            Set(ByVal Value As String)
                _dVGioiThieu = Value
            End Set
        End Property

        Public Property ID_PhanLoaiBenh() As Integer
            Get
                Return _iD_PhanLoaiBenh
            End Get
            Set(ByVal Value As Integer)
                _iD_PhanLoaiBenh = Value
            End Set
        End Property

        Public Property ID_PhanLoaiBN() As Integer
            Get
                Return _iD_PhanLoaiBN
            End Get
            Set(ByVal Value As Integer)
                _iD_PhanLoaiBN = Value
            End Set
        End Property
        Public Property ID_PhacdoDT() As Integer
            Get
                Return _iD_PhacdoDT
            End Get
            Set(ByVal Value As Integer)
                _iD_PhacdoDT = Value
            End Set
        End Property
        Public Property NgayChupXQ() As DateTime
            Get
                Return _ngayChupXQ
            End Get
            Set(ByVal Value As DateTime)
                _ngayChupXQ = Value
            End Set
        End Property

        Public Property KetquaXQ() As Byte
            Get
                Return _ketquaXQ
            End Get
            Set(ByVal Value As Byte)
                _ketquaXQ = Value
            End Set
        End Property

        Public Property XNHIV1() As Byte
            Get
                Return _xNHIV1
            End Get
            Set(ByVal Value As Byte)
                _xNHIV1 = Value
            End Set
        End Property

        Public Property XNHIV2() As Byte
            Get
                Return _xNHIV2
            End Get
            Set(ByVal Value As Byte)
                _xNHIV2 = Value
            End Set
        End Property

        Public Property ART() As Byte
            Get
                Return _aRT
            End Get
            Set(ByVal Value As Byte)
                _aRT = Value
            End Set
        End Property

        Public Property CPT() As Byte
            Get
                Return _cPT
            End Get
            Set(ByVal Value As Byte)
                _cPT = Value
            End Set
        End Property

        Public Property LymPho() As String
            Get
                Return _lymPho
            End Get
            Set(ByVal Value As String)
                _lymPho = Value
            End Set
        End Property

        Public Property GiamSatDT() As String
            Get
                Return _giamSatDT
            End Get
            Set(ByVal Value As String)
                _giamSatDT = Value
            End Set
        End Property

        Public Property ID_KetquaDT() As Integer
            Get
                Return _iD_KetquaDT
            End Get
            Set(ByVal Value As Integer)
                _iD_KetquaDT = Value
            End Set
        End Property

        Public Property NgayRV() As DateTime
            Get
                Return _ngayRV
            End Get
            Set(ByVal Value As DateTime)
                _ngayRV = Value
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

        Public Property Ngay_SD() As DateTime
            Get
                Return _ngay_SD
            End Get
            Set(ByVal Value As DateTime)
                _ngay_SD = Value
            End Set
        End Property

        Public Property Nguoi_SD() As Integer
            Get
                Return _nguoi_SD
            End Get
            Set(ByVal Value As Integer)
                _nguoi_SD = Value
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
        Public Property ten_PhanLoaiBenh() As String
            Get
                Return _ten_PhanLoaiBenh
            End Get
            Set(ByVal Value As String)
                _ten_PhanLoaiBenh = Value
            End Set
        End Property
        Public Property ten_PhanLoaiBN() As String
            Get
                Return _ten_PhanLoaiBN
            End Get
            Set(ByVal Value As String)
                _ten_PhanLoaiBN = Value
            End Set
        End Property
        Public Property Ten_ngayVV() As String
            Get
                Return _Ten_ngayVV
            End Get
            Set(ByVal Value As String)
                _Ten_ngayVV = Value
            End Set
        End Property
        Public Property Ten_ngayRV() As String
            Get
                Return _Ten_ngayRV
            End Get
            Set(ByVal Value As String)
                _Ten_ngayRV = Value
            End Set
        End Property
        Public Property ten_KetQuaDT() As String
            Get
                Return _ten_KetQuaDT
            End Get
            Set(ByVal Value As String)
                _ten_KetQuaDT = Value
            End Set
        End Property
        Public Property TEN_PHACDODT() As String
            Get
                Return _TEN_PHACDODT
            End Get
            Set(ByVal Value As String)
                _TEN_PHACDODT = Value
            End Set
        End Property
        Public Property Hoten() As String
            Get
                Return _Hoten
            End Get
            Set(ByVal Value As String)
                _Hoten = Value
            End Set
        End Property
        Public Property Tuoi() As Integer
            Get
                Return _Tuoi
            End Get
            Set(ByVal Value As Integer)
                _Tuoi = Value
            End Set
        End Property
        Public Property Gioitinh() As Boolean
            Get
                Return _Gioitinh
            End Get
            Set(ByVal Value As Boolean)
                _Gioitinh = Value
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

        Public Property PhanloaiBN() As String
            Get
                Return _PhanloaiBN
            End Get
            Set(ByVal Value As String)
                _PhanloaiBN = Value
            End Set
        End Property
        Public Property PhacdoKhac() As String
            Get
                Return _PhacdoKhac
            End Get
            Set(ByVal Value As String)
                _PhacdoKhac = Value
            End Set
        End Property

        Public Property KetquaDT() As String
            Get
                Return _KetquaDT
            End Get
            Set(ByVal Value As String)
                _KetquaDT = Value
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
        Public Property Tiepnhan() As Byte
            Get
                Return _Tiepnhan
            End Get
            Set(ByVal Value As Byte)
                _Tiepnhan = Value
            End Set
        End Property
        Public Property Chandoan() As String
            Get
                Return _Chandoan
            End Get
            Set(ByVal Value As String)
                _Chandoan = Value
            End Set
        End Property
        Public Property DVTIEPNHAN() As String
            Get
                Return _DVTIEPNHAN
            End Get
            Set(ByVal Value As String)
                _DVTIEPNHAN = Value
            End Set
        End Property
        Public Property TN_KetQuaDT() As String
            Get
                Return _TN_KetQuaDT
            End Get
            Set(ByVal Value As String)
                _TN_KetQuaDT = Value
            End Set
        End Property
      
        Public Property ID_PhacdoTD() As Integer
            Get
                Return _ID_PhacdoTD
            End Get
            Set(ByVal Value As Integer)
                _ID_PhacdoTD = Value
            End Set
        End Property
        Public Property Ten_PhacdoTD() As String
            Get
                Return _Ten_PhacdoTD
            End Get
            Set(ByVal Value As String)
                _Ten_PhacdoTD = Value
            End Set
        End Property
        Public Property PhacdoTDKhac() As String
            Get
                Return _PhacdoTDKhac
            End Get
            Set(ByVal Value As String)
                _PhacdoTDKhac = Value
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
#End Region

    End Class
    Public Class NTP_BN_KQXETNGHIEMInfo

#Region "Private Members"

   
        Dim _iD_Dieutri As Integer
        Dim _ID_Xetnghiem_GD As Integer
        Dim _ID_Phieuxetnghiem_C As Integer
        Dim _ThoiGianDT As Integer
        Dim _ngayXN As DateTime
        Dim _ngay_NM As DateTime
        Dim _SoXN As String
        Dim _KetquaXN As Integer
        Dim _CanNang As Integer
        Dim _NGUOI_NM As Integer
        
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal ID_Dieutri As String, ByVal ID_Phieuxetnghiem_C As Integer, ByVal ThoiGianDT As Integer, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal CanNang As Integer, ByVal NGAY_NM As DateTime, ByVal NGUOI_NM As Integer)
            Me.ID_Dieutri = iD_Dieutri
            Me.ID_Phieuxetnghiem_C = ID_Phieuxetnghiem_C
            Me.ThoiGianDT = ThoiGianDT
            Me.NgayXN = NgayXN
            Me.SoXN = SoXN
            Me.KetquaXN = KetquaXN
            Me.CanNang = CanNang
            Me.NGUOI_NM = NGUOI_NM
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_Phieuxetnghiem_C() As Integer
            Get
                Return _ID_Phieuxetnghiem_C
            End Get
            Set(ByVal Value As Integer)
                _ID_Phieuxetnghiem_C = Value
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

        Public Property SoXN() As String
            Get
                Return _SoXN
            End Get
            Set(ByVal Value As String)
                _SoXN = Value
            End Set
        End Property

        Public Property NgayXN() As DateTime
            Get
                Return _ngayXN
            End Get
            Set(ByVal Value As DateTime)
                _ngayXN = Value
            End Set
        End Property

        Public Property ID_Xetnghiem_GD() As Integer
            Get
                Return _ID_Xetnghiem_GD
            End Get
            Set(ByVal Value As Integer)
                _ID_Xetnghiem_GD = Value
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

        Public Property ThoiGianDT() As Integer
            Get
                Return _ThoiGianDT
            End Get
            Set(ByVal Value As Integer)
                _ThoiGianDT = Value
            End Set
        End Property

        Public Property CanNang() As Integer
            Get
                Return _CanNang
            End Get
            Set(ByVal Value As Integer)
                _CanNang = Value
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

        




#End Region

    End Class
    Public Class NTP_BN_KETQUADTInfo

        Dim _ID_Dieutri As Integer
        Dim _ID_Benhnhan As Integer
        Dim _Hoten As String
        Dim _Gioitinh As String
        Dim _Tuoi As String
        Dim _SoDKDT As String
        Dim _NgayRV As DateTime
        'Dim _NgayVV As DateTime
        Dim _Ghichu As String
        Dim _KetquaDT As Integer
        Dim _Ravien As Integer
        Dim _ID_Benhvien As String
        Dim _TEN_Benhvien As String
        Dim _MATINH As String
        ' initialization
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Dieutri As Integer, ByVal NgayRV As DateTime, ByVal ketquaDT As Integer, ByVal Ghichu As String)
            Me.ID_Dieutri = iD_Dieutri
            Me.NgayRV = NgayRV
            Me.Ghichu = Ghichu
            Me.KetquaDT = ketquaDT
        End Sub

        ' public properties
        Public Property ID_Dieutri() As Integer
            Get
                Return _ID_Dieutri
            End Get
            Set(ByVal Value As Integer)
                _ID_Dieutri = Value
            End Set
        End Property
        Public Property ID_Benhnhan() As String
            Get
                Return _ID_Benhnhan
            End Get
            Set(ByVal Value As String)
                _ID_Benhnhan = Value
            End Set
        End Property
        Public Property Hoten() As String
            Get
                Return _Hoten
            End Get
            Set(ByVal Value As String)
                _Hoten = Value
            End Set
        End Property

        Public Property Tuoi() As String
            Get
                Return _Tuoi
            End Get
            Set(ByVal Value As String)
                _Tuoi = Value
            End Set
        End Property


        Public Property Gioitinh() As String
            Get
                Return _Gioitinh
            End Get
            Set(ByVal Value As String)
                _Gioitinh = Value
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
        Public Property NgayRV() As DateTime
            Get
                Return _NgayRV
            End Get
            Set(ByVal Value As DateTime)
                _NgayRV = Value
            End Set
        End Property
        'Public Property NgayVV() As DateTime
        '    Get
        '        Return _NgayVV
        '    End Get
        '    Set(ByVal Value As DateTime)
        '        _NgayVV = Value
        '    End Set
        'End Property
        Public Property Ghichu() As String
            Get
                Return _Ghichu
            End Get
            Set(ByVal Value As String)
                _Ghichu = Value
            End Set
        End Property
        Public Property KetquaDT() As Integer
            Get
                Return _KetquaDT
            End Get
            Set(ByVal Value As Integer)
                _KetquaDT = Value
            End Set
        End Property
        Public Property Ravien() As Integer
            Get
                Return _Ravien
            End Get
            Set(ByVal Value As Integer)
                _Ravien = Value
            End Set
        End Property
        Public Property ID_Benhvien() As String
            Get
                Return _ID_Benhvien
            End Get
            Set(ByVal Value As String)
                _ID_Benhvien = Value
            End Set
        End Property
        Public Property TEN_Benhvien() As String
            Get
                Return _TEN_Benhvien
            End Get
            Set(ByVal Value As String)
                _TEN_Benhvien = Value
            End Set
        End Property
        Public Property MATINH() As String
            Get
                Return _MATINH
            End Get
            Set(ByVal Value As String)
                _MATINH = Value
            End Set
        End Property
       

    End Class
End Namespace



