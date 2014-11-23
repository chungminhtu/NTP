public class NTP_QLTTB_DM_TRANGTHAI_BO

	Public Sub InsertItem(ByVal objData As NTP_QLTTB_DM_TRANGTHAI_Info)
        NTP_QLTTB_DM_TRANGTHAI_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_QLTTB_DM_TRANGTHAI_Info)
		NTP_QLTTB_DM_TRANGTHAI_DAl.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_TRANGTHAI as integer)
		NTP_QLTTB_DM_TRANGTHAI_DAl.Instance.DeleteItem(ID_TRANGTHAI)
	End Sub

	Public Function SelectItem(ByVal ID_TRANGTHAI as integer) as NTP_QLTTB_DM_TRANGTHAI_Info
        Dim ds As DataSet = NTP_QLTTB_DM_TRANGTHAI_DAL.Instance.SelectItem(ID_TRANGTHAI)
		Dim retVal As NTP_QLTTB_DM_TRANGTHAI_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_QLTTB_DM_TRANGTHAI_Info
			If not IsDBNull(row.Item("ID_TRANGTHAI")) Then retVal.ID_TRANGTHAI = row.Item("ID_TRANGTHAI")
			If not IsDBNull(row.Item("TEN_TRANGTHAI")) Then retVal.TEN_TRANGTHAI = row.Item("TEN_TRANGTHAI")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_QLTTB_DM_TRANGTHAI_DAL.Instance.SelectAllItems()
	End Function

End Class
