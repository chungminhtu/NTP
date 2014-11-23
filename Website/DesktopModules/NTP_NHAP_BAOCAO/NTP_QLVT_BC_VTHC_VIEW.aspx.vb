Imports CrystalDecisions.CrystalReports.Engine

Public Class NTP_QLVT_BC_VTHC_VIEW
    Inherits System.Web.UI.Page

    Dim rpt As New ReportDocument
    Dim rptHC As New ReportDocument
    Dim rptSub As New ReportDocument


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dsHC As New DataSet
        Dim dsVT As New DataSet

        Dim obj As New NTP_QLVT.NTP_CU_VATTUHOACHAT_BO
        Dim ID_KHO As Integer
        Dim ID_BAOCAO As Integer

        If Me.Page.User.Identity.IsAuthenticated = False Then
            Response.Write("Not authenticated")
            Exit Sub
        End If

        Me.Title = "Bao cao vat tu, hoa chat tuyen tinh"

        ID_KHO = Request.QueryString("ID_KHO")
        ID_BAOCAO = Request.QueryString("ID_BC")
        Dim iVT As Integer
        iVT = Request.QueryString("VT")

        If iVT = 1 Then
            ds = obj.BaoCao_SUDUNGVATTU(ID_KHO, ID_BAOCAO)
            dsVT = obj.BaoCao_SUDUNGVATTU_SUB(ID_KHO, ID_BAOCAO)


            Dim sPath As String
            sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\QLVT_BC_SUDUNG_TINH.rpt"

            rpt.Load(sPath)

            rptSub = rpt.Subreports("QLVT_BC_SUDUNG_TINH_SUB.rpt")

            rptSub.SetDataSource(dsVT.Tables(0))
            rpt.SetDataSource(ds.Tables(0))

          
        Else
            ds = obj.BaoCaoHC_VT_Main_tuyentinh(ID_KHO, ID_BAOCAO)
            'dsVT = obj.BaoCaoVattu_tuyentinh(ID_KHO, ID_BAOCAO)
            dsHC = obj.BaoCaoHoaChat_tuyentinh(ID_KHO, ID_BAOCAO)

            Dim sPath As String
            sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\QLVT_BaoCaoVattu_HoaChat_tuyentinh.rpt"
            rpt.Load(sPath)

            rptHC = rpt.Subreports("BaoCaoHoaChat_tuyentinh.rpt")

            ' Dim rptVT As New ReportDocument
            ' rptVT = rpt.Subreports("BaoCaoVattu_tuyentinh.rpt")

            rpt.SetDataSource(ds.Tables(0))
            'rptVT.SetDataSource(dsVT.Tables(0))
            rptHC.SetDataSource(dsHC.Tables(0))
        End If
       

        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

        rptSub.Dispose()
        rptSub.Close()

        rptHC.Dispose()
        rptHC.Close()

        rpt.Dispose()
        rpt.Close()
    End Sub
End Class
