Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL

Public Class NTP_QLT_DM_KHOTHUOC_DAL

    Public Sub InsertItem(ByVal bibi As NTP_QLT_DM_KHOTHUOC_Info)
        SqlHelper.ExecuteNonQuery(sqlconnectionstring, _
         "NTP_QLT_DM_KHOTHUOC_Insert", _
         Getnull(bibi.ID), _
         Getnull(bibi.MA_KHO), _
         Getnull(bibi.TEN_KHO), _
         Getnull(bibi.CAP_KHO), _
         Getnull(bibi.ID_KHO_CAPTREN), _
         Getnull(bibi.DIA_CHI))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLT_DM_KHOTHUOC_Info)
        SqlHelper.ExecuteNonQuery(sqlconnectionstring, _
         "NTP_QLT_DM_KHOTHUOC_Update", _
         Getnull(bibi.ID), _
         Getnull(bibi.MA_KHO), _
         Getnull(bibi.TEN_KHO), _
         Getnull(bibi.CAP_KHO), _
         Getnull(bibi.ID_KHO_CAPTREN), _
         Getnull(bibi.DIA_CHI))
    End Sub

    Public Sub DeleteItem(ByVal ID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_DM_KHOTHUOC_Delete", ID _
      )
    End Sub

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(sqlconnectionstring, _
         "NTP_QLT_DM_KHOTHUOC_SelectList")
    End Function

End Class
