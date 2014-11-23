Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_HC_EXPORT_DAL
    Private Shared _thisInstance As NTP_CU_HC_EXPORT_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_HC_EXPORT_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_HC_EXPORT_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_CU_HC_EXPORT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_HC_EXPORT_Insert", _
         GetNull(bibi.ID_EXPORT), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.ID_VATTU), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.ID_KHO_NHAN), _
         GetNull(bibi.NGAY_XUAT_KHO), _
         GetNull(bibi.LOAI_XUAT), _
         GetNull(bibi.LO_SX), _
         GetNull(bibi.HAN_DUNG), _
         GetNull(bibi.SO_LUONG), _
         GetNull(bibi.NGAY_NM), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.MA_PHIEU), _
         GetNull(bibi.NGUOI_VIETPHIEU))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_CU_HC_EXPORT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_HC_EXPORT_Update", _
         GetNull(bibi.ID_EXPORT), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.ID_VATTU), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.ID_KHO_NHAN), _
         GetNull(bibi.NGAY_XUAT_KHO), _
         GetNull(bibi.LOAI_XUAT), _
         GetNull(bibi.LO_SX), _
         GetNull(bibi.HAN_DUNG), _
         GetNull(bibi.SO_LUONG), _
         GetNull(bibi.NGAY_NM), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.MA_PHIEU), _
         GetNull(bibi.NGUOI_VIETPHIEU))
    End Sub

    Public Sub DeleteItem(ByVal ID_EXPORT As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_HC_EXPORT_Delete", _
         GetNull(ID_EXPORT))
    End Sub

    Public Function SelectItem(ByVal ID_EXPORT As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_HC_EXPORT_Select", _
         GetNull(ID_EXPORT))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_HC_EXPORT_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer, ByVal ID_LYDONHAPXUAT As Integer, ByVal ID_DONVI_NHAN As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "NTP_CU_HC_EXPORT_Search", GetNull(ID_KHO), GetNull(sMA_PHIEU), GetNull(dtFromDate), GetNull(dtToDate), GetNull(iNguonKinhPhi), GetNull(ID_LYDONHAPXUAT), GetNull(ID_DONVI_NHAN))
    End Function
End Class
