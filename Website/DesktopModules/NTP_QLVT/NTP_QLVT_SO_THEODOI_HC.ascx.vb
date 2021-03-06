Imports NTP_Common.mdlGlobal

Public Class NTP_QLVT_SO_THEODOI_VT
    Inherits DotNetNuke.Entities.Modules.ModuleSettingsBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                End If
                SetValue(Me.txtTuNgay, Now, enuDATA_TYPE.DATE_TYPE)
                SetValue(Me.txtDenNgay, Now, enuDATA_TYPE.DATE_TYPE)
                BindComboVATTU()
                If Not Session(FILTER_STRING) Is Nothing Then
                    ' setstate
                    '
                Else
                    'BindData(Me.txtMA_PHIEU.Text, CType(GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE), Date), CType(GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE), Date), cboNGUON_KINHPHI.SelectedValue)
                End If
            End If
            Me.Literal1.Visible = False
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        End Try

    End Sub

    Private Sub BindComboVATTU()
        Dim obj As New NTP_QLVT.NTP_QLVT_DM_VATTU_BO
        Try
            Me.cboVattu.DataSource = obj.SelectAllItems(NTP_Common.enuTYPE_VATTU_HOACHAT.HOACHAT)
            Me.cboVattu.DataBind()
            Me.cboVattu.Items.Insert(0, (New ListItem("--- Tất cả ---", Null.NullInteger)))
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
            obj = Nothing
        End Try
    End Sub

    Protected Sub cmdView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim url As String
        Dim dtDateFrom As Date = GetValue(Me.txtTuNgay, enuDATA_TYPE.DATE_TYPE)
        Dim dtDateTo As Date = GetValue(Me.txtDenNgay, enuDATA_TYPE.DATE_TYPE)
        url = Request.ApplicationPath & "/DesktopModules/NTP_QLVT/BAOCAO_SO_THEODOI_HC.aspx?ID_KHO=" & Me.CurrentUserStock.ID_KHO_QLVT & "&DATEFROM=" & dtDateFrom & "&DATETO=" & dtDateTo & "&ID_VATTU=" & Me.cboVattu.SelectedItem.Value   ' "./DesktopModules/VTP_VIEWREPORT/ShowReport.aspx"
        Literal1.Text = "<script language = 'javascript'>" & _
                                "window.open('" & url & "','_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');</script>"
        Literal1.Visible = True

    End Sub

    Protected Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Response.Redirect(NavigateURL())
    End Sub
End Class
