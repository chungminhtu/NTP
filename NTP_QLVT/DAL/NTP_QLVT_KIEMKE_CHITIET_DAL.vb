Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLVT_KIEMKE_CHITIET_DAL
    Private Shared _thisInstance As NTP_QLVT_KIEMKE_CHITIET_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_KIEMKE_CHITIET_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_KIEMKE_CHITIET_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function


    Public Sub InsertItem(ByVal bibi As NTP_QLVT_KIEMKE_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
           "NTP_QLVT_KIEMKE_CHITIET_Insert", _
           Getnull(bibi.ID_KIEMKE_CHITIET), _
           Getnull(bibi.ID_KIEMKE), _
           Getnull(bibi.ID_VATTU), _
           Getnull(bibi.ID_TRANGTHAI), _
           Getnull(bibi.SO_LUONG), _
           Getnull(bibi.LO_SANXUAT))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_KIEMKE_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
           "NTP_QLVT_KIEMKE_CHITIET_Update", _
           Getnull(bibi.ID_KIEMKE_CHITIET), _
           Getnull(bibi.ID_KIEMKE), _
           Getnull(bibi.ID_VATTU), _
           Getnull(bibi.ID_TRANGTHAI), _
           Getnull(bibi.SO_LUONG), _
           Getnull(bibi.LO_SANXUAT))
    End Sub

    Public Sub DeleteItem(ByVal ID_KIEMKE_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_KIEMKE_CHITIET_Delete", _
         Getnull(ID_KIEMKE_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_KIEMKE_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KIEMKE_CHITIET_Select", _
         Getnull(ID_KIEMKE_CHITIET))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
   "NTP_QLVT_KIEMKE_CHITIET_SelectList")
    End Function

    Public Function Search(ByVal iID_PHIEUKIEMKE As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "NTP_QLVT_KIEMKE_CHITIET_Search", iID_PHIEUKIEMKE)
    End Function
End Class
