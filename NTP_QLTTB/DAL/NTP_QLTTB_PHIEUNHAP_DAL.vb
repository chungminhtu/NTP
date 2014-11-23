Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL
Public Class NTP_QLTTB_PHIEUNHAP_DAL

    Private Shared _thisInstance As NTP_QLTTB_PHIEUNHAP_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLTTB_PHIEUNHAP_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLTTB_PHIEUNHAP_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    ''' <summary>
    ''' Insert into NTP_QLTTB_PHIEUNHAP
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub InsertItem(ByVal bibi As NTP_QLTTB_PHIEUNHAP_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_Insert", _
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

    ''' <summary>
    ''' Update NTP_QLTTB_PHIEUNHAP
    ''' </summary>
    ''' <param name="bibi"></param>
    ''' <remarks></remarks>
    Public Sub UpdateItem(ByVal bibi As NTP_QLTTB_PHIEUNHAP_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_Update", _
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

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP As Int64)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_Delete", _
      Getnull(ID_PHIEUNHAP))
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_Select", _
         Getnull(ID_PHIEUNHAP))
    End Function

    Public Function SelectItemByMa(ByVal MA_PHIEUNHAP As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_SelectByMa", _
         Getnull(MA_PHIEUNHAP))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_SelectList")
    End Function


    ''' <summary>
    ''' Search thong tin theo keysearch: MA_PHIEUNHAP, NGUON_KINHPHI, TU_NGAY, DEN_NGAY
    ''' </summary>
    ''' <param name="sMA_PHIEUNHAP"></param>
    ''' <param name="iID_NGUONKINHPHI"></param>
    ''' <param name="dTU_NGAY"></param>
    ''' <param name="dDEN_NGAY"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Search(ByVal sMA_PHIEUNHAP As String, ByVal iID_NGUONKINHPHI As Integer, ByVal dTU_NGAY As DateTime, ByVal dDEN_NGAY As DateTime) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLTTB_PHIEUNHAP_Search", Getnull(sMA_PHIEUNHAP), Getnull(iID_NGUONKINHPHI), Getnull(dTU_NGAY), Getnull(dDEN_NGAY))
    End Function

End Class
