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

    Private Function LoadOrganizations(ByVal sKeyword As String) As Generic.List(Of ASBMenuItem)
        Dim aOut As New Generic.List(Of ASBMenuItem)
        'Dim dr As IDataReader = OrganizationController.Instance.Organization_Search(sKeyword)
        'Try
        '    Dim oMenuItem As ASBMenuItem
        '    Dim iCount, iName, iCode As Integer
        '    iName = Reader_GetColIndex(dr, "Org_Name")
        '    iCode = Reader_GetColIndex(dr, "Org_ID")
        '    While dr.Read
        '        If iCount > mnNumMenuItems Then Exit While
        '        oMenuItem = New ASBMenuItem
        '        oMenuItem.Label = dr.Item(iName)
        '        oMenuItem.Value = dr.Item(iCode)

        '        aOut.Add(oMenuItem) '
        '        iCount += 1
        '    End While
        'Finally
        '    dr.Close()
        'End Try
        Return aOut
    End Function

    Private Function LoadUnits(ByVal sKeyword As String) As Generic.List(Of ASBMenuItem)
        Dim aOut As New Generic.List(Of ASBMenuItem)
        'Dim dr As IDataReader = UnitController.Instance.Unit_Search(sKeyword)
        'Try
        '    Dim oMenuItem As ASBMenuItem
        '    Dim iCount, iName, iCode As Integer
        '    iName = Reader_GetColIndex(dr, "Unit_Name")
        '    iCode = Reader_GetColIndex(dr, "Unit_Name")
        '    While dr.Read
        '        If iCount > mnNumMenuItems Then Exit While
        '        oMenuItem = New ASBMenuItem
        '        oMenuItem.Label = dr.Item(iName)
        '        oMenuItem.Value = dr.Item(iCode)

        '        aOut.Add(oMenuItem) '
        '        iCount += 1
        '    End While
        'Finally
        '    dr.Close()
        'End Try
        Return aOut
    End Function

    Private Function LoadUserUnits(ByVal sKeyword As String) As Generic.List(Of ASBMenuItem)
        Dim aOut As New Generic.List(Of ASBMenuItem)
        'Dim dr As IDataReader = UnitController.Instance.User_Unit_Search(sKeyword)
        'Try
        '    Dim oMenuItem As ASBMenuItem
        '    Dim iCount, iName, iCode As Integer
        '    iName = Reader_GetColIndex(dr, "Name")
        '    iCode = Reader_GetColIndex(dr, "Name")
        '    While dr.Read
        '        If iCount > mnNumMenuItems Then Exit While
        '        oMenuItem = New ASBMenuItem
        '        oMenuItem.Label = dr.Item(iName)
        '        oMenuItem.Value = dr.Item(iCode)

        '        aOut.Add(oMenuItem) '
        '        iCount += 1
        '    End While
        'Finally
        '    dr.Close()
        'End Try
        Return aOut
    End Function

    Private Function Demo(ByVal sKeyword As String) As Generic.List(Of ASBMenuItem)
        Dim aOut As New Generic.List(Of ASBMenuItem)
        Dim ds As New DataSet
        Dim adap As New SqlClient.SqlDataAdapter("select ModuleID, ModuleTitle from Modules where moduletitle like '%" & sKeyword & "%'", "Data Source=ENT-HUNGHM-NB\SQL2005;Initial Catalog=NTP;User Id=sa;Password=123456;")
        Try
            adap.Fill(ds)
            Dim oMenuItem As ASBMenuItem
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If i > mnNumMenuItems Then Exit For
                oMenuItem = New ASBMenuItem
                oMenuItem.Label = ds.Tables(0).Rows(i).Item(1)
                oMenuItem.Value = ds.Tables(0).Rows(i).Item(0)
                aOut.Add(oMenuItem)
            Next
            'Dim a As String = Request.ApplicationPath
            'If iCount > mnNumMenuItems Then Exit While
            '
        Finally
            adap = Nothing
            ds = Nothing
        End Try
        Return aOut
    End Function

    Private Function LoadCities(ByVal sKeyword As String) As Generic.List(Of ASBMenuItem)
        Dim aOut As New Generic.List(Of ASBMenuItem)

        'Dim sConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\databases\AutoSuggestBox_Demo.mdb;User Id=admin;Password=;"
        Dim sConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~\database\AutoSuggestBox_Demo.mdb") + ";User Id=admin;Password=;"
        Dim oCn As OleDbConnection = New OleDbConnection(sConnString)

        Dim sSql As String
        sSql = "SELECT TOP " & (mnNumMenuItems + 1) & " tblCity.Name as CityName, " & _
                    "tblCity.Code as CityCode, " & _
                    "tblCountry.Name as CountryName, " & _
                    "tblState.Name as StateName " & _
                  " FROM (tblCity INNER JOIN tblCountry ON tblCity.CountryID=tblCountry.ID) " & _
                    "		LEFT OUTER JOIN tblState ON tblCity.StateID=tblState.ID " & _
                  " WHERE (tblCity.Name LIKE '" + sKeyword.Replace("'", "''") + "%') " & _
                  " ORDER BY tblCity.Name"

        Dim oCmd As OleDbCommand = New OleDbCommand(sSql, oCn)
        oCn.Open()

        Dim oReader As OleDbDataReader = oCmd.ExecuteReader()

        Dim sCity As String
        Dim sCityCode As String
        Dim sState As String
        Dim sCountry As String

        Dim sLabel As String

        Dim oMenuItem As ASBMenuItem


        While oReader.Read()

            'Build label using City, Country & State
            sCity = oReader.GetString(0)
            sCityCode = oReader.GetString(1)
            sCountry = oReader.GetString(2)

            If (oReader.GetValue(3) Is System.DBNull.Value) Then
                sState = ""
            Else
                sState = oReader.GetString(3)
            End If

            sLabel = sCity

            'Append either city or country
            If (sState <> "") Then
                sLabel &= ", " & sState
            Else
                sLabel &= ", " & sCountry
            End If

            oMenuItem = New ASBMenuItem
            oMenuItem.Label = sLabel
            oMenuItem.Value = sCityCode

            aOut.Add(oMenuItem)

        End While

        oReader.Close()
        oCn.Close()

        Return aOut
    End Function

    Function LoadMenuItems() As Generic.List(Of ASBMenuItem)
        Dim aMenuItems As New Generic.List(Of ASBMenuItem)
        aMenuItems = Demo(msKeyword)
        LoadMenuItems = aMenuItems

    End Function
End Class
