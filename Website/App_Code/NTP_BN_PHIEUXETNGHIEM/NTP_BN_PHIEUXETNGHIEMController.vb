

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

Namespace YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM

    ''' <summary>
    ''' The Controller class for NTP_BN_PHIEUXETNGHIEM
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_PHIEUXETNGHIEMController
#Region "Public Methods"
        Public Function [Get](ByVal iD_Phieuxetnghiem As Integer) As NTP_BN_PHIEUXETNGHIEMInfo
            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_PHIEUXETNGHIEM(iD_Phieuxetnghiem), GetType(NTP_BN_PHIEUXETNGHIEMInfo)), NTP_BN_PHIEUXETNGHIEMInfo)

        End Function

        Public Function List(ByVal Id_BenhNhan As String, ByVal DV_Xetnghiem As String) As List(Of NTP_BN_PHIEUXETNGHIEMInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUXETNGHIEMInfo)(DataProvider.Instance().ListNTP_BN_PHIEUXETNGHIEM(Id_BenhNhan, DV_Xetnghiem))

        End Function
   

        Public Function Add(ByVal objNTP_BN_PHIEUXETNGHIEM As NTP_BN_PHIEUXETNGHIEMInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_PHIEUXETNGHIEM(objNTP_BN_PHIEUXETNGHIEM.ID_Benhnhan, objNTP_BN_PHIEUXETNGHIEM.SoXN, objNTP_BN_PHIEUXETNGHIEM.ID_Benhvien, objNTP_BN_PHIEUXETNGHIEM.ID_PhanloaiYte, objNTP_BN_PHIEUXETNGHIEM.LydoXN, objNTP_BN_PHIEUXETNGHIEM.Soluong, objNTP_BN_PHIEUXETNGHIEM.HIV, objNTP_BN_PHIEUXETNGHIEM.SoDKDT, objNTP_BN_PHIEUXETNGHIEM.XNVien, objNTP_BN_PHIEUXETNGHIEM.Ghichu, objNTP_BN_PHIEUXETNGHIEM.NGAY_NM, objNTP_BN_PHIEUXETNGHIEM.NGUOI_NM, objNTP_BN_PHIEUXETNGHIEM.DV_XETNGHIEM, objNTP_BN_PHIEUXETNGHIEM.SoThangDT, objNTP_BN_PHIEUXETNGHIEM.NGAYXN, objNTP_BN_PHIEUXETNGHIEM.DV_Tiepnhan), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_PHIEUXETNGHIEM As NTP_BN_PHIEUXETNGHIEMInfo)

            DataProvider.Instance().UpdateNTP_BN_PHIEUXETNGHIEM(objNTP_BN_PHIEUXETNGHIEM.ID_Phieuxetnghiem, objNTP_BN_PHIEUXETNGHIEM.ID_Benhnhan, objNTP_BN_PHIEUXETNGHIEM.SoXN, objNTP_BN_PHIEUXETNGHIEM.ID_Benhvien, objNTP_BN_PHIEUXETNGHIEM.ID_PhanloaiYte, objNTP_BN_PHIEUXETNGHIEM.LydoXN, objNTP_BN_PHIEUXETNGHIEM.Soluong, objNTP_BN_PHIEUXETNGHIEM.HIV, objNTP_BN_PHIEUXETNGHIEM.SoDKDT, objNTP_BN_PHIEUXETNGHIEM.XNVien, objNTP_BN_PHIEUXETNGHIEM.Ghichu, objNTP_BN_PHIEUXETNGHIEM.NGAY_NM, objNTP_BN_PHIEUXETNGHIEM.NGUOI_NM, objNTP_BN_PHIEUXETNGHIEM.DV_XETNGHIEM, objNTP_BN_PHIEUXETNGHIEM.SoThangDT, objNTP_BN_PHIEUXETNGHIEM.NGAYXN, objNTP_BN_PHIEUXETNGHIEM.DV_Tiepnhan)

        End Sub

        Public Sub Delete(ByVal iD_Phieuxetnghiem As Integer)

            DataProvider.Instance().DeleteNTP_BN_PHIEUXETNGHIEM(iD_Phieuxetnghiem)

        End Sub
        Public Function NTP_BN_PHIEUXETNGHIEM_SelectByDVDieutri(ByVal iD_Phieuxetnghiem As Integer, ByVal ID_Benhvien As String) As NTP_BN_PHIEUXETNGHIEMInfo

            Return CType(CBO.FillObject(DataProvider.Instance().NTP_BN_PHIEUXETNGHIEM_SelectByDVDieutri(iD_Phieuxetnghiem, ID_Benhvien), GetType(NTP_BN_PHIEUXETNGHIEMInfo)), NTP_BN_PHIEUXETNGHIEMInfo)

        End Function
        Public Function NTP_BN_PHIEUXETNGHIEM_SelectByIDBENHNHAN(ByVal ID_BENHNHAN As String, ByVal DV_XETNGHIEM As String) As DataSet
            Return DataProvider.Instance().NTP_BN_PHIEUXETNGHIEM_SelectByIDBENHNHAN(ID_BENHNHAN, DV_XETNGHIEM)
        End Function
