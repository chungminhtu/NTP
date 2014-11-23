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

Namespace YourCompany.Modules.NTP_BN_CTCHONGLAO

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


#Region "NTP_BN_CTCHONGLAO Methods"
        Public Overrides Function GetNTP_BN_CTCHONGLAO(ByVal iD_CTChonglao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAO_Select", iD_CTChonglao), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_CTCHONGLAO() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAO_SelectList"), IDataReader)
        End Function

        Public Overrides Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAO_SelectList", Id_BenhVien, ThangNam, DieuKien), IDataReader)
        End Function
        Public Overrides Function AddNTP_BN_CTCHONGLAO(ByVal nam As Integer, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal mADV As String, ByVal aFBcongdong As Integer, ByVal aFBhotro As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal SoBNPhathien As Integer, ByVal SoBNDKDT As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAO_Insert", GetNull(nam), GetNull(mA_TINH), mA_HUYEN, GetNull(mADV), GetNull(aFBcongdong), GetNull(aFBhotro), GetNull(ngayBC), GetNull(nguoiBC), nGUOI_NM, GetNull(huyenXN), GetNull(tinhXN), GetNull(pTNhap), GetNull(SoBNPhathien), GetNull(SoBNDKDT)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_CTCHONGLAO(ByVal iD_CTChonglao As Integer, ByVal nam As Integer, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal mADV As String, ByVal aFBcongdong As Integer, ByVal aFBhotro As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal SoBNPhathien As Integer, ByVal SoBNDKDT As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAO_Update", iD_CTChonglao, GetNull(nam), GetNull(mA_TINH), mA_HUYEN, GetNull(mADV), GetNull(aFBcongdong), GetNull(aFBhotro), GetNull(ngayBC), GetNull(nguoiBC), nGUOI_NM, GetNull(huyenXN), GetNull(tinhXN), GetNull(pTNhap), GetNull(SoBNPhathien), GetNull(SoBNDKDT))
            'SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAO_Update", iD_CTChonglao, GetNull(nam), GetNull(mA_TINH), mA_HUYEN, GetNull(mADV), GetNull(aFBcongdong), GetNull(aFBhotro), GetNull(ngayBC), GetNull(nguoiBC), nGUOI_NM, GetNull(huyenXN), GetNull(tinhXN), GetNull(pTNhap))
        End Sub

        Public Overrides Sub DeleteNTP_BN_CTCHONGLAO(ByVal iD_CTChonglao As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAO_Delete", iD_CTChonglao)
        End Sub
#End Region


#Region "NTP_BN_CTCHONGLAOP1 Methods"
        Public Overrides Function GetNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP1_Select", iD_CTChonglaoP1), IDataReader)
        End Function

        Public Overrides Function ListCTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer, ByVal Phanloai As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP1_SelectByID", iD_CTChonglaoP1, Phanloai), IDataReader)
        End Function
        Public Overrides Function ListNTP_BN_CTCHONGLAOP1(ByVal Id_CTChongLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP1_SelectList", Id_CTChongLao), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal soCShienco As Integer, ByVal soCSTrienkhai As Integer, ByVal diemkinhTT As Integer, ByVal diemkinhKD As Integer, ByVal xNNC As Integer, ByVal xNKSD As Integer, ByVal tuvanHIV As Integer, ByVal cungcapART As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP1_Insert", GetNull(iD_CTChonglao), phanloai, GetNull(soCShienco), GetNull(soCSTrienkhai), GetNull(diemkinhTT), GetNull(diemkinhKD), GetNull(xNNC), GetNull(xNKSD), GetNull(tuvanHIV), GetNull(cungcapART)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer, ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal soCShienco As Integer, ByVal soCSTrienkhai As Integer, ByVal diemkinhTT As Integer, ByVal diemkinhKD As Integer, ByVal xNNC As Integer, ByVal xNKSD As Integer, ByVal tuvanHIV As Integer, ByVal cungcapART As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP1_Update", iD_CTChonglaoP1, GetNull(iD_CTChonglao), phanloai, GetNull(soCShienco), GetNull(soCSTrienkhai), GetNull(diemkinhTT), GetNull(diemkinhKD), GetNull(xNNC), GetNull(xNKSD), GetNull(tuvanHIV), GetNull(cungcapART))
        End Sub

        Public Overrides Sub DeleteNTP_BN_CTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP1_Delete", iD_CTChonglaoP1)
        End Sub
#End Region


#Region "NTP_BN_CTCHONGLAOP2 Methods"
        Public Overrides Function GetNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP2_Select", iD_CTChonglaoP2), IDataReader)
        End Function
        Public Overrides Function ListCTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer, ByVal loaihinhYte As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP2_SelectByID", iD_CTChonglaoP2, loaihinhYte), IDataReader)
        End Function
        Public Overrides Function ListNTP_BN_CTCHONGLAOP2(ByVal Id_CTChongLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP2_SelectList", Id_CTChongLao), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglao As Integer, ByVal loaihinhYte As Long, ByVal duocChuyen As Integer, ByVal chandoan As Integer, ByVal dieuTri As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP2_Insert", GetNull(iD_CTChonglao), GetNull(loaihinhYte), GetNull(duocChuyen), GetNull(chandoan), GetNull(dieuTri)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer, ByVal iD_CTChonglao As Integer, ByVal loaihinhYte As Long, ByVal duocChuyen As Integer, ByVal chandoan As Integer, ByVal dieuTri As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP2_Update", iD_CTChonglaoP2, GetNull(iD_CTChonglao), GetNull(loaihinhYte), GetNull(duocChuyen), GetNull(chandoan), GetNull(dieuTri))
        End Sub

        Public Overrides Sub DeleteNTP_BN_CTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP2_Delete", iD_CTChonglaoP2)
        End Sub
#End Region


#Region "NTP_BN_CTCHONGLAOP3 Methods"
        Public Overrides Function GetNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP3_Select", iD_CTChonglaoP3), IDataReader)
        End Function
        Public Overrides Function ListCTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer, ByVal iD_NguonNhanLuc As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP3_SelectByID", iD_CTChonglaoP3, iD_NguonNhanLuc), IDataReader)
        End Function
        Public Overrides Function ListNTP_BN_CTCHONGLAOP3(ByVal Id_CTChongLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP3_SelectList", Id_CTChongLao), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal iD_NguonNhanLuc As Integer, ByVal nLHienco As Integer, ByVal nLDaotao As Integer, ByVal TongsoNLDaotao As Integer, ByVal ghichu As String) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP3_Insert", GetNull(iD_CTChonglao), phanloai, GetNull(iD_NguonNhanLuc), GetNull(nLHienco), GetNull(nLDaotao), GetNull(TongsoNLDaotao), GetNull(ghichu)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer, ByVal iD_CTChonglao As Integer, ByVal phanloai As Boolean, ByVal iD_NguonNhanLuc As Integer, ByVal nLHienco As Integer, ByVal nLDaotao As Integer, ByVal TongsoNLDaotao As Integer, ByVal ghichu As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP3_Update", iD_CTChonglaoP3, GetNull(iD_CTChonglao), phanloai, GetNull(iD_NguonNhanLuc), GetNull(nLHienco), GetNull(nLDaotao), GetNull(TongsoNLDaotao), GetNull(ghichu))
        End Sub

        Public Overrides Sub DeleteNTP_BN_CTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_CTCHONGLAOP3_Delete", iD_CTChonglaoP3)
        End Sub
#End Region

#Region "NTP_BN_BCCTCHONGLAOIN Methods"
        Public Overrides Function ListBCTHAMGIAYTETRONGCTCL(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer) As DataSet
            'Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCTHAMGIAYTETRONGCTCL_IN", Tinh, Mien, Vung, Nam)
            'Return ds
        End Function
        Public Overrides Function ListBCNHANLUCTHAMGIAPCL(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PHANLOAIBC As Integer) As DataSet
            'Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCNHANLUCTHAMGIACTCL_IN", Tinh, Mien, Vung, Nam, PHANLOAIBC)
            ' Return ds
        End Function

        Public Overrides Function ListBCTHAMGIAYTETRONGHDPHATHIEN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PHANLOAIBC As Integer) As DataSet
            ' Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCTHAMGIAYTETRONGHDPHATHIEN_IN", Tinh, Mien, Vung, Nam, PHANLOAIBC)
            'Return ds
        End Function

#End Region
    End Class

End Namespace