Public Class Configuration
    Public Shared ReadOnly Property SQLConnectionString() As String
        Get
            Return System.Web.Configuration.WebConfigurationManager.AppSettings("SiteSqlServer")
        End Get
    End Property

    Public Shared ReadOnly Property ReportDirectory() As String
        Get
            Return System.Web.Configuration.WebConfigurationManager.AppSettings("ReportDirectory")
        End Get
    End Property

    Public Shared ReadOnly Property DownloadDirectory() As String
        Get
            Return System.Web.Configuration.WebConfigurationManager.AppSettings("DownloadDirectoryName")
        End Get
    End Property

End Class
