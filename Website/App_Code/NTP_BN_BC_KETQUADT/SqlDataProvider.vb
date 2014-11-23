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
Imports System.Collections.Generic

Namespace YourCompany.Modules.NTP_BN_BC_KETQUADT

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


#Region "NTP_BN_BC_KETQUADT Methods"
        Public Overrides Function GetNTP_BN_BC_KETQUADT(ByVal iD_BC_KetquaDT As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADT_Select", iD_BC_KetquaDT), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_BC_KETQUADT() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADT_SelectList"), IDataReader)
        End Function

        Public Overrides Function GET_ID_BAOCAO(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaDT_GETIDBC", quy, nam, dVBaocao), IDataReader)
        End Function
        Public Overrides Function ListNTP_BN_DONVICHUABC(ByVal quy As Byte, ByVal nam As Integer, ByVal _mA_TINH As String, ByVal LOAIBC As Byte, ByVal dVBaocao As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_DONVICHUABC", quy, nam, _mA_TINH, LOAIBC, dVBaocao), IDataReader)
        End Function
        Public Overrides Function AddNTP_BN_BC_KETQUADT(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADT_Insert", quy, nam, dVBaocao, GetNull(mA_TINH), GetNull(mA_HUYEN), GetNull(nguoiBC), GetNull(ngayBC), GetNull(nGUOI_NM), GetNull(huyenXN), GetNull(tinhXN), GetNull(pTNhap)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_BC_KETQUADT(ByVal iD_BC_KetquaDT As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String, ByVal mA_TINH As String, ByVal mA_HUYEN As String, ByVal nguoiBC As String, ByVal ngayBC As DateTime, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal pTNhap As Boolean)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADT_Update", iD_BC_KetquaDT, quy, nam, dVBaocao, GetNull(mA_TINH), GetNull(mA_HUYEN), GetNull(nguoiBC), GetNull(ngayBC), GetNull(nGUOI_NM), GetNull(huyenXN), GetNull(tinhXN), GetNull(pTNhap))
        End Sub

        Public Overrides Sub DeleteNTP_BN_BC_KETQUADT(ByVal iD_BC_KetquaDT As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADT_Delete", iD_BC_KetquaDT)
        End Sub

        Public Overrides Function ListByDieuKien(ByVal Nam As String, ByVal Id_BenhVien As String, ByVal DieuKien As String, ByVal MA_TINH As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaDT_SelectList", Nam, Id_BenhVien, DieuKien, MA_TINH), IDataReader)
        End Function
#End Region

#Region "NTP_BN_BC_KETQUADTP1 Methods"
        Public Overrides Function GetNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDTP1 As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP1_Select", iD_BC_KetquaDTP1), IDataReader)
        End Function
        Public Overrides Function ListKETQUADTP1(ByVal iD_BC_KetquaDTP1 As Integer, ByVal iD_Phanloai As Integer, ByVal dVBaocao As String, ByVal Quy As Integer, ByVal Nam As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP1_SelectByID", iD_BC_KetquaDTP1, iD_Phanloai, dVBaocao, Quy, Nam), IDataReader)
        End Function
        Public Overrides Function ListNTP_BN_BC_KETQUADTP(ByVal ID_BC_KetquaDT As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaDTP1_SelectList", ID_BC_KetquaDT), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDT As Integer, ByVal iD_Phanloai As Byte, ByVal soBNDK As Integer, ByVal khoi As Integer, ByVal hoanthanh As Integer, ByVal chet As Integer, ByVal thatbai As Integer, ByVal bo As Integer, ByVal chuyen As Integer, ByVal khongdanhgia As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP1_Insert", GetNull(iD_BC_KetquaDT), iD_Phanloai, GetNull(soBNDK), GetNull(khoi), GetNull(hoanthanh), GetNull(chet), GetNull(thatbai), GetNull(bo), GetNull(chuyen), GetNull(khongdanhgia)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDTP1 As Integer, ByVal iD_BC_KetquaDT As Integer, ByVal iD_Phanloai As Byte, ByVal soBNDK As Integer, ByVal khoi As Integer, ByVal hoanthanh As Integer, ByVal chet As Integer, ByVal thatbai As Integer, ByVal bo As Integer, ByVal chuyen As Integer, ByVal khongdanhgia As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP1_Update", iD_BC_KetquaDTP1, GetNull(iD_BC_KetquaDT), iD_Phanloai, GetNull(soBNDK), GetNull(khoi), GetNull(hoanthanh), GetNull(chet), GetNull(thatbai), GetNull(bo), GetNull(chuyen), GetNull(khongdanhgia))
        End Sub

        Public Overrides Sub DeleteNTP_BN_BC_KETQUADTP(ByVal iD_BC_KetquaDTP1 As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP1_Delete", iD_BC_KetquaDTP1)
        End Sub
#End Region


#Region "NTP_BN_BC_KETQUADTP2 Methods"
        Public Overrides Function GetNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT_P2 As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP2_Select", iD_BC_KetquaDT_P2), IDataReader)
        End Function
        Public Overrides Function ListKETQUADTP2(ByVal iD_BC_KetquaDTP2 As Integer, ByVal Phanloai As Byte) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP2_SelectByID", iD_BC_KetquaDTP2, Phanloai), IDataReader)
        End Function

        Public Overrides Function ListNTP_BN_BC_KETQUADTP2(ByVal ID_BC_KetquaDT As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP2_SelectList", ID_BC_KetquaDT), IDataReader)
        End Function

        Public Overrides Function AddNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT As Integer, ByVal phanloai As Byte, ByVal xNHIV As Decimal, ByVal duongHIV As Integer, ByVal cPT As Integer, ByVal aRV As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP2_Insert", GetNull(iD_BC_KetquaDT), phanloai, GetNull(xNHIV), GetNull(duongHIV), GetNull(cPT), GetNull(aRV)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT_P2 As Integer, ByVal iD_BC_KetquaDT As Integer, ByVal phanloai As Byte, ByVal xNHIV As Decimal, ByVal duongHIV As Integer, ByVal cPT As Integer, ByVal aRV As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP2_Update", iD_BC_KetquaDT_P2, GetNull(iD_BC_KetquaDT), phanloai, GetNull(xNHIV), GetNull(duongHIV), GetNull(cPT), GetNull(aRV))
        End Sub

        Public Overrides Sub DeleteNTP_BN_BC_KETQUADTP2(ByVal iD_BC_KetquaDT_P2 As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KETQUADTP2_Delete", iD_BC_KetquaDT_P2)
        End Sub
#End Region
#Region "NTP_BN_BCKETQUADIEUTRILAOIN Methods"
        Public Overrides Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Luachon As Integer, ByVal Dieukien As String) As DataSet
            'DataSet ds = new DataSet();
            '          string[] s = { "DMHoachat_GIA_RPT" };
            '          SqlHelper.FillDataset(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHoachat_GIA_RPT", ds, s, _madt, qadmin);
            '          //ds.WriteXmlSchema("DMHoachat_GIA_RPT.xsd");
            '          return ds;
            '          Return SqlHelper.FillDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BC_KetquaDT_SelectList", Tinh, Mien, Vung, Nam)
            'Dim ds As New DataSet
            'SqlHelper.FillDataset(ConnectionString, DatabaseOwner &  ObjectQualifier + "spDMHoachat_GIA_RPT", ds, s, Tinh, Mien,Vung, Nam);
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCKETQUADIEUTRILAO_IN", Tinh, Mien, Vung, Nam, Quy, Luachon,Dieukien)
            'Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory

            'ds.WriteXmlSchema("NTP_BN_BCKETQUADIEUTRILAOIN.xsd")
            ' Return ds
        End Function
        Public Overrides Function ListBaoCaoKQDTCacthe(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String) As DataSet
            ' Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_BN_BCKETQUADTCHUNGCACTHE_IN]", Tinh, Mien, Vung, Nam, Quy)
            ' Return ds
        End Function
        Public Overrides Function BCKETQUADIEUTRILAOBYHUYEN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Luachon As Integer, ByVal Dieukien As String) As DataSet
            'Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_BN_BCKETQUADIEUTRILAOBYHUYEN_IN", Tinh, Mien, Vung, Nam, Quy, Luachon,Dieukien)
            'Return ds
        End Function
#End Region
#Region "NTP_DM_BENHVIEN Methods"


        Public Overrides Function ListNTP_DM_BENHVIEN(ByVal MA_TINH As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_BENHVIEN_SelectListByTinh", MA_TINH), IDataReader)
        End Function
        Public Overrides Function ListNTP_DM_BENHVIEN_BY_VUNG(ByVal sTEN_BV As String, ByVal IDVung As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "[NTP_DM_BENHVIEN_SearchByVung]", sTEN_BV, IDVung), IDataReader)
        End Function
#End Region
#Region "NTP_DM_TINH Methods"
        Public Overrides Function ListNTP_DM_TINHALL() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_TINH_SelectALL"), IDataReader)
        End Function

        Public Overrides Function ListNTP_DM_TINH(ByVal id_Benhvien As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_TINH_SelectByCAPQL", id_Benhvien), IDataReader)
        End Function
        Public Overrides Function ListNTP_DM_TINHforMIEN(ByVal ID_MIEN As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_TINH_SelectByVungMien", 0, ID_MIEN), IDataReader)
        End Function

#End Region
#Region "NTP_DM_MIEN Methods"


        Public Overrides Function ListNTP_DM_MIEN() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_MIEN_SelectList"), IDataReader)
        End Function
        Public Overrides Function NTP_DM_MIEN_Select(ByVal ID_MIEN As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_MIEN_Select", ID_MIEN), IDataReader)
        End Function

#End Region

#Region "NTP_DM_VUNG Methods"
        Public Overrides Function GetNTP_DM_VUNG(ByVal iD_VUNG As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_VUNG_Select", iD_VUNG), IDataReader)
        End Function

        Public Overrides Function ListNTP_DM_VUNG(ByVal Mien As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_VUNG_SelectByMien", Mien), IDataReader)
        End Function
        Public Overrides Function ListNTP_DM_VUNGALL() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_VUNG_SelectList"), IDataReader)
        End Function

        Public Overrides Function AddNTP_DM_VUNG(ByVal tEN_VUNG As String, ByVal iD_MIEN As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_VUNG_Insert", GetNull(tEN_VUNG), GetNull(iD_MIEN)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_DM_VUNG(ByVal iD_VUNG As Integer, ByVal tEN_VUNG As String, ByVal iD_MIEN As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_VUNG_Update", iD_VUNG, GetNull(tEN_VUNG), GetNull(iD_MIEN))
        End Sub

        Public Overrides Sub DeleteNTP_DM_VUNG(ByVal iD_VUNG As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_VUNG_Delete", iD_VUNG)
        End Sub
#End Region
#Region "NTP_DM_LOAIBV Methods"

        Public Overrides Function ListNTP_DM_LOAIBV() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_DM_LOAIBV_Select"), IDataReader)
        End Function

#End Region
    End Class

End Namespace