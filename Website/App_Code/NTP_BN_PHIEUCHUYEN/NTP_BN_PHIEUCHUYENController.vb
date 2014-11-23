
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

Namespace YourCompany.Modules.NTP_BN_PHIEUCHUYEN

    ''' <summary>
    ''' The Controller class for NTP_BN_PHIEUCHUYEN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_PHIEUCHUYENController

#Region "Public Methods"
        Public Function [Get](ByVal iD_Phieuchuyen As Integer) As NTP_BN_PHIEUCHUYENInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_PHIEUCHUYEN(iD_Phieuchuyen), GetType(NTP_BN_PHIEUCHUYENInfo)), NTP_BN_PHIEUCHUYENInfo)

        End Function
        'Public Function GetBenhNhan(ByVal iD_Phieuchuyen As Integer) As NTP_BN_PHIEUCHUYENBENHNHANInfo

        '    Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_PHIEUCHUYENBENHNHAN(iD_Phieuchuyen), GetType(NTP_BN_PHIEUCHUYENBENHNHANInfo)), NTP_BN_PHIEUCHUYENBENHNHANInfo)

        'End Function


        Public Function GetNTP_BN_PHIEUCHUYENByID_Dieutri(ByVal ID_Dieutri As Integer) As NTP_BN_PHIEUCHUYENInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_PHIEUCHUYENByID_Dieutri(ID_Dieutri), GetType(NTP_BN_PHIEUCHUYENInfo)), NTP_BN_PHIEUCHUYENInfo)

        End Function
        Public Function List() As List(Of NTP_BN_PHIEUCHUYENInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUCHUYENInfo)(DataProvider.Instance().ListNTP_BN_PHIEUCHUYEN())

        End Function

        Public Function ListbyNTP_BN_DIEUTRI(ByVal Ravien As Integer, ByVal ID_BENHVIEN As String) As List(Of NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENBENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENBENHNHANInfo)(DataProvider.Instance().ListbyNTP_BN_DIEUTRI(Ravien, ID_BENHVIEN))

        End Function
        Public Function ListByDVTiepNhan(ByVal DVTiepNhan As String) As List(Of NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENBENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENBENHNHANInfo)(DataProvider.Instance().ListByDVTiepNhan(DVTiepNhan))

        End Function
        Public Function ListByDVTNam(ByVal DVTiepNhan As String, ByVal Nam As Integer) As List(Of NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENBENHNHANInfo)

            Return CBO.FillCollection(Of NTP_BN_PHIEUCHUYEN.NTP_BN_PHIEUCHUYENBENHNHANInfo)(DataProvider.Instance().ListByDVNam(DVTiepNhan, Nam))

        End Function

        Public Function AddNTP_BN_PHIEUCHUYEN(ByVal objNTP_BN_PHIEUCHUYEN As NTP_BN_PHIEUCHUYENInfo) As String

            Return CType(DataProvider.Instance().AddNTP_BN_PHIEUCHUYEN(objNTP_BN_PHIEUCHUYEN.ID_Dieutri, objNTP_BN_PHIEUCHUYEN.PhanLoai, objNTP_BN_PHIEUCHUYEN.DVChuyen, objNTP_BN_PHIEUCHUYEN.DVTiepnhan, objNTP_BN_PHIEUCHUYEN.TinhTrangBN, objNTP_BN_PHIEUCHUYEN.Lydo, objNTP_BN_PHIEUCHUYEN.NgayChuyen, objNTP_BN_PHIEUCHUYEN.SoDKDT, objNTP_BN_PHIEUCHUYEN.Tiepnhan, objNTP_BN_PHIEUCHUYEN.NGUOI_NM), String)

        End Function

        Public Sub Update(ByVal objNTP_BN_PHIEUCHUYEN As NTP_BN_PHIEUCHUYENInfo)

            DataProvider.Instance().UpdateNTP_BN_PHIEUCHUYEN(objNTP_BN_PHIEUCHUYEN.ID_Phieuchuyen, objNTP_BN_PHIEUCHUYEN.ID_Dieutri, objNTP_BN_PHIEUCHUYEN.PhanLoai, objNTP_BN_PHIEUCHUYEN.DVChuyen, objNTP_BN_PHIEUCHUYEN.DVTiepnhan, objNTP_BN_PHIEUCHUYEN.TinhTrangBN, objNTP_BN_PHIEUCHUYEN.Lydo, objNTP_BN_PHIEUCHUYEN.NgayChuyen, objNTP_BN_PHIEUCHUYEN.SoDKDT, objNTP_BN_PHIEUCHUYEN.Tiepnhan, objNTP_BN_PHIEUCHUYEN.NGAY_NM, objNTP_BN_PHIEUCHUYEN.NGUOI_NM)

        End Sub
     

        Public Sub Delete(ByVal iD_Phieuchuyen As Integer)

            DataProvider.Instance().DeleteNTP_BN_PHIEUCHUYEN(iD_Phieuchuyen)

        End Sub
#End Region

    End Class
End Namespace