#End Region
    End Class
    Public Class NTP_BN_PHIEUXETNGHIEM_CController

#Region "Public Methods"
        Public Function [Get](ByVal iD_Phieuxetnghiem_C As Integer) As NTP_BN_PHIEUXETNGHIEM_CInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_PHIEUXETNGHIEM_C(iD_Phieuxetnghiem_C), GetType(NTP_BN_PHIEUXETNGHIEM_CInfo)), NTP_BN_PHIEUXETNGHIEM_CInfo)

        End Function

        Public Function List() As List(Of NTP_BN_PHIEUXETNGHIEM_CInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUXETNGHIEM_CInfo)(DataProvider.Instance().ListNTP_BN_PHIEUXETNGHIEM_C())

        End Function
        Public Function ListByID(ByVal Id_PhieuXetNghiemBN As Integer) As List(Of NTP_BN_PHIEUXETNGHIEM_CInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUXETNGHIEM_CInfo)(DataProvider.Instance().ListByIDNTP_BN_PHIEUXETNGHIEM_C(Id_PhieuXetNghiemBN))

        End Function

        Public Function ListByIDBENHNHAN(ByVal Id_BENHNHAN As String, ByVal GiaidoanDT As Byte) As List(Of NTP_BN_PHIEUXETNGHIEM_CViewInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUXETNGHIEM_CViewInfo)(DataProvider.Instance().ListByIDBENHNHANNTP_BN_PHIEUXETNGHIEM_C(Id_BENHNHAN, GiaidoanDT))

        End Function
        Public Function Add(ByVal objNTP_BN_PHIEUXETNGHIEM_C As NTP_BN_PHIEUXETNGHIEM_CInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_PHIEUXETNGHIEM_C(objNTP_BN_PHIEUXETNGHIEM_C.ID_Phieuxetnghiem, objNTP_BN_PHIEUXETNGHIEM_C.NgayNhanMau, objNTP_BN_PHIEUXETNGHIEM_C.TrangthaiDom, objNTP_BN_PHIEUXETNGHIEM_C.Maudom, objNTP_BN_PHIEUXETNGHIEM_C.Ketqua, objNTP_BN_PHIEUXETNGHIEM_C.SoXN), Integer)

        End Function
        Public Function ListByThang(ByVal thang As String, ByVal Id_BenhVien As String) As List(Of NTP_BN_PHIEUXETNGHIEM_CViewInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUXETNGHIEM_CViewInfo)(DataProvider.Instance().ListByThangNTP_BN_PHIEUXETNGHIEM_C(thang, Id_BenhVien))

        End Function
        Public Sub Update(ByVal objNTP_BN_PHIEUXETNGHIEM_C As NTP_BN_PHIEUXETNGHIEM_CInfo)

            DataProvider.Instance().UpdateNTP_BN_PHIEUXETNGHIEM_C(objNTP_BN_PHIEUXETNGHIEM_C.ID_Phieuxetnghiem_C, objNTP_BN_PHIEUXETNGHIEM_C.ID_Phieuxetnghiem, objNTP_BN_PHIEUXETNGHIEM_C.NgayNhanMau, objNTP_BN_PHIEUXETNGHIEM_C.TrangthaiDom, objNTP_BN_PHIEUXETNGHIEM_C.Maudom, objNTP_BN_PHIEUXETNGHIEM_C.Ketqua, objNTP_BN_PHIEUXETNGHIEM_C.SoXN)

        End Sub

        Public Sub Delete(ByVal iD_Phieuxetnghiem As Integer, ByVal iD_Phieuxetnghiem_C As Integer)

            DataProvider.Instance().DeleteNTP_BN_PHIEUXETNGHIEM_C(iD_Phieuxetnghiem, iD_Phieuxetnghiem_C)

        End Sub
