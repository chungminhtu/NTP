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
Imports System.ComponentModel
Imports System.Text
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls

Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.UI.Utilities

Namespace DotNetNuke.Modules.Chat
    Public Enum MessageType
        UNDEFINED = 0
        ENTER = 1
        LEAVE = 2
        CHAT = 3
        POLL = 4
    End Enum

    <DefaultProperty("Text"), ToolboxData("<{0}:DnnChat runat=server></{0}:DnnChat>")> _
    Public Class DnnChat
        Inherits WebControl
        Implements INamingContainer, DotNetNuke.UI.Utilities.IClientAPICallbackEventHandler 'System.Web.UI.ICallbackEventHandler, 

        'private variables
        Private _Messages As DnnChatMessageCollection
        Private _pnlMessages As Panel = New Panel
        Private _pnlChat As Panel = New Panel
        Private _txt As TextBox = New TextBox
        Const _txtBoxHeight As Integer = 15

        'constructor
        Public Sub New()
            'set default size
            MyBase.Width = New Unit(350, UnitType.Pixel)
            MyBase.Height = New Unit(200, UnitType.Pixel)

        End Sub

#Region " Public Properties "

        ''' <summary>
        ''' The number of chat messages will be cached in application state
        ''' </summary>
        ''' <remarks></remarks>
        Private ReadOnly Property HistoryCapacity() As Integer
            Get
                Return GetSetting(Of Integer)("dnnChat_History", 50)
            End Get
        End Property

        ''' <summary>
        ''' The number of chat messages will be cached in application state
        ''' </summary>
        ''' <remarks></remarks>
        Private ReadOnly Property DisplayCapacity() As Integer
            Get
                Return GetSetting(Of Integer)("dnnChat_DisplayCapacity", 10)
            End Get
        End Property

        ''' <summary>
        ''' The number of seconds between chat update requests
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property PollingInterval() As Integer
            Get
                Return GetSetting(Of Integer)("dnnChat_PollingInterval", 2000)
            End Get
        End Property

        ''' <summary>
        ''' The style of the message display area
        ''' </summary>
        ''' <remarks></remarks>
        Private _MessageAreaStyle As Style
        <Bindable(False), Category("Appearance"), Description("Sets or gets the style of the message display area"), _
        PersistenceMode(PersistenceMode.InnerProperty)> Public Property MessageAreaStyle() As Style
            Get
                Return _MessageAreaStyle
            End Get
            Set(ByVal value As Style)
                _MessageAreaStyle = value
            End Set
        End Property

        ''' <summary>
        ''' The style of the send message area
        ''' </summary>
        ''' <remarks></remarks>
        Private _SendAreaStyle As Style
        <Bindable(False), Category("Appearance"), Description("Sets or gets the style of the send message area"), PersistenceMode(PersistenceMode.InnerProperty)> _
        Public Property SendAreaStyle() As Style
            Get
                Return _SendAreaStyle
            End Get
            Set(ByVal value As Style)
                _SendAreaStyle = value
            End Set
        End Property

        ''' <summary>
        ''' The css class to apply to the sender of each message
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property SenderCssClass() As String
            Get
                Return GetSetting(Of String)("dnnChat_SenderCssClass", "NormalBold")
            End Get
        End Property

        ''' <summary>
        ''' The css class to apply to the body of each message
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property MessageCssClass() As String
            Get
                Return GetSetting(Of String)("dnnChat_MessageCssClass", "Normal")
            End Get
        End Property

        Public ReadOnly Property ExitedMessage() As String
            Get
                Return GetSetting(Of String)("dnnChat_ExitedMessage", "NormalRed")
            End Get
        End Property

        ''' <summary>
        ''' Sets or gets the message that is displayed when a user enters
        ''' </summary>
        Public ReadOnly Property EnteredMessage() As String
            Get
                Return GetSetting(Of String)("dnnChat_EnteredMessage", "NormalRed")
            End Get
        End Property
        ''' <summary>
        ''' Sets or gets the message that is displayed when a user enters
        ''' </summary>
        Public ReadOnly Property SenderText() As String
            Get
                Return GetSetting(Of String)("dnnChat_SenderText", Localization.GetString("SenderTextDefault.Text", ParentModule.LocalResourceFile))
            End Get
        End Property

        Public ReadOnly Property AllowFormatting() As Boolean
            Get
                Return GetSetting(Of Boolean)("dnnChat_AllowFormatting", True)
            End Get
        End Property
