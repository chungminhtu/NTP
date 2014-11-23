Imports Microsoft.ApplicationBlocks.Data
Imports NTP_Common.Configuration
Imports NTP_Common.Common
Imports NTP_DAL
Imports NTP_QLT

Public Class QLT_DM_THUOC_BO
    Public Sub InsertItem(ByVal objData As QLT_DM_THUOC_Info)
        Dim bibi As New QLT_DM_THUOC_DAL
        bibi.InsertItem(objData)
        bibi = Nothing
    End Sub

    Public Sub UpdateItem(ByVal objData As QLT_DM_THUOC_Info)
        Dim bibi As New QLT_DM_THUOC_DAL
        bibi.UpdateItem(objData)
        bibi = Nothing
    End Sub

    Public Sub DeleteItem(ByVal ID_THUOC As Integer)
        Dim bibi As New QLT_DM_THUOC_DAL
        bibi.DeleteItem(ID_THUOC)
        bibi = Nothing
    End Sub

    Public Function SelectItem(ByVal ID_THUOC As Integer) As QLT_DM_THUOC_Info
        Dim bibi As New QLT_DM_THUOC_DAL
        Dim ds As DataSet = bibi.SelectItem(ID_THUOC)
        Dim retVal As QLT_DM_THUOC_Info
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New QLT_DM_THUOC_Info
            If Not IsDBNull(row.Item("ID_THUOC")) Then retVal.ID_THUOC = row.Item("ID_THUOC")
            If Not IsDBNull(row.Item("MA_THUOC")) Then retVal.MA_THUOC = row.Item("MA_THUOC")
            If Not IsDBNull(row.Item("TEN_THUOC")) Then retVal.TEN_THUOC = row.Item("TEN_THUOC")
            If Not IsDBNull(row.Item("HAM_LUONG")) Then retVal.HAM_LUONG = row.Item("HAM_LUONG")
            If Not IsDBNull(row.Item("MA_NUOC")) Then retVal.MA_NUOC = row.Item("MA_NUOC")
            If Not IsDBNull(row.Item("ID_DVT")) Then retVal.ID_DVT = row.Item("ID_DVT")
        End If
        bibi = Nothing
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return (New QLT_DM_THUOC_DAL).SelectAllItems()
    End Function

    Public Function Search(ByVal sTen_Thuoc As String) As DataSet
        Return (New QLT_DM_THUOC_DAL).search(sTen_Thuoc)
    End Function

    Public Function searchLo(ByVal ID_Thuoc As Integer, ByVal ID_Kho As Integer) As DataSet
        Return (New QLT_DM_THUOC_DAL).SearchLo(ID_Thuoc, ID_Kho)
    End Function

    Public Sub Update_LoSX(ByVal ID_Thuoc As Integer, ByVal Lo_SX As String, ByVal Lo_SXCu As String, ByVal ID_Kho As Integer)
        Dim bibi As New QLT_DM_THUOC_DAL
        bibi.Update_LoSX(ID_Thuoc, Lo_SX, Lo_SXCu, ID_Kho)
        bibi = Nothing

    End Sub

End Class
