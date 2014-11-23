Imports CrystalDecisions.CrystalReports.Engine

Public Class BAOCAO_SO_THEODOI_VT
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet

        Dim obj As New NTP_QLVT.NTP_QLVT_KY_KIEMKE_BO
        Dim ID_KHO As Integer
        Dim dtDateFrom As Date
        Dim dtDateTo As Date
        Dim ID_VATTU As Integer

        Me.Title = "So theo doi vat tu"

        ID_KHO = Request.QueryString("ID_KHO")
        dtDateFrom = Request.QueryString("DATEFROM")
        dtDateTo = Request.QueryString("DATETO")
        ID_VATTU = Request.QueryString("ID_VATTU")

        ds = obj.SO_THEODOI_VATTU(ID_KHO, dtDateFrom, dtDateTo, ID_VATTU)

        Dim rpt As New ReportDocument
        Dim sPath As String
        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\SoTheodoi_VT.rpt"
        rpt.Load(sPath)

        rpt.SetDataSource(ds.Tables(0))

        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

    End Sub
End Class
