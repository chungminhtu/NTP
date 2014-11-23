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

Namespace YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO

    ''' <summary>
    ''' The Controller class for NTP_BN_BC_THUNHANBNLAO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_BC_THUNHANBNLAOController
       

#Region "Public Methods"
        Public Function [Get](ByVal iD_BCThunhanBNLao As Integer) As NTP_BN_BC_THUNHANBNLAOInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BC_THUNHANBNLAO(iD_BCThunhanBNLao), GetType(NTP_BN_BC_THUNHANBNLAOInfo)), NTP_BN_BC_THUNHANBNLAOInfo)

        End Function

        Public Function List() As List(Of NTP_BN_BC_THUNHANBNLAOInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_THUNHANBNLAOInfo)(DataProvider.Instance().ListNTP_BN_BC_THUNHANBNLAO())

        End Function
        Public Function GET_ID_BAOCAO(ByVal QUY As Byte, ByVal Nam As Integer, ByVal DVBAOCAO As String)
            Return CType(CBO.FillObject(DataProvider.Instance().GET_ID_BAOCAO(QUY, Nam, DVBAOCAO), GetType(NTP_BN_BC_THUNHANBNLAOInfo)), NTP_BN_BC_THUNHANBNLAOInfo)

        End Function
        Public Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal MA_TINH As String) As List(Of NTP_BN_BC_THUNHANBNLAOInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_THUNHANBNLAOInfo)(DataProvider.Instance().ListByDieuKien(Id_BenhVien, ThangNam, DieuKien, MA_TINH))

        End Function

        Public Function Add(ByVal objNTP_BN_BC_THUNHANBNLAO As NTP_BN_BC_THUNHANBNLAOInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_BC_THUNHANBNLAO(objNTP_BN_BC_THUNHANBNLAO.Quy, objNTP_BN_BC_THUNHANBNLAO.Nam, objNTP_BN_BC_THUNHANBNLAO.DVBaocao, objNTP_BN_BC_THUNHANBNLAO.NguoiBC, objNTP_BN_BC_THUNHANBNLAO.NgayBC, objNTP_BN_BC_THUNHANBNLAO.HuyenXN, objNTP_BN_BC_THUNHANBNLAO.TinhXN, objNTP_BN_BC_THUNHANBNLAO.PTNhap, objNTP_BN_BC_THUNHANBNLAO.MA_TINH, objNTP_BN_BC_THUNHANBNLAO.MA_HUYEN, objNTP_BN_BC_THUNHANBNLAO.NGAY_NM, objNTP_BN_BC_THUNHANBNLAO.NGUOI_NM), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_BC_THUNHANBNLAO As NTP_BN_BC_THUNHANBNLAOInfo)

            DataProvider.Instance().UpdateNTP_BN_BC_THUNHANBNLAO(objNTP_BN_BC_THUNHANBNLAO.ID_BCThunhanBNLao, objNTP_BN_BC_THUNHANBNLAO.Quy, objNTP_BN_BC_THUNHANBNLAO.Nam, objNTP_BN_BC_THUNHANBNLAO.DVBaocao, objNTP_BN_BC_THUNHANBNLAO.NguoiBC, objNTP_BN_BC_THUNHANBNLAO.NgayBC, objNTP_BN_BC_THUNHANBNLAO.HuyenXN, objNTP_BN_BC_THUNHANBNLAO.TinhXN, objNTP_BN_BC_THUNHANBNLAO.PTNhap, objNTP_BN_BC_THUNHANBNLAO.MA_TINH, objNTP_BN_BC_THUNHANBNLAO.MA_HUYEN, objNTP_BN_BC_THUNHANBNLAO.NGAY_NM, objNTP_BN_BC_THUNHANBNLAO.NGUOI_NM)

        End Sub

        Public Sub Delete(ByVal iD_BCThunhanBNLao As Integer)

            DataProvider.Instance().DeleteNTP_BN_BC_THUNHANBNLAO(iD_BCThunhanBNLao)

        End Sub
