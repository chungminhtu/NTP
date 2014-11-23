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

Namespace YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM

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

#Region "NTP_BN_PHIEUXETNGHIEM Methods"
        Public Overrides Function GetNTP_BN_PHIEUXETNGHIEM(ByVal iD_Phieuxetnghiem As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_Select", iD_Phieuxetnghiem), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_PHIEUXETNGHIEM(ByVal Id_BenhNhan As String, ByVal DV_Xetnghiem As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_SelectList", Id_BenhNhan, DV_Xetnghiem), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_PHIEUXETNGHIEM(ByVal iD_Benhnhan As String, ByVal soXN As String, ByVal iD_Benhvien As String, ByVal iD_PhanloaiYte As Integer, ByVal lydoXN As Integer, ByVal soluong As Byte, ByVal hIV As Boolean, ByVal soDKDT As String, ByVal xNVien As String, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal DV_XETNGHIEM As String, ByVal SoThangDT As Integer, ByVal Ngayxn As DateTime, ByVal DV_Tiepnhan As String) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_Insert", GetNull(iD_Benhnhan), GetNull(soXN), GetNull(iD_Benhvien), iD_PhanloaiYte, GetNull(lydoXN), GetNull(soluong), GetNull(hIV), GetNull(soDKDT), GetNull(xNVien), nGUOI_NM, DV_XETNGHIEM, SoThangDT, Ngayxn, DV_Tiepnhan), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_PHIEUXETNGHIEM(ByVal iD_Phieuxetnghiem As Integer, ByVal iD_Benhnhan As String, ByVal soXN As String, ByVal iD_Benhvien As String, ByVal iD_PhanloaiYte As Integer, ByVal lydoXN As Integer, ByVal soluong As Byte, ByVal hIV As Boolean, ByVal soDKDT As String, ByVal xNVien As String, ByVal ghichu As String, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal DV_XETNGHIEM As String, ByVal SoThangDT As Integer, ByVal Ngayxn As DateTime, ByVal DV_Tiepnhan As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_Update", iD_Phieuxetnghiem, GetNull(iD_Benhnhan), GetNull(soXN), GetNull(iD_Benhvien), iD_PhanloaiYte, GetNull(lydoXN), GetNull(soluong), GetNull(hIV), GetNull(soDKDT), GetNull(xNVien), nGUOI_NM, DV_XETNGHIEM, SoThangDT, Ngayxn, DV_Tiepnhan)
        End Sub

        Public Overrides Sub DeleteNTP_BN_PHIEUXETNGHIEM(ByVal iD_Phieuxetnghiem As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_Delete", iD_Phieuxetnghiem)
        End Sub
        Public Overrides Function NTP_BN_PHIEUXETNGHIEM_SelectByDVDieutri(ByVal ID_Phieuxetnghiem As Integer, ByVal ID_Benhvien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_SelectByDVDieutri", ID_Phieuxetnghiem, ID_Benhvien), IDataReader)
        End Function
        Public Overrides Function NTP_BN_PHIEUXETNGHIEM_SelectByIDBENHNHAN(ByVal ID_BENHNHAN As String, ByVal DV_XETNGHIEM As String) As DataSet

            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_SelectByIDBENHNHAN", ID_BENHNHAN, DV_XETNGHIEM)
        End Function
#End Region
#Region "NTP_BN_PHIEUXETNGHIEM_C Methods"
        Public Overrides Function GetNTP_BN_PHIEUXETNGHIEM_C(ByVal iD_Phieuxetnghiem_C As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_C_Select", iD_Phieuxetnghiem_C), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_PHIEUXETNGHIEM_C() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_C_SelectList"), IDataReader)
        End Function
        Public Overrides Function ListByIDNTP_BN_PHIEUXETNGHIEM_C(ByVal Id_PhieuXetNghiemBN As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_C_SelectByID", Id_PhieuXetNghiemBN), IDataReader)
        End Function
        Public Overrides Function ListByIDBENHNHANNTP_BN_PHIEUXETNGHIEM_C(ByVal Id_BENHNHAN As String, ByVal GiaidoanDT As Byte) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_C_ByID_Benhnhan", Id_BENHNHAN, GiaidoanDT), IDataReader)
        End Function

        Public Overrides Function ListByThangNTP_BN_PHIEUXETNGHIEM_C(ByVal thang As String, ByVal Id_BenhVien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_SelectByKQThang", thang, Id_BenhVien), IDataReader)
        End Function
        Public Overrides Function AddNTP_BN_PHIEUXETNGHIEM_C(ByVal iD_XetnghiemBN As Integer, ByVal ngayNhanMau As DateTime, ByVal trangthaiDom As String, ByVal maudom As Byte, ByVal ketqua As Byte, ByVal soXN As String) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_C_Insert", iD_XetnghiemBN, GetNull(ngayNhanMau), GetNull(trangthaiDom), GetNull(maudom), GetNull(ketqua), GetNull(soXN)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_PHIEUXETNGHIEM_C(ByVal ID_Phieuxetnghiem_C As Integer, ByVal iD_XetnghiemBN As Integer, ByVal ngayNhanMau As DateTime, ByVal trangthaiDom As String, ByVal maudom As Byte, ByVal ketqua As Byte, ByVal soXN As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_C_Update", ID_Phieuxetnghiem_C, iD_XetnghiemBN, GetNull(ngayNhanMau), GetNull(trangthaiDom), GetNull(maudom), GetNull(ketqua), GetNull(soXN))
        End Sub

        Public Overrides Sub DeleteNTP_BN_PHIEUXETNGHIEM_C(ByVal iD_Phieuxetnghiem As Integer, ByVal ID_Phieuxetnghiem_C As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_PHIEUXETNGHIEM_C_Delete", iD_Phieuxetnghiem, ID_Phieuxetnghiem_C)
        End Sub
       
#End Region
#Region "NTP_BN_XETNGHIEM_GD Methods"
        Public Overrides Function GetNTP_BN_XETNGHIEM_GD(ByVal iD_Xetnghiem_GD As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_Select", iD_Xetnghiem_GD), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_XETNGHIEM_GD() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_SelectList"), IDataReader)
        End Function

        Public Overrides Function GetNTP_BN_XETNGHIEM_GDByThoigianDT(ByVal iD_Xetnghiem_GD As Integer, ByVal ThoigianDT As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_SelectByTG", iD_Xetnghiem_GD, ThoigianDT), IDataReader)
        End Function

        Public Overrides Function ListByIDDIEUTRINTP_BN_XETNGHIEM_GD(ByVal Id_DieuTri As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_SelectList", Id_DieuTri), IDataReader)
        End Function


        Public Overrides Function AddNTP_BN_XETNGHIEM_GD(ByVal iD_Dieutri As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal thoiGianDT As Byte, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal canNang As Integer, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal Nuoicay As String) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_Insert", iD_Dieutri, iD_Phieuxetnghiem_C, thoiGianDT, GetNull(NgayXN), GetNull(SoXN), GetNull(KetquaXN), GetNull(canNang), nGAY_NM, nGUOI_NM, GetNull(Nuoicay)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_XETNGHIEM_GD(ByVal iD_Xetnghiem_GD As Integer, ByVal iD_Dieutri As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal thoiGianDT As Byte, ByVal NgayXN As DateTime, ByVal SoXN As String, ByVal KetquaXN As Integer, ByVal canNang As Integer, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal Nuoicay As String)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_Update", iD_Xetnghiem_GD, iD_Dieutri, iD_Phieuxetnghiem_C, thoiGianDT, GetNull(NgayXN), GetNull(SoXN), GetNull(KetquaXN), GetNull(canNang), nGAY_NM, nGUOI_NM, GetNull(Nuoicay))
        End Sub

        Public Overrides Sub DeleteNTP_BN_XETNGHIEM_GD(ByVal iD_Xetnghiem_GD As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEM_GD_Delete", iD_Xetnghiem_GD)
        End Sub
	Public Overrides Function NTP_BN_XETNGHIEMBNTHATBAI(ByVal iD_BENHNHAN As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_XETNGHIEMBNTHATBAI", iD_BENHNHAN), IDataReader)
        End Function
#End Region
    End Class

End Namespace