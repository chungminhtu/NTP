Public Class QLT_PHIEU_NHAP_BO
    Public Function InsertItem(ByVal objData As QLT_PHIEU_NHAP_Info)
        Dim bibi As New QLT_PHIEU_NHAP_DAL
        ' bibi.InsertItem(objData)

        Dim ds As DataSet
        Dim i As Integer
        ds = bibi.InsertItem(objData)
        Dim retVal As QLT_PHIEU_NHAP_Info
        Dim row As DataRow = ds.Tables(0).Rows(0)
        'retVal.ID_PHIEUNHAP = CInt(ds.Tables(0).Rows(0).ItemArray(0))
        bibi = Nothing
        i = CInt(ds.Tables(0).Rows(0).ItemArray(0))
        Return i
    End Function

    Public Sub UpdateItem(ByVal objData As QLT_PHIEU_NHAP_Info)
        Dim bibi As New QLT_PHIEU_NHAP_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP As Double)
        Dim bibi As New QLT_PHIEU_NHAP_DAL
        bibi.DeleteItem(ID_PHIEUNHAP)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP As Double) As QLT_PHIEU_NHAP_Info
        Dim bibi As New QLT_PHIEU_NHAP_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_PHIEUNHAP)
        Dim retVal As QLT_PHIEU_NHAP_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New QLT_PHIEU_NHAP_Info
            If Not IsDBNull(row.Item("ID_PHIEUNHAP")) Then retVal.ID_PHIEUNHAP = row.Item("ID_PHIEUNHAP")
            If Not IsDBNull(row.Item("MA_PHIEU_NHAP")) Then retVal.MA_PHIEU_NHAP = row.Item("MA_PHIEU_NHAP")
            If Not IsDBNull(row.Item("ID_DONVI_NHAP")) Then retVal.ID_DONVI_NHAP = row.Item("ID_DONVI_NHAP")
            If Not IsDBNull(row.Item("NGAY_NHAP")) Then retVal.NGAY_NHAP = row.Item("NGAY_NHAP")
            If Not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
            If Not IsDBNull(row.Item("NGUOI_NHAP")) Then retVal.NGUOI_NHAP = row.Item("NGUOI_NHAP")
            If Not IsDBNull(row.Item("ID_PHIEUXUAT")) Then retVal.ID_PHIEUXUAT = row.Item("ID_PHIEUXUAT")
            If Not IsDBNull(row.Item("ID_LYDO_NHAPXUAT")) Then retVal.ID_LYDO_NHAPXUAT = row.Item("ID_LYDO_NHAPXUAT")
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
            If Not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
            If Not IsDBNull(row.Item("NGAY_NM")) Then retVal.NGAY_NM = row.Item("NGAY_NM")
            If Not IsDBNull(row.Item("NGUOI_NM")) Then retVal.NGUOI_NM = row.Item("NGUOI_NM")
            If Not IsDBNull(row.Item("SO_PHIEUXUAT")) Then retVal.SO_PHIEUXUAT = row.Item("SO_PHIEUXUAT")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New QLT_PHIEU_NHAP_DAL).SelectAllItems()
    End Function
    Public Function Search(ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return (New QLT_PHIEU_NHAP_DAL).Search(sMA_PHIEU, dtFromDate, dtToDate, iNguonKinhPhi)
    End Function
End Class
