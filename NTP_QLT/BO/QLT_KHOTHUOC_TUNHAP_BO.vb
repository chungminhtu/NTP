Public Class QLT_KHOTHUOC_TUNHAP_BO
    Public Sub InsertItem(ByVal objData As NTP_QLT.QLT_KHOTHUOC_TUNHAP_Info)
        Dim bibi As New NTP_QLT.QLT_KHOTHUOC_TUNHAP_DAL
        bibi.InsertItem(objData)
        bibi = Nothing
    End Sub

    Public Sub UpdateItem(ByVal objData As QLT_KHOTHUOC_TUNHAP_Info)
        Dim bibi As New QLT_KHOTHUOC_TUNHAP_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_TUNHAP As Integer)
        Dim bibi As New QLT_KHOTHUOC_TUNHAP_DAL
        bibi.DeleteItem(ID_TUNHAP)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_TUNHAP As Integer) As QLT_KHOTHUOC_TUNHAP_Info
        Dim bibi As New QLT_KHOTHUOC_TUNHAP_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_TUNHAP)
        Dim retVal As QLT_KHOTHUOC_TUNHAP_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New QLT_KHOTHUOC_TUNHAP_Info
            If Not IsDBNull(row.Item("ID_TUNHAP")) Then retVal.ID_TUNHAP = row.Item("ID_TUNHAP")
            If Not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
            If Not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
            If Not IsDBNull(row.Item("LO_SX")) Then retVal.LO_SX = row.Item("LO_SX")
            If Not IsDBNull(row.Item("TON_DAUKY")) Then retVal.TON_DAUKY = row.Item("TON_DAUKY")
            If Not IsDBNull(row.Item("NHAP")) Then retVal.NHAP = row.Item("NHAP")
            If Not IsDBNull(row.Item("XUAT")) Then retVal.XUAT = row.Item("XUAT")
            If Not IsDBNull(row.Item("TON_CUOIKY")) Then retVal.TON_CUOIKY = row.Item("TON_CUOIKY")
            If Not IsDBNull(row.Item("THUA")) Then retVal.THUA = row.Item("THUA")
            If Not IsDBNull(row.Item("THIEU")) Then retVal.THIEU = row.Item("THIEU")
            If Not IsDBNull(row.Item("HONG")) Then retVal.HONG = row.Item("HONG")
            If Not IsDBNull(row.Item("TOT")) Then retVal.TOT = row.Item("TOT")
            If Not IsDBNull(row.Item("Kem_PC")) Then retVal.Kem_PC = row.Item("Kem_PC")
            If Not IsDBNull(row.Item("Mat_PC")) Then retVal.Mat_PC = row.Item("Mat_PC")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New QLT_KHOTHUOC_TUNHAP_DAL).SelectAllItems()
    End Function

    Public Function Search(ByVal ID_KhoThuoc As Integer, ByVal ID_KyKiemKe As Integer) As DataSet
        Return (New QLT_KHOTHUOC_TUNHAP_DAL).Search(ID_KhoThuoc, ID_KyKiemKe)
    End Function

End Class
