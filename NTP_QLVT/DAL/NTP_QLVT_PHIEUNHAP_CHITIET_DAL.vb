Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLVT_PHIEUNHAP_CHITIET_DAL
    Private Shared _thisInstance As NTP_QLVT_PHIEUNHAP_CHITIET_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_PHIEUNHAP_CHITIET_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_PHIEUNHAP_CHITIET_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_QLVT_PHIEUNHAP_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_CHITIET_Insert", _
         Getnull(bibi.ID_PHIEUNHAP_CHITIET), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_VATTU), _
         Getnull(bibi.SO_LUONG), _
         Getnull(bibi.LO_SANXUAT), _
           Getnull(bibi.HAN_SUDUNG), _
            Getnull(bibi.MA_NUOC))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_PHIEUNHAP_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_CHITIET_Update", _
         Getnull(bibi.ID_PHIEUNHAP_CHITIET), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_VATTU), _
         Getnull(bibi.SO_LUONG), _
         Getnull(bibi.LO_SANXUAT), _
           Getnull(bibi.HAN_SUDUNG), _
            Getnull(bibi.MA_NUOC))
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_CHITIET_Delete", _
         Getnull(ID_PHIEUNHAP_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_CHITIET_Select", _
         Getnull(ID_PHIEUNHAP_CHITIET))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_CHITIET_SelectList")
    End Function

    Public Function Search(ByVal iID_PHIEUNHAP As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "NTP_QLVT_PHIEUNHAP_CHITIET_Search", iID_PHIEUNHAP)
    End Function
End Class
