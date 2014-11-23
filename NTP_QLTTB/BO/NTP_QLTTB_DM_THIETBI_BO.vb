Imports NTP_QLTTB

Public Class NTP_QLTTB_DM_THIETBI_BO
    Public Sub InsertItem(ByVal objData As NTP_QLTTB_DM_THIETBI_Info)
        NTP_QLTTB_DM_THIETBI_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLTTB_DM_THIETBI_Info)
        NTP_QLTTB_DM_THIETBI_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_THIETBI As Int32)
        NTP_QLTTB_DM_THIETBI_DAL.Instance.DeleteItem(ID_THIETBI)
    End Sub

    Public Function SelectItem(ByVal ID As Int32) As NTP_QLTTB_DM_THIETBI_Info
        Dim ds As DataSet = NTP_QLTTB_DM_THIETBI_DAL.Instance.SelectItem(ID)
        Dim retVal As New NTP_QLTTB_DM_THIETBI_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLTTB_DM_THIETBI_Info
            If Not IsDBNull(row.Item("ID_THIETBI")) Then retVal.ID_THIETBI = row.Item("ID_THIETBI")
            If Not IsDBNull(row.Item("TEN_THIETBI")) Then retVal.TEN_THIETBI = row.Item("TEN_THIETBI")
            If Not IsDBNull(row.Item("ID_DVT")) Then retVal.ID_DVT = row.Item("ID_DVT")
            If Not IsDBNull(row.Item("MA_NUOC")) Then retVal.MA_NUOC = row.Item("MA_NUOC")
            If Not IsDBNull(row.Item("NHAN_HIEU")) Then retVal.NHAN_HIEU = row.Item("NHAN_HIEU")
        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_QLTTB_DM_THIETBI_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sTEN_THIETBI As String) As DataSet
        Return NTP_QLTTB_DM_THIETBI_DAL.Instance.Search(sTEN_THIETBI)
    End Function

End Class


