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

Namespace YourCompany.Modules.NTP_KD_BC_HOATDONGXN

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_KD_BC_HOATDONGXN", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region



#Region "NTP_KD_BC_HOATDONGXN Methods"
        Public MustOverride Function GetNTP_KD_BC_HOATDONGXN(ByVal iD_HOATDONGXN As Integer) As IDataReader
        Public MustOverride Function ListNTP_KD_BC_HOATDONGXN() As IDataReader
        Public MustOverride Function GET_ID_BAOCAO(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_BENHVIEN As String) As IDataReader

        Public MustOverride Function ListByDieuKien(ByVal ThangNam As String, ByVal Id_BenhVien As String, ByVal DieuKien As String, ByVal MA_TINH As String) As IDataReader
        Public MustOverride Function AddNTP_KD_BC_HOATDONGXN(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_BENHVIEN As String, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal soTBPhathienD As Integer, ByVal soTBPhathienA As Integer, ByVal soTBTheodoiD As Integer, ByVal soTBTheodoiA As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal pTNhap As Boolean) As Integer
        Public MustOverride Sub UpdateNTP_KD_BC_HOATDONGXN(ByVal iD_HOATDONGXN As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal iD_BENHVIEN As String, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal soTBPhathienD As Integer, ByVal soTBPhathienA As Integer, ByVal soTBTheodoiD As Integer, ByVal soTBTheodoiA As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal pTNhap As Boolean)
        Public MustOverride Sub DeleteNTP_KD_BC_HOATDONGXN(ByVal iD_HOATDONGXN As Integer)
        Public MustOverride Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
        Public MustOverride Function NTP_KD_BCHOATDONGXETNGHIEMBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet

#End Region


#Region "NTP_KD_BC_HOATDONGXNC Methods"
        Public MustOverride Function GetNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXNC As Integer) As IDataReader
        Public MustOverride Function ListHOATDONGXNC(ByVal iD_HOATDONGXNC As Integer, ByVal Phanloai As Integer) As IDataReader

        Public MustOverride Function ListNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXN As Integer) As IDataReader
        Public MustOverride Function AddNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXN As Integer, ByVal pHANLOAI As Byte, ByVal duongAFB1Mau As Integer, ByVal duongAFB2Mau As Integer, ByVal duongAFB3Mau As Integer, ByVal amAFB1Mau As Integer, ByVal amAFB2Mau As Integer, ByVal amAFB3Mau As Integer, ByVal soBNDangky As Integer) As Integer
        Public MustOverride Sub UpdateNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXNC As Integer, ByVal iD_HOATDONGXN As Integer, ByVal pHANLOAI As Byte, ByVal duongAFB1Mau As Integer, ByVal duongAFB2Mau As Integer, ByVal duongAFB3Mau As Integer, ByVal amAFB1Mau As Integer, ByVal amAFB2Mau As Integer, ByVal amAFB3Mau As Integer, ByVal soBNDangky As Integer)
        Public MustOverride Sub DeleteNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXNC As Integer)
#End Region




    End Class

End Namespace