Imports System
Imports Vizion.Models
Imports Vizion.Repositories

Public Interface IDbRepository : Inherits IDisposable
    Property Users() As IUserRepository
    Property Customers() As ICustomerRepository
    Property Shipments() As IShipmentRepository
    Property Inventory() As IInventoryRepository
    Function Complete() As Integer
End Interface
