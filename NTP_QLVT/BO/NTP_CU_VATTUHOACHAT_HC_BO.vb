public class NTP_CU_VATTUHOACHAT_HC_BO

	Public Sub InsertItem(ByVal objData As NTP_CU_VATTUHOACHAT_HC_Info)
        NTP_CU_VATTUHOACHAT_HC_DAL.Instance.InsertItem(objData)

	End Sub

	Public Sub UpdateItem(ByVal objData As NTP_CU_VATTUHOACHAT_HC_Info)
		NTP_CU_VATTUHOACHAT_HC_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_CHITIET as double)
		NTP_CU_VATTUHOACHAT_HC_DAL.Instance.DeleteItem(ID_CHITIET)
    End Sub

	Public Function SelectItem(ByVal ID_CHITIET as double) as NTP_CU_VATTUHOACHAT_HC_Info
        Dim ds As DataSet = NTP_CU_VATTUHOACHAT_HC_DAL.Instance.SelectItem(ID_CHITIET)
		Dim retVal As NTP_CU_VATTUHOACHAT_HC_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_CU_VATTUHOACHAT_HC_Info
			If not IsDBNull(row.Item("ID_CHITIET")) Then retVal.ID_CHITIET = row.Item("ID_CHITIET")
			If not IsDBNull(row.Item("ID_BAOCAO")) Then retVal.ID_BAOCAO = row.Item("ID_BAOCAO")
			If not IsDBNull(row.Item("ID_VATTU")) Then retVal.ID_VATTU = row.Item("ID_VATTU")
			If not IsDBNull(row.Item("TON_DAU")) Then retVal.TON_DAU = row.Item("TON_DAU")
			If not IsDBNull(row.Item("NHAP")) Then retVal.NHAP = row.Item("NHAP")
			If not IsDBNull(row.Item("XUAT")) Then retVal.XUAT = row.Item("XUAT")
			If not IsDBNull(row.Item("THUA")) Then retVal.THUA = row.Item("THUA")
			If not IsDBNull(row.Item("THIEU_HONG")) Then retVal.THIEU_HONG = row.Item("THIEU_HONG")
			If not IsDBNull(row.Item("TON_CUOI")) Then retVal.TON_CUOI = row.Item("TON_CUOI")
			If not IsDBNull(row.Item("HAN_SUDUNG")) Then retVal.HAN_SUDUNG = row.Item("HAN_SUDUNG")
			If not IsDBNull(row.Item("NGUOI_NM")) Then retVal.NGUOI_NM = row.Item("NGUOI_NM")
			If not IsDBNull(row.Item("NGAY_NM")) Then retVal.NGAY_NM = row.Item("NGAY_NM")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
            If Not IsDBNull(row.Item("LO_SX")) Then retVal.LO_SX = row.Item("LO_SX")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_CU_VATTUHOACHAT_HC_DAL.Instance.SelectAllItems()
	End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Integer, ByVal ID_NGUONKINHPHI As Integer) As DataSet
        Return NTP_CU_VATTUHOACHAT_HC_DAL.Instance.Search(ID_KHO, ID_BAOCAO, ID_NGUONKINHPHI)
    End Function
End Class
