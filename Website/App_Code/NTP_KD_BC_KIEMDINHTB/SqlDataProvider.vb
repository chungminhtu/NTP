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

Namespace YourCompany.Modules.NTP_KD_BC_KIEMDINHTB

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


        '#Region "NTP_KD_BC_KIEMDINHTB Methods"
        '        Public Overrides Function GetNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer) As IDataReader
        '            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Select", iD_KiemdinhTB), IDataReader)
        '        End Function

        '        Public Overrides Function ListNTP_KD_BC_KIEMDINHTB() As IDataReader
        '            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_SelectList"), IDataReader)
        '        End Function
        '        Public Overrides Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String) As IDataReader
        '            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_SelectList", ThangNam, Id_BenhVien, DieuKien), IDataReader)
        '        End Function
        '        Public Overrides Function AddNTP_KD_BC_KIEMDINHTB(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPD As Integer, ByVal cLBPK As Integer, ByVal taymauDat As Integer, ByVal taymauQ As Integer, ByVal taymauC As Integer, ByVal dosachDat As Integer, ByVal dosachK As Integer, ByVal dodayDat As Integer, ByVal dodayD As Integer, ByVal dodayM As Integer, ByVal kichthuocDat As Integer, ByVal kichthuocT As Integer, ByVal kichthuocN As Integer, ByVal dominDat As Integer, ByVal dominK As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean) As Integer
        '            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Insert", GetNull(quy), GetNull(nam), GetNull(iD_Benhvien), GetNull(tSTBThuchien), GetNull(tSTBCanthuchien), GetNull(soTBKiemdinh), GetNull(saiDlon), GetNull(saiAlon), GetNull(dLLon), GetNull(saiDNho), GetNull(saiANho), GetNull(dLNho), GetNull(cLBPD), GetNull(cLBPK), GetNull(taymauDat), GetNull(taymauQ), GetNull(taymauC), GetNull(dosachDat), GetNull(dosachK), GetNull(dodayDat), GetNull(dodayD), GetNull(dodayM), GetNull(kichthuocDat), GetNull(kichthuocT), GetNull(kichthuocN), GetNull(dominDat), GetNull(dominK), GetNull(nguoi_NM), GetNull(pTNhap), GetNull(huyenXN), GetNull(tinhXN)), Integer)
        '        End Function

        '        Public Overrides Sub UpdateNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPD As Integer, ByVal cLBPK As Integer, ByVal taymauDat As Integer, ByVal taymauQ As Integer, ByVal taymauC As Integer, ByVal dosachDat As Integer, ByVal dosachK As Integer, ByVal dodayDat As Integer, ByVal dodayD As Integer, ByVal dodayM As Integer, ByVal kichthuocDat As Integer, ByVal kichthuocT As Integer, ByVal kichthuocN As Integer, ByVal dominDat As Integer, ByVal dominK As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean)
        '            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Update", iD_KiemdinhTB, GetNull(quy), GetNull(nam), GetNull(iD_Benhvien), GetNull(tSTBThuchien), GetNull(tSTBCanthuchien), GetNull(soTBKiemdinh), GetNull(saiDlon), GetNull(saiAlon), GetNull(dLLon), GetNull(saiDNho), GetNull(saiANho), GetNull(dLNho), GetNull(cLBPD), GetNull(cLBPK), GetNull(taymauDat), GetNull(taymauQ), GetNull(taymauC), GetNull(dosachDat), GetNull(dosachK), GetNull(dodayDat), GetNull(dodayD), GetNull(dodayM), GetNull(kichthuocDat), GetNull(kichthuocT), GetNull(kichthuocN), GetNull(dominDat), GetNull(dominK), GetNull(nguoi_NM), GetNull(pTNhap), GetNull(huyenXN), GetNull(tinhXN))
        '        End Sub

        '        Public Overrides Sub DeleteNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer)
        '            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Delete", iD_KiemdinhTB)
        '        End Sub
        '#End Region

