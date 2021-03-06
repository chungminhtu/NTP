Imports System.Web.UI

Public Module mdlGlobal
    Public Const FILTER_STRING As String = "FILTER_STRING"
    Public Const ERR_DUPLICATE As Integer = 2627
    Public Const ERR_VIOLATION_FK As Integer = 547

    Public Enum enuERROR_CODE
        SUCCESS = 0
        DUPLICATE_PK_KEY = 2627
    End Enum

    Public Enum enuDATA_TYPE
        DATE_TYPE = 0
        NUMERIC_TYPE = 1
        INTEGER_TYPE = 2
    End Enum

    Public Enum enuBILL_STATUS
        [DEFAULT] = 0
        LOCK = 1
    End Enum

    Public Enum enuTRANGTHAI_KY_KIEMKE
        CHUA_KIEMKE = -1
        DA_KHOA_SO = 0
        KET_THUC_KIEMKE = 1
    End Enum

    Public Enum enuTYPE_VATTU_HOACHAT
        VATTU = 1
        HOACHAT = 0
    End Enum

    Public Sub GetFilterValue(ByVal sFilterString As String, ByVal txtObject As Object)
        '--------------------
        'Information
        '--------------------
        'Author     : LuanNH
        'Purpose    : Lấy giá trị trong Filter String và gán vào TextBox
        '--------------------
        'Param Description
        '--------------------
        'sFilterString  : xâu chứa các giá trị Filter. VD:
        '"key1=value1;key2=value2;"
        'txtObject      : TextBox hoặc ComboObject
        '--------------------
        Dim sKeyName = GetFilterKeyName(txtObject)
        Dim iPos As Integer = InStr(sFilterString, sKeyName)
        If iPos > 0 Then
            sFilterString = Mid(sFilterString, iPos + Len(sKeyName) + 1)
        Else
            Exit Sub
        End If
        iPos = InStr(sFilterString, ";")
        If iPos > 0 Then
            Dim sValue As String = Left(sFilterString, iPos - 1)
            If TypeOf txtObject Is System.Web.UI.WebControls.TextBox Then
                txtObject.Text = sValue
            ElseIf TypeOf txtObject Is System.Web.UI.WebControls.DropDownList Then
                If Not CType(txtObject, System.Web.UI.WebControls.DropDownList).Items.FindByValue(sValue) Is Nothing Then
                    txtObject.SelectedValue = sValue
                End If
            ElseIf TypeOf txtObject Is System.Web.UI.WebControls.CheckBoxList Then
                For Each mItem As System.Web.UI.WebControls.ListItem In txtObject.Items()
                    If InStr(sValue, mItem.Value & ",") > 0 Then
                        mItem.Selected = True
                    Else
                        mItem.Selected = False
                    End If
                Next
            End If
        End If
    End Sub

    Private Function GetFilterKeyName(ByVal txtObject As Object) As String
        Return TypeName(txtObject.BindingContainer) & "-" & txtObject.ID
    End Function

    Public Sub AppendFilterString(ByRef sFilterString As String, ByVal txtObject As Object)
        '--------------------
        'Information
        '--------------------
        'Author     : LuanNH
        'Purpose    : Đặt giá trị vào Filter String
        '--------------------
        'Param Description
        '--------------------
        'sFilterString  : xâu chứa các giá trị Filter. VD:
        '"key1=value1;key2=value2;"
        'txtObject      : TextBox hoặc ComboObject
        '--------------------
        Dim sValue As String
        Dim sKeyName = GetFilterKeyName(txtObject)
        If TypeOf txtObject Is System.Web.UI.WebControls.TextBox Then
            If txtObject.Text <> "" Then
                sFilterString = sFilterString & sKeyName & "=" & txtObject.Text & ";"
            End If
        ElseIf TypeOf txtObject Is System.Web.UI.WebControls.DropDownList Then
            sFilterString = sFilterString & sKeyName & "=" & txtObject.SelectedValue & ";"
        ElseIf TypeOf txtObject Is System.Web.UI.WebControls.CheckBoxList Then
            For Each mItem As System.Web.UI.WebControls.ListItem In txtObject.Items()
                If mItem.Selected Then
                    sValue = sValue & "," & mItem.Value
                End If
            Next
            If sValue <> "" Then
                sValue += ","
                sFilterString = sFilterString & sKeyName & "=" & sValue & ";"
            End If
        End If

    End Sub

    'set focus to any control

    Public Sub SetFormFocus(ByVal control As Control, ByVal SupportPartial As Boolean, Optional ByVal ToTop As Boolean = False)

        If SupportPartial Then
            Dim sm As System.Web.UI.ScriptManager = ScriptManager.GetCurrent(control.Page)
            sm.SetFocus(control)
        Else
            If Not control.Page Is Nothing And control.Visible Then
                If control.Page.Request.Browser.JavaScript = True Then

                    ' Create JavaScript 
                    Dim sb As New System.Text.StringBuilder
                    sb.Append("<SCRIPT LANGUAGE='JavaScript'>")
                    sb.Append("<!--")
                    sb.Append(ControlChars.Lf)
                    sb.Append("function SetInitialFocus() {")
                    sb.Append(ControlChars.Lf)
                    sb.Append(" document.")

                    ' Find the Form 
                    Dim objParent As Control = control.Parent
                    While Not TypeOf objParent Is System.Web.UI.HtmlControls.HtmlForm
                        objParent = objParent.Parent
                    End While
                    sb.Append(objParent.ClientID)
                    sb.Append("['")
                    If control.GetType.Name = "WebNumericEdit" Then
                        sb.Append("x" & control.ClientID & "_t")
                    ElseIf control.GetType.Name = "USERCodeAndList" Then
                        sb.Append("cl_" & control.ID)
                    Else
                        sb.Append(control.UniqueID)
                    End If
                    sb.Append("'].focus(); " & ControlChars.Lf & objParent.ClientID & "['" & control.UniqueID & "'].scrollIntoView(true); ")
                    If ToTop Then
                        sb.Append(ControlChars.Lf & " scroll(0,0); ")
                    End If
                    sb.Append(ControlChars.Lf & " }")
                    sb.Append("window.onload = SetInitialFocus;")
                    sb.Append(ControlChars.Lf)
                    sb.Append("// -->")
                    sb.Append(ControlChars.Lf)
                    sb.Append("</SCRIPT>")

                    ' Register Client Script 
                    control.Page.RegisterClientScriptBlock("InitialFocus", sb.ToString())
                End If
            End If
        End If

    End Sub

    Public Sub SetPageToTop(ByVal PageToTop As Page)
        ' Create JavaScript 
        Dim sb As String
        ' Find the Form 
        sb = sb & " <script language='javascript'> " & vbNewLine
        sb = sb & " function move_top() { " & vbNewLine
        sb = sb & "         scroll(0,0); " & vbNewLine
        sb = sb & " } " & vbNewLine
        sb = sb & " </script> " & vbNewLine
        sb = sb & " window.onload = move_up; " & vbNewLine
        ' Register Client Script 
        PageToTop.RegisterClientScriptBlock("ScrollPageToTop", sb.ToString())

    End Sub

    Public Function ProcessSQLError(ByVal sqlex As SqlClient.SqlException) As String
        Dim ret As String
        Select Case sqlex.Number
            Case ERR_DUPLICATE
                ret = "Dữ liệu trường khóa đã có trong cơ sở dữ liệu"
            Case ERR_VIOLATION_FK
                ret = "Lỗi liên quan đến ràng buộc dữ liệu <br>" & vbCrLf & sqlex.ToString
            Case Else
                ret = sqlex.Message
        End Select
        Return ret
    End Function

    Public Sub Combo_HandleTyping(ByVal objCombo As System.Web.UI.WebControls.DropDownList)
        objCombo.Attributes("onKeyDown") = "TADD_OnKeyDown(this);"
    End Sub

    Public Sub TextboxSetInput(ByVal objTextbox As System.Web.UI.WebControls.TextBox, ByVal objDatatype As enuDATA_TYPE)
        Select Case objDatatype
            Case enuDATA_TYPE.DATE_TYPE
                Dim sScript As String
                Dim sm As System.Web.UI.ScriptManager = ScriptManager.GetCurrent(objTextbox.Page)
                sScript = "<script language=""javascript"" type=""text/javascript"">jQuery(function($){$(""#" & objTextbox.ClientID & """).mask(""99/99/9999""); });</script>"
                'objTextbox.Page.ClientScript.RegisterClientScriptBlock(GetType(String), "setinput" & objTextbox.ClientID, sScript)
                sm.RegisterClientScriptBlock(objTextbox.Page, GetType(Page), "setinput" & objTextbox.ClientID, sScript, True)
            Case enuDATA_TYPE.NUMERIC_TYPE

            Case enuDATA_TYPE.INTEGER_TYPE

        End Select
    End Sub

    Public Function GetValue(ByVal txtTextbox As System.Web.UI.WebControls.TextBox, ByVal objDatatype As enuDATA_TYPE) As Object
        Select Case objDatatype
            Case enuDATA_TYPE.DATE_TYPE
                'Change date 
                Dim dt As Date
                If Date.TryParseExact(txtTextbox.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dt) Then
                    'parse true
                    Return dt
                Else
                    'parse false
                    Return Date.MinValue
                End If
            Case enuDATA_TYPE.INTEGER_TYPE
                Return txtTextbox.Text
            Case enuDATA_TYPE.NUMERIC_TYPE
                Return txtTextbox.Text
        End Select
    End Function

    Public Sub SetValue(ByRef txtTextbox As System.Web.UI.WebControls.TextBox, ByVal value As Object, ByVal objDatatype As enuDATA_TYPE)
        Select Case objDatatype
            Case enuDATA_TYPE.DATE_TYPE
                'Change date 
                If CType(value, Date) = Date.MinValue Then
                    'txtTextbox.Text = ""
                    Return
                Else
                    txtTextbox.Text = CType(value, Date).ToString("dd/MM/yyyy")
                End If

            Case enuDATA_TYPE.INTEGER_TYPE
                txtTextbox.Text = value
            Case enuDATA_TYPE.NUMERIC_TYPE
                txtTextbox.Text = value
        End Select
    End Sub

    Public Function GetStatusComment(ByVal iStatus As Integer) As String
        Dim ret As String
        Select Case iStatus
            Case 0
                ret = "Chưa khóa sổ"
            Case 1
                ret = "Đã khóa sổ"
        End Select
        Return ret
    End Function

    Public Function GetTrangthai_ky_kiemke(ByVal iStatus As enuTRANGTHAI_KY_KIEMKE) As String
        Select Case iStatus
            Case enuTRANGTHAI_KY_KIEMKE.CHUA_KIEMKE
                Return ""
            Case enuTRANGTHAI_KY_KIEMKE.DA_KHOA_SO
                Return "Kỳ kiểm kê đang được khóa sổ kiểm kê"
            Case enuTRANGTHAI_KY_KIEMKE.KET_THUC_KIEMKE
                Return "Kỳ kiểm kê đã khóa sổ"
        End Select
    End Function
End Module