Imports System.Net
Imports System.Web.Http
Imports System.Collections.Generic
Imports System.Linq
Imports Demo.Models
Imports System.Web.Http.Description
Imports System.Threading.Tasks
Imports Demo.Repositories
Imports System.Linq.Expressions
Imports System.Data.Entity
Imports System.Net.Http

Namespace Controllers
    <RoutePrefix("api/customers")>
    Public Class CustomersController : Inherits ApiController
        Private ReadOnly _dbWmsDataRepository As IDbRepository
        Public Sub New()
            _dbWmsDataRepository = New DBRepository(New WmsDataContextDev())
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()

            _dbWmsDataRepository.Dispose()
        End Sub

        <HttpGet>
        Public Function [Get]() As IHttpActionResult
            Dim myCustomers = _dbWmsDataRepository.Customers.GetAll.OrderBy(Function(x) x.Id).ToList
            If myCustomers.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myCustomers)
        End Function

        <HttpGet>
        <Route("{id:int:min(1)}")>
        <ResponseType(GetType(Customer))>
        Public Function GetCustomer(id As Integer) As IHttpActionResult
            Dim myCustomer As Customer = _dbWmsDataRepository.Customers.Get(id)

            If myCustomer Is Nothing Then
                Return NotFound()
            End If
            Return Ok(myCustomer)
        End Function

        <HttpGet>
        <Route("{name}")>
        Public Function GetCustomerByName(name As String) As IHttpActionResult
            Dim myCustomers = Me.GetBySearch(Function(x) x.Name.Contains(name)).OrderBy(Function(x) x.Id).ToList()
            If myCustomers.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myCustomers)
        End Function


#Region "Private Methods"
        Private Function GetBySearch(expression As Expression(Of Func(Of Customer, Boolean))) As List(Of Customer)
            Return _dbWmsDataRepository.Customers.Search(expression).ToList()
        End Function
#End Region
    End Class
End Namespace