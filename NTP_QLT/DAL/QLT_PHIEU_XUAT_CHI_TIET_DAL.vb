Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT
Public Class QLT_PHIEU_XUAT_CHI_TIET_DAL

    'Public Sub New()
    '    MyBase.Initialize()
    'End Sub

    'Public Overloads Shared Function Instance() As NTP_QLT_PHIEUXUAT_CHITIET_DAO
    '    Return CType(Instance(NAMESPACE_NAME & "." & "NTP_QLT_PHIEUXUAT_CHITIET_DAO", ASSEMBLY_NAME), NTP_QLT_PHIEUXUAT_CHITIET_DAO)
    'End Function

    Public Sub InsertItem(ByVal bibi As QLT_PHIEU_XUAT_CHI_TIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_CHITIET_Insert", _
         Getnull(bibi.ID_PHIEUXUAT_CHITIET), _
         Getnull(bibi.ID_PHIEUXUAT), _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.LO_SX), _
         Getnull(bibi.HAN_SUDUNG), _
         Getnull(bibi.NGAY_SX), _
         Getnull(bibi.SO_LUONG))
    End Sub

    Public Sub UpdateItem(ByVal bibi As QLT_PHIEU_XUAT_CHI_TIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_CHITIET_Update", _
         Getnull(bibi.ID_PHIEUXUAT_CHITIET), _
         Getnull(bibi.ID_PHIEUXUAT), _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.LO_SX), _
         Getnull(bibi.HAN_SUDUNG), _
         Getnull(bibi.NGAY_SX), _
         Getnull(bibi.SO_LUONG))
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUXUAT_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_CHITIET_Delete", _
         Getnull(ID_PHIEUXUAT_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUXUAT_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_CHITIET_Select", _
         Getnull(ID_PHIEUXUAT_CHITIET))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_CHITIET_SelectList")
    End Function
    Public Function SearchItem(ByVal ID_PHIEUXUAT As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_CHITIET_SEARCH", Getnull(ID_PHIEUXUAT))
    End Function

End Class

