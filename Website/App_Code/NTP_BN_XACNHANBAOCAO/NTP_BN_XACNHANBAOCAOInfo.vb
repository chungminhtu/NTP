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

Namespace YourCompany.Modules.NTP_BN_XACNHANBAOCAO

    ''' <summary>
    ''' The Info class for NTP_BN_XACNHANBAOCAO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_XACNHANBAOCAOInfo
        ' local property declarations
        Private _Id_MaBC As Integer
        Private _Quy As Integer
        Private _Nam As Integer
        Private _NgayBC As String
        Private _NguoiBC As String
        Private _LoaiBC As Integer
        Private _TenBC As String
        Private _Ten_TINH As String
        Private _Ma_TINH As String
        ' initialization
        Public Sub New()
        End Sub

        ' public properties
        Public Property Ten_TINH() As String
            Get
                Return _Ten_TINH
            End Get
            Set(ByVal Value As String)
                _Ten_TINH = Value
            End Set
        End Property
        Public Property Id_MaBC() As Integer
            Get
                Return _Id_MaBC
            End Get
            Set(ByVal Value As Integer)
                _Id_MaBC = Value
            End Set
        End Property

        Public Property Quy() As Integer
            Get
                Return _Quy
            End Get
            Set(ByVal Value As Integer)
                _Quy = Value
            End Set
        End Property

        Public Property NguoiBC() As String
            Get
                Return _NguoiBC
            End Get
            Set(ByVal Value As String)
                _NguoiBC = Value
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

        Public Property NgayBC() As String
            Get
                Return _NgayBC
            End Get
            Set(ByVal Value As String)
                _NgayBC = Value
            End Set
        End Property
        Public Property LoaiBC() As Integer
            Get
                Return _LoaiBC
            End Get
            Set(ByVal Value As Integer)
                _LoaiBC = Value
            End Set
        End Property
        Public Property TenBC() As String
            Get
                Return _TenBC
            End Get
            Set(ByVal Value As String)
                _TenBC = Value
            End Set
        End Property
        Public Property Ma_TINH() As String
            Get
                Return _Ma_TINH
            End Get
            Set(ByVal Value As String)
                _Ma_TINH = Value
            End Set
        End Property
    End Class

End Namespace
