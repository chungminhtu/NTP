Imports System.Text.RegularExpressions

Namespace DotNetNuke.Modules.Chat
    Public Class DnnChatCodeHelper
        'TODO something with compiled  
        ' http://blogs.msdn.com/bclteam/archive/2004/11/12/256783.aspx

        'Performance wise all the regular expressions are in a shared class, so they can be pre-compiled
        Shared _regexUrlSimple As Regex = New Regex("\[url\](?<UrlHref>[^\]]+)\[\/url\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        ' \[ = Matches an opening square bracket.
        ' url = Matches the text url.
        ' \] = Matches a closing square bracket.
        ' (?<UrlHref>[^\]]+) = Match one or more of any character except for the character enclosed in square brackets,
        '       which in this instance is a closing square bracket. This part of the pattern (which matches the URL between 
        '       the BBCode [url] ... [/url] tags) is enclosed in parenthesis because it needs to be remembered for the substitution.
        '       By adding "?<UrlHref>" this group gets as alias the name "UrlHref"
        ' \[\/url\] = Matches the closing BBCode url tag.
        Shared _regexUrl As Regex = New Regex("\[url=(?<UrlHref>[^\]]+)\](?<LinkedText>[^\]]+)\[\/url\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexBold As Regex = New Regex("\[b\](?<Text>[^\]]+)\[\/b\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexUnderline As Regex = New Regex("\[u\](?<Text>[^\]]+)\[\/u\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexItalic As Regex = New Regex("\[i\](?<Text>[^\]]+)\[\/i\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexColor As Regex = New Regex("\[color=(?<Value>[^\]]+)\](?<Text>[^\]]+)\[\/color\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexSize As Regex = New Regex("\[size=(?<Value>[^\]]+)\](?<Text>[^\]]+)\[\/size\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexStrike As Regex = New Regex("\[s\](?<Text>[^\]]+)\[\/s\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexSub As Regex = New Regex("\[sub\](?<Text>[^\]]+)\[\/sub\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexSup As Regex = New Regex("\[sup\](?<Text>[^\]]+)\[\/sup\]", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Shared _regexHTMLTags As Regex = New Regex("<[^>]*>", RegexOptions.IgnoreCase Or RegexOptions.Compiled)


        Public Shared Function RemoveShadyHtmlTags(ByRef pText As String) As String
            Dim retVal As String = String.Empty
            Dim objSecurity As New PortalSecurity
            Dim lMatch As Match

            Try
                retVal = pText
                'System.Text.RegularExpressions.Regex.Replace(pText, "</?(?i:script|embed|object|frameset|frame|iframe|meta|link|style)(.|\\n)*?>", String.Empty)
                'System.Text.RegularExpressions.Regex.Replace(pText, "<[^>]*>", String.Empty)

                pText = objSecurity.InputFilter(pText, PortalSecurity.FilterFlag.NoScripting)

                lMatch = _regexHTMLTags.Match(pText)

                Do While lMatch.Success
                    pText = pText.Replace(lMatch.Value, lMatch.Value.Substring(1, lMatch.Value.Length - 2))
                    lMatch = _regexHTMLTags.Match(pText)
                Loop
                retVal = pText
            Catch ex As Exception

            End Try

            Return retVal

        End Function
        Public Shared Function ParseBBCodeToHtmlTags(ByRef pText As String, ByVal pImageDirectoryRoot As String) As String

            Dim retVal As String = String.Empty

            Try

                retVal = pText

                'BBcodes can be nested, so when a BBcode-tag has been replaced by a HTML-tag the modified text will be parsed again
                If ParseBBCodeURLToHtmlTag(pText) Or _
                    ParseBBCodeURLsimpleToHtmlTag(pText) Or _
                    ParseBBCodeBoldToHtmlTag(pText) Or _
                    ParseBBCodeItalicToHtmlTag(pText) Or _
                    ParseBBCodeUnderlineToHtmlTag(pText) Or _
                    ParseBBCodeColorToHtmlTag(pText) Or _
                    ParseBBCodeSizeToHtmlTag(pText) Or _
                    ParseBBCodeStrikeToHtmlTag(pText) Or _
                    ParseBBCodeSubToHtmlTag(pText) Or _
                    ParseBBCodeSupToHtmlTag(pText) Or _
                    ParseBBCodeEmoticons(pText, pImageDirectoryRoot) Then

                    ParseBBCodeToHtmlTags(pText, pImageDirectoryRoot)
                End If

                retVal = pText
            Catch ex As Exception

            End Try
            Return retVal
        End Function
        Private Shared Function ParseBBCodeURLsimpleToHtmlTag(ByRef pText As String) As String
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexUrlSimple.Match(pText)

            If lMatch.Success Then
                Dim lReplacemt As String = String.Format("<a href=""{0}"" target=""_new"">{1}</a>", DotNetNuke.Common.AddHTTP(lMatch.Groups.Item("UrlHref").Value), lMatch.Groups.Item("UrlHref").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)
                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeURLToHtmlTag(ByRef pText As String) As Boolean
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexUrl.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String = String.Format("<a href=""{0}"" target=""_new"">{1}</a>", DotNetNuke.Common.AddHTTP(lMatch.Groups.Item("UrlHref").Value), lMatch.Groups.Item("LinkedText").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeSupToHtmlTag(ByRef pText As String) As Boolean
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexSup.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String = String.Format("<sup>{0}</sup>", lMatch.Groups.Item("Text").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeStrikeToHtmlTag(ByRef pText As String) As Boolean
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexStrike.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String = String.Format("<strike>{0}</strike>", lMatch.Groups.Item("Text").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeSubToHtmlTag(ByRef pText As String) As Boolean
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexSub.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String = String.Format("<sub>{0}</sub>", lMatch.Groups.Item("Text").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeBoldToHtmlTag(ByRef pText As String) As String
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexBold.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String = String.Format("<b>{0}</b>", lMatch.Groups.Item("Text").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeItalicToHtmlTag(ByRef pText As String) As String
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexItalic.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String = String.Format("<i>{0}</i>", lMatch.Groups.Item("Text").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeUnderlineToHtmlTag(ByRef pText As String) As String
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexUnderline.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String = String.Format("<u>{0}</u>", lMatch.Groups.Item("Text").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeSizeToHtmlTag(ByRef pText As String) As String
            Dim retVal As Boolean = False
            Dim lMatch As Match
            'Dim _size As Integer

            lMatch = _regexSize.Match(pText)

            If lMatch.Success Then

                Dim lReplacemt As String

                Select Case lMatch.Groups.Item("Value").Value
                    Case "xx-small", "xx-small", "small", "medium", "large", "x-large", "xx-large"
                        'Watch out: the space after colon is important to prevent from matching with emoticons
                        lReplacemt = String.Format("<span style=""font-size: {0}"">{1}</span>", lMatch.Groups.Item("Value").Value, lMatch.Groups.Item("Text").Value)
                    Case Else
                        'If IsNumeric(lMatch.Groups.Item("Value").Value) Then
                        '    'TODO minimum and maximum size in settings
                        '    _size = CType(lMatch.Groups.Item("Value").Value, Integer)
                        '    If _size < 1 Then
                        '        _size = 1
                        '    ElseIf _size > 40 Then
                        '        _size = 40
                        '    End If
                        '    lReplacemt = String.Format("<span style=""font-size:{0}"">{1}</span>", CType(_size, String), lMatch.Groups.Item("Text").Value)
                        'Else
                        lReplacemt = lMatch.Groups.Item("Text").Value
                        'End If
                End Select


                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeColorToHtmlTag(ByRef pText As String) As String
            Dim retVal As Boolean = False
            Dim lMatch As Match

            lMatch = _regexColor.Match(pText)

            If lMatch.Success Then

                'Watch out: the space after colon is important to prevent from matching with emoticons
                Dim lReplacemt As String = String.Format("<span style=""color: {0}"">{1}</span>", lMatch.Groups.Item("Value").Value, lMatch.Groups.Item("Text").Value)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                retVal = True
            End If

            Return retVal
        End Function
        Private Shared Function ParseBBCodeEmoticons(ByRef pText As String, ByVal pImageDirectoryRoot As String) As Boolean
            Dim retVal As Boolean = False

            Dim lReplacementMade As Boolean = False
            Dim lEmoticonArray As New ArrayList

            'TODO: mooie generiek functionaliteit


            lEmoticonArray = (DnnChatCodeHelper).GiveDnnChtatEmoticons(pImageDirectoryRoot)
            For i As Integer = 0 To lEmoticonArray.Count - 1
                msParseBBCodeEmoticon(pText, lEmoticonArray(i), lReplacementMade)
            Next

            retVal = lReplacementMade
            Return retVal
        End Function
        Private Shared Sub msParseBBCodeEmoticon(ByRef pText As String, ByVal pEmoticon As DnnChatEmoticon, ByRef pReplacement As Boolean)
            Dim lMatch As Match
            Dim _regexSmiley As Regex
            Dim lReplacemt As String = String.Empty

            _regexSmiley = New Regex(pEmoticon.RegularExpression, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            lMatch = _regexSmiley.Match(pText)

            If lMatch.Success Then

                lReplacemt = String.Format("<img src=""{0}{1}"" alt=""{2}"" />", pEmoticon.ImageDirectoryRoot, pEmoticon.ImageName, pEmoticon.AlternateText)
                pText = pText.Replace(lMatch.Value, lReplacemt)

                pReplacement = True
            End If


        End Sub
        Public Shared Function GiveDnnChtatEmoticons(ByVal pImageDirectoryRoot As String) As ArrayList
            Dim key As String = String.Format("DnnChat_EmoticonsCollection")
            Dim retval As New ArrayList
            Dim oCache As Object


            Try
                Dim ctx As Web.HttpContext = Web.HttpContext.Current
                Dim lvstrImageRoot As String = String.Empty
                oCache = ctx.Cache.Get(key)
                If oCache Is Nothing Then
                    lvstrImageRoot = pImageDirectoryRoot + "Emoticons/"

                    retval.Add(New DnnChatEmoticon("regular_smile.gif", lvstrImageRoot, "regular smile", ":)", "\:\)|\:\-\)|\(\:|\(\-\:"))
                    retval.Add(New DnnChatEmoticon("teeth_smile.gif", lvstrImageRoot, "teeth smile", ":D"))
                    retval.Add(New DnnChatEmoticon("wink_smile.gif", lvstrImageRoot, "wink smile", ";)"))
                    retval.Add(New DnnChatEmoticon("omg_smile.gif", lvstrImageRoot, "omg smile", ":-O"))
                    retval.Add(New DnnChatEmoticon("tounge_smile.gif", lvstrImageRoot, "tounge smile", ":P"))
                    retval.Add(New DnnChatEmoticon("shades_smile.gif", lvstrImageRoot, "shades smile", "(H)"))
                    retval.Add(New DnnChatEmoticon("angry_smile.gif", lvstrImageRoot, "angry smile", ":@"))
                    retval.Add(New DnnChatEmoticon("confused_smile.gif", lvstrImageRoot, "confused smile", ":S"))
                    retval.Add(New DnnChatEmoticon("embaressed_smile.gif", lvstrImageRoot, "embarressed smile", ":$"))
                    retval.Add(New DnnChatEmoticon("sad_smile.gif", lvstrImageRoot, "sad smile", ":("))
                    retval.Add(New DnnChatEmoticon("cry_smile.gif", lvstrImageRoot, "cry smile", ":,("))
                    retval.Add(New DnnChatEmoticon("whatchutalkingabout_smile.gif", lvstrImageRoot, "whatchutalkingabout smile", ":|"))
                    retval.Add(New DnnChatEmoticon("angel_smile.gif", lvstrImageRoot, "angel smile", "(A)"))
                    ''todo adding more msn emoticons

                    ctx.Cache.Insert(key, retval, Nothing, DateTime.Now.AddDays(1), TimeSpan.Zero)
                Else
                    retval = CType(oCache, ArrayList)
                End If

            Catch ex As Exception
                retval = New ArrayList
            End Try

            Return retval
        End Function
    End Class
End Namespace