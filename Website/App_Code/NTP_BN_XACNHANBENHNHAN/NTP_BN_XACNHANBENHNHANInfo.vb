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

Namespace YourCompany.Modules.NTP_BN_XACNHANBENHNHAN

    ''' <summary>
    ''' The Info class for NTP_BN_XACNHANBENHNHAN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_XACNHANBENHNHANInfo
    
            ' local property declarations
            Private _ID_Dieutri As Integer
            Private _ID_Benhnhan As String
            Private _Hoten As String
            Private _Tuoi As Integer
            Private _NgayDT As String
            Private _NgayRV As String
        Private _gioitinh As Boolean
        Private _GT As String

            Private _Diachi As String
            Private _Ten_PhanloaiBN As String
            Private _Ten_KetquaDT As String
            Private _MaDV As String
            ' initialization
            Public Sub New()
            End Sub

            ' public properties
            Public Property ID_benhnhan() As String
                Get
                    Return _ID_Benhnhan
                End Get
                Set(ByVal Value As String)
                    _ID_Benhnhan = Value
                End Set
            End Property
            Public Property Id_dieutri() As Integer
                Get
                    Return _ID_Dieutri
                End Get
                Set(ByVal Value As Integer)
                    _ID_Dieutri = Value
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

            Public Property Diachi() As String
                Get
                    Return _Diachi
                End Get
                Set(ByVal Value As String)
                    _Diachi = Value
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
                Return _gioitinh
            End Get
            Set(ByVal Value As Boolean)
                _gioitinh = Value
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
                    GT = "N?"
                End If

            End Get
        End Property
            Public Property NgayDT() As String
                Get
                    Return _NgayDT
                End Get
                Set(ByVal Value As String)
                    _NgayDT = Value
                End Set
            End Property
            Public Property NgayRV() As String
                Get
                    Return _NgayRV
                End Get
                Set(ByVal Value As String)
                    _NgayRV = Value
                End Set
            End Property
            Public Property Ten_PhanloaiBN() As String
                Get
                    Return _Ten_PhanloaiBN
                End Get
                Set(ByVal Value As String)
                    _Ten_PhanloaiBN = Value
                End Set
            End Property
            Public Property Ten_KetquaDT() As String
                Get
                    Return _Ten_KetquaDT
                End Get
                Set(ByVal Value As String)
                    _Ten_KetquaDT = Value
                End Set
            End Property
            Public Property MaDV() As String
                Get
                    Return _MaDV
                End Get
                Set(ByVal Value As String)
                    _MaDV = Value
                End Set
            End Property
      

    End Class

End Namespace
