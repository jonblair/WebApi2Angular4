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
    <RoutePrefix("api/inventorymetrics")>
    Public Class InventoryMetricsController : Inherits ApiController
        Private ReadOnly _dbWmsDataRepository As IDbRepository
        Public Sub New()
            _dbWmsDataRepository = New DBRepository(New WmsDataContextNashville())
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()

            _dbWmsDataRepository.Dispose()
        End Sub

        <HttpGet>
        Public Function [Get]() As IHttpActionResult
            Dim myInventoryPalletMetrics = _dbWmsDataRepository.Inventory.GetInventoryMetricsByPallets.ToList()

            If myInventoryPalletMetrics Is Nothing Or myInventoryPalletMetrics.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myInventoryPalletMetrics)
        End Function


#Region "Private Methods"

#End Region
    End Class
End Namespace