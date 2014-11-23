public class NTP_DM_NGUONKINHPHI_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_NGUONKINHPHI_Info)
        NTP_DM_NGUONKINHPHI_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_NGUONKINHPHI_Info)
        NTP_DM_NGUONKINHPHI_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_NGUONKINHPHI As Integer)
        NTP_DM_NGUONKINHPHI_DAL.Instance.DeleteItem(ID_NGUONKINHPHI)

    End Sub

    Public Function SelectItem(ByVal ID_NGUONKINHPHI As Integer) As NTP_DM_NGUONKINHPHI_Info
        Dim ds As DataSet = NTP_DM_NGUONKINHPHI_DAL.Instance.SelectItem(ID_NGUONKINHPHI)
        Dim retVal As NTP_DM_NGUONKINHPHI_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_NGUONKINHPHI_Info
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
            If Not IsDBNull(row.Item("MO_TA")) Then retVal.MO_TA = row.Item("MO_TA")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_NGUONKINHPHI_DAL.Instance.SelectAllItems()
    End Function

End Class
