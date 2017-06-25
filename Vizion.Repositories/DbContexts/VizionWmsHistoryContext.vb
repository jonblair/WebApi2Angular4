Imports Vizion.Models
'Imports Queries.Persistence.EntityConfigurations
Imports System.Data.Entity

Public Class VizionWmsHistoryContext : Inherits DbContext
    Public Sub New()
        MyBase.New("name=VizionWMSHistoryContext")
        Me.Configuration.LazyLoadingEnabled = False
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Database.SetInitializer(Of DbContext)(Nothing)
        MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class
