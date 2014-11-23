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

Namespace YourCompany.Modules.NTP_BAOCAOTUYENTINH

    ''' <summary>
    ''' The Info class for NTP_BAOCAOTUYENTINH
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
   
    Public Class NTP_BAOCAOTUYENTINHInfo
        ' local property declarations
        Dim _NguoiBC As String
        Dim _Ngaybc As DateTime
        Dim _quy As Byte
        Dim _nam As Integer
        Dim _mA_TINH As String
        Dim _Ma_huyen As String
        ' initialization
        Public Sub New()

        End Sub

        ' public properties
        Public Property NguoiBC() As String
            Get
                Return _NguoiBC
            End Get
            Set(ByVal Value As String)
                _NguoiBC = Value
            End Set
        End Property
        Public Property Ngaybc() As DateTime
            Get
                Return _Ngaybc
            End Get
            Set(ByVal Value As DateTime)
                _Ngaybc = Value
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

        Public Property MA_TINH() As String
            Get
                Return _mA_TINH
            End Get
            Set(ByVal Value As String)
                _mA_TINH = Value
            End Set
        End Property
        Public Property MA_Huyen() As String
            Get
                Return _Ma_huyen
            End Get
            Set(ByVal Value As String)
                _Ma_huyen = Value
            End Set
        End Property

    End Class
    Public Class NTP_DMTINHInfo

#Region "Private Members"
        Dim _MA_Tinh As String
        Dim _tEN_Tinh As String
#End Region
        Public Property tEN_Tinh() As String
            Get
                Return _tEN_Tinh
            End Get
            Set(ByVal Value As String)
                _tEN_Tinh = Value
            End Set
        End Property

        Public Property MA_Tinh() As String
            Get
                Return _MA_Tinh
            End Get
            Set(ByVal Value As String)
                _MA_Tinh = Value
            End Set
        End Property

    End Class
    Public Class NTP_DM_BENHVIENInfo

#Region "Private Members"
        Dim _iD_BENHVIEN As String
        Dim _tEN_BENHVIEN As String
        Dim _iD_Phanloaiyte As String
        Dim _iD_MATINH As String
        Dim _iD_HUYEN As String
        Dim _cAPQUANLY As Byte
        Dim _iD_VUNG As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_BENHVIEN As String, ByVal tEN_BENHVIEN As String, ByVal iD_Phanloaiyte As String, ByVal iD_MATINH As String, ByVal iD_HUYEN As String, ByVal cAPQUANLY As Byte, ByVal iD_VUNG As Integer)
            Me.ID_BENHVIEN = ID_BENHVIEN
            Me.TEN_BENHVIEN = TEN_BENHVIEN
            Me.ID_Phanloaiyte = ID_Phanloaiyte
            Me.ID_MATINH = ID_MATINH
            Me.ID_HUYEN = ID_HUYEN
            Me.CAPQUANLY = CAPQUANLY
            Me.ID_VUNG = ID_VUNG
        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_BENHVIEN() As String
            Get
                Return _iD_BENHVIEN
            End Get
            Set(ByVal Value As String)
                _iD_BENHVIEN = Value
            End Set
        End Property

        Public Property TEN_BENHVIEN() As String
            Get
                Return _tEN_BENHVIEN
            End Get
            Set(ByVal Value As String)
                _tEN_BENHVIEN = Value
            End Set
        End Property

        Public Property ID_Phanloaiyte() As String
            Get
                Return _iD_Phanloaiyte
            End Get
            Set(ByVal Value As String)
                _iD_Phanloaiyte = Value
            End Set
        End Property

        Public Property ID_MATINH() As String
            Get
                Return _iD_MATINH
            End Get
            Set(ByVal Value As String)
                _iD_MATINH = Value
            End Set
        End Property

        Public Property ID_HUYEN() As String
            Get
                Return _iD_HUYEN
            End Get
            Set(ByVal Value As String)
                _iD_HUYEN = Value
            End Set
        End Property

        Public Property CAPQUANLY() As Byte
            Get
                Return _cAPQUANLY
            End Get
            Set(ByVal Value As Byte)
                _cAPQUANLY = Value
            End Set
        End Property

        Public Property ID_VUNG() As Integer
            Get
                Return _iD_VUNG
            End Get
            Set(ByVal Value As Integer)
                _iD_VUNG = Value
            End Set
        End Property
#End Region


    End Class
End Namespace
