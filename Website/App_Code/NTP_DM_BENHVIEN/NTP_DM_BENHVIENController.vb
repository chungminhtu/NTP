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

Namespace YourCompany.Modules.NTP_DM_BENHVIEN

    ''' <summary>
    ''' The Controller class for NTP_DM_BENHVIEN
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_DM_BENHVIENController
      

#Region "Public Methods"
        Public Function [Get](ByVal iD_BENHVIEN As String) As NTP_DM_BENHVIENInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_DM_BENHVIEN(iD_BENHVIEN), GetType(NTP_DM_BENHVIENInfo)), NTP_DM_BENHVIENInfo)

        End Function

        Public Function List() As List(Of NTP_DM_BENHVIENInfo)

            Return CBO.FillCollection(Of NTP_DM_BENHVIENInfo)(DataProvider.Instance().ListNTP_DM_BENHVIEN())

        End Function

        Public Function GetByNTP_DM_VUNG(ByVal iD_VUNG As Integer) As ArrayList

            Return CBO.FillCollection(DataProvider.Instance().GetNTP_DM_BENHVIENByNTP_DM_VUNG(iD_VUNG), GetType(NTP_DM_BENHVIENInfo))

        End Function
        Public Function GetByBenVien(ByVal Id_BenhVien As String, ByVal Id_tinh As String) As ArrayList

            Return CBO.FillCollection(DataProvider.Instance().GetNTP_DM_BENHVIENByBenhVien(Id_BenhVien, Id_tinh), GetType(NTP_DM_BENHVIENInfo))

        End Function

        Public Function Add(ByVal objNTP_DM_BENHVIEN As NTP_DM_BENHVIENInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_DM_BENHVIEN(objNTP_DM_BENHVIEN.TEN_BENHVIEN, objNTP_DM_BENHVIEN.ID_Phanloaiyte, objNTP_DM_BENHVIEN.ID_MATINH, objNTP_DM_BENHVIEN.ID_HUYEN, objNTP_DM_BENHVIEN.CAPQUANLY, objNTP_DM_BENHVIEN.ID_VUNG), Integer)

        End Function

        Public Sub Update(ByVal objNTP_DM_BENHVIEN As NTP_DM_BENHVIENInfo)

            DataProvider.Instance().UpdateNTP_DM_BENHVIEN(objNTP_DM_BENHVIEN.ID_BENHVIEN, objNTP_DM_BENHVIEN.TEN_BENHVIEN, objNTP_DM_BENHVIEN.ID_Phanloaiyte, objNTP_DM_BENHVIEN.ID_MATINH, objNTP_DM_BENHVIEN.ID_HUYEN, objNTP_DM_BENHVIEN.CAPQUANLY, objNTP_DM_BENHVIEN.ID_VUNG)

        End Sub

        Public Sub Delete(ByVal iD_BENHVIEN As String)

            DataProvider.Instance().DeleteNTP_DM_BENHVIEN(iD_BENHVIEN)

        End Sub
#End Region



    End Class
End Namespace
