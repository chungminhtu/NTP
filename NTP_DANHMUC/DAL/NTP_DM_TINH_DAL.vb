Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_TINH_DAL
    Private Shared _thisInstance As NTP_DM_TINH_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_TINH_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_TINH_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_TINH_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_TINH_Insert", _
         Getnull(bibi.MA_TINH), _
         Getnull(bibi.TEN_TINH), _
         Getnull(bibi.ID_VUNG))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_TINH_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_TINH_Update", _
         Getnull(bibi.MA_TINH), _
         Getnull(bibi.TEN_TINH), _
         Getnull(bibi.ID_VUNG))
    End Sub

    Public Sub DeleteItem(ByVal MA_TINH As String)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_TINH_Delete", _
         Getnull(MA_TINH))
    End Sub

    Public Function SelectItem(ByVal MA_TINH As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_TINH_Select", _
         Getnull(MA_TINH))
    End Function

    Public Function SelectItemByIDMien(ByVal ID_MIEN As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_TINH_SelectByMaMien", _
         GetNull(ID_MIEN))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_TINH_SelectList")
    End Function

    Public Function Search(ByVal sTenTinh As String, ByVal iIDVung As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_TINH_Search", Getnull(sTenTinh), Getnull(iIDVung))
    End Function

    Public Function GetID() As String
        Return CType(SqlHelper.ExecuteScalar(SQLConnectionString, _
         "NTP_DM_TINH_GetID"), String)
    End Function
End Class
