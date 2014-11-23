public class NTP_DM_THUOC_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_THUOC_Info)
        NTP_DM_THUOC_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_THUOC_Info)
        NTP_DM_THUOC_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_THUOC As Integer)
        NTP_DM_THUOC_DAL.Instance.DeleteItem(ID_THUOC)
    End Sub

    Public Function SelectItem(ByVal ID_THUOC As Integer) As NTP_DM_THUOC_Info
        Dim ds As DataSet = NTP_DM_THUOC_DAL.Instance.SelectItem(ID_THUOC)
        Dim retVal As NTP_DM_THUOC_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_THUOC_Info
            If Not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
            If Not IsDBNull(row.Item("MA_THUOC")) Then retVal.MA_THUOC = row.Item("MA_THUOC")
            If Not IsDBNull(row.Item("TEN_THUOC")) Then retVal.TEN_THUOC = row.Item("TEN_THUOC")
            If Not IsDBNull(row.Item("HAM_LUONG")) Then retVal.HAM_LUONG = row.Item("HAM_LUONG")
            If Not IsDBNull(row.Item("MA_NUOC")) Then retVal.MA_NUOC = row.Item("MA_NUOC")
            If Not IsDBNull(row.Item("ID_DVT")) Then retVal.ID_DVT = row.Item("ID_DVT")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_THUOC_DAL.Instance.SelectAllItems()
    End Function

End Class
