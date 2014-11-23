Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Web


Namespace ASB
	''' <summary>Data structure for menu items in suggestion div</summary>
	Public Class ASBMenuItem
		Private msLabel As String
		Private msValue As String
		Private mbIsSelectable As Boolean
		Private msCSSClass As String

		#Region "Class Properties"

		Public Property Label() As String
			Get
				Return msLabel
			End Get
			Set(ByVal value As String)
				msLabel=value
			End Set
		End Property

		Public Property Value() As String
			Get
				Return msValue
			End Get
			Set(ByVal value As String)
				msValue=value
			End Set
		End Property


		Public Property IsSelectable() As Boolean
			Get
				Return mbIsSelectable
			End Get
			Set(ByVal value As Boolean)
				mbIsSelectable=value
			End Set
		End Property

		Public Property CSSClass() As String
			Get
				Return msCSSClass
			End Get
			Set(ByVal value As String)
				msCSSClass=value
			End Set
		End Property
		#End Region


		'Constructor
		Public Sub New()
			msCSSClass="asbMenuItem"
			mbIsSelectable=True
		End Sub


		Public Function GenHtml(ByVal nItemIndex As Integer, ByVal sTextBoxID As String) As String
			Dim sMenuItemValueID As String
			Dim sFunc1 As String
			Dim sFunc2 As String

			Dim sHtml As String=""
			If Me.IsSelectable Then
				Dim sCtrlID As String=sTextBoxID & "_mi_" & nItemIndex
				Dim sObj As String="asbGetObj('" & sTextBoxID & "')"

				sFunc1=sObj & ".OnMouseClick(" & nItemIndex & ")"
				sFunc2=sObj & ".OnMouseOver(" & nItemIndex & ")"

				sHtml &= "<div class=""" & Me.CSSClass & """" & " id=""" & sCtrlID & """" & " name=""" & sCtrlID & """" & " value=""" & System.Web.HttpUtility.HtmlEncode(Me.Value) & """" & " onclick=""" & sFunc1 & """" & " onmouseover=""" & sFunc2 & """>" & Me.Label & "</div>"
				sMenuItemValueID=sCtrlID & "_value"
				sHtml &= Constants.vbLf + Constants.vbCr
			Else
				sHtml &= "<div class=""" & Me.CSSClass & """ style=""cursor:auto"">" & Me.Label & "</div>"
			End If

			Return sHtml
		End Function
	End Class

End Namespace
