Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_SUDUNGTHUOC_CHITIET_DAL
    Private Shared _thisInstance As NTP_CU_SUDUNGTHUOC_CHITIET_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_SUDUNGTHUOC_CHITIET_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_SUDUNGTHUOC_CHITIET_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_CU_SUDUNGTHUOC_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_CHITIET_Insert", _
         GetNull(bibi.ID_CHITIET), _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.TYPE), _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.ID_MATINH), _
         GetNull(bibi.TD_SOLUONG), _
         GetNull(bibi.TD_HANDUNG), _
         GetNull(bibi.TD_LOSX), _
         GetNull(bibi.N_SOLUONG), _
         GetNull(bibi.N_LOSX), _
         GetNull(bibi.N_HANDUNG), _
         GetNull(bibi.TRA_LAI), _
         GetNull(bibi.THUA), _
         GetNull(bibi.X_SUDUNG_TOANTINH), _
         GetNull(bibi.X_TINH_THIEU), _
         GetNull(bibi.X_TINH_HONG_VO), _
         GetNull(bibi.X_HUYEN_HONGVO), _
         GetNull(bibi.X_HUYEN_DIEUCHUYEN), _
         GetNull(bibi.TC_SOLUONG), _
         GetNull(bibi.TC_LOSX), _
         GetNull(bibi.TC_HANDUNG), _
         GetNull(bibi.GHI_CHU))

    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_CU_SUDUNGTHUOC_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_CHITIET_Update", _
         GetNull(bibi.ID_CHITIET), _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.TYPE), _
         GetNull(bibi.ID_THUOC), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.ID_MATINH), _
         GetNull(bibi.TD_SOLUONG), _
         GetNull(bibi.TD_HANDUNG), _
         GetNull(bibi.TD_LOSX), _
         GetNull(bibi.N_SOLUONG), _
         GetNull(bibi.N_LOSX), _
         GetNull(bibi.N_HANDUNG), _
         GetNull(bibi.TRA_LAI), _
         GetNull(bibi.THUA), _
         GetNull(bibi.X_SUDUNG_TOANTINH), _
         GetNull(bibi.X_TINH_THIEU), _
         GetNull(bibi.X_TINH_HONG_VO), _
         GetNull(bibi.X_HUYEN_HONGVO), _
         GetNull(bibi.X_HUYEN_DIEUCHUYEN), _
         GetNull(bibi.TC_SOLUONG), _
         GetNull(bibi.TC_LOSX), _
         GetNull(bibi.TC_HANDUNG), _
         GetNull(bibi.GHI_CHU))
    End Sub

    Public Sub DeleteItem(ByVal ID_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_CHITIET_Delete", _
         GetNull(ID_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_CHITIET_Select", _
         GetNull(ID_CHITIET))

    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_CHITIET_SelectList")

    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Integer, ByVal ID_THUOC As Integer, ByVal id_nguonkinhphi As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_CHITIET_Search", GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(ID_THUOC), GetNull(id_nguonkinhphi))

    End Function
End Class
