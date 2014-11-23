Imports CrystalDecisions.CrystalReports.Engine
Partial Class Report_form_ThuNhanBNLao
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument
   Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rpt.Dispose()
        rpt.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Dim ds As New DataSet

            Dim obj As New YourCompany.Modules.NTP_BN_BC_THUNHANBNLAO.NTP_BN_BCTHUNHANBNLAOINController
            Dim Myformulas As FormulaFieldDefinitions
            Dim Tinh As String
            Dim Mien As Integer
            Dim Vung As Integer
            Dim Nam As Integer
            Dim Quy As String
            Dim Loaibc As Integer
            Dim Opt As Integer
            Dim Kieuin As Integer
            Dim Dieukien As String
            Dieukien = ""
            Me.Title = "Tinh hinh thu nhan BN Lao"
            Loaibc = Request.QueryString("PhanloaiBC")
            If Request.QueryString("ID_Tinh") = "" Then
                Tinh = "ALL"
            Else
                Tinh = Request.QueryString("ID_Tinh")
            End If
            'Response.Write(Request.QueryString("ID_Tinh"))
            If Request.QueryString("ID_Mien") = "" Then
                Mien = 0
            Else
                Mien = Request.QueryString("ID_Mien")
            End If
            If Request.QueryString("ID_Vung") = "" Then
                Vung = 0
            Else
                Vung = Request.QueryString("ID_Vung")
            End If
            Nam = Request.QueryString("Nam")
            Quy = Request.QueryString("Quy")
            Opt = Request.QueryString("Opt")
            Dieukien = Request.QueryString("Dieukien")

            Kieuin = Request.QueryString("Kieuin")
            Select Case Opt
                Case 1, 2, 3, 4
                    ds = obj.ListBaoCaoNTP_BN_BCTHUNHANBNLAO_IN(Loaibc, Tinh, Mien, Vung, Nam, Quy, Dieukien)
                Case 5, 6
                    ds = obj.ListBaoCaoTuoiGioi(Tinh, Mien, Vung, Nam, Quy, Loaibc)
                Case 7
                    ds = obj.ListBaoCaoNgoaiLaoPhoi(Tinh, Mien, Vung, Nam, Quy)
                Case 8
                    ds = obj.ListBaoCaoNTP_BN_BCTHUNHANBNLAOBYHUYEN_IN(Loaibc, Tinh, Mien, Vung, Nam, Quy, Dieukien)
                Case 9,10
                    ds = obj.ListBaoCaoNTP_BN_BCTHUNHANBNLAOBY_TREEM(Loaibc, Tinh, Mien, Vung, Nam, Quy, Dieukien)

            End Select

            Dim sPath As String
            If Opt = 1 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_TinhhinhThunhanBNLao.rpt"
            ElseIf Opt = 2 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_TinhhinhThunhanBNLaotheoTinhQuy.rpt"
            ElseIf Opt = 3 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_ThunhanBNLaoAFB(+)MoitheoHuyenQuy.rpt "
            ElseIf Opt = 4 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_ThunhanBNLaotheoHuyen.rpt"
            ElseIf Opt = 5 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_ThunhanLaoPhoiAFB(+)MoiTheotuoivagioi.rpt"
            ElseIf Opt = 6 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_ThunhanLaoPhoiAFB(+)MoiHIV(+)MoiTheotuoivagioi.rpt"
            ElseIf Opt = 7 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_ThuNhanBNLaoAFB(-)MoivaLNP.rpt"
            ElseIf Opt = 8 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_TinhhinhThunhanBNLaoBYHUYEN.rpt"
            ElseIf Opt = 9 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_ThunhanBNLaotheoTreem.rpt"
            ElseIf Opt = 10 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_ThunhanBNLaotheoTreemBYTINH.rpt"

            End If

            rpt.Load(sPath)
            Myformulas = rpt.DataDefinition.FormulaFields
            Myformulas.Item("Quy").Text = "'" & Quy & "'"
            Myformulas.Item("Nam").Text = "'" & Nam & "'"
            If Opt = 1 Or Opt = 5 Or Opt = 6 Or Opt = 7 Or Opt = 8 Then
                Myformulas.Item("Groupby").Text = Kieuin
            End If
            rpt.SetDataSource(ds.Tables(0))
            Me.CrystalReportViewer1.ReportSource = rpt
            '   Me.CrystalReportViewer1
            Me.CrystalReportViewer1.DataBind()
	ds=nothing
	'obj=nothing
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
            Response.Write(ex.ToString)
        Finally

        End Try
    End Sub
End Class
