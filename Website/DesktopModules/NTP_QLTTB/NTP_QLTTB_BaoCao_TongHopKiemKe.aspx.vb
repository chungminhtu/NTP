Imports CrystalDecisions.CrystalReports.Engine

Public Class NTP_QLTTB_BaoCao_TongHopKiemKe
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet

        Dim obj As New NTP_QLTTB.NTP_QLTTB_KHOASO_BO
        Dim ID_KHO As Integer
        Dim ID_KY_KIEMKE As Integer

        ID_KHO = Request.QueryString("ID_KHO")
        ID_KY_KIEMKE = Request.QueryString("ID_KY_KIEMKE")

        ds = obj.BaoCaoKiemKe(ID_KHO, ID_KY_KIEMKE)
        Dim rpt As New ReportDocument
        Dim sPath As String
        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\QLTTB_BangTongHopKiemKe.rpt"
        rpt.Load(sPath)
        rpt.SetDataSource(ds.Tables(0))
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

    End Sub
End Class
