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

Namespace YourCompany.Modules.NTP_KD_BC_KIEMDINHTB

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
            objProvider = CType(Framework.Reflection.CreateObject("data", "YourCompany.Modules.NTP_KD_BC_KIEMDINHTB", ""), DataProvider)
        End Sub

        ' return the provider
        Public Shared Shadows Function Instance() As DataProvider
            Return objProvider
        End Function

#End Region



        '#Region "NTP_KD_BC_KIEMDINHTB Methods"
        '        Public MustOverride Function GetNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer) As IDataReader
        '        Public MustOverride Function ListNTP_KD_BC_KIEMDINHTB() As IDataReader
        '        Public MustOverride Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String) As IDataReader
        '        Public MustOverride Function AddNTP_KD_BC_KIEMDINHTB(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPD As Integer, ByVal cLBPK As Integer, ByVal taymauDat As Integer, ByVal taymauQ As Integer, ByVal taymauC As Integer, ByVal dosachDat As Integer, ByVal dosachK As Integer, ByVal dodayDat As Integer, ByVal dodayD As Integer, ByVal dodayM As Integer, ByVal kichthuocDat As Integer, ByVal kichthuocT As Integer, ByVal kichthuocN As Integer, ByVal dominDat As Integer, ByVal dominK As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean) As Integer
        '        Public MustOverride Sub UpdateNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPD As Integer, ByVal cLBPK As Integer, ByVal taymauDat As Integer, ByVal taymauQ As Integer, ByVal taymauC As Integer, ByVal dosachDat As Integer, ByVal dosachK As Integer, ByVal dodayDat As Integer, ByVal dodayD As Integer, ByVal dodayM As Integer, ByVal kichthuocDat As Integer, ByVal kichthuocT As Integer, ByVal kichthuocN As Integer, ByVal dominDat As Integer, ByVal dominK As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean)
        '        Public MustOverride Sub DeleteNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer)
        '#End Region



#Region "NTP_KD_BC_KIEMDINHTB Methods"
        Public MustOverride Function GetNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer) As IDataReader
        Public MustOverride Function ListNTP_KD_BC_KIEMDINHTB() As IDataReader
        Public MustOverride Function GET_ID_BAOCAO(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_BENHVIEN As String) As IDataReader

        Public MustOverride Function AddNTP_KD_BC_KIEMDINHTB(ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPDat As Integer, ByVal taymauDat As Integer, ByVal dosachDat As Integer, ByVal dodayDat As Integer, ByVal kichthuocDat As Integer, ByVal dominDat As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal ngayBC As DateTime, ByVal NguoiBC As String, ByVal Loilon As Integer, ByVal Loinho As Integer, ByVal TongsoTBKiemdinh As Integer) As Integer
        Public MustOverride Sub UpdateNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer, ByVal quy As Byte, ByVal nam As Integer, ByVal iD_Benhvien As String, ByVal tSTBThuchien As Integer, ByVal tSTBCanthuchien As Integer, ByVal soTBKiemdinh As Integer, ByVal saiDlon As Integer, ByVal saiAlon As Integer, ByVal dLLon As Integer, ByVal saiDNho As Integer, ByVal saiANho As Integer, ByVal dLNho As Integer, ByVal cLBPDat As Integer, ByVal taymauDat As Integer, ByVal dosachDat As Integer, ByVal dodayDat As Integer, ByVal kichthuocDat As Integer, ByVal dominDat As Integer, ByVal ngay_NM As DateTime, ByVal nguoi_NM As String, ByVal pTNhap As Boolean, ByVal huyenXN As Boolean, ByVal tinhXN As Boolean, ByVal ngayBC As DateTime, ByVal NguoiBC As String, ByVal Loilon As Integer, ByVal Loinho As Integer, ByVal TongsoTBKiemdinh As Integer)
        Public MustOverride Sub DeleteNTP_KD_BC_KIEMDINHTB(ByVal iD_KiemdinhTB As Integer)
        Public MustOverride Function ListByDieuKien(ByVal Id_BenhVien As String, ByVal ThangNam As String, ByVal DieuKien As String, ByVal MA_TINH As String) As IDataReader
        Public MustOverride Function ListBaoCao(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
        Public MustOverride Function NTP_KD_BCTHUDOMPHBYHUYEN_IN(ByVal Tinh As String, ByVal Mien As Integer, ByVal Vung As Integer, ByVal Nam As Integer, ByVal Quy As String, ByVal DieuKien As String) As DataSet
        Public MustOverride Function InPhieuPhanhoiKQKD(ByVal Thang As String, ByVal Nam As Integer, ByVal id_Benhvien As String, ByVal LoaiBC As Integer, ByVal Dieukien As String) As DataSet
#End Region






    End Class

End Namespace