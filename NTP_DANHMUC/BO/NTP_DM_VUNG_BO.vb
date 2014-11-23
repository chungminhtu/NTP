public class NTP_DM_VUNG_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_VUNG_Info)
        NTP_DM_VUNG_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_VUNG_Info)
        NTP_DM_VUNG_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_VUNG As Integer)
        NTP_DM_VUNG_DAL.Instance.DeleteItem(ID_VUNG)

    End Sub

    Public Function SelectItem(ByVal ID_VUNG As Integer) As NTP_DM_VUNG_Info
        Dim ds As DataSet = NTP_DM_VUNG_DAL.Instance.SelectItem(ID_VUNG)
        Dim retVal As NTP_DM_VUNG_Info = Nothing
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_VUNG_Info
            If Not IsDBNull(row.Item("ID_VUNG")) Then retVal.ID_VUNG = row.Item("ID_VUNG")
            If Not IsDBNull(row.Item("TEN_VUNG")) Then retVal.TEN_VUNG = row.Item("TEN_VUNG")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_VUNG_DAL.Instance.SelectAllItems()
    End Function

    Public Function GetIDMien(ByVal ID_VUNG As Integer) As Integer
        Return NTP_DM_VUNG_DAL.Instance.GetIDMien(ID_VUNG)
    End Function
End Class
