public class NTP_CU_SUDUNGTHUOC_BO

    Public Function InsertItem(ByVal objData As NTP_CU_SUDUNGTHUOC_Info) As Int64
        Dim ds As New DataSet
        ds = NTP_CU_SUDUNGTHUOC_DAL.Instance.InsertItem(objData)
        If ds.Tables(0).Rows.Count > 0 Then
            Return ds.Tables(0).Rows(0).Item(0)
        Else
            Return Nothing
        End If
    End Function

	Public Sub UpdateItem(ByVal objData As NTP_CU_SUDUNGTHUOC_Info)
		NTP_CU_SUDUNGTHUOC_DAL.Instance.UpdateItem(objData)
    End Sub

	Public Sub DeleteItem(ByVal ID_BAOCAO as double)
		NTP_CU_SUDUNGTHUOC_DAL.Instance.DeleteItem(ID_BAOCAO)
    End Sub

	Public Function SelectItem(ByVal ID_BAOCAO as double) as NTP_CU_SUDUNGTHUOC_Info

        Dim ds As DataSet = NTP_CU_SUDUNGTHUOC_DAL.Instance.SelectItem(ID_BAOCAO)
		Dim retVal As NTP_CU_SUDUNGTHUOC_Info
		If ds.Tables(0).Rows.Count > 0 Then
			Dim row as DataRow = ds.Tables(0).Rows(0)
			retVal=New NTP_CU_SUDUNGTHUOC_Info
			If not IsDBNull(row.Item("ID_BAOCAO")) Then retVal.ID_BAOCAO = row.Item("ID_BAOCAO")
			If not IsDBNull(row.Item("NAM")) Then retVal.NAM = row.Item("NAM")
			If not IsDBNull(row.Item("QUY")) Then retVal.QUY = row.Item("QUY")
			If not IsDBNull(row.Item("NGUOI_TAO")) Then retVal.NGUOI_TAO = row.Item("NGUOI_TAO")
			If not IsDBNull(row.Item("NGAY_TAO")) Then retVal.NGAY_TAO = row.Item("NGAY_TAO")
			If not IsDBNull(row.Item("ID_BENHVIEN_KHO")) Then retVal.ID_BENHVIEN_KHO = row.Item("ID_BENHVIEN_KHO")
			If not IsDBNull(row.Item("ID_MATINH")) Then retVal.ID_MATINH = row.Item("ID_MATINH")
		End If

		Return retVal
	End Function

	Public Function SelectAllItems() as DataSet
        Return NTP_CU_SUDUNGTHUOC_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal NAM As Int16) As DataSet
        Return NTP_CU_SUDUNGTHUOC_DAL.Instance.Search(ID_KHO, NAM)
    End Function

    Public Function SearchALL(ByVal NAM As Int16) As DataSet
        Return NTP_CU_SUDUNGTHUOC_DAL.Instance.SearchALL(NAM)
    End Function

    Public Function BC_SUDUNGTHUOC(ByVal ID_KHO As Integer, ByVal ID_BAOCAO As Int64, ByVal iType As Int16) As DataSet
        Return NTP_CU_SUDUNGTHUOC_DAL.Instance.BC_SUDUNGTHUOC(ID_KHO, ID_BAOCAO, iType)
    End Function

    Public Sub PheDuyet(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Double, ByVal NguoiPheDuyet As Integer)
        NTP_CU_SUDUNGTHUOC_DAL.Instance.PheDuyet(ID_KHO, ID_BAOCAO, NguoiPheDuyet)
    End Sub

    Public Function BC_SUDUNGTHUOC_TW(ByVal ID_KHO As Integer, ByVal ID_KY As Int16, ByVal NAM As Int16) As DataSet
        Return NTP_CU_SUDUNGTHUOC_DAL.Instance.BC_SUDUNGTHUOC_TW(ID_KHO, ID_KY, NAM)
    End Function

End Class
