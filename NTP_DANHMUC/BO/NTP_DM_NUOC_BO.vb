public class NTP_DM_NUOC_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_NUOC_Info)
        NTP_DM_NUOC_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_NUOC_Info)
        NTP_DM_NUOC_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal MA_NUOC As String)
        NTP_DM_NUOC_DAL.Instance.DeleteItem(MA_NUOC)
    End Sub

    Public Function SelectItem(ByVal MA_NUOC As String) As NTP_DM_NUOC_Info
        Dim ds As DataSet = NTP_DM_NUOC_DAL.Instance.SelectItem(MA_NUOC)
        Dim retVal As NTP_DM_NUOC_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_NUOC_Info
            If Not IsDBNull(row.Item("MA_NUOC")) Then retVal.MA_NUOC = row.Item("MA_NUOC")
            If Not IsDBNull(row.Item("TEN_NUOC")) Then retVal.TEN_NUOC = row.Item("TEN_NUOC")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_NUOC_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sTEN_NUOC As String) As DataSet
        Return NTP_DM_NUOC_DAL.Instance.Search(sTEN_NUOC)
    End Function

End Class
