Imports Vizion.Models
'Imports Queries.Persistence.EntityConfigurations
Imports System.Data.Entity

Public Class VizionWMSReportsContext : Inherits DbContext

    Public Sub New()
        MyBase.New("name=VizionWMSReportsContext")
        Me.Configuration.LazyLoadingEnabled = False
    End Sub

End Class
