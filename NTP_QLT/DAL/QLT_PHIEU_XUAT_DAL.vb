Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT

Public Class QLT_PHIEU_XUAT_DAL

    'Public Overloads Shared Function Instance() As QLT_PHIEU_XUAT_DAL
    '    Return CType(Instance(NAMESPACE_NAME & "." & "NTP_QLT_PHIEUXUAT_DAO", ASSEMBLY_NAME), QLT_PHIEU_XUAT_DAL)
    'End Function

    Public Function InsertItem(ByVal bibi As QLT_PHIEU_XUAT_Info)
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_Insert", _
         Getnull(bibi.MA_PHIEUXUAT), _
         Getnull(bibi.ID_DONVI_XUAT), _
         Getnull(bibi.NGAY_XUAT), _
         Getnull(bibi.NGUOI_XUAT), _
         Getnull(bibi.NGUOI_NM), _
         Getnull(bibi.NGAY_NM), _
         Getnull(bibi.ID_DONVI_NHAP), _
         Getnull(bibi.ID_LYDO_NHAPXUAT), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NAM), _
         Getnull(bibi.ID_NGUONKINHPHI))
    End Function

    Public Sub UpdateItem(ByVal bibi As QLT_PHIEU_XUAT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_Update", _
         Getnull(bibi.ID_PHIEUXUAT), _
         Getnull(bibi.MA_PHIEUXUAT), _
         Getnull(bibi.ID_DONVI_XUAT), _
         Getnull(bibi.NGAY_XUAT), _
         Getnull(bibi.NGUOI_XUAT), _
         Getnull(bibi.NGUOI_NM), _
         Getnull(bibi.NGAY_NM), _
         Getnull(bibi.ID_DONVI_NHAP), _
         Getnull(bibi.ID_LYDO_NHAPXUAT), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NAM), _
         Getnull(bibi.ID_NGUONKINHPHI))
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUXUAT As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_Delete", _
         Getnull(ID_PHIEUXUAT))
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUXUAT As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_Select", _
         Getnull(ID_PHIEUXUAT))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_PHIEUXUAT_SelectList")
    End Function
    Public Function Search(ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        'Public Function Search(ByVal ID_KHONHAP As Integer, ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        'Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        ' "NTP_QLT_PHIEUNHAP_Search", ID_KHONHAP, Getnull(sMA_PHIEU), Getnull(dtFromDate), Getnull(dtToDate), Getnull(iNguonKinhPhi))
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
        "NTP_QLT_PHIEUXUAT_Search", Getnull(sMA_PHIEU), Getnull(dtFromDate), Getnull(dtToDate), Getnull(iNguonKinhPhi))
    End Function
End Class

