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

Namespace YourCompany.Modules.NTP_DM_BENHVIEN

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

#Region "NTP_DM_BENHVIEN Methods"
        Public Overrides Function GetNTP_DM_BENHVIEN(ByVal iD_BENHVIEN As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_HTC_DM_BENHVIEN_Select", iD_BENHVIEN), IDataReader)
        End Function

        Public Overrides Function ListNTP_DM_BENHVIEN() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_HTC_DM_BENHVIEN_SelectList"), IDataReader)
        End Function

        Public Overrides Function GetNTP_DM_BENHVIENByNTP_DM_VUNG(ByVal iD_VUNG As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_BENHVIEN_SelectByNTP_DM_VUNG", iD_VUNG), IDataReader)
        End Function
        Public Overrides Function GetNTP_DM_BENHVIENByBenhVien(ByVal Id_BenhVien As String, ByVal Id_tinh As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_BENHVIEN_SelectListByBV", Id_BenhVien, Id_tinh), IDataReader)
        End Function


        Public Overrides Function AddNTP_DM_BENHVIEN(ByVal tEN_BENHVIEN As String, ByVal iD_Phanloaiyte As String, ByVal iD_MATINH As String, ByVal iD_HUYEN As String, ByVal cAPQUANLY As Byte, ByVal iD_VUNG As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_BENHVIEN_Insert", GetNull(tEN_BENHVIEN), GetNull(iD_Phanloaiyte), GetNull(iD_MATINH), GetNull(iD_HUYEN), GetNull(cAPQUANLY), iD_VUNG), Integer)
        End Function

        Public Overrides Sub UpdateNTP_DM_BENHVIEN(ByVal iD_BENHVIEN As String, ByVal tEN_BENHVIEN As String, ByVal iD_Phanloaiyte As String, ByVal iD_MATINH As String, ByVal iD_HUYEN As String, ByVal cAPQUANLY As Byte, ByVal iD_VUNG As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_BENHVIEN_Update", iD_BENHVIEN, GetNull(tEN_BENHVIEN), GetNull(iD_Phanloaiyte), GetNull(iD_MATINH), GetNull(iD_HUYEN), GetNull(cAPQUANLY), iD_VUNG)
        End Sub

        Public Overrides Sub DeleteNTP_DM_BENHVIEN(ByVal iD_BENHVIEN As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_BENHVIEN_Delete", iD_BENHVIEN)
        End Sub
#End Region


    End Class

End Namespace