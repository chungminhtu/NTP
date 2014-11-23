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
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Namespace DotNetNuke.Modules.Chat

    Public Enum ChatMessageType
        Normal = 0
        Whipser
    End Enum

    <Serializable(), XmlRootAttribute("DnnChatMessage")> _
<DefaultProperty("MessageText")> _
    Public Class DnnChatMessage

#Region " Enums "
#End Region

#Region " variables "
        Private _ID As Long = 0
        Private _DateTime As Date = Date.Now
        Private _Content As String = String.Empty
        Private _ModifiedContent As String = String.Empty
        Private _SenderName As String = String.Empty
        Private _messageType As ChatMessageType = ChatMessageType.Normal
        Private _imageDirectoryRoot As String = String.Empty
        Private _allowFormatting As Boolean = False
#End Region

#Region " Public properties "
        <System.Xml.Serialization.XmlAttribute("ID")> _
         Public Property ID() As Long
            Get
                Return _ID
            End Get
            Set(ByVal value As Long)
                _ID = value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttribute("DT")> _
        Public Property DateTime() As Date
            Get
                Return _DateTime
            End Get
            Set(ByVal value As DateTime)
                _DateTime = value
            End Set
        End Property

        <System.Xml.Serialization.XmlIgnore()> _
        Public Property Content() As String
            Get
                Return _Content
            End Get
            Set(ByVal value As String)
                _Content = Modify(value)
            End Set
        End Property

        <System.Xml.Serialization.XmlIgnore()> _
Public Property ImageDirectoryRoot() As String
            Get
                Return _imageDirectoryRoot
            End Get
            Set(ByVal value As String)
                _imageDirectoryRoot = value
            End Set
        End Property
        <System.Xml.Serialization.XmlIgnore()> _
Public Property AllowFormatting() As Boolean
            Get
                Return _allowFormatting
            End Get
            Set(ByVal value As Boolean)
                _allowFormatting = value
            End Set
        End Property
        <System.Xml.Serialization.XmlIgnore()> _
        Public Property ModifiedContent() As String
            Get
                Return _ModifiedContent
            End Get
            Set(ByVal value As String)
                _ModifiedContent = Modify(value)
            End Set
        End Property
        <System.Xml.Serialization.XmlAttribute("CONTENTCDATA")> _
        Public Property ContentCDATA() As String
            Get
                'Return (New XmlDocument).CreateCDataSection(Content).OuterXml
                'Return System.Web.HttpUtility.HtmlDecode(Content)
                Return Content
            End Get
            Set(ByVal value As String)
                _Content = Modify(value)
            End Set
        End Property

        <System.Xml.Serialization.XmlAttribute("SN")> _
        Public Property SenderName() As String
            Get
                Return _SenderName
            End Get
            Set(ByVal value As String)
                _SenderName = value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttribute("MT")> _
        Public Property MessageType() As Integer
            Get
                Return _messageType
            End Get
            Set(ByVal value As Integer)
                _messageType = value
            End Set
        End Property
#End Region

#Region " Constructors "
        Public Sub New(ByVal iD As Long, ByVal dateTime As Date, ByVal content As String, ByVal senderName As String)
            Me.ID = iD
            Me.DateTime = dateTime
            Me.Content = content
            Me.SenderName = senderName
        End Sub
        Public Sub New(ByVal msgCompact As DnnChatMessageCompact, ByVal pImageDirectoryRoot As String, ByVal pAllowFormatting As Boolean)
            'Me.DateTime = Now
            'First filling the imageroot property, because this property is used in the folowing statements
            Me.ImageDirectoryRoot = pImageDirectoryRoot

            Me.AllowFormatting = pAllowFormatting

            Me.MessageType = msgCompact.MessageType
            Me.ContentCDATA = msgCompact.ContentCDATA
        End Sub
        Public Sub New()

        End Sub

#End Region

        'Massage the message cosmetically

        Private Function Modify(ByVal content As String) As String
            Dim retVal As String = String.Empty

            retVal = DnnChatCodeHelper.RemoveShadyHtmlTags(content)
            If Me.AllowFormatting Then retVal = DnnChatCodeHelper.ParseBBCodeToHtmlTags(retVal, Me.ImageDirectoryRoot)

            Return retVal
        End Function
    End Class
    <Serializable(), XmlRootAttribute("DnnChatMessage")> _
<DefaultProperty("MessageText")> _
    Public Class DnnChatMessageCompact

#Region " variables "
        Private _ContentCDATA As String = String.Empty
        Private _messageType As ChatMessageType = ChatMessageType.Normal
#End Region

#Region " Public properties "
        <System.Xml.Serialization.XmlAttribute("CONTENTCDATA")> _
        Public Property ContentCDATA() As String
            Get
                'Return (New XmlDocument).CreateCDataSection(Content).OuterXml
                'Return System.Web.HttpUtility.HtmlDecode(Content)
                Return _ContentCDATA
            End Get
            Set(ByVal value As String)
                _ContentCDATA = value
            End Set
        End Property
        <System.Xml.Serialization.XmlAttribute("MT")> _
        Public Property MessageType() As Integer
            Get
                Return _messageType
            End Get
            Set(ByVal value As Integer)
                _messageType = value
            End Set
        End Property
#End Region
        Public Sub New()

        End Sub
    End Class

End Namespace