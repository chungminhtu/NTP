Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_TTB_KHO_DAL
    Private Shared _thisInstance As NTP_CU_TTB_KHO_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_TTB_KHO_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_TTB_KHO_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    'Public Sub InsertItem(ByVal bibi As NTP_CU_THUOC_KHO_Info)
    '    SqlHelper.ExecuteNonQuery(SQLConnectionString, _
    '     "NTP_CU_THUOC_KHO_Insert", _
    '     GetNull(bibi.ID_KY), _
    '     GetNull(bibi.ID_KHO), _
    '     GetNull(bibi.THANG), _
    '     GetNull(bibi.NAM), _
    '     GetNull(bibi.ID_THUOC), _
    '     GetNull(bibi.ID_NGUONKINHPHI), _
    '     GetNull(bibi.LO_SX), _
    '     GetNull(bibi.HAN_DUNG), _
    '     GetNull(bibi.TON_DAU), _
    '     GetNull(bibi.NHAP), _
    '     GetNull(bibi.XUAT), _
    '     GetNull(bibi.TON_CUOI), _
    '     GetNull(bibi.NGAY_KHOA_SO))
    'End Sub

    'Public Sub UpdateItem(ByVal bibi As NTP_CU_THUOC_KHO_Info)
    '    SqlHelper.ExecuteNonQuery(SQLConnectionString, _
    '     "NTP_CU_THUOC_KHO_Update", _
    '     GetNull(bibi.ID_KY), _
    '     GetNull(bibi.ID_KHO), _
    '     GetNull(bibi.THANG), _
    '     GetNull(bibi.NAM), _
    '     GetNull(bibi.ID_THUOC), _
    '     GetNull(bibi.ID_NGUONKINHPHI), _
    '     GetNull(bibi.LO_SX), _
    '     GetNull(bibi.HAN_DUNG), _
    '     GetNull(bibi.TON_DAU), _
    '     GetNull(bibi.NHAP), _
    '     GetNull(bibi.XUAT), _
    '     GetNull(bibi.TON_CUOI), _
    '     GetNull(bibi.NGAY_KHOA_SO))
    'End Sub

    'Public Sub DeleteItem(ByVal ID_KY As Double)
    '    SqlHelper.ExecuteNonQuery(SQLConnectionString, _
    '     "NTP_CU_THUOC_KHO_Delete", _
    '     GetNull(ID_KY))
    'End Sub

    'Public Function SelectItem(ByVal ID_KY As Double) As DataSet
    '    Return SqlHelper.ExecuteDataset(SQLConnectionString, _
    '     "NTP_CU_THUOC_KHO_Select", _
    '     GetNull(ID_KY))
    'End Function

    'Public Function SelectAllItems() As DataSet
    '    Return SqlHelper.ExecuteDataset(SQLConnectionString, _
    '     "NTP_CU_THUOC_KHO_SelectList")
    'End Function

    Public Sub TongHopSoLieu(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
        "ntp_cu_ttb_tonghop_nx", _
        GetNull(ID_KHO), thang, nam, UserID)
    End Sub

    Public Sub KhoaSo(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
        "ntp_cu_ttb_khoaso", _
        GetNull(ID_KHO), thang, nam, UserID)
    End Sub

    Public Function ListSolieu(ByVal ID_KHO As Integer, ByVal NAM As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "ntp_cu_ttb_listsolieu", _
         GetNull(ID_KHO), GetNull(NAM))
    End Function


    Public Function BaoCao_TH_NhapXuat_Main(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_ttb_bc_th_nhapxuat_main", _
        ID_KHO, ky, LoaiKy, nam, GetNull(id_nguonkp), GetNull(id_thuoc))
    End Function

    Public Function BaoCao_TH_NhapXuat_Donvi(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_ttb_bc_th_nhapxuat_donvi", _
        ID_KHO, ky, LoaiKy, nam, GetNull(id_nguonkp), GetNull(id_thuoc))
    End Function

    Public Function BaoCao_TH_NhapXuat_Xuat(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_ttb_bc_th_nhapxuat_xuat", _
        ID_KHO, ky, LoaiKy, nam, GetNull(id_nguonkp), GetNull(id_thuoc))
    End Function

    'Public Function CheckLoSX(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer, ByVal lo_sx As String, ByVal han_dung As Date) As DataSet
    '    Return SqlHelper.ExecuteDataset(SQLConnectionString, _
    '    "ntp_cu_thuoc_kiemtralosx", _
    '    ID_KHO, thang, nam, id_nguonkp, id_thuoc, lo_sx, han_dung)
    'End Function
    Public Function BaoCao_chitiet_nhapxuat(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thietbi As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "ntp_cu_ttb_bc_chitiet_nx", _
        ID_KHO, thang, nam, GetNull(id_nguonkp), GetNull(id_thietbi))
    End Function
End Class
