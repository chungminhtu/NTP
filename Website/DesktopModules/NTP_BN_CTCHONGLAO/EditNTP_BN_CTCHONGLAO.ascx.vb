'
' DotNetNuke® - http://www.dotnetnuke.com
' Copyright (c) 2002-2006
' by Perpetual Motion Interactive Systems Inc. ( http://www.perpetualmotion.ca )
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'

Imports DotNetNuke

Imports NTP_Common.mdlGlobal


Namespace YourCompany.Modules.NTP_BN_CTCHONGLAO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_BN_CTCHONGLAO
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

#End Region

#Region "Event Handlers"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' cmdCancel_Click runs when the cancel button is clicked
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCancel.Click
            Try
                Response.Redirect(NavigateURL(), True)
            Catch exc As Exception    'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

     

#End Region

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
           
           
            Try
               
                If DotNetNuke.Framework.AJAX.IsInstalled Then
                    DotNetNuke.Framework.AJAX.RegisterScriptManager()
                    'DotNetNuke.Framework.AJAX.RegisterPostBackControl(Me.TextBox1)
                End If
                If Not IsPostBack Then

                    If Request.QueryString("id_Tinh") <> "" And (Me.CurrentUserStock.ID_BENHVIEN = "7210" Or Me.CurrentUserStock.ID_BENHVIEN = "3112") Then
                        BindComboHuyen(Request.QueryString("id_Tinh"))
                    Else
                        BindComboBenhVien(Me.CurrentUserStock.ID_BENHVIEN, Me.CurrentUserStock.ID_MATINH)
                    End If
                    pnlBaoCao1.Visible = True
                    PanelPhan4.Visible = False
                    'cboDonVi.SelectedValue = Me.CurrentUserStock.ID_BENHVIEN
                    SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
                    Dim obj As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOController
                    Dim inf As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOInfo
                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtId_CTChongLao.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtId_CTChongLao.Text)
                        Me.txtNam.Text = inf.Nam
                        SetValue(Me.txtNgayBaoCao, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        ''Me.cboHuyen.SelectedValue = inf.MA_HUYEN
                        Me.cboDonVi.SelectedValue = inf.MADV
                        Me.txtNguoiBaoCao.Text = inf.NguoiBC
                        Me.txtAFBChuyenDen.Text = inf.AFBcongdong
                        Me.txtAFBDieuTri.Text = inf.AFBhotro
                        Me.TxtSoBNPhathien.Text = inf.SoBNPhathien
                        Me.TxtSoBNDieutri.Text = inf.SoBNDKDT
                        LoadValuesP1(txtId_CTChongLao.Text)
                        LoadValuesP2(txtId_CTChongLao.Text)
                        LoadP4(txtId_CTChongLao.Text)
                       
                    Else
                        cmdCreateNew_Click(sender, e)
                    End If
                    NTP_Common.SetFormFocus(Me.txtNam, Me.ModuleConfiguration.SupportsPartialRendering)
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                'obj = Nothing
                'inf = Nothing
            End Try

        End Sub
        Private Sub BindComboHuyen(ByVal Id_Tinh As String)
            Dim obj As New NTP_BN_BC_KETQUADT.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.cboDonVi.DataSource = obj.ListNTP_DM_BENHVIEN(Id_Tinh)
                Me.cboDonVi.DataBind()
                Me.cboDonVi.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub
        Private Sub LoadP4(ByVal id_Baocao As Integer)
            Try
                Dim obj As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj4 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf4 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj5 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf5 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj6 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf6 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj7 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf7 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj8 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf8 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj9 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf9 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj10 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf10 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj11 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf11 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj12 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf12 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj13 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf13 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj14 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf14 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj15 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf15 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj16 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf16 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                Dim obj17 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
                Dim inf17 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
                inf = obj.ListCTCHONGLAOP3(id_Baocao, 1)
                If Not inf Is Nothing Then
                    txtNhanLucHienCo.Text = inf.NLHienco
                    txtNhanLucDTTrongNam.Text = inf.NLDaotao
                    txtNhanLucDaDT.Text = inf.TongsoNLDaotao
                    txtId_NhanLuc.Text = inf.ID_CTChonglaoP3
                End If
                inf1 = obj1.ListCTCHONGLAOP3(id_Baocao, 2)
                If Not inf1 Is Nothing Then
                    txtNhanLucHienCo1.Text = inf1.NLHienco
                    txtNhanLucDTTrongNam1.Text = inf1.NLDaotao
                    txtNhanLucDaDT1.Text = inf1.TongsoNLDaotao
                    txtId_NhanLuc1.Text = inf1.ID_CTChonglaoP3
                End If
                inf2 = obj2.ListCTCHONGLAOP3(id_Baocao, 3)
                If Not inf2 Is Nothing Then
                    txtNhanLucHienCo2.Text = inf2.NLHienco
                    txtNhanLucDTTrongNam2.Text = inf2.NLDaotao
                    txtNhanLucDaDT2.Text = inf2.TongsoNLDaotao
                    txtId_NhanLuc2.Text = inf2.ID_CTChonglaoP3
                End If
                inf3 = obj3.ListCTCHONGLAOP3(id_Baocao, 4)
                If Not inf3 Is Nothing Then
                    txtNhanLucHienCo3.Text = inf3.NLHienco
                    txtNhanLucDTTrongNam3.Text = inf3.NLDaotao
                    txtNhanLucDaDT3.Text = inf3.TongsoNLDaotao
                    txtId_NhanLuc3.Text = inf3.ID_CTChonglaoP3
                End If
                inf4 = obj4.ListCTCHONGLAOP3(id_Baocao, 5)
                If Not inf4 Is Nothing Then
                    txtNhanLucHienCo4.Text = inf4.NLHienco
                    txtNhanLucDTTrongNam4.Text = inf4.NLDaotao
                    txtNhanLucDaDT4.Text = inf4.TongsoNLDaotao
                    txtId_NhanLuc4.Text = inf4.ID_CTChonglaoP3
                End If

                inf5 = obj5.ListCTCHONGLAOP3(id_Baocao, 6)
                If Not inf5 Is Nothing Then
                    txtNhanLucHienCo5.Text = inf5.NLHienco
                    txtNhanLucDTTrongNam5.Text = inf5.NLDaotao
                    txtNhanLucDaDT5.Text = inf5.TongsoNLDaotao
                    txtId_NhanLuc5.Text = inf5.ID_CTChonglaoP3
                End If
                inf6 = obj6.ListCTCHONGLAOP3(id_Baocao, 7)
                If Not inf6 Is Nothing Then
                    txtNhanLucHienCo6.Text = inf6.NLHienco
                    txtNhanLucDTTrongNam6.Text = inf6.NLDaotao
                    txtNhanLucDaDT6.Text = inf6.TongsoNLDaotao
                    txtId_NhanLuc6.Text = inf6.ID_CTChonglaoP3
                End If
                inf7 = obj7.ListCTCHONGLAOP3(id_Baocao, 8)
                If Not inf7 Is Nothing Then
                    txtNhanLucHienCo7.Text = inf7.NLHienco
                    txtNhanLucDTTrongNam7.Text = inf7.NLDaotao
                    txtNhanLucDaDT7.Text = inf7.TongsoNLDaotao
                    txtId_NhanLuc7.Text = inf7.ID_CTChonglaoP3
                End If

                inf8 = obj8.ListCTCHONGLAOP3(id_Baocao, 9)
                If Not inf8 Is Nothing Then
                    txtNhanLucHienCo8.Text = inf8.NLHienco
                    txtNhanLucDTTrongNam8.Text = inf8.NLDaotao
                    txtNhanLucDaDT8.Text = inf8.TongsoNLDaotao
                    txtId_NhanLuc8.Text = inf8.ID_CTChonglaoP3
                    TxtGhichu1.Text = inf8.Ghichu
                End If
                inf9 = obj9.ListCTCHONGLAOP3(id_Baocao, 10)
                If Not inf9 Is Nothing Then
                    txtNhanLucHienCo9.Text = inf9.NLHienco
                    txtNhanLucDTTrongNam9.Text = inf9.NLDaotao
                    txtNhanLucDaDT9.Text = inf9.TongsoNLDaotao
                    txtId_NhanLuc9.Text = inf9.ID_CTChonglaoP3

                End If
                inf10 = obj10.ListCTCHONGLAOP3(id_Baocao, 11)
                If Not inf10 Is Nothing Then
                    txtNhanLucHienCo10.Text = inf10.NLHienco
                    txtNhanLucDTTrongNam10.Text = inf10.NLDaotao
                    txtNhanLucDaDT10.Text = inf10.TongsoNLDaotao
                    txtId_NhanLuc10.Text = inf10.ID_CTChonglaoP3
                End If
                inf11 = obj11.ListCTCHONGLAOP3(id_Baocao, 12)
                If Not inf11 Is Nothing Then
                    txtNhanLucHienCo11.Text = inf11.NLHienco
                    txtNhanLucDTTrongNam11.Text = inf11.NLDaotao
                    txtNhanLucDaDT11.Text = inf11.TongsoNLDaotao
                    txtId_NhanLuc11.Text = inf11.ID_CTChonglaoP3
                End If
                inf12 = obj12.ListCTCHONGLAOP3(id_Baocao, 13)
                If Not inf12 Is Nothing Then
                    txtNhanLucHienCo12.Text = inf12.NLHienco
                    txtNhanLucDTTrongNam12.Text = inf12.NLDaotao
                    txtNhanLucDaDT12.Text = inf12.TongsoNLDaotao
                    txtId_NhanLuc12.Text = inf12.ID_CTChonglaoP3
                End If
                inf13 = obj13.ListCTCHONGLAOP3(id_Baocao, 14)
                If Not inf13 Is Nothing Then
                    txtNhanLucHienCo13.Text = inf13.NLHienco
                    txtNhanLucDTTrongNam13.Text = inf13.NLDaotao
                    txtNhanLucDaDT13.Text = inf13.TongsoNLDaotao
                    txtId_NhanLuc13.Text = inf13.ID_CTChonglaoP3
                End If
                inf14 = obj14.ListCTCHONGLAOP3(id_Baocao, 15)
                If Not inf14 Is Nothing Then
                    txtNhanLucHienCo14.Text = inf14.NLHienco
                    txtNhanLucDTTrongNam14.Text = inf14.NLDaotao
                    txtNhanLucDaDT14.Text = inf14.TongsoNLDaotao
                    txtId_NhanLuc14.Text = inf14.ID_CTChonglaoP3
                End If
                inf15 = obj15.ListCTCHONGLAOP3(id_Baocao, 16)
                If Not inf15 Is Nothing Then
                    txtNhanLucHienCo15.Text = inf15.NLHienco
                    txtNhanLucDTTrongNam15.Text = inf15.NLDaotao
                    txtNhanLucDaDT15.Text = inf15.TongsoNLDaotao
                    txtId_NhanLuc15.Text = inf15.ID_CTChonglaoP3
                End If
                inf16 = obj16.ListCTCHONGLAOP3(id_Baocao, 17)
                If Not inf16 Is Nothing Then
                    txtNhanLucHienCo16.Text = inf16.NLHienco
                    txtNhanLucDTTrongNam16.Text = inf16.NLDaotao
                    txtNhanLucDaDT16.Text = inf16.TongsoNLDaotao
                    txtId_NhanLuc16.Text = inf16.ID_CTChonglaoP3
                    TxtGhichu2.Text = inf16.Ghichu
                End If
                inf17 = obj17.ListCTCHONGLAOP3(id_Baocao, 18)
                If Not inf17 Is Nothing Then
                    txtNhanLucHienCo17.Text = inf17.NLHienco
                    txtNhanLucDTTrongNam17.Text = inf17.NLDaotao
                    txtNhanLucDaDT17.Text = inf17.TongsoNLDaotao
                    txtId_NhanLuc17.Text = inf17.ID_CTChonglaoP3
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
            End Try
        End Sub
        Private Sub UpdatePhan4(ByVal id_Baocao As Integer)
            Dim obj As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj4 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf4 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj5 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf5 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj6 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf6 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj7 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf7 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj8 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf8 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj9 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf9 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj10 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf10 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj11 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf11 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj12 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf12 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj13 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf13 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj14 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf14 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj15 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf15 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj16 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf16 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Dim obj17 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf17 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Try
                inf.NLHienco = IIf(txtNhanLucHienCo.Text = "", 0, txtNhanLucHienCo.Text)
                inf.NLDaotao = IIf(txtNhanLucDTTrongNam.Text = "", 0, txtNhanLucDTTrongNam.Text)
                inf.TongsoNLDaotao = IIf(txtNhanLucDaDT.Text = "", 0, txtNhanLucDaDT.Text)
                inf.ID_CTChonglaoP3 = IIf(txtId_NhanLuc.Text = "", 0, txtId_NhanLuc.Text)
                inf.ID_NguonNhanLuc = 1
                inf.ID_CTChonglao = id_Baocao
                inf.Phanloai = False
                If txtId_NhanLuc.Text = "" Or txtId_NhanLuc.Text Is Nothing Then
                    txtId_NhanLuc.Text = obj.Add(inf)
                Else
                    obj.Update(inf)
                End If
                inf1.NLHienco = IIf(txtNhanLucHienCo1.Text = "", 0, txtNhanLucHienCo1.Text)
                inf1.NLDaotao = IIf(txtNhanLucDTTrongNam1.Text = "", 0, txtNhanLucDTTrongNam1.Text)
                inf1.TongsoNLDaotao = IIf(txtNhanLucDaDT1.Text = "", 0, txtNhanLucDaDT1.Text)
                inf1.ID_CTChonglaoP3 = IIf(txtId_NhanLuc1.Text = "", 0, txtId_NhanLuc1.Text)
                inf1.ID_NguonNhanLuc = 2
                inf1.ID_CTChonglao = id_Baocao
                inf1.Phanloai = False
                If txtId_NhanLuc1.Text = "" Or txtId_NhanLuc1.Text Is Nothing Then
                    txtId_NhanLuc1.Text = obj.Add(inf1)
                Else
                    obj1.Update(inf1)
                End If
                inf2.NLHienco = IIf(txtNhanLucHienCo2.Text = "", 0, txtNhanLucHienCo2.Text)
                inf2.NLDaotao = IIf(txtNhanLucDTTrongNam2.Text = "", 0, txtNhanLucDTTrongNam2.Text)
                inf2.TongsoNLDaotao = IIf(txtNhanLucDaDT2.Text = "", 0, txtNhanLucDaDT2.Text)
                inf2.ID_CTChonglaoP3 = IIf(txtId_NhanLuc2.Text = "", 0, txtId_NhanLuc2.Text)
                inf2.ID_NguonNhanLuc = 3
                inf2.ID_CTChonglao = id_Baocao
                inf2.Phanloai = False
                If txtId_NhanLuc2.Text = "" Or txtId_NhanLuc2.Text Is Nothing Then
                    txtId_NhanLuc2.Text = obj.Add(inf2)
                Else
                    obj2.Update(inf2)
                End If
                inf3.NLHienco = IIf(txtNhanLucHienCo3.Text = "", 0, txtNhanLucHienCo3.Text)
                inf3.NLDaotao = IIf(txtNhanLucDTTrongNam3.Text = "", 0, txtNhanLucDTTrongNam3.Text)
                inf3.TongsoNLDaotao = IIf(txtNhanLucDaDT3.Text = "", 0, txtNhanLucDaDT3.Text)
                inf3.ID_CTChonglaoP3 = IIf(txtId_NhanLuc3.Text = "", 0, txtId_NhanLuc3.Text)
                inf3.ID_NguonNhanLuc = 4
                inf3.ID_CTChonglao = id_Baocao
                inf3.Phanloai = False
                If txtId_NhanLuc3.Text = "" Or txtId_NhanLuc3.Text Is Nothing Then
                    txtId_NhanLuc3.Text = obj.Add(inf3)
                Else

                    obj3.Update(inf3)
                End If
                inf4.NLHienco = IIf(txtNhanLucHienCo4.Text = "", 0, txtNhanLucHienCo4.Text)
                inf4.NLDaotao = IIf(txtNhanLucDTTrongNam4.Text = "", 0, txtNhanLucDTTrongNam4.Text)
                inf4.TongsoNLDaotao = IIf(txtNhanLucDaDT4.Text = "", 0, txtNhanLucDaDT4.Text)
                inf4.ID_CTChonglaoP3 = IIf(txtId_NhanLuc4.Text = "", 0, txtId_NhanLuc4.Text)
                inf4.ID_NguonNhanLuc = 5
                inf4.ID_CTChonglao = id_Baocao
                inf4.Phanloai = False
                If txtId_NhanLuc4.Text = "" Or txtId_NhanLuc4.Text Is Nothing Then
                    txtId_NhanLuc4.Text = obj.Add(inf4)
                Else

                    obj4.Update(inf4)
                End If
                inf5.NLHienco = IIf(txtNhanLucHienCo5.Text = "", 0, txtNhanLucHienCo5.Text)
                inf5.NLDaotao = IIf(txtNhanLucDTTrongNam5.Text = "", 0, txtNhanLucDTTrongNam5.Text)
                inf5.TongsoNLDaotao = IIf(txtNhanLucDaDT5.Text = "", 0, txtNhanLucDaDT5.Text)
                inf5.ID_CTChonglaoP3 = IIf(txtId_NhanLuc5.Text = "", 0, txtId_NhanLuc5.Text)
                inf5.ID_NguonNhanLuc = 6
                inf5.ID_CTChonglao = id_Baocao
                inf5.Phanloai = False
                If txtId_NhanLuc5.Text = "" Or txtId_NhanLuc5.Text Is Nothing Then
                    txtId_NhanLuc5.Text = obj.Add(inf5)
                Else

                    obj5.Update(inf5)
                End If

                inf6.NLHienco = IIf(txtNhanLucHienCo6.Text = "", 0, txtNhanLucHienCo6.Text)
                inf6.NLDaotao = IIf(txtNhanLucDTTrongNam6.Text = "", 0, txtNhanLucDTTrongNam6.Text)
                inf6.TongsoNLDaotao = IIf(txtNhanLucDaDT6.Text = "", 0, txtNhanLucDaDT6.Text)
                inf6.ID_CTChonglaoP3 = IIf(txtId_NhanLuc6.Text = "", 0, txtId_NhanLuc6.Text)
                inf6.ID_NguonNhanLuc = 7
                inf6.ID_CTChonglao = id_Baocao
                inf6.Phanloai = False
                If txtId_NhanLuc6.Text = "" Or txtId_NhanLuc6.Text Is Nothing Then
                    txtId_NhanLuc6.Text = obj.Add(inf6)
                Else

                    obj6.Update(inf6)
                End If

                inf7.NLHienco = IIf(txtNhanLucHienCo7.Text = "", 0, txtNhanLucHienCo7.Text)
                inf7.NLDaotao = IIf(txtNhanLucDTTrongNam7.Text = "", 0, txtNhanLucDTTrongNam7.Text)
                inf7.TongsoNLDaotao = IIf(txtNhanLucDaDT7.Text = "", 0, txtNhanLucDaDT7.Text)
                inf7.ID_CTChonglaoP3 = IIf(txtId_NhanLuc7.Text = "", 0, txtId_NhanLuc7.Text)
                inf7.ID_NguonNhanLuc = 8
                inf7.ID_CTChonglao = id_Baocao
                inf7.Phanloai = False
                If txtId_NhanLuc7.Text = "" Or txtId_NhanLuc7.Text Is Nothing Then
                    txtId_NhanLuc7.Text = obj.Add(inf7)
                Else

                    obj7.Update(inf7)
                End If
                inf8.NLHienco = IIf(txtNhanLucHienCo8.Text = "", 0, txtNhanLucHienCo8.Text)
                inf8.NLDaotao = IIf(txtNhanLucDTTrongNam8.Text = "", 0, txtNhanLucDTTrongNam8.Text)
                inf8.TongsoNLDaotao = IIf(txtNhanLucDaDT8.Text = "", 0, txtNhanLucDaDT8.Text)
                inf8.ID_CTChonglaoP3 = IIf(txtId_NhanLuc8.Text = "", 0, txtId_NhanLuc8.Text)
                inf8.ID_NguonNhanLuc = 9
                inf8.ID_CTChonglao = id_Baocao
                inf8.Ghichu = TxtGhichu1.Text
                inf8.Phanloai = False
                If txtId_NhanLuc8.Text = "" Or txtId_NhanLuc8.Text Is Nothing Then
                    txtId_NhanLuc8.Text = obj.Add(inf8)
                Else

                    obj8.Update(inf8)
                End If
                inf9.NLHienco = IIf(txtNhanLucHienCo9.Text = "", 0, txtNhanLucHienCo9.Text)
                inf9.NLDaotao = IIf(txtNhanLucDTTrongNam9.Text = "", 0, txtNhanLucDTTrongNam9.Text)
                inf9.TongsoNLDaotao = IIf(txtNhanLucDaDT9.Text = "", 0, txtNhanLucDaDT9.Text)
                inf9.ID_CTChonglaoP3 = IIf(txtId_NhanLuc9.Text = "", 0, txtId_NhanLuc9.Text)
                inf9.ID_NguonNhanLuc = 10
                inf9.ID_CTChonglao = id_Baocao
                inf9.Phanloai = False
                If txtId_NhanLuc9.Text = "" Or txtId_NhanLuc9.Text Is Nothing Then
                    txtId_NhanLuc9.Text = obj.Add(inf9)
                Else

                    obj9.Update(inf9)
                End If

                inf10.NLHienco = IIf(txtNhanLucHienCo10.Text = "", 0, txtNhanLucHienCo10.Text)
                inf10.NLDaotao = IIf(txtNhanLucDTTrongNam10.Text = "", 0, txtNhanLucDTTrongNam10.Text)
                inf10.TongsoNLDaotao = IIf(txtNhanLucDaDT10.Text = "", 0, txtNhanLucDaDT10.Text)
                inf10.ID_CTChonglaoP3 = IIf(txtId_NhanLuc10.Text = "", 0, txtId_NhanLuc10.Text)
                inf10.ID_NguonNhanLuc = 11
                inf10.ID_CTChonglao = id_Baocao
                inf10.Phanloai = True
                If txtId_NhanLuc10.Text = "" Or txtId_NhanLuc10.Text Is Nothing Then
                    txtId_NhanLuc10.Text = obj.Add(inf10)
                Else

                    obj10.Update(inf10)
                End If
                inf11.NLHienco = IIf(txtNhanLucHienCo11.Text = "", 0, txtNhanLucHienCo11.Text)
                inf11.NLDaotao = IIf(txtNhanLucDTTrongNam11.Text = "", 0, txtNhanLucDTTrongNam11.Text)
                inf11.TongsoNLDaotao = IIf(txtNhanLucDaDT11.Text = "", 0, txtNhanLucDaDT11.Text)
                inf11.ID_CTChonglaoP3 = IIf(txtId_NhanLuc11.Text = "", 0, txtId_NhanLuc11.Text)
                inf11.ID_NguonNhanLuc = 12
                inf11.ID_CTChonglao = id_Baocao
                inf11.Phanloai = True
                If txtId_NhanLuc11.Text = "" Or txtId_NhanLuc11.Text Is Nothing Then
                    txtId_NhanLuc11.Text = obj.Add(inf11)
                Else

                    obj11.Update(inf11)
                End If
                inf12.NLHienco = IIf(txtNhanLucHienCo12.Text = "", 0, txtNhanLucHienCo12.Text)
                inf12.NLDaotao = IIf(txtNhanLucDTTrongNam12.Text = "", 0, txtNhanLucDTTrongNam12.Text)
                inf12.TongsoNLDaotao = IIf(txtNhanLucDaDT12.Text = "", 0, txtNhanLucDaDT12.Text)
                inf12.ID_CTChonglaoP3 = IIf(txtId_NhanLuc12.Text = "", 0, txtId_NhanLuc12.Text)
                inf12.ID_NguonNhanLuc = 13
                inf12.ID_CTChonglao = id_Baocao
                inf12.Phanloai = True
                If txtId_NhanLuc12.Text = "" Or txtId_NhanLuc12.Text Is Nothing Then
                    txtId_NhanLuc12.Text = obj.Add(inf12)
                Else

                    obj12.Update(inf12)
                End If
                inf13.NLHienco = IIf(txtNhanLucHienCo13.Text = "", 0, txtNhanLucHienCo13.Text)
                inf13.NLDaotao = IIf(txtNhanLucDTTrongNam13.Text = "", 0, txtNhanLucDTTrongNam13.Text)
                inf13.TongsoNLDaotao = IIf(txtNhanLucDaDT13.Text = "", 0, txtNhanLucDaDT13.Text)
                inf13.ID_CTChonglaoP3 = IIf(txtId_NhanLuc13.Text = "", 0, txtId_NhanLuc13.Text)
                inf13.ID_NguonNhanLuc = 14
                inf13.ID_CTChonglao = id_Baocao
                inf13.Phanloai = True
                If txtId_NhanLuc13.Text = "" Or txtId_NhanLuc13.Text Is Nothing Then
                    txtId_NhanLuc13.Text = obj.Add(inf13)
                Else

                    obj13.Update(inf13)
                End If
                inf14.NLHienco = IIf(txtNhanLucHienCo14.Text = "", 0, txtNhanLucHienCo14.Text)
                inf14.NLDaotao = IIf(txtNhanLucDTTrongNam14.Text = "", 0, txtNhanLucDTTrongNam14.Text)
                inf14.TongsoNLDaotao = IIf(txtNhanLucDaDT14.Text = "", 0, txtNhanLucDaDT14.Text)
                inf14.ID_CTChonglaoP3 = IIf(txtId_NhanLuc14.Text = "", 0, txtId_NhanLuc14.Text)
                inf14.ID_NguonNhanLuc = 15
                inf14.ID_CTChonglao = id_Baocao
                inf14.Phanloai = True
                If txtId_NhanLuc14.Text = "" Or txtId_NhanLuc14.Text Is Nothing Then
                    txtId_NhanLuc14.Text = obj.Add(inf14)
                Else

                    obj14.Update(inf14)
                End If
                inf15.NLHienco = IIf(txtNhanLucHienCo15.Text = "", 0, txtNhanLucHienCo15.Text)
                inf15.NLDaotao = IIf(txtNhanLucDTTrongNam15.Text = "", 0, txtNhanLucDTTrongNam15.Text)
                inf15.TongsoNLDaotao = IIf(txtNhanLucDaDT15.Text = "", 0, txtNhanLucDaDT15.Text)
                inf15.ID_CTChonglaoP3 = IIf(txtId_NhanLuc15.Text = "", 0, txtId_NhanLuc15.Text)
                inf15.ID_NguonNhanLuc = 16
                inf15.ID_CTChonglao = id_Baocao

                inf15.Phanloai = True
                If txtId_NhanLuc15.Text = "" Or txtId_NhanLuc15.Text Is Nothing Then
                    txtId_NhanLuc15.Text = obj.Add(inf15)
                Else

                    obj15.Update(inf15)
                End If
                inf16.NLHienco = IIf(txtNhanLucHienCo16.Text = "", 0, txtNhanLucHienCo16.Text)
                inf16.NLDaotao = IIf(txtNhanLucDTTrongNam16.Text = "", 0, txtNhanLucDTTrongNam16.Text)
                inf16.TongsoNLDaotao = IIf(txtNhanLucDaDT16.Text = "", 0, txtNhanLucDaDT16.Text)
                inf16.ID_CTChonglaoP3 = IIf(txtId_NhanLuc16.Text = "", 0, txtId_NhanLuc16.Text)
                inf16.ID_NguonNhanLuc = 17
                inf16.ID_CTChonglao = id_Baocao
                inf16.Ghichu = TxtGhichu2.Text
                inf16.Phanloai = True
                If txtId_NhanLuc16.Text = "" Or txtId_NhanLuc16.Text Is Nothing Then
                    txtId_NhanLuc16.Text = obj.Add(inf16)
                Else

                    obj16.Update(inf16)
                End If
                inf17.NLHienco = IIf(txtNhanLucHienCo17.Text = "", 0, txtNhanLucHienCo17.Text)
                inf17.NLDaotao = IIf(txtNhanLucDTTrongNam17.Text = "", 0, txtNhanLucDTTrongNam17.Text)
                inf17.TongsoNLDaotao = IIf(txtNhanLucDaDT17.Text = "", 0, txtNhanLucDaDT17.Text)
                inf17.ID_CTChonglaoP3 = IIf(txtId_NhanLuc17.Text = "", 0, txtId_NhanLuc17.Text)
                inf17.ID_NguonNhanLuc = 18
                inf17.ID_CTChonglao = id_Baocao
                inf17.Phanloai = True
                If txtId_NhanLuc17.Text = "" Or txtId_NhanLuc17.Text Is Nothing Then
                    txtId_NhanLuc17.Text = obj.Add(inf17)
                Else

                    obj17.Update(inf17)
                End If

            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
            End Try
        End Sub

        Private Sub BindComboBenhVien(ByVal Id_BenhVien As String, ByVal Id_Tinh As String)
            Dim obj As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim itm As ListItem
            Try
                itm = New ListItem
                itm.Value = Null.NullString
                itm.Text = "--- Chọn cơ sở y tế ---"
                Me.cboDonVi.DataSource = obj.GetByBenVien(Id_BenhVien, Id_Tinh)
                Me.cboDonVi.DataBind()
                Me.cboDonVi.Items.Insert(0, itm)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
            End Try
        End Sub

        Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            Dim obj As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOController
            Dim inf As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOInfo
            Dim objBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo

            Try
                inf.Nam = Me.txtNam.Text
                Dim dtNgay As Date
                dtNgay = CType(NTP_Common.GetValue(Me.txtNgayBaoCao, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                inf.NgayBC = dtNgay
                'inf.MA_HUYEN = Me.cboHuyen.SelectedValue
                inf.MADV = Me.cboDonVi.SelectedValue
                infBenhVien = objBenhVien.Get(inf.MADV)
                inf.MA_HUYEN = infBenhVien.ID_HUYEN
                inf.MA_TINH = infBenhVien.ID_MATINH
                inf.NguoiBC = Me.txtNguoiBaoCao.Text
                inf.AFBcongdong = IIf(Me.txtAFBChuyenDen.Text = "", 0, Me.txtAFBChuyenDen.Text)
                inf.AFBhotro = IIf(Me.txtAFBDieuTri.Text = "", 0, Me.txtAFBDieuTri.Text)
                inf.SoBNPhathien = IIf(Me.TxtSoBNPhathien.Text = "", 0, Me.TxtSoBNPhathien.Text)
                inf.SoBNDKDT = IIf(Me.TxtSoBNDieutri.Text = "", 0, Me.TxtSoBNDieutri.Text)
                If txtId_CTChongLao.Text = "" Or txtId_CTChongLao.Text Is Nothing Then
                    txtId_CTChongLao.Text = obj.Add(inf)
                Else
                    inf.ID_CTChonglao = txtId_CTChongLao.Text
                    obj.Update(inf)
                End If

                UpdatePhan1(txtId_CTChongLao.Text)
                UpdatePhan2(txtId_CTChongLao.Text)
                UpdatePhan4(txtId_CTChongLao.Text)

                cmdCreateNew.Enabled = True
                cmdAdd.Enabled = True

                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally

            End Try


        End Sub

        Private Sub UpdatePhan1(ByVal ID_Baocao As Integer)
            Dim obj1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Controller
            Dim inf1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Info
            Dim obj2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Controller
            Dim inf2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Info
            Try

                inf1.SoCShienco = IIf(Me.txtSoCSYTHuyen.Text = "", 0, Me.txtSoCSYTHuyen.Text)
                inf1.SoCSTrienkhai = IIf(Me.txtCSYTCoChongLao.Text = "", 0, Me.txtCSYTCoChongLao.Text)
                inf1.DiemkinhTT = IIf(Me.txtSoDiemKinh.Text = "", 0, Me.txtSoDiemKinh.Text)
                inf1.DiemkinhKD = IIf(Me.txtSoDiemKinhKiemDinh.Text = "", 0, Me.txtSoDiemKinhKiemDinh.Text)
                inf1.XNNC = IIf(Me.txtSoCSCoXNNuoiCay.Text = "", 0, Me.txtSoCSCoXNNuoiCay.Text)
                inf1.XNKSD = IIf(Me.txtSoCSCoXnKhangSinh.Text = "", 0, Me.txtSoCSCoXnKhangSinh.Text)
                inf1.TuvanHIV = IIf(Me.txtSoCSCoHIV.Text = "", 0, Me.txtSoCSCoHIV.Text)
                inf1.CungcapART = IIf(Me.txtSoCSART.Text = "", 0, Me.txtSoCSART.Text)
                inf1.ID_CTChonglao = ID_Baocao
                inf1.Phanloai = False ' yte cong
                If txtId_CoSoYTe.Text = "" Or txtId_CoSoYTe.Text Is Nothing Then
                    obj1.Add(inf1)
                Else
                    inf1.ID_CTChonglaoP1 = txtId_CoSoYTe.Text
                    obj1.Update(inf1)

                End If

                inf2.SoCShienco = IIf(Me.txtSoCSYTHuyen1.Text = "", 0, Me.txtSoCSYTHuyen1.Text)
                inf2.SoCSTrienkhai = IIf(Me.txtCSYTCoChongLao1.Text = "", 0, Me.txtCSYTCoChongLao1.Text)
                inf2.DiemkinhTT = IIf(Me.txtSoDiemKinh1.Text = "", 0, Me.txtSoDiemKinh1.Text)
                inf2.DiemkinhKD = IIf(Me.txtSoDiemKinhKiemDinh1.Text = "", 0, Me.txtSoDiemKinhKiemDinh1.Text)
                inf2.XNKSD = IIf(Me.txtSoCSCoXnKhangSinh1.Text = "", 0, Me.txtSoCSCoXnKhangSinh1.Text)
                inf2.TuvanHIV = IIf(Me.txtSoCSCoHIV1.Text = "", 0, Me.txtSoCSCoHIV1.Text)
                inf2.CungcapART = IIf(Me.txtSoCSART1.Text = "", 0, Me.txtSoCSART1.Text)
                inf2.XNNC = IIf(Me.txtSoCSCoXNNuoiCay1.Text = "", 0, Me.txtSoCSCoXNNuoiCay1.Text)
                inf2.ID_CTChonglao = ID_Baocao
                inf2.Phanloai = True ' yte tu
                If txtId_CoSoYTe1.Text = "" Or txtId_CoSoYTe1.Text Is Nothing Then
                    txtId_CoSoYTe1.Text = obj2.Add(inf2)
                Else
                    inf2.ID_CTChonglaoP1 = txtId_CoSoYTe1.Text
                    obj2.Update(inf2)

                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)

            End Try

        End Sub

        Private Sub UpdatePhan2(ByVal ID_Baocao As Integer)
            Dim obj As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Controller
            Dim inf As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Info
            Dim obj1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Controller
            Dim inf1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Info
            Dim obj2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Controller
            Dim inf2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Info
            Try

                inf.DuocChuyen = IIf(Me.txtCSChuyen.Text = "", 0, Me.txtCSChuyen.Text)
                inf.ID_CTChonglao = ID_Baocao
                inf.DieuTri = 0
                inf.Chandoan = 0
                inf.LoaihinhYte = 1
                If txtId_DonVi.Text = "" Or txtId_DonVi.Text Is Nothing Then
                    txtId_DonVi.Text = obj.Add(inf)
                Else
                    inf.ID_CTChonglaoP2 = txtId_DonVi.Text
                    obj.Update(inf)
                End If

                inf1.DuocChuyen = IIf(Me.txtCSChuyen1.Text = "", 0, Me.txtCSChuyen1.Text)
                inf1.DieuTri = IIf(Me.txtCSDieuTri1.Text = "", 0, Me.txtCSDieuTri1.Text)
                inf1.Chandoan = IIf(Me.txtCSChanDoan1.Text = "", 0, Me.txtCSChanDoan1.Text)
                inf1.ID_CTChonglao = ID_Baocao
                inf1.LoaihinhYte = 2
                If txtId_DonVi1.Text = "" Or txtId_DonVi1.Text Is Nothing Then
                    txtId_DonVi1.Text = obj1.Add(inf1)
                Else
                    inf1.ID_CTChonglaoP2 = txtId_DonVi1.Text
                    obj1.Update(inf1)
                End If

                inf2.DuocChuyen = IIf(Me.txtCSChuyen2.Text = "", 0, Me.txtCSChuyen2.Text)
                inf2.DieuTri = IIf(Me.txtCSDieuTri2.Text = "", 0, Me.txtCSDieuTri2.Text)
                inf2.Chandoan = IIf(Me.txtCSChanDoan2.Text = "", 0, Me.txtCSChanDoan2.Text)
                inf2.LoaihinhYte = 3
                inf2.ID_CTChonglao = ID_Baocao

                If txtId_DonVi2.Text = "" Or txtId_DonVi2.Text Is Nothing Then
                    txtId_DonVi2.Text = obj2.Add(inf2)
                Else
                    inf2.ID_CTChonglaoP2 = txtId_DonVi2.Text
                    obj2.Update(inf2)
                End If

            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try


        End Sub

        Private Sub UpdatePhan4()
            Dim obj3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Controller
            Dim inf3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP3Info
            Try
                inf3.NLHienco = Me.txtNhanLucHienCo.Text
                inf3.NLDaotao = Me.txtNhanLucDTTrongNam.Text
                inf3.ID_NguonNhanLuc = 0
                inf3.TongsoNLDaotao = Me.txtNhanLucDaDT.Text
                If txtId_CTChongLao.Text = "" Or txtId_CTChongLao.Text Is Nothing Then
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Chưa tồn tại báo cáo chính", Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
                Else
                    inf3.ID_CTChonglao = Me.txtId_CTChongLao.Text
                    If txtId_NhanLuc.Text = "" Or txtId_NhanLuc.Text Is Nothing Then
                        obj3.Add(inf3)
                    Else
                        inf3.ID_CTChonglaoP3 = txtId_NhanLuc.Text
                        obj3.Update(inf3)
                    End If

                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Dữ liệu đã được ghi lại thành công", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub

        Private Sub LoadValuesP1(ByVal ID_Baocao As Integer)

            Try
                Dim obj1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Controller
                Dim inf1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Info
                Dim obj2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Controller
                Dim inf2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP1Info

                inf1 = obj1.ListCTCHONGLAOP1(ID_Baocao, 0) ' yte cong
                If Not inf1 Is Nothing Then
                    Me.txtSoCSYTHuyen.Text = inf1.SoCShienco
                    Me.txtCSYTCoChongLao.Text = inf1.SoCSTrienkhai
                    Me.txtSoDiemKinh.Text = inf1.DiemkinhTT
                    Me.txtSoDiemKinhKiemDinh.Text = inf1.DiemkinhKD
                    Me.txtSoCSCoXNNuoiCay.Text = inf1.XNNC
                    Me.txtSoCSCoXnKhangSinh.Text = inf1.XNKSD
                    Me.txtSoCSCoHIV.Text = inf1.TuvanHIV
                    Me.txtSoCSART.Text = inf1.CungcapART
                    Me.txtId_CoSoYTe.Text = inf1.ID_CTChonglaoP1
                End If
                inf2 = obj1.ListCTCHONGLAOP1(ID_Baocao, 1) ' yte tu
                If Not inf2 Is Nothing Then
                    Me.txtSoCSYTHuyen1.Text = inf2.SoCShienco
                    Me.txtCSYTCoChongLao1.Text = inf2.SoCSTrienkhai
                    Me.txtSoDiemKinh1.Text = inf2.DiemkinhTT
                    Me.txtSoDiemKinhKiemDinh1.Text = inf2.DiemkinhKD
                    Me.txtSoCSCoXNNuoiCay1.Text = inf2.XNNC
                    Me.txtSoCSCoXnKhangSinh1.Text = inf2.XNKSD
                    Me.txtSoCSCoHIV1.Text = inf2.TuvanHIV
                    Me.txtSoCSART1.Text = inf2.CungcapART
                    Me.txtId_CoSoYTe1.Text = inf2.ID_CTChonglaoP1
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try



        End Sub
        Private Sub LoadValuesP2(ByVal ID_Baocao As Integer)

            Try
                Dim obj1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Controller
                Dim inf1 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Info
                Dim obj2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Controller
                Dim inf2 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Info
                Dim obj3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Controller
                Dim inf3 As New NTP_BN_CTCHONGLAO.NTP_BN_CTCHONGLAOP2Info
                inf1 = obj1.ListCTCHONGLAOP2(ID_Baocao, 1) ' tu den,2: yte cong,3 yte tu
                If Not inf1 Is Nothing Then
                    Me.txtCSChuyen.Text = inf1.DuocChuyen
                    Me.txtId_DonVi.Text = inf1.ID_CTChonglaoP2
                End If
                inf2 = obj2.ListCTCHONGLAOP2(ID_Baocao, 2) ' tu den,2: yte cong,3 yte tu
                If Not inf2 Is Nothing Then
                    Me.txtCSChuyen1.Text = inf2.DuocChuyen
                    Me.txtCSDieuTri1.Text = inf2.DieuTri
                    Me.txtCSChanDoan1.Text = inf2.Chandoan
                    Me.txtId_DonVi1.Text = inf2.ID_CTChonglaoP2
                End If
                inf3 = obj3.ListCTCHONGLAOP2(ID_Baocao, 3) ' tu den,2: yte cong,3 yte tu
                If Not inf3 Is Nothing Then
                    Me.txtCSChuyen2.Text = inf3.DuocChuyen
                    Me.txtCSDieuTri2.Text = inf3.DieuTri
                    Me.txtCSChanDoan2.Text = inf3.Chandoan
                    Me.txtId_DonVi2.Text = inf3.ID_CTChonglaoP2
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub


        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            Me.txtId_CTChongLao.Text = ""
            Me.txtNam.Text = Year(Now)
            Me.txtNguoiBaoCao.Text = ""
            SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
            Me.cboDonVi.SelectedValue = ""
            pnlBaoCao1.Visible = True
            PanelPhan4.Visible = False
            Me.txtAFBChuyenDen.Text = ""
            Me.txtAFBDieuTri.Text = ""
            Me.TxtSoBNDieutri.Text = ""
            Me.TxtSoBNPhathien.Text = ""

            Me.txtSoCSYTHuyen.Text = ""
            Me.txtCSYTCoChongLao.Text = ""
            Me.txtSoDiemKinh.Text = ""
            Me.txtSoDiemKinhKiemDinh.Text = ""
            Me.txtSoCSCoXNNuoiCay.Text = ""
            Me.txtSoCSCoXnKhangSinh.Text = ""
            Me.txtSoCSCoHIV.Text = ""
            Me.txtSoCSART.Text = ""
            Me.txtId_CoSoYTe.Text = ""

            Me.txtSoCSYTHuyen1.Text = ""
            Me.txtCSYTCoChongLao1.Text = ""
            Me.txtSoDiemKinh1.Text = ""
            Me.txtSoDiemKinhKiemDinh1.Text = ""
            Me.txtSoCSCoXNNuoiCay1.Text = ""
            Me.txtSoCSCoXnKhangSinh1.Text = ""
            Me.txtSoCSCoHIV1.Text = ""
            Me.txtSoCSART1.Text = ""
            Me.txtId_CoSoYTe1.Text = ""

            Me.txtCSChuyen.Text = ""
            Me.txtId_DonVi.Text = ""
            Me.txtCSChuyen1.Text = ""
            Me.txtCSDieuTri1.Text = ""
            Me.txtCSChanDoan1.Text = ""
            Me.txtId_DonVi1.Text = ""
            Me.txtCSChuyen2.Text = ""
            Me.txtCSDieuTri2.Text = ""
            Me.txtCSChanDoan2.Text = ""
            Me.txtId_DonVi2.Text = ""
            ClearPhan4()
            cmdCreateNew.Enabled = False
            cmdAdd.Enabled = True
        End Sub
        Private Sub ClearPhan4()
            Me.txtNhanLucHienCo.Text = ""
            Me.txtNhanLucDTTrongNam.Text = ""
            Me.txtNhanLucDaDT.Text = ""
            Me.txtId_NhanLuc.Text = ""
            Me.txtNhanLucHienCo1.Text = ""
            Me.txtNhanLucDTTrongNam1.Text = ""
            Me.txtNhanLucDaDT1.Text = ""
            Me.txtId_NhanLuc1.Text = ""
            Me.txtNhanLucHienCo2.Text = ""
            Me.txtNhanLucDTTrongNam2.Text = ""
            Me.txtNhanLucDaDT2.Text = ""
            Me.txtId_NhanLuc2.Text = ""
            Me.txtNhanLucHienCo3.Text = ""
            Me.txtNhanLucDTTrongNam3.Text = ""
            Me.txtNhanLucDaDT3.Text = ""
            Me.txtId_NhanLuc3.Text = ""
            Me.txtNhanLucHienCo4.Text = ""
            Me.txtNhanLucDTTrongNam4.Text = ""
            Me.txtNhanLucDaDT4.Text = ""
            Me.txtId_NhanLuc4.Text = ""
            Me.txtNhanLucHienCo5.Text = ""
            Me.txtNhanLucDTTrongNam5.Text = ""
            Me.txtNhanLucDaDT5.Text = ""
            Me.txtId_NhanLuc5.Text = ""
            Me.txtNhanLucHienCo6.Text = ""
            Me.txtNhanLucDTTrongNam6.Text = ""
            Me.txtNhanLucDaDT6.Text = ""
            Me.txtId_NhanLuc6.Text = ""
            Me.txtNhanLucHienCo7.Text = ""
            Me.txtNhanLucDTTrongNam7.Text = ""
            Me.txtNhanLucDaDT7.Text = ""
            Me.txtId_NhanLuc7.Text = ""
            Me.txtNhanLucHienCo8.Text = ""
            Me.txtNhanLucDTTrongNam8.Text = ""
            Me.txtNhanLucDaDT8.Text = ""
            Me.txtId_NhanLuc8.Text = ""
            Me.txtNhanLucHienCo9.Text = ""
            Me.txtNhanLucDTTrongNam9.Text = ""
            Me.txtNhanLucDaDT9.Text = ""
            Me.txtId_NhanLuc9.Text = ""
            Me.txtNhanLucHienCo10.Text = ""
            Me.txtNhanLucDTTrongNam10.Text = ""
            Me.txtNhanLucDaDT10.Text = ""
            Me.txtId_NhanLuc10.Text = ""
            Me.txtNhanLucHienCo11.Text = ""
            Me.txtNhanLucDTTrongNam11.Text = ""
            Me.txtNhanLucDaDT11.Text = ""
            Me.txtId_NhanLuc11.Text = ""
            Me.txtNhanLucHienCo12.Text = ""
            Me.txtNhanLucDTTrongNam12.Text = ""
            Me.txtNhanLucDaDT12.Text = ""
            Me.txtId_NhanLuc12.Text = ""
            Me.txtNhanLucHienCo13.Text = ""
            Me.txtNhanLucDTTrongNam13.Text = ""
            Me.txtNhanLucDaDT13.Text = ""
            Me.txtId_NhanLuc13.Text = ""
            Me.txtNhanLucHienCo14.Text = ""
            Me.txtNhanLucDTTrongNam14.Text = ""
            Me.txtNhanLucDaDT14.Text = ""
            Me.txtId_NhanLuc14.Text = ""
            Me.txtNhanLucHienCo15.Text = ""
            Me.txtNhanLucDTTrongNam15.Text = ""
            Me.txtNhanLucDaDT15.Text = ""
            Me.txtId_NhanLuc15.Text = ""
            Me.txtNhanLucHienCo16.Text = ""
            Me.txtNhanLucDTTrongNam16.Text = ""
            Me.txtNhanLucDaDT16.Text = ""
            Me.txtId_NhanLuc16.Text = ""
            Me.txtNhanLucHienCo17.Text = ""
            Me.txtNhanLucDTTrongNam17.Text = ""
            Me.txtNhanLucDaDT17.Text = ""
            Me.txtId_NhanLuc17.Text = ""
            Me.TxtGhichu1.Text = ""
            Me.TxtGhichu2.Text = ""
         
        End Sub
        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
            pnlBaoCao1.Visible = True
            PanelPhan4.Visible = False
            If txtId_CTChongLao.Text <> "" Then
                UpdatePhan4(txtId_CTChongLao.Text)
            End If
        End Sub

        Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
            pnlBaoCao1.Visible = False
            PanelPhan4.Visible = True
            If txtId_CTChongLao.Text <> "" Then
                UpdatePhan1(txtId_CTChongLao.Text)
                UpdatePhan2(txtId_CTChongLao.Text)
            End If
        End Sub
    End Class
End Namespace