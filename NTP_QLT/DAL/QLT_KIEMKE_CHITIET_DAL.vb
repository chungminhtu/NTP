Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT
Public Class QLT_KIEMKE_CHITIET_DAL
    'Inherits TL_DataProvider

    'Public Sub New()
    '    MyBase.Initialize()
    'End Sub

    'Public Overloads Shared Function Instance() As NTP_QLT_KIEMKE_CHITIET_DAO
    '    Return CType(Instance(NAMESPACE_NAME & "." & "NTP_QLT_KIEMKE_CHITIET_DAO", ASSEMBLY_NAME), NTP_QLT_KIEMKE_CHITIET_DAO)
    'End Function

    Public Sub InsertItem(ByVal bibi As NTP_QLT.QLT_KIEMKE_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KIEMKE_CHITIET_Insert", _
         Getnull(bibi.ID_KIEMKE_CHITIET), _
         Getnull(bibi.ID_KIEMKE), _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.ID_TRANGTHAI), _
         Getnull(bibi.LO_SX), _
         Getnull(bibi.HAN_SUDUNG), _
         Getnull(bibi.NGAY_SX), _
         Getnull(bibi.SO_LUONG), _
         Getnull(bibi.Loai_Phieu))
    End Sub

    Public Sub UpdateItem(ByVal bibi As QLT_KIEMKE_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KIEMKE_CHITIET_Update", _
         Getnull(bibi.ID_KIEMKE_CHITIET), _
         Getnull(bibi.ID_KIEMKE), _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.ID_TRANGTHAI), _
         Getnull(bibi.LO_SX), _
         Getnull(bibi.HAN_SUDUNG), _
         Getnull(bibi.NGAY_SX), _
         Getnull(bibi.SO_LUONG), _
         Getnull(bibi.Loai_Phieu))
    End Sub

    Public Sub DeleteItem(ByVal ID_KIEMKE_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KIEMKE_CHITIET_Delete", _
         Getnull(ID_KIEMKE_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_KIEMKE_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KIEMKE_CHITIET_Select", _
         Getnull(ID_KIEMKE_CHITIET))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KIEMKE_CHITIET_SelectList")
    End Function
    Public Function SearchItem(ByVal ID_KIEMKE As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KIEMKE_CHITIET_SEARCH", Getnull(ID_KIEMKE))
    End Function
End Class
