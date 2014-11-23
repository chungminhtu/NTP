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

Namespace YourCompany.Modules.NTP_BN_DIEUTRI

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_DIEUTRI", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region



#Region "NTP_BN_DIEUTRI Methods"
        Public MustOverride Function GetNTP_BN_DIEUTRI(ByVal iD_Dieutri As Integer) As IDataReader
        Public MustOverride Function NTP_BN_DIEUTRI_SelectByDVDieutri(ByVal iD_Dieutri As Integer, ByVal ID_Benhvien As String) As IDataReader
        Public MustOverride Function ListNTP_BN_DIEUTRI() As IDataReader
        Public MustOverride Function ListByID_BenhNhanNTP_BN_DIEUTRI(ByVal ID_BenhNhan As String, ByVal ID_Benhvien As String) As IDataReader
        Public MustOverride Function AddNTP_BN_DIEUTRI(ByVal iD_BENHNHAN As String, ByVal soDKDT As String, ByVal dVDieutri As String, ByVal ngayVV As DateTime, ByVal ngayDT As DateTime, ByVal iD_PHANLOAIYTE As Integer, ByVal dVGioiThieu As String, ByVal iD_PhanLoaiBenh As Integer, ByVal iD_PhanLoaiBN As Integer, ByVal ngayChupXQ As DateTime, ByVal ketquaXQ As Byte, ByVal xNHIV1 As Byte, ByVal xNHIV2 As Byte, ByVal aRT As Byte, ByVal cPT As Byte, ByVal lymPho As String, ByVal giamSatDT As String, ByVal iD_KetquaDT As Integer, ByVal ngayRV As DateTime, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal Id_PhieuChuyen As Integer, ByVal ID_PhacdoDT As Integer, ByVal PhacdoKhac As String, ByVal Chandoan As String, ByVal ID_PhacdoTD As Integer, ByVal Ten_PhacdoTDKhac As String, ByVal MaBNQL As String, ByVal tuoi As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_DIEUTRI(ByVal iD_Dieutri As Integer, ByVal iD_BENHNHAN As String, ByVal soDKDT As String, ByVal dVDieutri As String, ByVal ngayVV As DateTime, ByVal ngayDT As DateTime, ByVal iD_PHANLOAIYTE As Integer, ByVal dVGioiThieu As String, ByVal iD_PhanLoaiBenh As Integer, ByVal iD_PhanLoaiBN As Integer, ByVal ngayChupXQ As DateTime, ByVal ketquaXQ As Byte, ByVal xNHIV1 As Byte, ByVal xNHIV2 As Byte, ByVal aRT As Byte, ByVal cPT As Byte, ByVal lymPho As String, ByVal giamSatDT As String, ByVal iD_KetquaDT As Integer, ByVal ngayRV As DateTime, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal Id_PhieuChuyen As Integer, ByVal ID_PhacdoDT As Integer, ByVal PhacdoKhac As String, ByVal Chandoan As String, ByVal ID_PhacdoTD As Integer, ByVal Ten_PhacdoTDKhac As String, ByVal MaBNQL As String, ByVal tuoi As Integer)
        Public MustOverride Sub DeleteNTP_BN_DIEUTRI(ByVal iD_Dieutri As Integer)
#End Region

#Region "NTP_BN_KETQUAXN Methods"
        Public MustOverride Function ListByID_BenhNhanNTP_BN_KETQUAXN(ByVal ID_BenhNhan As String) As IDataReader
        Public MustOverride Function AddNTP_BN_KETQUAXN(ByVal ID_Dieutri As String, ByVal ID_Phieuxetnghiem_C As Integer, ByVal ThoiGianDT As Integer, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal CanNang As Integer, ByVal NGAY_NM As DateTime, ByVal NGUOI_NM As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_KETQUAXN(ByVal ID_Xetnghiem_GD As Integer, ByVal ID_Dieutri As String, ByVal ID_Phieuxetnghiem_C As Integer, ByVal ThoiGianDT As Integer, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal CanNang As Integer, ByVal NGAY_NM As DateTime, ByVal NGUOI_NM As Integer)

#End Region
#Region "NTP_BN_KETQUADT methods"
        Public MustOverride Function ListNTP_BN_DMBENHVIENCHUYEN(ByVal ID_BENHVIEN As String) As IDataReader
        Public MustOverride Function ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(ByVal ID_BENHVIEN As String, ByVal MATINH As String) As IDataReader
        Public MustOverride Function GetNTP_BN_KETQUADT(ByVal ID_Dieutri As Integer) As IDataReader
        Public MustOverride Sub UpdateNTP_BN_KETQUADT(ByVal ID_Dieutri As Integer, ByVal ID_KetquaDT As Integer, ByVal NgayRV As DateTime, ByVal Ghichu As String)
#End Region
    End Class

End Namespace