public class NTP_DM_CAP_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_CAP_Info)
        NTP_DM_CAP_DAL.Instance.InsertItem(objData)

	End Sub

	Public Sub UpdateItem(ByVal objData As NTP_DM_CAP_Info)
        NTP_DM_CAP_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_CAP as integer)
        NTP_DM_CAP_DAL.Instance.DeleteItem(ID_CAP)
    End Sub

	Public Function SelectItem(ByVal ID_CAP as integer) as NTP_DM_CAP_Info

        Dim ds As DataSet = NTP_DM_CAP_DAL.Instance.SelectItem(ID_CAP)
		Dim retVal As NTP_DM_CAP_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_DM_CAP_Info
			If not IsDBNull(row.Item("ID_CAP")) Then retVal.ID_CAP = row.Item("ID_CAP")
			If not IsDBNull(row.Item("TEN_CAP")) Then retVal.TEN_CAP = row.Item("TEN_CAP")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_DM_CAP_DAL.Instance.SelectAllItems()
	End Function

End Class
