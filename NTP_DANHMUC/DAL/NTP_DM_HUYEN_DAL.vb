Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke

Public Class NTP_DM_HUYEN_DAL


    Private Shared _thisInstance As NTP_DM_HUYEN_DAL
    Private Shared PadLock As New Object

    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared Function Instance() As NTP_DM_HUYEN_DAL
        '
        ' Prevents multiple threads from creating
        ' separate instances
        '
        SyncLock PadLock
            '
            ' initialize object if it hasn't already been done
            '
            If _thisInstance Is Nothing Then
                _thisInstance = New NTP_DM_HUYEN_DAL
            End If
            '
            ' return the initialized instance
            '
            Return _thisInstance
        End SyncLock
    End Function

    Public Sub InsertItem(ByVal bibi As NTP_DM_HUYEN_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
                     "NTP_DM_HUYEN_Insert", _
                     Getnull(bibi.MA_HUYEN), _
                     Getnull(bibi.TEN_HUYEN), _
                     Getnull(bibi.MA_TINH))

    End Sub

    Public Sub UpdateItem(ByVal bibi As NTP_DM_HUYEN_Info)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_HUYEN_Update", _
         Getnull(bibi.MA_HUYEN), _
         Getnull(bibi.TEN_HUYEN), _
         Getnull(bibi.MA_TINH))
    End Sub

    Public Sub DeleteItem(ByVal MA_HUYEN As String)
        SqlHelper.ExecuteNonQuery(SQLConnectionString, _
         "NTP_DM_HUYEN_Delete", _
         Getnull(MA_HUYEN))
    End Sub

    Public Function SelectItem(ByVal MA_HUYEN As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
         "NTP_DM_HUYEN_Select", _
         Getnull(MA_HUYEN))
    End Function

    Public Function SelectAllItems() As DataSet
        Return SqlHelper.ExecuteDataSet(SQLConnectionString, _
         "NTP_DM_HUYEN_SelectList")
    End Function


    Public Function Search(ByVal sTenHuyen As String, ByVal sTinh As String) As DataSet
        Return SqlHelper.ExecuteDataset(SQLConnectionString, _
          "NTP_DM_HUYEN_Search", Getnull(sTenHuyen), Getnull(sTinh))
    End Function

    ''' <summary>
    ''' TungND3 : gen ID Huyen
    ''' </summary>
    ''' <param name="MA_TINH"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetID(ByVal MA_TINH As String) As String
        Dim str As String = ""
        Try
            Dim ID As Integer = SqlHelper.ExecuteScalar(SQLConnectionString, _
              "NTP_DM_HUYEN_GetID", GetNull(MA_TINH))
            If ID < 1000 Then
                Str = "0" + ID.ToString
            Else
                Str = ID.ToString
            End If
        Catch ex As Exception

        End Try
        Return str
    End Function
End Class
