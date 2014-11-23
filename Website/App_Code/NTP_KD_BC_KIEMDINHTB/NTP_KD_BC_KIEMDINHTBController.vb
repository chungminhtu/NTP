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

Namespace YourCompany.Modules.NTP_KD_BC_KIEMDINHTB

    ''' <summary>
    ''' The Controller class for NTP_KD_BC_KIEMDINHTB
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_KD_BC_KIEMDINHTBController
    

        '#Region "Public Methods"
        '        Public Function [Get](ByVal iD_KiemdinhTB As Integer) As NTP_KD_BC_KIEMDINHTBInfo

        '            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_KD_BC_KIEMDINHTB(iD_KiemdinhTB), GetType(NTP_KD_BC_KIEMDINHTBInfo)), NTP_KD_BC_KIEMDINHTBInfo)

        '        End Function

        '        Public Function List() As List(Of NTP_KD_BC_KIEMDINHTBInfo)

        '            Return CBO.FillCollection(Of NTP_KD_BC_KIEMDINHTBInfo)(DataProvider.Instance().ListNTP_KD_BC_KIEMDINHTB())

        '        End Function
        '        Public Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String) As List(Of NTP_KD_BC_KIEMDINHTBInfo)

        '            Return CBO.FillCollection(Of NTP_KD_BC_KIEMDINHTBInfo)(DataProvider.Instance().ListByDieuKien(Id_BenhVien, ThangNam, DieuKien))

        '        End Function
        '        Public Function Add(ByVal objNTP_KD_BC_KIEMDINHTB As NTP_KD_BC_KIEMDINHTBInfo) As Integer

        '            Return CType(DataProvider.Instance().AddNTP_KD_BC_KIEMDINHTB(objNTP_KD_BC_KIEMDINHTB.Quy, objNTP_KD_BC_KIEMDINHTB.Nam, objNTP_KD_BC_KIEMDINHTB.ID_Benhvien, objNTP_KD_BC_KIEMDINHTB.TSTBThuchien, objNTP_KD_BC_KIEMDINHTB.TSTBCanthuchien, objNTP_KD_BC_KIEMDINHTB.SoTBKiemdinh, objNTP_KD_BC_KIEMDINHTB.SaiDlon, objNTP_KD_BC_KIEMDINHTB.SaiAlon, objNTP_KD_BC_KIEMDINHTB.DLLon, objNTP_KD_BC_KIEMDINHTB.SaiDNho, objNTP_KD_BC_KIEMDINHTB.SaiANho, objNTP_KD_BC_KIEMDINHTB.DLNho, objNTP_KD_BC_KIEMDINHTB.CLBPD, objNTP_KD_BC_KIEMDINHTB.CLBPK, objNTP_KD_BC_KIEMDINHTB.TaymauDat, objNTP_KD_BC_KIEMDINHTB.TaymauQ, objNTP_KD_BC_KIEMDINHTB.TaymauC, objNTP_KD_BC_KIEMDINHTB.DosachDat, objNTP_KD_BC_KIEMDINHTB.DosachK, objNTP_KD_BC_KIEMDINHTB.DodayDat, objNTP_KD_BC_KIEMDINHTB.DodayD, objNTP_KD_BC_KIEMDINHTB.DodayM, objNTP_KD_BC_KIEMDINHTB.KichthuocDat, objNTP_KD_BC_KIEMDINHTB.KichthuocT, objNTP_KD_BC_KIEMDINHTB.KichthuocN, objNTP_KD_BC_KIEMDINHTB.DominDat, objNTP_KD_BC_KIEMDINHTB.DominK, objNTP_KD_BC_KIEMDINHTB.Ngay_NM, objNTP_KD_BC_KIEMDINHTB.Nguoi_NM, objNTP_KD_BC_KIEMDINHTB.PTNhap, objNTP_KD_BC_KIEMDINHTB.HuyenXN, objNTP_KD_BC_KIEMDINHTB.TinhXN), Integer)

        '        End Function

        '        Public Sub Update(ByVal objNTP_KD_BC_KIEMDINHTB As NTP_KD_BC_KIEMDINHTBInfo)

        '            DataProvider.Instance().UpdateNTP_KD_BC_KIEMDINHTB(objNTP_KD_BC_KIEMDINHTB.ID_KiemdinhTB, objNTP_KD_BC_KIEMDINHTB.Quy, objNTP_KD_BC_KIEMDINHTB.Nam, objNTP_KD_BC_KIEMDINHTB.ID_Benhvien, objNTP_KD_BC_KIEMDINHTB.TSTBThuchien, objNTP_KD_BC_KIEMDINHTB.TSTBCanthuchien, objNTP_KD_BC_KIEMDINHTB.SoTBKiemdinh, objNTP_KD_BC_KIEMDINHTB.SaiDlon, objNTP_KD_BC_KIEMDINHTB.SaiAlon, objNTP_KD_BC_KIEMDINHTB.DLLon, objNTP_KD_BC_KIEMDINHTB.SaiDNho, objNTP_KD_BC_KIEMDINHTB.SaiANho, objNTP_KD_BC_KIEMDINHTB.DLNho, objNTP_KD_BC_KIEMDINHTB.CLBPD, objNTP_KD_BC_KIEMDINHTB.CLBPK, objNTP_KD_BC_KIEMDINHTB.TaymauDat, objNTP_KD_BC_KIEMDINHTB.TaymauQ, objNTP_KD_BC_KIEMDINHTB.TaymauC, objNTP_KD_BC_KIEMDINHTB.DosachDat, objNTP_KD_BC_KIEMDINHTB.DosachK, objNTP_KD_BC_KIEMDINHTB.DodayDat, objNTP_KD_BC_KIEMDINHTB.DodayD, objNTP_KD_BC_KIEMDINHTB.DodayM, objNTP_KD_BC_KIEMDINHTB.KichthuocDat, objNTP_KD_BC_KIEMDINHTB.KichthuocT, objNTP_KD_BC_KIEMDINHTB.KichthuocN, objNTP_KD_BC_KIEMDINHTB.DominDat, objNTP_KD_BC_KIEMDINHTB.DominK, objNTP_KD_BC_KIEMDINHTB.Ngay_NM, objNTP_KD_BC_KIEMDINHTB.Nguoi_NM, objNTP_KD_BC_KIEMDINHTB.PTNhap, objNTP_KD_BC_KIEMDINHTB.HuyenXN, objNTP_KD_BC_KIEMDINHTB.TinhXN)

        '        End Sub

        '        Public Sub Delete(ByVal iD_KiemdinhTB As Integer)

        '            DataProvider.Instance().DeleteNTP_KD_BC_KIEMDINHTB(iD_KiemdinhTB)

        '        End Sub
        '#End Region
