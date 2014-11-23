Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls

<DefaultProperty("Text"), ToolboxData("<{0}:MultiSelectGrid runat=server></{0}:MultiSelectGrid>")> Public Class MultiSelectGrid
    Inherits System.Web.UI.WebControls.DataGrid

    Private Const ID_CHECK_ALL As String = "chkAll"
    Private Const ID_CHECK_ITEM As String = "chkItem"

    Protected mSelItems As DataGridItemCollection

    <Bindable(True), Category("Misc"), DefaultValue(True)> Property MultiSelect() As Boolean
        Get
            Dim obj As Object = Me.ViewState.Item("MultiSelect")
            If obj Is Nothing Then
                Return True
            Else
                Return CBool(obj)
            End If
        End Get

        Set(ByVal Value As Boolean)
            'If Value = True Then
            '    If Me.ViewState.Item("Created") = False Then
            '        Me.Columns.AddAt(0, New TemplateColumn)
            '        Me.ViewState.Item("Created") = True
            '    End If
            'Else
            '    If Me.ViewState.Item("Created") = True Then
            '        Me.Columns.RemoveAt(0)
            '        Me.ViewState.Item("Created") = False
            '    End If
            'End If
            Me.ViewState.Item("MultiSelect") = Value
        End Set
    End Property

    <Bindable(True), Category("Misc"), DefaultValue(True)> Property Highlighted() As Boolean
        Get
            Dim obj As Object = Me.ViewState.Item("Highlighted")
            If obj Is Nothing Then
                Return True
            Else
                Return CBool(obj)
            End If
        End Get
        Set(ByVal Value As Boolean)
            Me.ViewState.Item("Highlighted") = Value
        End Set
    End Property

    <Bindable(True), Category("Misc"), DefaultValue("")> Property HighlightCssClass() As String
        Get
            Dim obj As Object = Me.ViewState.Item("HighlightCssClass")
            If obj Is Nothing Then
                Return String.Empty
            Else
                Return CStr(obj)
            End If
        End Get
        Set(ByVal Value As String)
            Me.ViewState.Item("HighlightCssClass") = Value
        End Set
    End Property

    Public ReadOnly Property SelectedItems() As DataGridItemCollection
        Get
            If (Not Me.Context Is Nothing) AndAlso (Me.MultiSelect = True) Then
                'Chua co Collection?
                If mSelItems Is Nothing Then
                    Dim arr As New System.Collections.ArrayList
                    Dim ctl As Control, chk As CheckBox
                    Dim dgi As DataGridItem
                    'Duyet cac DataGridItem trong DataGrid
                    For Each dgi In Me.Items
                        'Lay CheckBox control
                        ctl = dgi.Cells(0).FindControl(ID_CHECK_ITEM)
                        If Not ctl Is Nothing Then
                            If TypeOf ctl Is CheckBox Then
                                chk = CType(ctl, CheckBox)
                                'Checked?
                                If chk.Checked = True Then
                                    'Add vao ArrayList
                                    arr.Add(dgi)
                                End If
                            End If
                        End If
                    Next
                    mSelItems = New DataGridItemCollection(arr)
                End If
                Return mSelItems
            Else
                Return Nothing
            End If
        End Get
    End Property

    Protected Overrides Sub OnItemCreated(ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
        Dim chk As CheckBox
        MyBase.OnItemCreated(e)
        Select Case e.Item.ItemType
            Case ListItemType.Header
                If Me.MultiSelect = True Then
                    chk = New CheckBox
                    chk.ID = ID_CHECK_ALL
                    chk.Attributes("onclick") = "msgCheckAll(this)"
                    e.Item.Cells(0).Controls.Add(chk)
                End If
            Case ListItemType.Item, ListItemType.AlternatingItem
                If Me.MultiSelect = True Then
                    chk = New CheckBox
                    chk.ID = ID_CHECK_ITEM
                    If Me.Highlighted = True Then
                        If e.Item.ItemType = ListItemType.Item Then
                            chk.Attributes("onclick") = String.Format("msgHighlight(this,'{0}','{1}')", Me.ItemStyle.CssClass, Me.HighlightCssClass)
                        Else
                            chk.Attributes("onclick") = String.Format("msgHighlight(this,'{0}','{1}')", Me.AlternatingItemStyle.CssClass, Me.HighlightCssClass)
                        End If
                        AddHandler chk.CheckedChanged, AddressOf chk_CheckedChanged
                    End If
                    e.Item.Cells(0).Controls.Add(chk)
                End If
        End Select
    End Sub

    Protected Sub chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chk As CheckBox = CType(sender, CheckBox)
        Dim dgi As DataGridItem
        dgi = CType(chk.Parent.Parent, DataGridItem)
        If (chk.Checked) Then
            dgi.CssClass = Me.HighlightCssClass
        Else
            If dgi.ItemType = ListItemType.Item Then
                dgi.CssClass = Me.ItemStyle.CssClass
            Else
                dgi.CssClass = Me.AlternatingItemStyle.CssClass
            End If
        End If
    End Sub

    'Protected Overrides Sub OnInit(ByVal e As System.EventArgs)
    '    MyBase.OnInit(e)
    '    If Me.ViewState.Item("Created") = False Then
    '        Me.Columns.AddAt(0, New TemplateColumn)
    '        Me.ViewState.Item("Created") = True
    '    End If
    'End Sub
End Class
