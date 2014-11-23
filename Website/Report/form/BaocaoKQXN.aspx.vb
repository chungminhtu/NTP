Imports CrystalDecisions.CrystalReports.Engine

Partial Class Report_form_BaocaoKQXN
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument
    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        rpt.Close()
        rpt.Dispose()
    End Sub
  Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rpt.Dispose()
        rpt.Close()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim ds As New DataSet

            Dim obj As New YourCompany.Modules.NTP_BN_BC_KETQUAXN.NTP_BN_BC_KETQUAXNController
            Dim Tinh As String
            Dim Mien As Integer
            Dim Vung As Integer
            Dim Nam As Integer
            Dim Quy As String
            Dim Kieuin As Integer
            Dim Opt As Integer
            Dim Myformulas As FormulaFieldDefinitions
	   Dim Dieukien As String
            Dieukien = ""
            Opt = Request.QueryString("Opt")

            Me.Title = "Bao cao Ket qua Am hoa dom"
            If Request.QueryString("Tinh") = "" Then
                Tinh = "ALL"
            Else
                Tinh = Request.QueryString("Tinh")
            End If
            If Request.QueryString("Mien") = "" Then
                Mien = 0
            Else
                Mien = Request.QueryString("Mien")
            End If
            If Request.QueryString("Vung") = "" Then
                Vung = 0
            Else
                Vung = Request.QueryString("Vung")
            End If
            Nam = Request.QueryString("Nam")
'response.write (Request.QueryString("Kieuin"))
             Kieuin = Request.QueryString("Kieuin")
            Quy = Request.QueryString("Quy")
 	    Dieukien = Request.QueryString("Dieukien")
            Dim sPath As String
            If Opt = 1 Then
                ds = obj.ListBaoCao(Tinh, Mien, Vung, Nam, Quy,Dieukien)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUAAMHOADOM.rpt"
            Else
                ds = obj.NTP_BN_BCKETQUAAMHOADOMBYHUYEN_IN(Tinh, Mien, Vung, Nam, Quy,Dieukien)
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUAAMHOADOMBYHUYEN.rpt"
            End If
            rpt.Load(sPath)
            Myformulas = rpt.DataDefinition.FormulaFields
            Myformulas.Item("Quy").Text = "'" & Quy & "'"
            Myformulas.Item("Nam").Text = "'" & Nam & "'"
            Myformulas.Item("Groupby").Text = Kieuin
            rpt.SetDataSource(ds.Tables(0))
            Me.CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.DataBind()
ds=nothing
'obj =nothing
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub

End Class
