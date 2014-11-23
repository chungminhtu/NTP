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

Namespace YourCompany.Modules.NTP_BN_THUOC

    ''' <summary>
    ''' The Info class for NTP_BN_THUOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_THUOCInfo
#Region "Private Members"
        Dim _iD_Thuoc As Integer
        Dim _iD_Dieutri As Integer
        Dim _ngayDT As DateTime
        Dim _iD_PhacdoDT As Integer
        Dim _phacDoKhac As String
        Dim _giaidoanDT As Boolean
        Dim _tungay As DateTime
        Dim _rHZE As Byte
        Dim _rHZ As Byte
        Dim _rHE As Byte
        Dim _rH As Byte
        Dim _eH As Byte
        Dim _e As Byte
        Dim _h As Byte
        Dim _z As Byte
        Dim _s As Byte
        Dim _tLaoKhac As String
        Dim _cotrimoxazole As Byte
        Dim _aRT As String
        Dim _khac As String
        Dim _nGAY_NM As DateTime
        Dim _nGUOI_NM As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_Thuoc As Integer, ByVal iD_Dieutri As Integer, ByVal ngayDT As DateTime, ByVal iD_PhacdoDT As Integer, ByVal phacDoKhac As String, ByVal giaidoanDT As Boolean, ByVal tungay As DateTime, ByVal rHZE As Byte, ByVal rHZ As Byte, ByVal rHE As Byte, ByVal rH As Byte, ByVal eH As Byte, ByVal e As Byte, ByVal h As Byte, ByVal z As Byte, ByVal s As Byte, ByVal tLaoKhac As String, ByVal cotrimoxazole As Byte, ByVal aRT As String, ByVal khac As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer)
            Me.ID_Thuoc = ID_Thuoc
            Me.ID_Dieutri = ID_Dieutri
            Me.NgayDT = NgayDT
            Me.ID_PhacdoDT = ID_PhacdoDT
            Me.PhacDoKhac = PhacDoKhac
            Me.GiaidoanDT = GiaidoanDT
            Me.Tungay = Tungay
            Me.RHZE = RHZE
            Me.RHZ = RHZ
            Me.RHE = RHE
            Me.RH = RH
            Me.EH = EH
            Me.E = E
            Me.H = H
            Me.Z = Z
            Me.S = S
            Me.TLaoKhac = TLaoKhac
            Me.Cotrimoxazole = Cotrimoxazole
            Me.ART = ART
            Me.Khac = Khac
            Me.NGAY_NM = NGAY_NM
            Me.NGUOI_NM = NGUOI_NM
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_Thuoc() As Integer
            Get
                Return _iD_Thuoc
            End Get
            Set(ByVal Value As Integer)
                _iD_Thuoc = Value
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

        Public Property NgayDT() As DateTime
            Get
                Return _ngayDT
            End Get
            Set(ByVal Value As DateTime)
                _ngayDT = Value
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

        Public Property PhacDoKhac() As String
            Get
                Return _phacDoKhac
            End Get
            Set(ByVal Value As String)
                _phacDoKhac = Value
            End Set
        End Property

        Public Property GiaidoanDT() As Boolean
            Get
                Return _giaidoanDT
            End Get
            Set(ByVal Value As Boolean)
                _giaidoanDT = Value
            End Set
        End Property

        Public Property Tungay() As DateTime
            Get
                Return _tungay
            End Get
            Set(ByVal Value As DateTime)
                _tungay = Value
            End Set
        End Property

        Public Property RHZE() As Byte
            Get
                Return _rHZE
            End Get
            Set(ByVal Value As Byte)
                _rHZE = Value
            End Set
        End Property

        Public Property RHZ() As Byte
            Get
                Return _rHZ
            End Get
            Set(ByVal Value As Byte)
                _rHZ = Value
            End Set
        End Property

        Public Property RHE() As Byte
            Get
                Return _rHE
            End Get
            Set(ByVal Value As Byte)
                _rHE = Value
            End Set
        End Property

        Public Property RH() As Byte
            Get
                Return _rH
            End Get
            Set(ByVal Value As Byte)
                _rH = Value
            End Set
        End Property

        Public Property EH() As Byte
            Get
                Return _eH
            End Get
            Set(ByVal Value As Byte)
                _eH = Value
            End Set
        End Property

        Public Property E() As Byte
            Get
                Return _e
            End Get
            Set(ByVal Value As Byte)
                _e = Value
            End Set
        End Property

        Public Property H() As Byte
            Get
                Return _h
            End Get
            Set(ByVal Value As Byte)
                _h = Value
            End Set
        End Property

        Public Property Z() As Byte
            Get
                Return _z
            End Get
            Set(ByVal Value As Byte)
                _z = Value
            End Set
        End Property

        Public Property S() As Byte
            Get
                Return _s
            End Get
            Set(ByVal Value As Byte)
                _s = Value
            End Set
        End Property

        Public Property TLaoKhac() As String
            Get
                Return _tLaoKhac
            End Get
            Set(ByVal Value As String)
                _tLaoKhac = Value
            End Set
        End Property

        Public Property Cotrimoxazole() As Byte
            Get
                Return _cotrimoxazole
            End Get
            Set(ByVal Value As Byte)
                _cotrimoxazole = Value
            End Set
        End Property

        Public Property ART() As String
            Get
                Return _aRT
            End Get
            Set(ByVal Value As String)
                _aRT = Value
            End Set
        End Property

        Public Property Khac() As String
            Get
                Return _khac
            End Get
            Set(ByVal Value As String)
                _khac = Value
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

End Namespace
