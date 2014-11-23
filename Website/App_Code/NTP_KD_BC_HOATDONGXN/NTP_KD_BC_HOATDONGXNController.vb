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

Namespace YourCompany.Modules.NTP_KD_BC_HOATDONGXN

    ''' <summary>
    ''' The Controller class for NTP_KD_BC_HOATDONGXN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_KD_BC_HOATDONGXNController
   

#Region "Public Methods"
        Public Function [Get](ByVal iD_HOATDONGXN As Integer) As NTP_KD_BC_HOATDONGXNInfo
            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_KD_BC_HOATDONGXN(iD_HOATDONGXN), GetType(NTP_KD_BC_HOATDONGXNInfo)), NTP_KD_BC_HOATDONGXNInfo)
        End Function

        Public Function List() As List(Of NTP_KD_BC_HOATDONGXNInfo)
            Return CBO.FillCollection(Of NTP_KD_BC_HOATDONGXNInfo)(DataProvider.Instance().ListNTP_KD_BC_HOATDONGXN())
        End Function
        Public Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal MA_TINH As String) As List(Of NTP_KD_BC_HOATDONGXNInfo)
            Return CBO.FillCollection(Of NTP_KD_BC_HOATDONGXNInfo)(DataProvider.Instance().ListByDieuKien(ThangNam, Id_BenhVien, DieuKien, MA_TINH))
        End Function
        Public Function GET_ID_BAOCAO(ByVal QUY As Byte, ByVal Nam As Integer, ByVal iD_BENHVIEN As String)
            Return CType(CBO.FillObject(DataProvider.Instance().GET_ID_BAOCAO(QUY, Nam, iD_BENHVIEN), GetType(NTP_KD_BC_HOATDONGXNInfo)), NTP_KD_BC_HOATDONGXNInfo)

            'Return CBO.FillCollection(Of NTP_BN_BC_KETQUADTInfo)(DataProvider.Instance().GET_ID_BAOCAO(QUY, Nam, DVBAOCAO))

        End Function
        Public Function Add(ByVal objNTP_KD_BC_HOATDONGXN As NTP_KD_BC_HOATDONGXNInfo) As Integer
            Return CType(DataProvider.Instance().AddNTP_KD_BC_HOATDONGXN(objNTP_KD_BC_HOATDONGXN.Quy, objNTP_KD_BC_HOATDONGXN.Nam, objNTP_KD_BC_HOATDONGXN.ID_BENHVIEN, objNTP_KD_BC_HOATDONGXN.HuyenXN, objNTP_KD_BC_HOATDONGXN.TinhXN, objNTP_KD_BC_HOATDONGXN.SoTBPhathienD, objNTP_KD_BC_HOATDONGXN.SoTBPhathienA, objNTP_KD_BC_HOATDONGXN.SoTBTheodoiD, objNTP_KD_BC_HOATDONGXN.SoTBTheodoiA, objNTP_KD_BC_HOATDONGXN.NgayBC, objNTP_KD_BC_HOATDONGXN.NguoiBC, objNTP_KD_BC_HOATDONGXN.PTNhap), Integer)
        End Function

        Public Sub Update(ByVal objNTP_KD_BC_HOATDONGXN As NTP_KD_BC_HOATDONGXNInfo)
            DataProvider.Instance().UpdateNTP_KD_BC_HOATDONGXN(objNTP_KD_BC_HOATDONGXN.ID_HOATDONGXN, objNTP_KD_BC_HOATDONGXN.Quy, objNTP_KD_BC_HOATDONGXN.Nam, objNTP_KD_BC_HOATDONGXN.ID_BENHVIEN, objNTP_KD_BC_HOATDONGXN.HuyenXN, objNTP_KD_BC_HOATDONGXN.TinhXN, objNTP_KD_BC_HOATDONGXN.SoTBPhathienD, objNTP_KD_BC_HOATDONGXN.SoTBPhathienA, objNTP_KD_BC_HOATDONGXN.SoTBTheodoiD, objNTP_KD_BC_HOATDONGXN.SoTBTheodoiA, objNTP_KD_BC_HOATDONGXN.NgayBC, objNTP_KD_BC_HOATDONGXN.NguoiBC, objNTP_KD_BC_HOATDONGXN.PTNhap)
        End Sub

        Public Sub Delete(ByVal iD_HOATDONGXN As Integer)
            DataProvider.Instance().DeleteNTP_KD_BC_HOATDONGXN(iD_HOATDONGXN)
        End Sub
        Public Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().ListBaoCao(Tinh, Mien, Vung, Nam, Quy, LoaiBC, Dieukien)
        End Function
        Public Function NTP_KD_BCHOATDONGXETNGHIEMBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
            Return DataProvider.Instance().NTP_KD_BCHOATDONGXETNGHIEMBYHUYEN_IN(Tinh, Mien, Vung, Nam, Quy, LoaiBC, Dieukien)
        End Function
