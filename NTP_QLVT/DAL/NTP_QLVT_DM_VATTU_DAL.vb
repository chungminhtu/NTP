Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLVT_DM_VATTU_DAL

    Private Shared _thisInstance As NTP_QLVT_DM_VATTU_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_DM_VATTU_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_DM_VATTU_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_QLVT_DM_VATTU_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_VATTU_Insert", _
             GetNull(bibi.ID_VATTU), _
             GetNull(bibi.TEN_VATTU), _
             GetNull(bibi.ID_DVT), _
            GetNull(bibi.TYPE_HCVT), _
            GetNull(bibi.MA_NUOC))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_DM_VATTU_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_VATTU_Update", _
         GetNull(bibi.ID_VATTU), _
         GetNull(bibi.TEN_VATTU), _
         GetNull(bibi.ID_DVT), _
            GetNull(bibi.TYPE_HCVT), _
            GetNull(bibi.MA_NUOC))
    End Sub

    Public Sub DeleteItem(ByVal ID_VATTU As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_VATTU_Delete", _
         Getnull(ID_VATTU))
    End Sub

    Public Function SelectItem(ByVal ID_VATTU As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_VATTU_Select", _
         Getnull(ID_VATTU))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_VATTU_SelectList")
    End Function

    Public Function SelectAllItems(ByVal iType As NTP_Common.enuTYPE_VATTU_HOACHAT) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_VATTU_SelectListByType", iType)
    End Function

    Public Function Search(ByVal sTEN_VATTU As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
          "NTP_QLVT_DM_VATTU_Search", Getnull(sTEN_VATTU))
    End Function
End Class
