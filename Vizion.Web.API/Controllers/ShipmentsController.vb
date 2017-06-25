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
    <RoutePrefix("api/shipments")>
    Public Class ShipmentsController : Inherits ApiController
        Private ReadOnly _dbWmsDataRepository As IDbRepository
        Public Sub New()
            _dbWmsDataRepository = New DBRepository(New VizionWMSDataContext())
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()

            _dbWmsDataRepository.Dispose()
        End Sub

        <HttpGet>
        Public Function [Get]() As IHttpActionResult
            Dim myShipments = _dbWmsDataRepository.Shipments.GetAll.OrderBy(Function(x) x.Id).ToList

            If myShipments.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myShipments)
        End Function

        <HttpGet>
        <Route("{id:int:min(1)}")>
        <ResponseType(GetType(Shipment))>
        Public Function GetShipment(id As Integer) As IHttpActionResult
            Dim myShipment As Shipment = _dbWmsDataRepository.Shipments.Get(id)

            If myShipment Is Nothing Then
                Return NotFound()
            End If
            Return Ok(myShipment)
        End Function

        <HttpGet>
        <Route("{name}")>
        Public Function GetShipmentByCustomerName(name As String) As IHttpActionResult
            Dim myShipments = Me.GetBySearch(Function(x) x.CustomerName.Contains(name)).OrderBy(Function(x) x.Id).ToList()
            If myShipments.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myShipments)
        End Function


#Region "Private Methods"
        Private Function GetBySearch(expression As Expression(Of Func(Of Shipment, Boolean))) As List(Of Shipment)
            Return _dbWmsDataRepository.Shipments.Search(expression).ToList()
        End Function


#End Region
    End Class
End Namespace