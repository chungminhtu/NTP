Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLVT_PHIEUNHAP_DAL
    Private Shared _thisInstance As NTP_QLVT_PHIEUNHAP_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_PHIEUNHAP_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_PHIEUNHAP_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Function InsertItem(ByVal bibi As NTP_QLVT_PHIEUNHAP_Info) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_Insert", _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.MA_PHIEUNHAP), _
         Getnull(bibi.NGAY_NHAP), _
         Getnull(bibi.NGUOI_NHAP), _
         Getnull(bibi.ID_KHONHAP), _
         Getnull(bibi.ID_KHOXUAT), _
         Getnull(bibi.ID_NGUONKINHPHI), _
         Getnull(bibi.ID_LYDO_NHAPXUAT), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.NGAY_NM), _
         Getnull(bibi.NGUOI_NM), _
         Getnull(bibi.ID_PHIEUXUAT), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NAM), _
         Getnull(bibi.SO_PHIEUXUAT))
    End Function

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_PHIEUNHAP_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_Update", _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.MA_PHIEUNHAP), _
         Getnull(bibi.NGAY_NHAP), _
         Getnull(bibi.NGUOI_NHAP), _
         Getnull(bibi.ID_KHONHAP), _
         Getnull(bibi.ID_KHOXUAT), _
         Getnull(bibi.ID_NGUONKINHPHI), _
         Getnull(bibi.ID_LYDO_NHAPXUAT), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.NGAY_NM), _
         Getnull(bibi.NGUOI_NM), _
         Getnull(bibi.ID_PHIEUXUAT), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NAM), _
         Getnull(bibi.SO_PHIEUXUAT))
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_Delete", _
         Getnull(ID_PHIEUNHAP))
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_Select", _
         Getnull(ID_PHIEUNHAP))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_SelectList")
    End Function

    Public Function Search(ByVal ID_KHONHAP As Integer, ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUNHAP_Search", ID_KHONHAP, Getnull(sMA_PHIEU), Getnull(dtFromDate), Getnull(dtToDate), Getnull(iNguonKinhPhi))
    End Function


End Class