#Region "NTP_KD_BC_KIEMDINHTB Methods"
        Public Overrides Function GetNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Select", iD_KiemdinhTB), IDataReader)
        End Function

        Public Overrides Function ListNTP_KD_BC_KIEMDINHTB() As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_SelectList"), IDataReader)
        End Function
        Public Overrides Function GET_ID_BAOCAO(ByVal quy As Byte, ByVal nam As Integer, ByVal dVBaocao As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_GETIDBC", quy, nam, dVBaocao), IDataReader)
        End Function
        Public Overrides Function AddNTP_KD_BC_KIEMDINHTB(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPDat As Integer, ByVal taymauDat As Integer, ByVal dosachDat As Integer, ByVal dodayDat As Integer, ByVal kichthuocDat As Integer, ByVal dominDat As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal ngayBC As DateTime, ByVal NguoiBC As String, ByVal Loilon As Integer, ByVal Loinho As Integer, ByVal TongsoTBKiemdinh As Integer) As Integer
            Return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Insert", quy, nam, iD_Benhvien, GetNull(tSTBThuchien), GetNull(tSTBCanthuchien), GetNull(soTBKiemdinh), GetNull(saiDlon), GetNull(saiAlon), GetNull(dLLon), GetNull(saiDNho), GetNull(saiANho), GetNull(dLNho), GetNull(cLBPDat), GetNull(taymauDat), GetNull(dosachDat), GetNull(dodayDat), GetNull(kichthuocDat), GetNull(dominDat), GetNull(nguoi_NM), GetNull(pTNhap), GetNull(huyenXN), GetNull(tinhXN), GetNull(ngayBC), GetNull(NguoiBC), GetNull(Loilon), GetNull(Loinho), GetNull(TongsoTBKiemdinh)), Integer)
        End Function

        Public Overrides Sub UpdateNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPDat As Integer, ByVal taymauDat As Integer, ByVal dosachDat As Integer, ByVal dodayDat As Integer, ByVal kichthuocDat As Integer, ByVal dominDat As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal ngayBC As DateTime, ByVal NguoiBC As String, ByVal Loilon As Integer, ByVal Loinho As Integer, ByVal TongsoTBKiemdinh As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Update", iD_KiemdinhTB, quy, nam, iD_Benhvien, GetNull(tSTBThuchien), GetNull(tSTBCanthuchien), GetNull(soTBKiemdinh), GetNull(saiDlon), GetNull(saiAlon), GetNull(dLLon), GetNull(saiDNho), GetNull(saiANho), GetNull(dLNho), GetNull(cLBPDat), GetNull(taymauDat), GetNull(dosachDat), GetNull(dodayDat), GetNull(kichthuocDat), GetNull(dominDat), GetNull(nguoi_NM), GetNull(pTNhap), GetNull(huyenXN), GetNull(tinhXN), GetNull(ngayBC), GetNull(NguoiBC), GetNull(Loilon), GetNull(Loinho), GetNull(TongsoTBKiemdinh))
        End Sub

        Public Overrides Sub DeleteNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer)
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_Delete", iD_KiemdinhTB)
        End Sub
        Public Overrides Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal MA_tinh As String) As IDataReader
            Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BC_KIEMDINHTB_SelectList", ThangNam, Id_BenhVien, DieuKien, MA_tinh), IDataReader)
        End Function
        Public Overrides Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            'Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BCKIEMDINHTB_IN", Tinh, Mien, Vung, Nam, Quy, LoaiBC, Dieukien)

            ' Return ds
        End Function

        Public Overrides Function NTP_KD_BCTHUDOMPHBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal DieuKien As String) As DataSet
            'Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_BCTHUDOMPHBYHUYEN_IN", Tinh, Mien, Vung, Nam, Quy, DieuKien)

            ' Return ds
        End Function
        Public Overrides Function InPhieuPhanhoiKQKD(ByVal Thang As String, ByVal Nam As Integer, ByVal id_Benhvien As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            'Dim ds As New DataSet
            Return SqlHelper.ExecuteDataset(ConnectionString, DatabaseOwner & ObjectQualifier & "NTP_KD_PHANHOIKETQUAKDTB", Thang, Nam, id_Benhvien, LoaiBC, Dieukien)

            ' Return ds
        End Function

#End Region






    End Class

End Namespace