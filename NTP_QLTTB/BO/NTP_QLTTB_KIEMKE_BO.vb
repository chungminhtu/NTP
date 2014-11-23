public class NTP_QLTTB_KIEMKE_BO

    Public Function InsertItem(ByVal objData As NTP_QLTTB_KIEMKE_Info) As Int64
        Dim ds As New DataSet
        ds = NTP_QLTTB_KIEMKE_DAL.Instance.InsertItem(objData)

    End Function

	Public Sub UpdateItem(ByVal objData As NTP_QLTTB_KIEMKE_Info)
		NTP_QLTTB_KIEMKE_DAL.Instance.UpdateItem(objData)

	End Sub

	Public Sub DeleteItem(ByVal ID_KIEMKE as double)
		NTP_QLTTB_KIEMKE_DAL.Instance.DeleteItem(ID_KIEMKE)

	End Sub

	Public Function SelectItem(ByVal ID_KIEMKE as double) as NTP_QLTTB_KIEMKE_Info

        Dim ds As DataSet = NTP_QLTTB_KIEMKE_DAL.Instance.SelectItem(ID_KIEMKE)
		Dim retVal As NTP_QLTTB_KIEMKE_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_QLTTB_KIEMKE_Info
			If not IsDBNull(row.Item("ID_KIEMKE")) Then retVal.ID_KIEMKE = row.Item("ID_KIEMKE")
			If not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
			If not IsDBNull(row.Item("NGAY_KIEMKE")) Then retVal.NGAY_KIEMKE = row.Item("NGAY_KIEMKE")
			If not IsDBNull(row.Item("NGUOI_KIEMKE")) Then retVal.NGUOI_KIEMKE = row.Item("NGUOI_KIEMKE")
			If not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
            If Not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
        Else
            retVal = Nothing
        End If

		Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_QLTTB_KIEMKE_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return NTP_QLTTB_KIEMKE_DAL.Instance.Search(ID_KHO, dtFromDate, dtToDate, iNguonKinhPhi)
    End Function

End Class
