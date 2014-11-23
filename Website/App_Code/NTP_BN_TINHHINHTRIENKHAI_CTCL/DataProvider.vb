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

Namespace YourCompany.Modules.NTP_BN_TINHHINHTRIENKHAI_CTCL

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_BN_TINHHINHTRIENKHAI_CTCL", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region

#Region "Abstract methods"
        Public MustOverride Function GetNTP_BN_TINHHINHTRIENKHAI_CTCLs(ByVal Nam As Integer) As IDataReader
        Public MustOverride Function NTP_BN_TINHHINHTRIENKHAI_CTCL_List() As IDataReader
        Public MustOverride Function GetNTP_BN_TINHHINHTRIENKHAI_CTCL(ByVal ID_TRIENKHAI As Integer) As IDataReader
        Public MustOverride Function AddNTP_BN_TINHHINHTRIENKHAI_CTCL(ByVal Nam As Integer, ByVal MA_TINH As String, ByVal SLHUYEN As Integer, ByVal SLHuyenTK As Integer, ByVal SLXa As Integer, ByVal SLXaTK As Integer, ByVal DansoTinh As Integer, ByVal SodanTK As Integer, ByVal SoDVQL As Integer) As Integer
        Public MustOverride Sub UpdateNTP_BN_TINHHINHTRIENKHAI_CTCL(ByVal ID_TRIENKHAI As Integer, ByVal Nam As Integer, ByVal MA_TINH As String, ByVal SLHUYEN As Integer, ByVal SLHuyenTK As Integer, ByVal SLXa As Integer, ByVal SLXaTK As Integer, ByVal DansoTinh As Integer, ByVal SodanTK As Integer, ByVal SoDVQL As Integer)
        Public MustOverride Sub DeleteNTP_BN_TINHHINHTRIENKHAI_CTCL(ByVal ID_TRIENKHAI As Integer)
        Public MustOverride Function ListBaoCao(ByVal Nam As Integer) As DataSet

#End Region

    End Class

End Namespace