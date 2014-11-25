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

Namespace YourCompany.Modules.NTP_SOKHAMBENH

    ''' <summary>
    ''' The Controller class for NTP_SOKHAMBENH
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_SOKHAMBENHController


#Region "Public Methods"
        Public Function [Get](ByVal iD_Dieutri As Integer) As NTP_SOKHAMBENHInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_SOKHAMBENH(iD_Dieutri), GetType(NTP_SOKHAMBENHInfo)), NTP_SOKHAMBENHInfo)

        End Function
        Public Function NTP_SOKHAMBENH_SelectByDVDieutri(ByVal iD_Dieutri As Integer, ByVal ID_Benhvien As String) As NTP_SOKHAMBENHInfo

            Return CType(CBO.FillObject(DataProvider.Instance().NTP_SOKHAMBENH_SelectByDVDieutri(iD_Dieutri, ID_Benhvien), GetType(NTP_SOKHAMBENHInfo)), NTP_SOKHAMBENHInfo)

        End Function
        Public Function List() As List(Of NTP_SOKHAMBENHInfo)

            Return CBO.FillCollection(Of NTP_SOKHAMBENHInfo)(DataProvider.Instance().ListNTP_SOKHAMBENH())

        End Function
        Public Function ListByID_BenhNhan(ByVal ID_BenhNhan As String, ByVal ID_Benhvien As String) As List(Of NTP_SOKHAMBENHInfo)

            Return CBO.FillCollection(Of NTP_SOKHAMBENHInfo)(DataProvider.Instance().ListByID_BenhNhanNTP_SOKHAMBENH(ID_BenhNhan, ID_Benhvien))

        End Function

        Public Function Add(ByVal objNTP_SOKHAMBENH As NTP_SOKHAMBENHInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_SOKHAMBENH(objNTP_SOKHAMBENH.ID_BENHNHAN, objNTP_SOKHAMBENH.SoDKDT, objNTP_SOKHAMBENH.DVDieutri, objNTP_SOKHAMBENH.NgayVV, objNTP_SOKHAMBENH.NgayDT, objNTP_SOKHAMBENH.ID_PHANLOAIYTE, objNTP_SOKHAMBENH.DVGioiThieu, objNTP_SOKHAMBENH.ID_PhanLoaiBenh, objNTP_SOKHAMBENH.ID_PhanLoaiBN, objNTP_SOKHAMBENH.NgayChupXQ, objNTP_SOKHAMBENH.KetquaXQ, objNTP_SOKHAMBENH.XNHIV1, objNTP_SOKHAMBENH.XNHIV2, objNTP_SOKHAMBENH.ART, objNTP_SOKHAMBENH.CPT, objNTP_SOKHAMBENH.LymPho, objNTP_SOKHAMBENH.GiamSatDT, objNTP_SOKHAMBENH.ID_KetquaDT, objNTP_SOKHAMBENH.NgayRV, objNTP_SOKHAMBENH.Ghichu, objNTP_SOKHAMBENH.NGAY_NM, objNTP_SOKHAMBENH.NGUOI_NM, objNTP_SOKHAMBENH.Ngay_SD, objNTP_SOKHAMBENH.Nguoi_SD, objNTP_SOKHAMBENH.HuyenXN, objNTP_SOKHAMBENH.TinhXN, objNTP_SOKHAMBENH.ID_PhieuChuyen, objNTP_SOKHAMBENH.ID_PhacdoDT, objNTP_SOKHAMBENH.PhacdoKhac, objNTP_SOKHAMBENH.Chandoan, objNTP_SOKHAMBENH.ID_PhacdoTD, objNTP_SOKHAMBENH.PhacdoTDKhac, objNTP_SOKHAMBENH.MaBNQL, objNTP_SOKHAMBENH.Tuoi), Integer)

        End Function

        Public Sub Update(ByVal objNTP_SOKHAMBENH As NTP_SOKHAMBENHInfo)

            DataProvider.Instance().UpdateNTP_SOKHAMBENH(objNTP_SOKHAMBENH.ID_Dieutri, objNTP_SOKHAMBENH.ID_BENHNHAN, objNTP_SOKHAMBENH.SoDKDT, objNTP_SOKHAMBENH.DVDieutri, objNTP_SOKHAMBENH.NgayVV, objNTP_SOKHAMBENH.NgayDT, objNTP_SOKHAMBENH.ID_PHANLOAIYTE, objNTP_SOKHAMBENH.DVGioiThieu, objNTP_SOKHAMBENH.ID_PhanLoaiBenh, objNTP_SOKHAMBENH.ID_PhanLoaiBN, objNTP_SOKHAMBENH.NgayChupXQ, objNTP_SOKHAMBENH.KetquaXQ, objNTP_SOKHAMBENH.XNHIV1, objNTP_SOKHAMBENH.XNHIV2, objNTP_SOKHAMBENH.ART, objNTP_SOKHAMBENH.CPT, objNTP_SOKHAMBENH.LymPho, objNTP_SOKHAMBENH.GiamSatDT, objNTP_SOKHAMBENH.ID_KetquaDT, objNTP_SOKHAMBENH.NgayRV, objNTP_SOKHAMBENH.Ghichu, objNTP_SOKHAMBENH.NGAY_NM, objNTP_SOKHAMBENH.NGUOI_NM, objNTP_SOKHAMBENH.Ngay_SD, objNTP_SOKHAMBENH.Nguoi_SD, objNTP_SOKHAMBENH.HuyenXN, objNTP_SOKHAMBENH.TinhXN, objNTP_SOKHAMBENH.ID_PhieuChuyen, objNTP_SOKHAMBENH.ID_PhacdoDT, objNTP_SOKHAMBENH.PhacdoKhac, objNTP_SOKHAMBENH.Chandoan, objNTP_SOKHAMBENH.ID_PhacdoTD, objNTP_SOKHAMBENH.PhacdoTDKhac, objNTP_SOKHAMBENH.MaBNQL, objNTP_SOKHAMBENH.Tuoi)

        End Sub

        Public Sub Delete(ByVal iD_Dieutri As Integer)

            DataProvider.Instance().DeleteNTP_SOKHAMBENH(iD_Dieutri)

        End Sub
