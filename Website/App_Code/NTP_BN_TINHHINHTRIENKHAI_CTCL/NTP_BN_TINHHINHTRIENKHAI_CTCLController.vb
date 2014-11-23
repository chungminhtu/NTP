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

Namespace YourCompany.Modules.NTP_BN_TINHHINHTRIENKHAI_CTCL

    ''' <summary>
    ''' The Controller class for NTP_BN_TINHHINHTRIENKHAI_CTCL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_TINHHINHTRIENKHAI_CTCLController
      
#Region "Public Methods"

        Public Function NTP_BN_TINHHINHTRIENKHAI_CTCL_List() As List(Of NTP_BN_TINHHINHTRIENKHAI_CTCLInfo)
            Return CBO.FillCollection(Of NTP_BN_TINHHINHTRIENKHAI_CTCLInfo)(DataProvider.Instance().NTP_BN_TINHHINHTRIENKHAI_CTCL_List)
        End Function
        Public Function [Get](ByVal Nam As Integer) As List(Of NTP_BN_TINHHINHTRIENKHAI_CTCLInfo)
            Return CBO.FillCollection(Of NTP_BN_TINHHINHTRIENKHAI_CTCLInfo)(DataProvider.Instance().GetNTP_BN_TINHHINHTRIENKHAI_CTCLs(Nam))

        End Function

        Public Function [List](ByVal ID_TRIENKHAI As Integer) As NTP_BN_TINHHINHTRIENKHAI_CTCLInfo
            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_TINHHINHTRIENKHAI_CTCL(ID_TRIENKHAI), GetType(NTP_BN_TINHHINHTRIENKHAI_CTCLInfo)), NTP_BN_TINHHINHTRIENKHAI_CTCLInfo)

        End Function

        Public Function AddNTP_BN_TINHHINHTRIENKHAI_CTCL(ByVal objNTP_BN_TINHHINHTRIENKHAI_CTCL As NTP_BN_TINHHINHTRIENKHAI_CTCLInfo) As Integer
            Return CType(DataProvider.Instance().AddNTP_BN_TINHHINHTRIENKHAI_CTCL(objNTP_BN_TINHHINHTRIENKHAI_CTCL.Nam, objNTP_BN_TINHHINHTRIENKHAI_CTCL.MA_TINH, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLHuyen, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLHuyenTK, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLXa, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLXaTK, objNTP_BN_TINHHINHTRIENKHAI_CTCL.DansoTinh, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SodanTK, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SoDVQL), Integer)

        End Function
        Public Sub UpdateNTP_BN_TINHHINHTRIENKHAI_CTCL(ByVal objNTP_BN_TINHHINHTRIENKHAI_CTCL As NTP_BN_TINHHINHTRIENKHAI_CTCLInfo)

            DataProvider.Instance().UpdateNTP_BN_TINHHINHTRIENKHAI_CTCL(objNTP_BN_TINHHINHTRIENKHAI_CTCL.ID_TRIENKHAI, objNTP_BN_TINHHINHTRIENKHAI_CTCL.Nam, objNTP_BN_TINHHINHTRIENKHAI_CTCL.MA_TINH, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLHuyen, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLHuyenTK, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLXa, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SLXaTK, objNTP_BN_TINHHINHTRIENKHAI_CTCL.DansoTinh, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SodanTK, objNTP_BN_TINHHINHTRIENKHAI_CTCL.SoDVQL)

        End Sub

        Public Sub DeleteNTP_BN_TINHHINHTRIENKHAI_CTCL(ByVal ID_TRIENKHAI As Integer)

            DataProvider.Instance().DeleteNTP_BN_TINHHINHTRIENKHAI_CTCL(ID_TRIENKHAI)

        End Sub
        Public Function ListBaoCao(ByVal Nam As Integer) As DataSet
            Return DataProvider.Instance().ListBaoCao(Nam)
        End Function

#End Region

#Region "Optional Interfaces"


#End Region

    End Class
End Namespace
