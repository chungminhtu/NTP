Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_NUOC_DAL

    Private Shared _thisInstance As NTP_DM_NUOC_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_NUOC_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_NUOC_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function
    Public Sub InsertItem(ByVal bibi As NTP_DM_NUOC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_NUOC_Insert", _
         Getnull(bibi.MA_NUOC), _
         Getnull(bibi.TEN_NUOC))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_NUOC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_NUOC_Update", _
         Getnull(bibi.MA_NUOC), _
         Getnull(bibi.TEN_NUOC))
    End Sub

    Public Sub DeleteItem(ByVal MA_NUOC As String)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_NUOC_Delete", _
         Getnull(MA_NUOC))
    End Sub

    Public Function SelectItem(ByVal MA_NUOC As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_NUOC_Select", _
         Getnull(MA_NUOC))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_NUOC_SelectList")
    End Function

    Public Function Search(ByVal sTEN_NUOC As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "NTP_DM_NUOC_Search", Getnull(sTEN_NUOC))
    End Function

End Class
