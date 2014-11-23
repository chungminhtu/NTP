Public Class Common
    Public Shared Function GetNull(ByVal objInput As Object) As Object
        If objInput Is Nothing Then
            Return DBNull.Value
        Else
            If objInput.GetType.Equals(GetType(Date)) Then
                If CType(objInput, Date) = Date.MinValue Then
                    Return DBNull.Value
                End If
            ElseIf objInput.GetType.Equals(GetType(String)) Then
                If CType(objInput, String).Trim = "" Then
                    Return DBNull.Value
                End If
            ElseIf objInput.GetType.Equals(GetType(Integer)) Then
                If CType(objInput, Integer) = -1 Then
                    Return DBNull.Value
                End If
            End If
            Return objInput
        End If

    End Function


    Public Shared Function SetNull(ByVal iType As enuDATA_TYPE) As Object
        Dim ret As Object
        Select Case iType
            Case enuDATA_TYPE.DATE_TYPE
                ret = Date.MinValue
            Case enuDATA_TYPE.INTEGER_TYPE
                ret = -1
            Case enuDATA_TYPE.NUMERIC_TYPE
                ret = -1
        End Select
        Return ret
    End Function

    Public Shared Function SetStockOfCurrentUser(ByVal iUserID As Integer) As NTP_DM_USER_KHO_Info
        Dim dr As SqlClient.SqlDataReader
        Dim ar As New ArrayList
        dr = NTP_DAL.SqlHelper.ExecuteReader(NTP_Common.Configuration.SQLConnectionString, "NTP_GetStockOfCurrentUser", iUserID)
        Dim obj As New NTP_DM_USER_KHO_Info
        While dr.Read
            obj.USERID = iUserID
            obj.ID_KHO_QLVT = dr("ID_KHO_QLVT")
            obj.ID_KHO_TTBI = dr("ID_KHO_TTBI")
            obj.ID_KHO_THUOC = dr("ID_KHO_THUOC")
            obj.ID_BENHVIEN = dr("ID_BENHVIEN")
            obj.TEN_KHO_QLVT = dr("TEN_KHO_QLVT")
            obj.TEN_KHO_TTBI = dr("TEN_KHO_QLTTBI")
            obj.TEN_KHO_THUOC = dr("TEN_KHO_THUOC")
            obj.TEN_BENHVIEN = dr("TEN_BENHVIEN")
            obj.ID_MATINH = dr("ID_MATINH")
            Try
                obj.TEN_TINH = dr("TEN_TINH")
            Catch ex As Exception
                obj.TEN_TINH = "host"
            End Try
            obj.CAPQUANLY = dr("CAPQUANLY")
        End While
        Return obj
    End Function

End Class

Public Class NTP_DM_USER_KHO_Info

    Private _USERID As Integer
    Private _ID_KHO_QLVT As Integer
    Private _ID_KHO_TTBI As Integer
    Private _ID_KHO_THUOC As Integer
    Private _ID_BENHVIEN As String
    Private _ID_MATINH As String
    Private _TEN_KHO_QLVT As String
    Private _TEN_KHO_TTBI As String
    Private _TEN_KHO_THUOC As String
    Private _TEN_BENHVIEN As String
    Private _TEN_TINH As String
    Private _CAPQUANLY As Integer


    Public Sub New()

    End Sub

    Public Property USERID() As Integer
        Get
            Return _USERID
        End Get
        Set(ByVal Value As Integer)
            _USERID = Value
        End Set
    End Property
    Public Property ID_MATINH() As String
        Get
            Return _ID_MATINH
        End Get
        Set(ByVal Value As String)
            _ID_MATINH = Value
        End Set
    End Property

    Public Property ID_KHO_QLVT() As Integer
        Get
            Return _ID_KHO_QLVT
        End Get
        Set(ByVal Value As Integer)
            _ID_KHO_QLVT = Value
        End Set
    End Property

    Public Property ID_KHO_TTBI() As Integer
        Get
            Return _ID_KHO_TTBI
        End Get
        Set(ByVal Value As Integer)
            _ID_KHO_TTBI = Value
        End Set
    End Property

    Public Property ID_KHO_THUOC() As Integer
        Get
            Return _ID_KHO_THUOC
        End Get
        Set(ByVal Value As Integer)
            _ID_KHO_THUOC = Value
        End Set
    End Property

    Public Property ID_BENHVIEN() As String
        Get
            Return _ID_BENHVIEN
        End Get
        Set(ByVal Value As String)
            _ID_BENHVIEN = Value
        End Set
    End Property


    Public Property TEN_KHO_QLVT() As String
        Get
            Return _TEN_KHO_QLVT
        End Get
        Set(ByVal Value As String)
            _TEN_KHO_QLVT = Value
        End Set
    End Property

    Public Property TEN_KHO_TTBI() As String
        Get
            Return _TEN_KHO_TTBI
        End Get
        Set(ByVal Value As String)
            _TEN_KHO_TTBI = Value
        End Set
    End Property

    Public Property TEN_KHO_THUOC() As String
        Get
            Return _TEN_KHO_THUOC
        End Get
        Set(ByVal Value As String)
            _TEN_KHO_THUOC = Value
        End Set
    End Property

    Public Property TEN_BENHVIEN() As String
        Get
            Return _TEN_BENHVIEN
        End Get
        Set(ByVal Value As String)
            _TEN_BENHVIEN = Value
        End Set
    End Property

    Public Property TEN_TINH() As String
        Get
            Return _TEN_TINH
        End Get
        Set(ByVal Value As String)
            _TEN_TINH = Value
        End Set
    End Property

    Public Property CAPQUANLY() As Integer
        Get
            Return _CAPQUANLY
        End Get
        Set(ByVal Value As Integer)
            _CAPQUANLY = Value
        End Set
    End Property


End Class


