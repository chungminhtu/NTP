Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT
Public Class QLT_PHIEU_XUAT_BO
    
    Public Function InsertItem(ByVal objData As NTP_QLT.QLT_PHIEU_XUAT_Info)
        Dim bibi As New QLT_PHIEU_XUAT_DAL
        ' bibi.InsertItem(objData)

        Dim ds As DataSet
        Dim i As Integer
        ds = bibi.InsertItem(objData)
        Dim retVal As QLT_PHIEU_XUAT_Info
        Dim row As DataRow = ds.Tables(0).Rows(0)
        'retVal.ID_PHIEUNHAP = CInt(ds.Tables(0).Rows(0).ItemArray(0))
        bibi = Nothing
        i = CInt(ds.Tables(0).Rows(0).ItemArray(0))
        Return i
    End Function

    Public Sub UpdateItem(ByVal objData As QLT_PHIEU_XUAT_Info)
        Dim bibi As New QLT_PHIEU_XUAT_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUXUAT As Double)
        Dim bibi As New QLT_PHIEU_XUAT_DAL
        bibi.DeleteItem(ID_PHIEUXUAT)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUXUAT As Double) As QLT_PHIEU_XUAT_Info
        Dim bibi As New QLT_PHIEU_XUAT_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_PHIEUXUAT)
        Dim retVal As QLT_PHIEU_XUAT_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New QLT_PHIEU_XUAT_Info
            If Not IsDBNull(row.Item("ID_PHIEUXUAT")) Then retVal.ID_PHIEUXUAT = row.Item("ID_PHIEUXUAT")
            If Not IsDBNull(row.Item("MA_PHIEUXUAT")) Then retVal.MA_PHIEUXUAT = row.Item("MA_PHIEUXUAT")
            If Not IsDBNull(row.Item("ID_DONVI_XUAT")) Then retVal.ID_DONVI_XUAT = row.Item("ID_DONVI_XUAT")
            If Not IsDBNull(row.Item("NGAY_XUAT")) Then retVal.NGAY_XUAT = row.Item("NGAY_XUAT")
            If Not IsDBNull(row.Item("NGUOI_XUAT")) Then retVal.NGUOI_XUAT = row.Item("NGUOI_XUAT")
            If Not IsDBNull(row.Item("NGUOI_NM")) Then retVal.NGUOI_NM = row.Item("NGUOI_NM")
            If Not IsDBNull(row.Item("NGAY_NM")) Then retVal.NGAY_NM = row.Item("NGAY_NM")
            If Not IsDBNull(row.Item("ID_DONVI_NHAP")) Then retVal.ID_DONVI_NHAP = row.Item("ID_DONVI_NHAP")
            If Not IsDBNull(row.Item("ID_LYDO_NHAPXUAT")) Then retVal.ID_LYDO_NHAPXUAT = row.Item("ID_LYDO_NHAPXUAT")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
            If Not IsDBNull(row.Item("ID_PHIEUNHAP")) Then retVal.ID_PHIEUNHAP = row.Item("ID_PHIEUNHAP")
            If Not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
            If Not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New NTP_QLT.QLT_PHIEU_XUAT_DAL).SelectAllItems()
    End Function
    Public Function Search(ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return (New QLT_PHIEU_XUAT_DAL).Search(sMA_PHIEU, dtFromDate, dtToDate, iNguonKinhPhi)
    End Function
End Class

