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

Namespace YourCompany.Modules.NTP_BN_BC_KETQUAXN

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

#Region "Public Methods"

        Public Overrides Function GetNTP_BN_BC_KETQUAXN(ByVal ID_KETQUAXN As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaXN_Select", ID_KETQUAXN), IDataReader)

        End Function

        Public Overrides Function ListNTP_BN_BC_KETQUAXN(ByVal Nam As Integer, ByVal ID_BENHVIEN As String, ByVal Thamso As String, ByVal MA_TINH As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaXN_SelectList", Nam, ID_BENHVIEN, Thamso, MA_TINH), IDataReader)

        End Function
        Public Overrides Function LISTKETQUAXN_BYID(ByVal ID_KETQUAXN As Integer, ByVal dVBaocao As String, ByVal Quy As Integer, ByVal Nam As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaXN_SelectByID", ID_KETQUAXN, dVBaocao, Quy, Nam), IDataReader)
        End Function
        Public Overrides Function GET_ID_BAOCAO(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUAXN_GETIDBC", quy, nam, dVBaocao), IDataReader)
        End Function

        Public Overrides Function ListCOSODIEUTRI(ByVal ID_BENHVIEN As String, ByVal MA_TINH As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_BENHVIEN_SelectListByBV", ID_BENHVIEN, MA_TINH), IDataReader)


        End Function

        Public Overrides Function AddNTP_BN_BC_KETQUAXN(ByVal Quy As Integer, ByVal Nam As Integer, ByVal DVBaocao As String, ByVal NguoiBC As String, ByVal NgayBC As DateTime, ByVal LaoDTMoi As Integer, ByVal LaoTaitri As Integer, ByVal DuongHaiT As Integer, ByVal AmHaiT As Integer, ByVal KhongHaiT As Integer, ByVal DuongBaT As Integer, ByVal AmBaT As Integer, ByVal KhongBaT As Integer, ByVal HuyenXN As Boolean, ByVal TinhXN As Boolean, ByVal PTNhap As Boolean, ByVal MA_TINH As String, ByVal MA_HUYEN As String, ByVal NGUOI_NM As Integer) As String
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaXN_Insert", Quy, Nam, DVBaocao, NguoiBC, NgayBC, LaoDTMoi, LaoTaitri, DuongHaiT, AmHaiT, KhongHaiT, DuongBaT, AmBaT, KhongBaT, HuyenXN, TinhXN, PTNhap, MA_TINH, MA_HUYEN, NGUOI_NM), String)
            ' SqlHelper.ExecuteNonQuery(ConnectionString, GetFullyQualifiedName("NTP_BN_BC_KetquaXN_Insert"), Quy, Nam, DVBaocao, NguoiBC, NgayBC, LaoDTMoi, LaoTaitri, DuongHaiT, AmHaiT, KhongHaiT, DuongBaT, AmBaT, KhongBaT, HuyenXN, TinhXN, PTNhap, MA_TINH, MA_HUYEN, NGUOI_NM)
        End Function

        Public Overrides Sub UpdateNTP_BN_BC_KETQUAXN(ByVal ID_KETQUAXN As Integer, ByVal Quy As Integer, ByVal Nam As Integer, ByVal DVBaocao As String, ByVal NguoiBC As String, ByVal NgayBC As DateTime, ByVal LaoDTMoi As Integer, ByVal LaoTaitri As Integer, ByVal DuongHaiT As Integer, ByVal AmHaiT As Integer, ByVal KhongHaiT As Integer, ByVal DuongBaT As Integer, ByVal AmBaT As Integer, ByVal KhongBaT As Integer, ByVal HuyenXN As Boolean, ByVal TinhXN As Boolean, ByVal PTNhap As Boolean, ByVal MA_TINH As String, ByVal MA_HUYEN As String, ByVal NGUOI_NM As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaXN_Update", ID_KETQUAXN, Quy, Nam, DVBaocao, NguoiBC, NgayBC, LaoDTMoi, LaoTaitri, DuongHaiT, AmHaiT, KhongHaiT, DuongBaT, AmBaT, KhongBaT, HuyenXN, TinhXN, PTNhap, MA_TINH, MA_HUYEN, NGUOI_NM)
        End Sub
       


        Public Overrides Sub DeleteNTP_BN_BC_KETQUAXN(ByVal ID_KETQUAXN As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaXN_Delete", ID_KETQUAXN)

        End Sub
        Public Overrides Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Dieukien As String) As DataSet
            ' Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCKETQUAAMHOADOM_IN", Tinh, Mien, Vung, Nam, Quy,Dieukien)
            ' Return ds
        End Function
        Public Overrides Function NTP_BN_BCKETQUAAMHOADOMBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Dieukien As String) As DataSet
            ' Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCKETQUAAMHOADOMBYHUYEN_IN", Tinh, Mien, Vung, Nam, Quy,Dieukien)
            ' Return ds
        End Function
   
#End Region

    End Class

End Namespace