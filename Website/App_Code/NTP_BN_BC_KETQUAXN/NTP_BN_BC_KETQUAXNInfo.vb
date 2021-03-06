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

Namespace YourCompany.Modules.NTP_BN_BC_KETQUAXN

    ''' <summary>
    ''' The Info class for NTP_BN_BC_KETQUAXN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_BC_KETQUAXNInfo
#Region "Private Members"
        Dim _IDKetquaXN As Integer
        Dim _quy As Byte = 0
        Dim _nam As Integer
        Dim _dVBaocao As String = String.Empty
        Dim _nguoiBC As String = String.Empty
        Dim _ngayBC As String
        Dim _laoDTMoi As Int32 = 0
        Dim _laoTaitri As Int32 = 0
        Dim _DuongHaiT As Int32 = 0
        Dim _AmHaiT As Int32 = 0
        Dim _KhongHaiT As Int32 = 0
        Dim _DuongBaT As Int32 = 0
        Dim _AmBaT As Int32 = 0
        Dim _KhongBaT As Int32 = 0
        Dim _MA_HUYEN As String
        Dim _MA_TINH As String
        Dim _TEN_TINH As String
        Dim _pTNhap As Boolean = False
        Dim _nGUOI_NM As Integer
        Dim _Ten_Benhvien As String
        Dim _ID_Benhvien As String
        Dim _TinhXN As Boolean
        Dim _TinhXNTT As Boolean
        Dim _HuyenXN As Boolean
        Dim _XNTinh As String
#End Region
        ' initialization
#Region "Constructors"

        Public Sub New()
        End Sub

        Public Sub New(ByVal ID_BC_KetquaXN As Integer, ByVal Quy As Integer, ByVal Nam As Integer, ByVal DVBaocao As String, ByVal NguoiBC As String, ByVal NgayBC As DateTime, ByVal LaoDTMoi As Integer, ByVal LaoTaitri As Integer, ByVal DuongHaiT As Integer, ByVal AmHaiT As Integer, ByVal KhongHaiT As Integer, ByVal DuongBaT As Integer, ByVal AmBaT As Integer, ByVal KhongBaT As Integer, ByVal NGUOI_NM As Integer)
            Me.IDKetquaXN = ID_BC_KetquaXN
            Me.Quy = Quy
            Me.Nam = Nam
            Me.DVBaocao = DVBaocao
            Me.NguoiBC = NguoiBC
            Me.NgayBC = NgayBC
            Me.LaoDTMoi = LaoDTMoi
            Me.LaoTaitri = LaoTaitri
            Me.DuongHaiT = DuongHaiT
            Me.AmHaiT = AmHaiT
            Me.KhongHaiT = KhongHaiT
            Me.Nguoi_NM = NGUOI_NM
        End Sub

