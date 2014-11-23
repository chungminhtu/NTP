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

Namespace YourCompany.Modules.NTP_BN_BC_KETQUAXN

    ''' <summary>
    ''' The Controller class for NTP_BN_BC_KETQUAXN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_BC_KETQUAXNController
        

#Region "Public Methods"


        Public Function [Get](ByVal ID_BC_KetquaXN As Integer) As NTP_BN_BC_KETQUAXNInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_BC_KETQUAXN(ID_BC_KetquaXN), GetType(NTP_BN_BC_KETQUAXNInfo)), NTP_BN_BC_KETQUAXNInfo)


        End Function

        Public Function ListNTP_BN_BC_KETQUAXN(ByVal Nam As Integer, ByVal ID_BENHVIEN As String, ByVal Thamso As String, ByVal MA_TINH As String) As List(Of NTP_BN_BC_KETQUAXNInfo)
            Return CBO.FillCollection(Of NTP_BN_BC_KETQUAXNInfo)(DataProvider.Instance().ListNTP_BN_BC_KETQUAXN(Nam, ID_BENHVIEN, Thamso, MA_TINH))
            ' Return CType(CBO.FillObject(DataProvider.Instance().ListNTP_BN_BC_KETQUAXN(Nam, ID_BENHVIEN, Thamso, MA_TINH), GetType(NTP_BN_BC_KETQUAXNInfo)), NTP_BN_BC_KETQUAXNInfo)
        End Function
        Public Function LISTKETQUAXN_BYID(ByVal ID_KETQUAXN As Integer, ByVal dVBaocao As String, ByVal Quy As Integer, ByVal Nam As Integer) As NTP_BN_BC_KETQUAXNInfo
            Return CType(CBO.FillObject(DataProvider.Instance().LISTKETQUAXN_BYID(ID_KETQUAXN, dVBaocao, Quy, Nam), GetType(NTP_BN_BC_KETQUAXNInfo)), NTP_BN_BC_KETQUAXNInfo)
        End Function
        Public Function GET_ID_BAOCAO(ByVal QUY As Byte, ByVal Nam As Integer, ByVal DVBAOCAO As String)
            Return CType(CBO.FillObject(DataProvider.Instance().GET_ID_BAOCAO(QUY, Nam, DVBAOCAO), GetType(NTP_BN_BC_KETQUAXNInfo)), NTP_BN_BC_KETQUAXNInfo)


        End Function

        Public Function ListCOSODIEUTRI(ByVal ID_BENHVIEN As String, ByVal MATINH As String) As List(Of NTP_BN_BC_KETQUAXNInfo)
            Return CBO.FillCollection(Of NTP_BN_BC_KETQUAXNInfo)(DataProvider.Instance().ListCOSODIEUTRI(ID_BENHVIEN, MATINH))

        End Function
            
        Public Function AddNTP_BN_BC_KETQUAXN(ByVal objNTP_BN_BC_KETQUAXN As NTP_BN_BC_KETQUAXNInfo) As String
            Return CType(DataProvider.Instance().AddNTP_BN_BC_KETQUAXN(objNTP_BN_BC_KETQUAXN.Quy, objNTP_BN_BC_KETQUAXN.Nam, objNTP_BN_BC_KETQUAXN.DVBaocao, objNTP_BN_BC_KETQUAXN.NguoiBC, objNTP_BN_BC_KETQUAXN.NgayBC, objNTP_BN_BC_KETQUAXN.LaoDTMoi, objNTP_BN_BC_KETQUAXN.LaoTaitri, objNTP_BN_BC_KETQUAXN.DuongHaiT, objNTP_BN_BC_KETQUAXN.AmHaiT, objNTP_BN_BC_KETQUAXN.KhongHaiT, objNTP_BN_BC_KETQUAXN.DuongBaT, objNTP_BN_BC_KETQUAXN.AmBaT, objNTP_BN_BC_KETQUAXN.KhongBaT, objNTP_BN_BC_KETQUAXN.HuyenXN, objNTP_BN_BC_KETQUAXN.TinhXN, objNTP_BN_BC_KETQUAXN.PTNhap, objNTP_BN_BC_KETQUAXN.MA_TINH, objNTP_BN_BC_KETQUAXN.MA_HUYEN, objNTP_BN_BC_KETQUAXN.Nguoi_NM), String)

        End Function

        Public Sub UpdateNTP_BN_BC_KETQUAXN(ByVal objNTP_BN_BC_KETQUAXN As NTP_BN_BC_KETQUAXNInfo)
            DataProvider.Instance().UpdateNTP_BN_BC_KETQUAXN(objNTP_BN_BC_KETQUAXN.IDKetquaXN, objNTP_BN_BC_KETQUAXN.Quy, objNTP_BN_BC_KETQUAXN.Nam, objNTP_BN_BC_KETQUAXN.DVBaocao, objNTP_BN_BC_KETQUAXN.NguoiBC, objNTP_BN_BC_KETQUAXN.NgayBC, objNTP_BN_BC_KETQUAXN.LaoDTMoi, objNTP_BN_BC_KETQUAXN.LaoTaitri, objNTP_BN_BC_KETQUAXN.DuongHaiT, objNTP_BN_BC_KETQUAXN.AmHaiT, objNTP_BN_BC_KETQUAXN.KhongHaiT, objNTP_BN_BC_KETQUAXN.DuongBaT, objNTP_BN_BC_KETQUAXN.AmBaT, objNTP_BN_BC_KETQUAXN.KhongBaT, objNTP_BN_BC_KETQUAXN.HUYENXN, objNTP_BN_BC_KETQUAXN.TinhXN, objNTP_BN_BC_KETQUAXN.PTNhap, objNTP_BN_BC_KETQUAXN.MA_TINH, objNTP_BN_BC_KETQUAXN.MA_HUYEN, objNTP_BN_BC_KETQUAXN.Nguoi_NM)
        End Sub

        Public Sub DeleteNTP_BN_BC_KETQUAXN(ByVal ID_BC_KetquaXN As Integer)

            DataProvider.Instance().DeleteNTP_BN_BC_KETQUAXN(ID_BC_KetquaXN)

        End Sub
        Public Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().ListBaoCao(Tinh, Mien, Vung, Nam, Quy,Dieukien)
        End Function
        Public Function NTP_BN_BCKETQUAAMHOADOMBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().NTP_BN_BCKETQUAAMHOADOMBYHUYEN_IN(Tinh, Mien, Vung, Nam, Quy,Dieukien)
        End Function
#End Region



    End Class
End Namespace
