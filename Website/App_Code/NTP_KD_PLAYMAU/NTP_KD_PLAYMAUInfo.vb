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

Namespace YourCompany.Modules.NTP_KD_PLAYMAU

    ''' <summary>
    ''' The Info class for NTP_KD_PLAYMAU
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_KD_PLAYMAUInfo

#Region "Private Members"
        Dim _iD_PLAYMAU As Integer
        Dim _thangLM As Integer
        Dim _mA_TINH As String
        Dim _iD_BENHVIEN As String
        Dim _kTVien As String
        Dim _nhanxet As String
        Dim _ngayKD1 As DateTime
        Dim _kDVien1 As String
        Dim _nhanxet1 As String
        Dim _ngayKD2 As DateTime
        Dim _kDVien2 As String
        Dim _nhanxet2 As String
        Dim _Ketqua As Boolean
        Dim _KetquaKD As String
        Dim _tinhXN As Integer
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
        Dim _pTNhap As Byte
        Dim _Nam As Integer
        Dim _NgayLM As DateTime
        Dim _Ten_BenhVien As String
        Dim _Ten_Tinh As String
        Dim _SoTBThuchien As Integer
        Dim _SoTBCanKD As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_PLAYMAU As Integer, ByVal thangLM As Integer, ByVal Nam As Integer, ByVal mA_TINH As String, ByVal iD_BENHVIEN As String, ByVal kTVien As String, ByVal nhanxet As String, ByVal ngayKD1 As DateTime, ByVal kDVien1 As String, ByVal nhanxet1 As String, ByVal ngayKD2 As DateTime, ByVal kDVien2 As String, ByVal nhanxet2 As String, ByVal tinhXN As Boolean, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal pTNhap As Byte, ByVal NgayLM As DateTime, ByVal Ten_BenhVien As String, ByVal Ten_Tinh As String, ByVal SoTBThuchien As Integer, ByVal SoTBCanKD As Integer)
            Me.ID_PLAYMAU = iD_PLAYMAU
            Me.ThangLM = thangLM
            Me.MA_TINH = mA_TINH
            Me.ID_BENHVIEN = iD_BENHVIEN
            Me.KTVien = kTVien
            Me.Nhanxet = nhanxet
            Me.NgayKD1 = ngayKD1
            Me.KDVien1 = kDVien1
            Me.Nhanxet1 = nhanxet1
            Me.NgayKD2 = ngayKD2
            Me.KDVien2 = kDVien2
            Me.Nhanxet2 = nhanxet2
            Me.TinhXN = tinhXN
            Me.NGAY_NM = nGAY_NM
            Me.NGUOI_NM = nGUOI_NM
            Me.PTNhap = pTNhap
            Me.NgayLM = NgayLM
            Me.Ten_Tinh = Ten_Tinh
            Me.Ten_BenhVien = Ten_BenhVien
            Me.Nam = Nam
            Me.SoTBThuchien = SoTBThuchien
            Me.SoTBCanKD = SoTBCanKD
        End Sub
#End Region

