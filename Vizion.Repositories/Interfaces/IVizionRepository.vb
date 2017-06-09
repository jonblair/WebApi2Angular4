Imports System
Imports Vizion.Models
Imports Vizion.Repositories

Public Interface IVizionRepository : Inherits IDisposable
    Property Users() As IUserRepository


    Function Complete() As Integer
End Interface
