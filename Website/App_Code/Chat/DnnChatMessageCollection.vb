Imports System
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Namespace DotNetNuke.Modules.Chat
    <Serializable(), XmlRootAttribute("MSGS")> _
    Public Class DnnChatMessageCollection
        Inherits CollectionBase

        Private _ModuleID As Integer = 0

        Public Sub New()

        End Sub

        Public Sub New(ByVal moduleID As Integer)
            Me.ModuleID = moduleID
        End Sub

        <System.Xml.Serialization.XmlAttribute("Item")> _
        Default Public Property Item(ByVal index As Integer) As DnnChatMessage
            Get
                Return CType(List(index), DnnChatMessage)
            End Get
            Set(ByVal Value As DnnChatMessage)
                List(index) = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttribute("MID")> _
        Public Property ModuleID() As Integer
            Get
                Return _ModuleID
            End Get
            Set(ByVal Value As Integer)
                _ModuleID = Value
            End Set
        End Property

        Public Function Add(ByVal value As DnnChatMessage) As Integer
            Return List.Add(value)
        End Function

        'Public Function Add(ByVal pXmlizedString As String, ByVal id As Integer, ByVal SenderText As String) As DnnChatMessage
        '    Dim message As DnnChatMessage
        '    Try
        '        'TODO MHO geneuzel met namespaces
        '        '<DnnChatMessage ID="{ID}" DT="{DT}" CONTENTCDATA="{CT}" SN="{SN}" MT="{MT}" />'
        '        '<?xml version="1.0" encoding="utf-8"?><MSG xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" ID="9" DT="2007-03-10T22:45:23.1469264+01:00" CONTENTCDATA="Gentle People, bla bla bla " SN="Weasel" MT="0" />'


        '        message = DeserializeDnnChatmessage(pXmlizedString)
        '        message.ID = id
        '        message.DateTime = Now 'TODO bij het tonen: (New Entities.Users.UserTime).CurrentUserTime

        '        If Entities.Users.UserController.GetCurrentUserInfo.UserID > 0 Then
        '            message.SenderName = Entities.Users.UserController.GetCurrentUserInfo.Username
        '        Else
        '            message.SenderName = "Mr. Doe" '// TODO localize
        '        End If
        '        message.SenderName = String.Format(SenderText, message.SenderName) '// TODO check for valid replacement 

        '        List.Add(message)

        '    Catch ex As Exception
        '        message = Nothing
        '    End Try

        '    Return message

        'End Function

        Public Function IndexOf(ByVal value As DnnChatMessage) As Integer
            Return List.IndexOf(value)
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal value As DnnChatMessage)
            List.Insert(index, value)
        End Sub

        Public Sub Remove(ByVal value As DnnChatMessage)
            List.Remove(value)
        End Sub

        Public Function Contains(ByVal value As DnnChatMessage) As Boolean
            Return List.Contains(value)
        End Function

        'Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal value As [Object])
        'End Sub
        'Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal value As [Object])
        'End Sub
        'Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldValue As [Object], ByVal newValue As [Object])
        '    If Not newValue.GetType().IsSubclassOf(GetType(DnnChatMessage)) Then
        '        Throw New ArgumentException("newValue must derive from type DnnChatMessage.", "newValue")
        '    End If
        'End Sub
        'Protected Overrides Sub OnValidate(ByVal value As [Object])
        'End Sub
        'Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
        'End Sub
        'Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
        'End Sub
        'Protected Overrides Sub OnClearComplete()
        'End Sub

        ' <summary>
        ' To convert a Byte Array of Unicode values (UTF-8 encoded) to a complete String.
        ' </summary>
        ' <param name="characters">Unicode Byte Array to be converted to String</param>
        ' <returns>String converted from Unicode Byte Array</returns>
        Private Function UTF8ByteArrayToString(ByVal characters As Byte()) As String
            Dim encoding As UTF8Encoding = New UTF8Encoding()
            Dim constructedString As String = encoding.GetString(characters)
            Return constructedString
        End Function

        ' <summary>
        ' Converts the String to UTF8 Byte array and is used in De serialization
        ' </summary>
        ' <param name="pXmlString"></param>
        ' <returns></returns>
        Private Shared Function StringToUTF8ByteArray(ByVal pXmlString As String) As Byte()
            Dim encoding As UTF8Encoding = New UTF8Encoding()
            Dim byteArray As Byte() = encoding.GetBytes(pXmlString)
            Return byteArray
        End Function

        ' <summary>
        ' Method to convert this Object to XML string
        ' </summary>
        ' <returns>XML string</returns>
        Public Function Serialize() As String
            Dim _xmlizedString As String = String.Empty

            Try
                Dim _memoryStream As MemoryStream = New MemoryStream()
                Dim _xmlTextWriter As XmlTextWriter = New XmlTextWriter(_memoryStream, Encoding.UTF8)

                'To prevent the writing of the '<?xml version="1.0" encoding="utf-8" ?>' message above the xml 
                _xmlTextWriter.Formatting = Formatting.None
                _xmlTextWriter.WriteRaw("")

                'Create our own namespaces for the output()
                Dim _xmlSerializerNamespaces As XmlSerializerNamespaces = New XmlSerializerNamespaces()

                'Add an empty namespace and empty value
                _xmlSerializerNamespaces.Add("", "")

                'Create the serializer
                Dim _xmlSerializer As XmlSerializer = New XmlSerializer(GetType(DnnChatMessageCollection))

                'Serialize the object with our own namespaces (notice the overload)
                _xmlSerializer.Serialize(_xmlTextWriter, Me, _xmlSerializerNamespaces)

                _memoryStream = CType(_xmlTextWriter.BaseStream, MemoryStream)
                _xmlizedString = UTF8ByteArrayToString(_memoryStream.ToArray())

            Catch ex As Exception
                _xmlizedString = String.Empty
            End Try

            ' SKA: Blast, can't get the ModuleID to be an attriute in the root node
            '      Let's just fix that the filthy way:
            _xmlizedString = _xmlizedString.Replace("<MSGS>", String.Format("<MSGS MID=""{0}"">", Me.ModuleID))

            Return _xmlizedString
        End Function

        Public Shared Function DeserializeDnnChatmessage(ByVal pXmlizedString As String, ByVal pImageDirectoryRoot As String, ByVal pAllowFormatting As Boolean) As DnnChatMessage

            'Create our own namespaces for the output()
            Dim _xmlSerializerNamespaces As XmlSerializerNamespaces = New XmlSerializerNamespaces()

            'Add an empty namespace and empty value
            _xmlSerializerNamespaces.Add("", "")

            'TODO TESTMODE
            'Dim cm As New DnnChatMessage(2, Date.Now, "banaan!!!!!!!", "Harry")
            'pXmlizedString = Me.SerializeDnnChatmessage(cm)

            Dim xs As XmlSerializer = New XmlSerializer(GetType(DnnChatMessageCompact), "")
            Dim ms As MemoryStream = New MemoryStream(StringToUTF8ByteArray(pXmlizedString))
            Dim xt As XmlTextWriter = New XmlTextWriter(ms, Encoding.UTF8)

            Return New DnnChatMessage(CType(xs.Deserialize(ms), DnnChatMessageCompact), pImageDirectoryRoot, pAllowFormatting)
        End Function

        Public Function SerializeDnnChatmessage(ByVal pObject As DnnChatMessage) As String
            Dim XmlizedString As String = String.Empty

            Try
                'Create our own namespaces for the output()
                Dim _xmlSerializerNamespaces As XmlSerializerNamespaces = New XmlSerializerNamespaces()

                'Add an empty namespace and empty value
                _xmlSerializerNamespaces.Add("", "")

                Dim ms As MemoryStream = New MemoryStream
                Dim xs As XmlSerializer = New XmlSerializer(GetType(DnnChatMessage), "")
                Dim xt As XmlTextWriter = New XmlTextWriter(ms, Encoding.UTF8)

                'To prevent the writing of the '<?xml version="1.0" encoding="utf-8" ?>' message above the xml 
                xt.Formatting = Formatting.None
                xt.WriteRaw("")

                xs.Serialize(xt, pObject, _xmlSerializerNamespaces)
                ms = CType(xt.BaseStream, MemoryStream)
                XmlizedString = UTF8ByteArrayToString(ms.ToArray())

            Catch ex As Exception
                XmlizedString = String.Empty
            End Try
            Return XmlizedString
        End Function
    End Class

End Namespace
