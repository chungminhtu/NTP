'
' DotNetNukeŽ - http://www.dotnetnuke.com
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

Namespace YourCompany.Modules.NTP_BN_DM_PHANLOAIYTE

    ''' <summary>
    ''' The Controller class for NTP_BN_DM_PHANLOAIYTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_DM_PHANLOAIYTEController


#Region "Public Methods"
        Public Function [Get](ByVal iD_PHANLOAIYTE As Integer) As NTP_BN_DM_PHANLOAIYTEInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetNTP_BN_DM_PHANLOAIYTE(iD_PHANLOAIYTE), GetType(NTP_BN_DM_PHANLOAIYTEInfo)), NTP_BN_DM_PHANLOAIYTEInfo)

        End Function

        Public Function List() As List(Of NTP_BN_DM_PHANLOAIYTEInfo)

            Return CBO.FillCollection(Of NTP_BN_DM_PHANLOAIYTEInfo)(DataProvider.Instance().ListNTP_BN_DM_PHANLOAIYTE())

        End Function

        Public Function ListBC() As List(Of NTP_BN_DM_PHANLOAIYTEInfo)

            Return CBO.FillCollection(Of NTP_BN_DM_PHANLOAIYTEInfo)(DataProvider.Instance().ListBCNTP_BN_DM_PHANLOAIYTE())

        End Function

        Public Function Add(ByVal objNTP_BN_DM_PHANLOAIYTE As NTP_BN_DM_PHANLOAIYTEInfo) As Integer

            Return CType(DataProvider.Instance().AddNTP_BN_DM_PHANLOAIYTE(objNTP_BN_DM_PHANLOAIYTE.Ten_PHANLOAIYTE), Integer)

        End Function

        Public Sub Update(ByVal objNTP_BN_DM_PHANLOAIYTE As NTP_BN_DM_PHANLOAIYTEInfo)

            DataProvider.Instance().UpdateNTP_BN_DM_PHANLOAIYTE(objNTP_BN_DM_PHANLOAIYTE.ID_PHANLOAIYTE, objNTP_BN_DM_PHANLOAIYTE.Ten_PHANLOAIYTE)

        End Sub

        Public Sub Delete(ByVal iD_PHANLOAIYTE As Integer)

            DataProvider.Instance().DeleteNTP_BN_DM_PHANLOAIYTE(iD_PHANLOAIYTE)

        End Sub
#End Region




    End Class
End Namespace
