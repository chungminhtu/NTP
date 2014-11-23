public class NTP_DM_LYDO_NHAPXUAT_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_LYDO_NHAPXUAT_Info)
        NTP_DM_LYDO_NHAPXUAT_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_LYDO_NHAPXUAT_Info)
        NTP_DM_LYDO_NHAPXUAT_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID As Integer)
        NTP_DM_LYDO_NHAPXUAT_DAL.Instance.DeleteItem(ID)
    End Sub

    Public Function SelectItem(ByVal ID As Integer) As NTP_DM_LYDO_NHAPXUAT_Info
        Dim ds As DataSet = NTP_DM_LYDO_NHAPXUAT_DAL.Instance.SelectItem(ID)
        Dim retVal As NTP_DM_LYDO_NHAPXUAT_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_LYDO_NHAPXUAT_Info
            If Not IsDBNull(row.Item("ID")) Then retVal.ID = row.Item("ID")
            If Not IsDBNull(row.Item("MO_TA")) Then retVal.MO_TA = row.Item("MO_TA")
            If Not IsDBNull(row.Item("TYPE")) Then retVal.TYPE = row.Item("TYPE")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_LYDO_NHAPXUAT_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sType As String) As DataSet
        Return NTP_DM_LYDO_NHAPXUAT_DAL.Instance.Search(sType)
    End Function

End Class
