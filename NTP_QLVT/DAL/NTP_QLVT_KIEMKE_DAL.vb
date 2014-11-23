Imports NTP_Common.Common
Imports NTP_Common.Configuration
Imports NTP_DAL

Public Class NTP_QLVT_KIEMKE_DAL
    Private Shared _thisInstance As NTP_QLVT_KIEMKE_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_QLVT_KIEMKE_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_QLVT_KIEMKE_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Function InsertItem(ByVal bibi As NTP_QLVT_KIEMKE_Info) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KIEMKE_Insert", _
         Getnull(bibi.ID_KIEMKE), _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.NGAY_KIEMKE), _
         Getnull(bibi.NGUOI_KIEMKE), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.ID_NGUONKINHPHI), _
         Getnull(bibi.TRANG_THAI))
    End Function

    Public Sub UpdateItem(ByVal bibi As NTP_QLVT_KIEMKE_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_KIEMKE_Update", _
         Getnull(bibi.ID_KIEMKE), _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.NGAY_KIEMKE), _
         Getnull(bibi.NGUOI_KIEMKE), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.GHI_CHU), _
         Getnull(bibi.ID_NGUONKINHPHI), _
         Getnull(bibi.TRANG_THAI))
    End Sub

    Public Sub DeleteItem(ByVal ID_KIEMKE As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLVT_KIEMKE_Delete", _
         Getnull(ID_KIEMKE))
    End Sub

    Public Function SelectItem(ByVal ID_KIEMKE As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KIEMKE_Select", _
         Getnull(ID_KIEMKE))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLVT_KIEMKE_SelectList")
    End Function

    Public Function Search(ByVal ID_KHO As Integer, ByVal dtFromDate As Date, ByVal dtToDate As Date, ByVal iNguonKinhPhi As Integer) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
      "NTP_QLVT_KIEMKE_Search", Getnull(ID_KHO), Getnull(dtFromDate), Getnull(dtToDate), Getnull(iNguonKinhPhi))
    End Function
End Class
