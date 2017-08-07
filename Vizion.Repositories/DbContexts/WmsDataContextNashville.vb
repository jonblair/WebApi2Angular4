Imports Demo.Models
'Imports Queries.Persistence.EntityConfigurations
Imports System.Data.Entity

Public Class WmsDataContextNashville : Inherits DbContext

    Public Sub New()
        MyBase.New("name=WMSDataContextNashville")
        Me.Configuration.LazyLoadingEnabled = False
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Database.SetInitializer(Of WmsDataContextDev)(Nothing)
        MyBase.OnModelCreating(modelBuilder)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        Dispose()
    End Sub

    Public Property Inventory() As DbSet(Of Inventory)
        Get
            Return m_Inventory
        End Get
        Set
            m_Inventory = Value
        End Set
    End Property
    Private m_Inventory As DbSet(Of Inventory)
End Class
