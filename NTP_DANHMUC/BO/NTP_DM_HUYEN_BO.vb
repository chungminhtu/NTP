public class NTP_DM_HUYEN_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_HUYEN_Info)
        NTP_DM_HUYEN_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_HUYEN_Info)
        NTP_DM_HUYEN_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal MA_HUYEN As String)
        NTP_DM_HUYEN_DAL.Instance.DeleteItem(MA_HUYEN)
    End Sub

    Public Function SelectItem(ByVal MA_HUYEN As String) As NTP_DM_HUYEN_Info
        Dim ds As DataSet = NTP_DM_HUYEN_DAL.Instance.SelectItem(MA_HUYEN)
        Dim retVal As NTP_DM_HUYEN_Info = Nothing
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_HUYEN_Info
            If Not IsDBNull(row.Item("MA_HUYEN")) Then retVal.MA_HUYEN = row.Item("MA_HUYEN")
            If Not IsDBNull(row.Item("TEN_HUYEN")) Then retVal.TEN_HUYEN = row.Item("TEN_HUYEN")
            If Not IsDBNull(row.Item("MA_TINH")) Then retVal.MA_TINH = row.Item("MA_TINH")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_HUYEN_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sTenHuyen As String, ByVal sTinh As String) As DataSet
        Return NTP_DM_HUYEN_DAL.Instance.Search(sTenHuyen, sTinh)
    End Function

    Public Function GetID(ByVal MA_TINH As String) As String
        Return NTP_DM_HUYEN_DAL.Instance.GetID(MA_TINH)
    End Function
End Class
