Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL
Public Class NTP_QLVT_DM_KHO_DAL

    Private Shared _thisInstance As NTP_QLVT_DM_KHO_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_DM_KHO_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_DM_KHO_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function


    Public Sub InsertItem(ByVal bibi As NTP_QLVT_DM_KHO_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_KHO_Insert", _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.MA_KHO), _
         Getnull(bibi.TEN_KHO), _
         Getnull(bibi.ID_VUNG), _
         Getnull(bibi.ID_KHO_CAPTREN), _
         Getnull(bibi.DIA_CHI), _
        Getnull(bibi.MA_HUYEN), _
          Getnull(bibi.MA_TINH))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_DM_KHO_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_KHO_Update", _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.MA_KHO), _
         Getnull(bibi.TEN_KHO), _
         Getnull(bibi.ID_VUNG), _
         Getnull(bibi.ID_KHO_CAPTREN), _
         Getnull(bibi.DIA_CHI), _
          Getnull(bibi.MA_HUYEN), _
          Getnull(bibi.MA_TINH))
    End Sub

    Public Sub DeleteItem(ByVal ID_KHO As Int64)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_DM_KHO_Delete", _
        ID_KHO)
    End Sub

    Public Function SelectItem(ByVal ID_KHO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_KHO_Select", _
         ID_KHO)
    End Function

    Public Function SelectItemByMa(ByVal MA_KHO As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_KHO_SelectbyMa", _
         MA_KHO)
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_KHO_SelectList")
    End Function

    Public Function Search(ByVal sTEN_KHO As String, ByVal sMA_TINH As String, ByVal sMA_HUYEN As String, ByVal iID_KHO_CAPTREN As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_DM_KHO_Search", Getnull(sTEN_KHO), Getnull(sMA_TINH), Getnull(sMA_HUYEN), Getnull(iID_KHO_CAPTREN))
    End Function

End Class
