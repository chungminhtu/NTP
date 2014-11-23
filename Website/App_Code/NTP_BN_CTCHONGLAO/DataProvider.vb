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

Namespace YourCompany.Modules.NTP_BN_CTCHONGLAO

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_CTCHONGLAO", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region

#Region "NTP_BN_CTCHONGLAO Methods"
        Public MustOverride Function GetNTP_BN_CTCHONGLAO(ByVal iD_CTChonglao As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_CTCHONGLAO() As IDataReader
        Public MustOverride Function ListByDieuKien(ByVal ThangNam As String, ByVal Id_BenhVien As String, ByVal DieuKien As String) As IDataReader
        Public MustOverride Function AddNTP_BN_CTCHONGLAO(ByVal nam As Integer, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal mADV As String, ByVal aFBcongdong As Integer, ByVal aFBhotro As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal SoBNPhathien As Integer, ByVal SoBNDKDT As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_CTCHONGLAO(ByVal iD_CTChonglao As Integer, ByVal nam As Integer, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal mADV As String, ByVal aFBcongdong As Integer, ByVal aFBhotro As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal SoBNPhathien As Integer, ByVal SoBNDKDT As Integer)
        Public MustOverride Sub DeleteNTP_BN_CTCHONGLAO(ByVal iD_CTChonglao As Integer)
       
#End Region




#Region "NTP_BN_CTCHONGLAOP1 Methods"
        Public MustOverride Function GetNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer) As IDataReader
        Public MustOverride Function ListCTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer, ByVal phanloai As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_CTCHONGLAOP1(ByVal Id_CTChongLao As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal soCShienco As Integer, ByVal soCSTrienkhai As Integer, ByVal diemkinhTT As Integer, ByVal diemkinhKD As Integer, ByVal xNNC As Integer, ByVal xNKSD As Integer, ByVal tuvanHIV As Integer, ByVal cungcapART As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer, ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal soCShienco As Integer, ByVal soCSTrienkhai As Integer, ByVal diemkinhTT As Integer, ByVal diemkinhKD As Integer, ByVal xNNC As Integer, ByVal xNKSD As Integer, ByVal tuvanHIV As Integer, ByVal cungcapART As Integer)
        Public MustOverride Sub DeleteNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer)
#End Region


#Region "NTP_BN_CTCHONGLAOP2 Methods"
        Public MustOverride Function GetNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer) As IDataReader
        Public MustOverride Function ListCTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer, ByVal loaihinhYte As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_CTCHONGLAOP2(ByVal Id_CTChongLao As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglao As Integer, ByVal loaihinhYte As Long, ByVal duocChuyen As Integer, ByVal chandoan As Integer, ByVal dieuTri As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer, ByVal iD_CTChonglao As Integer, ByVal loaihinhYte As Long, ByVal duocChuyen As Integer, ByVal chandoan As Integer, ByVal dieuTri As Integer)
        Public MustOverride Sub DeleteNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer)
#End Region



#Region "NTP_BN_CTCHONGLAOP3 Methods"
        Public MustOverride Function GetNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer) As IDataReader
        Public MustOverride Function ListCTCHONGLAOP3(ByVal Id_CTChongLao As Integer, ByVal iD_NguonNhanLuc As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_CTCHONGLAOP3(ByVal Id_CTChongLao As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal iD_NguonNhanLuc As Integer, ByVal nLHienco As Integer, ByVal nLDaotao As Integer, ByVal TongsoNLDaotao As Integer, ByVal Ghichu As String) As Integer
        Public MustOverride Sub UpdateNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer, ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal iD_NguonNhanLuc As Integer, ByVal nLHienco As Integer, ByVal nLDaotao As Integer, ByVal TongsoNLDaotao As Integer, ByVal Ghichu As String)
        Public MustOverride Sub DeleteNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer)
#End Region

#Region "NTP_BN_CTCHONGLAOIN Methods"
        Public MustOverride Function ListBCTHAMGIAYTETRONGCTCL(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer) As DataSet
        Public MustOverride Function ListBCTHAMGIAYTETRONGHDPHATHIEN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PHANLOAIBC As Integer) As DataSet
        Public MustOverride Function ListBCNHANLUCTHAMGIAPCL(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PHANLOAIBC As Integer) As DataSet

#End Region
    End Class
End Namespace