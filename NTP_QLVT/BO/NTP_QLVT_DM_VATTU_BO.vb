public class NTP_QLVT_DM_VATTU_BO

	Public Sub InsertItem(ByVal objData As NTP_QLVT_DM_VATTU_Info)
        NTP_QLVT_DM_VATTU_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_QLVT_DM_VATTU_Info)
        NTP_QLVT_DM_VATTU_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_VATTU as integer)

        NTP_QLVT_DM_VATTU_DAL.Instance.DeleteItem(ID_VATTU)

	End Sub

	Public Function SelectItem(ByVal ID_VATTU as integer) as NTP_QLVT_DM_VATTU_Info
        Dim ds As DataSet = NTP_QLVT_DM_VATTU_DAL.Instance.SelectItem(ID_VATTU)
		Dim retVal As NTP_QLVT_DM_VATTU_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_QLVT_DM_VATTU_Info
			If not IsDBNull(row.Item("ID_VATTU")) Then retVal.ID_VATTU = row.Item("ID_VATTU")
			If not IsDBNull(row.Item("TEN_VATTU")) Then retVal.TEN_VATTU = row.Item("TEN_VATTU")
            If Not IsDBNull(row.Item("ID_DVT")) Then retVal.ID_DVT = row.Item("ID_DVT")
            If Not IsDBNull(row.Item("MA_NUOC")) Then retVal.MA_NUOC = row.Item("MA_NUOC")
            If Not IsDBNull(row.Item("TYPE")) Then retVal.TYPE_HCVT = row.Item("TYPE")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_QLVT_DM_VATTU_DAL.Instance.SelectAllItems()
    End Function

    Public Function SelectAllItems(ByVal iType As NTP_Common.enuTYPE_VATTU_HOACHAT) As DataSet
        Return NTP_QLVT_DM_VATTU_DAL.Instance.SelectAllItems(iType)
    End Function

    Public Function Search(ByVal sTEN_VATTU As String) As DataSet
        Return NTP_QLVT_DM_VATTU_DAL.Instance.Search(sTEN_VATTU)
    End Function
End Class
