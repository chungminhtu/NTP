Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLTTB_KHOA_SO_DAL

    Private Shared _thisInstance As NTP_QLTTB_KHOA_SO_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLTTB_KHOA_SO_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLTTB_KHOA_SO_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Function KiemTraKy(ByVal ID_KHO As Integer, ByVal iYear As Int16) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
              "NTP_QLTTB_KIEMTRAKY", _
              GetNull(ID_KHO), GetNull(iYear))
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal iYear As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                  "NTP_QLTTB_KHOASO_SEARCH", _
                  GetNull(ID_KHO), GetNull(iYear))
    End Function

    Public Sub KhoaSo(ByVal iYear As Integer, ByVal ID_KHO As Integer, ByVal sMoTa As String, ByVal NguoiNM As Integer, ByVal NgayKK As Date)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
                   "NTP_QLTTB_KHOASO", _
                   GetNull(iYear), _
                   GetNull(ID_KHO), GetNull(sMoTa), GetNull(NguoiNM), GetNull(NgayKK))
    End Sub

    Public Sub KetChuyenSoLieu(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Integer, ByVal UserID As Integer)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
                  "NTP_QLTTB_KETCHUYENSOLIEU", _
                  GetNull(ID_KHO), GetNull(ID_KY_KIEMKE), GetNull(UserID))
    End Sub

    Public Function BaoCaoKiemKe(ByVal ID_KHO As Integer, ByVal ID_KY_KIEMKE As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
                 "NTP_QLTTB_BAOCAOKIEMKE", _
                 GetNull(ID_KHO), GetNull(ID_KY_KIEMKE))
    End Function
End Class
