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
Imports DotNetNuke

Namespace YourCompany.Modules.NTP_BN_BC_KETQUADT

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' An abstract class for the data access layer
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

        ' singleton reference to the instantiated object 
        Private Shared objProvider As DataProvider = Nothing

        ' constructor
        Shared Sub New()
            CreateProvider()
        End Sub

        ' dynamically create provider
        Private Shared Sub CreateProvider()
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_BC_KETQUADT", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region



#Region "NTP_BN_BC_KETQUADT Methods"


        Public MustOverride Function GetNTP_BN_BC_KETQUADT(ByVal iD_BC_KetquaDT As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_BC_KETQUADT() As IDataReader
        Public MustOverride Function GET_ID_BAOCAO(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String) As IDataReader
        Public MustOverride Function ListNTP_BN_DONVICHUABC(ByVal quy As Byte, ByVal nam As Integer, ByVal _mA_TINH As String, ByVal LOAIBC As Byte, ByVal dVBaocao As String) As IDataReader
        Public MustOverride Function AddNTP_BN_BC_KETQUADT(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean) As Integer
        Public MustOverride Sub UpdateNTP_BN_BC_KETQUADT(ByVal iD_BC_KetquaDT As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean)
        Public MustOverride Sub DeleteNTP_BN_BC_KETQUADT(ByVal iD_BC_KetquaDT As Integer)
        Public MustOverride Function ListByDieuKien(ByVal Nam As String, ByVal Id_BenhVien As String, ByVal DieuKien As String, ByVal MA_TINH As String) As IDataReader
#End Region





#Region "NTP_BN_BC_KETQUADTP Methods"
        Public MustOverride Function GetNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDTP1 As Integer) As IDataReader
        Public MustOverride Function ListKETQUADTP1(ByVal iD_BC_KetquaDTP1 As Integer, ByVal iD_Phanloai As Integer, ByVal dVBaocao As String, ByVal Quy As Integer, ByVal Nam As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_BC_KETQUADTP(ByVal ID_BC_KetquaDT As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDT As Integer, ByVal iD_Phanloai As Byte, ByVal soBNDK As Integer, ByVal khoi As Integer, ByVal hoanthanh As Integer, ByVal chet As Integer, ByVal thatbai As Integer, ByVal bo As Integer, ByVal chuyen As Integer, ByVal khongdanhgia As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDTP1 As Integer, ByVal iD_BC_KetquaDT As Integer, ByVal iD_Phanloai As Byte, ByVal soBNDK As Integer, ByVal khoi As Integer, ByVal hoanthanh As Integer, ByVal chet As Integer, ByVal thatbai As Integer, ByVal bo As Integer, ByVal chuyen As Integer, ByVal khongdanhgia As Integer)
        Public MustOverride Sub DeleteNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDTP1 As Integer)
#End Region




#Region "NTP_BN_BC_KETQUADTP2 Methods"
        Public MustOverride Function GetNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT_P2 As Integer) As IDataReader
        Public MustOverride Function ListKETQUADTP2(ByVal iD_BC_KetquaDTP2 As Integer, ByVal Phanloai As Byte) As IDataReader
        Public MustOverride Function ListNTP_BN_BC_KETQUADTP2(ByVal ID_BC_KetquaDT As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT As Integer, ByVal phanloai As Byte, ByVal xNHIV As Decimal, ByVal duongHIV As Integer, ByVal cPT As Integer, ByVal aRV As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT_P2 As Integer, ByVal iD_BC_KetquaDT As Integer, ByVal phanloai As Byte, ByVal xNHIV As Decimal, ByVal duongHIV As Integer, ByVal cPT As Integer, ByVal aRV As Integer)
        Public MustOverride Sub DeleteNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT_P2 As Integer)
#End Region
#Region "NTP_BN_BCKETQUADIEUTRILAOIN Methods"
        Public MustOverride Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Luachon As Integer, ByVal Dieukien As String) As DataSet
        Public MustOverride Function ListBaoCaoKQDTCacthe(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String) As DataSet
        Public MustOverride Function BCKETQUADIEUTRILAOBYHUYEN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Luachon As Integer, ByVal Dieukien As String) As DataSet
#End Region


#Region "NTP_DM_BENHVIEN Methods"

        Public MustOverride Function ListNTP_DM_BENHVIEN(ByVal MA_TINH As String) As IDataReader
        Public MustOverride Function ListNTP_DM_BENHVIEN_BY_VUNG(ByVal sTEN_BV As String, ByVal IDVung As Integer) As IDataReader

#End Region

#Region "NTP_DM_TINH Methods"
        Public MustOverride Function ListNTP_DM_TINHALL() As IDataReader
        Public MustOverride Function ListNTP_DM_TINH(ByVal id_benhvien As String) As IDataReader
        Public MustOverride Function ListNTP_DM_TINHforMIEN(ByVal Mien As Integer) As IDataReader

#End Region

#Region "NTP_DM_MIEN Methods"

        Public MustOverride Function ListNTP_DM_MIEN() As IDataReader
        Public MustOverride Function NTP_DM_MIEN_Select(ByVal ID_MIEN As Integer) As IDataReader

       
#End Region



#Region "NTP_DM_VUNG Methods"
        Public MustOverride Function GetNTP_DM_VUNG(ByVal iD_VUNG As Integer) As IDataReader
        Public MustOverride Function ListNTP_DM_VUNGALL() As IDataReader
        Public MustOverride Function ListNTP_DM_VUNG(ByVal Mien As Integer) As IDataReader
        Public MustOverride Function AddNTP_DM_VUNG(ByVal tEN_VUNG As String, ByVal iD_MIEN As Integer) As Integer
        Public MustOverride Sub UpdateNTP_DM_VUNG(ByVal iD_VUNG As Integer, ByVal tEN_VUNG As String, ByVal iD_MIEN As Integer)
        Public MustOverride Sub DeleteNTP_DM_VUNG(ByVal iD_VUNG As Integer)
#End Region

#Region "NTP_DM_LOAIBV Methods"

        Public MustOverride Function ListNTP_DM_LOAIBV() As IDataReader
       

#End Region




    End Class

End Namespace