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
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.Common.Utilities

Namespace YourCompany.Modules.NTP_SOKHAMBENH

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' SQL Server implementation of the abstract DataProvider class
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class SqlDataProvider

        Inherits DataProvider

#Region "Private Members"

        Private Const ProviderType As String = "data"
        Private Const ModuleQualifier As String = "YourCompany_"

        Private _providerConfiguration As Framework.Providers.ProviderConfiguration = Framework.Providers.ProviderConfiguration.GetProviderConfiguration(ProviderType)
        Private _connectionString As String
        Private _providerPath As String
        Private _objectQualifier As String
        Private _databaseOwner As String

#End Region

#Region "Constructors"

        Public Sub New()

            ' Read the configuration specific information for this provider
            Dim objProvider As Framework.Providers.Provider = CType(_providerConfiguration.Providers(_providerConfiguration.DefaultProvider), Framework.Providers.Provider)

            ' Read the attributes for this provider
            'Get Connection string from web.config
            _connectionString = Config.GetConnectionString()

            If _connectionString = "" Then
                ' Use connection string specified in provider
                _connectionString = objProvider.Attributes("connectionString")
            End If

            _providerPath = objProvider.Attributes("providerPath")

            _objectQualifier = objProvider.Attributes("objectQualifier")
            If _objectQualifier <> "" And _objectQualifier.EndsWith("_") = False Then
                _objectQualifier += "_"
            End If

            _databaseOwner = objProvider.Attributes("databaseOwner")
            If _databaseOwner <> "" And _databaseOwner.EndsWith(".") = False Then
                _databaseOwner += "."
            End If

        End Sub

#End Region

#Region "Properties"

        Public ReadOnly Property ConnectionString() As String
            Get
                Return _connectionString
            End Get
        End Property

        Public ReadOnly Property ProviderPath() As String
            Get
                Return _providerPath
            End Get
        End Property

        Public ReadOnly Property ObjectQualifier() As String
            Get
                Return _objectQualifier
            End Get
        End Property

        Public ReadOnly Property DatabaseOwner() As String
            Get
                Return _databaseOwner
            End Get
        End Property

#End Region

#Region "Private Methods"

        Private Function GetFullyQualifiedName(ByVal name As String) As String
            Return DatabaseOwner & ObjectQualifier & ModuleQualifier & name
        End Function

        Private Function GetNull(ByVal Field As Object) As Object
            Return DotNetNuke.Common.Utilities.Null.GetNull(Field, DBNull.Value)
        End Function

#End Region


