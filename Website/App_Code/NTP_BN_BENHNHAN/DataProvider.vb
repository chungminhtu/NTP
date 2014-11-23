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

Namespace YourCompany.Modules.NTP_BN_BENHNHAN

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_BENHNHAN", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region

#Region "NTP_BN_BENHNHAN Methods"
        Public MustOverride Function GetNTP_BN_BENHNHAN(ByVal iD_Benhnhan As String) As IDataReader
        Public MustOverride Function GetBENHNHAN_DIEUTRI(ByVal iD_Benhnhan As String) As IDataReader
        Public MustOverride Function ListNTP_BN_BENHNHAN() As IDataReader
        Public MustOverride Function ListByDVTiepNhan(ByVal DVTiepNhan As String) As IDataReader
        Public MustOverride Function ListFindNTP_BN_BENHNHAN(ByVal ID_Benhnhan As String, ByVal Hoten As String, ByVal soCMND As String, ByVal DUNGTEN As Boolean, ByVal MaTinh As String, ByVal MaHuyen As String) As IDataReader
        'Public MustOverride Function ListFindNTP_BN_BENHNHAN_XETNGHIEM(ByVal ID_Benhnhan As String, ByVal Hoten As String, ByVal soCMND As String, ByVal DUNGTEN As Boolean, ByVal MaTinh As String, ByVal MaHuyen As String) As IDataReader
        Public MustOverride Function ListByBenhNhanByDonviDieutri(ByVal RaVien As Integer, ByVal Diachi As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal Hoten As String, ByVal SoCM As String, ByVal DVDIEUTRI As String) As IDataReader
        Public MustOverride Function ListByBenhNhanDieuTri(ByVal RaVien As Integer, ByVal Diachi As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal Hoten As String, ByVal soCM As String, ByVal DVDIEUTRI As String) As IDataReader
        Public MustOverride Function AddNTP_BN_BENHNHAN(ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal nGUOI_NM As Integer, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal MaBNQL As String) As String
        Public MustOverride Sub AddNTP_BN_BENHNHAN_TN(ByVal iD_Benhnhan As String, ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal Ngaynhap As DateTime, ByVal nGUOI_NM As Integer, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean)
        Public MustOverride Sub UpdateNTP_BN_BENHNHAN(ByVal iD_Benhnhan As String, ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal MaBNQL As String)
        Public MustOverride Sub DeleteNTP_BN_BENHNHAN(ByVal iD_Benhnhan As String)
        Public MustOverride Function NTP_BN_DIEUTRI_Finds(ByVal Diachi As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal MaBN As String, ByVal Hoten As String, ByVal SoCMT As String, ByVal DVDieutri As String, ByVal MATINH As String, ByVal Phanloaibenh As Integer, ByVal LUACHON As Byte) As IDataReader
        Public MustOverride Function NTP_BN_XETNGHIEM_Finds(ByVal Diachi As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal MaBN As String, ByVal Hoten As String, ByVal SoCMT As String, ByVal DVDieutri As String, ByVal MATINH As String, ByVal Phanloaibenh As Integer) As IDataReader
        Public MustOverride Function In_DANHSACHBNDIEUTRI(ByVal Tinh As String, ByVal ID_BENHVIEN As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal XACNHANBN As Integer, ByVal Dieukien As String) As DataSet

#End Region

    End Class

End Namespace