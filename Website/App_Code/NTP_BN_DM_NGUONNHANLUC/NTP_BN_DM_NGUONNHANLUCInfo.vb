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

Namespace YourCompany.Modules.NTP_BN_DM_NGUONNHANLUC

    ''' <summary>
    ''' The Info class for NTP_BN_DM_NGUONNHANLUC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class NTP_BN_DM_NguonNhanLucInfo
#Region "Private Members"
        Dim _iD_NguonNhanLuc As Integer
        Dim _ten_NguonNhanLuc As String
        Dim _phanLoai As Integer
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal iD_NguonNhanLuc As Integer, ByVal ten_NguonNhanLuc As String)
            Me.ID_NguonNhanLuc = ID_NguonNhanLuc
            Me.Ten_NguonNhanLuc = ten_NguonNhanLuc

        End Sub
#End Region

#Region "Public Properties"
        Public Property ID_NguonNhanLuc() As Integer
            Get
                Return _iD_NguonNhanLuc
            End Get
            Set(ByVal Value As Integer)
                _iD_NguonNhanLuc = Value
            End Set
        End Property

        Public Property Ten_NguonNhanLuc() As String
            Get
                Return _ten_NguonNhanLuc
            End Get
            Set(ByVal Value As String)
                _ten_NguonNhanLuc = Value
            End Set
        End Property
        Public Property PhanLoai() As Integer
            Get
                Return _phanLoai
            End Get
            Set(ByVal Value As Integer)
                _phanLoai = Value
            End Set
        End Property
#End Region

    End Class

End Namespace
