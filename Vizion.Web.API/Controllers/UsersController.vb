Imports System.Net
Imports System.Web.Http
Imports System.Collections.Generic
Imports System.Linq
Imports Vizion.Models
Imports Vizion.Services

Namespace Controllers
    <RoutePrefix("api/users")>
    Public Class UsersController : Inherits ApiController
        Private ReadOnly myUserService As UserService
        Public Sub New()
            myUserService = New UserService
        End Sub

        Public Function [Get]() As IEnumerable(Of User)
            Return myUserService.GetUsers
        End Function

        <Route("{id:int}")>
        Public Function GetUser(id As Integer) As IHttpActionResult
            Dim myUser = myUserService.GetUserById(id)
            If myUser Is Nothing Then
                Return NotFound()
            End If
            Return Ok(myUser)
        End Function

        <Route("{name}")>
        Public Function GetUserByName(name As String) As IHttpActionResult
            Dim myUsers As New List(Of User)
            myUsers = myUserService.GetUsersByNameSearch(name)
            If myUsers.Count > 0 Then
                Return NotFound()
            End If
            Return Ok(myUsers)
        End Function
    End Class
End Namespace