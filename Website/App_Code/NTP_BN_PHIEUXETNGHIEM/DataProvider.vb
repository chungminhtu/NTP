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

Namespace YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region

#Region "NTP_BN_PHIEUXETNGHIEM Methods"
        Public MustOverride Function GetNTP_BN_PHIEUXETNGHIEM(ByVal iD_Phieuxetnghiem As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_PHIEUXETNGHIEM(ByVal Id_BenhNhan As String, ByVal DV_Xetnghiem As String) As IDataReader
        Public MustOverride Function AddNTP_BN_PHIEUXETNGHIEM(ByVal iD_Benhnhan As String, ByVal soXN As String, ByVal iD_Benhvien As String, ByVal iD_PhanloaiYte As Integer, ByVal lydoXN As Integer, ByVal soluong As Byte, ByVal hIV As Boolean, ByVal soDKDT As String, ByVal xNVien As String, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal DV_XETNGHIEM As String, ByVal SoThangDT As Integer, ByVal Ngayxn As DateTime, ByVal DVTiepnhan As String) As Int32
        Public MustOverride Sub UpdateNTP_BN_PHIEUXETNGHIEM(ByVal iD_Phieuxetnghiem As Integer, ByVal iD_Benhnhan As String, ByVal soXN As String, ByVal iD_Benhvien As String, ByVal iD_PhanloaiYte As Integer, ByVal lydoXN As Integer, ByVal soluong As Byte, ByVal hIV As Boolean, ByVal soDKDT As String, ByVal xNVien As String, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal DV_XETNGHIEM As String, ByVal SoThangDT As Integer, ByVal Ngayxn As DateTime, ByVal DVTiepnhan As String)
        Public MustOverride Sub DeleteNTP_BN_PHIEUXETNGHIEM(ByVal iD_Phieuxetnghiem As Integer)
        Public MustOverride Function NTP_BN_PHIEUXETNGHIEM_SelectByDVDieutri(ByVal iD_Phieuxetnghiem As Integer, ByVal ID_Benhvien As String) As IDataReader
        Public MustOverride Function NTP_BN_PHIEUXETNGHIEM_SelectByIDBENHNHAN(ByVal ID_BENHNHAN As String, ByVal DV_XETNGHIEM As String) As DataSet

#End Region
#Region "NTP_BN_PHIEUXETNGHIEM_C Methods"
        Public MustOverride Function GetNTP_BN_PHIEUXETNGHIEM_C(ByVal iD_Phieuxetnghiem_C As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_PHIEUXETNGHIEM_C() As IDataReader
        Public MustOverride Function ListByIDNTP_BN_PHIEUXETNGHIEM_C(ByVal Id_PhieuXetNghiemBN As Int32) As IDataReader
        Public MustOverride Function ListByIDBENHNHANNTP_BN_PHIEUXETNGHIEM_C(ByVal Id_BENHNHAN As String, ByVal GiaidoanDT As Byte) As IDataReader
        Public MustOverride Function ListByThangNTP_BN_PHIEUXETNGHIEM_C(ByVal thang As String, ByVal Id_BenhVien As String) As IDataReader
        Public MustOverride Function AddNTP_BN_PHIEUXETNGHIEM_C(ByVal iD_Phieuxetnghiem As Int32, ByVal ngayNhanMau As DateTime, ByVal trangthaiDom As String, ByVal maudom As Byte, ByVal ketqua As Byte, ByVal soXN As String) As Int32
        Public MustOverride Sub UpdateNTP_BN_PHIEUXETNGHIEM_C(ByVal iD_Phieuxetnghiem_C As Integer, ByVal iD_Phieuxetnghiem As Integer, ByVal ngayNhanMau As DateTime, ByVal trangthaiDom As String, ByVal maudom As Byte, ByVal ketqua As Byte, ByVal soXN As String)
        Public MustOverride Sub DeleteNTP_BN_PHIEUXETNGHIEM_C(ByVal iD_Phieuxetnghiem As Integer, ByVal iD_Phieuxetnghiem_C As Integer)
#End Region
#Region "NTP_BN_XETNGHIEM_GD Methods"
        Public MustOverride Function GetNTP_BN_XETNGHIEM_GD(ByVal iD_Xetnghiem_GD As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_XETNGHIEM_GD() As IDataReader
        Public MustOverride Function GetNTP_BN_XETNGHIEM_GDByThoigianDT(ByVal iD_Xetnghiem_GD As Integer, ByVal ThoigianDT As Integer) As IDataReader
        Public MustOverride Function ListByIDDIEUTRINTP_BN_XETNGHIEM_GD(ByVal Id_DieuTri As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_XETNGHIEM_GD(ByVal iD_Dieutri As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal thoiGianDT As Byte, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal canNang As Integer, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal Nuoicay As String) As Integer
        Public MustOverride Sub UpdateNTP_BN_XETNGHIEM_GD(ByVal iD_Xetnghiem_GD As Integer, ByVal iD_Dieutri As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal thoiGianDT As Byte, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal canNang As Integer, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal Nuoicay As String)
        Public MustOverride Sub DeleteNTP_BN_XETNGHIEM_GD(ByVal iD_Xetnghiem_GD As Integer)
 	Public MustOverride Function NTP_BN_XETNGHIEMBNTHATBAI(ByVal iD_BENHNHAN As String) As IDataReader
#End Region

    End Class

End Namespace