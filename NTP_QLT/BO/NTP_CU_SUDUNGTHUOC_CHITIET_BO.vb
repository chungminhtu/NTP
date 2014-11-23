public class NTP_CU_SUDUNGTHUOC_CHITIET_BO

	Public Sub InsertItem(ByVal objData As NTP_CU_SUDUNGTHUOC_CHITIET_Info)

        NTP_CU_SUDUNGTHUOC_CHITIET_DAL.Instance.InsertItem(objData)

	End Sub

	Public Sub UpdateItem(ByVal objData As NTP_CU_SUDUNGTHUOC_CHITIET_Info)
	NTP_CU_SUDUNGTHUOC_CHITIET_DAl.Instance.UpdateItem(objData)

	End Sub

	Public Sub DeleteItem(ByVal ID_CHITIET as double)
	NTP_CU_SUDUNGTHUOC_CHITIET_DAl.Instance.DeleteItem(ID_CHITIET)

	End Sub

	Public Function SelectItem(ByVal ID_CHITIET as double) as NTP_CU_SUDUNGTHUOC_CHITIET_Info

        Dim ds As DataSet = NTP_CU_SUDUNGTHUOC_CHITIET_DAL.Instance.SelectItem(ID_CHITIET)
		Dim retVal As NTP_CU_SUDUNGTHUOC_CHITIET_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_CU_SUDUNGTHUOC_CHITIET_Info
			If not IsDBNull(row.Item("ID_CHITIET")) Then retVal.ID_CHITIET = row.Item("ID_CHITIET")
			If not IsDBNull(row.Item("ID_BAOCAO")) Then retVal.ID_BAOCAO = row.Item("ID_BAOCAO")
			If not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
			If not IsDBNull(row.Item("TYPE")) Then retVal.TYPE = row.Item("TYPE")
			If not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
			If not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
			If not IsDBNull(row.Item("ID_MATINH")) Then retVal.ID_MATINH = row.Item("ID_MATINH")
			If not IsDBNull(row.Item("TD_SOLUONG")) Then retVal.TD_SOLUONG = row.Item("TD_SOLUONG")
			If not IsDBNull(row.Item("TD_HANDUNG")) Then retVal.TD_HANDUNG = row.Item("TD_HANDUNG")
			If not IsDBNull(row.Item("TD_LOSX")) Then retVal.TD_LOSX = row.Item("TD_LOSX")
			If not IsDBNull(row.Item("N_SOLUONG")) Then retVal.N_SOLUONG = row.Item("N_SOLUONG")
			If not IsDBNull(row.Item("N_LOSX")) Then retVal.N_LOSX = row.Item("N_LOSX")
			If not IsDBNull(row.Item("N_HANDUNG")) Then retVal.N_HANDUNG = row.Item("N_HANDUNG")
			If not IsDBNull(row.Item("TRA_LAI")) Then retVal.TRA_LAI = row.Item("TRA_LAI")
			If not IsDBNull(row.Item("THUA")) Then retVal.THUA = row.Item("THUA")
			If not IsDBNull(row.Item("X_SUDUNG_TOANTINH")) Then retVal.X_SUDUNG_TOANTINH = row.Item("X_SUDUNG_TOANTINH")
			If not IsDBNull(row.Item("X_TINH_THIEU")) Then retVal.X_TINH_THIEU = row.Item("X_TINH_THIEU")
			If not IsDBNull(row.Item("X_TINH_HONG_VO")) Then retVal.X_TINH_HONG_VO = row.Item("X_TINH_HONG_VO")
			If not IsDBNull(row.Item("X_HUYEN_HONGVO")) Then retVal.X_HUYEN_HONGVO = row.Item("X_HUYEN_HONGVO")
			If not IsDBNull(row.Item("X_HUYEN_DIEUCHUYEN")) Then retVal.X_HUYEN_DIEUCHUYEN = row.Item("X_HUYEN_DIEUCHUYEN")
			If not IsDBNull(row.Item("TC_SOLUONG")) Then retVal.TC_SOLUONG = row.Item("TC_SOLUONG")
			If not IsDBNull(row.Item("TC_LOSX")) Then retVal.TC_LOSX = row.Item("TC_LOSX")
			If not IsDBNull(row.Item("TC_HANDUNG")) Then retVal.TC_HANDUNG = row.Item("TC_HANDUNG")
			If not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
		End If

		Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_CU_SUDUNGTHUOC_CHITIET_DAL.Instance.SelectAllItems()
	End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64, ByVal ID_THUOC As Integer, ByVal id_nguonkinhphi As Integer) As DataSet
        Return NTP_CU_SUDUNGTHUOC_CHITIET_DAL.Instance.Search(ID_KHO, ID_BAOCAO, ID_THUOC, id_nguonkinhphi)
    End Function
End Class
