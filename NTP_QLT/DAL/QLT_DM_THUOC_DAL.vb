Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT

Public Class QLT_DM_THUOC_DAL
    ' Inherits TL_DataProvider

    'Public Sub New()
    '    MyBase.Initialize()
    'End Sub

    'Public Overloads Shared Function Instance() As QLT_DM_THUOC_DAL
    '    Return CType(Instance(NAMESPACE_NAME & "." & "NTP_DM_THUOC_DAO", ASSEMBLY_NAME), NTP_DM_THUOC_DAO)
    'End Function

    Public Sub InsertItem(ByVal bibi As QLT_DM_THUOC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_THUOC_Insert", _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.MA_THUOC), _
         GetNull(bibi.TEN_THUOC), _
         GetNull(bibi.HAM_LUONG), _
         GetNull(bibi.MA_NUOC), _
         GetNull(bibi.ID_DVT))
    End Sub

    Public Sub UpdateItem(ByVal bibi As QLT_DM_THUOC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_THUOC_Update", _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.MA_THUOC), _
         GetNull(bibi.TEN_THUOC), _
         GetNull(bibi.HAM_LUONG), _
         GetNull(bibi.MA_NUOC), _
         GetNull(bibi.ID_DVT))
    End Sub

    Public Sub DeleteItem(ByVal ID_THUOC As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_THUOC_Delete", _
         GetNull(ID_THUOC))
    End Sub

    Public Function SelectItem(ByVal ID_THUOC As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_THUOC_Select", _
         GetNull(ID_THUOC))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_THUOC_SelectList")
    End Function
    Public Function Search(ByVal sTen_Thuoc As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_THUOC_Search", _
         GetNull(sTen_Thuoc))
    End Function

    Public Function SearchLo(ByVal ID_Thuoc As Integer, ByVal ID_Kho As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_THUOC_SearchLo", _
         GetNull(ID_Thuoc), GetNull(ID_Kho))
    End Function

    Public Sub Update_LoSX(ByVal ID_Thuoc As Integer, ByVal Lo_SX As String, ByVal Lo_SXCu As String, ByVal ID_Kho As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_THUOC_UpdateLo", _
         GetNull(ID_Thuoc), GetNull(Lo_SX), GetNull(Lo_SXCu), GetNull(ID_Kho))
    End Sub
End Class
