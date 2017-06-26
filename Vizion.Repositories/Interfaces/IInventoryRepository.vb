Imports Vizion.Models

Public Interface IInventoryRepository : Inherits IRepository(Of Inventory)
    Function GetInventoryByCustomer(customer As String) As List(Of Inventory)
End Interface