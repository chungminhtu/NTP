Public Class QLT_DM_TRANG_THAI_BO
    Public Sub InsertItem(ByVal objData As NTP_QLT.QLT_DM_TRANG_THAI_Info)
        Dim bibi As New NTP_QLT.QLT_DM_TRANG_THAI_DAL
        bibi.InsertItem(objData)
        bibi = Nothing
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLT.QLT_DM_TRANG_THAI_Info)
        Dim bibi As New NTP_QLT.QLT_DM_TRANG_THAI_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_TRANGTHAI As Integer)
        Dim bibi As New NTP_QLT.QLT_DM_TRANG_THAI_DAL
        bibi.DeleteItem(ID_TRANGTHAI)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_TRANGTHAI As Integer) As NTP_QLT.QLT_DM_TRANG_THAI_Info
        Dim bibi As New NTP_QLT.QLT_DM_TRANG_THAI_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_TRANGTHAI)
        Dim retVal As NTP_QLT.QLT_DM_TRANG_THAI_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLT.QLT_DM_TRANG_THAI_Info
            If Not IsDBNull(row.Item("ID_TRANGTHAI")) Then retVal.ID_TRANGTHAI = row.Item("ID_TRANGTHAI")
            If Not IsDBNull(row.Item("MO_TA")) Then retVal.MO_TA = row.Item("MO_TA")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New NTP_QLT.QLT_DM_TRANG_THAI_DAL).SelectAllItems()
    End Function
End Class
