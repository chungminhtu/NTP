Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_THIETBI_DAL
    Private Shared _thisInstance As NTP_CU_THIETBI_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_THIETBI_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_THIETBI_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Function InsertItem(ByVal bibi As NTP_CU_THIETBI_Info) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THIETBI_Insert", _
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

    Public Sub UpdateItem(ByVal bibi As NTP_CU_THIETBI_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THIETBI_Update", _
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
    End Sub

    Public Sub DeleteItem(ByVal ID_BAOCAO As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THIETBI_Delete", _
         GetNull(ID_BAOCAO))
    End Sub

    Public Function SelectItem(ByVal ID_BAOCAO As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THIETBI_Select", _
         GetNull(ID_BAOCAO))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THIETBI_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal Nam As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_THIETBI_Search", GetNull(ID_KHO), GetNull(Nam))
    End Function

    Public Sub PheDuyet(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Double, ByVal NguoiPheDuyet As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_CU_THIETBI_PHEDUYET", _
         GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(NguoiPheDuyet))
    End Sub

    Public Function BaoCao_SudungTTB_TuyenTinh(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                "NTP_CU_THIETBI_BC_SUDUNGTTB_TINH", GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function

    Public Function BaoCao_SudungTTB(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                "NTP_CU_THIETBI_BC_SUDUNGTTB", GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function


    Public Function BaoCao_SudungTTB_Sub(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Int64) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
               "NTP_CU_THIETBI_BC_SUDUNGTTB_SUB", GetNull(ID_KHO), GetNull(ID_BAOCAO))
    End Function


End Class
