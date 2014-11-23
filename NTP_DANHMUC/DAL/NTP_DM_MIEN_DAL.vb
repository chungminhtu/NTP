Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_MIEN_DAL
    Private Shared _thisInstance As NTP_DM_MIEN_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_MIEN_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_MIEN_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_MIEN_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_MIEN_Insert", _
         GetNull(bibi.ID_MIEN), _
         GetNull(bibi.TEN_MIEN))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_MIEN_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_MIEN_Update", _
         GetNull(bibi.ID_MIEN), _
         GetNull(bibi.TEN_MIEN))
    End Sub

    Public Sub DeleteItem(ByVal ID_MIEN As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_MIEN_Delete", _
         GetNull(ID_MIEN))
    End Sub

    Public Function SelectItem(ByVal ID_MIEN As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_MIEN_Select", _
         GetNull(ID_MIEN))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_MIEN_SelectList")
    End Function

End Class
