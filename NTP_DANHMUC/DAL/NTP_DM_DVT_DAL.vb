Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_DVT_DAL
   
    Private Shared _thisInstance As NTP_DM_DVT_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_DVT_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_DVT_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_DVT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_DVT_Insert", _
         Getnull(bibi.ID_DVT), _
         Getnull(bibi.TEN_DVT))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_DVT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_DVT_Update", _
         Getnull(bibi.ID_DVT), _
         Getnull(bibi.TEN_DVT))
    End Sub

    Public Sub DeleteItem(ByVal ID_DVT As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_DVT_Delete", _
         Getnull(ID_DVT))
    End Sub

    Public Function SelectItem(ByVal ID_DVT As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_DVT_Select", _
         Getnull(ID_DVT))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_DVT_SelectList")
    End Function

End Class
