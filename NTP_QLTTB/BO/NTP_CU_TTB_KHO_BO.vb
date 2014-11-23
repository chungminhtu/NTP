Public Class NTP_CU_TTB_KHO_BO

    'Public Sub InsertItem(ByVal objData As NTP_CU_THUOC_KHO_Info)
    '       NTP_CU_THUOC_KHO_DAL.Instance.InsertItem(objData)
    '   End Sub

    'Public Sub UpdateItem(ByVal objData As NTP_CU_THUOC_KHO_Info)
    '       NTP_CU_THUOC_KHO_DAL.Instance.UpdateItem(objData)
    '   End Sub

    'Public Sub DeleteItem(ByVal ID_KY as double)
    '	NTP_CU_THUOC_KHO_DAL.Instance.DeleteItem(ID_KY)
    '   End Sub

    'Public Function SelectItem(ByVal ID_KY as double) as NTP_CU_THUOC_KHO_Info
    '       Dim ds As DataSet = NTP_CU_THUOC_KHO_DAL.Instance.SelectItem(ID_KY)
    '	Dim retVal As NTP_CU_THUOC_KHO_Info
    '	If ds.Tables(0).Rows.Count > 0 Then
    '		Dim row as DataRow = ds.Tables(0).Rows(0)
    '		retVal=New NTP_CU_THUOC_KHO_Info
    '		If not IsDBNull(row.Item("ID_KY")) Then retVal.ID_KY = row.Item("ID_KY")
    '		If not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
    '		If not IsDBNull(row.Item("THANG")) Then retVal.THANG = row.Item("THANG")
    '		If not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
    '		If not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
    '		If not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
    '		If not IsDBNull(row.Item("LO_SX")) Then retVal.LO_SX = row.Item("LO_SX")
    '		If not IsDBNull(row.Item("HAN_DUNG")) Then retVal.HAN_DUNG = row.Item("HAN_DUNG")
    '		If not IsDBNull(row.Item("TON_DAU")) Then retVal.TON_DAU = row.Item("TON_DAU")
    '		If not IsDBNull(row.Item("NHAP")) Then retVal.NHAP = row.Item("NHAP")
    '		If not IsDBNull(row.Item("XUAT")) Then retVal.XUAT = row.Item("XUAT")
    '		If not IsDBNull(row.Item("TON_CUOI")) Then retVal.TON_CUOI = row.Item("TON_CUOI")
    '		If not IsDBNull(row.Item("NGAY_KHOA_SO")) Then retVal.NGAY_KHOA_SO = row.Item("NGAY_KHOA_SO")
    '	End If
    '       Return retVal
    'End Function

    'Public Function SelectAllItems() as DataSet
    '       Return NTP_CU_THUOC_KHO_DAL.Instance.SelectAllItems()
    'End Function

    Public Sub TongHopSoLieu(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        NTP_CU_TTB_KHO_DAL.Instance.TongHopSoLieu(ID_KHO, thang, nam, UserID)
    End Sub

    Public Sub KhoaSo(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal UserID As Integer)
        NTP_CU_TTB_KHO_DAL.Instance.KhoaSo(ID_KHO, thang, nam, UserID)
    End Sub

    Public Function ListSolieu(ByVal ID_KHO As Integer, ByVal NAM As Integer) As DataSet
        Return NTP_CU_TTB_KHO_DAL.Instance.ListSolieu(ID_KHO, NAM)
    End Function

    Public Function BaoCao_TH_NhapXuat_Main(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer) As DataSet
        Return NTP_CU_TTB_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Main(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_thuoc)
    End Function

    Public Function BaoCao_TH_NhapXuat_Donvi(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer) As DataSet
        Return NTP_CU_TTB_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Donvi(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_thuoc)
    End Function

    Public Function BaoCao_TH_NhapXuat_Xuat(ByVal ID_KHO As Integer, ByVal ky As Integer, ByVal LoaiKy As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer) As DataSet
        Return NTP_CU_TTB_KHO_DAL.Instance.BaoCao_TH_NhapXuat_Xuat(ID_KHO, ky, LoaiKy, nam, id_nguonkp, id_thuoc)
    End Function

    'Public Function CheckLoSX(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thuoc As Integer, ByVal lo_sx As String, ByVal han_dung As Date) As Double
    '    Dim ds As New DataSet
    '    ds = NTP_CU_TTB_KHO_DAL.Instance.CheckLoSX(ID_KHO, thang, nam, id_nguonkp, id_thuoc, lo_sx, han_dung)
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        Return ds.Tables(0).Rows(0).Item(0)
    '    Else
    '        Return 0
    '    End If
    'End Function

    Public Function BaoCao_chitiet_nhapxuat(ByVal ID_KHO As Integer, ByVal thang As Integer, ByVal nam As Integer, ByVal id_nguonkp As Integer, ByVal id_thietbi As Integer) As DataSet
        Return NTP_CU_TTB_KHO_DAL.Instance.BaoCao_chitiet_nhapxuat(ID_KHO, thang, nam, id_nguonkp, id_thietbi)
    End Function
End Class
