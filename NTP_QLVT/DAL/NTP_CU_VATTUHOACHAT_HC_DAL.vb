Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_VATTUHOACHAT_HC_DAL
    Private Shared _thisInstance As NTP_CU_VATTUHOACHAT_HC_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_VATTUHOACHAT_HC_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_VATTUHOACHAT_HC_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_CU_VATTUHOACHAT_HC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_HC_Insert", _
         GetNull(bibi.ID_CHITIET), _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.ID_VATTU), _
         GetNull(bibi.TON_DAU), _
         GetNull(bibi.NHAP), _
         GetNull(bibi.XUAT), _
         GetNull(bibi.THUA), _
         GetNull(bibi.THIEU_HONG), _
         GetNull(bibi.TON_CUOI), _
         GetNull(bibi.HAN_SUDUNG), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.NGAY_NM), _
         GetNull(bibi.GHI_CHU), _
         GetNull(bibi.ID_NGUONKINHPHI), GetNull(bibi.LO_SX))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_CU_VATTUHOACHAT_HC_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_HC_Update", _
         GetNull(bibi.ID_CHITIET), _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.ID_VATTU), _
         GetNull(bibi.TON_DAU), _
         GetNull(bibi.NHAP), _
         GetNull(bibi.XUAT), _
         GetNull(bibi.THUA), _
         GetNull(bibi.THIEU_HONG), _
         GetNull(bibi.TON_CUOI), _
         GetNull(bibi.HAN_SUDUNG), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.NGAY_NM), _
         GetNull(bibi.GHI_CHU), _
         GetNull(bibi.ID_NGUONKINHPHI), GetNull(bibi.LO_SX))
    End Sub

    Public Sub DeleteItem(ByVal ID_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_HC_Delete", _
         GetNull(ID_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_HC_Select", _
         GetNull(ID_CHITIET))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_HC_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Integer, ByVal ID_NGUONKINHPHI As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_HC_Search", GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(ID_NGUONKINHPHI))
    End Function

End Class