#Region "NTP_SOKHAMBENH Methods"
        Public Overrides Function GetNTP_SOKHAMBENH(ByVal iD_Dieutri As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_Select", iD_Dieutri), IDataReader)
        End Function
        Public Overrides Function NTP_SOKHAMBENH_SelectByDVDieutri(ByVal iD_Dieutri As Integer, ByVal ID_Benhvien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_SelectByDVDieutri", iD_Dieutri, ID_Benhvien), IDataReader)
        End Function
        Public Overrides Function ListNTP_SOKHAMBENH() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_SelectList"), IDataReader)
        End Function
        Public Overrides Function ListByID_BenhNhanNTP_SOKHAMBENH(ByVal Id_BenhNhan As String, ByVal ID_Benhvien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_SelectByIDBENHNHAN", Id_BenhNhan, ID_Benhvien), IDataReader)
        End Function
        Public Overrides Function AddNTP_SOKHAMBENH(ByVal iD_BENHNHAN As String, ByVal soDKDT As String, ByVal dVDieutri As String, ByVal ngayVV As DateTime, ByVal ngayDT As DateTime, ByVal iD_PHANLOAIYTE As Integer, ByVal dVGioiThieu As String, ByVal iD_PhanLoaiBenh As Integer, ByVal iD_PhanLoaiBN As Integer, ByVal ngayChupXQ As DateTime, ByVal ketquaXQ As Byte, ByVal xNHIV1 As Byte, ByVal xNHIV2 As Byte, ByVal aRT As Byte, ByVal cPT As Byte, ByVal lymPho As String, ByVal giamSatDT As String, ByVal iD_KetquaDT As Integer, ByVal ngayRV As DateTime, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal Id_PhieuChuyen As Integer, ByVal ID_PhacdoDT As Integer, ByVal PhacdoKhac As String, ByVal Chandoan As String, ByVal ID_PhacdoTD As Integer, ByVal PhacdoTDKhac As String, ByVal MaBNQL As String, ByVal tuoi As Integer) As Integer

            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_Insert", GetNull(iD_BENHNHAN), GetNull(soDKDT), GetNull(dVDieutri), GetNull(ngayVV), GetNull(ngayDT), GetNull(iD_PHANLOAIYTE), GetNull(dVGioiThieu), GetNull(iD_PhanLoaiBenh), GetNull(iD_PhanLoaiBN), GetNull(ngayChupXQ), GetNull(ketquaXQ), GetNull(xNHIV1), GetNull(xNHIV2), GetNull(aRT), GetNull(cPT), GetNull(lymPho), GetNull(giamSatDT), GetNull(iD_KetquaDT), GetNull(ngayRV), GetNull(ghichu), GetNull(nGAY_NM), GetNull(nGUOI_NM), GetNull(ngay_SD), GetNull(nguoi_SD), GetNull(huyenXN), GetNull(tinhXN), GetNull(Id_PhieuChuyen), GetNull(ID_PhacdoDT), GetNull(PhacdoKhac), GetNull(Chandoan), GetNull(ID_PhacdoTD), GetNull(PhacdoTDKhac), GetNull(MaBNQL), GetNull(tuoi)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_SOKHAMBENH(ByVal iD_Dieutri As Integer, ByVal iD_BENHNHAN As String, ByVal soDKDT As String, ByVal dVDieutri As String, ByVal ngayVV As DateTime, ByVal ngayDT As DateTime, ByVal iD_PHANLOAIYTE As Integer, ByVal dVGioiThieu As String, ByVal iD_PhanLoaiBenh As Integer, ByVal iD_PhanLoaiBN As Integer, ByVal ngayChupXQ As DateTime, ByVal ketquaXQ As Byte, ByVal xNHIV1 As Byte, ByVal xNHIV2 As Byte, ByVal aRT As Byte, ByVal cPT As Byte, ByVal lymPho As String, ByVal giamSatDT As String, ByVal iD_KetquaDT As Integer, ByVal ngayRV As DateTime, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal Id_PhieuChuyen As Integer, ByVal ID_PhacdoDT As Integer, ByVal PhacdoKhac As String, ByVal Chandoan As String, ByVal ID_PhacdoTD As Integer, ByVal PhacdoTDKhac As String, ByVal MaBNQL As String, ByVal tuoi As Integer)
            ' DataProvider.Instance().UpdateNTP_SOKHAMBENH(objNTP_SOKHAMBENH.ID_Dieutri, objNTP_SOKHAMBENH.ID_BENHNHAN, objNTP_SOKHAMBENH.SoDKDT, objNTP_SOKHAMBENH.DVDieutri, objNTP_SOKHAMBENH.NgayVV, objNTP_SOKHAMBENH.NgayDT, objNTP_SOKHAMBENH.ID_PHANLOAIYTE, objNTP_SOKHAMBENH.DVGioiThieu, objNTP_SOKHAMBENH.ID_PhanLoaiBenh, objNTP_SOKHAMBENH.ID_PhanLoaiBN, objNTP_SOKHAMBENH.NgayChupXQ, objNTP_SOKHAMBENH.KetquaXQ, objNTP_SOKHAMBENH.XNHIV1, objNTP_SOKHAMBENH.XNHIV2, objNTP_SOKHAMBENH.ART, objNTP_SOKHAMBENH.CPT, objNTP_SOKHAMBENH.LymPho, objNTP_SOKHAMBENH.GiamSatDT, objNTP_SOKHAMBENH.ID_KetquaDT, objNTP_SOKHAMBENH.NgayRV, objNTP_SOKHAMBENH.Ghichu, objNTP_SOKHAMBENH.NGAY_NM, objNTP_SOKHAMBENH.NGUOI_NM, objNTP_SOKHAMBENH.Ngay_SD, objNTP_SOKHAMBENH.Nguoi_SD, objNTP_SOKHAMBENH.HuyenXN, objNTP_SOKHAMBENH.TinhXN, objNTP_SOKHAMBENH.ID_PhieuChuyen, objNTP_SOKHAMBENH.ID_PhacdoDT, objNTP_SOKHAMBENH.PhacdoKhac)

            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_Update", iD_Dieutri, GetNull(iD_BENHNHAN), GetNull(soDKDT), GetNull(dVDieutri), GetNull(ngayVV), GetNull(ngayDT), GetNull(iD_PHANLOAIYTE), GetNull(dVGioiThieu), GetNull(iD_PhanLoaiBenh), GetNull(iD_PhanLoaiBN), GetNull(ngayChupXQ), GetNull(ketquaXQ), GetNull(xNHIV1), GetNull(xNHIV2), GetNull(aRT), GetNull(cPT), GetNull(lymPho), GetNull(giamSatDT), GetNull(iD_KetquaDT), GetNull(ngayRV), GetNull(ghichu), GetNull(nGAY_NM), GetNull(nGUOI_NM), GetNull(ngay_SD), GetNull(nguoi_SD), GetNull(huyenXN), GetNull(tinhXN), GetNull(Id_PhieuChuyen), GetNull(ID_PhacdoDT), GetNull(PhacdoKhac), GetNull(Chandoan), GetNull(ID_PhacdoTD), GetNull(PhacdoTDKhac), GetNull(MaBNQL), GetNull(tuoi))
        End Sub

        Public Overrides Sub DeleteNTP_SOKHAMBENH(ByVal iD_Dieutri As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_Delete", iD_Dieutri)
        End Sub
#End Region


#Region "NTP_BN_KETQUAXN Methods"

        Public Overrides Function ListByID_BenhNhanNTP_BN_KETQUAXN(ByVal Id_BenhNhan As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_SelectByIDBENHNHAN", Id_BenhNhan), IDataReader)
        End Function
        Public Overrides Function AddNTP_BN_KETQUAXN(ByVal ID_Dieutri As String, ByVal ID_Phieuxetnghiem_C As Integer, ByVal ThoiGianDT As Integer, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal CanNang As Integer, ByVal NGAY_NM As DateTime, ByVal NGUOI_NM As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_Insert", GetNull(ID_Dieutri), GetNull(ID_Phieuxetnghiem_C), GetNull(ThoiGianDT), GetNull(NgayXN), GetNull(SoXN), GetNull(KetquaXN), GetNull(CanNang), GetNull(NGAY_NM), GetNull(NGUOI_NM)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_KETQUAXN(ByVal ID_Xetnghiem_GD As Integer, ByVal ID_Dieutri As String, ByVal ID_Phieuxetnghiem_C As Integer, ByVal ThoiGianDT As Integer, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal CanNang As Integer, ByVal NGAY_NM As DateTime, ByVal NGUOI_NM As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_Update", ID_Xetnghiem_GD, GetNull(ID_Dieutri), GetNull(ID_Phieuxetnghiem_C), GetNull(ThoiGianDT), GetNull(NgayXN), GetNull(SoXN), GetNull(KetquaXN), GetNull(CanNang), GetNull(NGAY_NM), GetNull(NGUOI_NM))
        End Sub


#End Region

#Region "NTP_BN_KETQUADT Methods"

        Public Overrides Function GetNTP_BN_KETQUADT(ByVal ID_Dieutri As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_Select", ID_Dieutri), IDataReader)

        End Function


        Public Overrides Function ListNTP_BN_DMBENHVIENCHUYEN(ByVal ID_Benhvien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_BN_DMBENHVIEN_SelectListNotByBV]", ID_Benhvien), IDataReader)

        End Function
        Public Overrides Function ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(ByVal ID_Benhvien As String, ByVal MATINH As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_DM_BENHVIEN_ListDVChuyen_HTC]", ID_Benhvien, MATINH), IDataReader)

        End Function
        Public Overrides Sub UpdateNTP_BN_KETQUADT(ByVal ID_Dieutri As Integer, ByVal ID_KetquaDT As Integer, ByVal NgayRV As DateTime, ByVal Ghichu As String)
            '  SqlHelper.ExecuteNonQuery(ConnectionString, GetFullyQualifiedName("UpdateNTP_BN_KETQUADT"), ID_Dieutri, ID_KetquaDT, NgayRV, GetNull(Ghichu))
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_SOKHAMBENH_UpdateKETQUADT]", ID_Dieutri, ID_KetquaDT, NgayRV, GetNull(Ghichu))
        End Sub


#End Region
    End Class

End Namespace