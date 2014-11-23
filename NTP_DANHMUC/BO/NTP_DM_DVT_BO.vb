public class NTP_DM_DVT_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_DVT_Info)
        NTP_DM_DVT_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_DVT_Info)
        NTP_DM_DVT_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_DVT As Integer)
        NTP_DM_DVT_DAL.Instance.DeleteItem(ID_DVT)
    End Sub

    Public Function SelectItem(ByVal ID_DVT As Integer) As NTP_DM_DVT_Info
        Dim ds As DataSet = NTP_DM_DVT_DAL.Instance.SelectItem(ID_DVT)
        Dim retVal As NTP_DM_DVT_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_DVT_Info
            If Not IsDBNull(row.Item("ID_DVT")) Then retVal.ID_DVT = row.Item("ID_DVT")
            If Not IsDBNull(row.Item("TEN_DVT")) Then retVal.TEN_DVT = row.Item("TEN_DVT")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_DVT_DAL.Instance.SelectAllItems()
    End Function

End Class
