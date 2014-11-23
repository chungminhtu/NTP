public class NTP_CU_THIETBI_CHITIET_BO

	Public Sub InsertItem(ByVal objData As NTP_CU_THIETBI_CHITIET_Info)
        NTP_CU_THIETBI_CHITIET_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_CU_THIETBI_CHITIET_Info)
		NTP_CU_THIETBI_CHITIET_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_CHITIET as double)
        NTP_CU_THIETBI_CHITIET_DAL.Instance.DeleteItem(ID_CHITIET)
    End Sub

	Public Function SelectItem(ByVal ID_CHITIET as double) as NTP_CU_THIETBI_CHITIET_Info
        Dim ds As DataSet = NTP_CU_THIETBI_CHITIET_DAL.Instance.SelectItem(ID_CHITIET)
		Dim retVal As NTP_CU_THIETBI_CHITIET_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_CU_THIETBI_CHITIET_Info
			If not IsDBNull(row.Item("ID_CHITIET")) Then retVal.ID_CHITIET = row.Item("ID_CHITIET")
			If not IsDBNull(row.Item("ID_BAOCAO")) Then retVal.ID_BAOCAO = row.Item("ID_BAOCAO")
			If not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
			If not IsDBNull(row.Item("TYPE")) Then retVal.TYPE = row.Item("TYPE")
			If not IsDBNull(row.Item("ID_THIETBI")) Then retVal.ID_THIETBI = row.Item("ID_THIETBI")
			If not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
			If not IsDBNull(row.Item("ID_MATINH")) Then retVal.ID_MATINH = row.Item("ID_MATINH")
			If not IsDBNull(row.Item("TD_SOLUONG")) Then retVal.TD_SOLUONG = row.Item("TD_SOLUONG")
			If not IsDBNull(row.Item("N_SOLUONG")) Then retVal.N_SOLUONG = row.Item("N_SOLUONG")
			If not IsDBNull(row.Item("N_NAM")) Then retVal.N_NAM = row.Item("N_NAM")
			If not IsDBNull(row.Item("XSD_TINH_SOLUONG")) Then retVal.XSD_TINH_SOLUONG = row.Item("XSD_TINH_SOLUONG")
			If not IsDBNull(row.Item("XSD_TINH_NAM")) Then retVal.XSD_TINH_NAM = row.Item("XSD_TINH_NAM")
			If not IsDBNull(row.Item("XSD_HUYEN_SOLUONG")) Then retVal.XSD_HUYEN_SOLUONG = row.Item("XSD_HUYEN_SOLUONG")
			If not IsDBNull(row.Item("XSD_HUYEN_NAM")) Then retVal.XSD_HUYEN_NAM = row.Item("XSD_HUYEN_NAM")
			If not IsDBNull(row.Item("HONG_TINH_SOLUONG")) Then retVal.HONG_TINH_SOLUONG = row.Item("HONG_TINH_SOLUONG")
			If not IsDBNull(row.Item("HONG_TINH_NAM")) Then retVal.HONG_TINH_NAM = row.Item("HONG_TINH_NAM")
			If not IsDBNull(row.Item("HONG_HUYEN_SOLUONG")) Then retVal.HONG_HUYEN_SOLUONG = row.Item("HONG_HUYEN_SOLUONG")
			If not IsDBNull(row.Item("HONG_HUYEN_NAM")) Then retVal.HONG_HUYEN_NAM = row.Item("HONG_HUYEN_NAM")
			If not IsDBNull(row.Item("CHO_THANHLY")) Then retVal.CHO_THANHLY = row.Item("CHO_THANHLY")
			If not IsDBNull(row.Item("DA_THANHLY")) Then retVal.DA_THANHLY = row.Item("DA_THANHLY")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
            If Not IsDBNull(row.Item("TC_SOLUONG")) Then retVal.TC_SOLUONG = row.Item("TC_SOLUONG")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_CU_THIETBI_CHITIET_DAL.Instance.SelectAllItems()
	End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Integer, ByVal ID_NGUONKINHPHI As Integer) As DataSet
        Return NTP_CU_THIETBI_CHITIET_DAL.Instance.Search(ID_KHO, ID_BAOCAO, ID_NGUONKINHPHI)
    End Function

End Class
