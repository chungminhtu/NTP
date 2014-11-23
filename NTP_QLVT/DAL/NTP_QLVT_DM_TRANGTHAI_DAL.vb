Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL
Public Class NTP_QLVT_DM_TRANGTHAI_DAL

    Private Shared _thisInstance As NTP_QLVT_DM_TRANGTHAI_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_DM_TRANGTHAI_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_DM_TRANGTHAI_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_QLVT_DM_TRANGTHAI_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_TRANGTHAI_Insert", _
         Getnull(bibi.ID_TRANGTHAI), _
         Getnull(bibi.TEN_TRANGTHAI))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_DM_TRANGTHAI_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_TRANGTHAI_Update", _
         Getnull(bibi.ID_TRANGTHAI), _
         Getnull(bibi.TEN_TRANGTHAI))
    End Sub

    Public Sub DeleteItem(ByVal ID_TRANGTHAI As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_TRANGTHAI_Delete", _
         Getnull(ID_TRANGTHAI))
    End Sub

    Public Function SelectItem(ByVal ID_TRANGTHAI As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_TRANGTHAI_Select", _
         Getnull(ID_TRANGTHAI))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_TRANGTHAI_SelectList")
    End Function

End Class