#End Region



    End Class
    Public Class NTP_KD_BC_HOATDONGXNCController
    

#Region "Public Methods"
        Public Function [Get](ByVal iD_HOATDONGXNC As Integer) As NTP_KD_BC_HOATDONGXNCInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_KD_BC_HOATDONGXNC(iD_HOATDONGXNC), GetType(NTP_KD_BC_HOATDONGXNCInfo)), NTP_KD_BC_HOATDONGXNCInfo)

        End Function

        Public Function ListHOATDONGXNC(ByVal iD_HOATDONGXNC As Integer, ByVal Phanloai As Integer) As NTP_KD_BC_HOATDONGXNCInfo

            Return CType(CBO.FillObject(DataProvider.Instance().ListHOATDONGXNC(iD_HOATDONGXNC, Phanloai), GetType(NTP_KD_BC_HOATDONGXNCInfo)), NTP_KD_BC_HOATDONGXNCInfo)

        End Function
        Public Function List(ByVal iD_HOATDONGXN As String) As List(Of NTP_KD_BC_HOATDONGXNCInfo)

            Return CBO.FillCollection(Of NTP_KD_BC_HOATDONGXNCInfo)(DataProvider.Instance().ListNTP_KD_BC_HOATDONGXNC(iD_HOATDONGXN))

        End Function

        Public Function Add(ByVal objNTP_KD_BC_HOATDONGXNC As NTP_KD_BC_HOATDONGXNCInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_KD_BC_HOATDONGXNC(objNTP_KD_BC_HOATDONGXNC.ID_HOATDONGXN, objNTP_KD_BC_HOATDONGXNC.PHANLOAI, objNTP_KD_BC_HOATDONGXNC.DuongAFB1Mau, objNTP_KD_BC_HOATDONGXNC.DuongAFB2Mau, objNTP_KD_BC_HOATDONGXNC.DuongAFB3Mau, objNTP_KD_BC_HOATDONGXNC.AmAFB1Mau, objNTP_KD_BC_HOATDONGXNC.AmAFB2Mau, objNTP_KD_BC_HOATDONGXNC.AmAFB3Mau, objNTP_KD_BC_HOATDONGXNC.SoBNDangky), Integer)

        End Function

        Public Sub Update(ByVal objNTP_KD_BC_HOATDONGXNC As NTP_KD_BC_HOATDONGXNCInfo)

            DataProvider.Instance().UpdateNTP_KD_BC_HOATDONGXNC(objNTP_KD_BC_HOATDONGXNC.ID_HOATDONGXNC, objNTP_KD_BC_HOATDONGXNC.ID_HOATDONGXN, objNTP_KD_BC_HOATDONGXNC.PHANLOAI, objNTP_KD_BC_HOATDONGXNC.DuongAFB1Mau, objNTP_KD_BC_HOATDONGXNC.DuongAFB2Mau, objNTP_KD_BC_HOATDONGXNC.DuongAFB3Mau, objNTP_KD_BC_HOATDONGXNC.AmAFB1Mau, objNTP_KD_BC_HOATDONGXNC.AmAFB2Mau, objNTP_KD_BC_HOATDONGXNC.AmAFB3Mau, objNTP_KD_BC_HOATDONGXNC.SoBNDangky)

        End Sub

        Public Sub Delete(ByVal iD_HOATDONGXNC As Integer)
            DataProvider.Instance().DeleteNTP_KD_BC_HOATDONGXNC(iD_HOATDONGXNC)
        End Sub
      
#End Region
    End Class
End Namespace
