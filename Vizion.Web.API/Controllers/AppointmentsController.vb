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
    <RoutePrefix("api/appointments")>
    Public Class AppointmentsController : Inherits ApiController
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
            Dim myAppointments = _dbWmsDataRepository.Appointments.GetAll.OrderBy(Function(x) x.AppointDate).ToList
            If myAppointments.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myAppointments)
        End Function

        <HttpGet>
        <Route("{id:int:min(1)}")>
        <ResponseType(GetType(Appointment))>
        Public Function GetAppointment(id As Integer) As IHttpActionResult
            Dim myAppointment As Appointment = _dbWmsDataRepository.Appointments.Get(id)

            If myAppointment Is Nothing Then
                Return NotFound()
            End If
            Return Ok(myAppointment)
        End Function

        <HttpGet>
        <Route("{name}")>
        Public Function GetAppointmentByCustomerName(name As String) As IHttpActionResult
            Dim myAppointments = Me.GetBySearch(Function(x) x.Customer.Contains(name)).OrderBy(Function(x) x.AppointDate).ToList()
            If myAppointments.Count = 0 Then
                Return NotFound()
            End If
            Return Ok(myAppointments)
        End Function


#Region "Private Methods"
        Private Function GetBySearch(expression As Expression(Of Func(Of Appointment, Boolean))) As List(Of Appointment)
            Return _dbWmsDataRepository.Appointments.Search(expression).ToList()
        End Function
#End Region
    End Class
End Namespace