Imports CrystalDecisions.CrystalReports.Engine

Partial Class Report_form_BaocaoHuyen
    Inherits System.Web.UI.Page
    Dim rpt As New ReportDocument
 Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        rpt.Dispose()
        rpt.Close()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Dim ds As New DataSet
            Dim dsP2 As New DataSet
            Dim obj As New YourCompany.Modules.NTP_BAOCAOTUYENTINH.NTP_BAOCAOTUYENTINHController
            Dim Tinh As String
            Dim sNguoibc As String
            Dim Nam As Integer
            Dim Quy As String
            Dim Opt As Integer
            Dim Tentinh As String
            Dim TenHuyen As String
            Dim Myformulas As FormulaFieldDefinitions
            Dim sNgaybc As String
            Dim Tungay As String
            Dim Denngay As String
            Dim Capnhatdl As Integer
            Dim Capin As Integer
            Me.Title = "Bao cao Thong ke tuyen Huyen"
            If Request.QueryString("Tinh") = "" Then
                Tinh = "ALL"
            Else
                Tinh = Request.QueryString("Tinh")
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
            TenHuyen = Request.QueryString("Tenhuyen")
            sNguoibc = Request.QueryString("Nguoibc")
            sNgaybc = Request.QueryString("Ngaybc")
            If Opt <> 7 Then
                Capin = Request.QueryString("capin") ' =0 lay so lieu tu phieu DKDT; =1 Lay tu so lieu bang BC 
                If Capin = 0 Then
                    Tungay = Request.QueryString("Tungay")
                    Denngay = Request.QueryString("Denngay")
                    Capnhatdl = Request.QueryString("Capnhatdl")
                Else
                    Tungay = "01/01/1945"
                    Denngay = "01/01/1945"
                    Capnhatdl = 0
                End If
            Else
                Tungay = Request.QueryString("Tungay")
                Denngay = Request.QueryString("Denngay")
            End If
            If Opt < 7 Then
                ds = obj.ListBaoCaoTuyenHuyen(Tungay, Denngay, Nam, Quy, Tinh, Opt, Capin, Capnhatdl)
                dsP2 = obj.ListBaoCaoTuyenHuyen(Tungay, Denngay, Nam, Quy, Tinh, Opt, Capin, Capnhatdl)
            Else
                ds = obj.ListBaoCaoTuyenHuyen(Tungay, Denngay, Nam, Quy, Tinh, Opt, 0, 0)
            End If
            '  ds.Reset()
            Dim sPath As String
            If Opt = 1 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_THUNHANBNLAO_HUYEN.rpt"
            ElseIf Opt = 2 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUADIEUTRILAO_HUYEN.rpt"
            ElseIf Opt = 3 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KETQUAAMHOADOM_HUYEN.rpt"
            ElseIf Opt = 4 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_HOATDONGXN_HUYEN.rpt"
            ElseIf Opt = 5 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_KIEMDINHTB_HUYEN.rpt"
            ElseIf Opt = 6 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_CHUONGTRINHCHONGLAO_HUYEN.rpt"
            ElseIf Opt = 7 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_PXN_PHATHIENDUONG.rpt"
            ElseIf Opt = 8 Then
                sPath = Me.Request.PhysicalApplicationPath & NTP_Common.Configuration.ReportDirectory & "\BN_PXN_PHATHIENAM3MAU.rpt"

            End If

            rpt.Load(sPath)
            '  Response.Write(Len(Quy))
            Select Case Opt
                Case 1, 2, 3
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
                    Myformulas.Item("Tinh").Text = "'" & Tentinh & "'"
                    Myformulas.Item("Nguoibc").Text = "'" & sNguoibc & "'"
                    Myformulas.Item("Huyen").Text = "'" & TenHuyen & "'"
                    Myformulas.Item("Ngaybc").Text = "'" & sNgaybc & "'"
                    rpt.SetDataSource(ds.Tables(0))
                Case 5
                    Myformulas = rpt.DataDefinition.FormulaFields
                    Myformulas.Item("Quy").Text = "'" & Quy & "'"
                    Myformulas.Item("Nam").Text = "'" & Nam & "'"
                    Myformulas.Item("Tinh").Text = "'" & Tentinh & "'"
                    Myformulas.Item("Huyen").Text = "'" & TenHuyen & "'"
                    rpt.SetDataSource(ds.Tables(0))
                Case 4
                    Myformulas = rpt.DataDefinition.FormulaFields
                    Myformulas.Item("Quy").Text = "'" & Quy & "'"
                    Myformulas.Item("Nam").Text = "'" & Nam & "'"
                    Myformulas.Item("Tinh").Text = "'" & Tentinh & "'"
                    Myformulas.Item("Huyen").Text = "'" & TenHuyen & "'"
                    Dim rptP2 As New ReportDocument
                    Dim Formular As FormulaFieldDefinitions
                    rptP2 = rpt.Subreports("BN_HOATDONGXN_TINHP2.rpt")
                    Formular = rptP2.DataDefinition.FormulaFields
                    Formular.Item("Nguoibc").Text = "'" & UCase(sNguoibc) & "'"
                    rptP2.SetDataSource(dsP2.Tables(0))
                    rpt.SetDataSource(ds.Tables(0))
                Case 6
                    Myformulas = rpt.DataDefinition.FormulaFields
                    Myformulas.Item("Nam").Text = "'" & Nam & "'"
                    Myformulas.Item("Tinh").Text = "'" & Tentinh & "'"
                    Myformulas.Item("Huyen").Text = "'" & TenHuyen & "'"
                    Myformulas.Item("Nguoibc").Text = "'" & sNguoibc & "'"
                    Myformulas.Item("Ngaybc").Text = "'" & sNgaybc & "'"
                    rpt.SetDataSource(ds.Tables(0))
                Case 7, 8
                    Myformulas = rpt.DataDefinition.FormulaFields
                    Myformulas.Item("Donvi").Text = "'TÊN TỈNH: " & UCase(Tentinh) & " - HUYỆN:" & UCase(TenHuyen) & "'"
                    Myformulas.Item("Ngaybc").Text = "'Từ ngày: " & Request.QueryString("ngay1") & " -  đến ngày: " & Request.QueryString("ngay2") & "'"
                    rpt.SetDataSource(ds.Tables(0))
            End Select


            Me.CrystalReportViewer1.ReportSource = rpt
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
