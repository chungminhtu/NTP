Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_CU_SUDUNGTHUOC_DAL
    Private Shared _thisInstance As NTP_CU_SUDUNGTHUOC_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_CU_SUDUNGTHUOC_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_CU_SUDUNGTHUOC_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Function InsertItem(ByVal bibi As NTP_CU_SUDUNGTHUOC_Info) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_Insert", _
         GetNull(bibi.ID_BAOCAO), _
         GetNull(bibi.NAM), _
         GetNull(bibi.QUY), _
         GetNull(bibi.NGUOI_TAO), _
         GetNull(bibi.NGAY_TAO), _
         GetNull(bibi.ID_BENHVIEN_KHO), _
         GetNull(bibi.ID_MATINH))
    End Function

    Public Sub UpdateItem(ByVal bibi As NTP_CU_SUDUNGTHUOC_Info)
        SqlHelper.ExecuteNonQuery(sqlConnectionString, _
         "NTP_CU_SUDUNGTHUOC_Update", _
         Getnull(bibi.ID_BAOCAO), _
         Getnull(bibi.NAM), _
         Getnull(bibi.QUY), _
         Getnull(bibi.NGUOI_TAO), _
         Getnull(bibi.NGAY_TAO), _
         Getnull(bibi.ID_BENHVIEN_KHO), _
         Getnull(bibi.ID_MATINH))
    End Sub

    Public Sub DeleteItem(ByVal ID_BAOCAO As Double)
        SqlHelper.ExecuteNonQuery(sqlConnectionString, _
         "NTP_CU_SUDUNGTHUOC_Delete", _
         Getnull(ID_BAOCAO))
    End Sub

    Public Function SelectItem(ByVal ID_BAOCAO As Double) As DataSet
        Return SqlHelper.ExecuteDataSet(sqlConnectionString, _
         "NTP_CU_SUDUNGTHUOC_Select", _
         Getnull(ID_BAOCAO))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(sqlConnectionString, _
         "NTP_CU_SUDUNGTHUOC_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Int64, ByVal Nam As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_Search", GetNull(ID_KHO), GetNull(Nam))
    End Function

    Public Function SearchALL(ByVal Nam As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_CU_SUDUNGTHUOC_SearchALL", GetNull(Nam))
    End Function

    Public Function BC_SUDUNGTHUOC(ByVal ID_KHO As Integer, ByVal ID_BAOCAO As Int64, ByVal iType As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_BC_SUDUNGTHUOC", GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(iType))
    End Function

    Public Sub PheDuyet(ByVal ID_KHO As Int64, ByVal ID_BAOCAO As Double, ByVal NguoiPheDuyet As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_BC_SUDUNGTHUOC_PHEDUYET", _
         GetNull(ID_KHO), GetNull(ID_BAOCAO), GetNull(NguoiPheDuyet))
    End Sub

    Public Function BC_SUDUNGTHUOC_TW(ByVal ID_KHO As Integer, ByVal ID_KY As Int16, ByVal NAM As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_BC_SUDUNGTHUOC_TW", GetNull(ID_KHO), GetNull(ID_KY), GetNull(NAM))
    End Function

End Class
