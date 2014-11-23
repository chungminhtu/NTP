Public Class QLT_KIEMKE_BO
    Function InsertItem(ByVal objData As NTP_QLT.QLT_KIEMKE_Info)
        Dim bibi As New NTP_QLT.QLT_KIEMKE_DAL
        Dim i As Integer
        i = bibi.InsertItem(objData)
        bibi = Nothing
        Return i
    End Function

    Public Sub UpdateItem(ByVal objData As NTP_QLT.QLT_KIEMKE_Info)
        Dim bibi As New NTP_QLT.QLT_KIEMKE_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_KIEMKE As Double)
        Dim bibi As New NTP_QLT.QLT_KIEMKE_DAL
        bibi.DeleteItem(ID_KIEMKE)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_KIEMKE As Double) As NTP_QLT.QLT_KIEMKE_Info
        Dim bibi As New NTP_QLT.QLT_KIEMKE_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_KIEMKE)
        Dim retVal As NTP_QLT.QLT_KIEMKE_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLT.QLT_KIEMKE_Info
            If Not IsDBNull(row.Item("ID_KIEMKE")) Then retVal.ID_KIEMKE = row.Item("ID_KIEMKE")
            If Not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("NGAY_KIEMKE")) Then retVal.NGAY_KIEMKE = row.Item("NGAY_KIEMKE")
            If Not IsDBNull(row.Item("NGUOI_KIEM")) Then retVal.NGUOI_KIEM = row.Item("NGUOI_KIEM")
            If Not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New NTP_QLT.QLT_KIEMKE_DAL).SelectAllItems()
    End Function
End Class
