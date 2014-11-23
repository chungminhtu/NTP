Imports NTP_QLTTB

Public Class NTP_QLTTB_DM_KHO_BO
    Public Sub InsertItem(ByVal objData As NTP_QLTTB_DM_KHO_Info)
        NTP_QLTTB_DM_KHO_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLTTB_DM_KHO_Info)
        NTP_QLTTB_DM_KHO_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_KHO As Int64)
        NTP_QLTTB_DM_KHO_DAL.Instance.DeleteItem(ID_KHO)
    End Sub

    Public Function SelectItem(ByVal ID_KHO As Int64) As NTP_QLTTB_DM_KHO_Info
        Dim ds As DataSet = NTP_QLTTB_DM_KHO_DAL.Instance.SelectItem(ID_KHO)
        Dim retVal As New NTP_QLTTB_DM_KHO_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLTTB_DM_KHO_Info
            If Not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
            If Not IsDBNull(row.Item("MA_KHO")) Then retVal.MA_KHO = row.Item("MA_KHO")
            If Not IsDBNull(row.Item("TEN_KHO")) Then retVal.TEN_KHO = row.Item("TEN_KHO")
            If Not IsDBNull(row.Item("ID_VUNG")) Then retVal.ID_VUNG = row.Item("ID_VUNG")
            If Not IsDBNull(row.Item("ID_KHO_CAPTREN")) Then retVal.ID_KHO_CAPTREN = row.Item("ID_KHO_CAPTREN")
            If Not IsDBNull(row.Item("DIA_CHI")) Then retVal.DIA_CHI = row.Item("DIA_CHI")
            If Not IsDBNull(row.Item("MA_TINH")) Then retVal.MA_TINH = row.Item("MA_TINH")
            If Not IsDBNull(row.Item("MA_HUYEN")) Then retVal.MA_HUYEN = row.Item("MA_HUYEN")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_QLTTB_DM_KHO_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sTEN_KHO As String, ByVal sMA_TINH As String, ByVal sMA_HUYEN As String, ByVal iID_KHO_CAPTREN As Integer) As DataSet
        Return NTP_QLTTB_DM_KHO_DAL.Instance.Search(sTEN_KHO, sMA_TINH, sMA_HUYEN, iID_KHO_CAPTREN)
    End Function

End Class