#End Region



    End Class
    Public Class NTP_BN_BC_THUNHANBNLAOP1Controller

#Region "Public Methods"
        Public Function [Get](ByVal iD_BCThunhanBNLao As Integer) As NTP_BN_BC_THUNHANBNLAOP1Info

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BC_THUNHANBNLAOP1(iD_BCThunhanBNLao), GetType(NTP_BN_BC_THUNHANBNLAOP1Info)), NTP_BN_BC_THUNHANBNLAOP1Info)

        End Function
        Public Function ListTHUNHANBNLAOP1(ByVal iD_BCThunhanBNLao As Integer, ByVal Phanloai As Integer) As NTP_BN_BC_THUNHANBNLAOP1Info
            Return CType(CBO.FillObject(DataProvider.Instance().ListTHUNHANBNLAOP1(iD_BCThunhanBNLao, Phanloai), GetType(NTP_BN_BC_THUNHANBNLAOP1Info)), NTP_BN_BC_THUNHANBNLAOP1Info)

        End Function
        Public Function List(ByVal iD_BCThunhanBNLao As Integer) As List(Of NTP_BN_BC_THUNHANBNLAOP1Info)

            Return CBO.FillCollection(Of NTP_BN_BC_THUNHANBNLAOP1Info)(DataProvider.Instance().ListNTP_BN_BC_THUNHANBNLAOP1(iD_BCThunhanBNLao))

        End Function


        Public Function Add(ByVal objNTP_BN_BC_THUNHANBNLAOP1 As NTP_BN_BC_THUNHANBNLAOP1Info) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_BC_THUNHANBNLAOP1(objNTP_BN_BC_THUNHANBNLAOP1.ID_BCThunhanBNLao, objNTP_BN_BC_THUNHANBNLAOP1.Phanloai, objNTP_BN_BC_THUNHANBNLAOP1.Moi, objNTP_BN_BC_THUNHANBNLAOP1.Taiphat, objNTP_BN_BC_THUNHANBNLAOP1.Thatbai, objNTP_BN_BC_THUNHANBNLAOP1.Taitri, objNTP_BN_BC_THUNHANBNLAOP1.AFBKhac, objNTP_BN_BC_THUNHANBNLAOP1.AmNho, objNTP_BN_BC_THUNHANBNLAOP1.AmTrung, objNTP_BN_BC_THUNHANBNLAOP1.AmLon, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiPhoiNho, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiPhoiTrung, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiPhoiLon, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiphoiKhac), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_BC_THUNHANBNLAOP1 As NTP_BN_BC_THUNHANBNLAOP1Info)

            DataProvider.Instance().UpdateNTP_BN_BC_THUNHANBNLAOP1(objNTP_BN_BC_THUNHANBNLAOP1.ID_BCThunhanBNLao, objNTP_BN_BC_THUNHANBNLAOP1.Phanloai, objNTP_BN_BC_THUNHANBNLAOP1.ID_BCThunhanBNLaoP1, objNTP_BN_BC_THUNHANBNLAOP1.Moi, objNTP_BN_BC_THUNHANBNLAOP1.Taiphat, objNTP_BN_BC_THUNHANBNLAOP1.Thatbai, objNTP_BN_BC_THUNHANBNLAOP1.Taitri, objNTP_BN_BC_THUNHANBNLAOP1.AFBKhac, objNTP_BN_BC_THUNHANBNLAOP1.AmNho, objNTP_BN_BC_THUNHANBNLAOP1.AmTrung, objNTP_BN_BC_THUNHANBNLAOP1.AmLon, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiPhoiNho, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiPhoiTrung, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiPhoiLon, objNTP_BN_BC_THUNHANBNLAOP1.NgoaiphoiKhac)

        End Sub

        Public Sub Delete(ByVal iD_BCThunhanBNLao As Integer)

            DataProvider.Instance().DeleteNTP_BN_BC_THUNHANBNLAOP1(iD_BCThunhanBNLao)

        End Sub
