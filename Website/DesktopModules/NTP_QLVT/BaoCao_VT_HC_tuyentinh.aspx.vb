Imports CrystalDecisions.CrystalReports.Engine

Public Class BaoCao_VT_HC_tuyentinh
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dsHC As New DataSet
        Dim dsVT As New DataSet

        Dim obj As New NTP_QLVT.NTP_QLVT_KY_KIEMKE_BO
        Dim ID_KHO As Integer
        Dim ID_KY_KIEMKE As Integer

        Me.Title = "Bao cao vat tu, hoa chat tuyen tinh"

        ID_KHO = Request.QueryString("ID_KHO")
        ID_KY_KIEMKE = Request.QueryString("ID_KY_KIEMKE")

        ds = obj.BaoCaoHC_VT_Main_tuyentinh(ID_KHO, ID_KY_KIEMKE)
        dsVT = obj.BaoCaoVattu_tuyentinh(ID_KHO, ID_KY_KIEMKE)
        dsHC = obj.BaoCaoHoaChat_tuyentinh(ID_KHO, ID_KY_KIEMKE)

        Dim rpt As New ReportDocument
        Dim sPath As String
        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BaoCaoVattu_HoaChat_tuyentinh.rpt"
        rpt.Load(sPath)

        Dim rptHC As New ReportDocument
        rptHC = rpt.Subreports("BaoCaoHoaChat_tuyentinh.rpt")

        Dim rptVT As New ReportDocument
        rptVT = rpt.Subreports("BaoCaoVattu_tuyentinh.rpt")

        rpt.SetDataSource(ds.Tables(0))
        rptVT.SetDataSource(dsVT.Tables(0))
        rptHC.SetDataSource(dsHC.Tables(0))

        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

    End Sub
End Class
