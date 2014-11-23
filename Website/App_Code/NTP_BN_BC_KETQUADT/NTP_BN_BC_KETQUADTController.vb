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

Namespace YourCompany.Modules.NTP_BN_BC_KETQUADT

    ''' <summary>
    ''' The Controller class for NTP_BN_BC_KETQUADT
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_BC_KETQUADTController
     



#Region "Public Methods"
        Public Function [Get](ByVal iD_BC_KetquaDT As Integer) As NTP_BN_BC_KETQUADTInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BC_KETQUADT(iD_BC_KetquaDT), GetType(NTP_BN_BC_KETQUADTInfo)), NTP_BN_BC_KETQUADTInfo)

        End Function

        Public Function List() As List(Of NTP_BN_BC_KETQUADTInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADTInfo)(DataProvider.Instance().ListNTP_BN_BC_KETQUADT())

        End Function
        Public Function GET_ID_BAOCAO(ByVal QUY As Byte, ByVal Nam As Integer, ByVal DVBAOCAO As String)
            Return CType(CBO.FillObject(DataProvider.Instance().GET_ID_BAOCAO(QUY, Nam, DVBAOCAO), GetType(NTP_BN_BC_KETQUADTInfo)), NTP_BN_BC_KETQUADTInfo)

        End Function
        Public Function ListNTP_BN_DONVICHUABC(ByVal quy As Byte, ByVal nam As Integer, ByVal _mA_TINH As String, ByVal LOAIBC As Byte, ByVal dVBaocao As String) As List(Of NTP_BN_BC_KETQUADTInfo)
            ' Return CType(CBO.FillObject(DataProvider.Instance().ListNTP_BN_DONVICHUABC(quy, nam, _mA_TINH, LOAIBC), GetType(NTP_BN_BC_KETQUADTInfo)), NTP_BN_BC_KETQUADTInfo)
            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADTInfo)(DataProvider.Instance().ListNTP_BN_DONVICHUABC(quy, nam, _mA_TINH, LOAIBC, dVBaocao))
        End Function
        Public Function Add(ByVal objNTP_BN_BC_KETQUADT As NTP_BN_BC_KETQUADTInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_BC_KETQUADT(objNTP_BN_BC_KETQUADT.Quy, objNTP_BN_BC_KETQUADT.Nam, objNTP_BN_BC_KETQUADT.DVBaocao, objNTP_BN_BC_KETQUADT.MA_TINH, objNTP_BN_BC_KETQUADT.MA_HUYEN, objNTP_BN_BC_KETQUADT.NguoiBC, objNTP_BN_BC_KETQUADT.NgayBC, objNTP_BN_BC_KETQUADT.NGAY_NM, objNTP_BN_BC_KETQUADT.NGUOI_NM, objNTP_BN_BC_KETQUADT.HuyenXN, objNTP_BN_BC_KETQUADT.TinhXN, objNTP_BN_BC_KETQUADT.PTNhap), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_BC_KETQUADT As NTP_BN_BC_KETQUADTInfo)

            DataProvider.Instance().UpdateNTP_BN_BC_KETQUADT(objNTP_BN_BC_KETQUADT.ID_BC_KetquaDT, objNTP_BN_BC_KETQUADT.Quy, objNTP_BN_BC_KETQUADT.Nam, objNTP_BN_BC_KETQUADT.DVBaocao, objNTP_BN_BC_KETQUADT.MA_TINH, objNTP_BN_BC_KETQUADT.MA_HUYEN, objNTP_BN_BC_KETQUADT.NguoiBC, objNTP_BN_BC_KETQUADT.NgayBC, objNTP_BN_BC_KETQUADT.NGAY_NM, objNTP_BN_BC_KETQUADT.NGUOI_NM, objNTP_BN_BC_KETQUADT.HuyenXN, objNTP_BN_BC_KETQUADT.TinhXN, objNTP_BN_BC_KETQUADT.PTNhap)

        End Sub

        Public Sub Delete(ByVal iD_BC_KetquaDT As Integer)

            DataProvider.Instance().DeleteNTP_BN_BC_KETQUADT(iD_BC_KetquaDT)

        End Sub


        Public Function ListByDieuKien(ByVal Nam As String, ByVal Id_BenhVien As String, ByVal DieuKien As String, ByVal mA_TINH As String) As List(Of NTP_BN_BC_KETQUADTInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADTInfo)(DataProvider.Instance().ListByDieuKien(Nam, Id_BenhVien, DieuKien, mA_TINH))

        End Function
#End Region
    End Class
    Public Class NTP_BN_BC_KETQUADTPController

