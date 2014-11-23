Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_VUNG_DAL
    Private Shared _thisInstance As NTP_DM_VUNG_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_VUNG_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_VUNG_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_VUNG_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_VUNG_Insert", _
         Getnull(bibi.ID_VUNG), _
         Getnull(bibi.TEN_VUNG))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_VUNG_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_VUNG_Update", _
         Getnull(bibi.ID_VUNG), _
         Getnull(bibi.TEN_VUNG))
    End Sub

    Public Sub DeleteItem(ByVal ID_VUNG As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_VUNG_Delete", _
         Getnull(ID_VUNG))
    End Sub

    Public Function SelectItem(ByVal ID_VUNG As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_VUNG_Select", _
         Getnull(ID_VUNG))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_VUNG_SelectList")
    End Function

    Public Function GetIDMien(ByVal ID_VUNG As Integer) As Integer
        Return SqlHelper.ExecuteScalar(SQLConnectionString, _
         "NTP_DM_VUNG_GetIDMien", _
         GetNull(ID_VUNG))
    End Function

End Class
