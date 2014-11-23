public class NTP_QLVT_PHIEUNHAP_BO

    Public Function InsertItem(ByVal objData As NTP_QLVT_PHIEUNHAP_Info) As Double
        Dim ds As New DataSet
        ds = NTP_QLVT_PHIEUNHAP_DAL.Instance.InsertItem(objData)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds.Tables(0).Rows(0).Item(0)
        Else
            Return Double.MinValue
        End If
    End Function

	Public Sub UpdateItem(ByVal objData As NTP_QLVT_PHIEUNHAP_Info)

        NTP_QLVT_PHIEUNHAP_DAL.Instance.UpdateItem(objData)

	End Sub

	Public Sub DeleteItem(ByVal ID_PHIEUNHAP as double)

        NTP_QLVT_PHIEUNHAP_DAL.Instance.DeleteItem(ID_PHIEUNHAP)

	End Sub

	Public Function SelectItem(ByVal ID_PHIEUNHAP as double) as NTP_QLVT_PHIEUNHAP_Info

        Dim ds As DataSet = NTP_QLVT_PHIEUNHAP_DAL.Instance.SelectItem(ID_PHIEUNHAP)
		Dim retVal As NTP_QLVT_PHIEUNHAP_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_QLVT_PHIEUNHAP_Info
			If not IsDBNull(row.Item("ID_PHIEUNHAP")) Then retVal.ID_PHIEUNHAP = row.Item("ID_PHIEUNHAP")
			If not IsDBNull(row.Item("MA_PHIEUNHAP")) Then retVal.MA_PHIEUNHAP = row.Item("MA_PHIEUNHAP")
			If not IsDBNull(row.Item("NGAY_NHAP")) Then retVal.NGAY_NHAP = row.Item("NGAY_NHAP")
			If not IsDBNull(row.Item("NGUOI_NHAP")) Then retVal.NGUOI_NHAP = row.Item("NGUOI_NHAP")
			If not IsDBNull(row.Item("ID_KHONHAP")) Then retVal.ID_KHONHAP = row.Item("ID_KHONHAP")
			If not IsDBNull(row.Item("ID_KHOXUAT")) Then retVal.ID_KHOXUAT = row.Item("ID_KHOXUAT")
			If not IsDBNull(row.Item("ID_NGUONKINHPHI")) Then retVal.ID_NGUONKINHPHI = row.Item("ID_NGUONKINHPHI")
			If not IsDBNull(row.Item("ID_LYDO_NHAPXUAT")) Then retVal.ID_LYDO_NHAPXUAT = row.Item("ID_LYDO_NHAPXUAT")
			If not IsDBNull(row.Item("GHI_CHU")) Then retVal.GHI_CHU = row.Item("GHI_CHU")
			If not IsDBNull(row.Item("NGAY_NM")) Then retVal.NGAY_NM = row.Item("NGAY_NM")
			If not IsDBNull(row.Item("NGUOI_NM")) Then retVal.NGUOI_NM = row.Item("NGUOI_NM")
			If not IsDBNull(row.Item("ID_PHIEUXUAT")) Then retVal.ID_PHIEUXUAT = row.Item("ID_PHIEUXUAT")
			If not IsDBNull(row.Item("ID_KY_KIEMKE")) Then retVal.ID_KY_KIEMKE = row.Item("ID_KY_KIEMKE")
			If not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
            If Not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
            If Not IsDBNull(row.Item("SO_PHIEUXUAT")) Then retVal.SO_PHIEUXUAT = row.Item("SO_PHIEUXUAT")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_QLVT_PHIEUNHAP_DAL.Instance.SelectAllItems()
	End Function

    Public Function Search(ByVal ID_KHONHAP As Integer, ByVal sMA_PHIEU As String, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return NTP_QLVT_PHIEUNHAP_DAL.Instance.Search(ID_KHONHAP, sMA_PHIEU, dtFromDate, dtToDate, iNguonKinhPhi)
    End Function


End Class
