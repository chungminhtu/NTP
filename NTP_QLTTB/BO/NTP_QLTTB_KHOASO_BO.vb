Public Class NTP_QLTTB_KHOASO_BO
    Public Function KiemTraKy(ByVal ID_KHO As Integer, ByVal iYear As Int16) As NTP_Common.enuTRANGTHAI_KY_KIEMKE
        Dim ds As New DataSet
        ds = NTP_QLTTB.NTP_QLTTB_KHOA_SO_DAL.Instance.KiemTraKy(ID_KHO, iYear)
        'Kiem tra xem co gia tri khong, de biet ky nay co duoc nhap phieu vao khong
        If ds.Tables(0).Rows.Count > 0 Then
            Select Case ds.Tables(0).Rows(0).Item(0)
                Case 0
                    Return NTP_Common.enuTRANGTHAI_KY_KIEMKE.DA_KHOA_SO
                Case 1
                    Return NTP_Common.enuTRANGTHAI_KY_KIEMKE.KET_THUC_KIEMKE
            End Select
        Else
            Return NTP_Common.enuTRANGTHAI_KY_KIEMKE.CHUA_KIEMKE
        End If
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal iYear As Integer) As DataSet
        Return NTP_QLTTB.NTP_QLTTB_KHOA_SO_DAL.Instance.Search(ID_KHO, iYear)
    End Function

    Public Sub KhoaSo(ByVal iYear As Integer, ByVal ID_KHO As Integer, ByVal sMoTa As String, ByVal NguoiNM As Integer, ByVal NgayKK As Date)
        NTP_QLTTB.NTP_QLTTB_KHOA_SO_DAL.Instance.KhoaSo(iYear, ID_KHO, sMoTa, NguoiNM, NgayKK)
    End Sub

    Public Sub KetChuyenSoLieu(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Integer, ByVal UserID As Integer)
        NTP_QLTTB.NTP_QLTTB_KHOA_SO_DAL.Instance.KetChuyenSoLieu(ID_KHO, ID_KY_KIEMKE, UserID)
    End Sub

    Public Function BaoCaoKiemKe(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Integer) As DataSet
        Return NTP_QLTTB.NTP_QLTTB_KHOA_SO_DAL.Instance.BaoCaoKiemKe(ID_KHO, ID_KY_KIEMKE)
    End Function
End Class
