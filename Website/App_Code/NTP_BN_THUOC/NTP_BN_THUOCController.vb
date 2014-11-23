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

Namespace YourCompany.Modules.NTP_BN_THUOC

    ''' <summary>
    ''' The Controller class for NTP_BN_THUOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_THUOCController
    

#Region "Public Methods"
        Public Function [Get](ByVal iD_Thuoc As Integer) As NTP_BN_THUOCInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_THUOC(iD_Thuoc), GetType(NTP_BN_THUOCInfo)), NTP_BN_THUOCInfo)

        End Function

        Public Function List(ByVal Id_DieuTri As Integer) As List(Of NTP_BN_THUOCInfo)

            Return CBO.FillCollection(Of NTP_BN_THUOCInfo)(DataProvider.Instance().ListNTP_BN_THUOC(Id_DieuTri))

        End Function

        Public Function Add(ByVal objNTP_BN_THUOC As NTP_BN_THUOCInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_THUOC(objNTP_BN_THUOC.ID_Dieutri, objNTP_BN_THUOC.NgayDT, objNTP_BN_THUOC.ID_PhacdoDT, objNTP_BN_THUOC.PhacDoKhac, objNTP_BN_THUOC.GiaidoanDT, objNTP_BN_THUOC.Tungay, objNTP_BN_THUOC.RHZE, objNTP_BN_THUOC.RHZ, objNTP_BN_THUOC.RHE, objNTP_BN_THUOC.RH, objNTP_BN_THUOC.EH, objNTP_BN_THUOC.E, objNTP_BN_THUOC.H, objNTP_BN_THUOC.Z, objNTP_BN_THUOC.S, objNTP_BN_THUOC.TLaoKhac, objNTP_BN_THUOC.Cotrimoxazole, objNTP_BN_THUOC.ART, objNTP_BN_THUOC.Khac, objNTP_BN_THUOC.NGAY_NM, objNTP_BN_THUOC.NGUOI_NM), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_THUOC As NTP_BN_THUOCInfo)

            DataProvider.Instance().UpdateNTP_BN_THUOC(objNTP_BN_THUOC.ID_Thuoc, objNTP_BN_THUOC.ID_Dieutri, objNTP_BN_THUOC.NgayDT, objNTP_BN_THUOC.ID_PhacdoDT, objNTP_BN_THUOC.PhacDoKhac, objNTP_BN_THUOC.GiaidoanDT, objNTP_BN_THUOC.Tungay, objNTP_BN_THUOC.RHZE, objNTP_BN_THUOC.RHZ, objNTP_BN_THUOC.RHE, objNTP_BN_THUOC.RH, objNTP_BN_THUOC.EH, objNTP_BN_THUOC.E, objNTP_BN_THUOC.H, objNTP_BN_THUOC.Z, objNTP_BN_THUOC.S, objNTP_BN_THUOC.TLaoKhac, objNTP_BN_THUOC.Cotrimoxazole, objNTP_BN_THUOC.ART, objNTP_BN_THUOC.Khac, objNTP_BN_THUOC.NGAY_NM, objNTP_BN_THUOC.NGUOI_NM)

        End Sub

        Public Sub Delete(ByVal iD_Thuoc As Integer)

            DataProvider.Instance().DeleteNTP_BN_THUOC(iD_Thuoc)

        End Sub
#End Region



    End Class
End Namespace
