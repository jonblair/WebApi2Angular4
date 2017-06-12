Imports System.Data.Entity
Imports System.Linq.Expressions
Imports Vizion.Models
Imports Vizion.Repositories


Public Class UserService
    Private ReadOnly _dbRepository As IDbRepository

    Public Sub New()
        _dbRepository = New DBRepository(New VizionWMSDataContext())
    End Sub

    Public Function GetUsers() As List(Of User)
        Return _dbRepository.Users.GetAll.OrderBy(Function(x) x.Id).ToList()
    End Function

    Public Function GetUserById(ByVal userId As Integer) As User
        Return _dbRepository.Users.Get(userId)
    End Function

    Public Function GetUsersByNameSearch(ByVal name As String) As List(Of User)
        Return GetBySearch(Function(x) x.FullName Like name)
    End Function

#Region "Private Methods"
    Private Function GetBySearch(expression As Expression(Of Func(Of User, Boolean))) As List(Of User)
        Return _dbRepository.Users.Search(expression)
    End Function
#End Region
End Class
