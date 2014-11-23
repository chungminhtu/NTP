Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_THUOC_DAL
    Private Shared _thisInstance As NTP_DM_THUOC_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_THUOC_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_THUOC_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_THUOC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_THUOC_Insert", _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.MA_THUOC), _
         Getnull(bibi.TEN_THUOC), _
         Getnull(bibi.HAM_LUONG), _
         Getnull(bibi.MA_NUOC), _
         Getnull(bibi.ID_DVT))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_THUOC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_THUOC_Update", _
         Getnull(bibi.ID_THUOC), _
         Getnull(bibi.MA_THUOC), _
         Getnull(bibi.TEN_THUOC), _
         Getnull(bibi.HAM_LUONG), _
         Getnull(bibi.MA_NUOC), _
         Getnull(bibi.ID_DVT))
    End Sub

    Public Sub DeleteItem(ByVal ID_THUOC As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_THUOC_Delete", _
         Getnull(ID_THUOC))
    End Sub

    Public Function SelectItem(ByVal ID_THUOC As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_THUOC_Select", _
         Getnull(ID_THUOC))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_THUOC_SelectList")
    End Function

End Class
