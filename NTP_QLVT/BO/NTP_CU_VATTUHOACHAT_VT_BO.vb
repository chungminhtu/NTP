public class NTP_CU_VATTUHOACHAT_VT_BO

    Public Sub InsertItem(ByVal objData As NTP_CU_VATTUHOACHAT_VT_Info)
        NTP_CU_VATTUHOACHAT_VT_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_CU_VATTUHOACHAT_VT_Info)
		NTP_CU_VATTUHOACHAT_VT_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_CHITIET As Double)
        NTP_CU_VATTUHOACHAT_VT_DAL.Instance.DeleteItem(ID_CHITIET)
    End Sub

	Public Function SelectAllItems() as DataSet
        Return NTP_CU_VATTUHOACHAT_VT_DAL.Instance.SelectAllItems()
    End Function

    Public Function SelectItem(ByVal ID_CHITIET As Double) As NTP_CU_VATTUHOACHAT_VT_Info
        Dim ds As DataSet = NTP_CU_VATTUHOACHAT_VT_DAL.Instance.SelectItem(ID_CHITIET)
        Dim retVal As NTP_CU_VATTUHOACHAT_VT_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_CU_VATTUHOACHAT_VT_Info
            If Not IsDBNull(row.Item("ID_CHITIET")) Then retVal.ID_CHITIET = row.Item("ID_CHITIET")
            If Not IsDBNull(row.Item("ID_BAOCAO")) Then retVal.ID_BAOCAO = row.Item("ID_BAOCAO")
            If Not IsDBNull(row.Item("ID_VATTU")) Then retVal.ID_VATTU = row.Item("ID_VATTU")
            If Not IsDBNull(row.Item("TD_TINH")) Then retVal.TD_TINH = row.Item("TD_TINH")
            If Not IsDBNull(row.Item("TD_BVHUYENTINH")) Then retVal.TD_BVHUYENTINH = row.Item("TD_BVHUYENTINH")
            If Not IsDBNull(row.Item("N_TW_CAP")) Then retVal.N_TW_CAP = row.Item("N_TW_CAP")
            If Not IsDBNull(row.Item("N_TINH_CAP")) Then retVal.N_TINH_CAP = row.Item("N_TINH_CAP")
            If Not IsDBNull(row.Item("X_TOANTINH")) Then retVal.X_TOANTINH = row.Item("X_TOANTINH")
            If Not IsDBNull(row.Item("X_SUDUNG")) Then retVal.X_SUDUNG = row.Item("X_SUDUNG")
            If Not IsDBNull(row.Item("THUA_TINH")) Then retVal.THUA_TINH = row.Item("THUA_TINH")
            If Not IsDBNull(row.Item("THUA_HUYEN")) Then retVal.THUA_HUYEN = row.Item("THUA_HUYEN")
            If Not IsDBNull(row.Item("THIEU_TINH")) Then retVal.THIEU_TINH = row.Item("THIEU_TINH")
            If Not IsDBNull(row.Item("THIEU_HUYEN")) Then retVal.THIEU_HUYEN = row.Item("THIEU_HUYEN")
            If Not IsDBNull(row.Item("TC_TINH")) Then retVal.TC_TINH = row.Item("TC_TINH")
            If Not IsDBNull(row.Item("TC_HUYEN")) Then retVal.TC_HUYEN = row.Item("TC_HUYEN")
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
            If Not IsDBNull(row.Item("ID_DONVI")) Then retVal.ID_DONVI = row.Item("ID_DONVI")
            If Not IsDBNull(row.Item("TRA_LAI")) Then retVal.TRA_LAI = row.Item("TRA_LAI")
            If Not IsDBNull(row.Item("HONG_TINH")) Then retVal.HONG_TINH = row.Item("HONG_TINH")
            If Not IsDBNull(row.Item("DIEU_CHUYEN")) Then retVal.DIEU_CHUYEN = row.Item("DIEU_CHUYEN")
        End If
        Return retVal
    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Integer, ByVal ID_NGUONKINHPHI As Integer) As DataSet
        Return NTP_CU_VATTUHOACHAT_VT_DAL.Instance.Search(ID_KHO, ID_BAOCAO, ID_NGUONKINHPHI)
    End Function

  

End Class
