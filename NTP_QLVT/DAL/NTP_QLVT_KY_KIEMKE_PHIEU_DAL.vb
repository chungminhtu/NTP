Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLVT_KY_KIEMKE_PHIEU_DAL
    Private Shared _thisInstance As NTP_QLVT_KY_KIEMKE_PHIEU_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_KY_KIEMKE_PHIEU_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_KY_KIEMKE_PHIEU_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_QLVT_KY_KIEMKE_PHIEU_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
   "NTP_QLVT_KY_KIEMKE_PHIEU_Insert", _
   Getnull(bibi.ID_KY_KIEMKE), _
   Getnull(bibi.ID_PHIEU), _
   Getnull(bibi.LOAI_PHIEU), _
   Getnull(bibi.NGAY_NM), _
   Getnull(bibi.NGUOI_NM))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_KY_KIEMKE_PHIEU_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_PHIEU_Update", _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.ID_PHIEU), _
         Getnull(bibi.LOAI_PHIEU), _
         Getnull(bibi.NGAY_NM), _
         Getnull(bibi.NGUOI_NM))
    End Sub

    Public Sub DeleteItem()
        '  SqlHelper.ExecuteNonQuery(SQLConnectionString, _
        '   "NTP_QLVT_KY_KIEMKE_PHIEU_Delete", _
        ')
    End Sub

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_PHIEU_SelectList")
    End Function

End Class
