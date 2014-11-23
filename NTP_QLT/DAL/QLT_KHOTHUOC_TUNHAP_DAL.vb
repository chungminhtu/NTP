Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT
Public Class QLT_KHOTHUOC_TUNHAP_DAL
    Public Sub InsertItem(ByVal bibi As QLT_KHOTHUOC_TUNHAP_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KHOTHUOC_TUNHAP_Insert", _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.ID_KY_KIEMKE), _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.LO_SX), _
         GetNull(bibi.TON_DAUKY), _
         GetNull(bibi.NHAP), _
         GetNull(bibi.XUAT), _
         GetNull(bibi.TON_CUOIKY), _
         GetNull(bibi.THUA), _
         GetNull(bibi.THIEU), _
         GetNull(bibi.HONG), _
         GetNull(bibi.TOT), _
         GetNull(bibi.Kem_PC), _
         GetNull(bibi.Mat_PC))
    End Sub

    Public Sub UpdateItem(ByVal bibi As QLT_KHOTHUOC_TUNHAP_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KHOTHUOC_TUNHAP_Update", _
         GetNull(bibi.ID_TUNHAP), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.ID_KY_KIEMKE), _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.LO_SX), _
         GetNull(bibi.TON_DAUKY), _
         GetNull(bibi.NHAP), _
         GetNull(bibi.XUAT), _
         GetNull(bibi.TON_CUOIKY), _
         GetNull(bibi.THUA), _
         GetNull(bibi.THIEU), _
         GetNull(bibi.HONG), _
         GetNull(bibi.TOT), _
         GetNull(bibi.Kem_PC), _
         GetNull(bibi.Mat_PC))
    End Sub

    Public Sub DeleteItem(ByVal ID_TUNHAP As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KHOTHUOC_TUNHAP_Delete", _
         GetNull(ID_TUNHAP))
    End Sub

    Public Function SelectItem(ByVal ID_TUNHAP As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KHOTHUOC_TUNHAP_Select", _
         GetNull(ID_TUNHAP))
    End Function

    Public Function Search(ByVal ID_KhoThuoc As Integer, ByVal ID_KyKiemKe As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KHOTHUOC_TUNHAP_SEARCH", _
         GetNull(ID_KhoThuoc), GetNull(ID_KyKiemKe))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KHOTHUOC_TUNHAP_SelectList")
    End Function


End Class
