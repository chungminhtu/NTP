Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT
Public Class QLT_KIEMKE_DAL

    ''Public Sub New()
    ''    MyBase.Initialize()
    ''End Sub

    'Public Overloads Shared Function Instance() As NTP_QLT_KIEMKE_DAO
    '    Return CType(Instance(NAMESPACE_NAME & "." & "NTP_QLT_KIEMKE_DAO", ASSEMBLY_NAME), NTP_QLT_KIEMKE_DAO)
    'End Function

    Function InsertItem(ByVal bibi As NTP_QLT.QLT_KIEMKE_Info)
        Return SqlHelper.ExecuteScalar(SQLConnectionString, _
         "NTP_QLT_KIEMKE_Insert", _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.NGAY_KIEMKE), _
         Getnull(bibi.NGUOI_KIEM), _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.GHI_CHU))
    End Function

    Public Sub UpdateItem(ByVal bibi As NTP_QLT.QLT_KIEMKE_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KIEMKE_Update", _
         Getnull(bibi.ID_KIEMKE), _
         Getnull(bibi.ID_KY_KIEMKE), _
         Getnull(bibi.NGAY_KIEMKE), _
         Getnull(bibi.NGUOI_KIEM), _
         Getnull(bibi.ID_KHO), _
         Getnull(bibi.GHI_CHU))
    End Sub

    Public Sub DeleteItem(ByVal ID_KIEMKE As Double)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_QLT_KIEMKE_Delete", _
         Getnull(ID_KIEMKE))
    End Sub

    Public Function SelectItem(ByVal ID_KIEMKE As Double) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KIEMKE_Select", _
         Getnull(ID_KIEMKE))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_QLT_KIEMKE_SelectList")
    End Function
End Class
