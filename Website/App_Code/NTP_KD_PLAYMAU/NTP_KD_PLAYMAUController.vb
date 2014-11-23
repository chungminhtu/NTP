'
' DotNetNuke® - http://www.dotnetnuke.com
' Copyright (c) 2002-2006
' by Perpetual Motion Interactive Systems Inc. ( http://www.perpetualmotion.ca )
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'

Imports System
Imports System.Configuration
Imports System.Data
Imports System.XML
Imports System.Web
Imports System.Collections.Generic
Imports DotNetNuke
Imports DotNetNuke.Services.Search
Imports DotNetNuke.Common.Utilities.XmlUtils

Namespace YourCompany.Modules.NTP_KD_PLAYMAU

    ''' <summary>
    ''' The Controller class for NTP_KD_PLAYMAU
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------



    Public Class NTP_KD_PLAYMAUController


#Region "Public Methods"
        Public Function [Get](ByVal iD_PLAYMAU As Integer) As NTP_KD_PLAYMAUInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_KD_PLAYMAU(iD_PLAYMAU), GetType(NTP_KD_PLAYMAUInfo)), NTP_KD_PLAYMAUInfo)

        End Function
        
        Public Function List() As List(Of NTP_KD_PLAYMAUInfo)

            Return CBO.FillCollection(Of NTP_KD_PLAYMAUInfo)(DataProvider.Instance().ListNTP_KD_PLAYMAU())

        End Function
        Public Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal opt As Integer, ByVal Id_MATINH As String) As List(Of NTP_KD_PLAYMAUInfo)

            Return CBO.FillCollection(Of NTP_KD_PLAYMAUInfo)(DataProvider.Instance().ListByDieuKien(Id_BenhVien, ThangNam, DieuKien, opt, Id_MATINH))

        End Function
        Public Function Add(ByVal objNTP_KD_PLAYMAU As NTP_KD_PLAYMAUInfo) As Integer
            Return CType(DataProvider.Instance().AddNTP_KD_PLAYMAU(objNTP_KD_PLAYMAU.ThangLM, objNTP_KD_PLAYMAU.Nam, objNTP_KD_PLAYMAU.MA_TINH, objNTP_KD_PLAYMAU.ID_BENHVIEN, objNTP_KD_PLAYMAU.KTVien, objNTP_KD_PLAYMAU.Nhanxet, objNTP_KD_PLAYMAU.NGUOI_NM, objNTP_KD_PLAYMAU.NgayLM, objNTP_KD_PLAYMAU.SoTBThuchien, objNTP_KD_PLAYMAU.SoTBCanKD), Integer)

        End Function
        Public Sub Update(ByVal objNTP_KD_PLAYMAU As NTP_KD_PLAYMAUInfo)
            DataProvider.Instance().UpdateNTP_KD_PLAYMAU(objNTP_KD_PLAYMAU.ID_PLAYMAU, objNTP_KD_PLAYMAU.ThangLM, objNTP_KD_PLAYMAU.Nam, objNTP_KD_PLAYMAU.MA_TINH, objNTP_KD_PLAYMAU.ID_BENHVIEN, objNTP_KD_PLAYMAU.KTVien, objNTP_KD_PLAYMAU.Nhanxet, objNTP_KD_PLAYMAU.NGUOI_NM, objNTP_KD_PLAYMAU.NgayLM, objNTP_KD_PLAYMAU.SoTBThuchien, objNTP_KD_PLAYMAU.SoTBCanKD)
        End Sub
        Public Sub UpdateLan1(ByVal objNTP_KD_PLAYMAU As NTP_KD_PLAYMAUInfo)
            DataProvider.Instance().UpdateNTP_KD_PLAYMAU_LAN1(objNTP_KD_PLAYMAU.ID_PLAYMAU, objNTP_KD_PLAYMAU.NgayKD1, objNTP_KD_PLAYMAU.KDVien1, objNTP_KD_PLAYMAU.Nhanxet1)
        End Sub
        Public Sub UpdateLan2(ByVal objNTP_KD_PLAYMAU As NTP_KD_PLAYMAUInfo)
            DataProvider.Instance().UpdateNTP_KD_PLAYMAU_LAN2(objNTP_KD_PLAYMAU.ID_PLAYMAU, objNTP_KD_PLAYMAU.NgayKD2, objNTP_KD_PLAYMAU.KDVien2, objNTP_KD_PLAYMAU.Nhanxet2)
        End Sub

        Public Sub Delete(ByVal iD_PLAYMAU As Integer)
            DataProvider.Instance().DeleteNTP_KD_PLAYMAU(iD_PLAYMAU)
        End Sub
       
        Public Function IN_PHIEULAYMAU(ByVal THANG As Integer, ByVal NAM As Integer, ByVal ID_BENHVIEN As String) As DataSet
            Return DataProvider.Instance().IN_PHIEULAYMAU(THANG, NAM, ID_BENHVIEN)
        End Function
        Public Function IN_PHIEULAYMAU_KQKDLAN2(ByVal THANG As Integer, ByVal NAM As Integer, ByVal ID_BENHVIEN As String) As DataSet
            Return DataProvider.Instance().IN_PHIEULAYMAU_KQKDLAN2(THANG, NAM, ID_BENHVIEN)
        End Function
       
