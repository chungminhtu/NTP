﻿Public Class NTP_CU_HC_IMPORT_Info

    Private _ID_IMPORT As Double
    Private _ID_KHO As Double
    Private _ID_VATTU As Integer
    Private _ID_NGUONKINHPHI As Integer
    Private _NGAY_NHAP_KHO As Date
    Private _LO_SX As String
    Private _HAN_DUNG As Date
    Private _SO_LUONG As Double
    Private _NGAY_NM As Date
    Private _NGUOI_NM As Integer
    Private _TRANG_THAI As Integer
    Private _MA_PHIEU As String
    Private _NGAY_SX As Date
    Private _NGUOI_VIETPHIEU As String
    Private _LOAI_NHAP As Integer
    Public Sub New()

    End Sub

    Public Property ID_IMPORT() As Double
        Get
            Return _ID_IMPORT
        End Get
        Set(ByVal Value As Double)
            _ID_IMPORT = Value
        End Set
    End Property

    Public Property ID_KHO() As Double
        Get
            Return _ID_KHO
        End Get
        Set(ByVal Value As Double)
            _ID_KHO = Value
        End Set
    End Property

    Public Property ID_VATTU() As Integer
        Get
            Return _ID_VATTU
        End Get
        Set(ByVal Value As Integer)
            _ID_VATTU = Value
        End Set
    End Property

    Public Property ID_NGUONKINHPHI() As Integer
        Get
            Return _ID_NGUONKINHPHI
        End Get
        Set(ByVal Value As Integer)
            _ID_NGUONKINHPHI = Value
        End Set
    End Property

    Public Property NGAY_NHAP_KHO() As Date
        Get
            Return _NGAY_NHAP_KHO
        End Get
        Set(ByVal Value As Date)
            _NGAY_NHAP_KHO = Value
        End Set
    End Property

    Public Property LO_SX() As String
        Get
            Return _LO_SX
        End Get
        Set(ByVal Value As String)
            _LO_SX = Value
        End Set
    End Property

    Public Property HAN_DUNG() As Date
        Get
            Return _HAN_DUNG
        End Get
        Set(ByVal Value As Date)
            _HAN_DUNG = Value
        End Set
    End Property

    Public Property SO_LUONG() As Double
        Get
            Return _SO_LUONG
        End Get
        Set(ByVal Value As Double)
            _SO_LUONG = Value
        End Set
    End Property

    Public Property NGAY_NM() As Date
        Get
            Return _NGAY_NM
        End Get
        Set(ByVal Value As Date)
            _NGAY_NM = Value
        End Set
    End Property

    Public Property NGUOI_NM() As Integer
        Get
            Return _NGUOI_NM
        End Get
        Set(ByVal Value As Integer)
            _NGUOI_NM = Value
        End Set
    End Property

    Public Property TRANG_THAI() As Integer
        Get
            Return _TRANG_THAI
        End Get
        Set(ByVal Value As Integer)
            _TRANG_THAI = Value
        End Set
    End Property

    Public Property MA_PHIEU() As String
        Get
            Return _MA_PHIEU
        End Get
        Set(ByVal value As String)
            _MA_PHIEU = value
        End Set
    End Property

    Public Property NGAY_SX() As Date
        Get
            Return _NGAY_SX
        End Get
        Set(ByVal value As Date)
            _NGAY_SX = value
        End Set
    End Property

    Public Property NGUOI_VIETPHIEU() As String
        Get
            Return _NGUOI_VIETPHIEU
        End Get
        Set(ByVal value As String)
            _NGUOI_VIETPHIEU = value
        End Set
    End Property

    Public Property LOAI_NHAP() As Integer
        Get
            Return _LOAI_NHAP
        End Get
        Set(ByVal value As Integer)
            _LOAI_NHAP = value
        End Set
    End Property
End Class
