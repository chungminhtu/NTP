public class NTP_DM_HANG_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_HANG_Info)
        NTP_DM_HANG_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_HANG_Info)
        NTP_DM_HANG_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_HANG As Integer)
        NTP_DM_HANG_DAL.Instance.DeleteItem(ID_HANG)
    End Sub

    Public Function SelectItem(ByVal ID_HANG As Integer) As NTP_DM_HANG_Info
        Dim ds As DataSet = NTP_DM_HANG_DAL.Instance.SelectItem(ID_HANG)
        Dim retVal As NTP_DM_HANG_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_HANG_Info
            If Not IsDBNull(row.Item("ID_HANG")) Then retVal.ID_HANG = row.Item("ID_HANG")
            If Not IsDBNull(row.Item("MA_HANG")) Then retVal.MA_HANG = row.Item("MA_HANG")
            If Not IsDBNull(row.Item("TEN_HANG")) Then retVal.TEN_HANG = row.Item("TEN_HANG")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_HANG_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sTenHang As String) As DataSet
        Return NTP_DM_HANG_DAL.Instance.Search(sTenHang)
    End Function

End Class
