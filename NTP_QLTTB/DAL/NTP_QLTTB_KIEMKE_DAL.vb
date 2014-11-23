Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLTTB_KIEMKE_DAL
    Private Shared _thisInstance As NTP_QLTTB_KIEMKE_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLTTB_KIEMKE_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLTTB_KIEMKE_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function


    Public Function InsertItem(ByVal bibi As NTP_QLTTB_KIEMKE_Info) As DataSet
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_KIEMKE_Insert", _
         GetNull(bibi.ID_KIEMKE), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.NGAY_KIEMKE), _
         GetNull(bibi.NGUOI_KIEMKE), _
         GetNull(bibi.ID_KY_KIEMKE), _
         GetNull(bibi.GHI_CHU), _
        GetNull(bibi.ID_NGUONKINHPHI), _
        GetNull(bibi.TRANG_THAI))

    End Function

    Public Sub UpdateItem(ByVal bibi As NTP_QLTTB_KIEMKE_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_KIEMKE_Update", _
         GetNull(bibi.ID_KIEMKE), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.NGAY_KIEMKE), _
         GetNull(bibi.NGUOI_KIEMKE), _
         GetNull(bibi.ID_KY_KIEMKE), _
         GetNull(bibi.GHI_CHU), _
         GetNull(bibi.ID_NGUONKINHPHI), _
        GetNull(bibi.TRANG_THAI))
    End Sub

    Public Sub DeleteItem(ByVal ID_KIEMKE As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_KIEMKE_Delete", _
         GetNull(ID_KIEMKE))
    End Sub

    Public Function SelectItem(ByVal ID_KIEMKE As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_KIEMKE_Select", _
         GetNull(ID_KIEMKE))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(sqlConnectionString, _
         "NTP_QLTTB_KIEMKE_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
      "NTP_QLTTB_KIEMKE_Search", GetNull(ID_KHO), GetNull(dtFromDate), GetNull(dtToDate), GetNull(iNguonKinhPhi))
    End Function
End Class
