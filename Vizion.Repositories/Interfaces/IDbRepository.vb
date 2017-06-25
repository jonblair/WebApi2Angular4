Imports System
Imports Vizion.Models
Imports Vizion.Repositories

Public Interface IDbRepository : Inherits IDisposable
    Property Users() As IUserRepository
    Property Customers() As ICustomerRepository
    Function Complete() As Integer
End Interface
