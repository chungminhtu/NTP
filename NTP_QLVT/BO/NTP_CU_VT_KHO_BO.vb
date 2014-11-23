Public Class NTP_CU_VT_KHO_BO

    Public Sub TongHopSoLieu(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        NTP_CU_VT_KHO_DAL.Instance.TongHopSoLieu(ID_KHO, thang, nam, UserID)
    End Sub

    Public Sub KhoaSo(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        NTP_CU_VT_KHO_DAL.Instance.KhoaSo(ID_KHO, thang, nam, UserID)
    End Sub

    Public Function ListSolieu(ByVal ID_KHO As Integer, ByVal NAM As Integer) As DataSet
        Return NTP_CU_VT_KHO_DAL.Instance.ListSolieu(ID_KHO, NAM)
    End Function

    Public Function BaoCao_TH_NhapXuat_Main(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_vattu As Integer) As DataSet
        Return NTP_CU_VT_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Main(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_vattu)
    End Function

    Public Function BaoCao_TH_NhapXuat_Donvi(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_vattu As Integer) As DataSet
        Return NTP_CU_VT_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Donvi(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_vattu)
    End Function

    Public Function BaoCao_TH_NhapXuat_Xuat(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_vattu As Integer) As DataSet
        Return NTP_CU_VT_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Xuat(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_vattu)
    End Function

    Public Function BaoCao_chitiet_nhapxuat(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer) As DataSet
        Return NTP_CU_VT_KHO_DAL.Instance.BaoCao_chitiet_nhapxuat(ID_KHO, thang, nam, id_nguonkp, id_thuoc)
    End Function
End Class
