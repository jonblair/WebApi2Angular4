Imports Vizion.Models
'Imports Queries.Persistence.EntityConfigurations
Imports System.Data.Entity

Public Class VizionWMSDataContext : Inherits DbContext

    Public Sub New()
        MyBase.New("name=VizionWMSDataContext")
        Me.Configuration.LazyLoadingEnabled = False
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Database.SetInitializer(Of VizionWMSDataContext)(Nothing)
        MyBase.OnModelCreating(modelBuilder)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        Dispose()
    End Sub

    Public Property User() As DbSet(Of User)
        Get
            Return m_User
        End Get
        Set
            m_User = Value
        End Set
    End Property
    Private m_User As DbSet(Of User)

    Public Property Customer() As DbSet(Of Customer)
        Get
            Return m_Customer
        End Get
        Set
            m_Customer = Value
        End Set
    End Property
    Private m_Customer As DbSet(Of Customer)
End Class
