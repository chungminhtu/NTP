public class NTP_DM_MIEN_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_MIEN_Info)
        NTP_DM_MIEN_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_DM_MIEN_Info)
        NTP_DM_MIEN_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_MIEN as integer)
        NTP_DM_MIEN_DAL.Instance.DeleteItem(ID_MIEN)
    End Sub

	Public Function SelectItem(ByVal ID_MIEN as integer) as NTP_DM_MIEN_Info
        Dim ds As DataSet = NTP_DM_MIEN_DAL.Instance.SelectItem(ID_MIEN)
		Dim retVal As NTP_DM_MIEN_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_DM_MIEN_Info
			If not IsDBNull(row.Item("ID_MIEN")) Then retVal.ID_MIEN = row.Item("ID_MIEN")
			If not IsDBNull(row.Item("TEN_MIEN")) Then retVal.TEN_MIEN = row.Item("TEN_MIEN")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_DM_MIEN_DAL.Instance.SelectAllItems()
	End Function

End Class
