public class NTP_QLVT_KY_KIEMKE_PHIEU_BO

	Public Sub InsertItem(ByVal objData As NTP_QLVT_KY_KIEMKE_PHIEU_Info)
        NTP_QLVT_KY_KIEMKE_PHIEU_DAL.Instance.InsertItem(objData)
    End Sub

	Public Sub UpdateItem(ByVal objData As NTP_QLVT_KY_KIEMKE_PHIEU_Info)
        NTP_QLVT_KY_KIEMKE_PHIEU_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem()
        NTP_QLVT_KY_KIEMKE_PHIEU_DAL.Instance.DeleteItem()
    End Sub

	Public Function SelectAllItems() as DataSet
        Return NTP_QLVT_KY_KIEMKE_PHIEU_DAL.Instance.SelectAllItems()
	End Function

End Class
