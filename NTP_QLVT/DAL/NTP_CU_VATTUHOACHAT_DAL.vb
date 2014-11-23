Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_VATTUHOACHAT_DAL
    Private Shared _thisInstance As NTP_CU_VATTUHOACHAT_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_VATTUHOACHAT_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_VATTUHOACHAT_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Function InsertItem(ByVal bibi As NTP_CU_VATTUHOACHAT_Info) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_Insert", _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.NAM), _
         GetNull(bibi.QUY), _
         GetNull(bibi.NGUOI_TAO), _
         GetNull(bibi.NGAY_TAO), _
         GetNull(bibi.ID_BENHVIEN_KHO), _
         GetNull(bibi.ID_MATINH), _
         GetNull(bibi.TRANG_THAI), _
         GetNull(bibi.NGUOI_PHEDUYET), _
         GetNull(bibi.NGAY_PHEDUYET))
    End Function

    Public Sub UpdateItem(ByVal bibi As NTP_CU_VATTUHOACHAT_Info)
        SqlHelper.ExecuteNonQuery(sqlConnectionString, _
         "NTP_CU_VATTUHOACHAT_Update", _
         Getnull(bibi.ID_BAOCAO), _
         Getnull(bibi.NAM), _
         Getnull(bibi.QUY), _
         Getnull(bibi.NGUOI_TAO), _
         Getnull(bibi.NGAY_TAO), _
         Getnull(bibi.ID_BENHVIEN_KHO), _
         Getnull(bibi.ID_MATINH), _
         Getnull(bibi.TRANG_THAI), _
         Getnull(bibi.NGUOI_PHEDUYET), _
         Getnull(bibi.NGAY_PHEDUYET))
    End Sub

    Public Sub DeleteItem(ByVal ID_BAOCAO As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_Delete", _
         GetNull(ID_BAOCAO))
    End Sub

    Public Function SelectItem(ByVal ID_BAOCAO As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_Select", _
         GetNull(ID_BAOCAO))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(sqlConnectionString, _
         "NTP_CU_VATTUHOACHAT_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal Nam As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_Search", GetNull(ID_KHO), GetNull(Nam))
    End Function

    Public Function SearchByMaTinh(ByVal ID_TINH As Int64, ByVal Nam As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "[NTP_CU_VATTUHOACHAT_Search_ByUserID]", GetNull(ID_TINH), GetNull(Nam))
    End Function

    Public Sub PheDuyet(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Double, ByVal NguoiPheDuyet As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_VATTUHOACHAT_PHEDUYET", _
         GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(NguoiPheDuyet))
    End Sub

    Public Function BaoCaoHC_VT_Main_tuyentinh(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
       "NTP_CU_VATTUHOACHAT_BC_MAIN", _
       GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function

    Public Function BaoCaoVattu_tuyentinh(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
      "NTP_CU_VATTUHOACHAT_BC_VT", _
      GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function

    Public Function BaoCaoHoaChat_tuyentinh(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
      "NTP_CU_VATTUHOACHAT_BC_HC", _
      GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function

    Public Function BaoCao_SUDUNGVATTU(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
      "NTP_CU_VATTUHOACHAT_BC_SUDUNGVATTU", _
      GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function


    Public Function BaoCao_SUDUNGVATTU_SUB(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
      "NTP_CU_VATTUHOACHAT_BC_SUDUNGVATTU_SUB", _
      GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function
End Class
