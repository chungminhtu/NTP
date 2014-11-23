Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL
Imports NTP_QLT
Public Class QLT_KY_KIEMKE_DAL
    Private Shared _thisInstance As QLT_KY_KIEMKE_DAL
    Private Shared PadLock As New Object

    Public Shared Function Instance() As QLT_KY_KIEMKE_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New QLT_KY_KIEMKE_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function
    Public Function GetKyDaKiemKe(ByVal ID_KHO As Integer, ByVal Nam As Integer) As Integer
        Return SqlHelper.ExecuteScalar(SQLConnectionString, _
         "NTP_QLT_KY_KIEMKE_GetKyDaKiemKe", ID_KHO, Nam)
    End Function

    Public Sub InsertItem(ByVal bibi As QLT_KY_KIEMKE_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KY_KIEMKE_KHOASO", _
         Getnull(bibi.TEN_KY_KIEMKE), _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.NGAY_BATDAU), _
         Getnull(bibi.NGAY_KETTHUC), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NAM), _
         Getnull(bibi.THANG))
    End Sub

    Public Function CheckDaKiemKe(ByVal ID_Kho As Integer, ByVal nam As Integer, ByVal thang As Integer) As Int16
        Return SqlHelper.ExecuteScalar(SQLConnectionString, _
         "NTP_QLT_KY_KIEMKE_CheckDaKiemKe", ID_Kho, nam, thang)
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal Nam As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
              "NTP_QLT_KY_KIEMKE_Search", ID_KHO, Nam)
    End Function

    Public Function BaoCaoKiemKe(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                     "NTP_QLT_BAOCAO_TONGHOP_KIEMKE", ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoNhapXuat(ByVal Thang As Integer, ByVal Nam As Int64, ByVal ID_Kho As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                     "NTP_QLT_BAOCAO_TONGHOP_NHAPXUAT", Thang, Nam, ID_Kho)
    End Function

    Public Function BaoCaoSuDungThuoc(ByVal Thang As Integer, ByVal Nam As Int64, ByVal ID_Kho As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                     "NTP_QLT_BaoCao_SuDungThuoc_Tinh", Thang, Nam, ID_Kho)
    End Function


    Public Function BaoCaoSuDungThuoc_Sub(ByVal Thang As Integer, ByVal Nam As Int64, ByVal ID_Kho As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                     "NTP_QLT_BaoCao_SuDungThuoc_Huyen", Thang, Nam, ID_Kho)
    End Function
    Public Function BaoCaoSuDungThuoc_TuyenHuyen(ByVal Quy As Integer, ByVal Nam As Int64, ByVal ID_Kho As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                     "NTP_QLT_BaoCao_SuDungThuoc_TuyenHuyen", Quy, Nam, ID_Kho)
    End Function


    Public Sub KetChuyenSoLieu(ByVal Thang As Integer, ByVal Nam As Integer, ByVal ID_Kho As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KETCHUYENSOLIEU", _
         GetNull(Thang), _
         GetNull(Nam), GetNull(ID_Kho))
    End Sub
End Class
