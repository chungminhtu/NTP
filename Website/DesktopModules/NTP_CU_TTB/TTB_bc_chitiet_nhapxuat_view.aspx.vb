Imports CrystalDecisions.CrystalReports.Engine

Public Class TTB_bc_chitiet_nhapxuat_view
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dsHC As New DataSet
        Dim dsVT As New DataSet

        Dim obj As New NTP_QLTTB.NTP_CU_TTB_KHO_BO
        Dim ID_KHO As Integer
        Dim id_loaiky As Integer
        Dim ky As Integer
        Dim nam As Integer
        Dim id_nguonkp As Integer
        Dim id_thuoc As Integer

        If Me.Page.User.Identity.IsAuthenticated = False Then
            Response.Write("Not authenticated")
            Exit Sub
        End If

        Me.Title = "Bao cao chi tiet nhap xuat"

        ID_KHO = Request.QueryString("ID_KHO")
        'id_loaiky = Request.QueryString("loaiky")
        ky = Request.QueryString("thang")
        nam = Request.QueryString("nam")
        id_nguonkp = Request.QueryString("id_nguonkp")
        id_thuoc = Request.QueryString("ID_thietbi")

        ds = obj.BaoCao_chitiet_nhapxuat(ID_KHO, ky, nam, id_nguonkp, id_thuoc)

        'Dim dsXuat As New DataSet
        'dsXuat = obj.BaoCao_TH_NhapXuat_Xuat(ID_KHO, ky, id_loaiky, nam, id_nguonkp, id_thuoc)



        Dim sPath As String

        sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\cu_ttb_bc_chitiet_nhapxuat.rpt"
        rpt.Load(sPath)

        'Dim rptXuat As New ReportDocument
        'rptXuat = rpt.Subreports("cu_thuoc_bc_sudungthuoc_xuat.rpt")

        'rptXuat.SetDataSource(dsXuat.Tables(0))

        rpt.SetDataSource(ds.Tables(0))

        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.DataBind()

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rpt.Dispose()
        rpt.Close()
    End Sub
End Class