#Region "Public Methods"
        Public Function [Get](ByVal iD_BC_KetquaDTP1 As Integer) As NTP_BN_BC_KETQUADTPInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BC_KETQUADTP(iD_BC_KetquaDTP1), GetType(NTP_BN_BC_KETQUADTPInfo)), NTP_BN_BC_KETQUADTPInfo)

        End Function
       
        Public Function ListKETQUADTP1(ByVal iD_BC_KetquaDTP1 As Integer, ByVal iD_Phanloai As Integer, ByVal dVBaocao As String, ByVal Quy As Integer, ByVal Nam As Integer) As NTP_BN_BC_KETQUADTPInfo

            Return CType(CBO.FillObject(DataProvider.Instance().ListKETQUADTP1(iD_BC_KetquaDTP1, iD_Phanloai, dVBaocao, Quy, Nam), GetType(NTP_BN_BC_KETQUADTPInfo)), NTP_BN_BC_KETQUADTPInfo)

        End Function
       
        Public Function List(ByVal ID_BC_KetquaDT As Integer) As List(Of NTP_BN_BC_KETQUADTPInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADTPInfo)(DataProvider.Instance().ListNTP_BN_BC_KETQUADTP(ID_BC_KetquaDT))

        End Function

        Public Function Add(ByVal objNTP_BN_BC_KETQUADTP As NTP_BN_BC_KETQUADTPInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_BC_KETQUADTP(objNTP_BN_BC_KETQUADTP.ID_BC_KetquaDT, objNTP_BN_BC_KETQUADTP.ID_Phanloai, objNTP_BN_BC_KETQUADTP.SoBNDK, objNTP_BN_BC_KETQUADTP.Khoi, objNTP_BN_BC_KETQUADTP.Hoanthanh, objNTP_BN_BC_KETQUADTP.Chet, objNTP_BN_BC_KETQUADTP.Thatbai, objNTP_BN_BC_KETQUADTP.Bo, objNTP_BN_BC_KETQUADTP.Chuyen, objNTP_BN_BC_KETQUADTP.Khongdanhgia), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_BC_KETQUADTP As NTP_BN_BC_KETQUADTPInfo)

            DataProvider.Instance().UpdateNTP_BN_BC_KETQUADTP(objNTP_BN_BC_KETQUADTP.ID_BC_KetquaDTP1, objNTP_BN_BC_KETQUADTP.ID_BC_KetquaDT, objNTP_BN_BC_KETQUADTP.ID_Phanloai, objNTP_BN_BC_KETQUADTP.SoBNDK, objNTP_BN_BC_KETQUADTP.Khoi, objNTP_BN_BC_KETQUADTP.Hoanthanh, objNTP_BN_BC_KETQUADTP.Chet, objNTP_BN_BC_KETQUADTP.Thatbai, objNTP_BN_BC_KETQUADTP.Bo, objNTP_BN_BC_KETQUADTP.Chuyen, objNTP_BN_BC_KETQUADTP.Khongdanhgia)

        End Sub

        Public Sub Delete(ByVal iD_BC_KetquaDTP1 As Integer)

            DataProvider.Instance().DeleteNTP_BN_BC_KETQUADTP(iD_BC_KetquaDTP1)

        End Sub
#End Region
    End Class
    Public Class NTP_BN_BC_KETQUADTP2Controller
#Region "Public Methods"
        Public Function [Get](ByVal iD_BC_KetquaDT_P2 As Integer) As NTP_BN_BC_KETQUADTP2Info

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BC_KETQUADTP2(iD_BC_KetquaDT_P2), GetType(NTP_BN_BC_KETQUADTP2Info)), NTP_BN_BC_KETQUADTP2Info)

        End Function

        Public Function ListKETQUADTP2(ByVal iD_BC_KetquaDTP2 As Integer, ByVal Phanloai As Byte) As NTP_BN_BC_KETQUADTP2Info

            Return CType(CBO.FillObject(DataProvider.Instance().ListKETQUADTP2(iD_BC_KetquaDTP2, Phanloai), GetType(NTP_BN_BC_KETQUADTP2Info)), NTP_BN_BC_KETQUADTP2Info)

        End Function
        Public Function List(ByVal ID_BC_KetquaDT As Integer) As List(Of NTP_BN_BC_KETQUADTP2Info)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADTP2Info)(DataProvider.Instance().ListNTP_BN_BC_KETQUADTP2(ID_BC_KetquaDT))

        End Function

        Public Function Add(ByVal objNTP_BN_BC_KETQUADTP2 As NTP_BN_BC_KETQUADTP2Info) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_BC_KETQUADTP2(objNTP_BN_BC_KETQUADTP2.ID_BC_KetquaDT, objNTP_BN_BC_KETQUADTP2.Phanloai, objNTP_BN_BC_KETQUADTP2.XNHIV, objNTP_BN_BC_KETQUADTP2.DuongHIV, objNTP_BN_BC_KETQUADTP2.CPT, objNTP_BN_BC_KETQUADTP2.ARV), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_BC_KETQUADTP2 As NTP_BN_BC_KETQUADTP2Info)

            DataProvider.Instance().UpdateNTP_BN_BC_KETQUADTP2(objNTP_BN_BC_KETQUADTP2.ID_BC_KetquaDT_P2, objNTP_BN_BC_KETQUADTP2.ID_BC_KetquaDT, objNTP_BN_BC_KETQUADTP2.Phanloai, objNTP_BN_BC_KETQUADTP2.XNHIV, objNTP_BN_BC_KETQUADTP2.DuongHIV, objNTP_BN_BC_KETQUADTP2.CPT, objNTP_BN_BC_KETQUADTP2.ARV)

        End Sub

        Public Sub Delete(ByVal iD_BC_KetquaDT_P2 As Integer)

            DataProvider.Instance().DeleteNTP_BN_BC_KETQUADTP2(iD_BC_KetquaDT_P2)

        End Sub
