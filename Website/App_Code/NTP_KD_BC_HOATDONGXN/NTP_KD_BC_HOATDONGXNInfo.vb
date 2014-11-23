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

Namespace YourCompany.Modules.NTP_KD_BC_HOATDONGXN

    ''' <summary>
    ''' The Info class for NTP_KD_BC_HOATDONGXN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_KD_BC_HOATDONGXNInfo

#Region "Private Members"
        Dim _NgayBCIn As String
        Dim _iD_HOATDONGXN As Integer
        Dim _quy As Byte
        Dim _nam As Integer
        Dim _iD_BENHVIEN As String
        Dim _huyenXN As Boolean
        Dim _tinhXN As Boolean
        Dim _soTBPhathienD As Integer
        Dim _soTBPhathienA As Integer
        Dim _soTBTheodoiD As Integer
        Dim _soTBTheodoiA As Integer
        Dim _ngayBC As DateTime
        Dim _nguoiBC As String
        Dim _pTNhap As Boolean
        Dim _Ten_BenhVien As String
        Dim _Ten_Tinh As String
        Dim _tinhXNTT As Boolean
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_HOATDONGXN As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal iD_BENHVIEN As String, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal soTBPhathienD As Integer, ByVal soTBPhathienA As Integer, ByVal soTBTheodoiD As Integer, ByVal soTBTheodoiA As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal pTNhap As Boolean, ByVal Ten_BenhVien As String, ByVal Ten_Tinh As String)
            Me.ID_HOATDONGXN = iD_HOATDONGXN
            Me.Quy = quy
            Me.Nam = nam
            Me.ID_BENHVIEN = iD_BENHVIEN
            Me.HuyenXN = huyenXN
            Me.TinhXN = tinhXN
            Me.SoTBPhathienD = soTBPhathienD
            Me.SoTBPhathienA = soTBPhathienA
            Me.SoTBTheodoiD = soTBTheodoiD
            Me.SoTBTheodoiA = soTBTheodoiA
            Me.NgayBC = ngayBC
            Me.NguoiBC = nguoiBC
            Me.PTNhap = pTNhap
            Me.Ten_Tinh = Ten_Tinh
            Me.Ten_BenhVien = Ten_BenhVien
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
        Public Property ID_HOATDONGXN() As Integer
            Get
                Return _iD_HOATDONGXN
            End Get
            Set(ByVal Value As Integer)
                _iD_HOATDONGXN = Value
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

        Public Property ID_BENHVIEN() As String
            Get
                Return _iD_BENHVIEN
            End Get
            Set(ByVal Value As String)
                _iD_BENHVIEN = Value
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
        Public Property SoTBPhathienD() As Integer
            Get
                Return _soTBPhathienD
            End Get
            Set(ByVal Value As Integer)
                _soTBPhathienD = Value
            End Set
        End Property

        Public Property SoTBPhathienA() As Integer
            Get
                Return _soTBPhathienA
            End Get
            Set(ByVal Value As Integer)
                _soTBPhathienA = Value
            End Set
        End Property

        Public Property SoTBTheodoiD() As Integer
            Get
                Return _soTBTheodoiD
            End Get
            Set(ByVal Value As Integer)
                _soTBTheodoiD = Value
            End Set
        End Property

        Public Property SoTBTheodoiA() As Integer
            Get
                Return _soTBTheodoiA
            End Get
            Set(ByVal Value As Integer)
                _soTBTheodoiA = Value
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
        Public Property Ten_BenhVien() As String
            Get
                Return _Ten_BenhVien
            End Get
            Set(ByVal Value As String)
                _Ten_BenhVien = Value
            End Set
        End Property
#End Region

    End Class
    Public Class NTP_KD_BC_HOATDONGXNCInfo

#Region "Private Members"
        Dim _iD_HOATDONGXNC As Integer
        Dim _iD_HOATDONGXN As Integer
        Dim _pHANLOAI As Byte
        Dim _duongAFB1Mau As Integer
        Dim _duongAFB2Mau As Integer
        Dim _duongAFB3Mau As Integer
        Dim _amAFB1Mau As Integer
        Dim _amAFB2Mau As Integer
        Dim _amAFB3Mau As Integer
        Dim _soBNDangky As Integer
        Dim _Ten_PhanLoai As String
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_HOATDONGXNC As Integer, ByVal iD_HOATDONGXN As Integer, ByVal pHANLOAI As Byte, ByVal duongAFB1Mau As Integer, ByVal duongAFB2Mau As Integer, ByVal duongAFB3Mau As Integer, ByVal amAFB1Mau As Integer, ByVal amAFB2Mau As Integer, ByVal amAFB3Mau As Integer, ByVal soBNDangky As Integer, ByVal Ten_PhanLoai As String)
            Me.ID_HOATDONGXNC = iD_HOATDONGXNC
            Me.ID_HOATDONGXN = iD_HOATDONGXN
            Me.PHANLOAI = pHANLOAI
            Me.DuongAFB1Mau = duongAFB1Mau
            Me.DuongAFB2Mau = duongAFB2Mau
            Me.DuongAFB3Mau = duongAFB3Mau
            Me.AmAFB1Mau = amAFB1Mau
            Me.AmAFB2Mau = amAFB2Mau
            Me.AmAFB3Mau = amAFB3Mau
            Me.SoBNDangky = soBNDangky
            Me.Ten_PhanLoai = Ten_PhanLoai
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_HOATDONGXNC() As Integer
            Get
                Return _iD_HOATDONGXNC
            End Get
            Set(ByVal Value As Integer)
                _iD_HOATDONGXNC = Value
            End Set
        End Property

        Public Property ID_HOATDONGXN() As Integer
            Get
                Return _iD_HOATDONGXN
            End Get
            Set(ByVal Value As Integer)
                _iD_HOATDONGXN = Value
            End Set
        End Property

        Public Property PHANLOAI() As Byte
            Get
                Return _pHANLOAI
            End Get
            Set(ByVal Value As Byte)
                _pHANLOAI = Value
            End Set
        End Property

        Public Property DuongAFB1Mau() As Integer
            Get
                Return _duongAFB1Mau
            End Get
            Set(ByVal Value As Integer)
                _duongAFB1Mau = Value
            End Set
        End Property

        Public Property DuongAFB2Mau() As Integer
            Get
                Return _duongAFB2Mau
            End Get
            Set(ByVal Value As Integer)
                _duongAFB2Mau = Value
            End Set
        End Property

        Public Property DuongAFB3Mau() As Integer
            Get
                Return _duongAFB3Mau
            End Get
            Set(ByVal Value As Integer)
                _duongAFB3Mau = Value
            End Set
        End Property

        Public Property AmAFB1Mau() As Integer
            Get
                Return _amAFB1Mau
            End Get
            Set(ByVal Value As Integer)
                _amAFB1Mau = Value
            End Set
        End Property

        Public Property AmAFB2Mau() As Integer
            Get
                Return _amAFB2Mau
            End Get
            Set(ByVal Value As Integer)
                _amAFB2Mau = Value
            End Set
        End Property

        Public Property AmAFB3Mau() As Integer
            Get
                Return _amAFB3Mau
            End Get
            Set(ByVal Value As Integer)
                _amAFB3Mau = Value
            End Set
        End Property

        Public Property SoBNDangky() As Integer
            Get
                Return _soBNDangky
            End Get
            Set(ByVal Value As Integer)
                _soBNDangky = Value
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
End Namespace
