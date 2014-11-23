Imports CrystalDecisions.CrystalReports.Engine
Partial Class DesktopModules_NTP_BN_BC_KETQUADT_BaoCao
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument
    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        rpt.Close()
        rpt.Dispose()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try


            Dim ds As New DataSet

            Dim obj As New YourCompany.Modules.NTP_BN_BC_KETQUADT.NTP_BN_BCKETQUADIEUTRILAOINController
            Dim Tinh As String
            Dim Mien As Integer
            Dim Vung As Integer
            Dim Nam As Integer

            Me.Title = "So theo doi hoa chat"
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
            Dim Quy As Integer = Request.QueryString("Quy")
            ' ds = obj.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 1) -- Original
            ds = obj.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 1, "")

            Dim sPath As String
            sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\NTP_BN_BCKETQUADIEUTRILAO_IN.rpt"
            rpt.Load(sPath)

            rpt.SetDataSource(ds.Tables(0))
            Me.CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.DataBind()

        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally
           
        End Try
    End Sub

End Class
