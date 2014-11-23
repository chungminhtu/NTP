public class NTP_QLVT_KIEMKE_CHITIET_BO

	Public Sub InsertItem(ByVal objData As NTP_QLVT_KIEMKE_CHITIET_Info)
        NTP_QLVT_KIEMKE_CHITIET_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_QLVT_KIEMKE_CHITIET_Info)
        NTP_QLVT_KIEMKE_CHITIET_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_KIEMKE_CHITIET as double)
        NTP_QLVT_KIEMKE_CHITIET_DAL.Instance.DeleteItem(ID_KIEMKE_CHITIET)
    End Sub

	Public Function SelectItem(ByVal ID_KIEMKE_CHITIET as double) as NTP_QLVT_KIEMKE_CHITIET_Info
        Dim ds As DataSet = NTP_QLVT_KIEMKE_CHITIET_DAL.Instance.SelectItem(ID_KIEMKE_CHITIET)
		Dim retVal As NTP_QLVT_KIEMKE_CHITIET_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_QLVT_KIEMKE_CHITIET_Info
			If not IsDBNull(row.Item("ID_KIEMKE_CHITIET")) Then retVal.ID_KIEMKE_CHITIET = row.Item("ID_KIEMKE_CHITIET")
			If not IsDBNull(row.Item("ID_KIEMKE")) Then retVal.ID_KIEMKE = row.Item("ID_KIEMKE")
			If not IsDBNull(row.Item("ID_VATTU")) Then retVal.ID_VATTU = row.Item("ID_VATTU")
			If not IsDBNull(row.Item("ID_TRANGTHAI")) Then retVal.ID_TRANGTHAI = row.Item("ID_TRANGTHAI")
            If Not IsDBNull(row.Item("SO_LUONG")) Then retVal.SO_LUONG = row.Item("SO_LUONG")
            If Not IsDBNull(row.Item("LO_SANXUAT")) Then retVal.LO_SANXUAT = row.Item("LO_SANXUAT")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_QLVT_KIEMKE_CHITIET_DAL.Instance.SelectAllItems()
	End Function


    Public Function Search(ByVal iID_PHIEUKIEMKE As Double) As DataSet
        Return NTP_QLVT_KIEMKE_CHITIET_DAL.Instance.Search(iID_PHIEUKIEMKE)
    End Function
End Class
