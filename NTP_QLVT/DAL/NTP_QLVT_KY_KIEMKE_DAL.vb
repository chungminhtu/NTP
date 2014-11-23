Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLVT_KY_KIEMKE_DAL
    Private Shared _thisInstance As NTP_QLVT_KY_KIEMKE_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_KY_KIEMKE_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_KY_KIEMKE_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_QLVT_KY_KIEMKE_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_Insert", _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.NGAY_BATDAU), _
         Getnull(bibi.NGAY_KETTHUC), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.TEN_KY_KIEMKE))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_KY_KIEMKE_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_Update", _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.NGAY_BATDAU), _
         Getnull(bibi.NGAY_KETTHUC), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.TEN_KY_KIEMKE))
    End Sub

    Public Sub DeleteItem(ByVal ID_KY_KIEMKE As Int64)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_Delete", _
         Getnull(ID_KY_KIEMKE))
    End Sub

    Public Function SelectItem(ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_Select", _
         Getnull(ID_KY_KIEMKE))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_SelectList")
    End Function

    'Public Sub KhoaSoKiemKe(ByVal ID_KHO_QLVT As Integer, ByVal dtDateFrom As Date, ByVal dtDateTo As Date, ByVal iThang As Integer, ByVal iNam As Integer)
    '    SqlHelper.ExecuteNonQuery(SQLConnectionString, _
    '      "NTP_QLVT_KHOASO_KIEMKE", _
    '      Getnull(ID_KHO_QLVT), Getnull(dtDateFrom), Getnull(dtDateTo), iThang, iNam)
    'End Sub

    Public Sub KhoaSoKiemKe(ByVal ID_KHO_QLVT As Integer, ByVal iThang As Integer, ByVal iNam As Integer, ByVal sMO_TA As String, ByVal iNguoiNM As Integer, ByVal LAN_KIEMKE As Int16)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
          "NTP_QLVT_KHOASO_KIEMKE", _
          Getnull(ID_KHO_QLVT), iThang, iNam, sMO_TA, iNguoiNM, LAN_KIEMKE)
    End Sub

    Public Sub test()
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "TEST_PROC")
    End Sub

    Public Function KiemTraKy(ByVal id_kho As Integer, ByVal Thang As Integer, ByVal Nam As Integer) As DataSet
        'Kiem tra xem co gia tri khong, de biet ky nay co duoc nhap phieu vao khong
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KIEMTRA_KY", id_kho, Thang, Nam)

    End Function

    Public Function GetKyDaKiemKe(ByVal ID_KHO As Integer, ByVal Nam As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KY_KIEMKE_GetKyDaKiemKe", ID_KHO, Nam)
    End Function

    Public Function CHECK_KY_KIEMKE_EXIST(ByVal ID_KHO As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
               "NTP_QLVT_CHECK_KY_KIEMKE_EXIST", ID_KHO)
    End Function

    Public Function GET_LASTEST_KY_KIEMKE(ByVal ID_KHO As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
               "NTP_QLVT_GET_LASTEST_KY_KIEMKE", ID_KHO)
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal Nam As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
              "NTP_QLVT_KY_KIEMKE_Search", ID_KHO, Nam)
    End Function

    Public Sub KetChuyenSoLieu(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64, ByVal NGUOI_NM As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
                 "NTP_QLVT_KETCHUYEN_SOLIEU", _
                 Getnull(ID_KHO), Getnull(ID_KY_KIEMKE), NGUOI_NM)
    End Sub

    Public Function BaoCaoKiemKe(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                     "NTP_QLVT_BAOCAO_TONGHOP_KIEMKE", ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoVattu_tuyenhuyen(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                 "NTP_QLVT_BAOCAO_VATTU_TUYENHUYEN", ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoVattu_tuyentinh(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                 "NTP_QLVT_BAOCAO_VATTU_TUYENTINH", ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoHoaChat_tuyentinh(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                 "NTP_QLVT_BAOCAO_HOACHAT_TUYENTINH", ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoHC_VT_Main_tuyentinh(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
               "NTP_QLVT_BAOCAO_VATTU_HOACHAT_MAIN_TUYENTINH", ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function SO_THEODOI_VATTU(ByVal ID_KHO As Integer, ByVal dtDateFrom As Date, ByVal dtDateTo As Date, ByVal ID_VATTU As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
               "NTP_QLVT_SO_VATTU", ID_KHO, GetNull(dtDateFrom), GetNull(dtDateTo), GetNull(ID_VATTU))
    End Function

    Public Function SO_THEODOI_HOACHAT(ByVal ID_KHO As Integer, ByVal dtDateFrom As Date, ByVal dtDateTo As Date, ByVal ID_VATTU As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
               "NTP_QLVT_SO_HOACHAT", ID_KHO, GetNull(dtDateFrom), GetNull(dtDateTo), GetNull(ID_VATTU))
    End Function
End Class
