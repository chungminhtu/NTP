Imports CrystalDecisions.CrystalReports.Engine

Partial Class DesktopModules_NTP_BN_PHIEUXETNGHIEM
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
            Dim ds As New DataSet, Opt As Integer
            Dim ID_MaBN As String
            Dim MaBV As String
            Dim sPath As String
            Dim Tungay As Date, Denngay As Date
            Dim Matinh As String, MaHuyen As String
            Dim DK As String
            DK = ""
            Opt = Request.QueryString("Opt")
            If Opt = 1 Then
                Dim obj As New YourCompany.Modules.NTP_BN_PHIEUXETNGHIEM.NTP_BN_PHIEUXETNGHIEMController
                ID_MaBN = Request.QueryString("ID_MaBN")
                MaBV = "ALL"
                Me.Title = "Bao cao thong ke"
                ds = obj.NTP_BN_PHIEUXETNGHIEM_SelectByIDBENHNHAN(ID_MaBN, MaBV)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_DSPHIEUXETNGHIEM_BN.rpt"
            Else
                Dim obj As New YourCompany.Modules.NTP_BN_BENHNHAN.NTP_BN_BENHNHANController
                Matinh = Request.QueryString("Matinh")
                MaHuyen = Request.QueryString("MaHuyen")
                Tungay = Request.QueryString("Tungay")
                Denngay = Request.QueryString("Denngay")
                DK = Request.QueryString("Dieukien")
                ds = obj.In_DANHSACHBNDIEUTRI(Matinh, MaHuyen, Tungay, Denngay, 0, DK)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_DSBENHNHANDIEUTRI.rpt"
            End If
            rpt.Load(sPath)
           
                rpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = rpt
                Me.CrystalReportViewer1.DataBind()
ds=nothing

                Opt = 0
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub

End Class
