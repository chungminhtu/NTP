Imports CrystalDecisions.CrystalReports.Engine

Partial Class Report_form_BaocaoKiemDinh
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
            Dim subDS1 As New DataSet
            Dim subDS2 As New DataSet

            Dim obj As New YourCompany.Modules.NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
            Dim objKD As New YourCompany.Modules.NTP_KD_BC_KIEMDINHTB.NTP_KD_BC_KIEMDINHTBController
            Dim objPhieuLM As New YourCompany.Modules.NTP_KD_PLAYMAU.NTP_KD_PLAYMAUController
            Dim Tinh As String
            Dim Mien As Integer
            Dim Vung As Integer
            Dim Nam As Integer
            Dim Quy As String
            Dim Opt As String
            Dim Kieuin As Integer
            Dim Dieukien As String
            Dieukien = ""
            Dim Myformulas As FormulaFieldDefinitions
            Me.Title = "Bao cao Hoat dong XN"
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

            Opt = Trim(Request.QueryString("Opt"))
            ' Response.Write("mien=" & Mien)

            Quy = Request.QueryString("Quy")
            Kieuin = Request.QueryString("Kieuin")
            Dieukien = Request.QueryString("Dieukien")

            Select Case Opt
                Case 1, 2, 3
                    ds = obj.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, Opt, Dieukien)
                Case 4
                    ds = objKD.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 1, Dieukien)
                Case 5
                    ds = objKD.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 2, Dieukien)
                Case 55
                    ds = objKD.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 3, Dieukien)
                Case 66
                    ds = objKD.ListBaoCao(Tinh, Mien, Vung, Nam, Quy, 4, Dieukien)
                Case 6
                    ds = objKD.InPhieuPhanhoiKQKD(Mien, Nam, Tinh, 1, Dieukien)
                    subDS1 = objKD.InPhieuPhanhoiKQKD(Mien, Nam, Tinh, 2, Dieukien)
                    subDS2 = objKD.InPhieuPhanhoiKQKD(Mien, Nam, Tinh, 3, Dieukien)
                Case 7, 8 ' In phieu lay mau
                    ds = objPhieuLM.IN_PHIEULAYMAU(Mien, Nam, Tinh)
                Case 9
                    ds = objPhieuLM.IN_PHIEULAYMAU_KQKDLAN2(Mien, Nam, Tinh)
                Case 11
                    ds = obj.NTP_KD_BCHOATDONGXETNGHIEMBYHUYEN_IN(Tinh, Mien, Vung, Nam, Quy, Opt, Dieukien)
                Case 44
                    ds = objKD.NTP_KD_BCTHUDOMPHBYHUYEN_IN(Tinh, Mien, Vung, Nam, Quy, Dieukien)

            End Select

            Dim sPath As String
            If Opt = 1 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_SOTIEUBANKIEMDINH.rpt"
            ElseIf Opt = 2 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_THUDOMPHATHIEN.rpt"
            ElseIf Opt = 3 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_XETNGHIEMPHATHIENCOHTEST.rpt"
            ElseIf Opt = 4 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_PHANLOAILOIVATYLELOI.rpt"
            ElseIf Opt = 5 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_CHATLUONGTIEUBAN.rpt"
            ElseIf Opt = 6 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_PHIEUPHANHOI_KDTB.rpt"
            ElseIf Opt = 7 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_PHIEULAYMAU_KDTB.rpt"
            ElseIf Opt = 8 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_PHIEULAYMAU_KQKD1.rpt"
            ElseIf Opt = 9 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_PHIEULAYMAU_KQKD2.rpt"
            ElseIf Opt = 11 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_SOTIEUBANKIEMDINHBYHUYEN.rpt"
            ElseIf Opt = 44 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_THUDOMPHATHIENBYHUYEN.rpt"
            ElseIf Opt = 55 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_PHANLOAILOIVATYLELOIBYHUYEN.rpt"
            ElseIf Opt = 66 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\KD_CHATLUONGTIEUBANBYHUYEN.rpt"

            End If
            rpt.Load(sPath)
            If Opt = 6 Then
                Dim rptP2 As New ReportDocument
                'Dim Formular As FormulaFieldDefinitions
                rptP2 = rpt.Subreports("KD_PHIEUPHANHOI_KDTB_P1.rpt")
                Dim rptP3 As New ReportDocument
                rptP3 = rpt.Subreports("KD_PHIEUPHANHOI_KDTB_P2.rpt")
                Myformulas = rpt.DataDefinition.FormulaFields
                Myformulas.Item("Quy").Text = "'" & Quy & "'"
                Myformulas.Item("Nam").Text = "'" & Nam & "'"

                rptP2.SetDataSource(subDS1.Tables(0))
                rptP3.SetDataSource(subDS2.Tables(0))
                rpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = rpt
                Me.CrystalReportViewer1.DataBind()
            ElseIf Opt = 7 Or Opt = 8 Or Opt = 9 Then ' In phieu lay mau va KQKD
                Myformulas = rpt.DataDefinition.FormulaFields
                Myformulas.Item("Quy").Text = "'" & Quy & "'"
                Myformulas.Item("Nam").Text = "'" & Nam & "'"
                Myformulas.Item("Thang").Text = "'" & Mien & "'"
                rpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = rpt
                Me.CrystalReportViewer1.DataBind()
            Else
                Myformulas = rpt.DataDefinition.FormulaFields
                Myformulas.Item("Quy").Text = "'" & Quy & "'"
                Myformulas.Item("Nam").Text = "'" & Nam & "'"
                Myformulas.Item("Groupby").Text = Kieuin
                rpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = rpt
                Me.CrystalReportViewer1.DataBind()
            End If
		ds=nothing
		obj =nothing
            ' objKD =nothing
            'objPhieuLM=nothing
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
            Response.Write(ex.ToString)
        Finally

        End Try
    End Sub

End Class
