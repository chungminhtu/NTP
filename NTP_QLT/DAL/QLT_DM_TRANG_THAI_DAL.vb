Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT
Public Class QLT_DM_TRANG_THAI_DAL
    'Inherits TL_DataProvider

    'Public Sub New()
    '    MyBase.Initialize()
    'End Sub

    'Public Overloads Shared Function Instance() As NTP_QLT_DM_TRANGTHAI_DAO
    '    Return CType(Instance(NAMESPACE_NAME & "." & "NTP_QLT_DM_TRANGTHAI_DAO", ASSEMBLY_NAME), NTP_QLT_DM_TRANGTHAI_DAO)
    'End Function

    Public Sub InsertItem(ByVal bibi As NTP_QLT.QLT_DM_TRANG_THAI_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_DM_TRANGTHAI_Insert", _
         Getnull(bibi.ID_TRANGTHAI), _
         Getnull(bibi.MO_TA))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLT.QLT_DM_TRANG_THAI_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_DM_TRANGTHAI_Update", _
         Getnull(bibi.ID_TRANGTHAI), _
         Getnull(bibi.MO_TA))
    End Sub

    Public Sub DeleteItem(ByVal ID_TRANGTHAI As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_DM_TRANGTHAI_Delete", _
         Getnull(ID_TRANGTHAI))
    End Sub

    Public Function SelectItem(ByVal ID_TRANGTHAI As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_DM_TRANGTHAI_Select", _
         Getnull(ID_TRANGTHAI))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_DM_TRANGTHAI_SelectList")
    End Function

End Class
