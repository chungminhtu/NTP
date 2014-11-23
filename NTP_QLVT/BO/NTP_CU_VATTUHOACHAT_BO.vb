﻿public class NTP_CU_VATTUHOACHAT_BO

    Public Function InsertItem(ByVal objData As NTP_CU_VATTUHOACHAT_Info) As Int64
        Dim ds As New DataSet
        ds = NTP_CU_VATTUHOACHAT_DAL.Instance.InsertItem(objData)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds.Tables(0).Rows(0).Item(0)
        Else
            Return Nothing
        End If
    End Function

	Public Sub UpdateItem(ByVal objData As NTP_CU_VATTUHOACHAT_Info)
        NTP_CU_VATTUHOACHAT_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_BAOCAO as double)
        NTP_CU_VATTUHOACHAT_DAL.Instance.DeleteItem(ID_BAOCAO)
    End Sub

	Public Function SelectItem(ByVal ID_BAOCAO as double) as NTP_CU_VATTUHOACHAT_Info

        Dim ds As DataSet = NTP_CU_VATTUHOACHAT_DAL.Instance.SelectItem(ID_BAOCAO)
		Dim retVal As NTP_CU_VATTUHOACHAT_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_CU_VATTUHOACHAT_Info
			If not IsDBNull(row.Item("ID_BAOCAO")) Then retVal.ID_BAOCAO = row.Item("ID_BAOCAO")
			If not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
			If not IsDBNull(row.Item("QUY")) Then retVal.QUY = row.Item("QUY")
			If not IsDBNull(row.Item("NGUOI_TAO")) Then retVal.NGUOI_TAO = row.Item("NGUOI_TAO")
			If not IsDBNull(row.Item("NGAY_TAO")) Then retVal.NGAY_TAO = row.Item("NGAY_TAO")
			If not IsDBNull(row.Item("ID_BENHVIEN_KHO")) Then retVal.ID_BENHVIEN_KHO = row.Item("ID_BENHVIEN_KHO")
			If not IsDBNull(row.Item("ID_MATINH")) Then retVal.ID_MATINH = row.Item("ID_MATINH")
			If not IsDBNull(row.Item("TRANG_THAI")) Then retVal.TRANG_THAI = row.Item("TRANG_THAI")
			If not IsDBNull(row.Item("NGUOI_PHEDUYET")) Then retVal.NGUOI_PHEDUYET = row.Item("NGUOI_PHEDUYET")
			If not IsDBNull(row.Item("NGAY_PHEDUYET")) Then retVal.NGAY_PHEDUYET = row.Item("NGAY_PHEDUYET")
		End If
        Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.SelectAllItems()
	End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal Nam As Int16) As DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.Search(ID_KHO, Nam)
    End Function

    Public Function SearchByMaTinh(ByVal ID_TINH As Int64, ByVal Nam As Int16) As DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.SearchByMaTinh(ID_TINH, Nam)
    End Function

    Public Sub PheDuyet(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Double, ByVal NguoiPheDuyet As Integer)
        NTP_CU_VATTUHOACHAT_DAL.Instance.PheDuyet(ID_KHO, ID_BAOCAO, NguoiPheDuyet)
    End Sub


    Public Function BaoCaoHC_VT_Main_tuyentinh(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.BaoCaoHC_VT_Main_tuyentinh(ID_KHO, ID_BAOCAO)
    End Function

    Public Function BaoCaoVattu_tuyentinh(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.BaoCaoVattu_tuyentinh(ID_KHO, ID_BAOCAO)
    End Function

    Public Function BaoCaoHoaChat_tuyentinh(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.BaoCaoHoaChat_tuyentinh(ID_KHO, ID_BAOCAO)
    End Function

    Public Function BaoCao_SUDUNGVATTU(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.BaoCao_SUDUNGVATTU(ID_KHO, ID_BAOCAO)
    End Function

    Public Function BaoCao_SUDUNGVATTU_SUB(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return NTP_CU_VATTUHOACHAT_DAL.Instance.BaoCao_SUDUNGVATTU_SUB(ID_KHO, ID_BAOCAO)
    End Function
End Class
