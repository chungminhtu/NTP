Imports NTP_QLTTB

Public Class NTP_QLTTB_PHIEUNHAP_CHITIET_BO
    Public Sub InsertItem(ByVal objData As NTP_QLTTB_PHIEUNHAP_CHITIET_Info)
        NTP_QLTTB_PHIEUNHAP_CHITIET_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLTTB_PHIEUNHAP_CHITIET_Info)
        NTP_QLTTB_PHIEUNHAP_CHITIET_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP_CHITIET As Int64)
        NTP_QLTTB_PHIEUNHAP_CHITIET_DAL.Instance.DeleteItem(ID_PHIEUNHAP_CHITIET)
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP_CHITIET As Int64) As NTP_QLTTB_PHIEUNHAP_CHITIET_Info
        Dim ds As DataSet = NTP_QLTTB_PHIEUNHAP_CHITIET_DAL.Instance.SelectItem(ID_PHIEUNHAP_CHITIET)
        Dim retVal As New NTP_QLTTB_PHIEUNHAP_CHITIET_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLTTB_PHIEUNHAP_CHITIET_Info
            If Not IsDBNull(row.Item("ID_PHIEUNHAP_CHITIET")) Then retVal.ID_PHIEUNHAP_CHITIET = row.Item("ID_PHIEUNHAP_CHITIET")
            If Not IsDBNull(row.Item("ID_PHIEUNHAP")) Then retVal.ID_PHIEUNHAP = row.Item("ID_PHIEUNHAP")
            If Not IsDBNull(row.Item("ID_THIETBI")) Then retVal.ID_THIETBI = row.Item("ID_THIETBI")
            If Not IsDBNull(row.Item("SO_LUONG")) Then retVal.SO_LUONG = row.Item("SO_LUONG")
        End If
        Return retVal
    End Function

    Public Function SelectItemById(ByVal ID_PHIEUNHAP As Int64) As DataSet
        Return NTP_QLTTB.NTP_QLTTB_PHIEUNHAP_CHITIET_DAL.Instance.SelectItemById(ID_PHIEUNHAP)
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_QLTTB_PHIEUNHAP_CHITIET_DAL.Instance.SelectAllItems()
    End Function

End Class


