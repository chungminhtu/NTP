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

Namespace YourCompany.Modules.NTP_KD_BC_HOATDONGXN

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


#Region "NTP_KD_BC_HOATDONGXN Methods"
        Public Overrides Function GetNTP_KD_BC_HOATDONGXN(ByVal iD_HOATDONGXN As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXN_Select", iD_HOATDONGXN), IDataReader)
        End Function

        Public Overrides Function ListNTP_KD_BC_HOATDONGXN() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXN_SelectList"), IDataReader)
        End Function
        Public Overrides Function GET_ID_BAOCAO(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXN_GETIDBC", quy, nam, dVBaocao), IDataReader)
        End Function
        Public Overrides Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal MA_TINH As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXN_SelectList", ThangNam, Id_BenhVien, DieuKien, MA_TINH), IDataReader)
        End Function
        Public Overrides Function AddNTP_KD_BC_HOATDONGXN(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_BENHVIEN As String, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal soTBPhathienD As Integer, ByVal soTBPhathienA As Integer, ByVal soTBTheodoiD As Integer, ByVal soTBTheodoiA As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal pTNhap As Boolean) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXN_Insert", GetNull(quy), GetNull(nam), GetNull(iD_BENHVIEN), GetNull(huyenXN), GetNull(tinhXN), GetNull(soTBPhathienD), GetNull(soTBPhathienA), GetNull(soTBTheodoiD), GetNull(soTBTheodoiA), GetNull(ngayBC), GetNull(nguoiBC), GetNull(pTNhap)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_KD_BC_HOATDONGXN(ByVal iD_HOATDONGXN As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal iD_BENHVIEN As String, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal soTBPhathienD As Integer, ByVal soTBPhathienA As Integer, ByVal soTBTheodoiD As Integer, ByVal soTBTheodoiA As Integer, ByVal ngayBC As DateTime, ByVal nguoiBC As String, ByVal pTNhap As Boolean)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXN_Update", iD_HOATDONGXN, GetNull(quy), GetNull(nam), GetNull(iD_BENHVIEN), GetNull(huyenXN), GetNull(tinhXN), GetNull(soTBPhathienD), GetNull(soTBPhathienA), GetNull(soTBTheodoiD), GetNull(soTBTheodoiA), GetNull(ngayBC), GetNull(nguoiBC), GetNull(pTNhap))
        End Sub

        Public Overrides Sub DeleteNTP_KD_BC_HOATDONGXN(ByVal iD_HOATDONGXN As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXN_Delete", iD_HOATDONGXN)
        End Sub
        Public Overrides Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            '  Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BCHOATDONGXETNGHIEM_IN", Tinh, Mien, Vung, Nam, Quy, LoaiBC, Dieukien)

            ' Return ds
        End Function

        Public Overrides Function NTP_KD_BCHOATDONGXETNGHIEMBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            'Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BCHOATDONGXETNGHIEMBYHUYEN_IN", Tinh, Mien, Vung, Nam, Quy, LoaiBC, Dieukien)

            ' Return ds
        End Function
#End Region

#Region "NTP_KD_BC_HOATDONGXNC Methods"
        Public Overrides Function GetNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXNC As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXNC_Select", iD_HOATDONGXNC), IDataReader)
        End Function
        Public Overrides Function ListHOATDONGXNC(ByVal iD_HOATDONGXNC As Integer, ByVal pHANLOAI As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXNC_SelectByID", iD_HOATDONGXNC, pHANLOAI), IDataReader)
        End Function
        Public Overrides Function ListNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXN As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXNC_SelectList", iD_HOATDONGXN), IDataReader)
        End Function

        Public Overrides Function AddNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXN As Integer, ByVal pHANLOAI As Byte, ByVal duongAFB1Mau As Integer, ByVal duongAFB2Mau As Integer, ByVal duongAFB3Mau As Integer, ByVal amAFB1Mau As Integer, ByVal amAFB2Mau As Integer, ByVal amAFB3Mau As Integer, ByVal soBNDangky As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXNC_Insert", iD_HOATDONGXN, pHANLOAI, GetNull(duongAFB1Mau), GetNull(duongAFB2Mau), GetNull(duongAFB3Mau), GetNull(amAFB1Mau), GetNull(amAFB2Mau), GetNull(amAFB3Mau), GetNull(soBNDangky)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXNC As Integer, ByVal iD_HOATDONGXN As Integer, ByVal pHANLOAI As Byte, ByVal duongAFB1Mau As Integer, ByVal duongAFB2Mau As Integer, ByVal duongAFB3Mau As Integer, ByVal amAFB1Mau As Integer, ByVal amAFB2Mau As Integer, ByVal amAFB3Mau As Integer, ByVal soBNDangky As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXNC_Update", iD_HOATDONGXNC, iD_HOATDONGXN, pHANLOAI, GetNull(duongAFB1Mau), GetNull(duongAFB2Mau), GetNull(duongAFB3Mau), GetNull(amAFB1Mau), GetNull(amAFB2Mau), GetNull(amAFB3Mau), GetNull(soBNDangky))
        End Sub

        Public Overrides Sub DeleteNTP_KD_BC_HOATDONGXNC(ByVal iD_HOATDONGXNC As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_HOATDONGXNC_Delete", iD_HOATDONGXNC)
        End Sub
       
#End Region






    End Class

End Namespace