#End Region



    End Class
    Public Class NTP_BN_KQXETNGHIEMController


#Region "Public Methods"

        Public Function ListByID_BenbNhan(ByVal ID_BenhNhan As String) As List(Of NTP_BN_KQXETNGHIEMInfo)

            Return CBO.FillCollection(Of NTP_BN_KQXETNGHIEMInfo)(DataProvider.Instance().ListByID_BenhNhanNTP_BN_KETQUAXN(ID_BenhNhan))

        End Function

        Public Function Add(ByVal objNTP_BN_KETQUAXN As NTP_BN_KQXETNGHIEMInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_KETQUAXN(objNTP_BN_KETQUAXN.ID_Dieutri, objNTP_BN_KETQUAXN.ID_Phieuxetnghiem_C, objNTP_BN_KETQUAXN.ThoiGianDT, objNTP_BN_KETQUAXN.NgayXN, objNTP_BN_KETQUAXN.SoXN, objNTP_BN_KETQUAXN.KetquaXN, objNTP_BN_KETQUAXN.CanNang, objNTP_BN_KETQUAXN.NGAY_NM, objNTP_BN_KETQUAXN.NGUOI_NM), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_KETQUAXN As NTP_BN_KQXETNGHIEMInfo)

            DataProvider.Instance().UpdateNTP_BN_KETQUAXN(objNTP_BN_KETQUAXN.ID_Xetnghiem_GD, objNTP_BN_KETQUAXN.ID_Dieutri, objNTP_BN_KETQUAXN.ID_Phieuxetnghiem_C, objNTP_BN_KETQUAXN.ThoiGianDT, objNTP_BN_KETQUAXN.NgayXN, objNTP_BN_KETQUAXN.SoXN, objNTP_BN_KETQUAXN.KetquaXN, objNTP_BN_KETQUAXN.CanNang, objNTP_BN_KETQUAXN.NGAY_NM, objNTP_BN_KETQUAXN.NGUOI_NM)

        End Sub


#End Region
    End Class
    Public Class NTP_BN_KETQUADTController

#Region "NTP_BN_KETQUADT Methods"

        Public Function [Get](ByVal ID_Dieutri As Integer) As NTP_BN_KETQUADTInfo
            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_KETQUADT(ID_Dieutri), GetType(NTP_BN_KETQUADTInfo)), NTP_BN_KETQUADTInfo)

        End Function

        Public Function ListNTP_BN_DMBENHVIENCHUYEN(ByVal ID_BENHVIEN As String) As List(Of NTP_BN_KETQUADTInfo)
            Return CBO.FillCollection(Of NTP_SOKHAMBENH.NTP_BN_KETQUADTInfo)(DataProvider.Instance().ListNTP_BN_DMBENHVIENCHUYEN(ID_BENHVIEN))
        End Function
        Public Function ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(ByVal ID_BENHVIEN As String, ByVal MATINH As String) As List(Of NTP_BN_KETQUADTInfo)
            Return CBO.FillCollection(Of NTP_SOKHAMBENH.NTP_BN_KETQUADTInfo)(DataProvider.Instance().ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(ID_BENHVIEN, MATINH))
        End Function
        Public Sub UpdateNTP_BN_KETQUADT(ByVal objNTP_SOKHAMBENH As NTP_BN_KETQUADTInfo)
            DataProvider.Instance().UpdateNTP_BN_KETQUADT(objNTP_SOKHAMBENH.ID_Dieutri, objNTP_SOKHAMBENH.KetquaDT, objNTP_SOKHAMBENH.NgayRV, objNTP_SOKHAMBENH.Ghichu)

        End Sub




#End Region


    End Class
End Namespace
