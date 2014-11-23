Imports System.Collections
Imports System.Data.OleDb
Imports FSE.WebControl.ASB

Partial Class asb_includes_Auto
    Inherits System.Web.UI.Page


    Private msTextBoxID As String
    Private msMenuDivID As String
    Private msDataType As String
    Private mnNumMenuItems As Int32
    Private mbIncludeMoreMenuItem As Boolean
    Private msMoreMenuItemLabel As String
    Private msMenuItemCSSClass As String
    Private msKeyword As String


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load 'MyBase.Load, Me.Load
        'If TypeOf Session("AutoSuggestCall") Is Date Then
        '    Dim d As Date = Session("AutoSuggestCall")
        '    If (Now - d).TotalMilliseconds <= 500 Then
        '        Return
        '    End If
        'End If
        'Session("AutoSuggestCall") = Now
        'Turn off cache
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetCacheability(HttpCacheability.Server)

        msTextBoxID = Request.QueryString("TextBoxID")
        msMenuDivID = Request.QueryString("MenuDivID")
        msDataType = Request.QueryString("DataType")
        mnNumMenuItems = Convert.ToInt32(Request.QueryString("NumMenuItems"))
        mbIncludeMoreMenuItem = Convert.ToBoolean(Request.QueryString("IncludeMoreMenuItem"))
        msMoreMenuItemLabel = Request.QueryString("MoreMenuItemLabel")
        msMenuItemCSSClass = Request.QueryString("MenuItemCSSClass")
        msKeyword = Request.QueryString("Keyword")

        'Get menu item labels and values
        Dim aMenuItems As Generic.List(Of ASBMenuItem) = LoadMenuItems()

        'Generate html and write it to the page
        Dim sHtml As String
        sHtml = AutoSuggestBox.GenMenuItemsHtml(aMenuItems, _
                                                msTextBoxID, _
                                                mnNumMenuItems, _
                                                mbIncludeMoreMenuItem, _
                                                msMoreMenuItemLabel, _
                                                msMenuItemCSSClass)
        Response.Write(sHtml)


    End Sub


    Private Function LoadData(ByVal sKeyword As String) As Generic.List(Of ASBMenuItem)
        Dim aOut As New Generic.List(Of ASBMenuItem)
        Dim ds As New DataSet
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_KHO_BO
        Try
            'Tim ca tinh va huyen neu co 
            Dim sTinh As String
            Dim sHuyen As String
            If Not Request.QueryString("tinh") Is Nothing Then
                sTinh = Request.QueryString("tinh")
            Else
                sTinh = ""
            End If
            If Not Request.QueryString("huyen") Is Nothing Then
                sHuyen = Request.QueryString("huyen")
            Else
                sHuyen = ""
            End If
            ds = obj.Search(sKeyword, sTinh, sHuyen, Null.NullInteger)
            Dim oMenuItem As ASBMenuItem
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If i > mnNumMenuItems Then Exit For
                oMenuItem = New ASBMenuItem
                oMenuItem.Label = ds.Tables(0).Rows(i).Item("TEN_KHO")
                oMenuItem.Value = ds.Tables(0).Rows(i).Item("ID_KHO")
                aOut.Add(oMenuItem)
            Next
        Finally
            ds = Nothing
            obj = Nothing
        End Try
        Return aOut
    End Function


    Function LoadMenuItems() As Generic.List(Of ASBMenuItem)
        Dim aMenuItems As New Generic.List(Of ASBMenuItem)
        aMenuItems = LoadData(msKeyword)
        LoadMenuItems = aMenuItems

    End Function
End Class
