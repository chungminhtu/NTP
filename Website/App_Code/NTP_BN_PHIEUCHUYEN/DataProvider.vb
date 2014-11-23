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
Imports DotNetNuke

Namespace YourCompany.Modules.NTP_BN_PHIEUCHUYEN

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' An abstract class for the data access layer
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

        ' singleton reference to the instantiated object 
        Private Shared objProvider As DataProvider = Nothing

        ' constructor
        Shared Sub New()
            CreateProvider()
        End Sub

        ' dynamically create provider
        Private Shared Sub CreateProvider()
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_PHIEUCHUYEN", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region

#Region "NTP_BN_PHIEUCHUYEN Methods"
        Public MustOverride Function GetNTP_BN_PHIEUCHUYEN(ByVal iD_Phieuchuyen As Integer) As IDataReader
        ' Public MustOverride Function GetNTP_BN_PHIEUCHUYENBENHNHAN(ByVal iD_Phieuchuyen As Integer) As IDataReader
        Public MustOverride Function GetNTP_BN_PHIEUCHUYENByID_Dieutri(ByVal ID_Dieutri As Integer) As IDataReader
        Public MustOverride Function ListNTP_BN_PHIEUCHUYEN() As IDataReader
        Public MustOverride Function ListbyNTP_BN_DIEUTRI(ByVal Ravien As Integer, ByVal ID_BENHVIEN As String) As IDataReader
        Public MustOverride Function ListByDVTiepNhan(ByVal DVTiepNhan As String) As IDataReader
        Public MustOverride Function ListByDVNam(ByVal DVTiepNhan As String, ByVal nam As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_PHIEUCHUYEN(ByVal iD_Dieutri As Integer, ByVal phanLoai As Boolean, ByVal dVChuyen As String, ByVal dVTiepnhan As String, ByVal tinhTrangBN As String, ByVal lydo As String, ByVal ngayChuyen As DateTime, ByVal soDKDT As String, ByVal tiepnhan As Byte, ByVal nGUOI_NM As Integer) As String
        Public MustOverride Sub UpdateNTP_BN_PHIEUCHUYEN(ByVal iD_Phieuchuyen As Integer, ByVal iD_Dieutri As Integer, ByVal phanLoai As Boolean, ByVal dVChuyen As String, ByVal dVTiepnhan As String, ByVal tinhTrangBN As String, ByVal lydo As String, ByVal ngayChuyen As DateTime, ByVal soDKDT As String, ByVal tiepnhan As Byte, ByVal nGAY_NM As DateTime, ByVal nGUOI_NM As Integer)
        Public MustOverride Sub DeleteNTP_BN_PHIEUCHUYEN(ByVal iD_Phieuchuyen As Integer)
#End Region


    End Class

End Namespace