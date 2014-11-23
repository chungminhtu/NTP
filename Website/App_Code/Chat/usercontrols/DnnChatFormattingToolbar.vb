Imports System.ComponentModel
Imports System.Text
Imports System.Web.UI
Imports System.Web.UI.WebControls

Imports BTN = DotNetNuke.Modules.Chat.DnnChatFormattingToolbarButton

Namespace DotNetNuke.Modules.Chat
    <DefaultProperty("Text"), ToolboxData("<{0}:DnnChatEmoticonPicker runat=server></{0}:DnnChatEmoticonPicker>")> Public Class DnnChatFormattingToolbar

        'Inherits System.Web.UI.WebControls.WebControl
        Inherits System.Web.UI.Control

#Region " Public Properties "
        Private m_ChatRootImageUrl As String = String.Empty
        'Popup Selector OnMouseOver
        <Bindable(True), Category("Behaviour"), DefaultValue(False)> _
        Public Property ChatRootImageUrl() As String
            Get
                Return m_ChatRootImageUrl
            End Get
            Set(ByVal value As String)
                m_ChatRootImageUrl = value
            End Set
        End Property
        Private m_ShowPopupOnMouseOver As Boolean = True
        'Popup Selector OnMouseOver
        <Bindable(True), Category("Behaviour"), DefaultValue(False)> _
        Public Property ShowPopupOnMouseOver() As Boolean
            Get
                Return m_ShowPopupOnMouseOver
            End Get
            Set(ByVal value As Boolean)
                m_ShowPopupOnMouseOver = value
            End Set
        End Property

        Private m_NumberOfEmoticonsColumns As Integer = 5
        'Popup Selector OnMouseOver
        <Bindable(True), Category("Behaviour"), DefaultValue(5)> _
        Public Property NumberOfEmoticonsColumns() As Integer
            Get
                Return m_NumberOfEmoticonsColumns
            End Get
            Set(ByVal value As Integer)
                m_NumberOfEmoticonsColumns = value
            End Set
        End Property
        Private _moduleID As Integer = 123 ''todo
        Public Property ModuleID() As Integer
            Get
                Return _moduleID
            End Get
            Set(ByVal value As Integer)
                _moduleID = value
            End Set
        End Property

        Private m_ResultControlClientID As String = String.Empty
        Public Property ResultControlClientID() As String
            Get
                Return m_ResultControlClientID
            End Get
            Set(ByVal Value As String)
                m_ResultControlClientID = Value
            End Set
        End Property
        Private m_EnableButtons As Boolean = True
        Public Property EnableButtons() As Boolean
            Get
                Return m_EnableButtons
            End Get
            Set(ByVal value As Boolean)
                m_EnableButtons = value
            End Set
        End Property
        Public ReadOnly Property HeightInPixels() As Integer
            Get
                Return 50
            End Get
        End Property
        Private _LocalResourceFile As String
        Public Property LocalResourceFile() As String
            Get
                Return _LocalResourceFile
            End Get
            Set(ByVal value As String)
                _LocalResourceFile = value
            End Set
        End Property
