Public Class NTP_CU_HC_KHO_BO

    Public Sub TongHopSoLieu(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        NTP_CU_HC_KHO_DAL.Instance.TongHopSoLieu(ID_KHO, thang, nam, UserID)
    End Sub

    Public Sub KhoaSo(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        NTP_CU_HC_KHO_DAL.Instance.KhoaSo(ID_KHO, thang, nam, UserID)
    End Sub

    Public Function ListSolieu(ByVal ID_KHO As Integer, ByVal NAM As Integer) As DataSet
        Return NTP_CU_HC_KHO_DAL.Instance.ListSolieu(ID_KHO, NAM)
    End Function

    Public Function BaoCao_TH_NhapXuat_Main(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer) As DataSet
        Return NTP_CU_HC_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Main(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_VATTU)
    End Function

    Public Function BaoCao_TH_NhapXuat_Donvi(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer) As DataSet
        Return NTP_CU_HC_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Donvi(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_VATTU)
    End Function

    Public Function BaoCao_TH_NhapXuat_Xuat(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer) As DataSet
        Return NTP_CU_HC_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Xuat(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_VATTU)
    End Function

    Public Function CheckLoSX(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_VATTU As Integer, ByVal lo_sx As String, ByVal han_dung As Date) As Double
        Dim ds As New DataSet
        ds = NTP_CU_HC_KHO_DAL.Instance.CheckLoSX(ID_KHO, thang, nam, id_nguonkp, id_VATTU, lo_sx, han_dung)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds.Tables(0).Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function BaoCao_chitiet_nhapxuat(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_vattu As Integer) As DataSet
        Return NTP_CU_HC_KHO_DAL.Instance.BaoCao_chitiet_nhapxuat(ID_KHO, thang, nam, id_nguonkp, id_vattu)
    End Function
End Class
