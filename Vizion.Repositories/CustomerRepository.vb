Imports Vizion.Models
Imports Vizion.Repositories
Imports System.Data.Entity

Public Class CustomerRepository : Inherits Repository(Of Customer)
    Implements ICustomerRepository

    Private myCustomerList As List(Of Customer)
    Private myCustomer As Customer

    Public Sub New(context As DbContext)
        MyBase.New(context)

        myCustomerList = New List(Of Customer)
        myCustomer = New Customer
    End Sub

    Public ReadOnly Property _dbContext() As DbContext
        Get
            Return TryCast(Context, DbContext)
        End Get
    End Property
End Class
