Imports NTP_QLT
Public Class QLT_PHIEU_XUAT_CHI_TIET_BO
    Public Sub InsertItem(ByVal objData As NTP_QLT.QLT_PHIEU_XUAT_CHI_TIET_Info)
        Dim bibi As New NTP_QLT.QLT_PHIEU_XUAT_CHI_TIET_DAL
        bibi.InsertItem(objData)
        bibi = Nothing
    End Sub

    Public Sub UpdateItem(ByVal objData As QLT_PHIEU_XUAT_CHI_TIET_Info)
        Dim bibi As New QLT_PHIEU_XUAT_CHI_TIET_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUXUAT_CHITIET As Double)
        Dim bibi As New QLT_PHIEU_XUAT_CHI_TIET_DAL
        bibi.DeleteItem(ID_PHIEUXUAT_CHITIET)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUXUAT_CHITIET As Double) As QLT_PHIEU_XUAT_CHI_TIET_Info
        Dim bibi As New QLT_PHIEU_XUAT_CHI_TIET_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_PHIEUXUAT_CHITIET)
        Dim retVal As QLT_PHIEU_XUAT_CHI_TIET_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New QLT_PHIEU_XUAT_CHI_TIET_Info
            If Not IsDBNull(row.Item("ID_PHIEUXUAT_CHITIET")) Then retVal.ID_PHIEUXUAT_CHITIET = row.Item("ID_PHIEUXUAT_CHITIET")
            If Not IsDBNull(row.Item("ID_PHIEUXUAT")) Then retVal.ID_PHIEUXUAT = row.Item("ID_PHIEUXUAT")
            If Not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
            If Not IsDBNull(row.Item("LO_SX")) Then retVal.LO_SX = row.Item("LO_SX")
            If Not IsDBNull(row.Item("HAN_SUDUNG")) Then retVal.HAN_SUDUNG = row.Item("HAN_SUDUNG")
            If Not IsDBNull(row.Item("NGAY_SX")) Then retVal.NGAY_SX = row.Item("NGAY_SX")
            If Not IsDBNull(row.Item("SO_LUONG")) Then retVal.SO_LUONG = row.Item("SO_LUONG")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New QLT_PHIEU_XUAT_CHI_TIET_DAL).SelectAllItems()
    End Function

    Public Function SearchItem(ByVal ID_PhieuXuat As Double) As DataSet
        Return (New QLT_PHIEU_XUAT_CHI_TIET_DAL).SearchItem(ID_PhieuXuat)
    End Function

End Class