#End Region
#Region "Public Properties"
       
        Public Property IDKetquaXN() As Integer
            Get
                Return _IDKetquaXN
            End Get
            Set(ByVal Value As Integer)
                _IDKetquaXN = Value
            End Set
        End Property


        Public Property Quy() As Byte
            Get
                Return _quy
            End Get
            Set(ByVal value As Byte)
                If _quy <> value Then
                    _quy = value
                End If
            End Set
        End Property


        Public Property Nam() As Integer
            Get
                Return _nam
            End Get
            Set(ByVal value As Integer)
                If _nam <> value Then
                    _nam = value
                End If
            End Set
        End Property


        Public Property DVBaocao() As String
            Get
                Return _dVBaocao
            End Get
            Set(ByVal value As String)
                If _dVBaocao <> value Then
                    _dVBaocao = value
                End If
            End Set
        End Property


        Public Property NguoiBC() As String
            Get
                Return _nguoiBC
            End Get
            Set(ByVal value As String)
                If _nguoiBC <> value Then
                    _nguoiBC = value
                End If
            End Set
        End Property


        Public Property NgayBC() As String
            Get
                Return _ngayBC
            End Get
            Set(ByVal value As String)
                If _ngayBC <> value Then
                    _ngayBC = value
                End If
            End Set
        End Property


        Public Property LaoDTMoi() As Int32
            Get
                Return _laoDTMoi
            End Get
            Set(ByVal value As Int32)
                If _laoDTMoi <> value Then
                    _laoDTMoi = value
                End If
            End Set
        End Property


        Public Property LaoTaitri() As Int32
            Get
                Return _laoTaitri
            End Get
            Set(ByVal value As Int32)
                If _laoTaitri <> value Then
                    _laoTaitri = value
                End If
            End Set
        End Property

        Public Property DuongHaiT() As Int32
            Get
                Return _DuongHaiT
            End Get
            Set(ByVal value As Int32)
                If _DuongHaiT <> value Then
                    _DuongHaiT = value
                End If
            End Set
        End Property
        Public Property AmHaiT() As Int32
            Get
                Return _AmHaiT
            End Get
            Set(ByVal value As Int32)
                If _AmHaiT <> value Then
                    _AmHaiT = value
                End If
            End Set
        End Property
        Public Property KhongHaiT() As Int32
            Get
                Return _KhongHaiT
            End Get
            Set(ByVal value As Int32)
                If _KhongHaiT <> value Then
                    _KhongHaiT = value
                End If
            End Set
        End Property
        Public Property DuongBaT() As Int32
            Get
                Return _DuongBaT
            End Get
            Set(ByVal value As Int32)
                If _DuongBaT <> value Then
                    _DuongBaT = value
                End If
            End Set
        End Property
        Public Property AmBaT() As Int32
            Get
                Return _AmBaT
            End Get
            Set(ByVal value As Int32)
                If _AmBaT <> value Then
                    _AmBaT = value
                End If
            End Set
        End Property
        Public Property KhongBaT() As Int32
            Get
                Return _KhongBaT
            End Get
            Set(ByVal value As Int32)
                If _KhongBaT <> value Then
                    _KhongBaT = value
                End If
            End Set
        End Property
        Public Property MA_TINH() As String
            Get
                Return _MA_TINH
            End Get
            Set(ByVal value As String)
                If _MA_TINH <> value Then
                    _MA_TINH = value
                End If
            End Set
        End Property
        Public Property TEN_TINH() As String
            Get
                Return _TEN_TINH
            End Get
            Set(ByVal value As String)
                If _TEN_TINH <> value Then
                    _TEN_TINH = value
                End If
            End Set
        End Property


        Public Property MA_HUYEN() As String
            Get
                Return _MA_HUYEN
            End Get
            Set(ByVal value As String)
                If _MA_HUYEN <> value Then
                    _MA_HUYEN = value
                End If
            End Set
        End Property


        Public Property PTNhap() As Boolean
            Get
                Return _pTNhap
            End Get
            Set(ByVal value As Boolean)
                If _pTNhap <> value Then
                    _pTNhap = value
                End If
            End Set
        End Property


        Public Property Nguoi_NM() As Integer
            Get
                Return _nGUOI_NM
            End Get
            Set(ByVal value As Integer)
                If _nGUOI_NM <> value Then
                    _nGUOI_NM = value
                End If
            End Set
        End Property
        Public Property Ten_Benhvien() As String
            Get
                Return _Ten_Benhvien
            End Get
            Set(ByVal value As String)
                If _Ten_Benhvien <> value Then
                    _Ten_Benhvien = value
                End If
            End Set
        End Property
        Public Property ID_Benhvien() As String
            Get
                Return _ID_Benhvien
            End Get
            Set(ByVal value As String)
                If _ID_Benhvien <> value Then
                    _ID_Benhvien = value
                End If
            End Set
        End Property
        Public Property TinhXN() As Boolean
            Get
                Return _TinhXN
            End Get
            Set(ByVal value As Boolean)
                If _TinhXN <> value Then
                    _TinhXN = value
                End If
            End Set
        End Property
        Public Property TinhXNTT() As Boolean
            Get
                Return _TinhXNTT
            End Get
            Set(ByVal value As Boolean)
                If _TinhXNTT <> value Then
                    _TinhXNTT = value
                End If
            End Set
        End Property
        Public Property XNTinh() As String
            Set(ByVal value As String)

                If _XNTinh <> value Then
                    _XNTinh = value

                End If
            End Set
            Get
                If _TinhXN = True Then
                    'Return "Nam"
                    XNTinh = "Đã XN"
                Else
                    'Return " N? "
                    XNTinh = "Chưa XN"
                End If

            End Get
        End Property
        Public Property HUYENXN() As Boolean
            Get
                Return _HuyenXN
            End Get
            Set(ByVal value As Boolean)
                If _HuyenXN <> value Then
                    _HuyenXN = value
                End If
            End Set
        End Property
#End Region
    End Class

End Namespace
