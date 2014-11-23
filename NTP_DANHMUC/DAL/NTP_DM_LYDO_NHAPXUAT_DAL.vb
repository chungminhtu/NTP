Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_LYDO_NHAPXUAT_DAL

    Private Shared _thisInstance As NTP_DM_LYDO_NHAPXUAT_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_LYDO_NHAPXUAT_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_LYDO_NHAPXUAT_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_LYDO_NHAPXUAT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_LYDO_NHAPXUAT_Insert", _
         Getnull(bibi.ID), _
         Getnull(bibi.MO_TA), _
         Getnull(bibi.TYPE))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_LYDO_NHAPXUAT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_LYDO_NHAPXUAT_Update", _
         Getnull(bibi.ID), _
         Getnull(bibi.MO_TA), _
         Getnull(bibi.TYPE))
    End Sub

    Public Sub DeleteItem(ByVal ID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_LYDO_NHAPXUAT_Delete", _
         ID)
    End Sub

    Public Function SelectItem(ByVal ID As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_LYDO_NHAPXUAT_Select", _
         ID)
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_LYDO_NHAPXUAT_SelectList")
    End Function

    Public Function Search(ByVal sType As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "NTP_DM_LYDO_NHAPXUAT_Search", Getnull(sType))
    End Function


End Class