#End Region



    End Class
    Public Class NTP_BN_BC_THUNHANBNLAOP2Controller
   

#Region "Public Methods"
        Public Function [Get](ByVal iD_BCThunhanBNLao As Integer) As NTP_BN_BC_THUNHANBNLAOP2Info

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BC_THUNHANBNLAOP2(iD_BCThunhanBNLao), GetType(NTP_BN_BC_THUNHANBNLAOP2Info)), NTP_BN_BC_THUNHANBNLAOP2Info)

        End Function
        Public Function ListTHUNHANBNLAOP2(ByVal iD_BCThunhanBNLao As Integer, ByVal Phanloai As Integer) As NTP_BN_BC_THUNHANBNLAOP2Info

            Return CType(CBO.FillObject(DataProvider.Instance().ListTHUNHANBNLAOP2(iD_BCThunhanBNLao, Phanloai), GetType(NTP_BN_BC_THUNHANBNLAOP2Info)), NTP_BN_BC_THUNHANBNLAOP2Info)

        End Function
        Public Function List(ByVal iD_BCThunhanBNLao As Integer) As List(Of NTP_BN_BC_THUNHANBNLAOP2Info)

            Return CBO.FillCollection(Of NTP_BN_BC_THUNHANBNLAOP2Info)(DataProvider.Instance().ListNTP_BN_BC_THUNHANBNLAOP2(iD_BCThunhanBNLao))

        End Function

        Public Function Add(ByVal objNTP_BN_BC_THUNHANBNLAOP2 As NTP_BN_BC_THUNHANBNLAOP2Info) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_BC_THUNHANBNLAOP2(objNTP_BN_BC_THUNHANBNLAOP2.ID_BCThunhanBNLao, objNTP_BN_BC_THUNHANBNLAOP2.Phanloai, objNTP_BN_BC_THUNHANBNLAOP2.Nam0, objNTP_BN_BC_THUNHANBNLAOP2.Nu0, objNTP_BN_BC_THUNHANBNLAOP2.Nam5, objNTP_BN_BC_THUNHANBNLAOP2.Nu5, objNTP_BN_BC_THUNHANBNLAOP2.Nam15, objNTP_BN_BC_THUNHANBNLAOP2.Nu15, objNTP_BN_BC_THUNHANBNLAOP2.Nam25, objNTP_BN_BC_THUNHANBNLAOP2.Nu25, objNTP_BN_BC_THUNHANBNLAOP2.Nam35, objNTP_BN_BC_THUNHANBNLAOP2.Nu35, objNTP_BN_BC_THUNHANBNLAOP2.Nam45, objNTP_BN_BC_THUNHANBNLAOP2.Nu45, objNTP_BN_BC_THUNHANBNLAOP2.Nam55, objNTP_BN_BC_THUNHANBNLAOP2.Nu55, objNTP_BN_BC_THUNHANBNLAOP2.Nam65, objNTP_BN_BC_THUNHANBNLAOP2.Nu65), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_BC_THUNHANBNLAOP2 As NTP_BN_BC_THUNHANBNLAOP2Info)

            DataProvider.Instance().UpdateNTP_BN_BC_THUNHANBNLAOP2(objNTP_BN_BC_THUNHANBNLAOP2.ID_BCThunhanBNLao, objNTP_BN_BC_THUNHANBNLAOP2.Phanloai, objNTP_BN_BC_THUNHANBNLAOP2.ID_BCThunhanBNLaoP2, objNTP_BN_BC_THUNHANBNLAOP2.Nam0, objNTP_BN_BC_THUNHANBNLAOP2.Nu0, objNTP_BN_BC_THUNHANBNLAOP2.Nam5, objNTP_BN_BC_THUNHANBNLAOP2.Nu5, objNTP_BN_BC_THUNHANBNLAOP2.Nam15, objNTP_BN_BC_THUNHANBNLAOP2.Nu15, objNTP_BN_BC_THUNHANBNLAOP2.Nam25, objNTP_BN_BC_THUNHANBNLAOP2.Nu25, objNTP_BN_BC_THUNHANBNLAOP2.Nam35, objNTP_BN_BC_THUNHANBNLAOP2.Nu35, objNTP_BN_BC_THUNHANBNLAOP2.Nam45, objNTP_BN_BC_THUNHANBNLAOP2.Nu45, objNTP_BN_BC_THUNHANBNLAOP2.Nam55, objNTP_BN_BC_THUNHANBNLAOP2.Nu55, objNTP_BN_BC_THUNHANBNLAOP2.Nam65, objNTP_BN_BC_THUNHANBNLAOP2.Nu65)

        End Sub

        Public Sub Delete(ByVal iD_BCThunhanBNLao As Integer)

            DataProvider.Instance().DeleteNTP_BN_BC_THUNHANBNLAOP2(iD_BCThunhanBNLao)

        End Sub
