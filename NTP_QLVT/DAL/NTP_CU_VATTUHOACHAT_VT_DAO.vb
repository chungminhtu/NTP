Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

public class NTP_CU_VATTUHOACHAT_VT_DAO
	Inherits TL_DataProvider

	Public Sub New()
	MyBase.Initialize() 
	End Sub 

	Public Overloads Shared Function Instance() As NTP_CU_VATTUHOACHAT_VT_DAO
	Return CType(Instance(NAMESPACE_NAME & "." & "NTP_CU_VATTUHOACHAT_VT_DAO", ASSEMBLY_NAME), NTP_CU_VATTUHOACHAT_VT_DAO)
	End Function

	Public Sub InsertItem(ByVal bibi As NTP_CU_VATTUHOACHAT_VT_Info)
		SqlHelper.ExecuteNonQuery(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_VT_Insert", _
			Getnull(bibi.ID_CHITIET), _
			Getnull(bibi.ID_BAOCAO), _
			Getnull(bibi.ID_VATTU), _
			Getnull(bibi.TD_TINH), _
			Getnull(bibi.TD_BVHUYENTINH), _
			Getnull(bibi.N_TW_CAP), _
			Getnull(bibi.N_TINH_CAP), _
			Getnull(bibi.X_TOANTINH), _
			Getnull(bibi.X_SUDUNG), _
			Getnull(bibi.THUA_TINH), _
			Getnull(bibi.THUA_HUYEN), _
			Getnull(bibi.THIEU_TINH), _
			Getnull(bibi.THIEU_HUYEN), _
			Getnull(bibi.TC_TINH), _
			Getnull(bibi.TC_HUYEN))
	End Sub

	Public Sub UpdateItem(ByVal bibi As NTP_CU_VATTUHOACHAT_VT_Info)
		SqlHelper.ExecuteNonQuery(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_VT_Update", _
			Getnull(bibi.ID_CHITIET), _
			Getnull(bibi.ID_BAOCAO), _
			Getnull(bibi.ID_VATTU), _
			Getnull(bibi.TD_TINH), _
			Getnull(bibi.TD_BVHUYENTINH), _
			Getnull(bibi.N_TW_CAP), _
			Getnull(bibi.N_TINH_CAP), _
			Getnull(bibi.X_TOANTINH), _
			Getnull(bibi.X_SUDUNG), _
			Getnull(bibi.THUA_TINH), _
			Getnull(bibi.THUA_HUYEN), _
			Getnull(bibi.THIEU_TINH), _
			Getnull(bibi.THIEU_HUYEN), _
			Getnull(bibi.TC_TINH), _
			Getnull(bibi.TC_HUYEN))
	End Sub

	Public Sub DeleteItem()
		SqlHelper.ExecuteNonQuery(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_VT_Delete", _
)
	End Sub

	Public Function SelectAllItems() as DataSet
		Return SqlHelper.ExecuteDataSet(ConnectionString, _
			"NTP_CU_VATTUHOACHAT_VT_SelectList")
	End Function

End Class
