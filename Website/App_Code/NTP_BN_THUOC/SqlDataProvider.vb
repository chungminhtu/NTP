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

Namespace YourCompany.Modules.NTP_BN_THUOC

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

#Region "NTP_BN_THUOC Methods"
        Public Overrides Function GetNTP_BN_THUOC(ByVal iD_Thuoc As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_THUOC_Select", iD_Thuoc), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_THUOC(ByVal Id_DieuTri As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_THUOC_SelectList", Id_DieuTri), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_THUOC(ByVal iD_Dieutri As Integer, ByVal ngayDT As DateTime, ByVal iD_PhacdoDT As Integer, ByVal phacDoKhac As String, ByVal giaidoanDT As Boolean, ByVal tungay As DateTime, ByVal rHZE As Byte, ByVal rHZ As Byte, ByVal rHE As Byte, ByVal rH As Byte, ByVal eH As Byte, ByVal e As Byte, ByVal h As Byte, ByVal z As Byte, ByVal s As Byte, ByVal tLaoKhac As String, ByVal cotrimoxazole As Byte, ByVal aRT As String, ByVal khac As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_THUOC_Insert", GetNull(iD_Dieutri), GetNull(ngayDT), GetNull(iD_PhacdoDT), GetNull(phacDoKhac), GetNull(giaidoanDT), GetNull(tungay), GetNull(rHZE), GetNull(rHZ), GetNull(rHE), GetNull(rH), GetNull(eH), GetNull(e), GetNull(h), GetNull(z), GetNull(s), GetNull(tLaoKhac), GetNull(cotrimoxazole), GetNull(aRT), GetNull(khac), nGUOI_NM), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_THUOC(ByVal iD_Thuoc As Integer, ByVal iD_Dieutri As Integer, ByVal ngayDT As DateTime, ByVal iD_PhacdoDT As Integer, ByVal phacDoKhac As String, ByVal giaidoanDT As Boolean, ByVal tungay As DateTime, ByVal rHZE As Byte, ByVal rHZ As Byte, ByVal rHE As Byte, ByVal rH As Byte, ByVal eH As Byte, ByVal e As Byte, ByVal h As Byte, ByVal z As Byte, ByVal s As Byte, ByVal tLaoKhac As String, ByVal cotrimoxazole As Byte, ByVal aRT As String, ByVal khac As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_THUOC_Update", iD_Thuoc, GetNull(iD_Dieutri), GetNull(ngayDT), GetNull(iD_PhacdoDT), GetNull(phacDoKhac), GetNull(giaidoanDT), GetNull(tungay), GetNull(rHZE), GetNull(rHZ), GetNull(rHE), GetNull(rH), GetNull(eH), GetNull(e), GetNull(h), GetNull(z), GetNull(s), GetNull(tLaoKhac), GetNull(cotrimoxazole), GetNull(aRT), GetNull(khac), nGUOI_NM)
        End Sub

        Public Overrides Sub DeleteNTP_BN_THUOC(ByVal iD_Thuoc As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_THUOC_Delete", iD_Thuoc)
        End Sub
#End Region


    End Class

End Namespace