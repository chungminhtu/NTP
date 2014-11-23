public class NTP_QLVT_KY_KIEMKE_BO

	Public Sub InsertItem(ByVal objData As NTP_QLVT_KY_KIEMKE_Info)
        NTP_QLVT_KY_KIEMKE_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_QLVT_KY_KIEMKE_Info)
        NTP_QLVT_KY_KIEMKE_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_KY_KIEMKE As Int64)
        NTP_QLVT_KY_KIEMKE_DAL.Instance.DeleteItem(ID_KY_KIEMKE)
    End Sub

    Public Function SelectItem(ByVal ID_KY_KIEMKE As Int64) As NTP_QLVT_KY_KIEMKE_Info
        Dim ds As DataSet = NTP_QLVT_KY_KIEMKE_DAL.Instance.SelectItem(ID_KY_KIEMKE)
        Dim retVal As NTP_QLVT_KY_KIEMKE_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLVT_KY_KIEMKE_Info
            If Not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("ID_KHO")) Then retVal.ID_KHO = row.Item("ID_KHO")
            If Not IsDBNull(row.Item("NGAY_BATDAU")) Then retVal.NGAY_BATDAU = row.Item("NGAY_BATDAU")
            If Not IsDBNull(row.Item("NGAY_KETTHUC")) Then retVal.NGAY_KETTHUC = row.Item("NGAY_KETTHUC")
            If Not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
            If Not IsDBNull(row.Item("TEN_KY_KIEMKE")) Then retVal.TEN_KY_KIEMKE = row.Item("TEN_KY_KIEMKE")
        End If
        Return retVal
    End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.SelectAllItems()
	End Function

    Public Sub KhoaSoKiemKe(ByVal ID_KHO_QLVT As Integer, ByVal iThang As Integer, ByVal iNam As Integer, ByVal sMO_TA As String, ByVal iNguoiNM As Integer, ByVal LAN_KIEMKE As Int16)
        NTP_QLVT_KY_KIEMKE_DAL.Instance.KhoaSoKiemKe(ID_KHO_QLVT, iThang, iNam, sMO_TA, iNguoiNM, LAN_KIEMKE)
    End Sub

    Public Sub test()
        NTP_QLVT_KY_KIEMKE_DAL.Instance.test()
    End Sub


    Public Function KiemTraKy(ByVal id_kho As Integer, ByVal Thang As Integer, ByVal Nam As Integer) As NTP_Common.enuTRANGTHAI_KY_KIEMKE
        'Kiem tra xem co gia tri khong, de biet ky nay co duoc nhap phieu vao khong
        Dim ds As New DataSet
        ds = NTP_QLVT_KY_KIEMKE_DAL.Instance.KiemTraKy(id_kho, Thang, Nam)
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

    Public Function GetKyDaKiemKe(ByVal ID_KHO As Integer, ByVal Nam As Integer) As ArrayList
        Dim ds As New DataSet
        ds = NTP_QLVT_KY_KIEMKE_DAL.Instance.GetKyDaKiemKe(ID_KHO, Nam)
        Dim ret As New ArrayList
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            ret.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        Return ret
    End Function

    Public Function CHECK_KY_KIEMKE_EXIST(ByVal ID_KHO As Integer) As Boolean
        Dim ds As New DataSet
        ds = NTP_QLVT_KY_KIEMKE_DAL.Instance.CHECK_KY_KIEMKE_EXIST(ID_KHO)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub GET_LASTEST_KY_KIEMKE(ByVal ID_KHO As Integer, ByRef iThang As Int16, ByRef iNam As Int16, ByRef iTrangThai As Int16)
        Dim ds As New DataSet
        ds = NTP_QLVT_KY_KIEMKE_DAL.Instance.GET_LASTEST_KY_KIEMKE(ID_KHO)
        If ds.Tables(0).Rows.Count > 0 Then
            iThang = ds.Tables(0).Rows(0).Item(0)
            iNam = ds.Tables(0).Rows(0).Item(1)
            iTrangThai = ds.Tables(0).Rows(0).Item(2)
        Else
            iThang = -1
            iNam = -1
            iTrangThai = -1
        End If
    End Sub

    Public Function Search(ByVal ID_KHO As Integer, ByVal Nam As Int16) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.Search(ID_KHO, Nam)
    End Function

    Public Sub KetChuyenSoLieu(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64, ByVal NGUOI_NM As Integer)
        NTP_QLVT_KY_KIEMKE_DAL.Instance.KetChuyenSoLieu(ID_KHO, ID_KY_KIEMKE, NGUOI_NM)
    End Sub

    Public Function BaoCaoKiemKe(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.BaoCaoKiemKe(ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoVattu_tuyenhuyen(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.BaoCaoVattu_tuyenhuyen(ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoHC_VT_Main_tuyentinh(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.BaoCaoHC_VT_Main_tuyentinh(ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoVattu_tuyentinh(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.BaoCaoVattu_tuyentinh(ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function BaoCaoHoaChat_tuyentinh(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Int64) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.BaoCaoHoaChat_tuyentinh(ID_KHO, ID_KY_KIEMKE)
    End Function

    Public Function SO_THEODOI_VATTU(ByVal ID_KHO As Integer, ByVal dtDateFrom As Date, ByVal dtDateTo As Date, ByVal ID_VATTU As Integer) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.SO_THEODOI_VATTU(ID_KHO, dtDateFrom, dtDateTo, ID_VATTU)
    End Function

    Public Function SO_THEODOI_HOACHAT(ByVal ID_KHO As Integer, ByVal dtDateFrom As Date, ByVal dtDateTo As Date, ByVal ID_VATTU As Integer) As DataSet
        Return NTP_QLVT_KY_KIEMKE_DAL.Instance.SO_THEODOI_HOACHAT(ID_KHO, dtDateFrom, dtDateTo, ID_VATTU)
    End Function
End Class
