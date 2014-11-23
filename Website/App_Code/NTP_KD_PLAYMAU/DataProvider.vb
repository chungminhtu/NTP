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

Imports System
Imports DotNetNuke

Namespace YourCompany.Modules.NTP_KD_PLAYMAU

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' An abstract class for the data access layer
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

        ' singleton reference to the instantiated object 
        Private Shared objProvider As DataProvider = Nothing

        ' constructor
        Shared Sub New()
            CreateProvider()
        End Sub

        ' dynamically create provider
        Private Shared Sub CreateProvider()
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_KD_PLAYMAU", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region


#Region "NTP_KD_PLAYMAU Methods"
        Public MustOverride Function GetNTP_KD_PLAYMAU(ByVal iD_PLAYMAU As Integer) As IDataReader
        Public MustOverride Function ListNTP_KD_PLAYMAU() As IDataReader
        Public MustOverride Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal opt As Integer, ByVal Id_MATINH As String) As IDataReader
        Public MustOverride Function AddNTP_KD_PLAYMAU(ByVal thangLM As Integer, ByVal Nam As Integer, ByVal mA_TINH As String, ByVal iD_BENHVIEN As String, ByVal kTVien As String, ByVal nhanxet As String, ByVal nGUOI_NM As Integer, ByVal NgayLM As DateTime, ByVal SoTBThuchien As Integer, ByVal SoTBCanKD As Integer) As Integer
        Public MustOverride Sub UpdateNTP_KD_PLAYMAU(ByVal iD_PLAYMAU As Integer, ByVal thangLM As Integer, ByVal Nam As Integer, ByVal mA_TINH As String, ByVal iD_BENHVIEN As String, ByVal kTVien As String, ByVal nhanxet As String, ByVal nGUOI_NM As Integer, ByVal NgayLM As DateTime, ByVal SoTBThuchien As Integer, ByVal SoTBCanKD As Integer)
        Public MustOverride Sub UpdateNTP_KD_PLAYMAU_LAN1(ByVal iD_PLAYMAU As Integer, ByVal ngayKD1 As DateTime, ByVal kDVien1 As String, ByVal nhanxet1 As String)
        Public MustOverride Sub UpdateNTP_KD_PLAYMAU_LAN2(ByVal iD_PLAYMAU As Integer, ByVal ngayKD2 As DateTime, ByVal kDVien2 As String, ByVal nhanxet2 As String)
        Public MustOverride Sub DeleteNTP_KD_PLAYMAU(ByVal iD_PLAYMAU As Integer)
        Public MustOverride Function IN_PHIEULAYMAU(ByVal THANG As Integer, ByVal NAM As Integer, ByVal ID_BENHVIEN As String) As DataSet
        Public MustOverride Function IN_PHIEULAYMAU_KQKDLAN2(ByVal THANG As Integer, ByVal NAM As Integer, ByVal ID_BENHVIEN As String) As DataSet
        Public MustOverride Sub DeleteNTP_KD_PLAYMAU_C_KQLAN1(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)
        Public MustOverride Sub DeleteNTP_KD_PLAYMAU_C_KQLAN2(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)

#End Region



#Region "NTP_KD_PLAYMAU_C Methods"
        Public MustOverride Function GetNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer) As IDataReader
        Public MustOverride Function ListNTP_KD_PLAYMAU_C(ByVal Id_PhieuLAYMAU As Integer) As IDataReader
        Public MustOverride Function ListLan1NTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer) As IDataReader
        Public MustOverride Function ListLan2NTP_KD_PLAYMAU_C(ByVal Id_PhieuLAYMAU As Integer) As IDataReader
        Public MustOverride Function AddNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal soTB As String, ByVal kiemdinhH As String, ByVal ghichu As String) As Integer
        Public MustOverride Sub UpdateNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal soTB As String, ByVal kiemdinhH As String, ByVal ghichu As String)
        Public MustOverride Sub UpdateNTP_KD_PLAYMAU_C_KQLAN1(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal kiemdinhT1 As String, ByVal chatluong As Byte, ByVal taymau As Byte, ByVal dosach As Byte, ByVal doDay As Byte, ByVal kichco As Byte, ByVal domin As Byte, ByVal ghichu As String)
        Public MustOverride Sub UpdateNTP_KD_PLAYMAU_C_KQLAN2(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal kiemdinhT2 As String, ByVal ghichu As String)
       

        'Public MustOverride Function AddNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal soTB As String, ByVal kiemdinhH As String, ByVal kiemdinhT1 As String, ByVal kiemDinhT2 As String, ByVal chatluong As Byte, ByVal taymau As Byte, ByVal dosach As Byte, ByVal doDay As Byte, ByVal kichco As Byte, ByVal domin As Byte, ByVal ghichu As String) As Integer
        'Public MustOverride Sub UpdateNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU_C As Integer, ByVal iD_PLAYMAU As Integer, ByVal iD_Phieuxetnghiem_C As Integer, ByVal soTB As String, ByVal kiemdinhH As String, ByVal kiemdinhT1 As String, ByVal kiemDinhT2 As String, ByVal chatluong As Byte, ByVal taymau As Byte, ByVal dosach As Byte, ByVal doDay As Byte, ByVal kichco As Byte, ByVal domin As Byte, ByVal ghichu As String)
        Public MustOverride Sub DeleteNTP_KD_PLAYMAU_C(ByVal iD_PLAYMAU As Integer, ByVal iD_PLAYMAU_C As Integer)
      
#End Region


    End Class

End Namespace