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

Namespace YourCompany.Modules.NTP_BAOCAOTUYENTINH

    ''' <summary>
    ''' The Controller class for NTP_BAOCAOTUYENTINH
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BAOCAOTUYENTINHController
        
#Region "Public Methods"
        Public Function ListBaoCaoTuyenTinh(ByVal Tinh As String, ByVal Nam As Integer, ByVal Quy As String, ByVal Phanloaibc As Integer, ByVal DVBaocao As String) As DataSet
            Return DataProvider.Instance().ListBaoCaoTuyenTinh(Tinh, Nam, Quy, Phanloaibc, DVBaocao)
        End Function
        'Public Function ListBaoCaoTuyenHuyen(ByVal Nam As Integer, ByVal Quy As Integer, ByVal DVBaocao As String, ByVal Phanloaibc As Integer) As DataSet
        '    Return DataProvider.Instance().ListBaoCaoTuyenHuyen(Nam, Quy, DVBaocao, Phanloaibc)
        'End Function
        Public Function ListBaoCaoTuyenHuyen(ByVal TUNGAY As String, ByVal DENNGAY As String, ByVal Nam As Integer, ByVal Quy As String, ByVal DVBaocao As String, ByVal Phanloaibc As Integer, ByVal CAPIN As Integer, ByVal CAPNHATDL As Integer)
            Return DataProvider.Instance().ListBaoCaoTuyenHuyen(TUNGAY, DENNGAY, Nam, Quy, DVBaocao, Phanloaibc, CAPIN, CAPNHATDL)

        End Function

        Public Function ListBaoCaoHoatdongPCL(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As Integer, ByVal Phanloaibc As Integer) As DataSet
            Return DataProvider.Instance().ListBaoCaoHoatdongPCL(Tinh, Mien, Vung, Nam, Quy, Phanloaibc)
        End Function

        Public Function ListDMTinh(ByVal Matinh As String) As List(Of NTP_BAOCAOTUYENTINH.NTP_DMTINHInfo)
            Return CBO.FillCollection(Of NTP_BAOCAOTUYENTINH.NTP_DMTINHInfo)(DataProvider.Instance().ListDMTinh(Matinh))
        End Function
        Public Function ListDMTinhByCap(ByVal MaBV As String) As List(Of NTP_BAOCAOTUYENTINH.NTP_DMTINHInfo)
            Return CBO.FillCollection(Of NTP_BAOCAOTUYENTINH.NTP_DMTINHInfo)(DataProvider.Instance().ListDMTinhByCap(MaBV))
        End Function
        Public Function GetNguoBC(ByVal Ma_Huyen As String, ByVal Ma_Tinh As String, ByVal Nam As Integer, ByVal Quy As Integer, ByVal Phanloaibc As Integer) As NTP_BAOCAOTUYENTINHInfo
            Return CType(CBO.FillObject(DataProvider.Instance().GetNguoBC(Ma_Huyen, Ma_Tinh, Nam, Quy, Phanloaibc), GetType(NTP_BAOCAOTUYENTINHInfo)), NTP_BAOCAOTUYENTINHInfo)

        End Function
        Public Function ListCocoDT(ByVal ID_Benhvien As String) As List(Of NTP_BAOCAOTUYENTINH.NTP_DM_BENHVIENInfo)
            Return CBO.FillCollection(Of NTP_BAOCAOTUYENTINH.NTP_DM_BENHVIENInfo)(DataProvider.Instance().ListCocoDT(ID_Benhvien))
        End Function

#End Region
    End Class

End Namespace
