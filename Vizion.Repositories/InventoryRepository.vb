Imports Vizion.Models
Imports Vizion.Repositories
Imports System.Data.Entity

Public Interface IInventoryRepository : Inherits IRepository(Of Inventory)
    Function GetInventoryByCustomer(customer As String) As List(Of Inventory)
End Interface

Public Class InventoryRepository : Inherits Repository(Of Inventory)
    Implements IInventoryRepository

    Public Sub New(context As DbContext)
        MyBase.New(context)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        _dbContext.Dispose()
    End Sub

    Public ReadOnly Property _dbContext() As DbContext
        Get
            Return TryCast(Context, DbContext)
        End Get
    End Property

    Public Function GetInventoryByCustomer(customer As String) As List(Of Inventory) Implements IInventoryRepository.GetInventoryByCustomer
        Return Context.[Set](Of Inventory)().Where(Function(x) x.Customer = customer).ToList()
    End Function
End Class

