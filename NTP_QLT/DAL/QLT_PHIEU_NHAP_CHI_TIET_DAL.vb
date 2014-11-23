Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT

Public Class QLT_PHIEU_NHAP_CHI_TIET_DAL


    Public Sub InsertItem(ByVal bibi As NTP_QLT.QLT_PHIEU_NHAP_CHI_TIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUNHAP_CHITIET_Insert", _
         Getnull(bibi.ID_PHIEUNHAP_CHITIET), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.LO_SX), _
         Getnull(bibi.HAN_SUDUNG), _
         Getnull(bibi.NGAY_SX), _
         Getnull(bibi.SO_LUONG))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLT.QLT_PHIEU_NHAP_CHI_TIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUNHAP_CHITIET_Update", _
         Getnull(bibi.ID_PHIEUNHAP_CHITIET), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.LO_SX), _
         Getnull(bibi.HAN_SUDUNG), _
         Getnull(bibi.NGAY_SX), _
         Getnull(bibi.SO_LUONG))
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUNHAP_CHITIET_Delete", _
         Getnull(ID_PHIEUNHAP_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUNHAP_CHITIET_Select", _
         Getnull(ID_PHIEUNHAP_CHITIET))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUNHAP_CHITIET_SelectList")
    End Function
    Public Function SearchItem(ByVal ID_PHIEUNHAP As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUNHAP_CHITIET_SEARCH", Getnull(ID_PHIEUNHAP))
    End Function

End Class



