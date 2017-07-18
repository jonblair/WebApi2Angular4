Imports Vizion.Models
'Imports Queries.Persistence.EntityConfigurations
Imports System.Data.Entity

Public Class WmsReportsContextDev : Inherits DbContext
    Public Sub New()
        MyBase.New("name=WMSReportsContextDev")
        Me.Configuration.LazyLoadingEnabled = False
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Database.SetInitializer(Of DbContext)(Nothing)
        MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class
