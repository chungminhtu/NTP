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

Namespace YourCompany.Modules.NTP_BN_DIEUTRI

    ''' <summary>
    ''' The Controller class for NTP_BN_DIEUTRI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_DIEUTRIController
     

#Region "Public Methods"
        Public Function [Get](ByVal iD_Dieutri As Integer) As NTP_BN_DIEUTRIInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_DIEUTRI(iD_Dieutri), GetType(NTP_BN_DIEUTRIInfo)), NTP_BN_DIEUTRIInfo)

        End Function
        Public Function NTP_BN_DIEUTRI_SelectByDVDieutri(ByVal iD_Dieutri As Integer, ByVal ID_Benhvien As String) As NTP_BN_DIEUTRIInfo

            Return CType(CBO.FillObject(DataProvider.Instance().NTP_BN_DIEUTRI_SelectByDVDieutri(iD_Dieutri, ID_Benhvien), GetType(NTP_BN_DIEUTRIInfo)), NTP_BN_DIEUTRIInfo)

        End Function
        Public Function List() As List(Of NTP_BN_DIEUTRIInfo)

            Return CBO.FillCollection(Of NTP_BN_DIEUTRIInfo)(DataProvider.Instance().ListNTP_BN_DIEUTRI())

        End Function
        Public Function ListByID_BenhNhan(ByVal ID_BenhNhan As String, ByVal ID_Benhvien As String) As List(Of NTP_BN_DIEUTRIInfo)

            Return CBO.FillCollection(Of NTP_BN_DIEUTRIInfo)(DataProvider.Instance().ListByID_BenhNhanNTP_BN_DIEUTRI(ID_BenhNhan, ID_Benhvien))

        End Function

        Public Function Add(ByVal objNTP_BN_DIEUTRI As NTP_BN_DIEUTRIInfo) As Integer

  Return CType(DataProvider.Instance().AddNTP_BN_DIEUTRI(objNTP_BN_DIEUTRI.ID_BENHNHAN, objNTP_BN_DIEUTRI.SoDKDT, objNTP_BN_DIEUTRI.DVDieutri, objNTP_BN_DIEUTRI.NgayVV, objNTP_BN_DIEUTRI.NgayDT, objNTP_BN_DIEUTRI.ID_PHANLOAIYTE, objNTP_BN_DIEUTRI.DVGioiThieu, objNTP_BN_DIEUTRI.ID_PhanLoaiBenh, objNTP_BN_DIEUTRI.ID_PhanLoaiBN, objNTP_BN_DIEUTRI.NgayChupXQ, objNTP_BN_DIEUTRI.KetquaXQ, objNTP_BN_DIEUTRI.XNHIV1, objNTP_BN_DIEUTRI.XNHIV2, objNTP_BN_DIEUTRI.ART, objNTP_BN_DIEUTRI.CPT, objNTP_BN_DIEUTRI.LymPho, objNTP_BN_DIEUTRI.GiamSatDT, objNTP_BN_DIEUTRI.ID_KetquaDT, objNTP_BN_DIEUTRI.NgayRV, objNTP_BN_DIEUTRI.Ghichu, objNTP_BN_DIEUTRI.NGAY_NM, objNTP_BN_DIEUTRI.NGUOI_NM, objNTP_BN_DIEUTRI.Ngay_SD, objNTP_BN_DIEUTRI.Nguoi_SD, objNTP_BN_DIEUTRI.HuyenXN, objNTP_BN_DIEUTRI.TinhXN, objNTP_BN_DIEUTRI.ID_PhieuChuyen, objNTP_BN_DIEUTRI.ID_PhacdoDT, objNTP_BN_DIEUTRI.PhacdoKhac, objNTP_BN_DIEUTRI.Chandoan, objNTP_BN_DIEUTRI.ID_PhacdoTD, objNTP_BN_DIEUTRI.PhacdoTDKhac, objNTP_BN_DIEUTRI.MaBNQL, objNTP_BN_DIEUTRI.Tuoi), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_DIEUTRI As NTP_BN_DIEUTRIInfo)

            DataProvider.Instance().UpdateNTP_BN_DIEUTRI(objNTP_BN_DIEUTRI.ID_Dieutri, objNTP_BN_DIEUTRI.ID_BENHNHAN, objNTP_BN_DIEUTRI.SoDKDT, objNTP_BN_DIEUTRI.DVDieutri, objNTP_BN_DIEUTRI.NgayVV, objNTP_BN_DIEUTRI.NgayDT, objNTP_BN_DIEUTRI.ID_PHANLOAIYTE, objNTP_BN_DIEUTRI.DVGioiThieu, objNTP_BN_DIEUTRI.ID_PhanLoaiBenh, objNTP_BN_DIEUTRI.ID_PhanLoaiBN, objNTP_BN_DIEUTRI.NgayChupXQ, objNTP_BN_DIEUTRI.KetquaXQ, objNTP_BN_DIEUTRI.XNHIV1, objNTP_BN_DIEUTRI.XNHIV2, objNTP_BN_DIEUTRI.ART, objNTP_BN_DIEUTRI.CPT, objNTP_BN_DIEUTRI.LymPho, objNTP_BN_DIEUTRI.GiamSatDT, objNTP_BN_DIEUTRI.ID_KetquaDT, objNTP_BN_DIEUTRI.NgayRV, objNTP_BN_DIEUTRI.Ghichu, objNTP_BN_DIEUTRI.NGAY_NM, objNTP_BN_DIEUTRI.NGUOI_NM, objNTP_BN_DIEUTRI.Ngay_SD, objNTP_BN_DIEUTRI.Nguoi_SD, objNTP_BN_DIEUTRI.HuyenXN, objNTP_BN_DIEUTRI.TinhXN, objNTP_BN_DIEUTRI.ID_PhieuChuyen, objNTP_BN_DIEUTRI.ID_PhacdoDT, objNTP_BN_DIEUTRI.PhacdoKhac, objNTP_BN_DIEUTRI.Chandoan, objNTP_BN_DIEUTRI.ID_PhacdoTD, objNTP_BN_DIEUTRI.PhacdoTDKhac, objNTP_BN_DIEUTRI.MaBNQL, objNTP_BN_DIEUTRI.Tuoi)

        End Sub

        Public Sub Delete(ByVal iD_Dieutri As Integer)

            DataProvider.Instance().DeleteNTP_BN_DIEUTRI(iD_Dieutri)

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
            Return CBO.FillCollection(Of NTP_BN_DIEUTRI.NTP_BN_KETQUADTInfo)(DataProvider.Instance().ListNTP_BN_DMBENHVIENCHUYEN(ID_BENHVIEN))
        End Function
        Public Function ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(ByVal ID_BENHVIEN As String, ByVal MATINH As String) As List(Of NTP_BN_KETQUADTInfo)
            Return CBO.FillCollection(Of NTP_BN_DIEUTRI.NTP_BN_KETQUADTInfo)(DataProvider.Instance().ListNTP_DM_BENHVIEN_ListDVChuyen_HTC(ID_BENHVIEN, MATINH))
        End Function
        Public Sub UpdateNTP_BN_KETQUADT(ByVal objNTP_BN_dieutri As NTP_BN_KETQUADTInfo)
            DataProvider.Instance().UpdateNTP_BN_KETQUADT(objNTP_BN_dieutri.ID_Dieutri, objNTP_BN_dieutri.KetquaDT, objNTP_BN_dieutri.NgayRV, objNTP_BN_dieutri.Ghichu)

        End Sub




#End Region


    End Class
End Namespace