#End Region
    End Class
    Public Class NTP_BN_BCKETQUADIEUTRILAOINController
#Region "Public Methods"

        Public Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Luachon As Integer, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().ListBaoCao(Tinh, Mien, Vung, Nam, Quy, Luachon,Dieukien)
        End Function

        Public Function ListBaoCaoKQDTCacthe(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoKQDTCacthe(Tinh, Mien, Vung, Nam, Quy)
        End Function
        Public Function BCKETQUADIEUTRILAOBYHUYEN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Luachon As Integer, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().BCKETQUADIEUTRILAOBYHUYEN(Tinh, Mien, Vung, Nam, Quy, Luachon,Dieukien)
        End Function
#End Region
    End Class

    Public Class NTP_DM_BENHVIENController


#Region "Public Methods"


        Public Function ListNTP_DM_BENHVIEN(ByVal MA_TINH As String) As List(Of NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENInfo)(DataProvider.Instance().ListNTP_DM_BENHVIEN(MA_TINH))

        End Function

        Public Function ListNTP_DM_BENHVIEN_BY_VUNG(ByVal sTEN_BV As String, ByVal IDVung As Integer) As List(Of NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENInfo)
            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENInfo)(DataProvider.Instance().ListNTP_DM_BENHVIEN_BY_VUNG(sTEN_BV, IDVung))

        End Function


#End Region
    End Class

    Public Class NTP_DM_TINHController


#Region "Public Methods"

        Public Function ListNTP_DM_TINHALL() As List(Of NTP_BN_BC_KETQUADT.NTP_DM_TINHInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_TINHInfo)(DataProvider.Instance().ListNTP_DM_TINHALL())

        End Function
        Public Function ListNTP_DM_TINH(ByVal id_benhvien As String) As List(Of NTP_BN_BC_KETQUADT.NTP_DM_TINHInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_TINHInfo)(DataProvider.Instance().ListNTP_DM_TINH(id_benhvien))

        End Function
        Public Function ListNTP_DM_TINHforMIEN(ByVal ID_MIEN As Integer) As List(Of NTP_BN_BC_KETQUADT.NTP_DM_TINHInfo)
            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_TINHInfo)(DataProvider.Instance().ListNTP_DM_TINHforMIEN(ID_MIEN))
        End Function

#End Region
    End Class
    Public Class NTP_DM_MIENController

#Region "Public Methods"
       

        Public Function List() As List(Of NTP_BN_BC_KETQUADT.NTP_DM_MIENInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_MIENInfo)(DataProvider.Instance().ListNTP_DM_MIEN())

        End Function
        Public Function NTP_DM_MIEN_Select(ByVal ID_MIEN As Integer) As List(Of NTP_BN_BC_KETQUADT.NTP_DM_MIENInfo)
            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_MIENInfo)(DataProvider.Instance().NTP_DM_MIEN_Select(ID_MIEN))

        End Function

#End Region
    End Class
    Public Class NTP_DM_VUNGController
      

#Region "Public Methods"
        Public Function [Get](ByVal iD_VUNG As Integer) As NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_DM_VUNG(iD_VUNG), GetType(NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo)), NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo)

        End Function

        Public Function ListNTP_DM_VUNGALL() As List(Of NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo)(DataProvider.Instance().ListNTP_DM_VUNGALL())

        End Function

        Public Function ListByMien(ByVal Mien As Integer) As List(Of NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo)(DataProvider.Instance().ListNTP_DM_VUNG(Mien))

        End Function

        Public Function Add(ByVal objNTP_DM_VUNG As NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_DM_VUNG(objNTP_DM_VUNG.TEN_VUNG, objNTP_DM_VUNG.ID_MIEN), Integer)

        End Function

        Public Sub Update(ByVal objNTP_DM_VUNG As NTP_BN_BC_KETQUADT.NTP_DM_VUNGInfo)

            DataProvider.Instance().UpdateNTP_DM_VUNG(objNTP_DM_VUNG.ID_VUNG, objNTP_DM_VUNG.TEN_VUNG, objNTP_DM_VUNG.ID_MIEN)

        End Sub

        Public Sub Delete(ByVal iD_VUNG As Integer)

            DataProvider.Instance().DeleteNTP_DM_VUNG(iD_VUNG)

        End Sub
#End Region

    End Class
    Public Class NTP_DM_LOAIBVController


#Region "Public Methods"


        Public Function List() As List(Of NTP_BN_BC_KETQUADT.NTP_DM_LOAIBVInfo)

            Return CBO.FillCollection(Of NTP_BN_BC_KETQUADT.NTP_DM_LOAIBVInfo)(DataProvider.Instance().ListNTP_DM_LOAIBV())

        End Function
       

#End Region
    End Class
End Namespace
