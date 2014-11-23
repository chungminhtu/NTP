Imports CrystalDecisions.CrystalReports.Engine

Public Class NTP_TTB_BC_TTB_VIEW
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dsHC As New DataSet
        Dim dsVT As New DataSet

        Dim obj As New NTP_QLTTB.NTP_CU_THIETBI_BO

        Dim ID_KHO As Integer
        Dim ID_BAOCAO As Integer

        Try
            If Me.Page.User.Identity.IsAuthenticated = False Then
                Response.Write("Not authenticated")
                Exit Sub
            End If

            Me.Title = "Bao cao trang thiet bi tuyen tinh"

            ID_KHO = Request.QueryString("ID_KHO")
            ID_BAOCAO = Request.QueryString("ID_BC")

            ds = obj.BaoCao_SudungTTB(ID_KHO, ID_BAOCAO)
            Dim dsSub As New DataSet
            dsSub = obj.BaoCao_SudungTTB_Sub(ID_KHO, ID_BAOCAO)


            Dim sPath As String
            sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\QLTB_BC_SUDUNG_TINH.rpt"
            rpt.Load(sPath)

            Dim rptSub As New ReportDocument
            rptSub = rpt.OpenSubreport("QLTB_BC_SUDUNG_TINH_SUB.rpt")

            rptSub.SetDataSource(dsSub.Tables(0))
            rpt.SetDataSource(ds.Tables(0))

            Me.CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.DataBind()
        Catch ex As Exception
            Response.Write(ex.ToString)
        Finally
            'rpt.Dispose()
            'rpt.Close()
        End Try
      

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rpt.Dispose()
        rpt.Close()
    End Sub
End Class
