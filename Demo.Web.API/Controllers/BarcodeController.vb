Imports System.Net
Imports System.Web.Http

Namespace Controllers
    <RoutePrefix("api/barcode")>
    Public Class BarcodeController : Inherits ApiController

        Public Sub New()

        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        <HttpGet>
        Public Function [Get](barcode As String) As IHttpActionResult

            If IsNothing(barcode) Then
                Return NotFound()
            End If
            Return Ok(barcode)
        End Function
    End Class
End Namespace