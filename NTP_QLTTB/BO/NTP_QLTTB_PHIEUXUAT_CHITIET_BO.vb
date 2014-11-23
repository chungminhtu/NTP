Imports NTP_QLTTB

Public Class NTP_QLTTB_PHIEUXUAT_CHITIET_BO
    Public Sub InsertItem(ByVal objData As NTP_QLTTB_PHIEUXUAT_CHITIET_Info)
        NTP_QLTTB_PHIEUXUAT_CHITIET_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLTTB_PHIEUXUAT_CHITIET_Info)
        NTP_QLTTB_PHIEUXUAT_CHITIET_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUXUAT_CHITIET As Int64)
        NTP_QLTTB_PHIEUXUAT_CHITIET_DAL.Instance.DeleteItem(ID_PHIEUXUAT_CHITIET)
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUXUAT_CHITIET As Int64) As NTP_QLTTB_PHIEUXUAT_CHITIET_Info
        Dim ds As DataSet = NTP_QLTTB_PHIEUXUAT_CHITIET_DAL.Instance.SelectItem(ID_PHIEUXUAT_CHITIET)
        Dim retVal As New NTP_QLTTB_PHIEUXUAT_CHITIET_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLTTB_PHIEUXUAT_CHITIET_Info
            If Not IsDBNull(row.Item("ID_PHIEUXUAT_CHITIET")) Then retVal.ID_PHIEUXUAT_CHITIET = row.Item("ID_PHIEUXUAT_CHITIET")
            If Not IsDBNull(row.Item("ID_PHIEUXUAT")) Then retVal.ID_PHIEUXUAT = row.Item("ID_PHIEUXUAT")
            If Not IsDBNull(row.Item("ID_THIETBI")) Then retVal.ID_THIETBI = row.Item("ID_THIETBI")
            If Not IsDBNull(row.Item("SO_LUONG")) Then retVal.SO_LUONG = row.Item("SO_LUONG")
        End If
        Return retVal
    End Function

    Public Function SelectItemById(ByVal ID_PHIEUXUAT As String) As DataSet
        Return NTP_QLTTB.NTP_QLTTB_PHIEUXUAT_CHITIET_DAL.Instance.SelectItemById(ID_PHIEUXUAT)
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_QLTTB_PHIEUXUAT_CHITIET_DAL.Instance.SelectAllItems()
    End Function

End Class


