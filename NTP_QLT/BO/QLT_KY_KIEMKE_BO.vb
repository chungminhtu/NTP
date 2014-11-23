Public Class QLT_KY_KIEMKE_BO

    Public Function GetKyDaKiemKe(ByVal ID_KHO As Integer, ByVal Nam As Integer) As Integer

        Return (New QLT_KY_KIEMKE_DAL).GetKyDaKiemKe(ID_KHO, Nam)

    End Function

    Public Sub InsertItem(ByVal objData As QLT_KY_KIEMKE_Info)
        Dim bibi As New QLT_KY_KIEMKE_DAL
        bibi.InsertItem(objData)
        bibi = Nothing
    End Sub

    Public Function CheckDaKiemKe(ByVal id_kho As Integer, ByVal nam As Integer, ByVal thang As Integer) As Int16
        Return (New QLT_KY_KIEMKE_DAL).CheckDaKiemKe(id_kho, nam, thang)
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal Nam As Int16) As DataSet
        Return QLT_KY_KIEMKE_DAL.Instance.Search(ID_KHO, Nam)
    End Function

    Public Function BaoCaoKiemKe(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return QLT_KY_KIEMKE_DAL.Instance.BaoCaoKiemKe(ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoNhapXuat(ByVal thang As Integer, ByVal Nam As Integer, ByVal ID_KHO As Integer) As DataSet
        Return QLT_KY_KIEMKE_DAL.Instance.BaoCaoNhapXuat(thang, Nam, ID_KHO)
    End Function

    Public Function BaoCaoSuDungThuoc(ByVal thang As Integer, ByVal Nam As Integer, ByVal ID_KHO As Integer) As DataSet
        Return QLT_KY_KIEMKE_DAL.Instance.BaoCaoSuDungThuoc(thang, Nam, ID_KHO)
    End Function

    Public Function BaoCaoSuDungThuoc_Sub(ByVal thang As Integer, ByVal Nam As Integer, ByVal ID_KHO As Integer) As DataSet
        Return QLT_KY_KIEMKE_DAL.Instance.BaoCaoSuDungThuoc_Sub(thang, Nam, ID_KHO)
    End Function
    Public Function BaoCaoSuDungThuoc_TuyenHuyen(ByVal Quy As Integer, ByVal Nam As Integer, ByVal ID_KHO As Integer) As DataSet
        Return QLT_KY_KIEMKE_DAL.Instance.BaoCaoSuDungThuoc_TuyenHuyen(Quy, Nam, ID_KHO)
    End Function
    Public Sub KetChuyenSoLieu(ByVal Thang As Integer, ByVal Nam As Integer, ByVal ID_Kho As Integer)
        Dim bibi As New QLT_KY_KIEMKE_DAL
        bibi.KetChuyenSoLieu(Thang, Nam, ID_Kho)
        ' bibi.InsertItem()
        bibi = Nothing
    End Sub
End Class
