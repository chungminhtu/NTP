Imports CrystalDecisions.CrystalReports.Engine

Partial Class Report_form_BaocaoTinh
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
            Dim dsP2 As New DataSet
            Dim dsP3 As New DataSet
            Dim dsP1 As New DataSet
            Dim obj As New YourCompany.Modules.NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHController
            Dim objKD As New YourCompany.Modules.NTP_KD_BAOCAOTUYENTINH.NTP_KD_BAOCAOTUYENTINHController
            Dim Tinh As String
            Dim DVBaocao As String

            Dim Nam As Integer
            Dim Quy As String
            Dim Opt As Integer
            Dim Tentinh As String
            Dim sNguoibc As String
            Dim sNgaybc As String
            Dim Capin As Integer
            Dim Myformulas As FormulaFieldDefinitions

            Me.Title = "Bao cao Thong ke tuyen Tinh"
            If Request.QueryString("Tinh") = "" Then
                Tinh = "ALL"
            Else
                Tinh = Request.QueryString("Tinh")
            End If

            If Trim(Request.QueryString("DVBaocao")) = "" Then
                DVBaocao = "ALL"
            Else
                DVBaocao = Request.QueryString("DVBaocao")
            End If
           
            If Request.QueryString("Tentinh") = "" Then
                Tentinh = ""
            Else
                Tentinh = Request.QueryString("Tentinh")
            End If
            Nam = Request.QueryString("Nam")
            If Request.QueryString("Quy") = "" Then
                Quy = 0
            Else
                Quy = Request.QueryString("Quy")
            End If
            Opt = Request.QueryString("Opt")
            sNguoibc = Request.QueryString("Nguoibc")
            sNgaybc = Request.QueryString("Ngaybc")

            If Opt = 1 Then

                ds = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 0, DVBaocao)
            ElseIf Opt = 2 Then
                ds = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 1, DVBaocao)
                dsP2 = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 1, DVBaocao)
                dsP3 = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 1, DVBaocao)
            ElseIf Opt = 3 Then
                ds = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 2, DVBaocao)
            ElseIf Opt = 4 Then
                ds = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 3, DVBaocao)
                dsP2 = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 3, DVBaocao)
                dsP3 = obj.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 3, DVBaocao)
            ElseIf Opt = 5 Then
                ds = objKD.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 0, DVBaocao)
                dsP2 = objKD.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 0, DVBaocao)
            ElseIf Opt = 6 Then
		 Capin= Request.QueryString("capin")
		if capin=1 then
	                ds = objKD.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 1, DVBaocao)
        	        dsP2 = objKD.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 1, DVBaocao)
		else
	                ds = objKD.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 2, DVBaocao)
        	        dsP2 = objKD.ListBaoCaoTuyenTinh(Tinh, Nam, Quy, 2, DVBaocao)
		end if
            End If

            Dim sPath As String
            If Opt = 1 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_THUNHANBNLAO_TINH.rpt"
            ElseIf Opt = 2 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUADIEUTRILAO_TINH.rpt"
            ElseIf Opt = 3 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUAAMHOADOM_TINH.rpt"
            ElseIf Opt = 4 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_CHUONGTRINHCHONGLAO_TINH.rpt"
                ' Kiem dinh TB
            ElseIf Opt = 5 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_HOATDONGXN_TINH.rpt"
            ElseIf Opt = 6 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KIEMDINHTB_TINH.rpt"
            End If

                rpt.Load(sPath)
                If Opt = 1 Or Opt = 3 Then
                    Myformulas = rpt.DataDefinition.FormulaFields
                    If Opt <> 3 Then
                        Myformulas.Item("Quy").Text = "'" & Quy & "'"
                        Myformulas.Item("Nam").Text = "'" & Nam & "'"
                    Else
                        If Len(Quy) = 1 Then
                            Myformulas.Item("Quy").Text = "'" & IIf(Quy = 1, 4, Quy - 1) & "'"
                            Myformulas.Item("Nam").Text = "'" & IIf(Quy = 1, Nam - 1, Nam) & "'"
                        Else
                            Myformulas.Item("Quy").Text = "'" & Quy & "'"
                            Myformulas.Item("Nam").Text = "'" & Nam & "'"
                        End If
                    End If
                    ' Myformulas.Item("Tinh").Text = "'" & Tentinh & "'"
                    Myformulas.Item("Nguoibc").Text = "'" & UCase(sNguoibc) & "'"
                    Myformulas.Item("Ngaybc").Text = "'" & sNgaybc & "'"
                    rpt.SetDataSource(ds.Tables(0))
                ElseIf Opt = 2 Then
                    Dim rptP2 As New ReportDocument
                    Dim Formular As FormulaFieldDefinitions
                    rptP2 = rpt.Subreports("BN_KETQUADIEUTRILAO_TINHP2.rpt")
                    Dim rptP3 As New ReportDocument
                    rptP3 = rpt.Subreports("BN_KETQUADIEUTRILAO_TINHP3.rpt")
                    Myformulas = rpt.DataDefinition.FormulaFields
                    Formular = rptP3.DataDefinition.FormulaFields
                    Myformulas.Item("Quy").Text = "'" & Quy & "'"
                    Myformulas.Item("Nam").Text = "'" & Nam & "'"
                    'Myformulas.Item("Tinh").Text = "'" & Tentinh & "'"
                    Myformulas.Item("Nguoibc").Text = "'" & UCase(sNguoibc) & "'"
                    Myformulas.Item("Ngaybc").Text = "'" & UCase(sNguoibc) & "'"
                    rptP2.SetDataSource(dsP2.Tables(0))
                    rptP3.SetDataSource(dsP3.Tables(0))
                    rpt.SetDataSource(ds.Tables(0))

            ElseIf Opt = 4 Then
                Dim rptP22 As New ReportDocument
                rptP22 = rpt.Subreports("BN_CHUONGTRINHCHONGLAO_TINHP2.rpt")
                Dim rptP33 As New ReportDocument
                rptP33 = rpt.Subreports("BN_CHUONGTRINHCHONGLAO_TINHP3.rpt")
                Myformulas = rpt.DataDefinition.FormulaFields
                'Myformulas.Item("Quy").Text = "'" & Quy & "'"
                Myformulas.Item("Nam").Text = "'" & Nam & "'"
                'Myformulas.Item("Tinh").Text = "'" & Tentinh & "'"
                Myformulas.Item("Nguoibc").Text = "'" & sNguoibc & "'"
                rptP22.SetDataSource(dsP2.Tables(0))
                rptP33.SetDataSource(dsP3.Tables(0))

                rpt.SetDataSource(ds.Tables(0))
            ElseIf Opt = 5 Or Opt = 6 Then
                Dim rptP2 As New ReportDocument
                If Opt = 5 Then
                    rptP2 = rpt.Subreports("BN_HOATDONGXN_TINHP2.rpt")
                    Myformulas = rpt.DataDefinition.FormulaFields
                    Myformulas.Item("Quy").Text = "'" & Quy & "'"
                    Myformulas.Item("Nam").Text = "'" & Nam & "'"
                    'Myformulas.Item("Tinh").Text = "'" & UCase(Tentinh) & "'"
                Else
                    rptP2 = rpt.Subreports("BN_KIEMDINHTB_TINHP2.rpt")
                    Myformulas = rpt.DataDefinition.FormulaFields
                    Myformulas.Item("Quy").Text = "'" & Quy & "'"
                    Myformulas.Item("Nam").Text = "'" & Nam & "'"
                    Myformulas.Item("Tinh").Text = "'" & UCase(Tentinh) & "'"
                End If

                If Opt = 5 Then
                    Dim Formular As FormulaFieldDefinitions
                    Formular = rptP2.DataDefinition.FormulaFields
                    Formular.Item("Nguoibc").Text = "'" & UCase(sNguoibc) & "'"
                End If
                rptP2.SetDataSource(dsP2.Tables(0))
                rpt.SetDataSource(ds.Tables(0))

            End If
                Me.CrystalReportViewer1.ReportSource = rpt
                Me.CrystalReportViewer1.DataBind()
ds=nothing
	'obj=nothing
	'objKD=nothing
        Catch ex As Exception
            ProcessModuleLoadException(Me, ex)
        Finally

        End Try
    End Sub
End Class
