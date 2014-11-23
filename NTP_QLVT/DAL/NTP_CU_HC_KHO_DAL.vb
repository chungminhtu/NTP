Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_HC_KHO_DAL
    Private Shared _thisInstance As NTP_CU_HC_KHO_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_HC_KHO_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_HC_KHO_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub TongHopSoLieu(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
        "ntp_cu_HC_tonghop_nx", _
        GetNull(ID_KHO), thang, nam, UserID)
    End Sub

    Public Sub KhoaSo(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
        "ntp_cu_HC_khoaso", _
        GetNull(ID_KHO), thang, nam, UserID)
    End Sub

    Public Function ListSolieu(ByVal ID_KHO As Integer, ByVal NAM As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "ntp_cu_HC_listsolieu", _
         GetNull(ID_KHO), GetNull(NAM))
    End Function


    Public Function BaoCao_TH_NhapXuat_Main(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_HC_bc_th_nhapxuat_main", _
        ID_KHO, ky, LoaiKy, nam, GetNull(id_nguonkp), GetNull(id_VATTU))
    End Function

    Public Function BaoCao_TH_NhapXuat_Donvi(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_HC_bc_th_nhapxuat_donvi", _
        ID_KHO, ky, LoaiKy, nam, GetNull(id_nguonkp), GetNull(id_VATTU))
    End Function

    Public Function BaoCao_TH_NhapXuat_Xuat(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_HC_bc_th_nhapxuat_xuat", _
        ID_KHO, ky, LoaiKy, nam, GetNull(id_nguonkp), GetNull(id_VATTU))
    End Function

    Public Function CheckLoSX(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer, ByVal lo_sx As String, ByVal han_dung As Date) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_HC_kiemtralosx", _
        ID_KHO, thang, nam, id_nguonkp, id_VATTU, lo_sx, han_dung)
    End Function

    Public Function BaoCao_chitiet_nhapxuat(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_vattu As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_hc_bc_chitiet_nx", _
        ID_KHO, thang, nam, GetNull(id_nguonkp), GetNull(id_vattu))
    End Function
End Class
