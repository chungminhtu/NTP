Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_THUOC_IMPORT_DAL
    Private Shared _thisInstance As NTP_CU_THUOC_IMPORT_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_THUOC_IMPORT_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_THUOC_IMPORT_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_CU_THUOC_IMPORT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THUOC_IMPORT_Insert", _
         GetNull(bibi.ID_IMPORT), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.NGAY_NHAP_KHO), _
         GetNull(bibi.LO_SX), _
         GetNull(bibi.HAN_DUNG), _
         GetNull(bibi.SO_LUONG), _
         GetNull(bibi.NGAY_NM), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.MA_PHIEU), _
         GetNull(bibi.NGAY_SX), _
         GetNull(bibi.NGUOI_VIETPHIEU), GetNull(bibi.LOAI_NHAP))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_CU_THUOC_IMPORT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THUOC_IMPORT_Update", _
         GetNull(bibi.ID_IMPORT), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.NGAY_NHAP_KHO), _
         GetNull(bibi.LO_SX), _
         GetNull(bibi.HAN_DUNG), _
         GetNull(bibi.SO_LUONG), _
         GetNull(bibi.NGAY_NM), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.MA_PHIEU), _
         GetNull(bibi.NGAY_SX), _
         GetNull(bibi.NGUOI_VIETPHIEU), GetNull(bibi.LOAI_NHAP))
    End Sub

    Public Sub DeleteItem(ByVal ID_IMPORT As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THUOC_IMPORT_Delete", _
         GetNull(ID_IMPORT))
    End Sub

    Public Function SelectItem(ByVal ID_IMPORT As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THUOC_IMPORT_Select", _
         GetNull(ID_IMPORT))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THUOC_IMPORT_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THUOC_IMPORT_Search", ID_KHO, GetNull(sMA_PHIEU), GetNull(dtFromDate), GetNull(dtToDate), GetNull(iNguonKinhPhi))
    End Function
End Class
