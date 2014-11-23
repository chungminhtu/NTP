Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL
Public Class NTP_QLTTB_DM_KHO_DAL

    Private Shared _thisInstance As NTP_QLTTB_DM_KHO_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLTTB_DM_KHO_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLTTB_DM_KHO_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    ''' <summary>
    ''' Insert into NTP_QLTTB_DM_KHO
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub InsertItem(ByVal bibi As NTP_QLTTB_DM_KHO_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_DM_KHO_Insert", _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.MA_KHO), _
         Getnull(bibi.TEN_KHO), _
         Getnull(bibi.ID_VUNG), _
         Getnull(bibi.ID_KHO_CAPTREN), _
         Getnull(bibi.DIA_CHI), _
        Getnull(bibi.MA_HUYEN), _
          Getnull(bibi.MA_TINH))
    End Sub

    ''' <summary>
    ''' Update NTP_QLTTB_DM_KHO
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub UpdateItem(ByVal bibi As NTP_QLTTB_DM_KHO_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_DM_KHO_Update", _
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
         "NTP_QLTTB_DM_KHO_Delete", _
      Getnull(ID_KHO))
    End Sub

    Public Function SelectItem(ByVal ID_KHO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_DM_KHO_Select", _
         Getnull(ID_KHO))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_DM_KHO_SelectList")
    End Function

    ''' <summary>
    ''' Search thong tin theo keysearch: TEN_KHO, TINH, HUYEN, KHO_CAPTREN
    ''' </summary>
    ''' <param name="sTEN_KHO"></param>
    ''' <param name="sMA_TINH"></param>
    ''' <param name="sMA_HUYEN"></param>
    ''' <param name="iID_KHO_CAPTREN"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Search(ByVal sTEN_KHO As String, ByVal sMA_TINH As String, ByVal sMA_HUYEN As String, ByVal iID_KHO_CAPTREN As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_DM_KHO_Search", Getnull(sTEN_KHO), Getnull(sMA_TINH), Getnull(sMA_HUYEN), Getnull(iID_KHO_CAPTREN))
    End Function

End Class
