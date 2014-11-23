public class NTP_DM_BENHVIEN_BO

	Public Sub InsertItem(ByVal objData As NTP_DM_BENHVIEN_Info)
        NTP_DM_BENHVIEN_DAL.Instance.InsertItem(objData)
    End Sub

    Public Sub UpdateItem(ByVal objData As NTP_DM_BENHVIEN_Info)
        NTP_DM_BENHVIEN_DAL.Instance.UpdateItem(objData)
    End Sub

    Public Sub DeleteItem(ByVal ID_BENHVIEN As Integer)
        NTP_DM_BENHVIEN_DAL.Instance.DeleteItem(ID_BENHVIEN)
    End Sub

    Public Function SelectItem(ByVal ID_BENHVIEN As Integer) As NTP_DM_BENHVIEN_Info
        Dim ds As DataSet = NTP_DM_BENHVIEN_DAL.Instance.SelectItem(ID_BENHVIEN)
        Dim retVal As NTP_DM_BENHVIEN_Info = Nothing
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables(0).Rows(0)
            retVal = New NTP_DM_BENHVIEN_Info
            If Not IsDBNull(row.Item("ID_BENHVIEN")) Then retVal.ID_BENHVIEN = row.Item("ID_BENHVIEN")
            If Not IsDBNull(row.Item("TEN_BENHVIEN")) Then retVal.TEN_BENHVIEN = row.Item("TEN_BENHVIEN")
            If Not IsDBNull(row.Item("MA_BENHVIEN")) Then retVal.MA_BENHVIEN = row.Item("MA_BENHVIEN")
            If Not IsDBNull(row.Item("DIA_CHI")) Then retVal.DIA_CHI = row.Item("DIA_CHI")
            If Not IsDBNull(row.Item("ID_VUNG")) Then
                retVal.ID_VUNG = row.Item("ID_VUNG")
            Else
                retVal.ID_VUNG = SetNull(enuDATA_TYPE.INTEGER_TYPE)
            End If
            'If Not IsDBNull(row.Item("ID_MIEN")) Then
            '    retVal.ID_MIEN = row.Item("ID_MIEN")
            'Else
            '    retVal.ID_VUNG = SetNull(enuDATA_TYPE.INTEGER_TYPE)
            'End If
            If Not IsDBNull(row.Item("ID_CAP")) Then
                retVal.ID_CAP = row.Item("ID_CAP")
            Else
                retVal.ID_CAP = SetNull(enuDATA_TYPE.INTEGER_TYPE)
            End If
            If Not IsDBNull(row.Item("ID_BENHVIEN_CAPTREN")) Then
                retVal.ID_BENHVIEN_CAPTREN = row.Item("ID_BENHVIEN_CAPTREN")
            Else
                retVal.ID_BENHVIEN_CAPTREN = SetNull(enuDATA_TYPE.INTEGER_TYPE)
            End If
            If Not IsDBNull(row.Item("MA_BENHVIEN_CAPTREN")) Then retVal.MA_BENHVIEN_CAPTREN = row.Item("MA_BENHVIEN_CAPTREN")
            If Not IsDBNull(row.Item("ID_PHANLOAIYTE")) Then retVal.PHANLOAIYTE = row.Item("ID_PHANLOAIYTE")
            If Not IsDBNull(row.Item("ID_HUYEN")) Then retVal.ID_HUYEN = row.Item("ID_HUYEN")

        End If
        Return retVal
    End Function

    Public Function SelectAllItems() As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.SelectAllItems()
    End Function

    Public Function Search(ByVal sTEN_BENHVIEN As String, ByVal iID_VUNG As Integer) As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.Search(sTEN_BENHVIEN, iID_VUNG)
    End Function

    Public Function DanhsachBVTheoCap(ByVal iID_CAP As Integer) As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.DanhsachBVTheoCap(iID_CAP)
    End Function

    Public Function DanhsachBVChuaPhanCap() As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.DanhsachBVChuaPhanCap()
    End Function

    Public Sub PHANCAP(ByVal ID_BENHVIEN As Integer, ByVal ID_CAP As Integer)
        NTP_DM_BENHVIEN_DAL.Instance.PHANCAP(ID_BENHVIEN, ID_CAP)
    End Sub

    Public Function DanhsachBVTheoDonVi(ByVal iID_BENHVIEN As Integer) As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.DanhsachBVTheoDonVi(iID_BENHVIEN)
    End Function

    Public Function DanhsachBVChuaPhanDonVi() As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.DanhsachBVChuaPhanDonVi()
    End Function

    Public Sub CapNhatDonViCapTren(ByVal ID_BENHVIEN As Integer, ByVal iID_BENHVIEN_CAPTREN As Integer)
        NTP_DM_BENHVIEN_DAL.Instance.CapNhatDonViCapTren(ID_BENHVIEN, iID_BENHVIEN_CAPTREN)
    End Sub

    Public Function SearchUser(ByVal sSearchText As String, ByVal ID_BENHVIEN_KHO As Integer) As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.SearchUser(sSearchText, ID_BENHVIEN_KHO)
    End Function

    Public Function GetUserInBV(ByVal ID_BENHVIEN_KHO As Integer) As DataSet
        Return NTP_DM_BENHVIEN_DAL.Instance.GetUserInBV(ID_BENHVIEN_KHO)
    End Function

    Public Sub CapNhatUser_BV(ByVal ID_BENHVIEN_KHO As Integer, ByVal USERID As Integer)
        NTP_DM_BENHVIEN_DAL.Instance.CapNhatUser_BV(ID_BENHVIEN_KHO, USERID)
    End Sub

    Public Function GetID(ByVal MA_TINH As String) As String
        Return NTP_DM_BENHVIEN_DAL.Instance.GetID(MA_TINH)
    End Function
End Class


