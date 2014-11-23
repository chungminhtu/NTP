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

Namespace YourCompany.Modules.NTP_BN_CTCHONGLAO

    ''' <summary>
    ''' The Controller class for NTP_BN_CTCHONGLAO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_CTCHONGLAOController
       

        Public Function [Get](ByVal iD_CTChonglao As Integer) As NTP_BN_CTCHONGLAOInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_CTCHONGLAO(iD_CTChonglao), GetType(NTP_BN_CTCHONGLAOInfo)), NTP_BN_CTCHONGLAOInfo)

        End Function

        Public Function List() As List(Of NTP_BN_CTCHONGLAOInfo)

            Return CBO.FillCollection(Of NTP_BN_CTCHONGLAOInfo)(DataProvider.Instance().ListNTP_BN_CTCHONGLAO())

        End Function
        Public Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String) As List(Of NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOInfo)

            Return CBO.FillCollection(Of NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOInfo)(DataProvider.Instance().ListByDieuKien(Id_BenhVien, ThangNam, DieuKien))

        End Function

        Public Function Add(ByVal objNTP_BN_CTCHONGLAO As NTP_BN_CTCHONGLAOInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_CTCHONGLAO(objNTP_BN_CTCHONGLAO.Nam, objNTP_BN_CTCHONGLAO.MA_TINH, objNTP_BN_CTCHONGLAO.MA_HUYEN, objNTP_BN_CTCHONGLAO.MADV, objNTP_BN_CTCHONGLAO.AFBcongdong, objNTP_BN_CTCHONGLAO.AFBhotro, objNTP_BN_CTCHONGLAO.NgayBC, objNTP_BN_CTCHONGLAO.NguoiBC, objNTP_BN_CTCHONGLAO.NGAY_NM, objNTP_BN_CTCHONGLAO.NGUOI_NM, objNTP_BN_CTCHONGLAO.HuyenXN, objNTP_BN_CTCHONGLAO.TinhXN, objNTP_BN_CTCHONGLAO.PTNhap, objNTP_BN_CTCHONGLAO.SoBNPhathien, objNTP_BN_CTCHONGLAO.SoBNDKDT), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_CTCHONGLAO As NTP_BN_CTCHONGLAOInfo)
            DataProvider.Instance().UpdateNTP_BN_CTCHONGLAO(objNTP_BN_CTCHONGLAO.ID_CTChonglao, objNTP_BN_CTCHONGLAO.Nam, objNTP_BN_CTCHONGLAO.MA_TINH, objNTP_BN_CTCHONGLAO.MA_HUYEN, objNTP_BN_CTCHONGLAO.MADV, objNTP_BN_CTCHONGLAO.AFBcongdong, objNTP_BN_CTCHONGLAO.AFBhotro, objNTP_BN_CTCHONGLAO.NgayBC, objNTP_BN_CTCHONGLAO.NguoiBC, objNTP_BN_CTCHONGLAO.NGAY_NM, objNTP_BN_CTCHONGLAO.NGUOI_NM, objNTP_BN_CTCHONGLAO.HuyenXN, objNTP_BN_CTCHONGLAO.TinhXN, objNTP_BN_CTCHONGLAO.PTNhap, objNTP_BN_CTCHONGLAO.SoBNPhathien, objNTP_BN_CTCHONGLAO.SoBNDKDT)
        End Sub

        Public Sub Delete(ByVal iD_CTChonglao As Integer)

            DataProvider.Instance().DeleteNTP_BN_CTCHONGLAO(iD_CTChonglao)
        End Sub
       
    End Class

    Public Class NTP_BN_CTCHONGLAOP1Controller
      


        Public Function [Get](ByVal iD_CTChonglaoP1 As Integer) As NTP_BN_CTCHONGLAOP1Info

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_CTCHONGLAOP1(iD_CTChonglaoP1), GetType(NTP_BN_CTCHONGLAOP1Info)), NTP_BN_CTCHONGLAOP1Info)

        End Function
        Public Function ListCTCHONGLAOP1(ByVal iD_CTChonglaoP1 As Integer, ByVal phanloai As Integer) As NTP_BN_CTCHONGLAOP1Info

            Return CType(CBO.FillObject(DataProvider.Instance().ListCTCHONGLAOP1(iD_CTChonglaoP1, phanloai), GetType(NTP_BN_CTCHONGLAOP1Info)), NTP_BN_CTCHONGLAOP1Info)

        End Function

        Public Function List(ByVal Id_CTChongLao As Integer) As List(Of NTP_BN_CTCHONGLAOP1Info)

            Return CBO.FillCollection(Of NTP_BN_CTCHONGLAOP1Info)(DataProvider.Instance().ListNTP_BN_CTCHONGLAOP1(Id_CTChongLao))

        End Function

        Public Function Add(ByVal objNTP_BN_CTCHONGLAOP1 As NTP_BN_CTCHONGLAOP1Info) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_CTCHONGLAOP1(objNTP_BN_CTCHONGLAOP1.ID_CTChonglao, objNTP_BN_CTCHONGLAOP1.Phanloai, objNTP_BN_CTCHONGLAOP1.SoCShienco, objNTP_BN_CTCHONGLAOP1.SoCSTrienkhai, objNTP_BN_CTCHONGLAOP1.DiemkinhTT, objNTP_BN_CTCHONGLAOP1.DiemkinhKD, objNTP_BN_CTCHONGLAOP1.XNNC, objNTP_BN_CTCHONGLAOP1.XNKSD, objNTP_BN_CTCHONGLAOP1.TuvanHIV, objNTP_BN_CTCHONGLAOP1.CungcapART), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_CTCHONGLAOP1 As NTP_BN_CTCHONGLAOP1Info)

            DataProvider.Instance().UpdateNTP_BN_CTCHONGLAOP1(objNTP_BN_CTCHONGLAOP1.ID_CTChonglaoP1, objNTP_BN_CTCHONGLAOP1.ID_CTChonglao, objNTP_BN_CTCHONGLAOP1.Phanloai, objNTP_BN_CTCHONGLAOP1.SoCShienco, objNTP_BN_CTCHONGLAOP1.SoCSTrienkhai, objNTP_BN_CTCHONGLAOP1.DiemkinhTT, objNTP_BN_CTCHONGLAOP1.DiemkinhKD, objNTP_BN_CTCHONGLAOP1.XNNC, objNTP_BN_CTCHONGLAOP1.XNKSD, objNTP_BN_CTCHONGLAOP1.TuvanHIV, objNTP_BN_CTCHONGLAOP1.CungcapART)

        End Sub

        Public Sub Delete(ByVal iD_CTChonglaoP1 As Integer)

            DataProvider.Instance().DeleteNTP_BN_CTCHONGLAOP1(iD_CTChonglaoP1)

        End Sub



    End Class

    Public Class NTP_BN_CTCHONGLAOP2Controller



        Public Function [Get](ByVal iD_CTChonglaoP2 As Integer) As NTP_BN_CTCHONGLAOP2Info

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_CTCHONGLAOP2(iD_CTChonglaoP2), GetType(NTP_BN_CTCHONGLAOP2Info)), NTP_BN_CTCHONGLAOP2Info)

        End Function
        Public Function ListCTCHONGLAOP2(ByVal iD_CTChonglaoP2 As Integer, ByVal Loaihinhyte As Integer) As NTP_BN_CTCHONGLAOP2Info

            Return CType(CBO.FillObject(DataProvider.Instance().ListCTCHONGLAOP2(iD_CTChonglaoP2, Loaihinhyte), GetType(NTP_BN_CTCHONGLAOP2Info)), NTP_BN_CTCHONGLAOP2Info)

        End Function

        Public Function List(ByVal Id_CTChongLao As Integer) As List(Of NTP_BN_CTCHONGLAOP2Info)

            Return CBO.FillCollection(Of NTP_BN_CTCHONGLAOP2Info)(DataProvider.Instance().ListNTP_BN_CTCHONGLAOP2(Id_CTChongLao))

        End Function

        Public Function Add(ByVal objNTP_BN_CTCHONGLAOP2 As NTP_BN_CTCHONGLAOP2Info) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_CTCHONGLAOP2(objNTP_BN_CTCHONGLAOP2.ID_CTChonglao, objNTP_BN_CTCHONGLAOP2.LoaihinhYte, objNTP_BN_CTCHONGLAOP2.DuocChuyen, objNTP_BN_CTCHONGLAOP2.Chandoan, objNTP_BN_CTCHONGLAOP2.DieuTri), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_CTCHONGLAOP2 As NTP_BN_CTCHONGLAOP2Info)

            DataProvider.Instance().UpdateNTP_BN_CTCHONGLAOP2(objNTP_BN_CTCHONGLAOP2.ID_CTChonglaoP2, objNTP_BN_CTCHONGLAOP2.ID_CTChonglao, objNTP_BN_CTCHONGLAOP2.LoaihinhYte, objNTP_BN_CTCHONGLAOP2.DuocChuyen, objNTP_BN_CTCHONGLAOP2.Chandoan, objNTP_BN_CTCHONGLAOP2.DieuTri)

        End Sub

        Public Sub Delete(ByVal iD_CTChonglaoP2 As Integer)

            DataProvider.Instance().DeleteNTP_BN_CTCHONGLAOP2(iD_CTChonglaoP2)

        End Sub
    End Class
    Public Class NTP_BN_CTCHONGLAOP3Controller
        Public Function [Get](ByVal iD_CTChonglaoP3 As Integer) As NTP_BN_CTCHONGLAOP3Info

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_CTCHONGLAOP3(iD_CTChonglaoP3), GetType(NTP_BN_CTCHONGLAOP3Info)), NTP_BN_CTCHONGLAOP3Info)

        End Function
        Public Function ListCTCHONGLAOP3(ByVal iD_CTChonglaoP3 As Integer, ByVal iD_NguonNhanLuc As Integer) As NTP_BN_CTCHONGLAOP3Info

            Return CType(CBO.FillObject(DataProvider.Instance().ListCTCHONGLAOP3(iD_CTChonglaoP3, iD_NguonNhanLuc), GetType(NTP_BN_CTCHONGLAOP3Info)), NTP_BN_CTCHONGLAOP3Info)

        End Function
        Public Function List(ByVal Id_CTChongLao As Integer) As List(Of NTP_BN_CTCHONGLAOP3Info)

            Return CBO.FillCollection(Of NTP_BN_CTCHONGLAOP3Info)(DataProvider.Instance().ListNTP_BN_CTCHONGLAOP3(Id_CTChongLao))

        End Function

        Public Function Add(ByVal objNTP_BN_CTCHONGLAOP3 As NTP_BN_CTCHONGLAOP3Info) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_CTCHONGLAOP3(objNTP_BN_CTCHONGLAOP3.ID_CTChonglao, objNTP_BN_CTCHONGLAOP3.Phanloai, objNTP_BN_CTCHONGLAOP3.ID_NguonNhanLuc, objNTP_BN_CTCHONGLAOP3.NLHienco, objNTP_BN_CTCHONGLAOP3.NLDaotao, objNTP_BN_CTCHONGLAOP3.TongsoNLDaotao, objNTP_BN_CTCHONGLAOP3.Ghichu), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_CTCHONGLAOP3 As NTP_BN_CTCHONGLAOP3Info)

            DataProvider.Instance().UpdateNTP_BN_CTCHONGLAOP3(objNTP_BN_CTCHONGLAOP3.ID_CTChonglaoP3, objNTP_BN_CTCHONGLAOP3.ID_CTChonglao, objNTP_BN_CTCHONGLAOP3.Phanloai, objNTP_BN_CTCHONGLAOP3.ID_NguonNhanLuc, objNTP_BN_CTCHONGLAOP3.NLHienco, objNTP_BN_CTCHONGLAOP3.NLDaotao, objNTP_BN_CTCHONGLAOP3.TongsoNLDaotao, objNTP_BN_CTCHONGLAOP3.Ghichu)

        End Sub

        Public Sub Delete(ByVal iD_CTChonglaoP3 As Integer)

            DataProvider.Instance().DeleteNTP_BN_CTCHONGLAOP3(iD_CTChonglaoP3)

        End Sub
    End Class
    Public Class NTP_BN_BCCTCHONGLAOINController
        Public Function ListBCTHAMGIAYTETRONGCTCL(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer) As DataSet
            Return DataProvider.Instance().ListBCTHAMGIAYTETRONGCTCL(Tinh, Mien, Vung, Nam)
        End Function

        Public Function ListBCTHAMGIAYTETRONGHDPHATHIEN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PHANLOAIBC As Integer) As DataSet
            Return DataProvider.Instance().ListBCTHAMGIAYTETRONGHDPHATHIEN(Tinh, Mien, Vung, Nam, PHANLOAIBC)
        End Function
        Public Function ListBCNHANLUCTHAMGIAPCL(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PHANLOAIBC As Integer) As DataSet
            Return DataProvider.Instance().ListBCNHANLUCTHAMGIAPCL(Tinh, Mien, Vung, Nam, PHANLOAIBC)
        End Function
    End Class



End Namespace
