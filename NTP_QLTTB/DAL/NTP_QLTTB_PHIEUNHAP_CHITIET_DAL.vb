Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL
Public Class NTP_QLTTB_PHIEUNHAP_CHITIET_DAL

    Private Shared _thisInstance As NTP_QLTTB_PHIEUNHAP_CHITIET_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLTTB_PHIEUNHAP_CHITIET_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLTTB_PHIEUNHAP_CHITIET_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    ''' <summary>
    ''' Insert into NTP_QLTTB_PHIEUNHAP_CHITIET
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub InsertItem(ByVal bibi As NTP_QLTTB_PHIEUNHAP_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_CHITIET_Insert", _
         Getnull(bibi.ID_PHIEUNHAP_CHITIET), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_THIETBI), _
         Getnull(bibi.SO_LUONG))
    End Sub

    ''' <summary>
    ''' Update NTP_QLTTB_PHIEUNHAP_CHITIET
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub UpdateItem(ByVal bibi As NTP_QLTTB_PHIEUNHAP_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_CHITIET_Update", _
         Getnull(bibi.ID_PHIEUNHAP_CHITIET), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_THIETBI), _
         Getnull(bibi.SO_LUONG))
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP_CHITIET As Int64)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_CHITIET_Delete", _
      Getnull(ID_PHIEUNHAP_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP_CHITIET As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_CHITIET_Select", _
         Getnull(ID_PHIEUNHAP_CHITIET))
    End Function

    Public Function SelectItemById(ByVal ID_PHIEUNHAP As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
           "NTP_QLTTB_PHIEUNHAP_CHITIET_SelectById", _
           Getnull(ID_PHIEUNHAP))
    End Function
    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_CHITIET_SelectList")
    End Function

End Class
