public class NTP_DM_TINH_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_TINH_Info)
        NTP_DM_TINH_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_TINH_Info)
        NTP_DM_TINH_DAL.Instance.UpdateItem(objData)

    End Sub

    Public Sub DeleteItem(ByVal MA_TINH As String)

        NTP_DM_TINH_DAL.Instance.DeleteItem(MA_TINH)

    End Sub

    Public Function SelectItem(ByVal MA_TINH As String) As NTP_DM_TINH_Info

        Dim ds As DataSet = NTP_DM_TINH_DAL.Instance.SelectItem(MA_TINH)
        Dim retVal As NTP_DM_TINH_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_TINH_Info
            If Not IsDBNull(row.Item("MA_TINH")) Then retVal.MA_TINH = row.Item("MA_TINH")
            If Not IsDBNull(row.Item("TEN_TINH")) Then retVal.TEN_TINH = row.Item("TEN_TINH")
            If Not IsDBNull(row.Item("ID_VUNG")) Then retVal.ID_VUNG = row.Item("ID_VUNG")
        End If
        Return retVal
    End Function


    Public Function SelectItemByMien(ByVal ID_MIEN As Integer) As DataSet
        Return NTP_DM_TINH_DAL.Instance.SelectItemByIDMien(ID_MIEN)
    End Function
    Public Function SelectAllItems() As DataSet
        Return NTP_DM_TINH_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sTenTinh As String, ByVal iIDVung As Integer) As DataSet
        Return NTP_DM_TINH_DAL.Instance.Search(sTenTinh, iIDVung)
    End Function

    Public Function GetID() As String
        Return NTP_DM_TINH_DAL.Instance.GetID
    End Function
End Class
