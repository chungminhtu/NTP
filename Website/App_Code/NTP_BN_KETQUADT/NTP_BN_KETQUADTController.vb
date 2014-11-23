'
' DotNetNuke� - http://www.dotnetnuke.com
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

Namespace YourCompany.Modules.NTP_BN_KETQUADT

    ''' <summary>
    ''' The Controller class for NTP_BN_KETQUADT
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_KETQUADTController
       

#Region "Public Methods"

      
        Public Function [Get](ByVal ID_Dieutri As Integer) As NTP_BN_KETQUADTInfo
            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_KETQUADT(iD_Dieutri), GetType(NTP_BN_KETQUADTInfo)), NTP_BN_KETQUADTInfo)

        End Function

        Public Function ListNTP_BN_DMBENHVIENCHUYEN(ByVal ID_BENHVIEN As String) As List(Of NTP_BN_KETQUADTInfo)

            Return CBO.FillCollection(Of NTP_BN_KETQUADT.NTP_BN_KETQUADTInfo)(DataProvider.Instance().ListNTP_BN_DMBENHVIENCHUYEN(ID_BENHVIEN))
        End Function
        Public Sub UpdateNTP_BN_KETQUADT(ByVal objNTP_BN_KETQUADT As NTP_BN_KETQUADTInfo)
            DataProvider.Instance().UpdateNTP_BN_KETQUADT(objNTP_BN_KETQUADT.ID_Dieutri, objNTP_BN_KETQUADT.KetquaDT, objNTP_BN_KETQUADT.NgayRV, objNTP_BN_KETQUADT.Ghichu)

        End Sub


       

#End Region

#Region "Optional Interfaces"

      

#End Region

    End Class
End Namespace