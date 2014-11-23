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

Namespace YourCompany.Modules.NTP_KD_BC_KIEMDINHTB

    Public Class NTP_KD_BC_KIEMDINHTBInfo

#Region "Private Members"
        Dim _NgayBCIn As String
        Dim _quy As Byte
        Dim _nam As Integer
        Dim _iD_Benhvien As String
        Dim _iD_KiemdinhTB As Integer
        Dim _tSTBThuchien As Integer
        Dim _tSTBCanthuchien As Integer
        Dim _soTBKiemdinh As Integer
        Dim _saiDlon As Integer
        Dim _saiAlon As Integer
        Dim _dLLon As Integer
        Dim _saiDNho As Integer
        Dim _saiANho As Integer
        Dim _dLNho As Integer
        Dim _cLBPDat As Integer
        Dim _taymauDat As Integer
        Dim _dosachDat As Integer
        Dim _dodayDat As Integer
        Dim _kichthuocDat As Integer
        Dim _dominDat As Integer
        Dim _ngay_NM As DateTime
        Dim _nguoi_NM As String
        Dim _pTNhap As Boolean
        Dim _huyenXN As Boolean
        Dim _tinhXN As Boolean
        Dim _tinhXNTT As Boolean
        Dim _ngayBC As DateTime
        Dim _nguoiBC As String
        Dim _Ten_BenhVien As String
        Dim _Ten_Tinh As String
        Dim _Loilon As Integer
        Dim _Loinho As Integer
        Dim _TongsoTBKiemdinh As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal iD_KiemdinhTB As Integer, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPDat As Integer, ByVal taymauDat As Integer, ByVal dosachDat As Integer, ByVal dodayDat As Integer, ByVal kichthuocDat As Integer, ByVal dominDat As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal Loilon As Integer, ByVal Loinho As Integer, ByVal TongsoTBKiemdinh As Integer)
            Me.ID_KiemdinhTB = iD_KiemdinhTB
            Me.Quy = quy
            Me.Nam = nam
            Me.ID_Benhvien = iD_Benhvien
            Me.TSTBThuchien = tSTBThuchien
            Me.TSTBCanthuchien = tSTBCanthuchien
            Me.SoTBKiemdinh = soTBKiemdinh
            Me.SaiDlon = saiDlon
            Me.SaiAlon = saiAlon
            Me.DLLon = dLLon
            Me.SaiDNho = saiDNho
            Me.SaiANho = saiANho
            Me.DLNho = dLNho
            Me.CLBPDat = cLBPDat
            Me.TaymauDat = taymauDat
            Me.DosachDat = dosachDat
            Me.DodayDat = dodayDat
            Me.KichthuocDat = kichthuocDat
            Me.DominDat = dominDat
            Me.Ngay_NM = ngay_NM
            Me.Nguoi_NM = nguoi_NM
            Me.PTNhap = pTNhap
            Me.HuyenXN = huyenXN
            Me.TinhXN = tinhXN
            Me.Loilon = Loilon
            Me.Loinho = Loinho
            Me.TongsoTBKiemdinh = TongsoTBKiemdinh
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

        Public Property ID_Benhvien() As String
            Get
                Return _iD_Benhvien
            End Get
            Set(ByVal Value As String)
                _iD_Benhvien = Value
            End Set
        End Property

        Public Property ID_KiemdinhTB() As Integer
            Get
                Return _iD_KiemdinhTB
            End Get
            Set(ByVal Value As Integer)
                _iD_KiemdinhTB = Value
            End Set
        End Property

        Public Property TSTBThuchien() As Integer
            Get
                Return _tSTBThuchien
            End Get
            Set(ByVal Value As Integer)
                _tSTBThuchien = Value
            End Set
        End Property

        Public Property TSTBCanthuchien() As Integer
            Get
                Return _tSTBCanthuchien
            End Get
            Set(ByVal Value As Integer)
                _tSTBCanthuchien = Value
            End Set
        End Property

        Public Property SoTBKiemdinh() As Integer
            Get
                Return _soTBKiemdinh
            End Get
            Set(ByVal Value As Integer)
                _soTBKiemdinh = Value
            End Set
        End Property

        Public Property SaiDlon() As Integer
            Get
                Return _saiDlon
            End Get
            Set(ByVal Value As Integer)
                _saiDlon = Value
            End Set
        End Property

        Public Property SaiAlon() As Integer
            Get
                Return _saiAlon
            End Get
            Set(ByVal Value As Integer)
                _saiAlon = Value
            End Set
        End Property

        Public Property DLLon() As Integer
            Get
                Return _dLLon
            End Get
            Set(ByVal Value As Integer)
                _dLLon = Value
            End Set
        End Property

        Public Property SaiDNho() As Integer
            Get
                Return _saiDNho
            End Get
            Set(ByVal Value As Integer)
                _saiDNho = Value
            End Set
        End Property

        Public Property SaiANho() As Integer
            Get
                Return _saiANho
            End Get
            Set(ByVal Value As Integer)
                _saiANho = Value
            End Set
        End Property

        Public Property DLNho() As Integer
            Get
                Return _dLNho
            End Get
            Set(ByVal Value As Integer)
                _dLNho = Value
            End Set
        End Property

        Public Property CLBPDat() As Integer
            Get
                Return _cLBPDat
            End Get
            Set(ByVal Value As Integer)
                _cLBPDat = Value
            End Set
        End Property

        Public Property TaymauDat() As Integer
            Get
                Return _taymauDat
            End Get
            Set(ByVal Value As Integer)
                _taymauDat = Value
            End Set
        End Property

        Public Property DosachDat() As Integer
            Get
                Return _dosachDat
            End Get
            Set(ByVal Value As Integer)
                _dosachDat = Value
            End Set
        End Property

        Public Property DodayDat() As Integer
            Get
                Return _dodayDat
            End Get
            Set(ByVal Value As Integer)
                _dodayDat = Value
            End Set
        End Property

        Public Property KichthuocDat() As Integer
            Get
                Return _kichthuocDat
            End Get
            Set(ByVal Value As Integer)
                _kichthuocDat = Value
            End Set
        End Property

        Public Property DominDat() As Integer
            Get
                Return _dominDat
            End Get
            Set(ByVal Value As Integer)
                _dominDat = Value
            End Set
        End Property

        Public Property Ngay_NM() As DateTime
            Get
                Return _ngay_NM
            End Get
            Set(ByVal Value As DateTime)
                _ngay_NM = Value
            End Set
        End Property

        Public Property Nguoi_NM() As String
            Get
                Return _nguoi_NM
            End Get
            Set(ByVal Value As String)
                _nguoi_NM = Value
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


        Public Property Ten_Tinh() As String
            Get
                Return _Ten_Tinh
            End Get
            Set(ByVal Value As String)
                _Ten_Tinh = Value
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
        Public Property Loilon() As Integer
            Get
                Return _Loilon
            End Get
            Set(ByVal Value As Integer)
                _Loilon = Value
            End Set
        End Property
        Public Property Loinho() As Integer
            Get
                Return _Loinho
            End Get
            Set(ByVal Value As Integer)
                _Loinho = Value
            End Set
        End Property
        Public Property TongsoTBKiemdinh() As Integer
            Get
                Return _TongsoTBKiemdinh
            End Get
            Set(ByVal Value As Integer)
                _TongsoTBKiemdinh = Value
            End Set
        End Property

#End Region

    End Class
End Namespace
