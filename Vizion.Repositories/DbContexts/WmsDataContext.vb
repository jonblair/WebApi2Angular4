﻿Imports Vizion.Models
'Imports Queries.Persistence.EntityConfigurations
Imports System.Data.Entity

Public Class WmsDataContext : Inherits DbContext

    Public Sub New()
        MyBase.New("name=WMSDataContext")
        Me.Configuration.LazyLoadingEnabled = False
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Database.SetInitializer(Of WmsDataContext)(Nothing)
        MyBase.OnModelCreating(modelBuilder)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        Dispose()
    End Sub

    Public Property Users() As DbSet(Of User)
        Get
            Return m_User
        End Get
        Set
            m_User = Value
        End Set
    End Property
    Private m_User As DbSet(Of User)

    Public Property Customers() As DbSet(Of Customer)
        Get
            Return m_Customer
        End Get
        Set
            m_Customer = Value
        End Set
    End Property
    Private m_Customer As DbSet(Of Customer)

    Public Property Shipments() As DbSet(Of Shipment)
        Get
            Return m_Shipment
        End Get
        Set
            m_Shipment = Value
        End Set
    End Property
    Private m_Shipment As DbSet(Of Shipment)

    Public Property Inventory() As DbSet(Of Inventory)
        Get
            Return m_Inventory
        End Get
        Set
            m_Inventory = Value
        End Set
    End Property
    Private m_Inventory As DbSet(Of Inventory)

    Public Property Appointments() As DbSet(Of Appointment)
        Get
            Return m_Appointment
        End Get
        Set
            m_Appointment = Value
        End Set
    End Property
    Private m_Appointment As DbSet(Of Appointment)
End Class