Public Class QLT_KIEMKE_CHITIET_BO
    Public Sub InsertItem(ByVal objData As NTP_QLT.QLT_KIEMKE_CHITIET_Info)
        Dim bibi As New NTP_QLT.QLT_KIEMKE_CHITIET_DAL
        bibi.InsertItem(objData)
        bibi = Nothing
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLT.QLT_KIEMKE_CHITIET_Info)
        Dim bibi As New NTP_QLT.QLT_KIEMKE_CHITIET_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_KIEMKE_CHITIET As Double)
        Dim bibi As New NTP_QLT.QLT_KIEMKE_CHITIET_DAL
        bibi.DeleteItem(ID_KIEMKE_CHITIET)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_KIEMKE_CHITIET As Double) As NTP_QLT.QLT_KIEMKE_CHITIET_Info
        Dim bibi As New NTP_QLT.QLT_KIEMKE_CHITIET_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_KIEMKE_CHITIET)
        Dim retVal As NTP_QLT.QLT_KIEMKE_CHITIET_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLT.QLT_KIEMKE_CHITIET_Info
            If Not IsDBNull(row.Item("ID_KIEMKE_CHITIET")) Then retVal.ID_KIEMKE_CHITIET = row.Item("ID_KIEMKE_CHITIET")
            If Not IsDBNull(row.Item("ID_KIEMKE")) Then retVal.ID_KIEMKE = row.Item("ID_KIEMKE")
            If Not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
            If Not IsDBNull(row.Item("ID_TRANGTHAI")) Then retVal.ID_TRANGTHAI = row.Item("ID_TRANGTHAI")
            If Not IsDBNull(row.Item("LO_SX")) Then retVal.LO_SX = row.Item("LO_SX")
            If Not IsDBNull(row.Item("HAN_SUDUNG")) Then retVal.HAN_SUDUNG = row.Item("HAN_SUDUNG")
            If Not IsDBNull(row.Item("NGAY_SX")) Then retVal.NGAY_SX = row.Item("NGAY_SX")
            If Not IsDBNull(row.Item("SO_LUONG")) Then retVal.SO_LUONG = row.Item("SO_LUONG")
            If Not IsDBNull(row.Item("Loai_Phieu")) Then retVal.SO_LUONG = row.Item("Loai_Phieu")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New NTP_QLT.QLT_KIEMKE_CHITIET_DAL).SelectAllItems()
    End Function

    Public Function SearchItem(ByVal ID_KIEMKE As Double) As DataSet
        Return (New QLT_KIEMKE_CHITIET_DAL).SearchItem(ID_KIEMKE)
    End Function
End Class
