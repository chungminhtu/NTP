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

Namespace YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO

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


#Region "NTP_BN_BC_THUNHANBNLAO Methods"
        Public Overrides Function GetNTP_BN_BC_THUNHANBNLAO(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAO_Select", iD_BCThunhanBNLao), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_BC_THUNHANBNLAO() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAO_SelectList"), IDataReader)
        End Function
        Public Overrides Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_ThunhanBNLao_SelectList", ThangNam, Id_BenhVien, DieuKien), IDataReader)
        End Function
        Public Overrides Function AddNTP_BN_BC_THUNHANBNLAO(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAO_Insert", quy, nam, dVBaocao, GetNull(nguoiBC), GetNull(ngayBC), GetNull(huyenXN), GetNull(tinhXN), GetNull(pTNhap), GetNull(mA_TINH), GetNull(mA_HUYEN), GetNull(nGUOI_NM)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_BC_THUNHANBNLAO(ByVal iD_BCThunhanBNLao As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAO_Update", iD_BCThunhanBNLao, quy, nam, dVBaocao, GetNull(nguoiBC), GetNull(ngayBC), GetNull(huyenXN), GetNull(tinhXN), GetNull(pTNhap), GetNull(mA_TINH), GetNull(mA_HUYEN), GetNull(nGUOI_NM))
        End Sub

        Public Overrides Sub DeleteNTP_BN_BC_THUNHANBNLAO(ByVal iD_BCThunhanBNLao As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAO_Delete", iD_BCThunhanBNLao)
        End Sub
#End Region


#Region "NTP_BN_BC_THUNHANBNLAOP1 Methods"
        Public Overrides Function GetNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_ThunhanBNLaoP1_Select", iD_BCThunhanBNLao), IDataReader)
        End Function
        Public Overrides Function ListTHUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer, ByVal Phanloai As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_ThunhanBNLaoP1_SelectByID", iD_BCThunhanBNLao, Phanloai), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP1_SelectList", iD_BCThunhanBNLao), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal moi As Integer, ByVal taiphat As Integer, ByVal thatbai As Integer, ByVal taitri As Integer, ByVal aFBKhac As Integer, ByVal amNho As Integer, ByVal amTrung As Integer, ByVal amLon As Integer, ByVal ngoaiPhoiNho As Integer, ByVal ngoaiPhoiTrung As Integer, ByVal ngoaiPhoiLon As Integer, ByVal ngoaiphoiKhac As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP1_Insert", iD_BCThunhanBNLao, phanloai, GetNull(moi), GetNull(taiphat), GetNull(thatbai), GetNull(taitri), GetNull(aFBKhac), GetNull(amNho), GetNull(amTrung), GetNull(amLon), GetNull(ngoaiPhoiNho), GetNull(ngoaiPhoiTrung), GetNull(ngoaiPhoiLon), GetNull(ngoaiphoiKhac)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal iD_BCThunhanBNLaoP1 As Integer, ByVal moi As Integer, ByVal taiphat As Integer, ByVal thatbai As Integer, ByVal taitri As Integer, ByVal aFBKhac As Integer, ByVal amNho As Integer, ByVal amTrung As Integer, ByVal amLon As Integer, ByVal ngoaiPhoiNho As Integer, ByVal ngoaiPhoiTrung As Integer, ByVal ngoaiPhoiLon As Integer, ByVal ngoaiphoiKhac As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP1_Update", iD_BCThunhanBNLaoP1, iD_BCThunhanBNLao, phanloai, GetNull(moi), GetNull(taiphat), GetNull(thatbai), GetNull(taitri), GetNull(aFBKhac), GetNull(amNho), GetNull(amTrung), GetNull(amLon), GetNull(ngoaiPhoiNho), GetNull(ngoaiPhoiTrung), GetNull(ngoaiPhoiLon), GetNull(ngoaiphoiKhac))
        End Sub

        Public Overrides Sub DeleteNTP_BN_BC_THUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP1_Delete", iD_BCThunhanBNLao)
        End Sub
#End Region


