Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports AjaxControlToolkit
Imports System.Data
Imports System.Data.SqlClient

<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<System.Web.Script.Services.ScriptService()> _
Public Class wsNTP_QLVT_DM_KHO
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function gettinh(ByVal knownCategoryValues As String, ByVal category As String) As List(Of CascadingDropDownNameValue)
        Dim ret As New List(Of CascadingDropDownNameValue)
        Dim obj As New NTP_DANHMUC.NTP_DM_TINH_BO
        Dim ds As New DataSet
        Dim value As CascadingDropDownNameValue
        Try
            ds = obj.SelectAllItems
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                value = New CascadingDropDownNameValue
                value.name = ds.Tables(0).Rows(i).Item("TEN_TINH")
                value.value = ds.Tables(0).Rows(i).Item("MA_TINH")
                ret.Add(value)
            Next
        Catch ex As Exception
        Finally
            obj = Nothing
        End Try

        Return ret
    End Function

    <WebMethod()> _
    Public Function gethuyen(ByVal knownCategoryValues As String, ByVal category As String) As List(Of CascadingDropDownNameValue)
        Dim ret As New List(Of CascadingDropDownNameValue)
        Dim obj As New NTP_DANHMUC.NTP_DM_HUYEN_BO
        Dim ds As New DataSet
        Dim value As CascadingDropDownNameValue
        Try
            Dim arrValue As String()
            Dim stinh As String
            'arrValue = knownCategoryValues.Split(System.Convert.ToChar(":"), System.Convert.ToChar(";"))
            'stinh = arrValue(1)
            Dim kv As StringDictionary
            kv = CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues)
            stinh = kv.Item("tinh")
            ds = obj.Search("", stinh)
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                value = New CascadingDropDownNameValue
                value.name = ds.Tables(0).Rows(i).Item("TEN_HUYEN")
                value.value = ds.Tables(0).Rows(i).Item("MA_HUYEN")
                ret.Add(value)
            Next
        Catch ex As Exception
        Finally
            obj = Nothing
        End Try

        Return ret
    End Function

    <WebMethod()> _
    Public Function getkho(ByVal knownCategoryValues As String, ByVal category As String) As List(Of CascadingDropDownNameValue)
        Dim ret As New List(Of CascadingDropDownNameValue)
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_KHO_BO
        Dim ds As New DataSet
        Dim value As CascadingDropDownNameValue
        Try
            Dim arrValue As String()
            Dim shuyen As String
            'arrValue = knownCategoryValues.Split(System.Convert.ToChar(":"), System.Convert.ToChar(";"))
            'shuyen = arrValue(2)
            Dim kv As StringDictionary
            kv = CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues)
            shuyen = kv.Item("huyen")
            Dim stinh As String
            stinh = kv.Item("tinh")
            ds = obj.Search("", stinh, shuyen, Null.NullInteger)
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                value = New CascadingDropDownNameValue
                value.name = ds.Tables(0).Rows(i).Item("TEN_KHO")
                value.value = ds.Tables(0).Rows(i).Item("ID_KHO")
                ret.Add(value)
            Next
        Catch ex As Exception
        Finally
            obj = Nothing
        End Try

        Return ret
    End Function
End Class
