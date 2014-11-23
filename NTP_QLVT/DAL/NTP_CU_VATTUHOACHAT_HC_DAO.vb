Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

public class NTP_CU_VATTUHOACHAT_HC_DAO
	Inherits TL_DataProvider

	Public Sub New()
	MyBase.Initialize() 
	End Sub 

	Public Overloads Shared Function Instance() As NTP_CU_VATTUHOACHAT_HC_DAO
	Return CType(Instance(NAMESPACE_NAME & "." & "NTP_CU_VATTUHOACHAT_HC_DAO", ASSEMBLY_NAME), NTP_CU_VATTUHOACHAT_HC_DAO)
	End Function

	Public Sub InsertItem(ByVal bibi As NTP_CU_VATTUHOACHAT_HC_Info)
		SqlHelper.ExecuteNonQuery(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_HC_Insert", _
			Getnull(bibi.ID_CHITIET), _
			Getnull(bibi.ID_BAOCAO), _
			Getnull(bibi.ID_VATTU), _
			Getnull(bibi.TON_DAU), _
			Getnull(bibi.NHAP), _
			Getnull(bibi.XUAT), _
			Getnull(bibi.THUA), _
			Getnull(bibi.THIEU_HONG), _
			Getnull(bibi.TON_CUOI), _
			Getnull(bibi.HAN_SUDUNG), _
			Getnull(bibi.NGUOI_NM), _
			Getnull(bibi.NGAY_NM), _
			Getnull(bibi.GHI_CHU))
	End Sub

	Public Sub UpdateItem(ByVal bibi As NTP_CU_VATTUHOACHAT_HC_Info)
		SqlHelper.ExecuteNonQuery(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_HC_Update", _
			Getnull(bibi.ID_CHITIET), _
			Getnull(bibi.ID_BAOCAO), _
			Getnull(bibi.ID_VATTU), _
			Getnull(bibi.TON_DAU), _
			Getnull(bibi.NHAP), _
			Getnull(bibi.XUAT), _
			Getnull(bibi.THUA), _
			Getnull(bibi.THIEU_HONG), _
			Getnull(bibi.TON_CUOI), _
			Getnull(bibi.HAN_SUDUNG), _
			Getnull(bibi.NGUOI_NM), _
			Getnull(bibi.NGAY_NM), _
			Getnull(bibi.GHI_CHU))
	End Sub

	Public Sub DeleteItem(ByVal ID_CHITIET as double)
		SqlHelper.ExecuteNonQuery(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_HC_Delete", _
			Getnull(bibi.ID_CHITIET))
	End Sub

	Public Function SelectItem(ByVal ID_CHITIET as double) as DataSet
		Return SqlHelper.ExecuteDataSet(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_HC_Select", _
			Getnull(bibi.ID_CHITIET))
	End Function

	Public Function SelectAllItems() as DataSet
		Return SqlHelper.ExecuteDataSet(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_HC_SelectList")
	End Function

End Class
