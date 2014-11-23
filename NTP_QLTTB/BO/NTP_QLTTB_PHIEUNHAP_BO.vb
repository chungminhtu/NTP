Imports NTP_QLTTB

Public Class NTP_QLTTB_PHIEUNHAP_BO
    Public Sub InsertItem(ByVal objData As NTP_QLTTB_PHIEUNHAP_Info)
        NTP_QLTTB_PHIEUNHAP_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_QLTTB_PHIEUNHAP_Info)
        NTP_QLTTB_PHIEUNHAP_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_PHIEUNHAP As Int64)
        NTP_QLTTB_PHIEUNHAP_DAL.Instance.DeleteItem(ID_PHIEUNHAP)
    End Sub

    Public Function SelectItem(ByVal ID_PHIEUNHAP As Int64) As NTP_QLTTB_PHIEUNHAP_Info
        Dim ds As DataSet = NTP_QLTTB_PHIEUNHAP_DAL.Instance.SelectItem(ID_PHIEUNHAP)
        Dim retVal As New NTP_QLTTB_PHIEUNHAP_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLTTB_PHIEUNHAP_Info
            If Not IsDBNull(row.Item("ID_PHIEUNHAP")) Then retVal.ID_PHIEUNHAP = row.Item("ID_PHIEUNHAP")
            If Not IsDBNull(row.Item("MA_PHIEUNHAP")) Then retVal.MA_PHIEUNHAP = row.Item("MA_PHIEUNHAP")
            If Not IsDBNull(row.Item("NGAY_NHAP")) Then retVal.NGAY_NHAP = row.Item("NGAY_NHAP")
            If Not IsDBNull(row.Item("NGUOI_NHAP")) Then retVal.NGUOI_NHAP = row.Item("NGUOI_NHAP")
            If Not IsDBNull(row.Item("ID_KHONHAP")) Then retVal.ID_KHONHAP = row.Item("ID_KHONHAP")
            If Not IsDBNull(row.Item("ID_KHOXUAT")) Then retVal.ID_KHOXUAT = row.Item("ID_KHOXUAT")
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
            If Not IsDBNull(row.Item("ID_LYDO_NHAPXUAT")) Then retVal.ID_LYDO_NHAPXUAT = row.Item("ID_LYDO_NHAPXUAT")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
            If Not IsDBNull(row.Item("NGAY_NM")) Then retVal.NGAY_NM = row.Item("NGAY_NM")
            If Not IsDBNull(row.Item("NGUOI_NM")) Then retVal.NGUOI_NM = row.Item("NGUOI_NM")
            If Not IsDBNull(row.Item("ID_PHIEUXUAT")) Then retVal.ID_PHIEUXUAT = row.Item("ID_PHIEUXUAT")
            If Not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
            If Not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
            If Not IsDBNull(row.Item("SO_PHIEUXUAT")) Then retVal.SO_PHIEUXUAT = row.Item("SO_PHIEUXUAT")
        End If
        Return retVal
    End Function

    Public Function SelectItemByMa(ByVal MA_PHIEUNHAP As String) As NTP_QLTTB_PHIEUNHAP_Info
        Dim ds As DataSet = NTP_QLTTB_PHIEUNHAP_DAL.Instance.SelectItemByMa(MA_PHIEUNHAP)
        Dim retVal As New NTP_QLTTB_PHIEUNHAP_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_QLTTB_PHIEUNHAP_Info
            If Not IsDBNull(row.Item("ID_PHIEUNHAP")) Then retVal.ID_PHIEUNHAP = row.Item("ID_PHIEUNHAP")
            If Not IsDBNull(row.Item("MA_PHIEUNHAP")) Then retVal.MA_PHIEUNHAP = row.Item("MA_PHIEUNHAP")
            If Not IsDBNull(row.Item("NGAY_NHAP")) Then retVal.NGAY_NHAP = row.Item("NGAY_NHAP")
            If Not IsDBNull(row.Item("NGUOI_NHAP")) Then retVal.NGUOI_NHAP = row.Item("NGUOI_NHAP")
            If Not IsDBNull(row.Item("ID_KHONHAP")) Then retVal.ID_KHONHAP = row.Item("ID_KHONHAP")
            If Not IsDBNull(row.Item("ID_KHOXUAT")) Then retVal.ID_KHOXUAT = row.Item("ID_KHOXUAT")
            If Not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
            If Not IsDBNull(row.Item("ID_LYDO_NHAPXUAT")) Then retVal.ID_LYDO_NHAPXUAT = row.Item("ID_LYDO_NHAPXUAT")
            If Not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
            If Not IsDBNull(row.Item("NGAY_NM")) Then retVal.NGAY_NM = row.Item("NGAY_NM")
            If Not IsDBNull(row.Item("NGUOI_NM")) Then retVal.NGUOI_NM = row.Item("NGUOI_NM")
            If Not IsDBNull(row.Item("ID_PHIEUXUAT")) Then retVal.ID_PHIEUXUAT = row.Item("ID_PHIEUXUAT")
            If Not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
            If Not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
            If Not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
            If Not IsDBNull(row.Item("SO_PHIEUXUAT")) Then retVal.SO_PHIEUXUAT = row.Item("SO_PHIEUXUAT")
        End If
        Return retVal
    End Function

  

    Public Function SelectAllItems() As DataSet
        Return NTP_QLTTB_PHIEUNHAP_DAL.Instance.SelectAllItems()
    End Function


    Public Function Search(ByVal sMA_PHIEUNHAP As String, ByVal iID_NGUONKINHPHI As Integer, ByVal dTU_NGAY As DateTime, ByVal dDEN_NGAY As DateTime) As DataSet
        Return NTP_QLTTB_PHIEUNHAP_DAL.Instance.Search(sMA_PHIEUNHAP, iID_NGUONKINHPHI, dTU_NGAY, dDEN_NGAY)
    End Function

End Class


