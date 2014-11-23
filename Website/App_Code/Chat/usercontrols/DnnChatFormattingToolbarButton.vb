Namespace DotNetNuke.Modules.Chat
    Public Class DnnChatFormattingToolbarButton

        Public Enum BtnType As Integer
            Emoticon = 0
            Color
            Size
            Bold
            Italicized
            Url
            Underlined
            Strikethrough
            Superscript
            Subscript
            'Strong
            'Blink
            'Citations
            'Sample
            'Definition
            'Code
            'Variable
            'Typewriter

        End Enum

        Public Enum ButtonFormatStyle As Integer
            First
            Middle
            Last
        End Enum

#Region " Public Properties "
        Private _moduleID As Integer
        Public Property ModuleID() As Integer
            Get
                Return _moduleID
            End Get
            Set(ByVal value As Integer)
                _moduleID = value
            End Set
        End Property
        Private _ChatRootImageUrl As String = String.Empty
        Public Property ChatRootImageUrl() As String
            Get
                Return _ChatRootImageUrl
            End Get
            Set(ByVal value As String)
                _ChatRootImageUrl = value
            End Set
        End Property
        Private _buttonStyle As ButtonFormatStyle
        Public Property ButtonStyle() As ButtonFormatStyle
            Get
                Return _buttonStyle
            End Get
            Set(ByVal value As ButtonFormatStyle)
                _buttonStyle = value
            End Set
        End Property
        Private _formatTye As BtnType
        Public Property FormatType() As BtnType
            Get
                Return _formatTye
            End Get
            Set(ByVal value As BtnType)
                _formatTye = value
            End Set
        End Property
        Private _chatwindowTextboxId As String = String.Empty
        Public Property ChatwindowTextboxId() As String
            Get
                Return _chatwindowTextboxId
            End Get
            Set(ByVal value As String)
                _chatwindowTextboxId = value
            End Set
        End Property
        Public ReadOnly Property HtmlTagDisabled() As String
            Get
                Return String.Format("{0}", Me.ImageTagDisabled)
            End Get
        End Property
        Public ReadOnly Property HtmlTag(ByVal pEnabled As Boolean) As Boolean
            Get
                If pEnabled Then
                    Return HtmlTagEnabled
                Else
                    Return HtmlTagDisabled
                End If
            End Get
        End Property
        Public ReadOnly Property HtmlTagEnabled() As String
            Get
                Return String.Format("{0}{1}", Me.SubSelectorTag, Me.LinkTag)
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
#Region " Private Readonly Properties "
        Private ReadOnly Property LinkTag() As String
            Get
                Return String.Format("<a {0} {1}>{2}</a>", Me.LinkHrefAttribute, Me.LinkOnClickAttribute, Me.ImageTagEnabled)
            End Get
        End Property
        Private ReadOnly Property SubSelectorTag() As String
            Get
                Dim retval As String = String.Empty
                Select Case Me.FormatType
                    Case BtnType.Emoticon
                        retval = (New SubSelector(Me)).DivTag

                    Case BtnType.Size
                        retval = (New SubSelector(Me)).DivTag

                    Case BtnType.Color
                        retval = (New SubSelector(Me)).DivTag

                    Case Else

                End Select
                Return retval

            End Get
        End Property
        Private ReadOnly Property PopupControlClientID() As String
            Get
                Return (String.Format("div_{0}_{1}", Me.ModuleID, CType(Me.FormatType, Integer)))
            End Get
        End Property
        Private ReadOnly Property AlternateText() As String
            Get
                Dim retval As String = String.Empty
                Select Case Me.FormatType
                    Case BtnType.Emoticon
                        retval = Localization.GetString("InsertEmoticon", LocalResourceFile)

                    Case BtnType.Bold
                        retval = Localization.GetString("ApplyBold", LocalResourceFile)

                    Case BtnType.Size
                        retval = Localization.GetString("ApplySize", LocalResourceFile) '"Apply size"

                    Case BtnType.Color
                        retval = Localization.GetString("ApplyColor", LocalResourceFile) '"Apply color"

                    Case BtnType.Url
                        retval = Localization.GetString("InsertHyperlink", LocalResourceFile) '"Apply url"

                    Case BtnType.Underlined
                        retval = Localization.GetString("ApplyUnderline", LocalResourceFile) '"Apply undeline"

                    Case BtnType.Italicized
                        retval = Localization.GetString("ApplyItalic", LocalResourceFile) '"Apply italic"

                    Case BtnType.Strikethrough
                        retval = Localization.GetString("ApplyStrikethrough", LocalResourceFile) '"Apply strikethrough"

                    Case BtnType.Subscript
                        retval = Localization.GetString("ApplySubscript", LocalResourceFile) '"Apply subscript"

                    Case BtnType.Superscript
                        retval = Localization.GetString("ApplySuperscript", LocalResourceFile) '"Apply superscript"

                End Select
                Return retval
            End Get
        End Property
        Private ReadOnly Property ImageUrlDisabled() As String
            Get
                Return Me.ImageUrl(False)
            End Get
        End Property

        Private ReadOnly Property ImageUrlEnsabled() As String
            Get
                Return Me.ImageUrl(True)
            End Get
        End Property
        Private ReadOnly Property ImageUrl(ByVal pEnabled As Boolean) As String
            Get

                Dim retval As String = String.Empty
                Dim _imageName As String = String.Empty

                Select Case Me.FormatType
                    Case BtnType.Emoticon
                        _imageName = "emoticon"

                    Case BtnType.Bold
                        _imageName = "bold"

                    Case BtnType.Size
                        _imageName = "size"

                    Case BtnType.Color
                        _imageName = "color"

                    Case BtnType.Url
                        _imageName = "url"

                    Case BtnType.Underlined
                        _imageName = "underline"

                    Case BtnType.Italicized
                        _imageName = "italic"

                    Case BtnType.Strikethrough
                        _imageName = "strikethrough"

                    Case BtnType.Subscript
                        _imageName = "subscript"

                    Case BtnType.Superscript
                        _imageName = "superscript"
                End Select

                If pEnabled Then
                    retval = String.Format("{0}{1}.gif", Me.ChatRootImageUrl, _imageName)
                Else
                    retval = String.Format("{0}{1}_grayed.gif", Me.ChatRootImageUrl, _imageName)
                End If

                Return retval
            End Get

        End Property
        Private ReadOnly Property OpeningTag() As String
            Get
                Dim retval As String = String.Empty
                Select Case Me.FormatType
                    Case BtnType.Emoticon
                        retval = ""

                    Case BtnType.Bold
                        retval = "[b]"

                    Case BtnType.Size
                        retval = "[size=]"

                    Case BtnType.Color
                        retval = "[color=]"

                    Case BtnType.Url
                        retval = "[url=]"

                    Case BtnType.Underlined
                        retval = "[u]"

                    Case BtnType.Italicized
                        retval = "[i]"

                    Case BtnType.Strikethrough
                        retval = "[s]"

                    Case BtnType.Subscript
                        retval = "[sub]"

                    Case BtnType.Superscript
                        retval = "[sup]"

                End Select
                Return retval
            End Get

        End Property
        Private ReadOnly Property ClosingTag() As String
            Get
                Dim retval As String = String.Empty
                Select Case Me.FormatType
                    Case BtnType.Emoticon
                        retval = ""

                    Case BtnType.Bold
                        retval = "[/b]"

                    Case BtnType.Size
                        retval = "[/size]"

                    Case BtnType.Color
                        retval = "[/color]"

                    Case BtnType.Url
                        retval = "[/url]"

                    Case BtnType.Underlined
                        retval = "[/u]"

                    Case BtnType.Italicized
                        retval = "[/i]"

                    Case BtnType.Strikethrough
                        retval = "[/s]"

                    Case BtnType.Subscript
                        retval = "[/sub]"

                    Case BtnType.Superscript
                        retval = "[/sup]"
                End Select
                Return retval
            End Get

        End Property
        Private ReadOnly Property LinkJavascript() As String
            Get
                Dim retval As String = String.Empty
                Select Case Me.FormatType
                    Case BtnType.Emoticon, BtnType.Color, BtnType.Size
                        retval = String.Format("show_{0}_{1}();return false;", Me.ModuleID, CType(Me.FormatType, Integer))

                    Case Else
                        retval = String.Format("bbTag('{0}','{1}','{2}' );return false;", Me.ChatwindowTextboxId, Me.OpeningTag, Me.ClosingTag)

                End Select

                Return retval
            End Get
        End Property
        Private ReadOnly Property LinkHrefAttribute() As String
            Get
                Return "href=""""" 'Adding, so the user cn use teh keyboard as weel to navigate
            End Get
        End Property
        Private ReadOnly Property LinkOnClickAttribute() As String
            Get
                Return String.Format("onclick=""{0}""", Me.LinkJavascript)
            End Get
        End Property
        Private ReadOnly Property ImageUrlAttributeEnabled() As String
            Get
                Return String.Format("src=""{0}""", Me.ImageUrlEnsabled)
            End Get
        End Property
        Private ReadOnly Property ImageUrlAttributeDisabled() As String
            Get
                Return String.Format("src=""{0}""", Me.ImageUrlDisabled)
            End Get
        End Property
        Private ReadOnly Property ImageAltAttribute() As String
            Get
                Return String.Format("alt=""{0}""", Me.AlternateText)
            End Get
        End Property
        Private ReadOnly Property ImageOmMouseOverAttribute() As String
            Get
                Dim temp As String = String.Empty
                Select Case Me.FormatType
                    Case BtnType.Emoticon, BtnType.Color, BtnType.Size
                        temp = String.Format("show_{0}_{1}();", Me.ModuleID, CType(Me.FormatType, Integer))
                End Select

                Return String.Format("onmouseover=""this.style.borderColor='Gray';{0}""", temp)
            End Get
        End Property
        Private ReadOnly Property ImageOmMouseOutAttribute() As String
            Get
                Dim temp As String = String.Empty
                Select Case Me.FormatType
                    Case BtnType.Emoticon, BtnType.Color, BtnType.Size
                        temp = String.Format("hide_{0}_{1}()", Me.ModuleID, CType(Me.FormatType, Integer))
                End Select


                Return String.Format("onmouseout=""this.style.borderColor='white';{0}""", temp)
            End Get
        End Property
        Private ReadOnly Property ImageClassAttribute() As String
            Get
                Dim retval As String = String.Empty

                Select Case Me.ButtonStyle
                    Case ButtonFormatStyle.First
                        retval = "class=""bbif"""
                    Case ButtonFormatStyle.Middle
                        retval = "class=""bbim"""
                    Case ButtonFormatStyle.Last
                        retval = "class=""bbil"""
                End Select

                Return retval

            End Get
        End Property
        Private ReadOnly Property ImageTagEnabled() As String
            Get
                Return String.Format("<img {0} {1} {2} {3} {4} />", Me.ImageUrlAttributeEnabled, Me.ImageAltAttribute, Me.ImageOmMouseOverAttribute, Me.ImageOmMouseOutAttribute, Me.ImageClassAttribute)
            End Get
        End Property
        Private ReadOnly Property ImageTagDisabled() As String
            Get
                Return String.Format("<img {0} {1} {2} />", Me.ImageUrlAttributeDisabled, Me.ImageClassAttribute, Me.ImageAltAttribute)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()

        End Sub
        Public Sub New(ByVal pModuleID As Integer, _
                        ByVal pFormatType As BtnType, _
                        ByVal pChatwindowTextboxId As String, _
                        ByVal pChatRootImageUrl As String, _
                        ByVal pFormatStyle As ButtonFormatStyle, _
                        ByVal pLocalResourceFile As String)

            Me.ModuleID = pModuleID
            Me.FormatType = pFormatType
            Me.ChatwindowTextboxId = pChatwindowTextboxId
            Me.ChatRootImageUrl = pChatRootImageUrl
            Me.ButtonStyle = pFormatStyle
            Me.LocalResourceFile = pLocalResourceFile
        End Sub
        Public Sub New(ByVal pFormatType As BtnType, _
                        ByVal pChatRootImageUrl As String, _
                        ByVal pFormatStyle As ButtonFormatStyle, _
                        ByVal pLocalResourceFile As String)

            Me.FormatType = pFormatType
            Me.ChatRootImageUrl = pChatRootImageUrl
            Me.ButtonStyle = pFormatStyle
            Me.LocalResourceFile = pLocalResourceFile

        End Sub