#End Region

#Region " Private Properties "
        Private _rootImageUrl As String = String.Empty
        Private ReadOnly Property ChatRootImageUrl() As String
            Get
                If _rootImageUrl.Length = 0 Then
                    _rootImageUrl = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + Me.ParentModule.TemplateSourceDirectory + "/Images/"
                End If
                Return _rootImageUrl
            End Get
        End Property

        Private _ParentModule As PortalModuleBase
        Private ReadOnly Property ParentModule() As PortalModuleBase
            Get
                If _ParentModule Is Nothing Then
                    Dim CurrentControl As Control = Me
                    While CurrentControl IsNot Nothing AndAlso Not CurrentControl.Parent.Equals(CurrentControl)
                        If TypeOf CurrentControl Is PortalModuleBase Then
                            _ParentModule = CurrentControl
                            Exit While
                        Else
                            CurrentControl = CurrentControl.Parent
                        End If
                    End While
                End If
                Return _ParentModule
            End Get
        End Property
        Private ReadOnly Property DnnChatSessionMessagesKey() As String
            Get
                Return String.Format("DnnChatSessionMessages_{0}", Me.ParentModule.ModuleId())
            End Get
        End Property
        Private ReadOnly Property DnnChatSessionMessageCountKey() As String
            Get
                Return String.Format("DnnChatSessionMessageCount_{0}_{1}", Me.ParentModule.ModuleId(), "MessageCount")
            End Get
        End Property
        Private Property DnnChatSessionMessages() As DnnChatMessageCollection
            Get
                Dim retval As DnnChatMessageCollection
                retval = DataCache.GetCache(DnnChatSessionMessagesKey)
                If retval Is Nothing Then
                    retval = New DnnChatMessageCollection
                    Me.DnnChatSessionMessages = retval
                End If

                Return retval
            End Get
            Set(ByVal value As DnnChatMessageCollection)
                DataCache.SetCache(DnnChatSessionMessagesKey, value)
                'Web.HttpContext.Current.Cache.Insert(WebChatTopicMessagesKey, value)
            End Set
        End Property
        Private Property DnnChatSessionLastMessageID() As Long
            Get
                Return DataCache.GetCache(DnnChatSessionMessageCountKey)
            End Get
            Set(ByVal value As Long)
                DataCache.SetCache(DnnChatSessionMessageCountKey, value)
            End Set
        End Property
        Private ReadOnly Property DnnChatUsersCacheKey() As String
            Get
                Return String.Format("DnnChatUsers_{0}", ParentModule.ModuleId)
            End Get
        End Property
        Private _dnnChatUsers As Generic.Dictionary(Of Guid, DnnChatUser) = Nothing
        Private Property DnnChatUsers() As Generic.Dictionary(Of Guid, DnnChatUser)
            Get
                'Get from Cache only once per request
                If _dnnChatUsers Is Nothing Then
                    _dnnChatUsers = CType(DataCache.GetCache(DnnChatUsersCacheKey), Generic.Dictionary(Of Guid, DnnChatUser))
                End If
                'If it's still nothing we need to put a new one into cache
                If _dnnChatUsers Is Nothing Then
                    _dnnChatUsers = New Generic.Dictionary(Of Guid, DnnChatUser)
                    DataCache.SetCache(DnnChatUsersCacheKey, _dnnChatUsers)
                End If

                Return _dnnChatUsers
            End Get
            Set(ByVal value As Generic.Dictionary(Of Guid, DnnChatUser))
                DataCache.SetCache(DnnChatUsersCacheKey, value)
            End Set
        End Property
#End Region

