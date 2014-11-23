Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL
Public Class NTP_QLTTB_DM_THIETBI_DAL

    Private Shared _thisInstance As NTP_QLTTB_DM_THIETBI_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLTTB_DM_THIETBI_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLTTB_DM_THIETBI_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    ''' <summary>
    ''' Insert into NTP_QLTTB_DM_THIETBI
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub InsertItem(ByVal bibi As NTP_QLTTB_DM_THIETBI_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_DM_THIETBI_Insert", _
         GetNull(bibi.ID_THIETBI), _
         GetNull(bibi.TEN_THIETBI), _
         GetNull(bibi.ID_DVT), _
         GetNull(bibi.MA_NUOC), _
         GetNull(bibi.NHAN_HIEU))
    End Sub

    ''' <summary>
    ''' Update NTP_QLTTB_DM_THIETBI
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub UpdateItem(ByVal bibi As NTP_QLTTB_DM_THIETBI_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_DM_THIETBI_Update", _
          GetNull(bibi.ID_THIETBI), _
         GetNull(bibi.TEN_THIETBI), _
         GetNull(bibi.ID_DVT), _
         GetNull(bibi.MA_NUOC), _
         GetNull(bibi.NHAN_HIEU))
    End Sub

    Public Sub DeleteItem(ByVal ID_THIETBI As Int32)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_DM_THIETBI_Delete", _
        GetNull(ID_THIETBI))

    End Sub

    Public Function SelectItem(ByVal ID_THIETBI As Int32) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_DM_THIETBI_Select", _
       GetNull(ID_THIETBI))

    End Function


    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_DM_THIETBI_SelectList")
    End Function

    ''' <summary>
    ''' Search thong tin  theo keysearch: TEN_THIETBI
    ''' </summary>
    ''' <param name="sTEN_THIETBI"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Search(ByVal sTEN_THIETBI As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_DM_THIETBI_Search", GetNull(sTEN_THIETBI))

    End Function

End Class