#End Region
#Region " Private Properties "
        Private m_PopupControlClientID As String = String.Empty
        Private ReadOnly Property PopupControlClientID() As String
            Get
                If m_PopupControlClientID.Length = 0 Then
                    m_PopupControlClientID = Guid.NewGuid.ToString
                End If
                Return m_PopupControlClientID
            End Get
        End Property

        Private ReadOnly Property ClientScripFormatToolbarButtons() As String
            Get
                Dim ScriptInclude As New StringBuilder
                ScriptInclude.Append("<script language=javascript><!--" & vbCrLf)

                ScriptInclude.Append(ClientScripFormatToolbarButton(BTN.BtnType.Color))
                ScriptInclude.Append(ClientScripFormatToolbarButton(BTN.BtnType.Size))
                ScriptInclude.Append(ClientScripFormatToolbarButton(BTN.BtnType.Emoticon))

                ScriptInclude.Append(vbCrLf & "--></script>")
                Return ScriptInclude.ToString
            End Get
        End Property

        Private ReadOnly Property ClientScripFormatToolbarButton(ByVal pButton As BTN.BtnType) As String
            Get

                Dim lvstrReplacement As String = String.Format("_{0}_{1}", Me.ModuleID, CType(pButton, Integer))

                Dim ScriptInclude As New StringBuilder
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("var timer{0}=0;", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("var picker{0}=0;", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("function resetTmr{0}()", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append("{")
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("clearTimeout(timer{0});", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append("}")
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("function show{0}()", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append("{")
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("picker{0}=document.getElementById('div{0}');", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("picker{0}.style.visibility='visible';", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)

                If Not pButton = BTN.BtnType.Color Then
                    ScriptInclude.Append(String.Format("picker_{0}_{1} = document.getElementById('div_{0}_{1}');", Me.ModuleID, CType(BTN.BtnType.Color, Integer)))
                    ScriptInclude.Append(vbCrLf)
                    ScriptInclude.Append(String.Format("safeHide_{0}_{1}();", Me.ModuleID, CType(BTN.BtnType.Color, Integer)))
                    ScriptInclude.Append(vbCrLf)
                End If
                If Not pButton = BTN.BtnType.Size Then
                    ScriptInclude.Append(String.Format("picker_{0}_{1} = document.getElementById('div_{0}_{1}');", Me.ModuleID, CType(BTN.BtnType.Size, Integer)))
                    ScriptInclude.Append(vbCrLf)
                    ScriptInclude.Append(String.Format("safeHide_{0}_{1}();", Me.ModuleID, CType(BTN.BtnType.Size, Integer)))
                    ScriptInclude.Append(vbCrLf)
                End If
                If Not pButton = BTN.BtnType.Emoticon Then
                    ScriptInclude.Append(String.Format("picker_{0}_{1} = document.getElementById('div_{0}_{1}');", Me.ModuleID, CType(BTN.BtnType.Emoticon, Integer)))
                    ScriptInclude.Append(vbCrLf)
                    ScriptInclude.Append(String.Format("safeHide_{0}_{1}();", Me.ModuleID, CType(BTN.BtnType.Emoticon, Integer)))
                    ScriptInclude.Append(vbCrLf)
                End If

                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append("}")
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("function hide{0}()", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append("{")
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("timer{0}=setTimeout('safeHide{0}();',100);", lvstrReplacement))
                ScriptInclude.Append("}")
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("function safeHide{0}()", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append("{")
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("picker{0}.style.visibility='hidden';", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append(String.Format("resetTmr{0}();", lvstrReplacement))
                ScriptInclude.Append(vbCrLf)
                ScriptInclude.Append("}")
                ScriptInclude.Append(vbCrLf)

                Return ScriptInclude.ToString
            End Get
        End Property
#End Region
#Region " Constructors "
        Public Sub New(ByVal pResultControlClientID As String, _
                        ByVal pChatRootImageUrl As String, _
                        ByVal pLocalResourceFile As String, _
                        Optional ByVal pEnableButtons As Boolean = True, _
                        Optional ByVal pShowPopupOnMouseOver As Boolean = True, _
                        Optional ByVal pNumberOfEmoticonsColumns As Integer = 5)

            Me.ResultControlClientID = pResultControlClientID
            Me.ChatRootImageUrl = pChatRootImageUrl
            Me.LocalResourceFile = pLocalResourceFile
            Me.ShowPopupOnMouseOver = pShowPopupOnMouseOver
            Me.NumberOfEmoticonsColumns = pNumberOfEmoticonsColumns
            Me.EnableButtons = pEnableButtons
        End Sub
        Public Sub New()
        End Sub
#End Region

        Private Sub RenderFormatButtons(ByVal writer As HtmlTextWriter)

            If Me.EnableButtons Then
                writer.Write(Me.ClientScripFormatToolbarButtons)

                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Emoticon, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.First, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Bold, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Italicized, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Underlined, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Size, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Strikethrough, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Url, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Subscript, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Superscript, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagEnabled)
                writer.Write((New DnnChatFormattingToolbarButton(Me.ModuleID, BTN.BtnType.Color, Me.ResultControlClientID, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Last, LocalResourceFile)).HtmlTagEnabled)
            Else
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Emoticon, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.First, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Bold, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Italicized, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Underlined, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Size, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Strikethrough, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Url, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Subscript, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Superscript, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Middle, LocalResourceFile)).HtmlTagDisabled)
                writer.Write((New DnnChatFormattingToolbarButton(BTN.BtnType.Color, Me.ChatRootImageUrl, BTN.ButtonFormatStyle.Last, LocalResourceFile)).HtmlTagDisabled)

            End If

        End Sub

        Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
            MyBase.Render(writer)

            RenderFormatButtons(writer)

        End Sub

#Region " Creating the selector "

#End Region

        Protected Overrides Sub CreateChildControls()

        End Sub

        Private Sub EmoticonPicker_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            EnsureChildControls()
        End Sub
    End Class
End Namespace


