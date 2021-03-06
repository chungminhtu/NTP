'
' DotNetNukeŽ - http://www.dotnetnuke.com
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

Namespace YourCompany.Modules.NTP_BN_BENHNHAN

    ''' <summary>
    ''' The Controller class for NTP_BN_BENHNHAN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_BENHNHANController
     

#Region "Public Methods"
        Public Function [Get](ByVal iD_Benhnhan As String) As NTP_BN_BENHNHANInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BENHNHAN(iD_Benhnhan), GetType(NTP_BN_BENHNHANInfo)), NTP_BN_BENHNHANInfo)

        End Function
        Public Function GetBENHNHAN_DIEUTRI(ByVal iD_Benhnhan As String) As NTP_BN_BENHNHANInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetBENHNHAN_DIEUTRI(iD_Benhnhan), GetType(NTP_BN_BENHNHANInfo)), NTP_BN_BENHNHANInfo)

        End Function

        Public Function List() As List(Of NTP_BN_BENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_BENHNHANInfo)(DataProvider.Instance().ListNTP_BN_BENHNHAN())

        End Function
        Public Function ListFind(ByVal ID_Benhnhan As String, ByVal Hoten As String, ByVal soCMND As String, ByVal DUNGTEN As Boolean, ByVal MaTinh As String, ByVal MaHuyen As String) As NTP_BN_BENHNHANInfo
            Return CType(CBO.FillObject(DataProvider.Instance().ListFindNTP_BN_BENHNHAN(ID_Benhnhan, Hoten, soCMND, DUNGTEN, MaTinh, MaHuyen), GetType(NTP_BN_BENHNHANInfo)), NTP_BN_BENHNHANInfo)

            ' Return CBO.FillCollection(Of NTP_BN_BENHNHANInfo)(DataProvider.Instance().ListFindNTP_BN_BENHNHAN(ID_Benhnhan, Hoten, soCMND, DUNGTEN, MaTinh, MaHuyen))

        End Function
        Public Function ListByDVTiepNhan(ByVal DVTiepNhan As String) As List(Of NTP_BN_BENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_BENHNHANInfo)(DataProvider.Instance().ListByDVTiepNhan(DVTiepNhan))

        End Function
        Public Function ListByBenhNhanDieuTri(ByVal Ravien As Integer, ByVal diachi As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal Hoten As String, ByVal SoCM As String, ByVal DVDIEUTRI As String) As List(Of NTP_BN_BENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_BENHNHANInfo)(DataProvider.Instance().ListByBenhNhanDieuTri(Ravien, diachi, ThangNam, DieuKien, Hoten, SoCM, DVDIEUTRI))

        End Function
        Public Function ListByBenhNhanByDonviDieutri(ByVal Ravien As Integer, ByVal Diachi As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal Hoten As String, ByVal SoCM As String, ByVal DVDIEUTRI As String) As List(Of NTP_BN_BENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_BENHNHANInfo)(DataProvider.Instance().ListByBenhNhanByDonviDieutri(Ravien, Diachi, ThangNam, DieuKien, Hoten, SoCM, DVDIEUTRI))

        End Function
        Public Function Add(ByVal objNTP_BN_BENHNHAN As NTP_BN_BENHNHANInfo) As String

            Return CType(DataProvider.Instance().AddNTP_BN_BENHNHAN(objNTP_BN_BENHNHAN.ID_DoiTuong, objNTP_BN_BENHNHAN.HoTen, objNTP_BN_BENHNHAN.SoCMND, objNTP_BN_BENHNHAN.Tuoi, objNTP_BN_BENHNHAN.Gioitinh, objNTP_BN_BENHNHAN.MA_TINH, objNTP_BN_BENHNHAN.MA_HUYEN, objNTP_BN_BENHNHAN.Diachi, objNTP_BN_BENHNHAN.Sodienthoai, objNTP_BN_BENHNHAN.NGUOI_NM, objNTP_BN_BENHNHAN.Nguoi_SD, objNTP_BN_BENHNHAN.Huy, objNTP_BN_BENHNHAN.HuyenXN, objNTP_BN_BENHNHAN.TinhXN, objNTP_BN_BENHNHAN.MaBNQL), String)

        End Function

        Public Sub Add_TN(ByVal objNTP_BN_BENHNHAN As NTP_BN_BENHNHANInfo)
            DataProvider.Instance().AddNTP_BN_BENHNHAN_TN(objNTP_BN_BENHNHAN.ID_Benhnhan, objNTP_BN_BENHNHAN.ID_DoiTuong, objNTP_BN_BENHNHAN.HoTen, objNTP_BN_BENHNHAN.SoCMND, objNTP_BN_BENHNHAN.Tuoi, objNTP_BN_BENHNHAN.Gioitinh, objNTP_BN_BENHNHAN.MA_TINH, objNTP_BN_BENHNHAN.MA_HUYEN, objNTP_BN_BENHNHAN.Diachi, objNTP_BN_BENHNHAN.Sodienthoai, objNTP_BN_BENHNHAN.NGAY_NM, objNTP_BN_BENHNHAN.NGUOI_NM, objNTP_BN_BENHNHAN.Nguoi_SD, objNTP_BN_BENHNHAN.Huy, objNTP_BN_BENHNHAN.HuyenXN, objNTP_BN_BENHNHAN.TinhXN)
        End Sub
        Public Sub Update(ByVal objNTP_BN_BENHNHAN As NTP_BN_BENHNHANInfo)

            DataProvider.Instance().UpdateNTP_BN_BENHNHAN(objNTP_BN_BENHNHAN.ID_Benhnhan, objNTP_BN_BENHNHAN.ID_DoiTuong, objNTP_BN_BENHNHAN.HoTen, objNTP_BN_BENHNHAN.SoCMND, objNTP_BN_BENHNHAN.Tuoi, objNTP_BN_BENHNHAN.Gioitinh, objNTP_BN_BENHNHAN.MA_TINH, objNTP_BN_BENHNHAN.MA_HUYEN, objNTP_BN_BENHNHAN.Diachi, objNTP_BN_BENHNHAN.Sodienthoai, objNTP_BN_BENHNHAN.NGAY_NM, objNTP_BN_BENHNHAN.NGUOI_NM, objNTP_BN_BENHNHAN.Ngay_SD, objNTP_BN_BENHNHAN.Nguoi_SD, objNTP_BN_BENHNHAN.Huy, objNTP_BN_BENHNHAN.HuyenXN, objNTP_BN_BENHNHAN.TinhXN, objNTP_BN_BENHNHAN.MaBNQL)

        End Sub

        Public Sub Delete(ByVal iD_Benhnhan As String)

            DataProvider.Instance().DeleteNTP_BN_BENHNHAN(iD_Benhnhan)

        End Sub

        Public Function NTP_BN_DIEUTRI_Finds(ByVal Diachi As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal MaBN As String, ByVal Hoten As String, ByVal SoCMT As String, ByVal DVDieutri As String, ByVal MATINH As String, ByVal Phanloaibenh As Integer, ByVal LUACHON As Byte) As List(Of NTP_BN_BENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_BENHNHANInfo)(DataProvider.Instance().NTP_BN_DIEUTRI_Finds(Diachi, Tungay, Denngay, MaBN, Hoten, SoCMT, DVDieutri, MATINH, Phanloaibenh, LUACHON))

        End Function
        Public Function NTP_BN_XETNGHIEM_Finds(ByVal Diachi As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal MaBN As String, ByVal Hoten As String, ByVal SoCMT As String, ByVal DVDieutri As String, ByVal MATINH As String, ByVal Phanloaibenh As Integer) As List(Of NTP_BN_BENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_BENHNHANInfo)(DataProvider.Instance().NTP_BN_XETNGHIEM_Finds(Diachi, Tungay, Denngay, MaBN, Hoten, SoCMT, DVDieutri, MATINH, Phanloaibenh))
        End Function
        Public Function In_DANHSACHBNDIEUTRI(ByVal Tinh As String, ByVal ID_BENHVIEN As String, ByVal Tungay As DateTime, ByVal Denngay As DateTime, ByVal XACNHANBN As Integer, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().In_DANHSACHBNDIEUTRI(Tinh, ID_BENHVIEN, Tungay, Denngay, XACNHANBN, Dieukien)
        End Function
#End Region



    End Class
End Namespace