#End Region
        Private Class SubSelector

            Private _parent As DnnChatFormattingToolbarButton
            Public Property Parent() As DnnChatFormattingToolbarButton
                Get
                    Return _parent
                End Get
                Set(ByVal value As DnnChatFormattingToolbarButton)
                    _parent = value
                End Set
            End Property
            Private ReadOnly Property DivClassAttribute() As String
                Get
                    Return "class=""ssd"""
                End Get
            End Property
            Private ReadOnly Property DivIDAttribute() As String
                Get
                    Return String.Format("id=""{0}""", Me.Parent.PopupControlClientID)
                End Get
            End Property
            Public ReadOnly Property DivTag() As String
                Get
                    Return String.Format("<nobr><span {0} {1}>{2}</span></nobr>", Me.DivIDAttribute, Me.DivClassAttribute, Me.TableTag)
                End Get
            End Property
            Private ReadOnly Property TableTag() As String
                Get
                    Return String.Format("<table {0} {1} {2}>{3}</table>", Me.DivOnMouseOverAtribute, Me.DivOnMouseOutAtribute, Me.TableFormatAtribute, Me.TableRowsTag)
                End Get
            End Property
            Private ReadOnly Property DivOnMouseOverAtribute() As String
                Get
                    Return String.Format("onmouseover=""resetTmr_{0}_{1}();""", Me.Parent.ModuleID, CType(Me.Parent.FormatType, Integer))
                End Get
            End Property
            Private ReadOnly Property DivOnMouseOutAtribute() As String
                Get
                    Return String.Format("onmouseout=""hide_{0}_{1}();""", Me.Parent.ModuleID, CType(Me.Parent.FormatType, Integer))
                End Get
            End Property
            Private ReadOnly Property TableFormatAtribute() As String
                Get
                    Dim retval As String = String.Empty

                    Select Case Me.Parent.FormatType
                        Case BtnType.Emoticon
                            retval = "class=""et"""
                        Case BtnType.Size
                            retval = "class=""st"""
                        Case BtnType.Color
                            retval = "class=""ct"""
                    End Select
                    Return retval

                End Get
            End Property

            Private ReadOnly Property TableRowsTag() As String
                Get

                    Dim retval As String = String.Empty

                    Select Case Me.Parent.FormatType
                        Case BtnType.Color
                            retval = TableRowsColorSelector
                        Case BtnType.Emoticon
                            retval = TableRowsEmoticonSelector(DnnChatCodeHelper.GiveDnnChtatEmoticons(Me.Parent.ChatRootImageUrl))
                        Case BtnType.Size
                            retval = TableRowsSizeSelector
                    End Select
                    Return retval



                End Get
            End Property
            Private ReadOnly Property TableRowsEmoticonSelector(ByVal pEmoticons As ArrayList, Optional ByVal pNumberOfColumns As Integer = 5) As String
                Get
                    Dim _StringBuilder As New StringBuilder
                    Dim _linkOnClickAttribute As String = String.Empty
                    Dim _linkOnClickAttributeJS As String = String.Empty
                    Dim _linkHrefAttribute As String = String.Empty

                    Dim _ImageUrlAttribute As String = String.Empty
                    Dim _imageAltAttribute As String = String.Empty
                    Dim _ImageOmMouseOverAttribute As String = String.Empty
                    Dim _ImageOmMouseOutAttribute As String = String.Empty
                    Dim _ImageClassAttribute As String = String.Empty
                    Dim _Emoticon As DnnChatEmoticon

                    Dim lvstrImageRoot As String = Me.Parent.ChatRootImageUrl + "emoticons/"

                    For _index As Integer = 0 To pEmoticons.Count - 1

                        _Emoticon = CType(pEmoticons(_index), DnnChatEmoticon)

                        'create optional the tabelerow openening tag
                        If _index Mod 5 = 0 Then
                            _StringBuilder.Append("<tr>")
                        End If

                        'create the tabelecell openening tag
                        _StringBuilder.Append("<td class=""ec"">")

                        'Create the hyperlink opening tag
                        _linkHrefAttribute = "href=""""" 'Adding, so the user cn use teh keyboard as weel to navigate
                        _linkOnClickAttributeJS = String.Format("document.getElementById('{0}').value +=  '{1} '; hide_{2}_{3}(); document.getElementById('{0}').focus(); return false;", Me.Parent.ChatwindowTextboxId, _Emoticon.RepacementText, Me.Parent.ModuleID, CType(Me.Parent.FormatType, Integer))
                        _linkOnClickAttribute = String.Format("onclick=""{0}""", _linkOnClickAttributeJS)
                        _StringBuilder.Append(String.Format("<a {0} {1}>", _linkHrefAttribute, _linkOnClickAttribute))

                        'Create the image tag
                        _ImageUrlAttribute = String.Format("src=""{0}{1}""", lvstrImageRoot, _Emoticon.ImageName)
                        _imageAltAttribute = String.Format("alt=""{0}""", _Emoticon.AlternateText)
                        _ImageOmMouseOverAttribute = "onmouseover=""this.style.borderColor='Gray';"""
                        _ImageOmMouseOutAttribute = "onmouseout=""this.style.borderColor='white';"""
                        _ImageClassAttribute = "class=""eci"""
                        _StringBuilder.Append(String.Format("<img {0} {1} {2} {3} {4} />", _ImageUrlAttribute, _imageAltAttribute, _ImageOmMouseOverAttribute, _ImageOmMouseOutAttribute, _ImageClassAttribute))

                        'Create theb hyperlink closing tag
                        _StringBuilder.Append("</a>")

                        'create optional the tabelecll closing tag
                        _StringBuilder.Append("</td>")

                        'create optional the tabelerow closing tag
                        If ((_index + 1) Mod pNumberOfColumns = 0) OrElse (_index = pEmoticons.Count - 1) Then
                            _StringBuilder.Append("</tr>")
                        End If

                    Next

                    Return _StringBuilder.ToString

                End Get
            End Property
            Private ReadOnly Property TableRowColorSelectorCell(ByVal pColor As Color) As String
                Get
                    Dim _cellStyleAttribute As String = String.Format("style=""background-color:{0}""", pColor.Name)
                    Dim _cellOnClickAttribute As String = String.Format("onclick=""bbTag('{0}','[color=' +  this.id + ']','[/color]' );return false;""", Me.Parent.ChatwindowTextboxId)
                    'Dim _cellOnMouseOverAttribute = "onmouseover=""ccover(this.id);"""
                    'Dim _cellOnMouseOutAttribute = "onmouseout=""ccout(this.id);"""
                    Dim _cellClassAttribute As String = "class=""cc"""
                    Dim _cellIDattribute As String = String.Format("id=""{0}""", pColor.Name)
                    Dim _cellTooltip As String = String.Format("title=""{0}""", pColor.Name)
                    Return String.Format("<TD {0} {1} {2} {3} {4}></td>", _cellIDattribute, _cellStyleAttribute, _cellClassAttribute, _cellOnClickAttribute, _cellTooltip)
                End Get
            End Property

            Private ReadOnly Property TableRowsColorSelector() As String
                Get
                    Dim _StringBuilder As New StringBuilder

                    _StringBuilder.Append("<tr>")
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Black))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Gray))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.DarkGray))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.LightGray))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.White))
                    _StringBuilder.Append("</tr>")
                    _StringBuilder.Append("<tr>")
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Aquamarine))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Blue))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Navy))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Purple))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.DeepPink))
                    _StringBuilder.Append("</tr>")
                    _StringBuilder.Append("<tr>")
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Violet))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Pink))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.DarkGreen))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Green))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.YellowGreen))
                    _StringBuilder.Append("</tr>")
                    _StringBuilder.Append("<tr>")
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Yellow))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Orange))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Red))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Brown))
                    _StringBuilder.Append(Me.TableRowColorSelectorCell(Color.Beige))
                    _StringBuilder.Append("</tr>")
                    '"transparent.gif


                    Return _StringBuilder.ToString
                End Get
            End Property
            Private ReadOnly Property TableRowSizeSelectorCell(ByVal pSize As String, ByVal pClass As String) As String
                Get

                    Dim _StringBuilder As New StringBuilder
                    Dim _linkOnClickAttribute As String = String.Empty
                    Dim _linkOnClickAttributeJS As String = String.Empty
                    Dim _linkHrefAttribute As String = String.Empty
                    Dim _linkIDAttribute As String = String.Empty
                    Dim _link As String = String.Empty


                    'Create the hyperlink opening tag
                    _linkHrefAttribute = "href=""""" 'Adding, so the user cn use teh keyboard as weel to navigate
                    _linkOnClickAttributeJS = String.Format("bbTag('{0}','[size=' +  this.id + ']','[/size]' );return false;", Me.Parent.ChatwindowTextboxId)
                    _linkOnClickAttribute = String.Format("onclick=""{0}""", _linkOnClickAttributeJS)
                    _linkIDAttribute = String.Format("id=""{0}""", pSize)

                    _link = String.Format("<a {0} {1} (2)>{3}</a>", _linkIDAttribute, _linkHrefAttribute, _linkOnClickAttribute, pSize)

                    'Dim _cellOnClickAttribute = "onclick=""cC(this.id);""" TODO
                    Dim _cellOnClickAttribute As String = String.Format("onclick=""bbTag('{0}','[size=' +  this.id + ']','[/size]' );return false;""", Me.Parent.ChatwindowTextboxId)
                    Dim _cellOnMouseOverAttribute As String = "" '"onmouseover=""cOV(this);"""
                    Dim _cellOnMouseOutAttribute As String = "" '"onmouseout=""cOU(this);"""
                    Dim _cellClassAttribute As String = String.Format("class=""{0}""", pClass)
                    Dim _cellIDattribute As String = String.Format("id=""{0}""", pSize)
                    Return String.Format("<td {0} {1} {2} {3} {4}>{5}</td>", _cellIDattribute, _cellClassAttribute, _cellOnMouseOverAttribute, _cellOnMouseOutAttribute, _cellOnClickAttribute, _link)
                End Get
            End Property

            Private ReadOnly Property TableRowsSizeSelector() As String
                Get
                    Dim _StringBuilder As New StringBuilder

                    _StringBuilder.Append("<tr>")
                    _StringBuilder.Append(Me.TableRowSizeSelectorCell("xx-large", "scl")) 'TODO localize
                    _StringBuilder.Append(Me.TableRowSizeSelectorCell("small", "scr"))
                    _StringBuilder.Append("</tr>")
                    _StringBuilder.Append("<tr>")
                    _StringBuilder.Append(Me.TableRowSizeSelectorCell("x-large", "scl"))
                    _StringBuilder.Append(Me.TableRowSizeSelectorCell("x-small", "scr"))
                    _StringBuilder.Append("</tr>")
                    _StringBuilder.Append("<tr>")
                    _StringBuilder.Append(Me.TableRowSizeSelectorCell("large", "scl"))
                    _StringBuilder.Append(Me.TableRowSizeSelectorCell("xx-small", "scr"))
                    _StringBuilder.Append("</tr>")



                    Return _StringBuilder.ToString
                End Get
            End Property

#Region " Constructors "

            Public Sub New(ByVal pParent As DnnChatFormattingToolbarButton)

                Me.Parent = pParent

            End Sub

#End Region
        End Class
    End Class


End Namespace