#Region "NTP_BN_BC_THUNHANBNLAOP2 Methods"
        Public Overrides Function GetNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_ThunhanBNLaoP2_Select", iD_BCThunhanBNLao), IDataReader)
        End Function
        Public Overrides Function ListTHUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer, ByVal Phanloai As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_ThunhanBNLaoP2_SelectByID", iD_BCThunhanBNLao, Phanloai), IDataReader)
        End Function
        Public Overrides Function ListNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP2_SelectList", iD_BCThunhanBNLao), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLaoP2 As Integer, ByVal phanloai As Long, ByVal nam0 As Integer, ByVal nu0 As Integer, ByVal nam5 As Integer, ByVal nu5 As Integer, ByVal nam15 As Integer, ByVal nu15 As Integer, ByVal nam25 As Integer, ByVal nu25 As Integer, ByVal nam35 As Integer, ByVal nu35 As Integer, ByVal nam45 As Integer, ByVal nu45 As Integer, ByVal nam55 As Integer, ByVal nu55 As Integer, ByVal nam65 As Integer, ByVal nu65 As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP2_Insert", iD_BCThunhanBNLaoP2, phanloai, GetNull(nam0), GetNull(nu0), GetNull(nam5), GetNull(nu5), GetNull(nam15), GetNull(nu15), GetNull(nam25), GetNull(nu25), GetNull(nam35), GetNull(nu35), GetNull(nam45), GetNull(nu45), GetNull(nam55), GetNull(nu55), GetNull(nam65), GetNull(nu65)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer, ByVal phanloai As Long, ByVal iD_BCThunhanBNLaoP2 As Integer, ByVal nam0 As Integer, ByVal nu0 As Integer, ByVal nam5 As Integer, ByVal nu5 As Integer, ByVal nam15 As Integer, ByVal nu15 As Integer, ByVal nam25 As Integer, ByVal nu25 As Integer, ByVal nam35 As Integer, ByVal nu35 As Integer, ByVal nam45 As Integer, ByVal nu45 As Integer, ByVal nam55 As Integer, ByVal nu55 As Integer, ByVal nam65 As Integer, ByVal nu65 As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP2_Update", iD_BCThunhanBNLaoP2, iD_BCThunhanBNLao, phanloai, GetNull(nam0), GetNull(nu0), GetNull(nam5), GetNull(nu5), GetNull(nam15), GetNull(nu15), GetNull(nam25), GetNull(nu25), GetNull(nam35), GetNull(nu35), GetNull(nam45), GetNull(nu45), GetNull(nam55), GetNull(nu55), GetNull(nam65), GetNull(nu65))
        End Sub

        Public Overrides Sub DeleteNTP_BN_BC_THUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_THUNHANBNLAOP2_Delete", iD_BCThunhanBNLao)
        End Sub
#End Region





#Region "NTP_BN_BCTHUNHANBNLAOTHEOTUOIGIOIIN Methods"
        Public Overrides Function ListBaoCaoTuoiGioi(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer, ByVal PhanLoaiBC As Integer) As DataSet
            'DataSet ds = new DataSet();
            '          string[] s = { "DMHoachat_GIA_RPT" };
            '          SqlHelper.FillDataset(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHoachat_GIA_RPT", ds, s, _madt, qadmin);
            '          //ds.WriteXmlSchema("DMHoachat_GIA_RPT.xsd");
            '          return ds;
            '          Return SqlHelper.FillDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaDT_SelectList", Tinh, Mien, Vung, Nam)
            Dim ds As New DataSet

            Dim s As String = "NTP_BN_BCKETQUADIEUTRILAOIN1"
            'SqlHelper.FillDataset(ConnectionString, DatabaseOwner &  ObjectQualifier + "spDMHoachat_GIA_RPT", ds, s, Tinh, Mien,Vung, Nam);
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCTHUNHANBNLAOTHEOTUOIGIOI_IN", Tinh, Mien, Vung, Nam, Quy, PhanLoaiBC)
            'Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory

            'ds.WriteXmlSchema("NTP_BN_BCTHUNHANBNLAOTHEOTUOIGIOI_IN.xsd")
            Return ds
        End Function

        Public Overrides Function ListBaoCaoNgoaiLaoPhoi(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer) As DataSet

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCTHUNHANBNLAONGOAIPHOI_IN", Tinh, Mien, Vung, Nam, Quy)
            Return ds
        End Function

        Public Overrides Function ListBaoCaoThunhanBNLao_TUYENHUYEN(ByVal Quy As Integer, ByVal Nam As Integer, ByVal DonVi As String) As DataSet

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCThunhanBNLao_TUYENHUYEN", Quy, Nam, DonVi)
            Return ds
        End Function
        Public Overrides Function ListBaoCaoNTP_BN_BCTHUNHANBNLAO_IN(ByVal PhanLoaibc As Integer, ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer) As DataSet

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCTHUNHANBNLAO_IN", PhanLoaibc, Tinh, Mien, Vung, Nam, Quy)
            Return ds
        End Function
        Public Overrides Function ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGHDPHATHIEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer) As DataSet

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCTHAMGIAYTETRONGHDPHATHIEN_IN", Tinh, Mien, Vung, Nam)
            Return ds
        End Function
        Public Overrides Function ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGCTCL_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PhanLoaiYTe As Integer) As DataSet

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCTHAMGIAYTETRONGCTCL_IN", Tinh, Mien, Vung, Nam, PhanLoaiYTe)
            Return ds
        End Function
        Public Overrides Function ListBaoCaoNTP_BN_BCKETQUADTCHUNGCACTHE_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer) As DataSet

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCKETQUADTCHUNGCACTHE_IN", Tinh, Mien, Vung, Nam, Quy)
            Return ds
        End Function
        Public Overrides Function ListBaoCaoNTP_BN_BCKETQUADT_TUYENHUYEN(ByVal Quy As Integer, ByVal Nam As Integer, ByVal DonVi As String) As DataSet

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCKETQUADT_TUYENHUYEN", Quy, Nam, DonVi)
            Return ds
        End Function
        

#End Region
    End Class

End Namespace