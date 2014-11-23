Imports CrystalDecisions.CrystalReports.Engine

Partial Class DesktopModules_NTP_BN_BC_KETQUADT_BaoCao
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument
    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        rpt.Dispose()
        rpt.Close()
    End Sub
   Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rpt.Dispose()
        rpt.Close()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim ds As New DataSet
            Dim obj As New YourCompany.Modules.NTP_BN_BC_KETQUADT.NTP_BN_BCKETQUADIEUTRILAOINController
            Dim objTK As New YourCompany.Modules.NTP_BN_TINHHINHTRIENKHAI_CTCL.NTP_BN_TINHHINHTRIENKHAI_CTCLController
            Dim Tinh As String
            Dim Mien As Integer
            Dim Vung As Integer
            Dim Nam As Integer
            Dim Quy As String
            Dim Opt As Integer
            Dim Kieuin As Integer
            Dim Dieukien As String
            Dieukien = ""
            Dim Myformulas As FormulaFieldDefinitions
            Opt = Request.QueryString("Opt")

            If Opt = 0 Then Exit Sub
            Me.Title = "Bao cao thong ke"
            Kieuin = Request.QueryString("Kieuin")
            If Opt = 7 Then
                Nam = Request.QueryString("Nam")
            Else
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
                Quy = Request.QueryString("Quy")

                Dieukien = Request.QueryString("Dieukien")
            End If
            If Opt = 7 Then
                ds = objTK.ListBaoCao(Nam)
            ElseIf Opt = 1 Then
                ds = obj.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 1, Dieukien)
                'ds = obj.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 1)
            ElseIf Opt = 2 Then
                ds = obj.ListBaoCaoKQDTCacthe(Tinh, Mien, Vung, Nam, Quy)
            ElseIf Opt = 3 Then
                ds = obj.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 2, Dieukien)
            ElseIf Opt = 4 Then
                ds = obj.BCKETQUADIEUTRILAOBYHUYEN(Tinh, Mien, Vung, Nam, Quy, 2, Dieukien)
            End If

            Dim sPath As String
            If Opt = 7 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_TINHHINHTRIENKHAI_CTCL.rpt"
            ElseIf Opt = 1 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUADIEUTRILAO.rpt"
            ElseIf Opt = 2 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUADIEUTRILAOCACTHE.rpt"
            ElseIf Opt = 3 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_BCHOATDONGPHOIHOPDIEUTRI.rpt"
            ElseIf Opt = 4 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUADIEUTRILAOBYHUYEN.rpt"

            End If
            rpt.Load(sPath)
            Myformulas = rpt.DataDefinition.FormulaFields
            If Opt = 7 Then
                Myformulas.Item("Nam").Text = "'" & Nam & "'"
                Myformulas.Item("Groupby").Text = Kieuin
            Else
                Myformulas.Item("Quy").Text = "'" & Quy & "'"
                Myformulas.Item("Nam").Text = "'" & Nam & "'"
                Myformulas.Item("Groupby").Text = Kieuin
            End If
            rpt.SetDataSource(ds.Tables(0))
            Me.CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.DataBind()
            Opt = 0
ds=nothing
obj =nothing
objTK =nothing
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub

End Class
