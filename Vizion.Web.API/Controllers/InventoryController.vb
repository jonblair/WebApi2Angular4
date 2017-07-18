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
    <RoutePrefix("api/inventory")>
    Public Class InventoryController : Inherits ApiController
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
            Dim myInventorys = _dbWmsDataRepository.Inventory.GetAll.OrderBy(Function(x) x.Id).Take(100).ToList
            'Example of adding custom method in repos
            'Dim myInventorys2 = _dbWmsDataRepository.Inventory.GetInventoryByCustomer("").ToList()
            If myInventorys.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myInventorys)
        End Function

        <HttpGet>
        <Route("{id:int:min(1)}")>
        <ResponseType(GetType(Inventory))>
        Public Function GetInventory(id As Integer) As IHttpActionResult
            Dim myInventory As Inventory = _dbWmsDataRepository.Inventory.Get(id)

            If myInventory Is Nothing Then
                Return NotFound()
            End If
            Return Ok(myInventory)
        End Function

        <HttpGet>
        <Route("{name}")>
        Public Function GetInventoryByCustomerName(name As String) As IHttpActionResult
            Dim myInventorys = Me.GetBySearch(Function(x) x.Customer.Contains(name)).OrderBy(Function(x) x.Id).Take(100).ToList()
            If myInventorys.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myInventorys)
        End Function


#Region "Private Methods"
        Private Function GetBySearch(expression As Expression(Of Func(Of Inventory, Boolean))) As List(Of Inventory)
            Return _dbWmsDataRepository.Inventory.Search(expression).ToList()
        End Function
#End Region
    End Class
End Namespace