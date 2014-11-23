Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_HANG_DAL
    
    Private Shared _thisInstance As NTP_DM_HANG_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_HANG_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_HANG_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_HANG_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_HANG_Insert", _
         Getnull(bibi.ID_HANG), _
         Getnull(bibi.MA_HANG), _
         Getnull(bibi.TEN_HANG))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_HANG_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_HANG_Update", _
         Getnull(bibi.ID_HANG), _
         Getnull(bibi.MA_HANG), _
         Getnull(bibi.TEN_HANG))
    End Sub

    Public Sub DeleteItem(ByVal ID_HANG As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_HANG_Delete", _
         Getnull(ID_HANG))
    End Sub

    Public Function SelectItem(ByVal ID_HANG As Integer) As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_HANG_Select", _
         Getnull(ID_HANG))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_HANG_SelectList")
    End Function

    Public Function Search(ByVal sTenHang As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_HANG_Search", Getnull(sTenHang))
    End Function
End Class
