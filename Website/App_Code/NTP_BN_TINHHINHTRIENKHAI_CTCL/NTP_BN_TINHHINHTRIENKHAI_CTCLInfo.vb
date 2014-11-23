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

Namespace YourCompany.Modules.NTP_BN_TINHHINHTRIENKHAI_CTCL

    ''' <summary>
    ''' The Info class for NTP_BN_TINHHINHTRIENKHAI_CTCL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_TINHHINHTRIENKHAI_CTCLInfo
        ' local property declarations
        Dim _Nam As Integer
        Dim _Ma_Tinh As String
        Dim _ID_TRIENKHAI As Integer
        Dim _SLHuyen As Integer
        Dim _SLHuyenTK As Integer
        Dim _SLXa As Integer
        Dim _SLXaTK As Integer
        Dim _DansoTinh As Integer
        Dim _SodanTK As Integer
        Dim _TEN_TINH As String
        Dim _SoDVQL As Integer
        ' initialization

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal ID_TRIENKHAI As Integer, ByVal Nam As Integer, ByVal Ma_Tinh As String, ByVal SLHUYEN As Integer, ByVal SLHuyenTK As Integer, ByVal SLXa As Integer, ByVal SLXaTK As Integer, ByVal DansoTinh As Integer, ByVal SodanTK As Integer, ByVal SoDVQL As Integer)
            Me.ID_TRIENKHAI = ID_TRIENKHAI
            Me.Nam = Nam
            Me.SLHuyen = SLHUYEN
            Me.SLHuyenTK = SLHuyenTK
            Me.MA_TINH = Ma_Tinh
            Me.SLXa = SLXa
            Me.SLXaTK = SLXaTK
            Me.DansoTinh = DansoTinh
            Me.SodanTK = SodanTK
            Me.SoDVQL = SoDVQL

        End Sub
#End Region
        ' public properties
        Public Property ID_TRIENKHAI() As Integer
            Get
                Return _ID_TRIENKHAI
            End Get
            Set(ByVal Value As Integer)
                _ID_TRIENKHAI = Value
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
        Public Property TEN_Tinh() As String
            Get
                Return _TEN_TINH
            End Get
            Set(ByVal Value As String)
                _TEN_TINH = Value
            End Set
        End Property
        Public Property SLHuyen() As Integer
            Get
                Return _SLHuyen
            End Get
            Set(ByVal Value As Integer)
                _SLHuyen = Value
            End Set
        End Property

        Public Property SLHuyenTK() As Integer
            Get
                Return _SLHuyenTK
            End Get
            Set(ByVal Value As Integer)
                _SLHuyenTK = Value
            End Set
        End Property

        Public Property SLXa() As Integer
            Get
                Return _SLXa
            End Get
            Set(ByVal Value As Integer)
                _SLXa = Value
            End Set
        End Property

        Public Property SLXaTK() As Integer
            Get
                Return _SLXaTK
            End Get
            Set(ByVal Value As Integer)
                _SLXaTK = Value
            End Set
        End Property
        Public Property DansoTinh() As Integer
            Get
                Return _DansoTinh
            End Get
            Set(ByVal Value As Integer)
                _DansoTinh = Value
            End Set
        End Property


        Public Property SodanTK() As Integer
            Get
                Return _SodanTK
            End Get
            Set(ByVal Value As Integer)
                _SodanTK = Value
            End Set
        End Property
        Public Property SoDVQL() As Integer
            Get
                Return _SoDVQL
            End Get
            Set(ByVal value As Integer)
                _SoDVQL = value
            End Set
        End Property
    End Class

End Namespace