#End Region
    End Class






    Public Class NTP_KD_PLAYMAU_CController


#Region "Public Methods"
        Public Function [Get](ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer) As NTP_KD_PLAYMAU_CInfo
            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_KD_PLAYMAU_C(iD_PLAYMAU, iD_PLAYMAU_C), GetType(NTP_KD_PLAYMAU_CInfo)), NTP_KD_PLAYMAU_CInfo)

        End Function

        Public Function List(ByVal Id_PhieuLAYMAU As Integer) As List(Of NTP_KD_PLAYMAU_CInfo)

            Return CBO.FillCollection(Of NTP_KD_PLAYMAU_CInfo)(DataProvider.Instance().ListNTP_KD_PLAYMAU_C(Id_PhieuLAYMAU))

        End Function
        Public Function ListLan1(ByVal iD_PLAYMAU As Integer) As List(Of NTP_KD_PLAYMAU_CInfo)
            Return CBO.FillCollection(Of NTP_KD_PLAYMAU_CInfo)(DataProvider.Instance().ListLan1NTP_KD_PLAYMAU_C(iD_PLAYMAU))
        End Function
        Public Function ListLan2(ByVal Id_PhieuLAYMAU As Integer) As List(Of NTP_KD_PLAYMAU_CInfo)
            Return CBO.FillCollection(Of NTP_KD_PLAYMAU_CInfo)(DataProvider.Instance().ListLan2NTP_KD_PLAYMAU_C(Id_PhieuLAYMAU))

        End Function
        Public Function Add(ByVal objNTP_KD_PLAYMAU_C As NTP_KD_PLAYMAU_CInfo) As Integer
            Return CType(DataProvider.Instance().AddNTP_KD_PLAYMAU_C(objNTP_KD_PLAYMAU_C.ID_PLAYMAU, objNTP_KD_PLAYMAU_C.ID_Phieuxetnghiem_C, objNTP_KD_PLAYMAU_C.SoTB, objNTP_KD_PLAYMAU_C.KiemdinhH, objNTP_KD_PLAYMAU_C.Ghichu), Integer)
        End Function

        Public Sub Update(ByVal objNTP_KD_PLAYMAU_C As NTP_KD_PLAYMAU_CInfo)
            DataProvider.Instance().UpdateNTP_KD_PLAYMAU_C(objNTP_KD_PLAYMAU_C.ID_PLAYMAU_C, objNTP_KD_PLAYMAU_C.ID_PLAYMAU, objNTP_KD_PLAYMAU_C.ID_Phieuxetnghiem_C, objNTP_KD_PLAYMAU_C.SoTB, objNTP_KD_PLAYMAU_C.KiemdinhH, objNTP_KD_PLAYMAU_C.Ghichu)
        End Sub
        Public Sub UpdateLan1(ByVal objNTP_KD_PLAYMAU_C As NTP_KD_PLAYMAU_CInfo)
            DataProvider.Instance().UpdateNTP_KD_PLAYMAU_C_KQLAN1(objNTP_KD_PLAYMAU_C.ID_PLAYMAU_C, objNTP_KD_PLAYMAU_C.ID_PLAYMAU, objNTP_KD_PLAYMAU_C.KiemdinhT1, objNTP_KD_PLAYMAU_C.Chatluong, objNTP_KD_PLAYMAU_C.Taymau, objNTP_KD_PLAYMAU_C.Dosach, objNTP_KD_PLAYMAU_C.DoDay, objNTP_KD_PLAYMAU_C.Kichco, objNTP_KD_PLAYMAU_C.Domin, objNTP_KD_PLAYMAU_C.Ghichu1)
        End Sub
        Public Sub UpdateLan2(ByVal objNTP_KD_PLAYMAU_C As NTP_KD_PLAYMAU_CInfo)
            DataProvider.Instance().UpdateNTP_KD_PLAYMAU_C_KQLAN2(objNTP_KD_PLAYMAU_C.ID_PLAYMAU_C, objNTP_KD_PLAYMAU_C.ID_PLAYMAU, objNTP_KD_PLAYMAU_C.KiemDinhT2, objNTP_KD_PLAYMAU_C.Ghichu2)
        End Sub

        Public Sub Delete(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)

            DataProvider.Instance().DeleteNTP_KD_PLAYMAU_C(iD_PLAYMAU, iD_PLAYMAU_C)
        End Sub
        Public Sub DeleteNTP_KD_PLAYMAU_C_KQLAN1(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)
            DataProvider.Instance().DeleteNTP_KD_PLAYMAU_C_KQLAN1(iD_PLAYMAU, iD_PLAYMAU_C)
        End Sub
        Public Sub DeleteNTP_KD_PLAYMAU_C_KQLAN2(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)
            DataProvider.Instance().DeleteNTP_KD_PLAYMAU_C_KQLAN2(iD_PLAYMAU, iD_PLAYMAU_C)
        End Sub
#End Region
    End Class


End Namespace
