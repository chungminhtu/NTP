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

Namespace YourCompany.Modules.NTP_BN_KETQUADT

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
    End Class

End Namespace
