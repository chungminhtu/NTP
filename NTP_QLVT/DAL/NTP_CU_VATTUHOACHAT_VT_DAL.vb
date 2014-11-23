Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_VATTUHOACHAT_VT_DAL
    Private Shared _thisInstance As NTP_CU_VATTUHOACHAT_VT_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_VATTUHOACHAT_VT_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_VATTUHOACHAT_VT_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_CU_VATTUHOACHAT_VT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
   "NTP_CU_VATTUHOACHAT_VT_Insert", _
   GetNull(bibi.ID_CHITIET), _
   GetNull(bibi.ID_BAOCAO), _
   GetNull(bibi.ID_VATTU), _
   GetNull(bibi.TD_TINH), _
   GetNull(bibi.TD_BVHUYENTINH), _
   GetNull(bibi.N_TW_CAP), _
   GetNull(bibi.N_TINH_CAP), _
   GetNull(bibi.X_TOANTINH), _
   GetNull(bibi.X_SUDUNG), _
   GetNull(bibi.THUA_TINH), _
   GetNull(bibi.THUA_HUYEN), _
   GetNull(bibi.THIEU_TINH), _
   GetNull(bibi.THIEU_HUYEN), _
   GetNull(bibi.TC_TINH), _
   GetNull(bibi.TC_HUYEN), _
   GetNull(bibi.ID_NGUONKINHPHI), _
   GetNull(bibi.ID_DONVI), _
   GetNull(bibi.TRA_LAI), _
   GetNull(bibi.HONG_TINH), _
   GetNull(bibi.DIEU_CHUYEN))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_CU_VATTUHOACHAT_VT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
   "NTP_CU_VATTUHOACHAT_VT_Update", _
   GetNull(bibi.ID_CHITIET), _
   GetNull(bibi.ID_BAOCAO), _
   GetNull(bibi.ID_VATTU), _
   GetNull(bibi.TD_TINH), _
   GetNull(bibi.TD_BVHUYENTINH), _
   GetNull(bibi.N_TW_CAP), _
   GetNull(bibi.N_TINH_CAP), _
   GetNull(bibi.X_TOANTINH), _
   GetNull(bibi.X_SUDUNG), _
   GetNull(bibi.THUA_TINH), _
   GetNull(bibi.THUA_HUYEN), _
   GetNull(bibi.THIEU_TINH), _
   GetNull(bibi.THIEU_HUYEN), _
   GetNull(bibi.TC_TINH), _
   GetNull(bibi.TC_HUYEN), _
   GetNull(bibi.ID_NGUONKINHPHI), _
   GetNull(bibi.ID_DONVI), _
   GetNull(bibi.TRA_LAI), _
   GetNull(bibi.HONG_TINH), _
   GetNull(bibi.DIEU_CHUYEN))
    End Sub

    Public Sub DeleteItem(ByVal ID_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
   "NTP_CU_VATTUHOACHAT_VT_Delete", ID_CHITIET _
    )
    End Sub

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
   "NTP_CU_VATTUHOACHAT_VT_SelectList")
    End Function

    Public Function SelectItem(ByVal ID_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_VT_Select", _
         GetNull(ID_CHITIET))
    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Integer, ByVal ID_NGUONKINHPHI As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_VT_Search", GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(ID_NGUONKINHPHI))
    End Function

End Class
