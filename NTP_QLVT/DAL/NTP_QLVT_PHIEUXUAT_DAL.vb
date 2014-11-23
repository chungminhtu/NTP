Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

public class NTP_QLVT_PHIEUXUAT_DAL
    Private Shared _thisInstance As NTP_QLVT_PHIEUXUAT_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_PHIEUXUAT_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_PHIEUXUAT_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Function InsertItem(ByVal bibi As NTP_QLVT_PHIEUXUAT_Info) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUXUAT_Insert", _
         Getnull(bibi.ID_PHIEUXUAT), _
         Getnull(bibi.MA_PHIEUXUAT), _
         Getnull(bibi.NGAY_XUAT), _
         Getnull(bibi.NGUOI_XUAT), _
         Getnull(bibi.ID_KHOXUAT), _
         Getnull(bibi.ID_KHONHAP), _
         Getnull(bibi.ID_LYDO_NHAPXUAT), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.NGAY_NM), _
         Getnull(bibi.NGUOI_NM), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NAM), _
         Getnull(bibi.ID_NGUONKINHPHI))
    End Function

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_PHIEUXUAT_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_PHIEUXUAT_Update", _
         Getnull(bibi.ID_PHIEUXUAT), _
         Getnull(bibi.MA_PHIEUXUAT), _
         Getnull(bibi.NGAY_XUAT), _
         Getnull(bibi.NGUOI_XUAT), _
         Getnull(bibi.ID_KHOXUAT), _
         Getnull(bibi.ID_KHONHAP), _
         Getnull(bibi.ID_LYDO_NHAPXUAT), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.NGAY_NM), _
         Getnull(bibi.NGUOI_NM), _
         Getnull(bibi.ID_PHIEUNHAP), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NAM), _
         Getnull(bibi.ID_NGUONKINHPHI))
    End Sub

	Public Sub DeleteItem(ByVal ID_PHIEUXUAT as double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
   "NTP_QLVT_PHIEUXUAT_Delete", _
   Getnull(ID_PHIEUXUAT))
	End Sub

	Public Function SelectItem(ByVal ID_PHIEUXUAT as double) as DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
   "NTP_QLVT_PHIEUXUAT_Select", _
   Getnull(ID_PHIEUXUAT))
	End Function

	Public Function SelectAllItems() as DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
   "NTP_QLVT_PHIEUXUAT_SelectList")
    End Function


    Public Function Search(ByVal ID_KHOXUAT As Integer, ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer, ByVal iID_LYDO_NHAPXUAT As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_PHIEUXUAT_Search", ID_KHOXUAT, Getnull(sMA_PHIEU), Getnull(dtFromDate), Getnull(dtToDate), Getnull(iNguonKinhPhi), Getnull(iID_LYDO_NHAPXUAT))
    End Function

End Class