#Region " HTML Rendering "
        Protected Overrides Sub RenderContents(ByVal output As HtmlTextWriter)

            Dim lvstrPrefix As String = String.Format("{0}_{1}_", Me.ID, ParentModule.ModuleId)
            Dim lvstrChatwindowPanelId As String = String.Format("{0}{1}", lvstrPrefix, "pnl")
            Dim lvstrChatwindowButtonId As String = String.Format("{0}{1}", lvstrPrefix, "btn")
            Dim lvstrChatwindowTextboxId As String = String.Format("{0}{1}", lvstrPrefix, "txt")

            Dim lvblnIsAllowedToChat As Boolean = Security.HasPermission(Security.GetPermissions(Me.ParentModule.ModuleId, Me.ParentModule.TabId), Security.Permissions.ChatPermission)


            'The context is used for passing through the name of the chatwindow
            Dim strContext As String = String.Format("document.getElementById('{0}')", lvstrChatwindowPanelId)
            Dim strCallback As String = DotNetNuke.UI.Utilities.ClientAPI.GetCallbackEventReference(Me, String.Format("getChatMessageXML({0})", lvstrChatwindowTextboxId), "receiveChatMessage", strContext, "receiveChatMessageError") ' String.Format("sendChatMessage(document.getElementById('{0}'));", _txt.ID)

            'create the containing panel
            'this panel conatins the panel with the messages and a table for the user input controls
            _pnlChat.Height = Me.Height
            _pnlChat.Width = Me.Width
            'create the message display panel
            _pnlMessages.ID = lvstrChatwindowPanelId
            _pnlMessages.Height = New Unit(_pnlChat.Height.Value - ((New DnnChatFormattingToolbar).HeightInPixels) - _txtBoxHeight, UnitType.Pixel)
            '_pnlMessages.BorderStyle = WebControls.BorderStyle.Solid
            _pnlMessages.BorderWidth = New Unit(1, UnitType.Pixel)
            _pnlMessages.Style.Add(HtmlTextWriterStyle.Overflow, "scroll")
            _pnlMessages.ControlStyle.MergeWith(Me.MessageAreaStyle)
            _pnlChat.Controls.Add(_pnlMessages)


            'create the button 
            Dim btn As Button = New Button
            btn.ID = lvstrChatwindowButtonId
            btn.UseSubmitBehavior = False
            btn.Text = Localization.GetString("SendButton.Text", ParentModule.LocalResourceFile)
            btn.Enabled = lvblnIsAllowedToChat
            btn.Attributes("onClick") = strCallback

            'create the textbox
            _txt.ID = lvstrChatwindowTextboxId
            _txt.Width = New Unit(99, UnitType.Percentage)
            _txt.Enabled = lvblnIsAllowedToChat
            'This handles the Enter key
            'TODO: Use DotNetNuke.Utilities.ClientAPI
            _txt.Attributes("onkeydown") = "if ((event.keyCode == 13)) {" & strCallback & ";return false;} else return true;"

            'Create the table for the user input controls
            Dim tbl As Table = New Table
            tbl.Height = New Unit((_pnlChat.Height.Value - _pnlMessages.Height.Value), UnitType.Pixel)
            tbl.Width = Me.Width
            tbl.ToolTip = Me.ToolTip

            'create a new table row for textbox & button
            Dim tr As TableRow = New TableRow
            Dim tdTextbox As TableCell = New TableCell
            Dim tdButton As TableCell = New TableCell
            tr.Height = New Unit(_txtBoxHeight, UnitType.Pixel)
            tr.ControlStyle.MergeWith(Me.SendAreaStyle)

            tdTextbox.Width = New Unit(90, UnitType.Percentage)
            tdTextbox.Controls.Add(_txt)
            tr.Cells.Add(tdTextbox)
            tdButton.HorizontalAlign = HorizontalAlign.Right
            tdButton.Controls.Add(btn)
            tr.Cells.Add(tdButton)

            tbl.Rows.Add(tr)


            If Me.AllowFormatting Then msAddFormattingToolbar(tbl, lvstrChatwindowTextboxId, lvblnIsAllowedToChat)

            'Shout around that someone has entered
            strCallback = DotNetNuke.UI.Utilities.ClientAPI.GetCallbackEventReference(Me, _
                                            String.Format("getMessageXML('{0}', MSG_TYPE_ENTER)", getArrivalText(lvblnIsAllowedToChat)), _
                                            "receiveChatMessage", _
                                            strContext, _
                                            "receiveChatMessageError")
            ClientAPI.RegisterStartUpScript(Me.Page, _
                                        "enterChat_" & ParentModule.ModuleId.ToString, _
                                        "<script>" & strCallback & "</script>" _
                                        )

            'Have the thing poll every now and then
            strCallback = DotNetNuke.UI.Utilities.ClientAPI.GetCallbackEventReference(Me, _
                                            "getMessageXML(null, MSG_TYPE_POLL)", _
                                            "receiveChatMessage", _
                                            strContext, _
                                            "receiveChatMessageError")

            'Remove the trailing semicolon
            If strCallback.EndsWith(";") Then strCallback = strCallback.Remove(strCallback.LastIndexOf(";"c))

            'quote it
            strCallback = """" & strCallback & """"


            ClientAPI.RegisterStartUpScript(Me.Page, _
                                        "refreshChat_" & ParentModule.ModuleId.ToString, _
                                        "<script>window.setInterval(" & strCallback & "," & CType(Me.PollingInterval, String) & ");</script>" _
                                        )

            _pnlChat.Controls.Add(tbl)
            _pnlChat.RenderControl(output)

        End Sub
        Private Sub msAddFormattingToolbar(ByRef pTable As Table, ByVal pChatwindowTextboxId As String, ByVal pEnableButtons As Boolean)

            Dim lTableRow As TableRow = New TableRow
            Dim lTableCell As New TableCell
            lTableCell.Attributes("colspan") = "2"
            lTableCell.Controls.Add(New DnnChatFormattingToolbar(pChatwindowTextboxId, ChatRootImageUrl, ParentModule.LocalResourceFile, pEnableButtons))

            lTableRow.Cells.Add(lTableCell)
            lTableRow.Height = New Unit(20, UnitType.Pixel)
            pTable.Rows.Add(lTableRow)

        End Sub
        Private Function getArrivalText(ByVal bIsAllowedToChat As Boolean) As String
            Dim _text As String

            If bIsAllowedToChat Then
                _text = Localization.GetString("UserHasJoined", Me.ParentModule.LocalResourceFile)
            Else
                _text = Localization.GetString("UserIsReading", Me.ParentModule.LocalResourceFile)
            End If

            Return String.Format(_text, GetSenderName)

        End Function

