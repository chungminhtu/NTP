Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_BENHVIEN_DAL

    Private Shared _thisInstance As NTP_DM_BENHVIEN_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_BENHVIEN_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_BENHVIEN_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_BENHVIEN_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_BENHVIEN_Insert", _
         GetNull(bibi.ID_BENHVIEN), _
         GetNull(bibi.TEN_BENHVIEN), _
        GetNull(bibi.ID_VUNG), _
        GetNull(bibi.ID_MIEN), _
        GetNull(bibi.ID_CAP), _
        GetNull(bibi.MA_BENHVIEN), _
        GetNull(bibi.ID_BENHVIEN_CAPTREN), _
        GetNull(bibi.MA_BENHVIEN_CAPTREN), _
        GetNull(bibi.DIA_CHI), _
        GetNull(bibi.PHANLOAIYTE), _
        GetNull(bibi.ID_HUYEN))
    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_BENHVIEN_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_BENHVIEN_Update", _
         GetNull(bibi.ID_BENHVIEN), _
         GetNull(bibi.TEN_BENHVIEN), _
        GetNull(bibi.ID_VUNG), _
        GetNull(bibi.ID_MIEN), _
        GetNull(bibi.ID_CAP), _
        GetNull(bibi.MA_BENHVIEN), _
        GetNull(bibi.ID_BENHVIEN_CAPTREN), _
        GetNull(bibi.MA_BENHVIEN_CAPTREN), _
        GetNull(bibi.DIA_CHI), _
        GetNull(bibi.PHANLOAIYTE), _
        GetNull(bibi.ID_HUYEN))
    End Sub

    Public Sub DeleteItem(ByVal ID_BENHVIEN As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_BENHVIEN_Delete", _
         Getnull(ID_BENHVIEN))
    End Sub

    Public Function SelectItem(ByVal ID_BENHVIEN As Integer) As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_BENHVIEN_Select", _
         Getnull(ID_BENHVIEN))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_BENHVIEN_SelectList")
    End Function

    Public Function Search(ByVal sTEN_BENHVIEN As String, ByVal iID_VUNG As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_BENHVIEN_Search", Getnull(sTEN_BENHVIEN), Getnull(iID_VUNG))
    End Function


    Public Function DanhsachBVTheoCap(ByVal iID_CAP As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_BENHVIEN_DaPhanCap", GetNull(iID_CAP))
    End Function

    Public Function DanhsachBVChuaPhanCap() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_BENHVIEN_ChuaPhanCap")
    End Function

    Public Sub PHANCAP(ByVal ID_BENHVIEN As Integer, ByVal ID_CAP As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
               "NTP_DM_BENHVIEN_PHANCAP", _
               GetNull(ID_BENHVIEN), GetNull(ID_CAP))
    End Sub

    Public Function DanhsachBVTheoDonVi(ByVal iID_BENHVIEN As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_BENHVIEN_DS_BV_THEODONVI", GetNull(iID_BENHVIEN))
    End Function

    Public Function DanhsachBVChuaPhanDonVi() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_BENHVIEN_DS_BV_CHUAPHAN_DONVI")
    End Function

    Public Sub CapNhatDonViCapTren(ByVal ID_BENHVIEN As Integer, ByVal iID_BENHVIEN_CAPTREN As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
               "NTP_DM_BENHVIEN_CapNhatDonViCapTren", _
               GetNull(ID_BENHVIEN), GetNull(iID_BENHVIEN_CAPTREN))
    End Sub

    Public Function SearchUser(ByVal sSearchText As String, ByVal ID_BENHVIEN_KHO As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
          "NTP_DM_BENHVIEN_SEARCH_USER", GetNull(sSearchText), GetNull(ID_BENHVIEN_KHO))
    End Function

    Public Function GetUserInBV(ByVal ID_BENHVIEN_KHO As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_BENHVIEN_GetUserInBV", GetNull(ID_BENHVIEN_KHO))
    End Function

    Public Sub CapNhatUser_BV(ByVal ID_BENHVIEN_KHO As Integer, ByVal USERID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
            "NTP_DM_BENHVIEN_CapNhatUser_BV", _
            GetNull(ID_BENHVIEN_KHO), GetNull(USERID))
    End Sub


    Public Function GetID(ByVal MA_TINH As String) As String
        Dim ID As String = SqlHelper.ExecuteScalar(SQLConnectionString, _
          "NTP_DM_BENHVIEN_GetID", GetNull(MA_TINH))
        Dim str As String = ""
        If ID < 10 Then
            str = MA_TINH + "0" + ID.ToString
        Else
            str = MA_TINH + ID.ToString
        End If
        Return str
    End Function
End Class