#End Region
    End Class
    Public Class NTP_BN_BCTHUNHANBNLAOINController
#Region "Public Methods"

      
        Public Function ListBaoCaoTuoiGioi(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal PhanLoaiBC As Integer) As DataSet
            Return DataProvider.Instance().ListBaoCaoTuoiGioi(Tinh, Mien, Vung, Nam, Quy, PhanLoaiBC)
        End Function
        Public Function ListBaoCaoNgoaiLaoPhoi(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoNgoaiLaoPhoi(Tinh, Mien, Vung, Nam, Quy)
        End Function
        Public Function ListBaoCaoThunhanBNLao_TUYENHUYEN(ByVal Quy As Integer, ByVal Nam As Integer, ByVal DonVi As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoThunhanBNLao_TUYENHUYEN(Quy, Nam, DonVi)
        End Function
        Public Function ListBaoCaoNTP_BN_BCTHUNHANBNLAO_IN(ByVal PhanloaiBC As Integer, ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoNTP_BN_BCTHUNHANBNLAO_IN(PhanloaiBC, Tinh, Mien, Vung, Nam, Quy, Dieukien)
        End Function
        Public Function ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGHDPHATHIEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer) As DataSet
            Return DataProvider.Instance().ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGHDPHATHIEN_IN(Tinh, Mien, Vung, Nam)
        End Function
        Public Function ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGCTCL_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal PhanLoaiYTe As Integer) As DataSet
            Return DataProvider.Instance().ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGCTCL_IN(Tinh, Mien, Vung, Nam, PhanLoaiYTe)
        End Function
        Public Function ListBaoCaoNTP_BN_BCKETQUADTCHUNGCACTHE_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer) As DataSet
            Return DataProvider.Instance().ListBaoCaoNTP_BN_BCTHAMGIAYTETRONGHDPHATHIEN_IN(Tinh, Mien, Vung, Nam)
        End Function
        Public Function ListBaoCaoNTP_BN_BCKETQUADT_TUYENHUYEN(ByVal Quy As Integer, ByVal Nam As Integer, ByVal DonVi As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoNTP_BN_BCKETQUADT_TUYENHUYEN(Quy, Nam, DonVi)
        End Function
        Public Function ListBaoCaoNTP_BN_BCTHUNHANBNLAOBYHUYEN_IN(ByVal PhanloaiBC As Integer, ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoNTP_BN_BCTHUNHANBNLAOBYHUYEN_IN(PhanloaiBC, Tinh, Mien, Vung, Nam, Quy, Dieukien)
        End Function
        Public Function ListBaoCaoNTP_BN_BCTHUNHANBNLAOBY_TREEM(ByVal PhanloaiBC As Integer, ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoNTP_BN_BCTHUNHANBNLAOBY_TREEM(PhanloaiBC, Tinh, Mien, Vung, Nam, Quy, Dieukien)
        End Function
#End Region
    End Class

End Namespace