#End Region

        Private Sub DnnChat_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
            Me.Height = Unit.Parse(GetSetting(Of String)("dnnChat_Height", "200px"))
        End Sub

        Private Sub DnnChat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            'Make sure there's an ID created
            Dim dummy As Guid = ChatClientID

            If Me.Visible Then
                Me.EnsureChildControls()
                RegisterJavaScript()
            End If
        End Sub

        Private Sub RegisterJavaScript()
            Dim key As String = "DotNetNuke_Chat"

            If Not Page.ClientScript.IsClientScriptBlockRegistered(key) Then
                Page.ClientScript.RegisterClientScriptInclude(key, IO.Path.Combine(ParentModule.ModulePath, "DnnChat.js"))
            End If

            'TODO somewhere else
            key = "DnnChatBBcode_script"
            If Not Page.ClientScript.IsClientScriptBlockRegistered(key) Then
                Page.ClientScript.RegisterClientScriptInclude(key, IO.Path.Combine(ParentModule.ModulePath, "DnnChatBBcode.js"))
            End If
            'TODO somewhere else


            ClientAPI.RegisterClientReference(Me.Page, ClientAPI.ClientNamespaceReferences.dnn)
            ClientAPI.RegisterClientReference(Me.Page, ClientAPI.ClientNamespaceReferences.dnn_xml)
            ClientAPI.RegisterClientReference(Me.Page, ClientAPI.ClientNamespaceReferences.dnn_xmlhttp)

            Page.ClientScript.RegisterClientScriptBlock(Me.GetType, "DnnChat_Variables_" & Me.ParentModule.ModuleId.ToString, GetScriptVariables, True)

        End Sub

        Private Function GetScriptVariables() As String
            Dim retval As New StringBuilder

            'TODO: make sure the {1} will be replaced with js-safe values
            retval.AppendLine(String.Format("var cssClassSender_{0} = '{1}';", Me.ParentModule.ModuleId, Me.SenderCssClass))
            retval.AppendLine(String.Format("var cssClassMessage_{0} = '{1}';", Me.ParentModule.ModuleId, Me.MessageCssClass))
            retval.AppendLine(String.Format("var DisplayCapacity_{0} = {1};", Me.ParentModule.ModuleId, Me.DisplayCapacity))
            retval.AppendLine(String.Format("var last_previous_{0} = -1;", Me.ParentModule.ModuleId))
            retval.AppendLine(String.Format("var last_current_{0} = -1;", Me.ParentModule.ModuleId))
            retval.AppendLine(String.Format("var max_msgs_displayed_{0} = 0;", Me.ParentModule.ModuleId))
            retval.AppendLine(String.Format("var senderText_{0} = '{1}';", Me.ParentModule.ModuleId, Me.SenderText))

            Return retval.ToString
        End Function

        Private Overloads Sub CollectIncomingMessage(ByVal eventArgument As String)
            'EventArgument should give us the xml message from the client
            'This message should be Deserialzed 
            ' and must be decoded for formatting
            'and we'll need to drop it on the stack / in the queue, whatever...

            Dim _message As DnnChatMessage

            _message = DnnChatMessageCollection.DeserializeDnnChatmessage(eventArgument, Me.ChatRootImageUrl, Me.AllowFormatting)

            CollectIncomingMessage(_message)

        End Sub

        Private Sub RegisterUser()
            Dim lChatUser As DnnChatUser = New DnnChatUser()
            lChatUser.ChatSessionGuid = ChatClientID
            If ParentModule.UserInfo Is Nothing Then
                lChatUser.UserID = Null.NullInteger
            Else
                lChatUser.UserID = ParentModule.UserInfo.UserID
            End If
            lChatUser.Nickname = GetSenderName()

            If DnnChatUsers.ContainsKey(ChatClientID) = False Then
                DnnChatUsers.Add(ChatClientID, lChatUser)
            End If

            'This statement seems fishy, but it actually writes the updated ChatUsers-list to the cache
            DnnChatUsers = DnnChatUsers

        End Sub

        Private Sub UnregisterUser()

            If DnnChatUsers.ContainsKey(ChatClientID) Then
                DnnChatUsers.Remove(ChatClientID)

                'This statement seems fishy, but it actually writes the updated ChatUsers-list to the cache
                DnnChatUsers = DnnChatUsers
            End If

        End Sub

        Private Overloads Sub CollectIncomingMessage(ByVal msg As DnnChatMessage)

            'We'll ignore themessage if it's empty:
            If msg.Content.Length = 0 Then
                Exit Sub
            End If

            'Does the conversation need instantiation?
            If Me.DnnChatSessionMessages Is Nothing Then

                'no existing queue found so create a new queue
                _Messages = New DnnChatMessageCollection(Me.ParentModule.ModuleId)

            Else

                'existing Queue found, so use it
                _Messages = Me.DnnChatSessionMessages

            End If

            msg.SenderName = GetSenderName()
            msg.ID = DnnChatSessionLastMessageID + 1
            DnnChatSessionLastMessageID = msg.ID

            msg.DateTime = Now

            'Add the message to the stack
            _Messages.Add(msg)

            'purge stale messages
            While _Messages.Count > HistoryCapacity
                _Messages.RemoveAt(0)
            End While

            'Put the stack back in the cache
            Me.DnnChatSessionMessages = _Messages

            'SKA: What's the use of this?
            Select Case msg.MessageType
                Case MessageType.CHAT
                    'nothing special
                Case MessageType.ENTER
                    RegisterUser()
                    LastSentMessageID = msg.ID - 1
                Case MessageType.LEAVE
                    LastSentMessageID = Integer.MaxValue
                    UnregisterUser()
                Case Else
                    'emmm
            End Select

        End Sub

        Private Function GetSenderName() As String

            If ParentModule.UserId > 0 Then
                Return ParentModule.UserInfo.Username
            Else
                Return "Anonymous" '// TODO localize
            End If

        End Function
        Private Function GetReturnMessage() As String
            'This function should return the XML with all messages for the current client
            Dim _retval As String = String.Empty
            Dim _cmcReturn As New DnnChatMessageCollection(Me.ParentModule.ModuleId)

            Dim _lastMessageID As Integer = 0
            Dim _currentMessageID As Integer = 0


            If Not Me.DnnChatSessionMessages Is Nothing Then

                _lastMessageID = LastSentMessageID
                _currentMessageID = _lastMessageID

                For Each Msg As DnnChatMessage In Me.DnnChatSessionMessages
                    If Msg.ID > _lastMessageID Then
                        _cmcReturn.Add(Msg)
                        _currentMessageID = Msg.ID
                    End If
                Next
                If _currentMessageID <> _lastMessageID Then
                    LastSentMessageID = _currentMessageID
                End If

            End If


            _retval = _cmcReturn.Serialize

            Return _retval

        End Function

        Private _LastSentMessageID As Integer = Null.NullInteger

        Private ReadOnly Property lastSentMessageIDsKey() As String
            Get
                Return String.Format("{0}_{1}", "dnnChat_LM", Me.ParentModule.ModuleId)
            End Get
        End Property

        Private _LastSentMessageIDs As Generic.Dictionary(Of Guid, Integer)
        Private Property LastSentMessageID() As Integer
            Get
                'Get from cache only once per request
                If _LastSentMessageID = Nothing OrElse _LastSentMessageID <= 0 Then
                    'Appearently there's no chached object yet
                    Dim obj As Object = DataCache.GetCache(lastSentMessageIDsKey)
                    If obj Is Nothing Then
                        'LastSentMessageIDs are currently not in cache
                        _LastSentMessageID = Null.NullInteger
                    Else
                        'Cache found
                        _LastSentMessageIDs = CType(obj, Generic.Dictionary(Of Guid, Integer))

                        'Get this client's LastSentMessageID from the cached object
                        If _LastSentMessageIDs.ContainsKey(ChatClientID) Then
                            _LastSentMessageID = _LastSentMessageIDs(ChatClientID)
                        End If
                    End If
                End If

                Return _LastSentMessageID
            End Get
            Set(ByVal Value As Integer)
                Dim lLastSentMessageIDs As Generic.Dictionary(Of Guid, Integer)
                Dim obj As Object = DataCache.GetCache(lastSentMessageIDsKey)

                If obj Is Nothing Then
                    lLastSentMessageIDs = New Generic.Dictionary(Of Guid, Integer)
                Else
                    lLastSentMessageIDs = CType(obj, Generic.Dictionary(Of Guid, Integer))
                End If

                If lLastSentMessageIDs.ContainsKey(ChatClientID) Then
                    lLastSentMessageIDs(ChatClientID) = Value
                Else
                    lLastSentMessageIDs.Add(ChatClientID, Value)
                End If

                DataCache.SetCache(lastSentMessageIDsKey, lLastSentMessageIDs)

            End Set
        End Property

        Public Function RaiseClientAPICallbackEvent(ByVal eventArgument As String) As String Implements UI.Utilities.IClientAPICallbackEventHandler.RaiseClientAPICallbackEvent

            'When there a message in the argument, we'll need to process it
            'When it's empty, the client is only polling
            If eventArgument.Length > 0 Then
                CollectIncomingMessage(eventArgument)
            End If

            Return GetReturnMessage()
        End Function
        Private Function chatClientCookieKey() As String
            Return String.Format("chatclient_{0}_{1}", Me.ParentModule.TabId, Me.ParentModule.ModuleId)
        End Function

        Private ReadOnly Property ChatClientID() As Guid
            Get
                Try
                    Dim req As HttpRequest = HttpContext.Current.Request

                    ' save the chatclientid as a cookie
                    ' we just use a guid for it. It should identify the user's 
                    ' chat session, even in e webfarm environment en prevent from
                    ' sending too many messages to the client
                    Dim cookie As System.Web.HttpCookie = Nothing
                    Dim cookieValue As Guid = Guid.Empty

                    cookie = req.Cookies.Get(chatClientCookieKey)

                    If (cookie Is Nothing) Then
                        'This sets the cookie
                        cookieValue = Guid.NewGuid()
                        HttpContext.Current.Response.Cookies.Add(New System.Web.HttpCookie(chatClientCookieKey, cookieValue.ToString))
                    Else
                        Try
                            cookieValue = New GuidConverter().ConvertFromString(cookie.Value)
                        Catch ex As Exception
                            'Current cookie is broken. make a new one...
                            cookieValue = Guid.NewGuid()
                            HttpContext.Current.Response.Cookies.Add(New System.Web.HttpCookie(chatClientCookieKey, cookieValue.ToString))
                        End Try
                    End If

                    Return cookieValue
                Catch
                    Return Guid.Empty
                End Try
            End Get
        End Property


        Protected Function GetSetting(Of TSetting)(ByVal strSetting As String, ByVal defaultValue As TSetting) As TSetting
            Dim obj As Object = ParentModule.Settings.Item(strSetting)
            If obj Is Nothing Then
                Return defaultValue
            Else
                Return Convert.ChangeType(obj, GetType(TSetting))
            End If
        End Function

    End Class

End Namespace
