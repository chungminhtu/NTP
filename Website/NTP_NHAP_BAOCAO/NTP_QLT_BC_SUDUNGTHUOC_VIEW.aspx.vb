Imports CrystalDecisions.CrystalReports.Engine

Public Class NTP_QLT_BC_SUDUNGTHUOC_VIEW
    Inherits System.Web.UI.Page

    Dim rpt As New ReportDocument
    Dim rptSub As New ReportDocument

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dsSub As New DataSet

        Dim obj As New NTP_QLT.NTP_CU_SUDUNGTHUOC_BO
        Dim ID_KHO As Integer
        Dim ID_BAOCAO As Int64

        If Me.Page.User.Identity.IsAuthenticated = False Then
            Response.Write("Not authenticated")
            Exit Sub
        End If

        Me.Title = "Bao cao su dung thuoc"

        ID_KHO = Request.QueryString("ID_KHO")
        ID_BAOCAO = Request.QueryString("ID_BC")

        'Kiem tra cấp kho
        '
        Dim objBV As New NTP_DANHMUC.NTP_DM_BENHVIEN_Info
        objBV = (New NTP_DANHMUC.NTP_DM_BENHVIEN_BO).SelectItem(ID_KHO)

        Dim sPath As String

        If objBV.ID_CAP = 1 Then
            'Cap mien
            ds = obj.BC_SUDUNGTHUOC(ID_KHO, ID_BAOCAO, 2)
            dsSub = obj.BC_SUDUNGTHUOC(ID_KHO, ID_BAOCAO, 0)

            ds.Tables(0).TableName = "Main"
            dsSub.Tables(0).TableName = "Sub"

           
            sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\QLT_BaoCao_SuDungThuoc_Mien.rpt"
            rpt.Load(sPath)

            'Dim rptSub As New ReportDocument
            'rptSub = rpt.Subreports("BaoCao_SuDungThuoc_Huyen.rpt")

            'rptSub.SetDataSource(dsSub.Tables(0))
            rpt.SetDataSource(ds.Tables(0))
        ElseIf objBV.ID_CAP = 2 Then
            'Cap tinh 
            ds = obj.BC_SUDUNGTHUOC(ID_KHO, ID_BAOCAO, 1)
            dsSub = obj.BC_SUDUNGTHUOC(ID_KHO, ID_BAOCAO, 0)

            ds.Tables(0).TableName = "Main"
            dsSub.Tables(0).TableName = "Sub"

            sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\QLT_BaoCao_SuDungThuoc_Tinh.rpt"
            rpt.Load(sPath)


            rptSub = rpt.Subreports("BaoCao_SuDungThuoc_Huyen.rpt")

            rptSub.SetDataSource(dsSub.Tables(0))
            rpt.SetDataSource(ds.Tables(0))
        End If

        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

        'Clear
        'rpt.Dispose()
        'rptSub.Dispose()
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rptSub.Dispose()
        rpt.Dispose()

        rptSub.Close()
        rpt.Close()
    End Sub
End Class
