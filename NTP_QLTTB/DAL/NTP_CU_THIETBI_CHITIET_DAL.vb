Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_THIETBI_CHITIET_DAL
    Private Shared _thisInstance As NTP_CU_THIETBI_CHITIET_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_THIETBI_CHITIET_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_THIETBI_CHITIET_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_CU_THIETBI_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THIETBI_CHITIET_Insert", _
         GetNull(bibi.ID_CHITIET), _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.TYPE), _
         GetNull(bibi.ID_THIETBI), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.ID_MATINH), _
         GetNull(bibi.TD_SOLUONG), _
         GetNull(bibi.N_SOLUONG), _
         GetNull(bibi.N_NAM), _
         GetNull(bibi.XSD_TINH_SOLUONG), _
         GetNull(bibi.XSD_TINH_NAM), _
         GetNull(bibi.XSD_HUYEN_SOLUONG), _
         GetNull(bibi.XSD_HUYEN_NAM), _
         GetNull(bibi.HONG_TINH_SOLUONG), _
         GetNull(bibi.HONG_TINH_NAM), _
         GetNull(bibi.HONG_HUYEN_SOLUONG), _
         GetNull(bibi.HONG_HUYEN_NAM), _
         GetNull(bibi.CHO_THANHLY), _
         GetNull(bibi.DA_THANHLY), _
         GetNull(bibi.GHI_CHU), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.TC_SOLUONG))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_CU_THIETBI_CHITIET_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THIETBI_CHITIET_Update", _
         GetNull(bibi.ID_CHITIET), _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.ID_KHO), _
         GetNull(bibi.TYPE), _
         GetNull(bibi.ID_THIETBI), _
         GetNull(bibi.ID_NGUONKINHPHI), _
         GetNull(bibi.ID_MATINH), _
         GetNull(bibi.TD_SOLUONG), _
         GetNull(bibi.N_SOLUONG), _
         GetNull(bibi.N_NAM), _
         GetNull(bibi.XSD_TINH_SOLUONG), _
         GetNull(bibi.XSD_TINH_NAM), _
         GetNull(bibi.XSD_HUYEN_SOLUONG), _
         GetNull(bibi.XSD_HUYEN_NAM), _
         GetNull(bibi.HONG_TINH_SOLUONG), _
         GetNull(bibi.HONG_TINH_NAM), _
         GetNull(bibi.HONG_HUYEN_SOLUONG), _
         GetNull(bibi.HONG_HUYEN_NAM), _
         GetNull(bibi.CHO_THANHLY), _
         GetNull(bibi.DA_THANHLY), _
         GetNull(bibi.GHI_CHU), _
         GetNull(bibi.NGUOI_NM), _
         GetNull(bibi.TC_SOLUONG))
    End Sub

    Public Sub DeleteItem(ByVal ID_CHITIET As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THIETBI_CHITIET_Delete", _
         GetNull(ID_CHITIET))
    End Sub

    Public Function SelectItem(ByVal ID_CHITIET As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THIETBI_CHITIET_Select", _
         GetNull(ID_CHITIET))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THIETBI_CHITIET_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Integer, ByVal ID_NGUONKINHPHI As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THIETBI_CHITIET_Search", GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(ID_NGUONKINHPHI))
    End Function

End Class
