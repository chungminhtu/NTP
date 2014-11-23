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

Namespace YourCompany.Modules.NTP_KD_PLAYMAU

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


#Region "NTP_KD_PLAYMAU Methods"
        Public Overrides Function GetNTP_KD_PLAYMAU(ByVal iD_PLAYMAU As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_Select", iD_PLAYMAU), IDataReader)
        End Function

     
        Public Overrides Function ListNTP_KD_PLAYMAU() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_SelectList"), IDataReader)
        End Function
        Public Overrides Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal opt As Integer, ByVal Id_MATINH As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_SelectList", Id_BenhVien, ThangNam, DieuKien, opt, ID_MATINH), IDataReader)
        End Function
        Public Overrides Function AddNTP_KD_PLAYMAU(ByVal thangLM As Integer, ByVal Nam As Integer, ByVal mA_TINH As String, ByVal iD_BENHVIEN As String, ByVal kTVien As String, ByVal nhanxet As String, ByVal nGUOI_NM As Integer, ByVal NgayLM As DateTime, ByVal SoTBThuchien As Integer, ByVal SoTBCanKD As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_Insert", GetNull(thangLM), Nam, GetNull(mA_TINH), iD_BENHVIEN, GetNull(kTVien), GetNull(nhanxet), GetNull(nGUOI_NM), NgayLM, SoTBThuchien, SoTBCanKD), Integer)
        End Function

        Public Overrides Sub UpdateNTP_KD_PLAYMAU(ByVal iD_PLAYMAU As Integer, ByVal thangLM As Integer, ByVal Nam As Integer, ByVal mA_TINH As String, ByVal iD_BENHVIEN As String, ByVal kTVien As String, ByVal nhanxet As String, ByVal nGUOI_NM As Integer, ByVal NgayLM As DateTime, ByVal SoTBThuchien As Integer, ByVal SoTBCanKD As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_Update", iD_PLAYMAU, GetNull(thangLM), Nam, GetNull(mA_TINH), iD_BENHVIEN, GetNull(kTVien), GetNull(nhanxet), GetNull(nGUOI_NM), NgayLM, SoTBThuchien, SoTBCanKD)
        End Sub
        Public Overrides Sub UpdateNTP_KD_PLAYMAU_LAN1(ByVal iD_PLAYMAU As Integer, ByVal ngayKD1 As DateTime, ByVal kDVien1 As String, ByVal nhanxet1 As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_UpdateKQKDLan1", iD_PLAYMAU, GetNull(ngayKD1), GetNull(kDVien1), GetNull(nhanxet1))
        End Sub
        Public Overrides Sub UpdateNTP_KD_PLAYMAU_LAN2(ByVal iD_PLAYMAU As Integer, ByVal ngayKD2 As DateTime, ByVal kDVien2 As String, ByVal nhanxet2 As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_UpdateKQKDLan2", iD_PLAYMAU, GetNull(ngayKD2), GetNull(kDVien2), GetNull(nhanxet2))
        End Sub
        Public Overrides Sub DeleteNTP_KD_PLAYMAU(ByVal iD_PLAYMAU As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_Delete", iD_PLAYMAU)
        End Sub
      
        Public Overrides Function IN_PHIEULAYMAU(ByVal THANG As Integer, ByVal NAM As Integer, ByVal ID_BENHVIEN As String) As DataSet
            ' Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_KD_PLAYMAU_IN]", THANG, NAM, ID_BENHVIEN)
            ' Return ds
        End Function
        Public Overrides Function IN_PHIEULAYMAU_KQKDLAN2(ByVal THANG As Integer, ByVal NAM As Integer, ByVal ID_BENHVIEN As String) As DataSet
            ' Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_KD_PLAYMAU_KQKDLAN2_IN]", THANG, NAM, ID_BENHVIEN)
            ' Return ds
        End Function
      
#End Region

#Region "NTP_KD_PLAYMAU_C Methods"
        Public Overrides Function GetNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_C_Select", iD_PLAYMAU, iD_PLAYMAU_C), IDataReader)
        End Function

        Public Overrides Function ListNTP_KD_PLAYMAU_C(ByVal Id_PhieuLAYMAU As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_C_SelectList", Id_PhieuLAYMAU), IDataReader)
        End Function
        Public Overrides Function ListLan1NTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_KD_PLAYMAU_C_KDLan1_SelectList]", iD_PLAYMAU), IDataReader)
        End Function
        Public Overrides Function ListLan2NTP_KD_PLAYMAU_C(ByVal Id_PhieuLAYMAU As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PHIEUKIEMDINHLan2_Select", Id_PhieuLAYMAU), IDataReader)
        End Function
        Public Overrides Function AddNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal soTB As String, ByVal kiemdinhH As String, ByVal ghichu As String) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_C_InsertPhieuLM ", GetNull(iD_PLAYMAU), GetNull(iD_Phieuxetnghiem_C), GetNull(soTB), GetNull(kiemdinhH), GetNull(ghichu)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal soTB As String, ByVal kiemdinhH As String, ByVal ghichu As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_C_UpdatePhieuLM", iD_PLAYMAU_C, GetNull(iD_PLAYMAU), GetNull(iD_Phieuxetnghiem_C), GetNull(soTB), GetNull(kiemdinhH), GetNull(ghichu))
        End Sub
        Public Overrides Sub UpdateNTP_KD_PLAYMAU_C_KQLAN1(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal kiemdinhT1 As String, ByVal chatluong As Byte, ByVal taymau As Byte, ByVal dosach As Byte, ByVal doDay As Byte, ByVal kichco As Byte, ByVal domin As Byte, ByVal ghichu As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_C_UpdatePhieuKQKD1", iD_PLAYMAU_C, iD_PLAYMAU, GetNull(kiemdinhT1), GetNull(chatluong), GetNull(taymau), GetNull(dosach), GetNull(doDay), GetNull(kichco), GetNull(domin), GetNull(ghichu))
        End Sub
        Public Overrides Sub UpdateNTP_KD_PLAYMAU_C_KQLAN2(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal kiemdinhT2 As String, ByVal ghichu As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_C_UpdatePhieuKQKD2", iD_PLAYMAU_C, iD_PLAYMAU, GetNull(kiemdinhT2), GetNull(ghichu))
        End Sub
        Public Overrides Sub DeleteNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PLAYMAU_C_Delete", iD_PLAYMAU, iD_PLAYMAU_C)
        End Sub
        Public Overrides Sub DeleteNTP_KD_PLAYMAU_C_KQLAN1(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_KDLan1_C_Delete", iD_PLAYMAU, iD_PLAYMAU_C)
        End Sub
        Public Overrides Sub DeleteNTP_KD_PLAYMAU_C_KQLAN2(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_KDLan2_C_Delete", iD_PLAYMAU, iD_PLAYMAU_C)
        End Sub
#End Region



    End Class

End Namespace