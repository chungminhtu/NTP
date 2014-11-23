
Partial Class QLT_BAOCAO_TONGHOP_KIEMKE
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet

        Dim obj As New NTP_QLT.QLT_KY_KIEMKE_BO
        Dim ID_KHO As Integer
        Dim ID_KY_KIEMKE As Integer

        ID_KHO = Request.QueryString("ID_KHO")
        ID_KY_KIEMKE = Request.QueryString("ID_KY_KIEMKE")

        ds = obj.BaoCaoKiemKe(ID_KHO, ID_KY_KIEMKE)
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim sPath As String
        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BaoCao_TongHopKiemKe.rpt"
        rpt.Load(sPath)
        rpt.SetDataSource(ds.Tables(0))
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

    End Sub
End Class
