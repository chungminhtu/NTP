Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke


Public Class NTP_DM_CAP_DAL
    Private Shared _thisInstance As NTP_DM_CAP_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_CAP_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_CAP_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_CAP_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_CAP_Insert", _
         GetNull(bibi.ID_CAP), _
         GetNull(bibi.TEN_CAP))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_CAP_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_CAP_Update", _
         GetNull(bibi.ID_CAP), _
         GetNull(bibi.TEN_CAP))
    End Sub

    Public Sub DeleteItem(ByVal ID_CAP As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_CAP_Delete", _
         GetNull(ID_CAP))
    End Sub

    Public Function SelectItem(ByVal ID_CAP As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_CAP_Select", _
         GetNull(ID_CAP))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_CAP_SelectList")
    End Function

End Class
