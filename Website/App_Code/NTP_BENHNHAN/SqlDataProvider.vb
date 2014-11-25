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

Namespace YourCompany.Modules.NTP_BENHNHAN

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


#Region "NTP_BENHNHAN Methods"
        Public Overrides Function GetNTP_BENHNHAN(ByVal iD_Benhnhan As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_Select", iD_Benhnhan), IDataReader)
        End Function

        Public Overrides Function GetBENHNHAN_DIEUTRI(ByVal iD_Benhnhan As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_DANGDIEUTRI", iD_Benhnhan), IDataReader)
        End Function

        Public Overrides Function ListNTP_BENHNHAN() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_SelectList"), IDataReader)
        End Function
        Public Overrides Function ListFindNTP_BENHNHAN(ByVal ID_Benhnhan As String, ByVal Hoten As String, ByVal soCMND As String, ByVal DUNGTEN As Boolean, ByVal MaTinh As String, ByVal MaHuyen As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_Finds", ID_Benhnhan, Hoten, soCMND, DUNGTEN, MaTinh, MaHuyen), IDataReader)
        End Function
        Public Overrides Function ListByDVTiepNhan(ByVal DVTiepNhan As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUCHUYEN_SelectByDVTiepnhan", DVTiepNhan), IDataReader)
        End Function
        Public Overrides Function ListByBenhNhanByDonviDieutri(ByVal RaVien As Integer, ByVal diachi As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal Hoten As String, ByVal SoCM As String, ByVal DVDIEUTRI As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_BENHNHAN_BY_DONVIDIEUTRI]", RaVien, diachi, GetNull(ThangNam), DieuKien, GetNull(Hoten), GetNull(SoCM), DVDIEUTRI), IDataReader)
        End Function
        Public Overrides Function ListByBenhNhanDieuTri(ByVal RaVien As Integer, ByVal diachi As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal Hoten As String, ByVal SoCM As String, ByVal DVDIEUTRI As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_DSBenhNhan", RaVien, diachi, GetNull(ThangNam), DieuKien, GetNull(Hoten), GetNull(SoCM), DVDIEUTRI), IDataReader)
        End Function
        Public Overrides Function AddNTP_BENHNHAN(ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal nGUOI_NM As Integer, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal MaBNQL As String) As String
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_Insert", iD_DoiTuong, hoTen, GetNull(soCMND), GetNull(tuoi), GetNull(gioitinh), GetNull(mA_TINH), GetNull(mA_HUYEN), GetNull(diachi), GetNull(sodienthoai), GetNull(nGUOI_NM), GetNull(nguoi_SD), GetNull(huy), GetNull(huyenXN), tinhXN, GetNull(MaBNQL)), String)
        End Function

        Public Overrides Sub AddNTP_BENHNHAN_TN(ByVal iD_Benhnhan As String, ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal Ngaynhap As DateTime, ByVal nGUOI_NM As Integer, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean)
            SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_Insert_TN", iD_Benhnhan, iD_DoiTuong, hoTen, GetNull(soCMND), GetNull(tuoi), GetNull(gioitinh), GetNull(mA_TINH), GetNull(mA_HUYEN), GetNull(diachi), GetNull(sodienthoai), Ngaynhap, GetNull(nGUOI_NM), GetNull(nguoi_SD), GetNull(huy), GetNull(huyenXN), tinhXN)
        End Sub
        Public Overrides Sub UpdateNTP_BENHNHAN(ByVal iD_Benhnhan As String, ByVal iD_DoiTuong As Integer, ByVal hoTen As String, ByVal soCMND As String, ByVal tuoi As Integer, ByVal gioitinh As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal diachi As String, ByVal sodienthoai As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal ngay_SD As DateTime, ByVal nguoi_SD As String, ByVal huy As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal MaBNQL As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_Update", iD_Benhnhan, iD_DoiTuong, hoTen, GetNull(soCMND), GetNull(tuoi), GetNull(gioitinh), GetNull(mA_TINH), GetNull(mA_HUYEN), GetNull(diachi), GetNull(sodienthoai), GetNull(nGUOI_NM), GetNull(nguoi_SD), GetNull(huy), GetNull(huyenXN), tinhXN, GetNull(MaBNQL))
        End Sub

        Public Overrides Sub DeleteNTP_BENHNHAN(ByVal iD_Benhnhan As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BENHNHAN_Delete", iD_Benhnhan)
        End Sub

        Public Overrides Function NTP_SOKHAMBENH_Finds(ByVal Diachi As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal MaBN As String, ByVal Hoten As String, ByVal SoCMT As String, ByVal DVDieutri As String, ByVal MATINH As String, ByVal Phanloaibenh As Integer, ByVal LUACHON As Byte) As IDataReader

            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_Finds", Diachi, Tungay, Denngay, MaBN, Hoten, SoCMT, DVDieutri, MATINH, Phanloaibenh, LUACHON), IDataReader)
        End Function
        Public Overrides Function NTP_BN_XETNGHIEM_Finds(ByVal Diachi As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal MaBN As String, ByVal Hoten As String, ByVal SoCMT As String, ByVal DVDieutri As String, ByVal MATINH As String, ByVal Phanloaibenh As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_Finds", Diachi, Tungay, Denngay, MaBN, Hoten, SoCMT, DVDieutri, MATINH, Phanloaibenh), IDataReader)

            'System.Data.SqlClient.SqlCommand cmd = SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier + "NTP_BN_XETNGHIEM_Finds");

            ' cmd.CommandType = System.Data.CommandType.StoredProcedure;
            '   cmd.Parameters.AddWithValue("Diachi", Diachi);
            '   cmd.Parameters.AddWithValue("Tungay", Tungay);
            '   cmd.Parameters.AddWithValue("Denngay", Denngay);
            '   cmd.Parameters.AddWithValue("MaBN", MaBN);           
            '   cmd.Parameters.AddWithValue("Hoten",Hoten);
            '   cmd.Parameters.AddWithValue("SoCMT",SoCMT);
            '   cmd.Parameters.AddWithValue("DVDieutri", DVDieutri);           
            '   cmd.Parameters.AddWithValue("MATINH",MATINH);
            '  cmd.Parameters.AddWithValue("PhanbenhBN",PhanbenhBN);
            '   cmd.CommandTimeout = 18000;
            '   IDataReader dr;
            '   dr = (IDataReader)cmd.ExecuteReader();
            '   cmd.Dispose();
            '   cmd = null;
            '   return dr;        

        End Function
        Public Overrides Function In_DANHSACHBNDIEUTRI(ByVal Tinh As String, ByVal ID_BENHVIEN As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal XACNHANBN As Integer, ByVal Dieukien As String) As DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_SOKHAMBENH_DANHSACHBNDIEUTRI", Tinh, ID_BENHVIEN, Tungay, Denngay, XACNHANBN, Dieukien)

        End Function


#End Region

    End Class

End Namespace