Imports Vizion.Models
Imports Vizion.Repositories
Imports System.Data.Entity

Public Interface IInventoryRepository : Inherits IRepository(Of Inventory)
    Function GetInventoryByCustomer(customer As String) As List(Of Inventory)
    Function GetInventoryMetricsByPallets() As List(Of CustomerPalletMetrics)
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

    Public Function GetCurrentInventoryMetricsByPallets() As List(Of CustomerPalletMetrics) Implements IInventoryRepository.GetInventoryMetricsByPallets
        Dim metricsByPallets As List(Of CustomerPalletMetrics) = New List(Of CustomerPalletMetrics)

        Dim inventoryGrouped = Context.[Set](Of Inventory)().Where(Function(X) X.StorThru >= DateTime.Now).
            GroupBy(Function(x) x.Customer).[Select](Function(x) New With {
            Key .Customer = x.Key,
            Key .PalletCount = x.Distinct().Count()
            }).ToList()

        For Each item In inventoryGrouped
            Dim myCustomerPalletMetrics As CustomerPalletMetrics = New CustomerPalletMetrics

            myCustomerPalletMetrics.Customer = item.Customer
            myCustomerPalletMetrics.PalletCount = item.PalletCount

            metricsByPallets.Add(myCustomerPalletMetrics)
        Next


        Return metricsByPallets
    End Function
End Class