#Region "Public Methods"
        Public Function [Get](ByVal iD_KiemdinhTB As Integer) As NTP_KD_BC_KIEMDINHTBInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_KD_BC_KIEMDINHTB(iD_KiemdinhTB), GetType(NTP_KD_BC_KIEMDINHTBInfo)), NTP_KD_BC_KIEMDINHTBInfo)

        End Function

        Public Function List() As List(Of NTP_KD_BC_KIEMDINHTBInfo)

            Return CBO.FillCollection(Of NTP_KD_BC_KIEMDINHTBInfo)(DataProvider.Instance().ListNTP_KD_BC_KIEMDINHTB())

        End Function
        Public Function GET_ID_BAOCAO(ByVal QUY As Byte, ByVal Nam As Integer, ByVal iD_BENHVIEN As String)
            Return CType(CBO.FillObject(DataProvider.Instance().GET_ID_BAOCAO(QUY, Nam, iD_BENHVIEN), GetType(NTP_KD_BC_KIEMDINHTBInfo)), NTP_KD_BC_KIEMDINHTBInfo)

            'Return CBO.FillCollection(Of NTP_BN_BC_KETQUADTInfo)(DataProvider.Instance().GET_ID_BAOCAO(QUY, Nam, DVBAOCAO))

        End Function
        Public Function Add(ByVal objNTP_KD_BC_KIEMDINHTB As NTP_KD_BC_KIEMDINHTBInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_KD_BC_KIEMDINHTB(objNTP_KD_BC_KIEMDINHTB.Quy, objNTP_KD_BC_KIEMDINHTB.Nam, objNTP_KD_BC_KIEMDINHTB.ID_Benhvien, objNTP_KD_BC_KIEMDINHTB.TSTBThuchien, objNTP_KD_BC_KIEMDINHTB.TSTBCanthuchien, objNTP_KD_BC_KIEMDINHTB.SoTBKiemdinh, objNTP_KD_BC_KIEMDINHTB.SaiDlon, objNTP_KD_BC_KIEMDINHTB.SaiAlon, objNTP_KD_BC_KIEMDINHTB.DLLon, objNTP_KD_BC_KIEMDINHTB.SaiDNho, objNTP_KD_BC_KIEMDINHTB.SaiANho, objNTP_KD_BC_KIEMDINHTB.DLNho, objNTP_KD_BC_KIEMDINHTB.CLBPDat, objNTP_KD_BC_KIEMDINHTB.TaymauDat, objNTP_KD_BC_KIEMDINHTB.DosachDat, objNTP_KD_BC_KIEMDINHTB.DodayDat, objNTP_KD_BC_KIEMDINHTB.KichthuocDat, objNTP_KD_BC_KIEMDINHTB.DominDat, objNTP_KD_BC_KIEMDINHTB.Ngay_NM, objNTP_KD_BC_KIEMDINHTB.Nguoi_NM, objNTP_KD_BC_KIEMDINHTB.PTNhap, objNTP_KD_BC_KIEMDINHTB.HuyenXN, objNTP_KD_BC_KIEMDINHTB.TinhXN, objNTP_KD_BC_KIEMDINHTB.NgayBC, objNTP_KD_BC_KIEMDINHTB.NguoiBC, objNTP_KD_BC_KIEMDINHTB.Loilon, objNTP_KD_BC_KIEMDINHTB.Loinho, objNTP_KD_BC_KIEMDINHTB.TongsoTBKiemdinh), Integer)

        End Function

        Public Sub Update(ByVal objNTP_KD_BC_KIEMDINHTB As NTP_KD_BC_KIEMDINHTBInfo)

            DataProvider.Instance().UpdateNTP_KD_BC_KIEMDINHTB(objNTP_KD_BC_KIEMDINHTB.ID_KiemdinhTB, objNTP_KD_BC_KIEMDINHTB.Quy, objNTP_KD_BC_KIEMDINHTB.Nam, objNTP_KD_BC_KIEMDINHTB.ID_Benhvien, objNTP_KD_BC_KIEMDINHTB.TSTBThuchien, objNTP_KD_BC_KIEMDINHTB.TSTBCanthuchien, objNTP_KD_BC_KIEMDINHTB.SoTBKiemdinh, objNTP_KD_BC_KIEMDINHTB.SaiDlon, objNTP_KD_BC_KIEMDINHTB.SaiAlon, objNTP_KD_BC_KIEMDINHTB.DLLon, objNTP_KD_BC_KIEMDINHTB.SaiDNho, objNTP_KD_BC_KIEMDINHTB.SaiANho, objNTP_KD_BC_KIEMDINHTB.DLNho, objNTP_KD_BC_KIEMDINHTB.CLBPDat, objNTP_KD_BC_KIEMDINHTB.TaymauDat, objNTP_KD_BC_KIEMDINHTB.DosachDat, objNTP_KD_BC_KIEMDINHTB.DodayDat, objNTP_KD_BC_KIEMDINHTB.KichthuocDat, objNTP_KD_BC_KIEMDINHTB.DominDat, objNTP_KD_BC_KIEMDINHTB.Ngay_NM, objNTP_KD_BC_KIEMDINHTB.Nguoi_NM, objNTP_KD_BC_KIEMDINHTB.PTNhap, objNTP_KD_BC_KIEMDINHTB.HuyenXN, objNTP_KD_BC_KIEMDINHTB.TinhXN, objNTP_KD_BC_KIEMDINHTB.NgayBC, objNTP_KD_BC_KIEMDINHTB.NguoiBC, objNTP_KD_BC_KIEMDINHTB.Loilon, objNTP_KD_BC_KIEMDINHTB.Loinho, objNTP_KD_BC_KIEMDINHTB.TongsoTBKiemdinh)

        End Sub

        Public Sub Delete(ByVal iD_KiemdinhTB As Integer)

            DataProvider.Instance().DeleteNTP_KD_BC_KIEMDINHTB(iD_KiemdinhTB)

        End Sub
        Public Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal MA_tinh As String) As List(Of NTP_KD_BC_KIEMDINHTBInfo)

            Return CBO.FillCollection(Of NTP_KD_BC_KIEMDINHTBInfo)(DataProvider.Instance().ListByDieuKien(Id_BenhVien, ThangNam, DieuKien, MA_tinh))

        End Function
        Public Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().ListBaoCao(Tinh, Mien, Vung, Nam, Quy, LoaiBC, Dieukien)
        End Function
        Public Function NTP_KD_BCTHUDOMPHBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal DieuKien As String) As DataSet
            Return DataProvider.Instance().NTP_KD_BCTHUDOMPHBYHUYEN_IN(Tinh, Mien, Vung, Nam, Quy, DieuKien)
        End Function
        Public Function InPhieuPhanhoiKQKD(ByVal Thang As String, ByVal Nam As Integer, ByVal id_Benhvien As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().InPhieuPhanhoiKQKD(Thang, Nam, id_Benhvien, LoaiBC, Dieukien)
        End Function

#End Region


    End Class
 
End Namespace
