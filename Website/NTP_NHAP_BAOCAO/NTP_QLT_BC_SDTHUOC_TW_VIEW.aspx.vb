Imports CrystalDecisions.CrystalReports.Engine

Public Class NTP_QLT_BC_SDTHUOC_TW_VIEW
    Inherits System.Web.UI.Page

    Dim rpt As New ReportDocument

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dsSub As New DataSet

        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
        Dim ID_KHO As Integer
        Dim ID_KY As Int16
        Dim NAM As Int16

        If Me.Page.User.Identity.IsAuthenticated = False Then
            Response.Write("Not authenticated")
            Exit Sub
        End If

        Me.Title = "Bao cao su dung thuoc tw"

        ID_KHO = Request.QueryString("ID_KHO")
        NAM = Request.QueryString("NAM")
        ID_KY = Request.QueryString("ID_KY")

        ds = obj.BC_SUDUNGTHUOC_TW(ID_KHO, ID_KY, NAM)


        Dim sPath As String
        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\QLT_BaoCao_SuDungThuoc_TW.rpt"
        rpt.Load(sPath)

        rpt.SetDataSource(ds.Tables(0))

        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

      
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        'Clear
        rpt.Dispose()
        rpt.Close()
    End Sub
End Class