#End Region



    End Class
    Public Class NTP_BN_XETNGHIEM_GDController
        

#Region "Public Methods"
        Public Function [Get](ByVal iD_Xetnghiem_GD As Integer) As NTP_BN_XETNGHIEM_GDInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_XETNGHIEM_GD(iD_Xetnghiem_GD), GetType(NTP_BN_XETNGHIEM_GDInfo)), NTP_BN_XETNGHIEM_GDInfo)

        End Function

        Public Function List() As List(Of NTP_BN_XETNGHIEM_GDInfo)

            Return CBO.FillCollection(Of NTP_BN_XETNGHIEM_GDInfo)(DataProvider.Instance().ListNTP_BN_XETNGHIEM_GD())

        End Function
        Public Function GetNTP_BN_XETNGHIEM_GDByThoigianDT(ByVal iD_Xetnghiem_GD As Integer, ByVal ThoigianDT As Integer) As NTP_BN_XETNGHIEM_GDInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_XETNGHIEM_GDByThoigianDT(iD_Xetnghiem_GD, ThoigianDT), GetType(NTP_BN_XETNGHIEM_GDInfo)), NTP_BN_XETNGHIEM_GDInfo)

        End Function
        Public Function ListByIDDieuTriView(ByVal Id_DieuTri As Integer) As List(Of NTP_BN_XETNGHIEM_GDViewInfo)

            Return CBO.FillCollection(Of NTP_BN_XETNGHIEM_GDViewInfo)(DataProvider.Instance().ListByIDDIEUTRINTP_BN_XETNGHIEM_GD(Id_DieuTri))

        End Function

        Public Function Add(ByVal objNTP_BN_XETNGHIEM_GD As NTP_BN_XETNGHIEM_GDInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_XETNGHIEM_GD(objNTP_BN_XETNGHIEM_GD.ID_Dieutri, objNTP_BN_XETNGHIEM_GD.ID_Phieuxetnghiem_C, objNTP_BN_XETNGHIEM_GD.ThoiGianDT, objNTP_BN_XETNGHIEM_GD.NgayXN, objNTP_BN_XETNGHIEM_GD.SoXN, objNTP_BN_XETNGHIEM_GD.KetquaXN, objNTP_BN_XETNGHIEM_GD.CanNang, objNTP_BN_XETNGHIEM_GD.NGAY_NM, objNTP_BN_XETNGHIEM_GD.NGUOI_NM, objNTP_BN_XETNGHIEM_GD.Nuoicay), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_XETNGHIEM_GD As NTP_BN_XETNGHIEM_GDInfo)

            DataProvider.Instance().UpdateNTP_BN_XETNGHIEM_GD(objNTP_BN_XETNGHIEM_GD.ID_Xetnghiem_GD, objNTP_BN_XETNGHIEM_GD.ID_Dieutri, objNTP_BN_XETNGHIEM_GD.ID_Phieuxetnghiem_C, objNTP_BN_XETNGHIEM_GD.ThoiGianDT, objNTP_BN_XETNGHIEM_GD.NgayXN, objNTP_BN_XETNGHIEM_GD.SoXN, objNTP_BN_XETNGHIEM_GD.KetquaXN, objNTP_BN_XETNGHIEM_GD.CanNang, objNTP_BN_XETNGHIEM_GD.NGAY_NM, objNTP_BN_XETNGHIEM_GD.NGUOI_NM, objNTP_BN_XETNGHIEM_GD.Nuoicay)

        End Sub

        Public Sub Delete(ByVal iD_Xetnghiem_GD As Integer)

            DataProvider.Instance().DeleteNTP_BN_XETNGHIEM_GD(iD_Xetnghiem_GD)

        End Sub
	Public Function NTP_BN_XETNGHIEMBNTHATBAI(ByVal iD_BENHNHAN As String) As NTP_BN_XETNGHIEM_GDInfo

            Return CType(CBO.FillObject(DataProvider.Instance().NTP_BN_XETNGHIEMBNTHATBAI(iD_BENHNHAN), GetType(NTP_BN_XETNGHIEM_GDInfo)), NTP_BN_XETNGHIEM_GDInfo)

        End Function
#End Region



    End Class

End Namespace
