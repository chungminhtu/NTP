Imports NTP_Common.mdlGlobal
Partial Class QLT_BAOCAO_SUDUNGTHUOC_TuyenHuyen
    Inherits System.Web.UI.Page




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dsSub As New DataSet

        Dim obj As New NTP_QLT.QLT_KY_KIEMKE_BO
        Dim Nam As Integer
        Dim Quy As Integer
        Dim id_kho As Integer

        Nam = Request.QueryString("Nam")
        Quy = Request.QueryString("Quy")
        id_kho = Request.QueryString("ID_KHO")

        ds = obj.BaoCaoSuDungThuoc_TuyenHuyen(Quy, Nam, id_kho)

        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim sPath As String
        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BaoCao_SuDungThuoc_TuyenHuyen.rpt"
        rpt.Load(sPath)
        rpt.SetDataSource(ds.Tables(0))


        'dsSub = obj.BaoCaoSuDungThuoc_Sub(Thang, Nam, id_kho)
        'Dim rptSub As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptSub = rpt.Subreports("BaoCao_SuDungThuoc_Huyen.rpt")
        'rptSub.SetDataSource(dsSub.Tables(0))

        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()
        Me.CrystalReportViewer1.DisplayGroupTree = False
    End Sub
End Class
