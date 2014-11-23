Imports NTP_Common.mdlGlobal
Partial Class QLT_BAOCAO_THUOC_NHAPXUAT_rpt
    Inherits System.Web.UI.Page




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet

        Dim obj As New NTP_QLT.QLT_KY_KIEMKE_BO
        Dim Nam As Integer
        Dim Thang As Integer
        Dim id_kho As Integer
        Nam = Request.QueryString("Nam")
        Thang = Request.QueryString("Thang")
        id_kho = Request.QueryString("ID_KHO")
        ds = obj.BaoCaoNhapXuat(Thang, Nam, id_kho)
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim sPath As String
        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BaoCao_TongHopNhapXuat.rpt"
        rpt.Load(sPath)
        rpt.SetDataSource(ds.Tables(0))
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()
        Me.CrystalReportViewer1.DisplayGroupTree = False
    End Sub
End Class