#Region "Public Properties"
      
        Public Property ID_PLAYMAU() As Integer
            Get
                Return _iD_PLAYMAU
            End Get
            Set(ByVal Value As Integer)
                _iD_PLAYMAU = Value
            End Set
        End Property

        Public Property Ketqua() As Boolean
            Get
                Return _Ketqua
            End Get
            Set(ByVal Value As Boolean)
                _Ketqua = Value
            End Set
        End Property

        Public Property KetquaKD() As String
            Set(ByVal value As String)

                If _KetquaKD <> value Then
                    _KetquaKD = value

                End If
            End Set
            Get
                If _Ketqua = True Then
                    'Return "Nam"
                    KetquaKD = "**"
                Else
                    'Return " N? "
                    KetquaKD = ""
                End If

            End Get
        End Property



        Public Property ThangLM() As Integer
            Get
                Return _thangLM
            End Get
            Set(ByVal Value As Integer)
                _thangLM = Value
            End Set
        End Property
        Public Property Nam() As Integer
            Get
                Return _Nam
            End Get
            Set(ByVal Value As Integer)
                _Nam = Value
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

        Public Property ID_BENHVIEN() As String
            Get
                Return _iD_BENHVIEN
            End Get
            Set(ByVal Value As String)
                _iD_BENHVIEN = Value
            End Set
        End Property

        Public Property KTVien() As String
            Get
                Return _kTVien
            End Get
            Set(ByVal Value As String)
                _kTVien = Value
            End Set
        End Property

        Public Property Nhanxet() As String
            Get
                Return _nhanxet
            End Get
            Set(ByVal Value As String)
                _nhanxet = Value
            End Set
        End Property

        Public Property NgayKD1() As DateTime
            Get
                Return _ngayKD1
            End Get
            Set(ByVal Value As DateTime)
                _ngayKD1 = Value
            End Set
        End Property

        Public Property KDVien1() As String
            Get
                Return _kDVien1
            End Get
            Set(ByVal Value As String)
                _kDVien1 = Value
            End Set
        End Property

        Public Property Nhanxet1() As String
            Get
                Return _nhanxet1
            End Get
            Set(ByVal Value As String)
                _nhanxet1 = Value
            End Set
        End Property

        Public Property NgayKD2() As DateTime
            Get
                Return _ngayKD2
            End Get
            Set(ByVal Value As DateTime)
                _ngayKD2 = Value
            End Set
        End Property

        Public Property KDVien2() As String
            Get
                Return _kDVien2
            End Get
            Set(ByVal Value As String)
                _kDVien2 = Value
            End Set
        End Property

        Public Property Nhanxet2() As String
            Get
                Return _nhanxet2
            End Get
            Set(ByVal Value As String)
                _nhanxet2 = Value
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

        Public Property PTNhap() As Byte
            Get
                Return _pTNhap
            End Get
            Set(ByVal Value As Byte)
                _pTNhap = Value
            End Set
        End Property

        Public Property NgayLM() As DateTime
            Get
                Return _NgayLM
            End Get
            Set(ByVal Value As DateTime)
                _NgayLM = Value
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
        Public Property SoTBThuchien() As Integer
            Get
                Return _SoTBThuchien
            End Get
            Set(ByVal Value As Integer)
                _SoTBThuchien = Value
            End Set
        End Property
        Public Property SoTBCanKD() As Integer
            Get
                Return _SoTBCanKD
            End Get
            Set(ByVal Value As Integer)
                _SoTBCanKD = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_KD_PLAYMAU_CInfo

#Region "Private Members"
        Dim _iD_PLAYMAU_C As Integer
        Dim _iD_PLAYMAU As Integer
        Dim _iD_Phieuxetnghiem_C As Integer
        Dim _soTB As String
        Dim _kiemdinhH As String
        Dim _kiemdinhT1 As String
        Dim _kiemDinhT2 As String
        Dim _chatluong As Byte
        Dim _taymau As Byte
        Dim _dosach As Byte
        Dim _doDay As Byte
        Dim _kichco As Byte
        Dim _domin As Byte
        Dim _ghichu As String
        Dim _ghichu1 As String
        Dim _ghichu2 As String
        Private _Ten_KiemdinhH As String
        Private _Ten_KiemdinhT1 As String
        Private _Ten_KiemDinhT2 As String
        Private _tEN_CHATLUONG As String
        Private _tEN_TAYMAU As String
        Private _tEN_DOSACH As String
        Private _tEN_DODAY As String
        Private _tEN_KICHCO As String
        Private _tEN_DOMIN As String
        Dim _KetquaKD As String
        Dim _Ketqua As Boolean

