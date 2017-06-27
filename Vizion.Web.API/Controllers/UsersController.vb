Imports System.Net
Imports System.Web.Http
Imports System.Collections.Generic
Imports System.Linq
Imports Vizion.Models
Imports System.Web.Http.Description
Imports System.Threading.Tasks
Imports Vizion.Repositories
Imports System.Linq.Expressions
Imports System.Data.Entity
Imports System.Net.Http

Namespace Controllers
    <RoutePrefix("api/users")>
    Public Class UsersController : Inherits ApiController
        Private ReadOnly _dbWmsDataRepository As IDbRepository
        Public Sub New()
            _dbWmsDataRepository = New DBRepository(New WmsDataContext())
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()

            _dbWmsDataRepository.Dispose()
        End Sub

        <HttpGet>
        Public Function [Get]() As IHttpActionResult
            Dim myUsers = _dbWmsDataRepository.Users.GetAll.OrderBy(Function(x) x.Id).ToList

            If myUsers.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myUsers)
        End Function

        <HttpGet>
        <Route("{id:int:min(1)}")>
        <ResponseType(GetType(User))>
        Public Function GetUser(id As Integer) As IHttpActionResult
            Dim myUser As User = _dbWmsDataRepository.Users.Get(id)

            If myUser Is Nothing Then
                Return NotFound()
            End If
            Return Ok(myUser)
        End Function

        <HttpGet>
        <Route("{name}")>
        Public Function GetUserByName(name As String) As IHttpActionResult
            Dim myUsers = Me.GetBySearch(Function(x) x.FirstName.Contains(name) Or
                                             x.LastName.Contains(name) Or
                                             x.FirstName.Contains(name) & x.LastName.Contains(name)).OrderBy(Function(x) x.Id).ToList()
            If myUsers.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myUsers)
        End Function


#Region "Private Methods"
        Private Function GetBySearch(expression As Expression(Of Func(Of User, Boolean))) As List(Of User)
            Return _dbWmsDataRepository.Users.Search(expression).ToList()
        End Function
#End Region
    End Class
End Namespace