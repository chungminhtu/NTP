Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Collections
Imports System.IO

Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.ComponentModel
Imports System.Collections.Specialized


Namespace ASB
	Public Class AutoSuggestBox
		Inherits TextBox
		Implements INamingContainer, IPostBackDataHandler
        Private msDataType As String
        Private mnMinSuggestChars As Integer
		Private mnMaxSuggestChars As Integer
		Private mnKeyPressDelay As Integer
		Private mnNumMenuItems As Integer
		Private mbIncludeMoreMenuItem As Boolean
		Private msMoreMenuItemLabel As String
		Private msMenuCSSClass As String
		Private msMenuItemCSSClass As String
		Private msSelMenuItemCSSClass As String
		Private mbUseIFrame As Boolean
		Private msResourcesDir As String

        Private msSelectedValue As String

        '<hunghm>
        'Moi textbox 1 page
        Private msDataPage As String

		''' <summary>Initializes new instance of AutoSuggestBox/// </summary>
		''' <remarks>Wire the events so the control can participate in them</remarks>
		Public Sub New()
			'Set Defaults
            mnMaxSuggestChars = 15
            mnMinSuggestChars = 1
            msResourcesDir = "/asb_includes"

			'Number of milliseconds to wait before returning Suggestions div
			'Makes control more efficient
			mnKeyPressDelay =300

			mnNumMenuItems =10
			mbIncludeMoreMenuItem =False
			msMoreMenuItemLabel ="..."

			msMenuCSSClass ="asbMenu"
			msMenuItemCSSClass ="asbMenuItem"
			msSelMenuItemCSSClass ="asbSelMenuItem"

			mbUseIFrame =True
		End Sub


		#Region "Class Properties"

        'Hunghm3
        Public Property DataPage() As String
            Get
                Return msDataPage
            End Get
            Set(ByVal value As String)
                msDataPage = value
            End Set
        End Property

		Public Property DataType() As String
			Get
				Return msDataType
			End Get
			Set(ByVal value As String)
				msDataType=value
			End Set
        End Property

        Public Property MinSuggestChars() As Integer
            Get
                Return mnMinSuggestChars
            End Get
            Set(ByVal value As Integer)
                mnMinSuggestChars = value
            End Set
        End Property

		Public Property MaxSuggestChars() As Integer
			Get
				Return mnMaxSuggestChars
			End Get
			Set(ByVal value As Integer)
				mnMaxSuggestChars=value
			End Set
		End Property

		Public Property KeyPressDelay() As Integer
			Get
				Return mnKeyPressDelay
			End Get
			Set(ByVal value As Integer)
				mnKeyPressDelay=value
			End Set
		End Property

		Public Property NumMenuItems() As Integer
			Get
				Return mnNumMenuItems
			End Get
			Set(ByVal value As Integer)
				mnNumMenuItems=value
			End Set
		End Property

		Public Property IncludeMoreMenuItem() As Boolean
			Get
				Return mbIncludeMoreMenuItem
			End Get
			Set(ByVal value As Boolean)
				mbIncludeMoreMenuItem=value
			End Set
		End Property

		Public Property MoreMenuItemLabel() As String
			Get
				Return msMoreMenuItemLabel
			End Get
			Set(ByVal value As String)
				msMoreMenuItemLabel=value
			End Set
		End Property

		Public Property MenuCSSClass() As String
			Get
				Return msMenuCSSClass
			End Get
			Set(ByVal value As String)
				msMenuCSSClass=value
			End Set
		End Property

		Public Property MenuItemCSSClass() As String
			Get
				Return msMenuItemCSSClass
			End Get
			Set(ByVal value As String)
				msMenuItemCSSClass=value
			End Set
		End Property

		Public Property SelMenuItemCSSClass() As String
			Get
				Return msSelMenuItemCSSClass
			End Get
			Set(ByVal value As String)
				msSelMenuItemCSSClass=value
			End Set
		End Property

		Public Property UseIFrame() As Boolean
			Get
				Return mbUseIFrame
			End Get
			Set(ByVal value As Boolean)
				mbUseIFrame=value
			End Set
		End Property

		Public Property ResourcesDir() As String
			Get
				Return msResourcesDir
			End Get
			Set(ByVal value As String)
				msResourcesDir=value
			End Set
		End Property

		Public Property SelectedValue() As String
			Get
				Return msSelectedValue
			End Get
			Set(ByVal value As String)
				msSelectedValue=value
			End Set
		End Property

		Private ReadOnly Property TextBoxID() As String
			Get
				Return Me.ClientID
			End Get
		End Property

		Private ReadOnly Property MenuDivID() As String
			Get
				Return "divMenu_" & Me.TextBoxID
			End Get
		End Property


		Private ReadOnly Property ValueCtrlID() As String
			Get
				Return Me.ClientID & "_SelectedValue"
			End Get
		End Property


		Private ReadOnly Property ValueCtrlName() As String
			Get
				Return Me.UniqueID & ":SelectedValue"
			End Get
		End Property

		#End Region



		Private Function GetFirstCtrl(ByVal sCtrlType As String, ByVal colControls As ControlCollection) As Control

			Dim oFirstCtrl As Control=Nothing

			For Each oCtrl As Control In colControls
				'Check if control type matches sCtrlType 
				If oCtrl.GetType().ToString()=sCtrlType Then
					'Make sure the control is visible
					If oCtrl.Visible Then
						Return oCtrl
					Else
						GoTo Continue1
					End If
				End If


				If oCtrl.HasControls() Then
					oFirstCtrl=GetFirstCtrl(sCtrlType, oCtrl.Controls)
					If Not oFirstCtrl Is Nothing Then
						Exit For
					End If
				End If
				Continue1:
			Next oCtrl

			Return oFirstCtrl
		End Function



		Private Function IsTopASBCtrl() As Boolean
			Dim oCtrl As Control=GetFirstCtrl("ASB.AutoSuggestBox", Page.Controls)
			If oCtrl Is Nothing Then
				Return False
			End If

			If oCtrl.UniqueID=Me.UniqueID Then
				Return True
			Else
				Return False
			End If
		End Function




		''' <summary>This member overrides <see cref="IPostBackDataHandler.LoadPostData"/></summary>
		''' <remarks>This override is needed to get SelectedValue before WebPage.Load</remarks>
		Public Overloads Function LoadPostData(ByVal postDataKey As String, ByVal postCollection As NameValueCollection) As Boolean Implements IPostBackDataHandler.LoadPostData
			Dim bChanged As Boolean=False

			If Not postCollection(Me.ValueCtrlName) Is Nothing Then
				msSelectedValue=postCollection(Me.ValueCtrlName).ToString()
			End If

			'Duplicate functionality of textbox since there is no way to call base class
			If Not postCollection(Me.UniqueID) Is Nothing Then
				Dim sNewText As String=postCollection(Me.UniqueID).ToString()
				If sNewText<>Me.Text Then
					bChanged=True
					Me.Text=sNewText
				End If
			End If

			Return bChanged
		End Function




		''' <summary>This member overrides <see cref="Control.LoadViewState"/></summary>
		''' <remarks>Loads date from view-state saved in previous page into date control properties</remarks>
		Protected Overrides Sub LoadViewState(ByVal savedState As Object)
			MyBase.LoadViewState(savedState)

            msDataType = CStr(ViewState("DataType"))
            msDataPage = CStr(ViewState("DataPage"))
            mnMinSuggestChars = CInt(Fix(ViewState("MinSuggestChars")))
			mnMaxSuggestChars =CInt(Fix(ViewState("MaxSuggestChars")))
			mnKeyPressDelay =CInt(Fix(ViewState("KeyPressDelay")))
			mnNumMenuItems =CInt(Fix(ViewState("NumMenuItems")))
			mbIncludeMoreMenuItem =CBool(ViewState("IncludeMoreMenuItem"))
			msMoreMenuItemLabel =CStr(ViewState("MoreMenuItemLabel"))
			msMenuCSSClass =CStr(ViewState("MenuCSSClass"))
			msMenuItemCSSClass =CStr(ViewState("MenuItemCSSClass"))
			msSelMenuItemCSSClass =CStr(ViewState("SelMenuItemCSSClass"))
			mbUseIFrame =CBool(ViewState("UseIFrame"))
			msResourcesDir =CStr(ViewState("ResourcesDir"))
		End Sub



		''' <summary>This member overrides <see cref="Control.SaveViewState"/></summary>
		''' <remarks>Stores date control properties in view-state for future page</remarks>
		Protected Overrides Function SaveViewState() As Object
            ViewState("DataType") = msDataType
            ViewState("MinSuggestChars") = mnMinSuggestChars
			ViewState("MaxSuggestChars") =mnMaxSuggestChars
			ViewState("KeyPressDelay") =mnKeyPressDelay
			ViewState("NumMenuItems") =mnNumMenuItems
			ViewState("IncludeMoreMenuItem")=mbIncludeMoreMenuItem
			ViewState("MoreMenuItemLabel") =msMoreMenuItemLabel
			ViewState("MenuCSSClass") =msMenuCSSClass
			ViewState("MenuItemCSSClass") =msMenuItemCSSClass
			ViewState("SelMenuItemCSSClass")=msSelMenuItemCSSClass
			ViewState("UseIFrame") =mbUseIFrame
			ViewState("ResourcesDir") =msResourcesDir
            ViewState("DataPage") = msDataPage
			Return MyBase.SaveViewState()
		End Function




		Protected Sub WriteCSSAndJSIncludes()
			Dim writer As HtmlTextWriter = New HtmlTextWriter(New System.IO.StringWriter())

			'Include appropriate CSS and JS files
            writer.WriteLine("<script type='text/javascript' language='JavaScript' src='" & Me.Page.Request.ApplicationPath & msResourcesDir & "/AutoSuggestBox.js'></script>")
            writer.WriteLine("<link href='" & Me.Page.Request.ApplicationPath & msResourcesDir & "/AutoSuggestBox.css' type='text/css' rel='stylesheet'>")

            Me.Page.RegisterStartupScript("AutoSuggestBox", writer.InnerWriter.ToString())
		End Sub


		Protected Sub WriteJSAutoSuggestBox()
			Dim writer As HtmlTextWriter = New HtmlTextWriter(New System.IO.StringWriter())

            WriteCSSAndJSIncludes()

            writer.WriteLine("<script language=""javascript"">")
			writer.WriteLine("<!--")

            writer.WriteLine("var oASB_" + Me.TextBoxID + "=new JSAutoSuggestBox();")

            writer.WriteLine("oASB_" + Me.TextBoxID + ".msTextBoxID='" & Me.TextBoxID & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msMenuDivID='" & Me.MenuDivID & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msDataType='" & msDataType & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".mnMinSuggestChars=" & mnMinSuggestChars & ";")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".mnMaxSuggestChars=" & mnMaxSuggestChars & ";")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".mnKeyPressDelay=" & mnKeyPressDelay & ";")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".mnNumMenuItems=" & mnNumMenuItems & ";")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".mbIncludeMoreMenuItem=" & mbIncludeMoreMenuItem.ToString().ToLower() & ";")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msMoreMenuItemLabel='" & msMoreMenuItemLabel & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msMenuCSSClass='" & msMenuCSSClass & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msMenuItemCSSClass='" & msMenuItemCSSClass & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msSelMenuItemCSSClass='" & msSelMenuItemCSSClass & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".mbUseIFrame=" & mbUseIFrame.ToString().ToLower() & ";")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msResourcesDir='" & Me.Page.Request.ApplicationPath & msResourcesDir & "';")
            writer.WriteLine("oASB_" + Me.TextBoxID + ".msDataPage='" & msDataPage & "';")

            writer.WriteLine("asbAddObj('" & Me.TextBoxID & "', oASB_" + Me.TextBoxID + ");")

			writer.WriteLine("//-->")
			writer.WriteLine("</script>")
			writer.WriteLine("")

            Page.ClientScript.RegisterStartupScript(Page.GetType, "AutoSuggestBox_" & Me.UniqueID, writer.InnerWriter.ToString())
		End Sub



		''' <summary>Renders AutoSuggestBox to the output HTML parameter specified.</summary>
		''' <param name="output"> The HTML writer to write out to</param>
		Protected Overrides Sub Render(ByVal output As HtmlTextWriter)

			WriteJSAutoSuggestBox()

			Dim sObj As String="asbGetObj('" & Me.TextBoxID & "')"

			Me.Attributes("onblur") = sObj & ".OnBlur();"
			Me.Attributes("onkeydown") = sObj & ".OnKeyDown(event);"
			Me.Attributes("onkeypress") = "return " & sObj & ".OnKeyPress(event);"
            Me.Attributes("onkeyup") = sObj & ".OnKeyUp(event,'" & Me.msDataPage & "');" 'Hunghm3
			Me.Attributes("autocomplete") = "off"

			MyBase.Render(output)

			output.WriteLine("<br><div class='" & msMenuCSSClass & "' style='visibility:hidden' id='" & Me.MenuDivID & "'></div>")

			'Add hidden contol to store currently selected value
			output.WriteLine("<input type=""hidden"" id=""" & Me.ValueCtrlID & """ name=""" & Me.ValueCtrlName & """ value=""" & msSelectedValue & """>")
		End Sub



		''' <summary>
		''' Generate HTML to display menu items
		''' </summary>
		''' <param name="aMenuItems">Array of ASBMenuItem object</param>
		''' <param name="sTextBoxID">ID of the text box control</param>
		''' <param name="nNumMenuItems">Number of menu items in the list</param>
		''' <param name="bIncludeMoreMenuItem">Indicates if (more) menu item should be included</param>
		''' <param name="sMoreMenuItemLabel">Label for (more) menu item</param>
		''' <returns>Html for menu items</returns>
        Public Shared Function GenMenuItemsHtml(ByVal aMenuItems As Generic.List(Of ASBMenuItem), ByVal sTextBoxID As String, ByVal nNumMenuItems As Integer, ByVal bIncludeMoreMenuItem As Boolean, ByVal sMoreMenuItemLabel As String, ByVal sMenuItemCSSClass As String) As String
            Dim oMenuItem As ASBMenuItem
            Dim oWriter As HtmlTextWriter = New HtmlTextWriter(New StringWriter())

            Dim sHtml As String

            'Output menu items to the web page
            For nCount As Integer = 0 To aMenuItems.Count - 1
                oMenuItem = aMenuItems(nCount)
                oMenuItem.CSSClass = sMenuItemCSSClass
                sHtml = oMenuItem.GenHtml(nCount + 1, sTextBoxID)

                oWriter.WriteLine(sHtml)

                'Make sure number of items is less then mnNumMenuItems
                If nNumMenuItems = nCount Then
                    Exit For
                End If
            Next nCount


            'Add 'more' menu item 
            If bIncludeMoreMenuItem Then
                If aMenuItems.Count > nNumMenuItems Then
                    oMenuItem = New ASBMenuItem()

                    oMenuItem.Label = sMoreMenuItemLabel
                    oMenuItem.Value = ""
                    oMenuItem.IsSelectable = False
                    oMenuItem.CSSClass = sMenuItemCSSClass

                    sHtml = oMenuItem.GenHtml(nNumMenuItems + 1, sTextBoxID)
                    oWriter.WriteLine(sHtml)
                End If
            End If

            Return oWriter.InnerWriter.ToString()
        End Function
	End Class
End Namespace
