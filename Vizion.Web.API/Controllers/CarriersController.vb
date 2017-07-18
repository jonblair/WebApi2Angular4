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
    <RoutePrefix("api/carriers")>
    Public Class CarriersController : Inherits ApiController
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
            Dim myCarriers = _dbWmsDataRepository.Carriers.GetAll.OrderBy(Function(x) x.Id).ToList
            If myCarriers.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myCarriers)
        End Function

        <HttpGet>
        <Route("{id:int:min(1)}")>
        <ResponseType(GetType(Carrier))>
        Public Function GetCarrier(id As Integer) As IHttpActionResult
            Dim myCarrier As Carrier = _dbWmsDataRepository.Carriers.Get(id)

            If myCarrier Is Nothing Then
                Return NotFound()
            End If
            Return Ok(myCarrier)
        End Function

        <HttpGet>
        <Route("{name}")>
        Public Function GetCarrierByCustomerName(name As String) As IHttpActionResult
            Dim myCarriers = Me.GetBySearch(Function(x) x.Name.Contains(name)).OrderBy(Function(x) x.Id).ToList()
            If myCarriers.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myCarriers)
        End Function


#Region "Private Methods"
        Private Function GetBySearch(expression As Expression(Of Func(Of Carrier, Boolean))) As List(Of Carrier)
            Return _dbWmsDataRepository.Carriers.Search(expression).ToList()
        End Function
#End Region
    End Class
End Namespace