#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal soTB As String, ByVal kiemdinhH As String, ByVal kiemdinhT1 As String, ByVal kiemDinhT2 As String, ByVal chatluong As Byte, ByVal taymau As Byte, ByVal dosach As Byte, ByVal doDay As Byte, ByVal kichco As Byte, ByVal domin As Byte, ByVal ghichu As String, ByVal Ten_kiemdinhH As String, ByVal Ten_kiemdinhT1 As String, ByVal Ten_kiemDinhT2 As String, ByVal Ten_chatluong As Byte, ByVal Ten_taymau As Byte, ByVal Ten_dosach As Byte, ByVal Ten_doDay As Byte, ByVal Ten_kichco As Byte, ByVal Ten_domin As Byte, ByVal ghichu1 As String, ByVal ghichu2 As String)
            Me.ID_PLAYMAU_C = iD_PLAYMAU_C
            Me.ID_PLAYMAU = iD_PLAYMAU
            Me.ID_Phieuxetnghiem_C = iD_Phieuxetnghiem_C
            Me.SoTB = soTB
            Me.KiemdinhH = kiemdinhH
            Me.KiemdinhT1 = kiemdinhT1
            Me.KiemDinhT2 = kiemDinhT2
            Me.Chatluong = chatluong
            Me.Taymau = taymau
            Me.Dosach = dosach
            Me.DoDay = doDay
            Me.Kichco = kichco
            Me.Domin = domin
            Me.Ghichu = ghichu
            Me.Ten_KiemdinhH = Ten_kiemdinhH
            Me.Ten_KiemdinhT1 = Ten_kiemdinhT1
            Me.Ten_KiemDinhT2 = Ten_kiemDinhT2
            Me.TEN_CHATLUONG = Ten_chatluong
            Me.TEN_TAYMAU = Ten_taymau
            Me.TEN_DOSACH = Ten_dosach
            Me.TEN_DODAY = Ten_doDay
            Me.TEN_KICHCO = Ten_kichco
            Me.TEN_DOMIN = Ten_domin
            Me.Ghichu1 = ghichu1
            Me.Ghichu2 = ghichu2
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_PLAYMAU_C() As Integer
            Get
                Return _iD_PLAYMAU_C
            End Get
            Set(ByVal Value As Integer)
                _iD_PLAYMAU_C = Value
            End Set
        End Property

        Public Property ID_PLAYMAU() As Integer
            Get
                Return _iD_PLAYMAU
            End Get
            Set(ByVal Value As Integer)
                _iD_PLAYMAU = Value
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

        Public Property SoTB() As String
            Get
                Return _soTB
            End Get
            Set(ByVal Value As String)
                _soTB = Value
            End Set
        End Property

        Public Property KiemdinhH() As String
            Get
                Return _kiemdinhH
            End Get
            Set(ByVal Value As String)
                _kiemdinhH = Value
            End Set
        End Property

        Public Property KiemdinhT1() As String
            Get
                Return _kiemdinhT1
            End Get
            Set(ByVal Value As String)
                _kiemdinhT1 = Value
            End Set
        End Property

        Public Property KiemDinhT2() As String
            Get
                Return _kiemDinhT2
            End Get
            Set(ByVal Value As String)
                _kiemDinhT2 = Value
            End Set
        End Property

        Public Property Chatluong() As Byte
            Get
                Return _chatluong
            End Get
            Set(ByVal Value As Byte)
                _chatluong = Value
            End Set
        End Property

        Public Property Taymau() As Byte
            Get
                Return _taymau
            End Get
            Set(ByVal Value As Byte)
                _taymau = Value
            End Set
        End Property

        Public Property Dosach() As Byte
            Get
                Return _dosach
            End Get
            Set(ByVal Value As Byte)
                _dosach = Value
            End Set
        End Property

        Public Property DoDay() As Byte
            Get
                Return _doDay
            End Get
            Set(ByVal Value As Byte)
                _doDay = Value
            End Set
        End Property

        Public Property Kichco() As Byte
            Get
                Return _kichco
            End Get
            Set(ByVal Value As Byte)
                _kichco = Value
            End Set
        End Property

        Public Property Domin() As Byte
            Get
                Return _domin
            End Get
            Set(ByVal Value As Byte)
                _domin = Value
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
        Public Property Ghichu1() As String
            Get
                Return _ghichu1
            End Get
            Set(ByVal Value As String)
                _ghichu1 = Value
            End Set
        End Property
        Public Property Ghichu2() As String
            Get
                Return _ghichu2
            End Get
            Set(ByVal Value As String)
                _ghichu2 = Value
            End Set
        End Property
        Public Property Ten_KiemdinhH() As String
            Get
                'CanReadProperty("Ten_KiemdinhH", True)
                Return _Ten_KiemdinhH
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("Ten_KiemdinhH", True)
                If _Ten_KiemdinhH <> value Then
                    _Ten_KiemdinhH = value
                    'PropertyHasChanged("Ten_KiemdinhH")
                End If
            End Set
        End Property


        Public Property Ten_KiemdinhT1() As String
            Get
                'CanReadProperty("Ten_KiemdinhT1", True)
                Return _Ten_KiemdinhT1
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("Ten_KiemdinhT1", True)
                If _Ten_KiemdinhT1 <> value Then
                    _Ten_KiemdinhT1 = value
                    'PropertyHasChanged("Ten_KiemdinhT1")
                End If
            End Set
        End Property


        Public Property Ten_KiemDinhT2() As String
            Get
                'CanReadProperty("Ten_KiemDinhT2", True)
                Return _Ten_KiemDinhT2
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("Ten_KiemDinhT2", True)
                If _Ten_KiemDinhT2 <> value Then
                    _Ten_KiemDinhT2 = value
                    'PropertyHasChanged("Ten_KiemDinhT2")
                End If
            End Set
        End Property


        Public Property TEN_CHATLUONG() As String
            Get
                'CanReadProperty("TEN_CHATLUONG", True)
                Return _tEN_CHATLUONG
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TEN_CHATLUONG", True)
                If _tEN_CHATLUONG <> value Then
                    _tEN_CHATLUONG = value
                    'PropertyHasChanged("TEN_CHATLUONG")
                End If
            End Set
        End Property


        Public Property TEN_TAYMAU() As String
            Get
                'CanReadProperty("TEN_TAYMAU", True)
                Return _tEN_TAYMAU
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TEN_TAYMAU", True)
                If _tEN_TAYMAU <> value Then
                    _tEN_TAYMAU = value
                    'PropertyHasChanged("TEN_TAYMAU")
                End If
            End Set
        End Property


        Public Property TEN_DOSACH() As String
            Get
                'CanReadProperty("TEN_DOSACH", True)
                Return _tEN_DOSACH
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TEN_DOSACH", True)
                If _tEN_DOSACH <> value Then
                    _tEN_DOSACH = value
                    'PropertyHasChanged("TEN_DOSACH")
                End If
            End Set
        End Property


        Public Property TEN_DODAY() As String
            Get
                'CanReadProperty("TEN_DODAY", True)
                Return _tEN_DODAY
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TEN_DODAY", True)
                If _tEN_DODAY <> value Then
                    _tEN_DODAY = value
                    'PropertyHasChanged("TEN_DODAY")
                End If
            End Set
        End Property


        Public Property TEN_KICHCO() As String
            Get
                'CanReadProperty("TEN_KICHCO", True)
                Return _tEN_KICHCO
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TEN_KICHCO", True)
                If _tEN_KICHCO <> value Then
                    _tEN_KICHCO = value
                    'PropertyHasChanged("TEN_KICHCO")
                End If
            End Set
        End Property


        Public Property TEN_DOMIN() As String
            Get
                'CanReadProperty("TEN_DOMIN", True)
                Return _tEN_DOMIN
            End Get
            Set(ByVal value As String)
                'CanWriteProperty("TEN_DOMIN", True)
                If _tEN_DOMIN <> value Then
                    _tEN_DOMIN = value
                    'PropertyHasChanged("TEN_DOMIN")
                End If
            End Set
        End Property
        Public Property Ketqua() As Boolean
            Get
                Return _Ketqua
            End Get
            Set(ByVal Value As Boolean)
                _Ketqua = Value
            End Set
        End Property
        Public Property KetquaKD() As String
            Set(ByVal value As String)

                If _KetquaKD <> value Then
                    _KetquaKD = value

                End If
            End Set
            Get
                If _Ketqua = True Then
                    'Return "Nam"
                    KetquaKD = "**"
                Else
                    'Return " N? "
                    KetquaKD = ""
                End If

            End Get
        End Property
#End Region

    End Class

End Namespace
