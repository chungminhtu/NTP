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
Namespace YourCompany.Modules.NTP_KD_BC_HOATDONGXN

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The EditDynamicModule class is used to manage content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class EditNTP_KD_BC_HOATDONGXN
        Inherits Entities.Modules.PortalModuleBase

#Region "Private Members"

        Private ItemId As Integer = Common.Utilities.Null.NullInteger

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

                    'cboLaoHIV.SelectedValue = Me.CurrentUserStock.ID_BENHVIEN
                    SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
                    Dim obj As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
                    Dim inf As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNInfo

                    If Not Request.QueryString("id") Is Nothing Then
                        Me.txtID_HOATDONGXN.Text = Request.QueryString("id")
                        inf = obj.Get(Me.txtID_HOATDONGXN.Text)
                        Me.txtNam.Text = inf.Nam
                        SetValue(Me.txtNgayBaoCao, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        Me.cboDonVi.SelectedValue = inf.ID_BENHVIEN
                        Me.txtNguoiBaoCao.Text = inf.NguoiBC
                        Me.cboQuy.SelectedValue = inf.Quy
                        Me.txtSoTBPhatHienAm.Text = inf.SoTBPhathienA
                        Me.txtSoTBPhatHienDuong.Text = inf.SoTBPhathienD
                        Me.txtSoTBTheoDoiAm.Text = inf.SoTBTheodoiA
                        Me.txtSoTBTheoDoiDuong.Text = inf.SoTBTheodoiD
                        LoadDetail(txtID_HOATDONGXN.Text)
                        Tongcong()
                    Else
                        cmdCreateNew_Click(sender, e)
                    End If

                    NTP_Common.SetFormFocus(Me.cboDonVi, Me.ModuleConfiguration.SupportsPartialRendering)
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
            Dim obj As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
            Dim inf As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNInfo
            Dim objBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENController
            Dim infBenhVien As New NTP_DM_BENHVIEN.NTP_DM_BENHVIENInfo

            Try
                inf.Nam = Me.txtNam.Text
                Dim dtNgay As Date
                dtNgay = CType(NTP_Common.GetValue(Me.txtNgayBaoCao, NTP_Common.enuDATA_TYPE.DATE_TYPE), Date)
                inf.NgayBC = dtNgay
                'inf.MA_HUYEN = Me.cboHuyen.SelectedValue
                inf.ID_BENHVIEN = Me.cboDonVi.SelectedValue
                infBenhVien = objBenhVien.Get(inf.ID_BENHVIEN)
                'inf.HuyenXN = infBenhVien.ID_HUYEN
                'inf.TinhXN = infBenhVien.ID_MATINH
                inf.NguoiBC = Me.txtNguoiBaoCao.Text
                inf.Quy = Me.cboQuy.SelectedValue
                inf.SoTBPhathienA = IIf(Me.txtSoTBPhatHienAm.Text = "", 0, Me.txtSoTBPhatHienAm.Text)
                inf.SoTBPhathienD = IIf(Me.txtSoTBPhatHienDuong.Text = "", 0, Me.txtSoTBPhatHienDuong.Text)
                inf.SoTBTheodoiA = IIf(Me.txtSoTBTheoDoiAm.Text = "", 0, Me.txtSoTBTheoDoiAm.Text)
                inf.SoTBTheodoiD = IIf(Me.txtSoTBTheoDoiDuong.Text = "", 0, Me.txtSoTBTheoDoiDuong.Text)
                If txtID_HOATDONGXN.Text = "" Or txtID_HOATDONGXN.Text Is Nothing Then
                    txtID_HOATDONGXN.Text = obj.Add(inf)
                Else
                    inf.ID_HOATDONGXN = txtID_HOATDONGXN.Text
                    obj.Update(inf)
                End If
                Update_HOATDONGXNC(txtID_HOATDONGXN.Text)
                Tongcong()
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

        Private Sub Update_HOATDONGXNC(ByVal ID_Baocao As Integer)
            Dim obj1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCController
            Dim inf1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCInfo
            Dim obj2 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCController
            Dim inf2 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCInfo
            Try
                inf1.AmAFB1Mau = IIf(txtAFBAm1.Text = "", 0, txtAFBAm1.Text)
                inf1.AmAFB2Mau = IIf(txtAFBAm2.Text = "", 0, txtAFBAm2.Text)
                inf1.AmAFB3Mau = IIf(txtAFBAm3.Text = "", 0, txtAFBAm3.Text)
                inf1.DuongAFB1Mau = IIf(txtAFBDuong1.Text = "", 0, txtAFBDuong1.Text)
                inf1.DuongAFB2Mau = IIf(txtAFBDuong2.Text = "", 0, txtAFBDuong2.Text)
                inf1.DuongAFB3Mau = IIf(txtAFBDuong3.Text = "", 0, txtAFBDuong3.Text)
                inf1.SoBNDangky = IIf(txtSoBNDK.Text = "", 0, txtSoBNDK.Text)
                inf1.PHANLOAI = 0
                inf1.ID_HOATDONGXN = ID_Baocao
                If txtID_HOATDONGXNC.Text = "" Or txtID_HOATDONGXNC.Text Is Nothing Then
                    txtID_HOATDONGXNC.Text = obj1.Add(inf1)
                Else
                    inf1.ID_HOATDONGXNC = txtID_HOATDONGXNC.Text
                    obj1.Update(inf1)

                End If
                inf2.AmAFB1Mau = IIf(txtAFBAm11.Text = "", 0, txtAFBAm11.Text)
                inf2.AmAFB2Mau = IIf(txtAFBAm21.Text = "", 0, txtAFBAm21.Text)
                inf2.AmAFB3Mau = IIf(txtAFBAm31.Text = "", 0, txtAFBAm31.Text)
                inf2.DuongAFB1Mau = IIf(txtAFBDuong11.Text = "", 0, txtAFBDuong11.Text)
                inf2.DuongAFB2Mau = IIf(txtAFBDuong21.Text = "", 0, txtAFBDuong21.Text)
                inf2.DuongAFB3Mau = IIf(txtAFBDuong31.Text = "", 0, txtAFBDuong31.Text)
                inf2.SoBNDangky = IIf(txtSoBNDK1.Text = "", 0, txtSoBNDK1.Text)
                inf2.PHANLOAI = 1
                inf2.ID_HOATDONGXN = ID_Baocao
                If txtID_HOATDONGXNC1.Text = "" Or txtID_HOATDONGXNC1.Text Is Nothing Then
                    txtID_HOATDONGXNC1.Text = obj2.Add(inf2)
                Else
                    inf2.ID_HOATDONGXNC = txtID_HOATDONGXNC1.Text
                    obj2.Update(inf2)

                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)

            End Try

        End Sub



        Private Sub LoadDetail(ByVal ID_Baocao As Integer)

            Try
                Dim obj As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCController
                Dim inf As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCInfo
                Dim obj1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCController
                Dim inf1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCInfo
                inf = obj.ListHOATDONGXNC(ID_Baocao, 0)
                If Not inf Is Nothing Then
                    txtAFBAm1.Text = inf.AmAFB1Mau
                    txtAFBAm2.Text = inf.AmAFB2Mau
                    txtAFBAm3.Text = inf.AmAFB3Mau
                    txtAFBDuong1.Text = inf.DuongAFB1Mau
                    txtAFBDuong2.Text = inf.DuongAFB2Mau
                    txtAFBDuong3.Text = inf.DuongAFB3Mau
                    txtSoBNDK.Text = inf.SoBNDangky
                    txtID_HOATDONGXNC.Text = inf.ID_HOATDONGXNC
                End If
                inf1 = obj.ListHOATDONGXNC(ID_Baocao, 1)
                If Not inf1 Is Nothing Then
                    txtAFBAm11.Text = inf1.AmAFB1Mau
                    txtAFBAm21.Text = inf1.AmAFB2Mau
                    txtAFBAm31.Text = inf1.AmAFB3Mau
                    txtAFBDuong11.Text = inf1.DuongAFB1Mau
                    txtAFBDuong21.Text = inf1.DuongAFB2Mau
                    txtAFBDuong31.Text = inf1.DuongAFB3Mau
                    txtSoBNDK1.Text = inf1.SoBNDangky
                    txtID_HOATDONGXNC1.Text = inf1.ID_HOATDONGXNC
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try

        End Sub
     

        Protected Sub BindGrdKetQuaDT(ByVal ID_BCThunhanBNLao As String)
            Dim obj1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCController
            Dim inf1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNCInfo
            Try
             
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub


      

        Protected Sub cboDonVi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDonVi.SelectedIndexChanged
            NTP_Common.SetFormFocus(Me.txtNam, Me.ModuleConfiguration.SupportsPartialRendering)
        End Sub


       

        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect(NavigateURL())
        End Sub
        Private Sub Tongcong()
            LblTong1.Text = CInt(IIf(txtAFBAm1.Text = "", 0, txtAFBAm1.Text)) _
                        + CInt(IIf(txtAFBAm2.Text = "", 0, txtAFBAm2.Text)) _
                        + CInt(IIf(txtAFBAm3.Text = "", 0, txtAFBAm3.Text)) _
                        + CInt(IIf(txtAFBDuong1.Text = "", 0, txtAFBDuong1.Text)) _
                        + CInt(IIf(txtAFBDuong2.Text = "", 0, txtAFBDuong2.Text)) _
                        + CInt(IIf(txtAFBDuong3.Text = "", 0, txtAFBDuong3.Text))

            LblTong2.Text = CInt(IIf(txtAFBAm11.Text = "", 0, txtAFBAm11.Text)) _
                        + CInt(IIf(txtAFBAm21.Text = "", 0, txtAFBAm21.Text)) _
                        + CInt(IIf(txtAFBAm31.Text = "", 0, txtAFBAm31.Text)) _
                        + CInt(IIf(txtAFBDuong11.Text = "", 0, txtAFBDuong11.Text)) _
                        + CInt(IIf(txtAFBDuong21.Text = "", 0, txtAFBDuong21.Text)) _
                        + CInt(IIf(txtAFBDuong31.Text = "", 0, txtAFBDuong31.Text))
            TxtTong2.Text = CInt(IIf(txtAFBAm1.Text = "", 0, txtAFBAm1.Text)) _
                        + CInt(IIf(txtAFBAm2.Text = "", 0, txtAFBAm2.Text)) _
                        + CInt(IIf(txtAFBAm3.Text = "", 0, txtAFBAm3.Text))
            TxtTong1.Text = CInt(IIf(txtAFBDuong1.Text = "", 0, txtAFBDuong1.Text)) _
                        + CInt(IIf(txtAFBDuong2.Text = "", 0, txtAFBDuong2.Text)) _
                        + CInt(IIf(txtAFBDuong3.Text = "", 0, txtAFBDuong3.Text))
            TxtTong11.Text = CInt(IIf(txtAFBDuong11.Text = "", 0, txtAFBDuong11.Text)) _
                                   + CInt(IIf(txtAFBDuong21.Text = "", 0, txtAFBDuong21.Text)) _
                                   + CInt(IIf(txtAFBDuong31.Text = "", 0, txtAFBDuong31.Text))
            TxtTong21.Text = CInt(IIf(txtAFBAm11.Text = "", 0, txtAFBAm11.Text)) _
                        + CInt(IIf(txtAFBAm21.Text = "", 0, txtAFBAm21.Text)) _
                        + CInt(IIf(txtAFBAm31.Text = "", 0, txtAFBAm31.Text))

            LblTongPH.Text = CInt(IIf(Me.txtSoTBPhatHienAm.Text = "", 0, Me.txtSoTBPhatHienAm.Text)) + CInt(IIf(Me.txtSoTBPhatHienDuong.Text = "", 0, Me.txtSoTBPhatHienDuong.Text))
            LblTongTD.Text = CInt(IIf(Me.txtSoTBTheoDoiAm.Text = "", 0, Me.txtSoTBTheoDoiAm.Text)) + CInt(IIf(Me.txtSoTBTheoDoiDuong.Text = "", 0, Me.txtSoTBTheoDoiDuong.Text))
            LblTongcong.Text = CInt(LblTongPH.Text) + CInt(LblTongTD.Text)
        End Sub
        Protected Sub cmdCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
            Me.txtID_HOATDONGXN.Text = ""
            Me.txtNam.Text = Year(Now)
            Me.txtNguoiBaoCao.Text = ""
            If Month(Now) >= 1 And Month(Now) <= 3 Then
                Me.cboQuy.SelectedValue = 1
            ElseIf Month(Now) >= 4 And Month(Now) <= 6 Then
                Me.cboQuy.SelectedValue = 2
            ElseIf Month(Now) >= 7 And Month(Now) <= 9 Then
                Me.cboQuy.SelectedValue = 3
            ElseIf Month(Now) >= 10 And Month(Now) <= 12 Then
                Me.cboQuy.SelectedValue = 4
            End If
            SetValue(Me.txtNgayBaoCao, Now, enuDATA_TYPE.DATE_TYPE)
            Me.cboDonVi.SelectedValue = ""
            ClearDetail()
            cmdCreateNew.Enabled = False
            cmdAdd.Enabled = True
        End Sub
        Private Sub ClearDetail()
            Me.txtSoTBPhatHienAm.Text = ""
            Me.txtSoTBPhatHienDuong.Text = ""
            Me.txtSoTBTheoDoiAm.Text = ""
            Me.txtSoTBTheoDoiDuong.Text = ""
            TxtTong1.Text = ""
            TxtTong11.Text = ""
            TxtTong2.Text = ""
            TxtTong21.Text = ""
            txtAFBAm3.Text = ""
            txtAFBAm1.Text = ""
            txtAFBAm2.Text = ""
            txtAFBDuong1.Text = ""
            txtAFBDuong3.Text = ""
            txtAFBDuong2.Text = ""
            Me.txtID_HOATDONGXNC.Text = ""
            txtAFBAm31.Text = ""
            txtAFBAm11.Text = ""
            txtAFBAm21.Text = ""
            txtAFBDuong11.Text = ""
            txtAFBDuong31.Text = ""
            txtAFBDuong21.Text = ""
            Me.txtID_HOATDONGXNC1.Text = ""
            LblTong1.Text = 0
            LblTong2.Text = 0
            TxtTong1.Text = 0
            TxtTong2.Text = 0
            TxtTong21.Text() = 0
            TxtTong11.Text = 0
            LblTongPH.Text = 0
            LblTongTD.Text = 0
            LblTongcong.Text = 0
            txtSoBNDK.Text = ""
            txtSoBNDK1.Text = ""

        End Sub

        Protected Sub CmdXem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdXem.Click
            Dim obj As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
            Dim inf As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNInfo
            Dim obj1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNController
            Dim inf1 As New NTP_KD_BC_HOATDONGXN.NTP_KD_BC_HOATDONGXNInfo
            Try
                If txtNam.Text <> "" And cboDonVi.SelectedValue <> "" Then
                    inf1 = obj1.GET_ID_BAOCAO(cboQuy.SelectedValue, txtNam.Text, cboDonVi.SelectedValue)

                    If Not inf1 Is Nothing Then
                        Me.txtID_HOATDONGXN.Text = inf1.ID_HOATDONGXN
                        inf = obj.Get(Me.txtID_HOATDONGXN.Text)
                        Me.txtNam.Text = inf.Nam
                        SetValue(Me.txtNgayBaoCao, inf.NgayBC, enuDATA_TYPE.DATE_TYPE)
                        Me.cboDonVi.SelectedValue = inf.ID_BENHVIEN
                        Me.txtNguoiBaoCao.Text = inf.NguoiBC
                        Me.cboQuy.SelectedValue = inf.Quy
                        ClearDetail()
                        Me.txtSoTBPhatHienAm.Text = inf.SoTBPhathienA
                        Me.txtSoTBPhatHienDuong.Text = inf.SoTBPhathienD
                        Me.txtSoTBTheoDoiAm.Text = inf.SoTBTheodoiA
                        Me.txtSoTBTheoDoiDuong.Text = inf.SoTBTheodoiD
                        LoadDetail(txtID_HOATDONGXN.Text)
                        Tongcong()
                    Else
                        DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, "Không có số liệu. ", Skins.Controls.ModuleMessage.ModuleMessageType.YellowWarning)

                    End If
                End If
            Catch sqlex As SqlException
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(Me, NTP_Common.ProcessSQLError(sqlex), Skins.Controls.ModuleMessage.ModuleMessageType.RedError)
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            Finally
                obj = Nothing
                inf = Nothing
                obj1 = Nothing
                inf1 = Nothing
            End Try
        End Sub

        Protected Sub LblTongcong_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblTongcong.TextChanged

        End Sub
    End Class

End Namespace