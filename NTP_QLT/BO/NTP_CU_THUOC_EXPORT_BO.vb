public class NTP_CU_THUOC_EXPORT_BO

	Public Sub InsertItem(ByVal objData As NTP_CU_THUOC_EXPORT_Info)
        NTP_CU_THUOC_EXPORT_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_CU_THUOC_EXPORT_Info)
		NTP_CU_THUOC_EXPORT_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_EXPORT as double)
		NTP_CU_THUOC_EXPORT_DAL.Instance.DeleteItem(ID_EXPORT)
    End Sub

	Public Function SelectItem(ByVal ID_EXPORT as double) as NTP_CU_THUOC_EXPORT_Info
        Dim ds As DataSet = NTP_CU_THUOC_EXPORT_DAL.Instance.SelectItem(ID_EXPORT)
		Dim retVal As NTP_CU_THUOC_EXPORT_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_CU_THUOC_EXPORT_Info
			If not IsDBNull(row.Item("ID_EXPORT")) Then retVal.ID_EXPORT = row.Item("ID_EXPORT")
			If not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
			If not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
			If not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
			If not IsDBNull(row.Item("ID_KHO_NHAN")) Then retVal.ID_KHO_NHAN = row.Item("ID_KHO_NHAN")
			If not IsDBNull(row.Item("NGAY_XUAT_KHO")) Then retVal.NGAY_XUAT_KHO = row.Item("NGAY_XUAT_KHO")
			If not IsDBNull(row.Item("LOAI_XUAT")) Then retVal.LOAI_XUAT = row.Item("LOAI_XUAT")
			If not IsDBNull(row.Item("LO_SX")) Then retVal.LO_SX = row.Item("LO_SX")
			If not IsDBNull(row.Item("HAN_DUNG")) Then retVal.HAN_DUNG = row.Item("HAN_DUNG")
			If not IsDBNull(row.Item("SO_LUONG")) Then retVal.SO_LUONG = row.Item("SO_LUONG")
			If not IsDBNull(row.Item("NGAY_NM")) Then retVal.NGAY_NM = row.Item("NGAY_NM")
            If Not IsDBNull(row.Item("NGUOI_NM")) Then retVal.NGUOI_NM = row.Item("NGUOI_NM")
            If Not IsDBNull(row.Item("MA_PHIEU")) Then retVal.MA_PHIEU = row.Item("MA_PHIEU")
            If Not IsDBNull(row.Item("NGUOI_VIETPHIEU")) Then retVal.NGUOI_VIETPHIEU = row.Item("NGUOI_VIETPHIEU")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_CU_THUOC_EXPORT_DAL.Instance.SelectAllItems()
	End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer, ByVal ID_LYDONHAPXUAT As Integer, ByVal ID_DONVI_NHAN As Integer) As DataSet
        Return NTP_CU_THUOC_EXPORT_DAL.Instance.Search(ID_KHO, sMA_PHIEU, dtFromDate, dtToDate, iNguonKinhPhi, ID_LYDONHAPXUAT, ID_DONVI_NHAN)
    End Function
End Class
