Imports CrystalDecisions.CrystalReports.Engine

Partial Class DesktopModules_NTP_BN_CTCHONGLAO_BaoCao
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument
    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        rpt.Close()
        rpt.Dispose()
    End Sub
  Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rpt.Dispose()
        rpt.Close()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Dim ds As New DataSet
            Dim obj As New YourCompany.Modules.NTP_BN_CTCHONGLAO.NTP_BN_BCCTCHONGLAOINController
            Dim Tinh As String
            Dim Mien As Integer
            Dim Vung As Integer
            Dim Nam As Integer
            Dim Opt As Integer
            Dim Kieuin As Integer
            Dim Myformulas As FormulaFieldDefinitions

            If Request.QueryString("Tinh") = "" Then
                Tinh = "ALL"
            Else
                Tinh = Request.QueryString("Tinh")
            End If
            If Request.QueryString("Mien") = "" Then
                Mien = 0
            Else
                Mien = Request.QueryString("Mien")
            End If
            If Request.QueryString("Vung") = "" Then
                Vung = 0
            Else
                Vung = Request.QueryString("Vung")
            End If
            Nam = Request.QueryString("Nam")
            Opt = Request.QueryString("Opt")
            Kieuin = Request.QueryString("Kieuin")
            Dim sPath As String
            If Opt = 0 Then
                ds = obj.ListBCTHAMGIAYTETRONGCTCL(Tinh, Mien, Vung, Nam)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_SUTHAMGIACUAYTE_CTCL.rpt"
            ElseIf Opt = 1 Then
                ds = obj.ListBCTHAMGIAYTETRONGHDPHATHIEN(Tinh, Mien, Vung, Nam, 1)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_SUTHAMGIACUAYTE_PHATHIEN.rpt"
            ElseIf Opt = 2 Then
                ds = obj.ListBCTHAMGIAYTETRONGHDPHATHIEN(Tinh, Mien, Vung, Nam, 2)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_SUTHAMGIACUAYTE_CHANDOAN.rpt"
            ElseIf Opt = 3 Then
                ds = obj.ListBCTHAMGIAYTETRONGHDPHATHIEN(Tinh, Mien, Vung, Nam, 3)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_SUTHAMGIACUAYTE_DIEUTRI.rpt"
            ElseIf Opt = 4 Then
                ds = obj.ListBCTHAMGIAYTETRONGHDPHATHIEN(Tinh, Mien, Vung, Nam, 4)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_SUTHAMGIACUACONGDONGTRONGCTPHATHIEN.rpt"
            ElseIf Opt = 5 Then
                ds = obj.ListBCTHAMGIAYTETRONGHDPHATHIEN(Tinh, Mien, Vung, Nam, 5)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_SUTHAMGIACUACONGDONGTRONGCTDIEUTRI.rpt"
            ElseIf Opt = 6 Then
                ds = obj.ListBCNHANLUCTHAMGIAPCL(Tinh, Mien, Vung, Nam, 1)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_CANBOCHONGLAOTOANTINH_CTCL.rpt"
            ElseIf Opt = 7 Then
                ds = obj.ListBCNHANLUCTHAMGIAPCL(Tinh, Mien, Vung, Nam, 2)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_CANBODAIHOCTRENDAIHOC_CTCL.rpt"
            ElseIf Opt = 8 Then
                ds = obj.ListBCNHANLUCTHAMGIAPCL(Tinh, Mien, Vung, Nam, 3)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_CANBOSOCAPVACANBOKHAC_CTCL.rpt"
            ElseIf Opt = 9 Then
                ds = obj.ListBCNHANLUCTHAMGIAPCL(Tinh, Mien, Vung, Nam, 4)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_CANBOXETNGHIEMLAO_CTCL.rpt"
            ElseIf Opt = 10 Then
                ds = obj.ListBCNHANLUCTHAMGIAPCL(Tinh, Mien, Vung, Nam, 5)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_CANBOLAOKHAC_CTCL.rpt"
            End If
           
            rpt.Load(sPath)
            Myformulas = rpt.DataDefinition.FormulaFields
            Myformulas.Item("Nam").Text = "'" & Nam & "'"
            Myformulas.Item("Groupby").Text = Kieuin
            rpt.SetDataSource(ds.Tables(0))
            Me.CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.DataBind()
ds=nothing
	'obj=nothing
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub

End Class
