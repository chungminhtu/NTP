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

Namespace YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region



#Region "NTP_BN_BC_THUNHANBNLAO Methods"
        Public MustOverride Function GetNTP_BN_BC_THUNHANBNLAO(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_BC_THUNHANBNLAO() As IDataReader
        Public MustOverride Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String) As IDataReader
        Public MustOverride Function AddNTP_BN_BC_THUNHANBNLAO(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_BC_THUNHANBNLAO(ByVal iD_BCThunhanBNLao As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer)
        Public MustOverride Sub DeleteNTP_BN_BC_THUNHANBNLAO(ByVal iD_BCThunhanBNLao As Integer)
#End Region




#Region "NTP_BN_BC_THUNHANBNLAOP Methods"
        Public MustOverride Function GetNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLaoP1 As Integer) As IDataReader
        Public MustOverride Function ListTHUNHANBNLAOP1(ByVal iD_BCThunhanBNLaoP1 As Integer, ByVal Phanloai As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal moi As Integer, ByVal taiphat As Integer, ByVal thatbai As Integer, ByVal taitri As Integer, ByVal aFBKhac As Integer, ByVal amNho As Integer, ByVal amTrung As Integer, ByVal amLon As Integer, ByVal ngoaiPhoiNho As Integer, ByVal ngoaiPhoiTrung As Integer, ByVal ngoaiPhoiLon As Integer, ByVal ngoaiphoiKhac As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal iD_BCThunhanBNLaoP1 As Integer, ByVal moi As Integer, ByVal taiphat As Integer, ByVal thatbai As Integer, ByVal taitri As Integer, ByVal aFBKhac As Integer, ByVal amNho As Integer, ByVal amTrung As Integer, ByVal amLon As Integer, ByVal ngoaiPhoiNho As Integer, ByVal ngoaiPhoiTrung As Integer, ByVal ngoaiPhoiLon As Integer, ByVal ngoaiphoiKhac As Integer)
        Public MustOverride Sub DeleteNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLaoP1 As Integer)
#End Region



#Region "NTP_BN_BC_THUNHANBNLAOP2 Methods"
        Public MustOverride Function GetNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
        Public MustOverride Function ListTHUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer, ByVal Phanloai As Integer) As IDataReader

        Public MustOverride Function ListNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLaoP2 As Integer, ByVal phanloai As Long, ByVal nam0 As Integer, ByVal nu0 As Integer, ByVal nam5 As Integer, ByVal nu5 As Integer, ByVal nam15 As Integer, ByVal nu15 As Integer, ByVal nam25 As Integer, ByVal nu25 As Integer, ByVal nam35 As Integer, ByVal nu35 As Integer, ByVal nam45 As Integer, ByVal nu45 As Integer, ByVal nam55 As Integer, ByVal nu55 As Integer, ByVal nam65 As Integer, ByVal nu65 As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal iD_BCThunhanBNLaoP2 As Integer, ByVal nam0 As Integer, ByVal nu0 As Integer, ByVal nam5 As Integer, ByVal nu5 As Integer, ByVal nam15 As Integer, ByVal nu15 As Integer, ByVal nam25 As Integer, ByVal nu25 As Integer, ByVal nam35 As Integer, ByVal nu35 As Integer, ByVal nam45 As Integer, ByVal nu45 As Integer, ByVal nam55 As Integer, ByVal nu55 As Integer, ByVal nam65 As Integer, ByVal nu65 As Integer)
        Public MustOverride Sub DeleteNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer)
#End Region


        Public MustOverride Function ListBaoCaoTuoiGioi(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer, ByVal PhanLoaiBC As Integer) As DataSet
        Public MustOverride Function ListBaoCaoNgoaiLaoPhoi(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer) As DataSet

        Public MustOverride Function ListBaoCaoThunhanBNLao_TUYENHUYEN(ByVal Quy As Integer, ByVal Nam As Integer, ByVal DonVi As String) As DataSet
        Public MustOverride Function ListBaoCaoNTP_BN_BCTHUNHANBNLAO_IN(ByVal PhanLoaibc As Integer, ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer) As DataSet
        Public MustOverride Function ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGHDPHATHIEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer) As DataSet
        Public MustOverride Function ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGCTCL_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PhanLoaiYTe As Integer) As DataSet
        Public MustOverride Function ListBaoCaoNTP_BN_BCKETQUADTCHUNGCACTHE_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer) As DataSet
        Public MustOverride Function ListBaoCaoNTP_BN_BCKETQUADT_TUYENHUYEN(ByVal Quy As Integer, ByVal Nam As Integer, ByVal DonVi As String) As DataSet
        
    End Class

End Namespace